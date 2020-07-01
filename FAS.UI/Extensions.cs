using System;
using System.Drawing;
using System.Threading.Tasks;

namespace FAS.UI
{
    public static class Extensions
    {
        public static byte[] ToBytes(this Image self) => (byte[])new ImageConverter().ConvertTo(self, typeof(byte[]));

        public static async Task OnError(this Task self, Action<string> onError)
        {
            try
            {
                await self;
            }
            catch (Exception ex)
            {
                onError(ex.Message);
            }
        }
    }
}
