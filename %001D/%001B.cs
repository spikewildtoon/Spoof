// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001D;
using \u001E;
using System;

namespace \u001D
{
  internal class \u001B
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly int \u0001;
    protected uint \u0001;
    protected bool \u0001;
    protected uint \u0002;
    protected ushort \u0001;
    protected byte[] \u0001;
    protected uint \u0003;
    protected bool \u0002;

    public bool Populated
    {
      get
      {
        return this.\u0001;
      }
    }

    public DateTime TimeStamp
    {
      get
      {
        return \u007F.\u0001.AddSeconds((double) this.\u0002).ToLocalTime();
      }
      set
      {
        this.\u0002 = (uint) value.ToUniversalTime().Subtract(\u007F.\u0001).TotalSeconds;
      }
    }

    public bool Compressed
    {
      get
      {
        return ((int) this.\u0001 & \u001B.\u0001) == \u001B.\u0001;
      }
    }

    public byte[] Data
    {
      get
      {
        if (!this.\u0001)
          throw new InvalidOperationException(\u001B.\u0001(64179));
        if (this.Compressed)
          return \u0018.\u0018.\u001E\u0005(this.\u0001);
        return this.\u0001;
      }
      set
      {
        if (value == null)
        {
          if (!this.\u0002)
          {
            this.\u0001 = 0U;
            this.\u0003 = 0U;
          }
          this.\u0001 = (byte[]) null;
          this.\u0001 = false;
        }
        else
        {
          this.\u0001 = !this.Compressed ? value : \u0018.\u0018.\u001D\u0005(value);
          this.\u0001 = (uint) value.Length;
          this.\u0003 = (uint) this.\u0001.Length;
          this.\u0001 = true;
        }
      }
    }

    static \u001B()
    {
      \u0004.\u001D\u0005(typeof (\u001B));
      \u001B.\u0001 = 8;
    }

    protected \u001B()
    {
    }

    public void \u001D\u0005(\u001B data)
    {
      data.\u0001 = this.\u0001;
      data.\u0003 = this.\u0003;
      data.\u0001 = this.\u0001;
      data.\u0001 = data.\u0001 != null;
      data.\u0002 = false;
    }
  }
}
