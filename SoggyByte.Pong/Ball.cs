using System;
using System.Linq;
using System.Drawing;

namespace SoggyByte.Pong
{
  public class Ball
  {
    public FrmMain GameBoard;
    public Size Size;
    public int SpeedHoriz = 0;
    public int SpeedVert = 0;
    private Point IntLocation;

    public Ball(FrmMain gameBoard)
    {
      this.GameBoard = gameBoard;
      this.IntLocation = new Point(this.GameBoard.ClientRectangle.Width / 2, this.GameBoard.ClientRectangle.Height / 2);
      this.Size = new Size(24, 24);
    }

    /// <summary>
    /// The location of the ball (specifically, the CENTER of the ball).
    /// </summary>
    public Point Location => new Point(this.IntLocation.X - (this.Size.Width / 2), this.IntLocation.Y - (this.Size.Width / 2));

    public bool InMotion => (this.SpeedHoriz != 0 || this.SpeedVert != 0);

    public void Start()
    {
      var rand = new Random();
      var speed = 0;

      do
      {
        speed = rand.Next(-7, 7);
      } while (speed > -3 && speed < 3);

      this.SpeedHoriz = speed;

      do
      {
        speed = rand.Next(-7, 7);
      } while (speed > -3 && speed < 3);

      this.SpeedVert = speed;

      System.Diagnostics.Debug.WriteLine($"H {this.SpeedHoriz}, V {this.SpeedVert}");
    }

    public void UpdateBallLocation()
    {
      this.IntLocation.X += (int)this.SpeedHoriz;
      this.IntLocation.Y += (int)this.SpeedVert;
    }

    public void Reset()
    {
      this.IntLocation = new Point(this.GameBoard.ClientRectangle.Width / 2, this.GameBoard.ClientRectangle.Height / 2);
      this.SpeedHoriz = 0;
      this.SpeedVert = 0;
    }

    public EdgeEvent CheckEdges(Paddle pLeft, Paddle pRight)
    {
      if (!this.InMotion)
        return EdgeEvent.None;

      // Check for hitting the top or bottom of the window.
      if (this.Location.Y <= 0 || (this.Location.Y + this.Size.Height) >= this.GameBoard.Height)
      {
        this.SpeedVert *= -1;

        return (this.Location.Y <= 0 ? EdgeEvent.HitTop : EdgeEvent.HitBottom);
      }

      // Check for hitting a paddle.
      if (this.Location.Y >= pLeft.Location.Y && this.Location.Y <= (pLeft.Location.Y + pLeft.Size.Height) && this.Location.X <= (pLeft.Location.X + pLeft.Size.Width))
      {
        this.SpeedHoriz *= -1;

        return EdgeEvent.HitLeftPaddle;
      }
      if (this.Location.Y >= pRight.Location.Y && this.Location.Y <= (pRight.Location.Y + pRight.Size.Height) && (this.Location.X + this.Size.Width) >= pRight.Location.X)
      {
        this.SpeedHoriz *= -1;

        return EdgeEvent.HitRightPaddle;
      }

      // Check for hitting the sides of the window.
      if (this.Location.X <= 0 || (this.Location.X + this.Size.Width) >= this.GameBoard.Width)
      {
        return (this.Location.X <= 0 ? EdgeEvent.HitLeft : EdgeEvent.HitRight);
      }

      return EdgeEvent.None;
    }


  }
}
