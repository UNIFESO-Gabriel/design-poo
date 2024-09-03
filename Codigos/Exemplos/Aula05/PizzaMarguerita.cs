using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aula5.Pizza;

namespace Aula5
{
    public class PizzaMarguerita : Pizza
    {
        public PizzaMarguerita()
        {
            Nome = "Marguerita";
        }

        protected override void AssarPizza()
        {
            Console.WriteLine($"Assando {Nome} a 180ºC por 30 minutos no forno a lenha.");
        }

        protected override void ColocarRecheio()
        {
            Console.WriteLine("Colocando molho, mussarela, manjericão e tomate em rodelas.");
        }

        protected override void CortarPizza()
        {
            Console.WriteLine("Padrão de corte original, com 6 fatias.");
        }

        protected override void PrepararMassa()
        {
            Console.WriteLine($"Misturando os ingredientes da massa da {Nome}.");
        }

        protected override void PrepararMolho()
        {
            Console.WriteLine("Cozinhando a massa de 8 tomates, temperada com sal e pimenta.");
        }
    }
}
