using Aula5;
using System;
using static Aula5.Pizza;
using static Aula5.PizzaCalabresa;
using static Aula5.PizzaMarguerita;

public class Program
{
    public static void Main(String[] args)
    {
        Pizza pizza = new PizzaMarguerita();
        pizza.MontarPizza();
    }
}