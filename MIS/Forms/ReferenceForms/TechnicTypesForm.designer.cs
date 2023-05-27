﻿
namespace MIS.Forms.ReferenceForms
{
    partial class TechnicTypesForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.technicTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.technicTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicTypeBindingSource)).BeginInit();
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
            this.technicTypeIDDataGridViewTextBoxColumn,
            this.technicTypeNameDataGridViewTextBoxColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.dataGridView.DataSource = this.technicTypeBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 69);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(443, 299);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // technicTypeBindingSource
            // 
            this.technicTypeBindingSource.DataSource = typeof(MIS.Data.TechnicType);
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
            this.buttonAdd.Size = new System.Drawing.Size(443, 36);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить тип назначения";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // technicTypeIDDataGridViewTextBoxColumn
            // 
            this.technicTypeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.technicTypeIDDataGridViewTextBoxColumn.DataPropertyName = "TechnicType_ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.technicTypeIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.technicTypeIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.technicTypeIDDataGridViewTextBoxColumn.Name = "technicTypeIDDataGridViewTextBoxColumn";
            this.technicTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.technicTypeIDDataGridViewTextBoxColumn.Width = 43;
            // 
            // technicTypeNameDataGridViewTextBoxColumn
            // 
            this.technicTypeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.technicTypeNameDataGridViewTextBoxColumn.DataPropertyName = "TechnicTypeName";
            this.technicTypeNameDataGridViewTextBoxColumn.HeaderText = "Тип назначения";
            this.technicTypeNameDataGridViewTextBoxColumn.Name = "technicTypeNameDataGridViewTextBoxColumn";
            this.technicTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "";
            this.EditColumn.Image = global::MIS.Properties.Resources.edit_16;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Width = 30;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.Image = global::MIS.Properties.Resources.delete_16;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Width = 30;
            // 
            // TechnicTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 380);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView);
            this.Name = "TechnicTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Типы назначения";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource technicTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
    }
}