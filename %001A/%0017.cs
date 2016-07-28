// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Drawing;

namespace \u001A
{
  internal static class \u0017
  {
    public static Size \u001D\u0005(this Size sz, Size max)
    {
      if (sz.Width > max.Width)
        sz.Width = max.Width;
      if (sz.Height > max.Height)
        sz.Height = max.Height;
      return sz;
    }

    public static bool \u001D\u0005(this Size sz)
    {
      if (sz.Width != 0)
        return sz.Height != 0;
      return false;
    }

    public static Size \u001D\u0005(this Size sz, int maxWidth, int maxHeight)
    {
      if (sz.Width > maxWidth)
      {
        sz.Height = (int) ((double) maxWidth / (double) sz.Width * (double) sz.Height);
        sz.Width = maxWidth;
      }
      if (sz.Height > maxHeight)
      {
        sz.Width = (int) ((double) maxHeight / (double) sz.Height * (double) sz.Width);
        sz.Height = maxHeight;
      }
      return sz;
    }

    public static Size \u001D\u0005(this Size sz, float scale)
    {
      return new Size((int) \u0007\u0081.\u0091\u0096((double) sz.Width * (double) scale), (int) \u0007\u0081.\u0091\u0096((double) sz.Height * (double) scale));
    }
  }
}
