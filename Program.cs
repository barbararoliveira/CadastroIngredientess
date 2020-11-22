using System;
using cadastroingredientess.db;

namespace cadastroingredientess
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingrediente; 
            int tipo;

            Console.WriteLine("Olá usuário, digite o nome do novo ingrediente:");
            ingrediente = Console.ReadLine();
            Console.WriteLine("Qual o tipo (1, 2 ou 3)?");
            tipo = Convert.ToInt32(Console.ReadLine());

            using (var db = new hamburgueriaContext())
            {
                var novoIngrediente = new Ingrediente
                {
                    Id = Guid.NewGuid().ToString(),
                    Nome = ingrediente,
                    TipoIngredienteId = tipo,
                };

                db.Ingrediente.Add(novoIngrediente);
                db.SaveChanges();
            }    

            Console.WriteLine("Ingrediente incluso. Pressione qualquer tecla para finalizar:");
            Console.ReadKey();
        }
    }
}
