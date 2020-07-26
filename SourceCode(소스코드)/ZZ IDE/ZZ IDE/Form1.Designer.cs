namespace ZZ_IDE
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자르기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배경색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글씨색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그래밍언어변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.코딩하는이선생ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zZIDE정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.코딩하는이선생ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.열기ToolStripMenuItem1,
            this.저장하ToolStripMenuItem,
            this.다른이름으로저장하기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            this.파일ToolStripMenuItem.Click += new System.EventHandler(this.파일ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.열기ToolStripMenuItem.Text = "새로 만들기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem1
            // 
            this.열기ToolStripMenuItem1.Name = "열기ToolStripMenuItem1";
            this.열기ToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.열기ToolStripMenuItem1.Text = "열기";
            this.열기ToolStripMenuItem1.Click += new System.EventHandler(this.열기ToolStripMenuItem1_Click);
            // 
            // 저장하ToolStripMenuItem
            // 
            this.저장하ToolStripMenuItem.Name = "저장하ToolStripMenuItem";
            this.저장하ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.저장하ToolStripMenuItem.Text = "저장하기";
            this.저장하ToolStripMenuItem.Click += new System.EventHandler(this.저장하ToolStripMenuItem_Click);
            // 
            // 다른이름으로저장하기ToolStripMenuItem
            // 
            this.다른이름으로저장하기ToolStripMenuItem.Name = "다른이름으로저장하기ToolStripMenuItem";
            this.다른이름으로저장하기ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.다른이름으로저장하기ToolStripMenuItem.Text = "다른 이름으로 저장하기";
            this.다른이름으로저장하기ToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장하기ToolStripMenuItem_Click);
            // 
            // 편ToolStripMenuItem
            // 
            this.편ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자르기ToolStripMenuItem,
            this.복사하기ToolStripMenuItem,
            this.붙여넣ToolStripMenuItem});
            this.편ToolStripMenuItem.Name = "편ToolStripMenuItem";
            this.편ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편ToolStripMenuItem.Text = "편집";
            // 
            // 자르기ToolStripMenuItem
            // 
            this.자르기ToolStripMenuItem.Name = "자르기ToolStripMenuItem";
            this.자르기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.자르기ToolStripMenuItem.Text = "자르기";
            this.자르기ToolStripMenuItem.Click += new System.EventHandler(this.자르기ToolStripMenuItem_Click);
            // 
            // 복사하기ToolStripMenuItem
            // 
            this.복사하기ToolStripMenuItem.Name = "복사하기ToolStripMenuItem";
            this.복사하기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.복사하기ToolStripMenuItem.Text = "복사하기";
            this.복사하기ToolStripMenuItem.Click += new System.EventHandler(this.복사하기ToolStripMenuItem_Click);
            // 
            // 붙여넣ToolStripMenuItem
            // 
            this.붙여넣ToolStripMenuItem.Name = "붙여넣ToolStripMenuItem";
            this.붙여넣ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.붙여넣ToolStripMenuItem.Text = "붙여넣기";
            this.붙여넣ToolStripMenuItem.Click += new System.EventHandler(this.붙여넣ToolStripMenuItem_Click);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.배경색상ToolStripMenuItem,
            this.글씨색상ToolStripMenuItem,
            this.프로그래밍언어변경ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 배경색상ToolStripMenuItem
            // 
            this.배경색상ToolStripMenuItem.Name = "배경색상ToolStripMenuItem";
            this.배경색상ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.배경색상ToolStripMenuItem.Text = "배경 색상";
            this.배경색상ToolStripMenuItem.Click += new System.EventHandler(this.배경색상ToolStripMenuItem_Click);
            // 
            // 글씨색상ToolStripMenuItem
            // 
            this.글씨색상ToolStripMenuItem.Name = "글씨색상ToolStripMenuItem";
            this.글씨색상ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.글씨색상ToolStripMenuItem.Text = "글씨 색상";
            this.글씨색상ToolStripMenuItem.Click += new System.EventHandler(this.글씨색상ToolStripMenuItem_Click);
            // 
            // 프로그래밍언어변경ToolStripMenuItem
            // 
            this.프로그래밍언어변경ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.luaToolStripMenuItem,
            this.hTMLToolStripMenuItem,
            this.pHPToolStripMenuItem,
            this.jSToolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.cUSTOMToolStripMenuItem});
            this.프로그래밍언어변경ToolStripMenuItem.Name = "프로그래밍언어변경ToolStripMenuItem";
            this.프로그래밍언어변경ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.프로그래밍언어변경ToolStripMenuItem.Text = "프로그래밍 언어 변경";
            // 
            // luaToolStripMenuItem
            // 
            this.luaToolStripMenuItem.Name = "luaToolStripMenuItem";
            this.luaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.luaToolStripMenuItem.Text = "Lua";
            this.luaToolStripMenuItem.Click += new System.EventHandler(this.luaToolStripMenuItem_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.hTMLToolStripMenuItem_Click);
            // 
            // pHPToolStripMenuItem
            // 
            this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            this.pHPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pHPToolStripMenuItem.Text = "PHP";
            this.pHPToolStripMenuItem.Click += new System.EventHandler(this.pHPToolStripMenuItem_Click);
            // 
            // jSToolStripMenuItem
            // 
            this.jSToolStripMenuItem.Name = "jSToolStripMenuItem";
            this.jSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jSToolStripMenuItem.Text = "JS";
            this.jSToolStripMenuItem.Click += new System.EventHandler(this.jSToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // cUSTOMToolStripMenuItem
            // 
            this.cUSTOMToolStripMenuItem.Name = "cUSTOMToolStripMenuItem";
            this.cUSTOMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cUSTOMToolStripMenuItem.Text = "CUSTOM";
            this.cUSTOMToolStripMenuItem.Click += new System.EventHandler(this.cUSTOMToolStripMenuItem_Click);
            // 
            // 코딩하는이선생ToolStripMenuItem
            // 
            this.코딩하는이선생ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zZIDE정보ToolStripMenuItem});
            this.코딩하는이선생ToolStripMenuItem.Name = "코딩하는이선생ToolStripMenuItem";
            this.코딩하는이선생ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.코딩하는이선생ToolStripMenuItem.Text = "정보";
            // 
            // zZIDE정보ToolStripMenuItem
            // 
            this.zZIDE정보ToolStripMenuItem.Name = "zZIDE정보ToolStripMenuItem";
            this.zZIDE정보ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.zZIDE정보ToolStripMenuItem.Text = "ZZ IDE 정보";
            this.zZIDE정보ToolStripMenuItem.Click += new System.EventHandler(this.zZIDE정보ToolStripMenuItem_Click);
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(187, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.CommentPrefix = null;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
            this.fastColoredTextBox1.LeftBracket = '<';
            this.fastColoredTextBox1.LeftBracket2 = '(';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 24);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = '>';
            this.fastColoredTextBox1.RightBracket2 = ')';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(800, 426);
            this.fastColoredTextBox1.TabIndex = 1;
            this.fastColoredTextBox1.Text = "HELLO ZZ Studio IDE!";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZZ Studio IDE";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편ToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 저장하ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자르기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배경색상ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글씨색상ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 코딩하는이선생ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zZIDE정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그래밍언어변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMToolStripMenuItem;
    }
}

