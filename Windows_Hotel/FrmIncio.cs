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
            DateTime fecini = Convert.ToDateTime(txtFecini.Text);
            DateTime fecfin = Convert.ToDateTime(txtFecFin.Text);
            try
            {
                if (Convert.ToInt16(txtNumero.Text) <= 3)
                {
                    if (fecfin < fecini | fecini<DateTime.Today)
                    {
                        MessageBox.Show("Debe eligir un parametro de fechas adecuado", "Error");
                    }else
                    {
                        Form1 form = new Form1();
                        form.contadorHabitaciones = Convert.ToInt16(txtNumero.Text);
                        form.fecini = fecini;
                        form.fecfin = fecfin;
                        form.documento = txtDocumento.Text;
                        form.Show();
                    }  
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
