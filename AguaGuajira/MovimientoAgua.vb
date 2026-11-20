
Public Class MovimientoAgua

    Public Property CodigoTanque As String
    Public Property TipoMovimiento As String
    Public Property Volumen As Double
    Public Property FechaMovimiento As Date
    Public Property Observacion As String

    Public Sub New()
        FechaMovimiento = Date.Now
    End Sub

End Class

