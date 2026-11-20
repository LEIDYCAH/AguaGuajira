Public Class frmprincipal
    Private menuExpandido As Boolean = False
    Private menuNavegacion As Menu
    Private formularioActual As Form = Nothing

    'Load del formulario principal

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs
) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        ConfigurarHistorialDashboard()
        CargarHistorialDashboard()

        ' Configurar acoplamiento
        PnlEncabezado.Dock = DockStyle.Top
        Pnlmenu.Dock = DockStyle.Left
        PnlVista.Dock = DockStyle.Fill

        ' Ordenar los paneles
        PnlVista.Parent.Controls.SetChildIndex(PnlVista, 0)
        Pnlmenu.Parent.Controls.SetChildIndex(Pnlmenu, 1)
        PnlEncabezado.Parent.Controls.SetChildIndex(PnlEncabezado, 2)

        PnlContenido.PerformLayout()

        AdaptarInterfaz()
        PnlNotificaciones.Visible = False
        PnlNotificaciones.BringToFront()

        TxtContadorAlertas.Text = "0"
        TxtContadorAlertas.Visible = False


        menuNavegacion = New Menu(
    btnInicio,
    BtnCaptacion,
    BtnAlmacenamiento,
    BtnTratamiento,
    BtnMonitoreo,
    BtnFuentesAgua
)

        menuNavegacion.Seleccionar(btnInicio)

        EstilosApp.AplicarTitulo(LblTituuloPpal)
        EstilosApp.AplicarSubtitulo(LblSubPpal)
        EstilosApp.AplicarSTituloCard(txtalmacenamieno)
        EstilosApp.AplicarSTituloCard(txtCaptacion)
        EstilosApp.AplicarSTituloCard(TxtSensores)
        EstilosApp.AplicarSTituloCard(txtCalidad)
        EstilosApp.AplicarSTituloCard(LblSub)
        EstilosApp.AplicarBoton(BtnAlmacenamiento2)
        EstilosApp.AplicarBoton(BtnCaptacion2)
        EstilosApp.AplicarBoton(BtnTratamiento3)
        EstilosApp.AplicarBoton(BtnFuentesAgua2)
        EstilosApp.AplicarBoton(BtnMonitoreo2)
        EstilosApp.AplicarCampo(TxbAlmacenamiento)
        EstilosApp.AplicarCampo(TxbCaptacion)
        EstilosApp.AplicarCampo(TxbSensores)
        EstilosApp.AplicarCampo(TxbCalidad)

    End Sub

    'Acciones Formulario Principal

    'Tamaño del formulario y adaptacion de la interfaz

    Private Sub Formprincipal_Resize(
    sender As Object,
    e As EventArgs
) Handles Me.Resize

        AdaptarInterfaz()

    End Sub

    Private Sub AdaptarInterfaz()

        DisenoResponsive.AdaptarMenu(
        Pnlmenu,
        BtnMenu,
        Me.ClientSize.Width
    )

    End Sub


    Private Sub AbrirFormulario(formulario As Form)

        PnlInicio.Visible = False

        ' Cerrar el formulario anterior
        If formularioActual IsNot Nothing Then
            PnlVista.Controls.Remove(formularioActual)
            formularioActual.Dispose()
            formularioActual = Nothing
        End If

        ' Configurar el nuevo formulario
        formularioActual = formulario

        With formularioActual
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Margin = New Padding(0)
            .Padding = New Padding(0)
        End With

        ' Preparar el contenedor
        PnlVista.AutoScrollPosition = New Point(0, 0)
        PnlVista.Padding = New Padding(0)

        formularioActual.Location = New Point(0, 0)
        formularioActual.Size = PnlVista.ClientSize

        PnlVista.Controls.Add(formularioActual)

        formularioActual.Show()
        formularioActual.BringToFront()
    End Sub


    'Menu

    Private Sub BtnInicio_Click(
    sender As Object,
    e As EventArgs
) Handles btnInicio.Click

        If formularioActual IsNot Nothing Then
            PnlVista.Controls.Remove(formularioActual)
            formularioActual.Dispose()
            formularioActual = Nothing
        End If

        ' Mostrar el panel principal
        PnlInicio.Visible = True
        PnlInicio.BringToFront()

        ' Actualizar las últimas lecturas
        CargarHistorialDashboard()
        ActualizarTarjetaCaptacion()
        ActualizarTarjetaSensores()
        ActualizarTarjetaCalidad()
        ActualizarTarjetaAlmacenamiento()
        ActualizarAlertaFuentes()
        ActualizarAlertaAlmacenamiento()

        menuNavegacion.Seleccionar(btnInicio)

    End Sub

    Private Sub BtnCaptacion_Click(sender As Object, e As EventArgs) Handles BtnCaptacion.Click

        AbrirFormulario(New FrmCaptacion())
        menuNavegacion.Seleccionar(BtnCaptacion)

    End Sub

    Private Sub BtnAlmacenamiento_Click(sender As Object, e As EventArgs) Handles BtnAlmacenamiento.Click

        AbrirFormulario(New FrmAlmacenamiento)
        menuNavegacion.Seleccionar(BtnAlmacenamiento)

    End Sub

    Private Sub BtnTratamiento_Click(
    sender As Object,
    e As EventArgs
) Handles BtnTratamiento.Click

        AbrirFormulario(New FrmTratamiento)
        menuNavegacion.Seleccionar(BtnTratamiento)

    End Sub

    Private Sub BtnMonitoreo_Click(
    sender As Object,
    e As EventArgs
) Handles BtnMonitoreo.Click

        AbrirFormulario(New FrmMonitoreo)
        menuNavegacion.Seleccionar(BtnMonitoreo)

    End Sub

    Private Sub BtnFuentesAgua_Click(sender As Object, e As EventArgs) Handles BtnFuentesAgua.Click

        AbrirFormulario(New FrmFuentesAgua)
        menuNavegacion.Seleccionar(BtnFuentesAgua)

    End Sub

    Private Sub BtnNotificaciones_Click(sender As Object, e As EventArgs) Handles BtnNotificaciones.Click

        PnlNotificaciones.Visible = Not PnlNotificaciones.Visible

        If PnlNotificaciones.Visible Then
            PnlNotificaciones.BringToFront()
        End If

    End Sub


    Private Sub ActualizarContadorAlertas(cantidad As Integer)

        TxtContadorAlertas.Text = cantidad.ToString()
        TxtContadorAlertas.Visible = cantidad > 0

    End Sub

    Private Sub ConfigurarHistorialDashboard()

        With DtgReview
            .Columns.Clear()
            .Rows.Clear()

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False

            .ColumnHeadersDefaultCellStyle.BackColor = EstilosApp.Primario
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = EstilosApp.Fuente(9, True)

            .DefaultCellStyle.Font = EstilosApp.Fuente(9)
            .DefaultCellStyle.SelectionBackColor = EstilosApp.Lavanda
            .DefaultCellStyle.SelectionForeColor = EstilosApp.Primario

            .Columns.Add("Fecha", "Fecha")
            .Columns.Add("Sensor", "Sensor")
            .Columns.Add("PH", "pH")
            .Columns.Add("Turbidez", "Turbidez (NTU)")
            .Columns.Add("TDS", "TDS (ppm)")
            .Columns.Add("Temperatura", "Temperatura (°C)")
            .Columns.Add("Estado", "Estado")

        End With

    End Sub

    Private Sub CargarHistorialDashboard()

        DtgReview.Rows.Clear()

        Dim ultimasLecturas = DatosMonitoreo.Historial _
            .OrderByDescending(Function(x) x.Fecha) _
            .Take(10) _
            .ToList()

        For Each lectura In ultimasLecturas

            DtgReview.Rows.Add(
                lectura.Fecha.ToString("dd/MM/yyyy HH:mm"),
                lectura.Sensor,
                lectura.PH.ToString("N2"),
                lectura.Turbidez.ToString("N2"),
                lectura.TDS.ToString("N2"),
                lectura.Temperatura.ToString("N2"),
                lectura.Estado
            )

        Next

    End Sub

    Private Sub ActualizarTarjetaCaptacion()

        TxbCaptacion.Text =
            FrmCaptacion.VolumenTotalRegistrado.ToString("N2") & " L"

    End Sub

    Private Sub ActualizarTarjetaSensores()

        Dim totalLecturas As Integer = DatosMonitoreo.Historial.Count

        Dim sensoresRegistrados = DatosMonitoreo.Historial _
            .Select(Function(x) x.Sensor) _
            .Where(Function(x) Not String.IsNullOrWhiteSpace(x) AndAlso
                             x <> "Sin identificar") _
            .Distinct() _
            .Count()

        TxbSensores.Text = sensoresRegistrados.ToString()

    End Sub

    Private Sub ActualizarTarjetaCalidad()

        If DatosMonitoreo.Historial.Count = 0 Then
            TxbCalidad.Text = "Sin datos"
            txtSubtitulocalidad.Text = "Esperando mediciones"
            Exit Sub
        End If

        Dim ultimaLectura = DatosMonitoreo.Historial _
            .OrderByDescending(Function(x) x.Fecha) _
            .First()

        Dim estado As String = "Revisar parámetros"

        If ultimaLectura.PH >= 6.5 AndAlso ultimaLectura.PH <= 8.5 _
            AndAlso ultimaLectura.Turbidez <= 2 Then

            estado = "Parámetros dentro del rango"

        End If

        TxbCalidad.Text = estado
        txtSubtitulocalidad.Text = "Última medición registrada"

    End Sub

    Private Sub ActualizarTarjetaAlmacenamiento()

        Dim capacidad = FrmAlmacenamiento.capacidadTanque
        Dim agua = FrmAlmacenamiento.volumenAlmacenado

        If capacidad <= 0 Then
            TxbAlmacenamiento.Text = "--%"
            txtsubalmacenamiento.Text = "Sin datos del tanque"
            Exit Sub
        End If

        Dim porcentaje As Double = (agua / capacidad) * 100

        TxbAlmacenamiento.Text = porcentaje.ToString("N1") & "%"

        txtsubalmacenamiento.Text =
            agua.ToString("N2") & " L de " & capacidad.ToString("N2") & " L"

    End Sub

    Private Sub BtnFuentesAgua2_Click(sender As Object, e As EventArgs) Handles BtnFuentesAgua2.Click
        AbrirFormulario(New FrmFuentesAgua)
    End Sub

    Private Sub BtnTratamiento3_Click(sender As Object, e As EventArgs) Handles BtnTratamiento3.Click
        AbrirFormulario(New FrmTratamiento)
    End Sub

    Private Sub BtnMonitoreo2_Click(sender As Object, e As EventArgs) Handles BtnMonitoreo2.Click
        AbrirFormulario(New FrmMonitoreo)
    End Sub

    Private Sub BtnAlmacenamiento2_Click(sender As Object, e As EventArgs) Handles BtnAlmacenamiento2.Click
        AbrirFormulario(New FrmAlmacenamiento)
    End Sub

    Private Sub BtnCaptacion2_Click(sender As Object, e As EventArgs) Handles BtnCaptacion2.Click
        AbrirFormulario(New FrmCaptacion())
    End Sub

    Private Sub CambiarEstadoIcono(icono As Label, estado As String)

        Select Case estado.ToUpper()

            Case "NORMAL"
                icono.ForeColor = Color.ForestGreen
            Case "ATENCION"
                icono.ForeColor = Color.Goldenrod
            Case "URGENTE"
                icono.ForeColor = Color.Red
            Case Else
                icono.ForeColor = Color.Gray

        End Select

    End Sub

    Private Sub ActualizarAlertaFuentes()

        If DatosFuente.Historial.Count = 0 Then
            CambiarEstadoIcono(IconfuentesAGUA, "ATENCION")
            Exit Sub
        End If

        Dim fuentesInactivas = DatosFuente.Historial.Any(
            Function(f) f.Estado = "Inactiva"
        )

        Dim fuentesMantenimiento = DatosFuente.Historial.Any(
            Function(f) f.Estado = "En mantenimiento"
        )

        If fuentesInactivas OrElse fuentesMantenimiento Then
            CambiarEstadoIcono(IconfuentesAGUA, "URGENTE")
        Else
            CambiarEstadoIcono(IconfuentesAGUA, "NORMAL")
        End If

    End Sub
    Private Sub ActualizarAlertaAlmacenamiento()

        Dim capacidad = FrmAlmacenamiento.capacidadTanque
        Dim volumen = FrmAlmacenamiento.volumenAlmacenado

        If capacidad <= 0 Then
            CambiarEstadoIcono(lblAlmacenamientoIcone, "ATENCION")
            Exit Sub
        End If

        Dim porcentaje As Double = (volumen / capacidad) * 100

        If porcentaje < 10 Then
            CambiarEstadoIcono(lblAlmacenamientoIcone, "URGENTE")

        ElseIf porcentaje <= 30 Then
            CambiarEstadoIcono(lblAlmacenamientoIcone, "ATENCION")

        Else
            CambiarEstadoIcono(lblAlmacenamientoIcone, "NORMAL")
        End If

    End Sub

End Class

