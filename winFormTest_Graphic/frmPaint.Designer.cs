namespace winFormTest_Graphic
{
    partial class frmPaint
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.홈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShape = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuErase = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sblabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sblabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sblabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sblabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.홈ToolStripMenuItem,
            this.보기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave,
            this.toolStripSeparator1,
            this.menuExit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // menuNew
            // 
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(138, 22);
            this.menuNew.Text = "새로 만들기";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(138, 22);
            this.menuOpen.Text = "열기";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(138, 22);
            this.menuSave.Text = "저장";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(138, 22);
            this.menuExit.Text = "끝내기";
            // 
            // 홈ToolStripMenuItem
            // 
            this.홈ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShape,
            this.menuLine,
            this.menuRect,
            this.menuCircle,
            this.menuText,
            this.toolStripSeparator2,
            this.menuErase});
            this.홈ToolStripMenuItem.Name = "홈ToolStripMenuItem";
            this.홈ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.홈ToolStripMenuItem.Text = "그리기";
            // 
            // menuShape
            // 
            this.menuShape.Name = "menuShape";
            this.menuShape.Size = new System.Drawing.Size(150, 22);
            this.menuShape.Text = "연필그리기";
            this.menuShape.Click += new System.EventHandler(this.menuShape_Click);
            // 
            // menuLine
            // 
            this.menuLine.Name = "menuLine";
            this.menuLine.Size = new System.Drawing.Size(150, 22);
            this.menuLine.Text = "선그리기";
            this.menuLine.Click += new System.EventHandler(this.menuLine_Click);
            // 
            // menuRect
            // 
            this.menuRect.Name = "menuRect";
            this.menuRect.Size = new System.Drawing.Size(150, 22);
            this.menuRect.Text = "사각형 그리기";
            this.menuRect.Click += new System.EventHandler(this.menuRect_Click);
            // 
            // menuCircle
            // 
            this.menuCircle.Name = "menuCircle";
            this.menuCircle.Size = new System.Drawing.Size(150, 22);
            this.menuCircle.Text = "원그리기";
            this.menuCircle.Click += new System.EventHandler(this.menuCircle_Click);
            // 
            // menuText
            // 
            this.menuText.Name = "menuText";
            this.menuText.Size = new System.Drawing.Size(150, 22);
            this.menuText.Text = "문자 입력";
            this.menuText.Click += new System.EventHandler(this.menuText_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // menuErase
            // 
            this.menuErase.Name = "menuErase";
            this.menuErase.Size = new System.Drawing.Size(150, 22);
            this.menuErase.Text = "모두지우기";
            this.menuErase.Click += new System.EventHandler(this.menuErase_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuColor});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // menuColor
            // 
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(98, 22);
            this.menuColor.Text = "색상";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sblabel1,
            this.sblabel2,
            this.sblabel3,
            this.sblabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1019);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1904, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sblabel1
            // 
            this.sblabel1.AutoSize = false;
            this.sblabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sblabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sblabel1.Name = "sblabel1";
            this.sblabel1.Size = new System.Drawing.Size(100, 17);
            // 
            // sblabel2
            // 
            this.sblabel2.AutoSize = false;
            this.sblabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sblabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sblabel2.Name = "sblabel2";
            this.sblabel2.Size = new System.Drawing.Size(100, 17);
            // 
            // sblabel3
            // 
            this.sblabel3.AutoSize = false;
            this.sblabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sblabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sblabel3.Name = "sblabel3";
            this.sblabel3.Size = new System.Drawing.Size(100, 17);
            // 
            // sblabel4
            // 
            this.sblabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sblabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sblabel4.Name = "sblabel4";
            this.sblabel4.Size = new System.Drawing.Size(4, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // canvas
            // 
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 24);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1904, 995);
            this.canvas.TabIndex = 3;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 484);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 458);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPaint";
            this.Text = "Form1";
            this.ResizeEnd += new System.EventHandler(this.frmPaint_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmPaint_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem 홈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ToolStripMenuItem menuShape;
        private System.Windows.Forms.ToolStripMenuItem menuLine;
        private System.Windows.Forms.ToolStripMenuItem menuRect;
        private System.Windows.Forms.ToolStripMenuItem menuCircle;
        private System.Windows.Forms.ToolStripMenuItem menuErase;
        private System.Windows.Forms.ToolStripMenuItem menuColor;
        private System.Windows.Forms.ToolStripMenuItem menuText;
        private System.Windows.Forms.ToolStripStatusLabel sblabel1;
        private System.Windows.Forms.ToolStripStatusLabel sblabel2;
        private System.Windows.Forms.ToolStripStatusLabel sblabel3;
        private System.Windows.Forms.ToolStripStatusLabel sblabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

