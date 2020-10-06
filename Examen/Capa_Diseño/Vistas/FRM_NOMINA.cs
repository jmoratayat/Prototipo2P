using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
using Capa_Diseño.Vistas;

namespace Capa_Diseño.Vistas
{
    public partial class FRM_NOMINA : Form
    {
        Logica logi = new Logica();
        public FRM_NOMINA()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_EMPLEADO frpro = new FRM_EMPLEADO();
            frpro.ShowDialog();
            if (frpro.DialogResult == DialogResult.OK)
            {
                textBox2.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(); //para jalar el dato de datagridview
                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_CONCEPTO frpro = new FRM_CONCEPTO();
            frpro.ShowDialog();
            if (frpro.DialogResult == DialogResult.OK)
            {
                textBox3.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(); //para jalar el dato de datagridview
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox2.Text, textBox3.Text,textBox4.Text);
           
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox1.Text, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString() };
           
            if (logi.insertar_encabezado(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                string[] valores = { textBox1.Text, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString() };

                if (logi.insertar_detalle(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            } 

        }
    }
}
