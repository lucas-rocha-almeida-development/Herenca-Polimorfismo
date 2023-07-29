using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenca_Polimorfismo.Entities
{
    internal class FuncionarioTercerizado : Funcionarios //herda ou extende
    {

        public double AdditionalCharge { get; set; }//dispesa adicional ($)


        //CONSTRUTORES
        public FuncionarioTercerizado()
        {}
        //construtor com 4 argumentos
        public FuncionarioTercerizado(string name, int hours, double valuePerHours, double additionalCharge)
            : base (name,hours,valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }


        //sobreposição do metodo
        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * AdditionalCharge;//110% * dispensa adicional
        }

    }




}
