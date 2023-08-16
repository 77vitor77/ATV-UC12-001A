namespace Atividade12PRJ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblnome = new Label();
            lblcpf = new Label();
            lbldatadenascimento = new Label();
            lblRendamensal = new Label();
            txtnome = new TextBox();
            txtcpf = new TextBox();
            button1 = new Button();
            txtrendamensal = new TextBox();
            lblID = new Label();
            lblidmostrar = new Label();
            datadenascimento = new DateTimePicker();
            txtID = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblnome.Location = new Point(51, 61);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(210, 37);
            lblnome.TabIndex = 1;
            lblnome.Text = "Nome completo";
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblcpf.Location = new Point(193, 107);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(68, 37);
            lblcpf.TabIndex = 2;
            lblcpf.Text = "CPF:";
            // 
            // lbldatadenascimento
            // 
            lbldatadenascimento.AutoSize = true;
            lbldatadenascimento.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbldatadenascimento.Location = new Point(3, 206);
            lbldatadenascimento.Name = "lbldatadenascimento";
            lbldatadenascimento.Size = new Size(258, 37);
            lbldatadenascimento.TabIndex = 3;
            lbldatadenascimento.Text = "Data de Nascimento";
            // 
            // lblRendamensal
            // 
            lblRendamensal.AutoSize = true;
            lblRendamensal.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRendamensal.Location = new Point(18, 156);
            lblRendamensal.Name = "lblRendamensal";
            lblRendamensal.Size = new Size(243, 37);
            lblRendamensal.TabIndex = 4;
            lblRendamensal.Text = "Renda Mensal (R$):";
            // 
            // txtnome
            // 
            txtnome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtnome.Location = new Point(267, 58);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(250, 43);
            txtnome.TabIndex = 6;
            // 
            // txtcpf
            // 
            txtcpf.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtcpf.Location = new Point(267, 107);
            txtcpf.MaxLength = 11;
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(250, 43);
            txtcpf.TabIndex = 7;
            txtcpf.TextChanged += txtcpf_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 297);
            button1.Name = "button1";
            button1.Size = new Size(250, 68);
            button1.TabIndex = 9;
            button1.Text = "cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtrendamensal
            // 
            txtrendamensal.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtrendamensal.Location = new Point(268, 156);
            txtrendamensal.Name = "txtrendamensal";
            txtrendamensal.Size = new Size(250, 43);
            txtrendamensal.TabIndex = 10;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(81, 12);
            lblID.Name = "lblID";
            lblID.Size = new Size(180, 37);
            lblID.TabIndex = 0;
            lblID.Text = "ID de usuario:";
            // 
            // lblidmostrar
            // 
            lblidmostrar.AutoSize = true;
            lblidmostrar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblidmostrar.Location = new Point(187, 22);
            lblidmostrar.Name = "lblidmostrar";
            lblidmostrar.Size = new Size(0, 37);
            lblidmostrar.TabIndex = 11;
            // 
            // datadenascimento
            // 
            datadenascimento.Location = new Point(267, 220);
            datadenascimento.Name = "datadenascimento";
            datadenascimento.Size = new Size(258, 23);
            datadenascimento.TabIndex = 12;
            datadenascimento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(268, 9);
            txtID.Name = "txtID";
            txtID.Size = new Size(250, 43);
            txtID.TabIndex = 13;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 440);
            button2.Name = "button2";
            button2.Size = new Size(250, 68);
            button2.TabIndex = 14;
            button2.Text = "Correntista";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(276, 440);
            button3.Name = "button3";
            button3.Size = new Size(250, 68);
            button3.TabIndex = 15;
            button3.Text = "Correntista";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 520);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtID);
            Controls.Add(datadenascimento);
            Controls.Add(lblidmostrar);
            Controls.Add(txtrendamensal);
            Controls.Add(button1);
            Controls.Add(txtcpf);
            Controls.Add(txtnome);
            Controls.Add(lblRendamensal);
            Controls.Add(lbldatadenascimento);
            Controls.Add(lblcpf);
            Controls.Add(lblnome);
            Controls.Add(lblID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblnome;
        private Label lblcpf;
        private Label lbldatadenascimento;
        private Label lblRendamensal;
        private TextBox txtnome;
        private TextBox txtcpf;
        private TextBox txtdatadenascimento;
        private Button button1;
        private TextBox txtrendamensal;
        private Label lblID;
        private Label lblidmostrar;
        private DateTimePicker datadenascimento;
        private TextBox txtID;
        private Button button2;
        private Button button3;
    }
}