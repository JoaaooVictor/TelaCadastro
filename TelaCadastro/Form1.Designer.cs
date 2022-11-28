namespace TelaCadastro
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxFornecedor = new System.Windows.Forms.CheckBox();
            this.cbxProduto = new System.Windows.Forms.CheckBox();
            this.pnlFornecedor = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.pnlProduto = new System.Windows.Forms.Panel();
            this.txtIdFornecedorXProduto = new System.Windows.Forms.TextBox();
            this.lblIdProdutoXFornecedor = new System.Windows.Forms.Label();
            this.cbxAlimenticio = new System.Windows.Forms.CheckBox();
            this.pnlAlimenticio = new System.Windows.Forms.Panel();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.lblMedida = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.txtDataValidade = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBemvindo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtInscricaoEstadual = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlFornecedor.SuspendLayout();
            this.pnlProduto.SuspendLayout();
            this.pnlAlimenticio.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.AutoSize = true;
            this.cbxFornecedor.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFornecedor.Location = new System.Drawing.Point(333, 97);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(113, 32);
            this.cbxFornecedor.TabIndex = 0;
            this.cbxFornecedor.Text = "Fornecedor";
            this.cbxFornecedor.UseVisualStyleBackColor = true;
            this.cbxFornecedor.CheckedChanged += new System.EventHandler(this.cbxFornecedor_CheckedChanged);
            // 
            // cbxProduto
            // 
            this.cbxProduto.AutoSize = true;
            this.cbxProduto.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProduto.Location = new System.Drawing.Point(642, 97);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(89, 32);
            this.cbxProduto.TabIndex = 1;
            this.cbxProduto.Text = "Produto";
            this.cbxProduto.UseVisualStyleBackColor = true;
            this.cbxProduto.CheckedChanged += new System.EventHandler(this.cbxProduto_CheckedChanged);
            // 
            // pnlFornecedor
            // 
            this.pnlFornecedor.Controls.Add(this.txtInscricaoEstadual);
            this.pnlFornecedor.Controls.Add(this.lblId);
            this.pnlFornecedor.Controls.Add(this.txtId);
            this.pnlFornecedor.Controls.Add(this.txtCnpj);
            this.pnlFornecedor.Controls.Add(this.txtTelefone);
            this.pnlFornecedor.Controls.Add(this.txtEmail);
            this.pnlFornecedor.Controls.Add(this.txtEndereco);
            this.pnlFornecedor.Controls.Add(this.txtNomeFantasia);
            this.pnlFornecedor.Controls.Add(this.txtRazaoSocial);
            this.pnlFornecedor.Controls.Add(this.label7);
            this.pnlFornecedor.Controls.Add(this.label6);
            this.pnlFornecedor.Controls.Add(this.label5);
            this.pnlFornecedor.Controls.Add(this.label4);
            this.pnlFornecedor.Controls.Add(this.label3);
            this.pnlFornecedor.Controls.Add(this.lblCnpj);
            this.pnlFornecedor.Controls.Add(this.lblRazaoSocial);
            this.pnlFornecedor.Location = new System.Drawing.Point(83, 148);
            this.pnlFornecedor.Name = "pnlFornecedor";
            this.pnlFornecedor.Size = new System.Drawing.Size(932, 470);
            this.pnlFornecedor.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(528, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(120, 23);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "Id Fornecedor:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(654, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(62, 28);
            this.txtId.TabIndex = 21;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(198, 35);
            this.txtCnpj.Mask = "00\\. 000\\. 000\\/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(178, 28);
            this.txtCnpj.TabIndex = 13;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(198, 326);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(152, 28);
            this.txtTelefone.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(198, 281);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(595, 28);
            this.txtEmail.TabIndex = 11;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(198, 229);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(595, 28);
            this.txtEndereco.TabIndex = 10;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(198, 128);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(595, 28);
            this.txtNomeFantasia.TabIndex = 8;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(198, 80);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(595, 28);
            this.txtRazaoSocial.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Inscrição Estadual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Fantasia:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(123, 38);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(53, 23);
            this.lblCnpj.TabIndex = 1;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(64, 76);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(112, 23);
            this.lblRazaoSocial.TabIndex = 0;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // pnlProduto
            // 
            this.pnlProduto.Controls.Add(this.txtIdFornecedorXProduto);
            this.pnlProduto.Controls.Add(this.lblIdProdutoXFornecedor);
            this.pnlProduto.Controls.Add(this.cbxAlimenticio);
            this.pnlProduto.Controls.Add(this.pnlAlimenticio);
            this.pnlProduto.Controls.Add(this.txtPreco);
            this.pnlProduto.Controls.Add(this.txtDataValidade);
            this.pnlProduto.Controls.Add(this.txtCodigo);
            this.pnlProduto.Controls.Add(this.txtQuantidade);
            this.pnlProduto.Controls.Add(this.txtDescricao);
            this.pnlProduto.Controls.Add(this.label1);
            this.pnlProduto.Controls.Add(this.label2);
            this.pnlProduto.Controls.Add(this.label10);
            this.pnlProduto.Controls.Add(this.label11);
            this.pnlProduto.Controls.Add(this.label12);
            this.pnlProduto.Location = new System.Drawing.Point(83, 148);
            this.pnlProduto.Name = "pnlProduto";
            this.pnlProduto.Size = new System.Drawing.Size(932, 470);
            this.pnlProduto.TabIndex = 14;
            // 
            // txtIdFornecedorXProduto
            // 
            this.txtIdFornecedorXProduto.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdFornecedorXProduto.Location = new System.Drawing.Point(681, 56);
            this.txtIdFornecedorXProduto.Name = "txtIdFornecedorXProduto";
            this.txtIdFornecedorXProduto.Size = new System.Drawing.Size(62, 28);
            this.txtIdFornecedorXProduto.TabIndex = 22;
            // 
            // lblIdProdutoXFornecedor
            // 
            this.lblIdProdutoXFornecedor.AutoSize = true;
            this.lblIdProdutoXFornecedor.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProdutoXFornecedor.Location = new System.Drawing.Point(536, 59);
            this.lblIdProdutoXFornecedor.Name = "lblIdProdutoXFornecedor";
            this.lblIdProdutoXFornecedor.Size = new System.Drawing.Size(120, 23);
            this.lblIdProdutoXFornecedor.TabIndex = 21;
            this.lblIdProdutoXFornecedor.Text = "Id Fornecedor:";
            // 
            // cbxAlimenticio
            // 
            this.cbxAlimenticio.AutoSize = true;
            this.cbxAlimenticio.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAlimenticio.Location = new System.Drawing.Point(360, 3);
            this.cbxAlimenticio.Name = "cbxAlimenticio";
            this.cbxAlimenticio.Size = new System.Drawing.Size(175, 32);
            this.cbxAlimenticio.TabIndex = 19;
            this.cbxAlimenticio.Text = "Produto alimentício";
            this.cbxAlimenticio.UseVisualStyleBackColor = true;
            this.cbxAlimenticio.CheckedChanged += new System.EventHandler(this.cbxAlimenticio_CheckedChanged);
            // 
            // pnlAlimenticio
            // 
            this.pnlAlimenticio.Controls.Add(this.txtMedida);
            this.pnlAlimenticio.Controls.Add(this.lblMedida);
            this.pnlAlimenticio.Controls.Add(this.txtTipo);
            this.pnlAlimenticio.Controls.Add(this.label8);
            this.pnlAlimenticio.Location = new System.Drawing.Point(52, 284);
            this.pnlAlimenticio.Name = "pnlAlimenticio";
            this.pnlAlimenticio.Size = new System.Drawing.Size(302, 104);
            this.pnlAlimenticio.TabIndex = 20;
            // 
            // txtMedida
            // 
            this.txtMedida.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedida.Location = new System.Drawing.Point(147, 11);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(138, 28);
            this.txtMedida.TabIndex = 20;
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida.Location = new System.Drawing.Point(58, 14);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(70, 23);
            this.lblMedida.TabIndex = 16;
            this.lblMedida.Text = "Medida:";
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(147, 61);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(138, 28);
            this.txtTipo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipo:";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(198, 200);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(130, 28);
            this.txtPreco.TabIndex = 15;
            this.txtPreco.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataValidade
            // 
            this.txtDataValidade.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataValidade.Location = new System.Drawing.Point(198, 149);
            this.txtDataValidade.Mask = "00/00/0000";
            this.txtDataValidade.Name = "txtDataValidade";
            this.txtDataValidade.Size = new System.Drawing.Size(101, 28);
            this.txtDataValidade.TabIndex = 14;
            this.txtDataValidade.ValidatingType = typeof(System.DateTime);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(198, 56);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 28);
            this.txtCodigo.TabIndex = 13;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(198, 250);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(84, 28);
            this.txtQuantidade.TabIndex = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(198, 101);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(595, 28);
            this.txtDescricao.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Data de Validade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(112, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Código:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(91, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Descrição:";
            // 
            // lblBemvindo
            // 
            this.lblBemvindo.AutoSize = true;
            this.lblBemvindo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblBemvindo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBemvindo.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemvindo.Location = new System.Drawing.Point(293, 32);
            this.lblBemvindo.Name = "lblBemvindo";
            this.lblBemvindo.Size = new System.Drawing.Size(508, 41);
            this.lblBemvindo.TabIndex = 3;
            this.lblBemvindo.Text = "Seja bem-vindo, selecione qual tabela deseja:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(264, 650);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(147, 46);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPesquisar.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(49, 650);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(147, 46);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.LightCoral;
            this.btnExcluir.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(485, 650);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(147, 46);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Khaki;
            this.btnAtualizar.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(694, 650);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(147, 46);
            this.btnAtualizar.TabIndex = 19;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtInscricaoEstadual
            // 
            this.txtInscricaoEstadual.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscricaoEstadual.Location = new System.Drawing.Point(198, 175);
            this.txtInscricaoEstadual.Mask = "00000000000000";
            this.txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            this.txtInscricaoEstadual.Size = new System.Drawing.Size(152, 28);
            this.txtInscricaoEstadual.TabIndex = 23;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(887, 650);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(147, 46);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 758);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblBemvindo);
            this.Controls.Add(this.pnlProduto);
            this.Controls.Add(this.pnlFornecedor);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.cbxFornecedor);
            this.Name = "Cadastro";
            this.Text = "Cadastro System";
            this.pnlFornecedor.ResumeLayout(false);
            this.pnlFornecedor.PerformLayout();
            this.pnlProduto.ResumeLayout(false);
            this.pnlProduto.PerformLayout();
            this.pnlAlimenticio.ResumeLayout(false);
            this.pnlAlimenticio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxFornecedor;
        private System.Windows.Forms.CheckBox cbxProduto;
        private System.Windows.Forms.Panel pnlFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblBemvindo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Panel pnlProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox txtPreco;
        private System.Windows.Forms.MaskedTextBox txtDataValidade;
        private System.Windows.Forms.CheckBox cbxAlimenticio;
        private System.Windows.Forms.Panel pnlAlimenticio;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdFornecedorXProduto;
        private System.Windows.Forms.Label lblIdProdutoXFornecedor;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.MaskedTextBox txtInscricaoEstadual;
        private System.Windows.Forms.Button btnLimpar;
    }
}

