Public Class FrmAlmacenamiento
    Public Shared capacidadTanque As Double = 0
    Public Shared volumenAlmacenado As Double = 0
    Public Shared demandaCalculada As Double = 0
    Private tanqueActual As Tanque = Nothing
    Private evaluacionFavorable As Boolean = False

    Private Sub FrmAlmacenamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Estilo Almacenamiento:
        EstilosApp.AplicarTitulo(LblTituloalmacenamiento)
        EstilosApp.AplicarTarjeta(PnlCapacidadTanque)
        EstilosApp.AplicarTarjeta(PnlDisponible)
        EstilosApp.AplicarTarjeta(PnlCalculodemanda)
        EstilosApp.AplicarTarjeta(PnlDatosTanque)
        EstilosApp.AplicarTarjeta(PnlEvaluacion)
        EstilosApp.AplicarTarjeta(PnlCapacidadDemandada)
        EstilosApp.AplicarSubtitulo(LblCapacidad)
        EstilosApp.AplicarSubtitulo(LblCalculo)
        EstilosApp.AplicarSubtitulo(LblEvaluacion)
        EstilosApp.AplicarSubtitulo(LblDatosTanque)
        EstilosApp.AplicarSubtitulo(LblCapacidaddemanda)
        EstilosApp.AplicarSubtitulo(LblDispoible)
        EstilosApp.AplicarCampo(TxtcNumero)
        EstilosApp.AplicarCampo(TxtCConsumo)
        EstilosApp.AplicarCampo(TxtCDias)
        EstilosApp.AplicarCampo(Txtevaluacion)
        EstilosApp.AplicarCampo(TxbCapacidadtotal)
        EstilosApp.AplicarCampo(TxbAguaAlmacenada)
        EstilosApp.AplicarBoton(BtnCalculoDemanda)
        EstilosApp.AplicarBoton(BtnCalcular)
        EstilosApp.AplicarBoton(BtnAsignarTanque)

        ConfigurarInventarioTanques()
        ActualizarInventarioTanques()
    End Sub

    Private Sub BtnCalculoDemanda_Click_1(sender As Object, e As EventArgs) Handles BtnCalculoDemanda.Click

        Dim Habitantes As Double
        Dim consumo As Double
        Dim dias As Double
        Dim volumen As Double

        If Not Double.TryParse(TxtcNumero.Text, Habitantes) Then
            MessageBox.Show("Ingresa una Cantidad de habitantes valida.")
            Exit Sub
        End If
        If Not Double.TryParse(TxtCConsumo.Text, consumo) Then
            MessageBox.Show("Ingresa un valor de consumo valido.")
            Exit Sub
        End If

        If Not Double.TryParse(TxtCDias.Text, dias) Then
            MessageBox.Show("Ingresa una cantidad de días válida")
            Exit Sub
        End If

        If Habitantes <= 0 OrElse consumo <= 0 OrElse dias <= 0 Then
            MessageBox.Show("Por favor ingresa valores válidos.")
            Exit Sub
        End If

        ' Calculamos el volumen recolectado

        volumen = Habitantes * dias * consumo

        demandaCalculada = volumen

        ' Mostrar resultado
        Txtevaluacion.Text = volumen.ToString("N2") & " Litros"
        TxbCapacidadtotal.Focus()
        TxtCapa.Text = demandaCalculada.ToString("N2") & " L"
        MessageBox.Show("Ingresa porfavor los datos del tanque")
        EvaluarCapacidad()



    End Sub


    Private Sub BtnCalcular_Click_(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        Dim capacidad As Double
        Dim agua As Double

        If Not Double.TryParse(TxbCapacidadtotal.Text, capacidad) Then
            MessageBox.Show("Ingresa una capacidad válida.")
            Exit Sub
        End If

        If Not Double.TryParse(TxbAguaAlmacenada.Text, agua) Then
            MessageBox.Show("Ingresa el volumen de agua almacenada.")
            Exit Sub
        End If

        If capacidad <= 0 OrElse agua < 0 Then
            MessageBox.Show("La capacidad debe ser mayor que cero y el volumen no puede ser negativo.")
            Exit Sub
        End If

        If agua > capacidad Then
            MessageBox.Show("El volumen almacenado no puede superar la capacidad del tanque.")
            Exit Sub
        End If

        ' Registrar el nuevo tanque
        Dim registrado As Boolean =
        GestorTanques.RegistrarTanque(capacidad, agua)

        If Not registrado Then
            MessageBox.Show("No fue posible registrar el tanque.")
            Exit Sub
        End If

        ' Actualizar el inventario
        ActualizarInventarioTanques()

        ' Mostrar los datos del tanque recién registrado
        capacidadTanque = capacidad
        volumenAlmacenado = agua

        TxtCapacidadTanque.Text = capacidad.ToString("N2") & " L"
        LblCapacidad.Text = capacidad.ToString("N2") & " L"
        TxtAguaDisponible.Text = agua.ToString("N2") & " L"

        ActualizarIndicadorOcupacion()

        MessageBox.Show("Tanque registrado correctamente.")

        Dim codigoGenerado As String =
    GestorTanques.ListaTanques(
        GestorTanques.ListaTanques.Count - 1
    ).Codigo

        TxbCodigounico.Text = codigoGenerado

        TxbCapacidadtotal.Clear()
        TxbAguaAlmacenada.Clear()

    End Sub


    Private Sub PnlIndicadorOcupacion_Paint(
    sender As Object,
    e As PaintEventArgs
) Handles PnlIndicadorOcupacion.Paint

        Dim porcentaje As Double = 0

        If capacidadTanque > 0 Then
            porcentaje = (volumenAlmacenado / capacidadTanque) * 100
            porcentaje = Math.Max(0, Math.Min(100, porcentaje))
        End If

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim grosor As Single = 12
        Dim rect As New RectangleF(
            12, 12,
            PnlIndicadorOcupacion.Width - 24,
            PnlIndicadorOcupacion.Height - 24
        )

        Using fondo As New Pen(Color.FromArgb(230, 218, 250), grosor)
            e.Graphics.DrawArc(fondo, rect, -90, 360)
        End Using

        Dim colorProgreso As Color = Color.FromArgb(129, 91, 190)

        If porcentaje < 10 Then
            colorProgreso = Color.Crimson
        ElseIf porcentaje <= 30 Then
            colorProgreso = Color.Goldenrod
        End If

        Using progreso As New Pen(colorProgreso, grosor)
            progreso.StartCap = Drawing2D.LineCap.Round
            progreso.EndCap = Drawing2D.LineCap.Round

            If porcentaje > 0 Then
                e.Graphics.DrawArc(
                    progreso,
                    rect,
                    -90,
                    CSng(porcentaje * 3.6)
                )
            End If
        End Using

    End Sub

    Private Sub ActualizarIndicadorOcupacion()

        Dim porcentaje As Double = 0

        If capacidadTanque > 0 Then
            porcentaje = (volumenAlmacenado / capacidadTanque) * 100
            porcentaje = Math.Max(0, Math.Min(100, porcentaje))
        End If

        LblPorcentajeOcupacion.Text = porcentaje.ToString("0") & "%"

        PnlIndicadorOcupacion.Invalidate()

    End Sub


    Private Sub ConfigurarInventarioTanques()

        With DtvTanques
            .Columns.Clear()
            .Columns.Add("Codigo", "Código")
            .Columns.Add("Capacidad", "Capacidad máxima (L)")
            .Columns.Add("Volumen", "Volumen almacenado (L)")
            .Columns.Add("Disponible", "Capacidad libre (L)")
            .Columns.Add("Estado", "Estado")
            .Columns.Add("Poblacion", "Población asignada")

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With


        EstilosApp.AplicarGrilla(DtvTanques)

    End Sub

    Private Sub ActualizarInventarioTanques()

        DtvTanques.Rows.Clear()

        For Each tanque As Tanque In GestorTanques.ListaTanques

            Dim disponible As Double =
            tanque.Capacidad - tanque.VolumenAlmacenado

            DtvTanques.Rows.Add(
              tanque.Codigo,
              tanque.Capacidad.ToString("N2"),
              tanque.VolumenAlmacenado.ToString("N2"),
              disponible.ToString("N2"),
              tanque.Estado,
              tanque.PoblacionAsignada
)

        Next



    End Sub



    Private Sub DtvTanques_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtvTanques.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim codigo As String =
            DtvTanques.Rows(e.RowIndex).Cells("Codigo").Value.ToString()

        Dim tanqueSeleccionado As Tanque =
            GestorTanques.ListaTanques.FirstOrDefault(
                Function(t) t.Codigo = codigo
            )

        If tanqueSeleccionado Is Nothing Then Exit Sub

        capacidadTanque = tanqueSeleccionado.Capacidad
        volumenAlmacenado = tanqueSeleccionado.VolumenAlmacenado

        TxtCapacidadTanque.Text = capacidadTanque.ToString("N2") & " L"
        TxtAguaDisponible.Text = volumenAlmacenado.ToString("N2") & " L"
        LblCapacidad.Text = capacidadTanque.ToString("N2") & " L"
        tanqueActual = tanqueSeleccionado
        evaluacionFavorable = False

        ActualizarIndicadorOcupacion()

        If demandaCalculada > 0 Then
            EvaluarCapacidad()
        End If

    End Sub


    Private Sub EvaluarCapacidad()

        BtnAsignarTanque.Enabled = False
        evaluacionFavorable = False

        If tanqueActual Is Nothing Then
            LblNotificacionevaluacion.Text = "Selecciona un tanque"
            LblNotificacionevaluacion.ForeColor = Color.Firebrick
            Exit Sub

        End If


        If tanqueActual.Estado <> "Disponible" Then

            LblNotificacionevaluacion.Text = "Este tanque ya está asignado."
            LblNotificacionevaluacion.ForeColor = Color.Firebrick

            BtnAsignarTanque.Enabled = False

            Exit Sub

        End If

        If demandaCalculada <= 0 Then
            LblNotificacionevaluacion.Text = "Calcula primero la demanda"
            LblNotificacionevaluacion.ForeColor = Color.Firebrick
            Exit Sub
        End If

        Dim aguaDisponible As Double = tanqueActual.VolumenAlmacenado
        Dim diferencia As Double = aguaDisponible - demandaCalculada

        If diferencia >= 0 Then

            LblNotificacionevaluacion.Text =
                "Agua suficiente. Excedente: " & diferencia.ToString("N2") & " L"

            LblNotificacionevaluacion.ForeColor = Color.SeaGreen
            evaluacionFavorable = True

        Else

            LblNotificacionevaluacion.Text = "Agua insuficiente. Faltan: " & Math.Abs(diferencia).ToString("N2") & " L"

            LblNotificacionevaluacion.ForeColor = Color.Firebrick

            evaluacionFavorable = False
            BtnAsignarTanque.Enabled = False

        End If

    End Sub


    Private Sub AsignarTanqueAPoblacion()

        If tanqueActual Is Nothing Then
            MessageBox.Show("Selecciona un tanque del inventario.")
            Exit Sub
        End If

        If Not evaluacionFavorable Then
            MessageBox.Show("La evaluación debe ser favorable para asignar el tanque.")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TxbUbicacion.Text) Then
            MessageBox.Show("Ingresa la ubicación de la población.")
            TxbUbicacion.Focus()
            Exit Sub
        End If

        Dim asignado As Boolean = GestorTanques.AsignarTanque(
        tanqueActual.Codigo,
        TxbUbicacion.Text.Trim()
    )

        If asignado Then
            ActualizarInventarioTanques()
            MessageBox.Show("Tanque asignado correctamente a " & TxbUbicacion.Text)

            evaluacionFavorable = False
        Else
            MessageBox.Show("No fue posible asignar el tanque.")
        End If

    End Sub


    Private Sub BtnAsignarTanque_Click(sender As Object, e As EventArgs) Handles BtnAsignarTanque.Click

        AsignarTanqueAPoblacion()

    End Sub


    'Private Sub ConfigurarGrillaMovimientos()

    '    With DtvMovimientos
    '        .Columns.Clear()
    '        .Columns.Add("Codigo", "Código tanque")
    '        .Columns.Add("Tipo", "Movimiento")
    '        .Columns.Add("Volumen", "Volumen (L)")
    '        .Columns.Add("Fecha", "Fecha y hora")
    '        .Columns.Add("Observacion", "Observación")

    '        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    '        .ReadOnly = True
    '        .AllowUserToAddRows = False
    '        .AllowUserToDeleteRows = False
    '        .RowHeadersVisible = False
    '        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '    End With

    '    EstilosApp.AplicarGrilla(DtvMovimientos)

    'End Sub

    'Private Sub ActualizarGrillaMovimientos()

    '    DtvMovimientos.Rows.Clear()

    '    For Each movimiento As MovimientoAgua In GestorMovimientos.ListaMovimientos

    '        DtvMovimientos.Rows.Add(
    '        movimiento.CodigoTanque,
    '        movimiento.TipoMovimiento,
    '        movimiento.Volumen.ToString("N2"),
    '        movimiento.FechaMovimiento.ToString("dd/MM/yyyy HH:mm"),
    '        movimiento.Observacion
    '    )

    '    Next

    'End Sub


    Private Sub RegistrarMovimiento(
    tipo As String,
    volumen As Double,
    observacion As String
)

        If tanqueActual Is Nothing Then
            MessageBox.Show("Selecciona primero un tanque.")
            Exit Sub
        End If

        Dim registrado As Boolean =
        GestorMovimientos.RegistrarMovimientoValidado(
            tanqueActual.Codigo,
            tipo,
            volumen,
            observacion
        )

        If Not registrado Then
            MessageBox.Show("No se pudo registrar el movimiento. Verifica el volumen.")
            Exit Sub
        End If

        'Actualizar los datos del tanque seleccionado
        volumenAlmacenado = tanqueActual.VolumenAlmacenado

        TxtAguaDisponible.Text = volumenAlmacenado.ToString("N2") & " L"

        ActualizarInventarioTanques()
        ' ActualizarGrillaMovimientos()
        ActualizarIndicadorOcupacion()

        MessageBox.Show("Movimiento registrado correctamente.")

    End Sub


End Class