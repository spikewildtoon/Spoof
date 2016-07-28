// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001C;
using \u001E;
using \u0084;
using System;
using System.Management;

namespace \u001C
{
  internal static class \u0011
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly string \u0004;
    private static readonly string \u0005;
    private static readonly string \u0006;
    private static readonly string \u0007;
    private static readonly string \u0008;
    private static readonly string \u000E;
    private static readonly string \u000F;
    private static readonly string \u0010;
    private static readonly string \u0011;
    private static string \u0012;
    private static string \u0013;
    private static string \u0014;
    private static string \u0015;
    private static string \u0016;

    private static string MotherBoardSerial
    {
      get
      {
        if (\u008F\u0084.\u009E\u0092(\u0011.\u0012))
        {
          try
          {
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(\u0011.\u0004);
            try
            {
              ManagementObjectCollection objectCollection = \u0018\u0086.\u007E\u0010\u001F((object) managementObjectSearcher);
              ManagementObjectCollection.ManagementObjectEnumerator objectEnumerator = \u0017\u0086.\u007E\u0007\u001F((object) objectCollection);
              try
              {
                if (\u0099\u0082.\u007E\u000E\u001F((object) objectEnumerator))
                {
                  ManagementBaseObject managementBaseObject = \u0014\u0086.\u007E\u0008\u001F((object) objectEnumerator);
                  \u0011.\u0012 = \u0002\u007F.\u007E\u0087\u0091(\u0093\u0083.\u007E\u0002\u001F((object) managementBaseObject, \u0011.\u0005));
                }
              }
              finally
              {
                if (objectEnumerator != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) objectEnumerator);
              }
            }
            finally
            {
              if (managementObjectSearcher != null)
                \u001A\u001E.\u007E\u0094\u0092((object) managementObjectSearcher);
            }
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005();
          }
          if (\u008F\u0084.\u009E\u0092(\u0011.\u0012))
            \u0011.\u0012 = \u0011.\u0003;
        }
        return \u0011.\u0012;
      }
    }

    private static string SystemDriveSerial
    {
      get
      {
        // ISSUE: unable to decompile the method.
      }
    }

    private static string CPUSerial
    {
      get
      {
        if (\u008F\u0084.\u009E\u0092(\u0011.\u0014))
        {
          try
          {
            ManagementClass managementClass = new ManagementClass(\u0011.\u000E);
            try
            {
              ManagementObjectCollection objectCollection = \u0018\u0086.\u007E\u0006\u001F((object) managementClass);
              ManagementObjectCollection.ManagementObjectEnumerator objectEnumerator = \u0017\u0086.\u007E\u0007\u001F((object) objectCollection);
              try
              {
                if (\u0099\u0082.\u007E\u000E\u001F((object) objectEnumerator))
                {
                  ManagementObject managementObject = (ManagementObject) \u0014\u0086.\u007E\u0008\u001F((object) objectEnumerator);
                  \u0011.\u0014 = \u0002\u007F.\u007E\u0087\u0091(\u0005\u007F.\u007E\u0011\u001F((object) \u0013\u0083.\u007E\u0012\u001F((object) \u0010\u0086.\u007E\u0001\u001F((object) managementObject), \u0011.\u000F)));
                }
              }
              finally
              {
                if (objectEnumerator != null)
                  \u001A\u001E.\u007E\u0094\u0092((object) objectEnumerator);
              }
            }
            finally
            {
              if (managementClass != null)
                \u001A\u001E.\u007E\u0094\u0092((object) managementClass);
            }
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005();
          }
          if (\u008F\u0084.\u009E\u0092(\u0011.\u0014))
            \u0011.\u0014 = \u0011.\u0001;
        }
        return \u0011.\u0014;
      }
    }

    private static string UniqueSerial
    {
      get
      {
        if (\u008F\u0084.\u009E\u0092(\u0011.\u0015))
          \u0011.\u0015 = \u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0011.\u0010, new object[3]
          {
            (object) \u0011.MotherBoardSerial,
            (object) \u0011.CPUSerial,
            (object) \u0011.SystemDriveSerial
          });
        return \u0011.\u0015;
      }
    }

    internal static string HashedUniqueSerial
    {
      get
      {
        if (\u008F\u0084.\u009E\u0092(\u0011.\u0016))
          goto label_2;
label_1:
        return \u0011.\u0016;
label_2:
        \u0011.\u0016 = \u0004.\u001D\u0005(\u0011.UniqueSerial);
        goto label_1;
      }
    }

    static \u0011()
    {
      \u0004.\u001D\u0005(typeof (\u0011));
      \u0011.\u0001 = \u0011.\u0001(59037);
      \u0011.\u0002 = \u0011.\u0001(59058);
      \u0011.\u0003 = \u0011.\u0001(59075);
      \u0011.\u0004 = \u0011.\u0001(59096);
      \u0011.\u0005 = \u0011.\u0001(59137);
      \u0011.\u0006 = \u0011.\u0001(59154);
      \u0011.\u0007 = \u0011.\u0001(59179);
      \u0011.\u0008 = \u0011.\u0001(59224);
      \u0011.\u000E = \u0011.\u0001(59229);
      \u0011.\u000F = \u0011.\u0001(59250);
      \u0011.\u0010 = \u0011.\u0001(59267);
      \u0011.\u0011 = \u0011.\u0001(59284);
    }
  }
}
