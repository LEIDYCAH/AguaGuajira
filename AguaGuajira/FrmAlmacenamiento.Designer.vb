<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmacenamiento
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
        PnlCapacidadDemandada = New PanelRedondeado()
        TxtCapa = New TextBoxRedondeado()
        Label1 = New Label()
        Label2 = New Label()
        LblCapacidaddemanda = New Label()
        PnlEvaluacion = New PanelRedondeado()
        BtnAsignarTanque = New Button()
        Txtevaluacion = New TextBoxRedondeado()
        LblNotificacionevaluacion = New Label()
        LblEvaluacion = New Label()
        PnlDatosTanque = New PanelRedondeado()
        LblINventario = New Label()
        DtvTanques = New DataGridView()
        LblEstado = New Label()
        CmbEstado = New ComboBox()
        TxbCodigounico = New TextBoxRedondeado()
        LblCodigounico = New Label()
        Label3 = New Label()
        TxbCapacidadtotal = New TextBoxRedondeado()
        Label4 = New Label()
        BtnCalcular = New Button()
        TxbAguaAlmacenada = New TextBoxRedondeado()
        lblAguaAlmacenada = New Label()
        LblDatosTanque = New Label()
        PnlCalculodemanda = New PanelRedondeado()
        TxbUbicacion = New TextBoxRedondeado()
        LblUbicacion = New Label()
        TxtcNumero = New TextBoxRedondeado()
        BtnCalculoDemanda = New Button()
        TxtCDias = New TextBoxRedondeado()
        TxtCConsumo = New TextBoxRedondeado()
        LblCalculo2 = New Label()
        LblCalculo3 = New Label()
        LblCalculo1 = New Label()
        LblCalculo = New Label()
        PnlDisponible = New PanelRedondeado()
        PnlIndicadorOcupacion = New PanelRedondeado()
        LblPorcentajeOcupacion = New Label()
        TxtAguaDisponible = New TextBoxRedondeado()
        LblVolumenal = New Label()
        LblDispoible = New Label()
        PnlCapacidadTanque = New PanelRedondeado()
        TxtCapacidadTanque = New TextBoxRedondeado()
        Lblvolumenmx = New Label()
        LblCapacidad = New Label()
        SbAlmacenamiento = New Label()
        LblTituloalmacenamiento = New Label()
        IcAlmacenamiento = New Label()
        PnlCapacidadDemandada.SuspendLayout()
        PnlEvaluacion.SuspendLayout()
        PnlDatosTanque.SuspendLayout()
        CType(DtvTanques, ComponentModel.ISupportInitialize).BeginInit()
        PnlCalculodemanda.SuspendLayout()
        PnlDisponible.SuspendLayout()
        PnlIndicadorOcupacion.SuspendLayout()
        PnlCapacidadTanque.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlCapacidadDemandada
        ' 
        PnlCapacidadDemandada.BackColor = Color.White
        PnlCapacidadDemandada.Controls.Add(TxtCapa)
        PnlCapacidadDemandada.Controls.Add(Label1)
        PnlCapacidadDemandada.Controls.Add(Label2)
        PnlCapacidadDemandada.Controls.Add(LblCapacidaddemanda)
        PnlCapacidadDemandada.Location = New Point(437, 86)
        PnlCapacidadDemandada.Name = "PnlCapacidadDemandada"
        PnlCapacidadDemandada.Size = New Size(209, 113)
        PnlCapacidadDemandada.TabIndex = 5
        ' 
        ' TxtCapa
        ' 
        TxtCapa.BackColor = Color.White
        TxtCapa.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtCapa.Enabled = False
        TxtCapa.GrosorBorde = 1.5F
        TxtCapa.Location = New Point(26, 42)
        TxtCapa.Multiline = False
        TxtCapa.Name = "TxtCapa"
        TxtCapa.Padding = New Padding(10, 5, 10, 5)
        TxtCapa.RadioEsquinas = 30
        TxtCapa.ScrollBars = ScrollBars.Vertical
        TxtCapa.Size = New Size(156, 31)
        TxtCapa.TabIndex = 4
        TxtCapa.WordWrap = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 15)
        Label1.TabIndex = 3
        Label1.Text = "Volumen Almacenado"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(70, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 25)
        Label2.TabIndex = 1
        Label2.Text = "--L"
        ' 
        ' LblCapacidaddemanda
        ' 
        LblCapacidaddemanda.AutoSize = True
        LblCapacidaddemanda.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblCapacidaddemanda.Location = New Point(1, 10)
        LblCapacidaddemanda.Name = "LblCapacidaddemanda"
        LblCapacidaddemanda.Size = New Size(180, 21)
        LblCapacidaddemanda.TabIndex = 0
        LblCapacidaddemanda.Text = ChrW(55358) & ChrW(57047) & " Capacidad Necesaria"
        ' 
        ' PnlEvaluacion
        ' 
        PnlEvaluacion.BackColor = Color.White
        PnlEvaluacion.Controls.Add(BtnAsignarTanque)
        PnlEvaluacion.Controls.Add(Txtevaluacion)
        PnlEvaluacion.Controls.Add(LblNotificacionevaluacion)
        PnlEvaluacion.Controls.Add(LblEvaluacion)
        PnlEvaluacion.Location = New Point(56, 356)
        PnlEvaluacion.Name = "PnlEvaluacion"
        PnlEvaluacion.Size = New Size(274, 168)
        PnlEvaluacion.TabIndex = 6
        ' 
        ' BtnAsignarTanque
        ' 
        BtnAsignarTanque.Location = New Point(99, 127)
        BtnAsignarTanque.Name = "BtnAsignarTanque"
        BtnAsignarTanque.Size = New Size(75, 23)
        BtnAsignarTanque.TabIndex = 12
        BtnAsignarTanque.Text = "Registrar"
        BtnAsignarTanque.UseVisualStyleBackColor = True
        ' 
        ' Txtevaluacion
        ' 
        Txtevaluacion.BackColor = Color.White
        Txtevaluacion.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        Txtevaluacion.GrosorBorde = 1.5F
        Txtevaluacion.Location = New Point(34, 87)
        Txtevaluacion.Multiline = False
        Txtevaluacion.Name = "Txtevaluacion"
        Txtevaluacion.Padding = New Padding(10, 5, 10, 5)
        Txtevaluacion.RadioEsquinas = 20
        Txtevaluacion.ScrollBars = ScrollBars.Vertical
        Txtevaluacion.Size = New Size(191, 29)
        Txtevaluacion.TabIndex = 11
        Txtevaluacion.WordWrap = True
        ' 
        ' LblNotificacionevaluacion
        ' 
        LblNotificacionevaluacion.AutoSize = True
        LblNotificacionevaluacion.Location = New Point(11, 51)
        LblNotificacionevaluacion.Name = "LblNotificacionevaluacion"
        LblNotificacionevaluacion.Size = New Size(238, 15)
        LblNotificacionevaluacion.TabIndex = 3
        LblNotificacionevaluacion.Text = "Comparacion Demanda vs Capacidad Litros"
        LblNotificacionevaluacion.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' LblEvaluacion
        ' 
        LblEvaluacion.AutoSize = True
        LblEvaluacion.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblEvaluacion.Location = New Point(10, 14)
        LblEvaluacion.Name = "LblEvaluacion"
        LblEvaluacion.Size = New Size(134, 25)
        LblEvaluacion.TabIndex = 0
        LblEvaluacion.Text = ChrW(55358) & ChrW(56830) & " Evaluación"
        ' 
        ' PnlDatosTanque
        ' 
        PnlDatosTanque.BackColor = Color.White
        PnlDatosTanque.Controls.Add(LblINventario)
        PnlDatosTanque.Controls.Add(DtvTanques)
        PnlDatosTanque.Controls.Add(LblEstado)
        PnlDatosTanque.Controls.Add(CmbEstado)
        PnlDatosTanque.Controls.Add(TxbCodigounico)
        PnlDatosTanque.Controls.Add(LblCodigounico)
        PnlDatosTanque.Controls.Add(Label3)
        PnlDatosTanque.Controls.Add(TxbCapacidadtotal)
        PnlDatosTanque.Controls.Add(Label4)
        PnlDatosTanque.Controls.Add(BtnCalcular)
        PnlDatosTanque.Controls.Add(TxbAguaAlmacenada)
        PnlDatosTanque.Controls.Add(lblAguaAlmacenada)
        PnlDatosTanque.Controls.Add(LblDatosTanque)
        PnlDatosTanque.Location = New Point(702, 83)
        PnlDatosTanque.Name = "PnlDatosTanque"
        PnlDatosTanque.Size = New Size(368, 441)
        PnlDatosTanque.TabIndex = 6
        ' 
        ' LblINventario
        ' 
        LblINventario.AutoSize = True
        LblINventario.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblINventario.Location = New Point(26, 238)
        LblINventario.Name = "LblINventario"
        LblINventario.Size = New Size(234, 25)
        LblINventario.TabIndex = 19
        LblINventario.Text = "📦 Inventario de tanques"
        ' 
        ' DtvTanques
        ' 
        DtvTanques.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DtvTanques.Location = New Point(15, 273)
        DtvTanques.Name = "DtvTanques"
        DtvTanques.Size = New Size(342, 150)
        DtvTanques.TabIndex = 18
        ' 
        ' LblEstado
        ' 
        LblEstado.AutoSize = True
        LblEstado.Location = New Point(267, 131)
        LblEstado.Name = "LblEstado"
        LblEstado.Size = New Size(42, 15)
        LblEstado.TabIndex = 17
        LblEstado.Text = "Estado"
        ' 
        ' CmbEstado
        ' 
        CmbEstado.FormattingEnabled = True
        CmbEstado.Location = New Point(221, 150)
        CmbEstado.Name = "CmbEstado"
        CmbEstado.Size = New Size(136, 23)
        CmbEstado.TabIndex = 16
        ' 
        ' TxbCodigounico
        ' 
        TxbCodigounico.BackColor = Color.White
        TxbCodigounico.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxbCodigounico.Enabled = False
        TxbCodigounico.GrosorBorde = 1.5F
        TxbCodigounico.Location = New Point(15, 90)
        TxbCodigounico.Multiline = False
        TxbCodigounico.Name = "TxbCodigounico"
        TxbCodigounico.Padding = New Padding(10, 5, 10, 5)
        TxbCodigounico.RadioEsquinas = 20
        TxbCodigounico.ScrollBars = ScrollBars.Vertical
        TxbCodigounico.Size = New Size(136, 29)
        TxbCodigounico.TabIndex = 15
        TxbCodigounico.WordWrap = True
        ' 
        ' LblCodigounico
        ' 
        LblCodigounico.AutoSize = True
        LblCodigounico.Location = New Point(41, 74)
        LblCodigounico.Name = "LblCodigounico"
        LblCodigounico.Size = New Size(80, 15)
        LblCodigounico.TabIndex = 14
        LblCodigounico.Text = "Codigo Unico"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 15)
        Label3.TabIndex = 5
        Label3.Text = "Capacidad Total"
        ' 
        ' TxbCapacidadtotal
        ' 
        TxbCapacidadtotal.BackColor = Color.White
        TxbCapacidadtotal.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxbCapacidadtotal.GrosorBorde = 1.5F
        TxbCapacidadtotal.Location = New Point(221, 90)
        TxbCapacidadtotal.Multiline = False
        TxbCapacidadtotal.Name = "TxbCapacidadtotal"
        TxbCapacidadtotal.Padding = New Padding(10, 5, 10, 5)
        TxbCapacidadtotal.RadioEsquinas = 20
        TxbCapacidadtotal.ScrollBars = ScrollBars.Vertical
        TxbCapacidadtotal.Size = New Size(136, 29)
        TxbCapacidadtotal.TabIndex = 11
        TxbCapacidadtotal.WordWrap = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(240, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 15)
        Label4.TabIndex = 10
        Label4.Text = "Capacidad Total (L)"
        ' 
        ' BtnCalcular
        ' 
        BtnCalcular.BackColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnCalcular.FlatStyle = FlatStyle.Flat
        BtnCalcular.ForeColor = Color.White
        BtnCalcular.Location = New Point(141, 194)
        BtnCalcular.Name = "BtnCalcular"
        BtnCalcular.Size = New Size(106, 23)
        BtnCalcular.TabIndex = 9
        BtnCalcular.Text = "Registrar Datos"
        BtnCalcular.UseCompatibleTextRendering = True
        BtnCalcular.UseVisualStyleBackColor = False
        ' 
        ' TxbAguaAlmacenada
        ' 
        TxbAguaAlmacenada.BackColor = Color.White
        TxbAguaAlmacenada.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxbAguaAlmacenada.GrosorBorde = 1.5F
        TxbAguaAlmacenada.Location = New Point(15, 150)
        TxbAguaAlmacenada.Multiline = False
        TxbAguaAlmacenada.Name = "TxbAguaAlmacenada"
        TxbAguaAlmacenada.Padding = New Padding(10, 5, 10, 5)
        TxbAguaAlmacenada.RadioEsquinas = 20
        TxbAguaAlmacenada.ScrollBars = ScrollBars.Vertical
        TxbAguaAlmacenada.Size = New Size(136, 29)
        TxbAguaAlmacenada.TabIndex = 7
        TxbAguaAlmacenada.WordWrap = True
        ' 
        ' lblAguaAlmacenada
        ' 
        lblAguaAlmacenada.AutoSize = True
        lblAguaAlmacenada.Location = New Point(55, 134)
        lblAguaAlmacenada.Name = "lblAguaAlmacenada"
        lblAguaAlmacenada.Size = New Size(54, 15)
        lblAguaAlmacenada.TabIndex = 4
        lblAguaAlmacenada.Text = "Volumen"
        ' 
        ' LblDatosTanque
        ' 
        LblDatosTanque.AutoSize = True
        LblDatosTanque.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblDatosTanque.Location = New Point(26, 13)
        LblDatosTanque.Name = "LblDatosTanque"
        LblDatosTanque.Size = New Size(200, 25)
        LblDatosTanque.TabIndex = 0
        LblDatosTanque.Text = "🛢️ Gestor del Tanque"
        ' 
        ' PnlCalculodemanda
        ' 
        PnlCalculodemanda.BackColor = Color.White
        PnlCalculodemanda.Controls.Add(TxbUbicacion)
        PnlCalculodemanda.Controls.Add(LblUbicacion)
        PnlCalculodemanda.Controls.Add(TxtcNumero)
        PnlCalculodemanda.Controls.Add(BtnCalculoDemanda)
        PnlCalculodemanda.Controls.Add(TxtCDias)
        PnlCalculodemanda.Controls.Add(TxtCConsumo)
        PnlCalculodemanda.Controls.Add(LblCalculo2)
        PnlCalculodemanda.Controls.Add(LblCalculo3)
        PnlCalculodemanda.Controls.Add(LblCalculo1)
        PnlCalculodemanda.Controls.Add(LblCalculo)
        PnlCalculodemanda.Location = New Point(51, 86)
        PnlCalculodemanda.Name = "PnlCalculodemanda"
        PnlCalculodemanda.Size = New Size(336, 257)
        PnlCalculodemanda.TabIndex = 5
        ' 
        ' TxbUbicacion
        ' 
        TxbUbicacion.BackColor = Color.White
        TxbUbicacion.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxbUbicacion.GrosorBorde = 1.5F
        TxbUbicacion.Location = New Point(87, 56)
        TxbUbicacion.Multiline = False
        TxbUbicacion.Name = "TxbUbicacion"
        TxbUbicacion.Padding = New Padding(10, 5, 10, 5)
        TxbUbicacion.RadioEsquinas = 5
        TxbUbicacion.ScrollBars = ScrollBars.Vertical
        TxbUbicacion.Size = New Size(217, 29)
        TxbUbicacion.TabIndex = 13
        TxbUbicacion.WordWrap = True
        ' 
        ' LblUbicacion
        ' 
        LblUbicacion.AutoSize = True
        LblUbicacion.Location = New Point(21, 62)
        LblUbicacion.Name = "LblUbicacion"
        LblUbicacion.Size = New Size(60, 15)
        LblUbicacion.TabIndex = 12
        LblUbicacion.Text = "Ubicacion"
        ' 
        ' TxtcNumero
        ' 
        TxtcNumero.BackColor = Color.White
        TxtcNumero.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtcNumero.GrosorBorde = 1.5F
        TxtcNumero.Location = New Point(185, 95)
        TxtcNumero.Multiline = False
        TxtcNumero.Name = "TxtcNumero"
        TxtcNumero.Padding = New Padding(10, 5, 10, 5)
        TxtcNumero.RadioEsquinas = 5
        TxtcNumero.ScrollBars = ScrollBars.Vertical
        TxtcNumero.Size = New Size(119, 29)
        TxtcNumero.TabIndex = 10
        TxtcNumero.WordWrap = True
        ' 
        ' BtnCalculoDemanda
        ' 
        BtnCalculoDemanda.BackColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnCalculoDemanda.FlatStyle = FlatStyle.Flat
        BtnCalculoDemanda.ForeColor = Color.White
        BtnCalculoDemanda.Location = New Point(118, 224)
        BtnCalculoDemanda.Name = "BtnCalculoDemanda"
        BtnCalculoDemanda.Size = New Size(75, 23)
        BtnCalculoDemanda.TabIndex = 9
        BtnCalculoDemanda.Text = "Calcular"
        BtnCalculoDemanda.UseCompatibleTextRendering = True
        BtnCalculoDemanda.UseVisualStyleBackColor = False
        ' 
        ' TxtCDias
        ' 
        TxtCDias.BackColor = Color.White
        TxtCDias.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtCDias.GrosorBorde = 1.5F
        TxtCDias.Location = New Point(186, 172)
        TxtCDias.Multiline = False
        TxtCDias.Name = "TxtCDias"
        TxtCDias.Padding = New Padding(10, 5, 10, 5)
        TxtCDias.RadioEsquinas = 5
        TxtCDias.ScrollBars = ScrollBars.Vertical
        TxtCDias.Size = New Size(116, 29)
        TxtCDias.TabIndex = 8
        TxtCDias.WordWrap = True
        ' 
        ' TxtCConsumo
        ' 
        TxtCConsumo.BackColor = Color.White
        TxtCConsumo.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtCConsumo.GrosorBorde = 1.5F
        TxtCConsumo.Location = New Point(186, 131)
        TxtCConsumo.Multiline = False
        TxtCConsumo.Name = "TxtCConsumo"
        TxtCConsumo.Padding = New Padding(10, 5, 10, 5)
        TxtCConsumo.RadioEsquinas = 5
        TxtCConsumo.ScrollBars = ScrollBars.Vertical
        TxtCConsumo.Size = New Size(118, 29)
        TxtCConsumo.TabIndex = 11
        TxtCConsumo.WordWrap = True
        ' 
        ' LblCalculo2
        ' 
        LblCalculo2.AutoSize = True
        LblCalculo2.Location = New Point(21, 134)
        LblCalculo2.Name = "LblCalculo2"
        LblCalculo2.Size = New Size(161, 15)
        LblCalculo2.TabIndex = 4
        LblCalculo2.Text = "Consumo diario por persona:"
        ' 
        ' LblCalculo3
        ' 
        LblCalculo3.AutoSize = True
        LblCalculo3.Location = New Point(71, 174)
        LblCalculo3.Name = "LblCalculo3"
        LblCalculo3.Size = New Size(109, 15)
        LblCalculo3.TabIndex = 3
        LblCalculo3.Text = "Dias de autonomía:"
        ' 
        ' LblCalculo1
        ' 
        LblCalculo1.AutoSize = True
        LblCalculo1.Location = New Point(49, 100)
        LblCalculo1.Name = "LblCalculo1"
        LblCalculo1.Size = New Size(130, 15)
        LblCalculo1.TabIndex = 2
        LblCalculo1.Text = "Numero de Habitantes:"
        ' 
        ' LblCalculo
        ' 
        LblCalculo.AutoSize = True
        LblCalculo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCalculo.Location = New Point(21, 14)
        LblCalculo.Name = "LblCalculo"
        LblCalculo.Size = New Size(221, 25)
        LblCalculo.TabIndex = 0
        LblCalculo.Text = "👥 Calculo de Demanda"
        ' 
        ' PnlDisponible
        ' 
        PnlDisponible.BackColor = Color.White
        PnlDisponible.Controls.Add(PnlIndicadorOcupacion)
        PnlDisponible.Controls.Add(TxtAguaDisponible)
        PnlDisponible.Controls.Add(LblVolumenal)
        PnlDisponible.Controls.Add(LblDispoible)
        PnlDisponible.Location = New Point(340, 356)
        PnlDisponible.Name = "PnlDisponible"
        PnlDisponible.Size = New Size(350, 168)
        PnlDisponible.TabIndex = 4
        ' 
        ' PnlIndicadorOcupacion
        ' 
        PnlIndicadorOcupacion.Controls.Add(LblPorcentajeOcupacion)
        PnlIndicadorOcupacion.Location = New Point(192, 7)
        PnlIndicadorOcupacion.Name = "PnlIndicadorOcupacion"
        PnlIndicadorOcupacion.Size = New Size(150, 150)
        PnlIndicadorOcupacion.TabIndex = 7
        ' 
        ' LblPorcentajeOcupacion
        ' 
        LblPorcentajeOcupacion.BackColor = Color.Transparent
        LblPorcentajeOcupacion.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblPorcentajeOcupacion.Location = New Point(0, 0)
        LblPorcentajeOcupacion.Name = "LblPorcentajeOcupacion"
        LblPorcentajeOcupacion.Size = New Size(150, 150)
        LblPorcentajeOcupacion.TabIndex = 0
        LblPorcentajeOcupacion.Text = "0"
        LblPorcentajeOcupacion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TxtAguaDisponible
        ' 
        TxtAguaDisponible.BackColor = Color.White
        TxtAguaDisponible.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtAguaDisponible.GrosorBorde = 1.5F
        TxtAguaDisponible.Location = New Point(15, 87)
        TxtAguaDisponible.Multiline = False
        TxtAguaDisponible.Name = "TxtAguaDisponible"
        TxtAguaDisponible.Padding = New Padding(10, 5, 10, 5)
        TxtAguaDisponible.RadioEsquinas = 30
        TxtAguaDisponible.ScrollBars = ScrollBars.Vertical
        TxtAguaDisponible.Size = New Size(161, 41)
        TxtAguaDisponible.TabIndex = 6
        TxtAguaDisponible.WordWrap = True
        ' 
        ' LblVolumenal
        ' 
        LblVolumenal.AutoSize = True
        LblVolumenal.Location = New Point(41, 47)
        LblVolumenal.Name = "LblVolumenal"
        LblVolumenal.Size = New Size(124, 15)
        LblVolumenal.TabIndex = 3
        LblVolumenal.Text = "Volumen Almacenado"
        ' 
        ' LblDispoible
        ' 
        LblDispoible.AutoSize = True
        LblDispoible.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblDispoible.Location = New Point(26, 26)
        LblDispoible.Name = "LblDispoible"
        LblDispoible.Size = New Size(150, 21)
        LblDispoible.TabIndex = 0
        LblDispoible.Text = "♒ Agua Disponible"
        ' 
        ' PnlCapacidadTanque
        ' 
        PnlCapacidadTanque.BackColor = Color.White
        PnlCapacidadTanque.Controls.Add(TxtCapacidadTanque)
        PnlCapacidadTanque.Controls.Add(Lblvolumenmx)
        PnlCapacidadTanque.Controls.Add(LblCapacidad)
        PnlCapacidadTanque.Location = New Point(437, 227)
        PnlCapacidadTanque.Name = "PnlCapacidadTanque"
        PnlCapacidadTanque.Size = New Size(209, 116)
        PnlCapacidadTanque.TabIndex = 3
        ' 
        ' TxtCapacidadTanque
        ' 
        TxtCapacidadTanque.BackColor = Color.White
        TxtCapacidadTanque.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtCapacidadTanque.Enabled = False
        TxtCapacidadTanque.GrosorBorde = 1.5F
        TxtCapacidadTanque.Location = New Point(26, 51)
        TxtCapacidadTanque.Multiline = False
        TxtCapacidadTanque.Name = "TxtCapacidadTanque"
        TxtCapacidadTanque.Padding = New Padding(10, 5, 10, 5)
        TxtCapacidadTanque.RadioEsquinas = 30
        TxtCapacidadTanque.ScrollBars = ScrollBars.Vertical
        TxtCapacidadTanque.Size = New Size(167, 31)
        TxtCapacidadTanque.TabIndex = 5
        TxtCapacidadTanque.WordWrap = True
        ' 
        ' Lblvolumenmx
        ' 
        Lblvolumenmx.AutoSize = True
        Lblvolumenmx.Location = New Point(7, 90)
        Lblvolumenmx.Name = "Lblvolumenmx"
        Lblvolumenmx.Size = New Size(160, 15)
        Lblvolumenmx.TabIndex = 2
        Lblvolumenmx.Text = "Volumen Maximo del tanque"
        ' 
        ' LblCapacidad
        ' 
        LblCapacidad.AutoSize = True
        LblCapacidad.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblCapacidad.Location = New Point(21, 13)
        LblCapacidad.Name = "LblCapacidad"
        LblCapacidad.Size = New Size(161, 21)
        LblCapacidad.TabIndex = 0
        LblCapacidad.Text = ChrW(55358) & ChrW(57047) & " Capacidad Tanque"
        ' 
        ' SbAlmacenamiento
        ' 
        SbAlmacenamiento.AutoSize = True
        SbAlmacenamiento.BackColor = Color.Transparent
        SbAlmacenamiento.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        SbAlmacenamiento.ForeColor = Color.DarkCyan
        SbAlmacenamiento.Location = New Point(56, 48)
        SbAlmacenamiento.Name = "SbAlmacenamiento"
        SbAlmacenamiento.Size = New Size(292, 15)
        SbAlmacenamiento.TabIndex = 1
        SbAlmacenamiento.Text = "Control de capacidad y abastecimiento de agua"
        ' 
        ' LblTituloalmacenamiento
        ' 
        LblTituloalmacenamiento.AutoSize = True
        LblTituloalmacenamiento.BackColor = Color.Transparent
        LblTituloalmacenamiento.Font = New Font("Bauhaus 93", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTituloalmacenamiento.Location = New Point(54, 19)
        LblTituloalmacenamiento.Name = "LblTituloalmacenamiento"
        LblTituloalmacenamiento.Size = New Size(206, 28)
        LblTituloalmacenamiento.TabIndex = 0
        LblTituloalmacenamiento.Text = "Almacenamiento"
        ' 
        ' IcAlmacenamiento
        ' 
        IcAlmacenamiento.AutoSize = True
        IcAlmacenamiento.BackColor = Color.Transparent
        IcAlmacenamiento.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IcAlmacenamiento.ForeColor = SystemColors.HotTrack
        IcAlmacenamiento.Location = New Point(6, 11)
        IcAlmacenamiento.Name = "IcAlmacenamiento"
        IcAlmacenamiento.Size = New Size(73, 50)
        IcAlmacenamiento.TabIndex = 2
        IcAlmacenamiento.Text = "🛢️"
        ' 
        ' FrmAlmacenamiento
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(241), CByte(239), CByte(251))
        ClientSize = New Size(1082, 564)
        Controls.Add(LblTituloalmacenamiento)
        Controls.Add(SbAlmacenamiento)
        Controls.Add(IcAlmacenamiento)
        Controls.Add(PnlCalculodemanda)
        Controls.Add(PnlDatosTanque)
        Controls.Add(PnlCapacidadDemandada)
        Controls.Add(PnlEvaluacion)
        Controls.Add(PnlCapacidadTanque)
        Controls.Add(PnlDisponible)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmAlmacenamiento"
        Text = "FrmAlmacenamiento"
        PnlCapacidadDemandada.ResumeLayout(False)
        PnlCapacidadDemandada.PerformLayout()
        PnlEvaluacion.ResumeLayout(False)
        PnlEvaluacion.PerformLayout()
        PnlDatosTanque.ResumeLayout(False)
        PnlDatosTanque.PerformLayout()
        CType(DtvTanques, ComponentModel.ISupportInitialize).EndInit()
        PnlCalculodemanda.ResumeLayout(False)
        PnlCalculodemanda.PerformLayout()
        PnlDisponible.ResumeLayout(False)
        PnlDisponible.PerformLayout()
        PnlIndicadorOcupacion.ResumeLayout(False)
        PnlCapacidadTanque.ResumeLayout(False)
        PnlCapacidadTanque.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PnlCapacidadDemandada As PanelRedondeado
    Friend WithEvents Label1 As Label
    Friend WithEvents LblCapacidaddemanda As Label
    Friend WithEvents PnlEvaluacion As PanelRedondeado
    Friend WithEvents LblNotificacionevaluacion As Label
    Friend WithEvents LblEvaluacion As Label
    Friend WithEvents PnlDatosTanque As PanelRedondeado
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAguaAlmacenada As Label
    Friend WithEvents LblCapacidadtotal As Label
    Friend WithEvents LblDatosTanque As Label
    Friend WithEvents PnlCalculodemanda As PanelRedondeado
    Friend WithEvents BtnCalculoDemanda As Button
    Friend WithEvents LblCalculo2 As Label
    Friend WithEvents LblCalculo3 As Label
    Friend WithEvents LblCalculo1 As Label
    Friend WithEvents LblCalculo As Label
    Friend WithEvents PnlDisponible As PanelRedondeado
    Friend WithEvents LblVolumenal As Label
    Friend WithEvents LblDispoible As Label
    Friend WithEvents PnlCapacidadTanque As PanelRedondeado
    Friend WithEvents Lblvolumenmx As Label
    Friend WithEvents LblCapacidad As Label
    Friend WithEvents SbAlmacenamiento As Label
    Friend WithEvents LblTituloalmacenamiento As Label
    Friend WithEvents IcAlmacenamiento As Label
    Friend WithEvents TxtcNumero As TextBoxRedondeado
    Friend WithEvents Txtevaluacion As TextBoxRedondeado
    Friend WithEvents TxbAguaAlmacenada As TextBoxRedondeado
    Friend WithEvents txtCapacidadTotal As TextBoxRedondeado
    Friend WithEvents TxtCDias As TextBoxRedondeado
    Friend WithEvents TxtCConsumo As TextBoxRedondeado
    Friend WithEvents BtnAlmacenamiento2 As Label
    Friend WithEvents TxbCapacidadtotal As TextBoxRedondeado
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCapa As TextBoxRedondeado
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCapacidadTanque As TextBoxRedondeado
    Friend WithEvents TxtAguaDisponible As TextBoxRedondeado
    Friend WithEvents PnlIndicadorOcupacion As PanelRedondeado
    Friend WithEvents LblPorcentajeOcupacion As Label
    Friend WithEvents TxbCodigounico As TextBoxRedondeado
    Friend WithEvents LblCodigounico As Label
    Friend WithEvents TxbUbicacion As TextBoxRedondeado
    Friend WithEvents LblUbicacion As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents LblINventario As Label
    Friend WithEvents DtvTanques As DataGridView
    Friend WithEvents BtnAsignarTanque As Button

End Class
