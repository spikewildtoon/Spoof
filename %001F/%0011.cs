// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0015;
using \u0018;
using \u0019;
using \u001A;
using \u001B;
using \u001F;
using \u0080;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001F
{
  internal sealed class \u0011 : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private \u0016.\u0018 \u0001;
    private RadioButton \u0001;
    private Panel \u0001;
    private RadioButton \u0002;
    private RadioButton \u0003;
    private RadioButton \u0004;
    private RadioButton \u0005;
    private RadioButton \u0006;
    private Panel \u0002;
    private RadioButton \u0007;
    private RadioButton \u0008;
    private RadioButton \u000E;
    private Button \u0001;
    private Button \u0002;
    private Label \u0001;
    private Label \u0002;
    private Panel \u0003;
    private Button \u0003;
    private Button \u0004;

    [DefaultValue(typeof (Bitmap), null)]
    public Bitmap Image
    {
      get
      {
        return this.\u0001.Image;
      }
      set
      {
        this.\u0001.Image = value;
      }
    }

    static \u0011()
    {
      \u0004.\u001D\u0005(typeof (\u0011));
    }

    public \u0011()
    {
      this.\u001D\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u0093\u008B((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0011)));
      this.\u0001 = new RadioButton();
      this.\u0001 = new Panel();
      this.\u0002 = new RadioButton();
      this.\u0003 = new RadioButton();
      this.\u0004 = new RadioButton();
      this.\u0005 = new RadioButton();
      this.\u0006 = new RadioButton();
      this.\u0002 = new Panel();
      this.\u0007 = new RadioButton();
      this.\u0008 = new RadioButton();
      this.\u000E = new RadioButton();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0001 = new Label();
      this.\u0002 = new Label();
      this.\u0003 = new Panel();
      this.\u0003 = new Button();
      this.\u0004 = new Button();
      this.\u0001 = new \u0016.\u0018();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0002);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0003);
      \u001A\u001E.\u0084\u0086((object) this);
      \u008B\u001C.\u007E\u008F\u008E((object) this.\u0001, Appearance.Button);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0001, (System.Drawing.Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(68522)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(2, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0011.\u0001(68551));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(48, 48));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(675, 36));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0011.\u0001(68572));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(52, 322));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      \u008B\u001C.\u007E\u008F\u008E((object) this.\u0002, Appearance.Button);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0002, (System.Drawing.Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(68593)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(2, 272));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0011.\u0001(68630));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(48, 48));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 3);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u008B\u001C.\u007E\u008F\u008E((object) this.\u0003, Appearance.Button);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0003, (System.Drawing.Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(68659)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(2, 218));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0011.\u0001(68688));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(48, 48));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 3);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0003, new EventHandler(this.\u001E\u0005));
      \u008B\u001C.\u007E\u008F\u008E((object) this.\u0004, Appearance.Button);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0004, (System.Drawing.Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(68709)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(2, 164));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0011.\u0001(68730));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(48, 48));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 3);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0004, new EventHandler(this.\u001E\u0005));
      \u008B\u001C.\u007E\u008F\u008E((object) this.\u0005, Appearance.Button);
      \u0099\u001F.\u007E\u0091\u008E((object) this.\u0005, true);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0005, (System.Drawing.Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(68743)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(2, 110));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0011.\u0001(68768));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(48, 48));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 3);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0005, true);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0005, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0005, new EventHandler(this.\u001E\u0005));
      \u008B\u001C.\u007E\u008F\u008E((object) this.\u0006, Appearance.Button);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0006, (System.Drawing.Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(68785)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(2, 56));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0011.\u0001(68806));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(48, 48));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 3);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0006, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0006, new EventHandler(this.\u001E\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Top | AnchorStyles.Right);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0002), (Control) this.\u000E);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(617, 36));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0011.\u0001(68819));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(52, 160));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 4);
      \u008B\u001C.\u007E\u008F\u008E((object) this.\u0007, Appearance.Button);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0007, (System.Drawing.Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(68832)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(2, 110));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0011.\u0001(68857));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(48, 48));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 3);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0007, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0007, new EventHandler(this.\u001D\u0005));
      \u008B\u001C.\u007E\u008F\u008E((object) this.\u0008, Appearance.Button);
      \u0099\u001F.\u007E\u0091\u008E((object) this.\u0008, true);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0008, (System.Drawing.Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(68874)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(2, 56));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0011.\u0001(68895));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(48, 48));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 3);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0008, true);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0008, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0008, new EventHandler(this.\u001D\u0005));
      \u008B\u001C.\u007E\u008F\u008E((object) this.\u000E, Appearance.Button);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u000E, (System.Drawing.Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(68908)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(2, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u0011.\u0001(68925));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(48, 48));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 3);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u000E, true);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u000E, new EventHandler(this.\u001D\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0011.\u0001(7718), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(621, 382));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0011.\u0001(67519));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(106, 40));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0011.\u0001(68934));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0080\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0002, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(621, 428));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0011.\u0001(16228));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(106, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 6);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0011.\u0001(9914));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u0081\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0011.\u0001(10823), 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 9));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0011.\u0001(68943));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(205, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 10);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0011.\u0001(68956));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0002, AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(14, 384));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0011.\u0001(68989));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(597, 69));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 11);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0090\u0083.\u007E\u001F\u009C((object) componentResourceManager, \u0011.\u0001(69006)));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0003, AnchorStyles.Top | AnchorStyles.Right);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0003), (Control) this.\u0004);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(617, 252));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0011.\u0001(69031));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(52, 106));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 12);
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0003, (System.Drawing.Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(69044)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(2, 56));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0011.\u0001(69065));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(48, 48));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 0);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u007F\u0005));
      \u0087\u0081.\u007E\u0088\u0087((object) this.\u0004, (System.Drawing.Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(69078)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(2, 2));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0011.\u0001(69095));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(48, 48));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 0);
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0004, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0004, new EventHandler(this.\u001F\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      \u0012\u0082.\u007E\u009D\u0090((object) this.\u0001, BorderStyle.Fixed3D);
      this.\u0001.DrawingTool = \u0083.\u001B.\u0002;
      this.\u0001.DrawingToolSize = \u0007.\u0003;
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(8, 38));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0011.\u0001(69104));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(603, 341));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0001);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0002);
      \u000E\u001F.\u0010\u008B((object) this, new Size(734, 462));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0011.\u0001(8840)));
      \u000E\u001F.\u007E\u0007\u0084((object) this, new Size(750, 500));
      \u0092\u0081.\u0010\u0084((object) this, \u0011.\u0001(69133));
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0011.\u0001(68956));
      \u0097\u001C.\u0088\u008B((object) this, FormWindowState.Maximized);
      \u0098\u001C.\u008B\u008B((object) this, new FormClosingEventHandler(this.\u001D\u0005));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0002, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0003, false);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    public \u0005<T> \u001D\u0005<T>() where T : \u0013
    {
      return this.\u0001.\u001D\u0005<T>();
    }

    public void \u001D\u0005<T>(\u0005<T> value) where T : \u0013
    {
      this.\u0001.\u001D\u0005<T>(value);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u0090\u008E((object) this.\u000E))
      {
        if (!\u0099\u0082.\u007E\u0090\u008E((object) this.\u0008))
        {
          if (\u0099\u0082.\u007E\u0090\u008E((object) this.\u0007))
            this.\u0001.DrawingTool = \u0083.\u001B.\u0003;
          else
            \u0099\u001F.\u007E\u0091\u008E((object) this.\u000E, true);
        }
        else
          this.\u0001.DrawingTool = \u0083.\u001B.\u0002;
      }
      else
        this.\u0001.DrawingTool = \u0083.\u001B.\u0001;
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u0090\u008E((object) this.\u0001))
      {
        if (!\u0099\u0082.\u007E\u0090\u008E((object) this.\u0006))
        {
          if (\u0099\u0082.\u007E\u0090\u008E((object) this.\u0005))
            this.\u0001.DrawingToolSize = \u0007.\u0003;
          else if (\u0099\u0082.\u007E\u0090\u008E((object) this.\u0004))
            this.\u0001.DrawingToolSize = \u0007.\u0004;
          else if (\u0099\u0082.\u007E\u0090\u008E((object) this.\u0003))
            this.\u0001.DrawingToolSize = \u0007.\u0005;
          else if (\u0099\u0082.\u007E\u0090\u008E((object) this.\u0002))
            this.\u0001.DrawingToolSize = \u0007.\u0006;
          else
            \u0099\u001F.\u007E\u0091\u008E((object) this.\u0005, true);
        }
        else
          this.\u0001.DrawingToolSize = \u0007.\u0002;
      }
      else
        this.\u0001.DrawingToolSize = \u0007.\u0001;
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001E\u0005();
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001F\u0005();
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
    }

    private void \u001D\u0005(object sender, FormClosingEventArgs e)
    {
      if (\u0097\u001E.\u0014\u008B((object) this) != DialogResult.OK)
        return;
      Bitmap overlay = this.\u0001.Overlay;
      if (overlay == null)
      {
        \u0017.\u001D\u0005(\u0011.\u0001(69158), \u0011.\u0001(69235));
      }
      else
      {
        int num = \u0082.\u001D\u0005(overlay);
        if (num == 1)
        {
          \u0017.\u001D\u0005(\u0011.\u0001(69260), \u0011.\u0001(69462));
          \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, true);
        }
        else
        {
          if (num >= 10000)
            return;
          \u0017.\u001D\u0005(\u0011.\u0001(69491), \u0011.\u0001(69600));
          \u0099\u001F.\u007E\u0087\u0001\u0002((object) e, true);
        }
      }
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0082.\u001D\u0005(\u0002.\u0080);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }
  }
}
