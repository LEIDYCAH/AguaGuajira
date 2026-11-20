Public Class FrmCaptacion
    Public Shared VolumenCaptado As Double = 0
    Public Shared VolumenTotalRegistrado As Double = 0
    Private Sub FrmCaptacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler TxtPrecipitacion.KeyPress, AddressOf EstilosApp.SoloNumeros
        AddHandler txareacap.KeyPress, AddressOf EstilosApp.SoloNumeros
        AddHandler TxtCoeficiente.KeyPress, AddressOf EstilosApp.SoloNumeros

        'Estilo:
        EstilosApp.AplicarTitulo(LblTituloFormulario)
        EstilosApp.AplicarTarjeta(PnlFrmCaptacion)
        EstilosApp.AplicarCampo(TxtPrecipitacion)
        EstilosApp.AplicarCampo(txareacap)
        EstilosApp.AplicarCampo(TxtCoeficiente)
        EstilosApp.AplicarTarjeta(PnlResultadoCaptacion)
        EstilosApp.AplicarBoton(BtnValor)
        EstilosApp.AplicarSTituloCard(txtRegistroCap)
        EstilosApp.AplicarSTituloCard(lblHistorial)
        EstilosApp.AplicarSTituloCard(Lbltitulovolumen)

        Cmbzona.Items.Clear()

        Dim zonas = GestorTanques.ListaTanques _
            .Select(Function(t) t.PoblacionAsignada) _
            .Where(Function(z) Not String.IsNullOrWhiteSpace(z)) _
            .Distinct() _
            .OrderBy(Function(z) z)

        For Each zona In zonas
            Cmbzona.Items.Add(zona)
        Next

        If Cmbzona.Items.Count > 0 Then
            Cmbzona.SelectedIndex = 0
        End If

    End Sub

    Private Sub ConfigurarHistorial()

        With DgvHistorialCaptacion

            .Columns.Clear()

            .Columns.Add("Fecha", "Fecha")
            .Columns.Add("Precipitacion", "Precipitación (mm)")
            .Columns.Add("Area", "Área (m²)")
            .Columns.Add("Coeficiente", "Eficiencia")
            .Columns.Add("Volumen", "Volumen (L)")

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False

            ' Estilo de encabezados
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = EstilosApp.Lavanda
            .ColumnHeadersDefaultCellStyle.ForeColor = EstilosApp.Primario
            .ColumnHeadersDefaultCellStyle.Font = EstilosApp.Fuente(9, True)

            ' Estilo de las filas
            .DefaultCellStyle.BackColor = EstilosApp.Blanco
            .DefaultCellStyle.ForeColor = EstilosApp.Primario
            .DefaultCellStyle.Font = EstilosApp.Fuente(9)
            .DefaultCellStyle.SelectionBackColor = EstilosApp.Lavanda
            .DefaultCellStyle.SelectionForeColor = EstilosApp.Primario

            .RowTemplate.Height = 32
            .ColumnHeadersHeight = 35
            .BackgroundColor = EstilosApp.Blanco
            .BorderStyle = BorderStyle.None

        End With
    End Sub

    Private Sub BtnValor_Click(sender As Object, e As EventArgs) Handles BtnValor.Click
        Dim Precipitacion As Double
        Dim area As Double
        Dim coeficiente As Double
        Dim volumen As Double

        Dim cultura =
            Globalization.CultureInfo.GetCultureInfo("es-CO")

        ' Convertimos los datos ingresados en números

        If Cmbzona.SelectedIndex = -1 Then
            MessageBox.Show("Debes seleccionar una zona antes de registrar la captación.")
            Exit Sub
        End If

        If Not Double.TryParse(TxtPrecipitacion.Text, Precipitacion) Then
            MessageBox.Show("Ingresa una precipitación válida.")
            Exit Sub
        End If

        If Not Double.TryParse(txareacap.Text, area) Then
            MessageBox.Show("Ingresa un área válida.")
            Exit Sub
        End If

        If Not Double.TryParse(TxtCoeficiente.Text, coeficiente) Then
            MessageBox.Show("Ingresa un coeficiente válido.")
            Exit Sub
        End If

        ' Validamos que los datos sean correctos

        If Precipitacion <= 0 OrElse area <= 0 Then
            MessageBox.Show("La precipitación y el área deben ser mayores que cero.")
            Exit Sub
        End If

        If coeficiente <= 0 OrElse coeficiente > 1 Then
            MessageBox.Show("El coeficiente debe estar entre 0 y 1.")
            Exit Sub
        End If

        ' Calculamos el volumen recolectado

        volumen = Precipitacion * area * coeficiente

        VolumenCaptado = volumen
        VolumenTotalRegistrado += volumen

        ' Mostrar resultado

        TxtVolumen.Text = volumen.ToString("N2")

        DgvHistorialCaptacion.Rows.Add(
           DTFechaRegistro.Value.ToString("dd/MM/yyyy"),
          Precipitacion,
          area,
          coeficiente,
          volumen.ToString("N2")
)

        Dim nuevoLote As New LoteTratamiento With {
         .Codigo = "LOT-" & (LoteTratamiento.Historial.Count + 1).ToString("D3"),
         .Zona = Cmbzona.Text,
         .FechaCaptacion = DTFechaRegistro.Value,
         .VolumenCaptado = volumen,
         .FiltracionRealizada = False,
         .SODISRealizada = False,
         .Estado = "Sin Tratar"
}

        LoteTratamiento.Historial.Add(nuevoLote)

    End Sub

    Private Sub ActualizarDatosZona()

        If Cmbzona.SelectedIndex = -1 Then Exit Sub

        Dim zonaSeleccionada As String = Cmbzona.Text

        Dim tanquesZona = GestorTanques.ListaTanques _
            .Where(Function(t) t.PoblacionAsignada = zonaSeleccionada) _
            .ToList()

        Dim cantidadTanques As Integer = tanquesZona.Count

        Dim capacidadTotal As Double =
            tanquesZona.Sum(Function(t) t.Capacidad)

        LblTanues2.Text = cantidadTanques.ToString()

        lblCapatotal.Text = capacidadTotal.ToString("N2") & " L"

        Dim volumenTotal As Double =
    tanquesZona.Sum(Function(t) t.VolumenAlmacenado)

        Lblaratotal.Text = volumenTotal.ToString("N2") & " L"

    End Sub

    Private Sub CmbZona_SelectedIndexChanged(
    sender As Object,
    e As EventArgs
) Handles Cmbzona.SelectedIndexChanged

        ActualizarDatosZona()

    End Sub



End Class