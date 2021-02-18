﻿Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class mongoDBServer

    Dim server As String = "mongodb+srv://vending_machine:wYvBQGPZHF6tMGbqHueyZZeWMjcuq47zSA6p9DifL3WeExvSi5RWE4hYuuwAcgG4ZoSNoXyYb37txCESZw6UfffmFrnuRZXP4Rpqd9LfRMEq8K3toKAwsuUcbakHvz58@clustertni.kt6oq.mongodb.net/Food_Vending_Machine?retryWrites=true&w=majority"
    Public Function search_data()
        Dim conn = New MongoClient(server)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim found = database.GetCollection(Of BsonDocument)("products")
        MessageBox.Show(found.CountDocuments("{}"))
    End Function

    Public Function count_data()
        Dim conn = New MongoClient(server)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim found = database.GetCollection(Of BsonDocument)("products")
        Return found.CountDocuments("{}")
    End Function

    Public Function get_all_image()
        Dim conn = New MongoClient(server)
        Dim database = conn.GetDatabase("Food_Vending_Machine")
        Dim collection = database.GetCollection(Of BsonDocument)("products")
        Dim cursor = collection.Find(New BsonDocument()).ToList
        For Each t In cursor
            MessageBox.Show(String.Format("{0}", t("product_name")))
        Next
    End Function


    'def get_all_image()
    '    With pymongo.MongoClient(server) As conn:
    '        db = conn.get_database('Food_Vending_Machine')
    '        cursor = db['products'].find({}, {'image': 1})
    '        image = []
    '        For i in cursor:
    '            image.append(i['image'])
    '        Return image


    'def get_all_status()
    '    With pymongo.MongoClient(server) As conn:
    '        db = conn.get_database('Food_Vending_Machine')
    '        cursor = db['products'].find({}, {'stock': 1})
    '        status = []
    '        For i in cursor:
    '            status.append(i['stock'])
    '        Return status


    'def get_all_ids()
    '    With pymongo.MongoClient(server) As conn:
    '        db = conn.get_database('Food_Vending_Machine')
    '        cursor = db['products'].find()
    '        _id = []
    '        For i in cursor:
    '            _id.append(i['_id'])
    '        Return _id


    'def get_food(_id)
    '    With pymongo.MongoClient(server) As conn:
    '        db = conn.get_database('Food_Vending_Machine')
    '        where = {'_id': _id}
    '        cursor = db['products'].find_one(where, {'_id': 1, 'product_name': 1, 'price': 1, 'stock': 1})
    '        Return cursor


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


    'def export_log()
    '    With pymongo.MongoClient(server) As conn:
    '        db = conn.get_database('Food_Vending_Machine')
    '        cursor = db['transaction'].find({})
    '        df = pd.DataFrame(list(cursor))
    '    current_date = df['date'].dt.month
    '    df['Month'] = current_date
    '    df_export = df[df['Month'] == 2].groupby(['food_name'])[['food_name', 'price']].agg(
    '        {'food_name': ['count'], 'price': ['sum']}).sort_values(by=[('food_name', 'count'), ('price', 'sum')],
    '                                                                ascending=[0, 1])
    '    filename = 'Food Vending Machine ' + str(datetime.now().year) + '-' + str(datetime.now().month)
    '    write_excel = pd.ExcelWriter(desktop + filename + '.xlsx')
    '    sheet_name = filename
    '    df_export.to_excel(write_excel, sheet_name, encoding='utf8')
    '    write_excel.save()
End Class
