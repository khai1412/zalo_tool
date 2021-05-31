
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
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.dtg_NoiDung.Size = new System.Drawing.Size(884, 230);
            this.dtg_NoiDung.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.button1.Location = new System.Drawing.Point(0, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(742, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_Ket_ban
            // 
            this.cb_Ket_ban.AutoSize = true;
            this.cb_Ket_ban.Location = new System.Drawing.Point(748, 274);
            this.cb_Ket_ban.Name = "cb_Ket_ban";
            this.cb_Ket_ban.Size = new System.Drawing.Size(116, 21);
            this.cb_Ket_ban.TabIndex = 2;
            this.cb_Ket_ban.Text = "kết bạn tất cả";
            this.cb_Ket_ban.UseVisualStyleBackColor = true;
            // 
            // cb_Nhan_Tin
            // 
            this.cb_Nhan_Tin.AutoSize = true;
            this.cb_Nhan_Tin.Location = new System.Drawing.Point(748, 295);
            this.cb_Nhan_Tin.Name = "cb_Nhan_Tin";
            this.cb_Nhan_Tin.Size = new System.Drawing.Size(120, 21);
            this.cb_Nhan_Tin.TabIndex = 3;
            this.cb_Nhan_Tin.Text = "nhắn tin tất cả";
            this.cb_Nhan_Tin.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(748, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add thông tin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số điện thoại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nội dung tin nhắn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kết bạn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nhắn tin";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 325);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}

