using System;
using System.Linq;
using System.Drawing;

namespace SoggyByte.Pong
{
  public class Paddle
  {
    public FrmMain GameBoard;
    public bool IsLeftPaddle;
    public Point Location;
    public Size Size;

    public Paddle(bool isLeftPaddle, FrmMain gameBoard)
    {
      this.IsLeftPaddle = isLeftPaddle;
      this.GameBoard = gameBoard;
      this.Size = new Size(8, this.GameBoard.Size.Height / 4);

      this.Reset();
    }

    public void Move(int step)
    {
      var nextY = this.Location.Y + step;

      if (nextY < 0)
        this.Location.Y = 0;
      else if (nextY + this.Size.Height > this.GameBoard.Size.Height)
        this.Location.Y = this.GameBoard.Size.Height - this.Size.Height;
      else
        this.Location.Y = nextY;
    }

    public void Reset()
    {
      if (this.IsLeftPaddle)
        this.Location = new Point(2, (this.GameBoard.ClientRectangle.Height - this.Size.Height) / 2);
      else
        this.Location = new Point(this.GameBoard.ClientRectangle.Width - this.Size.Width - 2, (this.GameBoard.ClientRectangle.Height - this.Size.Height) / 2);
    }

  }
}
