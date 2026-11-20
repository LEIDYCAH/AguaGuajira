Public Class Tanque

    Public Property Codigo As String
    Public Property Capacidad As Double
    Public Property VolumenAlmacenado As Double
    Public Property Estado As String

    Public Property PoblacionAsignada As String
    Public Property FechaAsignacion As Date?

    Public Sub New()
        Estado = "Disponible"
        PoblacionAsignada = ""
        FechaAsignacion = Nothing
    End Sub

End Class

