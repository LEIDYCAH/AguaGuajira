

Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class TextBoxRedondeado
    Inherits UserControl

    Private CampoTexto As New TextBox()

    Private _RadioEsquinas As Integer = 12
    Private _ColorBorde As Color = Color.FromArgb(129, 120, 207)
    Private _GrosorBorde As Single = 1.5F

    Public Sub New()

        Me.SetStyle(
            ControlStyles.UserPaint Or
            ControlStyles.AllPaintingInWmPaint Or
            ControlStyles.OptimizedDoubleBuffer Or
            ControlStyles.ResizeRedraw, True
        )

        Me.Size = New Size(220, 38)
        Me.BackColor = Color.White
        Me.Padding = New Padding(10, 5, 10, 5)

        CampoTexto.BorderStyle = BorderStyle.None
        CampoTexto.Dock = DockStyle.Fill
        CampoTexto.Font = New Font("Segoe UI", 10)
        CampoTexto.BackColor = Color.White
        CampoTexto.ForeColor = Color.FromArgb(41, 38, 79)
        CampoTexto.Multiline = True
        CampoTexto.ScrollBars = ScrollBars.Vertical
        CampoTexto.WordWrap = True
        CampoTexto.TextAlign = HorizontalAlignment.Center

        Me.Controls.Add(CampoTexto)

    End Sub

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property RadioEsquinas As Integer
        Get
            Return _RadioEsquinas
        End Get
        Set(value As Integer)
            _RadioEsquinas = Math.Max(0, value)
            Me.Invalidate()
        End Set
    End Property


    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property ColorBorde As Color
        Get
            Return _ColorBorde
        End Get
        Set(value As Color)
            _ColorBorde = value
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property GrosorBorde As Single
        Get
            Return _GrosorBorde
        End Get
        Set(value As Single)
            _GrosorBorde = Math.Max(0.5F, value)
            Me.Invalidate()
        End Set
    End Property

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property Multiline As Boolean
        Get
            Return CampoTexto.Multiline
        End Get
        Set(value As Boolean)
            CampoTexto.Multiline = value
        End Set
    End Property

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property ScrollBars As System.Windows.Forms.ScrollBars
        Get
            Return CampoTexto.ScrollBars
        End Get
        Set(value As System.Windows.Forms.ScrollBars)
            CampoTexto.ScrollBars = value
        End Set
    End Property

    <Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property WordWrap As Boolean
        Get
            Return CampoTexto.WordWrap
        End Get
        Set(value As Boolean)
            CampoTexto.WordWrap = value
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return CampoTexto.Text
        End Get
        Set(value As String)
            CampoTexto.Text = value
        End Set
    End Property

    Public Overrides Property Font As Font
        Get
            Return CampoTexto.Font
        End Get
        Set(value As Font)
            CampoTexto.Font = value
            Me.Invalidate()
        End Set
    End Property

    Public Overrides Property ForeColor As Color
        Get
            Return CampoTexto.ForeColor
        End Get
        Set(value As Color)
            CampoTexto.ForeColor = value
        End Set
    End Property

    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
            CampoTexto.BackColor = value
            Me.Invalidate()
        End Set

    End Property


    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New RectangleF(
            _GrosorBorde,
            _GrosorBorde,
            Me.Width - _GrosorBorde * 2,
            Me.Height - _GrosorBorde * 2
        )

        Dim diametro As Single = Math.Min(
            _RadioEsquinas * 2,
            Math.Min(rect.Width, rect.Height)
        )

        Using ruta As New GraphicsPath()

            ruta.AddArc(rect.X, rect.Y, diametro, diametro, 180, 90)
            ruta.AddArc(rect.Right - diametro, rect.Y, diametro, diametro, 270, 90)
            ruta.AddArc(rect.Right - diametro, rect.Bottom - diametro, diametro, diametro, 0, 90)
            ruta.AddArc(rect.X, rect.Bottom - diametro, diametro, diametro, 90, 90)
            ruta.CloseFigure()

            Using pincel As New Pen(_ColorBorde, _GrosorBorde)
                e.Graphics.DrawPath(pincel, ruta)
            End Using

            Me.Region?.Dispose()
            Me.Region = New Region(ruta)

        End Using

    End Sub

    Public Sub Clear()
        CampoTexto.Clear()
    End Sub

End Class
