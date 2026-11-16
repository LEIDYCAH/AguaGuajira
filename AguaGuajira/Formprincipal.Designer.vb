<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmprincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PnlContenido = New Panel()
        PnlEncabezado = New Panel()
        PnlNotificaciones = New PanelRedondeado()
        TxtEmoji = New Label()
        PnlSeparador = New Panel()
        LblTituloNotificaciones = New Label()
        txtSubtitle = New Label()
        LblSinNotificaciones = New Label()
        tx1 = New Label()
        TxtContadorAlertas = New Label()
        BtnNotificaciones = New Button()
        BtnMenu = New Button()
        txsubtitle = New Label()
        Pnlmenu = New Panel()
        BtnTratamiento = New Button()
        BtnMonitoreo = New Button()
        BtnReportes = New Button()
        BtnAlmacenamiento = New Button()
        BtnCaptacion = New Button()
        btnInicio = New Button()
        PnlVista = New PanelRedondeado()
        PnlInicio = New PanelRedondeado()
        TblPrincipal = New TableLayoutPanel()
        PnlCardCalidad = New PanelRedondeado()
        txtSubtitulocalidad = New Label()
        txtdatosCalidad = New Label()
        txtCalidad = New Label()
        PnlCardCaptacion = New PanelRedondeado()
        txtDescriptionc = New Label()
        TxtValorCaptacion = New Label()
        txtCaptacion = New Label()
        PnlCardSensores = New PanelRedondeado()
        TxtSubSensores = New Label()
        TxtSensores = New Label()
        TxtRespuesta = New Label()
        PnlCardAlmaceamiento = New PanelRedondeado()
        txtsubalmacenamiento = New Label()
        txtValorAlmacenamiento = New Label()
        txtalmacenamieno = New Label()
        PnlContenido.SuspendLayout()
        PnlEncabezado.SuspendLayout()
        PnlNotificaciones.SuspendLayout()
        Pnlmenu.SuspendLayout()
        PnlVista.SuspendLayout()
        PnlInicio.SuspendLayout()
        TblPrincipal.SuspendLayout()
        PnlCardCalidad.SuspendLayout()
        PnlCardCaptacion.SuspendLayout()
        PnlCardSensores.SuspendLayout()
        PnlCardAlmaceamiento.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlContenido
        ' 
        PnlContenido.BackColor = Color.FromArgb(CByte(241), CByte(239), CByte(251))
        PnlContenido.Controls.Add(PnlEncabezado)
        PnlContenido.Controls.Add(Pnlmenu)
        PnlContenido.Controls.Add(PnlVista)
        PnlContenido.Dock = DockStyle.Fill
        PnlContenido.Location = New Point(0, 0)
        PnlContenido.Margin = New Padding(0)
        PnlContenido.Name = "PnlContenido"
        PnlContenido.Size = New Size(1187, 550)
        PnlContenido.TabIndex = 0
        ' 
        ' PnlEncabezado
        ' 
        PnlEncabezado.BackColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        PnlEncabezado.Controls.Add(PnlNotificaciones)
        PnlEncabezado.Controls.Add(tx1)
        PnlEncabezado.Controls.Add(TxtContadorAlertas)
        PnlEncabezado.Controls.Add(BtnNotificaciones)
        PnlEncabezado.Controls.Add(BtnMenu)
        PnlEncabezado.Controls.Add(txsubtitle)
        PnlEncabezado.Dock = DockStyle.Top
        PnlEncabezado.Location = New Point(158, 0)
        PnlEncabezado.Name = "PnlEncabezado"
        PnlEncabezado.Size = New Size(1029, 54)
        PnlEncabezado.TabIndex = 0
        ' 
        ' PnlNotificaciones
        ' 
        PnlNotificaciones.BackColor = Color.White
        PnlNotificaciones.BorderStyle = BorderStyle.Fixed3D
        PnlNotificaciones.Controls.Add(TxtEmoji)
        PnlNotificaciones.Controls.Add(PnlSeparador)
        PnlNotificaciones.Controls.Add(LblTituloNotificaciones)
        PnlNotificaciones.Controls.Add(txtSubtitle)
        PnlNotificaciones.Controls.Add(LblSinNotificaciones)
        PnlNotificaciones.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        PnlNotificaciones.Location = New Point(678, 33)
        PnlNotificaciones.Name = "PnlNotificaciones"
        PnlNotificaciones.RadioEsquinas = 16
        PnlNotificaciones.Size = New Size(320, 270)
        PnlNotificaciones.TabIndex = 7
        PnlNotificaciones.Visible = False
        ' 
        ' TxtEmoji
        ' 
        TxtEmoji.AutoSize = True
        TxtEmoji.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtEmoji.Location = New Point(141, 98)
        TxtEmoji.Name = "TxtEmoji"
        TxtEmoji.Size = New Size(47, 32)
        TxtEmoji.TabIndex = 12
        TxtEmoji.Text = "🔔"
        ' 
        ' PnlSeparador
        ' 
        PnlSeparador.BackColor = Color.BlueViolet
        PnlSeparador.Location = New Point(15, 55)
        PnlSeparador.Name = "PnlSeparador"
        PnlSeparador.Size = New Size(285, 1)
        PnlSeparador.TabIndex = 10
        ' 
        ' LblTituloNotificaciones
        ' 
        LblTituloNotificaciones.AutoSize = True
        LblTituloNotificaciones.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTituloNotificaciones.ForeColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        LblTituloNotificaciones.Location = New Point(177, 12)
        LblTituloNotificaciones.Name = "LblTituloNotificaciones"
        LblTituloNotificaciones.Size = New Size(123, 23)
        LblTituloNotificaciones.TabIndex = 8
        LblTituloNotificaciones.Text = "Notificaciones"
        ' 
        ' txtSubtitle
        ' 
        txtSubtitle.AutoSize = True
        txtSubtitle.Font = New Font("Segoe UI", 8F)
        txtSubtitle.Location = New Point(16, 34)
        txtSubtitle.Name = "txtSubtitle"
        txtSubtitle.Size = New Size(102, 13)
        txtSubtitle.TabIndex = 9
        txtSubtitle.Text = "Alertas del sistema"
        ' 
        ' LblSinNotificaciones
        ' 
        LblSinNotificaciones.AutoSize = True
        LblSinNotificaciones.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        LblSinNotificaciones.Location = New Point(74, 130)
        LblSinNotificaciones.Name = "LblSinNotificaciones"
        LblSinNotificaciones.Size = New Size(162, 15)
        LblSinNotificaciones.TabIndex = 11
        LblSinNotificaciones.Text = "No hay notificaciones nuevas"
        ' 
        ' tx1
        ' 
        tx1.AutoSize = True
        tx1.Font = New Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tx1.ForeColor = Color.White
        tx1.Location = New Point(75, 6)
        tx1.Name = "tx1"
        tx1.Size = New Size(149, 28)
        tx1.TabIndex = 0
        tx1.Text = "💧 Agua Guajira"
        ' 
        ' TxtContadorAlertas
        ' 
        TxtContadorAlertas.BackColor = Color.Transparent
        TxtContadorAlertas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtContadorAlertas.ForeColor = Color.Red
        TxtContadorAlertas.Location = New Point(1009, 6)
        TxtContadorAlertas.Name = "TxtContadorAlertas"
        TxtContadorAlertas.Size = New Size(25, 21)
        TxtContadorAlertas.TabIndex = 2
        TxtContadorAlertas.Text = "0"
        ' 
        ' BtnNotificaciones
        ' 
        BtnNotificaciones.BackColor = Color.FromArgb(CByte(241), CByte(239), CByte(251))
        BtnNotificaciones.FlatStyle = FlatStyle.System
        BtnNotificaciones.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnNotificaciones.ForeColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnNotificaciones.Location = New Point(987, 12)
        BtnNotificaciones.Name = "BtnNotificaciones"
        BtnNotificaciones.Size = New Size(30, 28)
        BtnNotificaciones.TabIndex = 1
        BtnNotificaciones.Text = "🔔"
        BtnNotificaciones.UseVisualStyleBackColor = False
        ' 
        ' BtnMenu
        ' 
        BtnMenu.Cursor = Cursors.Hand
        BtnMenu.FlatAppearance.BorderSize = 0
        BtnMenu.FlatStyle = FlatStyle.Flat
        BtnMenu.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnMenu.ForeColor = Color.White
        BtnMenu.Location = New Point(12, 8)
        BtnMenu.Name = "BtnMenu"
        BtnMenu.Size = New Size(31, 38)
        BtnMenu.TabIndex = 12
        BtnMenu.Text = "☰"
        BtnMenu.UseVisualStyleBackColor = True
        BtnMenu.Visible = False
        ' 
        ' txsubtitle
        ' 
        txsubtitle.AutoSize = True
        txsubtitle.Font = New Font("Modern No. 20", 7.249999F)
        txsubtitle.ForeColor = Color.White
        txsubtitle.Location = New Point(81, 33)
        txsubtitle.Name = "txsubtitle"
        txsubtitle.Size = New Size(143, 13)
        txsubtitle.TabIndex = 1
        txsubtitle.Text = "Sistema de adminstracion del agua"
        ' 
        ' Pnlmenu
        ' 
        Pnlmenu.BackColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        Pnlmenu.Controls.Add(BtnTratamiento)
        Pnlmenu.Controls.Add(BtnMonitoreo)
        Pnlmenu.Controls.Add(BtnReportes)
        Pnlmenu.Controls.Add(BtnAlmacenamiento)
        Pnlmenu.Controls.Add(BtnCaptacion)
        Pnlmenu.Controls.Add(btnInicio)
        Pnlmenu.Dock = DockStyle.Left
        Pnlmenu.Location = New Point(0, 0)
        Pnlmenu.Name = "Pnlmenu"
        Pnlmenu.Size = New Size(158, 550)
        Pnlmenu.TabIndex = 1
        ' 
        ' BtnTratamiento
        ' 
        BtnTratamiento.BackColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        BtnTratamiento.FlatAppearance.BorderColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnTratamiento.FlatAppearance.BorderSize = 0
        BtnTratamiento.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnTratamiento.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnTratamiento.FlatStyle = FlatStyle.Flat
        BtnTratamiento.Font = New Font("Georgia", 9.75F)
        BtnTratamiento.ForeColor = Color.White
        BtnTratamiento.Location = New Point(12, 178)
        BtnTratamiento.Name = "BtnTratamiento"
        BtnTratamiento.Size = New Size(139, 23)
        BtnTratamiento.TabIndex = 7
        BtnTratamiento.Text = ChrW(55358) & ChrW(57063) & " Tratamiento"
        BtnTratamiento.TextAlign = ContentAlignment.MiddleLeft
        BtnTratamiento.UseVisualStyleBackColor = False
        ' 
        ' BtnMonitoreo
        ' 
        BtnMonitoreo.BackColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        BtnMonitoreo.FlatAppearance.BorderColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnMonitoreo.FlatAppearance.BorderSize = 0
        BtnMonitoreo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnMonitoreo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnMonitoreo.FlatStyle = FlatStyle.Flat
        BtnMonitoreo.Font = New Font("Georgia", 9.75F)
        BtnMonitoreo.ForeColor = Color.White
        BtnMonitoreo.Location = New Point(12, 239)
        BtnMonitoreo.Name = "BtnMonitoreo"
        BtnMonitoreo.Size = New Size(139, 23)
        BtnMonitoreo.TabIndex = 6
        BtnMonitoreo.Text = "📈 Monitoreo"
        BtnMonitoreo.TextAlign = ContentAlignment.MiddleLeft
        BtnMonitoreo.UseVisualStyleBackColor = False
        ' 
        ' BtnReportes
        ' 
        BtnReportes.BackColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        BtnReportes.FlatAppearance.BorderColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnReportes.FlatAppearance.BorderSize = 0
        BtnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnReportes.FlatStyle = FlatStyle.Flat
        BtnReportes.Font = New Font("Georgia", 9.75F)
        BtnReportes.ForeColor = Color.White
        BtnReportes.Location = New Point(12, 210)
        BtnReportes.Name = "BtnReportes"
        BtnReportes.Size = New Size(139, 23)
        BtnReportes.TabIndex = 5
        BtnReportes.Text = "📊 Reportes"
        BtnReportes.TextAlign = ContentAlignment.MiddleLeft
        BtnReportes.UseVisualStyleBackColor = False
        ' 
        ' BtnAlmacenamiento
        ' 
        BtnAlmacenamiento.BackColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        BtnAlmacenamiento.FlatAppearance.BorderColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnAlmacenamiento.FlatAppearance.BorderSize = 0
        BtnAlmacenamiento.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnAlmacenamiento.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnAlmacenamiento.FlatStyle = FlatStyle.Flat
        BtnAlmacenamiento.Font = New Font("Georgia", 9.75F)
        BtnAlmacenamiento.ForeColor = Color.White
        BtnAlmacenamiento.Location = New Point(12, 144)
        BtnAlmacenamiento.Name = "BtnAlmacenamiento"
        BtnAlmacenamiento.Size = New Size(139, 23)
        BtnAlmacenamiento.TabIndex = 4
        BtnAlmacenamiento.Text = "🛢️Almacenamiento"
        BtnAlmacenamiento.TextAlign = ContentAlignment.MiddleLeft
        BtnAlmacenamiento.UseVisualStyleBackColor = False
        ' 
        ' BtnCaptacion
        ' 
        BtnCaptacion.BackColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        BtnCaptacion.FlatAppearance.BorderColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnCaptacion.FlatAppearance.BorderSize = 0
        BtnCaptacion.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnCaptacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnCaptacion.FlatStyle = FlatStyle.Flat
        BtnCaptacion.Font = New Font("Georgia", 9.75F)
        BtnCaptacion.ForeColor = Color.White
        BtnCaptacion.Location = New Point(12, 115)
        BtnCaptacion.Name = "BtnCaptacion"
        BtnCaptacion.Size = New Size(139, 23)
        BtnCaptacion.TabIndex = 3
        BtnCaptacion.Text = "🌧️ Captación"
        BtnCaptacion.TextAlign = ContentAlignment.MiddleLeft
        BtnCaptacion.UseVisualStyleBackColor = False
        ' 
        ' btnInicio
        ' 
        btnInicio.BackColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        btnInicio.FlatAppearance.BorderColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        btnInicio.FlatAppearance.BorderSize = 0
        btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        btnInicio.FlatStyle = FlatStyle.Flat
        btnInicio.Font = New Font("Georgia", 9.75F)
        btnInicio.ForeColor = Color.White
        btnInicio.Location = New Point(12, 86)
        btnInicio.Name = "btnInicio"
        btnInicio.Size = New Size(139, 23)
        btnInicio.TabIndex = 2
        btnInicio.Text = "🏠 Inicio"
        btnInicio.TextAlign = ContentAlignment.MiddleLeft
        btnInicio.UseVisualStyleBackColor = False
        ' 
        ' PnlVista
        ' 
        PnlVista.AutoScroll = True
        PnlVista.Controls.Add(PnlInicio)
        PnlVista.Dock = DockStyle.Fill
        PnlVista.Location = New Point(0, 0)
        PnlVista.Name = "PnlVista"
        PnlVista.RadioEsquinas = 1
        PnlVista.Size = New Size(1187, 550)
        PnlVista.TabIndex = 7
        ' 
        ' PnlInicio
        ' 
        PnlInicio.AutoScroll = True
        PnlInicio.Controls.Add(TblPrincipal)
        PnlInicio.Dock = DockStyle.Fill
        PnlInicio.Location = New Point(0, 0)
        PnlInicio.Name = "PnlInicio"
        PnlInicio.Size = New Size(1187, 550)
        PnlInicio.TabIndex = 7
        ' 
        ' TblPrincipal
        ' 
        TblPrincipal.AutoScroll = True
        TblPrincipal.ColumnCount = 2
        TblPrincipal.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblPrincipal.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblPrincipal.Controls.Add(PnlCardCalidad, 1, 1)
        TblPrincipal.Controls.Add(PnlCardCaptacion, 0, 1)
        TblPrincipal.Controls.Add(PnlCardSensores, 1, 0)
        TblPrincipal.Controls.Add(PnlCardAlmaceamiento, 0, 0)
        TblPrincipal.Dock = DockStyle.Fill
        TblPrincipal.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        TblPrincipal.Location = New Point(0, 0)
        TblPrincipal.Name = "TblPrincipal"
        TblPrincipal.Padding = New Padding(15)
        TblPrincipal.RowCount = 2
        TblPrincipal.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblPrincipal.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblPrincipal.Size = New Size(1187, 550)
        TblPrincipal.TabIndex = 7
        ' 
        ' PnlCardCalidad
        ' 
        PnlCardCalidad.Anchor = AnchorStyles.None
        PnlCardCalidad.AutoSize = True
        PnlCardCalidad.BackColor = Color.White
        PnlCardCalidad.Controls.Add(txtSubtitulocalidad)
        PnlCardCalidad.Controls.Add(txtdatosCalidad)
        PnlCardCalidad.Controls.Add(txtCalidad)
        PnlCardCalidad.Location = New Point(762, 334)
        PnlCardCalidad.Margin = New Padding(10)
        PnlCardCalidad.Name = "PnlCardCalidad"
        PnlCardCalidad.Size = New Size(240, 142)
        PnlCardCalidad.TabIndex = 6
        ' 
        ' txtSubtitulocalidad
        ' 
        txtSubtitulocalidad.AutoSize = True
        txtSubtitulocalidad.Font = New Font("Segoe UI", 7.75F)
        txtSubtitulocalidad.Location = New Point(28, 129)
        txtSubtitulocalidad.Name = "txtSubtitulocalidad"
        txtSubtitulocalidad.Size = New Size(109, 13)
        txtSubtitulocalidad.TabIndex = 6
        txtSubtitulocalidad.Text = "Estado de Medición"
        ' 
        ' txtdatosCalidad
        ' 
        txtdatosCalidad.AutoSize = True
        txtdatosCalidad.Font = New Font("Modern No. 20", 23.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtdatosCalidad.ForeColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        txtdatosCalidad.Location = New Point(120, 70)
        txtdatosCalidad.Name = "txtdatosCalidad"
        txtdatosCalidad.Size = New Size(36, 32)
        txtdatosCalidad.TabIndex = 5
        txtdatosCalidad.Text = "--"
        ' 
        ' txtCalidad
        ' 
        txtCalidad.AutoSize = True
        txtCalidad.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCalidad.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        txtCalidad.Location = New Point(21, 20)
        txtCalidad.Name = "txtCalidad"
        txtCalidad.Size = New Size(216, 30)
        txtCalidad.TabIndex = 4
        txtCalidad.Text = "💧 Calidad del Agua"
        ' 
        ' PnlCardCaptacion
        ' 
        PnlCardCaptacion.Anchor = AnchorStyles.None
        PnlCardCaptacion.AutoSize = True
        PnlCardCaptacion.BackColor = Color.White
        PnlCardCaptacion.Controls.Add(txtDescriptionc)
        PnlCardCaptacion.Controls.Add(TxtValorCaptacion)
        PnlCardCaptacion.Controls.Add(txtCaptacion)
        PnlCardCaptacion.Location = New Point(207, 336)
        PnlCardCaptacion.Margin = New Padding(10)
        PnlCardCaptacion.Name = "PnlCardCaptacion"
        PnlCardCaptacion.Size = New Size(193, 138)
        PnlCardCaptacion.TabIndex = 4
        ' 
        ' txtDescriptionc
        ' 
        txtDescriptionc.AutoSize = True
        txtDescriptionc.Font = New Font("Segoe UI", 7.75F)
        txtDescriptionc.Location = New Point(21, 125)
        txtDescriptionc.Name = "txtDescriptionc"
        txtDescriptionc.Size = New Size(135, 13)
        txtDescriptionc.TabIndex = 3
        txtDescriptionc.Text = "Volumen total registrado"
        ' 
        ' TxtValorCaptacion
        ' 
        TxtValorCaptacion.AutoSize = True
        TxtValorCaptacion.Font = New Font("Modern No. 20", 23.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtValorCaptacion.ForeColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        TxtValorCaptacion.Location = New Point(98, 66)
        TxtValorCaptacion.Name = "TxtValorCaptacion"
        TxtValorCaptacion.Size = New Size(58, 32)
        TxtValorCaptacion.TabIndex = 2
        TxtValorCaptacion.Text = "--L"
        ' 
        ' txtCaptacion
        ' 
        txtCaptacion.AutoSize = True
        txtCaptacion.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCaptacion.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        txtCaptacion.Location = New Point(43, 16)
        txtCaptacion.Name = "txtCaptacion"
        txtCaptacion.Size = New Size(147, 30)
        txtCaptacion.TabIndex = 1
        txtCaptacion.Text = "🌧️ Captación"
        ' 
        ' PnlCardSensores
        ' 
        PnlCardSensores.Anchor = AnchorStyles.None
        PnlCardSensores.AutoSize = True
        PnlCardSensores.BackColor = Color.White
        PnlCardSensores.Controls.Add(TxtSubSensores)
        PnlCardSensores.Controls.Add(TxtSensores)
        PnlCardSensores.Controls.Add(TxtRespuesta)
        PnlCardSensores.Location = New Point(781, 74)
        PnlCardSensores.Margin = New Padding(10)
        PnlCardSensores.Name = "PnlCardSensores"
        PnlCardSensores.Size = New Size(203, 142)
        PnlCardSensores.TabIndex = 5
        ' 
        ' TxtSubSensores
        ' 
        TxtSubSensores.AutoSize = True
        TxtSubSensores.Font = New Font("Segoe UI", 7.75F)
        TxtSubSensores.Location = New Point(30, 129)
        TxtSubSensores.Name = "TxtSubSensores"
        TxtSubSensores.Size = New Size(110, 13)
        TxtSubSensores.TabIndex = 9
        TxtSubSensores.Text = "Estado de Conexión"
        ' 
        ' TxtSensores
        ' 
        TxtSensores.AutoSize = True
        TxtSensores.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtSensores.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtSensores.Location = New Point(23, 20)
        TxtSensores.Name = "TxtSensores"
        TxtSensores.Size = New Size(177, 30)
        TxtSensores.TabIndex = 7
        TxtSensores.Text = "📟 Sensores LoT"
        ' 
        ' TxtRespuesta
        ' 
        TxtRespuesta.AutoSize = True
        TxtRespuesta.Font = New Font("Modern No. 20", 23.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtRespuesta.ForeColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        TxtRespuesta.Location = New Point(119, 68)
        TxtRespuesta.Name = "TxtRespuesta"
        TxtRespuesta.Size = New Size(36, 32)
        TxtRespuesta.TabIndex = 8
        TxtRespuesta.Text = "--"
        ' 
        ' PnlCardAlmaceamiento
        ' 
        PnlCardAlmaceamiento.Anchor = AnchorStyles.None
        PnlCardAlmaceamiento.AutoSize = True
        PnlCardAlmaceamiento.BackColor = Color.White
        PnlCardAlmaceamiento.Controls.Add(txtsubalmacenamiento)
        PnlCardAlmaceamiento.Controls.Add(txtValorAlmacenamiento)
        PnlCardAlmaceamiento.Controls.Add(txtalmacenamieno)
        PnlCardAlmaceamiento.Location = New Point(183, 76)
        PnlCardAlmaceamiento.Margin = New Padding(10)
        PnlCardAlmaceamiento.Name = "PnlCardAlmaceamiento"
        PnlCardAlmaceamiento.Size = New Size(242, 138)
        PnlCardAlmaceamiento.TabIndex = 5
        ' 
        ' txtsubalmacenamiento
        ' 
        txtsubalmacenamiento.AutoSize = True
        txtsubalmacenamiento.Font = New Font("Segoe UI", 7.75F)
        txtsubalmacenamiento.Location = New Point(26, 125)
        txtsubalmacenamiento.Name = "txtsubalmacenamiento"
        txtsubalmacenamiento.Size = New Size(97, 13)
        txtsubalmacenamiento.TabIndex = 6
        txtsubalmacenamiento.Text = "Nivel de deposíto"
        ' 
        ' txtValorAlmacenamiento
        ' 
        txtValorAlmacenamiento.AutoSize = True
        txtValorAlmacenamiento.Font = New Font("Modern No. 20", 23.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtValorAlmacenamiento.ForeColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        txtValorAlmacenamiento.Location = New Point(109, 63)
        txtValorAlmacenamiento.Name = "txtValorAlmacenamiento"
        txtValorAlmacenamiento.Size = New Size(51, 32)
        txtValorAlmacenamiento.TabIndex = 5
        txtValorAlmacenamiento.Text = "--%"
        ' 
        ' txtalmacenamieno
        ' 
        txtalmacenamieno.AutoSize = True
        txtalmacenamieno.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtalmacenamieno.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        txtalmacenamieno.Location = New Point(24, 13)
        txtalmacenamieno.Name = "txtalmacenamieno"
        txtalmacenamieno.Size = New Size(215, 30)
        txtalmacenamieno.TabIndex = 4
        txtalmacenamieno.Text = "🛢️ Almacenamiento"
        ' 
        ' frmprincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1187, 550)
        Controls.Add(PnlContenido)
        Name = "frmprincipal"
        Text = "frmprincipal"
        PnlContenido.ResumeLayout(False)
        PnlEncabezado.ResumeLayout(False)
        PnlEncabezado.PerformLayout()
        PnlNotificaciones.ResumeLayout(False)
        PnlNotificaciones.PerformLayout()
        Pnlmenu.ResumeLayout(False)
        PnlVista.ResumeLayout(False)
        PnlInicio.ResumeLayout(False)
        TblPrincipal.ResumeLayout(False)
        TblPrincipal.PerformLayout()
        PnlCardCalidad.ResumeLayout(False)
        PnlCardCalidad.PerformLayout()
        PnlCardCaptacion.ResumeLayout(False)
        PnlCardCaptacion.PerformLayout()
        PnlCardSensores.ResumeLayout(False)
        PnlCardSensores.PerformLayout()
        PnlCardAlmaceamiento.ResumeLayout(False)
        PnlCardAlmaceamiento.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PnlContenido As Panel
    Friend WithEvents PnlEncabezado As Panel
    Friend WithEvents Pnlmenu As Panel
    Friend WithEvents tx1 As Label
    Friend WithEvents txsubtitle As Label
    Friend WithEvents btnInicio As Button
    Friend WithEvents BtnAlmacenamiento As Button
    Friend WithEvents BtnCaptacion As Button
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnMonitoreo As Button
    Friend WithEvents PnlCardCaptacion As PanelRedondeado
    Friend WithEvents PnlCardSensores As PanelRedondeado
    Friend WithEvents PnlCardCalidad As PanelRedondeado
    Friend WithEvents PnlCardAlmaceamiento As PanelRedondeado
    Friend WithEvents txtCaptacion As Label
    Friend WithEvents TxtValorCaptacion As Label
    Friend WithEvents txtDescriptionc As Label
    Friend WithEvents txtsubalmacenamiento As Label
    Friend WithEvents txtValorAlmacenamiento As Label
    Friend WithEvents txtalmacenamieno As Label
    Friend WithEvents txtSubtitulocalidad As Label
    Friend WithEvents txtdatosCalidad As Label
    Friend WithEvents txtCalidad As Label
    Friend WithEvents TxtSubSensores As Label
    Friend WithEvents TxtSensores As Label
    Friend WithEvents BtnTratamiento As Button
    Friend WithEvents BtnNotificaciones As Button
    Friend WithEvents TxtContadorAlertas As Label
    Friend WithEvents PnlNotificaciones As PanelRedondeado
    Friend WithEvents txtSubtitle As Label
    Friend WithEvents LblTituloNotificaciones As Label
    Friend WithEvents LblSinNotificaciones As Label
    Friend WithEvents PnlSeparador As Panel
    Friend WithEvents TxtEmoji As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlVista As PanelRedondeado
    Friend WithEvents PnlInicio As PanelRedondeado
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LblAguaAlmacena As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TxtRespuesta As Label
    Friend WithEvents BtnMenu As Button
    Friend WithEvents TblPrincipal As TableLayoutPanel
End Class
