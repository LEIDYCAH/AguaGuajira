Public Class DatosFuente

    Public Property Id As String
    Public Property Tipo As String
    Public Property Nombre As String
    Public Property Ubicacion As String
    Public Property Capacidad As Double
    Public Property Estado As String

    Public Shared Historial As New List(Of DatosFuente)

End Class
