namespace SocialSis
{
    partial class FormNotaFiscal
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
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.chkPago = new System.Windows.Forms.CheckBox();
            this.listaFornecedor = new System.Windows.Forms.ListBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.listaInsumo = new System.Windows.Forms.ListBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataPrevPag = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNBoleto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 263;
            this.lineShape1.X2 = 263;
            this.lineShape1.Y1 = 13;
            this.lineShape1.Y2 = 603;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(831, 619);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Notas Registradas: ";
            // 
            // dgvCompra
            // 
            this.dgvCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCompra.Location = new System.Drawing.Point(305, 70);
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.Size = new System.Drawing.Size(497, 485);
            this.dgvCompra.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nota Paga:";
            // 
            // chkPago
            // 
            this.chkPago.AutoSize = true;
            this.chkPago.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPago.Location = new System.Drawing.Point(42, 544);
            this.chkPago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPago.Name = "chkPago";
            this.chkPago.Size = new System.Drawing.Size(48, 19);
            this.chkPago.TabIndex = 28;
            this.chkPago.Text = "Sim";
            this.chkPago.UseVisualStyleBackColor = true;
            // 
            // listaFornecedor
            // 
            this.listaFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaFornecedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaFornecedor.FormattingEnabled = true;
            this.listaFornecedor.ItemHeight = 16;
            this.listaFornecedor.Location = new System.Drawing.Point(12, 146);
            this.listaFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaFornecedor.Name = "listaFornecedor";
            this.listaFornecedor.Size = new System.Drawing.Size(182, 96);
            this.listaFornecedor.TabIndex = 27;
            this.listaFornecedor.Visible = false;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(10, 125);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(184, 22);
            this.txtFornecedor.TabIndex = 26;
            // 
            // listaInsumo
            // 
            this.listaInsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaInsumo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaInsumo.FormattingEnabled = true;
            this.listaInsumo.ItemHeight = 16;
            this.listaInsumo.Location = new System.Drawing.Point(10, 299);
            this.listaInsumo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaInsumo.Name = "listaInsumo";
            this.listaInsumo.Size = new System.Drawing.Size(184, 112);
            this.listaInsumo.TabIndex = 25;
            this.listaInsumo.Visible = false;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(3, 582);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(188, 24);
            this.btSalvar.TabIndex = 24;
            this.btSalvar.Text = "Salvar Nota";
            this.btSalvar.UseVisualStyleBackColor = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(27, 435);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(63, 22);
            this.txtQuantidade.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantidade:";
            // 
            // txtInsumo
            // 
            this.txtInsumo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsumo.Location = new System.Drawing.Point(10, 281);
            this.txtInsumo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.Size = new System.Drawing.Size(184, 22);
            this.txtInsumo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Escolha um Insumo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Escolha um Fornecedor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Registrar uma Nota Fiscal :";
            // 
            // txtDataPrevPag
            // 
            this.txtDataPrevPag.Location = new System.Drawing.Point(20, 490);
            this.txtDataPrevPag.Mask = "00/00/0000";
            this.txtDataPrevPag.Name = "txtDataPrevPag";
            this.txtDataPrevPag.Size = new System.Drawing.Size(68, 20);
            this.txtDataPrevPag.TabIndex = 30;
            this.txtDataPrevPag.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Data de Vencimento :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Número do Boleto :";
            // 
            // txtNBoleto
            // 
            this.txtNBoleto.Location = new System.Drawing.Point(10, 70);
            this.txtNBoleto.Name = "txtNBoleto";
            this.txtNBoleto.Size = new System.Drawing.Size(184, 20);
            this.txtNBoleto.TabIndex = 33;
            // 
            // FormNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 619);
            this.Controls.Add(this.txtNBoleto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataPrevPag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkPago);
            this.Controls.Add(this.listaFornecedor);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.listaInsumo);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInsumo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FormNotaFiscal";
            this.Text = "FormNotaFiscal";
            this.Load += new System.EventHandler(this.FormNotaFiscal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkPago;
        private System.Windows.Forms.ListBox listaFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.ListBox listaInsumo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDataPrevPag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNBoleto;
    }
}