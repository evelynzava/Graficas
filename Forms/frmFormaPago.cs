using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClasesVirtualesProgramacion.Forms
{
    public partial class frmFormaPago : Form
    {
        admGastos aConexion = new admGastos();
        public frmFormaPago()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string SQL = "select formapago, count(formapago) as Total from gastos group by formapago";
            if (aConexion.selectData(SQL, dslistadegastos.totalformapago) == true)
            {
                //limpiar el contenido del grafico antes de enlazar los nuevos datos
                oGrafico.Series.Clear();
                oGrafico.Titles.Clear();
                oGrafico.ChartAreas.Clear();
                oGrafico.Palette = ChartColorPalette.Bright;
                ChartArea areaGrafico = new ChartArea();
                areaGrafico.Area3DStyle.Enable3D = true;
                oGrafico.ChartAreas.Add(areaGrafico);
                Title tituloGrafico = new Title();
                tituloGrafico.Text = "Total de gastos por forma de pago";
                tituloGrafico.Font = new Font("Tahoma", 15, FontStyle.Bold);
                oGrafico.Titles.Add(tituloGrafico);
                Series serieDatos = new Series("formapago");
                serieDatos.ChartType = SeriesChartType.Doughnut;
                serieDatos.XValueMember = "formapago";
                serieDatos.YValueMembers = "Total";
                serieDatos.IsValueShownAsLabel = true;
                oGrafico.Series.Add(serieDatos);
                oGrafico.DataSource = dslistadegastos.totalformapago;

            }
        }

        private void oGrafico_Click(object sender, EventArgs e)
        {

        }
    }
}
