namespace WindowsFormsAppPrincipal
{
    partial class FromCadastroUsuario
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label ativoLabel;
            System.Windows.Forms.Label label1;
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButonCancelar = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(50, 145);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 16);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(53, 164);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(257, 22);
            this.nomeTextBox.TabIndex = 2;
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(316, 148);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(33, 16);
            cPFLabel.TabIndex = 2;
            cPFLabel.Text = "CPF";
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(319, 164);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(164, 22);
            this.cPFTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(501, 145);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 16);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(504, 164);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(253, 22);
            this.emailTextBox.TabIndex = 5;
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new System.Drawing.Point(50, 216);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(94, 16);
            nomeUsuarioLabel.TabIndex = 6;
            nomeUsuarioLabel.Text = "Nome Usuario";
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(53, 235);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(257, 22);
            this.nomeUsuarioTextBox.TabIndex = 7;
            this.nomeUsuarioTextBox.TextChanged += new System.EventHandler(this.nomeUsuarioTextBox_TextChanged);
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(316, 216);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(46, 16);
            senhaLabel.TabIndex = 8;
            senhaLabel.Text = "Senha";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(319, 235);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(164, 22);
            this.senhaTextBox.TabIndex = 9;
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(113, 296);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(0, 16);
            ativoLabel.TabIndex = 10;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(690, 233);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(67, 24);
            this.ativoCheckBox.TabIndex = 11;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(504, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(501, 216);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 16);
            label1.TabIndex = 13;
            label1.Text = "Confirmar Senha";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 63);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cadastro de Usuário";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButonCancelar
            // 
            this.ButonCancelar.BackColor = System.Drawing.Color.Red;
            this.ButonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButonCancelar.Location = new System.Drawing.Point(645, 369);
            this.ButonCancelar.Name = "ButonCancelar";
            this.ButonCancelar.Size = new System.Drawing.Size(112, 23);
            this.ButonCancelar.TabIndex = 15;
            this.ButonCancelar.Text = "Cancelar";
            this.ButonCancelar.UseVisualStyleBackColor = false;
            this.ButonCancelar.Click += new System.EventHandler(this.ButonCancelar_Click);
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.BackColor = System.Drawing.Color.SpringGreen;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSalvar.Location = new System.Drawing.Point(504, 369);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(112, 23);
            this.ButtonSalvar.TabIndex = 15;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // FromCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSalvar);
            this.Controls.Add(this.ButonCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromCadastroUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FromCadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButonCancelar;
        private System.Windows.Forms.Button ButtonSalvar;
    }
}