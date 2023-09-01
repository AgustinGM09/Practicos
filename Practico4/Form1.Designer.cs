namespace Practico4
{
    partial class FormListaDeNumeros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelDesde = new System.Windows.Forms.Label();
            this.labelHasta = new System.Windows.Forms.Label();
            this.textBoxDesde = new System.Windows.Forms.TextBox();
            this.textBoxHasta = new System.Windows.Forms.TextBox();
            this.buttonGenerarFuncion = new System.Windows.Forms.Button();
            this.labelListaDeNumeros = new System.Windows.Forms.Label();
            this.listBoxListaDeNumeros = new System.Windows.Forms.ListBox();
            this.buttonNumerosPares = new System.Windows.Forms.Button();
            this.buttonNumerosImpares = new System.Windows.Forms.Button();
            this.buttonNumerosPrimos = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGrafico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Location = new System.Drawing.Point(56, 99);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(48, 16);
            this.labelDesde.TabIndex = 0;
            this.labelDesde.Text = "Desde";
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Location = new System.Drawing.Point(56, 141);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(43, 16);
            this.labelHasta.TabIndex = 1;
            this.labelHasta.Text = "Hasta";
            // 
            // textBoxDesde
            // 
            this.textBoxDesde.Location = new System.Drawing.Point(125, 99);
            this.textBoxDesde.Name = "textBoxDesde";
            this.textBoxDesde.ShortcutsEnabled = false;
            this.textBoxDesde.Size = new System.Drawing.Size(100, 22);
            this.textBoxDesde.TabIndex = 2;
            this.textBoxDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDesde_KeyPress);
            // 
            // textBoxHasta
            // 
            this.textBoxHasta.Location = new System.Drawing.Point(124, 141);
            this.textBoxHasta.Name = "textBoxHasta";
            this.textBoxHasta.ShortcutsEnabled = false;
            this.textBoxHasta.Size = new System.Drawing.Size(100, 22);
            this.textBoxHasta.TabIndex = 3;
            this.textBoxHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHasta_KeyPress);
            // 
            // buttonGenerarFuncion
            // 
            this.buttonGenerarFuncion.Location = new System.Drawing.Point(268, 98);
            this.buttonGenerarFuncion.Name = "buttonGenerarFuncion";
            this.buttonGenerarFuncion.Size = new System.Drawing.Size(129, 23);
            this.buttonGenerarFuncion.TabIndex = 5;
            this.buttonGenerarFuncion.Text = "Generar Función";
            this.buttonGenerarFuncion.UseVisualStyleBackColor = true;
            this.buttonGenerarFuncion.Click += new System.EventHandler(this.buttonGenerarFuncion_Click);
            // 
            // labelListaDeNumeros
            // 
            this.labelListaDeNumeros.AutoSize = true;
            this.labelListaDeNumeros.Location = new System.Drawing.Point(529, 60);
            this.labelListaDeNumeros.Name = "labelListaDeNumeros";
            this.labelListaDeNumeros.Size = new System.Drawing.Size(112, 16);
            this.labelListaDeNumeros.TabIndex = 6;
            this.labelListaDeNumeros.Text = "Lista de Números";
            // 
            // listBoxListaDeNumeros
            // 
            this.listBoxListaDeNumeros.FormattingEnabled = true;
            this.listBoxListaDeNumeros.ItemHeight = 16;
            this.listBoxListaDeNumeros.Location = new System.Drawing.Point(482, 98);
            this.listBoxListaDeNumeros.Name = "listBoxListaDeNumeros";
            this.listBoxListaDeNumeros.Size = new System.Drawing.Size(282, 324);
            this.listBoxListaDeNumeros.TabIndex = 7;
            // 
            // buttonNumerosPares
            // 
            this.buttonNumerosPares.Location = new System.Drawing.Point(268, 141);
            this.buttonNumerosPares.Name = "buttonNumerosPares";
            this.buttonNumerosPares.Size = new System.Drawing.Size(129, 23);
            this.buttonNumerosPares.TabIndex = 8;
            this.buttonNumerosPares.Text = "Números Pares";
            this.buttonNumerosPares.UseVisualStyleBackColor = true;
            this.buttonNumerosPares.Click += new System.EventHandler(this.buttonNumerosPares_Click);
            // 
            // buttonNumerosImpares
            // 
            this.buttonNumerosImpares.Location = new System.Drawing.Point(268, 187);
            this.buttonNumerosImpares.Name = "buttonNumerosImpares";
            this.buttonNumerosImpares.Size = new System.Drawing.Size(129, 31);
            this.buttonNumerosImpares.TabIndex = 9;
            this.buttonNumerosImpares.Text = "Números Impares";
            this.buttonNumerosImpares.UseVisualStyleBackColor = true;
            this.buttonNumerosImpares.Click += new System.EventHandler(this.buttonNumerosImpares_Click);
            // 
            // buttonNumerosPrimos
            // 
            this.buttonNumerosPrimos.Location = new System.Drawing.Point(268, 240);
            this.buttonNumerosPrimos.Name = "buttonNumerosPrimos";
            this.buttonNumerosPrimos.Size = new System.Drawing.Size(129, 23);
            this.buttonNumerosPrimos.TabIndex = 10;
            this.buttonNumerosPrimos.Text = "Números Primos";
            this.buttonNumerosPrimos.UseVisualStyleBackColor = true;
            this.buttonNumerosPrimos.Click += new System.EventHandler(this.buttonNumerosPrimos_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(482, 456);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(282, 221);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // buttonGrafico
            // 
            this.buttonGrafico.Location = new System.Drawing.Point(268, 286);
            this.buttonGrafico.Name = "buttonGrafico";
            this.buttonGrafico.Size = new System.Drawing.Size(129, 23);
            this.buttonGrafico.TabIndex = 12;
            this.buttonGrafico.Text = "Generar Gráfico";
            this.buttonGrafico.UseVisualStyleBackColor = true;
            this.buttonGrafico.Click += new System.EventHandler(this.buttonGrafico_Click);
            // 
            // FormListaDeNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 767);
            this.Controls.Add(this.buttonGrafico);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonNumerosPrimos);
            this.Controls.Add(this.buttonNumerosImpares);
            this.Controls.Add(this.buttonNumerosPares);
            this.Controls.Add(this.listBoxListaDeNumeros);
            this.Controls.Add(this.labelListaDeNumeros);
            this.Controls.Add(this.buttonGenerarFuncion);
            this.Controls.Add(this.textBoxHasta);
            this.Controls.Add(this.textBoxDesde);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.labelDesde);
            this.Name = "FormListaDeNumeros";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.TextBox textBoxDesde;
        private System.Windows.Forms.TextBox textBoxHasta;
        private System.Windows.Forms.Button buttonGenerarFuncion;
        private System.Windows.Forms.Label labelListaDeNumeros;
        private System.Windows.Forms.ListBox listBoxListaDeNumeros;
        private System.Windows.Forms.Button buttonNumerosPares;
        private System.Windows.Forms.Button buttonNumerosImpares;
        private System.Windows.Forms.Button buttonNumerosPrimos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonGrafico;
    }
}

