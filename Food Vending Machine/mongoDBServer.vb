Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class MongoDBServer

    Dim server As String = "mongodb+srv://vending_machine:wYvBQGPZHF6tMGbqHueyZZeWMjcuq47zSA6p9DifL3WeExvSi5RWE4hYuuwAcgG4ZoSNoXyYb37txCESZw6UfffmFrnuRZXP4Rpqd9LfRMEq8K3toKAwsuUcbakHvz58@clustertni.kt6oq.mongodb.net/Food_Vending_Machine?retryWrites=true&w=majority"
    Dim base64 As New Base64
    Public Function CountFood()
        Dim conn = New MongoClient(server)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", "Visual Basic")
        Dim found = database.GetCollection(Of BsonDocument)("products")
        Return found.CountDocuments(filter)
    End Function

    Public Function GetAllImage()
        Dim conn = New MongoClient(server)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("products")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", "Visual Basic")
        Dim cursor = collection.Find(filter).Project(Builders(Of BsonDocument).Projection.Include("image").Exclude("_id")).ToList
        Dim image_list(cursor.Count)
        For i = 0 To cursor.Count - 1
            image_list(i) = base64.ConvertByteToImage(base64.ConvertBase64ToByteArray(cursor(i)("image")))
        Next
        Return image_list
    End Function
    Public Function GetAllFood()
        Dim conn = New MongoClient(server)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("products")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", "Visual Basic")
        Dim cursor = collection.Find(filter).Project(Builders(Of BsonDocument).Projection.Include("_id").Include("product_name").Include("stock")).ToList
        Dim foods_list(cursor.Count)
        For i = 0 To cursor.Count - 1
            foods_list(i) = cursor(i)
        Next
        Return foods_list
    End Function

    Public Function GetFood(id As String)
        Dim conn = New MongoClient(server)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("products")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of BsonObjectId)("_id", ObjectId.Parse(id))
        Dim food = collection.Find(filter).Project(Builders(Of BsonDocument).Projection.Include("_id").Include("product_name").Include("price").Include("stock").Include("image")).First
        Return food
    End Function

    Public Function Insert(product As Product)
        Dim result As Boolean

        Dim conn = New MongoClient(server)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("products")

        Dim data As BsonDocument = New BsonDocument()

        With data
            .Add("product_name", product.product_name)
            .Add("price", product.price)
            .Add("stock", product.stock)
            .Add("image", product.image)
            .Add("time", product.time)
            .Add("branch", "Visual Basic")
        End With

        Try
            collection.InsertOne(data)
            result = True
        Catch ex As Exception
            Debug.Fail(ex.Message)
            result = False
        End Try

        Return result
    End Function


    'def get_food_time(_id)
    '    With pymongo.MongoClient(server) As conn:
    '        db = conn.get_database('Food_Vending_Machine')
    '        where = {'_id': _id}
    '        cursor = db['products'].find_one(where, {'_id': 1, 'time': 1})
    '        Return cursor


    'def food_finish(_id, current_food)
    '    With pymongo.MongoClient(server) As conn:
    '        db = conn.get_database('Food_Vending_Machine')
    '        where = {'_id': _id}
    '        db['products'].update({'_id': _id}, {'$set': {'stock': current_food - 1}})
    '        db['transaction'].insert_one(
    '            {'date': datetime.now(), 'food_item': _id, 'food_name': db['products'].find_one(where)['product_name'],
    '             'price': db['products'].find_one(where)['price']})
End Class
