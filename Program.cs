using System;
using ModeloDatos;
using Importador;
using CalculadoraService;
using System.Linq;
using System.Collections.Generic;

namespace clientes_DC_szicom
{
    class Program
    {
        static void Main(string[] args)
        {
            var transportes = Parser.TxtToTteTerceros("C:/Users/magalip/Documents/Datos problema/Datos Problemas/tte_terceros-ago-2017.txt");
            var servicios = Parser.TxtToVolServicio("C:/Users/magalip/Documents/Datos problema/Datos Problemas/volumen_servicio_v2.txt");
            var consumos = Parser.TxtToConsumo("C:/Users/magalip/Documents/Datos problema/Datos Problemas/consumos-ago-2017.txt");
            var clientes = Parser.TxtToClients("C:/Users/magalip/Documents/Datos problema/Datos Problemas/clientes.txt");

            DateTime fechaInicio = new DateTime(2017, 8, 1);
            DateTime fechaFin = new DateTime(2017, 8, 31); 

            int unaSuma = servicios.Where(s => s.FechaInicio <= fechaInicio && s.FechaFin >= fechaFin && s.IdCliente == 665)
                          .Sum(s => s.CDC);

            var query = (from servicio in servicios
                        join cliente in clientes
                        on servicio.IdCliente equals cliente.Id
                        where servicio.FechaInicio <= fechaInicio && servicio.FechaFin >= fechaFin && servicio.Firme == "S" && servicio.CDC != 0
                        select cliente).ToList();





        }
    }
}
