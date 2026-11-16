Public Class FrmAlmacenamiento
    Private capacidadTanque As Double
    Private volumenAlmacenado As Double
    Private demandaCalculada As Double

    Private Sub FrmAlmacenamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ajustar el menú según el tamaño del formulario

        'DisenoResponsive.AdaptarMenu(PnlMenu, BtnMenu, Me.Width)

        'Estilo Almacenamiento:
        EstilosApp.AplicarTitulo(LblTituloalmacenamiento)
        EstilosApp.AplicarTarjeta(PnlCapacidadTanque)
        EstilosApp.AplicarTarjeta(PnlDisponible)
        EstilosApp.AplicarTarjeta(PnlCalculodemanda)
        EstilosApp.AplicarTarjeta(PnlDatosTanque)
        EstilosApp.AplicarTarjeta(PnlEvaluacion)
        EstilosApp.AplicarTarjeta(PnlCapacidadDemandada)
        EstilosApp.AplicarSubtitulo(LblCapacidad)
        EstilosApp.AplicarSubtitulo(LblCalculo)
        EstilosApp.AplicarSubtitulo(LblEvaluacion)
        EstilosApp.AplicarSubtitulo(LblDatosTanque)
        EstilosApp.AplicarSubtitulo(LblCapacidaddemanda)
        EstilosApp.AplicarSubtitulo(LblDatosTanque)
        EstilosApp.AplicarCampo(TxtcNumero)
        EstilosApp.AplicarCampo(TxtCConsumo)
        EstilosApp.AplicarCampo(TxtCDias)
        EstilosApp.AplicarCampo(Txtevaluacion)
        EstilosApp.AplicarCampo(txtCapacidadTotal)
        EstilosApp.AplicarCampo(TxbAguaAlmacenada)
        EstilosApp.AplicarBoton(BtnCalculoDemanda)
        EstilosApp.AplicarBoton(BtnCalcular)
    End Sub

    Private Sub BtnCalculoDemanda_Click(sender As Object, e As EventArgs)

        Dim Habitantes As Double
        Dim consumo As Double
        Dim dias As Double
        Dim volumen As Double

        If Not Double.TryParse(TxtcNumero.Text, Habitantes) Then
            MessageBox.Show("Ingresa una Cantidad de habitantes valida.")
            Exit Sub
        End If
        If Not Double.TryParse(TxtCConsumo.Text, consumo) Then
            MessageBox.Show("Ingresa un valor de consumo valido.")
            Exit Sub
        End If

        If Not Double.TryParse(TxtCDias.Text, dias) Then
            MessageBox.Show("Ingresa una cantidad de días válida")
            Exit Sub
        End If

        If Habitantes <= 0 OrElse consumo <= 0 OrElse dias <= 0 Then
            MessageBox.Show("Por favor ingresa valores válidos.")
            Exit Sub
        End If

        ' Calculamos el volumen recolectado

        volumen = Habitantes * dias * consumo

        ' Mostrar resultado
        Txtevaluacion.Text = volumen.ToString("N2") & " Liros"
        txtCapacidadTotal.Focus()

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs)

        Dim capacidad As Double
        Dim agua As Double

        If Not Double.TryParse(txtCapacidadTotal.Text, capacidad) Then
            MessageBox.Show("Ingresa una capacidad válida.")
            Exit Sub
        End If

        If Not Double.TryParse(TxbAguaAlmacenada.Text, agua) Then
            MessageBox.Show("Ingresa el volumen de agua almacenada.")
            Exit Sub
        End If

        If capacidad <= 0 OrElse agua < 0 Then
            MessageBox.Show("La capacidad debe ser mayor que cero y el agua no puede ser negativa.")
            Exit Sub
        End If

        If agua > capacidad Then
            MessageBox.Show("El agua almacenada no puede superar la capacidad del tanque.")
            Exit Sub
        End If

        capacidadTanque = capacidad
        volumenAlmacenado = agua

        LblCapa.Text = capacidad.ToString("N2") & " L"
        Lbldispo.Text = agua.ToString("N2") & " L"

        MessageBox.Show("Datos del tanque registrados correctamente.")


        'Evaluamos la demanda calculada si ya se ha ingresado
        If capacidadTanque <= 0 OrElse demandaCalculada <= 0 Then
            MessageBox.Show("Primero porfavor registra los datos del tanque y calcula la demanda.")
            Exit Sub
        End If

        Dim diferencia As Double

        diferencia = capacidadTanque - demandaCalculada

        If diferencia >= 0 Then
            LblNotificacionevaluacion.Text = "Capacidad suficiente"
            LblNotificacionevaluacion.ForeColor = Color.SeaGreen
        Else
            LblNotificacionevaluacion.Text = "Capacidad insuficiente"
            LblNotificacionevaluacion.ForeColor = Color.Firebrick
        End If
    End Sub


End Class