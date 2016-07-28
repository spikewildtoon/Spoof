// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u001A;
using \u001C;
using \u001E;
using \u0080;
using \u0081;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TSN.Controls;

namespace \u0014
{
  internal sealed class \u001B : Form
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private IContainer \u0001;
    private PictureBox \u0001;
    private \u0005 \u0001;
    private ComboBox \u0001;
    private Label \u0001;
    private RadioButton \u0001;
    private RadioButton \u0002;
    private Label \u0002;
    private Label \u0003;
    private Button \u0001;
    private Button \u0002;
    private RadioButton \u0003;
    private Label \u0004;

    public List<\u0018> CheckedBeanCombinations
    {
      get
      {
        return this.\u0001.Items.OfType<ListViewItemState<\u0018>>().Where<ListViewItemState<\u0018>>((Func<ListViewItemState<\u0018>, bool>) (item => \u0099\u0082.\u007E\u0017\u008D((object) item))).Select<ListViewItemState<\u0018>, \u0018>((Func<ListViewItemState<\u0018>, \u0018>) (item => item.State)).ToList<\u0018>();
      }
      set
      {
        this.\u0001.Items.OfType<ListViewItemState<\u0018>>().\u001D\u0005<ListViewItemState<\u0018>>(new Action<ListViewItemState<\u0018>>((object) new \u001B.\u0001()
        {
          \u0001 = value
        }, __methodptr(\u001D\u0005)));
      }
    }

