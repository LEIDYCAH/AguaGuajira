Public Class FrmFuentesAgua
    Private Sub FrmFuentesAgua_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigurarHistorialFuentes()
        ConfigurarCombosFuentes()
        CargarFuentesRegistradas()

        AddHandler TxtIdentificador.KeyPress, AddressOf EstilosApp.SoloNumeros
        AddHandler TxtCapacidad.KeyPress, AddressOf EstilosApp.SoloNumeros
        AddHandler TxtJagueyes.KeyPress, AddressOf EstilosApp.SoloNumeros
        AddHandler Txtpozos.KeyPress, AddressOf EstilosApp.SoloNumeros
        AddHandler TxtCaptacion.KeyPress, AddressOf EstilosApp.SoloNumeros
        AddHandler TxtFuentes.KeyPress, AddressOf EstilosApp.SoloNumeros

        EstilosApp.AplicarTitulo(LblTituloFuentes)
        EstilosApp.AplicarSubtitulo(LblSubFuente)
        EstilosApp.AplicarTarjeta(PnlCardLluvia)
        EstilosApp.AplicarTarjeta(PnlHistorialF)
        EstilosApp.AplicarTarjeta(PnlJagueyes)
        EstilosApp.AplicarTarjeta(PnlPozos)
        EstilosApp.AplicarTarjeta(PnlRegistrar)
        EstilosApp.AplicarTarjeta(PnlHistorialF)
        EstilosApp.AplicarSTituloCard(Lblcardcaptacion)
        EstilosApp.AplicarSTituloCard(LblCardPozos)
        EstilosApp.AplicarSTituloCard(LblCardJaueyes)
        EstilosApp.AplicarSTituloCard(LblCardTotal)
        EstilosApp.AplicarSTituloCard(LblCaptacion)
        EstilosApp.AplicarSTituloCard(LblRegistrar)
        EstilosApp.AplicarSTituloCard(LblTituloHistorialFuentes)
        EstilosApp.AplicarGrilla(DtgFuentesAgua)
        EstilosApp.AplicarCampo(TxtIdentificador)
        EstilosApp.AplicarCampo(TxtFuente)
        EstilosApp.AplicarCampo(TxbUbicacion)
        EstilosApp.AplicarCampo(TxtCapacidad)
        EstilosApp.AplicarCampo(TxtJagueyes)
        EstilosApp.AplicarCampo(Txtpozos)
        EstilosApp.AplicarCampo(TxtCaptacion)
        EstilosApp.AplicarCampo(TxtFuentes)
        EstilosApp.AplicarBoton(BtnRegistrar)


    End Sub

    Private Sub ConfigurarHistorialFuentes()

        With DtgFuentesAgua
            .Columns.Clear()
            .Columns.Add("Id", "Identificador")
            .Columns.Add("Tipo", "Tipo de fuente")
            .Columns.Add("Nombre", "Nombre")
            .Columns.Add("Ubicacion", "Ubicación")
            .Columns.Add("Capacidad", "Capacidad estimada (L)")
            .Columns.Add("Estado", "Estado")
        End With

        EstilosApp.AplicarGrilla(DtgFuentesAgua)

    End Sub

    Private Sub ConfigurarCombosFuentes()

        With CmbTIpo
            .Items.Clear()
            .DropDownStyle = ComboBoxStyle.DropDownList

            .Items.Add("Captación de lluvia")
            .Items.Add("Pozo")
            .Items.Add("Jagüey")

            .SelectedIndex = -1
        End With

        With CmbEstado
            .Items.Clear()
            .DropDownStyle = ComboBoxStyle.DropDownList

            .Items.Add("Activa")
            .Items.Add("Inactiva")
            .Items.Add("En mantenimiento")

            .SelectedIndex = -1
        End With

    End Sub

    Private Function GenerarIdentificador(tipo As String) As String

        Dim prefijo As String = ""

        Select Case tipo
            Case "Tanque"
                prefijo = "TQ"

            Case "Pozo"
                prefijo = "POZ"

            Case "Jagüey"
                prefijo = "JAG"

            Case "Captación de lluvia"
                prefijo = "CAP"
        End Select

        Dim contador As Integer = 0

        For Each fila As DataGridViewRow In DtgFuentesAgua.Rows

            If fila.IsNewRow Then Continue For

            Dim id As String = fila.Cells("Id").Value.ToString()

            If id.StartsWith(prefijo & "-", StringComparison.OrdinalIgnoreCase) Then
                contador += 1
            End If

        Next

        Return prefijo & "-" & (contador + 1).ToString("000")

    End Function

    Private Sub CmbTIpo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTIpo.SelectedIndexChanged

        If CmbTIpo.SelectedIndex <> -1 Then
            TxtIdentificador.Text = GenerarIdentificador(CmbTIpo.Text)
        Else
            TxtIdentificador.Clear()
        End If

    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        Dim capacidad As Double

        ' Validar identificador
        If String.IsNullOrWhiteSpace(TxtIdentificador.Text) Then
            MessageBox.Show("Ingresa el identificador de la fuente.")
            TxtIdentificador.Focus()
            Exit Sub
        End If

        ' Validar tipo de fuente
        If CmbTIpo.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona el tipo de fuente.")
            CmbTIpo.Focus()
            Exit Sub
        End If

        ' Validar nombre
        If String.IsNullOrWhiteSpace(TxtFuente.Text) Then
            MessageBox.Show("Ingresa el nombre de la fuente.")
            TxtFuente.Focus()
            Exit Sub
        End If

        ' Validar ubicación
        If String.IsNullOrWhiteSpace(TxbUbicacion.Text) Then
            MessageBox.Show("Ingresa la ubicación de la fuente.")
            TxbUbicacion.Focus()
            Exit Sub
        End If

        ' Validar capacidad
        If Not Double.TryParse(TxtCapacidad.Text, capacidad) OrElse capacidad <= 0 Then
            MessageBox.Show("Ingresa una capacidad válida mayor que cero.")
            TxtCapacidad.Focus()
            Exit Sub
        End If

        ' Validar estado
        If CmbEstado.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona el estado de la fuente.")
            CmbEstado.Focus()
            Exit Sub
        End If

        ' Evitar identificadores duplicados
        For Each fila As DataGridViewRow In DtgFuentesAgua.Rows

            If fila.Cells("Id").Value IsNot Nothing AndAlso
               fila.Cells("Id").Value.ToString().Trim().Equals(
               TxtIdentificador.Text.Trim(),
               StringComparison.OrdinalIgnoreCase) Then

                MessageBox.Show("Este identificador ya está registrado.")
                TxtIdentificador.Focus()
                Exit Sub

            End If

        Next

        ' Registrar fuente
        DtgFuentesAgua.Rows.Add(
            TxtIdentificador.Text.Trim(),
            CmbTIpo.Text,
            TxtFuente.Text.Trim(),
            TxbUbicacion.Text.Trim(),
            capacidad.ToString("N2"),
            CmbEstado.Text
        )

        Dim nuevaFuente As New DatosFuente With {
           .Id = TxtIdentificador.Text.Trim(),
          .Tipo = CmbTIpo.Text,
          .Nombre = TxtFuente.Text.Trim(),
          .Ubicacion = TxbUbicacion.Text.Trim(),
          .Capacidad = capacidad,
          .Estado = CmbEstado.Text
}
        DatosFuente.Historial.Add(nuevaFuente)

        ActualizarTarjetasFuentes()

        ' Limpiar campos
        TxtIdentificador.Clear()
        CmbTIpo.SelectedIndex = -1
        TxtFuente.Clear()
        TxbUbicacion.Clear()
        TxtCapacidad.Clear()
        CmbEstado.SelectedIndex = -1


    End Sub


    Private Sub ActualizarTarjetasFuentes()

        Dim totalLluvia As Integer = 0
        Dim totalPozos As Integer = 0
        Dim totalJagueyes As Integer = 0
        Dim totalFuentes As Integer = DtgFuentesAgua.Rows.Count

        For Each fila As DataGridViewRow In DtgFuentesAgua.Rows

            If fila.IsNewRow Then Continue For

            Dim tipo As String = fila.Cells("Tipo").Value.ToString()

            Select Case tipo

                Case "Captación de lluvia"
                    totalLluvia += 1

                Case "Pozo"
                    totalPozos += 1

                Case "Jagüey"
                    totalJagueyes += 1

            End Select

        Next

        TxtCaptacion.Text = totalLluvia.ToString("00")
        Txtpozos.Text = totalPozos.ToString("00")
        TxtJagueyes.Text = totalJagueyes.ToString("00")
        TxtFuentes.Text = totalFuentes.ToString("00")

    End Sub

    Private Sub CargarFuentesRegistradas()

        DtgFuentesAgua.Rows.Clear()

        For Each fuente In DatosFuente.Historial

            DtgFuentesAgua.Rows.Add(
                fuente.Id,
                fuente.Tipo,
                fuente.Nombre,
                fuente.Ubicacion,
                fuente.Capacidad.ToString("N2"),
                fuente.Estado
            )

        Next

        ActualizarTarjetasFuentes()

    End Sub

End Class