using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Paciente { get; set; }

        public Cliente(int Id, string Nome, string Cpf, string? Email, string? Paciente)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Email = Email;
            this.Cpf = Cpf;
            this.Paciente = Paciente;
        }

    }
}