// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u001A;
using \u001C;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TSN.Controls;

namespace \u001A
{
  internal sealed class \u0005 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private \u007F.\u001F \u0001;
    private \u001F.\u0081 \u0001;
    private \u001C.\u001A \u0001;
    private \u001E.\u001F \u0001;
    private bool \u0001;
    private IContainer \u0001;
    private \u001C.\u001D \u0001;
    private Label \u0001;
    private Label \u0002;
    private ListView \u0001;
    private Panel \u0001;
    private PictureBox \u0001;
    private PictureBox \u0002;
    private Button \u0001;
    private Button \u0002;
    private Button \u0003;
    private Button \u0004;
    private Button \u0005;
    private Label \u0003;

    static \u0005()
    {
      \u0004.\u001D\u0005(typeof (\u0005));
    }

    public \u0005(\u001F.\u0081 settings)
    {
      this.\u001D\u0005();
      this.Text = string.Format(\u0005.\u0001(48712), \u008F\u0084.\u009E\u0092(settings.Name) ? (object) \u0005.\u0001(47414) : (object) settings.Name);
      \u0080\u0086.\u0016\u008B((object) this, \u0013.Content_Icon);
      this.\u0001 = new \u001E.\u001F();
      this.\u0001 = settings;
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (this.\u0001)
        return;
      this.\u0001 = true;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u007F\u0005)));
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0005.\u0001 obj = new \u0005.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = this;
      if (this.\u0001)
        return;
      this.\u0001 = true;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = new ListViewItemState<string>[\u0005\u0081.\u007E\u0002\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001))];
      // ISSUE: reference to a compiler-generated field
      \u0083\u0081.\u007E\u0007\u008D((object) \u0081\u001F.\u007E\u008D\u008C((object) this.\u0001), (Array) obj.\u0001, 0);
      // ISSUE: reference to a compiler-generated method
      this.\u0001.\u001D\u0005(new Action<object>(obj.\u001D\u0005));
    }

    private void \u001D\u0005(object sender, FormClosingEventArgs e)
    {
      Action<object> action1 = (Action<object>) null;
      if (this.\u0001)
        return;
      \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, true);
      this.\u0001 = true;
      \u001E.\u001F obj = this.\u0001;
      if (action1 == null)
        goto label_4;
label_3:
      Action<object> action2 = action1;
      obj.\u001D\u0005(action2);
      return;
label_4:
      // ISSUE: method pointer
      action1 = new Action<object>((object) this, __methodptr(\u0080\u0005));
      goto label_3;
    }

    private bool \u001D\u0005(string file)
    {
      foreach (\u001F.\u0081 contentPack in \u0081.\u0080.Instance.ConnectSettings.ContentPacks)
      {
        if (contentPack != this.\u0001 && contentPack.InstallState != \u001D.\u001D.\u0001 && contentPack.\u0001.ContainsKey(file))
        {
          switch (contentPack.\u0001[file].\u0001)
          {
            case \u001D.\u001D.\u0002:
            case \u001D.\u001D.\u0003:
            case \u001D.\u001D.\u0004:
              return true;
            default:
              continue;
          }
        }
      }
      return false;
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0005.\u0002 obj = new \u0005.\u0002();
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = this;
      // ISSUE: reference to a compiler-generated field
      obj.\u0001 = new \u0014.\u001A();
      try
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        obj.\u0001.Shown += new EventHandler(obj.\u001D\u0005);
        // ISSUE: reference to a compiler-generated field
        int num = (int) \u0097\u001E.\u007E\u0099\u008B((object) obj.\u0001);
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (obj.\u0001 != null)
        {
          // ISSUE: reference to a compiler-generated field
          \u001A\u001E.\u007E\u0094\u0092((object) obj.\u0001);
        }
      }
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (this.\u0001)
        return;
      if (\u0005\u0081.\u007E\u009C\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001)) == 0)
      {
        // ISSUE: method pointer
        this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u001D\u0005)));
      }
      else
      {
        // ISSUE: method pointer
        this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u001D\u0005)), (object) \u0002\u007F.\u007E\u007F\u008D((object) \u008B\u0086.\u007E\u009D\u008C((object) \u0010\u0082.\u007E\u0091\u008C((object) this.\u0001), 0)));
      }
    }

    private void \u001D\u0005(object state)
    {
      string index = state as string;
      if (!\u008F\u0084.\u009E\u0092(index))
      {
        byte[] numArray = (byte[]) null;
        if (this.\u0001.Data.MultiFileData.ContainsKey(index))
          numArray = this.\u0001.Data.MultiFileData[index].Data;
        switch (\u001E.\u007F.\u001D\u0005(index))
        {
          case \u0017.\u0002:
            this.\u0001.\u001E\u0005(new Action<object>(this.\u001E\u0005), (object) \u007F.\u001F.\u001D\u0005(numArray, (byte[]) null));
            this.\u0001.\u001E\u0005(new Action<object>(this.\u001F\u0005));
            break;
          case \u0017.\u0003:
            MemoryStream memoryStream = new MemoryStream(numArray);
            try
            {
              this.\u0001.\u001E\u0005(new Action<object>(this.\u001E\u0005), (object) new \u007F.\u001F(\u0017.\u001D\u0005((Stream) memoryStream), (Bitmap) null));
            }
            finally
            {
              if (memoryStream != null)
                \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
            }
            this.\u0001.\u001E\u0005(new Action<object>(this.\u001F\u0005));
            break;
          case \u0017.\u0004:
          case \u0017.\u0005:
          case \u0017.\u0006:
            this.\u0001.\u001E\u0005(new Action<object>(this.\u001F\u0005), (object) new \u001D.\u0081(index, numArray, (byte[]) null));
            this.\u0001.\u001E\u0005(new Action<object>(this.\u001E\u0005));
            break;
        }
      }
      else
      {
        // ISSUE: method pointer
        this.\u0001.\u001E\u0005(new Action<object>((object) this, __methodptr(\u001F\u0005)));
        // ISSUE: method pointer
        this.\u0001.\u001E\u0005(new Action<object>((object) this, __methodptr(\u001E\u0005)));
      }
    }

    private void \u001E\u0005(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) new \u0005.\u0003()
      {
        \u0001 = this,
        \u0001 = (state as \u007F.\u001F)
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(\u007F.\u001F gr)
    {
      if (gr == null || gr.UserGraphicData == null)
      {
        \u0087\u0081.\u007E\u001E\u008E((object) this.\u0002, (Image) null);
      }
      else
      {
        \u0087\u0081.\u007E\u001E\u008E((object) this.\u0002, (Image) gr.UserGraphicData);
        \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, \u0083\u001E.\u007E\u001F\u001F((object) \u000E\u0086.\u007E\u001D\u008E((object) this.\u0002)).\u001D\u0005(224, 244));
      }
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      this.\u0001 = gr;
    }

    private void \u001F\u0005(object state)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: method pointer
      \u001F.\u001A.\u001E\u0005(this, new MethodInvoker((object) new \u0005.\u0004()
      {
        \u0001 = this,
        \u0001 = (state as \u001D.\u0081)
      }, __methodptr(\u001D\u0005)));
    }

    private void \u001D\u0005(\u001D.\u0081 audioData)
    {
      if (audioData == null)
      {
        this.\u0001.\u001F\u0005();
        \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, false);
      }
      else
      {
        if (audioData.UserAudioData != null)
          this.\u0001.\u001D\u0005(audioData.AudioFile, audioData.UserAudioData);
        else
          goto label_5;
label_2:
        \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, true);
        return;
