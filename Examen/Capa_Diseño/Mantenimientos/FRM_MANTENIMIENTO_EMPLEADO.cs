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
    public partial class FRM_MANTENIMIENTO_EMPLEADO : Form
    {
        Logica logi = new Logica();
        public FRM_MANTENIMIENTO_EMPLEADO()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_EMPLEADO frpro = new FRM_EMPLEADO();
            frpro.ShowDialog();
            if (frpro.DialogResult == DialogResult.OK)
            {
                textBox1.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString(); //para jalar el dato de datagridview
                textBox2.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString(); //valor 2
                textBox3.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString(); //valor 3
                textBox4.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString(); //valor 4
                textBox5.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString(); //valor 5
                textBox6.Text = frpro.dataGridView1.Rows[frpro.dataGridView1.CurrentRow.Index].Cells[5].Value.ToString(); //valor 6
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_MANTENIMIENTO_PROVEEDOR_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text}; //valores a ingresar
            if (logi.insertar_empleado(valores) == null)
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
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text }; //valores a ingresar
            if (logi.modificar_empleado(valores) == null)
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
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text}; //valores a ingresar
            if (logi.eliminar_empleado(valores) == null)
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
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

            }

        }
    }
}
