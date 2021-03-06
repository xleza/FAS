﻿using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace FAS.UI
{
    public static class Extensions
    {
        public static Bitmap ToBitmap(this byte[] self)
        {
            using (var ms = new MemoryStream(self))
            {
                return new Bitmap(ms);
            }
        }

        public static async Task OnSuccess(this Task self, Action onSuccess)
        {
            await self;

            onSuccess();
        }

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
        public static async Task<T> OnError<T>(this Task<T> self, Action<string> onError)
        {
            T result = default;
            try
            {
                result = await self;
            }
            catch (Exception ex)
            {
                onError(ex.Message);
            }

            return result;
        }
    }
}
