namespace so_thu_sai_gon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstThuMoi = new System.Windows.Forms.ListBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoChépToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstThuMoi
            // 
            this.lstThuMoi.AllowDrop = true;
            this.lstThuMoi.FormattingEnabled = true;
            this.lstThuMoi.Location = new System.Drawing.Point(16, 47);
            this.lstThuMoi.Name = "lstThuMoi";
            this.lstThuMoi.Size = new System.Drawing.Size(117, 160);
            this.lstThuMoi.TabIndex = 0;
            this.lstThuMoi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            this.lstThuMoi.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDanhSach_DragDrop);
            this.lstThuMoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.AllowDrop = true;
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Location = new System.Drawing.Point(171, 47);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(117, 160);
            this.lstDanhSach.TabIndex = 1;
            this.lstDanhSach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            this.lstDanhSach.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDanhSach_DragDrop);
            this.lstDanhSach.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thú mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(13, 224);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(35, 13);
            this.lblThoiGian.TabIndex = 4;
            this.lblThoiGian.Text = "label3";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageKey = "tải xuống.jpg";
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(183, 244);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 36);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu danh sách";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnLuu, "Lưu danh sách con thú vào file");
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tải xuống.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.sửaĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(309, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmuLoad,
            this.lưuDanhSáchToolStripMenuItem,
            this.mmuClose});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.hồSơToolStripMenuItem.Text = "Hồ Sơ";
            // 
            // mmuLoad
            // 
            this.mmuLoad.Name = "mmuLoad";
            this.mmuLoad.Size = new System.Drawing.Size(151, 22);
            this.mmuLoad.Text = "Tải danh sách";
            this.mmuLoad.Click += new System.EventHandler(this.mmuLoad_Click);
            // 
            // lưuDanhSáchToolStripMenuItem
            // 
            this.lưuDanhSáchToolStripMenuItem.Image = global::so_thu_sai_gon.Properties.Resources.tải_xuống;
            this.lưuDanhSáchToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lưuDanhSáchToolStripMenuItem.Name = "lưuDanhSáchToolStripMenuItem";
            this.lưuDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.lưuDanhSáchToolStripMenuItem.Text = "Lưu danh sách";
            this.lưuDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // mmuClose
            // 
            this.mmuClose.Name = "mmuClose";
            this.mmuClose.Size = new System.Drawing.Size(151, 22);
            this.mmuClose.Text = "Kết thúc";
            this.mmuClose.Click += new System.EventHandler(this.mmuClose_Click);
            // 
            // sửaĐổiToolStripMenuItem
            // 
            this.sửaĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoChépToolStripMenuItem,
            this.cắtToolStripMenuItem,
            this.dánToolStripMenuItem});
            this.sửaĐổiToolStripMenuItem.Name = "sửaĐổiToolStripMenuItem";
            this.sửaĐổiToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sửaĐổiToolStripMenuItem.Text = "Sửa đổi";
            // 
            // saoChépToolStripMenuItem
            // 
            this.saoChépToolStripMenuItem.Name = "saoChépToolStripMenuItem";
            this.saoChépToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.saoChépToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saoChépToolStripMenuItem.Text = "Sao chép";
            // 
            // cắtToolStripMenuItem
            // 
            this.cắtToolStripMenuItem.Name = "cắtToolStripMenuItem";
            this.cắtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cắtToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cắtToolStripMenuItem.Text = "Cắt";
            // 
            // dánToolStripMenuItem
            // 
            this.dánToolStripMenuItem.Name = "dánToolStripMenuItem";
            this.dánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.dánToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dánToolStripMenuItem.Text = "Dán";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 288);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.lstThuMoi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstThuMoi;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmuLoad;
        private System.Windows.Forms.ToolStripMenuItem lưuDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmuClose;
        private System.Windows.Forms.ToolStripMenuItem sửaĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoChépToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cắtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dánToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

