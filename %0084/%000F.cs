// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u001A;
using \u001C;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace \u0084
{
  [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
  internal sealed class \u000F : UITypeEditor
  {
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
    {
      return UITypeEditorEditStyle.Modal;
    }

    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
    {
      // ISSUE: type reference
      if (provider != null && \u001D\u0084.\u007E\u008D\u0096((object) provider, \u009C\u0082.\u0016\u0097(__typeref (IWindowsFormsEditorService))) is IWindowsFormsEditorService)
        goto label_13;
label_12:
      return value;
label_13:
      IntPtr handle = \u000E.\u001D\u0005();
      try
      {
        \u001B obj = new \u001B();
        try
        {
          if (value is string)
            obj.Value = value as string;
          if (\u0097\u001E.\u007E\u0099\u008B((object) obj) == DialogResult.OK)
            return (object) obj.Value;
          goto label_12;
        }
        finally
        {
          if (obj != null)
            \u001A\u001E.\u007E\u0094\u0092((object) obj);
        }
      }
      finally
      {
        if (\u0008\u0081.\u0087\u0096(handle, IntPtr.Zero))
          \u000E.\u001D\u0005(new HandleRef((object) null, handle));
      }
    }
  }
}
