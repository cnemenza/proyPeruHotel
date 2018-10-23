using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_PeruHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioReserva" en el código y en el archivo de configuración a la vez.
    public class ServicioReserva : IServicioReserva
    {
        public List<dataReserva> GetReservasConcluidasClientes(string strCod)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<dataReserva> objListaReserva = new List<dataReserva>();

            try
            {
                //haciendo la consulta con LINQ, sin usar el SP
                String a = "Concluido";
                var query = (from reser in MiHotel.vw_VistaReserva
                             where reser.id_cliente == strCod &&
                             reser.Estado == a
                             select new //par amandar el campo proyectado
                             {
                                 id_reserva = reser.id_reserva,
                                 reser_fechaIngreso = reser.reser_fechaIngreso,
                                 reser_fechaReser = reser.reser_fechaReser,
                                 reser_fechaSalida = reser.reser_fechaSalida,
                                 id_cliente = reser.id_cliente,
                                 Nombre = reser.Nombre,
                                 Cant_Hab = reser.Cant_Hab,
                                 Total = reser.Total,
                                 Estado = reser.Estado
                             });

                foreach (var resultado in query)
                {
                    dataReserva objReservaBE = new dataReserva();

                    objReservaBE.IdReserva = resultado.id_reserva;
                    objReservaBE.ReserFechaIngreso = Convert.ToDateTime(resultado.reser_fechaIngreso);
                    objReservaBE.ReserFechaReser = Convert.ToDateTime(resultado.reser_fechaReser);
                    objReservaBE.ReserFechaSalida = Convert.ToDateTime(resultado.reser_fechaSalida);
                    objReservaBE.IdCliente = resultado.id_cliente;
                    objReservaBE.Nombre = resultado.Nombre;
                    objReservaBE.CantHab = Convert.ToSingle(resultado.Cant_Hab);
                    objReservaBE.Total = Convert.ToSingle(resultado.Total);
                    objReservaBE.Estado = resultado.Estado;


                    //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                    objListaReserva.Add(objReservaBE);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return objListaReserva;
        }

        public List<dataReserva> GetReservasActivasClientes(string strCod)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<dataReserva> objListaReserva = new List<dataReserva>();

            try
            {
                //haciendo la consulta con LINQ, sin usar el SP
                String a = "Activo";
                var query = (from reser in MiHotel.vw_VistaReserva
                             where reser.id_cliente == strCod &&
                             reser.Estado == a
                             select new //par amandar el campo proyectado
                             {
                                 id_reserva = reser.id_reserva,
                                 reser_fechaIngreso = reser.reser_fechaIngreso,
                                 reser_fechaReser = reser.reser_fechaReser,
                                 reser_fechaSalida = reser.reser_fechaSalida,
                                 id_cliente = reser.id_cliente,
                                 Nombre = reser.Nombre,
                                 Cant_Hab = reser.Cant_Hab,
                                 Total = reser.Total,
                                 Estado = reser.Estado
                             });

                foreach (var resultado in query)
                {
                    dataReserva objReservaBE = new dataReserva();

                    objReservaBE.IdReserva = resultado.id_reserva;
                    objReservaBE.ReserFechaIngreso = Convert.ToDateTime(resultado.reser_fechaIngreso);
                    objReservaBE.ReserFechaReser = Convert.ToDateTime(resultado.reser_fechaReser);
                    objReservaBE.ReserFechaSalida = Convert.ToDateTime(resultado.reser_fechaSalida);
                    objReservaBE.IdCliente = resultado.id_cliente;
                    objReservaBE.Nombre = resultado.Nombre;
                    objReservaBE.CantHab = Convert.ToSingle(resultado.Cant_Hab);
                    objReservaBE.Total = Convert.ToSingle(resultado.Total);
                    objReservaBE.Estado = resultado.Estado;


                    //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                    objListaReserva.Add(objReservaBE);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return objListaReserva;
        }
    }
}
