namespace Interview
{
    partial class Filtro
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
            label1 = new Label();
            filter_name = new TextBox();
            filter_email = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            filter_data = new DateTimePicker();
            filter_block = new ComboBox();
            button1 = new Button();
            filter_tel = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome/Razão Social";
            // 
            // filter_name
            // 
            filter_name.Location = new Point(12, 27);
            filter_name.Name = "filter_name";
            filter_name.PlaceholderText = "Nome ou Razão Social do Cliente";
            filter_name.Size = new Size(240, 23);
            filter_name.TabIndex = 1;
            // 
            // filter_email
            // 
            filter_email.Location = new Point(12, 77);
            filter_email.Name = "filter_email";
            filter_email.PlaceholderText = "E-mail do Cliente";
            filter_email.Size = new Size(240, 23);
            filter_email.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 163);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 6;
            label4.Text = "Data de Cadastro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 220);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 8;
            label5.Text = "Cliente bloqueado";
            // 
            // filter_data
            // 
            filter_data.CustomFormat = "";
            filter_data.Location = new Point(12, 181);
            filter_data.Name = "filter_data";
            filter_data.Size = new Size(240, 23);
            filter_data.TabIndex = 10;
            // 
            // filter_block
            // 
            filter_block.FormattingEnabled = true;
            filter_block.Items.AddRange(new object[] { "Sim", "Não" });
            filter_block.Location = new Point(12, 238);
            filter_block.Name = "filter_block";
            filter_block.Size = new Size(240, 23);
            filter_block.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(12, 285);
            button1.Name = "button1";
            button1.Size = new Size(240, 37);
            button1.TabIndex = 12;
            button1.Text = "Aplicar Filtros";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // filter_tel
            // 
            filter_tel.Location = new Point(12, 130);
            filter_tel.Mask = "(99) 99999-9999";
            filter_tel.Name = "filter_tel";
            filter_tel.Size = new Size(240, 23);
            filter_tel.TabIndex = 4;
            // 
            // Filtro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 335);
            Controls.Add(filter_tel);
            Controls.Add(button1);
            Controls.Add(filter_block);
            Controls.Add(filter_data);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(filter_email);
            Controls.Add(label2);
            Controls.Add(filter_name);
            Controls.Add(label1);
            Name = "Filtro";
            Text = "Filtro compradores";
            Load += Filtro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox filter_name;
        private TextBox filter_email;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker filter_data;
        private ComboBox filter_block;
        private Button button1;
        private MaskedTextBox filter_tel;
    }
}