﻿namespace LibraryMS.usermain
{
    partial class borrowbook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search = new Sunny.UI.UIButton();
            this.mainGV = new Sunny.UI.UIDataGridView();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.bookname = new Sunny.UI.UITextBox();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.bookcid = new Sunny.UI.UITextBox();
            this.borrow = new Sunny.UI.UIButton();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.bookcase = new Sunny.UI.UIDataGridView();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.bookid = new Sunny.UI.UITextBox();
            this.bookcname = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainGV)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookcase)).BeginInit();
            this.uiPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.search.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.search.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.search.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.search.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.search.Location = new System.Drawing.Point(896, 3);
            this.search.MinimumSize = new System.Drawing.Size(1, 1);
            this.search.Name = "search";
            this.search.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.search.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.search.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.search.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.search.Size = new System.Drawing.Size(112, 60);
            this.search.Style = Sunny.UI.UIStyle.Orange;
            this.search.TabIndex = 1;
            this.search.Text = "查找";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // mainGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.mainGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mainGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainGV.BackgroundColor = System.Drawing.Color.White;
            this.mainGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mainGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.mainGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGV.EnableHeadersVisualStyles = false;
            this.mainGV.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.mainGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.mainGV.Location = new System.Drawing.Point(0, 0);
            this.mainGV.Name = "mainGV";
            this.mainGV.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.mainGV.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.mainGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.mainGV.RowTemplate.Height = 29;
            this.mainGV.SelectedIndex = -1;
            this.mainGV.ShowGridLine = true;
            this.mainGV.Size = new System.Drawing.Size(1011, 361);
            this.mainGV.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.mainGV.Style = Sunny.UI.UIStyle.Custom;
            this.mainGV.StyleCustomMode = true;
            this.mainGV.TabIndex = 2;
            this.mainGV.SelectIndexChange += new Sunny.UI.UIDataGridView.OnSelectIndexChange(this.mainGV_SelectIndexChange);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.bookname);
            this.uiPanel1.Controls.Add(this.search);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel1.Size = new System.Drawing.Size(1011, 65);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel1.TabIndex = 3;
            this.uiPanel1.Text = null;
            // 
            // bookname
            // 
            this.bookname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookname.FillColor = System.Drawing.Color.White;
            this.bookname.Font = new System.Drawing.Font("楷体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookname.Location = new System.Drawing.Point(4, 2);
            this.bookname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookname.Maximum = 2147483647D;
            this.bookname.Minimum = -2147483648D;
            this.bookname.MinimumSize = new System.Drawing.Size(1, 1);
            this.bookname.Name = "bookname";
            this.bookname.Padding = new System.Windows.Forms.Padding(5);
            this.bookname.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.bookname.Size = new System.Drawing.Size(885, 76);
            this.bookname.Style = Sunny.UI.UIStyle.Orange;
            this.bookname.TabIndex = 2;
            this.bookname.Watermark = "           请输入书名";
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.mainGV);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 100);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel2.Size = new System.Drawing.Size(1011, 361);
            this.uiPanel2.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel2.TabIndex = 4;
            this.uiPanel2.Text = null;
            // 
            // bookcid
            // 
            this.bookcid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookcid.FillColor = System.Drawing.Color.White;
            this.bookcid.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bookcid.Location = new System.Drawing.Point(4, 13);
            this.bookcid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookcid.Maximum = 2147483647D;
            this.bookcid.Minimum = -2147483648D;
            this.bookcid.MinimumSize = new System.Drawing.Size(1, 1);
            this.bookcid.Name = "bookcid";
            this.bookcid.Padding = new System.Windows.Forms.Padding(5);
            this.bookcid.ReadOnly = true;
            this.bookcid.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.bookcid.Size = new System.Drawing.Size(133, 34);
            this.bookcid.Style = Sunny.UI.UIStyle.Orange;
            this.bookcid.TabIndex = 7;
            // 
            // borrow
            // 
            this.borrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.borrow.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.borrow.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.borrow.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.borrow.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.borrow.Location = new System.Drawing.Point(23, 151);
            this.borrow.MinimumSize = new System.Drawing.Size(1, 1);
            this.borrow.Name = "borrow";
            this.borrow.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.borrow.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.borrow.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.borrow.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.borrow.Size = new System.Drawing.Size(77, 29);
            this.borrow.Style = Sunny.UI.UIStyle.Orange;
            this.borrow.TabIndex = 8;
            this.borrow.Text = "借阅";
            this.borrow.Click += new System.EventHandler(this.borrow_Click);
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.bookcase);
            this.uiPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiPanel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(4, 462);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel3.Size = new System.Drawing.Size(642, 183);
            this.uiPanel3.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel3.TabIndex = 10;
            this.uiPanel3.Text = null;
            // 
            // bookcase
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.bookcase.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bookcase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookcase.BackgroundColor = System.Drawing.Color.White;
            this.bookcase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookcase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bookcase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookcase.DefaultCellStyle = dataGridViewCellStyle7;
            this.bookcase.EnableHeadersVisualStyles = false;
            this.bookcase.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bookcase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.bookcase.Location = new System.Drawing.Point(0, 0);
            this.bookcase.Name = "bookcase";
            this.bookcase.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.bookcase.RowHeadersWidth = 100;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookcase.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.bookcase.RowTemplate.Height = 29;
            this.bookcase.SelectedIndex = -1;
            this.bookcase.ShowGridLine = true;
            this.bookcase.Size = new System.Drawing.Size(639, 183);
            this.bookcase.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.bookcase.Style = Sunny.UI.UIStyle.Orange;
            this.bookcase.TabIndex = 9;
            this.bookcase.SelectIndexChange += new Sunny.UI.UIDataGridView.OnSelectIndexChange(this.bookcsae_SelectIndexChange);
            // 
            // uiPanel4
            // 
            this.uiPanel4.AutoSize = true;
            this.uiPanel4.Controls.Add(this.bookid);
            this.uiPanel4.Controls.Add(this.bookcname);
            this.uiPanel4.Controls.Add(this.bookcid);
            this.uiPanel4.Controls.Add(this.borrow);
            this.uiPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiPanel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(744, 462);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiPanel4.Size = new System.Drawing.Size(186, 183);
            this.uiPanel4.Style = Sunny.UI.UIStyle.Orange;
            this.uiPanel4.TabIndex = 11;
            this.uiPanel4.Text = null;
            // 
            // bookid
            // 
            this.bookid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookid.FillColor = System.Drawing.Color.White;
            this.bookid.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bookid.Location = new System.Drawing.Point(4, 52);
            this.bookid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookid.Maximum = 2147483647D;
            this.bookid.Minimum = -2147483648D;
            this.bookid.MinimumSize = new System.Drawing.Size(1, 1);
            this.bookid.Name = "bookid";
            this.bookid.Padding = new System.Windows.Forms.Padding(5);
            this.bookid.ReadOnly = true;
            this.bookid.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.bookid.Size = new System.Drawing.Size(133, 34);
            this.bookid.Style = Sunny.UI.UIStyle.Orange;
            this.bookid.TabIndex = 10;
            // 
            // bookcname
            // 
            this.bookcname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookcname.FillColor = System.Drawing.Color.White;
            this.bookcname.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bookcname.Location = new System.Drawing.Point(4, 91);
            this.bookcname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookcname.Maximum = 2147483647D;
            this.bookcname.Minimum = -2147483648D;
            this.bookcname.MinimumSize = new System.Drawing.Size(1, 1);
            this.bookcname.Name = "bookcname";
            this.bookcname.Padding = new System.Windows.Forms.Padding(5);
            this.bookcname.ReadOnly = true;
            this.bookcname.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.bookcname.Size = new System.Drawing.Size(133, 34);
            this.bookcname.Style = Sunny.UI.UIStyle.Orange;
            this.bookcname.TabIndex = 9;
            // 
            // borrowbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1011, 650);
            this.Controls.Add(this.uiPanel4);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Name = "borrowbook";
            this.Text = "borrowbook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.borrowbook_FormClosing);
            this.Load += new System.EventHandler(this.borrowbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGV)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookcase)).EndInit();
            this.uiPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIButton search;
        private Sunny.UI.UIDataGridView mainGV;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UITextBox bookname;
        private Sunny.UI.UITextBox bookcid;
        private Sunny.UI.UIButton borrow;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UITextBox bookcname;
        private Sunny.UI.UITextBox bookid;
        private Sunny.UI.UIDataGridView bookcase;
    }
}