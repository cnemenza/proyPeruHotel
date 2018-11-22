using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Hotel
{
    public partial class Form1 : Form
    {
        ProxyHabitaciones.ServicioHabitacionClient objServiHabitaciones = new ProxyHabitaciones.ServicioHabitacionClient();
        ProxyRegistroReserva.ServicioRegistroReservaClient objServiRegistro = new ProxyRegistroReserva.ServicioRegistroReservaClient();
        ProxyRegistroReserva.DataRegistro objRegistro = new ProxyRegistroReserva.DataRegistro();
        public int contadorHabitaciones;
        public DateTime fecini;
        public DateTime fecfin;
        public String documento;
        public Form1()
        {
            InitializeComponent();
        }

        private void grvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contadorHabitaciones>0)
            {
                if (grvDatos.Rows[e.RowIndex].Cells[9].Selected)
                {

                    switch (contadorHabitaciones){
                        case 3:
                            lblHabi1.Text = grvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
                            lblPrecio1.Text = grvDatos.Rows[e.RowIndex].Cells[8].Value.ToString();
                            lblHabi1.Visible = true;
                            lblPrecio1.Visible = true; 
                            break;
                        case 2:
                            lblHabi2.Text = grvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
                            lblPrecio2.Text = grvDatos.Rows[e.RowIndex].Cells[8].Value.ToString();
                            lblHabi2.Visible = true;
                            lblPrecio2.Visible = true;
                            break;
                        case 1:
                            lblHabi3.Text = grvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
                            lblPrecio3.Text = grvDatos.Rows[e.RowIndex].Cells[8].Value.ToString();
                            lblHabi3.Visible = true;
                            lblPrecio3.Visible = true;
                            Single total = Convert.ToSingle(lblPrecio1.Text) + Convert.ToSingle(lblPrecio2.Text) +
                                Convert.ToSingle(lblPrecio3.Text);
                            lblTotal.Text = total.ToString();
                            lblTotal.Visible = true;
                            break;    
                    }

                    this.grvDatos.CurrentCell = null;
                    this.grvDatos.Rows[e.RowIndex].Visible = false;
                    contadorHabitaciones--;
                }
                
            }
            else
            {
                MessageBox.Show("Se alcanzo el numero solicitado de habitaciones");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                grvDatos.DataSource = objServiHabitaciones.ListarHabitacionesDisponibles(fecini, fecfin);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                objRegistro.ClieDni = documento;
                objRegistro.IdHabi1 = lblHabi1.Text;
                objRegistro.IdHabi2 = lblHabi2.Text;
                objRegistro.IdHabi3 = lblHabi3.Text;
                objRegistro.ReserFechaIngreso = fecini;
                objRegistro.ReserFechaSalida = fecfin;
                if (objServiRegistro.RegistroReserva(objRegistro))
                {
                    MessageBox.Show("Reserva Exitosa");
                }
                else
                {
                    MessageBox.Show("Error al registrar la reserva");
                }
                

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
