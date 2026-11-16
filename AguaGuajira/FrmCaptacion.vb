Public Class FrmCaptacion
    Public Shared VolumenCaptado As Double = 0
    Private Sub FrmCaptacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ajustar el menú según el tamaño del formulario


        'DisenoResponsive.AdaptarMenu(PnlMenu, BtnMenu, Me.Width)

        'Estilo:
        EstilosApp.AplicarTitulo(LblTituloFormulario)
        EstilosApp.AplicarTarjeta(PnlFrmCaptacion)
        EstilosApp.AplicarSubtitulo(txtRegistroCap)
        EstilosApp.AplicarSubtitulo(lblHistorial)
        EstilosApp.AplicarCampo(TxtPrecipitacion)
        EstilosApp.AplicarCampo(txareacap)
        EstilosApp.AplicarCampo(TxtCoeficiente)
        EstilosApp.AplicarTarjeta(PnlResultadoCaptacion)
        EstilosApp.AplicarBoton(BtnValor)

        ConfigurarHistorial()
        Me.WindowState = FormWindowState.Maximized


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

    Private Sub BtnValor_Click(sender As Object, e As EventArgs)
        Dim Precipitacion As Double
        Dim area As Double
        Dim coeficiente As Double
        Dim volumen As Double

        Dim cultura =
            Globalization.CultureInfo.GetCultureInfo("es-CO")

        ' Convertimos los datos ingresados en números

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

        ' Mostrar resultado

        TxtVolumen.Text = volumen.ToString("N2")

        DgvHistorialCaptacion.Rows.Add(
           DTFechaRegistro.Value.ToString("dd/MM/yyyy"),
          Precipitacion,
          area,
          coeficiente,
          volumen.ToString("N2")
)

    End Sub

End Class