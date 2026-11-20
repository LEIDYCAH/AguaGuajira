Public Class FrmMonitoreo
    Private Sub FrmMonitoreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler TbxPhManual.KeyPress, AddressOf EstilosApp.SoloNumeros
        AddHandler TbxTurbidezmanual.KeyPress, AddressOf EstilosApp.SoloNumeros
        AddHandler TxbTdsManual.KeyPress, AddressOf EstilosApp.SoloNumeros
        AddHandler TbxTemperaturaManual.KeyPress, AddressOf EstilosApp.SoloNumeros

        EstilosApp.AplicarTarjeta(PnlCardPh)
        EstilosApp.AplicarTitulo(TxtTituloMonitoreo)
        EstilosApp.AplicarSTituloCard(LblNombreSensor)
        EstilosApp.AplicarSTituloCard(lblsensorPH)
        EstilosApp.AplicarSTituloCard(Lblturbidezsensor)
        EstilosApp.AplicarSTituloCard(LblTemperaturaSensor)
        EstilosApp.AplicarSubtitulo(LblRegistroMonitoreo)
        EstilosApp.AplicarSubtitulo(LblHistorialMonitoreo)
        EstilosApp.AplicarSTituloCard(LblTituloNivelpH)
        EstilosApp.AplicarSTituloCard(LblTituloTurbidez)
        EstilosApp.AplicarSTituloCard(LblTituloTDS)
        EstilosApp.AplicarSTituloCard(LblTituloTemperatura)
        EstilosApp.AplicarSTituloCard(LblNombreSM)
        EstilosApp.AplicarSTituloCard(LblNombreSensor)
        EstilosApp.AplicarBoton(BtnRegistrarLectura)

        ConfigurarHistorialMonitoreo()
        ConfigurarSeriesGrafica()
        ConfigurarComboSensor()
    End Sub

    Private Sub ConfigurarComboSensor()

        CmbSensor.Items.Clear()

        For Each tanque As Tanque In GestorTanques.ListaTanques
            CmbSensor.Items.Add(tanque.Codigo)
        Next

        If CmbSensor.Items.Count > 0 Then
            CmbSensor.SelectedIndex = 0
        End If

    End Sub

    Private Sub ConfigurarHistorialMonitoreo()

        With DtgMonitoreo
            .Columns.Clear()
            .Columns.Add("Origen", "Origen")
            .Columns.Add("Fecha", "Fecha y hora")
            .Columns.Add("PH", "pH")
            .Columns.Add("Turbidez", "Turbidez (NTU)")
            .Columns.Add("TDS", "TDS (ppm)")
            .Columns.Add("Temperatura", "Temperatura (°C)")
            .Columns.Add("Estado", "Estado")
        End With

        EstilosApp.AplicarGrilla(DtgMonitoreo)

    End Sub


    Private Sub BtnRegistrarLectura_Click(sender As Object, e As EventArgs) Handles BtnRegistrarLectura.Click

        Dim ph As Double
        Dim turbidez As Double
        Dim tds As Double
        Dim temperatura As Double

        'Validar selección de sensor
        If CmbSensor.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona el origen de la medición.")
            CmbSensor.Focus()
            Exit Sub
        End If

        ' Validar pH
        If Not Double.TryParse(TbxPhManual.Text, ph) Then
            MessageBox.Show("Ingresa un valor válido de pH.")
            TbxPhManual.Focus()
            Exit Sub
        End If

        ' Validar turbidez
        If Not Double.TryParse(TbxTurbidezmanual.Text, turbidez) Then
            MessageBox.Show("Ingresa un valor válido de turbidez.")
            TbxTurbidezmanual.Focus()
            Exit Sub
        End If

        ' Validar TDS
        If Not Double.TryParse(TxbTdsManual.Text, tds) Then
            MessageBox.Show("Ingresa un valor válido de TDS.")
            TxbTdsManual.Focus()
            Exit Sub
        End If

        ' Validar temperatura
        If Not Double.TryParse(TbxTemperaturaManual.Text, temperatura) Then
            MessageBox.Show("Ingresa una temperatura válida.")
            TbxTemperaturaManual.Focus()
            Exit Sub
        End If

        ' Validar rangos
        If ph < 0 OrElse ph > 14 Then
            MessageBox.Show("El pH debe estar entre 0 y 14.")
            TbxPhManual.Focus()
            Exit Sub
        End If

        If turbidez < 0 OrElse tds < 0 Then
            MessageBox.Show("La turbidez y los TDS no pueden ser negativos.")
            Exit Sub
        End If

        If temperatura < -10 OrElse temperatura > 100 Then
            MessageBox.Show("Verifica la temperatura ingresada.")
            TbxTemperaturaManual.Focus()
            Exit Sub
        End If

        ' Registrar lectura
        Dim fechaLectura = Date.Now

        ' Guardar en el historial visible del módulo
        DtgMonitoreo.Rows.Add(
    fechaLectura.ToString("dd/MM/yyyy HH:mm"),
ph, turbidez, tds, temperatura, "Registrada", CmbSensor.Text
)

        ' Guardar también en el historial compartido
        Dim nuevaLectura As New DatosMonitoreo With {
    .Fecha = fechaLectura,
    .Sensor = CmbSensor.Text,
    .PH = ph,
    .Turbidez = turbidez,
    .TDS = tds,
    .Temperatura = temperatura,
    .Estado = "Registrada"
}

        DatosMonitoreo.Historial.Add(nuevaLectura)

        TbxPhManual.Text = ph.ToString("N2") & " pH"
        TbxTurbidezmanual.Text = turbidez.ToString("N2") & " NTU"
        TxbTdsManual.Text = tds.ToString("N2") & " ppm"
        TbxTemperaturaManual.Text = temperatura.ToString("N2") & " °C"

        ' Actualizar gráfica
        Dim indice = DtgMonitoreo.Rows.Count - 1

        ChMonitoreo.Series("SeriePH").Points.AddXY(indice + 1, ph)
        ChMonitoreo.Series("SerieTurbidez").Points.AddXY(indice + 1, turbidez)
        ChMonitoreo.Series("SerieTDS").Points.AddXY(indice + 1, tds)
        ChMonitoreo.Series("SerieTemperatura").Points.AddXY(indice + 1, temperatura)

        ' Limpiar campos
        TbxPhManual.Clear()
        TbxTurbidezmanual.Clear()
        TxbTdsManual.Clear()
        TbxTemperaturaManual.Clear()



    End Sub

    Private Sub ConfigurarSeriesGrafica()

        Dim nombresSeries As String() = {
            "SeriePH",
            "SerieTurbidez",
            "SerieTDS",
            "SerieTemperatura"
        }

        For Each nombre As String In nombresSeries

            With ChMonitoreo.Series(nombre)
                .ChartType = DataVisualization.Charting.SeriesChartType.Line
                .MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                .MarkerSize = 9
                .BorderWidth = 2
            End With

        Next

    End Sub

End Class