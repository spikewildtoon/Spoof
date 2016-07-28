// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Drawing;
using System.Drawing.Imaging;

namespace \u001A
{
  internal static class \u0018
  {
    public static void \u001D\u0005(this Graphics gr, Image image, Rectangle rect, float opacity)
    {
      ColorMatrix colorMatrix = new ColorMatrix();
      \u0082\u001E.\u007E\u0083\u0081((object) colorMatrix, opacity);
      ImageAttributes imageAttributes = new ImageAttributes();
      try
      {
        \u009C\u0086.\u007E\u000F\u0082((object) imageAttributes, colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
        \u0098\u0084.\u007E\u0003\u0080((object) gr, image, rect, 0, 0, \u0005\u0081.\u007E\u007F\u001F((object) image), \u0005\u0081.\u007E\u0080\u001F((object) image), GraphicsUnit.Pixel, imageAttributes);
      }
      finally
      {
        if (imageAttributes != null)
          \u001A\u001E.\u007E\u0094\u0092((object) imageAttributes);
      }
    }
  }
}
