using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Controlador del evento KeyPress para validar cada tecla que se presiona
        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }

        //Controlador del evento KeyPress para validar cada tecla que se presiona
        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir ingresar solo letras y algunos caracteres especiales
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }

        //Controlador del evento KeyPress para validar cada tecla que se presiona
        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir ingresar solo letras y algunos caracteres especiales
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Verifica si algún campo está vacío
            if (string.IsNullOrEmpty(TDni.Text) || string.IsNullOrEmpty(TNombre.Text) || string.IsNullOrEmpty(TApellido.Text))
            {
                // Muestra un MessageBox con el mensaje de error
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else 
            {
                // Muestra un MessageBox de consulta con el enfoque en "SI"
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar un nuevo Cliente?", "Confirmar Inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                // Verifica la opción seleccionada por el usuario
                if (ask == DialogResult.Yes)
                {
                    LModificar.Text = TNombre.Text + " " + TApellido.Text;

                    // Muestra un MessageBox de información con el nombre del cliente insertado
                    MessageBox.Show("El Cliente: " + LModificar.Text + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
                
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask2 = MessageBox.Show("Esta apunto de eliminar el cliente: " + TNombre.Text + " " + TApellido.Text, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (ask2 == DialogResult.Yes)
            {
                // Muestra un MessageBox de información con el nombre del cliente eliminado
                MessageBox.Show("El Cliente: " + TNombre.Text + " " + TApellido.Text + " se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TNombre.Clear();
                TApellido.Clear();
                TDni.Clear();
                LModificar.ResetText();
            }
            
        }
    }
}
