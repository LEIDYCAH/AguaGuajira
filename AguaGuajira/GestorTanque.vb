
Public Class GestorTanques

    Public Shared ListaTanques As New List(Of Tanque)

    Public Shared Function GenerarCodigo() As String

        Dim numero As Integer = ListaTanques.Count + 1
        Dim codigo As String

        Do
            codigo = "TNQ-" & numero.ToString("000")

            If Not ListaTanques.Any(Function(t) t.Codigo = codigo) Then
                Return codigo
            End If

            numero += 1
        Loop

    End Function

    Public Shared Function RegistrarTanque(
        capacidad As Double,
        volumen As Double
    ) As Boolean

        If capacidad <= 0 OrElse volumen < 0 OrElse volumen > capacidad Then
            Return False
        End If

        Dim nuevo As New Tanque With {
            .Codigo = GenerarCodigo(),
            .Capacidad = capacidad,
            .VolumenAlmacenado = volumen,
            .Estado = "Disponible"
        }

        ListaTanques.Add(nuevo)

        Return True

    End Function

    Public Shared Function AsignarTanque(codigo As String, nombrePoblacion As String) As Boolean

        If String.IsNullOrWhiteSpace(nombrePoblacion) Then
            Return False
        End If

        Dim tanque As Tanque = ListaTanques.FirstOrDefault(
            Function(t) t.Codigo = codigo
        )

        If tanque Is Nothing Then
            Return False
        End If

        If tanque.Estado <> "Disponible" Then
            Return False
        End If

        tanque.PoblacionAsignada = nombrePoblacion
        tanque.FechaAsignacion = Date.Now
        tanque.Estado = "Asignado"

        Return True
    End Function

End Class