    public \u0081.\u001E PlantMethod
    {
      get
      {
        if (\u0099\u0082.\u007E\u0090\u008E((object) this.\u0001))
          return \u0081.\u001E.\u0003;
        return \u0099\u0082.\u007E\u0090\u008E((object) this.\u0002) ? \u0081.\u001E.\u0002 : \u0081.\u001E.\u0001;
      }
      set
      {
        value.\u001D\u0005();
        switch (value)
        {
          case \u0081.\u001E.\u0001:
            \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, false);
            \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, false);
            \u0099\u001F.\u007E\u0091\u008E((object) this.\u0003, true);
            break;
          case \u0081.\u001E.\u0002:
            \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, false);
            \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, true);
            \u0099\u001F.\u007E\u0091\u008E((object) this.\u0003, false);
            break;
          case \u0081.\u001E.\u0003:
            \u0099\u001F.\u007E\u0091\u008E((object) this.\u0002, false);
            \u0099\u001F.\u007E\u0091\u008E((object) this.\u0001, true);
            \u0099\u001F.\u007E\u0091\u008E((object) this.\u0003, false);
            break;
        }
      }
    }

    static \u001B()
    {
      \u0004.\u001D\u0005(typeof (\u001B));
    }

    public \u001B()
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u001B)));
      ListViewGroup listViewGroup1 = new ListViewGroup(\u001B.\u0001(5844), HorizontalAlignment.Left);
      ListViewGroup listViewGroup2 = new ListViewGroup(\u001B.\u0001(5853), HorizontalAlignment.Left);
      ListViewGroup listViewGroup3 = new ListViewGroup(\u001B.\u0001(5866), HorizontalAlignment.Left);
      ListViewGroup listViewGroup4 = new ListViewGroup(\u001B.\u0001(5879), HorizontalAlignment.Left);
      ListViewGroup listViewGroup5 = new ListViewGroup(\u001B.\u0001(5892), HorizontalAlignment.Left);
      ListViewGroup listViewGroup6 = new ListViewGroup(\u001B.\u0001(5905), HorizontalAlignment.Left);
      ListViewGroup listViewGroup7 = new ListViewGroup(\u001B.\u0001(5918), HorizontalAlignment.Left);
      ListViewGroup listViewGroup8 = new ListViewGroup(\u001B.\u0001(5931), HorizontalAlignment.Left);
      ListViewGroup listViewGroup9 = new ListViewGroup(\u001B.\u0001(5844), HorizontalAlignment.Left);
      ListViewGroup listViewGroup10 = new ListViewGroup(\u001B.\u0001(5853), HorizontalAlignment.Left);
      ListViewGroup listViewGroup11 = new ListViewGroup(\u001B.\u0001(5866), HorizontalAlignment.Left);
      ListViewGroup listViewGroup12 = new ListViewGroup(\u001B.\u0001(5879), HorizontalAlignment.Left);
      ListViewGroup listViewGroup13 = new ListViewGroup(\u001B.\u0001(5892), HorizontalAlignment.Left);
      ListViewGroup listViewGroup14 = new ListViewGroup(\u001B.\u0001(5905), HorizontalAlignment.Left);
      ListViewGroup listViewGroup15 = new ListViewGroup(\u001B.\u0001(5918), HorizontalAlignment.Left);
      ListViewGroup listViewGroup16 = new ListViewGroup(\u001B.\u0001(5931), HorizontalAlignment.Left);
      ListViewGroup listViewGroup17 = new ListViewGroup(\u001B.\u0001(5844), HorizontalAlignment.Left);
      ListViewGroup listViewGroup18 = new ListViewGroup(\u001B.\u0001(5853), HorizontalAlignment.Left);
      ListViewGroup listViewGroup19 = new ListViewGroup(\u001B.\u0001(5866), HorizontalAlignment.Left);
      ListViewGroup listViewGroup20 = new ListViewGroup(\u001B.\u0001(5879), HorizontalAlignment.Left);
      ListViewGroup listViewGroup21 = new ListViewGroup(\u001B.\u0001(5892), HorizontalAlignment.Left);
      ListViewGroup listViewGroup22 = new ListViewGroup(\u001B.\u0001(5905), HorizontalAlignment.Left);
      ListViewGroup listViewGroup23 = new ListViewGroup(\u001B.\u0001(5918), HorizontalAlignment.Left);
      ListViewGroup listViewGroup24 = new ListViewGroup(\u001B.\u0001(5931), HorizontalAlignment.Left);
      ListViewGroup listViewGroup25 = new ListViewGroup(\u001B.\u0001(5844), HorizontalAlignment.Left);
      ListViewGroup listViewGroup26 = new ListViewGroup(\u001B.\u0001(5853), HorizontalAlignment.Left);
      ListViewGroup listViewGroup27 = new ListViewGroup(\u001B.\u0001(5866), HorizontalAlignment.Left);
      ListViewGroup listViewGroup28 = new ListViewGroup(\u001B.\u0001(5879), HorizontalAlignment.Left);
      ListViewGroup listViewGroup29 = new ListViewGroup(\u001B.\u0001(5892), HorizontalAlignment.Left);
      ListViewGroup listViewGroup30 = new ListViewGroup(\u001B.\u0001(5905), HorizontalAlignment.Left);
      ListViewGroup listViewGroup31 = new ListViewGroup(\u001B.\u0001(5918), HorizontalAlignment.Left);
      ListViewGroup listViewGroup32 = new ListViewGroup(\u001B.\u0001(5931), HorizontalAlignment.Left);
      this.\u0001 = new PictureBox();
      this.\u0001 = new ComboBox();
      this.\u0001 = new Label();
      this.\u0001 = new RadioButton();
      this.\u0002 = new RadioButton();
      this.\u0002 = new Label();
      this.\u0003 = new Label();
      this.\u0001 = new Button();
      this.\u0002 = new Button();
      this.\u0003 = new RadioButton();
      this.\u0001 = new \u0005();
      this.\u0004 = new Label();
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001B.\u0001(5944)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(-46, -65));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0001(5985));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(591, 325));
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 29);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0019\u001D.\u007E\u009B\u0088((object) this.\u0001, ComboBoxStyle.DropDownList);
      \u0003\u0083.\u007E\u0004\u0089((object) \u0016\u0083.\u007E\u0097\u0088((object) this.\u0001), new object[8]
      {
        (object) \u001B.\u0001(5844),
        (object) \u001B.\u0001(6018),
        (object) \u001B.\u0001(6027),
        (object) \u001B.\u0001(6036),
        (object) \u001B.\u0001(6045),
        (object) \u001B.\u0001(6054),
        (object) \u001B.\u0001(6063),
        (object) \u001B.\u0001(6072)
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(14, 334));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0001(6081));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(73, 21));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 3);
      \u0087\u007F.\u007E\u009C\u0088((object) this.\u0001, new EventHandler(this.\u001D\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001B.\u0001(5714), 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0098\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(6, 316));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0001(6106));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(85, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 32);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u0001(6127));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.MiddleLeft);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u001B.\u0001(5714), 9f));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0098\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(14, 291));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0001(6144));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(87, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 2);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u0001(6177));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, false);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001B.\u0001(5714), 9f));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0098\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(14, 266));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001B.\u0001(6194));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(73, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 1);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001B.\u0001(6223));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, false);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u001B.\u0001(5714), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0098\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(11, 373));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001B.\u0001(6232));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(422, 81));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 33);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0090\u0083.\u007E\u001F\u009C((object) componentResourceManager, \u001B.\u0001(6245)));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0002, ContentAlignment.MiddleLeft);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u001B.\u0001(5714), 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0098\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(6, 224));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001B.\u0001(6262));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(99, 15));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 34);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u001B.\u0001(6283));
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0003, ContentAlignment.MiddleLeft);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(439, 373));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0001(6304));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u001B.\u0001(6313));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0001, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u001F\u0005));
      \u0089\u001C.\u007E\u0099\u0087((object) this.\u0002, DialogResult.Cancel);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(439, 402));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u001B.\u0001(6318));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(75, 23));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 6);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u001B.\u0001(6331));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0002, true);
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u007F\u0005));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u009A\u0080.\u008F\u001F());
      \u0099\u001F.\u007E\u0091\u008E((object) this.\u0003, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u001B.\u0001(5714), 9f));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0098\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(14, 242));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u001B.\u0001(6340));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(53, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 0);
      \u0099\u001F.\u007E\u0092\u008E((object) this.\u0003, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u001B.\u0001(6365));
      \u0099\u001F.\u007E\u0097\u0087((object) this.\u0003, false);
      \u0087\u007F.\u007E\u0093\u008E((object) this.\u0003, new EventHandler(this.\u001E\u0005));
      \u0099\u001F.\u007E\u0087\u008C((object) this.\u0001, true);
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, false);
      \u0099\u001F.\u007E\u0089\u008C((object) this.\u0001, true);
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup1, \u001B.\u0001(5844));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup1, \u001B.\u0001(6374));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup2, \u001B.\u0001(5853));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup2, \u001B.\u0001(6387));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup3, \u001B.\u0001(5866));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup3, \u001B.\u0001(6400));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup4, \u001B.\u0001(5879));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup4, \u001B.\u0001(6413));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup5, \u001B.\u0001(5892));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup5, \u001B.\u0001(6426));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup6, \u001B.\u0001(5905));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup6, \u001B.\u0001(6439));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup7, \u001B.\u0001(5918));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup7, \u001B.\u0001(6452));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup8, \u001B.\u0001(5931));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup8, \u001B.\u0001(6452));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup9, \u001B.\u0001(5844));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup9, \u001B.\u0001(6374));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup10, \u001B.\u0001(5853));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup10, \u001B.\u0001(6387));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup11, \u001B.\u0001(5866));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup11, \u001B.\u0001(6400));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup12, \u001B.\u0001(5879));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup12, \u001B.\u0001(6413));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup13, \u001B.\u0001(5892));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup13, \u001B.\u0001(6426));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup14, \u001B.\u0001(5905));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup14, \u001B.\u0001(6439));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup15, \u001B.\u0001(5918));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup15, \u001B.\u0001(6452));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup16, \u001B.\u0001(5931));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup16, \u001B.\u0001(6452));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup17, \u001B.\u0001(5844));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup17, \u001B.\u0001(6374));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup18, \u001B.\u0001(5853));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup18, \u001B.\u0001(6387));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup19, \u001B.\u0001(5866));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup19, \u001B.\u0001(6400));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup20, \u001B.\u0001(5879));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup20, \u001B.\u0001(6413));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup21, \u001B.\u0001(5892));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup21, \u001B.\u0001(6426));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup22, \u001B.\u0001(5905));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup22, \u001B.\u0001(6439));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup23, \u001B.\u0001(5918));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup23, \u001B.\u0001(6452));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup24, \u001B.\u0001(5931));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup24, \u001B.\u0001(6452));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup25, \u001B.\u0001(5844));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup25, \u001B.\u0001(6374));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup26, \u001B.\u0001(5853));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup26, \u001B.\u0001(6387));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup27, \u001B.\u0001(5866));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup27, \u001B.\u0001(6400));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup28, \u001B.\u0001(5879));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup28, \u001B.\u0001(6413));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup29, \u001B.\u0001(5892));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup29, \u001B.\u0001(6426));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup30, \u001B.\u0001(5905));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup30, \u001B.\u0001(6439));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup31, \u001B.\u0001(5918));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup31, \u001B.\u0001(6452));
      \u0092\u0081.\u007E\u0012\u008D((object) listViewGroup32, \u001B.\u0001(5931));
      \u0092\u0081.\u007E\u0013\u008D((object) listViewGroup32, \u001B.\u0001(6452));
      \u0014\u001C.\u007E\u0014\u008D((object) \u001B\u007F.\u007E\u008A\u008C((object) this.\u0001), new ListViewGroup[32]
      {
        listViewGroup1,
        listViewGroup2,
        listViewGroup3,
        listViewGroup4,
        listViewGroup5,
        listViewGroup6,
        listViewGroup7,
        listViewGroup8,
        listViewGroup9,
        listViewGroup10,
        listViewGroup11,
        listViewGroup12,
        listViewGroup13,
        listViewGroup14,
        listViewGroup15,
        listViewGroup16,
        listViewGroup17,
        listViewGroup18,
        listViewGroup19,
        listViewGroup20,
        listViewGroup21,
        listViewGroup22,
        listViewGroup23,
        listViewGroup24,
        listViewGroup25,
        listViewGroup26,
        listViewGroup27,
        listViewGroup28,
        listViewGroup29,
        listViewGroup30,
        listViewGroup31,
        listViewGroup32
      });
      \u0080\u0082.\u007E\u008B\u008C((object) this.\u0001, ColumnHeaderStyle.Nonclickable);
      \u0099\u001F.\u007E\u008C\u008C((object) this.\u0001, false);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(107, 146));
      this.\u0001.MainColumnWidth = 380;
      \u0099\u001F.\u007E\u008F\u008C((object) this.\u0001, false);
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u001B.\u0001(6465));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(407, 221));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      \u0099\u001F.\u007E\u0093\u008C((object) this.\u0001, false);
      \u0017\u0080.\u007E\u0094\u008C((object) this.\u0001, View.Details);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u001B.\u0001(4135), 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(413, 448));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u001B.\u0001(6498));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(105, 12));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 35);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u001B.\u0001(6523));
      \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) this.\u0001);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) this.\u0002);
      \u000E\u001F.\u0010\u008B((object) this, new Size(520, 462));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u001B.\u0001(5257)));
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u001B.\u0001(6560));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u001B.\u0001(6585));
      \u009E\u001C.\u0087\u0084((object) this, new HelpEventHandler(this.\u001D\u0005));
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }

    private void \u001D\u0005(object sender, EventArgs e)
    {
      this.\u0001.\u001E\u0005(\u0005\u0081.\u007E\u0008\u0088((object) this.\u0001));
    }

    private void \u001E\u0005(object sender, EventArgs e)
    {
      \u0099\u001F obj = \u0099\u001F.\u007E\u008F\u0083;
      ComboBox comboBox = this.\u0001;
      bool flag;
      \u0099\u001F.\u007E\u008F\u0083((object) this.\u0001, flag = !\u0099\u0082.\u007E\u0090\u008E((object) this.\u0003));
      int num = flag ? 1 : 0;
      obj((object) comboBox, num != 0);
    }

    private void \u001F\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u007F\u0005(object sender, EventArgs e)
    {
      \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
      \u001A\u001E.\u0092\u008B((object) this);
    }

    private void \u001D\u0005(object sender, HelpEventArgs hlpevent)
    {
      \u0082.\u001D\u0005(\u0002.\u001A);
      \u0099\u001F.\u007E\u0003\u008C((object) hlpevent, true);
    }
  }
}
