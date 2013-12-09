namespace GUI
{
    partial class FormCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label5 = new System.Windows.Forms.Label();
            this.listaProduto = new System.Windows.Forms.ListBox();
            this.listaCliente = new System.Windows.Forms.ListBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.chkPago = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btPesquisaPorCliente = new System.Windows.Forms.PictureBox();
            this.btPesquisarPorProduto = new System.Windows.Forms.PictureBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPesquisaPorCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPesquisarPorProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Realizar Compra: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escolha um cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Escolha um produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(10, 213);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(184, 22);
            this.txtProduto.TabIndex = 5;
            this.txtProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProduto_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(10, 369);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(63, 22);
            this.txtQuantidade.TabIndex = 8;
            // 
            // dgvCompra
            // 
            this.dgvCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCompra.Location = new System.Drawing.Point(292, 54);
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.Size = new System.Drawing.Size(522, 422);
            this.dgvCompra.TabIndex = 10;
            this.dgvCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompra_CellClick);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(826, 513);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 266;
            this.lineShape1.X2 = 263;
            this.lineShape1.Y1 = 15;
            this.lineShape1.Y2 = 491;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Compras Registradas: ";
            // 
            // listaProduto
            // 
            this.listaProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaProduto.FormattingEnabled = true;
            this.listaProduto.ItemHeight = 16;
            this.listaProduto.Location = new System.Drawing.Point(10, 233);
            this.listaProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaProduto.Name = "listaProduto";
            this.listaProduto.Size = new System.Drawing.Size(184, 112);
            this.listaProduto.TabIndex = 13;
            this.listaProduto.Visible = false;
            this.listaProduto.Click += new System.EventHandler(this.listaProduto_Click);
            // 
            // listaCliente
            // 
            this.listaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaCliente.FormattingEnabled = true;
            this.listaCliente.ItemHeight = 16;
            this.listaCliente.Location = new System.Drawing.Point(10, 93);
            this.listaCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaCliente.Name = "listaCliente";
            this.listaCliente.Size = new System.Drawing.Size(184, 96);
            this.listaCliente.TabIndex = 15;
            this.listaCliente.Visible = false;
            this.listaCliente.Click += new System.EventHandler(this.listaCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(10, 76);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(184, 22);
            this.txtCliente.TabIndex = 14;
            this.txtCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyUp);
            // 
            // chkPago
            // 
            this.chkPago.AutoSize = true;
            this.chkPago.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPago.Location = new System.Drawing.Point(42, 425);
            this.chkPago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPago.Name = "chkPago";
            this.chkPago.Size = new System.Drawing.Size(48, 19);
            this.chkPago.TabIndex = 16;
            this.chkPago.Text = "Sim";
            this.chkPago.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Compra Paga:";
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(12, 452);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(118, 24);
            this.btSalvar.TabIndex = 9;
            this.btSalvar.Text = "Salvar Compra";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btPesquisaPorCliente
            // 
            this.btPesquisaPorCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPesquisaPorCliente.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisaPorCliente.Image")));
            this.btPesquisaPorCliente.Location = new System.Drawing.Point(200, 76);
            this.btPesquisaPorCliente.Name = "btPesquisaPorCliente";
            this.btPesquisaPorCliente.Size = new System.Drawing.Size(28, 50);
            this.btPesquisaPorCliente.TabIndex = 18;
            this.btPesquisaPorCliente.TabStop = false;
            this.btPesquisaPorCliente.Visible = false;
            this.btPesquisaPorCliente.Click += new System.EventHandler(this.btPesquisaPorCliente_Click);
            // 
            // btPesquisarPorProduto
            // 
            this.btPesquisarPorProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPesquisarPorProduto.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisarPorProduto.Image")));
            this.btPesquisarPorProduto.Location = new System.Drawing.Point(200, 213);
            this.btPesquisarPorProduto.Name = "btPesquisarPorProduto";
            this.btPesquisarPorProduto.Size = new System.Drawing.Size(28, 50);
            this.btPesquisarPorProduto.TabIndex = 19;
            this.btPesquisarPorProduto.TabStop = false;
            this.btPesquisarPorProduto.Visible = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelar.Enabled = false;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(136, 452);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(118, 24);
            this.btCancelar.TabIndex = 20;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btAlterar.Enabled = false;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAlterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Location = new System.Drawing.Point(66, 485);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(118, 24);
            this.btAlterar.TabIndex = 21;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(826, 513);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btPesquisarPorProduto);
            this.Controls.Add(this.btPesquisaPorCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkPago);
            this.Controls.Add(this.listaCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.listaProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCompra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPesquisaPorCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPesquisarPorProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.DataGridView dgvCompra;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listaProduto;
        private System.Windows.Forms.ListBox listaCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.CheckBox chkPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.PictureBox btPesquisaPorCliente;
        private System.Windows.Forms.PictureBox btPesquisarPorProduto;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAlterar;
    }
}