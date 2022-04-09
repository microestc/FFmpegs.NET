using System;
using System.Runtime.InteropServices;

namespace FFmpeg.NET
{
    public static unsafe class NativeApiExtensions
    {
        public static int MAX_ERROR = 64;
        /// <summary>Compute ceil(log2(x)).</summary>
        /// <param name="x">value used to compute ceil(log2(x))</param>
        /// <returns>computed ceiling of log2(x)</returns>
        public static int av_ceil_log2_c(this NativeApi api, int @x)
        {
            return api.av_log2((uint)(x - 1U) << 1);
        }

        /// <summary>Fill the provided buffer with a string containing an error string corresponding to the AVERROR code errnum.</summary>
        /// <param name="errbuf">a buffer</param>
        /// <param name="errbuf_size">size in bytes of errbuf</param>
        /// <param name="errnum">error code to describe</param>
        /// <returns>the buffer in input, filled with the error description</returns>
        public static byte* av_make_error_string(this NativeApi api, byte* @errbuf, ulong @errbuf_size, int @errnum)
        {
            api.av_strerror(errnum, errbuf, errbuf_size);
            return errbuf;
        }

        /// <summary>ftell() equivalent for AVIOContext.</summary>
        /// <returns>position or AVERROR.</returns>
        public static long avio_tell(this NativeApi api, AVIOContext* @s)
        {
            return api.avio_seek(s, 0, 1);
        }

        public static string? GetError(this NativeApi api, int number)
        {
            if (number >= 0) return null;
            var bytes = stackalloc byte[MAX_ERROR];
            api.av_strerror(number, bytes, (ulong)MAX_ERROR);
            return Marshal.PtrToStringAnsi((IntPtr) bytes);
        }

        public static int ThrowExceptionIfError(this NativeApi api, int error)
        {
            if (error < 0) throw new ApplicationException(api.GetError(error));
            return error;
        }
    }
}