label_5:
        this.\u0001.\u001F\u0005();
        goto label_2;
      }
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      if (this.\u0001)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0081\u0005)));
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      if (this.\u0001)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0082\u0005)));
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      if (this.\u0001)
        return;
      // ISSUE: method pointer
      this.\u0001.\u001D\u0005(new Action<object>((object) this, __methodptr(\u0083\u0005)));
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0080.\u0082.\u001D\u0005(\u0002.\u0018);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        goto label_3;
label_2:
      \u0099\u001F.\u0093\u008B((object) this, disposing);
      return;
label_3:
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      if (this.\u0001 != null)
      {
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
        goto label_2;
      }
      else
        goto label_2;
    }

    private void \u001D\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0005)));
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0001 = new ListView();
      this.\u0001 = new Panel();
      this.\u0001 = new PictureBox();
      this.\u0002 = new PictureBox();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0003 = new Button();
      this.\u0004 = new Button();
      this.\u0005 = new Button();
      this.\u0001 = new \u001C.\u001D();
      this.\u0003 = new Label();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0002);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0005.\u0001(9115), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(7, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(48753));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(168, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 11);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(48782));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0005.\u0001(9115), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(319, 10));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0005.\u0001(48807));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(79, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 11);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0005.\u0001(48824));
      \u0099\u001F.\u007E\u0087\u008C((object) this.\u0001, true);
      \u0099\u001F.\u007E\u0089\u008C((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 38));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(48837));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(306, 264));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u0099\u001F.\u007E\u0093\u008C((object) this.\u0001, false);
      \u0017\u0080.\u007E\u0094\u008C((object) this.\u0001, View.List);
      \u0087\u007F.\u007E\u0095\u008C((object) this.\u0001, new EventHandler(this.\u007F\u0005));
      \u0012\u0082.\u007E\u009C\u008A((object) this.\u0001, BorderStyle.FixedSingle);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(324, 38));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(48850));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(224, 224));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 16);
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0005.\u0001(48871)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(87, 87));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(48912));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(48, 48));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 7);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(0, 0));
      \u000E\u001F.\u007E\u0005\u0084((object) this.\u0002, new Size(224, 224));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0005.\u0001(48945));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(224, 224));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0002, PictureBoxSizeMode.StretchImage);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0002, 6);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0002, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 308));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(48966));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(98, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0005.\u0001(48995));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0080\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(116, 308));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0005.\u0001(49016));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(98, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0005.\u0001(49037));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u0081\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(220, 308));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0005.\u0001(49050));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(98, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 4);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0005.\u0001(49075));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u0082\u0005));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(472, 308));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0005.\u0001(8797));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0005.\u0001(8188));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0004, new EventHandler(this.\u001E\u0005));
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0005, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(391, 308));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0005.\u0001(14520));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 6);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0005.\u0001(14050));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0005, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0005, new EventHandler(this.\u001D\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u0008\u007F());
      \u0012\u0082.\u007E\u009D\u0090((object) this.\u0001, BorderStyle.FixedSingle);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(324, 268));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0005.\u0001(49092));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(224, 34));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 1);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0005.\u0001(6010), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(459, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0005.\u0001(8373));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 20);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0005.\u0001(8398));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0004);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0005);
      \u000E\u001F.\u0010\u008B((object) this, new Size(563, 342));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0005.\u0001(49113));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0005.\u0001(49142));
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u008F\u008B((object) this, new EventHandler(this.\u001F\u0005));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0002);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
