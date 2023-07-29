using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenca_Polimorfismo.Entities
{
    internal class Funcionarios 
    {
        public string Name { get; set; }//nome do funcionario
        public int Hours { get; set; }// horas trabalhadas do funcionario
        public double ValuePerHours { get; set; } //valor de cada hora trabalhada

        //CONSTRUTORES 
        public Funcionarios()
        {


        }

        public Funcionarios(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHours = valuePerHours;
        }
        public virtual double  Pagamento() {
            //metodo de pagamento
        return Hours * ValuePerHours;
        
        }
    }
}
