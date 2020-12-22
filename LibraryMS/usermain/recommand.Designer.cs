namespace LibraryMS.usermain
{
    partial class recommand
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
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.yes = new Sunny.UI.UIButton();
            this.reason = new Sunny.UI.UIRichTextBox();
            this.publish = new Sunny.UI.UITextBox();
            this.author = new Sunny.UI.UITextBox();
            this.type = new Sunny.UI.UITextBox();
            this.name = new Sunny.UI.UITextBox();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(320, 50);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 35);
            this.uiTabControl1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 30);
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.Padding = new System.Drawing.Point(600, 300);
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(747, 457);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControl1.TabIndex = 0;
            this.uiTabControl1.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTabControl1.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.tabPage1.Controls.Add(this.uiDataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(0, 50);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(747, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新书通报";
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.RowTemplate.Height = 29;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowGridLine = true;
            this.uiDataGridView1.Size = new System.Drawing.Size(747, 407);
            this.uiDataGridView1.Style = Sunny.UI.UIStyle.Custom;
            this.uiDataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.tabPage2.Controls.Add(this.yes);
            this.tabPage2.Controls.Add(this.reason);
            this.tabPage2.Controls.Add(this.publish);
            this.tabPage2.Controls.Add(this.author);
            this.tabPage2.Controls.Add(this.type);
            this.tabPage2.Controls.Add(this.name);
            this.tabPage2.Location = new System.Drawing.Point(0, 50);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(747, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图书荐购";
            // 
            // yes
            // 
            this.yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.yes.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.yes.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.yes.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.yes.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.yes.Location = new System.Drawing.Point(265, 328);
            this.yes.MinimumSize = new System.Drawing.Size(1, 1);
            this.yes.Name = "yes";
            this.yes.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.yes.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.yes.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.yes.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.yes.Size = new System.Drawing.Size(100, 35);
            this.yes.Style = Sunny.UI.UIStyle.Custom;
            this.yes.TabIndex = 37;
            this.yes.Text = "确认";
            this.yes.Click += new System.EventHandler(this.yes_Click_1);
            // 
            // reason
            // 
            this.reason.AutoWordSelection = true;
            this.reason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reason.FillColor = System.Drawing.Color.White;
            this.reason.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.reason.Location = new System.Drawing.Point(265, 203);
            this.reason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reason.MinimumSize = new System.Drawing.Size(1, 1);
            this.reason.Name = "reason";
            this.reason.Padding = new System.Windows.Forms.Padding(2);
            this.reason.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.reason.Size = new System.Drawing.Size(216, 116);
            this.reason.Style = Sunny.UI.UIStyle.Orange;
            this.reason.StyleCustomMode = true;
            this.reason.TabIndex = 36;
            this.reason.Text = " 推荐理由";
            // 
            // publish
            // 
            this.publish.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.publish.FillColor = System.Drawing.Color.White;
            this.publish.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.publish.Location = new System.Drawing.Point(265, 163);
            this.publish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.publish.Maximum = 2147483647D;
            this.publish.Minimum = -2147483648D;
            this.publish.MinimumSize = new System.Drawing.Size(1, 1);
            this.publish.Name = "publish";
            this.publish.Padding = new System.Windows.Forms.Padding(5);
            this.publish.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.publish.Size = new System.Drawing.Size(150, 30);
            this.publish.Style = Sunny.UI.UIStyle.Custom;
            this.publish.TabIndex = 35;
            this.publish.Watermark = "出版社";
            // 
            // author
            // 
            this.author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.author.FillColor = System.Drawing.Color.White;
            this.author.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.author.Location = new System.Drawing.Point(265, 83);
            this.author.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.author.Maximum = 2147483647D;
            this.author.Minimum = -2147483648D;
            this.author.MinimumSize = new System.Drawing.Size(1, 1);
            this.author.Name = "author";
            this.author.Padding = new System.Windows.Forms.Padding(5);
            this.author.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.author.Size = new System.Drawing.Size(150, 30);
            this.author.Style = Sunny.UI.UIStyle.Custom;
            this.author.TabIndex = 34;
            this.author.Watermark = "作者";
            // 
            // type
            // 
            this.type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.type.FillColor = System.Drawing.Color.White;
            this.type.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type.Location = new System.Drawing.Point(265, 123);
            this.type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.type.Maximum = 2147483647D;
            this.type.Minimum = -2147483648D;
            this.type.MinimumSize = new System.Drawing.Size(1, 1);
            this.type.Name = "type";
            this.type.Padding = new System.Windows.Forms.Padding(5);
            this.type.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.type.Size = new System.Drawing.Size(150, 30);
            this.type.Style = Sunny.UI.UIStyle.Custom;
            this.type.TabIndex = 33;
            this.type.Watermark = "图书类型";
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.FillColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(265, 43);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Maximum = 2147483647D;
            this.name.Minimum = -2147483648D;
            this.name.MinimumSize = new System.Drawing.Size(1, 1);
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(5);
            this.name.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.name.Size = new System.Drawing.Size(150, 30);
            this.name.Style = Sunny.UI.UIStyle.Custom;
            this.name.TabIndex = 32;
            this.name.Watermark = "图书名";
            // 
            // recommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(747, 492);
            this.Controls.Add(this.uiTabControl1);
            this.Name = "recommand";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "读者荐购";
            this.Load += new System.EventHandler(this.recommand_Load);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIButton yes;
        private Sunny.UI.UIRichTextBox reason;
        private Sunny.UI.UITextBox publish;
        private Sunny.UI.UITextBox author;
        private Sunny.UI.UITextBox type;
        private Sunny.UI.UITextBox name;
        private Sunny.UI.UIDataGridView uiDataGridView1;
    }
}