// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u001E;
using \u0081;
using \u0084;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Windows.Forms;

namespace \u0081
{
  internal sealed class \u007F : UserControl
  {
    private RichTextBox \u0002 = new RichTextBox();
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private ToolBarButton \u0001;
    private ToolBar \u0001;
    private ToolBarButton \u0002;
    private ToolBarButton \u0003;
    private ToolBarButton \u0004;
    private ToolBarButton \u0005;
    private ContextMenu \u0001;
    private MenuItem \u0001;
    private MenuItem \u0002;
    private MenuItem \u0003;
    private MenuItem \u0004;
    private MenuItem \u0005;
    private MenuItem \u0006;
    private MenuItem \u0007;
    private ToolBarButton \u0006;
    private ContextMenu \u0002;
    private MenuItem \u0008;
    private MenuItem \u000E;
    private MenuItem \u000F;
    private MenuItem \u0010;
    private MenuItem \u0011;
    private MenuItem \u0012;
    private MenuItem \u0013;
    private MenuItem \u0014;
    private MenuItem \u0015;
    private MenuItem \u0016;
    private MenuItem \u0017;
    private MenuItem \u0018;
    private MenuItem \u0019;
    private MenuItem \u001A;
    private MenuItem \u001B;
    private MenuItem \u001C;
    private ToolBarButton \u0007;
    private ContextMenu \u0003;
    private MenuItem \u001D;
    private MenuItem \u001E;
    private MenuItem \u001F;
    private MenuItem \u007F;
    private MenuItem \u0080;
    private MenuItem \u0081;
    private MenuItem \u0082;
    private MenuItem \u0083;
    private MenuItem \u0084;
    private ToolBarButton \u0008;
    private ToolBarButton \u000E;
    private ToolBarButton \u000F;
    private ToolBarButton \u0010;
    private ToolBarButton \u0011;
    private ToolBarButton \u0012;
    private ToolBarButton \u0013;
    private ToolBarButton \u0014;
    private ToolBarButton \u0015;
    private ToolBarButton \u0016;
    private ToolBarButton \u0017;
    private ToolBarButton \u0018;
    private ToolBarButton \u0019;
    private ToolBarButton \u001A;
    private ToolBarButton \u001B;
    private ImageList \u0001;
    private RichTextBox \u0001;
    private ColorDialog \u0001;
    private OpenFileDialog \u0001;
    private SaveFileDialog \u0001;
    private ToolTip \u0001;

    [Category("Appearance")]
    [Description("Controls whether the editing toolbar should be displayed")]
    [DefaultValue(true)]
    public bool ToolbarVisible
    {
      get
      {
        return \u0099\u0082.\u007E\u0081\u0084((object) this.\u0001);
      }
      set
      {
        \u0099\u001F.\u007E\u0082\u0084((object) this.\u0001, value);
      }
    }

    [Category("Appearance")]
    [Description("The background color of the editor portion of this control")]
    [DefaultValue(typeof (Color), "Window")]
    public Color EditorBackColor
    {
      get
      {
        return \u0091\u0084.\u007E\u001C\u0083((object) this.\u0001);
      }
      set
      {
        \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, value);
      }
    }

    [DefaultValue(BorderStyle.Fixed3D)]
    [Category("Appearance")]
    [Description("Indicates whether or not the edit control should have a border")]
    public new BorderStyle BorderStyle
    {
      get
      {
        return \u009C\u001B.\u007E\u0011\u008A((object) this.\u0001);
      }
      set
      {
        \u0012\u0082.\u007E\u0012\u008A((object) this.\u0001, value);
      }
    }

    [DefaultValue(false)]
    [Category("Behavior")]
    [Description("Controls whether the text in the edit control can be changed or not")]
    public bool ReadOnly
    {
      get
      {
        return \u0099\u0082.\u007E\u0018\u008A((object) this.\u0001);
      }
      set
      {
        \u0099\u001F.\u007E\u0019\u008A((object) this.\u0001, value);
        if (!value)
          return;
        this.ToolbarVisible = false;
      }
    }

    [Bindable(true)]
    [Category("Data")]
    [SettingsBindable(true)]
    [Editor(typeof (\u000F), typeof (UITypeEditor))]
    [Description("Contents in Rtf format")]
    public string Rtf
    {
      get
      {
        string str = \u0002\u007F.\u007E\u009A\u008E((object) this.\u0001);
        if (\u0016\u001D.\u007E\u0011\u0093((object) str, \u007F.\u0001(97031)))
          str = \u0084\u0080.\u007E\u0006\u0093((object) str, 0, \u0005\u0081.\u007E\u0001\u0093((object) str) - 1);
        return str;
      }
      set
      {
        string str = value;
        if (!\u0008\u001F.\u009B\u0092(str, \u0002\u007F.\u007E\u009A\u008E((object) this.\u0001)))
          return;
        \u0092\u0081.\u007E\u009B\u008E((object) this.\u0001, str);
        if (this.\u0002 == null)
          return;
        \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
      }
    }

