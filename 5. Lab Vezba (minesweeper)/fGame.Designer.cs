namespace _5.Lab_Vezba__minesweeper_
{
    partial class fGame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.begginerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itermediateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cheatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_brojMina = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_emoji = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.difToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(299, 26);
            this.menuStrip1.TabIndex = 82;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // difToolStripMenuItem
            // 
            this.difToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.begginerToolStripMenuItem,
            this.itermediateToolStripMenuItem,
            this.expertToolStripMenuItem,
            this.customToolStripMenuItem,
            this.toolStripSeparator1,
            this.cheatToolStripMenuItem});
            this.difToolStripMenuItem.Name = "difToolStripMenuItem";
            this.difToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.difToolStripMenuItem.Text = "Difficulty";
            // 
            // begginerToolStripMenuItem
            // 
            this.begginerToolStripMenuItem.Checked = true;
            this.begginerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.begginerToolStripMenuItem.Name = "begginerToolStripMenuItem";
            this.begginerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.begginerToolStripMenuItem.Text = "Begginer";
            this.begginerToolStripMenuItem.Click += new System.EventHandler(this.begginerToolStripMenuItem_Click);
            // 
            // itermediateToolStripMenuItem
            // 
            this.itermediateToolStripMenuItem.Name = "itermediateToolStripMenuItem";
            this.itermediateToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.itermediateToolStripMenuItem.Text = "Itermediate";
            this.itermediateToolStripMenuItem.Click += new System.EventHandler(this.itermediateToolStripMenuItem_Click);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler(this.expertToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // cheatToolStripMenuItem
            // 
            this.cheatToolStripMenuItem.Checked = true;
            this.cheatToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cheatToolStripMenuItem.Name = "cheatToolStripMenuItem";
            this.cheatToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cheatToolStripMenuItem.Text = "Cheat";
            this.cheatToolStripMenuItem.Click += new System.EventHandler(this.cheatToolStripMenuItem_Click);
            // 
            // lbl_brojMina
            // 
            this.lbl_brojMina.AutoSize = true;
            this.lbl_brojMina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brojMina.Location = new System.Drawing.Point(55, 43);
            this.lbl_brojMina.Name = "lbl_brojMina";
            this.lbl_brojMina.Size = new System.Drawing.Size(24, 18);
            this.lbl_brojMina.TabIndex = 83;
            this.lbl_brojMina.Text = "10";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(210, 43);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(16, 18);
            this.lbl_timer.TabIndex = 84;
            this.lbl_timer.Text = "0";
            // 
            // btn_emoji
            // 
            this.btn_emoji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emoji.Location = new System.Drawing.Point(125, 30);
            this.btn_emoji.Name = "btn_emoji";
            this.btn_emoji.Size = new System.Drawing.Size(45, 45);
            this.btn_emoji.TabIndex = 85;
            this.btn_emoji.UseVisualStyleBackColor = true;
            this.btn_emoji.Click += new System.EventHandler(this.btn_emoji_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 354);
            this.Controls.Add(this.btn_emoji);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_brojMina);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fGame";
            this.Text = "Minesweeper";
            this.Resize += new System.EventHandler(this.fGame_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem begginerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itermediateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.Label lbl_brojMina;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_emoji;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cheatToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

