// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0019;
using \u001F;
using \u0080;
using \u0084;
using System;

namespace \u0080
{
  internal static class \u0007
  {
    [NonSerialized]
    internal static \u0002 \u0001;

    static \u0007()
    {
      \u0004.\u001D\u0005(typeof (\u0007));
    }

    public static string \u001D\u0005(this \u0016 type)
    {
      switch (type)
      {
        case \u0016.\u0002:
          return \u0007.\u0001(81624);
        case \u0016.\u0003:
          return \u0007.\u0001(81637);
        case \u0016.\u0004:
          return \u0007.\u0001(81650);
        case \u0016.\u0005:
          return \u0007.\u0001(81659);
        default:
          return \u0007.\u0001(30770);
      }
    }

    public static string \u001D\u0005(this \u0014.\u007F house)
    {
      switch (house)
      {
        case \u0014.\u007F.\u0001:
          return \u0007.\u0001(45562);
        case \u0014.\u007F.\u0002:
          return \u0007.\u0001(45596);
        case \u0014.\u007F.\u0003:
          return \u0007.\u0001(45634);
        case \u0014.\u007F.\u0004:
          return \u0007.\u0001(45672);
        case \u0014.\u007F.\u0005:
          return \u0007.\u0001(45710);
        case \u0014.\u007F.\u0006:
          return \u0007.\u0001(45748);
        default:
          throw new NotSupportedException(\u009E\u0081.\u001F\u0093(\u0007.\u0001(81672), (object) house));
      }
    }

    public static string \u001D\u0005(this \u0008 wayPointType)
    {
      switch (wayPointType)
      {
        case \u0008.\u0001:
          return \u0007.\u0001(45562);
        case \u0008.\u0002:
          return \u0007.\u0001(45596);
        case \u0008.\u0003:
          return \u0007.\u0001(45634);
        case \u0008.\u0004:
          return \u0007.\u0001(45672);
        case \u0008.\u0005:
          return \u0007.\u0001(45710);
        case \u0008.\u0006:
          return \u0007.\u0001(45748);
        case \u0008.\u0007:
          return \u0007.\u0001(45794);
        default:
          throw new NotSupportedException(\u009E\u0081.\u001F\u0093(\u0007.\u0001(81717), (object) wayPointType));
      }
    }

    public static string \u001D\u0005(this \u0081 runType)
    {
      switch (runType)
      {
        case \u0081.\u0001:
          return \u0007.\u0001(81786);
        case \u0081.\u0002:
          return \u0007.\u0001(81795);
        default:
          return \u0007.\u0001(30770);
      }
    }

    public static string \u001D\u0005(this \u007F.\u007F wayPointType)
    {
      \u007F.\u007F obj = wayPointType;
      if ((uint) obj > 524U)
      {
        if ((uint) obj <= 2068U)
        {
          if ((uint) obj <= 1036U)
          {
            if (obj == \u007F.\u007F.\u0019)
              return \u0007.\u0001(82012);
            if (obj == \u007F.\u007F.\u0010)
              return \u0007.\u0001(81911);
          }
          else
          {
            if (obj == \u007F.\u007F.\u001A)
              return \u0007.\u0001(82021);
            if (obj == \u007F.\u007F.\u0011)
              return \u0007.\u0001(81924);
            if (obj == \u007F.\u007F.\u001B)
              return \u0007.\u0001(82030);
          }
        }
        else if ((uint) obj <= 4116U)
        {
          if (obj == \u007F.\u007F.\u0012)
            return \u0007.\u0001(81937);
          if (obj == \u007F.\u007F.\u001C)
            return \u0007.\u0001(82039);
        }
        else
        {
          if (obj == \u007F.\u007F.\u0013)
            return \u0007.\u0001(81950);
          if (obj == \u007F.\u007F.\u0014)
            return \u0007.\u0001(81963);
          if (obj == \u007F.\u007F.\u001D)
            return \u0007.\u0001(82048);
        }
      }
      else
        goto label_43;
label_42:
      throw new NotSupportedException(\u009E\u0081.\u001F\u0093(\u0007.\u0001(82065), (object) wayPointType));
label_43:
      if ((uint) obj > 84U)
      {
        if ((uint) obj <= 148U)
        {
          if (obj == \u007F.\u007F.\u0008)
            return \u0007.\u0001(81872);
          if (obj == \u007F.\u007F.\u0017)
            return \u0007.\u0001(81994);
          goto label_42;
        }
        else
        {
          if (obj == \u007F.\u007F.\u000E)
            return \u0007.\u0001(81885);
          if (obj == \u007F.\u007F.\u0018)
            return \u0007.\u0001(82003);
          if (obj == \u007F.\u007F.\u000F)
            return \u0007.\u0001(81898);
          goto label_42;
        }
      }
      else if ((uint) obj <= 44U)
      {
        switch (obj)
        {
          case \u007F.\u007F.\u0001:
            return \u0007.\u0001(81816);
          case \u007F.\u007F.\u0002:
            return \u0007.\u0001(81833);
          case \u007F.\u007F.\u0006:
            return \u0007.\u0001(81846);
          default:
            goto label_42;
        }
      }
      else
      {
        if (obj == \u007F.\u007F.\u0015)
          return \u0007.\u0001(81976);
        if (obj == \u007F.\u007F.\u0007)
          return \u0007.\u0001(81859);
        if (obj == \u007F.\u007F.\u0016)
          return \u0007.\u0001(81985);
        goto label_42;
      }
    }

