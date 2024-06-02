Public Class Fechas
    Public Property Edad As String
    Public Property Fdn As DateTime

    Public Sub Nombreyfecha(edad As String, FDN As DateTime)

        FDN = FDN.Date
        edad = edad
    End Sub

    Public Overrides Function ToString() As String
        Return "Edad: " & Edad & vbCrLf & "Fecha de nacimiento: " & Fdn.ToString()
    End Function


End Class