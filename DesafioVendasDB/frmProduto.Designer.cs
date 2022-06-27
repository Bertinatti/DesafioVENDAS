namespace DesafioGaragemDB
{
    partial class frmProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCadastroProduto = new System.Windows.Forms.Label();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.tbCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCadastroProduto);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(220, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 64);
            this.panel1.TabIndex = 13;
            // 
            // lblCadastroProduto
            // 
            this.lblCadastroProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroProduto.AutoSize = true;
            this.lblCadastroProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroProduto.ForeColor = System.Drawing.Color.White;
            this.lblCadastroProduto.Location = new System.Drawing.Point(148, 19);
            this.lblCadastroProduto.Name = "lblCadastroProduto";
            this.lblCadastroProduto.Size = new System.Drawing.Size(372, 24);
            this.lblCadastroProduto.TabIndex = 0;
            this.lblCadastroProduto.Text = "CADASTRO - Cadastrando produto.";
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCadastrarProduto.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(442, 459);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(214, 52);
            this.btnCadastrarProduto.TabIndex = 4;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNomeProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeProduto.Location = new System.Drawing.Point(220, 336);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(475, 26);
            this.tbNomeProduto.TabIndex = 2;
            // 
            // tbCodigoBarras
            // 
            this.tbCodigoBarras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodigoBarras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoBarras.Location = new System.Drawing.Point(220, 268);
            this.tbCodigoBarras.Name = "tbCodigoBarras";
            this.tbCodigoBarras.Size = new System.Drawing.Size(475, 26);
            this.tbCodigoBarras.TabIndex = 0;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProduto.ForeColor = System.Drawing.Color.White;
            this.lblNomeProduto.Location = new System.Drawing.Point(217, 314);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(150, 18);
            this.lblNomeProduto.TabIndex = 6;
            this.lblNomeProduto.Text = "Nome do produto:";
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(698, 315);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(61, 18);
            this.lblPreco.TabIndex = 7;
            this.lblPreco.Text = "Preço:";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarras.ForeColor = System.Drawing.Color.White;
            this.lblCodigoBarras.Location = new System.Drawing.Point(217, 246);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(150, 18);
            this.lblCodigoBarras.TabIndex = 8;
            this.lblCodigoBarras.Text = "Código de barras:";
            // 
            // lblEstoque
            // 
            this.lblEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.White;
            this.lblEstoque.Location = new System.Drawing.Point(698, 247);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(79, 18);
            this.lblEstoque.TabIndex = 9;
            this.lblEstoque.Text = "Estoque:";
            // 
            // tbEstoque
            // 
            this.tbEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEstoque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstoque.Location = new System.Drawing.Point(701, 268);
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(157, 26);
            this.tbEstoque.TabIndex = 1;
            // 
            // tbPreco
            // 
            this.tbPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPreco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreco.Location = new System.Drawing.Point(701, 336);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(157, 26);
            this.tbPreco.TabIndex = 3;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.tbNomeProduto);
            this.Controls.Add(this.tbEstoque);
            this.Controls.Add(this.tbCodigoBarras);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblCodigoBarras);
            this.Controls.Add(this.lblEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCadastroProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.TextBox tbCodigoBarras;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox tbEstoque;
        private System.Windows.Forms.TextBox tbPreco;
    }
}