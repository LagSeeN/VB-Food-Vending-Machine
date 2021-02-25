Imports MongoDB.Bson
Public Class Transaction
    Public Property _id As BsonObjectId
    '"_id" : ObjectId("6028c6b73995ea8d99574988"), 
    Public Property purchase_date As BsonDateTime
    '"date" : ISODate("2021-02-14T13:44:07.120+0000"), 
    Public Property food_item As BsonObjectId
    '"food_item" : ObjectId("60141d189320b3b12510a708"), 
    Public Property food_name As String
    '"food_name" : "ข้าวญี่ปุ่นผัดกระเทียม", 
    Public Property price As Double
    '"price" : 25.0, 
    Public Property branch As String
    '"branch" : "Python"
End Class
