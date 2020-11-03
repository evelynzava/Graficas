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
    public partial class frmSubCategoria : Form
    {
        admGastos oConexion = new admGastos();
        public frmSubCategoria()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            {
                string SQL = "select subcategoria, count(subcategoria) as Total from gastos group by subcategoria";
                if (oConexion.selectData(SQL, dslistadegastos.totalsubcategoria) == true)
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
                    tituloGrafico.Text = "Total de gastos por subcategoria";
                    tituloGrafico.Font = new Font("Tahoma", 15, FontStyle.Bold);
                    oGrafico.Titles.Add(tituloGrafico);
                    Series serieDatos = new Series("subcategoria");
                    oGrafico.Palette = ChartColorPalette.EarthTones;
                    serieDatos.XValueMember = "subcategoria";
                    serieDatos.YValueMembers = "Total";
                    serieDatos.IsValueShownAsLabel = true;
                    oGrafico.Series.Add(serieDatos);
                    oGrafico.DataSource = dslistadegastos.totalsubcategoria;

                }
            }
        }

        private void frmSubCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
