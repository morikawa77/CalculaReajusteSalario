using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioReajustado
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, percentualReajuste, salarioReajustado;
            Console.WriteLine("Digite o salário atual: ");
            salarioAtual = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o porcentual de reajuste: ");
            percentualReajuste = Convert.ToDouble(Console.ReadLine());
            percentualReajuste = (percentualReajuste / 100) +1;
            salarioReajustado = salarioAtual * percentualReajuste;
            Console.Write("O valor do salário atualizado é " + salarioReajustado);
            Console.ReadLine();
        }
    }
}
