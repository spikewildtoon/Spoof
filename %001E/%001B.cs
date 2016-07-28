// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0015;
using \u001A;
using \u001C;
using \u0081;
using \u0083;
using \u0084;
using System;
using System.ComponentModel;

namespace \u001E
{
  internal static class \u001B
  {
    public static \u0016.\u0081 \u001D\u0005(this OperatingSystem os)
    {
      \u0018 osVersionInfo = new \u0018();
      // ISSUE: type reference
      osVersionInfo.\u0001 = (uint) \u0082\u001D.\u0005\u009D(\u009C\u0082.\u0016\u0097(__typeref (\u0018)));
      if (!\u000E.\u001D\u0005(out osVersionInfo))
        throw new Win32Exception();
      \u0016.\u0081 obj = \u0016.\u0081.\u0001;
      \u001E lpSystemInfo = new \u001E();
      \u000E.\u001D\u0005(out lpSystemInfo);
      switch (osVersionInfo.\u0001)
      {
        case \u0011.\u0001:
          obj = \u0016.\u0081.\u0002;
          break;
        case \u0011.\u0002:
          if ((int) osVersionInfo.\u0002 == 4)
          {
            switch (osVersionInfo.\u0003)
            {
              case 0:
                obj = (int) \u008C\u0086.\u007E\u009C\u0092((object) osVersionInfo.\u0001, 0) == 66 || (int) \u008C\u0086.\u007E\u009C\u0092((object) osVersionInfo.\u0001, 0) == 67 ? \u0016.\u0081.\u0004 : \u0016.\u0081.\u0003;
                break;
              case 10:
                obj = (int) \u008C\u0086.\u007E\u009C\u0092((object) osVersionInfo.\u0001, 0) != 65 ? \u0016.\u0081.\u0005 : \u0016.\u0081.\u0006;
                break;
              case 90:
                obj = \u0016.\u0081.\u0007;
                break;
            }
          }
          else
            break;
        case \u0011.\u0003:
          switch (osVersionInfo.\u0002)
          {
            case 3:
              obj = \u0016.\u0081.\u0008;
              break;
            case 4:
              switch (osVersionInfo.\u0001)
              {
                case \u007F.\u0003:
                  obj = \u0016.\u0081.\u000E;
                  break;
                case \u007F.\u0002:
                  obj = \u0016.\u0081.\u000F;
                  break;
              }
            case 5:
              switch (osVersionInfo.\u0003)
              {
                case 0:
                  obj = \u0016.\u0081.\u0010;
                  break;
                case 1:
                  obj = \u0016.\u0081.\u0011;
                  break;
                case 2:
                  obj = !\u0095\u001C.\u0099\u0091((object) osVersionInfo.\u0001, (Enum) \u0010.\u0012) ? (osVersionInfo.\u0001 != \u007F.\u0003 || lpSystemInfo.\u0001 != \u0019.\u0001 ? (\u000E.\u001D\u0005(\u0010.\u0087\u0002) == 0 ? \u0016.\u0081.\u0014 : \u0016.\u0081.\u0015) : \u0016.\u0081.\u0012) : \u0016.\u0081.\u0013;
                  break;
              }
            case 6:
              switch (osVersionInfo.\u0003)
              {
                case 0:
                  obj = osVersionInfo.\u0001 == \u007F.\u0003 ? \u0016.\u0081.\u0016 : \u0016.\u0081.\u0017;
                  break;
                case 1:
                  obj = osVersionInfo.\u0001 == \u007F.\u0003 ? \u0016.\u0081.\u0019 : \u0016.\u0081.\u0018;
                  break;
                default:
                  if (osVersionInfo.\u0003 > 1U)
                  {
                    obj = \u0016.\u0081.\u001A;
                    break;
                  }
                  break;
              }
            default:
              if (osVersionInfo.\u0002 > 6U)
              {
                obj = \u0016.\u0081.\u001A;
                break;
              }
              break;
          }
      }
      return obj;
    }
  }
}
