Public Class FrmTratamiento

    Private Sub FrmCaptacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EstilosApp.AplicarTarjeta(PnlAguaRecibida)
        EstilosApp.AplicarTarjeta(PnlDesinfeccion)
        EstilosApp.AplicarTarjeta(PnlFiltracion)
        EstilosApp.AplicarTarjeta(PnlRegistro)
        EstilosApp.AplicarTarjeta(PnlResultado)
        EstilosApp.AplicarBoton(BtnRegistro)
        EstilosApp.AplicarTitulo(LblTratamiento)
        EstilosApp.AplicarSubtitulo(LblSubtratamiento)
        EstilosApp.AplicarCampo(TxtAguaRecibida)
        EstilosApp.AplicarSubtitulo(LblHistoriaTratamiento)

        ConfigurarHistorialTratamiento()
        TxtAguaRecibida.Text = FrmCaptacion.VolumenCaptado.ToString("N2") & " L"

    End Sub

    Private Sub ConfigurarHistorialTratamiento()

        With DgvHistorialTratamiento
            .Columns.Clear()
            .Columns.Add("Fecha", "Fecha")
            .Columns.Add("Volumen", "Volumen (L)")
            .Columns.Add("Proceso", "Proceso aplicado")
            .Columns.Add("Observaciones", "Observaciones")
        End With

        EstilosApp.AplicarGrilla(DgvHistorialTratamiento)

    End Sub


    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click
        Dim volumen As Double

        If Not Double.TryParse(TxtVolumen.Text, volumen) Then
            MessageBox.Show("Ingresa un volumen válido.")
            Exit Sub
        End If

        If volumen <= 0 Then
            MessageBox.Show("El volumen debe ser mayor que cero.")
            Exit Sub
        End If

        If CmbProceso.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona el proceso aplicado.")
            Exit Sub
        End If

        DgvHistorialTratamiento.Rows.Add(
        DtFechaRegistro.Value.ToString("dd/MM/yyyy"),
        volumen.ToString("N2"),
        CmbProceso.Text,
        TxtObservacionesT.Text
        )

        If CmbProceso.Text = "Filtración lenta en arena" Then
            LblValorFiltracion.Text = "Realizada"
        End If

        If CmbProceso.Text = "Desinfección solar SODIS" Then
            LblEstadosodiss.Text = "Realizada"
        End If

        If LblValorFiltracion.Text = "Realizada" AndAlso
           LblEstadosodiss.Text = "Realizada" Then

            lblvalorResultado.Text = "Procesos completados"

        Else
            lblvalorResultado.Text = "En tratamiento"
        End If


        MessageBox.Show("Tratamiento registrado correctamente.")

        TxtVolumen.Clear()
        TxtObservacionesT.Clear()
        CmbProceso.SelectedIndex = -1

    End Sub
End Class