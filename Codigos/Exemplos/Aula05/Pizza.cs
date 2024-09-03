using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    public abstract class Pizza
    {
		private string _nome;

		public string Nome
		{
			get { return _nome; }
			protected set { _nome = value; }
		}

		// Métodos para montar a pizza.
		protected abstract void PrepararMassa();
        protected abstract void PrepararMolho();
        protected abstract void ColocarRecheio();
        protected abstract void AssarPizza();
        protected abstract void CortarPizza();

		// Método FACHADA que monta a pizza.
		public void MontarPizza()
		{
			PrepararMassa();
            PrepararMolho();
			ColocarRecheio();
			AssarPizza();
			CortarPizza();
        }


    }
}
