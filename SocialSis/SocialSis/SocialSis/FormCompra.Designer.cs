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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label5 = new System.Windows.Forms.Label();
            this.listaProduto = new System.Windows.Forms.ListBox();
            this.listaCliente = new System.Windows.Forms.ListBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.chkPago = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Realizar Compra: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escolha um cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Escolha um produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(12, 232);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(184, 20);
            this.txtProduto.TabIndex = 5;
            this.txtProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProduto_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(220, 253);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(50, 20);
            this.txtQuantidade.TabIndex = 8;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(12, 423);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 9;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // dgvCompra
            // 
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(363, 53);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.Size = new System.Drawing.Size(448, 379);
            this.dgvCompra.TabIndex = 10;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(829, 460);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 322;
            this.lineShape1.X2 = 325;
            this.lineShape1.Y1 = 16;
            this.lineShape1.Y2 = 445;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Compras Registradas: ";
            // 
            // listaProduto
            // 
            this.listaProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaProduto.FormattingEnabled = true;
            this.listaProduto.Location = new System.Drawing.Point(12, 253);
            this.listaProduto.Name = "listaProduto";
            this.listaProduto.Size = new System.Drawing.Size(184, 91);
            this.listaProduto.TabIndex = 13;
            this.listaProduto.Visible = false;
            this.listaProduto.Click += new System.EventHandler(this.listaProduto_Click);
            // 
            // listaCliente
            // 
            this.listaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaCliente.FormattingEnabled = true;
            this.listaCliente.Location = new System.Drawing.Point(12, 111);
            this.listaCliente.Name = "listaCliente";
            this.listaCliente.Size = new System.Drawing.Size(184, 91);
            this.listaCliente.TabIndex = 15;
            this.listaCliente.Visible = false;
            this.listaCliente.Click += new System.EventHandler(this.listaCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(12, 90);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(184, 20);
            this.txtCliente.TabIndex = 14;
            this.txtCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyUp);
            // 
            // chkPago
            // 
            this.chkPago.AutoSize = true;
            this.chkPago.Location = new System.Drawing.Point(18, 383);
            this.chkPago.Name = "chkPago";
            this.chkPago.Size = new System.Drawing.Size(15, 14);
            this.chkPago.TabIndex = 16;
            this.chkPago.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Compra Paga:";
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 460);
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
            this.Name = "FormCompra";
            this.Text = "FormCompra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
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
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.DataGridView dgvCompra;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listaProduto;
        private System.Windows.Forms.ListBox listaCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.CheckBox chkPago;
        private System.Windows.Forms.Label label6;
    }
}