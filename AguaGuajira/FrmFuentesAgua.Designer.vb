<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFuentesAgua
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
        LblTituloFuentes = New Label()
        LblSubFuente = New Label()
        PnlCardLluvia = New PanelRedondeado()
        TxtCaptacion = New TextBoxRedondeado()
        Lblcardcaptacion = New Label()
        LblCaptacion = New Label()
        PnlPozos = New PanelRedondeado()
        Txtpozos = New TextBoxRedondeado()
        LblSubPozos = New Label()
        LblCardPozos = New Label()
        PnlJagueyes = New PanelRedondeado()
        TxtJagueyes = New TextBoxRedondeado()
        Lbljagueyes = New Label()
        LblCardJaueyes = New Label()
        PnlTotal = New PanelRedondeado()
        TxtFuentes = New TextBoxRedondeado()
        Lblsubtotal = New Label()
        LblCardTotal = New Label()
        PnlRegistrar = New PanelRedondeado()
        TxtIdentificador = New TextBoxRedondeado()
        CmbEstado = New ComboBox()
        BtnRegistrar = New Button()
        LblEstado = New Label()
        TxtCapacidad = New TextBoxRedondeado()
        LblCapacidad = New Label()
        TxbUbicacion = New TextBoxRedondeado()
        LblUbicacion = New Label()
        TxtFuente = New TextBoxRedondeado()
        Label1 = New Label()
        CmbTIpo = New ComboBox()
        LblTipofuente = New Label()
        LblId = New Label()
        LblRegistrar = New Label()
        PnlHistorialF = New PanelRedondeado()
        DtgFuentesAgua = New DataGridView()
        LblTituloHistorialFuentes = New Label()
        PnlCardLluvia.SuspendLayout()
        PnlPozos.SuspendLayout()
        PnlJagueyes.SuspendLayout()
        PnlTotal.SuspendLayout()
        PnlRegistrar.SuspendLayout()
        PnlHistorialF.SuspendLayout()
        CType(DtgFuentesAgua, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblTituloFuentes
        ' 
        LblTituloFuentes.AutoSize = True
        LblTituloFuentes.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTituloFuentes.Location = New Point(42, 28)
        LblTituloFuentes.Name = "LblTituloFuentes"
        LblTituloFuentes.Size = New Size(439, 37)
        LblTituloFuentes.TabIndex = 0
        LblTituloFuentes.Text = "‧₊˚ ⛲️ ‧₊ Gestión de fuentes de agua"
        ' 
        ' LblSubFuente
        ' 
        LblSubFuente.AutoSize = True
        LblSubFuente.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSubFuente.ForeColor = Color.FromArgb(CByte(112), CByte(108), CByte(145))
        LblSubFuente.Location = New Point(51, 65)
        LblSubFuente.Name = "LblSubFuente"
        LblSubFuente.Size = New Size(531, 17)
        LblSubFuente.TabIndex = 1
        LblSubFuente.Text = "Administración y seguimiento de los puntos de abastecimiento de agua de la comunidad."
        ' 
        ' PnlCardLluvia
        ' 
        PnlCardLluvia.Anchor = AnchorStyles.None
        PnlCardLluvia.BackColor = Color.White
        PnlCardLluvia.Controls.Add(TxtCaptacion)
        PnlCardLluvia.Controls.Add(Lblcardcaptacion)
        PnlCardLluvia.Controls.Add(LblCaptacion)
        PnlCardLluvia.Enabled = False
        PnlCardLluvia.ForeColor = Color.Black
        PnlCardLluvia.Location = New Point(539, 279)
        PnlCardLluvia.Name = "PnlCardLluvia"
        PnlCardLluvia.RadioEsquinas = 15
        PnlCardLluvia.Size = New Size(171, 115)
        PnlCardLluvia.TabIndex = 2
        ' 
        ' TxtCaptacion
        ' 
        TxtCaptacion.BackColor = Color.White
        TxtCaptacion.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtCaptacion.GrosorBorde = 1.5F
        TxtCaptacion.Location = New Point(18, 49)
        TxtCaptacion.Multiline = False
        TxtCaptacion.Name = "TxtCaptacion"
        TxtCaptacion.Padding = New Padding(10, 5, 10, 5)
        TxtCaptacion.RadioEsquinas = 12
        TxtCaptacion.ScrollBars = ScrollBars.Vertical
        TxtCaptacion.Size = New Size(137, 31)
        TxtCaptacion.TabIndex = 4
        TxtCaptacion.WordWrap = True
        ' 
        ' Lblcardcaptacion
        ' 
        Lblcardcaptacion.AutoSize = True
        Lblcardcaptacion.Location = New Point(34, 91)
        Lblcardcaptacion.Name = "Lblcardcaptacion"
        Lblcardcaptacion.Size = New Size(105, 15)
        Lblcardcaptacion.TabIndex = 2
        Lblcardcaptacion.Text = "Puntos registrados"
        ' 
        ' LblCaptacion
        ' 
        LblCaptacion.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        LblCaptacion.AutoSize = True
        LblCaptacion.Location = New Point(34, 15)
        LblCaptacion.Name = "LblCaptacion"
        LblCaptacion.Size = New Size(108, 15)
        LblCaptacion.TabIndex = 0
        LblCaptacion.Text = "Captación de lluvia"
        LblCaptacion.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PnlPozos
        ' 
        PnlPozos.Anchor = AnchorStyles.None
        PnlPozos.BackColor = Color.White
        PnlPozos.Controls.Add(Txtpozos)
        PnlPozos.Controls.Add(LblSubPozos)
        PnlPozos.Controls.Add(LblCardPozos)
        PnlPozos.ForeColor = Color.Black
        PnlPozos.Location = New Point(728, 282)
        PnlPozos.Name = "PnlPozos"
        PnlPozos.RadioEsquinas = 15
        PnlPozos.Size = New Size(171, 115)
        PnlPozos.TabIndex = 3
        ' 
        ' Txtpozos
        ' 
        Txtpozos.BackColor = Color.White
        Txtpozos.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        Txtpozos.Enabled = False
        Txtpozos.GrosorBorde = 1.5F
        Txtpozos.Location = New Point(25, 44)
        Txtpozos.Multiline = False
        Txtpozos.Name = "Txtpozos"
        Txtpozos.Padding = New Padding(10, 5, 10, 5)
        Txtpozos.RadioEsquinas = 12
        Txtpozos.ScrollBars = ScrollBars.Vertical
        Txtpozos.Size = New Size(137, 31)
        Txtpozos.TabIndex = 5
        Txtpozos.WordWrap = True
        ' 
        ' LblSubPozos
        ' 
        LblSubPozos.AutoSize = True
        LblSubPozos.Location = New Point(23, 91)
        LblSubPozos.Name = "LblSubPozos"
        LblSubPozos.Size = New Size(109, 15)
        LblSubPozos.TabIndex = 2
        LblSubPozos.Text = "Fuentes registrados"
        ' 
        ' LblCardPozos
        ' 
        LblCardPozos.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        LblCardPozos.AutoSize = True
        LblCardPozos.Location = New Point(68, 13)
        LblCardPozos.Name = "LblCardPozos"
        LblCardPozos.Size = New Size(38, 15)
        LblCardPozos.TabIndex = 0
        LblCardPozos.Text = "Pozos"
        LblCardPozos.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PnlJagueyes
        ' 
        PnlJagueyes.Anchor = AnchorStyles.None
        PnlJagueyes.BackColor = Color.White
        PnlJagueyes.Controls.Add(TxtJagueyes)
        PnlJagueyes.Controls.Add(Lbljagueyes)
        PnlJagueyes.Controls.Add(LblCardJaueyes)
        PnlJagueyes.ForeColor = Color.Black
        PnlJagueyes.Location = New Point(539, 142)
        PnlJagueyes.Name = "PnlJagueyes"
        PnlJagueyes.RadioEsquinas = 15
        PnlJagueyes.Size = New Size(171, 115)
        PnlJagueyes.TabIndex = 4
        ' 
        ' TxtJagueyes
        ' 
        TxtJagueyes.BackColor = Color.White
        TxtJagueyes.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtJagueyes.Enabled = False
        TxtJagueyes.GrosorBorde = 1.5F
        TxtJagueyes.Location = New Point(16, 45)
        TxtJagueyes.Multiline = False
        TxtJagueyes.Name = "TxtJagueyes"
        TxtJagueyes.Padding = New Padding(10, 5, 10, 5)
        TxtJagueyes.RadioEsquinas = 12
        TxtJagueyes.ScrollBars = ScrollBars.Vertical
        TxtJagueyes.Size = New Size(137, 31)
        TxtJagueyes.TabIndex = 3
        TxtJagueyes.WordWrap = True
        ' 
        ' Lbljagueyes
        ' 
        Lbljagueyes.AutoSize = True
        Lbljagueyes.Location = New Point(22, 91)
        Lbljagueyes.Name = "Lbljagueyes"
        Lbljagueyes.Size = New Size(130, 15)
        Lbljagueyes.TabIndex = 2
        Lbljagueyes.Text = "Reservorias Registrados"
        ' 
        ' LblCardJaueyes
        ' 
        LblCardJaueyes.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        LblCardJaueyes.AutoSize = True
        LblCardJaueyes.Location = New Point(34, 15)
        LblCardJaueyes.Name = "LblCardJaueyes"
        LblCardJaueyes.Size = New Size(54, 15)
        LblCardJaueyes.TabIndex = 0
        LblCardJaueyes.Text = "Jagüeyes"
        LblCardJaueyes.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PnlTotal
        ' 
        PnlTotal.Anchor = AnchorStyles.None
        PnlTotal.BackColor = Color.White
        PnlTotal.Controls.Add(TxtFuentes)
        PnlTotal.Controls.Add(Lblsubtotal)
        PnlTotal.Controls.Add(LblCardTotal)
        PnlTotal.ForeColor = Color.Black
        PnlTotal.Location = New Point(728, 142)
        PnlTotal.Name = "PnlTotal"
        PnlTotal.RadioEsquinas = 15
        PnlTotal.Size = New Size(171, 115)
        PnlTotal.TabIndex = 5
        ' 
        ' TxtFuentes
        ' 
        TxtFuentes.BackColor = Color.White
        TxtFuentes.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtFuentes.Enabled = False
        TxtFuentes.GrosorBorde = 1.5F
        TxtFuentes.Location = New Point(20, 45)
        TxtFuentes.Multiline = False
        TxtFuentes.Name = "TxtFuentes"
        TxtFuentes.Padding = New Padding(10, 5, 10, 5)
        TxtFuentes.RadioEsquinas = 12
        TxtFuentes.ScrollBars = ScrollBars.Vertical
        TxtFuentes.Size = New Size(137, 31)
        TxtFuentes.TabIndex = 4
        TxtFuentes.WordWrap = True
        ' 
        ' Lblsubtotal
        ' 
        Lblsubtotal.AutoSize = True
        Lblsubtotal.Location = New Point(25, 91)
        Lblsubtotal.Name = "Lblsubtotal"
        Lblsubtotal.Size = New Size(130, 15)
        Lblsubtotal.TabIndex = 2
        Lblsubtotal.Text = "Reservorias Registrados"
        ' 
        ' LblCardTotal
        ' 
        LblCardTotal.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        LblCardTotal.AutoSize = True
        LblCardTotal.Location = New Point(25, 15)
        LblCardTotal.Name = "LblCardTotal"
        LblCardTotal.Size = New Size(92, 15)
        LblCardTotal.TabIndex = 0
        LblCardTotal.Text = "Total de Fuentes"
        LblCardTotal.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PnlRegistrar
        ' 
        PnlRegistrar.BackColor = Color.White
        PnlRegistrar.Controls.Add(TxtIdentificador)
        PnlRegistrar.Controls.Add(CmbEstado)
        PnlRegistrar.Controls.Add(BtnRegistrar)
        PnlRegistrar.Controls.Add(LblEstado)
        PnlRegistrar.Controls.Add(TxtCapacidad)
        PnlRegistrar.Controls.Add(LblCapacidad)
        PnlRegistrar.Controls.Add(TxbUbicacion)
        PnlRegistrar.Controls.Add(LblUbicacion)
        PnlRegistrar.Controls.Add(TxtFuente)
        PnlRegistrar.Controls.Add(Label1)
        PnlRegistrar.Controls.Add(CmbTIpo)
        PnlRegistrar.Controls.Add(LblTipofuente)
        PnlRegistrar.Controls.Add(LblId)
        PnlRegistrar.Controls.Add(LblRegistrar)
        PnlRegistrar.Location = New Point(63, 119)
        PnlRegistrar.Name = "PnlRegistrar"
        PnlRegistrar.Size = New Size(455, 313)
        PnlRegistrar.TabIndex = 6
        ' 
        ' TxtIdentificador
        ' 
        TxtIdentificador.BackColor = Color.White
        TxtIdentificador.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtIdentificador.Enabled = False
        TxtIdentificador.GrosorBorde = 1.5F
        TxtIdentificador.Location = New Point(261, 87)
        TxtIdentificador.Multiline = False
        TxtIdentificador.Name = "TxtIdentificador"
        TxtIdentificador.Padding = New Padding(10, 5, 10, 5)
        TxtIdentificador.RadioEsquinas = 12
        TxtIdentificador.ScrollBars = ScrollBars.Vertical
        TxtIdentificador.Size = New Size(161, 31)
        TxtIdentificador.TabIndex = 15
        TxtIdentificador.WordWrap = True
        ' 
        ' CmbEstado
        ' 
        CmbEstado.BackColor = Color.Gainsboro
        CmbEstado.FormattingEnabled = True
        CmbEstado.Location = New Point(261, 228)
        CmbEstado.Name = "CmbEstado"
        CmbEstado.Size = New Size(157, 23)
        CmbEstado.TabIndex = 14
        ' 
        ' BtnRegistrar
        ' 
        BtnRegistrar.Location = New Point(158, 268)
        BtnRegistrar.Name = "BtnRegistrar"
        BtnRegistrar.Size = New Size(133, 33)
        BtnRegistrar.TabIndex = 13
        BtnRegistrar.Text = "Registrar Fuente"
        BtnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' LblEstado
        ' 
        LblEstado.AutoSize = True
        LblEstado.Location = New Point(319, 203)
        LblEstado.Name = "LblEstado"
        LblEstado.Size = New Size(42, 15)
        LblEstado.TabIndex = 11
        LblEstado.Text = "Estado"
        ' 
        ' TxtCapacidad
        ' 
        TxtCapacidad.BackColor = Color.White
        TxtCapacidad.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtCapacidad.GrosorBorde = 1.5F
        TxtCapacidad.Location = New Point(34, 224)
        TxtCapacidad.Multiline = False
        TxtCapacidad.Name = "TxtCapacidad"
        TxtCapacidad.Padding = New Padding(10, 5, 10, 5)
        TxtCapacidad.RadioEsquinas = 12
        TxtCapacidad.ScrollBars = ScrollBars.Vertical
        TxtCapacidad.Size = New Size(157, 31)
        TxtCapacidad.TabIndex = 10
        TxtCapacidad.WordWrap = True
        ' 
        ' LblCapacidad
        ' 
        LblCapacidad.AutoSize = True
        LblCapacidad.Location = New Point(59, 203)
        LblCapacidad.Name = "LblCapacidad"
        LblCapacidad.Size = New Size(114, 15)
        LblCapacidad.TabIndex = 9
        LblCapacidad.Text = "Capacidad Estimada"
        ' 
        ' TxbUbicacion
        ' 
        TxbUbicacion.BackColor = Color.White
        TxbUbicacion.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxbUbicacion.GrosorBorde = 1.5F
        TxbUbicacion.Location = New Point(261, 161)
        TxbUbicacion.Multiline = False
        TxbUbicacion.Name = "TxbUbicacion"
        TxbUbicacion.Padding = New Padding(10, 5, 10, 5)
        TxbUbicacion.RadioEsquinas = 12
        TxbUbicacion.ScrollBars = ScrollBars.Vertical
        TxbUbicacion.Size = New Size(157, 31)
        TxbUbicacion.TabIndex = 8
        TxbUbicacion.WordWrap = True
        ' 
        ' LblUbicacion
        ' 
        LblUbicacion.AutoSize = True
        LblUbicacion.Location = New Point(311, 138)
        LblUbicacion.Name = "LblUbicacion"
        LblUbicacion.Size = New Size(60, 15)
        LblUbicacion.TabIndex = 7
        LblUbicacion.Text = "Ubicacion"
        ' 
        ' TxtFuente
        ' 
        TxtFuente.BackColor = Color.White
        TxtFuente.ColorBorde = Color.FromArgb(CByte(129), CByte(120), CByte(207))
        TxtFuente.GrosorBorde = 1.5F
        TxtFuente.Location = New Point(34, 161)
        TxtFuente.Multiline = False
        TxtFuente.Name = "TxtFuente"
        TxtFuente.Padding = New Padding(10, 5, 10, 5)
        TxtFuente.RadioEsquinas = 12
        TxtFuente.ScrollBars = ScrollBars.Vertical
        TxtFuente.Size = New Size(152, 31)
        TxtFuente.TabIndex = 6
        TxtFuente.WordWrap = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 15)
        Label1.TabIndex = 5
        Label1.Text = "Nombre de la fuente"
        ' 
        ' CmbTIpo
        ' 
        CmbTIpo.BackColor = Color.Gainsboro
        CmbTIpo.FormattingEnabled = True
        CmbTIpo.Location = New Point(32, 95)
        CmbTIpo.Name = "CmbTIpo"
        CmbTIpo.Size = New Size(154, 23)
        CmbTIpo.TabIndex = 4
        ' 
        ' LblTipofuente
        ' 
        LblTipofuente.AutoSize = True
        LblTipofuente.Location = New Point(77, 65)
        LblTipofuente.Name = "LblTipofuente"
        LblTipofuente.Size = New Size(83, 15)
        LblTipofuente.TabIndex = 2
        LblTipofuente.Text = "Tipo de fuente"
        ' 
        ' LblId
        ' 
        LblId.AutoSize = True
        LblId.Location = New Point(297, 63)
        LblId.Name = "LblId"
        LblId.Size = New Size(74, 15)
        LblId.TabIndex = 1
        LblId.Text = "Identificador"
        ' 
        ' LblRegistrar
        ' 
        LblRegistrar.AutoSize = True
        LblRegistrar.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblRegistrar.Location = New Point(15, 23)
        LblRegistrar.Name = "LblRegistrar"
        LblRegistrar.Size = New Size(252, 21)
        LblRegistrar.TabIndex = 0
        LblRegistrar.Text = "📝 Registrar nueva fuente de agua"
        ' 
        ' PnlHistorialF
        ' 
        PnlHistorialF.AutoSize = True
        PnlHistorialF.BackColor = Color.White
        PnlHistorialF.Controls.Add(DtgFuentesAgua)
        PnlHistorialF.Controls.Add(LblTituloHistorialFuentes)
        PnlHistorialF.Location = New Point(34, 455)
        PnlHistorialF.Name = "PnlHistorialF"
        PnlHistorialF.RadioEsquinas = 15
        PnlHistorialF.Size = New Size(905, 252)
        PnlHistorialF.TabIndex = 7
        ' 
        ' DtgFuentesAgua
        ' 
        DtgFuentesAgua.AllowUserToAddRows = False
        DtgFuentesAgua.AllowUserToDeleteRows = False
        DtgFuentesAgua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DtgFuentesAgua.BorderStyle = BorderStyle.Fixed3D
        DtgFuentesAgua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DtgFuentesAgua.Location = New Point(27, 56)
        DtgFuentesAgua.MultiSelect = False
        DtgFuentesAgua.Name = "DtgFuentesAgua"
        DtgFuentesAgua.ReadOnly = True
        DtgFuentesAgua.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DtgFuentesAgua.Size = New Size(853, 174)
        DtgFuentesAgua.TabIndex = 1
        ' 
        ' LblTituloHistorialFuentes
        ' 
        LblTituloHistorialFuentes.AutoSize = True
        LblTituloHistorialFuentes.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTituloHistorialFuentes.Location = New Point(29, 18)
        LblTituloHistorialFuentes.Name = "LblTituloHistorialFuentes"
        LblTituloHistorialFuentes.Size = New Size(178, 25)
        LblTituloHistorialFuentes.TabIndex = 0
        LblTituloHistorialFuentes.Text = "⏳ Historial Fuentes"
        ' 
        ' FrmFuentesAgua
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(241), CByte(239), CByte(251))
        ClientSize = New Size(1072, 706)
        Controls.Add(PnlHistorialF)
        Controls.Add(PnlRegistrar)
        Controls.Add(PnlTotal)
        Controls.Add(PnlJagueyes)
        Controls.Add(PnlPozos)
        Controls.Add(PnlCardLluvia)
        Controls.Add(LblSubFuente)
        Controls.Add(LblTituloFuentes)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmFuentesAgua"
        StartPosition = FormStartPosition.Manual
        Text = "FrmFuentesAgua"
        PnlCardLluvia.ResumeLayout(False)
        PnlCardLluvia.PerformLayout()
        PnlPozos.ResumeLayout(False)
        PnlPozos.PerformLayout()
        PnlJagueyes.ResumeLayout(False)
        PnlJagueyes.PerformLayout()
        PnlTotal.ResumeLayout(False)
        PnlTotal.PerformLayout()
        PnlRegistrar.ResumeLayout(False)
        PnlRegistrar.PerformLayout()
        PnlHistorialF.ResumeLayout(False)
        PnlHistorialF.PerformLayout()
        CType(DtgFuentesAgua, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LblSubFuente As Label
    Friend WithEvents PnlCardLluvia As PanelRedondeado
    Friend WithEvents LblCaptacion As Label
    Friend WithEvents LblTituloFuentes As Label
    Friend WithEvents Lblcardcaptacion As Label
    Friend WithEvents PnlPozos As PanelRedondeado
    Friend WithEvents LblSubPozos As Label
    Friend WithEvents LblCardPozos As Label
    Friend WithEvents PnlJagueyes As PanelRedondeado
    Friend WithEvents Lbljagueyes As Label
    Friend WithEvents LblCardJaueyes As Label
    Friend WithEvents PnlTotal As PanelRedondeado
    Friend WithEvents Lblsubtotal As Label
    Friend WithEvents LblCardTotal As Label
    Friend WithEvents PnlRegistrar As PanelRedondeado
    Friend WithEvents LblTipofuente As Label
    Friend WithEvents LblId As Label
    Friend WithEvents LblRegistrar As Label
    Friend WithEvents TxtJagueyes As TextBoxRedondeado
    Friend WithEvents LblUbicacion As Label
    Friend WithEvents TxtFuente As TextBoxRedondeado
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbTIpo As ComboBox
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents LblEstado As Label
    Friend WithEvents TxtCapacidad As TextBoxRedondeado
    Friend WithEvents LblCapacidad As Label
    Friend WithEvents PnlHistorialF As PanelRedondeado
    Friend WithEvents LblTituloHistorialFuentes As Label
    Friend WithEvents DtgFuentesAgua As DataGridView
    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents TxtCaptacion As TextBoxRedondeado
    Friend WithEvents Txtpozos As TextBoxRedondeado
    Friend WithEvents TxtFuentes As TextBoxRedondeado
    Friend WithEvents TxbUbicacion As TextBoxRedondeado
    Friend WithEvents TxtIdentificador As TextBoxRedondeado

End Class
