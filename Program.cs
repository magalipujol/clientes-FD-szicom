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

            var clientesVolContratado = Filtro.FiltrarClientesConVolContratado(clientes, servicios);
            var clientesConConsumo = Filtro.FiltrarClientesConUnConsumo(clientesVolContratado, consumos);
            var clientesFD = Filtro.FiltrarClientesFD(clientesConConsumo);

            Console.WriteLine($"clientes con vol contratado (286) {clientesVolContratado.Count()}");
            Console.WriteLine($"clientes con consumo (11284) {clientesConConsumo.Count()}");
            Console.WriteLine($"clientes FD (49) {clientesFD.Count()}");
                
           







        }
    }
}
