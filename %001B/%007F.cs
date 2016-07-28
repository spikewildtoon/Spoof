// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001B;
using System;
using System.ComponentModel;
using System.Globalization;

namespace \u001B
{
  internal sealed class \u007F : TypeConverter
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u007F()
    {
      \u0004.\u001D\u0005(typeof (\u007F));
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      // ISSUE: type reference
      if (\u0091\u001F.\u001A\u0097(destinationType, \u009C\u0082.\u0016\u0097(__typeref (string))))
        return (object) \u007F.\u0001(4610);
      return \u0016\u0080.\u001D\u0001\u0002((object) this, context, culture, value, destinationType);
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      // ISSUE: type reference
      if (\u0091\u001F.\u001A\u0097(sourceType, \u009C\u0082.\u0016\u0097(__typeref (string))))
        return false;
      return \u007F\u007F.\u001B\u0001\u0002((object) this, context, sourceType);
    }
  }
}
