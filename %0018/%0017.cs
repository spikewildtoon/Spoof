// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0018;
using \u0019;
using \u001B;
using \u001F;
using \u0082;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using TSN.Drawing;
using TSN.IO;

namespace \u0018
{
  internal sealed class \u0017 : \u0014.\u0019
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
    private IContainer \u0001;
    private Panel \u0001;
    private FlowLayoutPanel \u0001;
    private Label \u0001;
    private \u0015 \u0001;

    static \u0017()
    {
      \u0004.\u001D\u0005(typeof (\u0017));
      \u0017.\u0001 = \u0017.\u0001(34915);
      \u0017.\u0002 = \u0017.\u0001(34984);
      \u0017.\u0003 = \u0017.\u0001(35033);
      \u0017.\u0004 = \u0017.\u0001(35054);
      \u0017.\u0005 = \u0017.\u0001(35091);
      \u0017.\u0006 = \u0017.\u0001(35112);
      \u0017.\u0007 = \u0017.\u0001(35165);
      \u0017.\u0008 = \u0017.\u0001(35194);
      \u0017.\u000E = \u0017.\u0001(35235);
      \u0017.\u000F = \u0017.\u0001(35248);
      \u0017.\u0010 = \u0017.\u0001(35313);
      \u0017.\u0011 = \u0017.\u0001(35342);
      \u0017.\u0012 = \u0017.\u0001(35407);
      \u0017.\u0013 = \u0017.\u0001(35428);
      \u0017.\u0014 = \u0017.\u0001(35489);
      \u0017.\u0015 = \u0017.\u0001(35510);
      \u0017.\u0016 = \u0017.\u0001(35575);
      \u0017.\u0017 = \u0017.\u0001(35604);
      \u0017.\u0018 = \u0017.\u0001(35653);
      \u0017.\u0019 = \u0017.\u0001(35662);
      \u0017.\u001A = \u0017.\u0001(35723);
      \u0017.\u001B = \u0017.\u0001(35748);
      \u0017.\u001C = \u0017.\u0001(9045);
    }

