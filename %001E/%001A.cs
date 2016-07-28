// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001E;
using \u0080;
using System.Diagnostics;
using System.Drawing;

namespace \u001E
{
  internal static class \u001A
  {
    public static Point \u001D\u0005(this Point sz, Point max)
    {
      if (sz.X > max.X)
        sz.X = max.X;
      if (sz.Y > max.Y)
        sz.Y = max.Y;
      return sz;
    }

    public static PointF \u001D\u0005(this PointF value)
    {
      float num1 = (float) ((double) value.X * (double) value.X + (double) value.Y * (double) value.Y);
      float num2 = (float) (1.0 / \u0007\u0081.\u0099\u0096((double) num1));
      value.X *= num2;
      value.Y *= num2;
      return value;
    }

    public static Point \u001D\u0005(this Point p, Rectangle bounds)
    {
      bounds = \u0015.\u001D\u0005(bounds);
      if (p.X < bounds.Left)
        p.X = bounds.Left;
      if (p.Y < bounds.Top)
        p.Y = bounds.Top;
      if (p.X > bounds.Right)
        p.X = bounds.Right;
      if (p.Y > bounds.Bottom)
        p.Y = bounds.Bottom;
      return p;
    }

    public static Point \u001D\u0005(this Point p, int x, int y)
    {
      return new Point(p.X + x, p.Y + y);
    }

    public static Rectangle \u001D\u0005(this Point p, int width, int height)
    {
      return new Rectangle(p.X - width / 2, p.Y - height / 2, width, height);
    }

    public static Rectangle \u001D\u0005(this Point p, Size sz)
    {
      return new Rectangle(p.X - sz.Width / 2, p.Y - sz.Height / 2, sz.Width, sz.Height);
    }

    public static Point \u001D\u0005(this Point p)
    {
      if (\u0097\u0080.\u001E\u008F().X < 0)
        p.X += \u0097\u0080.\u001E\u008F().X;
      if (\u0097\u0080.\u001E\u008F().Y < 0)
        p.Y += \u0097\u0080.\u001E\u008F().Y;
      return p;
    }

    public static Point \u001E\u0005(this Point p)
    {
      if (\u0097\u0080.\u001E\u008F().X < 0)
        p.X -= \u0097\u0080.\u001E\u008F().X;
      if (\u0097\u0080.\u001E\u008F().Y < 0)
        p.Y -= \u0097\u0080.\u001E\u008F().Y;
      return p;
    }

    public static Rectangle \u001D\u0005(this Rectangle rec)
    {
      return new Rectangle(rec.Location.\u001D\u0005(), rec.Size);
    }

    public static Rectangle \u001E\u0005(this Rectangle rec)
    {
      return new Rectangle(rec.Location.\u001E\u0005(), rec.Size);
    }

    [DebuggerStepThrough]
    public static Point \u001E\u0005(this Point p, Point p2)
    {
      return new Point(p.X + p2.X, p.Y + p2.Y);
    }

    [DebuggerStepThrough]
    public static Point \u001F\u0005(this Point p, Point p2)
    {
      return new Point(p.X - p2.X, p.Y - p2.Y);
    }
  }
}
