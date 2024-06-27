using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraindo_Celular_POO_C_.Models
{
    public abstract class Smartphome
    {
        public Smartphome(int numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        
        public int Numero { get; set; }
        protected string Modelo;
        protected string Imei;
        protected int Memoria; 
        
        
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        
        public void ReceberLigação()
        {
            Console.WriteLine("Recebendo ligação.....");
        }
        
        public virtual void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando App {nome}");
        }


    }
    

}