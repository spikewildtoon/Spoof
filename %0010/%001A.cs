// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0008;
using System.Runtime.InteropServices;

namespace \u0010
{
  [ClassInterface(ClassInterfaceType.None)]
  [TypeLibType(TypeLibTypeFlags.FHidden)]
  internal sealed class \u001A : \u001C
  {
    public \u001F \u0001;
    public \u007F \u0001;
    public \u0080 \u0001;
    public int \u0001;

    internal \u001A()
    {
      this.\u0001 = 0;
      this.\u0001 = (\u001F) null;
      this.\u0001 = (\u007F) null;
      this.\u0001 = (\u0080) null;
    }

    public virtual void ondragbegin()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001();
    }

    public virtual void ondragend()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001();
    }

    public virtual void onpositionchange()
    {
      if (this.\u0001 == null)
        return;
      this.\u0001();
    }
  }
}
