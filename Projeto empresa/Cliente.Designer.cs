namespace Projeto_empresa
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.btnValidarCPF = new System.Windows.Forms.Panel();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btsair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btlimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btsalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btoutros = new System.Windows.Forms.RadioButton();
            this.rbfeminino = new System.Windows.Forms.RadioButton();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstCliente = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnValidarCPF.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValidarCPF
            // 
            this.btnValidarCPF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnValidarCPF.Controls.Add(this.txtdata);
            this.btnValidarCPF.Controls.Add(this.label11);
            this.btnValidarCPF.Controls.Add(this.txtcpf);
            this.btnValidarCPF.Controls.Add(this.btnExcluir);
            this.btnValidarCPF.Controls.Add(this.btnEditar);
            this.btnValidarCPF.Controls.Add(this.btcancelar);
            this.btnValidarCPF.Controls.Add(this.label7);
            this.btnValidarCPF.Controls.Add(this.btsair);
            this.btnValidarCPF.Controls.Add(this.label6);
            this.btnValidarCPF.Controls.Add(this.btlimpar);
            this.btnValidarCPF.Controls.Add(this.label5);
            this.btnValidarCPF.Controls.Add(this.btsalvar);
            this.btnValidarCPF.Controls.Add(this.label4);
            this.btnValidarCPF.Controls.Add(this.label3);
            this.btnValidarCPF.Controls.Add(this.label2);
            this.btnValidarCPF.Controls.Add(this.btoutros);
            this.btnValidarCPF.Controls.Add(this.rbfeminino);
            this.btnValidarCPF.Controls.Add(this.rbmasculino);
            this.btnValidarCPF.Controls.Add(this.cbestado);
            this.btnValidarCPF.Controls.Add(this.txttelefone);
            this.btnValidarCPF.Controls.Add(this.txtnome);
            this.btnValidarCPF.Controls.Add(this.txtemail);
            this.btnValidarCPF.Controls.Add(this.label8);
            this.btnValidarCPF.Location = new System.Drawing.Point(1, 55);
            this.btnValidarCPF.Name = "btnValidarCPF";
            this.btnValidarCPF.Size = new System.Drawing.Size(879, 224);
            this.btnValidarCPF.TabIndex = 0;
            this.btnValidarCPF.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(99, 187);
            this.txtdata.Mask = "00/00/0000";
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(71, 20);
            this.txtdata.TabIndex = 21;
            this.txtdata.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.MidnightBlue;
            this.label11.Font = new System.Drawing.Font("12SaruYellowFog", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(14, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "Data de nascimeto";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(99, 11);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(278, 20);
            this.txtcpf.TabIndex = 19;
            this.txtcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtcpf_MaskInputRejected);
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(611, 8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 35);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(611, 45);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 35);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcancelar.BackgroundImage")));
            this.btcancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btcancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btcancelar.Location = new System.Drawing.Point(611, 82);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(124, 35);
            this.btcancelar.TabIndex = 5;
            this.btcancelar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MidnightBlue;
            this.label7.Font = new System.Drawing.Font("12SaruYellowFog", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(43, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sexo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btsair
            // 
            this.btsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsair.BackgroundImage")));
            this.btsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btsair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btsair.Location = new System.Drawing.Point(741, 82);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(124, 35);
            this.btsair.TabIndex = 4;
            this.btsair.Text = "                                                               ";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MidnightBlue;
            this.label6.Font = new System.Drawing.Font("12SaruYellowFog", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(29, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Estado";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btlimpar.BackgroundImage")));
            this.btlimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btlimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlimpar.Location = new System.Drawing.Point(741, 45);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(124, 35);
            this.btlimpar.TabIndex = 3;
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("12SaruYellowFog", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefone";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btsalvar.BackgroundImage")));
            this.btsalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btsalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btsalvar.Location = new System.Drawing.Point(741, 8);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(124, 35);
            this.btsalvar.TabIndex = 2;
            this.btsalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("12SaruYellowFog", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(43, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("12SaruYellowFog", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(46, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("12SaruYellowFog", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(56, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btoutros
            // 
            this.btoutros.AutoSize = true;
            this.btoutros.Location = new System.Drawing.Point(249, 156);
            this.btoutros.Name = "btoutros";
            this.btoutros.Size = new System.Drawing.Size(56, 17);
            this.btoutros.TabIndex = 16;
            this.btoutros.Text = "Outros";
            this.btoutros.UseVisualStyleBackColor = true;
            this.btoutros.CheckedChanged += new System.EventHandler(this.btoutros_CheckedChanged);
            // 
            // rbfeminino
            // 
            this.rbfeminino.AutoSize = true;
            this.rbfeminino.Location = new System.Drawing.Point(176, 156);
            this.rbfeminino.Name = "rbfeminino";
            this.rbfeminino.Size = new System.Drawing.Size(67, 17);
            this.rbfeminino.TabIndex = 15;
            this.rbfeminino.Text = "Feminino";
            this.rbfeminino.UseVisualStyleBackColor = true;
            this.rbfeminino.CheckedChanged += new System.EventHandler(this.rbfeminino_CheckedChanged);
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(97, 156);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(73, 17);
            this.rbmasculino.TabIndex = 14;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            this.rbmasculino.CheckedChanged += new System.EventHandler(this.rbmasculino_CheckedChanged);
            // 
            // cbestado
            // 
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Location = new System.Drawing.Point(100, 127);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(154, 21);
            this.cbestado.TabIndex = 13;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(99, 101);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(278, 20);
            this.txttelefone.TabIndex = 10;
            this.txttelefone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(100, 42);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(278, 20);
            this.txtnome.TabIndex = 9;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(99, 72);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(278, 20);
            this.txtemail.TabIndex = 8;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.MidnightBlue;
            this.label8.Font = new System.Drawing.Font("Microstyle Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-5, -41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 260);
            this.label8.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microstyle Extended", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(879, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lstCliente);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(1, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 278);
            this.panel2.TabIndex = 2;
            // 
            // lstCliente
            // 
            this.lstCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstCliente.FullRowSelect = true;
            this.lstCliente.GridLines = true;
            this.lstCliente.Location = new System.Drawing.Point(-3, 1);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(876, 340);
            this.lstCliente.TabIndex = 3;
            this.lstCliente.UseCompatibleStateImageBehavior = false;
            this.lstCliente.View = System.Windows.Forms.View.Details;
            this.lstCliente.SelectedIndexChanged += new System.EventHandler(this.lstCliente_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CPF";
            this.columnHeader1.Width = 176;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 149;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefone";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Estado";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sexo";
            this.columnHeader6.Width = 112;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.MidnightBlue;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microstyle Extended", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(879, 40);
            this.label9.TabIndex = 3;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MidnightBlue;
            this.label10.Font = new System.Drawing.Font("12SaruYellowFog", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(42, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Pesquisar";
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtpesquisa.Location = new System.Drawing.Point(133, 292);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(650, 20);
            this.txtpesquisa.TabIndex = 18;
            this.txtpesquisa.TextChanged += new System.EventHandler(this.txtpesquisa_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(793, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dada de nascimento";
            this.columnHeader7.Width = 115;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidarCPF);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "0,,,,,,,,,,,,,,,,,,,,,,,,,";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btnValidarCPF.ResumeLayout(false);
            this.btnValidarCPF.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btnValidarCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.RadioButton btoutros;
        private System.Windows.Forms.RadioButton rbfeminino;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstCliente;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox txtdata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

