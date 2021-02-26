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
    Public Function CountFood(is_sale As Boolean)
        Dim settings = MongoClientSettings.FromConnectionString(server)
        settings.SslSettings = New SslSettings With {
            .ClientCertificates = New List(Of X509Certificate)() From {
                cert
            }
        }
        Dim conn = New MongoClient(settings)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim filter As FilterDefinition(Of BsonDocument)
        If is_sale Then
            filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", branch) And Builders(Of BsonDocument).Filter.Eq(Of Int32)("is_available", 1)
        Else
            filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", branch)
        End If
        Dim found = database.GetCollection(Of BsonDocument)("products")
        Return found.CountDocuments(filter)
    End Function

    Public Function GetAllImage(is_sale As Boolean)
        Dim settings = MongoClientSettings.FromConnectionString(server)
        settings.SslSettings = New SslSettings With {
            .ClientCertificates = New List(Of X509Certificate)() From {
                cert
            }
        }
        Dim conn = New MongoClient(settings)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("products")
        Dim filter As FilterDefinition(Of BsonDocument)
        If is_sale Then
            filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", branch) And Builders(Of BsonDocument).Filter.Eq(Of Int32)("is_available", 1)
        Else
            filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", branch)
        End If
        Dim cursor = collection.Find(filter).Project(Builders(Of BsonDocument).Projection.Include("image")).ToList
        Dim image_list As New ArrayList
        For Each img In cursor
            image_list.Add(base64.ConvertByteToImage(base64.ConvertBase64ToByteArray(img("image"))))
        Next
        Return image_list
    End Function
    Public Function GetAllFood(is_sale As Boolean)
        Dim settings = MongoClientSettings.FromConnectionString(server)
        settings.SslSettings = New SslSettings With {
            .ClientCertificates = New List(Of X509Certificate)() From {
                cert
            }
        }
        Dim conn = New MongoClient(settings)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("products")
        Dim filter As FilterDefinition(Of BsonDocument)
        If is_sale Then
            filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", branch) And Builders(Of BsonDocument).Filter.Eq(Of Int32)("is_available", 1)
        Else
            filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", branch)
        End If
        Dim cursor = collection.Find(filter).Project(Builders(Of BsonDocument).Projection.Include("_id").Include("product_name").Include("stock")).ToList
        Dim foods_list As New ArrayList
        For Each item In cursor
            foods_list.Add(item)
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
        Dim food = collection.Find(filter).Project(Builders(Of BsonDocument).Projection.Include("_id").Include("product_name").Include("price").Include("stock").Include("image").Include("time").Include("is_available")).First
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
            .Add("is_available", product.is_available)
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
            .Add("is_available", product.is_available)
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

    Public Function GetTransaction() As List(Of TransactionResult)
        Dim settings = MongoClientSettings.FromConnectionString(server)
        settings.SslSettings = New SslSettings With {
            .ClientCertificates = New List(Of X509Certificate)() From {
                cert
            }
        }
        Dim conn = New MongoClient(settings)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("transaction")
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("branch", "Visual Basic")

        Dim options = New AggregateOptions() With {
            .AllowDiskUse = True
        }

        Dim currentDate As DateTime = DateTime.Now
        Dim firstDayOfMonth = New DateTime(currentDate.Year, currentDate.Month, 1)
        Dim lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddTicks(-1)

        Dim pipeline As PipelineDefinition(Of BsonDocument, BsonDocument) = New BsonDocument() {New BsonDocument("$match", New BsonDocument().Add("$and", New BsonArray().Add(New BsonDocument().Add("branch", "Visual Basic")).Add(New BsonDocument().Add("date", New BsonDocument().Add("$gte", New BsonDateTime(firstDayOfMonth)))).Add(New BsonDocument().Add("date", New BsonDocument().Add("$lte", New BsonDateTime(lastDayOfMonth)))))), New BsonDocument("$group", New BsonDocument().Add("_id", New BsonDocument().Add("price", "$price").Add("food_name", "$food_name")).Add("SUM(price)", New BsonDocument().Add("$sum", "$price")).Add("COUNT(food_name)", New BsonDocument().Add("$sum", 1))), New BsonDocument("$project", New BsonDocument().Add("food_name", "$_id.food_name").Add("price", "$_id.price").Add("SUM(price)", "$SUM(price)").Add("COUNT(food_name)", "$COUNT(food_name)").Add("_id", 0)), New BsonDocument("$group", New BsonDocument().Add("_id", BsonNull.Value).Add("distinct", New BsonDocument().Add("$addToSet", "$$ROOT"))), New BsonDocument("$unwind", New BsonDocument().Add("path", "$distinct").Add("preserveNullAndEmptyArrays", New BsonBoolean(False))), New BsonDocument("$replaceRoot", New BsonDocument().Add("newRoot", "$distinct")), New BsonDocument("$sort", New BsonDocument().Add("COUNT(food_name)", -1).Add("food_name", 1))}

        Dim results = New List(Of TransactionResult)

        Using cursor = collection.Aggregate(pipeline, options)
            While cursor.MoveNext()
                Dim batch = cursor.Current
                For Each document As BsonDocument In batch
                    Dim result = New TransactionResult()

                    result.FoodName = document("food_name")
                    result.Price = document("price")
                    result.TotalSale = document("SUM(price)")
                    result.Count = document("COUNT(food_name)")

                    results.Add(result)
                Next
            End While
        End Using
        Return results
    End Function

End Class
