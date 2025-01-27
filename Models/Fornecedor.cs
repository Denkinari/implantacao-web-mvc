using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public string? Email { get; set; }

        public Fornecedor(int Id, string? Nome, string? Cnpj, string Email)
        {
            this.Id = Id;
            this.Email = Email;
            this.Cnpj = Cnpj;
            this.Nome = Nome;
        }
    }
}