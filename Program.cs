using System;
using ModeloDatos;
using Importador;
using CalculadoraService;
using System.Linq;

namespace clientes_DC_szicom
{
    class Program
    {
        static void Main(string[] args)
        {
            var transportes = Parser.TxtToTteTerceros("C:/Users/magalip/Documents/Datos problema/Datos Problemas/tte_terceros-ago-2017.txt");
            DateTime fechaInicio = new DateTime(2017, 8, 1);
            DateTime fechaFin = new DateTime(2017, 8, 31); 
            var servicios = Parser.TxtToVolServicio("C:/Users/magalip/Documents/Datos problema/Datos Problemas/volumen_servicio_v2.txt");

            int unaSuma = servicios.Where(s => s.FechaInicio <= fechaInicio && s.FechaFin >= fechaFin && s.IdCliente == 665)
                          .Sum(s => s.CDC);
            Console.WriteLine(unaSuma);
             




        }
    }
}
