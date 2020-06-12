using System.Drawing;
using System.Runtime.CompilerServices;
using Accord.Imaging;
using JetBrains.Annotations;



namespace PROcessing.Net.Imaging {
  public static class BitmapX {
    [NotNull]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static UnmanagedImage ToUnmanaged(this Bitmap thisImage) => UnmanagedImage.FromManagedImage(thisImage);
  }
}
