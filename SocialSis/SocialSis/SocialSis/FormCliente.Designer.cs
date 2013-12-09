namespace GUI
{
    partial class FormClienteProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClienteProfessor));
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lbTelefone1Clietne = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmailCliente = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lbRgCliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lbSairSistema = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtPrevPag = new System.Windows.Forms.MaskedTextBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btProcurarPorNome = new System.Windows.Forms.PictureBox();
            this.btProcurarPorCpf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btProcurarPorNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btProcurarPorCpf)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 18);
            this.label7.TabIndex = 85;
            this.label7.Text = "Dados pessoais do Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 16);
            this.label4.TabIndex = 83;
            this.label4.Text = "Data prevista para o pagamento: ";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(10, 376);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(188, 22);
            this.txtEndereco.TabIndex = 82;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(7, 355);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(71, 16);
            this.lbEndereco.TabIndex = 81;
            this.lbEndereco.Text = "Endereço :";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(10, 124);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(188, 22);
            this.txtCpf.TabIndex = 80;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(7, 103);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(42, 16);
            this.lbCpf.TabIndex = 79;
            this.lbCpf.Text = "CPF :";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(10, 272);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(188, 22);
            this.txtTel.TabIndex = 78;
            // 
            // lbTelefone1Clietne
            // 
            this.lbTelefone1Clietne.AutoSize = true;
            this.lbTelefone1Clietne.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone1Clietne.Location = new System.Drawing.Point(7, 252);
            this.lbTelefone1Clietne.Name = "lbTelefone1Clietne";
            this.lbTelefone1Clietne.Size = new System.Drawing.Size(67, 16);
            this.lbTelefone1Clietne.TabIndex = 77;
            this.lbTelefone1Clietne.Text = "Telefone : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(10, 324);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 22);
            this.txtEmail.TabIndex = 76;
            // 
            // lbEmailCliente
            // 
            this.lbEmailCliente.AutoSize = true;
            this.lbEmailCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailCliente.Location = new System.Drawing.Point(7, 304);
            this.lbEmailCliente.Name = "lbEmailCliente";
            this.lbEmailCliente.Size = new System.Drawing.Size(49, 16);
            this.lbEmailCliente.TabIndex = 75;
            this.lbEmailCliente.Text = "Email :";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimento.Location = new System.Drawing.Point(7, 206);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(138, 16);
            this.lbDataNascimento.TabIndex = 73;
            this.lbDataNascimento.Text = "Data de Nascimento : ";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(10, 176);
            this.txtRg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(190, 22);
            this.txtRg.TabIndex = 72;
            // 
            // lbRgCliente
            // 
            this.lbRgCliente.AutoSize = true;
            this.lbRgCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRgCliente.Location = new System.Drawing.Point(7, 155);
            this.lbRgCliente.Name = "lbRgCliente";
            this.lbRgCliente.Size = new System.Drawing.Size(39, 16);
            this.lbRgCliente.TabIndex = 71;
            this.lbRgCliente.Text = "RG : ";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(10, 72);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(188, 22);
            this.txtNome.TabIndex = 70;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.Location = new System.Drawing.Point(7, 52);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(54, 16);
            this.lbNomeCliente.TabIndex = 69;
            this.lbNomeCliente.Text = "Nome : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 18);
            this.label2.TabIndex = 87;
            this.label2.Text = "Clientes Alunos Registrados: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(261, 43);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(482, 438);
            this.dgvCliente.TabIndex = 86;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // lbSairSistema
            // 
            this.lbSairSistema.AutoSize = true;
            this.lbSairSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSairSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSairSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSairSistema.Location = new System.Drawing.Point(1097, 12);
            this.lbSairSistema.Name = "lbSairSistema";
            this.lbSairSistema.Size = new System.Drawing.Size(103, 16);
            this.lbSairSistema.TabIndex = 92;
            this.lbSairSistema.Text = "Sair do Sistema";
            this.lbSairSistema.Click += new System.EventHandler(this.lbSairSistema_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.Black;
            this.btSalvar.Location = new System.Drawing.Point(12, 457);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(96, 24);
            this.btSalvar.TabIndex = 94;
            this.btSalvar.Text = "Cadastrar Cliente";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(755, 527);
            this.shapeContainer1.TabIndex = 95;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 236;
            this.lineShape1.X2 = 236;
            this.lineShape1.Y1 = 8;
            this.lineShape1.Y2 = 508;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNasc.Location = new System.Drawing.Point(12, 427);
            this.txtDataNasc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(68, 22);
            this.txtDataNasc.TabIndex = 97;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtPrevPag
            // 
            this.txtPrevPag.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevPag.Location = new System.Drawing.Point(10, 228);
            this.txtPrevPag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrevPag.Mask = "00/00/0000";
            this.txtPrevPag.Name = "txtPrevPag";
            this.txtPrevPag.Size = new System.Drawing.Size(74, 22);
            this.txtPrevPag.TabIndex = 98;
            this.txtPrevPag.ValidatingType = typeof(System.DateTime);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btExcluir.Enabled = false;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(114, 491);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(96, 24);
            this.btExcluir.TabIndex = 100;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelar.Enabled = false;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(114, 457);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(96, 24);
            this.btCancelar.TabIndex = 99;
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
            this.btAlterar.Location = new System.Drawing.Point(10, 491);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(96, 24);
            this.btAlterar.TabIndex = 101;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btProcurarPorNome
            // 
            this.btProcurarPorNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProcurarPorNome.Image = ((System.Drawing.Image)(resources.GetObject("btProcurarPorNome.Image")));
            this.btProcurarPorNome.Location = new System.Drawing.Point(204, 73);
            this.btProcurarPorNome.Name = "btProcurarPorNome";
            this.btProcurarPorNome.Size = new System.Drawing.Size(28, 21);
            this.btProcurarPorNome.TabIndex = 104;
            this.btProcurarPorNome.TabStop = false;
            this.btProcurarPorNome.Click += new System.EventHandler(this.btProcurarPorNome_Click);
            // 
            // btProcurarPorCpf
            // 
            this.btProcurarPorCpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProcurarPorCpf.Image = ((System.Drawing.Image)(resources.GetObject("btProcurarPorCpf.Image")));
            this.btProcurarPorCpf.Location = new System.Drawing.Point(204, 125);
            this.btProcurarPorCpf.Name = "btProcurarPorCpf";
            this.btProcurarPorCpf.Size = new System.Drawing.Size(28, 21);
            this.btProcurarPorCpf.TabIndex = 107;
            this.btProcurarPorCpf.TabStop = false;
            this.btProcurarPorCpf.Click += new System.EventHandler(this.btProcurarPorCpf_Click);
            // 
            // FormClienteProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(755, 527);
            this.Controls.Add(this.btProcurarPorCpf);
            this.Controls.Add(this.btProcurarPorNome);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.txtPrevPag);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbSairSistema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lbTelefone1Clietne);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmailCliente);
            this.Controls.Add(this.lbDataNascimento);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.lbRgCliente);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormClienteProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente Professor";
            this.Load += new System.EventHandler(this.FormClienteProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btProcurarPorNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btProcurarPorCpf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lbTelefone1Clietne;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmailCliente;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lbRgCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lbSairSistema;
        private System.Windows.Forms.Button btSalvar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.MaskedTextBox txtPrevPag;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.PictureBox btProcurarPorNome;
        private System.Windows.Forms.PictureBox btProcurarPorCpf;
    }
}