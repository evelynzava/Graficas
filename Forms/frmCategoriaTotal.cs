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
    public partial class frmCategoriaTotal : Form
    {
        admGastos aConexion = new admGastos();
        public frmCategoriaTotal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
                string SQL = "select categoria, count(categoria) as Total from gastos group by categoria";
                if (aConexion.selectData(SQL,dslistadegastos.totalcategoria) == true)
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
                    tituloGrafico.Text = "Total de Gastos por Categoria";
                    tituloGrafico.Font = new Font("Tahoma", 15, FontStyle.Bold);
                    oGrafico.Titles.Add(tituloGrafico);
                    Series serieDatos = new Series("categoria");
                    serieDatos.ChartType = SeriesChartType.Pie;
                    serieDatos.XValueMember = "categoria";
                    serieDatos.YValueMembers = "Total";
                    serieDatos.IsValueShownAsLabel = true;
                    oGrafico.Series.Add(serieDatos);
                    oGrafico.DataSource = dslistadegastos.totalcategoria;

                }
            }

        private void frmCategoriaTotal_Load(object sender, EventArgs e)
        {

        }
    }
    }

