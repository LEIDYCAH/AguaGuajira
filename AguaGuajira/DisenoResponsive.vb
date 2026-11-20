Imports System.Drawing
Imports System.Windows.Forms

    Public Class DisenoResponsive

        ' Ancho mínimo para considerar que estamos en modo tablet
        Private Const AnchoTablet As Integer = 900

    ' Ajusta el menú según el tamaño disponible
    Public Shared Sub AdaptarMenu(
    menu As Panel,
    botonMenu As Button,
    anchoFormulario As Integer,
    Optional anchoMenu As Integer = 158
)

        Dim modoCompacto As Boolean = anchoFormulario <= AnchoTablet

        menu.Visible = Not modoCompacto
        botonMenu.Visible = modoCompacto

        If Not modoCompacto Then
            menu.Width = anchoMenu
        Else
            botonMenu.BringToFront()
        End If

    End Sub


End Class
