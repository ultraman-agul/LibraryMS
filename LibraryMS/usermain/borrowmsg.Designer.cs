namespace LibraryMS.usermain
{
    partial class borrowmsg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.borrowmsgGV = new Sunny.UI.UIDataGridView();
            this.bookid = new Sunny.UI.UITextBox();
            this.bookname = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.caseid = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.borrowmsgGV)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowmsgGV
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.borrowmsgGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.borrowmsgGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.borrowmsgGV.BackgroundColor = System.Drawing.Color.White;
            this.borrowmsgGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.borrowmsgGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.borrowmsgGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.borrowmsgGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.borrowmsgGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.borrowmsgGV.EnableHeadersVisualStyles = false;
            this.borrowmsgGV.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.borrowmsgGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.borrowmsgGV.Location = new System.Drawing.Point(0, 35);
            this.borrowmsgGV.Name = "borrowmsgGV";
            this.borrowmsgGV.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.borrowmsgGV.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.borrowmsgGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.borrowmsgGV.RowTemplate.Height = 29;
            this.borrowmsgGV.SelectedIndex = -1;
            this.borrowmsgGV.ShowGridLine = true;
            this.borrowmsgGV.Size = new System.Drawing.Size(835, 240);
            this.borrowmsgGV.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.borrowmsgGV.Style = Sunny.UI.UIStyle.Orange;
            this.borrowmsgGV.TabIndex = 0;
            this.borrowmsgGV.SelectIndexChange += new Sunny.UI.UIDataGridView.OnSelectIndexChange(this.uiDataGridView1_SelectIndexChange);
            // 
            // bookid
            // 
            this.bookid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookid.Enabled = false;
            this.bookid.FillColor = System.Drawing.Color.White;
            this.bookid.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bookid.Location = new System.Drawing.Point(62, 322);
            this.bookid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookid.Maximum = 2147483647D;
            this.bookid.Minimum = -2147483648D;
            this.bookid.MinimumSize = new System.Drawing.Size(1, 1);
            this.bookid.Name = "bookid";
            this.bookid.Padding = new System.Windows.Forms.Padding(5);
            this.bookid.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.bookid.Size = new System.Drawing.Size(150, 34);
            this.bookid.Style = Sunny.UI.UIStyle.Orange;
            this.bookid.TabIndex = 1;
            // 
            // bookname
            // 
            this.bookname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookname.Enabled = false;
            this.bookname.FillColor = System.Drawing.Color.White;
            this.bookname.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bookname.Location = new System.Drawing.Point(62, 366);
            this.bookname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookname.Maximum = 2147483647D;
            this.bookname.Minimum = -2147483648D;
            this.bookname.MinimumSize = new System.Drawing.Size(1, 1);
            this.bookname.Name = "bookname";
            this.bookname.Padding = new System.Windows.Forms.Padding(5);
            this.bookname.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.bookname.Size = new System.Drawing.Size(150, 34);
            this.bookname.Style = Sunny.UI.UIStyle.Orange;
            this.bookname.TabIndex = 2;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.uiButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.uiButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(81, 403);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.uiButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.uiButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.Orange;
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "归还";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // caseid
            // 
            this.caseid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caseid.Enabled = false;
            this.caseid.FillColor = System.Drawing.Color.White;
            this.caseid.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.caseid.Location = new System.Drawing.Point(62, 283);
            this.caseid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.caseid.Maximum = 2147483647D;
            this.caseid.Minimum = -2147483648D;
            this.caseid.MinimumSize = new System.Drawing.Size(1, 1);
            this.caseid.Name = "caseid";
            this.caseid.Padding = new System.Windows.Forms.Padding(5);
            this.caseid.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.caseid.Size = new System.Drawing.Size(150, 34);
            this.caseid.Style = Sunny.UI.UIStyle.Orange;
            this.caseid.TabIndex = 4;
            // 
            // borrowmsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 441);
            this.Controls.Add(this.caseid);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.borrowmsgGV);
            this.Name = "borrowmsg";
            this.Text = "borrowmsg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.borrowmsg_FormClosing);
            this.Load += new System.EventHandler(this.borrowmsg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowmsgGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView borrowmsgGV;
        private Sunny.UI.UITextBox bookid;
        private Sunny.UI.UITextBox bookname;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox caseid;
    }
}