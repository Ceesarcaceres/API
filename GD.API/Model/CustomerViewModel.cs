using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace GD.API.Model
{
    public class CustomerViewModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public int CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}

public class DashboardSmartRepository
{
    internal string _connectionString = "mongodb://localhost:27017";
    internal string _databaseName = "Estudo";

    public async void Teste()
    {
        var client = new MongoClient(_connectionString);
        var db = client.GetDatabase(_databaseName);

        var collection = db.GetCollection<BsonDocument>("Estudo");
        var filter = new BsonDocument("Code", "000001");


        var list = await collection.Find(filter).ToListAsync();
        foreach (var dc in list)
        {
            Console.WriteLine(dc);
        }
    }
}