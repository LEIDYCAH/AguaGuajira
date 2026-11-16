Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class PanelRedondeado
    Inherits Panel

    Private _radio As Integer = 20

    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    <DefaultValue(20)>
    Public Property RadioEsquinas As Integer

        Get
            Return _radio
        End Get

        Set(value As Integer)
            _radio = Math.Max(0, value)
            ActualizarForma()
        End Set

    End Property

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        ActualizarForma()
    End Sub

    Private Sub ActualizarForma()

        If Width <= 0 Or Height <= 0 Then Return

        Dim d As Integer = Math.Min(_radio * 2,
        Math.Min(Width, Height))

        Using ruta As New GraphicsPath()
            ruta.AddArc(0, 0, d, d, 180, 90)
            ruta.AddArc(Width - d, 0, d, d, 270, 90)
            ruta.AddArc(Width - d, Height - d, d, d, 0, 90)
            ruta.AddArc(0, Height - d, d, d, 90, 90)
            ruta.CloseFigure()
            Region = New Region(ruta)

        End Using

    End Sub

End Class

