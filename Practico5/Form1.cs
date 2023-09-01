using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            // Obtener la ruta de la carpeta donde se guardarán las fotos
            string rutaCarpeta = "C:\\Users\\Agustin\\source\\repos\\Practico5\\bin\\Debug\\Fotos";

            // Verificar si la carpeta existe, de lo contrario, crearla
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen en el PictureBox
                picFotoPerfil.Image = new System.Drawing.Bitmap(openFileDialog.FileName);

                // Generar un nombre único para el archivo
                string nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(openFileDialog.FileName);

                // Construir la ruta completa del archivo
                string rutaArchivo = Path.Combine(rutaCarpeta, nombreArchivo);

                // Guardar el archivo en la carpeta especificada
                picFotoPerfil.Image.Save(rutaArchivo);

                // Mostrar la ruta en el TextBox
                txtRutaFotoPerfil.Text = rutaArchivo;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                // Convertir la primera letra a mayúscula y las siguientes a minúscula
                textBox.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox.Text.ToLower());

                // Colocar el cursor al final del texto
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void txtApellido_TextChanged_1(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                // Convertir la primera letra a mayúscula y las siguientes a minúscula
                textBox.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox.Text.ToLower());

                // Colocar el cursor al final del texto
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string fechaNacimiento = dateTimePickerFechaNacimiento.Value.ToString("dd/MM/yyyy");
            string sexo;
            if (radioButtonHombre.Checked) {
                sexo = "hombre";
            }
            else{
                sexo = "mujer";
            }
            string saldo = txtSaldo.Text;
            Image foto = picFotoPerfil.Image;//Image.FromFile(picFotoPerfil.Image);
            string ruta = txtRutaFotoPerfil.Text;

            // Agregar los datos al DataGridView
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Height = 60;//Altura de las celdas
            if (dataGridView1.Columns[1].Name == "Nombre" || dataGridView1.Columns[0].Name == "Apellido")
            {
                dataGridView1.RowsDefaultCellStyle.Font = new Font("Papyrus", 16, FontStyle.Bold); // Cambiar la fuente a Arial, tamaño 12 y negrita
            }
            dataGridView1.Rows[n].Cells[0].Value = (apellido);
            dataGridView1.Rows[n].Cells[1].Value = (nombre);
            dataGridView1.Rows[n].Cells[2].Value = (fechaNacimiento);
            dataGridView1.Rows[n].Cells[3].Value = (sexo);
            dataGridView1.Rows[n].Cells[5].Value = (saldo);
            dataGridView1.Rows[n].Cells[6].Value = (foto);
            dataGridView1.Rows[n].Cells[7].Value = (ruta);

            // Limpiar los campos del formulario
            txtNombre.Text = "";
            txtApellido.Text = "";
            dateTimePickerFechaNacimiento.Text = "";
            txtSaldo.Text = "";
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "Sin título1.png");
            picFotoPerfil.Image = Image.FromFile(imagePath);
            txtRutaFotoPerfil.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda clickeada corresponde a la columna del botón
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Nombre" || dataGridView1.Columns[e.ColumnIndex].Name == "Apellido")
            {
                e.CellStyle.Font = new Font("Arial", 12, FontStyle.Bold); // Cambiar la fuente a Arial, tamaño 12 y negrita
            }
        }

    }
}
