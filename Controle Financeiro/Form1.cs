using System.Data;
using System.Data.SqlClient;

namespace Controle_Financeiro
{
    public partial class Form1 : Form
    {
        string caminho = "Data Source = LAPTOP-B5DSSADJ\\SQLEXPRESS; Initial Catalog = Saldos; Integrated Security = True";
        SqlConnection con;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(caminho);
            listagrid();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataIncio.Format = DateTimePickerFormat.Custom;
            dataIncio.CustomFormat = "dd/MM/yyyy";

            dataFinal.Format = DateTimePickerFormat.Custom;
            dataFinal.CustomFormat = "dd/MM/yyyy";

            ConfiguraGrid();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
           con.Open();
            string sql = "SELECT  Id_parcela AS ID , Sequencia_Parcela AS Seq , Descricao as Descrição , Valor as Valor , DataParcela as [Data da Parcela] , Tipo as [Tipo de Lançamento] , Pago AS [Pago?] FROM Valores where DataParcela between '" + dataIncio.Text + "' and '" + dataFinal.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            datagridDados.DataSource = ds.Tables[0];
            con.Close();


        }

        public void ConfiguraGrid()
        {
            datagridDados.Columns["Pago?"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void listagrid()
        {
            string sql = "SELECT  Id_parcela AS ID , Sequencia_Parcela AS Seq , Descricao as Descrição , Valor as Valor , DataParcela as [Data da Parcela] , Tipo as [Tipo de Lançamento] , Pago AS [Pago?] FROM Valores where DataParcela between '"+dataIncio.Text+ "' and '" +dataFinal.Text+ "'";


            SqlCommand objCommand = new SqlCommand(sql, con);

            try
            {
                datagridDados.DataSource = "";
                SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
                

                DataTable dtLista = new DataTable();

                objAdp.Fill(dtLista);

                datagridDados.DataSource = dtLista;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Lancamento lanc = new Lancamento();
            lanc.Show();
        }

        private void dataIncio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datagridDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (datagridDados.Columns[e.ColumnIndex].Name == "Pago?" && e.Value != null)
            {
                if (e.Value.ToString() == "X") // Campara valores.
                {
                    datagridDados.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}