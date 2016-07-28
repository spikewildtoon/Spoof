// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0019;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace \u0081
{
  internal static class \u001F
  {
    public static GraphicsPath \u001D\u0005(Rectangle rect, int radius, \u001A corners)
    {
      int num1 = rect.X + rect.Width;
      int num2 = rect.Y + rect.Height;
      int num3 = num1 - radius;
      int num4 = num2 - radius;
      int num5 = rect.X + radius;
      int num6 = rect.Y + radius;
      int num7 = radius * 2;
      int num8 = num1 - num7;
      int num9 = num2 - num7;
      GraphicsPath graphicsPath = (GraphicsPath) null;
      try
      {
        graphicsPath = new GraphicsPath();
        \u001A\u001E.\u007E\u009C\u0081((object) graphicsPath);
        if (\u0095\u001C.\u0099\u0091((object) corners, (Enum) \u001A.\u0002))
        {
          \u0096\u0080.\u007E\u009F\u0081((object) graphicsPath, rect.X, rect.Y, num7, num7, 180f, 90f);
        }
        else
        {
          \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, rect.X, num6, rect.X, rect.Y);
          \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, rect.X, rect.Y, num5, rect.Y);
        }
        \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, num5, rect.Y, num3, rect.Y);
        if (\u0095\u001C.\u0099\u0091((object) corners, (Enum) \u001A.\u0003))
        {
          \u0096\u0080.\u007E\u009F\u0081((object) graphicsPath, num8, rect.Y, num7, num7, 270f, 90f);
        }
        else
        {
          \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, num3, rect.Y, num1, rect.Y);
          \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, num1, rect.Y, num1, num6);
        }
        \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, num1, num6, num1, num4);
        if (\u0095\u001C.\u0099\u0091((object) corners, (Enum) \u001A.\u0005))
        {
          \u0096\u0080.\u007E\u009F\u0081((object) graphicsPath, num8, num9, num7, num7, 0.0f, 90f);
        }
        else
        {
          \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, num1, num4, num1, num2);
          \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, num1, num2, num3, num2);
        }
        \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, num3, num2, num5, num2);
        if (\u0095\u001C.\u0099\u0091((object) corners, (Enum) \u001A.\u0004))
        {
          \u0096\u0080.\u007E\u009F\u0081((object) graphicsPath, rect.X, num9, num7, num7, 90f, 90f);
        }
        else
        {
          \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, num5, num2, rect.X, num2);
          \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, rect.X, num2, rect.X, num4);
        }
        \u0093\u0080.\u007E\u009E\u0081((object) graphicsPath, rect.X, num4, rect.X, num6);
        \u001A\u001E.\u007E\u009D\u0081((object) graphicsPath);
        return graphicsPath;
      }
      catch
      {
        if (graphicsPath != null)
          \u001A\u001E.\u007E\u009A\u0081((object) graphicsPath);
        throw;
      }
    }
  }
}
