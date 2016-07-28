// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace \u0082
{
  internal sealed class \u001B
  {
    public static Image \u001D\u0005(string text, Font font, Color forecolor, Color glowColor, StringFormat sf, Size layout, int blurAmount = 6)
    {
      Bitmap bitmap1 = (Bitmap) null;
      Graphics graphics1 = \u001B\u0084.\u001C\u007F(IntPtr.Zero);
      try
      {
        SizeF size = \u0002\u0081.\u007E\u009C\u007F((object) graphics1, text, font, \u008D\u001F.\u0002\u0081(layout), sf);
        Bitmap bitmap2 = new Bitmap((int) size.Width, (int) size.Height);
        try
        {
          Graphics graphics2 = \u0005\u0087.\u001D\u007F((Image) bitmap2);
          try
          {
            SolidBrush solidBrush1 = new SolidBrush(\u001B\u001C.\u0015\u007F(16, (int) glowColor.R, (int) glowColor.G, (int) glowColor.B));
            try
            {
              SolidBrush solidBrush2 = new SolidBrush(forecolor);
              try
              {
                \u0015\u0083.\u007E\u0081\u007F((object) graphics2, SmoothingMode.HighQuality);
                \u0094\u0081.\u007E\u0083\u007F((object) graphics2, InterpolationMode.HighQualityBilinear);
                \u0008\u0083.\u007E\u0080\u007F((object) graphics2, TextRenderingHint.AntiAliasGridFit);
                \u009F\u0084.\u007E\u009B\u007F((object) graphics2, text, font, (Brush) solidBrush1, new RectangleF(PointF.Empty, size), sf);
                try
                {
                  bitmap1 = new Bitmap(\u0005\u0081.\u007E\u007F\u001F((object) bitmap2) + blurAmount, \u0005\u0081.\u007E\u0080\u001F((object) bitmap2) + blurAmount);
                  Graphics graphics3 = \u0005\u0087.\u001D\u007F((Image) bitmap1);
                  try
                  {
                    \u0015\u0083.\u007E\u0081\u007F((object) graphics3, SmoothingMode.AntiAlias);
                    \u0094\u0081.\u007E\u0083\u007F((object) graphics3, InterpolationMode.HighQualityBilinear);
                    \u0008\u0083.\u007E\u0080\u007F((object) graphics3, TextRenderingHint.AntiAliasGridFit);
                    for (int index1 = 0; index1 <= blurAmount; ++index1)
                    {
                      for (int index2 = 0; index2 <= blurAmount; ++index2)
                        \u0083\u001D.\u007E\u0001\u0080((object) graphics3, (Image) bitmap2, index1, index2);
                    }
                    \u009F\u0084.\u007E\u009B\u007F((object) graphics3, text, font, (Brush) solidBrush2, new RectangleF(new PointF((float) (blurAmount / 2), (float) (blurAmount / 2)), size), sf);
                  }
                  finally
                  {
                    if (graphics3 != null)
                      \u001A\u001E.\u007E\u0094\u0092((object) graphics3);
                  }
                }
                catch
                {
                  if (bitmap1 != null)
                    \u001A\u001E.\u007E\u001D\u001F((object) bitmap1);
                  bitmap1 = (Bitmap) null;
                  throw;
                }
              }
              finally
              {
                if (solidBrush2 != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) solidBrush2);
              }
            }
            finally
            {
              if (solidBrush1 != null)
                \u001A\u001E.\u007E\u0094\u0092((object) solidBrush1);
            }
          }
          finally
          {
            if (graphics2 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) graphics2);
          }
        }
        finally
        {
          if (bitmap2 != null)
            \u001A\u001E.\u007E\u0094\u0092((object) bitmap2);
        }
      }
      finally
      {
        if (graphics1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) graphics1);
      }
      return (Image) bitmap1;
    }

    public static void \u001D\u0005(Graphics gr, Font Font, string text, float outlineSize, RectangleF layout, Color textColor, Color borderColor, StringFormat sf)
    {
      \u0015\u0083.\u007E\u0081\u007F((object) gr, SmoothingMode.AntiAlias);
      \u0008\u0083.\u007E\u0080\u007F((object) gr, TextRenderingHint.AntiAlias);
      float num = (float) ((double) \u0094\u0084.\u007E\u0084\u007F((object) gr) * (double) \u0094\u0084.\u007E\u0097\u0081((object) Font) / 72.0);
      if ((double) outlineSize > 0.0)
      {
        GraphicsPath graphicsPath = new GraphicsPath();
        try
        {
          \u0082\u001F.\u007E\u0005\u0082((object) graphicsPath, text, \u009D\u001D.\u007E\u008E\u0081((object) Font), 0, num, layout, sf);
          \u0091\u007F.\u007E\u0007\u0082((object) graphicsPath, \u0012\u001E.\u0017\u0080());
          SolidBrush solidBrush = new SolidBrush(borderColor);
          try
          {
            \u0098\u0081.\u007E\u0098\u007F((object) gr, (Brush) solidBrush, graphicsPath);
          }
          finally
          {
            if (solidBrush != null)
              \u001A\u001E.\u007E\u0094\u0092((object) solidBrush);
          }
        }
        finally
        {
          if (graphicsPath != null)
            \u001A\u001E.\u007E\u0094\u0092((object) graphicsPath);
        }
      }
      GraphicsPath graphicsPath1 = new GraphicsPath();
      try
      {
        \u0082\u001F.\u007E\u0005\u0082((object) graphicsPath1, text, \u009D\u001D.\u007E\u008E\u0081((object) Font), 0, num, layout, sf);
        SolidBrush solidBrush = new SolidBrush(textColor);
        try
        {
          \u0098\u0081.\u007E\u0098\u007F((object) gr, (Brush) solidBrush, graphicsPath1);
        }
        finally
        {
          if (solidBrush != null)
            \u001A\u001E.\u007E\u0094\u0092((object) solidBrush);
        }
      }
      finally
      {
        if (graphicsPath1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) graphicsPath1);
      }
    }
  }
}
