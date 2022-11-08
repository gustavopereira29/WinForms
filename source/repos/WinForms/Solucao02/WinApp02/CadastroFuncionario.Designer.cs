namespace WinApp02
{
    partial class CadastroFuncionario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbAutonomo = new System.Windows.Forms.RadioButton();
            this.rbCLT = new System.Windows.Forms.RadioButton();
            this.rbPJ = new System.Windows.Forms.RadioButton();
            this.gbTipoDeContrato = new System.Windows.Forms.GroupBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.gbTipoDeContrato.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 187);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(45, 15);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salário:";
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.ForeColor = System.Drawing.Color.Red;
            this.lblErros.Location = new System.Drawing.Point(346, 187);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(38, 15);
            this.lblErros.TabIndex = 5;
            this.lblErros.Text = "label6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 125);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(275, 23);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 41);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(275, 23);
            this.textBox6.TabIndex = 13;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 17);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 14;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(97, 17);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(75, 19);
            this.rbFeminino.TabIndex = 15;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbAutonomo
            // 
            this.rbAutonomo.AutoSize = true;
            this.rbAutonomo.Location = new System.Drawing.Point(206, 20);
            this.rbAutonomo.Name = "rbAutonomo";
            this.rbAutonomo.Size = new System.Drawing.Size(83, 19);
            this.rbAutonomo.TabIndex = 16;
            this.rbAutonomo.TabStop = true;
            this.rbAutonomo.Text = "Autônomo";
            this.rbAutonomo.UseVisualStyleBackColor = true;
            // 
            // rbCLT
            // 
            this.rbCLT.AutoSize = true;
            this.rbCLT.Location = new System.Drawing.Point(6, 20);
            this.rbCLT.Name = "rbCLT";
            this.rbCLT.Size = new System.Drawing.Size(44, 19);
            this.rbCLT.TabIndex = 17;
            this.rbCLT.TabStop = true;
            this.rbCLT.Text = "CLT";
            this.rbCLT.UseVisualStyleBackColor = true;
            // 
            // rbPJ
            // 
            this.rbPJ.AutoSize = true;
            this.rbPJ.Location = new System.Drawing.Point(106, 20);
            this.rbPJ.Name = "rbPJ";
            this.rbPJ.Size = new System.Drawing.Size(35, 19);
            this.rbPJ.TabIndex = 18;
            this.rbPJ.TabStop = true;
            this.rbPJ.Text = "PJ";
            this.rbPJ.UseVisualStyleBackColor = true;
            // 
            // gbTipoDeContrato
            // 
            this.gbTipoDeContrato.Controls.Add(this.rbCLT);
            this.gbTipoDeContrato.Controls.Add(this.rbPJ);
            this.gbTipoDeContrato.Controls.Add(this.rbAutonomo);
            this.gbTipoDeContrato.Location = new System.Drawing.Point(334, 107);
            this.gbTipoDeContrato.Name = "gbTipoDeContrato";
            this.gbTipoDeContrato.Size = new System.Drawing.Size(310, 50);
            this.gbTipoDeContrato.TabIndex = 19;
            this.gbTipoDeContrato.TabStop = false;
            this.gbTipoDeContrato.Text = "Tipo de Contrato:";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbFeminino);
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Location = new System.Drawing.Point(334, 23);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(310, 50);
            this.gbSexo.TabIndex = 20;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 388);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.gbTipoDeContrato);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            this.gbTipoDeContrato.ResumeLayout(false);
            this.gbTipoDeContrato.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblSalario;
        private Label lblErros;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox6;
        private RadioButton rbMasculino;
        private RadioButton rbFeminino;
        private RadioButton rbAutonomo;
        private RadioButton rbCLT;
        private RadioButton rbPJ;
        private GroupBox gbTipoDeContrato;
        private GroupBox gbSexo;
    }
}