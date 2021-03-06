﻿using System.Runtime.InteropServices;
using PikaCore.Areas.Core.Controllers.Helpers;

namespace PikaCore.Areas.Infrastructure.Services.Helpers
{
    internal static class FileSystemAccessor
    {
        [DllImport("libposixhlpr.so")]
        internal static extern string permission_str(string file);

        [DllImport("libposixhlpr.so")]
        internal static extern Perms permission_model(string file);

        [DllImport("libposixhlpr.so")]
        internal static extern int owner(string file);
    }
}
