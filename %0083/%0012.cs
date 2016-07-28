// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using \u001B;
using \u001C;
using \u001E;
using \u001F;
using \u0081;
using \u0082;
using \u0083;
using \u0084;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Windows.Forms;
using TheToonTownSpoofer.Design;

namespace \u0083
{
  internal sealed class \u0012
  {
    private bool \u0001 = true;
    [NonSerialized]
    internal static \u0002 \u0001;
    private \u001A \u0001;
    private bool \u0002;

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal bool Modified
    {
      get
      {
        return this.\u0002;
      }
      set
      {
        if (this.\u0002 == value)
          return;
        this.\u0002 = value;
        if (this.\u0001 == null)
          return;
        this.\u0001((object) this, new \u000F(this.\u0002));
      }
    }

    [System.ComponentModel.Description("Defines the URL to check for updates and download paths.")]
    [DisplayName("Update URL")]
    public Uri UpdateUri
    {
      get
      {
        return this.\u0001.UpdateUri;
      }
      set
      {
        if (!\u008E\u0081.\u008B\u0002\u0002(this.\u0001.UpdateUri, value))
          return;
        if (!\u008F\u0084.\u009E\u0092(\u0002\u007F.\u007E\u0088\u0002\u0002((object) value)))
        {
          if (!value.\u001D\u0005())
            throw new PropertyException(\u0012.\u0001(101314));
          this.Modified = true;
          this.\u0001.UpdateUri = value;
        }
        else
        {
          this.Modified = true;
          this.\u0001.UpdateUri = value;
        }
      }
    }

    [DisplayName("Name")]
    [Category("Content Pack Properties")]
    [DefaultValue("")]
    [System.ComponentModel.Description("The name of your Content Pack which will be displayed on the Content Pack window.")]
    public string Name
    {
      get
      {
        return this.\u0001.Name;
      }
      set
      {
        if (!\u0008\u001F.\u009B\u0092(this.\u0001.Name, value))
          return;
        if (\u0005\u0081.\u007E\u0001\u0093((object) value) > 32)
          throw new PropertyException(\u0012.\u0001(101492));
        this.Modified = true;
        this.\u0001.Name = value;
      }
    }

    [DefaultValue("")]
    [System.ComponentModel.Description("The author is you!")]
    [Category("Content Pack Properties")]
    [DisplayName("Author")]
    public string Author
    {
      get
      {
        return this.\u0001.Author;
      }
      set
      {
        if (!\u0008\u001F.\u009B\u0092(this.\u0001.Author, value))
          return;
        if (\u0005\u0081.\u007E\u0001\u0093((object) value) > 32)
          throw new PropertyException(\u0012.\u0001(101577));
        this.Modified = true;
        this.\u0001.Author = value;
      }
    }

    [TypeConverter(typeof (\u007F))]
    [System.ComponentModel.Description("The description is displayed on the Content Pack window in Rich Text Format.")]
    [Category("Content Pack Properties")]
    [Editor(typeof (\u000F), typeof (UITypeEditor))]
    [DefaultValue("")]
    [DisplayName("Description")]
    public string Description
    {
      get
      {
        return this.\u0001.Description;
      }
      set
      {
        if (!\u0008\u001F.\u009B\u0092(this.\u0001.Description, value))
          return;
        this.Modified = true;
        this.\u0001.Description = value;
      }
    }

    [Category("Content Pack Properties")]
    [TypeConverter(typeof (\u0011))]
    [System.ComponentModel.Description("The version of the Content Pack. This does not have any relevance on checking for updates and is only used for yours and others reference.")]
    [DisplayName("Version")]
    public Version Version
    {
      get
      {
        return this.\u0001.Version;
      }
      set
      {
        if (!\u009B\u001E.\u0014\u0098(this.\u0001.Version, value))
          return;
        this.Modified = true;
        this.\u0001.Version = value;
      }
    }

    [Category("Content Pack Properties")]
    [DisplayName("Loader Pack")]
    [System.ComponentModel.Description("Determines if the Content Pack will contain no data and instead is simply used to download another Content Pack. We distribute NightLife using this method, users receive a small Content Pack which downloads the full package if users opt-in.")]
    [DefaultValue(false)]
    public bool LoaderPack
    {
      get
      {
        return this.\u0001.LoaderPack;
      }
      set
      {
        if (this.\u0001.LoaderPack == value)
          return;
        if (this.\u0001 && value)
        {
          if (\u0018.\u0017.\u001E\u0005(\u0012.\u0001(101642), \u0012.\u0001(101832), \u0018.\u0016.\u0006, \u0018.\u0016.\u0007) != DialogResult.Yes)
          {
            this.\u0001 = false;
            return;
          }
        }
        this.\u0001 = false;
        this.Modified = true;
        this.\u0001.LoaderPack = value;
      }
    }

