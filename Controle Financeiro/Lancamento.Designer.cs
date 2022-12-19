namespace Controle_Financeiro
{
    partial class Lancamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.combo_Tipo = new System.Windows.Forms.ComboBox();
            this.combo_Pago = new System.Windows.Forms.ComboBox();
            this.combo_Parcelas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.data_Parcela = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parcelas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Parcelas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pago?:";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(93, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(191, 23);
            this.txtId.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(93, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(349, 23);
            this.txtDescricao.TabIndex = 8;
            // 
            // combo_Tipo
            // 
            this.combo_Tipo.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.combo_Tipo.Location = new System.Drawing.Point(93, 173);
            this.combo_Tipo.Name = "combo_Tipo";
            this.combo_Tipo.Size = new System.Drawing.Size(127, 23);
            this.combo_Tipo.TabIndex = 13;
            // 
            // combo_Pago
            // 
            this.combo_Pago.Items.AddRange(new object[] {
            "X"});
            this.combo_Pago.Location = new System.Drawing.Point(93, 207);
            this.combo_Pago.Name = "combo_Pago";
            this.combo_Pago.Size = new System.Drawing.Size(69, 23);
            this.combo_Pago.TabIndex = 14;
            // 
            // combo_Parcelas
            // 
            this.combo_Parcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.combo_Parcelas.Location = new System.Drawing.Point(93, 105);
            this.combo_Parcelas.Name = "combo_Parcelas";
            this.combo_Parcelas.Size = new System.Drawing.Size(127, 23);
            this.combo_Parcelas.TabIndex = 15;
            this.combo_Parcelas.SelectedIndexChanged += new System.EventHandler(this.combo_Parcelas_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data_Parcela
            // 
            this.data_Parcela.Location = new System.Drawing.Point(93, 134);
            this.data_Parcela.Name = "data_Parcela";
            this.data_Parcela.Size = new System.Drawing.Size(250, 23);
            this.data_Parcela.TabIndex = 17;
            this.data_Parcela.ValueChanged += new System.EventHandler(this.data_Parcela_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(93, 72);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(127, 23);
            this.txtValorTotal.TabIndex = 19;
            // 
            // Lancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 248);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.data_Parcela);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo_Parcelas);
            this.Controls.Add(this.combo_Pago);
            this.Controls.Add(this.combo_Tipo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lancamento";
            this.Text = "Lancamento";
            this.Load += new System.EventHandler(this.Lancamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtId;
        private TextBox txtDescricao;
        private ComboBox combo_Tipo;
        private ComboBox combo_Pago;
        private ComboBox combo_Parcelas;
        private Button button1;
        private DateTimePicker data_Parcela;
        private Button button2;
        private TextBox txtValorTotal;
    }
}