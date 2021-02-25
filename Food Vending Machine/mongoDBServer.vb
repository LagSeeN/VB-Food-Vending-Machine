Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System
Imports System.IO
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Security.Cryptography.X509Certificates

Public Class MongoDBServer
    Dim server = "mongodb+srv://clustertni.kt6oq.mongodb.net/Food_Vending_Machine?authSource=%24external&authMechanism=MONGODB-X509&retryWrites=true&w=majority"
    Dim cert = New X509Certificate2(My.Resources.X509_cert_2554937799609490701, "")
    Dim base64 As New Base64
    Dim branch As String = "Visual Basic"
    Public Function CountFood()
        Dim settings = MongoClientSettings.FromConnectionString(server)
        settings.SslSettings = New SslSettings With {
            .ClientCertificates = New List(Of X509Certificate)() From {
                cert
            }
        }
        Dim conn = New MongoClient(settings)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", branch)
        Dim found = database.GetCollection(Of BsonDocument)("products")
        Return found.CountDocuments(filter)
    End Function

    Public Function GetAllImage()
        Dim settings = MongoClientSettings.FromConnectionString(server)
        settings.SslSettings = New SslSettings With {
            .ClientCertificates = New List(Of X509Certificate)() From {
                cert
            }
        }
        Dim conn = New MongoClient(settings)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("products")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", branch)
        Dim cursor = collection.Find(filter).Project(Builders(Of BsonDocument).Projection.Include("image")).ToList
        Dim image_list(cursor.Count) As Image
        For i = 0 To cursor.Count - 1
            image_list(i) = base64.ConvertByteToImage(base64.ConvertBase64ToByteArray(cursor(i)("image")))
        Next
        Return image_list
    End Function
    Public Function GetAllFood()
        Dim settings = MongoClientSettings.FromConnectionString(server)
        settings.SslSettings = New SslSettings With {
            .ClientCertificates = New List(Of X509Certificate)() From {
                cert
            }
        }
        Dim conn = New MongoClient(settings)
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
        Dim settings = MongoClientSettings.FromConnectionString(server)
        settings.SslSettings = New SslSettings With {
            .ClientCertificates = New List(Of X509Certificate)() From {
                cert
            }
        }
        Dim conn = New MongoClient(settings)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("products")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of BsonObjectId)("_id", ObjectId.Parse(id))
        Dim food = collection.Find(filter).Project(Builders(Of BsonDocument).Projection.Include("_id").Include("product_name").Include("price").Include("stock").Include("image").Include("time")).First
        Return food
    End Function

    Public Function Insert(product As Product)
        Dim result As Boolean

        Dim settings = MongoClientSettings.FromConnectionString(server)
        settings.SslSettings = New SslSettings With {
            .ClientCertificates = New List(Of X509Certificate)() From {
                cert
            }
        }
        Dim conn = New MongoClient(settings)
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

    Public Function Update(product As Product)
        Dim result As Boolean

        Dim settings = MongoClientSettings.FromConnectionString(server)
        settings.SslSettings = New SslSettings With {
            .ClientCertificates = New List(Of X509Certificate)() From {
                cert
            }
        }
        Dim conn = New MongoClient(settings)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("products")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of BsonObjectId)("_id", product.id)

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
            collection.UpdateOne(filter, New BsonDocument("$set", data))
            result = True
        Catch ex As Exception
            Debug.Fail(ex.Message)
            result = False
        End Try

        Return result
    End Function

    Public Sub food_finish(id As String)
        Dim settings = MongoClientSettings.FromConnectionString(server)
        settings.SslSettings = New SslSettings With {
            .ClientCertificates = New List(Of X509Certificate)() From {
                cert
            }
        }
        Dim conn = New MongoClient(settings)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("products")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of BsonObjectId)("_id", ObjectId.Parse(id))
        Dim stock_data = collection.Find(filter).Project(Builders(Of BsonDocument).Projection.Include("_id").Include("product_name").Include("price").Include("stock")).First

        'update stock
        filter = Builders(Of BsonDocument).Filter.Eq(Of BsonObjectId)("_id", stock_data("_id"))

        Dim data As BsonDocument = New BsonDocument()
        Dim new_stock As Integer = stock_data("stock")
        With data
            .Add("stock", new_stock - 1)
        End With
        collection.UpdateOne(filter, New BsonDocument("$set", data))

        'write transaction
        collection = database.GetCollection(Of BsonDocument)("transaction")
        data = New BsonDocument()

        With data
            .Add("date", Date.Now())
            .Add("food_item", stock_data("_id"))
            .Add("food_name", stock_data("product_name"))
            .Add("price", stock_data("price"))
            .Add("branch", "Visual Basic")
        End With
        collection.InsertOne(data)
        'write coin
    End Sub
End Class
