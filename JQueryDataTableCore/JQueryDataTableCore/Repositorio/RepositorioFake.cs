using JQueryDataTableCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JQueryDataTableCore.Repositorio
{
    public static class RepositorioFake
    {
        private static int UltimoId = 0;
        private static IList<Cliente> clientesCadastrados = CarregarClientesCadastradosDefault();

        public static IList<Cliente> GetClientesCadastrados()
        {
            return clientesCadastrados;
        }

        public static IList<Cliente> CarregarClientesCadastradosDefault()
        {
            IList<Cliente> clientesDefaults = new List<Cliente>();
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Maria Ferreita",
                Sexo = "Feminino",
                Estado = "Rio de Janeiro",
                Idade = 26
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "João Silva",
                Sexo = "Masculino",
                Estado = "São Paulo",
                Idade = 32
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Marieta Julia",
                Sexo = "Feminino",
                Estado = "Rio de Janeiro",
                Idade = 24
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Juliana Mariz",
                Sexo = "Feminino",
                Estado = "Minas Gerais",
                Idade = 30
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Ricardo Ferreira",
                Sexo = "Masculino",
                Estado = "Rio de Janeiro",
                Idade = 30
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Mario Zafra",
                Sexo = "Masculino",
                Estado = "Minas Gerais",
                Idade = 28
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Julieta Severo",
                Sexo = "Feminino",
                Estado = "Minas Gerais",
                Idade = 27
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Christina Oliveira",
                Sexo = "Feminino",
                Estado = "Rio de Janeiro",
                Idade = 40
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Luana dos Santos",
                Sexo = "Feminino",
                Estado = "São Paulo",
                Idade = 22
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Tadeu Santoro",
                Sexo = "Masculino",
                Estado = "São Paulo",
                Idade = 25
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Luiz Bueno",
                Sexo = "Masculino",
                Estado = "São Paulo",
                Idade = 27
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Galvao Cesar",
                Sexo = "Masculino",
                Estado = "Rio de Janeiro",
                Idade = 27
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Arnaldo Santos",
                Sexo = "Masculino",
                Estado = "Rio de Janeiro",
                Idade = 28
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Bruna Salvatore",
                Sexo = "Feminino",
                Estado = "Minas Gerais",
                Idade = 35
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Luiza Severo",
                Sexo = "Feminino",
                Estado = "São Paulo",
                Idade = 29
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Juliana Aguiar",
                Sexo = "Feminino",
                Estado = "Rio de Janeiro",
                Idade = 23
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Beatriz Rosa",
                Sexo = "Feminino",
                Estado = "Rio de Janeiro",
                Idade = 37
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Juliana Silva",
                Sexo = "Feminino",
                Estado = "Rio de Janeiro",
                Idade = 35
            });
            clientesDefaults.Add(new Cliente()
            {
                Id = UltimoId++,
                Nome = "Maria Albuquerque",
                Sexo = "Feminino",
                Estado = "Rio de Janeiro",
                Idade = 35
            });

            return clientesDefaults;
        }

        public static int InserirNovoCliente(Cliente cliente)
        {
            cliente.Id = UltimoId++;
            clientesCadastrados.Add(cliente);

            return cliente.Id;
        }

        public static void AtualizarCliente(Cliente cliente)
        {
            Cliente clienteLocalizado = clientesCadastrados.ToList<Cliente>().Find(x => x.Id == cliente.Id);
            clienteLocalizado.Nome = cliente.Nome;
            clienteLocalizado.Sexo = cliente.Nome;
            clienteLocalizado.Idade = cliente.Idade;
        }

        public static void RemoverCliente(int Id)
        {
            Cliente clienteLocalizado = clientesCadastrados.ToList<Cliente>().Find(x => x.Id == Id);
            clientesCadastrados.Remove(clienteLocalizado);
        }
    }
}