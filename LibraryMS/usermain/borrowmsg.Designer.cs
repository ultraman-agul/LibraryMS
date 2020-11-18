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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.borrowmsgGV = new Sunny.UI.UIDataGridView();
            this.bookid = new Sunny.UI.UITextBox();
            this.bookname = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.borrowmsgGV)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowmsgGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.borrowmsgGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.borrowmsgGV.BackgroundColor = System.Drawing.Color.White;
            this.borrowmsgGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.borrowmsgGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.borrowmsgGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(207)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.borrowmsgGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.borrowmsgGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.borrowmsgGV.EnableHeadersVisualStyles = false;
            this.borrowmsgGV.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.borrowmsgGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.borrowmsgGV.Location = new System.Drawing.Point(0, 35);
            this.borrowmsgGV.Name = "borrowmsgGV";
            this.borrowmsgGV.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.borrowmsgGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            this.bookid.FillColor = System.Drawing.Color.White;
            this.bookid.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bookid.Location = new System.Drawing.Point(62, 283);
            this.bookid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookid.Maximum = 2147483647D;
            this.bookid.Minimum = -2147483648D;
            this.bookid.MinimumSize = new System.Drawing.Size(1, 1);
            this.bookid.Name = "bookid";
            this.bookid.Padding = new System.Windows.Forms.Padding(5);
            this.bookid.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.bookid.Size = new System.Drawing.Size(150, 29);
            this.bookid.Style = Sunny.UI.UIStyle.Orange;
            this.bookid.TabIndex = 1;
            // 
            // bookname
            // 
            this.bookname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookname.FillColor = System.Drawing.Color.White;
            this.bookname.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bookname.Location = new System.Drawing.Point(62, 333);
            this.bookname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bookname.Maximum = 2147483647D;
            this.bookname.Minimum = -2147483648D;
            this.bookname.MinimumSize = new System.Drawing.Size(1, 1);
            this.bookname.Name = "bookname";
            this.bookname.Padding = new System.Windows.Forms.Padding(5);
            this.bookname.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.bookname.Size = new System.Drawing.Size(150, 29);
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
            this.uiButton1.Location = new System.Drawing.Point(86, 370);
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
            // borrowmsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 441);
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
    }
}