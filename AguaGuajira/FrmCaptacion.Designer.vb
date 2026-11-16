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
        PnlCaptacion = New PanelRedondeado()
        DgvHistorialCaptacion = New DataGridView()
        lblHistorial = New Label()
        PnlResultadoCaptacion = New PanelRedondeado()
        Lblextcalculo = New Label()
        PCVolumen = New PictureBox()
        TxtVolumen = New TextBox()
        Lbltitulovolumen = New Label()
        icon1 = New Label()
        PnlFrmCaptacion = New PanelRedondeado()
        BtnValor = New Button()
        DTFechaRegistro = New DateTimePicker()
        TxtFcRegistro = New Label()
        TxtCoeficiente = New TextBox()
        txCoeficientec = New Label()
        txtRegistroCap = New Label()
        Icnregistro = New Label()
        lblAreaCaptacion = New Label()
        txareacap = New TextBox()
        lbPrecipitacion = New Label()
        TxtPrecipitacion = New TextBox()
        LblSubtituloCaptacion = New Label()
        LblTituloFormulario = New Label()
        lblInicio = New Label()
        PnlCaptacion.SuspendLayout()
        CType(DgvHistorialCaptacion, ComponentModel.ISupportInitialize).BeginInit()
        PnlResultadoCaptacion.SuspendLayout()
        CType(PCVolumen, ComponentModel.ISupportInitialize).BeginInit()
        PnlFrmCaptacion.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlCaptacion
        ' 
        PnlCaptacion.AutoScroll = True
        PnlCaptacion.Controls.Add(DgvHistorialCaptacion)
        PnlCaptacion.Controls.Add(lblHistorial)
        PnlCaptacion.Controls.Add(PnlResultadoCaptacion)
        PnlCaptacion.Controls.Add(icon1)
        PnlCaptacion.Controls.Add(PnlFrmCaptacion)
        PnlCaptacion.Controls.Add(LblSubtituloCaptacion)
        PnlCaptacion.Controls.Add(LblTituloFormulario)
        PnlCaptacion.Controls.Add(lblInicio)
        PnlCaptacion.Dock = DockStyle.Fill
        PnlCaptacion.Location = New Point(0, 0)
        PnlCaptacion.Name = "PnlCaptacion"
        PnlCaptacion.RadioEsquinas = 1
        PnlCaptacion.Size = New Size(800, 450)
        PnlCaptacion.TabIndex = 8
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
        DgvHistorialCaptacion.Location = New Point(30, 385)
        DgvHistorialCaptacion.MultiSelect = False
        DgvHistorialCaptacion.Name = "DgvHistorialCaptacion"
        DgvHistorialCaptacion.ReadOnly = True
        DgvHistorialCaptacion.RowHeadersVisible = False
        DgvHistorialCaptacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvHistorialCaptacion.Size = New Size(917, 150)
        DgvHistorialCaptacion.TabIndex = 6
        ' 
        ' lblHistorial
        ' 
        lblHistorial.AutoSize = True
        lblHistorial.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHistorial.Location = New Point(30, 340)
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
        PnlResultadoCaptacion.Size = New Size(329, 243)
        PnlResultadoCaptacion.TabIndex = 3
        ' 
        ' Lblextcalculo
        ' 
        Lblextcalculo.AutoSize = True
        Lblextcalculo.Font = New Font("Segoe UI", 9.75F)
        Lblextcalculo.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        Lblextcalculo.Location = New Point(127, 217)
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
        PCVolumen.Location = New Point(79, 17)
        PCVolumen.Name = "PCVolumen"
        PCVolumen.Size = New Size(172, 121)
        PCVolumen.SizeMode = PictureBoxSizeMode.Zoom
        PCVolumen.TabIndex = 12
        PCVolumen.TabStop = False
        ' 
        ' TxtVolumen
        ' 
        TxtVolumen.BackColor = Color.Thistle
        TxtVolumen.BorderStyle = BorderStyle.None
        TxtVolumen.Enabled = False
        TxtVolumen.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        TxtVolumen.ForeColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        TxtVolumen.Location = New Point(16, 168)
        TxtVolumen.Multiline = True
        TxtVolumen.Name = "TxtVolumen"
        TxtVolumen.ReadOnly = True
        TxtVolumen.RightToLeft = RightToLeft.No
        TxtVolumen.Size = New Size(295, 49)
        TxtVolumen.TabIndex = 11
        TxtVolumen.Text = "--L"
        TxtVolumen.TextAlign = HorizontalAlignment.Center
        ' 
        ' Lbltitulovolumen
        ' 
        Lbltitulovolumen.AutoSize = True
        Lbltitulovolumen.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbltitulovolumen.ForeColor = Color.FromArgb(CByte(81), CByte(75), CByte(145))
        Lbltitulovolumen.Location = New Point(92, 141)
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
        icon1.Location = New Point(6, 17)
        icon1.Name = "icon1"
        icon1.Size = New Size(52, 36)
        icon1.TabIndex = 2
        icon1.Text = "🌧️"
        icon1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PnlFrmCaptacion
        ' 
        PnlFrmCaptacion.BackColor = Color.White
        PnlFrmCaptacion.Controls.Add(BtnValor)
        PnlFrmCaptacion.Controls.Add(DTFechaRegistro)
        PnlFrmCaptacion.Controls.Add(TxtFcRegistro)
        PnlFrmCaptacion.Controls.Add(TxtCoeficiente)
        PnlFrmCaptacion.Controls.Add(txCoeficientec)
        PnlFrmCaptacion.Controls.Add(txtRegistroCap)
        PnlFrmCaptacion.Controls.Add(Icnregistro)
        PnlFrmCaptacion.Controls.Add(lblAreaCaptacion)
        PnlFrmCaptacion.Controls.Add(txareacap)
        PnlFrmCaptacion.Controls.Add(lbPrecipitacion)
        PnlFrmCaptacion.Controls.Add(TxtPrecipitacion)
        PnlFrmCaptacion.Location = New Point(27, 80)
        PnlFrmCaptacion.Name = "PnlFrmCaptacion"
        PnlFrmCaptacion.Size = New Size(531, 243)
        PnlFrmCaptacion.TabIndex = 1
        ' 
        ' BtnValor
        ' 
        BtnValor.BackColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnValor.FlatStyle = FlatStyle.Flat
        BtnValor.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnValor.ForeColor = Color.White
        BtnValor.Location = New Point(195, 194)
        BtnValor.Name = "BtnValor"
        BtnValor.Size = New Size(75, 23)
        BtnValor.TabIndex = 10
        BtnValor.Text = "Calcular Registro"
        BtnValor.UseVisualStyleBackColor = False
        ' 
        ' DTFechaRegistro
        ' 
        DTFechaRegistro.CustomFormat = "dd/MM/yyyy"
        DTFechaRegistro.Format = DateTimePickerFormat.Short
        DTFechaRegistro.Location = New Point(290, 151)
        DTFechaRegistro.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        DTFechaRegistro.Name = "DTFechaRegistro"
        DTFechaRegistro.Size = New Size(130, 23)
        DTFechaRegistro.TabIndex = 9
        DTFechaRegistro.Value = New Date(2026, 11, 14, 10, 25, 31, 0)
        ' 
        ' TxtFcRegistro
        ' 
        TxtFcRegistro.AutoSize = True
        TxtFcRegistro.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        TxtFcRegistro.Location = New Point(290, 122)
        TxtFcRegistro.Name = "TxtFcRegistro"
        TxtFcRegistro.Size = New Size(113, 17)
        TxtFcRegistro.TabIndex = 8
        TxtFcRegistro.Text = "Fecha de registro"
        TxtFcRegistro.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' TxtCoeficiente
        ' 
        TxtCoeficiente.Location = New Point(41, 151)
        TxtCoeficiente.Name = "TxtCoeficiente"
        TxtCoeficiente.Size = New Size(130, 23)
        TxtCoeficiente.TabIndex = 7
        TxtCoeficiente.Text = "0,80"
        ' 
        ' txCoeficientec
        ' 
        txCoeficientec.AutoSize = True
        txCoeficientec.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        txCoeficientec.Location = New Point(38, 130)
        txCoeficientec.Name = "txCoeficientec"
        txCoeficientec.Size = New Size(151, 17)
        txCoeficientec.TabIndex = 6
        txCoeficientec.Text = "Coeficiente de eficiencia"
        ' 
        ' txtRegistroCap
        ' 
        txtRegistroCap.AutoSize = True
        txtRegistroCap.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        Icnregistro.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        lblAreaCaptacion.Location = New Point(292, 64)
        lblAreaCaptacion.Name = "lblAreaCaptacion"
        lblAreaCaptacion.Size = New Size(148, 17)
        lblAreaCaptacion.TabIndex = 4
        lblAreaCaptacion.Text = "Area de Captación (m²)"
        ' 
        ' txareacap
        ' 
        txareacap.Location = New Point(290, 82)
        txareacap.Name = "txareacap"
        txareacap.Size = New Size(130, 23)
        txareacap.TabIndex = 3
        txareacap.Text = "100"
        ' 
        ' lbPrecipitacion
        ' 
        lbPrecipitacion.AutoSize = True
        lbPrecipitacion.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        lbPrecipitacion.Location = New Point(44, 64)
        lbPrecipitacion.Name = "lbPrecipitacion"
        lbPrecipitacion.Size = New Size(125, 17)
        lbPrecipitacion.TabIndex = 1
        lbPrecipitacion.Text = "Precipitacion  (mm)"
        ' 
        ' TxtPrecipitacion
        ' 
        TxtPrecipitacion.Location = New Point(38, 89)
        TxtPrecipitacion.Name = "TxtPrecipitacion"
        TxtPrecipitacion.Size = New Size(130, 23)
        TxtPrecipitacion.TabIndex = 0
        TxtPrecipitacion.Text = "25"
        ' 
        ' LblSubtituloCaptacion
        ' 
        LblSubtituloCaptacion.AutoSize = True
        LblSubtituloCaptacion.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSubtituloCaptacion.ForeColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        LblSubtituloCaptacion.Location = New Point(58, 38)
        LblSubtituloCaptacion.Name = "LblSubtituloCaptacion"
        LblSubtituloCaptacion.Size = New Size(292, 15)
        LblSubtituloCaptacion.TabIndex = 0
        LblSubtituloCaptacion.Text = "Registro y cálculo de recolección de agua lluvia"
        ' 
        ' LblTituloFormulario
        ' 
        LblTituloFormulario.AutoSize = True
        LblTituloFormulario.Font = New Font("Bauhaus 93", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTituloFormulario.ForeColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        LblTituloFormulario.Location = New Point(54, 12)
        LblTituloFormulario.Name = "LblTituloFormulario"
        LblTituloFormulario.Size = New Size(245, 28)
        LblTituloFormulario.TabIndex = 0
        LblTituloFormulario.Text = "Captación del agua"
        ' 
        ' lblInicio
        ' 
        lblInicio.AutoSize = True
        lblInicio.Font = New Font("Bauhaus 93", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInicio.ForeColor = Color.FromArgb(CByte(41), CByte(38), CByte(79))
        lblInicio.Location = New Point(55, 12)
        lblInicio.Name = "lblInicio"
        lblInicio.Size = New Size(79, 28)
        lblInicio.TabIndex = 4
        lblInicio.Text = "Inicio"
        ' 
        ' FrmCaptacion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PnlCaptacion)
        Name = "FrmCaptacion"
        Text = "FrmCaptacion"
        PnlCaptacion.ResumeLayout(False)
        PnlCaptacion.PerformLayout()
        CType(DgvHistorialCaptacion, ComponentModel.ISupportInitialize).EndInit()
        PnlResultadoCaptacion.ResumeLayout(False)
        PnlResultadoCaptacion.PerformLayout()
        CType(PCVolumen, ComponentModel.ISupportInitialize).EndInit()
        PnlFrmCaptacion.ResumeLayout(False)
        PnlFrmCaptacion.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PnlCaptacion As PanelRedondeado
    Friend WithEvents DgvHistorialCaptacion As DataGridView
    Friend WithEvents lblHistorial As Label
    Friend WithEvents PnlResultadoCaptacion As PanelRedondeado
    Protected WithEvents Lblextcalculo As Label
    Friend WithEvents PCVolumen As PictureBox
    Friend WithEvents TxtVolumen As TextBox
    Friend WithEvents Lbltitulovolumen As Label
    Friend WithEvents icon1 As Label
    Friend WithEvents PnlFrmCaptacion As PanelRedondeado
    Friend WithEvents BtnValor As Button
    Friend WithEvents DTFechaRegistro As DateTimePicker
    Friend WithEvents TxtFcRegistro As Label
    Friend WithEvents TxtCoeficiente As TextBox
    Friend WithEvents txCoeficientec As Label
    Friend WithEvents txtRegistroCap As Label
    Friend WithEvents Icnregistro As Label
    Friend WithEvents lblAreaCaptacion As Label
    Friend WithEvents txareacap As TextBox
    Friend WithEvents lbPrecipitacion As Label
    Friend WithEvents TxtPrecipitacion As TextBox
    Friend WithEvents LblSubtituloCaptacion As Label
    Friend WithEvents LblTituloFormulario As Label
    Friend WithEvents lblInicio As Label
End Class
