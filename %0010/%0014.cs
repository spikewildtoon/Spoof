// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0006;
using \u0007;
using System.Runtime.InteropServices;

namespace \u0010
{
  [TypeLibType(TypeLibTypeFlags.FHidden)]
  [ClassInterface(ClassInterfaceType.None)]
  internal sealed class \u0014 : \u0080
  {
    public \u0001 \u0001;
    public \u0002 \u0001;
    public int \u0001;

    internal \u0014()
    {
      this.\u0001 = 0;
      this.\u0001 = (\u0001) null;
      this.\u0001 = (\u0002) null;
    }

    public virtual void onvideostart()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001();
    }

    public virtual void onvideoend()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001();
    }
  }
}
