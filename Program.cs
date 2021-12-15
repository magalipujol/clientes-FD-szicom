using System;
using ModeloDatos;
using Importador;
using CalculadoraService;


namespace clientes_DC_szicom
{
    class Program
    {
        static void Main(string[] args)
        {
            var transportes = Parser.TxtToTteTerceros("C:/Users/magalip/Documents/Datos problema/Datos Problemas/tte_terceros.txt");
        }
    }

    //public DateTime StringToDate(string dateString)
    //{
    //    string[] array = dateString.Split("/"); 
    //    return new DateTime(array[0])
    //}
}
