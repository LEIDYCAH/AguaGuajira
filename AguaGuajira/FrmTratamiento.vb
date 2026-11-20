Public Class FrmTratamiento
    Public Shared volumenLoteActual As Double = 0
    Public Shared filtracionRealizada As Boolean = False
    Public Shared sodisRealizada As Boolean = False
    Private Sub FrmTratamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler TxtVolumen.KeyPress, AddressOf EstilosApp.SoloNumeros

        EstilosApp.AplicarTitulo(LblTratamiento)
        EstilosApp.AplicarSubtitulo(LblSubtratamiento)
        EstilosApp.AplicarSubtitulo(LblHistoriaTratamiento)
        EstilosApp.AplicarTarjeta(PnlAguaRecibida)
        EstilosApp.AplicarTarjeta(PnlDesinfeccion)
        EstilosApp.AplicarTarjeta(PnlFiltracion)
        EstilosApp.AplicarTarjeta(PnlResultado)
        EstilosApp.AplicarTarjeta(PnlRegistro)
        EstilosApp.AplicarBoton(BtnRegistro)
        EstilosApp.AplicarCampo(TxtAguaRecibida)
        EstilosApp.AplicarCampo(TxtVolumen)
        EstilosApp.AplicarSTituloCard(LblRegistrodelTratamiento)
        EstilosApp.AplicarSTituloCard(LblAguaRecibida)
        EstilosApp.AplicarSTituloCard(LblDesinfeccion)
        EstilosApp.AplicarSTituloCard(lblResultado)
        EstilosApp.AplicarSTituloCard(LblFiltracion)
        EstilosApp.AplicarSTituloCard(LblHistoriaTratamiento)

        ConfigurarHistorialTratamiento()
        ActualizarFormularioTratamiento()
        ConfigurarComboLote()

    End Sub

    Private Sub ConfigurarHistorialTratamiento()

        With DgvHistorialTratamiento
            .Columns.Clear()
            .Columns.Add("Lote", "Código del lote")
            .Columns.Add("Fecha", "Fecha")
            .Columns.Add("Volumen", "Volumen (L)")
            .Columns.Add("Proceso", "Proceso aplicado")
            .Columns.Add("Observaciones", "Observaciones")
        End With

        EstilosApp.AplicarGrilla(DgvHistorialTratamiento)

    End Sub



    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click

        If CmbProceso.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona el proceso aplicado.")
            Exit Sub
        End If

        If loteActual Is Nothing Then
            MessageBox.Show("Debes seleccionar un lote de captación.")
            Exit Sub
        End If

        If loteActual.VolumenCaptado <= 0 Then
            MessageBox.Show("El lote seleccionado no tiene volumen de agua.")
            Exit Sub
        End If

        If CmbProceso.Text = "Filtración lenta en arena" AndAlso
       loteActual.FiltracionRealizada Then

            MessageBox.Show("La filtración de este lote ya fue registrada.")
            Exit Sub
        End If

        If CmbProceso.Text = "Desinfección solar SODIS" AndAlso
       Not loteActual.FiltracionRealizada Then

            MessageBox.Show("Primero debes registrar la filtración.")
            Exit Sub
        End If

        If CmbProceso.Text = "Desinfección solar SODIS" AndAlso
       loteActual.SODISRealizada Then

            MessageBox.Show("La desinfección SODIS de este lote ya fue registrada.")
            Exit Sub
        End If

        If CmbProceso.Text = "Filtración lenta en arena" Then

            loteActual.FiltracionRealizada = True

        ElseIf CmbProceso.Text = "Desinfección solar SODIS" Then

            loteActual.SODISRealizada = True

        End If

        filtracionRealizada = loteActual.FiltracionRealizada
        sodisRealizada = loteActual.SODISRealizada

        If filtracionRealizada AndAlso sodisRealizada Then
            loteActual.Estado = "Tratamiento completado"
        Else
            loteActual.Estado = "En tratamiento"
        End If

        Dim volumen As Double = loteActual.VolumenCaptado

        DgvHistorialTratamiento.Rows.Add(
        loteActual.Codigo,
        DtFechaRegistro.Value.ToString("dd/MM/yyyy"),
        volumen.ToString("N2"),
        CmbProceso.Text,
        TxtObservacionesT.Text
    )

        TxtObservacionesT.Clear()

        ActualizarFormularioTratamiento()

    End Sub


    Private Sub ActualizarFormularioTratamiento()

        If volumenLoteActual > 0 Then

            TxtVolumen.Text = volumenLoteActual.ToString("N2")
            TxtVolumen.Enabled = True

            If Not filtracionRealizada Then

                CmbProceso.SelectedItem = "Filtración lenta en arena"

            ElseIf Not sodisRealizada Then

                CmbProceso.SelectedItem = "Desinfección solar SODIS"

            Else

                CmbProceso.SelectedIndex = -1

            End If

        Else

            TxtVolumen.Text = "0.00"
            CmbProceso.SelectedIndex = -1

        End If

        LblValorFiltracion.Text =
        If(filtracionRealizada, "Realizada", "Pendiente")

        LblEstadosodiss.Text =
        If(sodisRealizada, "Realizada", "Pendiente")

        If filtracionRealizada AndAlso sodisRealizada Then
            lblvalorResultado.Text = "Procesos completados"
        ElseIf filtracionRealizada OrElse sodisRealizada Then
            lblvalorResultado.Text = "En tratamiento"
        Else
            lblvalorResultado.Text = "Sin evaluar"
        End If

    End Sub

    Private loteActual As LoteTratamiento
    Private lotesMostrados As New List(Of LoteTratamiento)

    Private Sub ConfigurarComboLote()

        CmbLote.Items.Clear()
        lotesMostrados.Clear()

        For Each lote As LoteTratamiento In LoteTratamiento.Historial

            CmbLote.Items.Add(
                lote.Codigo & " | " &
                lote.FechaCaptacion.ToString("dd/MM/yyyy")
            )

            lotesMostrados.Add(lote)

        Next

        If CmbLote.Items.Count > 0 Then
            CmbLote.SelectedIndex = 0
        End If

    End Sub

    Private Sub CmbLote_SelectedIndexChanged(
    sender As Object,
    e As EventArgs
) Handles CmbLote.SelectedIndexChanged

        If CmbLote.SelectedIndex = -1 Then Exit Sub

        loteActual = lotesMostrados(CmbLote.SelectedIndex)

        volumenLoteActual = loteActual.VolumenCaptado
        filtracionRealizada = loteActual.FiltracionRealizada
        sodisRealizada = loteActual.SODISRealizada

        TxtAguaRecibida.Text = loteActual.VolumenCaptado.ToString("N2")

        ActualizarFormularioTratamiento()
    End Sub

End Class