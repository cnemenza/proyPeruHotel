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
    public partial class FrmIncio : Form
    {
        public FrmIncio()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtNumero.Text) <= 3)
                {
                    Form1 form = new Form1();
                    form.contadorHabitaciones = Convert.ToInt16(txtNumero.Text);
                    form.fecini = Convert.ToDateTime(txtFecini.Text);
                    form.fecfin = Convert.ToDateTime(txtFecFin.Text);
                    form.documento = txtDocumento.Text;
                    form.Show();
                }
                else
                {
                    MessageBox.Show("El numero maximo de habitaciones es 3");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
