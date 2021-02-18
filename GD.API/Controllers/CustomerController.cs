using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GD.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Net;
namespace GD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //GET api
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var connectionString = "mongodb://localhost:27017";
                var client = new MongoClient(connectionString);
                var db = client.GetDatabase("Estudo");
                var collection = db.GetCollection<BsonDocument>("Estudo");
                var response = collection.Find(new BsonDocument()).ToList();
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest("error");
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody] CustomerViewModel customer)
        {
            try
            {
                var connectionString = "mongodb://localhost:27017";
                var client = new MongoClient(connectionString);
                var db = client.GetDatabase("Estudo");
                var collection = db.GetCollection<BsonDocument>("Estudo");
                var document = new BsonDocument();
                document.Add("Nome", customer.Name);
                document.Add("CPF", customer.CPF);
                document.Add("CEP", customer.CEP);
                document.Add("Logradouro", customer.Logradouro);
                document.Add("Numero", customer.Numero);
                document.Add("Bairro", customer.Bairro);
                document.Add("Cidade", customer.Cidade);
                document.Add("UF", customer.Email);
                document.Add("Telefone", customer.Telefone);
                collection.InsertOne(document);
                dynamic response = new
                {
                    document,
                    message = "Criado com sucesso"
                };
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest("error");
            }
        }
        //[HttpPut]
        //public IActionResult Put([FromBody]CustomerViewModel customer)
        //{
        //    try
        //    {
        //        var connectionString = "mongodb://localhost:27017";
        //        var client = new MongoClient(connectionString);
        //        var db = client.GetDatabase("Estudo");
        //        var collection = db.GetCollection<BsonDocument>("Estudo");
        //        var update = new BsonDocument();
        //        update.Add("Name", customer.Name);
        //        update.Add("CPF", customer.CPF);
        //        update.Add("CEP", customer.CEP);
        //        update.Add("Logradouro", customer.Logradouro);
        //        update.Add("Numero", customer.Numero);
        //        update.Add("Bairro", customer.Bairro);
        //        update.Add("Cidade", customer.Cidade);
        //        update.Add("UF", customer.UF);
        //        update.Add("Telefone", customer.Telefone);
        //        var filter = new BsonDocument();
        //        collection.UpdateOne(filter, update);
        //        dynamic response = new
        //        {
        //            filter,
        //            message = "Atualizado com Sucesso"
        //        };
        //        return Ok();

        //    }
        //    catch (Exception)
        //    {
        //        return BadRequest("error");
        //    }
        //}
        //[HttpDelete]
        //public IActionResult Delete([FromBody] CustomerViewModel customer)
        //{
        //    try
        //    {
        //            var connectionString = "mongodb://localhost:27017";
        //            var client = new MongoClient(connectionString);
        //            var db = client.GetDatabase("Estudo");
        //            var collection = db.GetCollection<BsonDocument>("Estudo");
        //            var document = new BsonDocument();
        //            document.Add("Nome", customer.Name);
        //            document.Add("CPF", customer.CPF);
        //            document.Add("CEP", customer.CEP);
        //            document.Add("Logradouro", customer.Logradouro);
        //            document.Add("Numero", customer.Numero);
        //            document.Add("Bairro", customer.Bairro);
        //            document.Add("Cidade", customer.Cidade);
        //            document.Add("UF", customer.Email);
        //            document.Add("Telefone", customer.Telefone);
        //            collection.DeleteOne(document);
        //            dynamic response = new
        //            {
        //                document,
        //                message = "Criado com sucesso"
        //            };
        //            return Ok(response);
        //        }
        //    catch (Exception)
        //    {
        //        return BadRequest("error");
        //    }
        //}
    }
}
