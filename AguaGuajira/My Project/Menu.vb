Public Class Menu

    Private ReadOnly _colorNormal As Color =
    Color.FromArgb(41, 38, 79)

    Private ReadOnly _colorActivo As Color =
    Color.FromArgb(129, 120, 207)

    Private ReadOnly _colorTexto As Color =
    Color.White

    Private ReadOnly _botones As List(Of Button)

    Public Sub New(ParamArray botones As Button())

        _botones = botones.ToList()

    End Sub

    Public Sub Seleccionar(botonActivo As Button)

        For Each boton As Button In _botones

            boton.BackColor = _colorNormal
            boton.ForeColor = _colorTexto

        Next

        botonActivo.BackColor = _colorActivo
        botonActivo.ForeColor = _colorTexto

    End Sub

End Class

