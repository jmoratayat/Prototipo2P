using Capa_Diseño.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Diseño.Mantenimientos;

namespace Capa_Diseño
{
    public partial class Menu : Form
    {
        private int childFormNumber = 0;

        public Menu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

     

   

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        bool ventanaProveedor = false;
        FRM_MANTENIMIENTO_EMPLEADO proveedor = new FRM_MANTENIMIENTO_EMPLEADO();
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FRM_MANTENIMIENTO_EMPLEADO);
            if (ventanaProveedor == false || frmC == null)
            {
                if (frmC == null)
                {
                    proveedor = new FRM_MANTENIMIENTO_EMPLEADO();
                }

                proveedor.MdiParent = this;
                proveedor.Show();
                Application.DoEvents();
                ventanaProveedor = true;
            }
            else
            {
                proveedor.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanaconcepto =false;
        FRM_MANTENIMIENTO_CONCEPTO concepto = new FRM_MANTENIMIENTO_CONCEPTO();

        private void CONCEPTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FRM_MANTENIMIENTO_CONCEPTO);
            if (ventanaconcepto == false || frmC == null)
            {
                if (frmC == null)
                {
                    concepto = new FRM_MANTENIMIENTO_CONCEPTO();
                }

                concepto.MdiParent = this;
                concepto.Show();
                Application.DoEvents();
                ventanaconcepto = true;
            }
            else
            {
                concepto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventananomina = false;
        FRM_NOMINA nomina = new FRM_NOMINA();

        private void nOMINAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FRM_NOMINA);
            if (ventananomina == false || frmC == null)
            {
                if (frmC == null)
                {
                    nomina = new FRM_NOMINA();
                }

                nomina.MdiParent = this;
                nomina.Show();
                Application.DoEvents();
                ventananomina = true;
            }
            else
            {
                concepto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
    }
}
