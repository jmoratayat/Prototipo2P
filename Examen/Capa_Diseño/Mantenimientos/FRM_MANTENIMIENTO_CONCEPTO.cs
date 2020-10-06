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

namespace Capa_Diseño.Mantenimientos
{
    public partial class FRM_MANTENIMIENTO_CONCEPTO : Form
    {
        Logica logi = new Logica();
        public FRM_MANTENIMIENTO_CONCEPTO()
        {
            InitializeComponent();
        
        }

        private void FRM_MANTENIMIENTO_CONCEPTO_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text }; //valores a ingresar
            if (logi.insertar_concepto(valores) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            else
            {
                MessageBox.Show("Guardado exitosamente");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
               
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
          

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text }; //valores a ingresar
            if (logi.modificar_concepto(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                MessageBox.Show("Modificacion exitosa");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
              

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text }; //valores a ingresar
            if (logi.eliminar_concepto(valores) == null)
            {
                MessageBox.Show("Error al eliminar");
            }
            else
            {
                MessageBox.Show("eliminacion exitosa");

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
               

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_CONCEPTO frpro = new FRM_CONCEPTO();
            frpro.ShowDialog();
            if (frpro.DialogResult == DialogResult.OK)
            {
                textBox1.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(); //para jalar el dato de datagridview
                textBox2.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString(); //valor 2
                textBox3.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString(); //valor 3
                textBox4.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString(); //valor 4
               
            }

        }
    }
}
