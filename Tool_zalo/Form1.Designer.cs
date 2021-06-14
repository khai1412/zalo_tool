
namespace Tool_zalo
{
    partial class Form1
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
            this.dtg_NoiDung = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_Ket_ban = new System.Windows.Forms.CheckBox();
            this.cb_Nhan_Tin = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_Sdt = new System.Windows.Forms.TextBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tb_NoiDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_NoiDung
            // 
            this.dtg_NoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_NoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtg_NoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtg_NoiDung.Location = new System.Drawing.Point(0, 0);
            this.dtg_NoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_NoiDung.Name = "dtg_NoiDung";
            this.dtg_NoiDung.RowHeadersWidth = 82;
            this.dtg_NoiDung.RowTemplate.Height = 24;
            this.dtg_NoiDung.Size = new System.Drawing.Size(1028, 230);
            this.dtg_NoiDung.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.button1.Location = new System.Drawing.Point(0, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 171);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_Ket_ban
            // 
            this.cb_Ket_ban.AutoSize = true;
            this.cb_Ket_ban.Location = new System.Drawing.Point(891, 294);
            this.cb_Ket_ban.Name = "cb_Ket_ban";
            this.cb_Ket_ban.Size = new System.Drawing.Size(116, 21);
            this.cb_Ket_ban.TabIndex = 2;
            this.cb_Ket_ban.Text = "kết bạn tất cả";
            this.cb_Ket_ban.UseVisualStyleBackColor = true;
            // 
            // cb_Nhan_Tin
            // 
            this.cb_Nhan_Tin.AutoSize = true;
            this.cb_Nhan_Tin.Location = new System.Drawing.Point(891, 321);
            this.cb_Nhan_Tin.Name = "cb_Nhan_Tin";
            this.cb_Nhan_Tin.Size = new System.Drawing.Size(120, 21);
            this.cb_Nhan_Tin.TabIndex = 3;
            this.cb_Nhan_Tin.Text = "nhắn tin tất cả";
            this.cb_Nhan_Tin.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(891, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add thông tin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_Sdt
            // 
            this.tb_Sdt.Location = new System.Drawing.Point(280, 255);
            this.tb_Sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Sdt.Multiline = true;
            this.tb_Sdt.Name = "tb_Sdt";
            this.tb_Sdt.Size = new System.Drawing.Size(266, 172);
            this.tb_Sdt.TabIndex = 12;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số điện thoại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nội dung tin nhắn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kết bạn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nhắn tin";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // tb_NoiDung
            // 
            this.tb_NoiDung.Location = new System.Drawing.Point(552, 255);
            this.tb_NoiDung.Multiline = true;
            this.tb_NoiDung.Name = "tb_NoiDung";
            this.tb_NoiDung.Size = new System.Drawing.Size(333, 171);
            this.tb_NoiDung.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nhập số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nhập nội dung tin nhắn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_NoiDung);
            this.Controls.Add(this.tb_Sdt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_Nhan_Tin);
            this.Controls.Add(this.cb_Ket_ban);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtg_NoiDung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_NoiDung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_Ket_ban;
        private System.Windows.Forms.CheckBox cb_Nhan_Tin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.TextBox tb_NoiDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

