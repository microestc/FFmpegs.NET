using System;

namespace FFmpeg.NET
{
    public unsafe static partial class FFmpegconst
    {
        public static readonly int EAGAIN = OperatingSystem.IsMacOS() ? 35 : 11;
        
        public static readonly int ENOMEM = 12;

        public static readonly int EINVAL = 22;

        public static readonly int EPIPE = 32;

        /// <summary>_WIN32_WINNT = 0x602</summary>
        public const int _WIN32_WINNT = 0x602;

        // public static attribute_deprecated = __declspec(deprecated);
        
        // public static av_alias = __attribute__((may_alias));
        
        // public static av_alloc_size = (...);
        
        // public static av_always_inline = __forceinline;
        
        /// <summary>AV_BUFFER_FLAG_READONLY = (1 &lt;&lt; 0)</summary>
        public const int AV_BUFFER_FLAG_READONLY = 0x1 << 0x0;
        
        /// <summary>AV_BUFFERSINK_FLAG_NO_REQUEST = 0x2</summary>
        public const int AV_BUFFERSINK_FLAG_NO_REQUEST = 0x2;
        
        /// <summary>AV_BUFFERSINK_FLAG_PEEK = 0x1</summary>
        public const int AV_BUFFERSINK_FLAG_PEEK = 0x1;
        
        // public static av_builtin_constant_p = __builtin_constant_p;
        
        // public static AV_CEIL_RSHIFT = (a,b) (!av_builtin_constant_p(b) ? -((-(a)) >> (b)) : ((a) + (1<<(b)) - 1) >> (b));
        
        /// <summary>AV_CH_BACK_CENTER = 0x100</summary>
        public const int AV_CH_BACK_CENTER = 0x100;
        
        /// <summary>AV_CH_BACK_LEFT = 0x10</summary>
        public const int AV_CH_BACK_LEFT = 0x10;
        
        /// <summary>AV_CH_BACK_RIGHT = 0x20</summary>
        public const int AV_CH_BACK_RIGHT = 0x20;
        
        /// <summary>AV_CH_BOTTOM_FRONT_CENTER = 0x4000000000UL</summary>
        public const ulong AV_CH_BOTTOM_FRONT_CENTER = 0x4000000000UL;
        
        /// <summary>AV_CH_BOTTOM_FRONT_LEFT = 0x8000000000UL</summary>
        public const ulong AV_CH_BOTTOM_FRONT_LEFT = 0x8000000000UL;
        
        /// <summary>AV_CH_BOTTOM_FRONT_RIGHT = 0x10000000000UL</summary>
        public const ulong AV_CH_BOTTOM_FRONT_RIGHT = 0x10000000000UL;
        
        /// <summary>AV_CH_FRONT_CENTER = 0x4</summary>
        public const int AV_CH_FRONT_CENTER = 0x4;
        
        /// <summary>AV_CH_FRONT_LEFT = 0x1</summary>
        public const int AV_CH_FRONT_LEFT = 0x1;
        
        /// <summary>AV_CH_FRONT_LEFT_OF_CENTER = 0x40</summary>
        public const int AV_CH_FRONT_LEFT_OF_CENTER = 0x40;
        
        /// <summary>AV_CH_FRONT_RIGHT = 0x2</summary>
        public const int AV_CH_FRONT_RIGHT = 0x2;
        
        /// <summary>AV_CH_FRONT_RIGHT_OF_CENTER = 0x80</summary>
        public const int AV_CH_FRONT_RIGHT_OF_CENTER = 0x80;
        
        /// <summary>AV_CH_LAYOUT_2_1 = AV_CH_LAYOUT_STEREO | AV_CH_BACK_CENTER</summary>
        public const int AV_CH_LAYOUT_2_1 = AV_CH_LAYOUT_STEREO | AV_CH_BACK_CENTER;
        
        /// <summary>AV_CH_LAYOUT_2_2 = AV_CH_LAYOUT_STEREO | AV_CH_SIDE_LEFT | AV_CH_SIDE_RIGHT</summary>
        public const int AV_CH_LAYOUT_2_2 = AV_CH_LAYOUT_STEREO | AV_CH_SIDE_LEFT | AV_CH_SIDE_RIGHT;
        
        // public static AV_CH_LAYOUT_22POINT2 = (ulong)(AV_CH_LAYOUT_5POINT1_BACK | AV_CH_FRONT_LEFT_OF_CENTER | AV_CH_FRONT_RIGHT_OF_CENTER | AV_CH_BACK_CENTER) | (ulong)(AV_CH_LOW_FREQUENCY_2) | (ulong)((AV_CH_SIDE_LEFT)(|(ulong)((AV_CH_SIDE_RIGHT)(|(ulong)((AV_CH_TOP_FRONT_LEFT)(|(ulong)((AV_CH_TOP_FRONT_RIGHT)(|(ulong)((AV_CH_TOP_FRONT_CENTER)(|(ulong)((AV_CH_TOP_CENTER)(|(ulong)((AV_CH_TOP_BACK_LEFT)(|(ulong)((AV_CH_TOP_BACK_RIGHT)(|(ulong)((AV_CH_TOP_SIDE_LEFT)(|(ulong)((AV_CH_TOP_SIDE_RIGHT)(|(ulong)((AV_CH_TOP_BACK_CENTER)(|(ulong)((AV_CH_BOTTOM_FRONT_CENTER)(|(ulong)((AV_CH_BOTTOM_FRONT_LEFT)(|(ulong)(AV_CH_BOTTOM_FRONT_RIGHT)))))))))))))))))))))))))));
        
        /// <summary>AV_CH_LAYOUT_2POINT1 = AV_CH_LAYOUT_STEREO | AV_CH_LOW_FREQUENCY</summary>
        public const int AV_CH_LAYOUT_2POINT1 = AV_CH_LAYOUT_STEREO | AV_CH_LOW_FREQUENCY;
        
        /// <summary>AV_CH_LAYOUT_3POINT1 = AV_CH_LAYOUT_SURROUND | AV_CH_LOW_FREQUENCY</summary>
        public const int AV_CH_LAYOUT_3POINT1 = AV_CH_LAYOUT_SURROUND | AV_CH_LOW_FREQUENCY;
        
        /// <summary>AV_CH_LAYOUT_4POINT0 = AV_CH_LAYOUT_SURROUND | AV_CH_BACK_CENTER</summary>
        public const int AV_CH_LAYOUT_4POINT0 = AV_CH_LAYOUT_SURROUND | AV_CH_BACK_CENTER;
        
        /// <summary>AV_CH_LAYOUT_4POINT1 = AV_CH_LAYOUT_4POINT0 | AV_CH_LOW_FREQUENCY</summary>
        public const int AV_CH_LAYOUT_4POINT1 = AV_CH_LAYOUT_4POINT0 | AV_CH_LOW_FREQUENCY;
        
        /// <summary>AV_CH_LAYOUT_5POINT0 = AV_CH_LAYOUT_SURROUND | AV_CH_SIDE_LEFT | AV_CH_SIDE_RIGHT</summary>
        public const int AV_CH_LAYOUT_5POINT0 = AV_CH_LAYOUT_SURROUND | AV_CH_SIDE_LEFT | AV_CH_SIDE_RIGHT;
        
        /// <summary>AV_CH_LAYOUT_5POINT0_BACK = AV_CH_LAYOUT_SURROUND | AV_CH_BACK_LEFT | AV_CH_BACK_RIGHT</summary>
        public const int AV_CH_LAYOUT_5POINT0_BACK = AV_CH_LAYOUT_SURROUND | AV_CH_BACK_LEFT | AV_CH_BACK_RIGHT;
        
        /// <summary>AV_CH_LAYOUT_5POINT1 = AV_CH_LAYOUT_5POINT0 | AV_CH_LOW_FREQUENCY</summary>
        public const int AV_CH_LAYOUT_5POINT1 = AV_CH_LAYOUT_5POINT0 | AV_CH_LOW_FREQUENCY;
        
        /// <summary>AV_CH_LAYOUT_5POINT1_BACK = AV_CH_LAYOUT_5POINT0_BACK | AV_CH_LOW_FREQUENCY</summary>
        public const int AV_CH_LAYOUT_5POINT1_BACK = AV_CH_LAYOUT_5POINT0_BACK | AV_CH_LOW_FREQUENCY;
        
        /// <summary>AV_CH_LAYOUT_6POINT0 = AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_CENTER</summary>
        public const int AV_CH_LAYOUT_6POINT0 = AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_CENTER;
        
        /// <summary>AV_CH_LAYOUT_6POINT0_FRONT = AV_CH_LAYOUT_2_2 | AV_CH_FRONT_LEFT_OF_CENTER | AV_CH_FRONT_RIGHT_OF_CENTER</summary>
        public const int AV_CH_LAYOUT_6POINT0_FRONT = AV_CH_LAYOUT_2_2 | AV_CH_FRONT_LEFT_OF_CENTER | AV_CH_FRONT_RIGHT_OF_CENTER;
        
        /// <summary>AV_CH_LAYOUT_6POINT1 = AV_CH_LAYOUT_5POINT1 | AV_CH_BACK_CENTER</summary>
        public const int AV_CH_LAYOUT_6POINT1 = AV_CH_LAYOUT_5POINT1 | AV_CH_BACK_CENTER;
        
        /// <summary>AV_CH_LAYOUT_6POINT1_BACK = AV_CH_LAYOUT_5POINT1_BACK | AV_CH_BACK_CENTER</summary>
        public const int AV_CH_LAYOUT_6POINT1_BACK = AV_CH_LAYOUT_5POINT1_BACK | AV_CH_BACK_CENTER;
        
        /// <summary>AV_CH_LAYOUT_6POINT1_FRONT = AV_CH_LAYOUT_6POINT0_FRONT | AV_CH_LOW_FREQUENCY</summary>
        public const int AV_CH_LAYOUT_6POINT1_FRONT = AV_CH_LAYOUT_6POINT0_FRONT | AV_CH_LOW_FREQUENCY;
        
        /// <summary>AV_CH_LAYOUT_7POINT0 = AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_LEFT | AV_CH_BACK_RIGHT</summary>
        public const int AV_CH_LAYOUT_7POINT0 = AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_LEFT | AV_CH_BACK_RIGHT;
        
        /// <summary>AV_CH_LAYOUT_7POINT0_FRONT = AV_CH_LAYOUT_5POINT0 | AV_CH_FRONT_LEFT_OF_CENTER | AV_CH_FRONT_RIGHT_OF_CENTER</summary>
        public const int AV_CH_LAYOUT_7POINT0_FRONT = AV_CH_LAYOUT_5POINT0 | AV_CH_FRONT_LEFT_OF_CENTER | AV_CH_FRONT_RIGHT_OF_CENTER;
        
        /// <summary>AV_CH_LAYOUT_7POINT1 = AV_CH_LAYOUT_5POINT1 | AV_CH_BACK_LEFT | AV_CH_BACK_RIGHT</summary>
        public const int AV_CH_LAYOUT_7POINT1 = AV_CH_LAYOUT_5POINT1 | AV_CH_BACK_LEFT | AV_CH_BACK_RIGHT;
        
        /// <summary>AV_CH_LAYOUT_7POINT1_WIDE = AV_CH_LAYOUT_5POINT1 | AV_CH_FRONT_LEFT_OF_CENTER | AV_CH_FRONT_RIGHT_OF_CENTER</summary>
        public const int AV_CH_LAYOUT_7POINT1_WIDE = AV_CH_LAYOUT_5POINT1 | AV_CH_FRONT_LEFT_OF_CENTER | AV_CH_FRONT_RIGHT_OF_CENTER;
        
        /// <summary>AV_CH_LAYOUT_7POINT1_WIDE_BACK = AV_CH_LAYOUT_5POINT1_BACK | AV_CH_FRONT_LEFT_OF_CENTER | AV_CH_FRONT_RIGHT_OF_CENTER</summary>
        public const int AV_CH_LAYOUT_7POINT1_WIDE_BACK = AV_CH_LAYOUT_5POINT1_BACK | AV_CH_FRONT_LEFT_OF_CENTER | AV_CH_FRONT_RIGHT_OF_CENTER;
        
        // public static AV_CH_LAYOUT_HEXADECAGONAL = (ulong)((AV_CH_LAYOUT_OCTAGONAL)(|(ulong)(AV_CH_WIDE_LEFT) | (ulong)((AV_CH_WIDE_RIGHT)(|(ulong)((AV_CH_TOP_BACK_LEFT)(|(ulong)((AV_CH_TOP_BACK_RIGHT)(|(ulong)((AV_CH_TOP_BACK_CENTER)(|(ulong)((AV_CH_TOP_FRONT_CENTER)(|(ulong)((AV_CH_TOP_FRONT_LEFT)(|(ulong)(AV_CH_TOP_FRONT_RIGHT)))))))))))))));
        
        /// <summary>AV_CH_LAYOUT_HEXAGONAL = AV_CH_LAYOUT_5POINT0_BACK | AV_CH_BACK_CENTER</summary>
        public const int AV_CH_LAYOUT_HEXAGONAL = AV_CH_LAYOUT_5POINT0_BACK | AV_CH_BACK_CENTER;
        
        /// <summary>AV_CH_LAYOUT_MONO = AV_CH_FRONT_CENTER</summary>
        public const int AV_CH_LAYOUT_MONO = AV_CH_FRONT_CENTER;
        
        /// <summary>AV_CH_LAYOUT_NATIVE = 0x8000000000000000UL</summary>
        public const ulong AV_CH_LAYOUT_NATIVE = 0x8000000000000000UL;
        
        /// <summary>AV_CH_LAYOUT_OCTAGONAL = AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_LEFT | AV_CH_BACK_CENTER | AV_CH_BACK_RIGHT</summary>
        public const int AV_CH_LAYOUT_OCTAGONAL = AV_CH_LAYOUT_5POINT0 | AV_CH_BACK_LEFT | AV_CH_BACK_CENTER | AV_CH_BACK_RIGHT;
        
        /// <summary>AV_CH_LAYOUT_QUAD = AV_CH_LAYOUT_STEREO | AV_CH_BACK_LEFT | AV_CH_BACK_RIGHT</summary>
        public const int AV_CH_LAYOUT_QUAD = AV_CH_LAYOUT_STEREO | AV_CH_BACK_LEFT | AV_CH_BACK_RIGHT;
        
        /// <summary>AV_CH_LAYOUT_STEREO = AV_CH_FRONT_LEFT | AV_CH_FRONT_RIGHT</summary>
        public const int AV_CH_LAYOUT_STEREO = AV_CH_FRONT_LEFT | AV_CH_FRONT_RIGHT;
        
        /// <summary>AV_CH_LAYOUT_STEREO_DOWNMIX = AV_CH_STEREO_LEFT | AV_CH_STEREO_RIGHT</summary>
        public const int AV_CH_LAYOUT_STEREO_DOWNMIX = AV_CH_STEREO_LEFT | AV_CH_STEREO_RIGHT;
        
        /// <summary>AV_CH_LAYOUT_SURROUND = AV_CH_LAYOUT_STEREO | AV_CH_FRONT_CENTER</summary>
        public const int AV_CH_LAYOUT_SURROUND = AV_CH_LAYOUT_STEREO | AV_CH_FRONT_CENTER;
        
        /// <summary>AV_CH_LOW_FREQUENCY = 0x8</summary>
        public const int AV_CH_LOW_FREQUENCY = 0x8;
        
        /// <summary>AV_CH_LOW_FREQUENCY_2 = 0x800000000UL</summary>
        public const ulong AV_CH_LOW_FREQUENCY_2 = 0x800000000UL;
        
        /// <summary>AV_CH_SIDE_LEFT = 0x200</summary>
        public const int AV_CH_SIDE_LEFT = 0x200;
        
        /// <summary>AV_CH_SIDE_RIGHT = 0x400</summary>
        public const int AV_CH_SIDE_RIGHT = 0x400;
        
        /// <summary>AV_CH_STEREO_LEFT = 0x20000000</summary>
        public const int AV_CH_STEREO_LEFT = 0x20000000;
        
        /// <summary>AV_CH_STEREO_RIGHT = 0x40000000</summary>
        public const int AV_CH_STEREO_RIGHT = 0x40000000;
        
        /// <summary>AV_CH_SURROUND_DIRECT_LEFT = 0x200000000UL</summary>
        public const ulong AV_CH_SURROUND_DIRECT_LEFT = 0x200000000UL;
        
        /// <summary>AV_CH_SURROUND_DIRECT_RIGHT = 0x400000000UL</summary>
        public const ulong AV_CH_SURROUND_DIRECT_RIGHT = 0x400000000UL;
        
        /// <summary>AV_CH_TOP_BACK_CENTER = 0x10000</summary>
        public const int AV_CH_TOP_BACK_CENTER = 0x10000;
        
        /// <summary>AV_CH_TOP_BACK_LEFT = 0x8000</summary>
        public const int AV_CH_TOP_BACK_LEFT = 0x8000;
        
        /// <summary>AV_CH_TOP_BACK_RIGHT = 0x20000</summary>
        public const int AV_CH_TOP_BACK_RIGHT = 0x20000;
        
        /// <summary>AV_CH_TOP_CENTER = 0x800</summary>
        public const int AV_CH_TOP_CENTER = 0x800;
        
        /// <summary>AV_CH_TOP_FRONT_CENTER = 0x2000</summary>
        public const int AV_CH_TOP_FRONT_CENTER = 0x2000;
        
        /// <summary>AV_CH_TOP_FRONT_LEFT = 0x1000</summary>
        public const int AV_CH_TOP_FRONT_LEFT = 0x1000;
        
        /// <summary>AV_CH_TOP_FRONT_RIGHT = 0x4000</summary>
        public const int AV_CH_TOP_FRONT_RIGHT = 0x4000;
        
        /// <summary>AV_CH_TOP_SIDE_LEFT = 0x1000000000UL</summary>
        public const ulong AV_CH_TOP_SIDE_LEFT = 0x1000000000UL;
        
        /// <summary>AV_CH_TOP_SIDE_RIGHT = 0x2000000000UL</summary>
        public const ulong AV_CH_TOP_SIDE_RIGHT = 0x2000000000UL;
        
        /// <summary>AV_CH_WIDE_LEFT = 0x80000000UL</summary>
        public const ulong AV_CH_WIDE_LEFT = 0x80000000UL;
        
        /// <summary>AV_CH_WIDE_RIGHT = 0x100000000UL</summary>
        public const ulong AV_CH_WIDE_RIGHT = 0x100000000UL;
        
        // public static av_clip = av_clip_c;
        
        // public static av_clip_int16 = av_clip_int16_c;
        
        // public static av_clip_int8 = av_clip_int8_c;
        
        // public static av_clip_intp2 = av_clip_intp2_c;
        
        // public static av_clip_uint16 = av_clip_uint16_c;
        
        // public static av_clip_uint8 = av_clip_uint8_c;
        
        // public static av_clip_uintp2 = av_clip_uintp2_c;
        
        // public static av_clip64 = av_clip64_c;
        
        // public static av_clipd = av_clipd_c;
        
        // public static av_clipf = av_clipf_c;
        
        // public static av_clipl_int32 = av_clipl_int32_c;
        
        /// <summary>AV_CODEC_CAP_AUTO_THREADS = AV_CODEC_CAP_OTHER_THREADS</summary>
        public const int AV_CODEC_CAP_AUTO_THREADS = AV_CODEC_CAP_OTHER_THREADS;
        
        /// <summary>AV_CODEC_CAP_AVOID_PROBING = (1 &lt;&lt; 17)</summary>
        public const int AV_CODEC_CAP_AVOID_PROBING = 0x1 << 0x11;
        
        /// <summary>AV_CODEC_CAP_CHANNEL_CONF = (1 &lt;&lt; 10)</summary>
        public const int AV_CODEC_CAP_CHANNEL_CONF = 0x1 << 0xa;
        
        /// <summary>AV_CODEC_CAP_DELAY = (1 &lt;&lt;  5)</summary>
        public const int AV_CODEC_CAP_DELAY = 0x1 << 0x5;
        
        /// <summary>AV_CODEC_CAP_DR1 = (1 &lt;&lt;  1)</summary>
        public const int AV_CODEC_CAP_DR1 = 0x1 << 0x1;
        
