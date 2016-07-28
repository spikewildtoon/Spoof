// Decompiled with JetBrains decompiler
// Type: .
// Assembly: TheToonTownSpoofer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=599186c172bd0364
// MVID: B039A871-4CC9-4341-8B41-AC2E69DB4046
// Assembly location: C:\Program Files (x86)\The Spoof Net\The ToonTown Spoofer V6\TheToonTownSpoofer.exe

using \u0001;
using \u0016;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace \u0016
{
  internal static class \u0008
  {
    [NonSerialized]
    internal static \u0002 \u0001;
    private static readonly string \u0001;
    private static readonly Guid \u0001;
    private static readonly string \u0002;
    private static readonly string \u0003;
    private static readonly Guid \u0002;

    static \u0008()
    {
      \u0004.\u001D\u0005(typeof (\u0008));
      \u0008.\u0001 = \u0008.\u0001(15838);
      \u0008.\u0001 = new Guid(\u0008.\u0001(15887));
      \u0008.\u0002 = \u0008.\u0001(15940);
      \u0008.\u0003 = \u0008.\u0001(15953);
      \u0008.\u0002 = new Guid(\u0008.\u0001(15970));
    }

    public static ImageCodecInfo \u001D\u0005(string mimeType)
    {
      // ISSUE: unable to decompile the method.
    }

    public static ImageCodecInfo \u001D\u0005()
    {
      return \u0008.\u001D\u0005(\u009F\u001F.\u0013\u0082(), \u0008.\u0002, \u0008.\u0003);
    }

    public static ImageCodecInfo \u001E\u0005()
    {
      return \u0008.\u001D\u0005(\u009F\u001F.\u0013\u0082(), \u0008.\u0001, \u0008.\u0002);
    }

    public static ImageCodecInfo \u001F\u0005()
    {
      return \u0008.\u001D\u0005(\u009F\u001F.\u0012\u0082(), \u0008.\u0001, \u0008.\u0002);
    }

    private static ImageCodecInfo \u001D\u0005(ImageCodecInfo[] codecs, Guid image_guid, string mime_type)
    {
      // ISSUE: unable to decompile the method.
    }

    public static void \u001D\u0005(Bitmap image, Stream image_stream, int quality)
    {
      \u0008.\u001D\u0005(image, image_stream, quality, \u0008.\u001E\u0005());
    }

    public static void \u001E\u0005(Bitmap image, Stream image_stream, int quality)
    {
      \u0008.\u001D\u0005(image, image_stream, quality, \u0008.\u001D\u0005());
    }

    private static void \u001D\u0005(Bitmap image, Stream image_stream, int quality, ImageCodecInfo codec)
    {
      if (quality < 0 || quality > 100)
        throw new ArgumentOutOfRangeException(\u0008.\u0001(15780), \u009E\u0081.\u001F\u0093(\u0008.\u0001(15793), (object) quality));
      EncoderParameters encoderParameters = new EncoderParameters();
      try
      {
        EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, (long) quality);
        try
        {
          \u000E\u001E.\u007E\u0088\u0081((object) encoderParameters, new EncoderParameter[1]
          {
            encoderParameter
          });
          \u009B\u001D.\u007E\u001E\u001F((object) image, image_stream, codec, encoderParameters);
        }
        finally
        {
          if (encoderParameter != null)
            \u001A\u001E.\u007E\u0094\u0092((object) encoderParameter);
        }
      }
      finally
      {
        if (encoderParameters != null)
          \u001A\u001E.\u007E\u0094\u0092((object) encoderParameters);
      }
    }

    public static void \u001D\u0005(Bitmap image, Stream image_stream, int quality, int width, int height)
    {
      Bitmap image1 = new Bitmap((Image) image, width, height);
      try
      {
        \u0008.\u001D\u0005(image1, image_stream, quality);
      }
      finally
      {
        if (image1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) image1);
      }
    }

    public static void \u001E\u0005(Bitmap image, Stream image_stream, int quality, int width, int height)
    {
      Bitmap image1 = new Bitmap((Image) image, width, height);
      try
      {
        \u0008.\u001E\u0005(image1, image_stream, quality);
      }
      finally
      {
        if (image1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) image1);
      }
    }

    public static void \u001D\u0005(Bitmap image, Stream image_stream, Color backColor, int quality, int width, int height)
    {
      Bitmap image1 = new Bitmap(width, height);
      try
      {
        Graphics graphics = \u0005\u0087.\u001D\u007F((Image) image1);
        try
        {
          \u0015\u0083.\u007E\u0081\u007F((object) graphics, SmoothingMode.HighQuality);
          \u0094\u0081.\u007E\u0083\u007F((object) graphics, InterpolationMode.High);
          \u0099\u0083.\u007E\u007F\u007F((object) graphics, CompositingQuality.HighQuality);
          \u0081\u0082.\u007E\u0091\u007F((object) graphics, backColor);
          \u0004\u001F.\u007E\u009E\u007F((object) graphics, (Image) image, new Rectangle(Point.Empty, new Size(width, height)));
        }
        finally
        {
          if (graphics != null)
            \u001A\u001E.\u007E\u0094\u0092((object) graphics);
        }
        \u0008.\u001E\u0005(image1, image_stream, quality);
      }
      finally
      {
        if (image1 != null)
          \u001A\u001E.\u007E\u0094\u0092((object) image1);
      }
    }

    public static void \u001D\u0005(Bitmap image, Stream image_stream, Color backColor, int quality)
    {
      \u0008.\u001D\u0005(image, image_stream, backColor, quality, \u0005\u0081.\u007E\u007F\u001F((object) image), \u0005\u0081.\u007E\u0080\u001F((object) image));
    }
  }
}
