namespace FinanceCal
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FinanceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FinanceCalPanel = new System.Windows.Forms.Panel();
            this.FinancePanel = new FinanceCal.FinancePanel();
            this.TPanel = new FinanceCal.TestPanel();
            this.MenuStrip.SuspendLayout();
            this.FinanceCalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FinanceMenu,
            this.NonMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(602, 24);
            this.MenuStrip.TabIndex = 19;
            // 
            // FinanceMenu
            // 
            this.FinanceMenu.Name = "FinanceMenu";
            this.FinanceMenu.Size = new System.Drawing.Size(83, 20);
            this.FinanceMenu.Text = "재무 계산기";
            this.FinanceMenu.Click += new System.EventHandler(this.FinanceMenu_Click);
            // 
            // NonMenu
            // 
            this.NonMenu.Name = "NonMenu";
            this.NonMenu.Size = new System.Drawing.Size(55, 20);
            this.NonMenu.Text = "미지정";
            this.NonMenu.Click += new System.EventHandler(this.NonMenu_Click);
            // 
            // FinanceCalPanel
            // 
            this.FinanceCalPanel.Controls.Add(this.TPanel);
            this.FinanceCalPanel.Controls.Add(this.FinancePanel);
            this.FinanceCalPanel.Location = new System.Drawing.Point(3, 25);
            this.FinanceCalPanel.Name = "FinanceCalPanel";
            this.FinanceCalPanel.Size = new System.Drawing.Size(597, 635);
            this.FinanceCalPanel.TabIndex = 20;
            // 
            // FinancePanel
            // 
            this.FinancePanel.Location = new System.Drawing.Point(9, 12);
            this.FinancePanel.Name = "FinancePanel";
            this.FinancePanel.Size = new System.Drawing.Size(140, 131);
            this.FinancePanel.TabIndex = 24;
            // 
            // TPanel
            // 
            this.TPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TPanel.Location = new System.Drawing.Point(28, 180);
            this.TPanel.Name = "TPanel";
            this.TPanel.Size = new System.Drawing.Size(27, 38);
            this.TPanel.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 672);
            this.Controls.Add(this.FinanceCalPanel);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.FinanceCalPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FinanceMenu;
        private System.Windows.Forms.ToolStripMenuItem NonMenu;
        private System.Windows.Forms.Panel FinanceCalPanel;
        private FinancePanel FinancePanel;
        private TestPanel TPanel;
    }
}

