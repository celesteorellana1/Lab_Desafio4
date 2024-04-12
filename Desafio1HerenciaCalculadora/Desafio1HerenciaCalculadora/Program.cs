using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1HerenciaCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Calculadora calc = new Calculadora("Casio", "fx-50");
            Console.WriteLine($"Suma: {calc.Sumar(15, 20)}");
            Console.WriteLine($"Resta: {calc.Restar(30, 16)}");
            Console.WriteLine($"Multiplicacion: {calc.Multiplicar(5, 25)}");
            Console.WriteLine($"Division: {calc.Dividir(80,5)}");

            CalculadoraCientifica cientifica = new CalculadoraCientifica("Xiaomi", "CalX");
            Console.WriteLine($"Potencia: {cientifica.Potencia(2, 3)}");
            Console.WriteLine($"Raiz: {cientifica.Raiz(16)}");
            Console.WriteLine($"Modulo: {cientifica.Modulo(20, 3)}");
            Console.WriteLine($"Logaritmo: {cientifica.Logaritmo(100, 10)}");

            double n1 = 128;
            double n2 = 8;
            double total = calc.Sumar(n1, n2);
            Console.WriteLine(total);
            double diferencia = calc.Restar(n1, n2);
            Console.WriteLine(diferencia);

            double raiz = cientifica.Raiz(n1);
            Console.WriteLine(raiz);

            MostrarTipo(calc);
            MostrarTipo(cientifica);

            Console.ReadLine();
        }

        public static void MostrarTipo(Calculadora calculadora)
        {
            Console.WriteLine(calculadora .Tipo());
        }
    }

    public class Calculadora
    {
        public Calculadora()
        {
        }

        public string Marca { get; set; }
        public string Serie { get; set;}

        public Calculadora(string marca, string serie)
        {
            Marca = marca;
            Serie = serie;
        }

        public double Sumar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Restar(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }

        public string Tipo()
        {
            return "Calculadora Basica";
        }
    }

    public class CalculadoraCientifica : Calculadora
    {
        public CalculadoraCientifica(string marca, string serie) : base(marca, serie)
        {
        }

        public double Potencia(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        public double Raiz(double n1)
        {
            return Math.Sqrt(n1);
        }

        public virtual string Tipo()
        {
            return "Cientifica";
        }
        
        public double Modulo(double n1, double n2)
        {
            return n1 % n2;
        }

        public double Logaritmo(double n1, double n2)
        {
            return Math.Log(n1, n2);
        }

    }
}