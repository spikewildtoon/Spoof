// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001B;
using System;
using System.Drawing.Imaging;

namespace \u001B
{
  internal static class \u0017
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0017()
    {
      \u0004.\u001D\u0005(typeof (\u0017));
    }

    public static string \u001D\u0005(this PixelFormat format)
    {
      switch (format)
      {
        case PixelFormat.Format32bppArgb:
          return \u0017.\u0001(55105);
        case PixelFormat.Format64bppArgb:
          return \u0017.\u0001(55180);
        case PixelFormat.Format48bppRgb:
          return \u0017.\u0001(55130);
        case PixelFormat.Format64bppPArgb:
          return \u0017.\u0001(55205);
        case PixelFormat.Format16bppArgb1555:
        case PixelFormat.Format16bppGrayScale:
        case PixelFormat.Format16bppRgb555:
        case PixelFormat.Format16bppRgb565:
          return \u0017.\u0001(54831);
        case PixelFormat.Format32bppPArgb:
          return \u0017.\u0001(54902);
        case PixelFormat.Format1bppIndexed:
          return \u0017.\u0001(54856);
        case PixelFormat.Format4bppIndexed:
          return \u0017.\u0001(55155);
        case PixelFormat.Format8bppIndexed:
          return \u0017.\u0001(55343);
        case PixelFormat.Format24bppRgb:
          return \u0017.\u0001(54877);
        case PixelFormat.Format32bppRgb:
          return \u0017.\u0001(55040);
        default:
          return \u0017.\u0001(55368);
      }
    }
  }
}