        /// <summary>AV_CODEC_CAP_DRAW_HORIZ_BAND = (1 &lt;&lt;  0)</summary>
        public const int AV_CODEC_CAP_DRAW_HORIZ_BAND = 0x1 << 0x0;
        
        /// <summary>AV_CODEC_CAP_ENCODER_FLUSH = (1 &lt;&lt; 21)</summary>
        public const int AV_CODEC_CAP_ENCODER_FLUSH = 0x1 << 0x15;
        
        /// <summary>AV_CODEC_CAP_ENCODER_REORDERED_OPAQUE = (1 &lt;&lt; 20)</summary>
        public const int AV_CODEC_CAP_ENCODER_REORDERED_OPAQUE = 0x1 << 0x14;
        
        /// <summary>AV_CODEC_CAP_EXPERIMENTAL = (1 &lt;&lt;  9)</summary>
        public const int AV_CODEC_CAP_EXPERIMENTAL = 0x1 << 0x9;
        
        /// <summary>AV_CODEC_CAP_FRAME_THREADS = (1 &lt;&lt; 12)</summary>
        public const int AV_CODEC_CAP_FRAME_THREADS = 0x1 << 0xc;
        
        /// <summary>AV_CODEC_CAP_HARDWARE = (1 &lt;&lt; 18)</summary>
        public const int AV_CODEC_CAP_HARDWARE = 0x1 << 0x12;
        
        /// <summary>AV_CODEC_CAP_HYBRID = (1 &lt;&lt; 19)</summary>
        public const int AV_CODEC_CAP_HYBRID = 0x1 << 0x13;
        
        /// <summary>AV_CODEC_CAP_INTRA_ONLY = 0x40000000</summary>
        public const int AV_CODEC_CAP_INTRA_ONLY = 0x40000000;
        
        /// <summary>AV_CODEC_CAP_LOSSLESS = 0x80000000</summary>
        public const uint AV_CODEC_CAP_LOSSLESS = 0x80000000U;
        
        /// <summary>AV_CODEC_CAP_OTHER_THREADS = (1 &lt;&lt; 15)</summary>
        public const int AV_CODEC_CAP_OTHER_THREADS = 0x1 << 0xf;
        
        /// <summary>AV_CODEC_CAP_PARAM_CHANGE = (1 &lt;&lt; 14)</summary>
        public const int AV_CODEC_CAP_PARAM_CHANGE = 0x1 << 0xe;
        
        /// <summary>AV_CODEC_CAP_SLICE_THREADS = (1 &lt;&lt; 13)</summary>
        public const int AV_CODEC_CAP_SLICE_THREADS = 0x1 << 0xd;
        
        /// <summary>AV_CODEC_CAP_SMALL_LAST_FRAME = (1 &lt;&lt;  6)</summary>
        public const int AV_CODEC_CAP_SMALL_LAST_FRAME = 0x1 << 0x6;
        
        /// <summary>AV_CODEC_CAP_SUBFRAMES = (1 &lt;&lt;  8)</summary>
        public const int AV_CODEC_CAP_SUBFRAMES = 0x1 << 0x8;
        
        /// <summary>AV_CODEC_CAP_TRUNCATED = (1 &lt;&lt;  3)</summary>
        public const int AV_CODEC_CAP_TRUNCATED = 0x1 << 0x3;
        
        /// <summary>AV_CODEC_CAP_VARIABLE_FRAME_SIZE = (1 &lt;&lt; 16)</summary>
        public const int AV_CODEC_CAP_VARIABLE_FRAME_SIZE = 0x1 << 0x10;
        
        /// <summary>AV_CODEC_EXPORT_DATA_FILM_GRAIN = 0x1 &lt;&lt; 0x3</summary>
        public const int AV_CODEC_EXPORT_DATA_FILM_GRAIN = 0x1 << 0x3;
        
        /// <summary>AV_CODEC_EXPORT_DATA_MVS = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_CODEC_EXPORT_DATA_MVS = 0x1 << 0x0;
        
        /// <summary>AV_CODEC_EXPORT_DATA_PRFT = 0x1 &lt;&lt; 0x1</summary>
        public const int AV_CODEC_EXPORT_DATA_PRFT = 0x1 << 0x1;
        
        /// <summary>AV_CODEC_EXPORT_DATA_VIDEO_ENC_PARAMS = 0x1 &lt;&lt; 0x2</summary>
        public const int AV_CODEC_EXPORT_DATA_VIDEO_ENC_PARAMS = 0x1 << 0x2;
        
        /// <summary>AV_CODEC_FLAG_4MV = 0x1 &lt;&lt; 0x2</summary>
        public const int AV_CODEC_FLAG_4MV = 0x1 << 0x2;
        
        /// <summary>AV_CODEC_FLAG_AC_PRED = 0x1 &lt;&lt; 0x18</summary>
        public const int AV_CODEC_FLAG_AC_PRED = 0x1 << 0x18;
        
        /// <summary>AV_CODEC_FLAG_BITEXACT = 0x1 &lt;&lt; 0x17</summary>
        public const int AV_CODEC_FLAG_BITEXACT = 0x1 << 0x17;
        
        /// <summary>AV_CODEC_FLAG_CLOSED_GOP = 0x1U &lt;&lt; 0x1f</summary>
        public const uint AV_CODEC_FLAG_CLOSED_GOP = 0x1U << 0x1f;
        
        /// <summary>AV_CODEC_FLAG_DROPCHANGED = 0x1 &lt;&lt; 0x5</summary>
        public const int AV_CODEC_FLAG_DROPCHANGED = 0x1 << 0x5;
        
        /// <summary>AV_CODEC_FLAG_GLOBAL_HEADER = 0x1 &lt;&lt; 0x16</summary>
        public const int AV_CODEC_FLAG_GLOBAL_HEADER = 0x1 << 0x16;
        
        /// <summary>AV_CODEC_FLAG_GRAY = 0x1 &lt;&lt; 0xd</summary>
        public const int AV_CODEC_FLAG_GRAY = 0x1 << 0xd;
        
        /// <summary>AV_CODEC_FLAG_INTERLACED_DCT = 0x1 &lt;&lt; 0x12</summary>
        public const int AV_CODEC_FLAG_INTERLACED_DCT = 0x1 << 0x12;
        
        /// <summary>AV_CODEC_FLAG_INTERLACED_ME = 0x1 &lt;&lt; 0x1d</summary>
        public const int AV_CODEC_FLAG_INTERLACED_ME = 0x1 << 0x1d;
        
        /// <summary>AV_CODEC_FLAG_LOOP_FILTER = 0x1 &lt;&lt; 0xb</summary>
        public const int AV_CODEC_FLAG_LOOP_FILTER = 0x1 << 0xb;
        
        /// <summary>AV_CODEC_FLAG_LOW_DELAY = 0x1 &lt;&lt; 0x13</summary>
        public const int AV_CODEC_FLAG_LOW_DELAY = 0x1 << 0x13;
        
        /// <summary>AV_CODEC_FLAG_OUTPUT_CORRUPT = 0x1 &lt;&lt; 0x3</summary>
        public const int AV_CODEC_FLAG_OUTPUT_CORRUPT = 0x1 << 0x3;
        
        /// <summary>AV_CODEC_FLAG_PASS1 = 0x1 &lt;&lt; 0x9</summary>
        public const int AV_CODEC_FLAG_PASS1 = 0x1 << 0x9;
        
        /// <summary>AV_CODEC_FLAG_PASS2 = 0x1 &lt;&lt; 0xa</summary>
        public const int AV_CODEC_FLAG_PASS2 = 0x1 << 0xa;
        
        /// <summary>AV_CODEC_FLAG_PSNR = 0x1 &lt;&lt; 0xf</summary>
        public const int AV_CODEC_FLAG_PSNR = 0x1 << 0xf;
        
        /// <summary>AV_CODEC_FLAG_QPEL = 0x1 &lt;&lt; 0x4</summary>
        public const int AV_CODEC_FLAG_QPEL = 0x1 << 0x4;
        
        /// <summary>AV_CODEC_FLAG_QSCALE = 0x1 &lt;&lt; 0x1</summary>
        public const int AV_CODEC_FLAG_QSCALE = 0x1 << 0x1;
        
        /// <summary>AV_CODEC_FLAG_TRUNCATED = 0x1 &lt;&lt; 0x10</summary>
        public const int AV_CODEC_FLAG_TRUNCATED = 0x1 << 0x10;
        
        /// <summary>AV_CODEC_FLAG_UNALIGNED = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_CODEC_FLAG_UNALIGNED = 0x1 << 0x0;
        
        /// <summary>AV_CODEC_FLAG2_CHUNKS = 0x1 &lt;&lt; 0xf</summary>
        public const int AV_CODEC_FLAG2_CHUNKS = 0x1 << 0xf;
        
        /// <summary>AV_CODEC_FLAG2_DROP_FRAME_TIMECODE = 0x1 &lt;&lt; 0xd</summary>
        public const int AV_CODEC_FLAG2_DROP_FRAME_TIMECODE = 0x1 << 0xd;
        
        /// <summary>AV_CODEC_FLAG2_EXPORT_MVS = 0x1 &lt;&lt; 0x1c</summary>
        public const int AV_CODEC_FLAG2_EXPORT_MVS = 0x1 << 0x1c;
        
        /// <summary>AV_CODEC_FLAG2_FAST = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_CODEC_FLAG2_FAST = 0x1 << 0x0;
        
        /// <summary>AV_CODEC_FLAG2_IGNORE_CROP = 0x1 &lt;&lt; 0x10</summary>
        public const int AV_CODEC_FLAG2_IGNORE_CROP = 0x1 << 0x10;
        
        /// <summary>AV_CODEC_FLAG2_LOCAL_HEADER = 0x1 &lt;&lt; 0x3</summary>
        public const int AV_CODEC_FLAG2_LOCAL_HEADER = 0x1 << 0x3;
        
        /// <summary>AV_CODEC_FLAG2_NO_OUTPUT = 0x1 &lt;&lt; 0x2</summary>
        public const int AV_CODEC_FLAG2_NO_OUTPUT = 0x1 << 0x2;
        
        /// <summary>AV_CODEC_FLAG2_RO_FLUSH_NOOP = 0x1 &lt;&lt; 0x1e</summary>
        public const int AV_CODEC_FLAG2_RO_FLUSH_NOOP = 0x1 << 0x1e;
        
        /// <summary>AV_CODEC_FLAG2_SHOW_ALL = 0x1 &lt;&lt; 0x16</summary>
        public const int AV_CODEC_FLAG2_SHOW_ALL = 0x1 << 0x16;
        
        /// <summary>AV_CODEC_FLAG2_SKIP_MANUAL = 0x1 &lt;&lt; 0x1d</summary>
        public const int AV_CODEC_FLAG2_SKIP_MANUAL = 0x1 << 0x1d;
        
        // public static AV_CODEC_ID_H265 = AV_CODEC_ID_HEVC;
        
        // public static AV_CODEC_ID_H266 = AV_CODEC_ID_VVC;
        
        // public static AV_CODEC_ID_IFF_BYTERUN1 = AV_CODEC_ID_IFF_ILBM;
        
        /// <summary>AV_CODEC_PROP_BITMAP_SUB = 0x1 &lt;&lt; 0x10</summary>
        public const int AV_CODEC_PROP_BITMAP_SUB = 0x1 << 0x10;
        
        /// <summary>AV_CODEC_PROP_INTRA_ONLY = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_CODEC_PROP_INTRA_ONLY = 0x1 << 0x0;
        
        /// <summary>AV_CODEC_PROP_LOSSLESS = 0x1 &lt;&lt; 0x2</summary>
        public const int AV_CODEC_PROP_LOSSLESS = 0x1 << 0x2;
        
        /// <summary>AV_CODEC_PROP_LOSSY = 0x1 &lt;&lt; 0x1</summary>
        public const int AV_CODEC_PROP_LOSSY = 0x1 << 0x1;
        
        /// <summary>AV_CODEC_PROP_REORDER = 0x1 &lt;&lt; 0x3</summary>
        public const int AV_CODEC_PROP_REORDER = 0x1 << 0x3;
        
        /// <summary>AV_CODEC_PROP_TEXT_SUB = 0x1 &lt;&lt; 0x11</summary>
        public const int AV_CODEC_PROP_TEXT_SUB = 0x1 << 0x11;
        
        // public static av_cold = __attribute__((cold));
        
        // public static av_const = __attribute__((const));
        
        /// <summary>AV_CPU_FLAG_3DNOW = 0x4</summary>
        public const int AV_CPU_FLAG_3DNOW = 0x4;
        
        /// <summary>AV_CPU_FLAG_3DNOWEXT = 0x20</summary>
        public const int AV_CPU_FLAG_3DNOWEXT = 0x20;
        
        /// <summary>AV_CPU_FLAG_AESNI = 0x80000</summary>
        public const int AV_CPU_FLAG_AESNI = 0x80000;
        
        /// <summary>AV_CPU_FLAG_ALTIVEC = 0x1</summary>
        public const int AV_CPU_FLAG_ALTIVEC = 0x1;
        
        /// <summary>AV_CPU_FLAG_ARMV5TE = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_CPU_FLAG_ARMV5TE = 0x1 << 0x0;
        
        /// <summary>AV_CPU_FLAG_ARMV6 = 0x1 &lt;&lt; 0x1</summary>
        public const int AV_CPU_FLAG_ARMV6 = 0x1 << 0x1;
        
        /// <summary>AV_CPU_FLAG_ARMV6T2 = 0x1 &lt;&lt; 0x2</summary>
        public const int AV_CPU_FLAG_ARMV6T2 = 0x1 << 0x2;
        
        /// <summary>AV_CPU_FLAG_ARMV8 = 0x1 &lt;&lt; 0x6</summary>
        public const int AV_CPU_FLAG_ARMV8 = 0x1 << 0x6;
        
        /// <summary>AV_CPU_FLAG_ATOM = 0x10000000</summary>
        public const int AV_CPU_FLAG_ATOM = 0x10000000;
        
        /// <summary>AV_CPU_FLAG_AVX = 0x4000</summary>
        public const int AV_CPU_FLAG_AVX = 0x4000;
        
        /// <summary>AV_CPU_FLAG_AVX2 = 0x8000</summary>
        public const int AV_CPU_FLAG_AVX2 = 0x8000;
        
        /// <summary>AV_CPU_FLAG_AVX512 = 0x100000</summary>
        public const int AV_CPU_FLAG_AVX512 = 0x100000;
        
        /// <summary>AV_CPU_FLAG_AVXSLOW = 0x8000000</summary>
        public const int AV_CPU_FLAG_AVXSLOW = 0x8000000;
        
        /// <summary>AV_CPU_FLAG_BMI1 = 0x20000</summary>
        public const int AV_CPU_FLAG_BMI1 = 0x20000;
        
        /// <summary>AV_CPU_FLAG_BMI2 = 0x40000</summary>
        public const int AV_CPU_FLAG_BMI2 = 0x40000;
        
        /// <summary>AV_CPU_FLAG_CMOV = 0x1000</summary>
        public const int AV_CPU_FLAG_CMOV = 0x1000;
        
        /// <summary>AV_CPU_FLAG_FMA3 = 0x10000</summary>
        public const int AV_CPU_FLAG_FMA3 = 0x10000;
        
        /// <summary>AV_CPU_FLAG_FMA4 = 0x800</summary>
        public const int AV_CPU_FLAG_FMA4 = 0x800;
        
        /// <summary>AV_CPU_FLAG_FORCE = 0x80000000U</summary>
        public const uint AV_CPU_FLAG_FORCE = 0x80000000U;
        
        /// <summary>AV_CPU_FLAG_LASX = 0x1 &lt;&lt; 0x1</summary>
        public const int AV_CPU_FLAG_LASX = 0x1 << 0x1;
        
        /// <summary>AV_CPU_FLAG_LSX = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_CPU_FLAG_LSX = 0x1 << 0x0;
        
        /// <summary>AV_CPU_FLAG_MMI = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_CPU_FLAG_MMI = 0x1 << 0x0;
        
        /// <summary>AV_CPU_FLAG_MMX = 0x1</summary>
        public const int AV_CPU_FLAG_MMX = 0x1;
        
        /// <summary>AV_CPU_FLAG_MMX2 = 0x2</summary>
        public const int AV_CPU_FLAG_MMX2 = 0x2;
        
        /// <summary>AV_CPU_FLAG_MMXEXT = 0x2</summary>
        public const int AV_CPU_FLAG_MMXEXT = 0x2;
        
        /// <summary>AV_CPU_FLAG_MSA = 0x1 &lt;&lt; 0x1</summary>
        public const int AV_CPU_FLAG_MSA = 0x1 << 0x1;
        
        /// <summary>AV_CPU_FLAG_NEON = 0x1 &lt;&lt; 0x5</summary>
        public const int AV_CPU_FLAG_NEON = 0x1 << 0x5;
        
        /// <summary>AV_CPU_FLAG_POWER8 = 0x4</summary>
        public const int AV_CPU_FLAG_POWER8 = 0x4;
        
        /// <summary>AV_CPU_FLAG_SETEND = 0x1 &lt;&lt; 0x10</summary>
        public const int AV_CPU_FLAG_SETEND = 0x1 << 0x10;
        
        /// <summary>AV_CPU_FLAG_SLOW_GATHER = 0x2000000</summary>
        public const int AV_CPU_FLAG_SLOW_GATHER = 0x2000000;
        
        /// <summary>AV_CPU_FLAG_SSE = 0x8</summary>
        public const int AV_CPU_FLAG_SSE = 0x8;
        
        /// <summary>AV_CPU_FLAG_SSE2 = 0x10</summary>
        public const int AV_CPU_FLAG_SSE2 = 0x10;
        
        /// <summary>AV_CPU_FLAG_SSE2SLOW = 0x40000000</summary>
        public const int AV_CPU_FLAG_SSE2SLOW = 0x40000000;
        
        /// <summary>AV_CPU_FLAG_SSE3 = 0x40</summary>
        public const int AV_CPU_FLAG_SSE3 = 0x40;
        
        /// <summary>AV_CPU_FLAG_SSE3SLOW = 0x20000000</summary>
        public const int AV_CPU_FLAG_SSE3SLOW = 0x20000000;
        
        /// <summary>AV_CPU_FLAG_SSE4 = 0x100</summary>
        public const int AV_CPU_FLAG_SSE4 = 0x100;
        
        /// <summary>AV_CPU_FLAG_SSE42 = 0x200</summary>
        public const int AV_CPU_FLAG_SSE42 = 0x200;
        
        /// <summary>AV_CPU_FLAG_SSSE3 = 0x80</summary>
        public const int AV_CPU_FLAG_SSSE3 = 0x80;
        
        /// <summary>AV_CPU_FLAG_SSSE3SLOW = 0x4000000</summary>
        public const int AV_CPU_FLAG_SSSE3SLOW = 0x4000000;
        
        /// <summary>AV_CPU_FLAG_VFP = 0x1 &lt;&lt; 0x3</summary>
        public const int AV_CPU_FLAG_VFP = 0x1 << 0x3;
        
        /// <summary>AV_CPU_FLAG_VFP_VM = 0x1 &lt;&lt; 0x7</summary>
        public const int AV_CPU_FLAG_VFP_VM = 0x1 << 0x7;
        
        /// <summary>AV_CPU_FLAG_VFPV3 = 0x1 &lt;&lt; 0x4</summary>
        public const int AV_CPU_FLAG_VFPV3 = 0x1 << 0x4;
        
        /// <summary>AV_CPU_FLAG_VSX = 0x2</summary>
        public const int AV_CPU_FLAG_VSX = 0x2;
        
        /// <summary>AV_CPU_FLAG_XOP = 0x400</summary>
        public const int AV_CPU_FLAG_XOP = 0x400;
        
        /// <summary>AV_DICT_APPEND = 32</summary>
        public const int AV_DICT_APPEND = 0x20;
        
        /// <summary>AV_DICT_DONT_OVERWRITE = 16</summary>
        public const int AV_DICT_DONT_OVERWRITE = 0x10;
        
