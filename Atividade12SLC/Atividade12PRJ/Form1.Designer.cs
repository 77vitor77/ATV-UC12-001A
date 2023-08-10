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
            lblID = new Label();
            lblnome = new Label();
            lblcpf = new Label();
            lbldatadenascimento = new Label();
            lblRendamensal = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(98, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(180, 37);
            lblID.TabIndex = 0;
            lblID.Text = "ID de usuario:";
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblnome.Location = new Point(98, 95);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(210, 37);
            lblnome.TabIndex = 1;
            lblnome.Text = "Nome completo";
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblcpf.Location = new Point(98, 181);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(62, 37);
            lblcpf.TabIndex = 2;
            lblcpf.Text = "CPF";
            // 
            // lbldatadenascimento
            // 
            lbldatadenascimento.AutoSize = true;
            lbldatadenascimento.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbldatadenascimento.Location = new Point(98, 267);
            lbldatadenascimento.Name = "lbldatadenascimento";
            lbldatadenascimento.Size = new Size(258, 37);
            lbldatadenascimento.TabIndex = 3;
            lbldatadenascimento.Text = "Data de Nascimento";
            // 
            // lblRendamensal
            // 
            lblRendamensal.AutoSize = true;
            lblRendamensal.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRendamensal.Location = new Point(98, 353);
            lblRendamensal.Name = "lblRendamensal";
            lblRendamensal.Size = new Size(243, 37);
            lblRendamensal.TabIndex = 4;
            lblRendamensal.Text = "Renda Mensal (R$):";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(98, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 43);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(98, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 43);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(98, 221);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 43);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(98, 307);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 43);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(98, 489);
            button1.Name = "button1";
            button1.Size = new Size(250, 41);
            button1.TabIndex = 9;
            button1.Text = "cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(98, 393);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 43);
            textBox5.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 569);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblRendamensal);
            Controls.Add(lbldatadenascimento);
            Controls.Add(lblcpf);
            Controls.Add(lblnome);
            Controls.Add(lblID);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblnome;
        private Label lblcpf;
        private Label lbldatadenascimento;
        private Label lblRendamensal;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private TextBox textBox5;
    }
}