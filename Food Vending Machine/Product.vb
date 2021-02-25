Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class Product
    Public Property id As ObjectId
    Public Property product_name As String
    Public Property price As Double
    Public Property stock As Int32
    Public Property image As String
    Public Property time As Double
    Public Property branch As String
    Public Property is_available As Int32
End Class
