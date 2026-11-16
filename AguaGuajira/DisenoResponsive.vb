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
    Optional anchoMenu As Integer = 220
)
        If anchoFormulario <= 900 Then

            menu.Visible = False

            botonMenu.Visible = True
            botonMenu.BringToFront()

        Else

            menu.Visible = True
            menu.Width = anchoMenu

            botonMenu.Visible = False

        End If

    End Sub

End Class
