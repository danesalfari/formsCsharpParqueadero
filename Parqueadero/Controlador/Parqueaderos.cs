using Parqueadero.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parqueadero.Controlador
{
    public class Parqueaderos
    {
        //Atributos
        private Vehiculo[] parque = new Vehiculo[3];
        private int ValorHora;
        private int TiempoParqueo;
        private double CierreCaja;

        //Metodos
        public Parqueaderos()
        {
        }

        public void AbrirParqueadero(int valorH)
        {
            Vehiculo veh = null;
            for (int i = 0; i < this.parque.Length; i++)
            {
                this.parque[i] = veh;
            }
            this.ValorHora = valorH;
            MessageBox.Show("El parqueadero esta abierto...");
        }

        public void IngresarVehiculo(Vehiculo vehi)
        {
            for (int i = 0; i < this.parque.Length; i++)
            {
                if (this.parque[i] == null)
                {
                    this.parque[i] = vehi;
                    MessageBox.Show("El vehiculo ha sido parqueado en la ubicación: " + i);
                    break;
                }
            }
        }
        public Vehiculo ConsultarVehiculo(string placa)
        {
            Vehiculo veh = null;
            foreach (var v in this.parque)
            {
                if (v.Placa1.Equals(placa))
                {
                    veh= v;
                    DateTime hs= DateTime.Now;
                    veh.HoraSalidad1= hs;
                    int horas = veh.HoraSalidad1.Hour - veh.HoraEntrada1.Hour;
                    int min= veh.HoraSalidad1.Minute - veh.HoraEntrada1.Minute;
                    if (min > 0)
                    {
                        horas++;
                    }
                    veh.TiempoPar = horas;
                    veh.Cobro1 = this.ValorHora * horas;
                    break;
                }
            }
            return veh;
        }
        public void RetirarVehiculo(Vehiculo vehiculo)
        {
            for (int i = 0; i < this.parque.Length; i++)
            {
                if (this.parque[i].Placa1.Equals(vehiculo.Placa1))
                {
                    this.CierreCaja += vehiculo.Cobro1;
                    this.parque[i] = null;
                    MessageBox.Show("El vehiculo ha sido retirado...");
                    MessageBox.Show("Valor en caja: " + this.CierreCaja);
                    break;
                }
            }                       
        }
    }
}
