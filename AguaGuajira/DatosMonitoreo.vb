
Public Class DatosMonitoreo

    Public Property Fecha As DateTime
    Public Property Sensor As String
    Public Property PH As Double
    Public Property Turbidez As Double
    Public Property TDS As Double
    Public Property Temperatura As Double
    Public Property Estado As String

    ' Historial compartido de mediciones
    Public Shared Historial As New List(Of DatosMonitoreo)

End Class


