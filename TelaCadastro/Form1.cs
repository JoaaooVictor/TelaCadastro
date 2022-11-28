using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Digests.SkeinEngine;
using static System.Net.Mime.MediaTypeNames;

namespace TelaCadastro
{
    public partial class Cadastro : Form 
    {
        #region Inicialização
        public Cadastro()
        {
            InitializeComponent();
            pnlAlimenticio.Visible = false;
            pnlFornecedor.Visible = false;
            pnlProduto.Visible = false;
            btnAtualizar.Enabled = false;
            
        }
        #endregion

        #region CheckBox
        private void cbxFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFornecedor.Checked)
            {
                pnlProduto.Visible = false;
                pnlFornecedor.Visible = true;
                cbxProduto.Checked = false;
            }
        }

        private void cbxProduto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxProduto.Checked)
            {
                pnlProduto.Visible = true;
                pnlFornecedor.Visible = false;
                cbxFornecedor.Checked = false;
                
            }
        }

        private void cbxAlimenticio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAlimenticio.Checked)
            {
                pnlAlimenticio.Visible = true;
            }
            else
            {
                pnlAlimenticio.Visible = false;
            }
        }
        #endregion

        #region Botões

        Conexao conectar = new Conexao();

        #region Botão Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            btnAtualizar.Enabled = true;
            MySqlConnection conectar = new MySqlConnection("server=localhost;User Id=root;database=cadastro; password=Joaozinho21*");
            try
            {
                conectar.Open();
                if (cbxFornecedor.Checked == true)
                {
                    string parametro = $"select * from tb_fornecedores where IdFornecedor = '{txtId.Text}'";

                    MySqlCommand comando = new MySqlCommand(parametro, conectar);
                    MySqlDataReader read;
                    read = comando.ExecuteReader();
                    

                    while (read.Read())
                    {
                        txtCnpj.Text = Convert.ToString(read["Cnpj"]);
                        txtRazaoSocial.Text = Convert.ToString(read["RazaoSocial"]);
                        txtEndereco.Text = Convert.ToString(read["Endereco"]);
                        txtNomeFantasia.Text = Convert.ToString(read["NomeFantasia"]);
                        txtInscricaoEstadual.Text = Convert.ToString(read["InscricaoEstadual"]);
                        txtEmail.Text = Convert.ToString(read["Email"]);
                        txtTelefone.Text = Convert.ToString(read["Telefone"]);
                    }
                }
                else if (cbxProduto.Checked == true)
                {
                    string parametro = $"select * from tb_produtos where IdFornecedor = '{txtIdFornecedorXProduto.Text}'";

                    MySqlCommand comando = new MySqlCommand(parametro, conectar);
                    MySqlDataReader read;
                    read = comando.ExecuteReader();

                    while (read.Read())
                    {
                        txtCodigo.Text = Convert.ToString(read["Codigo"]);
                        txtDescricao.Text = Convert.ToString(read["Descricao"]);
                        txtDataValidade.Text = Convert.ToString(read["DataValidade"]);
                        txtPreco.Text = Convert.ToString(read["Preco"]);
                        txtQuantidade.Text = Convert.ToString(read["Quantidade"]);
                        txtMedida.Text = Convert.ToString(read["Medida"]);
                        txtTipo.Text = Convert.ToString(read["Tipo"]);
                    }
                }

            }
            catch(Exception erro)
            {
                MessageBox.Show($"Erro:{erro.Message}");
                conectar.Close();
            }
            finally
            {
                conectar.Close();
                MessageBox.Show("Pesquisa efetuada com Sucesso!");
            }
        }
        #endregion

        #region Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            if (cbxFornecedor.Checked == true)
            {
                conectar.BancoDados($"delete from tb_fornecedores where IdFornecedor = {txtId.Text}");
                MessageBox.Show("Fornecedor deletado com Sucesso!");
                Limpar();
            }
            else if (cbxProduto.Checked == true)
            {
                conectar.BancoDados($"delete from tb_produtos where IdFornecedor = {txtIdFornecedorXProduto.Text}");
                MessageBox.Show("Produto deletado com Sucesso!");
                Limpar();
            }

        }
        #endregion

        #region Botão Atualizar
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (cbxFornecedor.Checked == true)
            {
                conectar.BancoDados($"update tb_fornecedores set Cnpj = '{txtCnpj.Text}' , RazaoSocial = '{txtRazaoSocial.Text}' , NomeFantasia = '{txtNomeFantasia.Text}' , InscricaoEstadual = '{txtInscricaoEstadual.Text}' , Email = '{txtEmail.Text}', Telefone = '{txtTelefone.Text}', Endereco = '{txtEndereco.Text}' WHERE IdFornecedor = {txtId.Text};");
                MessageBox.Show("Fornecedor atualizado com Sucesso!");
                btnAtualizar.Enabled = false;
                Limpar();
            }
            else if (cbxProduto.Checked == true)
            {
                conectar.BancoDados($"update tb_produtos set Codigo = '{txtCodigo.Text}' , Descricao = '{txtDescricao.Text}' , DataValidade = '{txtDataValidade.Text}' , Preco = '{txtPreco.Text}' , Quantidade = '{txtQuantidade.Text}', Medida = '{txtMedida.Text}', Tipo = '{txtTipo.Text}' WHERE IdFornecedor = {txtIdFornecedorXProduto.Text};");
                MessageBox.Show("Produto atualizado com Sucesso!");
                btnAtualizar.Enabled = false;
                Limpar();
            }
        }
        #endregion

        #region Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbxFornecedor.Checked == true)
            {
                conectar.BancoDados($"insert into tb_fornecedores values('{txtId.Text}','{txtCnpj.Text}','{txtRazaoSocial.Text}','{txtNomeFantasia.Text}','{txtInscricaoEstadual.Text}','{txtEmail.Text}','{txtTelefone.Text}','{txtEndereco.Text}')");
                MessageBox.Show("Fornecedor incluido com Sucesso!");
                Limpar();
            }
            else if (cbxProduto.Checked == true)
            {
                conectar.BancoDados($"insert into tb_produtos values('{txtIdFornecedorXProduto.Text}','{txtCodigo.Text}','{txtDescricao.Text}','{txtDataValidade.Text}','{txtPreco.Text}','{txtQuantidade.Text}','{txtMedida.Text}','{txtTipo.Text}')");
                MessageBox.Show("Produto incluido com Sucesso!");
                Limpar();
            }
        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCnpj.Text = null;
            txtCodigo.Text = null;
            txtDataValidade.Text = null;
            txtDescricao.Text = null;
            txtEmail.Text = null;
            txtEndereco.Text = null;
            txtIdFornecedorXProduto.Text = null;
            txtId.Text = null;
            txtInscricaoEstadual.Text = null;
            txtMedida.Text = null;
            txtNomeFantasia.Text = null;
            txtPreco.Text = null;
            txtQuantidade.Text = null;
            txtRazaoSocial.Text = null;
            txtTelefone.Text = null;
            txtTipo.Text = null;
        }
        #endregion

        #endregion

        #region Funções
        public void Limpar()
        {
            txtCnpj.Text = null;
            txtCodigo.Text = null;
            txtDataValidade.Text = null;    
            txtDescricao.Text = null;
            txtEmail.Text = null;
            txtEndereco.Text = null;    
            txtIdFornecedorXProduto.Text = null;
            txtId.Text = null;
            txtInscricaoEstadual.Text = null;   
            txtMedida.Text = null;  
            txtNomeFantasia.Text = null;    
            txtPreco.Text = null;
            txtQuantidade.Text = null;
            txtRazaoSocial.Text = null;
            txtTelefone.Text = null;
            txtTipo.Text = null;
            cbxAlimenticio.Checked = false;
            cbxFornecedor.Checked = false;
            cbxProduto.Checked = false;
        }
        #endregion


    }

}
