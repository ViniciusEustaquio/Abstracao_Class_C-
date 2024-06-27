using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraindo_Celular_POO_C_.Models
{
    public class Nokia : Smartphome
    {
        public Nokia(int numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }


        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando App {nome} no Celular: {Modelo} ");
        }
    }
}