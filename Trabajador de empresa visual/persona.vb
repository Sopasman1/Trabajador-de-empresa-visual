Public Class persona

    Public Property Nombre As String ' Gets and sets the name
    Public Property ApellidoPaterno As String ' Gets and sets the paternal last name
    Public Property ApellidoMaterno As String ' Gets and sets the maternal last name

    ' Constructor to initialize properties with empty strings
    Public Sub New()
        Nombre = ""
        ApellidoPaterno = ""
        ApellidoMaterno = ""
    End Sub

    ' ToString method for a formatted string representation
    Public Overrides Function ToString() As String
        ' Use string interpolation for cleaner formatting
        Return $"Nombre: {Nombre}, Apellido Paterno: {ApellidoPaterno}, Apellido Materno: {ApellidoMaterno}"
    End Function

End Class

