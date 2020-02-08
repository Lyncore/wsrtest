namespace TEST
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.менеджерыDataSet = new TEST.МенеджерыDataSet();
            this.напоминанияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.напоминанияTableAdapter = new TEST.МенеджерыDataSetTableAdapters.НапоминанияTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.событиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комментарийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.напоминанияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.событиеDataGridViewTextBoxColumn,
            this.комментарийDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.напоминанияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // менеджерыDataSet
            // 
            this.менеджерыDataSet.DataSetName = "МенеджерыDataSet";
            this.менеджерыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // напоминанияBindingSource
            // 
            this.напоминанияBindingSource.DataMember = "Напоминания";
            this.напоминанияBindingSource.DataSource = this.менеджерыDataSet;
            // 
            // напоминанияTableAdapter
            // 
            this.напоминанияTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // событиеDataGridViewTextBoxColumn
            // 
            this.событиеDataGridViewTextBoxColumn.DataPropertyName = "Событие";
            this.событиеDataGridViewTextBoxColumn.HeaderText = "Событие";
            this.событиеDataGridViewTextBoxColumn.Name = "событиеDataGridViewTextBoxColumn";
            // 
            // комментарийDataGridViewTextBoxColumn
            // 
            this.комментарийDataGridViewTextBoxColumn.DataPropertyName = "Комментарий";
            this.комментарийDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.комментарийDataGridViewTextBoxColumn.Name = "комментарийDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 385);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.напоминанияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private МенеджерыDataSet менеджерыDataSet;
        private System.Windows.Forms.BindingSource напоминанияBindingSource;
        private МенеджерыDataSetTableAdapters.НапоминанияTableAdapter напоминанияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn событиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn комментарийDataGridViewTextBoxColumn;
    }
}