    [Category("Content Pack Properties")]
    [DisplayName("Icon")]
    [DefaultValue(typeof (Bitmap), null)]
    [System.ComponentModel.Description("An image that will be displayed on the Content Pack window.")]
    [TypeConverter(typeof (\u007F))]
    public Bitmap Icon
    {
      get
      {
        return this.\u0001.Icon;
      }
      set
      {
        if (this.\u0001.Icon == value)
          return;
        if (value != null)
        {
          try
          {
            MemoryStream memoryStream = new MemoryStream();
            try
            {
              \u0008.\u001D\u0005(value, (Stream) memoryStream, \u009A\u0080.\u0090\u001F(), 100);
              if (\u001F\u001E.\u007E\u0080\u009D((object) memoryStream) > 5242880L)
              {
                if (\u0018.\u0017.\u001E\u0005(\u0012.\u0001(101857), \u0012.\u0001(101934), \u0018.\u0016.\u0006, \u0018.\u0016.\u0007) == DialogResult.No)
                  return;
              }
              \u0012\u0080.\u007E\u0082\u009D((object) memoryStream, 0L);
              this.\u0001.\u001D\u0005((Stream) memoryStream);
            }
            finally
            {
              if (memoryStream != null)
                \u001A\u001E.\u007E\u0094\u0092((object) memoryStream);
            }
          }
          catch (Exception ex)
          {
            ex.\u001D\u0005();
            \u0018.\u0017.\u001E\u0005(\u0012.\u0001(101971), \u0012.\u0001(102012));
          }
          \u001A\u001E.\u007E\u001D\u001F((object) value);
        }
        else
          goto label_14;
label_12:
        this.Modified = true;
        return;
label_14:
        this.\u0001.\u001D\u0005((Stream) null);
        goto label_12;
      }
    }

    [Category("Content Pack Properties")]
    [System.ComponentModel.Description("The minimum version of The ToonTown Spoofer this Content Pack supports.")]
    [DisplayName("Minimum Version")]
    [TypeConverter(typeof (\u0011))]
    public Version MinimumVersion
    {
      get
      {
        return this.\u0001.MinimumVersion;
      }
      set
      {
        if (!\u009B\u001E.\u0014\u0098(this.\u0001.MinimumVersion, value))
          return;
        if (\u009B\u001E.\u0015\u0098(value, new Version(6, 0)))
        {
          \u0018.\u0017.\u001D\u0005(\u0012.\u0001(102025), \u0012.\u0001(102219));
        }
        else
        {
          this.Modified = true;
          this.\u0001.MinimumVersion = value;
        }
      }
    }

    [ReadOnly(true)]
    [System.ComponentModel.Description("The ID is a unique, random Guid.")]
    [DisplayName("ID")]
    [Category("Content Pack Properties")]
    public Guid ID
    {
      get
      {
        return this.\u0001.ID;
      }
    }

    [Category("Content Pack Properties")]
    [DisplayName("Data Hash")]
    [System.ComponentModel.Description("The data hash is an Md5 hash code of the public data structure and is used internally to handle updates.")]
    [ReadOnly(true)]
    [TypeConverter(typeof (\u0017.\u001E))]
    public \u0080.\u0016 DataHash
    {
      get
      {
        return this.\u0001.DataHash;
      }
    }

    [System.ComponentModel.Description("The password does not guarantee no one can access your Content Pack, it is a simple level of protection to prevent average users from opening your Content Pack and making changes.")]
    [Category("Content Pack Properties")]
    [DisplayName("Password")]
    [PasswordPropertyText(true)]
    public string Password
    {
      get
      {
        return this.\u0001.Password;
      }
      set
      {
        \u0012.\u0001 obj1 = new \u0012.\u0001();
        obj1.\u0001 = value;
        if (!\u0008\u001F.\u009B\u0092(this.\u0001.Password, obj1.\u0001))
          return;
        if (\u008F\u0084.\u009E\u0092(obj1.\u0001))
        {
          this.Modified = true;
          this.\u0001.Password = obj1.\u0001;
        }
        else
        {
          \u0008 obj2 = new \u0008();
          try
          {
            \u0092\u0081.\u007E\u001D\u0084((object) obj2, \u0012.\u0001(102264));
            obj2.LabelMessage = \u0012.\u0001(102289);
            obj2.PasswordTextBox = true;
            obj2.InputValidating += new EventHandler<\u0011<string>>(obj1.\u001D\u0005);
            if (\u0097\u001E.\u007E\u0099\u008B((object) obj2) != DialogResult.OK)
              return;
            this.Modified = true;
            this.\u0001.Password = obj1.\u0001;
            if (\u008F\u0084.\u009E\u0092(obj1.\u0001))
              this.\u0001.PasswordHash = \u0080.\u0016.\u0001;
            else
              this.\u0001.PasswordHash = \u0094\u0082.\u007E\u0017\u009C((object) \u001D\u001F.\u001A\u009C(), obj1.\u0001).\u001D\u0005();
          }
          finally
          {
            if (obj2 != null)
              \u001A\u001E.\u007E\u0094\u0092((object) obj2);
          }
        }
      }
    }

    internal event EventHandler<\u000F> ModifiedStateChanged;

    static \u0012()
    {
      \u0004.\u001D\u0005(typeof (\u0012));
    }

    public \u0012(\u001A cp)
    {
      if (cp == null)
        throw new ArgumentNullException(\u0012.\u0001(101309));
      this.\u0001 = cp;
    }
  }
}
