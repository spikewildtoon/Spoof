// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Drawing;
using System.Drawing.Drawing2D;

namespace \u001D
{
  internal static class \u001F
  {
    public static GraphicsPath \u001D\u0005(Rectangle rec)
    {
      GraphicsPath graphicsPath = (GraphicsPath) null;
      try
      {
        graphicsPath = new GraphicsPath();
        \u001A\u001E.\u007E\u009C\u0081((object) graphicsPath);
        \u000E\u0080.\u007E\u0002\u0082((object) graphicsPath, rec);
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