        /// <summary>AV_DICT_DONT_STRDUP_KEY = 4</summary>
        public const int AV_DICT_DONT_STRDUP_KEY = 0x4;
        
        /// <summary>AV_DICT_DONT_STRDUP_VAL = 8</summary>
        public const int AV_DICT_DONT_STRDUP_VAL = 0x8;
        
        /// <summary>AV_DICT_IGNORE_SUFFIX = 2</summary>
        public const int AV_DICT_IGNORE_SUFFIX = 0x2;
        
        /// <summary>AV_DICT_MATCH_CASE = 1</summary>
        public const int AV_DICT_MATCH_CASE = 0x1;
        
        /// <summary>AV_DICT_MULTIKEY = 64</summary>
        public const int AV_DICT_MULTIKEY = 0x40;
        
        /// <summary>AV_DISPOSITION_ATTACHED_PIC = (1 &lt;&lt; 10)</summary>
        public const int AV_DISPOSITION_ATTACHED_PIC = 0x1 << 0xa;
        
        /// <summary>AV_DISPOSITION_CAPTIONS = (1 &lt;&lt; 16)</summary>
        public const int AV_DISPOSITION_CAPTIONS = 0x1 << 0x10;
        
        /// <summary>AV_DISPOSITION_CLEAN_EFFECTS = (1 &lt;&lt; 9)</summary>
        public const int AV_DISPOSITION_CLEAN_EFFECTS = 0x1 << 0x9;
        
        /// <summary>AV_DISPOSITION_COMMENT = (1 &lt;&lt; 3)</summary>
        public const int AV_DISPOSITION_COMMENT = 0x1 << 0x3;
        
        /// <summary>AV_DISPOSITION_DEFAULT = (1 &lt;&lt; 0)</summary>
        public const int AV_DISPOSITION_DEFAULT = 0x1 << 0x0;
        
        /// <summary>AV_DISPOSITION_DEPENDENT = (1 &lt;&lt; 19)</summary>
        public const int AV_DISPOSITION_DEPENDENT = 0x1 << 0x13;
        
        /// <summary>AV_DISPOSITION_DESCRIPTIONS = (1 &lt;&lt; 17)</summary>
        public const int AV_DISPOSITION_DESCRIPTIONS = 0x1 << 0x11;
        
        /// <summary>AV_DISPOSITION_DUB = (1 &lt;&lt; 1)</summary>
        public const int AV_DISPOSITION_DUB = 0x1 << 0x1;
        
        /// <summary>AV_DISPOSITION_FORCED = (1 &lt;&lt; 6)</summary>
        public const int AV_DISPOSITION_FORCED = 0x1 << 0x6;
        
        /// <summary>AV_DISPOSITION_HEARING_IMPAIRED = (1 &lt;&lt; 7)</summary>
        public const int AV_DISPOSITION_HEARING_IMPAIRED = 0x1 << 0x7;
        
        /// <summary>AV_DISPOSITION_KARAOKE = (1 &lt;&lt; 5)</summary>
        public const int AV_DISPOSITION_KARAOKE = 0x1 << 0x5;
        
        /// <summary>AV_DISPOSITION_LYRICS = (1 &lt;&lt; 4)</summary>
        public const int AV_DISPOSITION_LYRICS = 0x1 << 0x4;
        
        /// <summary>AV_DISPOSITION_METADATA = (1 &lt;&lt; 18)</summary>
        public const int AV_DISPOSITION_METADATA = 0x1 << 0x12;
        
        /// <summary>AV_DISPOSITION_ORIGINAL = (1 &lt;&lt; 2)</summary>
        public const int AV_DISPOSITION_ORIGINAL = 0x1 << 0x2;
        
        /// <summary>AV_DISPOSITION_STILL_IMAGE = (1 &lt;&lt; 20)</summary>
        public const int AV_DISPOSITION_STILL_IMAGE = 0x1 << 0x14;
        
        /// <summary>AV_DISPOSITION_TIMED_THUMBNAILS = (1 &lt;&lt; 11)</summary>
        public const int AV_DISPOSITION_TIMED_THUMBNAILS = 0x1 << 0xb;
        
        /// <summary>AV_DISPOSITION_VISUAL_IMPAIRED = (1 &lt;&lt; 8)</summary>
        public const int AV_DISPOSITION_VISUAL_IMPAIRED = 0x1 << 0x8;
        
        /// <summary>AV_EF_AGGRESSIVE = 0x1 &lt;&lt; 0x12</summary>
        public const int AV_EF_AGGRESSIVE = 0x1 << 0x12;
        
        /// <summary>AV_EF_BITSTREAM = 0x1 &lt;&lt; 0x1</summary>
        public const int AV_EF_BITSTREAM = 0x1 << 0x1;
        
        /// <summary>AV_EF_BUFFER = 0x1 &lt;&lt; 0x2</summary>
        public const int AV_EF_BUFFER = 0x1 << 0x2;
        
        /// <summary>AV_EF_CAREFUL = 0x1 &lt;&lt; 0x10</summary>
        public const int AV_EF_CAREFUL = 0x1 << 0x10;
        
        /// <summary>AV_EF_COMPLIANT = 0x1 &lt;&lt; 0x11</summary>
        public const int AV_EF_COMPLIANT = 0x1 << 0x11;
        
        /// <summary>AV_EF_CRCCHECK = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_EF_CRCCHECK = 0x1 << 0x0;
        
        /// <summary>AV_EF_EXPLODE = 0x1 &lt;&lt; 0x3</summary>
        public const int AV_EF_EXPLODE = 0x1 << 0x3;
        
        /// <summary>AV_EF_IGNORE_ERR = 0x1 &lt;&lt; 0xf</summary>
        public const int AV_EF_IGNORE_ERR = 0x1 << 0xf;
        
        /// <summary>AV_ERROR_MAX_STRING_SIZE = 64</summary>
        public const int AV_ERROR_MAX_STRING_SIZE = 0x40;
        
        // public static av_extern_inline = inline;
        
        /// <summary>AV_FOURCC_MAX_STRING_SIZE = 32</summary>
        public const int AV_FOURCC_MAX_STRING_SIZE = 0x20;
        
        // public static av_fourcc2str = (fourcc) av_fourcc_make_string((char[AV_FOURCC_MAX_STRING_SIZE]){0}, fourcc);
        
        /// <summary>AV_FRAME_FILENAME_FLAGS_MULTIPLE = 1</summary>
        public const int AV_FRAME_FILENAME_FLAGS_MULTIPLE = 0x1;
        
        /// <summary>AV_FRAME_FLAG_CORRUPT = (1 &lt;&lt; 0)</summary>
        public const int AV_FRAME_FLAG_CORRUPT = 0x1 << 0x0;
        
        /// <summary>AV_FRAME_FLAG_DISCARD = (1 &lt;&lt; 2)</summary>
        public const int AV_FRAME_FLAG_DISCARD = 0x1 << 0x2;
        
        // public static AV_GCC_VERSION_AT_LEAST = (x,y) 0;
        
        // public static AV_GCC_VERSION_AT_MOST = (x,y)  0;
        
        /// <summary>AV_GET_BUFFER_FLAG_REF = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_GET_BUFFER_FLAG_REF = 0x1 << 0x0;
        
        /// <summary>AV_GET_ENCODE_BUFFER_FLAG_REF = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_GET_ENCODE_BUFFER_FLAG_REF = 0x1 << 0x0;
        
        // public static AV_GLUE = (a, b) a ## b;
        
        // public static AV_HAS_BUILTIN = (x)(__has_builtin(x));
        
        /// <summary>AV_HAVE_BIGENDIAN = 0</summary>
        public const int AV_HAVE_BIGENDIAN = 0x0;
        
        /// <summary>AV_HAVE_FAST_UNALIGNED = 1</summary>
        public const int AV_HAVE_FAST_UNALIGNED = 0x1;
        
        /// <summary>AV_HWACCEL_CODEC_CAP_EXPERIMENTAL = 0x200</summary>
        public const int AV_HWACCEL_CODEC_CAP_EXPERIMENTAL = 0x200;
        
        /// <summary>AV_HWACCEL_FLAG_ALLOW_HIGH_DEPTH = 0x1 &lt;&lt; 0x1</summary>
        public const int AV_HWACCEL_FLAG_ALLOW_HIGH_DEPTH = 0x1 << 0x1;
        
        /// <summary>AV_HWACCEL_FLAG_ALLOW_PROFILE_MISMATCH = 0x1 &lt;&lt; 0x2</summary>
        public const int AV_HWACCEL_FLAG_ALLOW_PROFILE_MISMATCH = 0x1 << 0x2;
        
        /// <summary>AV_HWACCEL_FLAG_IGNORE_LEVEL = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_HWACCEL_FLAG_IGNORE_LEVEL = 0x1 << 0x0;
        
        /// <summary>AV_INPUT_BUFFER_MIN_SIZE = 0x4000</summary>
        public const int AV_INPUT_BUFFER_MIN_SIZE = 0x4000;
        
        /// <summary>AV_INPUT_BUFFER_PADDING_SIZE = 64</summary>
        public const int AV_INPUT_BUFFER_PADDING_SIZE = 0x40;
        
        // public static av_int_list_length = (list, term) av_int_list_length_for_size(sizeof(*(list)), list, term);
        
        // public static AV_IS_INPUT_DEVICE = (category)((category)(==AV_CLASS_CATEGORY_DEVICE_VIDEO_INPUT) || (category)(==AV_CLASS_CATEGORY_DEVICE_AUDIO_INPUT) || (category)(==AV_CLASS_CATEGORY_DEVICE_INPUT));
        
        // public static AV_IS_OUTPUT_DEVICE = (category)((category)(==AV_CLASS_CATEGORY_DEVICE_VIDEO_OUTPUT) || (category)(==AV_CLASS_CATEGORY_DEVICE_AUDIO_OUTPUT) || (category)(==AV_CLASS_CATEGORY_DEVICE_OUTPUT));
        
        // public static AV_JOIN = (a, b) AV_GLUE(a, b);
        
        // public static AV_LOG_C = (x)((x)(<<0x8));
        
        /// <summary>AV_LOG_DEBUG = 48</summary>
        public const int AV_LOG_DEBUG = 0x30;
        
        /// <summary>AV_LOG_ERROR = 16</summary>
        public const int AV_LOG_ERROR = 0x10;
        
        /// <summary>AV_LOG_FATAL = 8</summary>
        public const int AV_LOG_FATAL = 0x8;
        
        /// <summary>AV_LOG_INFO = 32</summary>
        public const int AV_LOG_INFO = 0x20;
        
        /// <summary>AV_LOG_MAX_OFFSET = (AV_LOG_TRACE - AV_LOG_QUIET)</summary>
        public const int AV_LOG_MAX_OFFSET = AV_LOG_TRACE - AV_LOG_QUIET;
        
        /// <summary>AV_LOG_PANIC = 0</summary>
        public const int AV_LOG_PANIC = 0x0;
        
        /// <summary>AV_LOG_PRINT_LEVEL = 2</summary>
        public const int AV_LOG_PRINT_LEVEL = 0x2;
        
        /// <summary>AV_LOG_QUIET = -8</summary>
        public const int AV_LOG_QUIET = -0x8;
        
        /// <summary>AV_LOG_SKIP_REPEATED = 1</summary>
        public const int AV_LOG_SKIP_REPEATED = 0x1;
        
        /// <summary>AV_LOG_TRACE = 56</summary>
        public const int AV_LOG_TRACE = 0x38;
        
        /// <summary>AV_LOG_VERBOSE = 40</summary>
        public const int AV_LOG_VERBOSE = 0x28;
        
        /// <summary>AV_LOG_WARNING = 24</summary>
        public const int AV_LOG_WARNING = 0x18;
        
        // public static av_mod_uintp2 = av_mod_uintp2_c;
        
        // public static AV_NE = (be, le) (le);
        
        // public static av_noinline = __declspec(noinline);
        
        /// <summary>AV_NOPTS_VALUE = ((int64_t)UINT64_C(0x8000000000000000))</summary>
        public static readonly long AV_NOPTS_VALUE = (long)(UINT64_C(0x8000000000000000L));
        
        // public static av_noreturn = __attribute__((noreturn));
        
        // public static AV_NOWARN_DEPRECATED = (code) __pragma(warning(push)) __pragma(warning(disable : 4996)) code; __pragma(warning(pop));
        
        /// <summary>AV_NUM_DATA_POINTERS = 8</summary>
        public const int AV_NUM_DATA_POINTERS = 0x8;
        
        /// <summary>AV_OPT_ALLOW_NULL = (1 &lt;&lt; 2)</summary>
        public const int AV_OPT_ALLOW_NULL = 0x1 << 0x2;
        
        /// <summary>AV_OPT_FLAG_AUDIO_PARAM = 8</summary>
        public const int AV_OPT_FLAG_AUDIO_PARAM = 0x8;
        
        /// <summary>AV_OPT_FLAG_BSF_PARAM = (1&lt;&lt;8)</summary>
        public const int AV_OPT_FLAG_BSF_PARAM = 0x1 << 0x8;
        
        /// <summary>AV_OPT_FLAG_CHILD_CONSTS = (1&lt;&lt;18)</summary>
        public const int AV_OPT_FLAG_CHILD_CONSTS = 0x1 << 0x12;
        
        /// <summary>AV_OPT_FLAG_DECODING_PARAM = 2</summary>
        public const int AV_OPT_FLAG_DECODING_PARAM = 0x2;
        
        /// <summary>AV_OPT_FLAG_DEPRECATED = (1&lt;&lt;17)</summary>
        public const int AV_OPT_FLAG_DEPRECATED = 0x1 << 0x11;
        
        /// <summary>AV_OPT_FLAG_ENCODING_PARAM = 1</summary>
        public const int AV_OPT_FLAG_ENCODING_PARAM = 0x1;
        
        /// <summary>AV_OPT_FLAG_EXPORT = 64</summary>
        public const int AV_OPT_FLAG_EXPORT = 0x40;
        
        /// <summary>AV_OPT_FLAG_FILTERING_PARAM = (1&lt;&lt;16)</summary>
        public const int AV_OPT_FLAG_FILTERING_PARAM = 0x1 << 0x10;
        
        /// <summary>AV_OPT_FLAG_READONLY = 128</summary>
        public const int AV_OPT_FLAG_READONLY = 0x80;
        
        /// <summary>AV_OPT_FLAG_RUNTIME_PARAM = (1&lt;&lt;15)</summary>
        public const int AV_OPT_FLAG_RUNTIME_PARAM = 0x1 << 0xf;
        
        /// <summary>AV_OPT_FLAG_SUBTITLE_PARAM = 32</summary>
        public const int AV_OPT_FLAG_SUBTITLE_PARAM = 0x20;
        
        /// <summary>AV_OPT_FLAG_VIDEO_PARAM = 16</summary>
        public const int AV_OPT_FLAG_VIDEO_PARAM = 0x10;
        
        /// <summary>AV_OPT_MULTI_COMPONENT_RANGE = (1 &lt;&lt; 12)</summary>
        public const int AV_OPT_MULTI_COMPONENT_RANGE = 0x1 << 0xc;
        
        /// <summary>AV_OPT_SEARCH_CHILDREN = (1 &lt;&lt; 0)</summary>
        public const int AV_OPT_SEARCH_CHILDREN = 0x1 << 0x0;
        
        /// <summary>AV_OPT_SEARCH_FAKE_OBJ = (1 &lt;&lt; 1)</summary>
        public const int AV_OPT_SEARCH_FAKE_OBJ = 0x1 << 0x1;
        
        /// <summary>AV_OPT_SERIALIZE_OPT_FLAGS_EXACT = 0x00000002</summary>
        public const int AV_OPT_SERIALIZE_OPT_FLAGS_EXACT = 0x2;
        
        /// <summary>AV_OPT_SERIALIZE_SKIP_DEFAULTS = 0x00000001</summary>
        public const int AV_OPT_SERIALIZE_SKIP_DEFAULTS = 0x1;
        
        // public static av_opt_set_int_list = (obj, name, val, term, flags) (av_int_list_length(val, term) > INT_MAX / sizeof(*(val)) ? AVERROR(EINVAL) : av_opt_set_bin(obj, name, (const uint8_t *)(val), av_int_list_length(val, term) * sizeof(*(val)), flags));
        
        // public static av_parity = av_parity_c;
        
        /// <summary>AV_PARSER_PTS_NB = 0x4</summary>
        public const int AV_PARSER_PTS_NB = 0x4;
        
        // public static AV_PIX_FMT_0BGR32 = AV_PIX_FMT_NE(0BGR, RGB0);
        
        // public static AV_PIX_FMT_0RGB32 = AV_PIX_FMT_NE(0RGB, BGR0);
        
        // public static AV_PIX_FMT_AYUV64 = AV_PIX_FMT_NE(AYUV64BE, AYUV64LE);
        
        // public static AV_PIX_FMT_BAYER_BGGR16 = AV_PIX_FMT_NE(BAYER_BGGR16BE,    BAYER_BGGR16LE);
        
        // public static AV_PIX_FMT_BAYER_GBRG16 = AV_PIX_FMT_NE(BAYER_GBRG16BE,    BAYER_GBRG16LE);
        
        // public static AV_PIX_FMT_BAYER_GRBG16 = AV_PIX_FMT_NE(BAYER_GRBG16BE,    BAYER_GRBG16LE);
        
        // public static AV_PIX_FMT_BAYER_RGGB16 = AV_PIX_FMT_NE(BAYER_RGGB16BE,    BAYER_RGGB16LE);
        
        // public static AV_PIX_FMT_BGR32 = AV_PIX_FMT_NE(ABGR, RGBA);
        
        // public static AV_PIX_FMT_BGR32_1 = AV_PIX_FMT_NE(BGRA, ARGB);
        
        // public static AV_PIX_FMT_BGR444 = AV_PIX_FMT_NE(BGR444BE, BGR444LE);
        
        // public static AV_PIX_FMT_BGR48 = AV_PIX_FMT_NE(BGR48BE,  BGR48LE);
        
        // public static AV_PIX_FMT_BGR555 = AV_PIX_FMT_NE(BGR555BE, BGR555LE);
        
        // public static AV_PIX_FMT_BGR565 = AV_PIX_FMT_NE(BGR565BE, BGR565LE);
        
        // public static AV_PIX_FMT_BGRA64 = AV_PIX_FMT_NE(BGRA64BE, BGRA64LE);
        
        /// <summary>AV_PIX_FMT_FLAG_ALPHA = 0x1 &lt;&lt; 0x7</summary>
        public const int AV_PIX_FMT_FLAG_ALPHA = 0x1 << 0x7;
        
        /// <summary>AV_PIX_FMT_FLAG_BAYER = 0x1 &lt;&lt; 0x8</summary>
        public const int AV_PIX_FMT_FLAG_BAYER = 0x1 << 0x8;
        
        /// <summary>AV_PIX_FMT_FLAG_BE = 0x1 &lt;&lt; 0x0</summary>
        public const int AV_PIX_FMT_FLAG_BE = 0x1 << 0x0;
        
        /// <summary>AV_PIX_FMT_FLAG_BITSTREAM = 0x1 &lt;&lt; 0x2</summary>
        public const int AV_PIX_FMT_FLAG_BITSTREAM = 0x1 << 0x2;
        
        /// <summary>AV_PIX_FMT_FLAG_FLOAT = 0x1 &lt;&lt; 0x9</summary>
        public const int AV_PIX_FMT_FLAG_FLOAT = 0x1 << 0x9;
        
        /// <summary>AV_PIX_FMT_FLAG_HWACCEL = 0x1 &lt;&lt; 0x3</summary>
        public const int AV_PIX_FMT_FLAG_HWACCEL = 0x1 << 0x3;
        
        /// <summary>AV_PIX_FMT_FLAG_PAL = 0x1 &lt;&lt; 0x1</summary>
        public const int AV_PIX_FMT_FLAG_PAL = 0x1 << 0x1;
        
        /// <summary>AV_PIX_FMT_FLAG_PLANAR = 0x1 &lt;&lt; 0x4</summary>
        public const int AV_PIX_FMT_FLAG_PLANAR = 0x1 << 0x4;
        
