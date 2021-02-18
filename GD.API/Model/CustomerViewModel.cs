using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using GD.API.Model;

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