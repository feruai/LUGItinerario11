using BEntity;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class BLLPartido
    {
        public static void EliminarPartido(int idPartido)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())  //uso de bloque transaccional para eliminar el partido
                {
                    DALPartido.EliminarPartido(idPartido); //llamo al método de la DAL para eliminar el partido de la base de datos
                    trx.Complete(); //confirmo la transacción
                }
            }

            catch (Exception ex)
            {
                throw;
            }

        }

        public static void GuardarPartido(BEPartido partido)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope()) //uso de bloque transaccional 
                {
                        //reglas de negocio que deben cumplirse para guardar una partida

                    if (partido.EquipoLocal == "")
                    {
                        throw new Exception("el campo del EQUIPO LOCAL no puede estar vacío");
                    }

                    if (partido.EquipoVisitante == "")
                    {
                        throw new Exception("el campo del EQUIPO VISITANTE no puede estar vacío");
                    }

                    if (partido.EquipoLocal.Length <= 5)
                    {
                        throw new Exception("el campo del EQUIPO LOCAL tiene que tener una longitud mayor a 5");
                    }

                    if (partido.EquipoVisitante.Length <= 5)
                    {
                        throw new Exception("el campo del EQUIPO VISITANTE tiene que tener una longitud mayor a 5");
                    }

                    if (partido.FechaPartido.Date < DateTime.Now.Date) //valido el dia sin importar la hora
                    {
                        throw new Exception("la fecha del partido NO puede ser menor a la fecha actual");
                    }
                    if (partido.Deporte.IdDeporte == 0)  //cambio realizado
                    {
                        throw new Exception("el deporte NO está elegido");
                    }

                    DALPartido.GuardarPartido(partido);
                    trx.Complete(); //confirmo la transacción
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void ModificarResultado(int idPart, int marcLocal, int marcVisitante)
        {
            try
            {

               
                {
                    if (PartidoAptoParaModificar(idPart))
                    {
                        using (TransactionScope trx = new TransactionScope())  //bloque transaccional
                        {
                            DALPartido.ModificarResultado(idPart, marcLocal, marcVisitante);  //llamo a la DAL para modificar en la base 
                            trx.Complete(); //confirmo la transacción
                        }
                       
                    }
                    else
                    { throw new Exception("Para modificar los marcadores la fecha debe ser la de HOY"); }
                   
                }
                    
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static bool PartidoAptoParaModificar(int idPart)   //no requiere bloque transaccional
        {
            try
            {
                return DALPartido.PartidoAptoParaModificar(idPart); 
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<BEPartido> ObtenerListaPartidos()   //no requiere bloque transaccional
        {
            try
            {
                return DALPartido.ObtenerListaPartidos();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void CargarListaPartidos(List<BEPartido> listaPartidosBorrador)
        {
            try
            {
                using (TransactionScope trx = new TransactionScope())  //uso el bloque transaccional para verificar cada estudiante
                {
                    foreach (var partido in listaPartidosBorrador)
                    {
                        GuardarPartido(partido);
                    }
                    trx.Complete();
                }
            }

            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
