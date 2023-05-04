﻿namespace Timesheets_System.Views
{
    partial class frmDepartment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtvgDepartment = new System.Windows.Forms.DataGridView();
            this.Column_TeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbDepartmentID = new System.Windows.Forms.TextBox();
            this.txbDepartmentName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvgDepartment)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtvgDepartment);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 633);
            this.panel1.TabIndex = 0;
            // 
            // dtvgDepartment
            // 
            this.dtvgDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvgDepartment.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtvgDepartment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvgDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvgDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_TeamID,
            this.Column_TeamName,
            this.Column_DepartmentID});
            this.dtvgDepartment.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtvgDepartment.Location = new System.Drawing.Point(3, 0);
            this.dtvgDepartment.Name = "dtvgDepartment";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvgDepartment.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtvgDepartment.RowHeadersVisible = false;
            this.dtvgDepartment.RowHeadersWidth = 51;
            this.dtvgDepartment.RowTemplate.Height = 24;
            this.dtvgDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvgDepartment.Size = new System.Drawing.Size(538, 633);
            this.dtvgDepartment.TabIndex = 2;
            // 
            // Column_TeamID
            // 
            this.Column_TeamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_TeamID.DataPropertyName = "Department_id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_TeamID.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_TeamID.FillWeight = 188.1243F;
            this.Column_TeamID.HeaderText = "Mã bộ phận";
            this.Column_TeamID.MinimumWidth = 6;
            this.Column_TeamID.Name = "Column_TeamID";
            this.Column_TeamID.ReadOnly = true;
            this.Column_TeamID.Width = 90;
            // 
            // Column_TeamName
            // 
            this.Column_TeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_TeamName.DataPropertyName = "Department_name";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_TeamName.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_TeamName.FillWeight = 48.99667F;
            this.Column_TeamName.HeaderText = "Tên bộ phận";
            this.Column_TeamName.MinimumWidth = 6;
            this.Column_TeamName.Name = "Column_TeamName";
            this.Column_TeamName.ReadOnly = true;
            this.Column_TeamName.Width = 150;
            // 
            // Column_DepartmentID
            // 
            this.Column_DepartmentID.DataPropertyName = "Descriptions";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_DepartmentID.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column_DepartmentID.FillWeight = 62.87906F;
            this.Column_DepartmentID.HeaderText = "Mô tả";
            this.Column_DepartmentID.MinimumWidth = 6;
            this.Column_DepartmentID.Name = "Column_DepartmentID";
            this.Column_DepartmentID.ReadOnly = true;
            // 
            // txbDepartmentID
            // 
            this.txbDepartmentID.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepartmentID.Location = new System.Drawing.Point(182, 40);
            this.txbDepartmentID.MaxLength = 20;
            this.txbDepartmentID.Name = "txbDepartmentID";
            this.txbDepartmentID.Size = new System.Drawing.Size(237, 31);
            this.txbDepartmentID.TabIndex = 3;
            // 
            // txbDepartmentName
            // 
            this.txbDepartmentName.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDepartmentName.Location = new System.Drawing.Point(182, 111);
            this.txbDepartmentName.MaxLength = 50;
            this.txbDepartmentName.Name = "txbDepartmentName";
            this.txbDepartmentName.Size = new System.Drawing.Size(237, 31);
            this.txbDepartmentName.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txbDescription);
            this.panel3.Controls.Add(this.txbDepartmentName);
            this.panel3.Controls.Add(this.txbDepartmentID);
            this.panel3.Location = new System.Drawing.Point(552, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 258);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên bộ phận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã bộ phận";
            // 
            // txbDescription
            // 
            this.txbDescription.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescription.Location = new System.Drawing.Point(182, 178);
            this.txbDescription.MaxLength = 100;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(237, 31);
            this.txbDescription.TabIndex = 5;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(865, 350);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(108, 43);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(715, 350);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(108, 43);
            this.btEdit.TabIndex = 11;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click_1);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(567, 350);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(108, 43);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 639);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách bộ phận";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvgDepartment)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtvgDepartment;
        private System.Windows.Forms.TextBox txbDepartmentID;
        private System.Windows.Forms.TextBox txbDepartmentName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TeamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DepartmentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}