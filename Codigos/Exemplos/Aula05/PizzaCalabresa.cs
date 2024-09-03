using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aula5.Pizza;

namespace Aula5
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa()
        {
            Nome = "Calabresa";
        }
        protected override void AssarPizza()
        {
            Console.WriteLine($"Assando {Nome} a 200ºC por 15 minutos no forno a lenha.");
        }

        protected override void ColocarRecheio()
        {
            Console.WriteLine("Colocando molho, mussarela, calabresa e cebola em rodelas.");
        }

        protected override void CortarPizza()
        {
            Console.WriteLine("Padrão de corte rudimentar, com 8 fatias.");
        }

        protected override void PrepararMassa()
        {
            Console.WriteLine($"Misturando os ingredientes da pizza {Nome}.");
        }

        protected override void PrepararMolho()
        {
            Console.WriteLine("Cozinhando a massa de 6 tomates, temperada com sal e pimenta.");
        }
    }
}