        /// <summary>AV_PIX_FMT_FLAG_RGB = 0x1 &lt;&lt; 0x5</summary>
        public const int AV_PIX_FMT_FLAG_RGB = 0x1 << 0x5;
        
        // public static AV_PIX_FMT_GBRAP10 = AV_PIX_FMT_NE(GBRAP10BE,   GBRAP10LE);
        
        // public static AV_PIX_FMT_GBRAP12 = AV_PIX_FMT_NE(GBRAP12BE,   GBRAP12LE);
        
        // public static AV_PIX_FMT_GBRAP16 = AV_PIX_FMT_NE(GBRAP16BE,   GBRAP16LE);
        
        // public static AV_PIX_FMT_GBRAPF32 = AV_PIX_FMT_NE(GBRAPF32BE, GBRAPF32LE);
        
        // public static AV_PIX_FMT_GBRP10 = AV_PIX_FMT_NE(GBRP10BE,    GBRP10LE);
        
        // public static AV_PIX_FMT_GBRP12 = AV_PIX_FMT_NE(GBRP12BE,    GBRP12LE);
        
        // public static AV_PIX_FMT_GBRP14 = AV_PIX_FMT_NE(GBRP14BE,    GBRP14LE);
        
        // public static AV_PIX_FMT_GBRP16 = AV_PIX_FMT_NE(GBRP16BE,    GBRP16LE);
        
        // public static AV_PIX_FMT_GBRP9 = AV_PIX_FMT_NE(GBRP9BE ,    GBRP9LE);
        
        // public static AV_PIX_FMT_GBRPF32 = AV_PIX_FMT_NE(GBRPF32BE,  GBRPF32LE);
        
        // public static AV_PIX_FMT_GRAY10 = AV_PIX_FMT_NE(GRAY10BE, GRAY10LE);
        
        // public static AV_PIX_FMT_GRAY12 = AV_PIX_FMT_NE(GRAY12BE, GRAY12LE);
        
        // public static AV_PIX_FMT_GRAY14 = AV_PIX_FMT_NE(GRAY14BE, GRAY14LE);
        
        // public static AV_PIX_FMT_GRAY16 = AV_PIX_FMT_NE(GRAY16BE, GRAY16LE);
        
        // public static AV_PIX_FMT_GRAY9 = AV_PIX_FMT_NE(GRAY9BE,  GRAY9LE);
        
        // public static AV_PIX_FMT_GRAYF32 = AV_PIX_FMT_NE(GRAYF32BE, GRAYF32LE);
        
        // public static AV_PIX_FMT_NE = (be, le) AV_PIX_FMT_##le;
        
        // public static AV_PIX_FMT_NV20 = AV_PIX_FMT_NE(NV20BE,  NV20LE);
        
        // public static AV_PIX_FMT_P010 = AV_PIX_FMT_NE(P010BE,  P010LE);
        
        // public static AV_PIX_FMT_P016 = AV_PIX_FMT_NE(P016BE,  P016LE);
        
        // public static AV_PIX_FMT_P210 = AV_PIX_FMT_NE(P210BE, P210LE);
        
        // public static AV_PIX_FMT_P216 = AV_PIX_FMT_NE(P216BE, P216LE);
        
        // public static AV_PIX_FMT_P410 = AV_PIX_FMT_NE(P410BE, P410LE);
        
        // public static AV_PIX_FMT_P416 = AV_PIX_FMT_NE(P416BE, P416LE);
        
        // public static AV_PIX_FMT_RGB32 = AV_PIX_FMT_NE(ARGB, BGRA);
        
        // public static AV_PIX_FMT_RGB32_1 = AV_PIX_FMT_NE(RGBA, ABGR);
        
        // public static AV_PIX_FMT_RGB444 = AV_PIX_FMT_NE(RGB444BE, RGB444LE);
        
        // public static AV_PIX_FMT_RGB48 = AV_PIX_FMT_NE(RGB48BE,  RGB48LE);
        
        // public static AV_PIX_FMT_RGB555 = AV_PIX_FMT_NE(RGB555BE, RGB555LE);
        
        // public static AV_PIX_FMT_RGB565 = AV_PIX_FMT_NE(RGB565BE, RGB565LE);
        
        // public static AV_PIX_FMT_RGBA64 = AV_PIX_FMT_NE(RGBA64BE, RGBA64LE);
        
        // public static AV_PIX_FMT_X2BGR10 = AV_PIX_FMT_NE(X2BGR10BE, X2BGR10LE);
        
        // public static AV_PIX_FMT_X2RGB10 = AV_PIX_FMT_NE(X2RGB10BE, X2RGB10LE);
        
        // public static AV_PIX_FMT_XYZ12 = AV_PIX_FMT_NE(XYZ12BE, XYZ12LE);
        
        // public static AV_PIX_FMT_Y210 = AV_PIX_FMT_NE(Y210BE,  Y210LE);
        
        // public static AV_PIX_FMT_YA16 = AV_PIX_FMT_NE(YA16BE,   YA16LE);
        
        // public static AV_PIX_FMT_YUV420P10 = AV_PIX_FMT_NE(YUV420P10BE, YUV420P10LE);
        
        // public static AV_PIX_FMT_YUV420P12 = AV_PIX_FMT_NE(YUV420P12BE, YUV420P12LE);
        
        // public static AV_PIX_FMT_YUV420P14 = AV_PIX_FMT_NE(YUV420P14BE, YUV420P14LE);
        
        // public static AV_PIX_FMT_YUV420P16 = AV_PIX_FMT_NE(YUV420P16BE, YUV420P16LE);
        
        // public static AV_PIX_FMT_YUV420P9 = AV_PIX_FMT_NE(YUV420P9BE , YUV420P9LE);
        
        // public static AV_PIX_FMT_YUV422P10 = AV_PIX_FMT_NE(YUV422P10BE, YUV422P10LE);
        
        // public static AV_PIX_FMT_YUV422P12 = AV_PIX_FMT_NE(YUV422P12BE, YUV422P12LE);
        
        // public static AV_PIX_FMT_YUV422P14 = AV_PIX_FMT_NE(YUV422P14BE, YUV422P14LE);
        
        // public static AV_PIX_FMT_YUV422P16 = AV_PIX_FMT_NE(YUV422P16BE, YUV422P16LE);
        
        // public static AV_PIX_FMT_YUV422P9 = AV_PIX_FMT_NE(YUV422P9BE , YUV422P9LE);
        
        // public static AV_PIX_FMT_YUV440P10 = AV_PIX_FMT_NE(YUV440P10BE, YUV440P10LE);
        
        // public static AV_PIX_FMT_YUV440P12 = AV_PIX_FMT_NE(YUV440P12BE, YUV440P12LE);
        
        // public static AV_PIX_FMT_YUV444P10 = AV_PIX_FMT_NE(YUV444P10BE, YUV444P10LE);
        
        // public static AV_PIX_FMT_YUV444P12 = AV_PIX_FMT_NE(YUV444P12BE, YUV444P12LE);
        
        // public static AV_PIX_FMT_YUV444P14 = AV_PIX_FMT_NE(YUV444P14BE, YUV444P14LE);
        
        // public static AV_PIX_FMT_YUV444P16 = AV_PIX_FMT_NE(YUV444P16BE, YUV444P16LE);
        
        // public static AV_PIX_FMT_YUV444P9 = AV_PIX_FMT_NE(YUV444P9BE , YUV444P9LE);
        
        // public static AV_PIX_FMT_YUVA420P10 = AV_PIX_FMT_NE(YUVA420P10BE, YUVA420P10LE);
        
        // public static AV_PIX_FMT_YUVA420P16 = AV_PIX_FMT_NE(YUVA420P16BE, YUVA420P16LE);
        
        // public static AV_PIX_FMT_YUVA420P9 = AV_PIX_FMT_NE(YUVA420P9BE , YUVA420P9LE);
        
        // public static AV_PIX_FMT_YUVA422P10 = AV_PIX_FMT_NE(YUVA422P10BE, YUVA422P10LE);
        
        // public static AV_PIX_FMT_YUVA422P12 = AV_PIX_FMT_NE(YUVA422P12BE, YUVA422P12LE);
        
        // public static AV_PIX_FMT_YUVA422P16 = AV_PIX_FMT_NE(YUVA422P16BE, YUVA422P16LE);
        
        // public static AV_PIX_FMT_YUVA422P9 = AV_PIX_FMT_NE(YUVA422P9BE , YUVA422P9LE);
        
        // public static AV_PIX_FMT_YUVA444P10 = AV_PIX_FMT_NE(YUVA444P10BE, YUVA444P10LE);
        
        // public static AV_PIX_FMT_YUVA444P12 = AV_PIX_FMT_NE(YUVA444P12BE, YUVA444P12LE);
        
        // public static AV_PIX_FMT_YUVA444P16 = AV_PIX_FMT_NE(YUVA444P16BE, YUVA444P16LE);
        
        // public static AV_PIX_FMT_YUVA444P9 = AV_PIX_FMT_NE(YUVA444P9BE , YUVA444P9LE);
        
        // public static AV_PKT_DATA_QUALITY_FACTOR = AV_PKT_DATA_QUALITY_STATS;
        
        /// <summary>AV_PKT_FLAG_CORRUPT = 0x0002</summary>
        public const int AV_PKT_FLAG_CORRUPT = 0x2;
        
        /// <summary>AV_PKT_FLAG_DISCARD = 0x0004</summary>
        public const int AV_PKT_FLAG_DISCARD = 0x4;
        
        /// <summary>AV_PKT_FLAG_DISPOSABLE = 0x0010</summary>
        public const int AV_PKT_FLAG_DISPOSABLE = 0x10;
        
        /// <summary>AV_PKT_FLAG_KEY = 0x0001</summary>
        public const int AV_PKT_FLAG_KEY = 0x1;
        
        /// <summary>AV_PKT_FLAG_TRUSTED = 0x0008</summary>
        public const int AV_PKT_FLAG_TRUSTED = 0x8;
        
        // public static av_popcount = av_popcount_c;
        
        // public static av_popcount64 = av_popcount64_c;
        
        // public static AV_PRAGMA = (s) _Pragma(#s);
        
        // public static av_printf_format = (fmtpos, attrpos) __attribute__((__format__(__printf__, fmtpos, attrpos)));
        
        /// <summary>AV_PROGRAM_RUNNING = 1</summary>
        public const int AV_PROGRAM_RUNNING = 0x1;
        
        /// <summary>AV_PTS_WRAP_ADD_OFFSET = 1</summary>
        public const int AV_PTS_WRAP_ADD_OFFSET = 0x1;
        
        /// <summary>AV_PTS_WRAP_IGNORE = 0</summary>
        public const int AV_PTS_WRAP_IGNORE = 0x0;
        
        /// <summary>AV_PTS_WRAP_SUB_OFFSET = -1</summary>
        public const int AV_PTS_WRAP_SUB_OFFSET = -0x1;
        
        // public static av_pure = __attribute__((pure));
        
        // public static av_sat_add32 = av_sat_add32_c;
        
        // public static av_sat_add64 = av_sat_add64_c;
        
        // public static av_sat_dadd32 = av_sat_dadd32_c;
        
        // public static av_sat_dsub32 = av_sat_dsub32_c;
        
        // public static av_sat_sub32 = av_sat_sub32_c;
        
        // public static av_sat_sub64 = av_sat_sub64_c;
        
        // public static AV_STRINGIFY = (s)(AV_TOSTRING(s));
        
        /// <summary>AV_SUBTITLE_FLAG_FORCED = 0x1</summary>
        public const int AV_SUBTITLE_FLAG_FORCED = 0x1;
        
        /// <summary>AV_TIME_BASE = 1000000</summary>
        public const int AV_TIME_BASE = 0xf4240;
        
        // public static AV_TIME_BASE_Q = (AVRational){1, AV_TIME_BASE};
        
        /// <summary>AV_TIMECODE_STR_SIZE = 0x17</summary>
        public const int AV_TIMECODE_STR_SIZE = 0x17;
        
        // public static AV_TOSTRING = (s) #s;
        
        // public static av_uninit = (x) x=x;
        
        // public static av_unused = __attribute__((unused));
        
        // public static av_used = __attribute__((used));
        
        // public static AV_VERSION = (a, b, c) AV_VERSION_DOT(a, b, c);
        
        // public static AV_VERSION_DOT = (a, b, c) a ##.## b ##.## c;
        
        // public static AV_VERSION_INT = (a, b, c) ((a)<<16 | (b)<<8 | (c));
        
        // public static AV_VERSION_MAJOR = (a)((a)(>>0x10));
        
        // public static AV_VERSION_MICRO = (a)((a)(&0xff));
        
        // public static AV_VERSION_MINOR = (a)((a)(&0xff00) >> 0x8);
        
        // public static AVERROR = (e) (-(e));
        
        /// <summary>AVERROR_BSF_NOT_FOUND = FFERRTAG(0xF8,&apos;B&apos;,&apos;S&apos;,&apos;F&apos;)</summary>
        public static readonly int AVERROR_BSF_NOT_FOUND = FFERRTAG(0xf8, 'B', 'S', 'F');
        
        /// <summary>AVERROR_BUFFER_TOO_SMALL = FFERRTAG( &apos;B&apos;,&apos;U&apos;,&apos;F&apos;,&apos;S&apos;)</summary>
        public static readonly int AVERROR_BUFFER_TOO_SMALL = FFERRTAG('B', 'U', 'F', 'S');
        
        /// <summary>AVERROR_BUG = FFERRTAG( &apos;B&apos;,&apos;U&apos;,&apos;G&apos;,&apos;!&apos;)</summary>
        public static readonly int AVERROR_BUG = FFERRTAG('B', 'U', 'G', '!');
        
        /// <summary>AVERROR_BUG2 = FFERRTAG( &apos;B&apos;,&apos;U&apos;,&apos;G&apos;,&apos; &apos;)</summary>
        public static readonly int AVERROR_BUG2 = FFERRTAG('B', 'U', 'G', ' ');
        
        /// <summary>AVERROR_DECODER_NOT_FOUND = FFERRTAG(0xF8,&apos;D&apos;,&apos;E&apos;,&apos;C&apos;)</summary>
        public static readonly int AVERROR_DECODER_NOT_FOUND = FFERRTAG(0xf8, 'D', 'E', 'C');
        
        /// <summary>AVERROR_DEMUXER_NOT_FOUND = FFERRTAG(0xF8,&apos;D&apos;,&apos;E&apos;,&apos;M&apos;)</summary>
        public static readonly int AVERROR_DEMUXER_NOT_FOUND = FFERRTAG(0xf8, 'D', 'E', 'M');
        
        /// <summary>AVERROR_ENCODER_NOT_FOUND = FFERRTAG(0xF8,&apos;E&apos;,&apos;N&apos;,&apos;C&apos;)</summary>
        public static readonly int AVERROR_ENCODER_NOT_FOUND = FFERRTAG(0xf8, 'E', 'N', 'C');
        
        /// <summary>AVERROR_EOF = FFERRTAG( &apos;E&apos;,&apos;O&apos;,&apos;F&apos;,&apos; &apos;)</summary>
        public static readonly int AVERROR_EOF = FFERRTAG('E', 'O', 'F', ' ');
        
        /// <summary>AVERROR_EXIT = FFERRTAG( &apos;E&apos;,&apos;X&apos;,&apos;I&apos;,&apos;T&apos;)</summary>
        public static readonly int AVERROR_EXIT = FFERRTAG('E', 'X', 'I', 'T');
        
        /// <summary>AVERROR_EXPERIMENTAL = (-0x2bb2afa8)</summary>
        public const int AVERROR_EXPERIMENTAL = -0x2bb2afa8;
        
        /// <summary>AVERROR_EXTERNAL = FFERRTAG( &apos;E&apos;,&apos;X&apos;,&apos;T&apos;,&apos; &apos;)</summary>
        public static readonly int AVERROR_EXTERNAL = FFERRTAG('E', 'X', 'T', ' ');
        
        /// <summary>AVERROR_FILTER_NOT_FOUND = FFERRTAG(0xF8,&apos;F&apos;,&apos;I&apos;,&apos;L&apos;)</summary>
        public static readonly int AVERROR_FILTER_NOT_FOUND = FFERRTAG(0xf8, 'F', 'I', 'L');
        
        /// <summary>AVERROR_HTTP_BAD_REQUEST = FFERRTAG(0xF8,&apos;4&apos;,&apos;0&apos;,&apos;0&apos;)</summary>
        public static readonly int AVERROR_HTTP_BAD_REQUEST = FFERRTAG(0xf8, '4', '0', '0');
        
        /// <summary>AVERROR_HTTP_FORBIDDEN = FFERRTAG(0xF8,&apos;4&apos;,&apos;0&apos;,&apos;3&apos;)</summary>
        public static readonly int AVERROR_HTTP_FORBIDDEN = FFERRTAG(0xf8, '4', '0', '3');
        
        /// <summary>AVERROR_HTTP_NOT_FOUND = FFERRTAG(0xF8,&apos;4&apos;,&apos;0&apos;,&apos;4&apos;)</summary>
        public static readonly int AVERROR_HTTP_NOT_FOUND = FFERRTAG(0xf8, '4', '0', '4');
        
        /// <summary>AVERROR_HTTP_OTHER_4XX = FFERRTAG(0xF8,&apos;4&apos;,&apos;X&apos;,&apos;X&apos;)</summary>
        public static readonly int AVERROR_HTTP_OTHER_4XX = FFERRTAG(0xf8, '4', 'X', 'X');
        
        /// <summary>AVERROR_HTTP_SERVER_ERROR = FFERRTAG(0xF8,&apos;5&apos;,&apos;X&apos;,&apos;X&apos;)</summary>
        public static readonly int AVERROR_HTTP_SERVER_ERROR = FFERRTAG(0xf8, '5', 'X', 'X');
        
        /// <summary>AVERROR_HTTP_UNAUTHORIZED = FFERRTAG(0xF8,&apos;4&apos;,&apos;0&apos;,&apos;1&apos;)</summary>
        public static readonly int AVERROR_HTTP_UNAUTHORIZED = FFERRTAG(0xf8, '4', '0', '1');
        
        /// <summary>AVERROR_INPUT_CHANGED = (-0x636e6701)</summary>
        public const int AVERROR_INPUT_CHANGED = -0x636e6701;
        
        /// <summary>AVERROR_INVALIDDATA = FFERRTAG( &apos;I&apos;,&apos;N&apos;,&apos;D&apos;,&apos;A&apos;)</summary>
        public static readonly int AVERROR_INVALIDDATA = FFERRTAG('I', 'N', 'D', 'A');
        
        /// <summary>AVERROR_MUXER_NOT_FOUND = FFERRTAG(0xF8,&apos;M&apos;,&apos;U&apos;,&apos;X&apos;)</summary>
        public static readonly int AVERROR_MUXER_NOT_FOUND = FFERRTAG(0xf8, 'M', 'U', 'X');
        
        /// <summary>AVERROR_OPTION_NOT_FOUND = FFERRTAG(0xF8,&apos;O&apos;,&apos;P&apos;,&apos;T&apos;)</summary>
        public static readonly int AVERROR_OPTION_NOT_FOUND = FFERRTAG(0xf8, 'O', 'P', 'T');
        
        /// <summary>AVERROR_OUTPUT_CHANGED = (-0x636e6702)</summary>
        public const int AVERROR_OUTPUT_CHANGED = -0x636e6702;
        
        /// <summary>AVERROR_PATCHWELCOME = FFERRTAG( &apos;P&apos;,&apos;A&apos;,&apos;W&apos;,&apos;E&apos;)</summary>
        public static readonly int AVERROR_PATCHWELCOME = FFERRTAG('P', 'A', 'W', 'E');
        
        /// <summary>AVERROR_PROTOCOL_NOT_FOUND = FFERRTAG(0xF8,&apos;P&apos;,&apos;R&apos;,&apos;O&apos;)</summary>
        public static readonly int AVERROR_PROTOCOL_NOT_FOUND = FFERRTAG(0xf8, 'P', 'R', 'O');
        
        /// <summary>AVERROR_STREAM_NOT_FOUND = FFERRTAG(0xF8,&apos;S&apos;,&apos;T&apos;,&apos;R&apos;)</summary>
        public static readonly int AVERROR_STREAM_NOT_FOUND = FFERRTAG(0xf8, 'S', 'T', 'R');
        
