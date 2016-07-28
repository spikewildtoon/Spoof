// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0014;
using \u0015;
using \u001A;
using \u001B;
using \u001E;
using \u001F;
using \u0080;
using \u0081;
using \u0084;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace \u001F
{
  internal sealed class \u0013 : \u0016.\u0014
  {
    [NonSerialized]
    internal new static \u0002 \u0001;
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
    private static readonly string \u0080;
    private static readonly string \u0081;
    private static readonly string \u0082;
    private static readonly string \u0083;
    private \u0082 \u0001;
    private \u001C \u0001;
    private IContainer \u0001;
    private \u001C \u0001;
    private LinkLabel \u0001;
    private LinkLabel \u0002;
    private \u0010 \u0001;
    private LinkLabel \u0003;
    private \u0010 \u0002;
    private Label \u0001;
    private LinkLabel \u0004;
    private PictureBox \u0001;
    private Label \u0002;
    private LinkLabel \u0005;
    private \u0010 \u0003;
    private Label \u0003;
    private \u0010 \u0004;
    private \u0010 \u0005;
    private \u0010 \u0006;
    private LinkLabel \u0006;
    private LinkLabel \u0007;
    private \u0010 \u0007;
    private Label \u0004;
    private LinkLabel \u0008;
    private \u0010 \u0008;
    private LinkLabel \u000E;
    private \u0010 \u000E;
    private LinkLabel \u000F;
    private \u0010 \u000F;
    private \u0010 \u0010;
    private LinkLabel \u0010;
    private LinkLabel \u0011;
    private \u0010 \u0011;
    private \u0010 \u0012;
    private LinkLabel \u0012;
    private Panel \u0001;
    private MenuStrip \u0001;
    private ToolStripMenuItem \u0001;
    private ToolStripMenuItem \u0002;
    private ToolStripMenuItem \u0003;
    private ToolStripSeparator \u0001;
    private ToolStripMenuItem \u0004;
    private ToolStripMenuItem \u0005;
    private ToolStripSeparator \u0002;
    private ToolStripMenuItem \u0006;
    private ToolStripMenuItem \u0007;
    private ToolStripMenuItem \u0008;
    private ToolStripMenuItem \u000E;
    private ToolStripMenuItem \u000F;

    static \u0013()
    {
      \u0004.\u001D\u0005(typeof (\u0013));
      \u0013.\u0001 = \u0013.\u0001(22883);
      \u0013.\u0002 = \u0013.\u0001(70981);
      \u0013.\u0003 = \u0013.\u0001(25631);
      \u0013.\u0004 = \u0013.\u0001(71066);
      \u0013.\u0005 = \u0013.\u0001(70924);
      \u0013.\u0006 = \u0013.\u0001(71123);
      \u0013.\u0007 = \u0013.\u0001(71176);
      \u0013.\u0008 = \u0013.\u0001(71221);
      \u0013.\u000E = \u0013.\u0001(71383);
      \u0013.\u000F = \u0013.\u0001(71424);
      \u0013.\u0010 = \u0013.\u0001(71505);
      \u0013.\u0011 = \u0013.\u0001(71598);
      \u0013.\u0012 = \u0013.\u0001(71675);
      \u0013.\u0013 = \u0013.\u0001(71788);
      \u0013.\u0014 = \u0013.\u0001(71873);
      \u0013.\u0015 = \u0013.\u0001(71954);
      \u0013.\u0016 = \u0013.\u0001(72035);
      \u0013.\u0017 = \u0013.\u0001(72217);
      \u0013.\u0018 = \u0013.\u0001(72266);
      \u0013.\u0019 = \u0013.\u0001(72347);
      \u0013.\u001A = \u0013.\u0001(72428);
      \u0013.\u001B = \u0013.\u0001(72541);
      \u0013.\u001C = \u0013.\u0001(72618);
      \u0013.\u001D = \u0013.\u0001(72703);
      \u0013.\u001E = \u0013.\u0001(72800);
      \u0013.\u001F = \u0013.\u0001(72893);
      \u0013.\u007F = \u0013.\u0001(73099);
      \u0013.\u0080 = \u0013.\u0001(73196);
      \u0013.\u0081 = \u0013.\u0001(73237);
      \u0013.\u0082 = \u0013.\u0001(73338);
      \u0013.\u0083 = \u0013.\u0001(73455);
    }

    public \u0013()
    {
      this.\u0083\u0005();
      this.\u0001 = \u0081.\u0080.Instance.GardenerFloraSettings.GardenerFloraCaptureFiles;
      // ISSUE: method pointer
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0002, new EventHandler((object) this, __methodptr(\u001D\u0005)));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0003, new EventHandler(((\u0014.\u0017) this).\u001E\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0004, new EventHandler(((\u0014.\u0017) this).\u001F\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0005, new EventHandler(((\u0014.\u0017) this).\u007F\u0005));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0006, new EventHandler(((\u0014.\u0017) this).\u0080\u0005));
      this.\u001E\u0005();
    }

    protected override bool \u001D\u0005(out \u0084.\u001B filePath)
    {
      \u0008 obj = new \u0008();
      try
      {
        obj.LabelMessage = \u0013.\u0001;
        \u0092\u0081.\u007E\u001D\u0084((object) obj, \u0013.\u0002);
        if (\u0097\u001E.\u007E\u0099\u008B((object) obj) == DialogResult.OK)
        {
          filePath = new \u0084.\u001B(obj.Value, \u001A.\u0016.\u001E\u0005(\u007F.GardenerFloraCaptureSettingsDirectory, \u0013.\u0001(69736)));
          return true;
        }
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
      filePath = (\u0084.\u001B) null;
      return false;
    }

    protected override void \u001D\u0005(\u0084.\u001B fileName)
    {
      this.\u007F\u0005(fileName);
    }

    protected override bool \u001D\u0005(\u0084.\u001B fileName)
    {
      try
      {
        this.\u0001.\u001D\u0005(fileName.\u0002);
        this.\u007F\u0005(fileName);
        return true;
      }
      catch (Exception ex)
      {
        \u0018.\u0017.\u001D\u0005(ex, fileName.\u0002);
        return false;
      }
    }

    private void \u007F\u0005(\u0084.\u001B fileName)
    {
      if (this.\u0001.Files.Contains(fileName))
        return;
      this.\u0001.Files.Add(fileName);
      \u0081.\u0080.\u001D\u0005();
    }

    protected override bool \u001E\u0005(out \u0084.\u001B fileName)
    {
      \u0084.\u001B selectedFile;
      bool flag = \u007F.\u001E\u0005(out selectedFile);
      fileName = !flag ? (\u0084.\u001B) null : selectedFile;
      return flag;
    }

    protected override bool \u001E\u0005(\u0084.\u001B fileName)
    {
      try
      {
        \u0082 obj = new \u0082(fileName.\u0002);
        if (this.\u0001 != null)
          this.\u0001.Dispose();
        this.\u0001 = obj;
        this.\u0082\u0005();
        return true;
      }
      catch (Exception ex)
      {
        ex.\u001D\u0005((object) \u009E\u0081.\u001F\u0093(\u0013.\u0003, (object) fileName.\u0002));
        \u0018.\u0017.\u001D\u0005(ex, fileName.\u0002);
        return false;
      }
    }

    protected override void \u001D\u0005()
    {
      if (this.\u0001 != null)
        goto label_2;
label_1:
      this.\u0001 = new \u0082();
      this.\u0082\u0005();
      return;
label_2:
      this.\u0001.Dispose();
      goto label_1;
    }

    protected override void \u001D\u0005(\u0084.\u001B fileName, bool modified)
    {
      if (\u0084.\u001B.\u001D\u0005(fileName, (object) null))
      {
        if (modified)
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u0013.\u0004);
        else
          \u0092\u0081.\u007E\u001D\u0084((object) this, \u0013.\u0005);
      }
      else if (modified)
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u009E\u0081.\u001F\u0093(\u0013.\u0006, (object) fileName.\u0001));
      else
        \u0092\u0081.\u007E\u001D\u0084((object) this, \u0081\u0086.\u0086\u0093(\u0013.\u0007, fileName.\u0001));
    }

    private void \u0082\u0005()
    {
      \u0016.\u0014.\u001D\u0005(this.\u0001.PlantFailedCapture, this.\u0004);
      \u0016.\u0014.\u001D\u0005(this.\u0001.FinalPlantCapture, this.\u0001);
      \u0016.\u0014.\u001D\u0005(this.\u0001.NoWaterCapture, this.\u0005);
      \u0016.\u0014.\u001D\u0005(this.\u0001.PickFlowerCapture, this.\u0002);
      \u0016.\u0014.\u001D\u0005(this.\u0001.PlantFlowerCapture, this.\u0006);
      \u0016.\u0014.\u001D\u0005(this.\u0001.PlantSuccessCapture, this.\u0003);
      \u0016.\u0014.\u001D\u0005(this.\u0001.WaterPlantCapture, this.\u0007);
      \u0016.\u0014.\u001D\u0005(this.\u0001.BasketFullCapture, this.\u0008);
      \u0016.\u0014.\u001D\u0005(this.\u0001.SellFlowersCapture, this.\u000E);
      \u0016.\u0014.\u001D\u0005(this.\u0001.DisabledBeanSlotCapture, this.\u000F);
      \u0016.\u0014.\u001D\u0005(this.\u0001.FinalPickCapture, this.\u0010);
      \u0016.\u0014.\u001D\u0005(this.\u0001.CancelPlantCapture, this.\u0011);
      \u0016.\u0014.\u001D\u0005(this.\u0001.NoRemoveCapture, this.\u0012);
    }

    private void \u0081\u0005(object sender, EventArgs e)
    {
      base.\u0001.\u001D\u0005((Form) this, (EventHandler<\u0080.\u0017>) null);
    }

    private void \u0082\u0005(object sender, EventArgs e)
    {
      this.\u0080\u0005();
      \u0082 bmp = (\u0082) null;
      try
      {
        if (!\u0013\u0080.\u0089\u0091(sender, (object) this.\u0006))
        {
          if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0001))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u000F, \u0013.\u0010, this.\u0001.PlantFlowerBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.PlantFlowerCapture != null)
              {
                this.\u0001.PlantFlowerCapture.Dispose();
                this.\u0001.PlantFlowerCapture = (\u0083.\u0018) null;
              }
              this.\u0001.PlantFlowerCapture = new \u0083.\u0018(bmp);
              this.\u0001.PlantFlowerBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0002))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u0011, \u0013.\u0012, this.\u0001.PlantFailedBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.PlantFailedCapture != null)
              {
                this.\u0001.PlantFailedCapture.Dispose();
                this.\u0001.PlantFailedCapture = (\u0083.\u0018) null;
              }
              this.\u0001.PlantFailedCapture = new \u0083.\u0018(bmp);
              this.\u0001.PlantFailedBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0004))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u0011, \u0013.\u0013, this.\u0001.PlantSuccessBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.PlantSuccessCapture != null)
              {
                this.\u0001.PlantSuccessCapture.Dispose();
                this.\u0001.PlantSuccessCapture = (\u0083.\u0018) null;
              }
              this.\u0001.PlantSuccessCapture = new \u0083.\u0018(bmp);
              this.\u0001.PlantSuccessBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0003))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u0014, \u0013.\u0015, this.\u0001.WaterPlantBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.WaterPlantCapture != null)
              {
                this.\u0001.WaterPlantCapture.Dispose();
                this.\u0001.WaterPlantCapture = (\u0083.\u0018) null;
              }
              this.\u0001.WaterPlantCapture = new \u0083.\u0018(bmp);
              this.\u0001.WaterPlantBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0005))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u0016, \u0013.\u0017, this.\u0001.NoWaterBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.NoWaterCapture != null)
              {
                this.\u0001.NoWaterCapture.Dispose();
                this.\u0001.NoWaterCapture = (\u0083.\u0018) null;
              }
              this.\u0001.NoWaterCapture = new \u0083.\u0018(bmp);
              this.\u0001.NoWaterBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0007))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u0018, \u0013.\u0019, this.\u0001.PickFlowerBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.PickFlowerCapture != null)
              {
                this.\u0001.PickFlowerCapture.Dispose();
                this.\u0001.PickFlowerCapture = (\u0083.\u0018) null;
              }
              this.\u0001.PickFlowerCapture = new \u0083.\u0018(bmp);
              this.\u0001.PickFlowerBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0008))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u001A, \u0013.\u001B, this.\u0001.BasketFullBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.BasketFullCapture != null)
              {
                this.\u0001.BasketFullCapture.Dispose();
                this.\u0001.BasketFullCapture = (\u0083.\u0018) null;
              }
              this.\u0001.BasketFullCapture = new \u0083.\u0018(bmp);
              this.\u0001.BasketFullBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u000E))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u001C, \u0013.\u001D, this.\u0001.SellFlowersBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.SellFlowersCapture != null)
              {
                this.\u0001.SellFlowersCapture.Dispose();
                this.\u0001.SellFlowersCapture = (\u0083.\u0018) null;
              }
              this.\u0001.SellFlowersCapture = new \u0083.\u0018(bmp);
              this.\u0001.SellFlowersBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u000F))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u001E, \u0013.\u001F, this.\u0001.DisabledBeanSlotBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.DisabledBeanSlotCapture != null)
              {
                this.\u0001.DisabledBeanSlotCapture.Dispose();
                this.\u0001.DisabledBeanSlotCapture = (\u0083.\u0018) null;
              }
              this.\u0001.DisabledBeanSlotCapture = new \u0083.\u0018(bmp);
              this.\u0001.DisabledBeanSlotBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0010))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u007F, \u0013.\u0080, this.\u0001.FinalPickBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.FinalPickCapture != null)
              {
                this.\u0001.FinalPickCapture.Dispose();
                this.\u0001.FinalPickCapture = (\u0083.\u0018) null;
              }
              this.\u0001.FinalPickCapture = new \u0083.\u0018(bmp);
              this.\u0001.FinalPickBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0011))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u0081, \u0013.\u000E, this.\u0001.CancelPlantBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.CancelPlantCapture != null)
              {
                this.\u0001.CancelPlantCapture.Dispose();
                this.\u0001.CancelPlantCapture = (\u0083.\u0018) null;
              }
              this.\u0001.CancelPlantCapture = new \u0083.\u0018(bmp);
              this.\u0001.CancelPlantBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
          else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0012))
          {
            \u0013 resulting_ratio;
            if (this.\u001D\u0005(\u0013.\u0082, \u0013.\u0083, this.\u0001.NoRemoveBounds, out bmp, out resulting_ratio))
            {
              if (this.\u0001.NoRemoveCapture != null)
              {
                this.\u0001.NoRemoveCapture.Dispose();
                this.\u0001.NoRemoveCapture = (\u0083.\u0018) null;
              }
              this.\u0001.NoRemoveCapture = new \u0083.\u0018(bmp);
              this.\u0001.NoRemoveBounds = resulting_ratio;
              this.FileModified = true;
            }
          }
        }
        else
        {
          \u0013 resulting_ratio;
          if (this.\u001D\u0005(\u0013.\u0008, \u0013.\u000E, this.\u0001.FinalPlantBounds, out bmp, out resulting_ratio))
          {
            if (this.\u0001.FinalPlantCapture != null)
            {
              this.\u0001.FinalPlantCapture.Dispose();
              this.\u0001.FinalPlantCapture = (\u0083.\u0018) null;
            }
            this.\u0001.FinalPlantCapture = new \u0083.\u0018(bmp);
            this.\u0001.FinalPlantBounds = resulting_ratio;
            this.FileModified = true;
          }
        }
      }
      catch
      {
        if (bmp != null)
          bmp.Dispose();
        throw;
      }
      this.\u0082\u0005();
    }

    private void \u0083\u0005(object sender, EventArgs e)
    {
      Control ctr;
      \u0083.\u0018 pix;
      if (!\u0013\u0080.\u0089\u0091(sender, (object) this.\u0001))
      {
        if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0006))
        {
          pix = this.\u0001.FinalPlantCapture;
          ctr = (Control) this.\u0006;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0005))
        {
          pix = this.\u0001.NoWaterCapture;
          ctr = (Control) this.\u0005;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0007))
        {
          pix = this.\u0001.PickFlowerCapture;
          ctr = (Control) this.\u0007;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0004))
        {
          pix = this.\u0001.PlantSuccessCapture;
          ctr = (Control) this.\u0004;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0002))
        {
          pix = this.\u0001.PlantFailedCapture;
          ctr = (Control) this.\u0002;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0003))
        {
          pix = this.\u0001.WaterPlantCapture;
          ctr = (Control) this.\u0003;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0008))
        {
          pix = this.\u0001.BasketFullCapture;
          ctr = (Control) this.\u0008;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u000E))
        {
          pix = this.\u0001.SellFlowersCapture;
          ctr = (Control) this.\u000E;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u000F))
        {
          pix = this.\u0001.DisabledBeanSlotCapture;
          ctr = (Control) this.\u000F;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0010))
        {
          pix = this.\u0001.FinalPickCapture;
          ctr = (Control) this.\u0010;
        }
        else if (\u0013\u0080.\u0089\u0091(sender, (object) this.\u0011))
        {
          pix = this.\u0001.CancelPlantCapture;
          ctr = (Control) this.\u0011;
        }
        else
        {
          if (!\u0013\u0080.\u0089\u0091(sender, (object) this.\u0012))
            return;
          pix = this.\u0001.NoRemoveCapture;
          ctr = (Control) this.\u0012;
        }
      }
      else
        goto label_29;
