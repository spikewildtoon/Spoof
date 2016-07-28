// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001A;
using \u0080;
using System.Diagnostics;
using System.Drawing;

namespace \u0080
{
  internal static class \u0015
  {
    public static bool \u001D\u0005(this Rectangle rec, Rectangle other)
    {
      if (rec.Left <= other.Right && other.Left <= rec.Right && rec.Top <= other.Bottom)
        return other.Top <= rec.Bottom;
      return false;
    }

    public static Rectangle \u001D\u0005(this Rectangle rec, Rectangle max_bounds)
    {
      rec = \u0015.\u001D\u0005(rec);
      max_bounds = \u0015.\u001D\u0005(max_bounds);
      if (rec.X < max_bounds.X)
      {
        int num = rec.Width - (max_bounds.X - rec.X);
        if (num < 0)
          num = 0;
        rec.Width = num;
        rec.X = max_bounds.X;
      }
      if (rec.Y < max_bounds.Y)
      {
        int num = rec.Height - (max_bounds.Y - rec.Y);
        if (num < 0)
          num = 0;
        rec.Height = num;
        rec.Y = max_bounds.Y;
      }
      if (rec.X > max_bounds.Right)
        rec.X = max_bounds.Right;
      if (rec.Y > max_bounds.Bottom)
        rec.Y = max_bounds.Bottom;
      if (rec.Right > max_bounds.Right)
        rec.Width = max_bounds.Right - rec.X;
      if (rec.Bottom > max_bounds.Bottom)
        rec.Height = max_bounds.Bottom - rec.Y;
      return rec;
    }

    public static bool \u001D\u0005(this Rectangle rec)
    {
      return rec.Size.\u001D\u0005();
    }

    public static Rectangle \u001D\u0005(this Rectangle rec, int width_offset, int height_offset)
    {
      return new Rectangle(rec.Location, new Size(rec.Width + width_offset, rec.Height + height_offset));
    }

    public static Rectangle \u001E\u0005(this Rectangle rec, int xOffset, int yOffset)
    {
      return new Rectangle(rec.Location.\u001D\u0005(xOffset, yOffset), rec.Size);
    }

    public static Rectangle \u001D\u0005(this Rectangle rec, Size sz)
    {
      return rec.\u001F\u0005(sz.Width, sz.Height);
    }

    public static Rectangle \u001F\u0005(this Rectangle rec, int width_offset, int height_offset)
    {
      return new Rectangle(rec.X - width_offset / 2, rec.Y - height_offset / 2, rec.Width + width_offset, rec.Height + height_offset);
    }

    [DebuggerStepThrough]
    public static PointF \u001D\u0005(this RectangleF rec)
    {
      return new PointF(rec.X + rec.Width / 2f, rec.Y + rec.Height / 2f);
    }

    [DebuggerStepThrough]
    public static float \u001D\u0005(this RectangleF rec)
    {
      return rec.X + rec.Width / 2f;
    }

    [DebuggerStepThrough]
    public static Point \u001D\u0005(this Rectangle rec)
    {
      return new Point(rec.X + rec.Width / 2, rec.Y + rec.Height / 2);
    }

    public static int \u001D\u0005(this Rectangle rec)
    {
      return rec.X + rec.Width / 2;
    }

    public static int \u001E\u0005(this Rectangle rec)
    {
      return rec.Y + rec.Height / 2;
    }

    [DebuggerStepThrough]
    public static PointF \u001E\u0005(this RectangleF rec)
    {
      return new PointF(rec.X, rec.Y + rec.Height);
    }

    [DebuggerStepThrough]
    public static PointF \u001F\u0005(this RectangleF rec)
    {
      return new PointF(rec.Right, rec.Bottom);
    }

    [DebuggerStepThrough]
    public static PointF \u007F\u0005(this RectangleF rec)
    {
      return new PointF(rec.X + rec.Width / 2f, rec.Y + rec.Height);
    }

    [DebuggerStepThrough]
    public static PointF \u0080\u0005(this RectangleF rec)
    {
      return new PointF(rec.Right, rec.Top);
    }

    [DebuggerStepThrough]
    public static PointF \u0081\u0005(this RectangleF rec)
    {
      return new PointF(rec.Left, rec.Top);
    }

    [DebuggerStepThrough]
    public static Point \u001E\u0005(this Rectangle rec)
    {
      return new Point(rec.X, rec.Y + rec.Height);
    }

    [DebuggerStepThrough]
    public static Point \u001F\u0005(this Rectangle rec)
    {
      return new Point(rec.Right, rec.Bottom);
    }

    [DebuggerStepThrough]
    public static Point \u007F\u0005(this Rectangle rec)
    {
      return new Point(rec.X + rec.Width / 2, rec.Y + rec.Height);
    }

    [DebuggerStepThrough]
    public static Point \u0080\u0005(this Rectangle rec)
    {
      return new Point(rec.Right, rec.Top);
    }

    [DebuggerStepThrough]
    public static Point \u0081\u0005(this Rectangle rec)
    {
      return new Point(rec.Left, rec.Top);
    }

    public static Rectangle \u001D\u0005(this Size sz, Rectangle bounds)
    {
      if (sz.Width > bounds.Width)
      {
        float num = (float) bounds.Width / (float) sz.Width;
        sz = new Size(bounds.Width, (int) ((double) sz.Height * (double) num));
      }
      if (sz.Height > bounds.Height)
      {
        float num = (float) bounds.Height / (float) sz.Height;
        sz = new Size((int) ((double) sz.Width * (double) num), bounds.Height);
      }
      return new Rectangle(Point.Empty, sz) { X = bounds.X + (bounds.Width / 2 - sz.Width / 2), Y = bounds.Y + (bounds.Height / 2 - sz.Height / 2) };
    }

    [DebuggerStepThrough]
    public static bool \u001D\u0005(this Rectangle rec, Point p)
    {
      if (rec.X <= p.X && rec.X + rec.Width >= p.X && rec.Y <= p.Y)
        return rec.Y + rec.Height >= p.Y;
      return false;
    }

    [DebuggerStepThrough]
    public static Rectangle \u001D\u0005(this Rectangle rec)
    {
      Rectangle rectangle = rec;
      if (rectangle.Width < 0)
      {
        rectangle.X += rectangle.Width;
        rectangle.Width *= -1;
      }
      if (rectangle.Height < 0)
      {
        rectangle.Y += rectangle.Height;
        rectangle.Height *= -1;
      }
      return rectangle;
    }
  }
}
