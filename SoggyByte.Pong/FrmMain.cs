using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace SoggyByte.Pong
{
  public partial class FrmMain : Form
  {
    private Ball Ball;
    private Paddle PaddleRight;
    private Paddle PaddleLeft;
    private Timer TimerTrigger;
    private int Player1Score;
    private int Player2Score;

    public FrmMain()
    {
      InitializeComponent();

      this.Ball = new Ball(this);
      this.PaddleLeft = new Paddle(true, this);
      this.PaddleRight = new Paddle(false, this);

      this.TimerTrigger = new Timer();
      this.TimerTrigger.Interval = (int)((1 / (decimal)29) * 1000m);
      this.TimerTrigger.Tick += this.TimerTrigger_Tick;
      this.TimerTrigger.Enabled = true;
    }

    private void TimerTrigger_Tick(object sender, EventArgs e)
    {
      this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      var gfx = e.Graphics;
      gfx.FillRectangle(Brushes.Black, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
      gfx.DrawString(this.Player1Score.ToString(), new Font("Sans Serif", 16f, FontStyle.Bold), Brushes.White, 4f, 4f);
      gfx.DrawString(this.Player2Score.ToString(), new Font("Sans Serif", 16f, FontStyle.Bold), Brushes.White, this.Width - 24, 4f);
      gfx.FillEllipse(Brushes.White, this.Ball.Location.X, this.Ball.Location.Y, this.Ball.Size.Width, this.Ball.Size.Height);
      gfx.FillRectangle(Brushes.White, this.PaddleLeft.Location.X, this.PaddleLeft.Location.Y, this.PaddleLeft.Size.Width, this.PaddleRight.Size.Height);
      gfx.FillRectangle(Brushes.White, this.PaddleRight.Location.X, this.PaddleRight.Location.Y, this.PaddleRight.Size.Width, this.PaddleRight.Size.Height);

      var edgeEvent = this.Ball.CheckEdges(this.PaddleLeft, this.PaddleRight);
      if (edgeEvent == EdgeEvent.HitLeft || edgeEvent == EdgeEvent.HitRight)
      {
        if (edgeEvent == EdgeEvent.HitLeft)
          this.Player2Score++;
        else
          this.Player1Score++;

        ctxMenu_miReset_Click(null, EventArgs.Empty);
        return;
      }

      this.Ball.UpdateBallLocation();
    }

    private void FrmMain_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.OemQuotes)
      {
        this.PaddleRight.Move(-10);
      }
      else if (e.KeyCode == Keys.OemQuestion)
      {
        this.PaddleRight.Move(10);
      }
      else if (e.KeyCode == Keys.A)
      {
        this.PaddleLeft.Move(-10);
      }
      else if (e.KeyCode == Keys.Z)
      {
        this.PaddleLeft.Move(10);
      }
      else if (e.KeyCode == Keys.Escape)
      {
        ctxMenu_miReset_Click(sender, EventArgs.Empty);
      }
      else if (e.KeyCode == Keys.Space)
      {
        ctxMenu_miStart_Click(sender, EventArgs.Empty);
      }
    }

    private void ctxMenu_miStart_Click(object sender, EventArgs e)
    {
      ctxMenu_miReset_Click(sender, e);

      this.Ball.Start();
    }

    private void ctxMenu_miReset_Click(object sender, EventArgs e)
    {
      this.Ball.Reset();
      this.PaddleLeft.Reset();
      this.PaddleRight.Reset();

      this.Invalidate();
    }

    private void ctxMenu_miQuit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

  }
}
