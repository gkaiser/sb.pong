namespace SB.Pong
{
  partial class FrmMain
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
      this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ctxMenu_miStart = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxMenu_miReset = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxMenu_miQuit = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // ctxMenu
      // 
      this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenu_miStart,
            this.ctxMenu_miReset,
            this.ctxMenu_miQuit});
      this.ctxMenu.Name = "ctxMenu";
      this.ctxMenu.Size = new System.Drawing.Size(103, 70);
      // 
      // ctxMenu_miStart
      // 
      this.ctxMenu_miStart.Name = "ctxMenu_miStart";
      this.ctxMenu_miStart.Size = new System.Drawing.Size(102, 22);
      this.ctxMenu_miStart.Text = "Start";
      this.ctxMenu_miStart.Click += new System.EventHandler(this.ctxMenu_miStart_Click);
      // 
      // ctxMenu_miReset
      // 
      this.ctxMenu_miReset.Name = "ctxMenu_miReset";
      this.ctxMenu_miReset.Size = new System.Drawing.Size(102, 22);
      this.ctxMenu_miReset.Text = "Reset";
      this.ctxMenu_miReset.Click += new System.EventHandler(this.ctxMenu_miReset_Click);
      // 
      // ctxMenu_miQuit
      // 
      this.ctxMenu_miQuit.Name = "ctxMenu_miQuit";
      this.ctxMenu_miQuit.Size = new System.Drawing.Size(102, 22);
      this.ctxMenu_miQuit.Text = "Quit";
      this.ctxMenu_miQuit.Click += new System.EventHandler(this.ctxMenu_miQuit_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 400);
      this.ContextMenuStrip = this.ctxMenu;
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.Name = "FrmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SB.Pong";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
      this.ctxMenu.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ContextMenuStrip ctxMenu;
    private System.Windows.Forms.ToolStripMenuItem ctxMenu_miStart;
    private System.Windows.Forms.ToolStripMenuItem ctxMenu_miReset;
    private System.Windows.Forms.ToolStripMenuItem ctxMenu_miQuit;
  }
}