    public static string \u001D\u0005(this \u001A.\u0019 playGround)
    {
      switch (playGround)
      {
        case \u001A.\u0019.\u0002:
          return \u0007.\u0001(82621);
        case \u001A.\u0019.\u0003:
          return \u0007.\u0001(83002);
        case \u001A.\u0019.\u0004:
          return \u0007.\u0001(83027);
        case \u001A.\u0019.\u0005:
          return \u0007.\u0001(83068);
        case \u001A.\u0019.\u0006:
          return \u0007.\u0001(83117);
        case \u001A.\u0019.\u0007:
          return \u0007.\u0001(82630);
        case \u001A.\u0019.\u0008:
          return \u0007.\u0001(82148);
        case \u001A.\u0019.\u000E:
          return \u0007.\u0001(82185);
        case \u001A.\u0019.\u000F:
          return \u0007.\u0001(82214);
        case \u001A.\u0019.\u0010:
          return \u0007.\u0001(82235);
        case \u001A.\u0019.\u0011:
          return \u0007.\u0001(82272);
        case \u001A.\u0019.\u0012:
          return \u0007.\u0001(82313);
        case \u001A.\u0019.\u0013:
          return \u0007.\u0001(82350);
        case \u001A.\u0019.\u0014:
          return \u0007.\u0001(82371);
        case \u001A.\u0019.\u0015:
          return \u0007.\u0001(82420);
        case \u001A.\u0019.\u0016:
          return \u0007.\u0001(82465);
        case \u001A.\u0019.\u0017:
          return \u0007.\u0001(82664);
        case \u001A.\u0019.\u0018:
          return \u0007.\u0001(82693);
        case \u001A.\u0019.\u0019:
          return \u0007.\u0001(82738);
        case \u001A.\u0019.\u001A:
          return \u0007.\u0001(82795);
        case \u001A.\u0019.\u001B:
          return \u0007.\u0001(82882);
        case \u001A.\u0019.\u001C:
          return \u0007.\u0001(82899);
        case \u001A.\u0019.\u001D:
          return \u0007.\u0001(82932);
        case \u001A.\u0019.\u001E:
          return \u0007.\u0001(82969);
        case \u001A.\u0019.\u001F:
          return \u0007.\u0001(82506);
        case \u001A.\u0019.\u007F:
          return \u0007.\u0001(82531);
        case \u001A.\u0019.\u0080:
          return \u0007.\u0001(82576);
        case \u001A.\u0019.\u0081:
          return \u0007.\u0001(82114);
        case \u001A.\u0019.\u0082:
          return \u0007.\u0001(82131);
        case \u001A.\u0019.\u0083:
          return \u0007.\u0001(82865);
        case \u001A.\u0019.\u0084:
          return \u0007.\u0001(82651);
        case \u001A.\u0019.\u0086:
          return \u0007.\u0001(82844);
        default:
          return \u0007.\u0001(30770);
      }
    }
  }
}
