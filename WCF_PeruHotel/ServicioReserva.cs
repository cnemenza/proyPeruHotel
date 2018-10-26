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
                             reser.estado == a
                             select new //par amandar el campo proyectado
                             {
                                 id_reserva = reser.id_reserva,
                                 reser_fechaReser = reser.reser_fechaReser,
                                 reser_fechaIngreso = reser.reser_fechaIngreso,
                                 reser_fechaSalida = reser.reser_fechaSalida,
                                 id_cliente = reser.id_cliente,
                                 nombre = reser.Nombre,
                                 cant_habi = reser.Cant_Hab,
                                 cant_dias = reser.Cant_Dias,
                                 monto_habi = reser.Monto_hab,
                                 monto_servicio = reser.Monto_servicio,
                                 total = reser.Total,
                                 estado = reser.estado
                             });

                foreach (var resultado in query)
                {
                    dataReserva objReservaBE = new dataReserva();

                    objReservaBE.IdReserva = resultado.id_reserva;
                    objReservaBE.ReserFechaIngreso = Convert.ToDateTime(resultado.reser_fechaIngreso);
                    objReservaBE.ReserFechaReser = Convert.ToDateTime(resultado.reser_fechaReser);
                    objReservaBE.ReserFechaSalida = Convert.ToDateTime(resultado.reser_fechaSalida);
                    objReservaBE.IdCliente = resultado.id_cliente;
                    objReservaBE.Nombre = resultado.nombre;
                    objReservaBE.CantHab = Convert.ToSingle(resultado.cant_habi);
                    objReservaBE.CantDias = Convert.ToSingle(resultado.cant_dias);
                    objReservaBE.MonHab = Convert.ToSingle(resultado.monto_habi);
                    objReservaBE.MonServicio = Convert.ToSingle(resultado.monto_servicio);
                    objReservaBE.Total = Convert.ToSingle(resultado.total);
                    objReservaBE.Estado = resultado.estado;


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
                             reser.estado == a
                             select new //par amandar el campo proyectado
                             {
                                 id_reserva = reser.id_reserva,
                                 reser_fechaReser = reser.reser_fechaReser,
                                 reser_fechaIngreso = reser.reser_fechaIngreso,
                                 reser_fechaSalida = reser.reser_fechaSalida,
                                 id_cliente = reser.id_cliente,
                                 nombre = reser.Nombre,
                                 cant_habi = reser.Cant_Hab,
                                 cant_dias = reser.Cant_Dias,
                                 monto_habi = reser.Monto_hab,
                                 monto_servicio = reser.Monto_servicio,
                                 total = reser.Total,
                                 estado = reser.estado
                             });

                foreach (var resultado in query)
                {
                    dataReserva objReservaBE = new dataReserva();

                    objReservaBE.IdReserva = resultado.id_reserva;
                    objReservaBE.ReserFechaIngreso = Convert.ToDateTime(resultado.reser_fechaIngreso);
                    objReservaBE.ReserFechaReser = Convert.ToDateTime(resultado.reser_fechaReser);
                    objReservaBE.ReserFechaSalida = Convert.ToDateTime(resultado.reser_fechaSalida);
                    objReservaBE.IdCliente = resultado.id_cliente;
                    objReservaBE.Nombre = resultado.nombre;
                    objReservaBE.CantHab = Convert.ToSingle(resultado.cant_habi);
                    objReservaBE.CantDias = Convert.ToSingle(resultado.cant_dias);
                    objReservaBE.MonHab = Convert.ToSingle(resultado.monto_habi);
                    objReservaBE.MonServicio = Convert.ToSingle(resultado.monto_servicio);
                    objReservaBE.Total = Convert.ToSingle(resultado.total);
                    objReservaBE.Estado = resultado.estado;


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

        public List<dataReserva> GetDetalleReservaHabitaciones(String strCod)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<dataReserva> objListaReserva = new List<dataReserva>();

            try
            {
                //haciendo la consulta con LINQ, sin usar el SP

                var query = (from reser in MiHotel.vw_VistaDetalleReserva
                             where reser.id_reserva == strCod
                             select new //par amandar el campo proyectado
                             {
                                 id_reserva = reser.id_reserva,
                                 id_habitacion = reser.id_habitacion,
                                 tipo_nombre = reser.tipo_nombre,
                                 tipo_precio = reser.tipo_precio,
                                 habi_num = reser.habi_num
                             });

                foreach (var resultado in query)
                {
                    dataReserva objReservaBE = new dataReserva();

                    objReservaBE.IdReserva = resultado.id_reserva;
                    objReservaBE.IdHabitacion = resultado.id_habitacion;
                    objReservaBE.TipoNombre = resultado.tipo_nombre;
                    objReservaBE.TipoPrecio = Convert.ToSingle(resultado.tipo_precio);
                    objReservaBE.HabiNum = resultado.habi_num;

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

        public List<dataReserva> GetDetalleReservaServicio(String strCod)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<dataReserva> objListaReserva = new List<dataReserva>();

            try
            {
                //haciendo la consulta con LINQ, sin usar el SP

                var query = (from reser in MiHotel.vw_VistaDetalleServicio
                             where reser.id_reserva == strCod
                             select new //par amandar el campo proyectado
                             {
                                 id_reserva = reser.id_reserva,
                                 id_cliente = reser.id_cliente,
                                 id_servicio = reser.id_servicio,
                                 servi_nom = reser.servi_nom,
                                 servi_precio = reser.servi_precio,
                                 cantidad = reser.cantidad
                             });

                foreach (var resultado in query)
                {
                    dataReserva objReservaBE = new dataReserva();

                    objReservaBE.IdReserva = resultado.id_reserva;
                    objReservaBE.IdCliente = resultado.id_cliente;
                    objReservaBE.IdServicio = resultado.id_servicio;
                    objReservaBE.ServiNom = resultado.servi_nom;
                    objReservaBE.ServiPrecio = Convert.ToSingle(resultado.servi_precio);
                    objReservaBE.CantidadServicio = Convert.ToSingle(resultado.cantidad);


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

       /* public List<dataReserva> GetAllReservasConcluidsaByFechas(DateTime fecIni, DateTime fecFin, String estado)
        {
            PeruHotelEntities MiHotel = new PeruHotelEntities();
            List<dataReserva> objListaReserva = new List<dataReserva>();

            try
            {
                if (estado == "1") //Activas
                {
                    var query = (from reser in MiHotel.vw_VistaReserva
                                 where reser.estado == "Concluido" &&
                                 reser.reser_fechaReser>=fecIni &&
                                 reser.reser_fechaReser <=fecFin
                                 select new //par amandar el campo proyectado
                                 {
                                     id_reserva = reser.id_reserva,
                                     reser_fechaReser = reser.reser_fechaReser,
                                     reser_fechaIngreso = reser.reser_fechaIngreso,
                                     reser_fechaSalida = reser.reser_fechaSalida,
                                     id_cliente = reser.id_cliente,
                                     nombre = reser.Nombre,
                                     cant_habi = reser.Cant_Hab,
                                     cant_dias = reser.Cant_Dias,
                                     monto_habi = reser.Monto_hab,
                                     monto_servicio = reser.Monto_servicio,
                                     total = reser.Total,
                                     estado = reser.estado
                                 });
                    foreach (var resultado in query)
                    {
                        dataReserva objReservaBE = new dataReserva();

                        objReservaBE.IdReserva = resultado.id_reserva;
                        objReservaBE.ReserFechaIngreso = Convert.ToDateTime(resultado.reser_fechaIngreso);
                        objReservaBE.ReserFechaReser = Convert.ToDateTime(resultado.reser_fechaReser);
                        objReservaBE.ReserFechaSalida = Convert.ToDateTime(resultado.reser_fechaSalida);
                        objReservaBE.IdCliente = resultado.id_cliente;
                        objReservaBE.Nombre = resultado.nombre;
                        objReservaBE.CantHab = Convert.ToSingle(resultado.cant_habi);
                        objReservaBE.CantDias = Convert.ToSingle(resultado.cant_dias);
                        objReservaBE.MonHab = Convert.ToSingle(resultado.monto_habi);
                        objReservaBE.MonServicio = Convert.ToSingle(resultado.monto_servicio);
                        objReservaBE.Total = Convert.ToSingle(resultado.total);
                        objReservaBE.Estado = resultado.estado;


                        //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                        objListaReserva.Add(objReservaBE);
                    }
                }
                else if (estado == "2") //Concluidas
                {
                    var query = (from reser in MiHotel.vw_VistaReserva
                                 where reser.estado == "Activo"
                                 select new //par amandar el campo proyectado
                                 {
                                     id_reserva = reser.id_reserva,
                                     reser_fechaReser = reser.reser_fechaReser,
                                     reser_fechaIngreso = reser.reser_fechaIngreso,
                                     reser_fechaSalida = reser.reser_fechaSalida,
                                     id_cliente = reser.id_cliente,
                                     nombre = reser.Nombre,
                                     cant_habi = reser.Cant_Hab,
                                     cant_dias = reser.Cant_Dias,
                                     monto_habi = reser.Monto_hab,
                                     monto_servicio = reser.Monto_servicio,
                                     total = reser.Total,
                                     estado = reser.estado
                                 });
                    foreach (var resultado in query)
                    {
                        dataReserva objReservaBE = new dataReserva();

                        objReservaBE.IdReserva = resultado.id_reserva;
                        objReservaBE.ReserFechaIngreso = Convert.ToDateTime(resultado.reser_fechaIngreso);
                        objReservaBE.ReserFechaReser = Convert.ToDateTime(resultado.reser_fechaReser);
                        objReservaBE.ReserFechaSalida = Convert.ToDateTime(resultado.reser_fechaSalida);
                        objReservaBE.IdCliente = resultado.id_cliente;
                        objReservaBE.Nombre = resultado.nombre;
                        objReservaBE.CantHab = Convert.ToSingle(resultado.cant_habi);
                        objReservaBE.CantDias = Convert.ToSingle(resultado.cant_dias);
                        objReservaBE.MonHab = Convert.ToSingle(resultado.monto_habi);
                        objReservaBE.MonServicio = Convert.ToSingle(resultado.monto_servicio);
                        objReservaBE.Total = Convert.ToSingle(resultado.total);
                        objReservaBE.Estado = resultado.estado;


                        //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                        objListaReserva.Add(objReservaBE);
                    }
                }
                else if (estado == "3") //Todas 
                {
                    var query = (from reser in MiHotel.vw_VistaReserva
                                 select new //par amandar el campo proyectado
                                 {
                                     id_reserva = reser.id_reserva,
                                     reser_fechaReser = reser.reser_fechaReser,
                                     reser_fechaIngreso = reser.reser_fechaIngreso,
                                     reser_fechaSalida = reser.reser_fechaSalida,
                                     id_cliente = reser.id_cliente,
                                     nombre = reser.Nombre,
                                     cant_habi = reser.Cant_Hab,
                                     cant_dias = reser.Cant_Dias,
                                     monto_habi = reser.Monto_hab,
                                     monto_servicio = reser.Monto_servicio,
                                     total = reser.Total,
                                     estado = reser.estado
                                 });
                    foreach (var resultado in query)
                    {
                        dataReserva objReservaBE = new dataReserva();

                        objReservaBE.IdReserva = resultado.id_reserva;
                        objReservaBE.ReserFechaIngreso = Convert.ToDateTime(resultado.reser_fechaIngreso);
                        objReservaBE.ReserFechaReser = Convert.ToDateTime(resultado.reser_fechaReser);
                        objReservaBE.ReserFechaSalida = Convert.ToDateTime(resultado.reser_fechaSalida);
                        objReservaBE.IdCliente = resultado.id_cliente;
                        objReservaBE.Nombre = resultado.nombre;
                        objReservaBE.CantHab = Convert.ToSingle(resultado.cant_habi);
                        objReservaBE.CantDias = Convert.ToSingle(resultado.cant_dias);
                        objReservaBE.MonHab = Convert.ToSingle(resultado.monto_habi);
                        objReservaBE.MonServicio = Convert.ToSingle(resultado.monto_servicio);
                        objReservaBE.Total = Convert.ToSingle(resultado.total);
                        objReservaBE.Estado = resultado.estado;


                        //Agregamos la instancia a la alista de Data Contractual a la lista de Vendedores
                        objListaReserva.Add(objReservaBE);
                    }
                }              
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return objListaReserva;
        }*/
    }
}
