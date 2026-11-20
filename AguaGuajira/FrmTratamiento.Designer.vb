<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTratamiento
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
        LblTratamiento = New Label()
        LblSubtratamiento = New Label()
        PnlAguaRecibida = New PanelRedondeado()
        TxtAguaRecibida = New TextBoxRedondeado()
        lblVolumenentrada = New Label()
        LblAguaRecibida = New Label()
        PnlFiltracion = New PanelRedondeado()
        LblsubFiltracion = New Label()
        LblFiltracion = New Label()
        LblValorFiltracion = New Label()
        PnlDesinfeccion = New PanelRedondeado()
        Label1 = New Label()
        LblDesinfeccion = New Label()
        LblEstadosodiss = New Label()
        PnlResultado = New PanelRedondeado()
        Label2 = New Label()
        lblResultado = New Label()
        lblvalorResultado = New Label()
        PnlRegistro = New PanelRedondeado()
        CmbLote = New ComboBox()
        LblLote = New Label()
        TxtObservacionesT = New TextBoxRedondeado()
        LblObservaciones = New Label()
        CmbProceso = New ComboBox()
        BtnRegistro = New Button()
        TxtVolumen = New TextBoxRedondeado()
        DtFechaRegistro = New DateTimePicker()
        LblProceso = New Label()
        LblVolumen = New Label()
        LblFechaRegistro = New Label()
        LblRegistrodelTratamiento = New Label()
        PnlTratamiento = New PanelRedondeado()
        LblHistoriaTratamiento = New Label()
        DgvHistorialTratamiento = New DataGridView()
        PnlAguaRecibida.SuspendLayout()
        PnlFiltracion.SuspendLayout()
        PnlDesinfeccion.SuspendLayout()
        PnlResultado.SuspendLayout()
        PnlRegistro.SuspendLayout()
        PnlTratamiento.SuspendLayout()
        CType(DgvHistorialTratamiento, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblTratamiento
        ' 
        LblTratamiento.AutoSize = True
        LblTratamiento.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTratamiento.Location = New Point(29, 48)
        LblTratamiento.Name = "LblTratamiento"
        LblTratamiento.Size = New Size(216, 25)
        LblTratamiento.TabIndex = 0
        LblTratamiento.Text = "🌊 Tratamiento del agua"
        ' 
        ' LblSubtratamiento
        ' 
        LblSubtratamiento.AutoSize = True
        LblSubtratamiento.Location = New Point(31, 85)
        LblSubtratamiento.Name = "LblSubtratamiento"
        LblSubtratamiento.Size = New Size(302, 15)
        LblSubtratamiento.TabIndex = 1
        LblSubtratamiento.Text = "Control y seguimiento de los procesos de potabilización" & vbCrLf
        ' 
        ' PnlAguaRecibida
        ' 
        PnlAguaRecibida.BackColor = Color.White
        PnlAguaRecibida.Controls.Add(TxtAguaRecibida)
        PnlAguaRecibida.Controls.Add(lblVolumenentrada)
        PnlAguaRecibida.Controls.Add(LblAguaRecibida)
        PnlAguaRecibida.Location = New Point(40, 135)
        PnlAguaRecibida.Name = "PnlAguaRecibida"
        PnlAguaRecibida.Size = New Size(179, 107)
        PnlAguaRecibida.TabIndex = 2
        ' 
        ' TxtAguaRecibida
        ' 
        TxtAguaRecibida.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TxtAguaRecibida.BackColor = Color.White
        TxtAguaRecibida.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtAguaRecibida.Enabled = False
        TxtAguaRecibida.GrosorBorde = 1.5F
        TxtAguaRecibida.Location = New Point(23, 44)
        TxtAguaRecibida.Multiline = False
        TxtAguaRecibida.Name = "TxtAguaRecibida"
        TxtAguaRecibida.Padding = New Padding(10, 5, 10, 5)
        TxtAguaRecibida.RadioEsquinas = 12
        TxtAguaRecibida.ScrollBars = ScrollBars.Vertical
        TxtAguaRecibida.Size = New Size(128, 30)
        TxtAguaRecibida.TabIndex = 4
        TxtAguaRecibida.Visible = False
        TxtAguaRecibida.WordWrap = True
        ' 
        ' lblVolumenentrada
        ' 
        lblVolumenentrada.AutoSize = True
        lblVolumenentrada.Location = New Point(31, 86)
        lblVolumenentrada.Name = "lblVolumenentrada"
        lblVolumenentrada.Size = New Size(113, 15)
        lblVolumenentrada.TabIndex = 3
        lblVolumenentrada.Text = "Volumen de entrada"
        ' 
        ' LblAguaRecibida
        ' 
        LblAguaRecibida.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblAguaRecibida.Location = New Point(35, 11)
        LblAguaRecibida.Name = "LblAguaRecibida"
        LblAguaRecibida.Size = New Size(109, 21)
        LblAguaRecibida.TabIndex = 2
        LblAguaRecibida.Text = "Agua Recibida"
        ' 
        ' PnlFiltracion
        ' 
        PnlFiltracion.BackColor = Color.White
        PnlFiltracion.Controls.Add(LblsubFiltracion)
        PnlFiltracion.Controls.Add(LblFiltracion)
        PnlFiltracion.Controls.Add(LblValorFiltracion)
        PnlFiltracion.Location = New Point(240, 135)
        PnlFiltracion.Name = "PnlFiltracion"
        PnlFiltracion.Size = New Size(179, 107)
        PnlFiltracion.TabIndex = 4
        ' 
        ' LblsubFiltracion
        ' 
        LblsubFiltracion.AutoSize = True
        LblsubFiltracion.Location = New Point(38, 87)
        LblsubFiltracion.Name = "LblsubFiltracion"
        LblsubFiltracion.Size = New Size(106, 15)
        LblsubFiltracion.TabIndex = 3
        LblsubFiltracion.Text = "Estado del proceso"
        ' 
        ' LblFiltracion
        ' 
        LblFiltracion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblFiltracion.Location = New Point(52, 15)
        LblFiltracion.Name = "LblFiltracion"
        LblFiltracion.Size = New Size(74, 21)
        LblFiltracion.TabIndex = 2
        LblFiltracion.Text = "Filtración"
        ' 
        ' LblValorFiltracion
        ' 
        LblValorFiltracion.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblValorFiltracion.Location = New Point(43, 48)
        LblValorFiltracion.Name = "LblValorFiltracion"
        LblValorFiltracion.Size = New Size(101, 25)
        LblValorFiltracion.TabIndex = 1
        LblValorFiltracion.Text = "Pendiente"
        ' 
        ' PnlDesinfeccion
        ' 
        PnlDesinfeccion.BackColor = Color.White
        PnlDesinfeccion.Controls.Add(Label1)
        PnlDesinfeccion.Controls.Add(LblDesinfeccion)
        PnlDesinfeccion.Controls.Add(LblEstadosodiss)
        PnlDesinfeccion.Location = New Point(240, 269)
        PnlDesinfeccion.Name = "PnlDesinfeccion"
        PnlDesinfeccion.Size = New Size(179, 107)
        PnlDesinfeccion.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 15)
        Label1.TabIndex = 3
        Label1.Text = "Estado del proceso"
        ' 
        ' LblDesinfeccion
        ' 
        LblDesinfeccion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblDesinfeccion.Location = New Point(17, 11)
        LblDesinfeccion.Name = "LblDesinfeccion"
        LblDesinfeccion.Size = New Size(147, 21)
        LblDesinfeccion.TabIndex = 2
        LblDesinfeccion.Text = "Desinfección SODIS"
        ' 
        ' LblEstadosodiss
        ' 
        LblEstadosodiss.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblEstadosodiss.Location = New Point(43, 44)
        LblEstadosodiss.Name = "LblEstadosodiss"
        LblEstadosodiss.Size = New Size(101, 25)
        LblEstadosodiss.TabIndex = 1
        LblEstadosodiss.Text = "Pendiente"
        ' 
        ' PnlResultado
        ' 
        PnlResultado.BackColor = Color.White
        PnlResultado.Controls.Add(Label2)
        PnlResultado.Controls.Add(lblResultado)
        PnlResultado.Controls.Add(lblvalorResultado)
        PnlResultado.Location = New Point(40, 269)
        PnlResultado.Name = "PnlResultado"
        PnlResultado.Size = New Size(179, 107)
        PnlResultado.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 15)
        Label2.TabIndex = 3
        Label2.Text = "Control del tratamiento"
        ' 
        ' lblResultado
        ' 
        lblResultado.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResultado.Location = New Point(52, 14)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(79, 21)
        lblResultado.TabIndex = 2
        lblResultado.Text = "Resultado"
        ' 
        ' lblvalorResultado
        ' 
        lblvalorResultado.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblvalorResultado.Location = New Point(34, 48)
        lblvalorResultado.Name = "lblvalorResultado"
        lblvalorResultado.Size = New Size(110, 25)
        lblvalorResultado.TabIndex = 1
        lblvalorResultado.Text = "Sin Evaluar"
        ' 
        ' PnlRegistro
        ' 
        PnlRegistro.BackColor = Color.White
        PnlRegistro.Controls.Add(CmbLote)
        PnlRegistro.Controls.Add(LblLote)
        PnlRegistro.Controls.Add(TxtObservacionesT)
        PnlRegistro.Controls.Add(LblObservaciones)
        PnlRegistro.Controls.Add(CmbProceso)
        PnlRegistro.Controls.Add(BtnRegistro)
        PnlRegistro.Controls.Add(TxtVolumen)
        PnlRegistro.Controls.Add(DtFechaRegistro)
        PnlRegistro.Controls.Add(LblProceso)
        PnlRegistro.Controls.Add(LblVolumen)
        PnlRegistro.Controls.Add(LblFechaRegistro)
        PnlRegistro.Controls.Add(LblRegistrodelTratamiento)
        PnlRegistro.Location = New Point(455, 97)
        PnlRegistro.Name = "PnlRegistro"
        PnlRegistro.Size = New Size(357, 313)
        PnlRegistro.TabIndex = 6
        ' 
        ' CmbLote
        ' 
        CmbLote.DropDownStyle = ComboBoxStyle.DropDownList
        CmbLote.FormattingEnabled = True
        CmbLote.Items.AddRange(New Object() {"Filtración lenta en arena", "Desinfección solar SODIS"})
        CmbLote.Location = New Point(179, 66)
        CmbLote.Name = "CmbLote"
        CmbLote.Size = New Size(143, 23)
        CmbLote.TabIndex = 12
        ' 
        ' LblLote
        ' 
        LblLote.AutoSize = True
        LblLote.Location = New Point(103, 69)
        LblLote.Name = "LblLote"
        LblLote.Size = New Size(30, 15)
        LblLote.TabIndex = 11
        LblLote.Text = "Lote"
        ' 
        ' TxtObservacionesT
        ' 
        TxtObservacionesT.BackColor = Color.White
        TxtObservacionesT.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtObservacionesT.GrosorBorde = 1.5F
        TxtObservacionesT.Location = New Point(136, 236)
        TxtObservacionesT.Multiline = True
        TxtObservacionesT.Name = "TxtObservacionesT"
        TxtObservacionesT.Padding = New Padding(10, 5, 10, 5)
        TxtObservacionesT.RadioEsquinas = 12
        TxtObservacionesT.ScrollBars = ScrollBars.Vertical
        TxtObservacionesT.Size = New Size(186, 31)
        TxtObservacionesT.TabIndex = 10
        TxtObservacionesT.WordWrap = True
        ' 
        ' LblObservaciones
        ' 
        LblObservaciones.AutoSize = True
        LblObservaciones.Location = New Point(34, 236)
        LblObservaciones.Name = "LblObservaciones"
        LblObservaciones.Size = New Size(84, 15)
        LblObservaciones.TabIndex = 9
        LblObservaciones.Text = "Observaciones"
        ' 
        ' CmbProceso
        ' 
        CmbProceso.FormattingEnabled = True
        CmbProceso.Items.AddRange(New Object() {"Filtración lenta en arena", "Desinfección solar SODIS"})
        CmbProceso.Location = New Point(179, 197)
        CmbProceso.Name = "CmbProceso"
        CmbProceso.Size = New Size(143, 23)
        CmbProceso.TabIndex = 8
        ' 
        ' BtnRegistro
        ' 
        BtnRegistro.BackColor = Color.White
        BtnRegistro.Location = New Point(68, 273)
        BtnRegistro.Name = "BtnRegistro"
        BtnRegistro.Size = New Size(193, 23)
        BtnRegistro.TabIndex = 7
        BtnRegistro.Text = "Registrar Tratamiento"
        BtnRegistro.UseVisualStyleBackColor = False
        ' 
        ' TxtVolumen
        ' 
        TxtVolumen.BackColor = Color.White
        TxtVolumen.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtVolumen.GrosorBorde = 1.5F
        TxtVolumen.Location = New Point(179, 157)
        TxtVolumen.Multiline = False
        TxtVolumen.Name = "TxtVolumen"
        TxtVolumen.Padding = New Padding(10, 5, 10, 5)
        TxtVolumen.RadioEsquinas = 12
        TxtVolumen.ScrollBars = ScrollBars.Vertical
        TxtVolumen.Size = New Size(143, 28)
        TxtVolumen.TabIndex = 5
        TxtVolumen.WordWrap = True
        ' 
        ' DtFechaRegistro
        ' 
        DtFechaRegistro.Format = DateTimePickerFormat.Short
        DtFechaRegistro.Location = New Point(179, 103)
        DtFechaRegistro.Name = "DtFechaRegistro"
        DtFechaRegistro.Size = New Size(144, 23)
        DtFechaRegistro.TabIndex = 4
        ' 
        ' LblProceso
        ' 
        LblProceso.AutoSize = True
        LblProceso.Location = New Point(34, 200)
        LblProceso.Name = "LblProceso"
        LblProceso.Size = New Size(99, 15)
        LblProceso.TabIndex = 3
        LblProceso.Text = "Proceso Aplicado"
        ' 
        ' LblVolumen
        ' 
        LblVolumen.AutoSize = True
        LblVolumen.Location = New Point(34, 161)
        LblVolumen.Name = "LblVolumen"
        LblVolumen.Size = New Size(139, 15)
        LblVolumen.TabIndex = 2
        LblVolumen.Text = "Volumen de agua a tratar"
        ' 
        ' LblFechaRegistro
        ' 
        LblFechaRegistro.AutoSize = True
        LblFechaRegistro.Location = New Point(34, 112)
        LblFechaRegistro.Name = "LblFechaRegistro"
        LblFechaRegistro.Size = New Size(100, 15)
        LblFechaRegistro.TabIndex = 1
        LblFechaRegistro.Text = "Fecha de Registro"
        ' 
        ' LblRegistrodelTratamiento
        ' 
        LblRegistrodelTratamiento.AutoSize = True
        LblRegistrodelTratamiento.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblRegistrodelTratamiento.Location = New Point(34, 19)
        LblRegistrodelTratamiento.Name = "LblRegistrodelTratamiento"
        LblRegistrodelTratamiento.Size = New Size(228, 25)
        LblRegistrodelTratamiento.TabIndex = 0
        LblRegistrodelTratamiento.Text = "Registro del tratamiento"
        ' 
        ' PnlTratamiento
        ' 
        PnlTratamiento.AutoScroll = True
        PnlTratamiento.AutoSize = True
        PnlTratamiento.BackColor = Color.White
        PnlTratamiento.Controls.Add(LblHistoriaTratamiento)
        PnlTratamiento.Controls.Add(DgvHistorialTratamiento)
        PnlTratamiento.Location = New Point(29, 416)
        PnlTratamiento.Name = "PnlTratamiento"
        PnlTratamiento.RadioEsquinas = 18
        PnlTratamiento.Size = New Size(783, 223)
        PnlTratamiento.TabIndex = 7
        ' 
        ' LblHistoriaTratamiento
        ' 
        LblHistoriaTratamiento.AutoSize = True
        LblHistoriaTratamiento.Location = New Point(22, 24)
        LblHistoriaTratamiento.Name = "LblHistoriaTratamiento"
        LblHistoriaTratamiento.Size = New Size(133, 15)
        LblHistoriaTratamiento.TabIndex = 1
        LblHistoriaTratamiento.Text = "Historial de Tratamiento"
        ' 
        ' DgvHistorialTratamiento
        ' 
        DgvHistorialTratamiento.AllowUserToAddRows = False
        DgvHistorialTratamiento.AllowUserToDeleteRows = False
        DgvHistorialTratamiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvHistorialTratamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvHistorialTratamiento.Location = New Point(2, 59)
        DgvHistorialTratamiento.MultiSelect = False
        DgvHistorialTratamiento.Name = "DgvHistorialTratamiento"
        DgvHistorialTratamiento.ReadOnly = True
        DgvHistorialTratamiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvHistorialTratamiento.Size = New Size(778, 161)
        DgvHistorialTratamiento.TabIndex = 0
        ' 
        ' FrmTratamiento
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(845, 758)
        Controls.Add(PnlTratamiento)
        Controls.Add(PnlRegistro)
        Controls.Add(PnlResultado)
        Controls.Add(PnlDesinfeccion)
        Controls.Add(PnlFiltracion)
        Controls.Add(PnlAguaRecibida)
        Controls.Add(LblSubtratamiento)
        Controls.Add(LblTratamiento)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmTratamiento"
        Text = "FrmTratamiento"
        PnlAguaRecibida.ResumeLayout(False)
        PnlAguaRecibida.PerformLayout()
        PnlFiltracion.ResumeLayout(False)
        PnlFiltracion.PerformLayout()
        PnlDesinfeccion.ResumeLayout(False)
        PnlDesinfeccion.PerformLayout()
        PnlResultado.ResumeLayout(False)
        PnlResultado.PerformLayout()
        PnlRegistro.ResumeLayout(False)
        PnlRegistro.PerformLayout()
        PnlTratamiento.ResumeLayout(False)
        PnlTratamiento.PerformLayout()
        CType(DgvHistorialTratamiento, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblTratamiento As Label
    Friend WithEvents LblSubtratamiento As Label
    Friend WithEvents PnlAguaRecibida As PanelRedondeado
    Friend WithEvents lblVolumenentrada As Label
    Friend WithEvents LblAguaRecibida As Label
    Friend WithEvents PnlTratamiento As PanelRedondeado
    Friend WithEvents LblsubFiltracion As Label
    Friend WithEvents LblFiltracion As Label
    Friend WithEvents LblValorFiltracion As Label
    Friend WithEvents PnlDesinfeccion As PanelRedondeado
    Friend WithEvents Label1 As Label
    Friend WithEvents LblDesinfeccion As Label
    Friend WithEvents LblEstadosodiss As Label
    Friend WithEvents PnlResultado As PanelRedondeado
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents lblvalorResultado As Label
    Friend WithEvents PnlRegistro As PanelRedondeado
    Friend WithEvents PnlFiltracion As PanelRedondeado
    Friend WithEvents LblRegistrodelTratamiento As Label
    Friend WithEvents TxtVolumen As TextBoxRedondeado
    Friend WithEvents DtFechaRegistro As DateTimePicker
    Friend WithEvents LblProceso As Label
    Friend WithEvents LblVolumen As Label
    Friend WithEvents LblFechaRegistro As Label
    Friend WithEvents BtnRegistro As Button
    Friend WithEvents TxtAguaRecibida As TextBoxRedondeado
    Friend WithEvents TxtObservacionesT As TextBoxRedondeado
    Friend WithEvents LblObservaciones As Label
    Friend WithEvents CmbProceso As ComboBox
    Friend WithEvents DgvHistorialTratamiento As DataGridView
    Friend WithEvents LblHistoriaTratamiento As Label
    Friend WithEvents CmbLote As ComboBox
    Friend WithEvents LblLote As Label
End Class
