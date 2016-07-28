// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using System.Security.Permissions;
using System.Windows.Forms;

namespace \u0017
{
  internal sealed class \u0013 : RichTextBox
  {
    protected override CreateParams CreateParams
    {
      [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)] get
      {
        CreateParams createParams1 = \u0005\u0086.\u0097\u008E((object) this);
        if (\u009C\u001B.\u0011\u008A((object) this) == BorderStyle.None && \u0099\u0082.\u0018\u008A((object) this))
        {
          \u0011\u001F obj = \u0011\u001F.\u007E\u0099\u0089;
          CreateParams createParams2 = createParams1;
          int num = createParams2.ExStyle | 131072;
          obj((object) createParams2, num);
        }
        return createParams1;
      }
    }

    public \u0013()
    {
      \u0012\u0082.\u0012\u008A((object) this, BorderStyle.None);
    }
  }
}
