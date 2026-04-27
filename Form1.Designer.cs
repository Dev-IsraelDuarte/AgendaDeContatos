namespace AgendaContatos
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
            txtNome = new TextBox();
            label2 = new Label();
            txtTelefone = new TextBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            lstContatos = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 93);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Contato:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(86, 111);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(230, 23);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 146);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(86, 164);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(230, 23);
            txtTelefone.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(174, 193);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(142, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar/Atualizar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(174, 438);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(142, 23);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover Selecionado";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // lstContatos
            // 
            lstContatos.FormattingEnabled = true;
            lstContatos.Location = new Point(86, 233);
            lstContatos.Name = "lstContatos";
            lstContatos.Size = new Size(230, 199);
            lstContatos.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 23);
            label3.Name = "label3";
            label3.Size = new Size(193, 25);
            label3.TabIndex = 7;
            label3.Text = "Agenda de Contatos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 473);
            Controls.Add(label3);
            Controls.Add(lstContatos);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTelefone);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtTelefone;
        private Button btnAdicionar;
        private Button btnRemover;
        private ListBox lstContatos;
        private Label label3;
    }
}
