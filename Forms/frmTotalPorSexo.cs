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
    public partial class frmTotalPorSexo : Form
    {
        admConexion oConexion = new admConexion();
        public frmTotalPorSexo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SQL = "select sexo, count(sexo) as Total from estudiantes group by sexo";
            if (oConexion.selectData(SQL, dsClasesVirtuales.totalporsexo) == true)
            {
                //limpiar el contenido del grafico antes de enlazar los nuevos datos
                oGrafico.Series.Clear();
                oGrafico.Titles.Clear();
                oGrafico.ChartAreas.Clear();
                oGrafico.Palette = ChartColorPalette.Excel;
                ChartArea areaGrafico = new ChartArea();
                areaGrafico.Area3DStyle.Enable3D = true;
                oGrafico.ChartAreas.Add(areaGrafico);
                Title tituloGrafico = new Title();
                tituloGrafico.Text = "Total de Estudiantes por sexo";
                tituloGrafico.Font = new Font("Tahoma", 15, FontStyle.Bold);
                oGrafico.Titles.Add(tituloGrafico);
                Series serieDatos = new Series("sexo");
                serieDatos.ChartType = SeriesChartType.Column;
                serieDatos.XValueMember = "sexo";
                serieDatos.YValueMembers = "Total";
                serieDatos.IsValueShownAsLabel = true;
                oGrafico.Series.Add(serieDatos);
                oGrafico.DataSource = dsClasesVirtuales.totalporsexo;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
