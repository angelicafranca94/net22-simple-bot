using MongoDB.Driver;

namespace SimpleBotCore.DBContext;

public class ConnectionStrings
{
    public MongoClient client { get; set; }
    public string db { get; set; }
    public string colletion { get; set; }
}
