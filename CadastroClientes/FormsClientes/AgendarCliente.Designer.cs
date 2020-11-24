namespace CadastroClientes.FormsClientes
{
    partial class AgendarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendarCliente));
            this.richTBClientes = new System.Windows.Forms.RichTextBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBProfissional = new System.Windows.Forms.ComboBox();
            this.comboBServico = new System.Windows.Forms.ComboBox();
            this.richTBAgenda = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboComissao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTBClientes
            // 
            this.richTBClientes.Location = new System.Drawing.Point(41, 12);
            this.richTBClientes.Name = "richTBClientes";
            this.richTBClientes.ReadOnly = true;
            this.richTBClientes.Size = new System.Drawing.Size(591, 79);
            this.richTBClientes.TabIndex = 0;
            this.richTBClientes.Text = "";
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(52, 215);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(157, 23);
            this.btnAgendar.TabIndex = 1;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o nome do cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(41, 130);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(199, 23);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(279, 130);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 10, 9, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 23);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selecione a data desejada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escolha o profissional de preferência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Escolha o serviço desejado";
            // 
            // comboBProfissional
            // 
            this.comboBProfissional.FormattingEnabled = true;
            this.comboBProfissional.Items.AddRange(new object[] {
            "Lucas",
            "Jéssica",
            "Júlia",
            "Maria",
            "Pedro"});
            this.comboBProfissional.Location = new System.Drawing.Point(41, 186);
            this.comboBProfissional.Name = "comboBProfissional";
            this.comboBProfissional.Size = new System.Drawing.Size(199, 23);
            this.comboBProfissional.TabIndex = 8;
            // 
            // comboBServico
            // 
            this.comboBServico.FormattingEnabled = true;
            this.comboBServico.Items.AddRange(new object[] {
            "Cortar cabelo (masc.) - R$ 21,00 c/ comissão ",
            "Cortar cabelo (fem.) - R$ 31,50 c/ comissão ",
            "Design sobrancelha - R$ 26,25  c/ comissão ",
            "Automaquiagem - R$ 52,50  c/ comissão ",
            "Design unhas - R$ 36,75 c/ comissão "});
            this.comboBServico.Location = new System.Drawing.Point(269, 186);
            this.comboBServico.Name = "comboBServico";
            this.comboBServico.Size = new System.Drawing.Size(247, 23);
            this.comboBServico.TabIndex = 8;
            this.comboBServico.SelectedIndexChanged += new System.EventHandler(this.comboBServico_SelectedIndexChanged);
            // 
            // richTBAgenda
            // 
            this.richTBAgenda.Location = new System.Drawing.Point(41, 259);
            this.richTBAgenda.Name = "richTBAgenda";
            this.richTBAgenda.ReadOnly = true;
            this.richTBAgenda.Size = new System.Drawing.Size(485, 96);
            this.richTBAgenda.TabIndex = 9;
            this.richTBAgenda.Text = "";
            this.richTBAgenda.TextChanged += new System.EventHandler(this.richTBAgenda_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marque o horário";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(533, 129);
            this.maskedTextBox1.Mask = "90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(37, 23);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // comboComissao
            // 
            this.comboComissao.FormattingEnabled = true;
            this.comboComissao.Items.AddRange(new object[] {
            "5%"});
            this.comboComissao.Location = new System.Drawing.Point(269, 216);
            this.comboComissao.Name = "comboComissao";
            this.comboComissao.Size = new System.Drawing.Size(247, 23);
            this.comboComissao.TabIndex = 12;
            this.comboComissao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AgendarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.comboComissao);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTBAgenda);
            this.Controls.Add(this.comboBServico);
            this.Controls.Add(this.comboBProfissional);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.richTBClientes);
            this.Name = "AgendarCliente";
            this.Text = "AgendarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTBClientes;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBProfissional;
        private System.Windows.Forms.ComboBox comboBServico;
        private System.Windows.Forms.RichTextBox richTBAgenda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboComissao;
    }
}