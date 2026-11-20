
Public Class GestorMovimientos

    Public Shared ListaMovimientos As New List(Of MovimientoAgua)

    Public Shared Sub RegistrarMovimiento(
        codigoTanque As String,
        tipo As String,
        volumen As Double,
        observacion As String
    )

        Dim movimiento As New MovimientoAgua With {
            .CodigoTanque = codigoTanque,
            .TipoMovimiento = tipo,
            .Volumen = volumen,
            .FechaMovimiento = Date.Now,
            .Observacion = observacion
        }

        ListaMovimientos.Add(movimiento)

    End Sub


    Public Shared Function RegistrarMovimientoValidado(
    codigoTanque As String,
    tipo As String,
    volumen As Double,
    observacion As String
) As Boolean

        Dim tanque As Tanque = GestorTanques.ListaTanques.FirstOrDefault(
        Function(t) t.Codigo = codigoTanque
    )

        If tanque Is Nothing OrElse volumen <= 0 Then
            Return False
        End If

        If tipo = "Entrada" Then

            If tanque.VolumenAlmacenado + volumen > tanque.Capacidad Then
                Return False
            End If

            tanque.VolumenAlmacenado += volumen

        ElseIf tipo = "Salida" Then

            If volumen > tanque.VolumenAlmacenado Then
                Return False
            End If

            tanque.VolumenAlmacenado -= volumen

        Else
            Return False
        End If

        RegistrarMovimiento(codigoTanque, tipo, volumen, observacion)

        Return True

    End Function


End Class

