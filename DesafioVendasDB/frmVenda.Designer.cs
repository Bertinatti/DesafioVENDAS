namespace DesafioGaragemDB
{
    partial class frmVenda
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
            this.components = new System.ComponentModel.Container();
            this.pExibirAcao = new System.Windows.Forms.Panel();
            this.lbRealizarCompra = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.lblProdutoEstoque = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.caboclo_dbDataSet = new DesafioGaragemDB.caboclo_dbDataSet();
            this.cbNomeCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new DesafioGaragemDB.caboclo_dbDataSetTableAdapters.clienteTableAdapter();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigobarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new DesafioGaragemDB.caboclo_dbDataSetTableAdapters.produtoTableAdapter();
            this.dgCarrinho = new System.Windows.Forms.DataGridView();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.lblCarrinho = new System.Windows.Forms.Label();
            this.btnSelecionaUsuario = new System.Windows.Forms.Button();
            this.cIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pExibirAcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caboclo_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // pExibirAcao
            // 
            this.pExibirAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pExibirAcao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pExibirAcao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pExibirAcao.Controls.Add(this.lbRealizarCompra);
            this.pExibirAcao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pExibirAcao.ForeColor = System.Drawing.Color.White;
            this.pExibirAcao.Location = new System.Drawing.Point(38, 30);
            this.pExibirAcao.Name = "pExibirAcao";
            this.pExibirAcao.Size = new System.Drawing.Size(1001, 64);
            this.pExibirAcao.TabIndex = 13;
            // 
            // lbRealizarCompra
            // 
            this.lbRealizarCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRealizarCompra.AutoSize = true;
            this.lbRealizarCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealizarCompra.ForeColor = System.Drawing.Color.White;
            this.lbRealizarCompra.Location = new System.Drawing.Point(329, 19);
            this.lbRealizarCompra.Name = "lbRealizarCompra";
            this.lbRealizarCompra.Size = new System.Drawing.Size(373, 24);
            this.lbRealizarCompra.TabIndex = 0;
            this.lbRealizarCompra.Text = "COMPRA - Realizando uma compra.";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbQuantidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantidade.Location = new System.Drawing.Point(790, 249);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(249, 26);
            this.tbQuantidade.TabIndex = 5;
            // 
            // lblProdutoEstoque
            // 
            this.lblProdutoEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProdutoEstoque.AutoSize = true;
            this.lblProdutoEstoque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoEstoque.ForeColor = System.Drawing.Color.White;
            this.lblProdutoEstoque.Location = new System.Drawing.Point(35, 184);
            this.lblProdutoEstoque.Name = "lblProdutoEstoque";
            this.lblProdutoEstoque.Size = new System.Drawing.Size(179, 18);
            this.lblProdutoEstoque.TabIndex = 6;
            this.lblProdutoEstoque.Text = "Produtos no estoque:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.White;
            this.lblNomeCliente.Location = new System.Drawing.Point(35, 115);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(141, 18);
            this.lblNomeCliente.TabIndex = 8;
            this.lblNomeCliente.Text = "Nome do cliente:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(787, 228);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(106, 18);
            this.lblQuantidade.TabIndex = 9;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnComprar.Enabled = false;
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.Location = new System.Drawing.Point(790, 470);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(249, 52);
            this.btnComprar.TabIndex = 14;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // caboclo_dbDataSet
            // 
            this.caboclo_dbDataSet.DataSetName = "caboclo_dbDataSet";
            this.caboclo_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbNomeCliente
            // 
            this.cbNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNomeCliente.BackColor = System.Drawing.Color.White;
            this.cbNomeCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "id_cliente", true));
            this.cbNomeCliente.DataSource = this.clienteBindingSource;
            this.cbNomeCliente.DisplayMember = "nome_cliente";
            this.cbNomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomeCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNomeCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomeCliente.FormattingEnabled = true;
            this.cbNomeCliente.Location = new System.Drawing.Point(38, 136);
            this.cbNomeCliente.Name = "cbNomeCliente";
            this.cbNomeCliente.Size = new System.Drawing.Size(687, 26);
            this.cbNomeCliente.TabIndex = 15;
            this.cbNomeCliente.ValueMember = "id_cliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.caboclo_dbDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // dgProdutos
            // 
            this.dgProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgProdutos.AutoGenerateColumns = false;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutoDataGridViewTextBoxColumn,
            this.codigobarrasDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn});
            this.dgProdutos.DataSource = this.produtoBindingSource;
            this.dgProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProdutos.Location = new System.Drawing.Point(38, 205);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.Size = new System.Drawing.Size(687, 165);
            this.dgProdutos.TabIndex = 16;
            this.dgProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_CellClick);
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "Id do produto:";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigobarrasDataGridViewTextBoxColumn
            // 
            this.codigobarrasDataGridViewTextBoxColumn.DataPropertyName = "codigo_barras";
            this.codigobarrasDataGridViewTextBoxColumn.HeaderText = "Codigo de barras:";
            this.codigobarrasDataGridViewTextBoxColumn.Name = "codigobarrasDataGridViewTextBoxColumn";
            this.codigobarrasDataGridViewTextBoxColumn.Width = 120;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nome_produto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "Nome do produto:";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            this.nomeprodutoDataGridViewTextBoxColumn.Width = 120;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço unitário:";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Quantidade no estoque:";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.Width = 150;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.caboclo_dbDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // dgCarrinho
            // 
            this.dgCarrinho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdProduto,
            this.cNomeProduto,
            this.cValorUnitario,
            this.cQuantidade,
            this.cValorTotal});
            this.dgCarrinho.Location = new System.Drawing.Point(38, 421);
            this.dgCarrinho.Name = "dgCarrinho";
            this.dgCarrinho.Size = new System.Drawing.Size(687, 168);
            this.dgCarrinho.TabIndex = 17;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAdicionarItem.Enabled = false;
            this.btnAdicionarItem.FlatAppearance.BorderSize = 0;
            this.btnAdicionarItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarItem.Location = new System.Drawing.Point(790, 305);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(249, 52);
            this.btnAdicionarItem.TabIndex = 14;
            this.btnAdicionarItem.Text = "Adicionar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = false;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // lblCarrinho
            // 
            this.lblCarrinho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCarrinho.AutoSize = true;
            this.lblCarrinho.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrinho.ForeColor = System.Drawing.Color.White;
            this.lblCarrinho.Location = new System.Drawing.Point(35, 400);
            this.lblCarrinho.Name = "lblCarrinho";
            this.lblCarrinho.Size = new System.Drawing.Size(182, 18);
            this.lblCarrinho.TabIndex = 6;
            this.lblCarrinho.Text = "Produtos no carrinho:";
            // 
            // btnSelecionaUsuario
            // 
            this.btnSelecionaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelecionaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSelecionaUsuario.FlatAppearance.BorderSize = 0;
            this.btnSelecionaUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSelecionaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionaUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionaUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelecionaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionaUsuario.Location = new System.Drawing.Point(790, 122);
            this.btnSelecionaUsuario.Name = "btnSelecionaUsuario";
            this.btnSelecionaUsuario.Size = new System.Drawing.Size(249, 52);
            this.btnSelecionaUsuario.TabIndex = 14;
            this.btnSelecionaUsuario.Text = "Confirmar Cliente";
            this.btnSelecionaUsuario.UseVisualStyleBackColor = false;
            this.btnSelecionaUsuario.Click += new System.EventHandler(this.btnSelecionaUsuario_Click);
            // 
            // cIdProduto
            // 
            this.cIdProduto.HeaderText = "Id do produto:";
            this.cIdProduto.Name = "cIdProduto";
            this.cIdProduto.Width = 120;
            // 
            // cNomeProduto
            // 
            this.cNomeProduto.HeaderText = "Nome do produto:";
            this.cNomeProduto.Name = "cNomeProduto";
            this.cNomeProduto.Width = 150;
            // 
            // cValorUnitario
            // 
            this.cValorUnitario.HeaderText = "Valor unitário:";
            this.cValorUnitario.Name = "cValorUnitario";
            this.cValorUnitario.Width = 120;
            // 
            // cQuantidade
            // 
            this.cQuantidade.HeaderText = "Quantidade:";
            this.cQuantidade.Name = "cQuantidade";
            this.cQuantidade.Width = 120;
            // 
            // cValorTotal
            // 
            this.cValorTotal.HeaderText = "Valor Total";
            this.cValorTotal.Name = "cValorTotal";
            this.cValorTotal.Width = 120;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 621);
            this.Controls.Add(this.dgCarrinho);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.cbNomeCliente);
            this.Controls.Add(this.pExibirAcao);
            this.Controls.Add(this.btnSelecionaUsuario);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.lblCarrinho);
            this.Controls.Add(this.lblProdutoEstoque);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.lblQuantidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenda";
            this.Text = "frmVenda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.pExibirAcao.ResumeLayout(false);
            this.pExibirAcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caboclo_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pExibirAcao;
        private System.Windows.Forms.Label lbRealizarCompra;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label lblProdutoEstoque;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnComprar;
        private caboclo_dbDataSet caboclo_dbDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private caboclo_dbDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        protected System.Windows.Forms.ComboBox cbNomeCliente;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private caboclo_dbDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigobarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgCarrinho;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Label lblCarrinho;
        private System.Windows.Forms.Button btnSelecionaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValorTotal;
    }
}