    [Description("Show the save button or not")]
    [Category("Appearance")]
    [DefaultValue(true)]
    public bool ShowSave
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0002);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0002, value);
        this.\u001F\u0005();
      }
    }

    [Category("Appearance")]
    [Description("Show the open button or not")]
    [DefaultValue(true)]
    public bool ShowOpen
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0003);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0003, value);
        this.\u001F\u0005();
      }
    }

    [DefaultValue(true)]
    [Category("Appearance")]
    [Description("Show the color button or not")]
    public bool ShowColors
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0007);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0007, value);
      }
    }

    [DefaultValue(true)]
    [Category("Appearance")]
    [Description("Show the undo button or not")]
    public bool ShowUndo
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0016);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0016, value);
        this.\u001F\u0005();
      }
    }

    [Category("Appearance")]
    [DefaultValue(true)]
    [Description("Show the redo button or not")]
    public bool ShowRedo
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0017);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0017, value);
        this.\u001F\u0005();
      }
    }

    [DefaultValue(true)]
    [Description("Show the bold button or not")]
    [Category("Appearance")]
    public bool ShowBold
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0008);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0008, value);
        this.\u001F\u0005();
      }
    }

    [Description("Show the italic button or not")]
    [DefaultValue(true)]
    [Category("Appearance")]
    public bool ShowItalic
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u000E);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u000E, value);
        this.\u001F\u0005();
      }
    }

    [DefaultValue(true)]
    [Description("Show the underline button or not")]
    [Category("Appearance")]
    public bool ShowUnderline
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u000F);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u000F, value);
        this.\u001F\u0005();
      }
    }

    [DefaultValue(true)]
    [Description("Show the strikeout button or not")]
    [Category("Appearance")]
    public bool ShowStrikeout
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0010);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0010, value);
        this.\u001F\u0005();
      }
    }

    [Category("Appearance")]
    [Description("Show the left justify button or not")]
    [DefaultValue(true)]
    public bool ShowLeftJustify
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0012);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0012, value);
        this.\u001F\u0005();
      }
    }

    [Description("Show the right justify button or not")]
    [Category("Appearance")]
    [DefaultValue(true)]
    public bool ShowRightJustify
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0014);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0014, value);
        this.\u001F\u0005();
      }
    }

    [DefaultValue(true)]
    [Category("Appearance")]
    [Description("Show the center justify button or not")]
    public bool ShowCenterJustify
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0013);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0013, value);
        this.\u001F\u0005();
      }
    }

    [Category("Appearance")]
    [Description("Show the font button or not")]
    [DefaultValue(true)]
    public bool ShowFont
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0005);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0005, value);
      }
    }

    [DefaultValue(true)]
    [Description("Show the font size button or not")]
    [Category("Appearance")]
    public bool ShowFontSize
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0006);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0006, value);
      }
    }

    [DefaultValue(true)]
    [Description("Show the cut button or not")]
    [Category("Appearance")]
    public bool ShowCut
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u0019);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0019, value);
      }
    }

    [Description("Show the copy button or not")]
    [Category("Appearance")]
    [DefaultValue(true)]
    public bool ShowCopy
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u001A);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u001A, value);
      }
    }

    [Category("Appearance")]
    [DefaultValue(true)]
    [Description("Show the paste button or not")]
    public bool ShowPaste
    {
      get
      {
        return \u0099\u0082.\u007E\u001D\u0090((object) this.\u001B);
      }
      set
      {
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u001B, value);
      }
    }

    [Category("Behavior")]
    [DefaultValue(true)]
    [Description("Detect URLs with-in the RichTextBox")]
    public bool DetectURLs
    {
      get
      {
        return \u0099\u0082.\u007E\u0098\u008E((object) this.\u0001);
      }
      set
      {
        \u0099\u001F.\u007E\u0099\u008E((object) this.\u0001, value);
      }
    }

    [DefaultValue(false)]
    [Category("Behavior")]
    [Description("Determines if the TAB key moves to the next control or enters a TAB character in the RichTextBox")]
    public bool AcceptsTab
    {
      get
      {
        return \u0099\u0082.\u007E\u000E\u008A((object) this.\u0001);
      }
      set
      {
        \u0099\u001F.\u007E\u000F\u008A((object) this.\u0001, value);
      }
    }

    [DefaultValue(true)]
    [Category("Behavior")]
    [Description("Determines if auto word selection is enabled")]
    public bool AutoWordSelection
    {
      get
      {
        return \u0099\u0082.\u007E\u0095\u008E((object) this.\u0001);
      }
      set
      {
        \u0099\u001F.\u007E\u0096\u008E((object) this.\u0001, value);
      }
    }

    [Category("Behavior")]
    [Description("Occurs when the selection is changed")]
    public event EventHandler SelectionChanged;

    [Category("Property Changed")]
    public event EventHandler RTFChanged;

    static \u007F()
    {
      \u0004.\u001D\u0005(typeof (\u007F));
    }

    public \u007F()
    {
      this.\u001D\u0005();
      this.\u001E\u0005();
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0002 != null)
      {
        \u001A\u001E.\u007E\u007F\u0001\u0002((object) this.\u0002);
        this.\u0002 = (RichTextBox) null;
      }
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      \u0099\u001F.\u009A\u0086((object) this, disposing);
    }

    private void \u001D\u0005()
    {
      this.\u0001 = (IContainer) new Container();
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u007F)));
      this.\u0001 = new ToolBarButton();
      this.\u0001 = new ToolBar();
      this.\u0002 = new ToolBarButton();
      this.\u0003 = new ToolBarButton();
      this.\u0004 = new ToolBarButton();
      this.\u0005 = new ToolBarButton();
      this.\u0001 = new ContextMenu();
      this.\u0001 = new MenuItem();
      this.\u0002 = new MenuItem();
      this.\u0003 = new MenuItem();
      this.\u0004 = new MenuItem();
      this.\u0005 = new MenuItem();
      this.\u0006 = new MenuItem();
      this.\u0007 = new MenuItem();
      this.\u0006 = new ToolBarButton();
      this.\u0002 = new ContextMenu();
      this.\u0008 = new MenuItem();
      this.\u000E = new MenuItem();
      this.\u000F = new MenuItem();
      this.\u0010 = new MenuItem();
      this.\u0011 = new MenuItem();
      this.\u0012 = new MenuItem();
      this.\u0013 = new MenuItem();
      this.\u0014 = new MenuItem();
      this.\u0015 = new MenuItem();
      this.\u0016 = new MenuItem();
      this.\u0017 = new MenuItem();
      this.\u0018 = new MenuItem();
      this.\u0019 = new MenuItem();
      this.\u001A = new MenuItem();
      this.\u001B = new MenuItem();
      this.\u001C = new MenuItem();
      this.\u0007 = new ToolBarButton();
      this.\u0003 = new ContextMenu();
      this.\u001D = new MenuItem();
      this.\u001E = new MenuItem();
      this.\u001F = new MenuItem();
      this.\u007F = new MenuItem();
      this.\u0080 = new MenuItem();
      this.\u0081 = new MenuItem();
      this.\u0082 = new MenuItem();
      this.\u0083 = new MenuItem();
      this.\u0084 = new MenuItem();
      this.\u0008 = new ToolBarButton();
      this.\u000E = new ToolBarButton();
      this.\u000F = new ToolBarButton();
      this.\u0010 = new ToolBarButton();
      this.\u0011 = new ToolBarButton();
      this.\u0012 = new ToolBarButton();
      this.\u0013 = new ToolBarButton();
      this.\u0014 = new ToolBarButton();
      this.\u0015 = new ToolBarButton();
      this.\u0016 = new ToolBarButton();
      this.\u0017 = new ToolBarButton();
      this.\u0018 = new ToolBarButton();
      this.\u0019 = new ToolBarButton();
      this.\u001A = new ToolBarButton();
      this.\u001B = new ToolBarButton();
      this.\u0001 = new ImageList(this.\u0001);
      this.\u0001 = new RichTextBox();
      this.\u0001 = new ColorDialog();
      this.\u0001 = new OpenFileDialog();
      this.\u0001 = new SaveFileDialog();
      this.\u0001 = new ToolTip(this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0001, \u007F.\u0001(95694));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0001, ToolBarButtonStyle.Separator);
      \u001C\u001D.\u007E\u0005\u0090((object) this.\u0001, ToolBarAppearance.Flat);
      \u0008\u0084.\u007E\u0012\u0090((object) \u0011\u0084.\u007E\u0006\u0090((object) this.\u0001), new ToolBarButton[22]
      {
        this.\u0002,
        this.\u0003,
        this.\u0004,
        this.\u0005,
        this.\u0006,
        this.\u0007,
        this.\u0001,
        this.\u0008,
        this.\u000E,
        this.\u000F,
        this.\u0010,
        this.\u0011,
        this.\u0012,
        this.\u0013,
        this.\u0014,
        this.\u0015,
        this.\u0016,
        this.\u0017,
        this.\u0018,
        this.\u0019,
        this.\u001A,
        this.\u001B
      });
      \u000E\u001F.\u007E\u0007\u0090((object) this.\u0001, new Size(16, 16));
      \u0099\u001F.\u007E\u0008\u0090((object) this.\u0001, false);
      \u0099\u001F.\u007E\u000E\u0090((object) this.\u0001, true);
      \u0013\u0082.\u007E\u000F\u0090((object) this.\u0001, this.\u0001);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u0001(95715));
      \u0099\u001F.\u007E\u0010\u0090((object) this.\u0001, true);
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(504, 26));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0018\u001D.\u007E\u0011\u0090((object) this.\u0001, new ToolBarButtonClickEventHandler(this.\u001D\u0005));
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0002, 11);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0002, \u007F.\u0001(95724));
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0002, (object) \u007F.\u0001(95737));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0002, \u007F.\u0001(95746));
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0003, 10);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0003, \u007F.\u0001(95787));
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0003, (object) \u007F.\u0001(95800));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0003, \u007F.\u0001(95809));
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0004, \u007F.\u0001(95846));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0004, ToolBarButtonStyle.Separator);
      \u0017\u001D.\u007E\u0014\u0090((object) this.\u0005, (Menu) this.\u0001);
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0005, 14);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0005, \u007F.\u0001(95867));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0005, ToolBarButtonStyle.DropDownButton);
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0005, (object) \u007F.\u0001(95880));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0005, \u007F.\u0001(95889));
      \u0081\u001E.\u007E\u0010\u0089((object) \u0018\u0084.\u007E\u000E\u0089((object) this.\u0001), new MenuItem[7]
      {
        this.\u0001,
        this.\u0002,
        this.\u0003,
        this.\u0004,
        this.\u0005,
        this.\u0006,
        this.\u0007
      });
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0001, 0);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0001, \u007F.\u0001(66270));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0001, new EventHandler(this.\u001E\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0002, \u007F.\u0001(95910));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0002, new EventHandler(this.\u001E\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0003, 2);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0003, \u007F.\u0001(95927));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0003, new EventHandler(this.\u001E\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0004, 3);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0004, \u007F.\u0001(8838));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0004, new EventHandler(this.\u001E\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0005, 4);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0005, \u007F.\u0001(95940));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0005, new EventHandler(this.\u001E\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0006, 5);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0006, \u007F.\u0001(52045));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0006, new EventHandler(this.\u001E\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0007, 6);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0007, \u007F.\u0001(95949));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0007, new EventHandler(this.\u001E\u0005));
      \u0017\u001D.\u007E\u0014\u0090((object) this.\u0006, (Menu) this.\u0002);
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0006, 15);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0006, \u007F.\u0001(95962));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0006, ToolBarButtonStyle.DropDownButton);
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0006, (object) \u007F.\u0001(95979));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0006, \u007F.\u0001(95992));
      \u0081\u001E.\u007E\u0010\u0089((object) \u0018\u0084.\u007E\u000E\u0089((object) this.\u0002), new MenuItem[16]
      {
        this.\u0008,
        this.\u000E,
        this.\u000F,
        this.\u0010,
        this.\u0011,
        this.\u0012,
        this.\u0013,
        this.\u0014,
        this.\u0015,
        this.\u0016,
        this.\u0017,
        this.\u0018,
        this.\u0019,
        this.\u001A,
        this.\u001B,
        this.\u001C
      });
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0008, 0);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0008, \u007F.\u0001(31394));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0008, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u000E, 1);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u000E, \u007F.\u0001(31399));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u000E, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u000F, 2);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u000F, \u007F.\u0001(44470));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u000F, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0010, 3);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0010, \u007F.\u0001(96021));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0010, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0011, 4);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0011, \u007F.\u0001(96026));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0011, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0012, 5);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0012, \u007F.\u0001(96031));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0012, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0013, 6);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0013, \u007F.\u0001(96036));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0013, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0014, 7);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0014, \u007F.\u0001(96041));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0014, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0015, 8);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0015, \u007F.\u0001(96046));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0015, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0016, 9);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0016, \u007F.\u0001(96051));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0016, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0017, 10);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0017, \u007F.\u0001(96056));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0017, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0018, 11);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0018, \u007F.\u0001(96061));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0018, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0019, 12);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0019, \u007F.\u0001(96066));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0019, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u001A, 13);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u001A, \u007F.\u0001(96071));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u001A, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u001B, 14);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u001B, \u007F.\u0001(96076));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u001B, new EventHandler(this.\u001F\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u001C, 15);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u001C, \u007F.\u0001(96081));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u001C, new EventHandler(this.\u001F\u0005));
      \u0017\u001D.\u007E\u0014\u0090((object) this.\u0007, (Menu) this.\u0003);
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0007, 7);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0007, \u007F.\u0001(96086));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0007, ToolBarButtonStyle.DropDownButton);
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0007, (object) \u007F.\u0001(96099));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0007, \u007F.\u0001(96108));
      \u0081\u001E.\u007E\u0010\u0089((object) \u0018\u0084.\u007E\u000E\u0089((object) this.\u0003), new MenuItem[9]
      {
        this.\u001D,
        this.\u001E,
        this.\u001F,
        this.\u007F,
        this.\u0080,
        this.\u0081,
        this.\u0082,
        this.\u0083,
        this.\u0084
      });
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u001D, 0);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u001D, \u007F.\u0001(96137));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u001D, new EventHandler(this.\u0081\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u001E, 1);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u001E, \u007F.\u0001(56980));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u001E, new EventHandler(this.\u0089\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u001F, 2);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u001F, \u007F.\u0001(7310));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u007F, 3);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u007F, \u007F.\u0001(62872));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u007F, new EventHandler(this.\u0082\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0080, 4);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0080, \u007F.\u0001(96146));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0080, new EventHandler(this.\u0086\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0081, 5);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0081, \u007F.\u0001(62845));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0081, new EventHandler(this.\u0084\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0082, 6);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0082, \u007F.\u0001(96159));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0082, new EventHandler(this.\u0087\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0083, 7);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0083, \u007F.\u0001(62840));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0083, new EventHandler(this.\u0083\u0005));
      \u0011\u001F.\u007E\u0096\u008D((object) this.\u0084, 8);
      \u0092\u0081.\u007E\u0098\u008D((object) this.\u0084, \u007F.\u0001(62890));
      \u0087\u007F.\u007E\u0099\u008D((object) this.\u0084, new EventHandler(this.\u0088\u0005));
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0008, 0);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0008, \u007F.\u0001(96172));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0008, ToolBarButtonStyle.ToggleButton);
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0008, (object) \u007F.\u0001(96185));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0008, \u007F.\u0001(96194));
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u000E, 1);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u000E, \u007F.\u0001(96203));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u000E, ToolBarButtonStyle.ToggleButton);
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u000E, (object) \u007F.\u0001(96216));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u000E, \u007F.\u0001(96225));
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u000F, 2);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u000F, \u007F.\u0001(96234));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u000F, ToolBarButtonStyle.ToggleButton);
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u000F, (object) \u007F.\u0001(96251));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u000F, \u007F.\u0001(96264));
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0010, 3);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0010, \u007F.\u0001(96277));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0010, ToolBarButtonStyle.ToggleButton);
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0010, (object) \u007F.\u0001(96294));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0010, \u007F.\u0001(96307));
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0011, \u007F.\u0001(96320));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0011, ToolBarButtonStyle.Separator);
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0012, 4);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0012, \u007F.\u0001(96341));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0012, ToolBarButtonStyle.ToggleButton);
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0012, (object) \u007F.\u0001(96354));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0012, \u007F.\u0001(96363));
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0013, 5);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0013, \u007F.\u0001(96380));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0013, ToolBarButtonStyle.ToggleButton);
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0013, (object) \u007F.\u0001(96393));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0013, \u007F.\u0001(96402));
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0014, 6);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0014, \u007F.\u0001(96419));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0014, ToolBarButtonStyle.ToggleButton);
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0014, (object) \u007F.\u0001(96432));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0014, \u007F.\u0001(96441));
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0015, \u007F.\u0001(96458));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0015, ToolBarButtonStyle.Separator);
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0016, 12);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0016, \u007F.\u0001(96479));
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0016, (object) \u007F.\u0001(96492));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0016, \u007F.\u0001(96501));
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0017, 13);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0017, \u007F.\u0001(96510));
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0017, (object) \u007F.\u0001(96523));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0017, \u007F.\u0001(96532));
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0018, \u007F.\u0001(96541));
      \u0019\u0086.\u007E\u0019\u0090((object) this.\u0018, ToolBarButtonStyle.Separator);
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u0019, 17);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u0019, \u007F.\u0001(96562));
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u0019, (object) \u007F.\u0001(96571));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u0019, \u007F.\u0001(96576));
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u001A, 18);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u001A, \u007F.\u0001(96581));
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u001A, (object) \u007F.\u0001(96594));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u001A, \u007F.\u0001(46904));
      \u0011\u001F.\u007E\u0015\u0090((object) this.\u001B, 19);
      \u0092\u0081.\u007E\u0016\u0090((object) this.\u001B, \u007F.\u0001(96603));
      \u008E\u007F.\u007E\u001B\u0090((object) this.\u001B, (object) \u007F.\u0001(96616));
      \u0092\u0081.\u007E\u001C\u0090((object) this.\u001B, \u007F.\u0001(96625));
      \u0005\u001D.\u007E\u0093\u0088((object) this.\u0001, (ImageListStreamer) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u007F.\u0001(96634)));
      \u0081\u0082.\u007E\u0094\u0088((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 0, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 1, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 2, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 3, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 4, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 5, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 6, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 7, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 8, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 9, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 10, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 11, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 12, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 13, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 14, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 15, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 16, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 17, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 18, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 19, \u007F.\u0001(7000));
      \u008B\u0081.\u007E\u0095\u0088((object) \u001A\u001C.\u007E\u0092\u0088((object) this.\u0001), 20, \u007F.\u0001(7000));
      \u0099\u001F.\u007E\u0096\u008E((object) this.\u0001, true);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 26));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u007F.\u0001(96671));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(504, 198));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u007F.\u0001(7000));
      \u0008\u001D.\u007E\u0006\u008F((object) this.\u0001, new LinkClickedEventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u0007\u008F((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0087\u007F.\u007E\u001E\u0084((object) this.\u0001, new EventHandler(this.\u0080\u0005));
      \u0092\u0081.\u007E\u0091\u008A((object) this.\u0001, \u007F.\u0001(96680));
      \u0092\u0081.\u007E\u0095\u008A((object) this.\u0001, \u007F.\u0001(96685));
      \u0092\u0081.\u007E\u0099\u008A((object) this.\u0001, \u007F.\u0001(96746));
      \u0092\u0081.\u007E\u0091\u008A((object) this.\u0001, \u007F.\u0001(96680));
      \u0092\u0081.\u007E\u0095\u008A((object) this.\u0001, \u007F.\u0001(96759));
      \u0092\u0081.\u007E\u0099\u008A((object) this.\u0001, \u007F.\u0001(96816));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0092\u0081.\u0010\u0084((object) this, \u007F.\u0001(96829));
      \u000E\u001F.\u0018\u0084((object) this, new Size(504, 224));
      \u0087\u007F.\u008F\u0084((object) this, new EventHandler(this.\u007F\u0005));
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, ToolBarButtonClickEventArgs e)
    {
      bool add = \u0099\u0082.\u007E\u0017\u0090((object) \u0011\u001E.\u007E\u001F\u0090((object) e));
      string key;
      if ((key = \u0002\u007F.\u007E\u0019\u0093((object) \u0002\u007F.\u007E\u0087\u0091(\u0005\u007F.\u007E\u001A\u0090((object) \u0011\u001E.\u007E\u001F\u0090((object) e))))) == null)
        return;
      // ISSUE: reference to a compiler-generated field
      if (\u0080.\u0003 == null)
      {
        // ISSUE: reference to a compiler-generated field
        \u0080.\u0003 = new Dictionary<string, int>(15)
        {
          {
            \u007F.\u0001(96185),
            0
          },
          {
            \u007F.\u0001(96216),
            1
          },
          {
            \u007F.\u0001(96251),
            2
          },
          {
            \u007F.\u0001(96294),
            3
          },
          {
            \u007F.\u0001(96354),
            4
          },
          {
            \u007F.\u0001(96393),
            5
          },
          {
            \u007F.\u0001(96432),
            6
          },
          {
            \u007F.\u0001(96099),
            7
          },
          {
            \u007F.\u0001(96492),
            8
          },
          {
            \u007F.\u0001(96523),
            9
          },
          {
            \u007F.\u0001(95800),
            10
          },
          {
            \u007F.\u0001(95737),
            11
          },
          {
            \u007F.\u0001(96571),
            12
          },
          {
            \u007F.\u0001(96594),
            13
          },
          {
            \u007F.\u0001(96616),
            14
          }
        };
      }
      int num;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: explicit non-virtual call
      if (!__nonvirtual (\u0080.\u0003.TryGetValue(key, out num)))
        return;
      switch (num)
      {
        case 0:
          this.\u001D\u0005(FontStyle.Bold, add);
          break;
        case 1:
          this.\u001D\u0005(FontStyle.Italic, add);
          break;
        case 2:
          this.\u001D\u0005(FontStyle.Underline, add);
          break;
        case 3:
          this.\u001D\u0005(FontStyle.Strikeout, add);
          break;
        case 4:
          \u0019\u001F.\u007E\u009E\u008E((object) this.\u0001, HorizontalAlignment.Left);
          \u0099\u001F.\u007E\u0018\u0090((object) this.\u0013, false);
          \u0099\u001F.\u007E\u0018\u0090((object) this.\u0014, false);
          break;
        case 5:
          \u0099\u001F.\u007E\u0018\u0090((object) this.\u0012, false);
          \u0019\u001F.\u007E\u009E\u008E((object) this.\u0001, HorizontalAlignment.Center);
          \u0099\u001F.\u007E\u0018\u0090((object) this.\u0014, false);
          break;
        case 6:
          \u0099\u001F.\u007E\u0018\u0090((object) this.\u0012, false);
          \u0099\u001F.\u007E\u0018\u0090((object) this.\u0013, false);
          \u0019\u001F.\u007E\u009E\u008E((object) this.\u0001, HorizontalAlignment.Right);
          break;
        case 7:
          \u0081\u0082.\u007E\u0001\u008F((object) this.\u0001, \u009A\u0080.\u0090\u001F());
          break;
        case 8:
          \u001A\u001E.\u007E\u0081\u008A((object) this.\u0001);
          break;
        case 9:
          \u001A\u001E.\u007E\u000E\u008F((object) this.\u0001);
          break;
        case 10:
          try
          {
            if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK || \u0005\u0081.\u007E\u0001\u0093((object) \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001)) <= 0)
              break;
            if (\u0016\u001D.\u007E\u0097\u0092((object) \u0002\u007F.\u007E\u0019\u0093((object) \u009C\u0080.\u0006\u009F(\u0002\u007F.\u007E\u0092\u008A((object) this.\u0001))), \u007F.\u0001(96858)))
            {
              \u0091\u001E.\u007E\u0008\u008F((object) this.\u0001, \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001), RichTextBoxStreamType.RichText);
              break;
            }
            \u0091\u001E.\u007E\u0008\u008F((object) this.\u0001, \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001), RichTextBoxStreamType.PlainText);
            break;
          }
          catch (ArgumentException ex)
          {
            ex.\u001D\u0005((object) \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
            \u0017.\u001E\u0005(\u0081\u0086.\u0086\u0093(\u007F.\u0001(96867), \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001)), \u007F.\u0001(96920));
            break;
          }
          catch (IOException ex)
          {
            ex.\u001D\u0005((object) \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
            \u0017.\u001D\u0005((Exception) ex, \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
            break;
          }
        case 11:
          try
          {
            if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK || \u0005\u0081.\u007E\u0001\u0093((object) \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001)) <= 0)
              break;
            if (\u0016\u001D.\u007E\u0097\u0092((object) \u0002\u007F.\u007E\u0019\u0093((object) \u009C\u0080.\u0006\u009F(\u0002\u007F.\u007E\u0092\u008A((object) this.\u0001))), \u007F.\u0001(96858)))
            {
              \u0092\u0081.\u007E\u000F\u008F((object) this.\u0001, \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
              break;
            }
            \u0091\u001E.\u007E\u0010\u008F((object) this.\u0001, \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001), RichTextBoxStreamType.PlainText);
            break;
          }
          catch (IOException ex)
          {
            ex.\u001D\u0005((object) \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
            \u0017.\u001D\u0005((Exception) ex, \u0002\u007F.\u007E\u0092\u008A((object) this.\u0001));
            break;
          }
        case 12:
          if (\u0005\u0081.\u007E\u0001\u0093((object) \u0002\u007F.\u007E\u001A\u008A((object) this.\u0001)) <= 0)
            break;
          \u001A\u001E.\u007E\u001F\u008A((object) this.\u0001);
          break;
        case 13:
          if (\u0005\u0081.\u007E\u0001\u0093((object) \u0002\u007F.\u007E\u001A\u008A((object) this.\u0001)) <= 0)
            break;
          \u001A\u001E.\u007E\u001E\u008A((object) this.\u0001);
          break;
        case 14:
          try
          {
            \u001A\u001E.\u007E\u007F\u008A((object) this.\u0001);
            break;
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005();
            \u0017.\u001E\u0005(\u007F.\u0001(96941), \u007F.\u0001(97010));
            break;
          }
      }
    }

    public void \u001E\u0005()
    {
      Font font = this.\u001D\u0005();
      int num = (int) \u008D\u001C.\u007E\u0095\u0081((object) font);
      \u0099\u001F.\u007E\u0018\u0090((object) this.\u0008, \u0099\u0082.\u007E\u0090\u0081((object) font));
      \u0099\u001F.\u007E\u0018\u0090((object) this.\u000E, \u0099\u0082.\u007E\u0091\u0081((object) font));
      \u0099\u001F.\u007E\u0018\u0090((object) this.\u000F, \u0099\u0082.\u007E\u0094\u0081((object) font));
      \u0099\u001F.\u007E\u0018\u0090((object) this.\u0010, \u0099\u0082.\u007E\u0093\u0081((object) font));
      \u0099\u001F.\u007E\u0018\u0090((object) this.\u0012, \u0014\u007F.\u007E\u009D\u008E((object) this.\u0001) == HorizontalAlignment.Left);
      \u0099\u001F.\u007E\u0018\u0090((object) this.\u0013, \u0014\u007F.\u007E\u009D\u008E((object) this.\u0001) == HorizontalAlignment.Center);
      \u0099\u001F.\u007E\u0018\u0090((object) this.\u0014, \u0014\u007F.\u007E\u009D\u008E((object) this.\u0001) == HorizontalAlignment.Right);
      bool flag = false;
      IEnumerator enumerator1 = \u0015\u0082.\u007E\u0011\u0089((object) \u0018\u0084.\u007E\u000E\u0089((object) this.\u0003));
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator1))
        {
          MenuItem menuItem = (MenuItem) \u0005\u007F.\u007E\u0092\u0092((object) enumerator1);
          \u0099\u001F.\u007E\u0094\u008D((object) menuItem, \u0097\u001D.\u0019\u007F(\u0091\u0084.\u007E\u009F\u008E((object) this.\u0001), \u0097\u0084.\u0018\u007F(\u0002\u007F.\u007E\u0097\u008D((object) menuItem))));
          if (\u0099\u0082.\u007E\u0093\u008D((object) menuItem))
            flag = true;
        }
      }
      finally
      {
        IDisposable disposable = enumerator1 as IDisposable;
        if (disposable != null)
          \u001A\u001E.\u007E\u0094\u0092((object) disposable);
      }
      \u0081\u0082.\u007E\u008B\u0088((object) this.\u0001, \u0091\u0084.\u007E\u009F\u008E((object) this.\u0001));
      \u0099\u001F.\u007E\u0094\u008D((object) this.\u001E, !flag);
      IEnumerator enumerator2 = \u0015\u0082.\u007E\u0011\u0089((object) \u0018\u0084.\u007E\u000E\u0089((object) this.\u0001));
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator2))
        {
          MenuItem menuItem = (MenuItem) \u0005\u007F.\u007E\u0092\u0092((object) enumerator2);
          \u0099\u001F.\u007E\u0094\u008D((object) menuItem, \u0008\u001F.\u009A\u0092(\u0002\u007F.\u007E\u0098\u0081((object) \u009D\u001D.\u007E\u008E\u0081((object) font)), \u0002\u007F.\u007E\u0097\u008D((object) menuItem)));
        }
      }
      finally
      {
        IDisposable disposable = enumerator2 as IDisposable;
        if (disposable != null)
          \u001A\u001E.\u007E\u0094\u0092((object) disposable);
      }
      IEnumerator enumerator3 = \u0015\u0082.\u007E\u0011\u0089((object) \u0018\u0084.\u007E\u000E\u0089((object) this.\u0002));
      try
      {
        while (\u0099\u0082.\u007E\u0091\u0092((object) enumerator3))
        {
          MenuItem menuItem = (MenuItem) \u0005\u007F.\u007E\u0092\u0092((object) enumerator3);
          \u0099\u001F.\u007E\u0094\u008D((object) menuItem, (double) (int) \u0094\u0084.\u007E\u0097\u0081((object) font) == (double) \u0008\u001C.\u007F\u0097(\u0002\u007F.\u007E\u0097\u008D((object) menuItem)));
        }
      }
      finally
      {
        IDisposable disposable = enumerator3 as IDisposable;
        if (disposable != null)
          \u001A\u001E.\u007E\u0094\u0092((object) disposable);
      }
    }

    private void \u001F\u0005()
    {
      if (!\u0099\u0082.\u007E\u001D\u0090((object) this.\u0002) && !\u0099\u0082.\u007E\u001D\u0090((object) this.\u0003))
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0004, false);
      else
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0004, true);
      if (!\u0099\u0082.\u007E\u001D\u0090((object) this.\u0005) && !\u0099\u0082.\u007E\u001D\u0090((object) this.\u0006) && !\u0099\u0082.\u007E\u001D\u0090((object) this.\u0007))
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0001, false);
      else
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0001, true);
      if (!\u0099\u0082.\u007E\u001D\u0090((object) this.\u0008) && !\u0099\u0082.\u007E\u001D\u0090((object) this.\u000E) && (!\u0099\u0082.\u007E\u001D\u0090((object) this.\u000F) && !\u0099\u0082.\u007E\u001D\u0090((object) this.\u0010)))
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0011, false);
      else
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0011, true);
      if (!\u0099\u0082.\u007E\u001D\u0090((object) this.\u0012) && !\u0099\u0082.\u007E\u001D\u0090((object) this.\u0013) && !\u0099\u0082.\u007E\u001D\u0090((object) this.\u0014))
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0015, false);
      else
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0015, true);
      if (!\u0099\u0082.\u007E\u001D\u0090((object) this.\u0016) && !\u0099\u0082.\u007E\u001D\u0090((object) this.\u0017))
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0018, false);
      else
        \u0099\u001F.\u007E\u001E\u0090((object) this.\u0018, true);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005();
      if (this.\u0001 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0001, (object) this, e);
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005(\u0002\u007F.\u007E\u0097\u008D((object) (MenuItem) sender));
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      this.\u001D\u0005(\u0008\u001C.\u007F\u0097(\u0002\u007F.\u007E\u0097\u008D((object) (MenuItem) sender)));
    }

    private void \u001D\u0005(object sender, LinkClickedEventArgs e)
    {
      \u0003.\u001F\u0005(\u0002\u007F.\u007E\u001C\u008C((object) e));
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      if (!\u0099\u0082.\u007E\u0016\u008A((object) this.\u0001) || this.\u0002 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
    }

    private void \u0080\u0005(object sender, EventArgs e)
    {
      if (this.\u0002 == null)
        return;
      \u0095\u001E.\u007E\u009E\u0095((object) this.\u0002, (object) this, EventArgs.Empty);
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005(\u009A\u0080.\u0090\u001F());
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005(\u009A\u0080.\u0091\u001F());
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005(\u009A\u0080.\u0005\u007F());
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005(\u009A\u0080.\u0099\u001F());
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005(\u009A\u0080.\u0097\u001F());
    }

    private void \u0087\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005(\u009A\u0080.\u009B\u001F());
    }

    private void \u0088\u0005(object sender, EventArgs e)
    {
      this.\u001E\u0005(\u009A\u0080.\u000F\u007F());
    }

    private void \u0089\u0005(object sender, EventArgs e)
    {
      if (\u0097\u001E.\u007E\u0088\u0088((object) this.\u0001) != DialogResult.OK)
        return;
      this.\u001E\u0005(\u0091\u0084.\u007E\u008A\u0088((object) this.\u0001));
    }

    public void \u001E\u0005(string fontFamily)
    {
      int num1 = \u0005\u0081.\u007E\u001C\u008A((object) this.\u0001);
      int num2 = \u0005\u0081.\u007E\u001B\u008A((object) this.\u0001);
      int num3 = 0;
      if (num2 <= 1 && \u0080\u0084.\u007E\u0002\u008F((object) this.\u0001) != null)
      {
        \u0094\u0083.\u007E\u0003\u008F((object) this.\u0001, new Font(fontFamily, \u0094\u0084.\u007E\u0096\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0001)), \u008D\u001C.\u007E\u0095\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0001))));
      }
      else
      {
        \u0092\u0081.\u007E\u009B\u008E((object) this.\u0002, \u0002\u007F.\u007E\u0004\u008F((object) this.\u0001));
        for (int index = 0; index < num2; ++index)
        {
          \u0090\u001F.\u007E\u0080\u008A((object) this.\u0002, num3 + index, 1);
          \u0094\u0083.\u007E\u0003\u008F((object) this.\u0002, new Font(fontFamily, \u0094\u0084.\u007E\u0096\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002)), \u008D\u001C.\u007E\u0095\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002))));
        }
        \u0090\u001F.\u007E\u0080\u008A((object) this.\u0002, num3, num2);
        \u0092\u0081.\u007E\u0005\u008F((object) this.\u0001, \u0002\u007F.\u007E\u0004\u008F((object) this.\u0002));
        \u0090\u001F.\u007E\u0080\u008A((object) this.\u0001, num1, num2);
      }
    }

    public void \u001D\u0005(FontStyle style, bool add)
    {
      if (style != FontStyle.Bold && style != FontStyle.Italic && (style != FontStyle.Strikeout && style != FontStyle.Underline))
        throw new InvalidProgramException(\u007F.\u0001(97036));
      int num1 = \u0005\u0081.\u007E\u001C\u008A((object) this.\u0001);
      int num2 = \u0005\u0081.\u007E\u001B\u008A((object) this.\u0001);
      int num3 = 0;
      if (num2 <= 1 && \u0080\u0084.\u007E\u0002\u008F((object) this.\u0001) != null)
      {
        if (add)
          \u0094\u0083.\u007E\u0003\u008F((object) this.\u0001, new Font(\u0080\u0084.\u007E\u0002\u008F((object) this.\u0001), \u008D\u001C.\u007E\u0095\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0001)) | style));
        else
          \u0094\u0083.\u007E\u0003\u008F((object) this.\u0001, new Font(\u0080\u0084.\u007E\u0002\u008F((object) this.\u0001), \u008D\u001C.\u007E\u0095\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0001)) & ~style));
      }
      else
      {
        \u0092\u0081.\u007E\u009B\u008E((object) this.\u0002, \u0002\u007F.\u007E\u0004\u008F((object) this.\u0001));
        for (int index = 0; index < num2; ++index)
        {
          \u0090\u001F.\u007E\u0080\u008A((object) this.\u0002, num3 + index, 1);
          if (add)
            \u0094\u0083.\u007E\u0003\u008F((object) this.\u0002, new Font(\u0080\u0084.\u007E\u0002\u008F((object) this.\u0002), \u008D\u001C.\u007E\u0095\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002)) | style));
          else
            \u0094\u0083.\u007E\u0003\u008F((object) this.\u0002, new Font(\u0080\u0084.\u007E\u0002\u008F((object) this.\u0002), \u008D\u001C.\u007E\u0095\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002)) & ~style));
        }
        \u0090\u001F.\u007E\u0080\u008A((object) this.\u0002, num3, num2);
        \u0092\u0081.\u007E\u0005\u008F((object) this.\u0001, \u0002\u007F.\u007E\u0004\u008F((object) this.\u0002));
        \u0090\u001F.\u007E\u0080\u008A((object) this.\u0001, num1, num2);
      }
    }

    public void \u001D\u0005(float fontSize)
    {
      if ((double) fontSize <= 0.0)
        throw new InvalidProgramException(\u007F.\u0001(97093));
      int num1 = \u0005\u0081.\u007E\u001C\u008A((object) this.\u0001);
      int num2 = \u0005\u0081.\u007E\u001B\u008A((object) this.\u0001);
      int num3 = 0;
      if (num2 <= 1 && \u0080\u0084.\u007E\u0002\u008F((object) this.\u0001) != null)
      {
        \u0094\u0083.\u007E\u0003\u008F((object) this.\u0001, new Font(\u009D\u001D.\u007E\u008E\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0001)), fontSize, \u008D\u001C.\u007E\u0095\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0001))));
      }
      else
      {
        \u0092\u0081.\u007E\u009B\u008E((object) this.\u0002, \u0002\u007F.\u007E\u0004\u008F((object) this.\u0001));
        for (int index = 0; index < num2; ++index)
        {
          \u0090\u001F.\u007E\u0080\u008A((object) this.\u0002, num3 + index, 1);
          \u0094\u0083.\u007E\u0003\u008F((object) this.\u0002, new Font(\u009D\u001D.\u007E\u008E\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002)), fontSize, \u008D\u001C.\u007E\u0095\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002))));
        }
        \u0090\u001F.\u007E\u0080\u008A((object) this.\u0002, num3, num2);
        \u0092\u0081.\u007E\u0005\u008F((object) this.\u0001, \u0002\u007F.\u007E\u0004\u008F((object) this.\u0002));
        \u0090\u001F.\u007E\u0080\u008A((object) this.\u0001, num1, num2);
      }
    }

    public void \u001E\u0005(Color newColor)
    {
      int num1 = \u0005\u0081.\u007E\u001C\u008A((object) this.\u0001);
      int num2 = \u0005\u0081.\u007E\u001B\u008A((object) this.\u0001);
      int num3 = 0;
      if (num2 <= 1 && \u0080\u0084.\u007E\u0002\u008F((object) this.\u0001) != null)
      {
        \u0081\u0082.\u007E\u0001\u008F((object) this.\u0001, newColor);
      }
      else
      {
        \u0092\u0081.\u007E\u009B\u008E((object) this.\u0002, \u0002\u007F.\u007E\u0004\u008F((object) this.\u0001));
        for (int index = 0; index < num2; ++index)
        {
          \u0090\u001F.\u007E\u0080\u008A((object) this.\u0002, num3 + index, 1);
          \u0081\u0082.\u007E\u0001\u008F((object) this.\u0002, newColor);
        }
        \u0090\u001F.\u007E\u0080\u008A((object) this.\u0002, num3, num2);
        \u0092\u0081.\u007E\u0005\u008F((object) this.\u0001, \u0002\u007F.\u007E\u0004\u008F((object) this.\u0002));
        \u0090\u001F.\u007E\u0080\u008A((object) this.\u0001, num1, num2);
      }
    }

    public Font \u001D\u0005()
    {
      int num1 = \u0005\u0081.\u007E\u001B\u008A((object) this.\u0001);
      int num2 = 0;
      if (num1 <= 1)
      {
        if (\u0080\u0084.\u007E\u0002\u008F((object) this.\u0001) != null)
          return \u0080\u0084.\u007E\u0002\u008F((object) this.\u0001);
        return \u0080\u0084.\u007E\u0092\u0083((object) this.\u0001);
      }
      \u0092\u0081.\u007E\u009B\u008E((object) this.\u0002, \u0002\u007F.\u007E\u0004\u008F((object) this.\u0001));
      FontStyle fontStyle = FontStyle.Bold | FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout;
      \u0090\u001F.\u007E\u0080\u008A((object) this.\u0002, num2, 1);
      string familyName = \u0002\u007F.\u007E\u0092\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002));
      float emSize = \u0094\u0084.\u007E\u0096\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002));
      FontStyle style = fontStyle & \u008D\u001C.\u007E\u0095\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002));
      for (int index = 1; index < num1; ++index)
      {
        \u0090\u001F.\u007E\u0080\u008A((object) this.\u0002, num2 + index, 1);
        style &= \u008D\u001C.\u007E\u0095\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002));
        if (\u0008\u001F.\u009B\u0092(familyName, \u0002\u007F.\u007E\u0098\u0081((object) \u009D\u001D.\u007E\u008E\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002)))))
          familyName = \u007F.\u0001(7000);
        if ((double) emSize != (double) \u0094\u0084.\u007E\u0096\u0081((object) \u0080\u0084.\u007E\u0002\u008F((object) this.\u0002)))
          emSize = 0.0f;
      }
      if (\u0008\u001F.\u009A\u0092(familyName, \u007F.\u0001(7000)))
        familyName = \u0002\u007F.\u007E\u0098\u0081((object) \u009D\u001D.\u007E\u008E\u0081((object) \u0080\u0084.\u007E\u0092\u0083((object) this.\u0002)));
      if ((double) emSize == 0.0)
        emSize = \u0094\u0084.\u007E\u0096\u0081((object) \u0080\u0084.\u007E\u0092\u0083((object) this.\u0002));
      return new Font(familyName, emSize, style);
    }
  }
}
