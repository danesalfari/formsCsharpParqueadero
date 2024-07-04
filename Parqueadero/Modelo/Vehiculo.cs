using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueadero.Modelo
{
    public class Vehiculo
    {
        //Atributos

        private string Placa;
        private DateTime HoraEntrada;
        private DateTime HoraSalidad;
        private string Tipo;        
        private int tiempoPar;
        private double Cobro;

        public Vehiculo()
        {
        }
        public Vehiculo(string placa, DateTime horaEntrada, string tipo)
        {
            this.Placa = placa;
            this.HoraEntrada = horaEntrada;            
            this.Tipo = tipo;            
        }

        public DateTime HoraSalidad1 { get => HoraSalidad; set => HoraSalidad = value; }
        public string Placa1 { get => Placa; set => Placa = value; }
        public DateTime HoraEntrada1 { get => HoraEntrada; set => HoraEntrada = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }        
        public int TiempoPar { get => tiempoPar; set => tiempoPar = value; }
        public double Cobro1 { get => Cobro; set => Cobro = value; }
    }
}
