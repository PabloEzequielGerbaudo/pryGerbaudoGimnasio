using System.Globalization;

namespace pryLantieriSP4
{
    public partial class frmMilanga : Form
    {
        private const int CantMozos = 5;
        private const int CantCategorias = 4;

        private readonly string[] mozos = { "Julio", "Esteban", "Javier", "Gonzalo", "Alberto" };
        private readonly string[] categorias = { "Comidas", "Bebidas sin alcohol", "Bebidas con alcohol", "Postres" };

        // Importes validados: filas = mozos, columnas = categorías
        private float[,] ventas = new float[CantMozos, CantCategorias];

        public frmMilanga()
        {
            InitializeComponent();
            ConfigurarGrilla();
            HabilitarConsultas(false);
        }

        private void ConfigurarGrilla()
        {
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.AllowUserToResizeColumns = false;
            dgvVentas.RowTemplate.Height = 28;
            dgvVentas.ColumnHeadersHeight = 35;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentas.RowHeadersWidth = 90;
            dgvVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            for (int c = 0; c < CantCategorias; c++)
            {
                int indice = dgvVentas.Columns.Add("col" + c, categorias[c]);
                DataGridViewColumn col = dgvVentas.Columns[indice];
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            dgvVentas.Rows.Add(CantMozos);
            for (int f = 0; f < CantMozos; f++)
            {
                dgvVentas.Rows[f].HeaderCell.Value = mozos[f];
            }

            // Si el usuario modifica una celda, los datos ya validados dejan de ser confiables
            dgvVentas.CellValueChanged += dgvVentas_CellValueChanged;
        }

        private void dgvVentas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (btnMozoDia.Enabled || btnTotales.Enabled)
            {
                HabilitarConsultas(false);
                LimpiarResultados();
            }
        }

        private void HabilitarConsultas(bool habilitar)
        {
            btnMozoDia.Enabled = habilitar;
            btnTotales.Enabled = habilitar;
        }

        private void LimpiarResultados()
        {
            txtMozo.Clear();
            txtImporteMozo.Clear();
            txtTotalGeneral.Clear();
            txtComidas.Clear();
            txtSinAlcohol.Clear();
            txtConAlcohol.Clear();
            txtPostres.Clear();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            dgvVentas.EndEdit();

            float[,] temporal = new float[CantMozos, CantCategorias];
            bool hayError = false;
            DataGridViewCell primerError = null;

            for (int f = 0; f < CantMozos; f++)
            {
                for (int c = 0; c < CantCategorias; c++)
                {
                    DataGridViewCell celda = dgvVentas[c, f];
                    celda.Style.BackColor = Color.Empty;

                    string texto = Convert.ToString(celda.Value)?.Trim();

                    if (string.IsNullOrEmpty(texto)
                        || !float.TryParse(texto, NumberStyles.Number, CultureInfo.CurrentCulture, out float valor)
                        || !float.IsFinite(valor)
                        || valor < 0)
                    {
                        celda.Style.BackColor = Color.LightCoral;
                        hayError = true;
                        primerError ??= celda;
                    }
                    else
                    {
                        temporal[f, c] = valor;
                    }
                }
            }

            if (hayError)
            {
                HabilitarConsultas(false);
                LimpiarResultados();
                MessageBox.Show(
                    "Hay celdas vacías o con valores no numéricos (los importes no pueden ser negativos).\n" +
                    "Revise las celdas marcadas en rojo.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dgvVentas.CurrentCell = primerError;
                return;
            }

            ventas = temporal;
            HabilitarConsultas(true);
            MessageBox.Show("Los datos son válidos. Ya puede realizar las consultas.",
                "Validación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMozoDia_Click(object sender, EventArgs e)
        {
            float mayorTotal = -1;
            List<string> ganadores = new List<string>();

            for (int f = 0; f < CantMozos; f++)
            {
                float totalMozo = 0;
                for (int c = 0; c < CantCategorias; c++)
                {
                    totalMozo += ventas[f, c];
                }

                if (totalMozo > mayorTotal)
                {
                    mayorTotal = totalMozo;
                    ganadores.Clear();
                    ganadores.Add(mozos[f]);
                }
                else if (totalMozo == mayorTotal)
                {
                    ganadores.Add(mozos[f]); // empate
                }
            }

            txtMozo.Text = string.Join(", ", ganadores);
            txtImporteMozo.Text = mayorTotal.ToString("C2");
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            float[] totalCategoria = new float[CantCategorias];
            float totalGeneral = 0;

            for (int f = 0; f < CantMozos; f++)
            {
                for (int c = 0; c < CantCategorias; c++)
                {
                    totalCategoria[c] += ventas[f, c];
                    totalGeneral += ventas[f, c];
                }
            }

            txtTotalGeneral.Text = totalGeneral.ToString("C2");
            txtComidas.Text = totalCategoria[0].ToString("C2");
            txtSinAlcohol.Text = totalCategoria[1].ToString("C2");
            txtConAlcohol.Text = totalCategoria[2].ToString("C2");
            txtPostres.Text = totalCategoria[3].ToString("C2");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
