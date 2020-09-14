namespace Exercicio_CRUD
{
    partial class cademp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cademp));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtPesquisa = new System.Windows.Forms.ToolStripLabel();
            this.boxPesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.btnPesquisa = new System.Windows.Forms.ToolStripButton();
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.txtID = new System.Windows.Forms.Label();
            this.bxID = new System.Windows.Forms.TextBox();
            this.txtRazSoc = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.Label();
            this.txtIncEst = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.Label();
            this.bxRazSoc = new System.Windows.Forms.TextBox();
            this.bxCNPJ = new System.Windows.Forms.TextBox();
            this.bxEndereco = new System.Windows.Forms.TextBox();
            this.bxCidade = new System.Windows.Forms.TextBox();
            this.bxInscEst = new System.Windows.Forms.TextBox();
            this.bxEstado = new System.Windows.Forms.TextBox();
            this.dgEmpresas = new System.Windows.Forms.DataGridView();
            this.txtTelefone = new System.Windows.Forms.Label();
            this.bxTelefone = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnAlterar,
            this.btnExcluir,
            this.toolStripSeparator1,
            this.txtPesquisa,
            this.boxPesquisa,
            this.btnPesquisa,
            this.btnLimpar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(23, 22);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(57, 22);
            this.txtPesquisa.Text = "Pesquisar";
            // 
            // boxPesquisa
            // 
            this.boxPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxPesquisa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.boxPesquisa.Name = "boxPesquisa";
            this.boxPesquisa.Size = new System.Drawing.Size(100, 25);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(23, 22);
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(23, 22);
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(40, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(18, 13);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "ID";
            // 
            // bxID
            // 
            this.bxID.Location = new System.Drawing.Point(116, 58);
            this.bxID.Name = "bxID";
            this.bxID.ReadOnly = true;
            this.bxID.Size = new System.Drawing.Size(100, 20);
            this.bxID.TabIndex = 2;
            // 
            // txtRazSoc
            // 
            this.txtRazSoc.AutoSize = true;
            this.txtRazSoc.Location = new System.Drawing.Point(40, 92);
            this.txtRazSoc.Name = "txtRazSoc";
            this.txtRazSoc.Size = new System.Drawing.Size(70, 13);
            this.txtRazSoc.TabIndex = 1;
            this.txtRazSoc.Text = "Razão Social";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.AutoSize = true;
            this.txtCNPJ.Location = new System.Drawing.Point(40, 123);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(34, 13);
            this.txtCNPJ.TabIndex = 1;
            this.txtCNPJ.Text = "CNPJ";
            // 
            // txtEndereco
            // 
            this.txtEndereco.AutoSize = true;
            this.txtEndereco.Location = new System.Drawing.Point(40, 157);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(53, 13);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.Text = "Endereço";
            // 
            // txtCidade
            // 
            this.txtCidade.AutoSize = true;
            this.txtCidade.Location = new System.Drawing.Point(40, 197);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(40, 13);
            this.txtCidade.TabIndex = 1;
            this.txtCidade.Text = "Cidade";
            // 
            // txtIncEst
            // 
            this.txtIncEst.AutoSize = true;
            this.txtIncEst.Location = new System.Drawing.Point(351, 123);
            this.txtIncEst.Name = "txtIncEst";
            this.txtIncEst.Size = new System.Drawing.Size(74, 13);
            this.txtIncEst.TabIndex = 1;
            this.txtIncEst.Text = "Insc. Estadual";
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Location = new System.Drawing.Point(275, 197);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(40, 13);
            this.txtEstado.TabIndex = 1;
            this.txtEstado.Text = "Estado";
            // 
            // bxRazSoc
            // 
            this.bxRazSoc.Location = new System.Drawing.Point(116, 88);
            this.bxRazSoc.Name = "bxRazSoc";
            this.bxRazSoc.Size = new System.Drawing.Size(437, 20);
            this.bxRazSoc.TabIndex = 2;
            // 
            // bxCNPJ
            // 
            this.bxCNPJ.Location = new System.Drawing.Point(116, 120);
            this.bxCNPJ.Name = "bxCNPJ";
            this.bxCNPJ.Size = new System.Drawing.Size(188, 20);
            this.bxCNPJ.TabIndex = 2;
            // 
            // bxEndereco
            // 
            this.bxEndereco.Location = new System.Drawing.Point(116, 157);
            this.bxEndereco.Name = "bxEndereco";
            this.bxEndereco.Size = new System.Drawing.Size(437, 20);
            this.bxEndereco.TabIndex = 2;
            // 
            // bxCidade
            // 
            this.bxCidade.Location = new System.Drawing.Point(116, 194);
            this.bxCidade.Name = "bxCidade";
            this.bxCidade.Size = new System.Drawing.Size(131, 20);
            this.bxCidade.TabIndex = 2;
            // 
            // bxInscEst
            // 
            this.bxInscEst.Location = new System.Drawing.Point(431, 120);
            this.bxInscEst.Name = "bxInscEst";
            this.bxInscEst.Size = new System.Drawing.Size(122, 20);
            this.bxInscEst.TabIndex = 2;
            // 
            // bxEstado
            // 
            this.bxEstado.Location = new System.Drawing.Point(316, 194);
            this.bxEstado.Name = "bxEstado";
            this.bxEstado.Size = new System.Drawing.Size(70, 20);
            this.bxEstado.TabIndex = 2;
            // 
            // dgEmpresas
            // 
            this.dgEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpresas.Location = new System.Drawing.Point(43, 229);
            this.dgEmpresas.Name = "dgEmpresas";
            this.dgEmpresas.Size = new System.Drawing.Size(510, 188);
            this.dgEmpresas.TabIndex = 3;
            this.dgEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpresas_CellContentClick);
            // 
            // txtTelefone
            // 
            this.txtTelefone.AutoSize = true;
            this.txtTelefone.Location = new System.Drawing.Point(404, 197);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(49, 13);
            this.txtTelefone.TabIndex = 1;
            this.txtTelefone.Text = "Telefone";
            // 
            // bxTelefone
            // 
            this.bxTelefone.Location = new System.Drawing.Point(459, 194);
            this.bxTelefone.Name = "bxTelefone";
            this.bxTelefone.Size = new System.Drawing.Size(94, 20);
            this.bxTelefone.TabIndex = 2;
            // 
            // cademp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.dgEmpresas);
            this.Controls.Add(this.bxTelefone);
            this.Controls.Add(this.bxEstado);
            this.Controls.Add(this.bxInscEst);
            this.Controls.Add(this.bxCidade);
            this.Controls.Add(this.bxEndereco);
            this.Controls.Add(this.bxCNPJ);
            this.Controls.Add(this.bxRazSoc);
            this.Controls.Add(this.bxID);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtIncEst);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtRazSoc);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.toolStrip1);
            this.Name = "cademp";
            this.Text = "cademp";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel txtPesquisa;
        private System.Windows.Forms.ToolStripTextBox boxPesquisa;
        private System.Windows.Forms.ToolStripButton btnPesquisa;
        private System.Windows.Forms.ToolStripButton btnLimpar;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox bxID;
        private System.Windows.Forms.Label txtRazSoc;
        private System.Windows.Forms.Label txtCNPJ;
        private System.Windows.Forms.Label txtEndereco;
        private System.Windows.Forms.Label txtCidade;
        private System.Windows.Forms.Label txtIncEst;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.TextBox bxRazSoc;
        private System.Windows.Forms.TextBox bxCNPJ;
        private System.Windows.Forms.TextBox bxEndereco;
        private System.Windows.Forms.TextBox bxCidade;
        private System.Windows.Forms.TextBox bxInscEst;
        private System.Windows.Forms.TextBox bxEstado;
        private System.Windows.Forms.DataGridView dgEmpresas;
        private System.Windows.Forms.Label txtTelefone;
        private System.Windows.Forms.TextBox bxTelefone;
    }
}