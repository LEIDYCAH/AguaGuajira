
Public Class LoteTratamiento

    Public Property Codigo As String
    Public Property FechaCaptacion As DateTime
    Public Property VolumenCaptado As Double
    Public Property FiltracionRealizada As Boolean
    Public Property SODISRealizada As Boolean
    Public Property Estado As String

    Public Shared Historial As New List(Of LoteTratamiento)

    Public Property Zona As String

End Class

