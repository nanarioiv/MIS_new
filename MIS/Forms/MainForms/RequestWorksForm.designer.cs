
namespace MIS.Forms.MainForms
{
    partial class RequestWorksForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.requestWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.requestWorkDtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Итого = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestWorkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestWorkDtDataGridViewTextBoxColumn,
            this.workDataGridViewTextBoxColumn,
            this.workPriceDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.spareDataGridViewTextBoxColumn,
            this.Цена,
            this.Итого,
            this.EditColumn,
            this.DeleteColumn});
            this.dataGridView.DataSource = this.requestWorkBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 54);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(844, 328);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // requestWorkBindingSource
            // 
            this.requestWorkBindingSource.DataSource = typeof(MIS.Data.RequestWork);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = global::MIS.Properties.Resources.add_btn;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(12, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(844, 36);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить услугу";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // requestWorkDtDataGridViewTextBoxColumn
            // 
            this.requestWorkDtDataGridViewTextBoxColumn.DataPropertyName = "RequestWorkDt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.requestWorkDtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.requestWorkDtDataGridViewTextBoxColumn.HeaderText = "Дата (удалить)";
            this.requestWorkDtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.requestWorkDtDataGridViewTextBoxColumn.Name = "requestWorkDtDataGridViewTextBoxColumn";
            this.requestWorkDtDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestWorkDtDataGridViewTextBoxColumn.Visible = false;
            this.requestWorkDtDataGridViewTextBoxColumn.Width = 150;
            // 
            // workDataGridViewTextBoxColumn
            // 
            this.workDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workDataGridViewTextBoxColumn.DataPropertyName = "Work";
            this.workDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.workDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.workDataGridViewTextBoxColumn.Name = "workDataGridViewTextBoxColumn";
            this.workDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workPriceDataGridViewTextBoxColumn
            // 
            this.workPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.workPriceDataGridViewTextBoxColumn.DataPropertyName = "WorkPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "-";
            this.workPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.workPriceDataGridViewTextBoxColumn.HeaderText = "Стоимость услуги";
            this.workPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.workPriceDataGridViewTextBoxColumn.Name = "workPriceDataGridViewTextBoxColumn";
            this.workPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.workPriceDataGridViewTextBoxColumn.Width = 113;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Врач (скрыть)";
            this.employeeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeDataGridViewTextBoxColumn.Visible = false;
            this.employeeDataGridViewTextBoxColumn.Width = 94;
            // 
            // spareDataGridViewTextBoxColumn
            // 
            this.spareDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.spareDataGridViewTextBoxColumn.DataPropertyName = "Spare";
            dataGridViewCellStyle5.NullValue = "-";
            this.spareDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.spareDataGridViewTextBoxColumn.HeaderText = "Расходник";
            this.spareDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.spareDataGridViewTextBoxColumn.Name = "spareDataGridViewTextBoxColumn";
            this.spareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Цена
            // 
            this.Цена.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Цена.DataPropertyName = "SparePrice";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "-";
            this.Цена.DefaultCellStyle = dataGridViewCellStyle6;
            this.Цена.HeaderText = "Стоимость расходника";
            this.Цена.MinimumWidth = 8;
            this.Цена.Name = "Цена";
            this.Цена.ReadOnly = true;
            this.Цена.Width = 136;
            // 
            // Итого
            // 
            this.Итого.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Итого.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Итого.DefaultCellStyle = dataGridViewCellStyle7;
            this.Итого.HeaderText = "Итого";
            this.Итого.MinimumWidth = 8;
            this.Итого.Name = "Итого";
            this.Итого.ReadOnly = true;
            this.Итого.Width = 62;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "";
            this.EditColumn.Image = global::MIS.Properties.Resources.edit_16;
            this.EditColumn.MinimumWidth = 8;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Width = 30;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::MIS.Properties.Resources.delete_16;
            this.DeleteColumn.MinimumWidth = 8;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Width = 30;
            // 
            // RequestWorksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 394);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView);
            this.Name = "RequestWorksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.SpareParametersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestWorkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource requestWorkBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestWorkDtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Итого;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
    }
}