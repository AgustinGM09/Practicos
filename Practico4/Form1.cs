using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practico4
{
    public partial class FormListaDeNumeros : Form
    {
        public FormListaDeNumeros()
        {
            InitializeComponent();
        }

        /*private void buttonGenerarFuncion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDesde.Text) && !string.IsNullOrEmpty(textBoxHasta.Text))//Evalua si los campos no están vacios
            {
                if (int.TryParse(textBoxDesde.Text, out int desde) && int.TryParse(textBoxHasta.Text, out int hasta))//Convierte los string ingresados a nùmeros
                {
                    if (desde < hasta)
                    {
                        listBoxListaDeNumeros.Items.Clear();
                        for (int i = desde; i <= hasta; i++)
                        {
                            listBoxListaDeNumeros.Items.Add(i);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingresa valores numéricos en el campo 'desde' menores que en el campo 'hasta'.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa valores numéricos válidos en ambos campos.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa valores en ambos campos.");
            }
        }*/

        private bool ValidarCampos()
        {
            if (!string.IsNullOrEmpty(textBoxDesde.Text) && !string.IsNullOrEmpty(textBoxHasta.Text))
            {
                if (int.TryParse(textBoxDesde.Text, out int desde) && int.TryParse(textBoxHasta.Text, out int hasta))
                {
                    if (desde < hasta)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Ingresa valores numéricos en el campo 'desde' menores que en el campo 'hasta'.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa valores numéricos válidos en ambos campos.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa valores en ambos campos.");
            }

            return false;
        }


        private void textBoxDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*private void buttonNumerosPares_Click(object sender, EventArgs e)
        {
            List<object> listaNumerosPares = new List<object>();
            buttonGenerarFuncion_Click(sender,e);
            foreach (object item in listBoxListaDeNumeros.Items)
            {
                if((int)item % 2 == 0)
                {
                    listaNumerosPares.Add(item);
                }
            }
            listBoxListaDeNumeros.Items.Clear();
            foreach (var item in listaNumerosPares)
            {
                listBoxListaDeNumeros.Items.Add(item); ;
            }
        }*/

        private void buttonGenerarFuncion_Click(object sender, EventArgs e)
        {
            listBoxListaDeNumeros.Items.Clear();
            if (ValidarCampos())
            {
                int desde = int.Parse(textBoxDesde.Text);
                int hasta = int.Parse(textBoxHasta.Text);
                for (int i = desde; i <= hasta; i++)
                {
                    listBoxListaDeNumeros.Items.Add(i);
                }
            }
        }

        private void buttonNumerosPares_Click(object sender, EventArgs e)
        {
            listBoxListaDeNumeros.Items.Clear();
            if (ValidarCampos())
            {
                int desde = int.Parse(textBoxDesde.Text);
                int hasta = int.Parse(textBoxHasta.Text);
                for (int i = desde; i <= hasta; i++)
                {
                    if (i % 2 == 0)
                    {
                        listBoxListaDeNumeros.Items.Add(i);
                    }
                }
            }
        }

        /*private void buttonNumerosImpares_Click(object sender, EventArgs e)
        {
            List<object> listaNumerosImpares = new List<object>();
            buttonGenerarFuncion_Click(sender, e);
            foreach (object item in listBoxListaDeNumeros.Items)
            {
                if (!((int)item % 2 == 0))
                {
                    listaNumerosImpares.Add(item);
                }
            }
            listBoxListaDeNumeros.Items.Clear();
            foreach (var item in listaNumerosImpares)
            {
                listBoxListaDeNumeros.Items.Add(item); ;
            }
        }*/

        private void buttonNumerosImpares_Click(object sender, EventArgs e)
        {
            listBoxListaDeNumeros.Items.Clear();
            if (ValidarCampos())
            {
                int desde = int.Parse(textBoxDesde.Text);
                int hasta = int.Parse(textBoxHasta.Text);
                for (int i = desde; i <= hasta; i++)
                {
                    if (!(i % 2 == 0))
                    {
                        listBoxListaDeNumeros.Items.Add(i);
                    }
                }
            }
        }

        /*private void buttonNumerosPrimos_Click(object sender, EventArgs e)
        {
            buttonGenerarFuncion_Click(sender, e);
            List<object> listaNumerosPrimos = new List<object>();
            foreach (object item in listBoxListaDeNumeros.Items)
            {
               if (esPrimo((int)item))
                {
                    listaNumerosPrimos.Add(item);
                }
            }

            listBoxListaDeNumeros.Items.Clear();
            foreach (var item in listaNumerosPrimos)
            {
                listBoxListaDeNumeros.Items.Add(item); ;
            }
        }*/

        private void buttonNumerosPrimos_Click(object sender, EventArgs e)
        {
            listBoxListaDeNumeros.Items.Clear();
            if (ValidarCampos())
            {
                int desde = int.Parse(textBoxDesde.Text);
                int hasta = int.Parse(textBoxHasta.Text);
                for (int i = desde; i <= hasta; i++)
                {
                    if (esPrimo(i))
                    {
                        listBoxListaDeNumeros.Items.Add(i);
                    }
                }
            }
        }

        public bool esPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }

        private void buttonGrafico_Click(object sender, EventArgs e)
        {
            // Crear el gráfico de pastel
            chart1.Series.Clear();
            Series series = chart1.Series.Add("Numeros");
            series.ChartType = SeriesChartType.Pie;

            foreach (var item in listBoxListaDeNumeros.Items)
            {
                series.Points.AddXY(item.ToString(), (int)item);
            }
        }
    }
}
