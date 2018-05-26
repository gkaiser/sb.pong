using System;

namespace SB.Pong
{
  public enum EdgeEvent
  {
    None = 0,
    HitTop = 1,
    HitBottom = 2,
    HitLeft = 4,
    HitRight = 8,
    HitLeftPaddle = 16,
    HitRightPaddle = 32,
  }
}
