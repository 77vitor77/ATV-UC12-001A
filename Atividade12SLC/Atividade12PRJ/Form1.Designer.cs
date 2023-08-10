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
            txtdatadenascimento = new TextBox();
            button1 = new Button();
            txtrendamensal = new TextBox();
            lblID = new Label();
            lblidmostrar = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblnome.Location = new Point(12, 68);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(210, 37);
            lblnome.TabIndex = 1;
            lblnome.Text = "Nome completo";
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblcpf.Location = new Point(268, 68);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(62, 37);
            lblcpf.TabIndex = 2;
            lblcpf.Text = "CPF";
            // 
            // lbldatadenascimento
            // 
            lbldatadenascimento.AutoSize = true;
            lbldatadenascimento.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbldatadenascimento.Location = new Point(12, 154);
            lbldatadenascimento.Name = "lbldatadenascimento";
            lbldatadenascimento.Size = new Size(258, 37);
            lbldatadenascimento.TabIndex = 3;
            lbldatadenascimento.Text = "Data de Nascimento";
            // 
            // lblRendamensal
            // 
            lblRendamensal.AutoSize = true;
            lblRendamensal.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRendamensal.Location = new Point(268, 154);
            lblRendamensal.Name = "lblRendamensal";
            lblRendamensal.Size = new Size(243, 37);
            lblRendamensal.TabIndex = 4;
            lblRendamensal.Text = "Renda Mensal (R$):";
            // 
            // txtnome
            // 
            txtnome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtnome.Location = new Point(12, 108);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(250, 43);
            txtnome.TabIndex = 6;
            // 
            // txtcpf
            // 
            txtcpf.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtcpf.Location = new Point(268, 108);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(250, 43);
            txtcpf.TabIndex = 7;
            // 
            // txtdatadenascimento
            // 
            txtdatadenascimento.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtdatadenascimento.Location = new Point(12, 194);
            txtdatadenascimento.Name = "txtdatadenascimento";
            txtdatadenascimento.Size = new Size(250, 43);
            txtdatadenascimento.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 285);
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
            txtrendamensal.Location = new Point(268, 194);
            txtrendamensal.Name = "txtrendamensal";
            txtrendamensal.Size = new Size(250, 43);
            txtrendamensal.TabIndex = 10;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(12, 18);
            lblID.Name = "lblID";
            lblID.Size = new Size(180, 37);
            lblID.TabIndex = 0;
            lblID.Text = "ID de usuario:";
            // 
            // lblidmostrar
            // 
            lblidmostrar.AutoSize = true;
            lblidmostrar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblidmostrar.Location = new Point(187, 18);
            lblidmostrar.Name = "lblidmostrar";
            lblidmostrar.Size = new Size(0, 37);
            lblidmostrar.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(282, 330);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 425);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblidmostrar);
            Controls.Add(txtrendamensal);
            Controls.Add(button1);
            Controls.Add(txtdatadenascimento);
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
        private DateTimePicker dateTimePicker1;
    }
}