    public \u0017(string message, string title, \u001D dialogType, Font font, bool enabledCloseButton, \u0012 position, params \u0016[] buttons)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      \u0017.\u0001 obj1 = new \u0017.\u0001();
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = dialogType;
      // ISSUE: explicit constructor call
      base.\u002Ector(enabledCloseButton);
      // ISSUE: reference to a compiler-generated field
      obj1.\u0001 = this;
      switch (message)
      {
        case null:
          throw new ArgumentNullException(\u0017.\u0001(34501));
        default:
          switch (title)
          {
            case null:
              throw new ArgumentNullException(\u0017.\u0001(34514));
            default:
              if (buttons == null)
                throw new ArgumentNullException(\u0017.\u0001(34523));
              if (buttons.Length == 0)
                throw new ArgumentException(\u0017.\u0001(34536));
              // ISSUE: reference to a compiler-generated field
              obj1.\u0001.\u001D\u0005();
              position.\u001D\u0005();
              for (int index = 0; index < buttons.Length; ++index)
                buttons[index].\u001D\u0005();
              this.\u001E\u0005();
              \u0092\u0081.\u007E\u001D\u0084((object) this, title);
              \u0092\u0081.\u007E\u001D\u0084((object) this.\u0001, message);
              if (font != null)
                \u0094\u0083.\u007E\u0093\u0083((object) this.\u0001, font);
              Rectangle rectangle = \u0097\u007F.\u0018\u008F(\u0098\u0080.\u009F\u0089());
              this.\u0001.StaticImage = true;
              this.\u0001.AnimationInterval = 25;
              // ISSUE: type reference
              ComponentResourceManager componentResourceManager = new ComponentResourceManager(\u009C\u0082.\u0016\u0097(__typeref (\u0017)));
              // ISSUE: reference to a compiler-generated field
              switch (obj1.\u0001)
              {
                case \u001D.\u0001:
                  this.\u0001.BaseImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u0001(34593));
                  \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u0001(34626)));
                  break;
                case \u001D.\u0002:
                  this.\u0001.BaseImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u0001(34655));
                  \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u0001(34684)));
                  break;
                case \u001D.\u0003:
                  this.\u0001.BaseImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u0001(34709));
                  \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u0001(34738)));
                  break;
                case \u001D.\u0004:
                  this.\u0001.BaseImage = (Image) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u0001(34763));
                  \u0080\u0086.\u0016\u008B((object) this, (Icon) \u0093\u0083.\u007E\u007F\u009C((object) componentResourceManager, \u0017.\u0001(34788)));
                  break;
              }
              this.\u0001.\u001D\u0005();
              Button button1 = (Button) null;
              \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
              Button button2 = (Button) null;
              Button button3 = (Button) null;
              for (int index = 0; index < buttons.Length; ++index)
              {
                \u0016 obj2 = buttons[index];
                try
                {
                  button1 = new Button();
                  \u008C\u001C.\u007E\u0019\u0083((object) button1, AnchorStyles.Bottom | AnchorStyles.Right);
                  \u0096\u0086.\u007E\u009F\u0083((object) button1, new Point(0, 0));
                  button1.Margin = new Padding(0, 0, index < buttons.Length - 1 ? 3 : 0, 0);
                  \u0099\u001F.\u007E\u0097\u0087((object) button1, true);
                  \u000E\u001F.\u007E\u0018\u0084((object) button1, new Size(75, 23));
                  \u0011\u001F.\u007E\u001A\u0084((object) button1, index);
                  switch (obj2)
                  {
                    case \u0016.\u0001:
                      if (button2 == null)
                        button2 = button1;
                      \u0092\u0081.\u007E\u001D\u0084((object) button1, \u0017.\u0001(16430));
                      button1.Click += (EventHandler) ((sender, e) =>
                      {
                        \u0089\u001C.\u0015\u008B((object) this, DialogResult.OK);
                        \u001A\u001E.\u0092\u008B((object) this);
                      });
                      break;
                    case \u0016.\u0002:
                      if (button3 == null)
                        button3 = button1;
                      \u0092\u0081.\u007E\u001D\u0084((object) button1, \u0017.\u0001(7680));
                      button1.Click += (EventHandler) ((sender, e) =>
                      {
                        \u0089\u001C.\u0015\u008B((object) this, DialogResult.Cancel);
                        \u001A\u001E.\u0092\u008B((object) this);
                      });
                      break;
                    case \u0016.\u0003:
                      if (button3 == null)
                        button3 = button1;
                      \u0092\u0081.\u007E\u001D\u0084((object) button1, \u0017.\u0001(34809));
                      button1.Click += (EventHandler) ((sender, e) =>
                      {
                        \u0089\u001C.\u0015\u008B((object) this, DialogResult.Abort);
                        \u001A\u001E.\u0092\u008B((object) this);
                      });
                      break;
                    case \u0016.\u0004:
                      \u0092\u0081.\u007E\u001D\u0084((object) button1, \u0017.\u0001(34832));
                      button1.Click += (EventHandler) ((sender, e) =>
                      {
                        \u0089\u001C.\u0015\u008B((object) this, DialogResult.Retry);
                        \u001A\u001E.\u0092\u008B((object) this);
                      });
                      break;
                    case \u0016.\u0005:
                      \u0092\u0081.\u007E\u001D\u0084((object) button1, \u0017.\u0001(34818));
                      button1.Click += (EventHandler) ((sender, e) =>
                      {
                        \u0089\u001C.\u0015\u008B((object) this, DialogResult.Ignore);
                        \u001A\u001E.\u0092\u008B((object) this);
                      });
                      break;
                    case \u0016.\u0006:
                      if (button2 == null)
                        button2 = button1;
                      \u0092\u0081.\u007E\u001D\u0084((object) button1, \u0017.\u0001(34841));
                      button1.Click += (EventHandler) ((sender, e) =>
                      {
                        \u0089\u001C.\u0015\u008B((object) this, DialogResult.Yes);
                        \u001A\u001E.\u0092\u008B((object) this);
                      });
                      break;
                    case \u0016.\u0007:
                      \u0092\u0081.\u007E\u001D\u0084((object) button1, \u0017.\u0001(34827));
                      button1.Click += (EventHandler) ((sender, e) =>
                      {
                        \u0089\u001C.\u0015\u008B((object) this, DialogResult.No);
                        \u001A\u001E.\u0092\u008B((object) this);
                      });
                      break;
                  }
                  \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) button1);
                }
                catch
                {
                  if (button1 != null)
                    \u001A\u001E.\u007E\u007F\u0001\u0002((object) button1);
                  throw;
                }
              }
              \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, true);
              if (button2 != null)
                \u000E\u001D.\u0006\u008B((object) this, (IButtonControl) button2);
              if (button3 != null)
                \u000E\u001D.\u000E\u008B((object) this, (IButtonControl) button3);
              int num1 = 12;
              int num2 = 6;
              int num3 = \u008F\u0080.\u001C\u008F().Width * 2;
              int num4 = \u008F\u0080.\u001C\u008F().Height * 2;
              int num5 = num1 * 2 + \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001) + num2 + \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001) + num4 + \u0006\u0083.\u001B\u008F();
              int num6 = num1 * 2 + \u0005\u0081.\u007E\u0083\u0084((object) this.\u0001) + num2 + \u0005\u0081.\u007E\u0083\u0084((object) this.\u0001) + num3;
              int width = (int) ((double) (rectangle.Width - num3 - \u0005\u0081.\u007E\u0083\u0084((object) this.\u0001) - num2 - num1 * 2) * 0.6);
              int height = (int) ((double) (rectangle.Height - num4 - \u0006\u0083.\u001B\u008F() - \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001) - num2 - num1 * 2) * 0.9);
              Size size = \u009A\u0082.\u007E\u0096\u0083((object) this.\u0001, new Size(width, height));
              \u000E\u001F.\u0082\u008B((object) this, new Size(\u0099\u0081.\u009E\u0096(num6, num3 + num1 * 2 + \u0005\u0081.\u007E\u0083\u0084((object) this.\u0001) + num2 + size.Width), \u0099\u0081.\u009E\u0096(num5, \u0099\u0081.\u009F\u0096(num4 + \u0006\u0083.\u001B\u008F() + num2 + num1 * 2 + \u0005\u0081.\u007E\u0098\u0083((object) this.\u0001) + size.Height, height))));
              \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(\u0005\u0081.\u007E\u0083\u0084((object) this.\u0001) / 2 - \u0005\u0081.\u007E\u0083\u0084((object) this.\u0001) / 2, \u008E\u0084.\u007E\u009E\u0083((object) this.\u0001).Y));
              // ISSUE: reference to a compiler-generated method
              this.Load += new EventHandler(obj1.\u001D\u0005);
              switch (position)
              {
                case \u0012.\u0001:
                  \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
                  return;
                case \u0012.\u0002:
                  \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.Manual);
                  \u0096\u0086.\u0018\u008B((object) this, new Point(rectangle.Width / 2 - \u0005\u0081.\u0083\u0084((object) this) / 2 + rectangle.X, rectangle.Height - \u0005\u0081.\u0098\u0083((object) this) + rectangle.Y - (int) ((double) rectangle.Height * 0.05)));
                  return;
                case \u0012.\u0003:
                  \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterParent);
                  return;
                default:
                  return;
              }
          }
      }
    }

    public static void \u001D\u0005(string text, string caption, \u0012 position)
    {
      int num = (int) \u0017.\u001D\u0005(text, caption, \u001D.\u0001, true, position, new \u0016[1]);
    }

    public static void \u001D\u0005(string text, string caption)
    {
      int num = (int) \u0017.\u001D\u0005(text, caption, \u001D.\u0001, new \u0016[1]);
    }

    public static void \u001E\u0005(string text, string caption)
    {
      int num = (int) \u0017.\u001D\u0005(text, caption, \u001D.\u0004, new \u0016[1]);
    }

    public static DialogResult \u001D\u0005(string text, string caption, params \u0016[] buttons)
    {
      return \u0017.\u001D\u0005(text, caption, \u001D.\u0004, buttons);
    }

    public static DialogResult \u001E\u0005(string text, string caption, params \u0016[] buttons)
    {
      return \u0017.\u001D\u0005(text, caption, \u001D.\u0002, true, buttons);
    }

    public static void \u001D\u0005(Exception ex, string path)
    {
      switch (path)
      {
        case null:
          path = string.Empty;
          break;
      }
      System.Type type = \u009C\u0083.\u007E\u0093\u0091((object) ex);
      // ISSUE: type reference
      if (\u0091\u001F.\u001A\u0097(type, \u009C\u0082.\u0016\u0097(__typeref (InvalidFileType))))
      {
        \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0019, new object[1]{ (object) path }), \u0017.\u001A);
      }
      else
      {
        // ISSUE: type reference
        if (\u0091\u001F.\u001A\u0097(type, \u009C\u0082.\u0016\u0097(__typeref (ArgumentNullException))))
        {
          \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0015, new object[1]
          {
            (object) \u0002\u007F.\u007E\u0090\u0091((object) ex)
          }), \u0017.\u0016);
        }
        else
        {
          // ISSUE: type reference
          if (\u0091\u001F.\u001A\u0097(type, \u009C\u0082.\u0016\u0097(__typeref (ArgumentException))))
          {
            \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0013, new object[1]
            {
              (object) \u0002\u007F.\u007E\u0090\u0091((object) ex)
            }), \u0017.\u0014);
          }
          else
          {
            // ISSUE: type reference
            if (\u0091\u001F.\u001A\u0097(type, \u009C\u0082.\u0016\u0097(__typeref (WebException))))
            {
              \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0001(34366), new object[2]
              {
                (object) path,
                (object) \u0002\u007F.\u007E\u0090\u0091((object) ex)
              }), \u0017.\u0001(34447));
            }
            else
            {
              // ISSUE: type reference
              if (\u0091\u001F.\u001A\u0097(type, \u009C\u0082.\u0016\u0097(__typeref (PathTooLongException))))
              {
                \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0004, new object[1]{ (object) path }), \u0017.\u0005);
              }
              else
              {
                // ISSUE: type reference
                if (\u0091\u001F.\u001A\u0097(type, \u009C\u0082.\u0016\u0097(__typeref (DirectoryNotFoundException))))
                {
                  \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0006, new object[1]
                  {
                    (object) \u009C\u0080.\u0005\u009F(path)
                  }), \u0017.\u0007);
                }
                else
                {
                  // ISSUE: type reference
                  if (\u0091\u001F.\u001A\u0097(type, \u009C\u0082.\u0016\u0097(__typeref (IOException))))
                  {
                    \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0008, new object[1]
                    {
                      (object) \u0002\u007F.\u007E\u0090\u0091((object) ex)
                    }), \u0017.\u000E);
                  }
                  else
                  {
                    // ISSUE: type reference
                    if (\u0091\u001F.\u001A\u0097(type, \u009C\u0082.\u0016\u0097(__typeref (NotSupportedException))))
                    {
                      \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u000F, new object[1]
                      {
                        (object) \u0002\u007F.\u007E\u0090\u0091((object) ex)
                      }), \u0017.\u0010);
                    }
                    else
                    {
                      // ISSUE: type reference
                      if (\u0091\u001F.\u001A\u0097(type, \u009C\u0082.\u0016\u0097(__typeref (UnauthorizedAccessException))))
                      {
                        \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0011, new object[1]
                        {
                          (object) \u0002\u007F.\u007E\u0090\u0091((object) ex)
                        }), \u0017.\u0012);
                      }
                      else
                      {
                        // ISSUE: type reference
                        if (\u0091\u001F.\u001A\u0097(type, \u009C\u0082.\u0016\u0097(__typeref (FileNotFoundException))))
                        {
                          \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0002, new object[1]{ (object) path }), \u0017.\u0003);
                        }
                        else
                        {
                          // ISSUE: type reference
                          if (\u0091\u001F.\u001A\u0097(type, \u009C\u0082.\u0016\u0097(__typeref (InvalidPixelFormatException))))
                          {
                            InvalidPixelFormatException pixelFormatException = ex as InvalidPixelFormatException;
                            \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0001, new object[2]
                            {
                              (object) \u009C\u0080.\u0008\u009F(path),
                              (object) pixelFormatException.PixelFormat.\u001D\u0005()
                            }), \u0017.\u0001(34472));
                          }
                          else
                            \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u0017, new object[1]
                            {
                              (object) \u0002\u007F.\u007E\u0090\u0091((object) ex)
                            }), \u0017.\u0018);
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }

    public static DialogResult \u001D\u0005(string title)
    {
      return \u0017.\u001E\u0005(\u0008\u0082.\u0082\u0093((IFormatProvider) \u0013.\u0001, \u0017.\u001B, new object[1]{ (object) title }), \u0017.\u001C, \u0016.\u0006, \u0016.\u0007);
    }

    public static DialogResult \u001D\u0005(string message, string title, \u001D dialogType)
    {
      return \u0017.\u001D\u0005(message, title, dialogType, true, \u0012.\u0001, new \u0016[1]);
    }

    public static DialogResult \u001D\u0005(string message, string title, \u001D dialogType, bool enabledCloseButton)
    {
      return \u0017.\u001D\u0005(message, title, dialogType, enabledCloseButton, \u0012.\u0001, new \u0016[1]);
    }

    public static DialogResult \u001D\u0005(string message, string title, \u001D dialogType, params \u0016[] buttons)
    {
      return \u0017.\u001D\u0005(message, title, dialogType, true, \u0012.\u0001, buttons);
    }

    public static DialogResult \u001D\u0005(string message, string title, \u001D dialogType, bool enabledCloseButton, params \u0016[] buttons)
    {
      return \u0017.\u001D\u0005(message, title, dialogType, enabledCloseButton, \u0012.\u0001, buttons);
    }

    public static DialogResult \u001D\u0005(string message, string title, \u001D dialogType, bool enabledCloseButton, \u0012 position, params \u0016[] buttons)
    {
      \u0017 obj = new \u0017(message, title, dialogType, (Font) null, enabledCloseButton, position, buttons);
      try
      {
        return \u0097\u001E.\u007E\u0099\u008B((object) obj);
      }
      finally
      {
        if (obj != null)
          \u001A\u001E.\u007E\u0094\u0092((object) obj);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.\u0001 != null)
        \u001A\u001E.\u007E\u0094\u0092((object) this.\u0001);
      base.Dispose(disposing);
    }

    private void \u001E\u0005()
    {
      this.\u0001 = new Panel();
      this.\u0001 = new FlowLayoutPanel();
      this.\u0001 = new Label();
      this.\u0001 = new \u0015();
      \u001A\u001E.\u007E\u0084\u0086((object) this.\u0001);
      \u001A\u001E.\u0084\u0086((object) this);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u007E\u0087\u0083((object) this.\u0001), (Control) this.\u0001);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(12, 12));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0001, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0017.\u0001(34846));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(134, 93));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 0);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Bottom | AnchorStyles.Left);
      \u0099\u001F.\u007E\u001B\u0083((object) this.\u0001, true);
      \u009D\u001C.\u007E\u009B\u008A((object) this.\u0001, AutoSizeMode.GrowAndShrink);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 93));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0001, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0017.\u0001(34859));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(0, 0));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 6);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
      \u0099\u001F.\u007E\u0019\u008C((object) this.\u0001, true);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(0, 0));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0001, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0017.\u0001(34876));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(96, 64));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 5);
      \u0016\u001E.\u007E\u001B\u008C((object) this.\u0001, ContentAlignment.MiddleCenter);
      \u008C\u001C.\u007E\u0019\u0083((object) this.\u0001, AnchorStyles.Top | AnchorStyles.Right);
      \u0096\u0086.\u007E\u009F\u0083((object) this.\u0001, new Point(102, 0));
      \u0001\u001F.\u007E\u0003\u0084((object) this.\u0001, new Padding(0));
      \u0092\u0081.\u007E\u0010\u0084((object) this.\u0001, \u0017.\u0001(34889));
      \u000E\u001F.\u007E\u0018\u0084((object) this.\u0001, new Size(32, 32));
      \u0011\u001F.\u007E\u001A\u0084((object) this.\u0001, 4);
      \u0099\u001F.\u007E\u001B\u0084((object) this.\u0001, false);
      \u0012\u0083.\u0097\u0086((object) this, new SizeF(6f, 13f));
      \u0013\u001E.\u0098\u0086((object) this, AutoScaleMode.Font);
      \u000E\u001F.\u0010\u008B((object) this, new Size(158, 117));
      \u009B\u0081.\u007E\u008E\u0086((object) \u0096\u001D.\u0087\u0083((object) this), (Control) this.\u0001);
      \u0007\u001F.\u0008\u008B((object) this, FormBorderStyle.FixedSingle);
      \u0099\u001F.\u001C\u008B((object) this, false);
      \u0099\u001F.\u001E\u008B((object) this, false);
      \u0092\u0081.\u0010\u0084((object) this, \u0017.\u0001(34902));
      \u009C\u001C.\u0084\u008B((object) this, FormStartPosition.CenterScreen);
      \u0092\u0081.\u007E\u001D\u0084((object) this, \u0017.\u0001(34902));
      \u0099\u001F.\u0086\u008B((object) this, true);
      \u0099\u001F.\u007E\u007F\u0086((object) this.\u0001, false);
      \u001A\u001E.\u007E\u0019\u0086((object) this.\u0001);
      \u0099\u001F.\u007F\u0086((object) this, false);
    }
  }
}
