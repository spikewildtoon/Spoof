// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u001E;
using \u007F;
using System;
using System.Drawing;
using System.IO;

namespace \u007F
{
  internal sealed class \u001F : IDisposable
  {
    private MemoryStream \u0001;
    private MemoryStream \u0002;

    public Bitmap UserGraphicData { get; private set; }

    public Bitmap ToonTownGraphicData { get; private set; }

    public \u001F(Bitmap userGraphicData, Bitmap toonTownGraphicData)
    {
      this.UserGraphicData = userGraphicData;
      this.ToonTownGraphicData = toonTownGraphicData;
    }

    public \u001F(byte[] userGraphicData, byte[] toonTownGraphicData)
    {
      if (userGraphicData != null)
        goto label_4;
label_2:
      if (toonTownGraphicData == null)
        return;
      this.\u0002 = new MemoryStream();
      toonTownGraphicData.\u001D\u0005((Stream) this.\u0002);
      this.ToonTownGraphicData = (Bitmap) \u0099\u001C.\u001C\u001F((Stream) this.\u0002);
      return;
label_4:
      this.\u0001 = new MemoryStream();
      userGraphicData.\u001D\u0005((Stream) this.\u0001);
      this.UserGraphicData = (Bitmap) \u0099\u001C.\u001C\u001F((Stream) this.\u0001);
      goto label_2;
    }

    public static \u001F \u001D\u0005(byte[] userGraphicData, byte[] toonTownGraphicData)
    {
      \u001F obj = (\u001F) null;
      try
      {
        return new \u001F(userGraphicData, toonTownGraphicData);
      }
      catch (Exception ex)
      {
        if (obj != null)
          obj.Dispose();
        ex.\u001D\u0005();
        return (\u001F) null;
      }
    }

    public void Dispose()
    {
      if (this.UserGraphicData != null)
        \u001A\u001E.\u007E\u001D\u001F((object) this.UserGraphicData);
      if (this.ToonTownGraphicData != null)
        \u001A\u001E.\u007E\u001D\u001F((object) this.ToonTownGraphicData);
      if (this.\u0001 != null)
        \u001A\u001E.\u007E\u0086\u009D((object) this.\u0001);
      if (this.\u0002 == null)
        return;
      \u001A\u001E.\u007E\u0086\u009D((object) this.\u0002);
    }
  }
}
