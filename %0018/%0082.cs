// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0017;
using \u0018;
using \u0019;
using \u001F;
using \u0084;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace \u0018
{
  internal sealed class \u0082 : \u0014.\u0019
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
    private static readonly string \u0012;
    private static readonly string \u0013;
    private static readonly string \u0014;
    private static readonly string \u0015;
    private static readonly string \u0016;
    private static readonly string \u0017;
    private static readonly string \u0018;
    private static readonly string \u0019;
    private static readonly string \u001A;
    private static readonly string \u001B;
    private static readonly string \u001C;
    private static readonly string \u001D;
    private static readonly string \u001E;
    private static readonly string \u001F;
    private static readonly string \u007F;
    private bool \u0001;
    private IContainer \u0001;
    private Label \u0001;
    private Label \u0002;
    private FolderBrowserDialog \u0001;

    static \u0082()
    {
      \u0004.\u001D\u0005(typeof (\u0082));
      \u0082.\u0001 = \u0082.\u0001(41532);
      \u0082.\u0002 = \u0082.\u0001(41545);
      \u0082.\u0003 = \u0082.\u0001(41554);
      \u0082.\u0004 = \u0082.\u0001(41587);
      \u0082.\u0005 = \u0082.\u0001(41612);
      \u0082.\u0006 = \u0082.\u0001(41625);
      \u0082.\u0007 = \u0082.\u0001(41642);
      \u0082.\u0008 = \u0082.\u0001(41655);
      \u0082.\u000E = \u0082.\u0001(41676);
      \u0082.\u000F = \u0082.\u0001(41713);
      \u0082.\u0010 = \u0082.\u0001(41778);
      \u0082.\u0011 = \u0082.\u0001(41815);
      \u0082.\u0012 = \u0082.\u0001(41864);
      \u0082.\u0013 = \u0082.\u0001(41889);
      \u0082.\u0014 = \u0082.\u0001(42006);
      \u0082.\u0015 = \u0082.\u0001(42027);
      \u0082.\u0016 = \u0082.\u0001(42076);
      \u0082.\u0017 = \u0082.\u0001(42153);
      \u0082.\u0018 = \u0082.\u0001(42162);
      \u0082.\u0019 = \u0082.\u0001(42171);
      \u0082.\u001A = \u0082.\u0001(42192);
      \u0082.\u001B = \u0082.\u0001(34209);
      \u0082.\u001C = \u0082.\u0001(42201);
      \u0082.\u001D = \u0082.\u0001(42210);
      \u0082.\u001E = \u0082.\u0001(42352);
      \u0082.\u001F = \u0082.\u0001(42389);
      \u0082.\u007F = \u0082.\u0001(42502);
    }

    public \u0082()
      : base(false)
    {
      this.\u001E\u0005();
      // ISSUE: method pointer
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler((object) this, __methodptr(\u001E\u0005)));
    }

    private void \u001D\u0005(string file)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      \u001A.\u001D\u0005(this, new MethodInvoker((object) new \u0082.\u0001()
      {
        \u0001 = file,
        \u0001 = this
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      // ISSUE: method pointer
      int num = \u001E\u001F.\u009A\u0098(new WaitCallback((object) this, __methodptr(\u001D\u0005)), (object) null) ? 1 : 0;
    }

    protected override void \u001D\u0005(\u0015 e)
    {
      e.Cancel = true;
      e.CancelReason = \u0082.\u000E;
      base.\u001D\u0005(e);
    }

    private void \u001E\u0005(object sender, FormClosingEventArgs e)
    {
      if (\u009A\u001E.\u007E\u009D\u008B((object) e) == CloseReason.WindowsShutDown || this.\u0001)
        return;
      \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, true);
    }

    public void \u001D\u0005(List<\u001B> failedToDelete, string parentDirectory, string childDirectory)
    {
      if (\u001D.\u0014.\u001D\u0005(parentDirectory, childDirectory))
        return;
      KeyValuePair<string, DirectoryInfo>[] keyValuePairArray1 = \u0012.\u001D\u0005(new DirectoryInfo(parentDirectory));
      KeyValuePair<string, DirectoryInfo>[] keyValuePairArray2 = \u0012.\u001D\u0005(new DirectoryInfo(childDirectory));
      if (keyValuePairArray1.Length >= keyValuePairArray2.Length)
        return;
      for (int index = 0; index < keyValuePairArray1.Length; ++index)
      {
        if (!\u0008\u0080.\u0099\u0092(keyValuePairArray1[index].Key, keyValuePairArray2[index].Key, StringComparison.OrdinalIgnoreCase))
          return;
      }
      int index1 = keyValuePairArray2.Length - 1;
      while (index1 >= keyValuePairArray1.Length && this.\u001D\u0005(failedToDelete, \u0002\u007F.\u007E\u0082\u009E((object) keyValuePairArray2[index1].Value)))
        --index1;
    }

    private void \u001D\u0005(List<\u001B> failedToDelete, string file)
    {
      try
      {
        if (!\u008F\u0084.\u0092\u009E(file))
          return;
        this.\u001D\u0005(file);
        \u009C\u001F.\u0091\u009E(file);
      }
      catch
      {
        failedToDelete.Add(new \u001B(file));
      }
    }

    private bool \u001D\u0005(List<\u001B> failedToDelete, string directory)
    {
      if (\u008F\u0084.\u001D\u009E(directory))
        goto label_2;
label_1:
      return false;
label_2:
      if (!\u0012.\u001D\u0005(directory))
        return this.\u001E\u0005(failedToDelete, directory);
      failedToDelete.Add(new \u001B(directory));
      goto label_1;
    }

    private bool \u001E\u0005(List<\u001B> failedToDelete, string directory)
    {
      try
      {
        this.\u001D\u0005(directory);
        \u009C\u001F.\u0081\u009E(directory);
        return true;
      }
      catch
      {
        failedToDelete.Add(new \u001B(directory));
      }
      return false;
    }

    private void \u001E\u0005(List<\u001B> failedToDelete, string directory)
    {
      if (!\u008F\u0084.\u001D\u009E(directory))
        return;
      string str1 = \u0081\u0086.\u0011\u009F(directory, \u0082.\u0008);
      if (\u008F\u0084.\u0092\u009E(str1))
        goto label_9;
label_8:
      this.\u001D\u0005(failedToDelete, directory);
      return;
label_9:
      foreach (string str2 in this.\u001D\u0005(str1))
        this.\u001D\u0005(failedToDelete, \u0081\u0086.\u0011\u009F(directory, str2));
      this.\u001D\u0005(failedToDelete, str1);
      goto label_8;
    }

    private HashSet<string> \u001D\u0005(string cache_file)
    {
      HashSet<string> stringSet = new HashSet<string>((IEqualityComparer<string>) \u0093\u001B.\u0090\u0093());
      try
      {
        StreamReader streamReader = new StreamReader(cache_file, \u001D\u001F.\u0016\u009C());
        string[] strArray;
        try
        {
          strArray = \u0083\u0086.\u007E\u0004\u0093((object) \u0002\u007F.\u007E\u0012\u009F((object) streamReader), new string[1]
          {
            \u008E\u001E.\u0098\u0095()
          }, StringSplitOptions.RemoveEmptyEntries);
        }
        finally
        {
          if (streamReader != null)
            \u001A\u001E.\u007E\u0094\u0092((object) streamReader);
        }
        foreach (string str in strArray)
        {
          string result;
          if (str.\u001D\u0005('\t', out result) && !\u008F\u0084.\u009E\u0092(result) && !stringSet.Contains(result))
            stringSet.Add(result);
        }
      }
      catch
      {
      }
      return stringSet;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u001E\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0082)));
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0001 = new FolderBrowserDialog();
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u0019\u008C((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0082.\u0001(7235), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(99, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0082.\u0001(41326));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(266, 14));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0082.\u0001(7235), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(12, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0082.\u0001(41351));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(81, 14));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0082.\u0001(41372));
      \u0092\u0081.\u007E\u0004\u008B((object) this.\u0001, \u0082.\u0001(41389));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(377, 33));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0082.\u0001(6778)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0099\u001F.\u001E\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0082.\u0001(41458));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0082.\u0001(41487));
      \u0087\u007F.\u008F\u008B((object) this, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
