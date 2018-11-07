using DotNetCoreLearning.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesFilme.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DotNetCoreLearningContext(
                serviceProvider.GetRequiredService<DbContextOptions<DotNetCoreLearningContext>>()))
            {
                // Se já existir um filme na base de dados, o método seed não é executado
                if (context.Filme.Any())
                {
                    return;   // DB has been seeded
                }

                context.Filme.AddRange(
                    new Filme
                    {
                        Titulo = "When Harry Met Sally",
                        DataLancamento = DateTime.Parse("1989-2-12"),
                        Genero = "Romantic Comedy",
                        Preco = 7.99M
                    },

                    new Filme
                    {
                        Titulo = "Ghostbusters ",
                        DataLancamento = DateTime.Parse("1984-3-13"),
                        Genero = "Comedy",
                        Preco = 8.99M
                    },

                    new Filme
                    {
                        Titulo = "Ghostbusters 2",
                        DataLancamento = DateTime.Parse("1986-2-23"),
                        Genero = "Comedy",
                        Preco = 9.99M
                    },

                    new Filme
                    {
                        Titulo = "Rio Bravo",
                        DataLancamento = DateTime.Parse("1959-4-15"),
                        Genero = "Western",
                        Preco = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}