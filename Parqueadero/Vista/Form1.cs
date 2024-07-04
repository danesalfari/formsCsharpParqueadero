using Parqueadero.Controlador;
using Parqueadero.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parqueadero
{
    public partial class Form1 : Form
    {
        Parqueaderos objPar= new Parqueaderos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxTipo.SelectedIndex= 0;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            objPar.AbrirParqueadero(int.Parse(txtValorHora.Text));
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }
        private void ingresar()
        {
            DateTime hoy= DateTime.Now;
            Vehiculo vehiculo= new Vehiculo(txtPlaca.Text,hoy,cbxTipo.Text);
            objPar.IngresarVehiculo(vehiculo);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();    
        }
        private void consultar()
        {
            Vehiculo vehiculo = objPar.ConsultarVehiculo(txtPlaca1.Text);
            if (vehiculo != null)
            { 
                txtCobro.Text= vehiculo.Cobro1.ToString();
                txtTipo.Text= vehiculo.Tipo1.ToString();
                DateTime horas = vehiculo.HoraEntrada1;
                txtHoraE.Text = horas.Hour.ToString() + ":" +horas.Minute.ToString();
                DateTime horas1 = vehiculo.HoraSalidad1;
                txtHoraS.Text= horas1.Hour.ToString() + ":" + horas1.Minute.ToString();
                txtTiempo.Text = vehiculo.TiempoPar.ToString();
                txtCobro.Text= vehiculo.Cobro1.ToString();
            }
        }

        private void btbRetirar_Click(object sender, EventArgs e)
        {
            retirar();
        }
        private void retirar()
        {
            Vehiculo vehiculo = objPar.ConsultarVehiculo(txtPlaca1.Text);
            DateTime horas= DateTime.Now;
            DateTime horas1= DateTime.Now;
            if (vehiculo != null)
            {
                txtCobro.Text = vehiculo.Cobro1.ToString();
                txtTipo.Text = vehiculo.Tipo1.ToString();
                horas = vehiculo.HoraEntrada1;                
                horas1 = vehiculo.HoraSalidad1;                
                txtTiempo.Text = vehiculo.TiempoPar.ToString();
                txtCobro.Text = vehiculo.Cobro1.ToString();
            }

            vehiculo.Placa1 = txtPlaca1.Text;
            vehiculo.HoraEntrada1 = horas;
            vehiculo.HoraSalidad1 = horas1;
            vehiculo.Tipo1= txtTipo.Text;
            vehiculo.Cobro1 = double.Parse(txtCobro.Text);
            vehiculo.TiempoPar = int.Parse(txtTiempo.Text);
            objPar.RetirarVehiculo(vehiculo);
        }
    }
}
