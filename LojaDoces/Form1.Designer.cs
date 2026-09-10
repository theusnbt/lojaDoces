namespace LojaDoces
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
            lblNomeDoce = new Label();
            lblPrecoUnitario = new Label();
            lblQuantidade = new Label();
            lblIdadeCliente = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblValorFinal = new Label();
            lblDesconto = new Label();
            lblNome = new Label();
            lblParcela = new Label();
            lblStatus = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNomeDoce
            // 
            lblNomeDoce.AutoSize = true;
            lblNomeDoce.Location = new Point(296, 58);
            lblNomeDoce.Name = "lblNomeDoce";
            lblNomeDoce.Size = new Size(70, 15);
            lblNomeDoce.TabIndex = 0;
            lblNomeDoce.Text = "Nome Doce";
            lblNomeDoce.Click += label1_Click;
            // 
            // lblPrecoUnitario
            // 
            lblPrecoUnitario.AutoSize = true;
            lblPrecoUnitario.Location = new Point(296, 116);
            lblPrecoUnitario.Name = "lblPrecoUnitario";
            lblPrecoUnitario.Size = new Size(82, 15);
            lblPrecoUnitario.TabIndex = 1;
            lblPrecoUnitario.Text = "Preço Unitario";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(297, 171);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblIdadeCliente
            // 
            lblIdadeCliente.AutoSize = true;
            lblIdadeCliente.Location = new Point(296, 222);
            lblIdadeCliente.Name = "lblIdadeCliente";
            lblIdadeCliente.Size = new Size(76, 15);
            lblIdadeCliente.TabIndex = 3;
            lblIdadeCliente.Text = "Idade Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(422, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(422, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(422, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(422, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 23);
            textBox4.TabIndex = 7;
            // 
            // lblValorFinal
            // 
            lblValorFinal.AutoSize = true;
            lblValorFinal.Location = new Point(296, 355);
            lblValorFinal.Name = "lblValorFinal";
            lblValorFinal.Size = new Size(61, 15);
            lblValorFinal.TabIndex = 8;
            lblValorFinal.Text = "Valor Final";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(296, 315);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 9;
            lblDesconto.Text = "Desconto";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(297, 275);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome";
            // 
            // lblParcela
            // 
            lblParcela.AutoSize = true;
            lblParcela.Location = new Point(297, 389);
            lblParcela.Name = "lblParcela";
            lblParcela.Size = new Size(45, 15);
            lblParcela.TabIndex = 11;
            lblParcela.Text = "Parcela";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(297, 419);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(291, 465);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(btnCalcular);
            Controls.Add(lblStatus);
            Controls.Add(lblParcela);
            Controls.Add(lblNome);
            Controls.Add(lblDesconto);
            Controls.Add(lblValorFinal);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblIdadeCliente);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPrecoUnitario);
            Controls.Add(lblNomeDoce);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeDoce;
        private Label lblPrecoUnitario;
        private Label lblQuantidade;
        private Label lblIdadeCliente;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblValorFinal;
        private Label lblDesconto;
        private Label lblNome;
        private Label lblParcela;
        private Label lblStatus;
        private Button btnCalcular;
    }
}
