<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonitoreo
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        TxtTituloMonitoreo = New Label()
        LblSubMonitoreo = New Label()
        PnlCardPh = New PanelRedondeado()
        TbxPhManual = New TextBoxRedondeado()
        LblTituloNivelpH = New Label()
        LblTituloTurbidez = New Label()
        PnlTurbidez = New PanelRedondeado()
        Label2 = New Label()
        TbxTurbidezmanual = New TextBoxRedondeado()
        LblTituloTDS = New Label()
        PnlRedondeado = New PanelRedondeado()
        Label3 = New Label()
        TxbTdsManual = New TextBoxRedondeado()
        LblTituloTemperatura = New Label()
        Pnltemperatura = New PanelRedondeado()
        Label1 = New Label()
        TbxTemperaturaManual = New TextBoxRedondeado()
        PnlHistorial = New PanelRedondeado()
        LblHistorialMonitoreo = New Label()
        DtgMonitoreo = New DataGridView()
        PnlRegistroMonitoreo = New PanelRedondeado()
        PnlNombreMonitoreo = New PanelRedondeado()
        CmbSensor = New ComboBox()
        LblNombreSM = New Label()
        BtnRegistrarLectura = New Button()
        LblRegistroMonitoreo = New Label()
        ChMonitoreo = New DataVisualization.Charting.Chart()
        PnlMonitoreoSensor = New PanelRedondeado()
        LblPendientedeconexion = New Label()
        PnlSensor = New PanelRedondeado()
        LblSC0 = New Label()
        LblNombreSensor = New Label()
        PanelRedondeado3 = New PanelRedondeado()
        LblSC3 = New Label()
        LblTemperaturaSensor = New Label()
        pnlSensorTurbidez = New PanelRedondeado()
        LblSC2 = New Label()
        Lblturbidezsensor = New Label()
        LblSensores = New Label()
        pnlSensorPh = New PanelRedondeado()
        LblSC1 = New Label()
        lblsensorPH = New Label()
        PnlCardPh.SuspendLayout()
        PnlTurbidez.SuspendLayout()
        PnlRedondeado.SuspendLayout()
        Pnltemperatura.SuspendLayout()
        PnlHistorial.SuspendLayout()
        CType(DtgMonitoreo, ComponentModel.ISupportInitialize).BeginInit()
        PnlRegistroMonitoreo.SuspendLayout()
        PnlNombreMonitoreo.SuspendLayout()
        CType(ChMonitoreo, ComponentModel.ISupportInitialize).BeginInit()
        PnlMonitoreoSensor.SuspendLayout()
        PnlSensor.SuspendLayout()
        PanelRedondeado3.SuspendLayout()
        pnlSensorTurbidez.SuspendLayout()
        pnlSensorPh.SuspendLayout()
        SuspendLayout()
        ' 
        ' TxtTituloMonitoreo
        ' 
        TxtTituloMonitoreo.AutoSize = True
        TxtTituloMonitoreo.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtTituloMonitoreo.Location = New Point(55, 53)
        TxtTituloMonitoreo.Name = "TxtTituloMonitoreo"
        TxtTituloMonitoreo.Size = New Size(127, 32)
        TxtTituloMonitoreo.TabIndex = 0
        TxtTituloMonitoreo.Text = "Monitoreo"
        ' 
        ' LblSubMonitoreo
        ' 
        LblSubMonitoreo.AutoSize = True
        LblSubMonitoreo.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSubMonitoreo.Location = New Point(57, 90)
        LblSubMonitoreo.Name = "LblSubMonitoreo"
        LblSubMonitoreo.Size = New Size(321, 17)
        LblSubMonitoreo.TabIndex = 1
        LblSubMonitoreo.Text = "Supervisión de parámetros y lecturas de los sensores"
        ' 
        ' PnlCardPh
        ' 
        PnlCardPh.BackColor = Color.Lavender
        PnlCardPh.BorderStyle = BorderStyle.Fixed3D
        PnlCardPh.Controls.Add(TbxPhManual)
        PnlCardPh.Controls.Add(LblTituloNivelpH)
        PnlCardPh.Location = New Point(75, 95)
        PnlCardPh.Name = "PnlCardPh"
        PnlCardPh.Size = New Size(180, 109)
        PnlCardPh.TabIndex = 2
        ' 
        ' TbxPhManual
        ' 
        TbxPhManual.BackColor = Color.White
        TbxPhManual.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TbxPhManual.GrosorBorde = 1.5F
        TbxPhManual.Location = New Point(18, 49)
        TbxPhManual.Multiline = False
        TbxPhManual.Name = "TbxPhManual"
        TbxPhManual.Padding = New Padding(10, 5, 10, 5)
        TbxPhManual.RadioEsquinas = 12
        TbxPhManual.ScrollBars = ScrollBars.Vertical
        TbxPhManual.Size = New Size(139, 34)
        TbxPhManual.TabIndex = 1
        TbxPhManual.WordWrap = True
        ' 
        ' LblTituloNivelpH
        ' 
        LblTituloNivelpH.AutoSize = True
        LblTituloNivelpH.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTituloNivelpH.Location = New Point(47, 14)
        LblTituloNivelpH.Name = "LblTituloNivelpH"
        LblTituloNivelpH.Size = New Size(91, 21)
        LblTituloNivelpH.TabIndex = 0
        LblTituloNivelpH.Text = "Nivel de pH"
        ' 
        ' LblTituloTurbidez
        ' 
        LblTituloTurbidez.AutoSize = True
        LblTituloTurbidez.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTituloTurbidez.Location = New Point(54, 12)
        LblTituloTurbidez.Name = "LblTituloTurbidez"
        LblTituloTurbidez.Size = New Size(70, 21)
        LblTituloTurbidez.TabIndex = 0
        LblTituloTurbidez.Text = "Turbidez"
        ' 
        ' PnlTurbidez
        ' 
        PnlTurbidez.BackColor = Color.Lavender
        PnlTurbidez.BorderStyle = BorderStyle.Fixed3D
        PnlTurbidez.Controls.Add(Label2)
        PnlTurbidez.Controls.Add(TbxTurbidezmanual)
        PnlTurbidez.Controls.Add(LblTituloTurbidez)
        PnlTurbidez.Location = New Point(510, 95)
        PnlTurbidez.Name = "PnlTurbidez"
        PnlTurbidez.Size = New Size(180, 119)
        PnlTurbidez.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(54, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 3
        Label2.Text = "TDS (ppm)"
        ' 
        ' TbxTurbidezmanual
        ' 
        TbxTurbidezmanual.BackColor = Color.White
        TbxTurbidezmanual.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TbxTurbidezmanual.GrosorBorde = 1.5F
        TbxTurbidezmanual.Location = New Point(21, 49)
        TbxTurbidezmanual.Multiline = False
        TbxTurbidezmanual.Name = "TbxTurbidezmanual"
        TbxTurbidezmanual.Padding = New Padding(10, 5, 10, 5)
        TbxTurbidezmanual.RadioEsquinas = 12
        TbxTurbidezmanual.ScrollBars = ScrollBars.Vertical
        TbxTurbidezmanual.Size = New Size(139, 34)
        TbxTurbidezmanual.TabIndex = 2
        TbxTurbidezmanual.WordWrap = True
        ' 
        ' LblTituloTDS
        ' 
        LblTituloTDS.AutoSize = True
        LblTituloTDS.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTituloTDS.Location = New Point(69, 12)
        LblTituloTDS.Name = "LblTituloTDS"
        LblTituloTDS.Size = New Size(38, 21)
        LblTituloTDS.TabIndex = 0
        LblTituloTDS.Text = "TDS"
        ' 
        ' PnlRedondeado
        ' 
        PnlRedondeado.BackColor = Color.Lavender
        PnlRedondeado.BorderStyle = BorderStyle.Fixed3D
        PnlRedondeado.Controls.Add(Label3)
        PnlRedondeado.Controls.Add(TxbTdsManual)
        PnlRedondeado.Controls.Add(LblTituloTDS)
        PnlRedondeado.Location = New Point(291, 95)
        PnlRedondeado.Name = "PnlRedondeado"
        PnlRedondeado.Size = New Size(180, 109)
        PnlRedondeado.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(71, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 3
        Label3.Text = "(NTU)"
        ' 
        ' TxbTdsManual
        ' 
        TxbTdsManual.BackColor = Color.White
        TxbTdsManual.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxbTdsManual.GrosorBorde = 1.5F
        TxbTdsManual.Location = New Point(22, 49)
        TxbTdsManual.Multiline = False
        TxbTdsManual.Name = "TxbTdsManual"
        TxbTdsManual.Padding = New Padding(10, 5, 10, 5)
        TxbTdsManual.RadioEsquinas = 12
        TxbTdsManual.ScrollBars = ScrollBars.Vertical
        TxbTdsManual.Size = New Size(139, 34)
        TxbTdsManual.TabIndex = 2
        TxbTdsManual.WordWrap = True
        ' 
        ' LblTituloTemperatura
        ' 
        LblTituloTemperatura.AutoSize = True
        LblTituloTemperatura.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTituloTemperatura.Location = New Point(42, 14)
        LblTituloTemperatura.Name = "LblTituloTemperatura"
        LblTituloTemperatura.Size = New Size(97, 21)
        LblTituloTemperatura.TabIndex = 0
        LblTituloTemperatura.Text = "Temperatura"
        ' 
        ' Pnltemperatura
        ' 
        Pnltemperatura.BackColor = Color.Lavender
        Pnltemperatura.BorderStyle = BorderStyle.Fixed3D
        Pnltemperatura.Controls.Add(Label1)
        Pnltemperatura.Controls.Add(TbxTemperaturaManual)
        Pnltemperatura.Controls.Add(LblTituloTemperatura)
        Pnltemperatura.Location = New Point(730, 95)
        Pnltemperatura.Name = "Pnltemperatura"
        Pnltemperatura.Size = New Size(180, 119)
        Pnltemperatura.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(69, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 15)
        Label1.TabIndex = 3
        Label1.Text = "(°C)"
        ' 
        ' TbxTemperaturaManual
        ' 
        TbxTemperaturaManual.BackColor = Color.White
        TbxTemperaturaManual.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TbxTemperaturaManual.GrosorBorde = 1.5F
        TbxTemperaturaManual.Location = New Point(24, 49)
        TbxTemperaturaManual.Multiline = False
        TbxTemperaturaManual.Name = "TbxTemperaturaManual"
        TbxTemperaturaManual.Padding = New Padding(10, 5, 10, 5)
        TbxTemperaturaManual.RadioEsquinas = 12
        TbxTemperaturaManual.ScrollBars = ScrollBars.Vertical
        TbxTemperaturaManual.Size = New Size(139, 34)
        TbxTemperaturaManual.TabIndex = 2
        TbxTemperaturaManual.WordWrap = True
        ' 
        ' PnlHistorial
        ' 
        PnlHistorial.AutoSize = True
        PnlHistorial.BackColor = Color.White
        PnlHistorial.Controls.Add(LblHistorialMonitoreo)
        PnlHistorial.Controls.Add(DtgMonitoreo)
        PnlHistorial.Location = New Point(55, 596)
        PnlHistorial.Name = "PnlHistorial"
        PnlHistorial.Size = New Size(552, 175)
        PnlHistorial.TabIndex = 6
        ' 
        ' LblHistorialMonitoreo
        ' 
        LblHistorialMonitoreo.AutoSize = True
        LblHistorialMonitoreo.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblHistorialMonitoreo.Location = New Point(32, 17)
        LblHistorialMonitoreo.Name = "LblHistorialMonitoreo"
        LblHistorialMonitoreo.Size = New Size(171, 21)
        LblHistorialMonitoreo.TabIndex = 1
        LblHistorialMonitoreo.Text = "🕚 Historial Monitoreo"
        ' 
        ' DtgMonitoreo
        ' 
        DtgMonitoreo.AllowUserToAddRows = False
        DtgMonitoreo.AllowUserToDeleteRows = False
        DtgMonitoreo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DtgMonitoreo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DtgMonitoreo.Location = New Point(21, 55)
        DtgMonitoreo.MultiSelect = False
        DtgMonitoreo.Name = "DtgMonitoreo"
        DtgMonitoreo.ReadOnly = True
        DtgMonitoreo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DtgMonitoreo.Size = New Size(506, 117)
        DtgMonitoreo.TabIndex = 0
        ' 
        ' PnlRegistroMonitoreo
        ' 
        PnlRegistroMonitoreo.BackColor = Color.White
        PnlRegistroMonitoreo.Controls.Add(PnlNombreMonitoreo)
        PnlRegistroMonitoreo.Controls.Add(BtnRegistrarLectura)
        PnlRegistroMonitoreo.Controls.Add(Pnltemperatura)
        PnlRegistroMonitoreo.Controls.Add(LblRegistroMonitoreo)
        PnlRegistroMonitoreo.Controls.Add(PnlTurbidez)
        PnlRegistroMonitoreo.Controls.Add(PnlRedondeado)
        PnlRegistroMonitoreo.Controls.Add(PnlCardPh)
        PnlRegistroMonitoreo.Location = New Point(57, 343)
        PnlRegistroMonitoreo.Name = "PnlRegistroMonitoreo"
        PnlRegistroMonitoreo.Size = New Size(936, 235)
        PnlRegistroMonitoreo.TabIndex = 7
        ' 
        ' PnlNombreMonitoreo
        ' 
        PnlNombreMonitoreo.BackColor = Color.Lavender
        PnlNombreMonitoreo.BorderStyle = BorderStyle.Fixed3D
        PnlNombreMonitoreo.Controls.Add(CmbSensor)
        PnlNombreMonitoreo.Controls.Add(LblNombreSM)
        PnlNombreMonitoreo.Location = New Point(291, 23)
        PnlNombreMonitoreo.Name = "PnlNombreMonitoreo"
        PnlNombreMonitoreo.Size = New Size(317, 44)
        PnlNombreMonitoreo.TabIndex = 3
        ' 
        ' CmbSensor
        ' 
        CmbSensor.FormattingEnabled = True
        CmbSensor.Location = New Point(143, 11)
        CmbSensor.Name = "CmbSensor"
        CmbSensor.Size = New Size(151, 23)
        CmbSensor.TabIndex = 1
        ' 
        ' LblNombreSM
        ' 
        LblNombreSM.AutoSize = True
        LblNombreSM.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblNombreSM.Location = New Point(9, 10)
        LblNombreSM.Name = "LblNombreSM"
        LblNombreSM.Size = New Size(123, 21)
        LblNombreSM.TabIndex = 0
        LblNombreSM.Text = "Nombre Sensor:"
        ' 
        ' BtnRegistrarLectura
        ' 
        BtnRegistrarLectura.ImageAlign = ContentAlignment.BottomCenter
        BtnRegistrarLectura.Location = New Point(782, 24)
        BtnRegistrarLectura.Name = "BtnRegistrarLectura"
        BtnRegistrarLectura.Size = New Size(111, 33)
        BtnRegistrarLectura.TabIndex = 11
        BtnRegistrarLectura.Text = "Registro"
        BtnRegistrarLectura.UseVisualStyleBackColor = True
        ' 
        ' LblRegistroMonitoreo
        ' 
        LblRegistroMonitoreo.AutoSize = True
        LblRegistroMonitoreo.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblRegistroMonitoreo.Location = New Point(34, 29)
        LblRegistroMonitoreo.Name = "LblRegistroMonitoreo"
        LblRegistroMonitoreo.Size = New Size(171, 21)
        LblRegistroMonitoreo.TabIndex = 0
        LblRegistroMonitoreo.Text = ChrW(55358) & ChrW(56830) & " Registro Monitoreo"
        ' 
        ' ChMonitoreo
        ' 
        ChMonitoreo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ChartArea1.AxisX.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.Title = "Fecha y Hora"
        ChartArea1.AxisY.Title = "Valor de medicion"
        ChartArea1.Name = "ChartArea1"
        ChMonitoreo.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        ChMonitoreo.Legends.Add(Legend1)
        ChMonitoreo.Location = New Point(613, 596)
        ChMonitoreo.Name = "ChMonitoreo"
        ChMonitoreo.Palette = DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.LegendText = "pH"
        Series1.Name = "SeriePH"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.LegendText = "Turbidez"
        Series2.Name = "SerieTurbidez"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.LegendText = "TDS"
        Series3.Name = "SerieTDS"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = DataVisualization.Charting.SeriesChartType.Line
        Series4.Legend = "Legend1"
        Series4.LegendText = "Temperatura"
        Series4.Name = "SerieTemperatura"
        ChMonitoreo.Series.Add(Series1)
        ChMonitoreo.Series.Add(Series2)
        ChMonitoreo.Series.Add(Series3)
        ChMonitoreo.Series.Add(Series4)
        ChMonitoreo.Size = New Size(376, 191)
        ChMonitoreo.TabIndex = 2
        ChMonitoreo.Text = "Chart1"
        Title1.Name = "Title1"
        Title1.Text = "Evolución de la calidad del agua"
        ChMonitoreo.Titles.Add(Title1)
        ' 
        ' PnlMonitoreoSensor
        ' 
        PnlMonitoreoSensor.BackColor = Color.White
        PnlMonitoreoSensor.Controls.Add(LblPendientedeconexion)
        PnlMonitoreoSensor.Controls.Add(PnlSensor)
        PnlMonitoreoSensor.Controls.Add(PanelRedondeado3)
        PnlMonitoreoSensor.Controls.Add(pnlSensorTurbidez)
        PnlMonitoreoSensor.Controls.Add(LblSensores)
        PnlMonitoreoSensor.Controls.Add(pnlSensorPh)
        PnlMonitoreoSensor.Location = New Point(55, 135)
        PnlMonitoreoSensor.Name = "PnlMonitoreoSensor"
        PnlMonitoreoSensor.Size = New Size(938, 195)
        PnlMonitoreoSensor.TabIndex = 8
        ' 
        ' LblPendientedeconexion
        ' 
        LblPendientedeconexion.AutoSize = True
        LblPendientedeconexion.Location = New Point(784, 20)
        LblPendientedeconexion.Name = "LblPendientedeconexion"
        LblPendientedeconexion.Size = New Size(128, 15)
        LblPendientedeconexion.TabIndex = 13
        LblPendientedeconexion.Text = "Pendiente de conexion"
        ' 
        ' PnlSensor
        ' 
        PnlSensor.BackColor = Color.LavenderBlush
        PnlSensor.BorderStyle = BorderStyle.Fixed3D
        PnlSensor.Controls.Add(LblSC0)
        PnlSensor.Controls.Add(LblNombreSensor)
        PnlSensor.Location = New Point(77, 73)
        PnlSensor.Name = "PnlSensor"
        PnlSensor.Size = New Size(180, 100)
        PnlSensor.TabIndex = 5
        ' 
        ' LblSC0
        ' 
        LblSC0.AutoSize = True
        LblSC0.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSC0.Location = New Point(50, 55)
        LblSC0.Name = "LblSC0"
        LblSC0.Size = New Size(83, 17)
        LblSC0.TabIndex = 1
        LblSC0.Text = "Sin Conexion"
        ' 
        ' LblNombreSensor
        ' 
        LblNombreSensor.AutoSize = True
        LblNombreSensor.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblNombreSensor.Location = New Point(34, 17)
        LblNombreSensor.Name = "LblNombreSensor"
        LblNombreSensor.Size = New Size(120, 21)
        LblNombreSensor.TabIndex = 0
        LblNombreSensor.Text = "Nombre Sensor"
        ' 
        ' PanelRedondeado3
        ' 
        PanelRedondeado3.BackColor = Color.LavenderBlush
        PanelRedondeado3.BorderStyle = BorderStyle.Fixed3D
        PanelRedondeado3.Controls.Add(LblSC3)
        PanelRedondeado3.Controls.Add(LblTemperaturaSensor)
        PanelRedondeado3.Location = New Point(732, 73)
        PanelRedondeado3.Name = "PanelRedondeado3"
        PanelRedondeado3.Size = New Size(180, 100)
        PanelRedondeado3.TabIndex = 6
        ' 
        ' LblSC3
        ' 
        LblSC3.AutoSize = True
        LblSC3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSC3.Location = New Point(50, 55)
        LblSC3.Name = "LblSC3"
        LblSC3.Size = New Size(83, 17)
        LblSC3.TabIndex = 2
        LblSC3.Text = "Sin Conexion"
        ' 
        ' LblTemperaturaSensor
        ' 
        LblTemperaturaSensor.AutoSize = True
        LblTemperaturaSensor.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTemperaturaSensor.Location = New Point(50, 17)
        LblTemperaturaSensor.Name = "LblTemperaturaSensor"
        LblTemperaturaSensor.Size = New Size(97, 21)
        LblTemperaturaSensor.TabIndex = 0
        LblTemperaturaSensor.Text = "Temperatura"
        ' 
        ' pnlSensorTurbidez
        ' 
        pnlSensorTurbidez.BackColor = Color.LavenderBlush
        pnlSensorTurbidez.BorderStyle = BorderStyle.Fixed3D
        pnlSensorTurbidez.Controls.Add(LblSC2)
        pnlSensorTurbidez.Controls.Add(Lblturbidezsensor)
        pnlSensorTurbidez.Location = New Point(512, 73)
        pnlSensorTurbidez.Name = "pnlSensorTurbidez"
        pnlSensorTurbidez.Size = New Size(180, 100)
        pnlSensorTurbidez.TabIndex = 5
        ' 
        ' LblSC2
        ' 
        LblSC2.AutoSize = True
        LblSC2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSC2.Location = New Point(50, 55)
        LblSC2.Name = "LblSC2"
        LblSC2.Size = New Size(83, 17)
        LblSC2.TabIndex = 2
        LblSC2.Text = "Sin Conexion"
        ' 
        ' Lblturbidezsensor
        ' 
        Lblturbidezsensor.AutoSize = True
        Lblturbidezsensor.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lblturbidezsensor.Location = New Point(50, 17)
        Lblturbidezsensor.Name = "Lblturbidezsensor"
        Lblturbidezsensor.Size = New Size(70, 21)
        Lblturbidezsensor.TabIndex = 0
        Lblturbidezsensor.Text = "Turbidez"
        ' 
        ' LblSensores
        ' 
        LblSensores.AutoSize = True
        LblSensores.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSensores.Location = New Point(42, 23)
        LblSensores.Name = "LblSensores"
        LblSensores.Size = New Size(187, 21)
        LblSensores.TabIndex = 12
        LblSensores.Text = "📡 Conexión de sensores"
        ' 
        ' pnlSensorPh
        ' 
        pnlSensorPh.BackColor = Color.LavenderBlush
        pnlSensorPh.BorderStyle = BorderStyle.Fixed3D
        pnlSensorPh.Controls.Add(LblSC1)
        pnlSensorPh.Controls.Add(lblsensorPH)
        pnlSensorPh.Location = New Point(293, 73)
        pnlSensorPh.Name = "pnlSensorPh"
        pnlSensorPh.Size = New Size(180, 100)
        pnlSensorPh.TabIndex = 4
        ' 
        ' LblSC1
        ' 
        LblSC1.AutoSize = True
        LblSC1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSC1.Location = New Point(50, 55)
        LblSC1.Name = "LblSC1"
        LblSC1.Size = New Size(83, 17)
        LblSC1.TabIndex = 1
        LblSC1.Text = "Sin Conexion"
        ' 
        ' lblsensorPH
        ' 
        lblsensorPH.AutoSize = True
        lblsensorPH.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblsensorPH.Location = New Point(50, 17)
        lblsensorPH.Name = "lblsensorPH"
        lblsensorPH.Size = New Size(82, 21)
        lblsensorPH.TabIndex = 0
        lblsensorPH.Text = "Sensor pH"
        ' 
        ' FrmMonitoreo
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1089, 788)
        Controls.Add(PnlMonitoreoSensor)
        Controls.Add(TxtTituloMonitoreo)
        Controls.Add(LblSubMonitoreo)
        Controls.Add(ChMonitoreo)
        Controls.Add(PnlRegistroMonitoreo)
        Controls.Add(PnlHistorial)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmMonitoreo"
        Text = "FrmMonitoreo"
        PnlCardPh.ResumeLayout(False)
        PnlCardPh.PerformLayout()
        PnlTurbidez.ResumeLayout(False)
        PnlTurbidez.PerformLayout()
        PnlRedondeado.ResumeLayout(False)
        PnlRedondeado.PerformLayout()
        Pnltemperatura.ResumeLayout(False)
        Pnltemperatura.PerformLayout()
        PnlHistorial.ResumeLayout(False)
        PnlHistorial.PerformLayout()
        CType(DtgMonitoreo, ComponentModel.ISupportInitialize).EndInit()
        PnlRegistroMonitoreo.ResumeLayout(False)
        PnlRegistroMonitoreo.PerformLayout()
        PnlNombreMonitoreo.ResumeLayout(False)
        PnlNombreMonitoreo.PerformLayout()
        CType(ChMonitoreo, ComponentModel.ISupportInitialize).EndInit()
        PnlMonitoreoSensor.ResumeLayout(False)
        PnlMonitoreoSensor.PerformLayout()
        PnlSensor.ResumeLayout(False)
        PnlSensor.PerformLayout()
        PanelRedondeado3.ResumeLayout(False)
        PanelRedondeado3.PerformLayout()
        pnlSensorTurbidez.ResumeLayout(False)
        pnlSensorTurbidez.PerformLayout()
        pnlSensorPh.ResumeLayout(False)
        pnlSensorPh.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtTituloMonitoreo As Label
    Friend WithEvents LblSubMonitoreo As Label
    Friend WithEvents PnlMonitoreo As PanelRedondeado
    Friend WithEvents PnlCardPh As PanelRedondeado
    Friend WithEvents Pnltemperatura As PanelRedondeado
    Friend WithEvents PnlRedondeado As PanelRedondeado
    Friend WithEvents LblTituloNivelpH As Label
    Friend WithEvents PanelRedondeado3 As PanelRedondeado
    Friend WithEvents LblTituloTemperatura As Label
    Friend WithEvents PanelRedondeado2 As PanelRedondeado
    Friend WithEvents LblTituloTDS As Label
    Friend WithEvents PnlTurbidez As PanelRedondeado
    Friend WithEvents LblTituloTurbidez As Label
    Friend WithEvents PnlHistorial As PanelRedondeado
    Friend WithEvents DtgMonitoreo As DataGridView
    Friend WithEvents LblHistorialMonitoreo As Label
    Friend WithEvents PnlRegistroMonitoreo As PanelRedondeado
    Friend WithEvents LblRegistroMonitoreo As Label
    Friend WithEvents BtnRegistrarLectura As Button
    Friend WithEvents ChMonitoreo As DataVisualization.Charting.Chart
    Friend WithEvents PnlMonitoreoSensor As PanelRedondeado
    Friend WithEvents LblSensores As Label
    Friend WithEvents PanelRedondeado1 As PanelRedondeado
    Friend WithEvents LblSC1 As Label
    Friend WithEvents lblsensorPH As Label
    Friend WithEvents Lblturbidezsensor As Label
    Friend WithEvents LblSC3 As Label
    Friend WithEvents LblTemperaturaSensor As Label
    Friend WithEvents LblSC2 As Label
    Friend WithEvents LblPendientedeconexion As Label
    Friend WithEvents PnlSensor As PanelRedondeado
    Friend WithEvents LblSC0 As Label
    Friend WithEvents LblNombreSensor As Label
    Friend WithEvents PnlNombreMonitoreo As PanelRedondeado
    Friend WithEvents LblNombreSM As Label
    Friend WithEvents TbxPhManual As TextBoxRedondeado
    Friend WithEvents TbxTurbidezmanual As TextBoxRedondeado
    Friend WithEvents TxbTdsManual As TextBoxRedondeado
    Friend WithEvents TbxTemperaturaManual As TextBoxRedondeado
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbSensor As ComboBox
    Friend WithEvents pnlSensorPh As PanelRedondeado
    Friend WithEvents pnlSensorTurbidez As PanelRedondeado

End Class
