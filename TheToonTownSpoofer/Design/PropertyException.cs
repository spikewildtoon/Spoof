// Decompiled with JetBrains decompiler
// Type: TheToonTownSpoofer.Design.PropertyException
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace TheToonTownSpoofer.Design
{
  [Serializable]
  public sealed class PropertyException : Exception
  {
    public PropertyException(string message)
      : base(message)
    {
    }

    private PropertyException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      \u0001\u0083.\u0092\u0091((object) this, info, context);
    }
  }
}
