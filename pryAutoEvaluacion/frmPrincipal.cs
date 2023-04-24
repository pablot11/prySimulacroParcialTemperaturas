using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAutoEvaluacion
{
    public partial class frmPrincipal : Form
    {
        clsLocalidad objLocalidad;
        clsTemperaturas objTemperaturas;
        DataTable tabla;
        DataTable tabla2;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                objLocalidad = new clsLocalidad();
                lstLocalidad.DisplayMember = "nombre";
                lstLocalidad.ValueMember = "localidad";
                lstLocalidad.DataSource = objLocalidad.getAll();
                lstLocalidad.SelectedIndex = -1;
                objTemperaturas = new clsTemperaturas();
                tabla = objLocalidad.getAll();
                tabla2 = objTemperaturas.getAll();

            }
            catch
            {
                MessageBox.Show("Error en la base de datos");
                
            }








        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int varLocalidad = Convert.ToInt32(lstLocalidad.SelectedValue);
            string varFecha = dtpFecha.Text;
            foreach (DataRow fila in tabla2.Rows)
            {
                if (varLocalidad == Convert.ToInt32(fila[0]))
                {
                    DateTime fechahora = Convert.ToDateTime(fila["fecha"]);
                    string fecha = fechahora.ToString("dd/MM/yyyy");


                     if (varFecha == fecha)
                     {
                    
                            txtMinima.Text = fila[2].ToString();
                            txtMaxima.Text = fila[3].ToString();


                     }
                    else
                    {
                        MessageBox.Show("No hay pai");
                    }

                }

            }

   







        }
    }
}
