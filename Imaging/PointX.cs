using System;
using System.Drawing;
using System.Runtime.CompilerServices;



namespace PROcessing.Net.Imaging {
  public static class PointX {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static PointF Scale(this PointF point, float scaleX, float scaleY) =>
      new PointF(point.X * scaleX, point.Y * scaleY);



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static PointF Scale(this PointF point, double scaleX, double scaleY) => new PointF(
      (float)(point.X * scaleX),
      (float)(point.Y * scaleY)
    );



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Point Round(this PointF point) => new Point((int)Math.Round(point.X), (int)Math.Round(point.Y));



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Point Truncate(this PointF point) => new Point((int)point.X, (int)point.Y);



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Point Ceiling(this PointF point) => new Point((int)Math.Ceiling(point.X), (int)Math.Ceiling(point.Y));
  }
}
