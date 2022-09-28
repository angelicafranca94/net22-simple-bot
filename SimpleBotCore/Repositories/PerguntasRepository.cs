using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using SimpleBotCore.DBContext;

namespace SimpleBotCore.Repositories;

public class Perguntas : IPerguntasRepository
{
    private readonly IMongoCollection<BsonDocument> _collection;
    private readonly ConnectionStrings _connectionStrings;


    public Perguntas(IOptions<ConnectionStrings> connectionStrings)
    {
        //var cliente = new MongoClient("mongodb://localhost:27017");
        //var db = cliente.GetDatabase("DBBot");
        //_collection = db.GetCollection<BsonDocument>("col01");

        _connectionStrings = connectionStrings.Value;
    }

    public void Perguntar(string pergunta)
    {
        var ask = new BsonDocument
                    {
                        { "Pergunta", pergunta }
                    };

        _collection.InsertOne(ask);
    }
}
