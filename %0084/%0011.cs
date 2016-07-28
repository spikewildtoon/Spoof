// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0084;
using System;
using System.ComponentModel;
using System.Globalization;
using TheToonTownSpoofer.Design;

namespace \u0084
{
  internal sealed class \u0011 : TypeConverter
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0011()
    {
      \u0004.\u001D\u0005(typeof (\u0011));
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
      // ISSUE: type reference
      if (\u0091\u001F.\u001A\u0097(destinationType, \u009C\u0082.\u0016\u0097(__typeref (string))))
        return (object) \u0002\u007F.\u007E\u0087\u0091(value);
      return \u0016\u0080.\u001D\u0001\u0002((object) this, context, culture, value, destinationType);
    }

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
      // ISSUE: type reference
      if (\u0091\u001F.\u001A\u0097(destinationType, \u009C\u0082.\u0016\u0097(__typeref (Version))))
        return true;
      return \u007F\u007F.\u001C\u0001\u0002((object) this, context, destinationType);
    }

    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
      string str = value as string;
      if (\u008F\u0084.\u009E\u0092(str))
        return (object) new Version(0, 0, 0, 0);
      Version version;
      if (!\u0095\u001B.\u0012\u0098(str, ref version))
        throw new PropertyException(\u0011.\u0001(106151));
      return (object) version;
    }

    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
      // ISSUE: type reference
      if (\u0091\u001F.\u001A\u0097(sourceType, \u009C\u0082.\u0016\u0097(__typeref (string))))
        return true;
      return \u007F\u007F.\u001B\u0001\u0002((object) this, context, sourceType);
    }
  }
}
