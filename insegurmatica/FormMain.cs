using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insegurmatica
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        // oculta el formulario no más cargue
        private void FormMain_Load(object sender, EventArgs e)
        {
            var form = (Form)sender;
            form.ShowInTaskbar = false;
            form.Location = new Point(-10000, -10000);
            Hide();

            // carga la configuración de la protección permanente
            if(Settings.Default.Protection)
            {
                toggleProtection.Text = "Deshabilitar protección permantente.";
                bandeja.Icon = Resources.SegavRed;
            }
            else
            {
                toggleProtection.Text = "Habilitar protección permanente.";
                bandeja.Icon = Resources.SegavGray;
            }

        } // _Load



        /// <summary>
        /// Muestra un carel diciendo que la acción requiere permisos adminitrativos.
        /// </summary>
        private void actionDisabled_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "La acción ha sido deshabilitada por el administrador.",
                "Permiso denegado!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }



        // alterna el supuesto estado de la protección
        private void toggleProtection_Click(object sender, EventArgs e)
        {
            if(toggleProtection.Text.Contains("Habil"))
            {
                toggleProtection.Text = "Deshabilitar protección permanente.";
                bandeja.Icon = Resources.SegavRed;
                Settings.Default.Protection = true;
            }
            else
            {
                toggleProtection.Text = "Habilitar protección permanente.";
                bandeja.Icon = Resources.SegavGray;
                Settings.Default.Protection = false;
            }

            Settings.Default.Save();

        } // toggleProtection_Click



        // muestra el formulario del dashboard de segav
        private void segav_Click(object sender, EventArgs e)
        {
            // TODO
            // un formulario para mostrar el panel principal de segurmática

            actionDisabled_Click(sender, e);
        }

    } // class
}
