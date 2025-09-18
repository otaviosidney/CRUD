namespace CRUD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            btnSalvar = new Button();
            label4 = new Label();
            txtLocalizar = new TextBox();
            btnConsultar = new Button();
            lstContatos = new ListView();
            label5 = new Label();
            txtID = new TextBox();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 46);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 114);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 186);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 76);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 23);
            txtNome.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(35, 146);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(270, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 23);
            txtEmail.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(35, 366);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 56);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Localizar";
            // 
            // txtLocalizar
            // 
            txtLocalizar.Location = new Point(504, 81);
            txtLocalizar.Name = "txtLocalizar";
            txtLocalizar.Size = new Size(149, 23);
            txtLocalizar.TabIndex = 8;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(698, 80);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button1_Click;
            // 
            // lstContatos
            // 
            lstContatos.Location = new Point(324, 123);
            lstContatos.Name = "lstContatos";
            lstContatos.Size = new Size(449, 285);
            lstContatos.TabIndex = 10;
            lstContatos.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 273);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 11;
            label5.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(35, 303);
            txtID.Name = "txtID";
            txtID.Size = new Size(265, 23);
            txtID.TabIndex = 12;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(127, 366);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 13;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += button2_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(225, 366);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 14;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(lstContatos);
            Controls.Add(btnConsultar);
            Controls.Add(txtLocalizar);
            Controls.Add(label4);
            Controls.Add(btnSalvar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Button btnSalvar;
        private Label label4;
        private TextBox txtLocalizar;
        private Button btnConsultar;
        private ListView lstContatos;
        private Label label5;
        private TextBox txtID;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}
