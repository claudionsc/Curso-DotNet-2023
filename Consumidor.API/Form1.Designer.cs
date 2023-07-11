namespace Consumidor.API
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
            components = new System.ComponentModel.Container();
            btnAtualizar = new Button();
            dtgGrid = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            finalizadoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            trabalhoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dtgGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trabalhoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(47, 70);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(214, 60);
            btnAtualizar.TabIndex = 0;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // dtgGrid
            // 
            dtgGrid.AutoGenerateColumns = false;
            dtgGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGrid.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, finalizadoDataGridViewCheckBoxColumn });
            dtgGrid.DataSource = trabalhoBindingSource;
            dtgGrid.Location = new Point(47, 167);
            dtgGrid.Name = "dtgGrid";
            dtgGrid.RowHeadersWidth = 51;
            dtgGrid.RowTemplate.Height = 29;
            dtgGrid.Size = new Size(431, 217);
            dtgGrid.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // finalizadoDataGridViewCheckBoxColumn
            // 
            finalizadoDataGridViewCheckBoxColumn.DataPropertyName = "Finalizado";
            finalizadoDataGridViewCheckBoxColumn.HeaderText = "Finalizado";
            finalizadoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            finalizadoDataGridViewCheckBoxColumn.Name = "finalizadoDataGridViewCheckBoxColumn";
            finalizadoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // trabalhoBindingSource
            // 
            trabalhoBindingSource.DataSource = typeof(Trabalho);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgGrid);
            Controls.Add(btnAtualizar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)trabalhoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtualizar;
        private DataGridView dtgGrid;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn finalizadoDataGridViewCheckBoxColumn;
        private BindingSource trabalhoBindingSource;
    }
}