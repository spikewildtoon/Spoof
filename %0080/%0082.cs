// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001A;
using \u001E;
using \u0080;
using System;
using System.Windows.Forms;

namespace \u0080
{
  internal static class \u0082
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;

    static \u0082()
    {
      \u0004.\u001D\u0005(typeof (\u0082));
      \u0082.\u0001 = \u0082.\u0001(93664);
      \u0082.\u0002 = \u0082.\u0001(93693);
      \u0082.\u0003 = \u0082.\u0001(93750);
      \u0082.\u0004 = \u0082.\u0001(93787);
      \u0082.\u0005 = \u0082.\u0001(93929);
    }

    public static void \u001D\u0005(\u0002 topic)
    {
      try
      {
        if (!topic.\u001D\u0005())
          topic = \u0002.\u0001;
        Control control = new Control();
        try
        {
          \u001A\u001E.\u007E\u009C\u0084((object) control);
          if (\u008F\u0084.\u0092\u009E(\u007F.\u001E))
            \u0003\u0087.\u0002\u008C(control, \u007F.\u001E, HelpNavigator.TopicId, (object) ((int) topic).ToString((IFormatProvider) \u0013.\u0001));
          else
            \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0082.\u0004, new object[1]
            {
              (object) \u009C\u0080.\u0008\u009F(\u007F.\u001E)
            }), \u0082.\u0005);
        }
        finally
        {
          if (control != null)
            \u001A\u001E.\u007E\u0094\u0092((object) control);
        }
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0082.\u0001, new object[1]
        {
          (object) \u007F.\u001E
        }));
        \u0017.\u001E\u0005(\u0082.\u0002, \u0082.\u0003);
      }
    }
  }
}
