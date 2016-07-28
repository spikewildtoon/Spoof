// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0080;
using \u0082;
using System;
using System.Diagnostics;
using System.Drawing;

namespace \u0082
{
  internal static class \u0001
  {
    public static readonly double \u0001 = Math.PI / 180.0;
    public static readonly double \u0002 = 180.0 / Math.PI;

    [DebuggerStepThrough]
    public static bool \u001D\u0005(PointF center, float radius, PointF point)
    {
      return \u0090\u007F.\u009A\u0096((double) point.X - (double) center.X, 2.0) + \u0090\u007F.\u009A\u0096((double) point.Y - (double) center.Y, 2.0) < \u0090\u007F.\u009A\u0096((double) radius, 2.0);
    }

    [DebuggerStepThrough]
    public static int \u001D\u0005(PointF center, float radius, \u0001.\u0001 line, out PointF intersection1, out PointF intersection2)
    {
      float num1 = line.\u0002.X - line.\u0001.X;
      float num2 = line.\u0002.Y - line.\u0001.Y;
      float num3 = (float) ((double) num1 * (double) num1 + (double) num2 * (double) num2);
      float num4 = (float) (2.0 * ((double) num1 * ((double) line.\u0001.X - (double) center.X) + (double) num2 * ((double) line.\u0001.Y - (double) center.Y)));
      float num5 = (float) (((double) line.\u0001.X - (double) center.X) * ((double) line.\u0001.X - (double) center.X) + ((double) line.\u0001.Y - (double) center.Y) * ((double) line.\u0001.Y - (double) center.Y) - (double) radius * (double) radius);
      float num6 = (float) ((double) num4 * (double) num4 - 4.0 * (double) num3 * (double) num5);
      if ((double) num3 <= 1E-07 || (double) num6 < 0.0)
      {
        intersection1 = new PointF(float.NaN, float.NaN);
        intersection2 = new PointF(float.NaN, float.NaN);
        return 0;
      }
      if ((double) num6 == 0.0)
      {
        float num7 = (float) (-(double) num4 / (2.0 * (double) num3));
        intersection1 = new PointF(line.\u0001.X + num7 * num1, line.\u0001.Y + num7 * num2);
        intersection2 = new PointF(float.NaN, float.NaN);
        return 1;
      }
      float num8 = (float) ((-(double) num4 + \u0007\u0081.\u0099\u0096((double) num6)) / (2.0 * (double) num3));
      intersection1 = new PointF(line.\u0001.X + num8 * num1, line.\u0001.Y + num8 * num2);
      float num9 = (float) ((-(double) num4 - \u0007\u0081.\u0099\u0096((double) num6)) / (2.0 * (double) num3));
      intersection2 = new PointF(line.\u0001.X + num9 * num1, line.\u0001.Y + num9 * num2);
      return 2;
    }

    public static float? \u001D\u0005(PointF p, RectangleF rec)
    {
      PointF end = rec.\u001D\u0005();
      \u0001.\u0001 AB = new \u0001.\u0001(p, end);
      PointF? nullable1 = new PointF?();
      PointF? nullable2;
      if ((double) p.Y > (double) rec.Top)
      {
        if ((double) p.Y >= (double) rec.Bottom)
        {
          nullable2 = \u0001.\u007F\u0005(AB, rec);
          if (!nullable2.HasValue)
            nullable2 = (double) p.X >= (double) rec.Left ? \u0001.\u001F\u0005(AB, rec) : \u0001.\u001E\u0005(AB, rec);
        }
        else if ((double) p.X <= (double) rec.Left)
        {
          nullable2 = \u0001.\u001E\u0005(AB, rec);
        }
        else
        {
          if ((double) p.X < (double) rec.Right)
            return new float?();
          nullable2 = \u0001.\u001F\u0005(AB, rec);
        }
      }
      else
        goto label_13;
label_10:
      if (!nullable2.HasValue)
        return new float?();
      return new float?(\u0001.\u001D\u0005(p, nullable2.Value));
label_13:
      nullable2 = \u0001.\u001D\u0005(AB, rec);
      if (!nullable2.HasValue)
      {
        nullable2 = (double) p.X >= (double) rec.Left ? \u0001.\u001F\u0005(AB, rec) : \u0001.\u001E\u0005(AB, rec);
        goto label_10;
      }
      else
        goto label_10;
    }

