using System;
using System.Drawing;
using System.Runtime.CompilerServices;



namespace PROcessing.Net.Imaging {
  public static class SizeX {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Equals(this Size size, int width, int height) => size.Width == width && size.Height == height;



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Size RoundInt(this SizeF size) => new Size((int)(size.Width + .5), (int)(size.Height + .5));



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Size TruncateInt(this SizeF size) => new Size((int)size.Width, (int)size.Height);



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Size CeilingInt(this SizeF size) => new Size(
      (int)Math.Ceiling(size.Width),
      (int)Math.Ceiling(size.Height)
    );



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static SizeF Scale(this SizeF size, float scaleX, float scaleY) =>
      new SizeF(size.Width * scaleX, size.Height * scaleY);



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static SizeF Scale(this SizeF size, double scaleX, double scaleY) => new SizeF(
      (float)(size.Width * scaleX),
      (float)(size.Height * scaleY)
    );
  }
}
