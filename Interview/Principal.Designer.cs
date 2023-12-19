namespace Interview
{
    partial class Principal
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
            btn_add = new Button();
            dataGrid = new DataGridView();
            btn_previous = new Button();
            btn_next = new Button();
            textPagination = new TextBox();
            btn_filter = new Button();
            btn_cleanFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(616, 50);
            label1.TabIndex = 0;
            label1.Text = "Consulte os seus Clientes cadastrados na sua Loja ou realize o cadastro \r\nde novos Cliente";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(674, 9);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(114, 45);
            btn_add.TabIndex = 1;
            btn_add.Text = "Adicionar cliente";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.Location = new Point(12, 112);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(776, 286);
            dataGrid.TabIndex = 2;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // btn_previous
            // 
            btn_previous.Enabled = false;
            btn_previous.Location = new Point(337, 415);
            btn_previous.Name = "btn_previous";
            btn_previous.Size = new Size(23, 23);
            btn_previous.TabIndex = 3;
            btn_previous.Text = "<";
            btn_previous.UseVisualStyleBackColor = true;
            btn_previous.Click += btn_previous_Click;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(449, 415);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(23, 23);
            btn_next.TabIndex = 4;
            btn_next.Text = ">";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // textPagination
            // 
            textPagination.Location = new Point(366, 415);
            textPagination.Name = "textPagination";
            textPagination.ReadOnly = true;
            textPagination.Size = new Size(77, 23);
            textPagination.TabIndex = 5;
            textPagination.Text = "1 de 1";
            textPagination.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_filter
            // 
            btn_filter.Location = new Point(277, 73);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(106, 33);
            btn_filter.TabIndex = 6;
            btn_filter.Text = "Filtrar";
            btn_filter.UseVisualStyleBackColor = true;
            btn_filter.Click += btn_filter_Click;
            // 
            // btn_cleanFilter
            // 
            btn_cleanFilter.Location = new Point(419, 73);
            btn_cleanFilter.Name = "btn_cleanFilter";
            btn_cleanFilter.Size = new Size(106, 33);
            btn_cleanFilter.TabIndex = 7;
            btn_cleanFilter.Text = "Limpar Filtros";
            btn_cleanFilter.UseVisualStyleBackColor = true;
            btn_cleanFilter.Click += btn_cleanFilter_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cleanFilter);
            Controls.Add(btn_filter);
            Controls.Add(textPagination);
            Controls.Add(btn_next);
            Controls.Add(btn_previous);
            Controls.Add(dataGrid);
            Controls.Add(btn_add);
            Controls.Add(label1);
            Name = "Principal";
            Text = "Listagem compradores";
            Load += Principal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_add;
        private DataGridView dataGrid;
        private Button btn_previous;
        private Button btn_next;
        private TextBox textPagination;
        private Button btn_filter;
        private Button btn_cleanFilter;
    }
}