        /// <summary>AVERROR_UNKNOWN = FFERRTAG( &apos;U&apos;,&apos;N&apos;,&apos;K&apos;,&apos;N&apos;)</summary>
        public static readonly int AVERROR_UNKNOWN = FFERRTAG('U', 'N', 'K', 'N');
        
        /// <summary>AVFILTER_CMD_FLAG_FAST = 0x2</summary>
        public const int AVFILTER_CMD_FLAG_FAST = 0x2;
        
        /// <summary>AVFILTER_CMD_FLAG_ONE = 0x1</summary>
        public const int AVFILTER_CMD_FLAG_ONE = 0x1;
        
        /// <summary>AVFILTER_FLAG_DYNAMIC_INPUTS = 0x1 &lt;&lt; 0x0</summary>
        public const int AVFILTER_FLAG_DYNAMIC_INPUTS = 0x1 << 0x0;
        
        /// <summary>AVFILTER_FLAG_DYNAMIC_OUTPUTS = 0x1 &lt;&lt; 0x1</summary>
        public const int AVFILTER_FLAG_DYNAMIC_OUTPUTS = 0x1 << 0x1;
        
        /// <summary>AVFILTER_FLAG_METADATA_ONLY = 0x1 &lt;&lt; 0x3</summary>
        public const int AVFILTER_FLAG_METADATA_ONLY = 0x1 << 0x3;
        
        /// <summary>AVFILTER_FLAG_SLICE_THREADS = 0x1 &lt;&lt; 0x2</summary>
        public const int AVFILTER_FLAG_SLICE_THREADS = 0x1 << 0x2;
        
        /// <summary>AVFILTER_FLAG_SUPPORT_TIMELINE = AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC | AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL</summary>
        public const int AVFILTER_FLAG_SUPPORT_TIMELINE = AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC | AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL;
        
        /// <summary>AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC = 0x1 &lt;&lt; 0x10</summary>
        public const int AVFILTER_FLAG_SUPPORT_TIMELINE_GENERIC = 0x1 << 0x10;
        
        /// <summary>AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL = 0x1 &lt;&lt; 0x11</summary>
        public const int AVFILTER_FLAG_SUPPORT_TIMELINE_INTERNAL = 0x1 << 0x11;
        
        /// <summary>AVFILTER_THREAD_SLICE = 0x1 &lt;&lt; 0x0</summary>
        public const int AVFILTER_THREAD_SLICE = 0x1 << 0x0;
        
        /// <summary>AVFMT_ALLOW_FLUSH = 0x10000</summary>
        public const int AVFMT_ALLOW_FLUSH = 0x10000;
        
        /// <summary>AVFMT_AVOID_NEG_TS_AUTO = -1</summary>
        public const int AVFMT_AVOID_NEG_TS_AUTO = -0x1;
        
        /// <summary>AVFMT_AVOID_NEG_TS_MAKE_NON_NEGATIVE = 1</summary>
        public const int AVFMT_AVOID_NEG_TS_MAKE_NON_NEGATIVE = 0x1;
        
        /// <summary>AVFMT_AVOID_NEG_TS_MAKE_ZERO = 2</summary>
        public const int AVFMT_AVOID_NEG_TS_MAKE_ZERO = 0x2;
        
        /// <summary>AVFMT_EVENT_FLAG_METADATA_UPDATED = 0x0001</summary>
        public const int AVFMT_EVENT_FLAG_METADATA_UPDATED = 0x1;
        
        /// <summary>AVFMT_EXPERIMENTAL = 0x0004</summary>
        public const int AVFMT_EXPERIMENTAL = 0x4;
        
        /// <summary>AVFMT_FLAG_AUTO_BSF = 0x200000</summary>
        public const int AVFMT_FLAG_AUTO_BSF = 0x200000;
        
        /// <summary>AVFMT_FLAG_BITEXACT = 0x0400</summary>
        public const int AVFMT_FLAG_BITEXACT = 0x400;
        
        /// <summary>AVFMT_FLAG_CUSTOM_IO = 0x0080</summary>
        public const int AVFMT_FLAG_CUSTOM_IO = 0x80;
        
        /// <summary>AVFMT_FLAG_DISCARD_CORRUPT = 0x0100</summary>
        public const int AVFMT_FLAG_DISCARD_CORRUPT = 0x100;
        
        /// <summary>AVFMT_FLAG_FAST_SEEK = 0x80000</summary>
        public const int AVFMT_FLAG_FAST_SEEK = 0x80000;
        
        /// <summary>AVFMT_FLAG_FLUSH_PACKETS = 0x0200</summary>
        public const int AVFMT_FLAG_FLUSH_PACKETS = 0x200;
        
        /// <summary>AVFMT_FLAG_GENPTS = 0x0001</summary>
        public const int AVFMT_FLAG_GENPTS = 0x1;
        
        /// <summary>AVFMT_FLAG_IGNDTS = 0x0008</summary>
        public const int AVFMT_FLAG_IGNDTS = 0x8;
        
        /// <summary>AVFMT_FLAG_IGNIDX = 0x0002</summary>
        public const int AVFMT_FLAG_IGNIDX = 0x2;
        
        /// <summary>AVFMT_FLAG_NOBUFFER = 0x0040</summary>
        public const int AVFMT_FLAG_NOBUFFER = 0x40;
        
        /// <summary>AVFMT_FLAG_NOFILLIN = 0x0010</summary>
        public const int AVFMT_FLAG_NOFILLIN = 0x10;
        
        /// <summary>AVFMT_FLAG_NONBLOCK = 0x0004</summary>
        public const int AVFMT_FLAG_NONBLOCK = 0x4;
        
        /// <summary>AVFMT_FLAG_NOPARSE = 0x0020</summary>
        public const int AVFMT_FLAG_NOPARSE = 0x20;
        
        /// <summary>AVFMT_FLAG_PRIV_OPT = 0x20000</summary>
        public const int AVFMT_FLAG_PRIV_OPT = 0x20000;
        
        /// <summary>AVFMT_FLAG_SHORTEST = 0x100000</summary>
        public const int AVFMT_FLAG_SHORTEST = 0x100000;
        
        /// <summary>AVFMT_FLAG_SORT_DTS = 0x10000</summary>
        public const int AVFMT_FLAG_SORT_DTS = 0x10000;
        
        /// <summary>AVFMT_GENERIC_INDEX = 0x0100</summary>
        public const int AVFMT_GENERIC_INDEX = 0x100;
        
        /// <summary>AVFMT_GLOBALHEADER = 0x0040</summary>
        public const int AVFMT_GLOBALHEADER = 0x40;
        
        /// <summary>AVFMT_NEEDNUMBER = 0x0002</summary>
        public const int AVFMT_NEEDNUMBER = 0x2;
        
        /// <summary>AVFMT_NO_BYTE_SEEK = 0x8000</summary>
        public const int AVFMT_NO_BYTE_SEEK = 0x8000;
        
        /// <summary>AVFMT_NOBINSEARCH = 0x2000</summary>
        public const int AVFMT_NOBINSEARCH = 0x2000;
        
        /// <summary>AVFMT_NODIMENSIONS = 0x0800</summary>
        public const int AVFMT_NODIMENSIONS = 0x800;
        
        /// <summary>AVFMT_NOFILE = 0x0001</summary>
        public const int AVFMT_NOFILE = 0x1;
        
        /// <summary>AVFMT_NOGENSEARCH = 0x4000</summary>
        public const int AVFMT_NOGENSEARCH = 0x4000;
        
        /// <summary>AVFMT_NOSTREAMS = 0x1000</summary>
        public const int AVFMT_NOSTREAMS = 0x1000;
        
        /// <summary>AVFMT_NOTIMESTAMPS = 0x0080</summary>
        public const int AVFMT_NOTIMESTAMPS = 0x80;
        
        /// <summary>AVFMT_SEEK_TO_PTS = 0x4000000</summary>
        public const int AVFMT_SEEK_TO_PTS = 0x4000000;
        
        /// <summary>AVFMT_SHOW_IDS = 0x0008</summary>
        public const int AVFMT_SHOW_IDS = 0x8;
        
        /// <summary>AVFMT_TS_DISCONT = 0x0200</summary>
        public const int AVFMT_TS_DISCONT = 0x200;
        
        /// <summary>AVFMT_TS_NEGATIVE = 0x40000</summary>
        public const int AVFMT_TS_NEGATIVE = 0x40000;
        
        /// <summary>AVFMT_TS_NONSTRICT = 0x20000</summary>
        public const int AVFMT_TS_NONSTRICT = 0x20000;
        
        /// <summary>AVFMT_VARIABLE_FPS = 0x0400</summary>
        public const int AVFMT_VARIABLE_FPS = 0x400;
        
        /// <summary>AVFMTCTX_NOHEADER = 0x0001</summary>
        public const int AVFMTCTX_NOHEADER = 0x1;
        
        /// <summary>AVFMTCTX_UNSEEKABLE = 0x0002</summary>
        public const int AVFMTCTX_UNSEEKABLE = 0x2;
        
        /// <summary>AVINDEX_DISCARD_FRAME = 0x0002</summary>
        public const int AVINDEX_DISCARD_FRAME = 0x2;
        
        /// <summary>AVINDEX_KEYFRAME = 0x0001</summary>
        public const int AVINDEX_KEYFRAME = 0x1;
        
        /// <summary>AVIO_FLAG_DIRECT = 0x8000</summary>
        public const int AVIO_FLAG_DIRECT = 0x8000;
        
        /// <summary>AVIO_FLAG_NONBLOCK = 8</summary>
        public const int AVIO_FLAG_NONBLOCK = 0x8;
        
        /// <summary>AVIO_FLAG_READ = 1</summary>
        public const int AVIO_FLAG_READ = 0x1;
        
        /// <summary>AVIO_FLAG_READ_WRITE = (AVIO_FLAG_READ|AVIO_FLAG_WRITE)</summary>
        public const int AVIO_FLAG_READ_WRITE = AVIO_FLAG_READ | AVIO_FLAG_WRITE;
        
        /// <summary>AVIO_FLAG_WRITE = 2</summary>
        public const int AVIO_FLAG_WRITE = 0x2;
        
        // public static avio_print = (s, ...) avio_print_string_array(s, (const char*[]){__VA_ARGS__, NULL});
        
        /// <summary>AVIO_SEEKABLE_NORMAL = (1 &lt;&lt; 0)</summary>
        public const int AVIO_SEEKABLE_NORMAL = 0x1 << 0x0;
        
        /// <summary>AVIO_SEEKABLE_TIME = (1 &lt;&lt; 1)</summary>
        public const int AVIO_SEEKABLE_TIME = 0x1 << 0x1;
        
        /// <summary>AVPALETTE_COUNT = 256</summary>
        public const int AVPALETTE_COUNT = 0x100;
        
        /// <summary>AVPALETTE_SIZE = 1024</summary>
        public const int AVPALETTE_SIZE = 0x400;
        
        /// <summary>AVPROBE_PADDING_SIZE = 32</summary>
        public const int AVPROBE_PADDING_SIZE = 0x20;
        
        /// <summary>AVPROBE_SCORE_EXTENSION = 50</summary>
        public const int AVPROBE_SCORE_EXTENSION = 0x32;
        
        /// <summary>AVPROBE_SCORE_MAX = 100</summary>
        public const int AVPROBE_SCORE_MAX = 0x64;
        
        /// <summary>AVPROBE_SCORE_MIME = 75</summary>
        public const int AVPROBE_SCORE_MIME = 0x4b;
        
        /// <summary>AVPROBE_SCORE_RETRY = (AVPROBE_SCORE_MAX/4)</summary>
        public const int AVPROBE_SCORE_RETRY = AVPROBE_SCORE_MAX / 0x4;
        
        /// <summary>AVPROBE_SCORE_STREAM_RETRY = (AVPROBE_SCORE_MAX/4-1)</summary>
        public const int AVPROBE_SCORE_STREAM_RETRY = AVPROBE_SCORE_MAX / 0x4 - 0x1;
        
        /// <summary>AVSEEK_FLAG_ANY = 4</summary>
        public const int AVSEEK_FLAG_ANY = 0x4;
        
        /// <summary>AVSEEK_FLAG_BACKWARD = 1</summary>
        public const int AVSEEK_FLAG_BACKWARD = 0x1;
        
        /// <summary>AVSEEK_FLAG_BYTE = 2</summary>
        public const int AVSEEK_FLAG_BYTE = 0x2;
        
        /// <summary>AVSEEK_FLAG_FRAME = 8</summary>
        public const int AVSEEK_FLAG_FRAME = 0x8;
        
        /// <summary>AVSEEK_FORCE = 0x20000</summary>
        public const int AVSEEK_FORCE = 0x20000;
        
        /// <summary>AVSEEK_SIZE = 0x10000</summary>
        public const int AVSEEK_SIZE = 0x10000;
        
        /// <summary>AVSTREAM_EVENT_FLAG_METADATA_UPDATED = 0x0001</summary>
        public const int AVSTREAM_EVENT_FLAG_METADATA_UPDATED = 0x1;
        
        /// <summary>AVSTREAM_EVENT_FLAG_NEW_PACKETS = (1 &lt;&lt; 1)</summary>
        public const int AVSTREAM_EVENT_FLAG_NEW_PACKETS = 0x1 << 0x1;
        
        /// <summary>AVSTREAM_INIT_IN_INIT_OUTPUT = 1</summary>
        public const int AVSTREAM_INIT_IN_INIT_OUTPUT = 0x1;
        
        /// <summary>AVSTREAM_INIT_IN_WRITE_HEADER = 0</summary>
        public const int AVSTREAM_INIT_IN_WRITE_HEADER = 0x0;
        
        // public static AVUNERROR = (e) (-(e));
        
        // public static DECLARE_ALIGNED = (n,t,v)      t __attribute__ ((aligned (n))) v;
        
        // public static DECLARE_ASM_ALIGNED = (n,t,v)  t av_used __attribute__ ((aligned (n))) v;
        
        // public static DECLARE_ASM_CONST = (n,t,v)    static const t av_used __attribute__ ((aligned (n))) v;
        
        /// <summary>FF_API_AUTO_THREADS = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_AUTO_THREADS = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_AV_MALLOCZ_ARRAY = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_AV_MALLOCZ_ARRAY = LIBAVUTIL_VERSION_MAJOR < 0x3a;
        
        /// <summary>FF_API_AVCTX_TIMEBASE = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_AVCTX_TIMEBASE = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_AVIOCONTEXT_WRITTEN = (LIBAVFORMAT_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_AVIOCONTEXT_WRITTEN = LIBAVFORMAT_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_AVSTREAM_CLASS = (LIBAVFORMAT_VERSION_MAJOR &gt; 59)</summary>
        public const bool FF_API_AVSTREAM_CLASS = LIBAVFORMAT_VERSION_MAJOR > 0x3b;
        
        /// <summary>FF_API_BUFFERSINK_ALLOC = LIBAVFILTER_VERSION_MAJOR &lt; 0x9</summary>
        public const bool FF_API_BUFFERSINK_ALLOC = LIBAVFILTER_VERSION_MAJOR < 0x9;
        
        /// <summary>FF_API_COLORSPACE_NAME = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_COLORSPACE_NAME = LIBAVUTIL_VERSION_MAJOR < 0x3a;
        
        /// <summary>FF_API_COMPUTE_PKT_FIELDS2 = (LIBAVFORMAT_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_COMPUTE_PKT_FIELDS2 = LIBAVFORMAT_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_D2STR = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_D2STR = LIBAVUTIL_VERSION_MAJOR < 0x3a;
        
        /// <summary>FF_API_DEBUG_MV = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_DEBUG_MV = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_DECLARE_ALIGNED = (LIBAVUTIL_VERSION_MAJOR &lt; 58)</summary>
        public const bool FF_API_DECLARE_ALIGNED = LIBAVUTIL_VERSION_MAJOR < 0x3a;
        
        /// <summary>FF_API_DEVICE_CAPABILITIES = (LIBAVDEVICE_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_DEVICE_CAPABILITIES = LIBAVDEVICE_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_FLAG_TRUNCATED = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_FLAG_TRUNCATED = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_GET_FRAME_CLASS = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_GET_FRAME_CLASS = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_INIT_PACKET = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_INIT_PACKET = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_LAVF_PRIV_OPT = (LIBAVFORMAT_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_LAVF_PRIV_OPT = LIBAVFORMAT_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_MPEGVIDEO_OPTS = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_MPEGVIDEO_OPTS = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_OPENH264_CABAC = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_OPENH264_CABAC = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_OPENH264_SLICE_MODE = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_OPENH264_SLICE_MODE = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_PAD_COUNT = LIBAVFILTER_VERSION_MAJOR &lt; 0x9</summary>
        public const bool FF_API_PAD_COUNT = LIBAVFILTER_VERSION_MAJOR < 0x9;
        
        /// <summary>FF_API_R_FRAME_RATE = 1</summary>
        public const int FF_API_R_FRAME_RATE = 0x1;
        
        /// <summary>FF_API_SUB_TEXT_FORMAT = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_SUB_TEXT_FORMAT = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_SWS_PARAM_OPTION = LIBAVFILTER_VERSION_MAJOR &lt; 0x9</summary>
        public const bool FF_API_SWS_PARAM_OPTION = LIBAVFILTER_VERSION_MAJOR < 0x9;
        
        /// <summary>FF_API_THREAD_SAFE_CALLBACKS = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_THREAD_SAFE_CALLBACKS = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_API_UNUSED_CODEC_CAPS = (LIBAVCODEC_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_API_UNUSED_CODEC_CAPS = LIBAVCODEC_VERSION_MAJOR < 0x3c;
        
        // public static FF_ARRAY_ELEMS = (a) (sizeof(a) / sizeof((a)[0]));
        
        /// <summary>FF_BUG_AMV = 0x20</summary>
        public const int FF_BUG_AMV = 0x20;
        
        /// <summary>FF_BUG_AUTODETECT = 0x1</summary>
        public const int FF_BUG_AUTODETECT = 0x1;
        
        /// <summary>FF_BUG_DC_CLIP = 0x1000</summary>
        public const int FF_BUG_DC_CLIP = 0x1000;
        
        /// <summary>FF_BUG_DIRECT_BLOCKSIZE = 0x200</summary>
        public const int FF_BUG_DIRECT_BLOCKSIZE = 0x200;
        
        /// <summary>FF_BUG_EDGE = 0x400</summary>
        public const int FF_BUG_EDGE = 0x400;
        
        /// <summary>FF_BUG_HPEL_CHROMA = 0x800</summary>
        public const int FF_BUG_HPEL_CHROMA = 0x800;
        
        /// <summary>FF_BUG_IEDGE = 0x8000</summary>
        public const int FF_BUG_IEDGE = 0x8000;
        
        /// <summary>FF_BUG_MS = 0x2000</summary>
        public const int FF_BUG_MS = 0x2000;
        
        /// <summary>FF_BUG_NO_PADDING = 0x10</summary>
        public const int FF_BUG_NO_PADDING = 0x10;
        
        /// <summary>FF_BUG_QPEL_CHROMA = 0x40</summary>
        public const int FF_BUG_QPEL_CHROMA = 0x40;
        
        /// <summary>FF_BUG_QPEL_CHROMA2 = 0x100</summary>
        public const int FF_BUG_QPEL_CHROMA2 = 0x100;
        
        /// <summary>FF_BUG_STD_QPEL = 0x80</summary>
        public const int FF_BUG_STD_QPEL = 0x80;
        
        /// <summary>FF_BUG_TRUNCATED = 0x4000</summary>
        public const int FF_BUG_TRUNCATED = 0x4000;
        
        /// <summary>FF_BUG_UMP4 = 0x8</summary>
        public const int FF_BUG_UMP4 = 0x8;
        
        /// <summary>FF_BUG_XVID_ILACE = 0x4</summary>
        public const int FF_BUG_XVID_ILACE = 0x4;
        
        // public static FF_CEIL_RSHIFT = AV_CEIL_RSHIFT;
        
        /// <summary>FF_CMP_BIT = 0x5</summary>
        public const int FF_CMP_BIT = 0x5;
        
