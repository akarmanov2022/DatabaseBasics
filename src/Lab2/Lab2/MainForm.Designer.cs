﻿namespace Lab2
{
    sealed partial class MainForm
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AboutToolContextStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolContextStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.AboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LeagueToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MatchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PlayersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TeamsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.ContextMenuStripMain.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Lab2.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Lab2.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.aboutToolStripMenuItem.Text = "О программе...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ContextMenuStripMain
            // 
            this.ContextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolContextStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolContextStripMenuItem});
            this.ContextMenuStripMain.Name = "ContextMenuStripMain";
            this.ContextMenuStripMain.Size = new System.Drawing.Size(192, 54);
            // 
            // AboutToolContextStripMenuItem
            // 
            this.AboutToolContextStripMenuItem.Image = global::Lab2.Properties.Resources.about;
            this.AboutToolContextStripMenuItem.Name = "AboutToolContextStripMenuItem";
            this.AboutToolContextStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.AboutToolContextStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.AboutToolContextStripMenuItem.Text = "О программе...";
            this.AboutToolContextStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // ExitToolContextStripMenuItem
            // 
            this.ExitToolContextStripMenuItem.Image = global::Lab2.Properties.Resources.exit;
            this.ExitToolContextStripMenuItem.Name = "ExitToolContextStripMenuItem";
            this.ExitToolContextStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.ExitToolContextStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ExitToolContextStripMenuItem.Text = "Выход";
            this.ExitToolContextStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripButton,
            this.ExitToolStripButton,
            this.LeagueToolStripButton,
            this.MatchToolStripButton,
            this.PlayersToolStripButton,
            this.TeamsToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(800, 25);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // AboutToolStripButton
            // 
            this.AboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutToolStripButton.Image = global::Lab2.Properties.Resources.about;
            this.AboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutToolStripButton.Name = "AboutToolStripButton";
            this.AboutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AboutToolStripButton.Text = "toolStripButton1";
            this.AboutToolStripButton.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ExitToolStripButton
            // 
            this.ExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitToolStripButton.Image = global::Lab2.Properties.Resources.exit;
            this.ExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolStripButton.Name = "ExitToolStripButton";
            this.ExitToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ExitToolStripButton.Text = "toolStripButton2";
            this.ExitToolStripButton.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // LeagueToolStripButton
            // 
            this.LeagueToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LeagueToolStripButton.Image = global::Lab2.Properties.Resources.leagues;
            this.LeagueToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeagueToolStripButton.Name = "LeagueToolStripButton";
            this.LeagueToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.LeagueToolStripButton.Text = "toolStripButton3";
            // 
            // MatchToolStripButton
            // 
            this.MatchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MatchToolStripButton.Image = global::Lab2.Properties.Resources.match;
            this.MatchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MatchToolStripButton.Name = "MatchToolStripButton";
            this.MatchToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.MatchToolStripButton.Text = "toolStripButton4";
            // 
            // PlayersToolStripButton
            // 
            this.PlayersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlayersToolStripButton.Image = global::Lab2.Properties.Resources.players;
            this.PlayersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayersToolStripButton.Name = "PlayersToolStripButton";
            this.PlayersToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PlayersToolStripButton.Text = "toolStripButton5";
            // 
            // TeamsToolStripButton
            // 
            this.TeamsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TeamsToolStripButton.Image = global::Lab2.Properties.Resources.teams;
            this.TeamsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TeamsToolStripButton.Name = "TeamsToolStripButton";
            this.TeamsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.TeamsToolStripButton.Text = "toolStripButton6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Программа для футбольных турниров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ContextMenuStripMain.ResumeLayout(false);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem AboutToolContextStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolContextStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton AboutToolStripButton;
        private System.Windows.Forms.ToolStripButton ExitToolStripButton;
        private System.Windows.Forms.ToolStripButton LeagueToolStripButton;
        private System.Windows.Forms.ToolStripButton MatchToolStripButton;
        private System.Windows.Forms.ToolStripButton PlayersToolStripButton;
        private System.Windows.Forms.ToolStripButton TeamsToolStripButton;
    }
}

