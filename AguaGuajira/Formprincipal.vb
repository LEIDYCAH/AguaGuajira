Public Class frmprincipal
    Private menuExpandido As Boolean = False
    Private menuNavegacion As Menu
    Private formularioActual As Form = Nothing

    'Load del formulario principal

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs
) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        AdaptarInterfaz()

        menuNavegacion = New Menu(
    btnInicio,
    BtnCaptacion,
    BtnAlmacenamiento,
    BtnTratamiento,
    BtnMonitoreo,
    BtnReportes
)

        menuNavegacion.Seleccionar(btnInicio)

        PnlInicio.Visible = True
        PnlInicio.BringToFront()

    End Sub


    'Acciones Formulario Principal

    'Tamaño del formulario y adaptacion de la interfaz

    Private Sub Formprincipal_Resize(
    sender As Object,
    e As EventArgs
) Handles Me.Resize

        AdaptarInterfaz()

    End Sub

    Private Sub AdaptarInterfaz()

        DisenoResponsive.AdaptarMenu(
        Pnlmenu,
        BtnMenu,
        Me.ClientSize.Width
    )

    End Sub

    Private Sub AbrirFormulario(formulario As Form)

        'Ocultar la pantalla de inicio
        PnlInicio.Visible = False

        'Cerrar el formulario anterior
        If formularioActual IsNot Nothing Then
            PnlVista.Controls.Remove(formularioActual)
            formularioActual.Dispose()
            formularioActual = Nothing
        End If

        'Configurar el nuevo formulario
        formularioActual = formulario

        formularioActual.TopLevel = False
        formularioActual.FormBorderStyle = FormBorderStyle.None
        formularioActual.Dock = DockStyle.Fill

        'Mostrar el formulario dentro del área central
        PnlVista.Controls.Add(formularioActual)
        formularioActual.Show()
        formularioActual.BringToFront()

    End Sub

    'Menu

    Private Sub BtnInicio_Click(
    sender As Object,
    e As EventArgs
) Handles btnInicio.Click

        If formularioActual IsNot Nothing Then
            PnlVista.Controls.Remove(formularioActual)
            formularioActual.Dispose()
            formularioActual = Nothing
        End If

        PnlInicio.Visible = True
        PnlInicio.BringToFront()

        menuNavegacion.Seleccionar(btnInicio)

    End Sub
    Private Sub BtnCaptacion_Click(sender As Object, e As EventArgs) Handles BtnCaptacion.Click

        AbrirFormulario(New FrmCaptacion())
        menuNavegacion.Seleccionar(BtnCaptacion)

    End Sub

    Private Sub BtnAlmacenamiento_Click(sender As Object, e As EventArgs) Handles BtnAlmacenamiento.Click

        AbrirFormulario(New FrmAlmacenamiento())
        menuNavegacion.Seleccionar(BtnAlmacenamiento)

    End Sub

    Private Sub BtnTratamiento_Click(
    sender As Object,
    e As EventArgs
) Handles BtnTratamiento.Click

        AbrirFormulario(New FrmTratamiento())
        menuNavegacion.Seleccionar(BtnTratamiento)

    End Sub

    Private Sub BtnMonitoreo_Click(
    sender As Object,
    e As EventArgs
) Handles BtnMonitoreo.Click

        AbrirFormulario(New FrmMonitoreo())
        menuNavegacion.Seleccionar(BtnMonitoreo)

    End Sub

    Private Sub BtnReportes_Click(
    sender As Object,
    e As EventArgs
) Handles BtnReportes.Click

        AbrirFormulario(New FrmReportes())
        menuNavegacion.Seleccionar(BtnReportes)

    End Sub


End Class