        /// <summary>FF_CMP_CHROMA = 0x100</summary>
        public const int FF_CMP_CHROMA = 0x100;
        
        /// <summary>FF_CMP_DCT = 0x3</summary>
        public const int FF_CMP_DCT = 0x3;
        
        /// <summary>FF_CMP_DCT264 = 0xe</summary>
        public const int FF_CMP_DCT264 = 0xe;
        
        /// <summary>FF_CMP_DCTMAX = 0xd</summary>
        public const int FF_CMP_DCTMAX = 0xd;
        
        /// <summary>FF_CMP_MEDIAN_SAD = 0xf</summary>
        public const int FF_CMP_MEDIAN_SAD = 0xf;
        
        /// <summary>FF_CMP_NSSE = 0xa</summary>
        public const int FF_CMP_NSSE = 0xa;
        
        /// <summary>FF_CMP_PSNR = 0x4</summary>
        public const int FF_CMP_PSNR = 0x4;
        
        /// <summary>FF_CMP_RD = 0x6</summary>
        public const int FF_CMP_RD = 0x6;
        
        /// <summary>FF_CMP_SAD = 0x0</summary>
        public const int FF_CMP_SAD = 0x0;
        
        /// <summary>FF_CMP_SATD = 0x2</summary>
        public const int FF_CMP_SATD = 0x2;
        
        /// <summary>FF_CMP_SSE = 0x1</summary>
        public const int FF_CMP_SSE = 0x1;
        
        /// <summary>FF_CMP_VSAD = 0x8</summary>
        public const int FF_CMP_VSAD = 0x8;
        
        /// <summary>FF_CMP_VSSE = 0x9</summary>
        public const int FF_CMP_VSSE = 0x9;
        
        /// <summary>FF_CMP_W53 = 0xb</summary>
        public const int FF_CMP_W53 = 0xb;
        
        /// <summary>FF_CMP_W97 = 0xc</summary>
        public const int FF_CMP_W97 = 0xc;
        
        /// <summary>FF_CMP_ZERO = 0x7</summary>
        public const int FF_CMP_ZERO = 0x7;
        
        /// <summary>FF_CODEC_PROPERTY_CLOSED_CAPTIONS = 0x2</summary>
        public const int FF_CODEC_PROPERTY_CLOSED_CAPTIONS = 0x2;
        
        /// <summary>FF_CODEC_PROPERTY_FILM_GRAIN = 0x4</summary>
        public const int FF_CODEC_PROPERTY_FILM_GRAIN = 0x4;
        
        /// <summary>FF_CODEC_PROPERTY_LOSSLESS = 0x1</summary>
        public const int FF_CODEC_PROPERTY_LOSSLESS = 0x1;
        
        /// <summary>FF_COMPLIANCE_EXPERIMENTAL = -0x2</summary>
        public const int FF_COMPLIANCE_EXPERIMENTAL = -0x2;
        
        /// <summary>FF_COMPLIANCE_NORMAL = 0x0</summary>
        public const int FF_COMPLIANCE_NORMAL = 0x0;
        
        /// <summary>FF_COMPLIANCE_STRICT = 0x1</summary>
        public const int FF_COMPLIANCE_STRICT = 0x1;
        
        /// <summary>FF_COMPLIANCE_UNOFFICIAL = -0x1</summary>
        public const int FF_COMPLIANCE_UNOFFICIAL = -0x1;
        
        /// <summary>FF_COMPLIANCE_VERY_STRICT = 0x2</summary>
        public const int FF_COMPLIANCE_VERY_STRICT = 0x2;
        
        /// <summary>FF_COMPRESSION_DEFAULT = -0x1</summary>
        public const int FF_COMPRESSION_DEFAULT = -0x1;
        
        /// <summary>FF_DCT_ALTIVEC = 0x5</summary>
        public const int FF_DCT_ALTIVEC = 0x5;
        
        /// <summary>FF_DCT_AUTO = 0x0</summary>
        public const int FF_DCT_AUTO = 0x0;
        
        /// <summary>FF_DCT_FAAN = 0x6</summary>
        public const int FF_DCT_FAAN = 0x6;
        
        /// <summary>FF_DCT_FASTINT = 0x1</summary>
        public const int FF_DCT_FASTINT = 0x1;
        
        /// <summary>FF_DCT_INT = 0x2</summary>
        public const int FF_DCT_INT = 0x2;
        
        /// <summary>FF_DCT_MMX = 0x3</summary>
        public const int FF_DCT_MMX = 0x3;
        
        /// <summary>FF_DEBUG_BITSTREAM = 0x4</summary>
        public const int FF_DEBUG_BITSTREAM = 0x4;
        
        /// <summary>FF_DEBUG_BUFFERS = 0x8000</summary>
        public const int FF_DEBUG_BUFFERS = 0x8000;
        
        /// <summary>FF_DEBUG_BUGS = 0x1000</summary>
        public const int FF_DEBUG_BUGS = 0x1000;
        
        /// <summary>FF_DEBUG_DCT_COEFF = 0x40</summary>
        public const int FF_DEBUG_DCT_COEFF = 0x40;
        
        /// <summary>FF_DEBUG_ER = 0x400</summary>
        public const int FF_DEBUG_ER = 0x400;
        
        /// <summary>FF_DEBUG_GREEN_MD = 0x800000</summary>
        public const int FF_DEBUG_GREEN_MD = 0x800000;
        
        /// <summary>FF_DEBUG_MB_TYPE = 0x8</summary>
        public const int FF_DEBUG_MB_TYPE = 0x8;
        
        /// <summary>FF_DEBUG_MMCO = 0x800</summary>
        public const int FF_DEBUG_MMCO = 0x800;
        
        /// <summary>FF_DEBUG_NOMC = 0x1000000</summary>
        public const int FF_DEBUG_NOMC = 0x1000000;
        
        /// <summary>FF_DEBUG_PICT_INFO = 0x1</summary>
        public const int FF_DEBUG_PICT_INFO = 0x1;
        
        /// <summary>FF_DEBUG_QP = 0x10</summary>
        public const int FF_DEBUG_QP = 0x10;
        
        /// <summary>FF_DEBUG_RC = 0x2</summary>
        public const int FF_DEBUG_RC = 0x2;
        
        /// <summary>FF_DEBUG_SKIP = 0x80</summary>
        public const int FF_DEBUG_SKIP = 0x80;
        
        /// <summary>FF_DEBUG_STARTCODE = 0x100</summary>
        public const int FF_DEBUG_STARTCODE = 0x100;
        
        /// <summary>FF_DEBUG_THREADS = 0x10000</summary>
        public const int FF_DEBUG_THREADS = 0x10000;
        
        /// <summary>FF_DEBUG_VIS_MV_B_BACK = 0x4</summary>
        public const int FF_DEBUG_VIS_MV_B_BACK = 0x4;
        
        /// <summary>FF_DEBUG_VIS_MV_B_FOR = 0x2</summary>
        public const int FF_DEBUG_VIS_MV_B_FOR = 0x2;
        
        /// <summary>FF_DEBUG_VIS_MV_P_FOR = 0x1</summary>
        public const int FF_DEBUG_VIS_MV_P_FOR = 0x1;
        
        /// <summary>FF_DECODE_ERROR_CONCEALMENT_ACTIVE = 4</summary>
        public const int FF_DECODE_ERROR_CONCEALMENT_ACTIVE = 0x4;
        
        /// <summary>FF_DECODE_ERROR_DECODE_SLICES = 8</summary>
        public const int FF_DECODE_ERROR_DECODE_SLICES = 0x8;
        
        /// <summary>FF_DECODE_ERROR_INVALID_BITSTREAM = 1</summary>
        public const int FF_DECODE_ERROR_INVALID_BITSTREAM = 0x1;
        
        /// <summary>FF_DECODE_ERROR_MISSING_REFERENCE = 2</summary>
        public const int FF_DECODE_ERROR_MISSING_REFERENCE = 0x2;
        
        /// <summary>FF_DXVA2_WORKAROUND_INTEL_CLEARVIDEO = 0x2</summary>
        public const int FF_DXVA2_WORKAROUND_INTEL_CLEARVIDEO = 0x2;
        
        /// <summary>FF_DXVA2_WORKAROUND_SCALING_LIST_ZIGZAG = 0x1</summary>
        public const int FF_DXVA2_WORKAROUND_SCALING_LIST_ZIGZAG = 0x1;
        
        /// <summary>FF_EC_DEBLOCK = 0x2</summary>
        public const int FF_EC_DEBLOCK = 0x2;
        
        /// <summary>FF_EC_FAVOR_INTER = 0x100</summary>
        public const int FF_EC_FAVOR_INTER = 0x100;
        
        /// <summary>FF_EC_GUESS_MVS = 0x1</summary>
        public const int FF_EC_GUESS_MVS = 0x1;
        
        /// <summary>FF_FDEBUG_TS = 0x0001</summary>
        public const int FF_FDEBUG_TS = 0x1;
        
        /// <summary>FF_HLS_TS_OPTIONS = (LIBAVFORMAT_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_HLS_TS_OPTIONS = LIBAVFORMAT_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_HTTP_CACHE_REDIRECT_DEFAULT = (LIBAVFORMAT_VERSION_MAJOR &lt; 60)</summary>
        public const bool FF_HTTP_CACHE_REDIRECT_DEFAULT = LIBAVFORMAT_VERSION_MAJOR < 0x3c;
        
        /// <summary>FF_IDCT_ALTIVEC = 0x8</summary>
        public const int FF_IDCT_ALTIVEC = 0x8;
        
        /// <summary>FF_IDCT_ARM = 0x7</summary>
        public const int FF_IDCT_ARM = 0x7;
        
        /// <summary>FF_IDCT_AUTO = 0x0</summary>
        public const int FF_IDCT_AUTO = 0x0;
        
        /// <summary>FF_IDCT_FAAN = 0x14</summary>
        public const int FF_IDCT_FAAN = 0x14;
        
        /// <summary>FF_IDCT_INT = 0x1</summary>
        public const int FF_IDCT_INT = 0x1;
        
        /// <summary>FF_IDCT_NONE = 0x18</summary>
        public const int FF_IDCT_NONE = 0x18;
        
        /// <summary>FF_IDCT_SIMPLE = 0x2</summary>
        public const int FF_IDCT_SIMPLE = 0x2;
        
        /// <summary>FF_IDCT_SIMPLEARM = 0xa</summary>
        public const int FF_IDCT_SIMPLEARM = 0xa;
        
        /// <summary>FF_IDCT_SIMPLEARMV5TE = 0x10</summary>
        public const int FF_IDCT_SIMPLEARMV5TE = 0x10;
        
        /// <summary>FF_IDCT_SIMPLEARMV6 = 0x11</summary>
        public const int FF_IDCT_SIMPLEARMV6 = 0x11;
        
        /// <summary>FF_IDCT_SIMPLEAUTO = 0x80</summary>
        public const int FF_IDCT_SIMPLEAUTO = 0x80;
        
        /// <summary>FF_IDCT_SIMPLEMMX = 0x3</summary>
        public const int FF_IDCT_SIMPLEMMX = 0x3;
        
        /// <summary>FF_IDCT_SIMPLENEON = 0x16</summary>
        public const int FF_IDCT_SIMPLENEON = 0x16;
        
        /// <summary>FF_IDCT_XVID = 0xe</summary>
        public const int FF_IDCT_XVID = 0xe;
        
        /// <summary>FF_LAMBDA_MAX = (256*128-1)</summary>
        public const int FF_LAMBDA_MAX = 0x100 * 0x80 - 0x1;
        
        /// <summary>FF_LAMBDA_SCALE = (1&lt;&lt;FF_LAMBDA_SHIFT)</summary>
        public const int FF_LAMBDA_SCALE = 0x1 << FF_LAMBDA_SHIFT;
        
        /// <summary>FF_LAMBDA_SHIFT = 7</summary>
        public const int FF_LAMBDA_SHIFT = 0x7;
        
        /// <summary>FF_LEVEL_UNKNOWN = -0x63</summary>
        public const int FF_LEVEL_UNKNOWN = -0x63;
        
        /// <summary>FF_LOSS_ALPHA = 0x8</summary>
        public const int FF_LOSS_ALPHA = 0x8;
        
        /// <summary>FF_LOSS_CHROMA = 0x20</summary>
        public const int FF_LOSS_CHROMA = 0x20;
        
        /// <summary>FF_LOSS_COLORQUANT = 0x10</summary>
        public const int FF_LOSS_COLORQUANT = 0x10;
        
        /// <summary>FF_LOSS_COLORSPACE = 0x4</summary>
        public const int FF_LOSS_COLORSPACE = 0x4;
        
        /// <summary>FF_LOSS_DEPTH = 0x2</summary>
        public const int FF_LOSS_DEPTH = 0x2;
        
        /// <summary>FF_LOSS_RESOLUTION = 0x1</summary>
        public const int FF_LOSS_RESOLUTION = 0x1;
        
        /// <summary>FF_MB_DECISION_BITS = 0x1</summary>
        public const int FF_MB_DECISION_BITS = 0x1;
        
        /// <summary>FF_MB_DECISION_RD = 0x2</summary>
        public const int FF_MB_DECISION_RD = 0x2;
        
        /// <summary>FF_MB_DECISION_SIMPLE = 0x0</summary>
        public const int FF_MB_DECISION_SIMPLE = 0x0;
        
        /// <summary>FF_PROFILE_AAC_ELD = 0x26</summary>
        public const int FF_PROFILE_AAC_ELD = 0x26;
        
        /// <summary>FF_PROFILE_AAC_HE = 0x4</summary>
        public const int FF_PROFILE_AAC_HE = 0x4;
        
        /// <summary>FF_PROFILE_AAC_HE_V2 = 0x1c</summary>
        public const int FF_PROFILE_AAC_HE_V2 = 0x1c;
        
        /// <summary>FF_PROFILE_AAC_LD = 0x16</summary>
        public const int FF_PROFILE_AAC_LD = 0x16;
        
        /// <summary>FF_PROFILE_AAC_LOW = 0x1</summary>
        public const int FF_PROFILE_AAC_LOW = 0x1;
        
        /// <summary>FF_PROFILE_AAC_LTP = 0x3</summary>
        public const int FF_PROFILE_AAC_LTP = 0x3;
        
        /// <summary>FF_PROFILE_AAC_MAIN = 0x0</summary>
        public const int FF_PROFILE_AAC_MAIN = 0x0;
        
        /// <summary>FF_PROFILE_AAC_SSR = 0x2</summary>
        public const int FF_PROFILE_AAC_SSR = 0x2;
        
        /// <summary>FF_PROFILE_ARIB_PROFILE_A = 0x0</summary>
        public const int FF_PROFILE_ARIB_PROFILE_A = 0x0;
        
        /// <summary>FF_PROFILE_ARIB_PROFILE_C = 0x1</summary>
        public const int FF_PROFILE_ARIB_PROFILE_C = 0x1;
        
        /// <summary>FF_PROFILE_AV1_HIGH = 0x1</summary>
        public const int FF_PROFILE_AV1_HIGH = 0x1;
        
        /// <summary>FF_PROFILE_AV1_MAIN = 0x0</summary>
        public const int FF_PROFILE_AV1_MAIN = 0x0;
        
        /// <summary>FF_PROFILE_AV1_PROFESSIONAL = 0x2</summary>
        public const int FF_PROFILE_AV1_PROFESSIONAL = 0x2;
        
        /// <summary>FF_PROFILE_DNXHD = 0x0</summary>
        public const int FF_PROFILE_DNXHD = 0x0;
        
        /// <summary>FF_PROFILE_DNXHR_444 = 0x5</summary>
        public const int FF_PROFILE_DNXHR_444 = 0x5;
        
        /// <summary>FF_PROFILE_DNXHR_HQ = 0x3</summary>
        public const int FF_PROFILE_DNXHR_HQ = 0x3;
        
        /// <summary>FF_PROFILE_DNXHR_HQX = 0x4</summary>
        public const int FF_PROFILE_DNXHR_HQX = 0x4;
        
        /// <summary>FF_PROFILE_DNXHR_LB = 0x1</summary>
        public const int FF_PROFILE_DNXHR_LB = 0x1;
        
        /// <summary>FF_PROFILE_DNXHR_SQ = 0x2</summary>
        public const int FF_PROFILE_DNXHR_SQ = 0x2;
        
        /// <summary>FF_PROFILE_DTS = 0x14</summary>
        public const int FF_PROFILE_DTS = 0x14;
        
        /// <summary>FF_PROFILE_DTS_96_24 = 0x28</summary>
        public const int FF_PROFILE_DTS_96_24 = 0x28;
        
        /// <summary>FF_PROFILE_DTS_ES = 0x1e</summary>
        public const int FF_PROFILE_DTS_ES = 0x1e;
        
        /// <summary>FF_PROFILE_DTS_EXPRESS = 0x46</summary>
        public const int FF_PROFILE_DTS_EXPRESS = 0x46;
        
        /// <summary>FF_PROFILE_DTS_HD_HRA = 0x32</summary>
        public const int FF_PROFILE_DTS_HD_HRA = 0x32;
        
        /// <summary>FF_PROFILE_DTS_HD_MA = 0x3c</summary>
        public const int FF_PROFILE_DTS_HD_MA = 0x3c;
        
        /// <summary>FF_PROFILE_H264_BASELINE = 0x42</summary>
        public const int FF_PROFILE_H264_BASELINE = 0x42;
        
        /// <summary>FF_PROFILE_H264_CAVLC_444 = 0x2c</summary>
        public const int FF_PROFILE_H264_CAVLC_444 = 0x2c;
        
        /// <summary>FF_PROFILE_H264_CONSTRAINED = 0x1 &lt;&lt; 0x9</summary>
        public const int FF_PROFILE_H264_CONSTRAINED = 0x1 << 0x9;
        
        /// <summary>FF_PROFILE_H264_CONSTRAINED_BASELINE = 0x42 | FF_PROFILE_H264_CONSTRAINED</summary>
        public const int FF_PROFILE_H264_CONSTRAINED_BASELINE = 0x42 | FF_PROFILE_H264_CONSTRAINED;
        
        /// <summary>FF_PROFILE_H264_EXTENDED = 0x58</summary>
        public const int FF_PROFILE_H264_EXTENDED = 0x58;
        
        /// <summary>FF_PROFILE_H264_HIGH = 0x64</summary>
        public const int FF_PROFILE_H264_HIGH = 0x64;
        
        /// <summary>FF_PROFILE_H264_HIGH_10 = 0x6e</summary>
        public const int FF_PROFILE_H264_HIGH_10 = 0x6e;
        
        /// <summary>FF_PROFILE_H264_HIGH_10_INTRA = 0x6e | FF_PROFILE_H264_INTRA</summary>
        public const int FF_PROFILE_H264_HIGH_10_INTRA = 0x6e | FF_PROFILE_H264_INTRA;
        
        /// <summary>FF_PROFILE_H264_HIGH_422 = 0x7a</summary>
        public const int FF_PROFILE_H264_HIGH_422 = 0x7a;
        
        /// <summary>FF_PROFILE_H264_HIGH_422_INTRA = 0x7a | FF_PROFILE_H264_INTRA</summary>
        public const int FF_PROFILE_H264_HIGH_422_INTRA = 0x7a | FF_PROFILE_H264_INTRA;
        
        /// <summary>FF_PROFILE_H264_HIGH_444 = 0x90</summary>
        public const int FF_PROFILE_H264_HIGH_444 = 0x90;
        
        /// <summary>FF_PROFILE_H264_HIGH_444_INTRA = 0xf4 | FF_PROFILE_H264_INTRA</summary>
        public const int FF_PROFILE_H264_HIGH_444_INTRA = 0xf4 | FF_PROFILE_H264_INTRA;
        
        /// <summary>FF_PROFILE_H264_HIGH_444_PREDICTIVE = 0xf4</summary>
        public const int FF_PROFILE_H264_HIGH_444_PREDICTIVE = 0xf4;
        
        /// <summary>FF_PROFILE_H264_INTRA = 0x1 &lt;&lt; 0xb</summary>
        public const int FF_PROFILE_H264_INTRA = 0x1 << 0xb;
        
