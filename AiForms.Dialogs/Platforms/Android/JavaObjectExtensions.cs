﻿using System;
namespace AiForms.Dialogs
{
    [Android.Runtime.Preserve(AllMembers = true)]
    public static class JavaObjectExtensions
    {
        public static bool IsDisposed(this Java.Lang.Object obj)
        {
            return obj.Handle == IntPtr.Zero;
        }
    }
}
