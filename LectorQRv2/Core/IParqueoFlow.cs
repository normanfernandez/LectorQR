using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LectorQRv2.Core
{
    public interface IParqueoFlow
    {
        //Interfaz de cómo debe funcionar el sistema de control de entrada y salida

        void EliminarPlacasPendientes();

        void EntradaInsertarQR(string QR);
        void EntradaInsertarPlaca(Models.Placa placa);

        List<Models.Parqueo> SalidaInsertarQR(string QR);
        Models.Parqueo SalidaInsertarPlaca(Models.Placa placa);
        void ConfirmarSalida(Models.Parqueo parqueo);
    }
}
