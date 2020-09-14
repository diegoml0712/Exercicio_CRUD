using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Exercicio_CRUD
{
    public partial class cademp : Form
    {
        public cademp()
        {
            InitializeComponent();
        }
        //Conexão Banco
        SqlConnection sqlCon = null;
        private string strCon = @"Password=B30ea91d;Persist Security Info=True;User ID=sa;Initial Catalog=cademp;Data Source=DESKTOP-MQ8OTL1\SQLEXPRESS";
        private string strSql = string.Empty;

        private void btnInserir_Click(object sender, EventArgs e)
        {
            strSql = "insert into empresas (razsoc, cnpj, insest, endereco, cidade, estado, telefone) values (@razsoc, @cnpj ,@insest, @endereco, @cidade, @estado, @telefone)";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            try
            {
                sqlCon.Open();

                //Passagem de parametros
                comando.Parameters.Add("@razsoc", SqlDbType.VarChar).Value = bxRazSoc.Text;
                comando.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = bxCNPJ.Text;
                comando.Parameters.Add("@insest", SqlDbType.VarChar).Value = bxInscEst.Text;
                comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = bxEndereco.Text;
                comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = bxCidade.Text;
                comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = bxEstado.Text;
                comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = bxTelefone.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Registrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                bxRazSoc.Clear();
                bxCNPJ.Clear();
                bxInscEst.Clear();
                bxEndereco.Clear();
                bxCidade.Clear();
                bxEstado.Clear();
                bxTelefone.Clear();
                bxRazSoc.Focus();

                strSql = "Select * from empresas order by id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand Commando = new SqlCommand(strSql, sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlCon.Open();
                dgEmpresas.DataSource = dt;
                sqlCon.Close();
            }
        }

        //datagrid
        private void dgEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bxID.Text = dgEmpresas.CurrentRow.Cells[0].Value.ToString();
            bxRazSoc.Text = dgEmpresas.CurrentRow.Cells[1].Value.ToString();
            bxCNPJ.Text = dgEmpresas.CurrentRow.Cells[2].Value.ToString();
            bxInscEst.Text = dgEmpresas.CurrentRow.Cells[3].Value.ToString();
            bxEndereco.Text = dgEmpresas.CurrentRow.Cells[4].Value.ToString();
            bxCidade.Text = dgEmpresas.CurrentRow.Cells[5].Value.ToString();
            bxEstado.Text = dgEmpresas.CurrentRow.Cells[6].Value.ToString();
            bxTelefone.Text = dgEmpresas.CurrentRow.Cells[7].Value.ToString();
        }

        //pesquisar
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (boxPesquisa.Text == string.Empty)
            {
                strSql = "Select * from empresas order by id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand Comando = new SqlCommand(strSql, sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlCon.Open();
                dgEmpresas.DataSource = dt;
                sqlCon.Close();
            }
            else
            {

                strSql = "Select * from empresas where id=@id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand Comando = new SqlCommand(strSql, sqlCon);

                Comando.Parameters.Add("@id", SqlDbType.Int).Value = boxPesquisa.Text;

                try
                {

                    if (boxPesquisa.Text == String.Empty)
                    {
                        throw new Exception("Digite um ID");
                    }
                    sqlCon.Open();

                    SqlDataReader dr = Comando.ExecuteReader();

                    if (dr.HasRows == false)
                    {
                        throw new Exception("Id não existe");
                    }

                    if (dr.Read())
                    {
                        bxID.Text = Convert.ToString(dr["id"]);
                        bxRazSoc.Text = Convert.ToString(dr["razsoc"]);
                        bxCNPJ.Text = Convert.ToString(dr["cnpj"]);
                        bxInscEst.Text = Convert.ToString(dr["insest"]);
                        bxEndereco.Text = Convert.ToString(dr["endereco"]);
                        bxCidade.Text = Convert.ToString(dr["cidade"]);
                        bxEstado.Text = Convert.ToString(dr["estado"]);
                        bxTelefone.Text = Convert.ToString(dr["telefone"]);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                    bxRazSoc.Focus();

                    strSql = "Select * from empresas order by id";
                    sqlCon = new SqlConnection(strCon);
                    SqlCommand Commando = new SqlCommand(strSql, sqlCon);
                    SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    sqlCon.Open();
                    dgEmpresas.DataSource = dt;
                    sqlCon.Close();
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            strSql = "update empresas set razsoc=@razsoc, cnpj=@cnpj, insest=@insest, endereco=@endereco, cidade=@cidade, estado=@estado, telefone=@telefone where id=@id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand Comando = new SqlCommand(strSql, sqlCon);

            Comando.Parameters.Add("@id", SqlDbType.Int).Value = bxID.Text;

            Comando.Parameters.Add("@razsoc", SqlDbType.VarChar).Value = bxRazSoc.Text;
            Comando.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = bxCNPJ.Text;
            Comando.Parameters.Add("@insest", SqlDbType.VarChar).Value = bxInscEst.Text;
            Comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = bxEndereco.Text;
            Comando.Parameters.Add("@cidade", SqlDbType.VarChar).Value = bxCidade.Text;
            Comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = bxEstado.Text;
            Comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = bxTelefone.Text;

            try
            {
                sqlCon.Open();
                Comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro alterado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                bxID.Clear();
                bxRazSoc.Clear();
                bxCNPJ.Clear();
                bxInscEst.Clear();
                bxEndereco.Clear();
                bxCidade.Clear();
                bxEndereco.Clear();
                bxTelefone.Clear();
                bxRazSoc.Focus();

                strSql = "Select * from empresas order by id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand Commando = new SqlCommand(strSql, sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlCon.Open();
                dgEmpresas.DataSource = dt;
                sqlCon.Close();
            }
        }
        //excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Registro", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)

            {
                MessageBox.Show("Operação Cancelada");
            }
            else
            {
                strSql = "delete from empresas where id = @id";
                sqlCon = new SqlConnection(strCon);

                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@id", SqlDbType.Int).Value = bxID.Text;

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registro excluido com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                    bxID.Clear();
                    bxRazSoc.Clear();
                    bxCNPJ.Clear();
                    bxInscEst.Clear();
                    bxEndereco.Clear();
                    bxCidade.Clear();
                    bxEndereco.Clear();
                    bxTelefone.Clear();
                    bxRazSoc.Focus();

                    strSql = "Select * from empresas order by id";
                    sqlCon = new SqlConnection(strCon);
                    SqlCommand Commando = new SqlCommand(strSql, sqlCon);
                    SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    sqlCon.Open();
                    dgEmpresas.DataSource = dt;
                    sqlCon.Close();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            bxID.Clear();
            bxRazSoc.Clear();
            bxCNPJ.Clear();
            bxInscEst.Clear();
            bxEndereco.Clear();
            bxCidade.Clear();
            bxEndereco.Clear();
            bxTelefone.Clear();
            bxRazSoc.Focus();

            strSql = "Select * from empresas order by id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand Commando = new SqlCommand(strSql, sqlCon);
            SqlDataAdapter da = new SqlDataAdapter(strSql, sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlCon.Open();
            dgEmpresas.DataSource = dt;
            sqlCon.Close();
        }
    }
}

