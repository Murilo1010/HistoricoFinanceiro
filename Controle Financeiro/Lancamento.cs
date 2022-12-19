using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Controle_Financeiro
{

    public partial class Lancamento : Form
    {
        string caminho = "Data Source = LAPTOP-B5DSSADJ\\SQLEXPRESS; Initial Catalog = Saldos; Integrated Security = True";
        SqlConnection con;

        ComboBox cmb;
        System.Object[] ItemRange;
        public Lancamento()
        {
            InitializeComponent();
            con = new SqlConnection(caminho);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }



        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e, MonthCalendar monthCalendar1)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int qualtipoparcela = 0;
            try
            {

                con.Open();
                int parcela = Convert.ToInt32(combo_Parcelas.SelectedValue);
                int parcela1 = Convert.ToInt32(combo_Parcelas.SelectedItem);
                if (parcela == 1)
                {

                    string comando = "INSERT INTO Valores2 (Descricao,Valor,Parcela,DataParcela,Tipo,Pago) VALUES ('" + txtDescricao.Text + "'," + txtValorTotal.Text + ",'" + combo_Parcelas.SelectedItem + "','" + data_Parcela.Text + "','" + combo_Tipo.SelectedItem + "','" + combo_Pago.SelectedItem + "')";
                    SqlCommand cmd = new SqlCommand(comando, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados Salvos com Sucesso!");
                    txtDescricao.Text = "";
                    txtValorTotal.Text = "";
                    combo_Parcelas.Text = "";
                    combo_Pago.Text = "";
                    combo_Tipo.Text = "";
                    qualtipoparcela = 1;
                }
                else
                {

                    int parcela2 = Convert.ToInt32(combo_Parcelas.SelectedItem);
                    qualtipoparcela = 2;
                }



                if (qualtipoparcela == 2)
                {


                    decimal valor = decimal.Parse((string)txtValorTotal.Text);
                    string tipo = (string)combo_Tipo.SelectedItem;
                    decimal valorparcela = valor / parcela1;

                    string comando = "EXECUTE Procedure_AdicionaParcela "+
                                     "@QuandideParcela = "+parcela1+" "+
                                     ",@IdParametro = " + txtId.Text + "  " +
                                     ",@Descricao =  "+txtDescricao.Text+" "+
                                     ",@Valor = "+valor+" " +
                                     ",@TipoLancamento = "+ tipo + "  ";
                    SqlCommand cmd = new SqlCommand(comando, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados Salvos com Sucesso!");
                    txtDescricao.Text = "";
                    txtValorTotal.Text = "";
                    combo_Parcelas.Text = "";
                    combo_Pago.Text = "";
                    combo_Tipo.Text = "";
                    AchaID();


                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }


        }

        private void combo_Parcelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lancamento_Load(object sender, EventArgs e)
        {
            data_Parcela.Format = DateTimePickerFormat.Custom;
            data_Parcela.CustomFormat = "dd/MM/yyyy";

            AchaID();
           
        }

        private void data_Parcela_ValueChanged(object sender, EventArgs e)
        {
            //DateTime data = Convert.ToDateTime(data_Parcela.Text);

            //int i = 1;
            //data = data.AddMonths(i);
            //string data1 = data.ToString("dd/MM/yyyy");
            //MessageBox.Show("Teste" + data1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorTotal_Click(object sender, EventArgs e)
        {


        }

        private void mskValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public  void AchaID()
        {
            

            //instância da conexão 

            //string com o comando a ser executado 
            string sql = "SELECT ISNULL(MAX(Id_parcela),1) AS ID FROM Valores";

            //instância do comando recebendo como parâmetro 
            //a string com o comando e a conexão 
            SqlCommand cmd = new SqlCommand(sql, con);

            //abro conexão 
            con.Open();

            //instância do leitor 
            SqlDataReader leitor = cmd.ExecuteReader();

            //enquanto leitor lê 
            while (leitor.Read())
            {
                //para cada iteração adiciono o nome 
                //ao listbox 
                txtId.Text = leitor["ID"].ToString();
            }

            //fecha conexão 
            con.Close();
        }

        }
    }


