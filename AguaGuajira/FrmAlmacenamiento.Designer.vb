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
        PnlAlmacenamiento = New PanelRedondeado()
        pnlUmage = New PanelRedondeado()
        PnlCapacidadDemandada = New PanelRedondeado()
        Label1 = New Label()
        Label2 = New Label()
        LblCapacidaddemanda = New Label()
        PnlEvaluacion = New PanelRedondeado()
        Txtevaluacion = New TextBox()
        LblNotificacionevaluacion = New Label()
        LblEvaluacion = New Label()
        PnlDatosTanque = New PanelRedondeado()
        BtnCalcular = New Button()
        TxbAguaAlmacenada = New TextBox()
        txtCapacidadTotal = New TextBox()
        Label3 = New Label()
        lblAguaAlmacenada = New Label()
        LblCapacidadtotal = New Label()
        LblDatosTanque = New Label()
        PnlCalculodemanda = New PanelRedondeado()
        BtnCalculoDemanda = New Button()
        TxtCDias = New TextBox()
        TxtCConsumo = New TextBox()
        TxtcNumero = New TextBox()
        LblCalculo2 = New Label()
        LblCalculo3 = New Label()
        LblCalculo1 = New Label()
        LblCal2 = New Label()
        LblCalculo = New Label()
        PnlDisponible = New PanelRedondeado()
        LblVolumenal = New Label()
        Lbldispo = New Label()
        LblDispoible = New Label()
        PnlCapacidadTanque = New PanelRedondeado()
        Lblvolumenmx = New Label()
        LblCapa = New Label()
        LblCapacidad = New Label()
        SbAlmacenamiento = New Label()
        LblTituloalmacenamiento = New Label()
        IcAlmacenamiento = New Label()
        PnlAlmacenamiento.SuspendLayout()
        PnlCapacidadDemandada.SuspendLayout()
        PnlEvaluacion.SuspendLayout()
        PnlDatosTanque.SuspendLayout()
        PnlCalculodemanda.SuspendLayout()
        PnlDisponible.SuspendLayout()
        PnlCapacidadTanque.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlAlmacenamiento
        ' 
        PnlAlmacenamiento.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PnlAlmacenamiento.AutoScroll = True
        PnlAlmacenamiento.Controls.Add(pnlUmage)
        PnlAlmacenamiento.Controls.Add(PnlCapacidadDemandada)
        PnlAlmacenamiento.Controls.Add(PnlEvaluacion)
        PnlAlmacenamiento.Controls.Add(PnlDatosTanque)
        PnlAlmacenamiento.Controls.Add(PnlCalculodemanda)
        PnlAlmacenamiento.Controls.Add(PnlDisponible)
        PnlAlmacenamiento.Controls.Add(PnlCapacidadTanque)
        PnlAlmacenamiento.Controls.Add(SbAlmacenamiento)
        PnlAlmacenamiento.Controls.Add(LblTituloalmacenamiento)
        PnlAlmacenamiento.Controls.Add(IcAlmacenamiento)
        PnlAlmacenamiento.Location = New Point(0, 0)
        PnlAlmacenamiento.Name = "PnlAlmacenamiento"
        PnlAlmacenamiento.RadioEsquinas = 18
        PnlAlmacenamiento.Size = New Size(1033, 700)
        PnlAlmacenamiento.TabIndex = 9
        ' 
        ' pnlUmage
        ' 
        pnlUmage.BackColor = Color.White
        pnlUmage.Location = New Point(123, 348)
        pnlUmage.Name = "pnlUmage"
        pnlUmage.Size = New Size(450, 148)
        pnlUmage.TabIndex = 7
        ' 
        ' PnlCapacidadDemandada
        ' 
        PnlCapacidadDemandada.BackColor = Color.White
        PnlCapacidadDemandada.Controls.Add(Label1)
        PnlCapacidadDemandada.Controls.Add(Label2)
        PnlCapacidadDemandada.Controls.Add(LblCapacidaddemanda)
        PnlCapacidadDemandada.Location = New Point(351, 68)
        PnlCapacidadDemandada.Name = "PnlCapacidadDemandada"
        PnlCapacidadDemandada.Size = New Size(185, 113)
        PnlCapacidadDemandada.TabIndex = 5
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
        PnlEvaluacion.Controls.Add(Txtevaluacion)
        PnlEvaluacion.Controls.Add(LblNotificacionevaluacion)
        PnlEvaluacion.Controls.Add(LblEvaluacion)
        PnlEvaluacion.Location = New Point(453, 190)
        PnlEvaluacion.Name = "PnlEvaluacion"
        PnlEvaluacion.Size = New Size(207, 144)
        PnlEvaluacion.TabIndex = 6
        ' 
        ' Txtevaluacion
        ' 
        Txtevaluacion.BackColor = Color.Thistle
        Txtevaluacion.Enabled = False
        Txtevaluacion.Location = New Point(21, 66)
        Txtevaluacion.Name = "Txtevaluacion"
        Txtevaluacion.Size = New Size(151, 23)
        Txtevaluacion.TabIndex = 10
        Txtevaluacion.WordWrap = False
        ' 
        ' LblNotificacionevaluacion
        ' 
        LblNotificacionevaluacion.AutoSize = True
        LblNotificacionevaluacion.Location = New Point(20, 113)
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
        LblEvaluacion.Location = New Point(20, 16)
        LblEvaluacion.Name = "LblEvaluacion"
        LblEvaluacion.Size = New Size(107, 25)
        LblEvaluacion.TabIndex = 0
        LblEvaluacion.Text = "Evaluación"
        ' 
        ' PnlDatosTanque
        ' 
        PnlDatosTanque.BackColor = Color.White
        PnlDatosTanque.Controls.Add(BtnCalcular)
        PnlDatosTanque.Controls.Add(TxbAguaAlmacenada)
        PnlDatosTanque.Controls.Add(txtCapacidadTotal)
        PnlDatosTanque.Controls.Add(Label3)
        PnlDatosTanque.Controls.Add(lblAguaAlmacenada)
        PnlDatosTanque.Controls.Add(LblCapacidadtotal)
        PnlDatosTanque.Controls.Add(LblDatosTanque)
        PnlDatosTanque.Location = New Point(758, 80)
        PnlDatosTanque.Name = "PnlDatosTanque"
        PnlDatosTanque.Size = New Size(254, 197)
        PnlDatosTanque.TabIndex = 6
        ' 
        ' BtnCalcular
        ' 
        BtnCalcular.BackColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnCalcular.FlatStyle = FlatStyle.Flat
        BtnCalcular.ForeColor = Color.White
        BtnCalcular.Location = New Point(62, 151)
        BtnCalcular.Name = "BtnCalcular"
        BtnCalcular.Size = New Size(106, 23)
        BtnCalcular.TabIndex = 9
        BtnCalcular.Text = "Registrar Datos"
        BtnCalcular.UseCompatibleTextRendering = True
        BtnCalcular.UseVisualStyleBackColor = False
        ' 
        ' TxbAguaAlmacenada
        ' 
        TxbAguaAlmacenada.Location = New Point(122, 97)
        TxbAguaAlmacenada.Name = "TxbAguaAlmacenada"
        TxbAguaAlmacenada.Size = New Size(100, 23)
        TxbAguaAlmacenada.TabIndex = 7
        TxbAguaAlmacenada.WordWrap = False
        ' 
        ' txtCapacidadTotal
        ' 
        txtCapacidadTotal.Location = New Point(122, 64)
        txtCapacidadTotal.Name = "txtCapacidadTotal"
        txtCapacidadTotal.Size = New Size(100, 23)
        txtCapacidadTotal.TabIndex = 6
        txtCapacidadTotal.WordWrap = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 15)
        Label3.TabIndex = 5
        Label3.Text = "Capacidad Requerida"
        ' 
        ' lblAguaAlmacenada
        ' 
        lblAguaAlmacenada.AutoSize = True
        lblAguaAlmacenada.Location = New Point(62, 105)
        lblAguaAlmacenada.Name = "lblAguaAlmacenada"
        lblAguaAlmacenada.Size = New Size(54, 15)
        lblAguaAlmacenada.TabIndex = 4
        lblAguaAlmacenada.Text = "Volumen"
        ' 
        ' LblCapacidadtotal
        ' 
        LblCapacidadtotal.AutoSize = True
        LblCapacidadtotal.Location = New Point(9, 68)
        LblCapacidadtotal.Name = "LblCapacidadtotal"
        LblCapacidadtotal.Size = New Size(108, 15)
        LblCapacidadtotal.TabIndex = 2
        LblCapacidadtotal.Text = "Capacidad Total (L)"
        ' 
        ' LblDatosTanque
        ' 
        LblDatosTanque.AutoSize = True
        LblDatosTanque.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblDatosTanque.Location = New Point(39, 20)
        LblDatosTanque.Name = "LblDatosTanque"
        LblDatosTanque.Size = New Size(165, 25)
        LblDatosTanque.TabIndex = 0
        LblDatosTanque.Text = "Datos del Tanque"
        ' 
        ' PnlCalculodemanda
        ' 
        PnlCalculodemanda.BackColor = Color.White
        PnlCalculodemanda.Controls.Add(BtnCalculoDemanda)
        PnlCalculodemanda.Controls.Add(TxtCDias)
        PnlCalculodemanda.Controls.Add(TxtCConsumo)
        PnlCalculodemanda.Controls.Add(TxtcNumero)
        PnlCalculodemanda.Controls.Add(LblCalculo2)
        PnlCalculodemanda.Controls.Add(LblCalculo3)
        PnlCalculodemanda.Controls.Add(LblCalculo1)
        PnlCalculodemanda.Controls.Add(LblCal2)
        PnlCalculodemanda.Controls.Add(LblCalculo)
        PnlCalculodemanda.Location = New Point(30, 80)
        PnlCalculodemanda.Name = "PnlCalculodemanda"
        PnlCalculodemanda.Size = New Size(308, 217)
        PnlCalculodemanda.TabIndex = 5
        ' 
        ' BtnCalculoDemanda
        ' 
        BtnCalculoDemanda.BackColor = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        BtnCalculoDemanda.FlatStyle = FlatStyle.Flat
        BtnCalculoDemanda.ForeColor = Color.White
        BtnCalculoDemanda.Location = New Point(116, 178)
        BtnCalculoDemanda.Name = "BtnCalculoDemanda"
        BtnCalculoDemanda.Size = New Size(75, 23)
        BtnCalculoDemanda.TabIndex = 9
        BtnCalculoDemanda.Text = "Calcular"
        BtnCalculoDemanda.UseCompatibleTextRendering = True
        BtnCalculoDemanda.UseVisualStyleBackColor = False
        ' 
        ' TxtCDias
        ' 
        TxtCDias.Location = New Point(192, 138)
        TxtCDias.Name = "TxtCDias"
        TxtCDias.Size = New Size(100, 23)
        TxtCDias.TabIndex = 8
        TxtCDias.WordWrap = False
        ' 
        ' TxtCConsumo
        ' 
        TxtCConsumo.Location = New Point(192, 102)
        TxtCConsumo.Name = "TxtCConsumo"
        TxtCConsumo.Size = New Size(100, 23)
        TxtCConsumo.TabIndex = 7
        TxtCConsumo.WordWrap = False
        ' 
        ' TxtcNumero
        ' 
        TxtcNumero.Location = New Point(192, 69)
        TxtcNumero.Name = "TxtcNumero"
        TxtcNumero.Size = New Size(100, 23)
        TxtcNumero.TabIndex = 6
        TxtcNumero.WordWrap = False
        ' 
        ' LblCalculo2
        ' 
        LblCalculo2.AutoSize = True
        LblCalculo2.Location = New Point(21, 109)
        LblCalculo2.Name = "LblCalculo2"
        LblCalculo2.Size = New Size(158, 15)
        LblCalculo2.TabIndex = 4
        LblCalculo2.Text = "Consumo diario por persona"
        ' 
        ' LblCalculo3
        ' 
        LblCalculo3.AutoSize = True
        LblCalculo3.Location = New Point(73, 147)
        LblCalculo3.Name = "LblCalculo3"
        LblCalculo3.Size = New Size(106, 15)
        LblCalculo3.TabIndex = 3
        LblCalculo3.Text = "Dias de autonomía"
        ' 
        ' LblCalculo1
        ' 
        LblCalculo1.AutoSize = True
        LblCalculo1.Location = New Point(51, 76)
        LblCalculo1.Name = "LblCalculo1"
        LblCalculo1.Size = New Size(127, 15)
        LblCalculo1.TabIndex = 2
        LblCalculo1.Text = "Numero de Habitantes"
        ' 
        ' LblCal2
        ' 
        LblCal2.AutoSize = True
        LblCal2.Location = New Point(51, 38)
        LblCal2.Name = "LblCal2"
        LblCal2.Size = New Size(129, 15)
        LblCal2.TabIndex = 1
        LblCal2.Text = "Datos de la comunidad"
        ' 
        ' LblCalculo
        ' 
        LblCalculo.AutoSize = True
        LblCalculo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCalculo.Location = New Point(21, 17)
        LblCalculo.Name = "LblCalculo"
        LblCalculo.Size = New Size(220, 25)
        LblCalculo.TabIndex = 0
        LblCalculo.Text = "👨‍👩‍👧‍👧 Calculo de Demanda"
        ' 
        ' PnlDisponible
        ' 
        PnlDisponible.BackColor = Color.White
        PnlDisponible.Controls.Add(LblVolumenal)
        PnlDisponible.Controls.Add(Lbldispo)
        PnlDisponible.Controls.Add(LblDispoible)
        PnlDisponible.Location = New Point(758, 296)
        PnlDisponible.Name = "PnlDisponible"
        PnlDisponible.Size = New Size(175, 116)
        PnlDisponible.TabIndex = 4
        ' 
        ' LblVolumenal
        ' 
        LblVolumenal.AutoSize = True
        LblVolumenal.Location = New Point(15, 84)
        LblVolumenal.Name = "LblVolumenal"
        LblVolumenal.Size = New Size(124, 15)
        LblVolumenal.TabIndex = 3
        LblVolumenal.Text = "Volumen Almacenado"
        ' 
        ' Lbldispo
        ' 
        Lbldispo.AutoSize = True
        Lbldispo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbldispo.Location = New Point(70, 44)
        Lbldispo.Name = "Lbldispo"
        Lbldispo.Size = New Size(38, 25)
        Lbldispo.TabIndex = 1
        Lbldispo.Text = "--L"
        ' 
        ' LblDispoible
        ' 
        LblDispoible.AutoSize = True
        LblDispoible.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblDispoible.Location = New Point(14, 11)
        LblDispoible.Name = "LblDispoible"
        LblDispoible.Size = New Size(150, 21)
        LblDispoible.TabIndex = 0
        LblDispoible.Text = "♒ Agua Disponible"
        ' 
        ' PnlCapacidadTanque
        ' 
        PnlCapacidadTanque.BackColor = Color.White
        PnlCapacidadTanque.Controls.Add(Lblvolumenmx)
        PnlCapacidadTanque.Controls.Add(LblCapa)
        PnlCapacidadTanque.Controls.Add(LblCapacidad)
        PnlCapacidadTanque.Location = New Point(564, 68)
        PnlCapacidadTanque.Name = "PnlCapacidadTanque"
        PnlCapacidadTanque.Size = New Size(175, 116)
        PnlCapacidadTanque.TabIndex = 3
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
        ' LblCapa
        ' 
        LblCapa.AutoSize = True
        LblCapa.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCapa.Location = New Point(65, 49)
        LblCapa.Name = "LblCapa"
        LblCapa.Size = New Size(38, 25)
        LblCapa.TabIndex = 1
        LblCapa.Text = "--L"
        ' 
        ' LblCapacidad
        ' 
        LblCapacidad.AutoSize = True
        LblCapacidad.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblCapacidad.Location = New Point(7, 12)
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
        SbAlmacenamiento.Location = New Point(42, 43)
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
        LblTituloalmacenamiento.Location = New Point(40, 17)
        LblTituloalmacenamiento.Name = "LblTituloalmacenamiento"
        LblTituloalmacenamiento.Size = New Size(206, 28)
        LblTituloalmacenamiento.TabIndex = 0
        LblTituloalmacenamiento.Text = "Almacenamiento"
        ' 
        ' IcAlmacenamiento
        ' 
        IcAlmacenamiento.AutoSize = True
        IcAlmacenamiento.BackColor = Color.Transparent
        IcAlmacenamiento.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        IcAlmacenamiento.ForeColor = SystemColors.HotTrack
        IcAlmacenamiento.Location = New Point(-1, 14)
        IcAlmacenamiento.Name = "IcAlmacenamiento"
        IcAlmacenamiento.Size = New Size(64, 45)
        IcAlmacenamiento.TabIndex = 2
        IcAlmacenamiento.Text = "🛢️"
        ' 
        ' FrmAlmacenamiento
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.White
        ClientSize = New Size(1187, 550)
        Controls.Add(PnlAlmacenamiento)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmAlmacenamiento"
        Text = "FrmAlmacenamiento"
        PnlAlmacenamiento.ResumeLayout(False)
        PnlAlmacenamiento.PerformLayout()
        PnlCapacidadDemandada.ResumeLayout(False)
        PnlCapacidadDemandada.PerformLayout()
        PnlEvaluacion.ResumeLayout(False)
        PnlEvaluacion.PerformLayout()
        PnlDatosTanque.ResumeLayout(False)
        PnlDatosTanque.PerformLayout()
        PnlCalculodemanda.ResumeLayout(False)
        PnlCalculodemanda.PerformLayout()
        PnlDisponible.ResumeLayout(False)
        PnlDisponible.PerformLayout()
        PnlCapacidadTanque.ResumeLayout(False)
        PnlCapacidadTanque.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PnlAlmacenamiento As PanelRedondeado
    Friend WithEvents pnlUmage As PanelRedondeado
    Friend WithEvents PnlCapacidadDemandada As PanelRedondeado
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblCapacidaddemanda As Label
    Friend WithEvents PnlEvaluacion As PanelRedondeado
    Friend WithEvents Txtevaluacion As TextBox
    Friend WithEvents LblNotificacionevaluacion As Label
    Friend WithEvents LblEvaluacion As Label
    Friend WithEvents PnlDatosTanque As PanelRedondeado
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents TxbAguaAlmacenada As TextBox
    Friend WithEvents txtCapacidadTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAguaAlmacenada As Label
    Friend WithEvents LblCapacidadtotal As Label
    Friend WithEvents LblDatosTanque As Label
    Friend WithEvents PnlCalculodemanda As PanelRedondeado
    Friend WithEvents BtnCalculoDemanda As Button
    Friend WithEvents TxtCDias As TextBox
    Friend WithEvents TxtCConsumo As TextBox
    Friend WithEvents TxtcNumero As TextBox
    Friend WithEvents LblCalculo2 As Label
    Friend WithEvents LblCalculo3 As Label
    Friend WithEvents LblCalculo1 As Label
    Friend WithEvents LblCal2 As Label
    Friend WithEvents LblCalculo As Label
    Friend WithEvents PnlDisponible As PanelRedondeado
    Friend WithEvents LblVolumenal As Label
    Friend WithEvents Lbldispo As Label
    Friend WithEvents LblDispoible As Label
    Friend WithEvents PnlCapacidadTanque As PanelRedondeado
    Friend WithEvents Lblvolumenmx As Label
    Friend WithEvents LblCapa As Label
    Friend WithEvents LblCapacidad As Label
    Friend WithEvents SbAlmacenamiento As Label
    Friend WithEvents LblTituloalmacenamiento As Label
    Friend WithEvents IcAlmacenamiento As Label
End Class
