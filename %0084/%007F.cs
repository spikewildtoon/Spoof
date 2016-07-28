// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace \u0084
{
  internal static class \u007F
  {
    public static void \u001D\u0005(Point[] pnts, GraphicsPath gp, Point hs)
    {
      \u001A\u001E.\u007E\u009B\u0081((object) gp);
      \u001A\u001E.\u007E\u009C\u0081((object) gp);
      for (int index = 0; index < pnts.Length - 1; ++index)
        \u0093\u0080.\u007E\u009E\u0081((object) gp, hs.X + pnts[index].X, hs.Y + pnts[index].Y, hs.X + pnts[index + 1].X, hs.Y + pnts[index + 1].Y);
      \u001A\u001E.\u007E\u009D\u0081((object) gp);
    }

    public static void \u001D\u0005(int degrees, Point[] points)
    {
      degrees %= 360;
      double num1 = Math.PI / 180.0 * (double) degrees;
      double num2 = \u0007\u0081.\u0092\u0096(num1);
      double num3 = \u0007\u0081.\u0095\u0096(num1);
      for (int index = 0; index < 8; ++index)
      {
        int x = points[index].X;
        int y = points[index].Y;
        double num4 = (double) x * num2 - (double) y * num3;
        double num5 = (double) y * num2 + (double) x * num3;
        points[index].X = (int) num4;
        points[index].Y = (int) num5;
      }
    }

    public static void \u001D\u0005(int dx, int m_nRotDeg, ref Point m_CntPnt, Point[] m_pnts)
    {
      if (m_nRotDeg >= 0 && m_nRotDeg <= 90)
        goto label_20;
label_5:
      if (m_nRotDeg >= 91 && m_nRotDeg <= 180)
      {
        int num1 = m_pnts[0].Y - dx / 2;
        if (num1 > 0)
          m_CntPnt.Y += num1;
        int num2 = m_pnts[1].X + dx / 2;
        if (num2 < 0)
          m_CntPnt.X -= num2;
      }
      if (m_nRotDeg >= 181 && m_nRotDeg <= 270)
      {
        int num1 = m_pnts[1].Y + dx / 2;
        if (num1 < 0)
          m_CntPnt.Y -= num1;
        int num2 = m_pnts[1].X + dx / 2;
        if (num2 < 0)
          m_CntPnt.X -= num2;
      }
      if (m_nRotDeg < 271 || m_nRotDeg > 360)
        return;
      int num3 = m_pnts[0].Y - dx / 2;
      if (num3 > 0)
        m_CntPnt.Y += num3;
      int num4 = m_pnts[1].X - dx / 2;
      if (num4 <= 0)
        return;
      m_CntPnt.X -= num4;
      return;
label_20:
      int num5 = m_pnts[1].Y - dx / 2;
      if (num5 > 0)
        goto label_21;
label_3:
      int num6 = m_pnts[0].X + dx / 2;
      if (num6 < 0)
      {
        m_CntPnt.X -= num6;
        goto label_5;
      }
      else
        goto label_5;
label_21:
      m_CntPnt.Y -= num5;
      goto label_3;
    }

    public static void \u001D\u0005(int dx, out Point[] points)
    {
      points = new Point[8];
      points[0] = new Point(-dx / 4, dx / 2);
      points[1] = new Point(dx / 4, dx / 2);
      points[2] = new Point(dx / 4, 0);
      points[3] = new Point(dx / 2, 0);
      points[4] = new Point(0, -dx / 2);
      points[5] = new Point(-dx / 2, 0);
      points[6] = new Point(-dx / 4, 0);
      points[7] = new Point(-dx / 4, dx / 2);
    }
  }
}
