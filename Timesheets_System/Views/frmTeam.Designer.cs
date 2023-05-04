﻿namespace Timesheets_System.Views
{
    partial class frmTeam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtvgTeam = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbDepartmentID = new System.Windows.Forms.ComboBox();
            this.txbTeamName = new System.Windows.Forms.TextBox();
            this.txbTeamId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.Column_TeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvgTeam)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtvgTeam);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 636);
            this.panel1.TabIndex = 0;
            // 
            // dtvgTeam
            // 
            this.dtvgTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvgTeam.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtvgTeam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvgTeam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtvgTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvgTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_TeamID,
            this.Column_TeamName,
            this.Column_DepartmentID});
            this.dtvgTeam.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtvgTeam.Location = new System.Drawing.Point(0, 0);
            this.dtvgTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtvgTeam.Name = "dtvgTeam";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvgTeam.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtvgTeam.RowHeadersVisible = false;
            this.dtvgTeam.RowHeadersWidth = 51;
            this.dtvgTeam.RowTemplate.Height = 24;
            this.dtvgTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvgTeam.Size = new System.Drawing.Size(539, 633);
            this.dtvgTeam.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbDepartmentID);
            this.panel3.Controls.Add(this.txbTeamName);
            this.panel3.Controls.Add(this.txbTeamId);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Location = new System.Drawing.Point(552, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 258);
            this.panel3.TabIndex = 3;
            // 
            // cbDepartmentID
            // 
            this.cbDepartmentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartmentID.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartmentID.FormattingEnabled = true;
            this.cbDepartmentID.Location = new System.Drawing.Point(181, 183);
            this.cbDepartmentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDepartmentID.Name = "cbDepartmentID";
            this.cbDepartmentID.Size = new System.Drawing.Size(237, 33);
            this.cbDepartmentID.TabIndex = 5;
            // 
            // txbTeamName
            // 
            this.txbTeamName.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTeamName.Location = new System.Drawing.Point(181, 111);
            this.txbTeamName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTeamName.Name = "txbTeamName";
            this.txbTeamName.Size = new System.Drawing.Size(237, 31);
            this.txbTeamName.TabIndex = 4;
            // 
            // txbTeamId
            // 
            this.txbTeamId.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTeamId.Location = new System.Drawing.Point(181, 39);
            this.txbTeamId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTeamId.Name = "txbTeamId";
            this.txbTeamId.Size = new System.Drawing.Size(237, 31);
            this.txbTeamId.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Mã Team";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 118);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(125, 24);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Tên Team";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(15, 186);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(141, 24);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Bộ phận";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(863, 350);
            this.btDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(108, 43);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(721, 350);
            this.btEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(107, 43);
            this.btEdit.TabIndex = 8;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAdd.Location = new System.Drawing.Point(577, 350);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(107, 43);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Column_TeamID
            // 
            this.Column_TeamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_TeamID.DataPropertyName = "Team_id";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_TeamID.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column_TeamID.FillWeight = 188.1243F;
            this.Column_TeamID.HeaderText = "Mã Team";
            this.Column_TeamID.MinimumWidth = 6;
            this.Column_TeamID.Name = "Column_TeamID";
            this.Column_TeamID.ReadOnly = true;
            this.Column_TeamID.Width = 90;
            // 
            // Column_TeamName
            // 
            this.Column_TeamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_TeamName.DataPropertyName = "Team_name";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_TeamName.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column_TeamName.FillWeight = 48.99667F;
            this.Column_TeamName.HeaderText = "Tên Team";
            this.Column_TeamName.MinimumWidth = 6;
            this.Column_TeamName.Name = "Column_TeamName";
            this.Column_TeamName.ReadOnly = true;
            this.Column_TeamName.Width = 170;
            // 
            // Column_DepartmentID
            // 
            this.Column_DepartmentID.DataPropertyName = "Department_name";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column_DepartmentID.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column_DepartmentID.FillWeight = 62.87906F;
            this.Column_DepartmentID.HeaderText = "Tên bộ phận";
            this.Column_DepartmentID.MinimumWidth = 6;
            this.Column_DepartmentID.Name = "Column_DepartmentID";
            this.Column_DepartmentID.ReadOnly = true;
            // 
            // frmTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 639);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "git ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvgTeam)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtvgTeam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbTeamName;
        private System.Windows.Forms.TextBox txbTeamId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox cbDepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TeamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DepartmentID;
    }
}