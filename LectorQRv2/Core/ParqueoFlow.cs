using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LectorQRv2.Models;
using LectorQRv2.DAO;

namespace LectorQRv2.Core
{
    public class ParqueoFlow : IParqueoFlow
    {
        //Atributos de la clase
        private Repository<Parqueo> ParqueoDAO = new Repository<Parqueo>(); //Objeto de manejo de datos
        private List<Parqueo> listaParqueoSalida = null; //Lista utilizada para la salida del vehículo

        public void EntradaInsertarPlaca(Placa placa)
        {
            Parqueo parqueo = ParqueoDAO.SelectSingle(p => p.placa == Placa.PENDIENTE);
            if (parqueo == null)
                throw new PlacaNoPendienteException();

            parqueo.placa = placa.NoSerie;

            ParqueoDAO.SaveAll();
        }

        public void EntradaInsertarQR(string QR)
        {
            //Primera función a llamar en el ciclo.
            //Inserta el QR del cliente

            if (ParqueoDAO.SelectSingle(p => p.placa == Placa.PENDIENTE ) != null)
                throw new PlacaPendienteException();

            Parqueo parqueo = new Parqueo
            {
                cedula = QR,
                fecha_entrada = DateTime.Now,
                fecha_salida = null,
                placa = Placa.PENDIENTE
            };

            ParqueoDAO.Insert(parqueo);
            ParqueoDAO.SaveAll();
        }

        public Parqueo SalidaInsertarPlaca(Placa placa)
        {
            //Función para insertar la placa para la salida

            if (listaParqueoSalida == null || listaParqueoSalida.Count == 0)
                throw new Exception("Registros de salida no llamados");

            Parqueo parqueo = listaParqueoSalida.Find(p => p.placa == placa.NoSerie);
            listaParqueoSalida = null;

            return parqueo;
        }

        public List<Parqueo> SalidaInsertarQR(string QR)
        {
            listaParqueoSalida = ParqueoDAO.FindAll(p => p.cedula == QR && p.fecha_salida == null).ToList();
            return this.listaParqueoSalida;
        }

        public void ConfirmarSalida(Models.Parqueo parqueo)
        {
            //Marca la salida del vehículo
            parqueo.fecha_salida = DateTime.Now;
            ParqueoDAO.SaveAll();
            listaParqueoSalida = null;
        }

        public void EliminarPlacasPendientes()
        {
            //Elimina todas las placas pendientes del sistema

            List<Parqueo> parqueoList = ParqueoDAO.FindAll(p => p.placa == Placa.PENDIENTE).ToList();

            foreach (var parqueo in parqueoList)
                ParqueoDAO.Delete(p => p.id == parqueo.id);

            ParqueoDAO.SaveAll();
        }
    }

    public class PlacaPendienteException : Exception
    {
        //Excepción en caso de que que haya placa pendiente
        public PlacaPendienteException() : base("Existe un parqueo con placa pendiente en la base de datos!");
    }

    public class PlacaNoPendienteException : Exception
    {
        //Excepción que ocurre si se intenta insertar una placa para la entrada
        public PlacaNoPendienteException() : base("No hay placas pendientes en la base de datos!") { }
    }
}
