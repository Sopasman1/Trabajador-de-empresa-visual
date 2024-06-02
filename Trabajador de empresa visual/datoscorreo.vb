Public Class datoscorreo
    Public Property CURP As String
    Public Property RFC As String
    Public Property Correo As String
    Public Property Phone As String


    Public Sub New(cURP As String, Rfc As String, correo As String, phone As String)
        cURP = cURP
        Rfc = Rfc
        correo = correo
        phone = phone
    End Sub


    Public Sub Clear()
        CURP = ""
        RFC = ""
        Correo = ""
        Phone = ""
    End Sub


    Public Overrides Function ToString() As String
        Return CURP & RFC & Correo & Phone
    End Function

End Class