label_27:
      if (pix == null || ctr == null)
        return;
      this.\u001D\u0005(pix, ctr);
      return;
label_29:
      pix = this.\u0001.PlantFlowerCapture;
      ctr = (Control) this.\u0001;
      goto label_27;
    }

    private void \u0084\u0005(object sender, EventArgs e)
    {
      this.\u0080\u0005();
    }

    private void \u0086\u0005(object sender, EventArgs e)
    {
      \u0082.\u001D\u0005(\u0002.\u001B);
    }

    protected override void Dispose(bool disposing)
    {
      if (this.\u0001 != null)
        this.\u0001.Dispose();
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u0083\u0005()
    {
      // ISSUE: type reference
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0013)));
      this.\u0001 = new \u001C();
      this.\u0001 = new LinkLabel();
      this.\u0002 = new LinkLabel();
      this.\u0010 = new \u0010();
      this.\u0012 = new \u0010();
      this.\u0001 = new \u0010();
      this.\u0003 = new LinkLabel();
      this.\u0002 = new \u0010();
      this.\u0001 = new Label();
      this.\u0004 = new LinkLabel();
      this.\u0001 = new PictureBox();
      this.\u0002 = new Label();
      this.\u0011 = new LinkLabel();
      this.\u000F = new LinkLabel();
      this.\u000E = new LinkLabel();
      this.\u0008 = new LinkLabel();
      this.\u0005 = new LinkLabel();
      this.\u0011 = new \u0010();
      this.\u0003 = new \u0010();
      this.\u000F = new \u0010();
      this.\u0003 = new Label();
      this.\u000E = new \u0010();
      this.\u0008 = new \u0010();
      this.\u0004 = new \u0010();
      this.\u0005 = new \u0010();
      this.\u0006 = new \u0010();
      this.\u0012 = new LinkLabel();
      this.\u0010 = new LinkLabel();
      this.\u0006 = new LinkLabel();
      this.\u0007 = new LinkLabel();
      this.\u0007 = new \u0010();
      this.\u0004 = new Label();
      this.\u0001 = new Panel();
      this.\u0001 = new MenuStrip();
      this.\u0001 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripMenuItem();
      this.\u0003 = new ToolStripMenuItem();
      this.\u0001 = new ToolStripSeparator();
      this.\u0004 = new ToolStripMenuItem();
      this.\u0005 = new ToolStripMenuItem();
      this.\u0002 = new ToolStripSeparator();
      this.\u0006 = new ToolStripMenuItem();
      this.\u0007 = new ToolStripMenuItem();
      this.\u0008 = new ToolStripMenuItem();
      this.\u000E = new ToolStripMenuItem();
      this.\u000F = new ToolStripMenuItem();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0099\u0001\u0002((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      this.\u0001.CenterColor = \u008E\u001D.\u0017\u007F(224, 224, 224);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0010);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0012);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0002);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0011);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0011);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000F);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0003);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u000E);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0008);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0005);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0012);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0010);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0006);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0007);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0004);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      this.\u0001.HeaderHeight = 30;
      this.\u0001.ImageBounds = new Rectangle(0, 0, 0, 0);
      this.\u0001.ImageLocation = new Point(0, 0);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0013.\u0001(19196));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(468, 358));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 32);
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0001, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0001, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(55, 236));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0013.\u0001(69745));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(136, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 40);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0001, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0013.\u0001(69762));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0001, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0001, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0001, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0002, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0002, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(55, 215));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0013.\u0001(69791));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(132, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 36);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0002, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0013.\u0001(69816));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0002, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0002, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0002, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0010, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0010, new Point(24, 131));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0010, \u0013.\u0001(69845));
      this.\u0010.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0010, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0010, 27);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0010, \u0013.\u0001(19266));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0012, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0012, new Point(24, 173));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0012, \u0013.\u0001(69874));
      this.\u0012.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0012, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0012, 27);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0012, \u0013.\u0001(19266));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(24, 152));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0013.\u0001(69903));
      this.\u0001.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 27);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0013.\u0001(19266));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0003, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0003, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0003, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0003, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(55, 320));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0013.\u0001(69932));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(132, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 35);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0003, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0013.\u0001(69949));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0003, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0003, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0003, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(24, 278));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0013.\u0001(69974));
      this.\u0002.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 30);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0013.\u0001(19266));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, new Font(\u0013.\u0001(10865), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0001, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(55, 46));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0013.\u0001(19703));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(60, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 44);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0013.\u0001(19720));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0004, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0004, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(55, 257));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0013.\u0001(70003));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(144, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 39);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0004, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0013.\u0001(70028));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0004, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0004, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0004, new EventHandler(this.\u0083\u0005));
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Bottom | AnchorStyles.Right);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0001, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0087\u0081.\u007E\u001E\u008E((object) this.\u0001, (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0013.\u0001(19783)));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(397, 288));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0013.\u0001(19808));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(64, 64));
      \u0019\u0080.\u007E\u001F\u008E((object) this.\u0001, PictureBoxSizeMode.AutoSize);
      \u0011\u001F.\u007E\u0080\u008E((object) this.\u0001, 46);
      \u0099\u001F.\u007E\u007F\u008E((object) this.\u0001, false);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0002, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0002, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0002, new Font(\u0013.\u0001(10865), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0002, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0002, new Point(13, 46));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0002, \u0013.\u0001(19895));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0002, new Size(42, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0002, 45);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0002, \u0013.\u0001(19912));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0011, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0011, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0011, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0011, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0011, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0011, new Point(55, 89));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0011, \u0013.\u0001(70057));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0011, new Size(137, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0011, 43);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0011, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, \u0013.\u0001(70082));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0011, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0011, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0011, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u000F, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000F, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000F, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000F, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u000F, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(55, 110));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u0013.\u0001(70111));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(131, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 43);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u000F, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u0013.\u0001(70136));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u000F, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u000F, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u000F, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u000E, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u000E, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000E, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u000E, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u000E, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(55, 299));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u0013.\u0001(70161));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(133, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 43);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u000E, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u0013.\u0001(70186));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u000E, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u000E, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u000E, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0008, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0008, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0008, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0008, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0008, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(55, 68));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0013.\u0001(70215));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(126, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 43);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0008, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u0013.\u0001(70240));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0008, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0008, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0008, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0005, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0005, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0005, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0005, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(55, 194));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0013.\u0001(70265));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(117, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 43);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0005, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0013.\u0001(70286));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0005, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0005, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0005, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0011, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0011, new Point(24, 89));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0011, \u0013.\u0001(70307));
      this.\u0011.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0011, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0011, 29);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0011, \u0013.\u0001(19266));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(24, 257));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0013.\u0001(70340));
      this.\u0003.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 21);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0013.\u0001(19266));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000F, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000F, new Point(24, 110));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000F, \u0013.\u0001(70373));
      this.\u000F.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000F, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000F, 29);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000F, \u0013.\u0001(19266));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0003, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0003, \u009A\u0080.\u0095\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0003, new Point(214, 72));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0003, \u0013.\u0001(20025));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0003, new Size(238, 163));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0003, 33);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0003, \u0090\u0083.\u007E\u001F\u009C((object) componentResourceManager, \u0013.\u0001(20046)));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u000E, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u000E, new Point(24, 299));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u000E, \u0013.\u0001(70402));
      this.\u000E.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u000E, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u000E, 29);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u000E, \u0013.\u0001(19266));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0008, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0008, new Point(24, 68));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0008, \u0013.\u0001(70435));
      this.\u0008.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0008, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0008, 29);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0008, \u0013.\u0001(19266));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(24, 215));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0013.\u0001(70464));
      this.\u0004.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 26);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0013.\u0001(19266));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0005, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0005, new Point(24, 194));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0005, \u0013.\u0001(70497));
      this.\u0005.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0005, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0005, 29);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0005, \u0013.\u0001(19266));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(24, 236));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0013.\u0001(70522));
      this.\u0006.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 25);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u0013.\u0001(19266));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0012, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0012, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0012, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0012, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0012, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0012, new Point(55, 173));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0012, \u0013.\u0001(70555));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0012, new Size(130, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0012, 42);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0012, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0012, \u0013.\u0001(70576));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0012, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0012, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0012, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0010, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0010, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0010, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0010, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0010, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0010, new Point(55, 131));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0010, \u0013.\u0001(70601));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0010, new Size(117, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0010, 42);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0010, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0010, \u0013.\u0001(70622));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0010, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0010, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0010, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0006, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0006, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0006, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0006, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0006, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0006, new Point(55, 152));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0006, \u0013.\u0001(70647));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0006, new Size(124, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0006, 42);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0006, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0006, \u0013.\u0001(70672));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0006, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0006, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0006, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001F\u008C((object) this.\u0007, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0007, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0007, new Font(\u0013.\u0001(10865), 12f));
      \u0081\u0082.\u007E\u007F\u008C((object) this.\u0007, \u008E\u001D.\u0017\u007F(51, 153, (int) byte.MaxValue));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(55, 278));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0013.\u0001(70697));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(129, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 41);
      \u0099\u001F.\u007E\u0080\u008C((object) this.\u0007, true);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u0013.\u0001(70722));
      \u0087\u007F.\u007E\u0086\u0084((object) this.\u0007, new EventHandler(this.\u0082\u0005));
      \u0087\u007F.\u007E\u0094\u0084((object) this.\u0007, new EventHandler(this.\u0084\u0005));
      \u0087\u007F.\u007E\u0095\u0084((object) this.\u0007, new EventHandler(this.\u0083\u0005));
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0007, \u008E\u001D.\u0017\u007F(224, 224, 224));
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0007, new Point(24, 320));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0007, \u0013.\u0001(70747));
      this.\u0007.On = true;
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0007, new Size(19, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0007, 24);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0007, \u0013.\u0001(19266));
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0004, true);
      \u0081\u0082.\u007E\u001D\u0083((object) this.\u0004, \u009A\u0080.\u008F\u001F());
      \u0094\u0083.\u007E\u0093\u0083((object) this.\u0004, new Font(\u0013.\u0001(10865), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204));
      \u0081\u0082.\u007E\u0095\u0083((object) this.\u0004, \u009A\u0080.\u0098\u001F());
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0004, new Point(10, 8));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0004, \u0013.\u0001(20319));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0004, new Size(221, 19));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0004, 32);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0004, \u0013.\u0001(70776));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0097\u0081.\u007E\u008C\u0083((object) this.\u0001, DockStyle.Fill);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 24));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0013.\u0001(70817));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(468, 358));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 34);
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u000E\u0087((object) this.\u0001), new ToolStripItem[3]
      {
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0007,
        (ToolStripItem) this.\u000E
      });
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0013.\u0001(70846));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(468, 24));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 35);
      \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, \u0013.\u0001(8477));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0001), new ToolStripItem[7]
      {
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0003,
        (ToolStripItem) this.\u0001,
        (ToolStripItem) this.\u0004,
        (ToolStripItem) this.\u0005,
        (ToolStripItem) this.\u0002,
        (ToolStripItem) this.\u0006
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0013.\u0001(20455));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(37, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0001, \u0013.\u0001(8507));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0013.\u0001(20468));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0002, Keys.N | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0002, \u0013.\u0001(8525));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0003, \u0013.\u0001(20489));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0003, Keys.O | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0003, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0003, \u0013.\u0001(8547));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0001, \u0013.\u0001(8556));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0001, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0004, \u0013.\u0001(20514));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0004, Keys.S | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0004, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0004, \u0013.\u0001(8598));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0005, \u0013.\u0001(20539));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0005, Keys.S | Keys.Shift | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0005, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0005, \u0013.\u0001(8628));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0002, \u0013.\u0001(8645));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0002, new Size(189, 6));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0006, \u0013.\u0001(20564));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u0006, Keys.W | Keys.Control);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0006, new Size(192, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0006, \u0013.\u0001(8691));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u0007), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u0008
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0007, \u0013.\u0001(20589));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0007, new Size(63, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0007, \u0013.\u0001(20606));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u0008, \u0013.\u0001(20619));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u0008, new Size(213, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u0008, \u0013.\u0001(20648));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u0008, new EventHandler(this.\u0081\u0005));
      \u008F\u001D.\u007E\u008D\u0090((object) \u0086\u0084.\u007E\u008A\u008D((object) this.\u000E), new ToolStripItem[1]
      {
        (ToolStripItem) this.\u000F
      });
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000E, \u0013.\u0001(8826));
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000E, new Size(44, 20));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000E, \u0013.\u0001(8843));
      \u0092\u0081.\u007E\u001C\u0087((object) this.\u000F, \u0013.\u0001(20681));
      \u0013\u001D.\u007E\u008F\u008D((object) this.\u000F, Keys.F1);
      \u000E\u001F.\u007E\u001E\u0087((object) this.\u000F, new Size(124, 22));
      \u0092\u0081.\u007E\u007F\u0087((object) this.\u000F, \u0013.\u0001(8873));
      \u0087\u007F.\u007E\u0015\u0087((object) this.\u000F, new EventHandler(this.\u0086\u0005));
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u0081\u0082.\u007E\u001D\u0083((object) this, \u008E\u001D.\u0017\u007F(218, 228, 246));
      \u000E\u001F.\u0010\u008B((object) this, new Size(468, 382));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u001A\u001D.\u0019\u008B((object) this, this.\u0001);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u000E\u001F.\u007E\u0005\u0084((object) this, new Size(474, 410));
      \u000E\u001F.\u007E\u0007\u0084((object) this, new Size(474, 410));
      \u0092\u0081.\u0010\u0084((object) this, \u0013.\u0001(70887));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0013.\u0001(70924));
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u001A\u001E.\u007E\u009A\u0001\u0002((object) this.\u0001);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
      \u001A\u001E.\u0019\u0086((object) this);
    }
  }
}
