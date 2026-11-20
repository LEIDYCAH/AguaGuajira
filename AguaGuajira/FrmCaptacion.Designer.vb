<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCaptacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCaptacion))
        DgvHistorialCaptacion = New DataGridView()
        lblHistorial = New Label()
        PnlResultadoCaptacion = New PanelRedondeado()
        Lblextcalculo = New Label()
        PCVolumen = New PictureBox()
        TxtVolumen = New TextBoxRedondeado()
        Lbltitulovolumen = New Label()
        icon1 = New Label()
        PnlFrmCaptacion = New PanelRedondeado()
        TxtPrecipitacion = New TextBoxRedondeado()
        TxtCoeficiente = New TextBoxRedondeado()
        txareacap = New TextBoxRedondeado()
        BtnValor = New Button()
        DTFechaRegistro = New DateTimePicker()
        TxtFcRegistro = New Label()
        txCoeficientec = New Label()
        txtRegistroCap = New Label()
        Icnregistro = New Label()
        lblAreaCaptacion = New Label()
        lbPrecipitacion = New Label()
        LblSubtituloCaptacion = New Label()
        LblTituloFormulario = New Label()
        TextBox1 = New TextBox()
        PnlZona = New PanelRedondeado()
        Label4 = New Label()
        PanelRedondeado2 = New PanelRedondeado()
        Lblaratotal = New Label()
        LblVolumen = New Label()
        PanelRedondeado1 = New PanelRedondeado()
        lblCapatotal = New Label()
        LblCapacidadt = New Label()
        PnlTanques = New PanelRedondeado()
        LblTanues2 = New Label()
        lblTanques = New Label()
        Cmbzona = New ComboBox()
        Label1 = New Label()
        CType(DgvHistorialCaptacion, ComponentModel.ISupportInitialize).BeginInit()
        PnlResultadoCaptacion.SuspendLayout()
        CType(PCVolumen, ComponentModel.ISupportInitialize).BeginInit()
        PnlFrmCaptacion.SuspendLayout()
        PnlZona.SuspendLayout()
        PanelRedondeado2.SuspendLayout()
        PanelRedondeado1.SuspendLayout()
        PnlTanques.SuspendLayout()
        SuspendLayout()
        ' 
        ' DgvHistorialCaptacion
        ' 
        DgvHistorialCaptacion.AllowUserToAddRows = False
        DgvHistorialCaptacion.AllowUserToDeleteRows = False
        DgvHistorialCaptacion.AllowUserToResizeRows = False
        DgvHistorialCaptacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvHistorialCaptacion.BackgroundColor = Color.White
        DgvHistorialCaptacion.BorderStyle = BorderStyle.None
        DgvHistorialCaptacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvHistorialCaptacion.Location = New Point(27, 548)
        DgvHistorialCaptacion.MultiSelect = False
        DgvHistorialCaptacion.Name = "DgvHistorialCaptacion"
        DgvHistorialCaptacion.ReadOnly = True
        DgvHistorialCaptacion.RowHeadersVisible = False
        DgvHistorialCaptacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvHistorialCaptacion.Size = New Size(935, 150)
        DgvHistorialCaptacion.TabIndex = 6
        ' 
        ' lblHistorial
        ' 
        lblHistorial.AutoSize = True
        lblHistorial.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHistorial.Location = New Point(27, 507)
        lblHistorial.Name = "lblHistorial"
        lblHistorial.Size = New Size(222, 21)
        lblHistorial.TabIndex = 5
        lblHistorial.Text = "⌛ Historial de Captaciones"
        ' 
        ' PnlResultadoCaptacion
        ' 
        PnlResultadoCaptacion.BackColor = Color.White
        PnlResultadoCaptacion.Controls.Add(Lblextcalculo)
        PnlResultadoCaptacion.Controls.Add(PCVolumen)
        PnlResultadoCaptacion.Controls.Add(TxtVolumen)
        PnlResultadoCaptacion.Controls.Add(Lbltitulovolumen)
        PnlResultadoCaptacion.Location = New Point(636, 80)
        PnlResultadoCaptacion.Name = "PnlResultadoCaptacion"
        PnlResultadoCaptacion.RadioEsquinas = 18
        PnlResultadoCaptacion.Size = New Size(329, 382)
        PnlResultadoCaptacion.TabIndex = 3
        ' 
        ' Lblextcalculo
        ' 
        Lblextcalculo.AutoSize = True
        Lblextcalculo.Font = New Font("Segoe UI", 9.75F)
        Lblextcalculo.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        Lblextcalculo.Location = New Point(148, 352)
        Lblextcalculo.Name = "Lblextcalculo"
        Lblextcalculo.Size = New Size(92, 17)
        Lblextcalculo.TabIndex = 13
        Lblextcalculo.Text = "Litros de agua"
        ' 
        ' PCVolumen
        ' 
        PCVolumen.BackColor = Color.Transparent
        PCVolumen.Enabled = False
        PCVolumen.ErrorImage = Nothing
        PCVolumen.Image = CType(resources.GetObject("PCVolumen.Image"), Image)
        PCVolumen.InitialImage = Nothing
        PCVolumen.Location = New Point(92, 27)
        PCVolumen.Name = "PCVolumen"
        PCVolumen.Size = New Size(172, 186)
        PCVolumen.SizeMode = PictureBoxSizeMode.Zoom
        PCVolumen.TabIndex = 12
        PCVolumen.TabStop = False
        ' 
        ' TxtVolumen
        ' 
        TxtVolumen.BackColor = Color.Thistle
        TxtVolumen.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtVolumen.Enabled = False
        TxtVolumen.GrosorBorde = 1.5F
        TxtVolumen.Location = New Point(18, 294)
        TxtVolumen.Multiline = False
        TxtVolumen.Name = "TxtVolumen"
        TxtVolumen.Padding = New Padding(10, 5, 10, 5)
        TxtVolumen.RadioEsquinas = 50
        TxtVolumen.RightToLeft = RightToLeft.No
        TxtVolumen.ScrollBars = ScrollBars.Vertical
        TxtVolumen.Size = New Size(295, 35)
        TxtVolumen.TabIndex = 20
        TxtVolumen.WordWrap = True
        ' 
        ' Lbltitulovolumen
        ' 
        Lbltitulovolumen.AutoSize = True
        Lbltitulovolumen.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbltitulovolumen.ForeColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        Lbltitulovolumen.Location = New Point(92, 263)
        Lbltitulovolumen.Name = "Lbltitulovolumen"
        Lbltitulovolumen.Size = New Size(159, 21)
        Lbltitulovolumen.TabIndex = 10
        Lbltitulovolumen.Text = "Volumen Calculado"
        ' 
        ' icon1
        ' 
        icon1.AutoSize = True
        icon1.BackColor = Color.Transparent
        icon1.Font = New Font("Segoe UI Emoji", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        icon1.ForeColor = Color.MediumPurple
        icon1.Location = New Point(18, 14)
        icon1.Name = "icon1"
        icon1.Size = New Size(52, 36)
        icon1.TabIndex = 2
        icon1.Text = "🌧️"
        icon1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PnlFrmCaptacion
        ' 
        PnlFrmCaptacion.AutoSize = True
        PnlFrmCaptacion.BackColor = Color.White
        PnlFrmCaptacion.Controls.Add(TxtPrecipitacion)
        PnlFrmCaptacion.Controls.Add(TxtCoeficiente)
        PnlFrmCaptacion.Controls.Add(txareacap)
        PnlFrmCaptacion.Controls.Add(BtnValor)
        PnlFrmCaptacion.Controls.Add(DTFechaRegistro)
        PnlFrmCaptacion.Controls.Add(TxtFcRegistro)
        PnlFrmCaptacion.Controls.Add(txCoeficientec)
        PnlFrmCaptacion.Controls.Add(txtRegistroCap)
        PnlFrmCaptacion.Controls.Add(Icnregistro)
        PnlFrmCaptacion.Controls.Add(lblAreaCaptacion)
        PnlFrmCaptacion.Controls.Add(lbPrecipitacion)
        PnlFrmCaptacion.Location = New Point(27, 246)
        PnlFrmCaptacion.Name = "PnlFrmCaptacion"
        PnlFrmCaptacion.Size = New Size(581, 246)
        PnlFrmCaptacion.TabIndex = 1
        ' 
        ' TxtPrecipitacion
        ' 
        TxtPrecipitacion.BackColor = Color.White
        TxtPrecipitacion.BorderStyle = BorderStyle.Fixed3D
        TxtPrecipitacion.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtPrecipitacion.GrosorBorde = 1.5F
        TxtPrecipitacion.Location = New Point(33, 92)
        TxtPrecipitacion.Multiline = False
        TxtPrecipitacion.Name = "TxtPrecipitacion"
        TxtPrecipitacion.Padding = New Padding(10, 5, 10, 5)
        TxtPrecipitacion.RadioEsquinas = 6
        TxtPrecipitacion.ScrollBars = ScrollBars.Vertical
        TxtPrecipitacion.Size = New Size(242, 30)
        TxtPrecipitacion.TabIndex = 13
        TxtPrecipitacion.WordWrap = True
        ' 
        ' TxtCoeficiente
        ' 
        TxtCoeficiente.BackColor = Color.White
        TxtCoeficiente.BorderStyle = BorderStyle.Fixed3D
        TxtCoeficiente.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtCoeficiente.GrosorBorde = 1.5F
        TxtCoeficiente.Location = New Point(29, 158)
        TxtCoeficiente.Multiline = False
        TxtCoeficiente.Name = "TxtCoeficiente"
        TxtCoeficiente.Padding = New Padding(10, 5, 10, 5)
        TxtCoeficiente.RadioEsquinas = 6
        TxtCoeficiente.ScrollBars = ScrollBars.Vertical
        TxtCoeficiente.Size = New Size(242, 30)
        TxtCoeficiente.TabIndex = 12
        TxtCoeficiente.WordWrap = True
        ' 
        ' txareacap
        ' 
        txareacap.BackColor = Color.White
        txareacap.BorderStyle = BorderStyle.Fixed3D
        txareacap.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        txareacap.GrosorBorde = 1.5F
        txareacap.Location = New Point(314, 92)
        txareacap.Multiline = False
        txareacap.Name = "txareacap"
        txareacap.Padding = New Padding(10, 5, 10, 5)
        txareacap.RadioEsquinas = 6
        txareacap.ScrollBars = ScrollBars.Vertical
        txareacap.Size = New Size(245, 30)
        txareacap.TabIndex = 11
        txareacap.WordWrap = True
        ' 
        ' BtnValor
        ' 
        BtnValor.BackColor = Color.Indigo
        BtnValor.FlatAppearance.BorderSize = 0
        BtnValor.FlatStyle = FlatStyle.Flat
        BtnValor.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnValor.ForeColor = Color.White
        BtnValor.Location = New Point(58, 201)
        BtnValor.Name = "BtnValor"
        BtnValor.Size = New Size(476, 30)
        BtnValor.TabIndex = 10
        BtnValor.Text = "Calcular Registro"
        BtnValor.UseVisualStyleBackColor = False
        ' 
        ' DTFechaRegistro
        ' 
        DTFechaRegistro.CustomFormat = "dd/MM/yyyy"
        DTFechaRegistro.Format = DateTimePickerFormat.Short
        DTFechaRegistro.Location = New Point(314, 158)
        DTFechaRegistro.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        DTFechaRegistro.Name = "DTFechaRegistro"
        DTFechaRegistro.Size = New Size(245, 23)
        DTFechaRegistro.TabIndex = 9
        DTFechaRegistro.Value = New Date(2026, 11, 14, 10, 25, 31, 0)
        ' 
        ' TxtFcRegistro
        ' 
        TxtFcRegistro.AutoSize = True
        TxtFcRegistro.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        TxtFcRegistro.Location = New Point(382, 131)
        TxtFcRegistro.Name = "TxtFcRegistro"
        TxtFcRegistro.Size = New Size(113, 17)
        TxtFcRegistro.TabIndex = 8
        TxtFcRegistro.Text = "Fecha de registro"
        TxtFcRegistro.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' txCoeficientec
        ' 
        txCoeficientec.AutoSize = True
        txCoeficientec.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        txCoeficientec.Location = New Point(46, 138)
        txCoeficientec.Name = "txCoeficientec"
        txCoeficientec.Size = New Size(151, 17)
        txCoeficientec.TabIndex = 6
        txCoeficientec.Text = "Coeficiente de eficiencia"
        ' 
        ' txtRegistroCap
        ' 
        txtRegistroCap.AutoSize = True
        txtRegistroCap.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtRegistroCap.Location = New Point(57, 26)
        txtRegistroCap.Name = "txtRegistroCap"
        txtRegistroCap.Size = New Size(154, 21)
        txtRegistroCap.TabIndex = 2
        txtRegistroCap.Text = "Registro Captación"
        ' 
        ' Icnregistro
        ' 
        Icnregistro.AutoSize = True
        Icnregistro.BackColor = Color.Transparent
        Icnregistro.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icnregistro.ForeColor = Color.Indigo
        Icnregistro.Location = New Point(23, 21)
        Icnregistro.Name = "Icnregistro"
        Icnregistro.Size = New Size(47, 32)
        Icnregistro.TabIndex = 5
        Icnregistro.Text = "📄"
        ' 
        ' lblAreaCaptacion
        ' 
        lblAreaCaptacion.AutoSize = True
        lblAreaCaptacion.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        lblAreaCaptacion.Location = New Point(367, 72)
        lblAreaCaptacion.Name = "lblAreaCaptacion"
        lblAreaCaptacion.Size = New Size(148, 17)
        lblAreaCaptacion.TabIndex = 4
        lblAreaCaptacion.Text = "Area de Captación (m²)"
        ' 
        ' lbPrecipitacion
        ' 
        lbPrecipitacion.AutoSize = True
        lbPrecipitacion.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        lbPrecipitacion.Location = New Point(53, 72)
        lbPrecipitacion.Name = "lbPrecipitacion"
        lbPrecipitacion.Size = New Size(125, 17)
        lbPrecipitacion.TabIndex = 1
        lbPrecipitacion.Text = "Precipitacion  (mm)"
        ' 
        ' LblSubtituloCaptacion
        ' 
        LblSubtituloCaptacion.AutoSize = True
        LblSubtituloCaptacion.Font = New Font("Segoe UI Black", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSubtituloCaptacion.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        LblSubtituloCaptacion.Location = New Point(60, 36)
        LblSubtituloCaptacion.Name = "LblSubtituloCaptacion"
        LblSubtituloCaptacion.Size = New Size(292, 15)
        LblSubtituloCaptacion.TabIndex = 0
        LblSubtituloCaptacion.Text = "Registro y cálculo de recolección de agua lluvia"
        ' 
        ' LblTituloFormulario
        ' 
        LblTituloFormulario.AutoSize = True
        LblTituloFormulario.Font = New Font("Bauhaus 93", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTituloFormulario.ForeColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        LblTituloFormulario.Location = New Point(58, 7)
        LblTituloFormulario.Name = "LblTituloFormulario"
        LblTituloFormulario.Size = New Size(245, 28)
        LblTituloFormulario.TabIndex = 0
        LblTituloFormulario.Text = "Captación del agua"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(640, 516)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 7
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' PnlZona
        ' 
        PnlZona.BackColor = Color.White
        PnlZona.Controls.Add(Label4)
        PnlZona.Controls.Add(PanelRedondeado2)
        PnlZona.Controls.Add(PanelRedondeado1)
        PnlZona.Controls.Add(PnlTanques)
        PnlZona.Controls.Add(Cmbzona)
        PnlZona.Controls.Add(Label1)
        PnlZona.Location = New Point(27, 80)
        PnlZona.Name = "PnlZona"
        PnlZona.Size = New Size(581, 156)
        PnlZona.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(29, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(189, 21)
        Label4.TabIndex = 14
        Label4.Text = "Destino de la captación"
        ' 
        ' PanelRedondeado2
        ' 
        PanelRedondeado2.BackColor = Color.Gainsboro
        PanelRedondeado2.BorderStyle = BorderStyle.Fixed3D
        PanelRedondeado2.Controls.Add(Lblaratotal)
        PanelRedondeado2.Controls.Add(LblVolumen)
        PanelRedondeado2.Location = New Point(402, 70)
        PanelRedondeado2.Name = "PanelRedondeado2"
        PanelRedondeado2.Size = New Size(132, 82)
        PanelRedondeado2.TabIndex = 4
        ' 
        ' Lblaratotal
        ' 
        Lblaratotal.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblaratotal.Location = New Point(11, 13)
        Lblaratotal.Name = "Lblaratotal"
        Lblaratotal.Size = New Size(100, 23)
        Lblaratotal.TabIndex = 1
        Lblaratotal.Text = "Label5"
        Lblaratotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblVolumen
        ' 
        LblVolumen.AutoSize = True
        LblVolumen.Location = New Point(30, 57)
        LblVolumen.Name = "LblVolumen"
        LblVolumen.Size = New Size(81, 15)
        LblVolumen.TabIndex = 0
        LblVolumen.Text = "Volumen total"
        ' 
        ' PanelRedondeado1
        ' 
        PanelRedondeado1.BackColor = Color.Gainsboro
        PanelRedondeado1.BorderStyle = BorderStyle.Fixed3D
        PanelRedondeado1.Controls.Add(lblCapatotal)
        PanelRedondeado1.Controls.Add(LblCapacidadt)
        PanelRedondeado1.Location = New Point(219, 68)
        PanelRedondeado1.Name = "PanelRedondeado1"
        PanelRedondeado1.Size = New Size(132, 84)
        PanelRedondeado1.TabIndex = 3
        ' 
        ' lblCapatotal
        ' 
        lblCapatotal.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCapatotal.Location = New Point(11, 13)
        lblCapatotal.Name = "lblCapatotal"
        lblCapatotal.Size = New Size(100, 23)
        lblCapatotal.TabIndex = 1
        lblCapatotal.Text = "Label3"
        lblCapatotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblCapacidadt
        ' 
        LblCapacidadt.AutoSize = True
        LblCapacidadt.Location = New Point(9, 60)
        LblCapacidadt.Name = "LblCapacidadt"
        LblCapacidadt.Size = New Size(107, 15)
        LblCapacidadt.TabIndex = 0
        LblCapacidadt.Text = "Capacidad total (L)"
        ' 
        ' PnlTanques
        ' 
        PnlTanques.BackColor = Color.Gainsboro
        PnlTanques.BorderStyle = BorderStyle.Fixed3D
        PnlTanques.Controls.Add(LblTanues2)
        PnlTanques.Controls.Add(lblTanques)
        PnlTanques.Location = New Point(32, 70)
        PnlTanques.Name = "PnlTanques"
        PnlTanques.Size = New Size(132, 82)
        PnlTanques.TabIndex = 2
        ' 
        ' LblTanues2
        ' 
        LblTanues2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTanues2.Location = New Point(11, 13)
        LblTanues2.Name = "LblTanues2"
        LblTanues2.Size = New Size(100, 23)
        LblTanues2.TabIndex = 1
        LblTanues2.Text = "Label2"
        LblTanues2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTanques
        ' 
        lblTanques.AutoSize = True
        lblTanques.Location = New Point(8, 57)
        lblTanques.Name = "lblTanques"
        lblTanques.Size = New Size(111, 15)
        lblTanques.TabIndex = 0
        lblTanques.Text = "Tanques registrados"
        ' 
        ' Cmbzona
        ' 
        Cmbzona.FormattingEnabled = True
        Cmbzona.Location = New Point(25, 38)
        Cmbzona.Name = "Cmbzona"
        Cmbzona.Size = New Size(534, 23)
        Cmbzona.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(440, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 15)
        Label1.TabIndex = 0
        Label1.Text = "Zona / Comunidad"
        ' 
        ' FrmCaptacion
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 638)
        Controls.Add(PnlZona)
        Controls.Add(TextBox1)
        Controls.Add(LblSubtituloCaptacion)
        Controls.Add(LblTituloFormulario)
        Controls.Add(icon1)
        Controls.Add(PnlFrmCaptacion)
        Controls.Add(PnlResultadoCaptacion)
        Controls.Add(DgvHistorialCaptacion)
        Controls.Add(lblHistorial)
        Name = "FrmCaptacion"
        Text = "Destino del agua captada"
        CType(DgvHistorialCaptacion, ComponentModel.ISupportInitialize).EndInit()
        PnlResultadoCaptacion.ResumeLayout(False)
        PnlResultadoCaptacion.PerformLayout()
        CType(PCVolumen, ComponentModel.ISupportInitialize).EndInit()
        PnlFrmCaptacion.ResumeLayout(False)
        PnlFrmCaptacion.PerformLayout()
        PnlZona.ResumeLayout(False)
        PnlZona.PerformLayout()
        PanelRedondeado2.ResumeLayout(False)
        PanelRedondeado2.PerformLayout()
        PanelRedondeado1.ResumeLayout(False)
        PanelRedondeado1.PerformLayout()
        PnlTanques.ResumeLayout(False)
        PnlTanques.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgvHistorialCaptacion As DataGridView
    Friend WithEvents lblHistorial As Label
    Friend WithEvents PnlResultadoCaptacion As PanelRedondeado
    Protected WithEvents Lblextcalculo As Label
    Friend WithEvents PCVolumen As PictureBox
    Friend WithEvents TxtVolumen As TextBoxRedondeado
    Friend WithEvents Lbltitulovolumen As Label
    Friend WithEvents icon1 As Label
    Friend WithEvents PnlFrmCaptacion As PanelRedondeado
    Friend WithEvents BtnValor As Button
    Friend WithEvents DTFechaRegistro As DateTimePicker
    Friend WithEvents TxtFcRegistro As Label
    Friend WithEvents txCoeficientec As Label
    Friend WithEvents txtRegistroCap As Label
    Friend WithEvents Icnregistro As Label
    Friend WithEvents lblAreaCaptacion As Label
    Friend WithEvents lbPrecipitacion As Label
    Friend WithEvents LblSubtituloCaptacion As Label
    Friend WithEvents LblTituloFormulario As Label
    Friend WithEvents txareacap As TextBoxRedondeado
    Friend WithEvents TxtPrecipitacion As TextBoxRedondeado
    Friend WithEvents TxtCoeficiente As TextBoxRedondeado
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PnlZona As PanelRedondeado
    Friend WithEvents PnlTanques As PanelRedondeado
    Friend WithEvents Cmbzona As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelRedondeado2 As PanelRedondeado
    Friend WithEvents Capatotal As Label
    Friend WithEvents Lblaratotal As Label
    Friend WithEvents PanelRedondeado1 As PanelRedondeado
    Friend WithEvents lblCapatotal As Label
    Friend WithEvents LblCapacidadt As Label
    Friend WithEvents LblTanues2 As Label
    Friend WithEvents lblTanques As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblVolumen As Label
End Class
