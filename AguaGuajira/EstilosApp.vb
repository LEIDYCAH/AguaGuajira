Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class EstilosApp

    ' Paleta de colores Divine

    Public Shared ReadOnly Fondo As Color =
    Color.FromArgb(241, 239, 251)

    Public Shared ReadOnly Primario As Color =
    Color.FromArgb(41, 38, 79)

    Public Shared ReadOnly Secundario As Color =
    Color.FromArgb(81, 75, 145)

    Public Shared ReadOnly Terciario As Color =
    Color.FromArgb(41, 38, 79)

    Public Shared ReadOnly Acento As Color =
    Color.FromArgb(129, 120, 207)

    Public Shared ReadOnly Lavanda As Color =
    Color.FromArgb(181, 172, 234)

    Public Shared ReadOnly Blanco As Color =
    Color.White

    Public Shared ReadOnly TextoSuave As Color =
    Color.FromArgb(112, 108, 145)


    ' Tipos de letra

    Public Shared Function Fuente(
    Optional tamano As Single = 10,
    Optional negrita As Boolean = False,
    Optional tipoletra As String = "Segoe UI"
) As Font

        Dim estilo As FontStyle =
        If(negrita, FontStyle.Bold, FontStyle.Regular And tamano > 20)

        Return New Font(tipoletra, tamano, estilo)

    End Function


    ' Tarjetas y Paneles 

    Public Shared Sub AplicarTarjeta(
    panel As PanelRedondeado
)

        panel.BackColor = Blanco
        panel.RadioEsquinas = 18
        panel.BorderStyle = BorderStyle.None

    End Sub


    ' Titulos

    Public Shared Sub AplicarTitulo(
    etiqueta As Label
)
        etiqueta.Font = Fuente(20, True, "Bauhaus 93")
        etiqueta.ForeColor = Primario
        etiqueta.BackColor = Color.Transparent
        etiqueta.AutoSize = True

    End Sub


    ' Subtitulos

    Public Shared Sub AplicarSubtitulo(
    etiqueta As Label
)

        etiqueta.Font = Fuente(12)
        etiqueta.ForeColor = Acento
        etiqueta.BackColor = Color.Transparent
        etiqueta.AutoSize = True

    End Sub


    ' Botones

    Public Shared Sub AplicarBoton(
    boton As Button
)

        boton.FlatStyle = FlatStyle.Flat
        boton.FlatAppearance.BorderSize = 0
        boton.BackColor = Acento
        boton.ForeColor = Blanco
        boton.Font = Fuente(10, True)
        boton.Cursor = Cursors.Hand
        boton.UseVisualStyleBackColor = False

    End Sub


    ' Campos de texto

    Public Shared Sub AplicarCampo(
    campo As TextBox
)
        campo.Font = Fuente(10)
        campo.ForeColor = Primario
        campo.BackColor = Blanco
        campo.BorderStyle = BorderStyle.FixedSingle

    End Sub

    'Grillas

    Public Shared Sub AplicarGrilla(grilla As DataGridView)

        ' Apariencia general
        grilla.Font = Fuente(9)
        grilla.ForeColor = Primario
        grilla.BackColor = Blanco
        grilla.BorderStyle = BorderStyle.None
        grilla.BackgroundColor = Blanco
        grilla.GridColor = Fondo
        grilla.CellBorderStyle =
        DataGridViewCellBorderStyle.SingleHorizontal

        ' Encabezados
        grilla.EnableHeadersVisualStyles = False
        grilla.ColumnHeadersVisible = True
        grilla.ColumnHeadersHeight = 38
        grilla.ColumnHeadersHeightSizeMode =
        DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        grilla.ColumnHeadersDefaultCellStyle.BackColor = Lavanda
        grilla.ColumnHeadersDefaultCellStyle.ForeColor = Primario
        grilla.ColumnHeadersDefaultCellStyle.Font = Fuente(9, True)
        grilla.ColumnHeadersDefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter

        ' Filas
        grilla.DefaultCellStyle.BackColor = Blanco
        grilla.DefaultCellStyle.ForeColor = Primario
        grilla.DefaultCellStyle.Font = Fuente(9)
        grilla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(227, 221, 248)
        grilla.DefaultCellStyle.SelectionForeColor = Primario
        grilla.DefaultCellStyle.Alignment =
        DataGridViewContentAlignment.MiddleCenter

        ' Filas alternadas
        grilla.AlternatingRowsDefaultCellStyle.BackColor =
        Color.FromArgb(248, 246, 255)

        ' Dimensiones
        grilla.RowTemplate.Height = 35
        grilla.RowHeadersVisible = False

        ' Comportamiento
        grilla.ReadOnly = True
        grilla.AllowUserToAddRows = False
        grilla.AllowUserToDeleteRows = False
        grilla.AllowUserToResizeRows = False
        grilla.MultiSelect = False
        grilla.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        grilla.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill
        grilla.ScrollBars = ScrollBars.Vertical

    End Sub



End Class

