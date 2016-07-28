// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0006;
using System.Runtime.InteropServices;

namespace \u0010
{
  [TypeLibType(TypeLibTypeFlags.FHidden)]
  [ClassInterface(ClassInterfaceType.None)]
  internal sealed class \u0016 : \u0019
  {
    public \u001C \u0001;
    public \u001D \u0001;
    public \u001E \u0001;
    public int \u0001;

    internal \u0016()
    {
      this.\u0001 = 0;
      this.\u0001 = (\u001C) null;
      this.\u0001 = (\u001D) null;
      this.\u0001 = (\u001E) null;
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