        /// <summary>FF_PROFILE_H264_MAIN = 0x4d</summary>
        public const int FF_PROFILE_H264_MAIN = 0x4d;
        
        /// <summary>FF_PROFILE_H264_MULTIVIEW_HIGH = 0x76</summary>
        public const int FF_PROFILE_H264_MULTIVIEW_HIGH = 0x76;
        
        /// <summary>FF_PROFILE_H264_STEREO_HIGH = 0x80</summary>
        public const int FF_PROFILE_H264_STEREO_HIGH = 0x80;
        
        /// <summary>FF_PROFILE_HEVC_MAIN = 0x1</summary>
        public const int FF_PROFILE_HEVC_MAIN = 0x1;
        
        /// <summary>FF_PROFILE_HEVC_MAIN_10 = 0x2</summary>
        public const int FF_PROFILE_HEVC_MAIN_10 = 0x2;
        
        /// <summary>FF_PROFILE_HEVC_MAIN_STILL_PICTURE = 0x3</summary>
        public const int FF_PROFILE_HEVC_MAIN_STILL_PICTURE = 0x3;
        
        /// <summary>FF_PROFILE_HEVC_REXT = 0x4</summary>
        public const int FF_PROFILE_HEVC_REXT = 0x4;
        
        /// <summary>FF_PROFILE_JPEG2000_CSTREAM_NO_RESTRICTION = 0x8000</summary>
        public const int FF_PROFILE_JPEG2000_CSTREAM_NO_RESTRICTION = 0x8000;
        
        /// <summary>FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_0 = 0x1</summary>
        public const int FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_0 = 0x1;
        
        /// <summary>FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_1 = 0x2</summary>
        public const int FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_1 = 0x2;
        
        /// <summary>FF_PROFILE_JPEG2000_DCINEMA_2K = 0x3</summary>
        public const int FF_PROFILE_JPEG2000_DCINEMA_2K = 0x3;
        
        /// <summary>FF_PROFILE_JPEG2000_DCINEMA_4K = 0x4</summary>
        public const int FF_PROFILE_JPEG2000_DCINEMA_4K = 0x4;
        
        /// <summary>FF_PROFILE_KLVA_ASYNC = 0x1</summary>
        public const int FF_PROFILE_KLVA_ASYNC = 0x1;
        
        /// <summary>FF_PROFILE_KLVA_SYNC = 0x0</summary>
        public const int FF_PROFILE_KLVA_SYNC = 0x0;
        
        /// <summary>FF_PROFILE_MJPEG_HUFFMAN_BASELINE_DCT = 0xc0</summary>
        public const int FF_PROFILE_MJPEG_HUFFMAN_BASELINE_DCT = 0xc0;
        
        /// <summary>FF_PROFILE_MJPEG_HUFFMAN_EXTENDED_SEQUENTIAL_DCT = 0xc1</summary>
        public const int FF_PROFILE_MJPEG_HUFFMAN_EXTENDED_SEQUENTIAL_DCT = 0xc1;
        
        /// <summary>FF_PROFILE_MJPEG_HUFFMAN_LOSSLESS = 0xc3</summary>
        public const int FF_PROFILE_MJPEG_HUFFMAN_LOSSLESS = 0xc3;
        
        /// <summary>FF_PROFILE_MJPEG_HUFFMAN_PROGRESSIVE_DCT = 0xc2</summary>
        public const int FF_PROFILE_MJPEG_HUFFMAN_PROGRESSIVE_DCT = 0xc2;
        
        /// <summary>FF_PROFILE_MJPEG_JPEG_LS = 0xf7</summary>
        public const int FF_PROFILE_MJPEG_JPEG_LS = 0xf7;
        
        /// <summary>FF_PROFILE_MPEG2_422 = 0x0</summary>
        public const int FF_PROFILE_MPEG2_422 = 0x0;
        
        /// <summary>FF_PROFILE_MPEG2_AAC_HE = 0x83</summary>
        public const int FF_PROFILE_MPEG2_AAC_HE = 0x83;
        
        /// <summary>FF_PROFILE_MPEG2_AAC_LOW = 0x80</summary>
        public const int FF_PROFILE_MPEG2_AAC_LOW = 0x80;
        
        /// <summary>FF_PROFILE_MPEG2_HIGH = 0x1</summary>
        public const int FF_PROFILE_MPEG2_HIGH = 0x1;
        
        /// <summary>FF_PROFILE_MPEG2_MAIN = 0x4</summary>
        public const int FF_PROFILE_MPEG2_MAIN = 0x4;
        
        /// <summary>FF_PROFILE_MPEG2_SIMPLE = 0x5</summary>
        public const int FF_PROFILE_MPEG2_SIMPLE = 0x5;
        
        /// <summary>FF_PROFILE_MPEG2_SNR_SCALABLE = 0x3</summary>
        public const int FF_PROFILE_MPEG2_SNR_SCALABLE = 0x3;
        
        /// <summary>FF_PROFILE_MPEG2_SS = 0x2</summary>
        public const int FF_PROFILE_MPEG2_SS = 0x2;
        
        /// <summary>FF_PROFILE_MPEG4_ADVANCED_CODING = 0xb</summary>
        public const int FF_PROFILE_MPEG4_ADVANCED_CODING = 0xb;
        
        /// <summary>FF_PROFILE_MPEG4_ADVANCED_CORE = 0xc</summary>
        public const int FF_PROFILE_MPEG4_ADVANCED_CORE = 0xc;
        
        /// <summary>FF_PROFILE_MPEG4_ADVANCED_REAL_TIME = 0x9</summary>
        public const int FF_PROFILE_MPEG4_ADVANCED_REAL_TIME = 0x9;
        
        /// <summary>FF_PROFILE_MPEG4_ADVANCED_SCALABLE_TEXTURE = 0xd</summary>
        public const int FF_PROFILE_MPEG4_ADVANCED_SCALABLE_TEXTURE = 0xd;
        
        /// <summary>FF_PROFILE_MPEG4_ADVANCED_SIMPLE = 0xf</summary>
        public const int FF_PROFILE_MPEG4_ADVANCED_SIMPLE = 0xf;
        
        /// <summary>FF_PROFILE_MPEG4_BASIC_ANIMATED_TEXTURE = 0x7</summary>
        public const int FF_PROFILE_MPEG4_BASIC_ANIMATED_TEXTURE = 0x7;
        
        /// <summary>FF_PROFILE_MPEG4_CORE = 0x2</summary>
        public const int FF_PROFILE_MPEG4_CORE = 0x2;
        
        /// <summary>FF_PROFILE_MPEG4_CORE_SCALABLE = 0xa</summary>
        public const int FF_PROFILE_MPEG4_CORE_SCALABLE = 0xa;
        
        /// <summary>FF_PROFILE_MPEG4_HYBRID = 0x8</summary>
        public const int FF_PROFILE_MPEG4_HYBRID = 0x8;
        
        /// <summary>FF_PROFILE_MPEG4_MAIN = 0x3</summary>
        public const int FF_PROFILE_MPEG4_MAIN = 0x3;
        
        /// <summary>FF_PROFILE_MPEG4_N_BIT = 0x4</summary>
        public const int FF_PROFILE_MPEG4_N_BIT = 0x4;
        
        /// <summary>FF_PROFILE_MPEG4_SCALABLE_TEXTURE = 0x5</summary>
        public const int FF_PROFILE_MPEG4_SCALABLE_TEXTURE = 0x5;
        
        /// <summary>FF_PROFILE_MPEG4_SIMPLE = 0x0</summary>
        public const int FF_PROFILE_MPEG4_SIMPLE = 0x0;
        
        /// <summary>FF_PROFILE_MPEG4_SIMPLE_FACE_ANIMATION = 0x6</summary>
        public const int FF_PROFILE_MPEG4_SIMPLE_FACE_ANIMATION = 0x6;
        
        /// <summary>FF_PROFILE_MPEG4_SIMPLE_SCALABLE = 0x1</summary>
        public const int FF_PROFILE_MPEG4_SIMPLE_SCALABLE = 0x1;
        
        /// <summary>FF_PROFILE_MPEG4_SIMPLE_STUDIO = 0xe</summary>
        public const int FF_PROFILE_MPEG4_SIMPLE_STUDIO = 0xe;
        
        /// <summary>FF_PROFILE_PRORES_4444 = 0x4</summary>
        public const int FF_PROFILE_PRORES_4444 = 0x4;
        
        /// <summary>FF_PROFILE_PRORES_HQ = 0x3</summary>
        public const int FF_PROFILE_PRORES_HQ = 0x3;
        
        /// <summary>FF_PROFILE_PRORES_LT = 0x1</summary>
        public const int FF_PROFILE_PRORES_LT = 0x1;
        
        /// <summary>FF_PROFILE_PRORES_PROXY = 0x0</summary>
        public const int FF_PROFILE_PRORES_PROXY = 0x0;
        
        /// <summary>FF_PROFILE_PRORES_STANDARD = 0x2</summary>
        public const int FF_PROFILE_PRORES_STANDARD = 0x2;
        
        /// <summary>FF_PROFILE_PRORES_XQ = 0x5</summary>
        public const int FF_PROFILE_PRORES_XQ = 0x5;
        
        /// <summary>FF_PROFILE_RESERVED = -0x64</summary>
        public const int FF_PROFILE_RESERVED = -0x64;
        
        /// <summary>FF_PROFILE_SBC_MSBC = 0x1</summary>
        public const int FF_PROFILE_SBC_MSBC = 0x1;
        
        /// <summary>FF_PROFILE_UNKNOWN = -0x63</summary>
        public const int FF_PROFILE_UNKNOWN = -0x63;
        
        /// <summary>FF_PROFILE_VC1_ADVANCED = 0x3</summary>
        public const int FF_PROFILE_VC1_ADVANCED = 0x3;
        
        /// <summary>FF_PROFILE_VC1_COMPLEX = 0x2</summary>
        public const int FF_PROFILE_VC1_COMPLEX = 0x2;
        
        /// <summary>FF_PROFILE_VC1_MAIN = 0x1</summary>
        public const int FF_PROFILE_VC1_MAIN = 0x1;
        
        /// <summary>FF_PROFILE_VC1_SIMPLE = 0x0</summary>
        public const int FF_PROFILE_VC1_SIMPLE = 0x0;
        
        /// <summary>FF_PROFILE_VP9_0 = 0x0</summary>
        public const int FF_PROFILE_VP9_0 = 0x0;
        
        /// <summary>FF_PROFILE_VP9_1 = 0x1</summary>
        public const int FF_PROFILE_VP9_1 = 0x1;
        
        /// <summary>FF_PROFILE_VP9_2 = 0x2</summary>
        public const int FF_PROFILE_VP9_2 = 0x2;
        
        /// <summary>FF_PROFILE_VP9_3 = 0x3</summary>
        public const int FF_PROFILE_VP9_3 = 0x3;
        
        /// <summary>FF_PROFILE_VVC_MAIN_10 = 0x1</summary>
        public const int FF_PROFILE_VVC_MAIN_10 = 0x1;
        
        /// <summary>FF_PROFILE_VVC_MAIN_10_444 = 0x21</summary>
        public const int FF_PROFILE_VVC_MAIN_10_444 = 0x21;
        
        /// <summary>FF_QP2LAMBDA = 118</summary>
        public const int FF_QP2LAMBDA = 0x76;
        
        /// <summary>FF_QUALITY_SCALE = FF_LAMBDA_SCALE</summary>
        public const int FF_QUALITY_SCALE = FF_LAMBDA_SCALE;
        
        /// <summary>FF_SUB_CHARENC_MODE_AUTOMATIC = 0x0</summary>
        public const int FF_SUB_CHARENC_MODE_AUTOMATIC = 0x0;
        
        /// <summary>FF_SUB_CHARENC_MODE_DO_NOTHING = -0x1</summary>
        public const int FF_SUB_CHARENC_MODE_DO_NOTHING = -0x1;
        
        /// <summary>FF_SUB_CHARENC_MODE_IGNORE = 0x2</summary>
        public const int FF_SUB_CHARENC_MODE_IGNORE = 0x2;
        
        /// <summary>FF_SUB_CHARENC_MODE_PRE_DECODER = 0x1</summary>
        public const int FF_SUB_CHARENC_MODE_PRE_DECODER = 0x1;
        
        /// <summary>FF_SUB_TEXT_FMT_ASS = 0x0</summary>
        public const int FF_SUB_TEXT_FMT_ASS = 0x0;
        
        /// <summary>FF_THREAD_FRAME = 0x1</summary>
        public const int FF_THREAD_FRAME = 0x1;
        
        /// <summary>FF_THREAD_SLICE = 0x2</summary>
        public const int FF_THREAD_SLICE = 0x2;
        
        // public static FFABS = (a) ((a) >= 0 ? (a) : (-(a)));
        
        // public static FFABS64U = (a) ((a) <= 0 ? -(uint64_t)(a) : (uint64_t)(a));
        
        // public static FFABSU = (a) ((a) <= 0 ? -(unsigned)(a) : (unsigned)(a));
        
        // public static FFALIGN = (x, a) (((x)+(a)-1)&~((a)-1));
        
        // public static FFDIFFSIGN = (x,y) (((x)>(y)) - ((x)<(y)));
        
        // public static FFERRTAG = (a, b, c, d) (-(int)MKTAG(a, b, c, d));
        
        // public static FFMAX = (a,b) ((a) > (b) ? (a) : (b));
        
        // public static FFMAX3 = (a,b,c) FFMAX(FFMAX(a,b),c);
        
        // public static FFMIN = (a,b) ((a) > (b) ? (b) : (a));
        
        // public static FFMIN3 = (a,b,c) FFMIN(FFMIN(a,b),c);
        
        // public static FFNABS = (a) ((a) <= 0 ? (a) : (-(a)));
        
        // public static FFSIGN = (a) ((a) > 0 ? 1 : -1);
        
        // public static FFSWAP = (type,a,b) do{type SWAP_tmp= b; b= a; a= SWAP_tmp;}while(0);
        
        // public static FFUDIV = (a,b) (((a)>0 ?(a):(a)-(b)+1) / (b));
        
        // public static FFUMOD = (a,b) ((a)-(b)*FFUDIV(a,b));
        
        // public static GET_UTF16 = (val, GET_16BIT, ERROR)val = (GET_16BIT);{unsigned int hi = val - 0xD800;if (hi < 0x800) {val = (GET_16BIT) - 0xDC00;if (val > 0x3FFU || hi > 0x3FFU){ERROR}val += (hi<<10) + 0x10000;}};
        
        // public static GET_UTF8 = (val, GET_BYTE, ERROR)val= (GET_BYTE);{uint32_t top = (val & 128) >> 1;if ((val & 0xc0) == 0x80 || val >= 0xFE){ERROR}while (val & top) {unsigned int tmp = (GET_BYTE) - 128;if(tmp>>6){ERROR}val= (val<<6) + tmp;top <<= 5;}val &= (top << 1) - 1;};
        
        /// <summary>LIBAVCODEC_BUILD = LIBAVCODEC_VERSION_INT</summary>
        public static readonly int LIBAVCODEC_BUILD = LIBAVCODEC_VERSION_INT;
        
        /// <summary>LIBAVCODEC_IDENT = &quot;Lavc&quot; AV_STRINGIFY(LIBAVCODEC_VERSION)</summary>
        public const string LIBAVCODEC_IDENT = "Lavc";
        
        /// <summary>LIBAVCODEC_VERSION = AV_VERSION(LIBAVCODEC_VERSION_MAJOR,    LIBAVCODEC_VERSION_MINOR,    LIBAVCODEC_VERSION_MICRO)</summary>
        public static readonly string LIBAVCODEC_VERSION = AV_VERSION(LIBAVCODEC_VERSION_MAJOR, LIBAVCODEC_VERSION_MINOR, LIBAVCODEC_VERSION_MICRO);
        
        /// <summary>LIBAVCODEC_VERSION_INT = AV_VERSION_INT(LIBAVCODEC_VERSION_MAJOR, LIBAVCODEC_VERSION_MINOR, LIBAVCODEC_VERSION_MICRO)</summary>
        public static readonly int LIBAVCODEC_VERSION_INT = AV_VERSION_INT(LIBAVCODEC_VERSION_MAJOR, LIBAVCODEC_VERSION_MINOR, LIBAVCODEC_VERSION_MICRO);
        
        /// <summary>LIBAVCODEC_VERSION_MAJOR = 59</summary>
        public const int LIBAVCODEC_VERSION_MAJOR = 0x3b;
        
        /// <summary>LIBAVCODEC_VERSION_MICRO = 100</summary>
        public const int LIBAVCODEC_VERSION_MICRO = 0x64;
        
        /// <summary>LIBAVCODEC_VERSION_MINOR = 18</summary>
        public const int LIBAVCODEC_VERSION_MINOR = 0x12;
        
        /// <summary>LIBAVDEVICE_BUILD = LIBAVDEVICE_VERSION_INT</summary>
        public static readonly int LIBAVDEVICE_BUILD = LIBAVDEVICE_VERSION_INT;
        
        /// <summary>LIBAVDEVICE_IDENT = &quot;Lavd&quot; AV_STRINGIFY(LIBAVDEVICE_VERSION)</summary>
        public const string LIBAVDEVICE_IDENT = "Lavd";
        
        /// <summary>LIBAVDEVICE_VERSION = AV_VERSION(LIBAVDEVICE_VERSION_MAJOR, LIBAVDEVICE_VERSION_MINOR, LIBAVDEVICE_VERSION_MICRO)</summary>
        public static readonly string LIBAVDEVICE_VERSION = AV_VERSION(LIBAVDEVICE_VERSION_MAJOR, LIBAVDEVICE_VERSION_MINOR, LIBAVDEVICE_VERSION_MICRO);
        
        /// <summary>LIBAVDEVICE_VERSION_INT = AV_VERSION_INT(LIBAVDEVICE_VERSION_MAJOR, LIBAVDEVICE_VERSION_MINOR, LIBAVDEVICE_VERSION_MICRO)</summary>
        public static readonly int LIBAVDEVICE_VERSION_INT = AV_VERSION_INT(LIBAVDEVICE_VERSION_MAJOR, LIBAVDEVICE_VERSION_MINOR, LIBAVDEVICE_VERSION_MICRO);
        
        /// <summary>LIBAVDEVICE_VERSION_MAJOR = 59</summary>
        public const int LIBAVDEVICE_VERSION_MAJOR = 0x3b;
        
        /// <summary>LIBAVDEVICE_VERSION_MICRO = 100</summary>
        public const int LIBAVDEVICE_VERSION_MICRO = 0x64;
        
        /// <summary>LIBAVDEVICE_VERSION_MINOR = 4</summary>
        public const int LIBAVDEVICE_VERSION_MINOR = 0x4;
        
        /// <summary>LIBAVFILTER_BUILD = LIBAVFILTER_VERSION_INT</summary>
        public static readonly int LIBAVFILTER_BUILD = LIBAVFILTER_VERSION_INT;
        
        /// <summary>LIBAVFILTER_IDENT = &quot;Lavfi&quot;</summary>
        public const string LIBAVFILTER_IDENT = "Lavfi";
        
        /// <summary>LIBAVFILTER_VERSION = AV_VERSION(LIBAVFILTER_VERSION_MAJOR, LIBAVFILTER_VERSION_MINOR, LIBAVFILTER_VERSION_MICRO)</summary>
        public static readonly string LIBAVFILTER_VERSION = AV_VERSION(LIBAVFILTER_VERSION_MAJOR, LIBAVFILTER_VERSION_MINOR, LIBAVFILTER_VERSION_MICRO);
        
        /// <summary>LIBAVFILTER_VERSION_INT = AV_VERSION_INT(LIBAVFILTER_VERSION_MAJOR, LIBAVFILTER_VERSION_MINOR, LIBAVFILTER_VERSION_MICRO)</summary>
        public static readonly int LIBAVFILTER_VERSION_INT = AV_VERSION_INT(LIBAVFILTER_VERSION_MAJOR, LIBAVFILTER_VERSION_MINOR, LIBAVFILTER_VERSION_MICRO);
        
        /// <summary>LIBAVFILTER_VERSION_MAJOR = 0x8</summary>
        public const int LIBAVFILTER_VERSION_MAJOR = 0x8;
        
