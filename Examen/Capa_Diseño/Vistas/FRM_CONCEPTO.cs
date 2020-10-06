using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica; //capa logia 
using System.Data.Odbc;

namespace Capa_Diseño.Vistas
{
    public partial class FRM_CONCEPTO : Form
    {
        Logica logi = new Logica(); //se crea el objeto logica en global
        public FRM_CONCEPTO()
        {
            InitializeComponent();
        }
        public void mostrar_consulta()
        {
            OdbcDataReader mostrar = logi.consultar("concepto"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void ACTUALIZAR_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            mostrar_consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            else
            {
                DialogResult = DialogResult.OK; //para seleccionar registro
                Close();
            }
        }
    }
}
