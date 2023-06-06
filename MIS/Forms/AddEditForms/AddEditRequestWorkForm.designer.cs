namespace MIS.Forms.AddEditForms
{
    partial class AddEditRequestWorkForm
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
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.linkLabelDeleteSpare = new System.Windows.Forms.LinkLabel();
            this.linkLabelSearchSpare = new System.Windows.Forms.LinkLabel();
            this.textBoxSpare = new System.Windows.Forms.TextBox();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.comboBoxWorks = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddEdit.FlatAppearance.BorderSize = 2;
            this.buttonAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddEdit.Location = new System.Drawing.Point(12, 138);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(153, 34);
            this.buttonAddEdit.TabIndex = 3;
            this.buttonAddEdit.UseVisualStyleBackColor = false;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatAppearance.BorderSize = 2;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = global::MIS.Properties.Resources.delete_16;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.Location = new System.Drawing.Point(237, 138);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(153, 34);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // linkLabelDeleteSpare
            // 
            this.linkLabelDeleteSpare.AutoSize = true;
            this.linkLabelDeleteSpare.Location = new System.Drawing.Point(327, 68);
            this.linkLabelDeleteSpare.Name = "linkLabelDeleteSpare";
            this.linkLabelDeleteSpare.Size = new System.Drawing.Size(57, 15);
            this.linkLabelDeleteSpare.TabIndex = 14;
            this.linkLabelDeleteSpare.TabStop = true;
            this.linkLabelDeleteSpare.Text = "Удалить";
            this.linkLabelDeleteSpare.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDeleteSpare_LinkClicked);
            // 
            // linkLabelSearchSpare
            // 
            this.linkLabelSearchSpare.AutoSize = true;
            this.linkLabelSearchSpare.Location = new System.Drawing.Point(18, 68);
            this.linkLabelSearchSpare.Name = "linkLabelSearchSpare";
            this.linkLabelSearchSpare.Size = new System.Drawing.Size(112, 15);
            this.linkLabelSearchSpare.TabIndex = 13;
            this.linkLabelSearchSpare.TabStop = true;
            this.linkLabelSearchSpare.Text = "Поиск расходника";
            this.linkLabelSearchSpare.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSearchSpare_LinkClicked);
            // 
            // textBoxSpare
            // 
            this.textBoxSpare.Location = new System.Drawing.Point(18, 86);
            this.textBoxSpare.Name = "textBoxSpare";
            this.textBoxSpare.ReadOnly = true;
            this.textBoxSpare.Size = new System.Drawing.Size(366, 21);
            this.textBoxSpare.TabIndex = 12;
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(305, 111);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(35, 23);
            this.comboBoxEmployees.TabIndex = 10;
            this.comboBoxEmployees.Visible = false;
            // 
            // comboBoxWorks
            // 
            this.comboBoxWorks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorks.FormattingEnabled = true;
            this.comboBoxWorks.Location = new System.Drawing.Point(18, 29);
            this.comboBoxWorks.Name = "comboBoxWorks";
            this.comboBoxWorks.Size = new System.Drawing.Size(366, 23);
            this.comboBoxWorks.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сотрудник (скрыть)";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Услуга";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(346, 113);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(38, 21);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата (скрыть)";
            this.label3.Visible = false;
            // 
            // AddEditRequestWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(402, 184);
            this.Controls.Add(this.linkLabelDeleteSpare);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxSpare);
            this.Controls.Add(this.linkLabelSearchSpare);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxWorks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditRequestWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.LinkLabel linkLabelSearchSpare;
        private System.Windows.Forms.TextBox textBoxSpare;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.ComboBox comboBoxWorks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelDeleteSpare;
    }
}