namespace MIS.Forms.AddEditForms
{
    partial class AddEditRequestForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTechnik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelSearchTechnik = new System.Windows.Forms.LinkLabel();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelSearchClient = new System.Windows.Forms.LinkLabel();
            this.dateTimePickerCreate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerExecution = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabelFaultType = new System.Windows.Forms.LinkLabel();
            this.textBoxFaultType = new System.Windows.Forms.TextBox();
            this.linkLabelStatus = new System.Windows.Forms.LinkLabel();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAnamnesis = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.buttonCancel.Location = new System.Drawing.Point(335, 622);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(153, 43);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddEdit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddEdit.FlatAppearance.BorderSize = 2;
            this.buttonAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddEdit.Location = new System.Drawing.Point(12, 622);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(153, 43);
            this.buttonAddEdit.TabIndex = 9;
            this.buttonAddEdit.UseVisualStyleBackColor = false;
            this.buttonAddEdit.Click += new System.EventHandler(this.buttonAddEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отделение";
            // 
            // textBoxTechnik
            // 
            this.textBoxTechnik.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxTechnik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTechnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTechnik.Location = new System.Drawing.Point(137, 68);
            this.textBoxTechnik.Name = "textBoxTechnik";
            this.textBoxTechnik.ReadOnly = true;
            this.textBoxTechnik.Size = new System.Drawing.Size(342, 20);
            this.textBoxTechnik.TabIndex = 1;
            this.textBoxTechnik.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Жалобы";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDescription.Location = new System.Drawing.Point(12, 252);
            this.textBoxDescription.MaxLength = 1000;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(473, 73);
            this.textBoxDescription.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Диагноз";
            // 
            // linkLabelSearchTechnik
            // 
            this.linkLabelSearchTechnik.AutoSize = true;
            this.linkLabelSearchTechnik.Location = new System.Drawing.Point(437, 50);
            this.linkLabelSearchTechnik.Name = "linkLabelSearchTechnik";
            this.linkLabelSearchTechnik.Size = new System.Drawing.Size(42, 15);
            this.linkLabelSearchTechnik.TabIndex = 2;
            this.linkLabelSearchTechnik.TabStop = true;
            this.linkLabelSearchTechnik.Text = "Поиск";
            this.linkLabelSearchTechnik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSearchTechnik_LinkClicked);
            // 
            // textBoxClient
            // 
            this.textBoxClient.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClient.Location = new System.Drawing.Point(137, 23);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.ReadOnly = true;
            this.textBoxClient.Size = new System.Drawing.Size(342, 20);
            this.textBoxClient.TabIndex = 1;
            this.textBoxClient.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пациент";
            // 
            // linkLabelSearchClient
            // 
            this.linkLabelSearchClient.AutoSize = true;
            this.linkLabelSearchClient.Location = new System.Drawing.Point(437, 5);
            this.linkLabelSearchClient.Name = "linkLabelSearchClient";
            this.linkLabelSearchClient.Size = new System.Drawing.Size(42, 15);
            this.linkLabelSearchClient.TabIndex = 1;
            this.linkLabelSearchClient.TabStop = true;
            this.linkLabelSearchClient.Text = "Поиск";
            this.linkLabelSearchClient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSearchClient_LinkClicked);
            // 
            // dateTimePickerCreate
            // 
            this.dateTimePickerCreate.Location = new System.Drawing.Point(138, 188);
            this.dateTimePickerCreate.Name = "dateTimePickerCreate";
            this.dateTimePickerCreate.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerCreate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата посещения";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSerial.Location = new System.Drawing.Point(357, 188);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(37, 20);
            this.textBoxSerial.TabIndex = 3;
            this.textBoxSerial.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Клинический диагноз";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(400, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Срок";
            this.label7.Visible = false;
            // 
            // dateTimePickerExecution
            // 
            this.dateTimePickerExecution.Location = new System.Drawing.Point(440, 184);
            this.dateTimePickerExecution.Name = "dateTimePickerExecution";
            this.dateTimePickerExecution.Size = new System.Drawing.Size(48, 21);
            this.dateTimePickerExecution.TabIndex = 7;
            this.dateTimePickerExecution.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Вид оплаты";
            // 
            // linkLabelFaultType
            // 
            this.linkLabelFaultType.AutoSize = true;
            this.linkLabelFaultType.Location = new System.Drawing.Point(434, 94);
            this.linkLabelFaultType.Name = "linkLabelFaultType";
            this.linkLabelFaultType.Size = new System.Drawing.Size(42, 15);
            this.linkLabelFaultType.TabIndex = 4;
            this.linkLabelFaultType.TabStop = true;
            this.linkLabelFaultType.Text = "Поиск";
            this.linkLabelFaultType.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFaultType_LinkClicked);
            // 
            // textBoxFaultType
            // 
            this.textBoxFaultType.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFaultType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFaultType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFaultType.Location = new System.Drawing.Point(137, 112);
            this.textBoxFaultType.Name = "textBoxFaultType";
            this.textBoxFaultType.ReadOnly = true;
            this.textBoxFaultType.Size = new System.Drawing.Size(339, 20);
            this.textBoxFaultType.TabIndex = 1;
            this.textBoxFaultType.TabStop = false;
            // 
            // linkLabelStatus
            // 
            this.linkLabelStatus.AutoSize = true;
            this.linkLabelStatus.Location = new System.Drawing.Point(434, 135);
            this.linkLabelStatus.Name = "linkLabelStatus";
            this.linkLabelStatus.Size = new System.Drawing.Size(42, 15);
            this.linkLabelStatus.TabIndex = 5;
            this.linkLabelStatus.TabStop = true;
            this.linkLabelStatus.Text = "Поиск";
            this.linkLabelStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelStatus_LinkClicked);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStatus.Location = new System.Drawing.Point(137, 153);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(339, 20);
            this.textBoxStatus.TabIndex = 1;
            this.textBoxStatus.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Анамнез ";
            // 
            // textBoxAnamnesis
            // 
            this.textBoxAnamnesis.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxAnamnesis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnamnesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnamnesis.Location = new System.Drawing.Point(12, 367);
            this.textBoxAnamnesis.MaxLength = 1000;
            this.textBoxAnamnesis.Multiline = true;
            this.textBoxAnamnesis.Name = "textBoxAnamnesis";
            this.textBoxAnamnesis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAnamnesis.Size = new System.Drawing.Size(473, 87);
            this.textBoxAnamnesis.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 499);
            this.textBox1.MaxLength = 1000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(473, 91);
            this.textBox1.TabIndex = 13;
            // 
            // AddEditRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(500, 677);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxTechnik);
            this.Controls.Add(this.textBoxSerial);
            this.Controls.Add(this.linkLabelSearchTechnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAnamnesis);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.linkLabelStatus);
            this.Controls.Add(this.textBoxFaultType);
            this.Controls.Add(this.linkLabelFaultType);
            this.Controls.Add(this.dateTimePickerExecution);
            this.Controls.Add(this.dateTimePickerCreate);
            this.Controls.Add(this.linkLabelSearchClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.textBoxClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTechnik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelSearchTechnik;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelSearchClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerExecution;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabelFaultType;
        private System.Windows.Forms.TextBox textBoxFaultType;
        private System.Windows.Forms.LinkLabel linkLabelStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAnamnesis;
        private System.Windows.Forms.TextBox textBox1;
    }
}