    [DebuggerStepThrough]
    private static PointF? \u001D\u0005(\u0001.\u0001 AB, RectangleF rec)
    {
      return \u0001.\u001D\u0005(AB, new \u0001.\u0001(rec.\u0081\u0005(), rec.\u0080\u0005()));
    }

    [DebuggerStepThrough]
    private static PointF? \u001E\u0005(\u0001.\u0001 AB, RectangleF rec)
    {
      return \u0001.\u001D\u0005(AB, new \u0001.\u0001(rec.\u0081\u0005(), rec.\u001E\u0005()));
    }

    [DebuggerStepThrough]
    private static PointF? \u001F\u0005(\u0001.\u0001 AB, RectangleF rec)
    {
      return \u0001.\u001D\u0005(AB, new \u0001.\u0001(rec.\u0080\u0005(), rec.\u001F\u0005()));
    }

    [DebuggerStepThrough]
    private static PointF? \u007F\u0005(\u0001.\u0001 AB, RectangleF rec)
    {
      return \u0001.\u001D\u0005(AB, new \u0001.\u0001(rec.\u001E\u0005(), rec.\u001F\u0005()));
    }

    [DebuggerStepThrough]
    public static PointF? \u001D\u0005(\u0001.\u0001 AB, \u0001.\u0001 CD)
    {
      double num1 = (double) AB.\u0001.Y - (double) CD.\u0001.Y;
      double num2 = (double) CD.\u0002.X - (double) CD.\u0001.X;
      double num3 = (double) AB.\u0001.X - (double) CD.\u0001.X;
      double num4 = (double) CD.\u0002.Y - (double) CD.\u0001.Y;
      double num5 = (double) AB.\u0002.X - (double) AB.\u0001.X;
      double num6 = (double) AB.\u0002.Y - (double) AB.\u0001.Y;
      double num7 = num5 * num4 - num6 * num2;
      double num8 = num1 * num2 - num3 * num4;
      if (num7 == 0.0)
      {
        if (num8 != 0.0)
          return new PointF?();
        if ((double) AB.\u0001.X >= (double) CD.\u0001.X && (double) AB.\u0001.X <= (double) CD.\u0002.X)
          return new PointF?(AB.\u0001);
        if ((double) CD.\u0001.X >= (double) AB.\u0001.X && (double) CD.\u0001.X <= (double) AB.\u0002.X)
          return new PointF?(CD.\u0001);
        return new PointF?();
      }
      double num9 = num8 / num7;
      if (num9 < 0.0 || num9 > 1.0)
        return new PointF?();
      double num10 = (num1 * num5 - num3 * num6) / num7;
      if (num10 < 0.0 || num10 > 1.0)
        return new PointF?();
      return new PointF?(new PointF(AB.\u0001.X + (float) (num9 * num5), AB.\u0001.Y + (float) (num9 * num6)));
    }

    [DebuggerStepThrough]
    public static uint \u001D\u0005(int left, int right)
    {
      return (uint) \u000F\u0081.\u009B\u0096(left - right);
    }

    [DebuggerStepThrough]
    public static float \u001D\u0005(PointF p1, PointF p2)
    {
      return (float) \u0007\u0081.\u009D\u0096(\u0007\u0081.\u0099\u0096(\u0090\u007F.\u009A\u0096((double) p2.X - (double) p1.X, 2.0) + \u0090\u007F.\u009A\u0096((double) p2.Y - (double) p1.Y, 2.0)));
    }

    [DebuggerStepThrough]
    public static double \u001D\u0005(double sideA, double sideB, double angleB)
    {
      return \u0001.\u001E\u0005(\u0007\u0081.\u008E\u0096(sideA * \u0007\u0081.\u0095\u0096(\u0001.\u001D\u0005(angleB)) / sideB));
    }

    [DebuggerStepThrough]
    public static double \u001D\u0005(double degrees)
    {
      return degrees * \u0001.\u0001;
    }

    [DebuggerStepThrough]
    public static double \u001E\u0005(double radians)
    {
      return radians * \u0001.\u0002;
    }

    [DebuggerStepThrough]
    public static float \u001D\u0005(Point p1, Point p2)
    {
      return (float) (((double) p1.Y - (double) p2.Y) / ((double) p1.X - (double) p2.X));
    }

    internal struct \u0001
    {
      public readonly PointF \u0001;
      public readonly PointF \u0002;

      [DebuggerStepThrough]
      public \u0001(PointF start, PointF end)
      {
        this.\u0001 = start;
        this.\u0002 = end;
      }
    }
  }
}
