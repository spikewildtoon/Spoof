// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0017;
using \u0083;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace \u0083
{
  internal sealed class \u0011
  {
    public static void \u001D\u0005(Graphics g, RectangleF drawRectF, Color drawColor, Orientation orientation)
    {
      Color color1_1 = \u0018.\u001D\u0005(\u0018.\u001E\u0005(drawColor, \u009A\u0080.\u0090\u001F(), 100), \u009A\u0080.\u0008\u007F(), 40);
      Color color1 = \u0018.\u001D\u0005(\u0018.\u001E\u0005(drawColor, \u008E\u001D.\u0017\u007F(64, 64, 64), 100), \u009A\u0080.\u0008\u007F(), 20);
      Color color2 = \u0018.\u001E\u0005(drawColor, \u008E\u001D.\u0017\u007F(128, 128, 128), 100);
      Color color3 = \u0018.\u001E\u0005(drawColor, \u008E\u001D.\u0017\u007F(192, 192, 192), 100);
      Color color2_1 = \u0018.\u001F\u0005(\u0018.\u001E\u0005(drawColor, \u009A\u0080.\u0008\u007F(), 100), \u009A\u0080.\u0008\u007F(), 75);
      ColorBlend colorBlend = new ColorBlend();
      \u008A\u0086.\u007E\u0080\u0081((object) colorBlend, new Color[5]
      {
        color1_1,
        color1,
        color2,
        color3,
        color2_1
      });
      colorBlend.Positions = new float[5]
      {
        0.0f,
        0.25f,
        0.5f,
        0.75f,
        1f
      };
      LinearGradientBrush linearGradientBrush1 = orientation == Orientation.Horizontal ? new LinearGradientBrush(new Point((int) drawRectF.Left, (int) drawRectF.Top - 1), new Point((int) drawRectF.Left, (int) drawRectF.Top + (int) drawRectF.Height + 1), color1_1, color2_1) : new LinearGradientBrush(new Point((int) drawRectF.Left - 1, (int) drawRectF.Top), new Point((int) drawRectF.Left + (int) drawRectF.Width + 1, (int) drawRectF.Top), color1_1, color2_1);
      try
      {
        \u0093\u001E.\u007E\u0016\u0082((object) linearGradientBrush1, colorBlend);
        \u0011.\u001D\u0005(g, drawRectF, (Brush) linearGradientBrush1);
      }
      finally
      {
        if (linearGradientBrush1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) linearGradientBrush1);
      }
      Color color1_2 = \u009A\u0080.\u0008\u007F();
      \u008A\u0086.\u007E\u0080\u0081((object) colorBlend, new Color[4]
      {
        color1_2,
        color2,
        color3,
        color2_1
      });
      colorBlend.Positions = new float[4]
      {
        0.0f,
        0.5f,
        0.75f,
        1f
      };
      LinearGradientBrush linearGradientBrush2 = orientation == Orientation.Horizontal ? new LinearGradientBrush(new Point((int) drawRectF.Left + 1, (int) drawRectF.Top), new Point((int) drawRectF.Left + 1, (int) drawRectF.Top + (int) drawRectF.Height - 1), color1_2, color2_1) : new LinearGradientBrush(new Point((int) drawRectF.Left, (int) drawRectF.Top + 1), new Point((int) drawRectF.Left + (int) drawRectF.Width - 1, (int) drawRectF.Top + 1), color1_2, color2_1);
      try
      {
        \u0093\u001E.\u007E\u0016\u0082((object) linearGradientBrush2, colorBlend);
        \u0011.\u001D\u0005(g, \u0092\u0083.\u0096\u0082(drawRectF, -3f, -3f), (Brush) linearGradientBrush2);
      }
      finally
      {
        if (linearGradientBrush2 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) linearGradientBrush2);
      }
    }

    public static void \u001E\u0005(Graphics g, RectangleF drawRectF, Color drawColor, Orientation orientation)
    {
      Color color1 = drawColor;
      Color color2 = \u0083\u001C.\u0094\u0089(color1);
      Color color3 = \u0083\u001C.\u0094\u0089(color2);
      Color color2_1 = \u0083\u001C.\u0094\u0089(color3);
      ColorBlend colorBlend = new ColorBlend();
      \u008A\u0086.\u007E\u0080\u0081((object) colorBlend, new Color[4]
      {
        color1,
        color2,
        color3,
        color2_1
      });
      colorBlend.Positions = new float[4]
      {
        0.0f,
        0.25f,
        0.65f,
        1f
      };
      LinearGradientBrush linearGradientBrush = orientation == Orientation.Horizontal ? new LinearGradientBrush(new Point((int) drawRectF.Left, (int) drawRectF.Top), new Point((int) drawRectF.Left, (int) drawRectF.Top + (int) drawRectF.Height), color1, color2_1) : new LinearGradientBrush(new Point((int) drawRectF.Left, (int) drawRectF.Top), new Point((int) drawRectF.Left + (int) drawRectF.Width, (int) drawRectF.Top), color1, color2_1);
      try
      {
        \u0093\u001E.\u007E\u0016\u0082((object) linearGradientBrush, colorBlend);
        \u0011.\u001D\u0005(g, drawRectF, (Brush) linearGradientBrush);
      }
      finally
      {
        if (linearGradientBrush != null)
          \u001A\u001E.\u007E\u0094\u0092((object) linearGradientBrush);
      }
    }

    public static void \u001D\u0005(Graphics g, RectangleF rect, Brush b)
    {
      if ((double) rect.Width > (double) rect.Height)
      {
        \u008A\u001E.\u007E\u0096\u007F((object) g, b, new RectangleF(rect.Left, rect.Top, rect.Height, rect.Height));
        \u008A\u001E.\u007E\u0096\u007F((object) g, b, new RectangleF(rect.Left + rect.Width - rect.Height, rect.Top, rect.Height, rect.Height));
        float width = rect.Width - rect.Height;
        float x = rect.Left + rect.Height / 2f;
        \u008A\u001E.\u007E\u0092\u007F((object) g, b, new RectangleF(x, rect.Top, width, rect.Height));
      }
      else if ((double) rect.Width < (double) rect.Height)
      {
        \u008A\u001E.\u007E\u0096\u007F((object) g, b, new RectangleF(rect.Left, rect.Top, rect.Width, rect.Width));
        \u008A\u001E.\u007E\u0096\u007F((object) g, b, new RectangleF(rect.Left, rect.Top + rect.Height - rect.Width, rect.Width, rect.Width));
        float y = rect.Top + rect.Width / 2f;
        float height = rect.Height - rect.Width;
        \u008A\u001E.\u007E\u0092\u007F((object) g, b, new RectangleF(rect.Left, y, rect.Width, height));
      }
      else
      {
        if ((double) rect.Width != (double) rect.Height)
          return;
        \u008A\u001E.\u007E\u0096\u007F((object) g, b, rect);
      }
    }
  }
}
