using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int tamanhoNome;
            int idade;
            int salario;
            string sexo;
            string estadoCivil;

            Console.Write("Digite um nome: ");
            nome = Console.ReadLine();
            tamanhoNome = nome.Length;
                while (tamanhoNome <= 3)
                {
                    Console.WriteLine("A quantidade informada não condiz com o mínimo estabelecido de 3 caracteres");
                    Console.ReadLine();
                    Console.Clear();
                    Console.Write("Digite um nome novamente: ");
                    nome = Console.ReadLine();
                    tamanhoNome = nome.Length;
                }

            Console.Clear();
            Console.Write("Digite uma idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
                while (idade < 0 || idade > 150)
                {
                    Console.WriteLine("A quantidade informada não condiz com a idade estabelecida entre 0 à 150 anos");
                    Console.ReadLine();
                    Console.Clear();
                    Console.Write("Digite uma idade novamente: ");
                    idade = Convert.ToInt32(Console.ReadLine());
                }

            Console.Clear();
            Console.Write("Digite um salário: ");
            salario = Convert.ToInt32(Console.ReadLine());
                while (salario == 0)
                {
                    Console.WriteLine("O salário informado deve ser maior que 0");
                    Console.ReadLine();
                    Console.Clear();
                    Console.Write("Digite um salário novamente: ");
                    salario = Convert.ToInt32(Console.ReadLine());
                }

            Console.Clear();
            Console.Write("Digite o sexo: ");
            sexo = Console.ReadLine();
            while (!(sexo == "f" || sexo == "m"))
            {
                Console.WriteLine("O sexo deve ser apenas 'm' ou 'f'");
                Console.ReadLine();
                Console.Clear();
                Console.Write("Digite o sexo novamente: ");
                sexo = Console.ReadLine();
            }


            Console.Clear();
            Console.Write("Digite seu estado civíl: ");
            estadoCivil = Console.ReadLine();
                while (!(estadoCivil == "s" || estadoCivil == "c" || estadoCivil == "v" || estadoCivil == "d"))
                {
                    Console.WriteLine("O estado civíl não condiz com o informado que deve ser 's', 'c', 'v' ou 'd'");
                    Console.ReadLine();
                    Console.Clear();
                    Console.Write("Digite seu estado civíl novamente: ");
                    estadoCivil = Console.ReadLine();
                }

            RetornoInformacoes(nome, idade, salario, sexo, estadoCivil);

            Console.ReadLine();
        }

        public static void RetornoInformacoes(string nome, int idade, int salario, string sexo, string estadoCivil)
        {
            Console.WriteLine("Informações Pessoais: \n" +
                "Nome: " + nome + "\n" +
                "Idade: " + idade + "\n" +
                "Salário: " + salario + "\n" +
                "Sexo: " + sexo + "\n" +
                "Estado Civíl: " + estadoCivil + "\n"
                );
        }
    }

}