        /// <summary>LIBAVFILTER_VERSION_MICRO = 0x64</summary>
        public const int LIBAVFILTER_VERSION_MICRO = 0x64;
        
        /// <summary>LIBAVFILTER_VERSION_MINOR = 0x18</summary>
        public const int LIBAVFILTER_VERSION_MINOR = 0x18;
        
        /// <summary>LIBAVFORMAT_BUILD = LIBAVFORMAT_VERSION_INT</summary>
        public static readonly int LIBAVFORMAT_BUILD = LIBAVFORMAT_VERSION_INT;
        
        /// <summary>LIBAVFORMAT_IDENT = &quot;Lavf&quot; AV_STRINGIFY(LIBAVFORMAT_VERSION)</summary>
        public const string LIBAVFORMAT_IDENT = "Lavf";
        
        /// <summary>LIBAVFORMAT_VERSION = AV_VERSION(LIBAVFORMAT_VERSION_MAJOR,   LIBAVFORMAT_VERSION_MINOR,   LIBAVFORMAT_VERSION_MICRO)</summary>
        public static readonly string LIBAVFORMAT_VERSION = AV_VERSION(LIBAVFORMAT_VERSION_MAJOR, LIBAVFORMAT_VERSION_MINOR, LIBAVFORMAT_VERSION_MICRO);
        
        /// <summary>LIBAVFORMAT_VERSION_INT = AV_VERSION_INT(LIBAVFORMAT_VERSION_MAJOR, LIBAVFORMAT_VERSION_MINOR, LIBAVFORMAT_VERSION_MICRO)</summary>
        public static readonly int LIBAVFORMAT_VERSION_INT = AV_VERSION_INT(LIBAVFORMAT_VERSION_MAJOR, LIBAVFORMAT_VERSION_MINOR, LIBAVFORMAT_VERSION_MICRO);
        
        /// <summary>LIBAVFORMAT_VERSION_MAJOR = 59</summary>
        public const int LIBAVFORMAT_VERSION_MAJOR = 0x3b;
        
        /// <summary>LIBAVFORMAT_VERSION_MICRO = 100</summary>
        public const int LIBAVFORMAT_VERSION_MICRO = 0x64;
        
        /// <summary>LIBAVFORMAT_VERSION_MINOR = 16</summary>
        public const int LIBAVFORMAT_VERSION_MINOR = 0x10;
        
        /// <summary>LIBAVUTIL_BUILD = LIBAVUTIL_VERSION_INT</summary>
        public static readonly int LIBAVUTIL_BUILD = LIBAVUTIL_VERSION_INT;
        
        /// <summary>LIBAVUTIL_IDENT = &quot;Lavu&quot; AV_STRINGIFY(LIBAVUTIL_VERSION)</summary>
        public const string LIBAVUTIL_IDENT = "Lavu";
        
        /// <summary>LIBAVUTIL_VERSION = AV_VERSION(LIBAVUTIL_VERSION_MAJOR,     LIBAVUTIL_VERSION_MINOR,     LIBAVUTIL_VERSION_MICRO)</summary>
        public static readonly string LIBAVUTIL_VERSION = AV_VERSION(LIBAVUTIL_VERSION_MAJOR, LIBAVUTIL_VERSION_MINOR, LIBAVUTIL_VERSION_MICRO);
        
        /// <summary>LIBAVUTIL_VERSION_INT = AV_VERSION_INT(LIBAVUTIL_VERSION_MAJOR, LIBAVUTIL_VERSION_MINOR, LIBAVUTIL_VERSION_MICRO)</summary>
        public static readonly int LIBAVUTIL_VERSION_INT = AV_VERSION_INT(LIBAVUTIL_VERSION_MAJOR, LIBAVUTIL_VERSION_MINOR, LIBAVUTIL_VERSION_MICRO);
        
        /// <summary>LIBAVUTIL_VERSION_MAJOR = 57</summary>
        public const int LIBAVUTIL_VERSION_MAJOR = 0x39;
        
        /// <summary>LIBAVUTIL_VERSION_MICRO = 100</summary>
        public const int LIBAVUTIL_VERSION_MICRO = 0x64;
        
        /// <summary>LIBAVUTIL_VERSION_MINOR = 17</summary>
        public const int LIBAVUTIL_VERSION_MINOR = 0x11;
        
        /// <summary>LIBPOSTPROC_BUILD = LIBPOSTPROC_VERSION_INT</summary>
        public static readonly int LIBPOSTPROC_BUILD = LIBPOSTPROC_VERSION_INT;
        
        /// <summary>LIBPOSTPROC_IDENT = &quot;postproc&quot;</summary>
        public const string LIBPOSTPROC_IDENT = "postproc";
        
        /// <summary>LIBPOSTPROC_VERSION = AV_VERSION(LIBPOSTPROC_VERSION_MAJOR, LIBPOSTPROC_VERSION_MINOR, LIBPOSTPROC_VERSION_MICRO)</summary>
        public static readonly string LIBPOSTPROC_VERSION = AV_VERSION(LIBPOSTPROC_VERSION_MAJOR, LIBPOSTPROC_VERSION_MINOR, LIBPOSTPROC_VERSION_MICRO);
        
        /// <summary>LIBPOSTPROC_VERSION_INT = AV_VERSION_INT(LIBPOSTPROC_VERSION_MAJOR, LIBPOSTPROC_VERSION_MINOR, LIBPOSTPROC_VERSION_MICRO)</summary>
        public static readonly int LIBPOSTPROC_VERSION_INT = AV_VERSION_INT(LIBPOSTPROC_VERSION_MAJOR, LIBPOSTPROC_VERSION_MINOR, LIBPOSTPROC_VERSION_MICRO);
        
        /// <summary>LIBPOSTPROC_VERSION_MAJOR = 0x38</summary>
        public const int LIBPOSTPROC_VERSION_MAJOR = 0x38;
        
        /// <summary>LIBPOSTPROC_VERSION_MICRO = 0x64</summary>
        public const int LIBPOSTPROC_VERSION_MICRO = 0x64;
        
        /// <summary>LIBPOSTPROC_VERSION_MINOR = 0x3</summary>
        public const int LIBPOSTPROC_VERSION_MINOR = 0x3;
        
        /// <summary>LIBSWRESAMPLE_BUILD = LIBSWRESAMPLE_VERSION_INT</summary>
        public static readonly int LIBSWRESAMPLE_BUILD = LIBSWRESAMPLE_VERSION_INT;
        
        /// <summary>LIBSWRESAMPLE_IDENT = &quot;SwR&quot;</summary>
        public const string LIBSWRESAMPLE_IDENT = "SwR";
        
        /// <summary>LIBSWRESAMPLE_VERSION = AV_VERSION(LIBSWRESAMPLE_VERSION_MAJOR, LIBSWRESAMPLE_VERSION_MINOR, LIBSWRESAMPLE_VERSION_MICRO)</summary>
        public static readonly string LIBSWRESAMPLE_VERSION = AV_VERSION(LIBSWRESAMPLE_VERSION_MAJOR, LIBSWRESAMPLE_VERSION_MINOR, LIBSWRESAMPLE_VERSION_MICRO);
        
        /// <summary>LIBSWRESAMPLE_VERSION_INT = AV_VERSION_INT(LIBSWRESAMPLE_VERSION_MAJOR, LIBSWRESAMPLE_VERSION_MINOR, LIBSWRESAMPLE_VERSION_MICRO)</summary>
        public static readonly int LIBSWRESAMPLE_VERSION_INT = AV_VERSION_INT(LIBSWRESAMPLE_VERSION_MAJOR, LIBSWRESAMPLE_VERSION_MINOR, LIBSWRESAMPLE_VERSION_MICRO);
        
        /// <summary>LIBSWRESAMPLE_VERSION_MAJOR = 0x4</summary>
        public const int LIBSWRESAMPLE_VERSION_MAJOR = 0x4;
        
        /// <summary>LIBSWRESAMPLE_VERSION_MICRO = 0x64</summary>
        public const int LIBSWRESAMPLE_VERSION_MICRO = 0x64;
        
        /// <summary>LIBSWRESAMPLE_VERSION_MINOR = 0x3</summary>
        public const int LIBSWRESAMPLE_VERSION_MINOR = 0x3;
        
        /// <summary>LIBSWSCALE_BUILD = LIBSWSCALE_VERSION_INT</summary>
        public static readonly int LIBSWSCALE_BUILD = LIBSWSCALE_VERSION_INT;
        
        /// <summary>LIBSWSCALE_IDENT = &quot;SwS&quot;</summary>
        public const string LIBSWSCALE_IDENT = "SwS";
        
        /// <summary>LIBSWSCALE_VERSION = AV_VERSION(LIBSWSCALE_VERSION_MAJOR, LIBSWSCALE_VERSION_MINOR, LIBSWSCALE_VERSION_MICRO)</summary>
        public static readonly string LIBSWSCALE_VERSION = AV_VERSION(LIBSWSCALE_VERSION_MAJOR, LIBSWSCALE_VERSION_MINOR, LIBSWSCALE_VERSION_MICRO);
        
        /// <summary>LIBSWSCALE_VERSION_INT = AV_VERSION_INT(LIBSWSCALE_VERSION_MAJOR, LIBSWSCALE_VERSION_MINOR, LIBSWSCALE_VERSION_MICRO)</summary>
        public static readonly int LIBSWSCALE_VERSION_INT = AV_VERSION_INT(LIBSWSCALE_VERSION_MAJOR, LIBSWSCALE_VERSION_MINOR, LIBSWSCALE_VERSION_MICRO);
        
        /// <summary>LIBSWSCALE_VERSION_MAJOR = 0x6</summary>
        public const int LIBSWSCALE_VERSION_MAJOR = 0x6;
        
        /// <summary>LIBSWSCALE_VERSION_MICRO = 0x64</summary>
        public const int LIBSWSCALE_VERSION_MICRO = 0x64;
        
        /// <summary>LIBSWSCALE_VERSION_MINOR = 0x4</summary>
        public const int LIBSWSCALE_VERSION_MINOR = 0x4;
        
        /// <summary>M_E = 2.7182818284590452354</summary>
        public const double M_E = 2.718281828459045D;
        
        /// <summary>M_LN10 = 2.30258509299404568402</summary>
        public const double M_LN10 = 2.302585092994046D;
        
        /// <summary>M_LN2 = 0.69314718055994530942</summary>
        public const double M_LN2 = 0.6931471805599453D;
        
        /// <summary>M_LOG2_10 = 3.32192809488736234787</summary>
        public const double M_LOG2_10 = 3.321928094887362D;
        
        /// <summary>M_PHI = 1.61803398874989484820</summary>
        public const double M_PHI = 1.618033988749895D;
        
        /// <summary>M_PI = 3.14159265358979323846</summary>
        public const double M_PI = 3.141592653589793D;
        
        /// <summary>M_PI_2 = 1.57079632679489661923</summary>
        public const double M_PI_2 = 1.5707963267948966D;
        
        /// <summary>M_SQRT1_2 = 0.70710678118654752440</summary>
        public const double M_SQRT1_2 = 0.7071067811865476D;
        
        /// <summary>M_SQRT2 = 1.41421356237309504880</summary>
        public const double M_SQRT2 = 1.4142135623730951D;
        
        // public static MKBETAG = (a,b,c,d) ((d) | ((c) << 8) | ((b) << 16) | ((unsigned)(a) << 24));
        
        // public static MKTAG = (a,b,c,d)   ((a) | ((b) << 8) | ((c) << 16) | ((unsigned)(d) << 24));
        
        /// <summary>PARSER_FLAG_COMPLETE_FRAMES = 0x1</summary>
        public const int PARSER_FLAG_COMPLETE_FRAMES = 0x1;
        
        /// <summary>PARSER_FLAG_FETCHED_OFFSET = 0x4</summary>
        public const int PARSER_FLAG_FETCHED_OFFSET = 0x4;
        
        /// <summary>PARSER_FLAG_ONCE = 0x2</summary>
        public const int PARSER_FLAG_ONCE = 0x2;
        
        /// <summary>PARSER_FLAG_USE_CODEC_TS = 0x1000</summary>
        public const int PARSER_FLAG_USE_CODEC_TS = 0x1000;
        
        /// <summary>PP_CPU_CAPS_3DNOW = 0x40000000</summary>
        public const int PP_CPU_CAPS_3DNOW = 0x40000000;
        
        /// <summary>PP_CPU_CAPS_ALTIVEC = 0x10000000</summary>
        public const int PP_CPU_CAPS_ALTIVEC = 0x10000000;
        
        /// <summary>PP_CPU_CAPS_AUTO = 0x80000</summary>
        public const int PP_CPU_CAPS_AUTO = 0x80000;
        
        /// <summary>PP_CPU_CAPS_MMX = 0x80000000U</summary>
        public const uint PP_CPU_CAPS_MMX = 0x80000000U;
        
        /// <summary>PP_CPU_CAPS_MMX2 = 0x20000000</summary>
        public const int PP_CPU_CAPS_MMX2 = 0x20000000;
        
        /// <summary>PP_FORMAT = 0x8</summary>
        public const int PP_FORMAT = 0x8;
        
        /// <summary>PP_FORMAT_411 = 0x2 | PP_FORMAT</summary>
        public const int PP_FORMAT_411 = 0x2 | PP_FORMAT;
        
        /// <summary>PP_FORMAT_420 = 0x11 | PP_FORMAT</summary>
        public const int PP_FORMAT_420 = 0x11 | PP_FORMAT;
        
        /// <summary>PP_FORMAT_422 = 0x1 | PP_FORMAT</summary>
        public const int PP_FORMAT_422 = 0x1 | PP_FORMAT;
        
        /// <summary>PP_FORMAT_440 = 0x10 | PP_FORMAT</summary>
        public const int PP_FORMAT_440 = 0x10 | PP_FORMAT;
        
        /// <summary>PP_FORMAT_444 = 0x0 | PP_FORMAT</summary>
        public const int PP_FORMAT_444 = 0x0 | PP_FORMAT;
        
        /// <summary>PP_PICT_TYPE_QP2 = 0x10</summary>
        public const int PP_PICT_TYPE_QP2 = 0x10;
        
        /// <summary>PP_QUALITY_MAX = 0x6</summary>
        public const int PP_QUALITY_MAX = 0x6;
        
        // public static PUT_UTF16 = (val, tmp, PUT_16BIT){uint32_t in = val;if (in < 0x10000) {tmp = in;PUT_16BIT} else {tmp = 0xD800 | ((in - 0x10000) >> 10);PUT_16BITtmp = 0xDC00 | ((in - 0x10000) & 0x3FF);PUT_16BIT}};
        
        // public static PUT_UTF8 = (val, tmp, PUT_BYTE){int bytes, shift;uint32_t in = val;if (in < 0x80) {tmp = in;PUT_BYTE} else {bytes = (av_log2(in) + 4) / 5;shift = (bytes - 1) * 6;tmp = (256 - (256 >> bytes)) | (in >> shift);PUT_BYTEwhile (shift >= 6) {shift -= 6;tmp = 0x80 | ((in >> shift) & 0x3f);PUT_BYTE}}};
        
        // public static ROUNDED_DIV = (a,b) (((a)>=0 ? (a) + ((b)>>1) : (a) - ((b)>>1))/(b));
        
        // public static RSHIFT = (a,b) ((a) > 0 ? ((a) + ((1<<(b))>>1))>>(b) : ((a) + ((1<<(b))>>1)-1)>>(b));
        
        /// <summary>SLICE_FLAG_ALLOW_FIELD = 0x2</summary>
        public const int SLICE_FLAG_ALLOW_FIELD = 0x2;
        
        /// <summary>SLICE_FLAG_ALLOW_PLANE = 0x4</summary>
        public const int SLICE_FLAG_ALLOW_PLANE = 0x4;
        
        /// <summary>SLICE_FLAG_CODED_ORDER = 0x1</summary>
        public const int SLICE_FLAG_CODED_ORDER = 0x1;
        
        /// <summary>SWR_FLAG_RESAMPLE = 0x1</summary>
        public const int SWR_FLAG_RESAMPLE = 0x1;
        
        /// <summary>SWS_ACCURATE_RND = 0x40000</summary>
        public const int SWS_ACCURATE_RND = 0x40000;
        
        /// <summary>SWS_AREA = 0x20</summary>
        public const int SWS_AREA = 0x20;
        
        /// <summary>SWS_BICUBIC = 0x4</summary>
        public const int SWS_BICUBIC = 0x4;
        
        /// <summary>SWS_BICUBLIN = 0x40</summary>
        public const int SWS_BICUBLIN = 0x40;
        
        /// <summary>SWS_BILINEAR = 0x2</summary>
        public const int SWS_BILINEAR = 0x2;
        
        /// <summary>SWS_BITEXACT = 0x80000</summary>
        public const int SWS_BITEXACT = 0x80000;
        
        /// <summary>SWS_CS_BT2020 = 0x9</summary>
        public const int SWS_CS_BT2020 = 0x9;
        
        /// <summary>SWS_CS_DEFAULT = 0x5</summary>
        public const int SWS_CS_DEFAULT = 0x5;
        
        /// <summary>SWS_CS_FCC = 0x4</summary>
        public const int SWS_CS_FCC = 0x4;
        
        /// <summary>SWS_CS_ITU601 = 0x5</summary>
        public const int SWS_CS_ITU601 = 0x5;
        
        /// <summary>SWS_CS_ITU624 = 0x5</summary>
        public const int SWS_CS_ITU624 = 0x5;
        
        /// <summary>SWS_CS_ITU709 = 0x1</summary>
        public const int SWS_CS_ITU709 = 0x1;
        
        /// <summary>SWS_CS_SMPTE170M = 0x5</summary>
        public const int SWS_CS_SMPTE170M = 0x5;
        
        /// <summary>SWS_CS_SMPTE240M = 0x7</summary>
        public const int SWS_CS_SMPTE240M = 0x7;
        
        /// <summary>SWS_DIRECT_BGR = 0x8000</summary>
        public const int SWS_DIRECT_BGR = 0x8000;
        
        /// <summary>SWS_ERROR_DIFFUSION = 0x800000</summary>
        public const int SWS_ERROR_DIFFUSION = 0x800000;
        
        /// <summary>SWS_FAST_BILINEAR = 0x1</summary>
        public const int SWS_FAST_BILINEAR = 0x1;
        
        /// <summary>SWS_FULL_CHR_H_INP = 0x4000</summary>
        public const int SWS_FULL_CHR_H_INP = 0x4000;
        
        /// <summary>SWS_FULL_CHR_H_INT = 0x2000</summary>
        public const int SWS_FULL_CHR_H_INT = 0x2000;
        
        /// <summary>SWS_GAUSS = 0x80</summary>
        public const int SWS_GAUSS = 0x80;
        
        /// <summary>SWS_LANCZOS = 0x200</summary>
        public const int SWS_LANCZOS = 0x200;
        
        /// <summary>SWS_MAX_REDUCE_CUTOFF = 0.002D</summary>
        public const double SWS_MAX_REDUCE_CUTOFF = 0.002D;
        
        /// <summary>SWS_PARAM_DEFAULT = 0x1e240</summary>
        public const int SWS_PARAM_DEFAULT = 0x1e240;
        
        /// <summary>SWS_POINT = 0x10</summary>
        public const int SWS_POINT = 0x10;
        
        /// <summary>SWS_PRINT_INFO = 0x1000</summary>
        public const int SWS_PRINT_INFO = 0x1000;
        
        /// <summary>SWS_SINC = 0x100</summary>
        public const int SWS_SINC = 0x100;
        
        /// <summary>SWS_SPLINE = 0x400</summary>
        public const int SWS_SPLINE = 0x400;
        
        /// <summary>SWS_SRC_V_CHR_DROP_MASK = 0x30000</summary>
        public const int SWS_SRC_V_CHR_DROP_MASK = 0x30000;
        
        /// <summary>SWS_SRC_V_CHR_DROP_SHIFT = 0x10</summary>
        public const int SWS_SRC_V_CHR_DROP_SHIFT = 0x10;
        
        /// <summary>SWS_X = 0x8</summary>
        public const int SWS_X = 0x8;
    }
}
