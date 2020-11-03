namespace ClasesVirtualesProgramacion.Forms
{
    partial class frmCategoriaTotal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.oGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dslistadegastos = new ClasesVirtualesProgramacion.Data.dslistadegastos();
            this.totalcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.oGrafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dslistadegastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalcategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oGrafico
            // 
            chartArea2.Name = "ChartArea1";
            this.oGrafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.oGrafico.Legends.Add(legend2);
            this.oGrafico.Location = new System.Drawing.Point(12, 1);
            this.oGrafico.Name = "oGrafico";
            this.oGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.oGrafico.Series.Add(series2);
            this.oGrafico.Size = new System.Drawing.Size(613, 390);
            this.oGrafico.TabIndex = 0;
            this.oGrafico.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Productos Por Categoria";
            this.oGrafico.Titles.Add(title2);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(405, 407);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(106, 32);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(532, 407);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 32);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dslistadegastos
            // 
            this.dslistadegastos.DataSetName = "dslistadegastos";
            this.dslistadegastos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalcategoriaBindingSource
            // 
            this.totalcategoriaBindingSource.DataMember = "totalcategoria";
            this.totalcategoriaBindingSource.DataSource = this.dslistadegastos;
            // 
            // frmCategoriaTotal
            // 
            this.AcceptButton = this.btnCerrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 492);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.oGrafico);
            this.Name = "frmCategoriaTotal";
            this.Text = "frmCategoriaTotal";
            this.Load += new System.EventHandler(this.frmCategoriaTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oGrafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dslistadegastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalcategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart oGrafico;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private Data.dslistadegastos dslistadegastos;
        private System.Windows.Forms.BindingSource totalcategoriaBindingSource;
    }
}