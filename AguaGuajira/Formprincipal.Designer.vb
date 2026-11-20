<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmprincipal
    Inherits System.Windows.Forms.Form

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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim IconoPPal As PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprincipal))
        PnlContenido = New Panel()
        Pnlmenu = New Panel()
        BtnFuentesAgua = New Button()
        BtnTratamiento = New Button()
        BtnMonitoreo = New Button()
        BtnAlmacenamiento = New Button()
        BtnCaptacion = New Button()
        btnInicio = New Button()
        PnlEncabezado = New Panel()
        LblBienvenido = New Label()
        IconUser = New PictureBox()
        Lbluser = New Label()
        tx1 = New Label()
        TxtContadorAlertas = New Label()
        BtnNotificaciones = New Button()
        BtnMenu = New Button()
        txsubtitle = New Label()
        PnlVista = New PanelRedondeado()
        PnlInicio = New PanelRedondeado()
        Pnlppal = New PanelRedondeado()
        LblTituuloPpal = New Label()
        LblSubPpal = New Label()
        PnlNotificaciones = New PanelRedondeado()
        TxtEmoji = New Label()
        PnlSeparador = New Panel()
        LblTituloNotificaciones = New Label()
        txtSubtitle = New Label()
        LblSinNotificaciones = New Label()
        PnlCardAlmaceamiento = New PanelRedondeado()
        TxbAlmacenamiento = New TextBoxRedondeado()
        txtsubalmacenamiento = New Label()
        txtalmacenamieno = New Label()
        PnlAlertas = New PanelRedondeado()
        LblAlertas = New Label()
        Lbltrata = New Label()
        BtnAlmacenamiento2 = New Button()
        IconfuentesAGUA = New Label()
        lblAlmacenamientoIcone = New Label()
        LblCapacidadImage = New Label()
        BtnTratamiento3 = New Button()
        BtnCaptacion2 = New Button()
        BtnFuentesAgua2 = New Button()
        PnlCardCaptacion = New PanelRedondeado()
        TxbCaptacion = New TextBoxRedondeado()
        txtDescriptionc = New Label()
        txtCaptacion = New Label()
        PnlResumen = New PanelRedondeado()
        DtgReview = New DataGridView()
        LblSub = New Label()
        LblIcono = New Label()
        PnlCardCalidad = New PanelRedondeado()
        TxbCalidad = New TextBoxRedondeado()
        txtSubtitulocalidad = New Label()
        txtCalidad = New Label()
        PnlCardSensores = New PanelRedondeado()
        TxbSensores = New TextBoxRedondeado()
        TxtSubSensores = New Label()
        TxtSensores = New Label()
        BtnMonitoreo2 = New Button()
        IconoPPal = New PictureBox()
        CType(IconoPPal, ComponentModel.ISupportInitialize).BeginInit()
        PnlContenido.SuspendLayout()
        Pnlmenu.SuspendLayout()
        PnlEncabezado.SuspendLayout()
        CType(IconUser, ComponentModel.ISupportInitialize).BeginInit()
        PnlVista.SuspendLayout()
        PnlInicio.SuspendLayout()
        Pnlppal.SuspendLayout()
        PnlNotificaciones.SuspendLayout()
        PnlCardAlmaceamiento.SuspendLayout()
        PnlAlertas.SuspendLayout()
        PnlCardCaptacion.SuspendLayout()
        PnlResumen.SuspendLayout()
        CType(DtgReview, ComponentModel.ISupportInitialize).BeginInit()
        PnlCardCalidad.SuspendLayout()
        PnlCardSensores.SuspendLayout()
        SuspendLayout()
        ' 
        ' IconoPPal
        ' 
        IconoPPal.BackColor = Color.Transparent
        IconoPPal.ErrorImage = Nothing
        IconoPPal.Image = CType(resources.GetObject("IconoPPal.Image"), Image)
        IconoPPal.InitialImage = Nothing
        IconoPPal.Location = New Point(0, 0)
        IconoPPal.Name = "IconoPPal"
        IconoPPal.Size = New Size(89, 80)
        IconoPPal.SizeMode = PictureBoxSizeMode.StretchImage
        IconoPPal.TabIndex = 8
        IconoPPal.TabStop = False
        ' 
        ' PnlContenido
        ' 
        PnlContenido.BackColor = Color.FromArgb(CByte(241), CByte(239), CByte(251))
        PnlContenido.Controls.Add(Pnlmenu)
        PnlContenido.Controls.Add(PnlEncabezado)
        PnlContenido.Controls.Add(PnlVista)
        PnlContenido.Dock = DockStyle.Fill
        PnlContenido.Location = New Point(0, 0)
        PnlContenido.Margin = New Padding(0)
        PnlContenido.Name = "PnlContenido"
        PnlContenido.Size = New Size(1156, 578)
        PnlContenido.TabIndex = 0
        ' 
        ' Pnlmenu
        ' 
        Pnlmenu.BackColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        Pnlmenu.Controls.Add(BtnFuentesAgua)
        Pnlmenu.Controls.Add(BtnTratamiento)
        Pnlmenu.Controls.Add(BtnMonitoreo)
        Pnlmenu.Controls.Add(BtnAlmacenamiento)
        Pnlmenu.Controls.Add(BtnCaptacion)
        Pnlmenu.Controls.Add(btnInicio)
        Pnlmenu.Location = New Point(0, 0)
        Pnlmenu.Name = "Pnlmenu"
        Pnlmenu.Size = New Size(158, 584)
        Pnlmenu.TabIndex = 1
        ' 
        ' BtnFuentesAgua
        ' 
        BtnFuentesAgua.BackColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        BtnFuentesAgua.FlatAppearance.BorderColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnFuentesAgua.FlatAppearance.BorderSize = 0
        BtnFuentesAgua.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnFuentesAgua.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnFuentesAgua.FlatStyle = FlatStyle.Flat
        BtnFuentesAgua.Font = New Font("Georgia", 9.75F)
        BtnFuentesAgua.ForeColor = Color.White
        BtnFuentesAgua.Location = New Point(9, 132)
        BtnFuentesAgua.Name = "BtnFuentesAgua"
        BtnFuentesAgua.Size = New Size(139, 23)
        BtnFuentesAgua.TabIndex = 8
        BtnFuentesAgua.Text = "📊 Fuentes Agua"
        BtnFuentesAgua.TextAlign = ContentAlignment.MiddleLeft
        BtnFuentesAgua.UseVisualStyleBackColor = False
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
        BtnTratamiento.Location = New Point(9, 269)
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
        BtnMonitoreo.Location = New Point(12, 311)
        BtnMonitoreo.Name = "BtnMonitoreo"
        BtnMonitoreo.Size = New Size(139, 23)
        BtnMonitoreo.TabIndex = 6
        BtnMonitoreo.Text = "📈 Monitoreo"
        BtnMonitoreo.TextAlign = ContentAlignment.MiddleLeft
        BtnMonitoreo.UseVisualStyleBackColor = False
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
        BtnAlmacenamiento.Location = New Point(9, 181)
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
        BtnCaptacion.Location = New Point(9, 228)
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
        ' PnlEncabezado
        ' 
        PnlEncabezado.BackColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        PnlEncabezado.Controls.Add(LblBienvenido)
        PnlEncabezado.Controls.Add(IconUser)
        PnlEncabezado.Controls.Add(Lbluser)
        PnlEncabezado.Controls.Add(tx1)
        PnlEncabezado.Controls.Add(TxtContadorAlertas)
        PnlEncabezado.Controls.Add(BtnNotificaciones)
        PnlEncabezado.Controls.Add(BtnMenu)
        PnlEncabezado.Controls.Add(txsubtitle)
        PnlEncabezado.Dock = DockStyle.Top
        PnlEncabezado.Location = New Point(0, 0)
        PnlEncabezado.Name = "PnlEncabezado"
        PnlEncabezado.Size = New Size(1156, 54)
        PnlEncabezado.TabIndex = 0
        ' 
        ' LblBienvenido
        ' 
        LblBienvenido.AutoSize = True
        LblBienvenido.ForeColor = Color.White
        LblBienvenido.Location = New Point(1075, 9)
        LblBienvenido.Name = "LblBienvenido"
        LblBienvenido.Size = New Size(69, 15)
        LblBienvenido.TabIndex = 15
        LblBienvenido.Text = "Bienvenido,"
        ' 
        ' IconUser
        ' 
        IconUser.Image = CType(resources.GetObject("IconUser.Image"), Image)
        IconUser.Location = New Point(1028, 6)
        IconUser.Name = "IconUser"
        IconUser.Size = New Size(41, 44)
        IconUser.SizeMode = PictureBoxSizeMode.StretchImage
        IconUser.TabIndex = 14
        IconUser.TabStop = False
        ' 
        ' Lbluser
        ' 
        Lbluser.AutoSize = True
        Lbluser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbluser.ForeColor = Color.White
        Lbluser.Location = New Point(1075, 24)
        Lbluser.Name = "Lbluser"
        Lbluser.Size = New Size(33, 15)
        Lbluser.TabIndex = 13
        Lbluser.Text = "User"
        ' 
        ' tx1
        ' 
        tx1.AutoSize = True
        tx1.Font = New Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tx1.ForeColor = Color.White
        tx1.Location = New Point(466, 9)
        tx1.Name = "tx1"
        tx1.Size = New Size(149, 28)
        tx1.TabIndex = 0
        tx1.Text = "💧 Agua Guajira"
        ' 
        ' TxtContadorAlertas
        ' 
        TxtContadorAlertas.BackColor = Color.Transparent
        TxtContadorAlertas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtContadorAlertas.ForeColor = Color.Plum
        TxtContadorAlertas.Location = New Point(1005, 12)
        TxtContadorAlertas.Name = "TxtContadorAlertas"
        TxtContadorAlertas.Size = New Size(16, 21)
        TxtContadorAlertas.TabIndex = 2
        TxtContadorAlertas.Text = "0"
        ' 
        ' BtnNotificaciones
        ' 
        BtnNotificaciones.BackColor = Color.Transparent
        BtnNotificaciones.Cursor = Cursors.Hand
        BtnNotificaciones.FlatAppearance.BorderSize = 0
        BtnNotificaciones.FlatStyle = FlatStyle.Flat
        BtnNotificaciones.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnNotificaciones.ForeColor = Color.White
        BtnNotificaciones.Location = New Point(974, 12)
        BtnNotificaciones.Name = "BtnNotificaciones"
        BtnNotificaciones.Size = New Size(47, 42)
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
        txsubtitle.Location = New Point(494, 37)
        txsubtitle.Name = "txsubtitle"
        txsubtitle.Size = New Size(143, 13)
        txsubtitle.TabIndex = 1
        txsubtitle.Text = "Sistema de adminstracion del agua"
        ' 
        ' PnlVista
        ' 
        PnlVista.AutoScroll = True
        PnlVista.Controls.Add(PnlInicio)
        PnlVista.Dock = DockStyle.Fill
        PnlVista.Location = New Point(0, 0)
        PnlVista.Margin = New Padding(0)
        PnlVista.Name = "PnlVista"
        PnlVista.RadioEsquinas = 1
        PnlVista.Size = New Size(1156, 578)
        PnlVista.TabIndex = 7
        ' 
        ' PnlInicio
        ' 
        PnlInicio.AutoScroll = True
        PnlInicio.AutoSize = True
        PnlInicio.BackColor = Color.Transparent
        PnlInicio.Controls.Add(Pnlppal)
        PnlInicio.Controls.Add(PnlNotificaciones)
        PnlInicio.Controls.Add(PnlCardAlmaceamiento)
        PnlInicio.Controls.Add(PnlAlertas)
        PnlInicio.Controls.Add(PnlCardCaptacion)
        PnlInicio.Controls.Add(PnlResumen)
        PnlInicio.Controls.Add(PnlCardCalidad)
        PnlInicio.Controls.Add(PnlCardSensores)
        PnlInicio.Dock = DockStyle.Fill
        PnlInicio.Location = New Point(0, 0)
        PnlInicio.Margin = New Padding(10)
        PnlInicio.Name = "PnlInicio"
        PnlInicio.Size = New Size(1156, 578)
        PnlInicio.TabIndex = 7
        ' 
        ' Pnlppal
        ' 
        Pnlppal.BackColor = Color.White
        Pnlppal.Controls.Add(IconoPPal)
        Pnlppal.Controls.Add(LblTituuloPpal)
        Pnlppal.Controls.Add(LblSubPpal)
        Pnlppal.Location = New Point(157, 57)
        Pnlppal.Name = "Pnlppal"
        Pnlppal.Size = New Size(423, 76)
        Pnlppal.TabIndex = 12
        ' 
        ' LblTituuloPpal
        ' 
        LblTituuloPpal.AutoSize = True
        LblTituuloPpal.BackColor = Color.White
        LblTituuloPpal.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTituuloPpal.Location = New Point(75, 10)
        LblTituuloPpal.Name = "LblTituuloPpal"
        LblTituuloPpal.Size = New Size(347, 37)
        LblTituuloPpal.TabIndex = 7
        LblTituuloPpal.Text = "¡Bienvenido a Agua Guajira!"
        ' 
        ' LblSubPpal
        ' 
        LblSubPpal.AutoSize = True
        LblSubPpal.BackColor = Color.White
        LblSubPpal.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSubPpal.Location = New Point(95, 52)
        LblSubPpal.Name = "LblSubPpal"
        LblSubPpal.Size = New Size(249, 17)
        LblSubPpal.TabIndex = 9
        LblSubPpal.Text = "Sistema de gestión y monitoreo del agua"
        ' 
        ' PnlNotificaciones
        ' 
        PnlNotificaciones.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PnlNotificaciones.BackColor = Color.White
        PnlNotificaciones.BorderStyle = BorderStyle.Fixed3D
        PnlNotificaciones.Controls.Add(TxtEmoji)
        PnlNotificaciones.Controls.Add(PnlSeparador)
        PnlNotificaciones.Controls.Add(LblTituloNotificaciones)
        PnlNotificaciones.Controls.Add(txtSubtitle)
        PnlNotificaciones.Controls.Add(LblSinNotificaciones)
        PnlNotificaciones.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        PnlNotificaciones.Location = New Point(747, 59)
        PnlNotificaciones.Name = "PnlNotificaciones"
        PnlNotificaciones.RadioEsquinas = 16
        PnlNotificaciones.Size = New Size(308, 333)
        PnlNotificaciones.TabIndex = 7
        PnlNotificaciones.Visible = False
        ' 
        ' TxtEmoji
        ' 
        TxtEmoji.AutoSize = True
        TxtEmoji.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtEmoji.Location = New Point(115, 110)
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
        LblTituloNotificaciones.Location = New Point(138, 11)
        LblTituloNotificaciones.Name = "LblTituloNotificaciones"
        LblTituloNotificaciones.Size = New Size(123, 23)
        LblTituloNotificaciones.TabIndex = 8
        LblTituloNotificaciones.Text = "Notificaciones"
        ' 
        ' txtSubtitle
        ' 
        txtSubtitle.AutoSize = True
        txtSubtitle.Font = New Font("Segoe UI", 8F)
        txtSubtitle.Location = New Point(154, 34)
        txtSubtitle.Name = "txtSubtitle"
        txtSubtitle.Size = New Size(102, 13)
        txtSubtitle.TabIndex = 9
        txtSubtitle.Text = "Alertas del sistema"
        ' 
        ' LblSinNotificaciones
        ' 
        LblSinNotificaciones.AutoSize = True
        LblSinNotificaciones.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        LblSinNotificaciones.Location = New Point(57, 147)
        LblSinNotificaciones.Name = "LblSinNotificaciones"
        LblSinNotificaciones.Size = New Size(162, 15)
        LblSinNotificaciones.TabIndex = 11
        LblSinNotificaciones.Text = "No hay notificaciones nuevas"
        ' 
        ' PnlCardAlmaceamiento
        ' 
        PnlCardAlmaceamiento.Anchor = AnchorStyles.None
        PnlCardAlmaceamiento.BackColor = Color.White
        PnlCardAlmaceamiento.Controls.Add(TxbAlmacenamiento)
        PnlCardAlmaceamiento.Controls.Add(txtsubalmacenamiento)
        PnlCardAlmaceamiento.Controls.Add(txtalmacenamieno)
        PnlCardAlmaceamiento.Location = New Point(164, 141)
        PnlCardAlmaceamiento.Margin = New Padding(10)
        PnlCardAlmaceamiento.Name = "PnlCardAlmaceamiento"
        PnlCardAlmaceamiento.Size = New Size(221, 130)
        PnlCardAlmaceamiento.TabIndex = 5
        ' 
        ' TxbAlmacenamiento
        ' 
        TxbAlmacenamiento.Anchor = AnchorStyles.None
        TxbAlmacenamiento.BackColor = Color.Gainsboro
        TxbAlmacenamiento.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxbAlmacenamiento.Enabled = False
        TxbAlmacenamiento.GrosorBorde = 1.5F
        TxbAlmacenamiento.Location = New Point(30, 53)
        TxbAlmacenamiento.Multiline = False
        TxbAlmacenamiento.Name = "TxbAlmacenamiento"
        TxbAlmacenamiento.Padding = New Padding(10, 5, 10, 5)
        TxbAlmacenamiento.RadioEsquinas = 20
        TxbAlmacenamiento.ScrollBars = ScrollBars.Vertical
        TxbAlmacenamiento.Size = New Size(175, 37)
        TxbAlmacenamiento.TabIndex = 7
        TxbAlmacenamiento.WordWrap = True
        ' 
        ' txtsubalmacenamiento
        ' 
        txtsubalmacenamiento.AutoSize = True
        txtsubalmacenamiento.Font = New Font("Segoe UI", 7.75F)
        txtsubalmacenamiento.Location = New Point(56, 107)
        txtsubalmacenamiento.Name = "txtsubalmacenamiento"
        txtsubalmacenamiento.Size = New Size(97, 13)
        txtsubalmacenamiento.TabIndex = 6
        txtsubalmacenamiento.Text = "Nivel de deposíto"
        ' 
        ' txtalmacenamieno
        ' 
        txtalmacenamieno.AutoSize = True
        txtalmacenamieno.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtalmacenamieno.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        txtalmacenamieno.Location = New Point(17, 13)
        txtalmacenamieno.Name = "txtalmacenamieno"
        txtalmacenamieno.Size = New Size(188, 25)
        txtalmacenamieno.TabIndex = 4
        txtalmacenamieno.Text = "🛢️ Almacenamiento"
        ' 
        ' PnlAlertas
        ' 
        PnlAlertas.Anchor = AnchorStyles.None
        PnlAlertas.BackColor = Color.White
        PnlAlertas.Controls.Add(LblAlertas)
        PnlAlertas.Controls.Add(Lbltrata)
        PnlAlertas.Controls.Add(BtnAlmacenamiento2)
        PnlAlertas.Controls.Add(IconfuentesAGUA)
        PnlAlertas.Controls.Add(lblAlmacenamientoIcone)
        PnlAlertas.Controls.Add(LblCapacidadImage)
        PnlAlertas.Controls.Add(BtnTratamiento3)
        PnlAlertas.Controls.Add(BtnCaptacion2)
        PnlAlertas.Controls.Add(BtnFuentesAgua2)
        PnlAlertas.Location = New Point(903, 293)
        PnlAlertas.Name = "PnlAlertas"
        PnlAlertas.Size = New Size(205, 233)
        PnlAlertas.TabIndex = 11
        ' 
        ' LblAlertas
        ' 
        LblAlertas.AutoSize = True
        LblAlertas.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblAlertas.Location = New Point(56, 22)
        LblAlertas.Name = "LblAlertas"
        LblAlertas.Size = New Size(96, 25)
        LblAlertas.TabIndex = 20
        LblAlertas.Text = "🚨 Alertas"
        ' 
        ' Lbltrata
        ' 
        Lbltrata.AutoSize = True
        Lbltrata.BackColor = Color.Transparent
        Lbltrata.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbltrata.Location = New Point(12, 140)
        Lbltrata.Name = "Lbltrata"
        Lbltrata.Size = New Size(54, 37)
        Lbltrata.TabIndex = 19
        Lbltrata.Text = "🚰"
        ' 
        ' BtnAlmacenamiento2
        ' 
        BtnAlmacenamiento2.Font = New Font("Bell MT", 12F, FontStyle.Bold)
        BtnAlmacenamiento2.Location = New Point(52, 107)
        BtnAlmacenamiento2.Name = "BtnAlmacenamiento2"
        BtnAlmacenamiento2.Size = New Size(139, 25)
        BtnAlmacenamiento2.TabIndex = 18
        BtnAlmacenamiento2.Text = "Almacenamiento"
        BtnAlmacenamiento2.UseVisualStyleBackColor = True
        ' 
        ' IconfuentesAGUA
        ' 
        IconfuentesAGUA.AutoSize = True
        IconfuentesAGUA.BackColor = Color.Transparent
        IconfuentesAGUA.FlatStyle = FlatStyle.Flat
        IconfuentesAGUA.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IconfuentesAGUA.ForeColor = Color.Black
        IconfuentesAGUA.Location = New Point(14, 180)
        IconfuentesAGUA.Name = "IconfuentesAGUA"
        IconfuentesAGUA.Size = New Size(54, 37)
        IconfuentesAGUA.TabIndex = 17
        IconfuentesAGUA.Text = "⛲"
        IconfuentesAGUA.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAlmacenamientoIcone
        ' 
        lblAlmacenamientoIcone.AutoSize = True
        lblAlmacenamientoIcone.BackColor = Color.Transparent
        lblAlmacenamientoIcone.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAlmacenamientoIcone.Location = New Point(19, 102)
        lblAlmacenamientoIcone.Name = "lblAlmacenamientoIcone"
        lblAlmacenamientoIcone.Size = New Size(42, 30)
        lblAlmacenamientoIcone.TabIndex = 16
        lblAlmacenamientoIcone.Text = "🛢️"
        ' 
        ' LblCapacidadImage
        ' 
        LblCapacidadImage.AutoSize = True
        LblCapacidadImage.BackColor = Color.Transparent
        LblCapacidadImage.Font = New Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblCapacidadImage.Location = New Point(17, 64)
        LblCapacidadImage.Name = "LblCapacidadImage"
        LblCapacidadImage.Size = New Size(46, 32)
        LblCapacidadImage.TabIndex = 6
        LblCapacidadImage.Text = "🌧️"
        ' 
        ' BtnTratamiento3
        ' 
        BtnTratamiento3.AutoSize = True
        BtnTratamiento3.BackColor = Color.White
        BtnTratamiento3.FlatAppearance.BorderColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnTratamiento3.FlatAppearance.BorderSize = 0
        BtnTratamiento3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnTratamiento3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnTratamiento3.Font = New Font("Bell MT", 12F, FontStyle.Bold)
        BtnTratamiento3.ForeColor = Color.Black
        BtnTratamiento3.Location = New Point(51, 148)
        BtnTratamiento3.Name = "BtnTratamiento3"
        BtnTratamiento3.Size = New Size(135, 29)
        BtnTratamiento3.TabIndex = 14
        BtnTratamiento3.Text = "Tratamiento"
        BtnTratamiento3.UseVisualStyleBackColor = False
        ' 
        ' BtnCaptacion2
        ' 
        BtnCaptacion2.Font = New Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCaptacion2.Location = New Point(43, 64)
        BtnCaptacion2.Name = "BtnCaptacion2"
        BtnCaptacion2.Size = New Size(139, 26)
        BtnCaptacion2.TabIndex = 10
        BtnCaptacion2.Text = "Captacion"
        BtnCaptacion2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' BtnFuentesAgua2
        ' 
        BtnFuentesAgua2.BackColor = Color.White
        BtnFuentesAgua2.FlatAppearance.BorderColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnFuentesAgua2.FlatAppearance.BorderSize = 0
        BtnFuentesAgua2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnFuentesAgua2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnFuentesAgua2.Font = New Font("Bell MT", 12F, FontStyle.Bold)
        BtnFuentesAgua2.ForeColor = Color.Black
        BtnFuentesAgua2.Location = New Point(46, 192)
        BtnFuentesAgua2.Name = "BtnFuentesAgua2"
        BtnFuentesAgua2.Size = New Size(139, 23)
        BtnFuentesAgua2.TabIndex = 15
        BtnFuentesAgua2.Text = "Fuentes Agua"
        BtnFuentesAgua2.UseVisualStyleBackColor = False
        ' 
        ' PnlCardCaptacion
        ' 
        PnlCardCaptacion.Anchor = AnchorStyles.None
        PnlCardCaptacion.BackColor = Color.White
        PnlCardCaptacion.Controls.Add(TxbCaptacion)
        PnlCardCaptacion.Controls.Add(txtDescriptionc)
        PnlCardCaptacion.Controls.Add(txtCaptacion)
        PnlCardCaptacion.Location = New Point(892, 151)
        PnlCardCaptacion.Margin = New Padding(10)
        PnlCardCaptacion.Name = "PnlCardCaptacion"
        PnlCardCaptacion.Size = New Size(213, 130)
        PnlCardCaptacion.TabIndex = 4
        ' 
        ' TxbCaptacion
        ' 
        TxbCaptacion.BackColor = Color.Gainsboro
        TxbCaptacion.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxbCaptacion.GrosorBorde = 1.5F
        TxbCaptacion.Location = New Point(19, 47)
        TxbCaptacion.Multiline = False
        TxbCaptacion.Name = "TxbCaptacion"
        TxbCaptacion.Padding = New Padding(10, 5, 10, 5)
        TxbCaptacion.RadioEsquinas = 20
        TxbCaptacion.ScrollBars = ScrollBars.Vertical
        TxbCaptacion.Size = New Size(175, 37)
        TxbCaptacion.TabIndex = 8
        TxbCaptacion.WordWrap = True
        ' 
        ' txtDescriptionc
        ' 
        txtDescriptionc.Anchor = AnchorStyles.Bottom
        txtDescriptionc.AutoSize = True
        txtDescriptionc.Font = New Font("Segoe UI", 7.75F)
        txtDescriptionc.Location = New Point(46, 106)
        txtDescriptionc.Name = "txtDescriptionc"
        txtDescriptionc.Size = New Size(135, 13)
        txtDescriptionc.TabIndex = 3
        txtDescriptionc.Text = "Volumen total registrado"
        ' 
        ' txtCaptacion
        ' 
        txtCaptacion.Anchor = AnchorStyles.Top
        txtCaptacion.AutoSize = True
        txtCaptacion.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCaptacion.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        txtCaptacion.Location = New Point(34, 6)
        txtCaptacion.Name = "txtCaptacion"
        txtCaptacion.Size = New Size(147, 30)
        txtCaptacion.TabIndex = 1
        txtCaptacion.Text = "🌧️ Captación"
        ' 
        ' PnlResumen
        ' 
        PnlResumen.Anchor = AnchorStyles.None
        PnlResumen.BackColor = Color.White
        PnlResumen.Controls.Add(DtgReview)
        PnlResumen.Controls.Add(LblSub)
        PnlResumen.Controls.Add(LblIcono)
        PnlResumen.Location = New Point(177, 289)
        PnlResumen.Name = "PnlResumen"
        PnlResumen.Size = New Size(710, 233)
        PnlResumen.TabIndex = 10
        ' 
        ' DtgReview
        ' 
        DtgReview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DtgReview.Location = New Point(22, 56)
        DtgReview.Name = "DtgReview"
        DtgReview.Size = New Size(661, 165)
        DtgReview.TabIndex = 2
        ' 
        ' LblSub
        ' 
        LblSub.AutoSize = True
        LblSub.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSub.Location = New Point(50, 20)
        LblSub.Name = "LblSub"
        LblSub.Size = New Size(242, 21)
        LblSub.TabIndex = 0
        LblSub.Text = "Resumen del historial del sistema"
        ' 
        ' LblIcono
        ' 
        LblIcono.AutoSize = True
        LblIcono.BackColor = Color.Transparent
        LblIcono.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblIcono.ForeColor = SystemColors.Highlight
        LblIcono.Location = New Point(22, 16)
        LblIcono.Name = "LblIcono"
        LblIcono.Size = New Size(43, 30)
        LblIcono.TabIndex = 1
        LblIcono.Text = "💧"
        ' 
        ' PnlCardCalidad
        ' 
        PnlCardCalidad.Anchor = AnchorStyles.None
        PnlCardCalidad.BackColor = Color.White
        PnlCardCalidad.Controls.Add(TxbCalidad)
        PnlCardCalidad.Controls.Add(txtSubtitulocalidad)
        PnlCardCalidad.Controls.Add(txtCalidad)
        PnlCardCalidad.Location = New Point(405, 142)
        PnlCardCalidad.Margin = New Padding(10)
        PnlCardCalidad.Name = "PnlCardCalidad"
        PnlCardCalidad.Size = New Size(213, 130)
        PnlCardCalidad.TabIndex = 6
        ' 
        ' TxbCalidad
        ' 
        TxbCalidad.BackColor = Color.Gainsboro
        TxbCalidad.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxbCalidad.Enabled = False
        TxbCalidad.GrosorBorde = 1.5F
        TxbCalidad.Location = New Point(26, 54)
        TxbCalidad.Multiline = False
        TxbCalidad.Name = "TxbCalidad"
        TxbCalidad.Padding = New Padding(10, 5, 10, 5)
        TxbCalidad.RadioEsquinas = 20
        TxbCalidad.ScrollBars = ScrollBars.Vertical
        TxbCalidad.Size = New Size(175, 37)
        TxbCalidad.TabIndex = 8
        TxbCalidad.WordWrap = True
        ' 
        ' txtSubtitulocalidad
        ' 
        txtSubtitulocalidad.AutoSize = True
        txtSubtitulocalidad.Font = New Font("Segoe UI", 7.75F)
        txtSubtitulocalidad.Location = New Point(52, 107)
        txtSubtitulocalidad.Name = "txtSubtitulocalidad"
        txtSubtitulocalidad.Size = New Size(109, 13)
        txtSubtitulocalidad.TabIndex = 6
        txtSubtitulocalidad.Text = "Estado de Medición"
        ' 
        ' txtCalidad
        ' 
        txtCalidad.AutoSize = True
        txtCalidad.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtCalidad.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        txtCalidad.Location = New Point(12, 12)
        txtCalidad.Name = "txtCalidad"
        txtCalidad.Size = New Size(189, 25)
        txtCalidad.TabIndex = 4
        txtCalidad.Text = "💧 Calidad del Agua"
        ' 
        ' PnlCardSensores
        ' 
        PnlCardSensores.Anchor = AnchorStyles.None
        PnlCardSensores.BackColor = Color.White
        PnlCardSensores.Controls.Add(TxbSensores)
        PnlCardSensores.Controls.Add(TxtSubSensores)
        PnlCardSensores.Controls.Add(TxtSensores)
        PnlCardSensores.Location = New Point(638, 142)
        PnlCardSensores.Margin = New Padding(10)
        PnlCardSensores.Name = "PnlCardSensores"
        PnlCardSensores.Size = New Size(230, 130)
        PnlCardSensores.TabIndex = 5
        ' 
        ' TxbSensores
        ' 
        TxbSensores.BackColor = Color.Gainsboro
        TxbSensores.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxbSensores.GrosorBorde = 1.5F
        TxbSensores.Location = New Point(30, 52)
        TxbSensores.Multiline = False
        TxbSensores.Name = "TxbSensores"
        TxbSensores.Padding = New Padding(10, 5, 10, 5)
        TxbSensores.RadioEsquinas = 20
        TxbSensores.ScrollBars = ScrollBars.Vertical
        TxbSensores.Size = New Size(175, 37)
        TxbSensores.TabIndex = 10
        TxbSensores.WordWrap = True
        ' 
        ' TxtSubSensores
        ' 
        TxtSubSensores.Anchor = AnchorStyles.Bottom
        TxtSubSensores.AutoSize = True
        TxtSubSensores.Font = New Font("Segoe UI", 7.75F)
        TxtSubSensores.Location = New Point(62, 106)
        TxtSubSensores.Name = "TxtSubSensores"
        TxtSubSensores.Size = New Size(110, 13)
        TxtSubSensores.TabIndex = 9
        TxtSubSensores.Text = "Estado de Conexión"
        ' 
        ' TxtSensores
        ' 
        TxtSensores.Anchor = AnchorStyles.Top
        TxtSensores.AutoSize = True
        TxtSensores.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TxtSensores.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtSensores.Location = New Point(26, 10)
        TxtSensores.Name = "TxtSensores"
        TxtSensores.Size = New Size(177, 30)
        TxtSensores.TabIndex = 7
        TxtSensores.Text = "📟 Sensores LoT"
        ' 
        ' BtnMonitoreo2
        ' 
        BtnMonitoreo2.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        BtnMonitoreo2.FlatAppearance.BorderColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnMonitoreo2.FlatAppearance.BorderSize = 0
        BtnMonitoreo2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnMonitoreo2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        BtnMonitoreo2.FlatStyle = FlatStyle.Popup
        BtnMonitoreo2.Font = New Font("Georgia", 9.75F)
        BtnMonitoreo2.ForeColor = Color.White
        BtnMonitoreo2.Location = New Point(36, 170)
        BtnMonitoreo2.Name = "BtnMonitoreo2"
        BtnMonitoreo2.Size = New Size(139, 23)
        BtnMonitoreo2.TabIndex = 13
        BtnMonitoreo2.Text = "📈 Monitoreo"
        BtnMonitoreo2.TextAlign = ContentAlignment.MiddleLeft
        BtnMonitoreo2.UseVisualStyleBackColor = False
        ' 
        ' frmprincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1156, 578)
        Controls.Add(PnlContenido)
        Name = "frmprincipal"
        Text = "frmprincipal"
        CType(IconoPPal, ComponentModel.ISupportInitialize).EndInit()
        PnlContenido.ResumeLayout(False)
        Pnlmenu.ResumeLayout(False)
        PnlEncabezado.ResumeLayout(False)
        PnlEncabezado.PerformLayout()
        CType(IconUser, ComponentModel.ISupportInitialize).EndInit()
        PnlVista.ResumeLayout(False)
        PnlVista.PerformLayout()
        PnlInicio.ResumeLayout(False)
        Pnlppal.ResumeLayout(False)
        Pnlppal.PerformLayout()
        PnlNotificaciones.ResumeLayout(False)
        PnlNotificaciones.PerformLayout()
        PnlCardAlmaceamiento.ResumeLayout(False)
        PnlCardAlmaceamiento.PerformLayout()
        PnlAlertas.ResumeLayout(False)
        PnlAlertas.PerformLayout()
        PnlCardCaptacion.ResumeLayout(False)
        PnlCardCaptacion.PerformLayout()
        PnlResumen.ResumeLayout(False)
        PnlResumen.PerformLayout()
        CType(DtgReview, ComponentModel.ISupportInitialize).EndInit()
        PnlCardCalidad.ResumeLayout(False)
        PnlCardCalidad.PerformLayout()
        PnlCardSensores.ResumeLayout(False)
        PnlCardSensores.PerformLayout()
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
    Friend WithEvents BtnMonitoreo As Button
    Friend WithEvents PnlCardCaptacion As PanelRedondeado
    Friend WithEvents PnlCardSensores As PanelRedondeado
    Friend WithEvents PnlCardCalidad As PanelRedondeado
    Friend WithEvents PnlCardAlmaceamiento As PanelRedondeado
    Friend WithEvents txtCaptacion As Label
    Friend WithEvents TxtValorCaptacion As Label
    Friend WithEvents txtDescriptionc As Label
    Friend WithEvents txtsubalmacenamiento As Label
    Friend WithEvents txtalmacenamieno As Label
    Friend WithEvents txtSubtitulocalidad As Label
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LblAguaAlmacena As Label
    Friend WithEvents BtnCaptacion2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnFuentesAgua As Button
    Friend WithEvents LblTituuloPpal As Label
    Friend WithEvents PnlInicio As PanelRedondeado
    Friend WithEvents IconUser As PictureBox
    Friend WithEvents Lbluser As Label
    Friend WithEvents LblSubPpal As Label
    Friend WithEvents LblBienvenido As Label
    Friend WithEvents PnlAlertas As PanelRedondeado
    Friend WithEvents PnlResumen As PanelRedondeado
    Friend WithEvents LblSub As Label
    Friend WithEvents LblIcono As Label
    Friend WithEvents DtgReview As DataGridView
    Friend WithEvents LblCapacidadImage As Label
    Friend WithEvents IcAlmacenamiento As Label
    Friend WithEvents BtnTratamiento3 As Button
    Friend WithEvents BtnCapacidad2 As Button
    Friend WithEvents BtnMonitoreo2 As Button
    Friend WithEvents BtnFuentesAgua2 As Button
    Friend WithEvents lblAlmacenamientoIcone As Label
    Friend WithEvents IconfuentesAGUA As Label
    Friend WithEvents BtnAlmacenamiento2 As Button
    Friend WithEvents Lbltrata As Label
    Friend WithEvents LblAlertas As Label
    Friend WithEvents TxbAlmacenamiento As TextBoxRedondeado
    Friend WithEvents TxbCaptacion As TextBoxRedondeado
    Friend WithEvents TxbSensores As TextBoxRedondeado
    Friend WithEvents TxbCalidad As TextBoxRedondeado
    Friend WithEvents Pnlppal As PanelRedondeado

End Class
