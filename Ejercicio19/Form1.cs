using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnVerdeFormulario_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnAzulFormulario_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnRojoFormulario_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float tamaño = float.Parse(comboBox1.SelectedItem.ToString());

            textBoxTexto.Font = new Font(textBoxTexto.Font, Font.Size=tamaño);
        }
        private void btnVerdeTexto_Click(object sender, EventArgs e)
        {
            textBoxTexto.ForeColor = Color.Green;
        }
        private void btnAzulTexto_Click(object sender, EventArgs e)
        {
            textBoxTexto.ForeColor = Color.Blue;

        }

        private void btnRojoTexto_Click(object sender, EventArgs e)
        {
            textBoxTexto.ForeColor = Color.Red;

        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            textBoxTexto.Visible = false;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            textBoxTexto.Visible = true;
        }
        private void checkBoxNegrita_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNegrita.Checked)
            {
                textBoxTexto.Font = new Font(textBoxTexto.Font, textBoxTexto.Font.Style | FontStyle.Bold);
            }
            else
            {
                textBoxTexto.Font = new Font(textBoxTexto.Font, textBoxTexto.Font.Style ^ FontStyle.Bold);
            }
        }

        private void checkBoxCursiva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNegrita.Checked)
            {
                textBoxTexto.Font = new Font(textBoxTexto.Font, textBoxTexto.Font.Style | FontStyle.Italic);
            }
            else
            {
                textBoxTexto.Font = new Font(textBoxTexto.Font, textBoxTexto.Font.Style ^ FontStyle.Italic);
            }
        }

        private void checkBoxSubrayado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNegrita.Checked)
            {
                textBoxTexto.Font = new Font(textBoxTexto.Font, textBoxTexto.Font.Style | FontStyle.Underline);
            }
            else
            {
                textBoxTexto.Font = new Font(textBoxTexto.Font, textBoxTexto.Font.Style ^ FontStyle.Underline);
            }
        }

        private void Fuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTexto.Font = new Font(Fuentes[Fuentes.SelectedIndex].Name, textBoxTexto.Font.Size);
        }
    }
}
