using System;
using System.Runtime.InteropServices;

namespace FFmpeg.NET.Internal
{
    public unsafe static partial class NativeMethods
    {
        private const Libraries AVUTIL = Libraries.AVUTIL;
        private const Libraries SWSCALE = Libraries.SWSCALE;
        private const Libraries POSTPROC = Libraries.POSTPROC;
        private const Libraries SWRESAMPLE = Libraries.SWRESAMPLE;
        private const Libraries AVCODEC = Libraries.AVCODEC;
        private const Libraries AVFORMAT = Libraries.AVFORMAT;
        private const Libraries AVFILTER = Libraries.AVFILTER;
        private const Libraries AVDEVICE = Libraries.AVDEVICE;
        
        [NativeMethod(AVCODEC, "av_codec_is_decoder")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_codec_is_decoder_delegate(AVCodec* @codec);

        [NativeMethod(AVCODEC, "av_codec_is_encoder")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_codec_is_encoder_delegate(AVCodec* @codec);

        [NativeMethod(AVCODEC, "av_codec_iterate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodec* av_codec_iterate_delegate(void** @opaque);

        [NativeMethod(AVCODEC, "av_cpb_properties_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCPBProperties* av_cpb_properties_alloc_delegate(ulong* @size);

        [NativeMethod(AVCODEC, "av_d3d11va_alloc_context")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVD3D11VAContext* av_d3d11va_alloc_context_delegate();

        [NativeMethod(AVCODEC, "av_fast_padded_malloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_fast_padded_malloc_delegate(void* @ptr, uint* @size, ulong @min_size);

        [NativeMethod(AVCODEC, "av_fast_padded_mallocz")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_fast_padded_mallocz_delegate(void* @ptr, uint* @size, ulong @min_size);

        [NativeMethod(AVCODEC, "av_get_audio_frame_duration")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_audio_frame_duration_delegate(AVCodecContext* @avctx, int @frame_bytes);

        [NativeMethod(AVCODEC, "av_get_audio_frame_duration2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_audio_frame_duration2_delegate(AVCodecParameters* @par, int @frame_bytes);

        [NativeMethod(AVCODEC, "av_get_bits_per_sample")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_bits_per_sample_delegate(AVCodecID @codec_id);

        [NativeMethod(AVCODEC, "av_get_exact_bits_per_sample")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_exact_bits_per_sample_delegate(AVCodecID @codec_id);

        [NativeMethod(AVCODEC, "av_get_pcm_codec")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecID av_get_pcm_codec_delegate(AVSampleFormat @fmt, int @be);

        [NativeMethod(AVCODEC, "av_get_profile_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_get_profile_name_delegate(AVCodec* @codec, int @profile);

        [NativeMethod(AVCODEC, "av_grow_packet")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_grow_packet_delegate(AVPacket* @pkt, int @grow_by);

        [NativeMethod(AVCODEC, "av_init_packet")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_init_packet_delegate(AVPacket* @pkt);

        [NativeMethod(AVCODEC, "av_new_packet")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_new_packet_delegate(AVPacket* @pkt, int @size);

        [NativeMethod(AVCODEC, "av_packet_add_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_packet_add_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size);

        [NativeMethod(AVCODEC, "av_packet_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVPacket* av_packet_alloc_delegate();

        [NativeMethod(AVCODEC, "av_packet_clone")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVPacket* av_packet_clone_delegate(AVPacket* @src);

        [NativeMethod(AVCODEC, "av_packet_copy_props")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_packet_copy_props_delegate(AVPacket* @dst, AVPacket* @src);

        [NativeMethod(AVCODEC, "av_packet_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_packet_free_delegate(AVPacket** @pkt);

        [NativeMethod(AVCODEC, "av_packet_free_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_packet_free_side_data_delegate(AVPacket* @pkt);

        [NativeMethod(AVCODEC, "av_packet_from_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_packet_from_data_delegate(AVPacket* @pkt, byte* @data, int @size);

        [NativeMethod(AVCODEC, "av_packet_get_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_packet_get_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, ulong* @size);

        [NativeMethod(AVCODEC, "av_packet_make_refcounted")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_packet_make_refcounted_delegate(AVPacket* @pkt);

        [NativeMethod(AVCODEC, "av_packet_make_writable")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_packet_make_writable_delegate(AVPacket* @pkt);

        [NativeMethod(AVCODEC, "av_packet_move_ref")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_packet_move_ref_delegate(AVPacket* @dst, AVPacket* @src);

        [NativeMethod(AVCODEC, "av_packet_new_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_packet_new_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size);

        [NativeMethod(AVCODEC, "av_packet_pack_dictionary")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_packet_pack_dictionary_delegate(AVDictionary* @dict, ulong* @size);

        [NativeMethod(AVCODEC, "av_packet_ref")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_packet_ref_delegate(AVPacket* @dst, AVPacket* @src);

        [NativeMethod(AVCODEC, "av_packet_rescale_ts")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_packet_rescale_ts_delegate(AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst);

        [NativeMethod(AVCODEC, "av_packet_shrink_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_packet_shrink_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size);

        [NativeMethod(AVCODEC, "av_packet_side_data_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_packet_side_data_name_delegate(AVPacketSideDataType @type);

        [NativeMethod(AVCODEC, "av_packet_unpack_dictionary")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_packet_unpack_dictionary_delegate(byte* @data, ulong @size, AVDictionary** @dict);

        [NativeMethod(AVCODEC, "av_packet_unref")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_packet_unref_delegate(AVPacket* @pkt);

        [NativeMethod(AVCODEC, "av_parser_close")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_parser_close_delegate(AVCodecParserContext* @s);

        [NativeMethod(AVCODEC, "av_parser_init")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecParserContext* av_parser_init_delegate(int @codec_id);

        [NativeMethod(AVCODEC, "av_parser_iterate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecParser* av_parser_iterate_delegate(void** @opaque);

        [NativeMethod(AVCODEC, "av_parser_parse2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_parser_parse2_delegate(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos);

        [NativeMethod(AVCODEC, "av_shrink_packet")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_shrink_packet_delegate(AVPacket* @pkt, int @size);

        [NativeMethod(AVCODEC, "av_xiphlacing")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint av_xiphlacing_delegate(byte* @s, uint @v);

        [NativeMethod(AVCODEC, "avcodec_align_dimensions")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avcodec_align_dimensions_delegate(AVCodecContext* @s, int* @width, int* @height);

        [NativeMethod(AVCODEC, "avcodec_align_dimensions2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avcodec_align_dimensions2_delegate(AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align);

        [NativeMethod(AVCODEC, "avcodec_alloc_context3")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecContext* avcodec_alloc_context3_delegate(AVCodec* @codec);

        [NativeMethod(AVCODEC, "avcodec_chroma_pos_to_enum")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVChromaLocation avcodec_chroma_pos_to_enum_delegate(int @xpos, int @ypos);

        [NativeMethod(AVCODEC, "avcodec_close")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_close_delegate(AVCodecContext* @avctx);

        [NativeMethod(AVCODEC, "avcodec_configuration")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avcodec_configuration_delegate();

        [NativeMethod(AVCODEC, "avcodec_decode_subtitle2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_decode_subtitle2_delegate(AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt);

        [NativeMethod(AVCODEC, "avcodec_default_execute")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_default_execute_delegate(AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size);

        [NativeMethod(AVCODEC, "avcodec_default_execute2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_default_execute2_delegate(AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count);

        [NativeMethod(AVCODEC, "avcodec_default_get_buffer2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_default_get_buffer2_delegate(AVCodecContext* @s, AVFrame* @frame, int @flags);

        [NativeMethod(AVCODEC, "avcodec_default_get_encode_buffer")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_default_get_encode_buffer_delegate(AVCodecContext* @s, AVPacket* @pkt, int @flags);

        [NativeMethod(AVCODEC, "avcodec_default_get_format")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVPixelFormat avcodec_default_get_format_delegate(AVCodecContext* @s, AVPixelFormat* @fmt);

        [NativeMethod(AVCODEC, "avcodec_descriptor_get")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecDescriptor* avcodec_descriptor_get_delegate(AVCodecID @id);

        [NativeMethod(AVCODEC, "avcodec_descriptor_get_by_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecDescriptor* avcodec_descriptor_get_by_name_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVCODEC, "avcodec_descriptor_next")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecDescriptor* avcodec_descriptor_next_delegate(AVCodecDescriptor* @prev);

        [NativeMethod(AVCODEC, "avcodec_encode_subtitle")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_encode_subtitle_delegate(AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub);

        [NativeMethod(AVCODEC, "avcodec_enum_to_chroma_pos")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_enum_to_chroma_pos_delegate(int* @xpos, int* @ypos, AVChromaLocation @pos);

        [NativeMethod(AVCODEC, "avcodec_fill_audio_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_fill_audio_frame_delegate(AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align);

        [NativeMethod(AVCODEC, "avcodec_find_best_pix_fmt_of_list")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVPixelFormat avcodec_find_best_pix_fmt_of_list_delegate(AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);

        [NativeMethod(AVCODEC, "avcodec_find_decoder")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodec* avcodec_find_decoder_delegate(AVCodecID @id);

        [NativeMethod(AVCODEC, "avcodec_find_decoder_by_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodec* avcodec_find_decoder_by_name_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVCODEC, "avcodec_find_encoder")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodec* avcodec_find_encoder_delegate(AVCodecID @id);

        [NativeMethod(AVCODEC, "avcodec_find_encoder_by_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodec* avcodec_find_encoder_by_name_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVCODEC, "avcodec_flush_buffers")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avcodec_flush_buffers_delegate(AVCodecContext* @avctx);

        [NativeMethod(AVCODEC, "avcodec_free_context")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avcodec_free_context_delegate(AVCodecContext** @avctx);

        [NativeMethod(AVCODEC, "avcodec_get_class")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVClass* avcodec_get_class_delegate();

        [NativeMethod(AVCODEC, "avcodec_get_frame_class")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVClass* avcodec_get_frame_class_delegate();

        [NativeMethod(AVCODEC, "avcodec_get_hw_config")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecHWConfig* avcodec_get_hw_config_delegate(AVCodec* @codec, int @index);

        [NativeMethod(AVCODEC, "avcodec_get_hw_frames_parameters")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_get_hw_frames_parameters_delegate(AVCodecContext* @avctx, AVBufferRef* @device_ref, AVPixelFormat @hw_pix_fmt, AVBufferRef** @out_frames_ref);

        [NativeMethod(AVCODEC, "avcodec_get_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avcodec_get_name_delegate(AVCodecID @id);

        [NativeMethod(AVCODEC, "avcodec_get_subtitle_rect_class")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVClass* avcodec_get_subtitle_rect_class_delegate();

        [NativeMethod(AVCODEC, "avcodec_get_type")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVMediaType avcodec_get_type_delegate(AVCodecID @codec_id);

        [NativeMethod(AVCODEC, "avcodec_is_open")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_is_open_delegate(AVCodecContext* @s);

        [NativeMethod(AVCODEC, "avcodec_license")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avcodec_license_delegate();

        [NativeMethod(AVCODEC, "avcodec_open2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_open2_delegate(AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options);

        [NativeMethod(AVCODEC, "avcodec_parameters_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecParameters* avcodec_parameters_alloc_delegate();

        [NativeMethod(AVCODEC, "avcodec_parameters_copy")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_parameters_copy_delegate(AVCodecParameters* @dst, AVCodecParameters* @src);

        [NativeMethod(AVCODEC, "avcodec_parameters_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avcodec_parameters_free_delegate(AVCodecParameters** @par);

        [NativeMethod(AVCODEC, "avcodec_parameters_from_context")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_parameters_from_context_delegate(AVCodecParameters* @par, AVCodecContext* @codec);

        [NativeMethod(AVCODEC, "avcodec_parameters_to_context")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_parameters_to_context_delegate(AVCodecContext* @codec, AVCodecParameters* @par);

        [NativeMethod(AVCODEC, "avcodec_pix_fmt_to_codec_tag")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avcodec_pix_fmt_to_codec_tag_delegate(AVPixelFormat @pix_fmt);

        [NativeMethod(AVCODEC, "avcodec_profile_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avcodec_profile_name_delegate(AVCodecID @codec_id, int @profile);

        [NativeMethod(AVCODEC, "avcodec_receive_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_receive_frame_delegate(AVCodecContext* @avctx, AVFrame* @frame);

        [NativeMethod(AVCODEC, "avcodec_receive_packet")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_receive_packet_delegate(AVCodecContext* @avctx, AVPacket* @avpkt);

        [NativeMethod(AVCODEC, "avcodec_send_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_send_frame_delegate(AVCodecContext* @avctx, AVFrame* @frame);

        [NativeMethod(AVCODEC, "avcodec_send_packet")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avcodec_send_packet_delegate(AVCodecContext* @avctx, AVPacket* @avpkt);

        [NativeMethod(AVCODEC, "avcodec_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avcodec_string_delegate(byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode);

        [NativeMethod(AVCODEC, "avcodec_version")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avcodec_version_delegate();

        [NativeMethod(AVCODEC, "avsubtitle_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avsubtitle_free_delegate(AVSubtitle* @sub);

        [NativeMethod(AVDEVICE, "av_input_audio_device_next")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVInputFormat* av_input_audio_device_next_delegate(AVInputFormat* @d);

        [NativeMethod(AVDEVICE, "av_input_video_device_next")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVInputFormat* av_input_video_device_next_delegate(AVInputFormat* @d);

        [NativeMethod(AVDEVICE, "av_output_audio_device_next")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVOutputFormat* av_output_audio_device_next_delegate(AVOutputFormat* @d);

        [NativeMethod(AVDEVICE, "av_output_video_device_next")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVOutputFormat* av_output_video_device_next_delegate(AVOutputFormat* @d);

        [NativeMethod(AVDEVICE, "avdevice_app_to_dev_control_message")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avdevice_app_to_dev_control_message_delegate(AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size);

        [NativeMethod(AVDEVICE, "avdevice_capabilities_create")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avdevice_capabilities_create_delegate(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s, AVDictionary** @device_options);

        [NativeMethod(AVDEVICE, "avdevice_capabilities_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avdevice_capabilities_free_delegate(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s);

        [NativeMethod(AVDEVICE, "avdevice_configuration")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avdevice_configuration_delegate();

        [NativeMethod(AVDEVICE, "avdevice_dev_to_app_control_message")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avdevice_dev_to_app_control_message_delegate(AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size);

        [NativeMethod(AVDEVICE, "avdevice_free_list_devices")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avdevice_free_list_devices_delegate(AVDeviceInfoList** @device_list);

        [NativeMethod(AVDEVICE, "avdevice_license")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avdevice_license_delegate();

        [NativeMethod(AVDEVICE, "avdevice_list_devices")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avdevice_list_devices_delegate(AVFormatContext* @s, AVDeviceInfoList** @device_list);

        [NativeMethod(AVDEVICE, "avdevice_list_input_sources")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avdevice_list_input_sources_delegate(AVInputFormat* @device, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);

        [NativeMethod(AVDEVICE, "avdevice_list_output_sinks")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avdevice_list_output_sinks_delegate(AVOutputFormat* @device, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);

        [NativeMethod(AVDEVICE, "avdevice_register_all")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avdevice_register_all_delegate();

        [NativeMethod(AVDEVICE, "avdevice_version")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avdevice_version_delegate();

        [NativeMethod(AVFILTER, "av_abuffersink_params_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVABufferSinkParams* av_abuffersink_params_alloc_delegate();

        [NativeMethod(AVFILTER, "av_buffersink_get_channel_layout")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate ulong av_buffersink_get_channel_layout_delegate(AVFilterContext* @ctx);

        [NativeMethod(AVFILTER, "av_buffersink_get_channels")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersink_get_channels_delegate(AVFilterContext* @ctx);

        [NativeMethod(AVFILTER, "av_buffersink_get_format")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersink_get_format_delegate(AVFilterContext* @ctx);

        [NativeMethod(AVFILTER, "av_buffersink_get_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersink_get_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);

        [NativeMethod(AVFILTER, "av_buffersink_get_frame_flags")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersink_get_frame_flags_delegate(AVFilterContext* @ctx, AVFrame* @frame, int @flags);

        [NativeMethod(AVFILTER, "av_buffersink_get_frame_rate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_buffersink_get_frame_rate_delegate(AVFilterContext* @ctx);

        [NativeMethod(AVFILTER, "av_buffersink_get_h")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersink_get_h_delegate(AVFilterContext* @ctx);

        [NativeMethod(AVFILTER, "av_buffersink_get_hw_frames_ctx")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferRef* av_buffersink_get_hw_frames_ctx_delegate(AVFilterContext* @ctx);

        [NativeMethod(AVFILTER, "av_buffersink_get_sample_aspect_ratio")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_buffersink_get_sample_aspect_ratio_delegate(AVFilterContext* @ctx);

        [NativeMethod(AVFILTER, "av_buffersink_get_sample_rate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersink_get_sample_rate_delegate(AVFilterContext* @ctx);

        [NativeMethod(AVFILTER, "av_buffersink_get_samples")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersink_get_samples_delegate(AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples);

        [NativeMethod(AVFILTER, "av_buffersink_get_time_base")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_buffersink_get_time_base_delegate(AVFilterContext* @ctx);

        [NativeMethod(AVFILTER, "av_buffersink_get_type")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVMediaType av_buffersink_get_type_delegate(AVFilterContext* @ctx);

        [NativeMethod(AVFILTER, "av_buffersink_get_w")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersink_get_w_delegate(AVFilterContext* @ctx);

        [NativeMethod(AVFILTER, "av_buffersink_params_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferSinkParams* av_buffersink_params_alloc_delegate();

        [NativeMethod(AVFILTER, "av_buffersink_set_frame_size")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_buffersink_set_frame_size_delegate(AVFilterContext* @ctx, uint @frame_size);

        [NativeMethod(AVFILTER, "av_buffersrc_add_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersrc_add_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);

        [NativeMethod(AVFILTER, "av_buffersrc_add_frame_flags")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersrc_add_frame_flags_delegate(AVFilterContext* @buffer_src, AVFrame* @frame, int @flags);

        [NativeMethod(AVFILTER, "av_buffersrc_close")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersrc_close_delegate(AVFilterContext* @ctx, long @pts, uint @flags);

        [NativeMethod(AVFILTER, "av_buffersrc_get_nb_failed_requests")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint av_buffersrc_get_nb_failed_requests_delegate(AVFilterContext* @buffer_src);

        [NativeMethod(AVFILTER, "av_buffersrc_parameters_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferSrcParameters* av_buffersrc_parameters_alloc_delegate();

        [NativeMethod(AVFILTER, "av_buffersrc_parameters_set")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersrc_parameters_set_delegate(AVFilterContext* @ctx, AVBufferSrcParameters* @param);

        [NativeMethod(AVFILTER, "av_buffersrc_write_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffersrc_write_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);

        [NativeMethod(AVFILTER, "av_filter_iterate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFilter* av_filter_iterate_delegate(void** @opaque);

        [NativeMethod(AVFILTER, "avfilter_config_links")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_config_links_delegate(AVFilterContext* @filter);

        [NativeMethod(AVFILTER, "avfilter_configuration")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avfilter_configuration_delegate();

        [NativeMethod(AVFILTER, "avfilter_filter_pad_count")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avfilter_filter_pad_count_delegate(AVFilter* @filter, int @is_output);

        [NativeMethod(AVFILTER, "avfilter_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avfilter_free_delegate(AVFilterContext* @filter);

        [NativeMethod(AVFILTER, "avfilter_get_by_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFilter* avfilter_get_by_name_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVFILTER, "avfilter_get_class")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVClass* avfilter_get_class_delegate();

        [NativeMethod(AVFILTER, "avfilter_graph_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFilterGraph* avfilter_graph_alloc_delegate();

        [NativeMethod(AVFILTER, "avfilter_graph_alloc_filter")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFilterContext* avfilter_graph_alloc_filter_delegate(AVFilterGraph* @graph, AVFilter* @filter, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVFILTER, "avfilter_graph_config")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_graph_config_delegate(AVFilterGraph* @graphctx, void* @log_ctx);

        [NativeMethod(AVFILTER, "avfilter_graph_create_filter")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_graph_create_filter_delegate(AVFilterContext** @filt_ctx, AVFilter* @filt, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @args, void* @opaque, AVFilterGraph* @graph_ctx);

        [NativeMethod(AVFILTER, "avfilter_graph_dump")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* avfilter_graph_dump_delegate(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @options);

        [NativeMethod(AVFILTER, "avfilter_graph_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avfilter_graph_free_delegate(AVFilterGraph** @graph);

        [NativeMethod(AVFILTER, "avfilter_graph_get_filter")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFilterContext* avfilter_graph_get_filter_delegate(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVFILTER, "avfilter_graph_parse")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_graph_parse_delegate(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx);

        [NativeMethod(AVFILTER, "avfilter_graph_parse_ptr")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_graph_parse_ptr_delegate(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx);

        [NativeMethod(AVFILTER, "avfilter_graph_parse2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_graph_parse2_delegate(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs);

        [NativeMethod(AVFILTER, "avfilter_graph_queue_command")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_graph_queue_command_delegate(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @target, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @cmd, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @arg, int @flags, double @ts);

        [NativeMethod(AVFILTER, "avfilter_graph_request_oldest")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_graph_request_oldest_delegate(AVFilterGraph* @graph);

        [NativeMethod(AVFILTER, "avfilter_graph_send_command")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_graph_send_command_delegate(AVFilterGraph* @graph, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @target, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @cmd, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @arg, byte* @res, int @res_len, int @flags);

        [NativeMethod(AVFILTER, "avfilter_graph_set_auto_convert")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avfilter_graph_set_auto_convert_delegate(AVFilterGraph* @graph, uint @flags);

        [NativeMethod(AVFILTER, "avfilter_init_dict")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_init_dict_delegate(AVFilterContext* @ctx, AVDictionary** @options);

        [NativeMethod(AVFILTER, "avfilter_init_str")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_init_str_delegate(AVFilterContext* @ctx, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @args);

        [NativeMethod(AVFILTER, "avfilter_inout_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFilterInOut* avfilter_inout_alloc_delegate();

        [NativeMethod(AVFILTER, "avfilter_inout_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avfilter_inout_free_delegate(AVFilterInOut** @inout);

        [NativeMethod(AVFILTER, "avfilter_insert_filter")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_insert_filter_delegate(AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx);

        [NativeMethod(AVFILTER, "avfilter_license")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avfilter_license_delegate();

        [NativeMethod(AVFILTER, "avfilter_link")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_link_delegate(AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad);

        [NativeMethod(AVFILTER, "avfilter_link_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avfilter_link_free_delegate(AVFilterLink** @link);

        [NativeMethod(AVFILTER, "avfilter_pad_count")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_pad_count_delegate(AVFilterPad* @pads);

        [NativeMethod(AVFILTER, "avfilter_pad_get_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avfilter_pad_get_name_delegate(AVFilterPad* @pads, int @pad_idx);

        [NativeMethod(AVFILTER, "avfilter_pad_get_type")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVMediaType avfilter_pad_get_type_delegate(AVFilterPad* @pads, int @pad_idx);

        [NativeMethod(AVFILTER, "avfilter_process_command")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avfilter_process_command_delegate(AVFilterContext* @filter, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @cmd, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @arg, byte* @res, int @res_len, int @flags);

        [NativeMethod(AVFILTER, "avfilter_version")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avfilter_version_delegate();

        [NativeMethod(AVFORMAT, "av_add_index_entry")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_add_index_entry_delegate(AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags);

        [NativeMethod(AVFORMAT, "av_append_packet")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_append_packet_delegate(AVIOContext* @s, AVPacket* @pkt, int @size);

        [NativeMethod(AVFORMAT, "av_codec_get_id")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecID av_codec_get_id_delegate(AVCodecTag** @tags, uint @tag);

        [NativeMethod(AVFORMAT, "av_codec_get_tag")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint av_codec_get_tag_delegate(AVCodecTag** @tags, AVCodecID @id);

        [NativeMethod(AVFORMAT, "av_codec_get_tag2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_codec_get_tag2_delegate(AVCodecTag** @tags, AVCodecID @id, uint* @tag);

        [NativeMethod(AVFORMAT, "av_demuxer_iterate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVInputFormat* av_demuxer_iterate_delegate(void** @opaque);

        [NativeMethod(AVFORMAT, "av_disposition_from_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_disposition_from_string_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @disp);

        [NativeMethod(AVFORMAT, "av_disposition_to_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_disposition_to_string_delegate(int @disposition);

        [NativeMethod(AVFORMAT, "av_dump_format")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_dump_format_delegate(AVFormatContext* @ic, int @index, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @is_output);

        [NativeMethod(AVFORMAT, "av_filename_number_test")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_filename_number_test_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename);

        [NativeMethod(AVFORMAT, "av_find_best_stream")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_find_best_stream_delegate(AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags);

        [NativeMethod(AVFORMAT, "av_find_default_stream_index")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_find_default_stream_index_delegate(AVFormatContext* @s);

        [NativeMethod(AVFORMAT, "av_find_input_format")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVInputFormat* av_find_input_format_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @short_name);

        [NativeMethod(AVFORMAT, "av_find_program_from_stream")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVProgram* av_find_program_from_stream_delegate(AVFormatContext* @ic, AVProgram* @last, int @s);

        [NativeMethod(AVFORMAT, "av_fmt_ctx_get_duration_estimation_method")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method_delegate(AVFormatContext* @ctx);

        [NativeMethod(AVFORMAT, "av_format_inject_global_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_format_inject_global_side_data_delegate(AVFormatContext* @s);

        [NativeMethod(AVFORMAT, "av_get_frame_filename")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_frame_filename_delegate(byte* @buf, int @buf_size, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @path, int @number);

        [NativeMethod(AVFORMAT, "av_get_frame_filename2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_frame_filename2_delegate(byte* @buf, int @buf_size, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @path, int @number, int @flags);

        [NativeMethod(AVFORMAT, "av_get_output_timestamp")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_output_timestamp_delegate(AVFormatContext* @s, int @stream, long* @dts, long* @wall);

        [NativeMethod(AVFORMAT, "av_get_packet")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_packet_delegate(AVIOContext* @s, AVPacket* @pkt, int @size);

        [NativeMethod(AVFORMAT, "av_guess_codec")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecID av_guess_codec_delegate(AVOutputFormat* @fmt, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @short_name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @mime_type, AVMediaType @type);

        [NativeMethod(AVFORMAT, "av_guess_format")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVOutputFormat* av_guess_format_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @short_name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @mime_type);

        [NativeMethod(AVFORMAT, "av_guess_frame_rate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_guess_frame_rate_delegate(AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame);

        [NativeMethod(AVFORMAT, "av_guess_sample_aspect_ratio")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_guess_sample_aspect_ratio_delegate(AVFormatContext* @format, AVStream* @stream, AVFrame* @frame);

        [NativeMethod(AVFORMAT, "av_hex_dump")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_hex_dump_delegate(_iobuf* @f, byte* @buf, int @size);

        [NativeMethod(AVFORMAT, "av_hex_dump_log")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_hex_dump_log_delegate(void* @avcl, int @level, byte* @buf, int @size);

        [NativeMethod(AVFORMAT, "av_index_search_timestamp")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_index_search_timestamp_delegate(AVStream* @st, long @timestamp, int @flags);

        [NativeMethod(AVFORMAT, "av_interleaved_write_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_interleaved_write_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);

        [NativeMethod(AVFORMAT, "av_interleaved_write_uncoded_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_interleaved_write_uncoded_frame_delegate(AVFormatContext* @s, int @stream_index, AVFrame* @frame);

        [NativeMethod(AVFORMAT, "av_match_ext")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_match_ext_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @extensions);

        [NativeMethod(AVFORMAT, "av_muxer_iterate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVOutputFormat* av_muxer_iterate_delegate(void** @opaque);

        [NativeMethod(AVFORMAT, "av_new_program")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVProgram* av_new_program_delegate(AVFormatContext* @s, int @id);

        [NativeMethod(AVFORMAT, "av_pkt_dump_log2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_pkt_dump_log2_delegate(void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st);

        [NativeMethod(AVFORMAT, "av_pkt_dump2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_pkt_dump2_delegate(_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st);

        [NativeMethod(AVFORMAT, "av_probe_input_buffer")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_probe_input_buffer_delegate(AVIOContext* @pb, AVInputFormat** @fmt, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size);

        [NativeMethod(AVFORMAT, "av_probe_input_buffer2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_probe_input_buffer2_delegate(AVIOContext* @pb, AVInputFormat** @fmt, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size);

        [NativeMethod(AVFORMAT, "av_probe_input_format")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVInputFormat* av_probe_input_format_delegate(AVProbeData* @pd, int @is_opened);

        [NativeMethod(AVFORMAT, "av_probe_input_format2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVInputFormat* av_probe_input_format2_delegate(AVProbeData* @pd, int @is_opened, int* @score_max);

        [NativeMethod(AVFORMAT, "av_probe_input_format3")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVInputFormat* av_probe_input_format3_delegate(AVProbeData* @pd, int @is_opened, int* @score_ret);

        [NativeMethod(AVFORMAT, "av_program_add_stream_index")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_program_add_stream_index_delegate(AVFormatContext* @ac, int @progid, uint @idx);

        [NativeMethod(AVFORMAT, "av_read_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_read_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);

        [NativeMethod(AVFORMAT, "av_read_pause")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_read_pause_delegate(AVFormatContext* @s);

        [NativeMethod(AVFORMAT, "av_read_play")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_read_play_delegate(AVFormatContext* @s);

        [NativeMethod(AVFORMAT, "av_sdp_create")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_sdp_create_delegate(AVFormatContext** @ac, int @n_files, byte* @buf, int @size);

        [NativeMethod(AVFORMAT, "av_seek_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_seek_frame_delegate(AVFormatContext* @s, int @stream_index, long @timestamp, int @flags);

        [NativeMethod(AVFORMAT, "av_stream_add_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_stream_add_side_data_delegate(AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size);

        [NativeMethod(AVFORMAT, "av_stream_get_class")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVClass* av_stream_get_class_delegate();

        [NativeMethod(AVFORMAT, "av_stream_get_codec_timebase")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_stream_get_codec_timebase_delegate(AVStream* @st);

        [NativeMethod(AVFORMAT, "av_stream_get_end_pts")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_stream_get_end_pts_delegate(AVStream* @st);

        [NativeMethod(AVFORMAT, "av_stream_get_parser")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecParserContext* av_stream_get_parser_delegate(AVStream* @s);

        [NativeMethod(AVFORMAT, "av_stream_get_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_stream_get_side_data_delegate(AVStream* @stream, AVPacketSideDataType @type, ulong* @size);

        [NativeMethod(AVFORMAT, "av_stream_new_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_stream_new_side_data_delegate(AVStream* @stream, AVPacketSideDataType @type, ulong @size);

        [NativeMethod(AVFORMAT, "av_url_split")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_url_split_delegate(byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url);

        [NativeMethod(AVFORMAT, "av_write_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_write_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);

        [NativeMethod(AVFORMAT, "av_write_trailer")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_write_trailer_delegate(AVFormatContext* @s);

        [NativeMethod(AVFORMAT, "av_write_uncoded_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_write_uncoded_frame_delegate(AVFormatContext* @s, int @stream_index, AVFrame* @frame);

        [NativeMethod(AVFORMAT, "av_write_uncoded_frame_query")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_write_uncoded_frame_query_delegate(AVFormatContext* @s, int @stream_index);

        [NativeMethod(AVFORMAT, "avformat_alloc_context")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFormatContext* avformat_alloc_context_delegate();

        [NativeMethod(AVFORMAT, "avformat_alloc_output_context2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_alloc_output_context2_delegate(AVFormatContext** @ctx, AVOutputFormat* @oformat, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @format_name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename);

        [NativeMethod(AVFORMAT, "avformat_close_input")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avformat_close_input_delegate(AVFormatContext** @s);

        [NativeMethod(AVFORMAT, "avformat_configuration")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avformat_configuration_delegate();

        [NativeMethod(AVFORMAT, "avformat_find_stream_info")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_find_stream_info_delegate(AVFormatContext* @ic, AVDictionary** @options);

        [NativeMethod(AVFORMAT, "avformat_flush")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_flush_delegate(AVFormatContext* @s);

        [NativeMethod(AVFORMAT, "avformat_free_context")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avformat_free_context_delegate(AVFormatContext* @s);

        [NativeMethod(AVFORMAT, "avformat_get_class")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVClass* avformat_get_class_delegate();

        [NativeMethod(AVFORMAT, "avformat_get_mov_audio_tags")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecTag* avformat_get_mov_audio_tags_delegate();

        [NativeMethod(AVFORMAT, "avformat_get_mov_video_tags")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecTag* avformat_get_mov_video_tags_delegate();

        [NativeMethod(AVFORMAT, "avformat_get_riff_audio_tags")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecTag* avformat_get_riff_audio_tags_delegate();

        [NativeMethod(AVFORMAT, "avformat_get_riff_video_tags")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVCodecTag* avformat_get_riff_video_tags_delegate();

        [NativeMethod(AVFORMAT, "avformat_index_get_entries_count")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_index_get_entries_count_delegate(AVStream* @st);

        [NativeMethod(AVFORMAT, "avformat_index_get_entry")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVIndexEntry* avformat_index_get_entry_delegate(AVStream* @st, int @idx);

        [NativeMethod(AVFORMAT, "avformat_index_get_entry_from_timestamp")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVIndexEntry* avformat_index_get_entry_from_timestamp_delegate(AVStream* @st, long @wanted_timestamp, int @flags);

        [NativeMethod(AVFORMAT, "avformat_init_output")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_init_output_delegate(AVFormatContext* @s, AVDictionary** @options);

        [NativeMethod(AVFORMAT, "avformat_license")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avformat_license_delegate();

        [NativeMethod(AVFORMAT, "avformat_match_stream_specifier")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_match_stream_specifier_delegate(AVFormatContext* @s, AVStream* @st, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @spec);

        [NativeMethod(AVFORMAT, "avformat_network_deinit")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_network_deinit_delegate();

        [NativeMethod(AVFORMAT, "avformat_network_init")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_network_init_delegate();

        [NativeMethod(AVFORMAT, "avformat_new_stream")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVStream* avformat_new_stream_delegate(AVFormatContext* @s, AVCodec* @c);

        [NativeMethod(AVFORMAT, "avformat_open_input")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_open_input_delegate(AVFormatContext** @ps, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, AVInputFormat* @fmt, AVDictionary** @options);

        [NativeMethod(AVFORMAT, "avformat_query_codec")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_query_codec_delegate(AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance);

        [NativeMethod(AVFORMAT, "avformat_queue_attached_pictures")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_queue_attached_pictures_delegate(AVFormatContext* @s);

        [NativeMethod(AVFORMAT, "avformat_seek_file")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_seek_file_delegate(AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags);

        [NativeMethod(AVFORMAT, "avformat_transfer_internal_stream_timing_info")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_transfer_internal_stream_timing_info_delegate(AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb);

        [NativeMethod(AVFORMAT, "avformat_version")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avformat_version_delegate();

        [NativeMethod(AVFORMAT, "avformat_write_header")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avformat_write_header_delegate(AVFormatContext* @s, AVDictionary** @options);

        [NativeMethod(AVFORMAT, "avio_accept")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_accept_delegate(AVIOContext* @s, AVIOContext** @c);

        [NativeMethod(AVFORMAT, "avio_alloc_context")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVIOContext* avio_alloc_context_delegate(byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek);

        [NativeMethod(AVFORMAT, "avio_check")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_check_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @flags);

        [NativeMethod(AVFORMAT, "avio_close")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_close_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_close_dir")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_close_dir_delegate(AVIODirContext** @s);

        [NativeMethod(AVFORMAT, "avio_close_dyn_buf")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_close_dyn_buf_delegate(AVIOContext* @s, byte** @pbuffer);

        [NativeMethod(AVFORMAT, "avio_closep")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_closep_delegate(AVIOContext** @s);

        [NativeMethod(AVFORMAT, "avio_context_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_context_free_delegate(AVIOContext** @s);

        [NativeMethod(AVFORMAT, "avio_enum_protocols")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avio_enum_protocols_delegate(void** @opaque, int @output);

        [NativeMethod(AVFORMAT, "avio_feof")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_feof_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_find_protocol_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avio_find_protocol_name_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url);

        [NativeMethod(AVFORMAT, "avio_flush")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_flush_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_free_directory_entry")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_free_directory_entry_delegate(AVIODirEntry** @entry);

        [NativeMethod(AVFORMAT, "avio_get_dyn_buf")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_get_dyn_buf_delegate(AVIOContext* @s, byte** @pbuffer);

        [NativeMethod(AVFORMAT, "avio_get_str")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_get_str_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);

        [NativeMethod(AVFORMAT, "avio_get_str16be")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_get_str16be_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);

        [NativeMethod(AVFORMAT, "avio_get_str16le")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_get_str16le_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);

        [NativeMethod(AVFORMAT, "avio_handshake")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_handshake_delegate(AVIOContext* @c);

        [NativeMethod(AVFORMAT, "avio_open")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_open_delegate(AVIOContext** @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @flags);

        [NativeMethod(AVFORMAT, "avio_open_dir")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_open_dir_delegate(AVIODirContext** @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, AVDictionary** @options);

        [NativeMethod(AVFORMAT, "avio_open_dyn_buf")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_open_dyn_buf_delegate(AVIOContext** @s);

        [NativeMethod(AVFORMAT, "avio_open2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_open2_delegate(AVIOContext** @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options);

        [NativeMethod(AVFORMAT, "avio_pause")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_pause_delegate(AVIOContext* @h, int @pause);

        [NativeMethod(AVFORMAT, "avio_print_string_array")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_print_string_array_delegate(AVIOContext* @s, byte*[] @strings);

        [NativeMethod(AVFORMAT, "avio_printf")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_printf_delegate(AVIOContext* @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt);

        [NativeMethod(AVFORMAT, "avio_protocol_get_class")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVClass* avio_protocol_get_class_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVFORMAT, "avio_put_str")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_put_str_delegate(AVIOContext* @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str);

        [NativeMethod(AVFORMAT, "avio_put_str16be")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_put_str16be_delegate(AVIOContext* @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str);

        [NativeMethod(AVFORMAT, "avio_put_str16le")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_put_str16le_delegate(AVIOContext* @s, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str);

        [NativeMethod(AVFORMAT, "avio_r8")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_r8_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_rb16")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avio_rb16_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_rb24")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avio_rb24_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_rb32")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avio_rb32_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_rb64")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate ulong avio_rb64_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_read")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_read_delegate(AVIOContext* @s, byte* @buf, int @size);

        [NativeMethod(AVFORMAT, "avio_read_dir")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_read_dir_delegate(AVIODirContext* @s, AVIODirEntry** @next);

        [NativeMethod(AVFORMAT, "avio_read_partial")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_read_partial_delegate(AVIOContext* @s, byte* @buf, int @size);

        [NativeMethod(AVFORMAT, "avio_read_to_bprint")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int avio_read_to_bprint_delegate(AVIOContext* @h, AVBPrint* @pb, ulong @max_size);

        [NativeMethod(AVFORMAT, "avio_rl16")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avio_rl16_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_rl24")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avio_rl24_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_rl32")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avio_rl32_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_rl64")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate ulong avio_rl64_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_seek")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long avio_seek_delegate(AVIOContext* @s, long @offset, int @whence);

        [NativeMethod(AVFORMAT, "avio_seek_time")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long avio_seek_time_delegate(AVIOContext* @h, int @stream_index, long @timestamp, int @flags);

        [NativeMethod(AVFORMAT, "avio_size")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long avio_size_delegate(AVIOContext* @s);

        [NativeMethod(AVFORMAT, "avio_skip")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long avio_skip_delegate(AVIOContext* @s, long @offset);

        [NativeMethod(AVFORMAT, "avio_w8")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_w8_delegate(AVIOContext* @s, int @b);

        [NativeMethod(AVFORMAT, "avio_wb16")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_wb16_delegate(AVIOContext* @s, uint @val);

        [NativeMethod(AVFORMAT, "avio_wb24")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_wb24_delegate(AVIOContext* @s, uint @val);

        [NativeMethod(AVFORMAT, "avio_wb32")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_wb32_delegate(AVIOContext* @s, uint @val);

        [NativeMethod(AVFORMAT, "avio_wb64")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_wb64_delegate(AVIOContext* @s, ulong @val);

        [NativeMethod(AVFORMAT, "avio_wl16")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_wl16_delegate(AVIOContext* @s, uint @val);

        [NativeMethod(AVFORMAT, "avio_wl24")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_wl24_delegate(AVIOContext* @s, uint @val);

        [NativeMethod(AVFORMAT, "avio_wl32")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_wl32_delegate(AVIOContext* @s, uint @val);

        [NativeMethod(AVFORMAT, "avio_wl64")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_wl64_delegate(AVIOContext* @s, ulong @val);

        [NativeMethod(AVFORMAT, "avio_write")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_write_delegate(AVIOContext* @s, byte* @buf, int @size);

        [NativeMethod(AVFORMAT, "avio_write_marker")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void avio_write_marker_delegate(AVIOContext* @s, long @time, AVIODataMarkerType @type);

        [NativeMethod(AVUTIL, "av_add_q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_add_q_delegate(AVRational @b, AVRational @c);

        [NativeMethod(AVUTIL, "av_add_stable")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_add_stable_delegate(AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc);

        [NativeMethod(AVUTIL, "av_audio_fifo_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVAudioFifo* av_audio_fifo_alloc_delegate(AVSampleFormat @sample_fmt, int @channels, int @nb_samples);

        [NativeMethod(AVUTIL, "av_audio_fifo_drain")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_audio_fifo_drain_delegate(AVAudioFifo* @af, int @nb_samples);

        [NativeMethod(AVUTIL, "av_audio_fifo_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_audio_fifo_free_delegate(AVAudioFifo* @af);

        [NativeMethod(AVUTIL, "av_audio_fifo_peek")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_audio_fifo_peek_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);

        [NativeMethod(AVUTIL, "av_audio_fifo_peek_at")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_audio_fifo_peek_at_delegate(AVAudioFifo* @af, void** @data, int @nb_samples, int @offset);

        [NativeMethod(AVUTIL, "av_audio_fifo_read")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_audio_fifo_read_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);

        [NativeMethod(AVUTIL, "av_audio_fifo_realloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_audio_fifo_realloc_delegate(AVAudioFifo* @af, int @nb_samples);

        [NativeMethod(AVUTIL, "av_audio_fifo_reset")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_audio_fifo_reset_delegate(AVAudioFifo* @af);

        [NativeMethod(AVUTIL, "av_audio_fifo_size")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_audio_fifo_size_delegate(AVAudioFifo* @af);

        [NativeMethod(AVUTIL, "av_audio_fifo_space")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_audio_fifo_space_delegate(AVAudioFifo* @af);

        [NativeMethod(AVUTIL, "av_audio_fifo_write")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_audio_fifo_write_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);

        [NativeMethod(AVUTIL, "av_bprint_channel_layout")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_bprint_channel_layout_delegate(AVBPrint* @bp, int @nb_channels, ulong @channel_layout);

        [NativeMethod(AVUTIL, "av_buffer_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferRef* av_buffer_alloc_delegate(ulong @size);

        [NativeMethod(AVUTIL, "av_buffer_allocz")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferRef* av_buffer_allocz_delegate(ulong @size);

        [NativeMethod(AVUTIL, "av_buffer_create")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferRef* av_buffer_create_delegate(byte* @data, ulong @size, av_buffer_create_free_func @free, void* @opaque, int @flags);

        [NativeMethod(AVUTIL, "av_buffer_default_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_buffer_default_free_delegate(void* @opaque, byte* @data);

        [NativeMethod(AVUTIL, "av_buffer_get_opaque")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_buffer_get_opaque_delegate(AVBufferRef* @buf);

        [NativeMethod(AVUTIL, "av_buffer_get_ref_count")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffer_get_ref_count_delegate(AVBufferRef* @buf);

        [NativeMethod(AVUTIL, "av_buffer_is_writable")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffer_is_writable_delegate(AVBufferRef* @buf);

        [NativeMethod(AVUTIL, "av_buffer_make_writable")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffer_make_writable_delegate(AVBufferRef** @buf);

        [NativeMethod(AVUTIL, "av_buffer_pool_buffer_get_opaque")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_buffer_pool_buffer_get_opaque_delegate(AVBufferRef* @ref);

        [NativeMethod(AVUTIL, "av_buffer_pool_get")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferRef* av_buffer_pool_get_delegate(AVBufferPool* @pool);

        [NativeMethod(AVUTIL, "av_buffer_pool_init")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferPool* av_buffer_pool_init_delegate(ulong @size, av_buffer_pool_init_alloc_func @alloc);

        [NativeMethod(AVUTIL, "av_buffer_pool_init2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferPool* av_buffer_pool_init2_delegate(ulong @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free);

        [NativeMethod(AVUTIL, "av_buffer_pool_uninit")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_buffer_pool_uninit_delegate(AVBufferPool** @pool);

        [NativeMethod(AVUTIL, "av_buffer_realloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffer_realloc_delegate(AVBufferRef** @buf, ulong @size);

        [NativeMethod(AVUTIL, "av_buffer_ref")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferRef* av_buffer_ref_delegate(AVBufferRef* @buf);

        [NativeMethod(AVUTIL, "av_buffer_replace")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_buffer_replace_delegate(AVBufferRef** @dst, AVBufferRef* @src);

        [NativeMethod(AVUTIL, "av_buffer_unref")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_buffer_unref_delegate(AVBufferRef** @buf);

        [NativeMethod(AVUTIL, "av_calloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_calloc_delegate(ulong @nmemb, ulong @size);

        [NativeMethod(AVUTIL, "av_channel_layout_extract_channel")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate ulong av_channel_layout_extract_channel_delegate(ulong @channel_layout, int @index);

        [NativeMethod(AVUTIL, "av_chroma_location_from_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_chroma_location_from_name_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVUTIL, "av_chroma_location_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_chroma_location_name_delegate(AVChromaLocation @location);

        [NativeMethod(AVUTIL, "av_color_primaries_from_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_color_primaries_from_name_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVUTIL, "av_color_primaries_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_color_primaries_name_delegate(AVColorPrimaries @primaries);

        [NativeMethod(AVUTIL, "av_color_range_from_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_color_range_from_name_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVUTIL, "av_color_range_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_color_range_name_delegate(AVColorRange @range);

        [NativeMethod(AVUTIL, "av_color_space_from_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_color_space_from_name_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVUTIL, "av_color_space_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_color_space_name_delegate(AVColorSpace @space);

        [NativeMethod(AVUTIL, "av_color_transfer_from_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_color_transfer_from_name_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVUTIL, "av_color_transfer_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_color_transfer_name_delegate(AVColorTransferCharacteristic @transfer);

        [NativeMethod(AVUTIL, "av_compare_mod")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_compare_mod_delegate(ulong @a, ulong @b, ulong @mod);

        [NativeMethod(AVUTIL, "av_compare_ts")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_compare_ts_delegate(long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b);

        [NativeMethod(AVUTIL, "av_content_light_metadata_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVContentLightMetadata* av_content_light_metadata_alloc_delegate(ulong* @size);

        [NativeMethod(AVUTIL, "av_content_light_metadata_create_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVContentLightMetadata* av_content_light_metadata_create_side_data_delegate(AVFrame* @frame);

        [NativeMethod(AVUTIL, "av_cpu_count")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_cpu_count_delegate();

        [NativeMethod(AVUTIL, "av_cpu_force_count")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_cpu_force_count_delegate(int @count);

        [NativeMethod(AVUTIL, "av_cpu_max_align")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate ulong av_cpu_max_align_delegate();

        [NativeMethod(AVUTIL, "av_d2q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_d2q_delegate(double @d, int @max);

        [NativeMethod(AVUTIL, "av_default_get_category")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVClassCategory av_default_get_category_delegate(void* @ptr);

        [NativeMethod(AVUTIL, "av_default_item_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_default_item_name_delegate(void* @ctx);

        [NativeMethod(AVUTIL, "av_dict_copy")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_dict_copy_delegate(AVDictionary** @dst, AVDictionary* @src, int @flags);

        [NativeMethod(AVUTIL, "av_dict_count")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_dict_count_delegate(AVDictionary* @m);

        [NativeMethod(AVUTIL, "av_dict_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_dict_free_delegate(AVDictionary** @m);

        [NativeMethod(AVUTIL, "av_dict_get")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVDictionaryEntry* av_dict_get_delegate(AVDictionary* @m, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, AVDictionaryEntry* @prev, int @flags);

        [NativeMethod(AVUTIL, "av_dict_get_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_dict_get_string_delegate(AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep);

        [NativeMethod(AVUTIL, "av_dict_parse_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_dict_parse_string_delegate(AVDictionary** @pm, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key_val_sep, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @pairs_sep, int @flags);

        [NativeMethod(AVUTIL, "av_dict_set")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_dict_set_delegate(AVDictionary** @pm, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @value, int @flags);

        [NativeMethod(AVUTIL, "av_dict_set_int")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_dict_set_int_delegate(AVDictionary** @pm, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, long @value, int @flags);

        [NativeMethod(AVUTIL, "av_div_q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_div_q_delegate(AVRational @b, AVRational @c);

        [NativeMethod(AVUTIL, "av_dynamic_hdr_plus_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVDynamicHDRPlus* av_dynamic_hdr_plus_alloc_delegate(ulong* @size);

        [NativeMethod(AVUTIL, "av_dynamic_hdr_plus_create_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVDynamicHDRPlus* av_dynamic_hdr_plus_create_side_data_delegate(AVFrame* @frame);

        [NativeMethod(AVUTIL, "av_dynarray_add")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_dynarray_add_delegate(void* @tab_ptr, int* @nb_ptr, void* @elem);

        [NativeMethod(AVUTIL, "av_dynarray_add_nofree")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_dynarray_add_nofree_delegate(void* @tab_ptr, int* @nb_ptr, void* @elem);

        [NativeMethod(AVUTIL, "av_dynarray2_add")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_dynarray2_add_delegate(void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data);

        [NativeMethod(AVUTIL, "av_fast_malloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_fast_malloc_delegate(void* @ptr, uint* @size, ulong @min_size);

        [NativeMethod(AVUTIL, "av_fast_mallocz")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_fast_mallocz_delegate(void* @ptr, uint* @size, ulong @min_size);

        [NativeMethod(AVUTIL, "av_fast_realloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_fast_realloc_delegate(void* @ptr, uint* @size, ulong @min_size);

        [NativeMethod(AVUTIL, "av_fifo_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFifoBuffer* av_fifo_alloc_delegate(uint @size);

        [NativeMethod(AVUTIL, "av_fifo_alloc_array")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFifoBuffer* av_fifo_alloc_array_delegate(ulong @nmemb, ulong @size);

        [NativeMethod(AVUTIL, "av_fifo_drain")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_fifo_drain_delegate(AVFifoBuffer* @f, int @size);

        [NativeMethod(AVUTIL, "av_fifo_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_fifo_free_delegate(AVFifoBuffer* @f);

        [NativeMethod(AVUTIL, "av_fifo_freep")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_fifo_freep_delegate(AVFifoBuffer** @f);

        [NativeMethod(AVUTIL, "av_fifo_generic_peek")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_fifo_generic_peek_delegate(AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_peek_func_func @func);

        [NativeMethod(AVUTIL, "av_fifo_generic_peek_at")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_fifo_generic_peek_at_delegate(AVFifoBuffer* @f, void* @dest, int @offset, int @buf_size, av_fifo_generic_peek_at_func_func @func);

        [NativeMethod(AVUTIL, "av_fifo_generic_read")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_fifo_generic_read_delegate(AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_read_func_func @func);

        [NativeMethod(AVUTIL, "av_fifo_generic_write")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_fifo_generic_write_delegate(AVFifoBuffer* @f, void* @src, int @size, av_fifo_generic_write_func_func @func);

        [NativeMethod(AVUTIL, "av_fifo_grow")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_fifo_grow_delegate(AVFifoBuffer* @f, uint @additional_space);

        [NativeMethod(AVUTIL, "av_fifo_realloc2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_fifo_realloc2_delegate(AVFifoBuffer* @f, uint @size);

        [NativeMethod(AVUTIL, "av_fifo_reset")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_fifo_reset_delegate(AVFifoBuffer* @f);

        [NativeMethod(AVUTIL, "av_fifo_size")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_fifo_size_delegate(AVFifoBuffer* @f);

        [NativeMethod(AVUTIL, "av_fifo_space")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_fifo_space_delegate(AVFifoBuffer* @f);

        [NativeMethod(AVUTIL, "av_file_map")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_file_map_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename, byte** @bufptr, ulong* @size, int @log_offset, void* @log_ctx);

        [NativeMethod(AVUTIL, "av_file_unmap")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_file_unmap_delegate(byte* @bufptr, ulong @size);

        [NativeMethod(AVUTIL, "av_find_best_pix_fmt_of_2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVPixelFormat av_find_best_pix_fmt_of_2_delegate(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);

        [NativeMethod(AVUTIL, "av_find_nearest_q_idx")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_find_nearest_q_idx_delegate(AVRational @q, AVRational* @q_list);

        [NativeMethod(AVUTIL, "av_fopen_utf8")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate _iobuf* av_fopen_utf8_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @path, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @mode);

        [NativeMethod(AVUTIL, "av_force_cpu_flags")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_force_cpu_flags_delegate(int @flags);

        [NativeMethod(AVUTIL, "av_fourcc_make_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_fourcc_make_string_delegate(byte* @buf, uint @fourcc);

        [NativeMethod(AVUTIL, "av_frame_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFrame* av_frame_alloc_delegate();

        [NativeMethod(AVUTIL, "av_frame_apply_cropping")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_frame_apply_cropping_delegate(AVFrame* @frame, int @flags);

        [NativeMethod(AVUTIL, "av_frame_clone")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFrame* av_frame_clone_delegate(AVFrame* @src);

        [NativeMethod(AVUTIL, "av_frame_copy")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_frame_copy_delegate(AVFrame* @dst, AVFrame* @src);

        [NativeMethod(AVUTIL, "av_frame_copy_props")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_frame_copy_props_delegate(AVFrame* @dst, AVFrame* @src);

        [NativeMethod(AVUTIL, "av_frame_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_frame_free_delegate(AVFrame** @frame);

        [NativeMethod(AVUTIL, "av_frame_get_buffer")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_frame_get_buffer_delegate(AVFrame* @frame, int @align);

        [NativeMethod(AVUTIL, "av_frame_get_plane_buffer")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferRef* av_frame_get_plane_buffer_delegate(AVFrame* @frame, int @plane);

        [NativeMethod(AVUTIL, "av_frame_get_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFrameSideData* av_frame_get_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type);

        [NativeMethod(AVUTIL, "av_frame_is_writable")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_frame_is_writable_delegate(AVFrame* @frame);

        [NativeMethod(AVUTIL, "av_frame_make_writable")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_frame_make_writable_delegate(AVFrame* @frame);

        [NativeMethod(AVUTIL, "av_frame_move_ref")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_frame_move_ref_delegate(AVFrame* @dst, AVFrame* @src);

        [NativeMethod(AVUTIL, "av_frame_new_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFrameSideData* av_frame_new_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type, ulong @size);

        [NativeMethod(AVUTIL, "av_frame_new_side_data_from_buf")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVFrameSideData* av_frame_new_side_data_from_buf_delegate(AVFrame* @frame, AVFrameSideDataType @type, AVBufferRef* @buf);

        [NativeMethod(AVUTIL, "av_frame_ref")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_frame_ref_delegate(AVFrame* @dst, AVFrame* @src);

        [NativeMethod(AVUTIL, "av_frame_remove_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_frame_remove_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type);

        [NativeMethod(AVUTIL, "av_frame_side_data_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_frame_side_data_name_delegate(AVFrameSideDataType @type);

        [NativeMethod(AVUTIL, "av_frame_unref")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_frame_unref_delegate(AVFrame* @frame);

        [NativeMethod(AVUTIL, "av_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_free_delegate(void* @ptr);

        [NativeMethod(AVUTIL, "av_freep")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_freep_delegate(void* @ptr);

        [NativeMethod(AVUTIL, "av_gcd")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_gcd_delegate(long @a, long @b);

        [NativeMethod(AVUTIL, "av_gcd_q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_gcd_q_delegate(AVRational @a, AVRational @b, int @max_den, AVRational @def);

        [NativeMethod(AVUTIL, "av_get_alt_sample_fmt")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVSampleFormat av_get_alt_sample_fmt_delegate(AVSampleFormat @sample_fmt, int @planar);

        [NativeMethod(AVUTIL, "av_get_bits_per_pixel")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_bits_per_pixel_delegate(AVPixFmtDescriptor* @pixdesc);

        [NativeMethod(AVUTIL, "av_get_bytes_per_sample")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_bytes_per_sample_delegate(AVSampleFormat @sample_fmt);

        [NativeMethod(AVUTIL, "av_get_channel_description")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_get_channel_description_delegate(ulong @channel);

        [NativeMethod(AVUTIL, "av_get_channel_layout")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate ulong av_get_channel_layout_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVUTIL, "av_get_channel_layout_channel_index")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_channel_layout_channel_index_delegate(ulong @channel_layout, ulong @channel);

        [NativeMethod(AVUTIL, "av_get_channel_layout_nb_channels")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_channel_layout_nb_channels_delegate(ulong @channel_layout);

        [NativeMethod(AVUTIL, "av_get_channel_layout_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_get_channel_layout_string_delegate(byte* @buf, int @buf_size, int @nb_channels, ulong @channel_layout);

        [NativeMethod(AVUTIL, "av_get_channel_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_get_channel_name_delegate(ulong @channel);

        [NativeMethod(AVUTIL, "av_get_colorspace_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_get_colorspace_name_delegate(AVColorSpace @val);

        [NativeMethod(AVUTIL, "av_get_cpu_flags")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_cpu_flags_delegate();

        [NativeMethod(AVUTIL, "av_get_default_channel_layout")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_get_default_channel_layout_delegate(int @nb_channels);

        [NativeMethod(AVUTIL, "av_get_extended_channel_layout")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_extended_channel_layout_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, ulong* @channel_layout, int* @nb_channels);

        [NativeMethod(AVUTIL, "av_get_media_type_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_get_media_type_string_delegate(AVMediaType @media_type);

        [NativeMethod(AVUTIL, "av_get_packed_sample_fmt")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVSampleFormat av_get_packed_sample_fmt_delegate(AVSampleFormat @sample_fmt);

        [NativeMethod(AVUTIL, "av_get_padded_bits_per_pixel")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_padded_bits_per_pixel_delegate(AVPixFmtDescriptor* @pixdesc);

        [NativeMethod(AVUTIL, "av_get_picture_type_char")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte av_get_picture_type_char_delegate(AVPictureType @pict_type);

        [NativeMethod(AVUTIL, "av_get_pix_fmt")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVPixelFormat av_get_pix_fmt_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVUTIL, "av_get_pix_fmt_loss")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_pix_fmt_loss_delegate(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);

        [NativeMethod(AVUTIL, "av_get_pix_fmt_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_get_pix_fmt_name_delegate(AVPixelFormat @pix_fmt);

        [NativeMethod(AVUTIL, "av_get_pix_fmt_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_get_pix_fmt_string_delegate(byte* @buf, int @buf_size, AVPixelFormat @pix_fmt);

        [NativeMethod(AVUTIL, "av_get_planar_sample_fmt")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVSampleFormat av_get_planar_sample_fmt_delegate(AVSampleFormat @sample_fmt);

        [NativeMethod(AVUTIL, "av_get_sample_fmt")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVSampleFormat av_get_sample_fmt_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVUTIL, "av_get_sample_fmt_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_get_sample_fmt_name_delegate(AVSampleFormat @sample_fmt);

        [NativeMethod(AVUTIL, "av_get_sample_fmt_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_get_sample_fmt_string_delegate(byte* @buf, int @buf_size, AVSampleFormat @sample_fmt);

        [NativeMethod(AVUTIL, "av_get_standard_channel_layout")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_get_standard_channel_layout_delegate(uint @index, ulong* @layout, byte** @name);

        [NativeMethod(AVUTIL, "av_get_time_base_q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_get_time_base_q_delegate();

        [NativeMethod(AVUTIL, "av_gettime")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_gettime_delegate();

        [NativeMethod(AVUTIL, "av_gettime_relative")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_gettime_relative_delegate();

        [NativeMethod(AVUTIL, "av_gettime_relative_is_monotonic")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_gettime_relative_is_monotonic_delegate();

        [NativeMethod(AVUTIL, "av_hwdevice_ctx_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferRef* av_hwdevice_ctx_alloc_delegate(AVHWDeviceType @type);

        [NativeMethod(AVUTIL, "av_hwdevice_ctx_create")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_hwdevice_ctx_create_delegate(AVBufferRef** @device_ctx, AVHWDeviceType @type, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @device, AVDictionary* @opts, int @flags);

        [NativeMethod(AVUTIL, "av_hwdevice_ctx_create_derived")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_hwdevice_ctx_create_derived_delegate(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags);

        [NativeMethod(AVUTIL, "av_hwdevice_ctx_create_derived_opts")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_hwdevice_ctx_create_derived_opts_delegate(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, AVDictionary* @options, int @flags);

        [NativeMethod(AVUTIL, "av_hwdevice_ctx_init")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_hwdevice_ctx_init_delegate(AVBufferRef* @ref);

        [NativeMethod(AVUTIL, "av_hwdevice_find_type_by_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVHWDeviceType av_hwdevice_find_type_by_name_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVUTIL, "av_hwdevice_get_hwframe_constraints")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVHWFramesConstraints* av_hwdevice_get_hwframe_constraints_delegate(AVBufferRef* @ref, void* @hwconfig);

        [NativeMethod(AVUTIL, "av_hwdevice_get_type_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_hwdevice_get_type_name_delegate(AVHWDeviceType @type);

        [NativeMethod(AVUTIL, "av_hwdevice_hwconfig_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_hwdevice_hwconfig_alloc_delegate(AVBufferRef* @device_ctx);

        [NativeMethod(AVUTIL, "av_hwdevice_iterate_types")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVHWDeviceType av_hwdevice_iterate_types_delegate(AVHWDeviceType @prev);

        [NativeMethod(AVUTIL, "av_hwframe_constraints_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_hwframe_constraints_free_delegate(AVHWFramesConstraints** @constraints);

        [NativeMethod(AVUTIL, "av_hwframe_ctx_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVBufferRef* av_hwframe_ctx_alloc_delegate(AVBufferRef* @device_ctx);

        [NativeMethod(AVUTIL, "av_hwframe_ctx_create_derived")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_hwframe_ctx_create_derived_delegate(AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags);

        [NativeMethod(AVUTIL, "av_hwframe_ctx_init")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_hwframe_ctx_init_delegate(AVBufferRef* @ref);

        [NativeMethod(AVUTIL, "av_hwframe_get_buffer")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_hwframe_get_buffer_delegate(AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags);

        [NativeMethod(AVUTIL, "av_hwframe_map")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_hwframe_map_delegate(AVFrame* @dst, AVFrame* @src, int @flags);

        [NativeMethod(AVUTIL, "av_hwframe_transfer_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_hwframe_transfer_data_delegate(AVFrame* @dst, AVFrame* @src, int @flags);

        [NativeMethod(AVUTIL, "av_hwframe_transfer_get_formats")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_hwframe_transfer_get_formats_delegate(AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags);

        [NativeMethod(AVUTIL, "av_image_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_alloc_delegate(ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align);

        [NativeMethod(AVUTIL, "av_image_check_sar")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_check_sar_delegate(uint @w, uint @h, AVRational @sar);

        [NativeMethod(AVUTIL, "av_image_check_size")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_check_size_delegate(uint @w, uint @h, int @log_offset, void* @log_ctx);

        [NativeMethod(AVUTIL, "av_image_check_size2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_check_size2_delegate(uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx);

        [NativeMethod(AVUTIL, "av_image_copy")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_image_copy_delegate(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);

        [NativeMethod(AVUTIL, "av_image_copy_plane")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_image_copy_plane_delegate(byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height);

        [NativeMethod(AVUTIL, "av_image_copy_plane_uc_from")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_image_copy_plane_uc_from_delegate(byte* @dst, long @dst_linesize, byte* @src, long @src_linesize, long @bytewidth, int @height);

        [NativeMethod(AVUTIL, "av_image_copy_to_buffer")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_copy_to_buffer_delegate(byte* @dst, int @dst_size, byte_ptrArray4 @src_data, int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align);

        [NativeMethod(AVUTIL, "av_image_copy_uc_from")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_image_copy_uc_from_delegate(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);

        [NativeMethod(AVUTIL, "av_image_fill_arrays")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_fill_arrays_delegate(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align);

        [NativeMethod(AVUTIL, "av_image_fill_black")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_fill_black_delegate(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height);

        [NativeMethod(AVUTIL, "av_image_fill_linesizes")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_fill_linesizes_delegate(ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width);

        [NativeMethod(AVUTIL, "av_image_fill_max_pixsteps")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_image_fill_max_pixsteps_delegate(int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc);

        [NativeMethod(AVUTIL, "av_image_fill_plane_sizes")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_fill_plane_sizes_delegate(ulong_array4 @size, AVPixelFormat @pix_fmt, int @height, long_array4 @linesizes);

        [NativeMethod(AVUTIL, "av_image_fill_pointers")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_fill_pointers_delegate(byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, int_array4 @linesizes);

        [NativeMethod(AVUTIL, "av_image_get_buffer_size")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_get_buffer_size_delegate(AVPixelFormat @pix_fmt, int @width, int @height, int @align);

        [NativeMethod(AVUTIL, "av_image_get_linesize")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_image_get_linesize_delegate(AVPixelFormat @pix_fmt, int @width, int @plane);

        [NativeMethod(AVUTIL, "av_int_list_length_for_size")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint av_int_list_length_for_size_delegate(uint @elsize, void* @list, ulong @term);

        [NativeMethod(AVUTIL, "av_log")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_log_delegate(void* @avcl, int @level, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt);

        [NativeMethod(AVUTIL, "av_log_default_callback")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_log_default_callback_delegate(void* @avcl, int @level, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl);

        [NativeMethod(AVUTIL, "av_log_format_line")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_log_format_line_delegate(void* @ptr, int @level, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);

        [NativeMethod(AVUTIL, "av_log_format_line2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_log_format_line2_delegate(void* @ptr, int @level, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);

        [NativeMethod(AVUTIL, "av_log_get_flags")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_log_get_flags_delegate();

        [NativeMethod(AVUTIL, "av_log_get_level")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_log_get_level_delegate();

        [NativeMethod(AVUTIL, "av_log_once")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_log_once_delegate(void* @avcl, int @initial_level, int @subsequent_level, int* @state, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt);

        [NativeMethod(AVUTIL, "av_log_set_callback")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_log_set_callback_delegate(av_log_set_callback_callback_func @callback);

        [NativeMethod(AVUTIL, "av_log_set_flags")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_log_set_flags_delegate(int @arg);

        [NativeMethod(AVUTIL, "av_log_set_level")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_log_set_level_delegate(int @level);

        [NativeMethod(AVUTIL, "av_log2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_log2_delegate(uint @v);

        [NativeMethod(AVUTIL, "av_log2_16bit")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_log2_16bit_delegate(uint @v);

        [NativeMethod(AVUTIL, "av_malloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_malloc_delegate(ulong @size);

        [NativeMethod(AVUTIL, "av_malloc_array")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_malloc_array_delegate(ulong @nmemb, ulong @size);

        [NativeMethod(AVUTIL, "av_mallocz")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_mallocz_delegate(ulong @size);

        [NativeMethod(AVUTIL, "av_mallocz_array")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_mallocz_array_delegate(ulong @nmemb, ulong @size);

        [NativeMethod(AVUTIL, "av_mastering_display_metadata_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVMasteringDisplayMetadata* av_mastering_display_metadata_alloc_delegate();

        [NativeMethod(AVUTIL, "av_mastering_display_metadata_create_side_data")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVMasteringDisplayMetadata* av_mastering_display_metadata_create_side_data_delegate(AVFrame* @frame);

        [NativeMethod(AVUTIL, "av_max_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_max_alloc_delegate(ulong @max);

        [NativeMethod(AVUTIL, "av_memcpy_backptr")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_memcpy_backptr_delegate(byte* @dst, int @back, int @cnt);

        [NativeMethod(AVUTIL, "av_memdup")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_memdup_delegate(void* @p, ulong @size);

        [NativeMethod(AVUTIL, "av_mul_q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_mul_q_delegate(AVRational @b, AVRational @c);

        [NativeMethod(AVUTIL, "av_nearer_q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_nearer_q_delegate(AVRational @q, AVRational @q1, AVRational @q2);

        [NativeMethod(AVUTIL, "av_opt_child_class_iterate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVClass* av_opt_child_class_iterate_delegate(AVClass* @parent, void** @iter);

        [NativeMethod(AVUTIL, "av_opt_child_next")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_opt_child_next_delegate(void* @obj, void* @prev);

        [NativeMethod(AVUTIL, "av_opt_copy")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_copy_delegate(void* @dest, void* @src);

        [NativeMethod(AVUTIL, "av_opt_eval_double")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_eval_double_delegate(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, double* @double_out);

        [NativeMethod(AVUTIL, "av_opt_eval_flags")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_eval_flags_delegate(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, int* @flags_out);

        [NativeMethod(AVUTIL, "av_opt_eval_float")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_eval_float_delegate(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, float* @float_out);

        [NativeMethod(AVUTIL, "av_opt_eval_int")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_eval_int_delegate(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, int* @int_out);

        [NativeMethod(AVUTIL, "av_opt_eval_int64")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_eval_int64_delegate(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, long* @int64_out);

        [NativeMethod(AVUTIL, "av_opt_eval_q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_eval_q_delegate(void* @obj, AVOption* @o, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, AVRational* @q_out);

        [NativeMethod(AVUTIL, "av_opt_find")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVOption* av_opt_find_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @unit, int @opt_flags, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_find2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVOption* av_opt_find2_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @unit, int @opt_flags, int @search_flags, void** @target_obj);

        [NativeMethod(AVUTIL, "av_opt_flag_is_set")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_flag_is_set_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @field_name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @flag_name);

        [NativeMethod(AVUTIL, "av_opt_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_opt_free_delegate(void* @obj);

        [NativeMethod(AVUTIL, "av_opt_freep_ranges")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_opt_freep_ranges_delegate(AVOptionRanges** @ranges);

        [NativeMethod(AVUTIL, "av_opt_get")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_get_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, byte** @out_val);

        [NativeMethod(AVUTIL, "av_opt_get_channel_layout")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_get_channel_layout_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, long* @ch_layout);

        [NativeMethod(AVUTIL, "av_opt_get_dict_val")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_get_dict_val_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVDictionary** @out_val);

        [NativeMethod(AVUTIL, "av_opt_get_double")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_get_double_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, double* @out_val);

        [NativeMethod(AVUTIL, "av_opt_get_image_size")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_get_image_size_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, int* @w_out, int* @h_out);

        [NativeMethod(AVUTIL, "av_opt_get_int")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_get_int_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, long* @out_val);

        [NativeMethod(AVUTIL, "av_opt_get_key_value")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_get_key_value_delegate(byte** @ropts, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key_val_sep, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @pairs_sep, uint @flags, byte** @rkey, byte** @rval);

        [NativeMethod(AVUTIL, "av_opt_get_pixel_fmt")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_get_pixel_fmt_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVPixelFormat* @out_fmt);

        [NativeMethod(AVUTIL, "av_opt_get_q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_get_q_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVRational* @out_val);

        [NativeMethod(AVUTIL, "av_opt_get_sample_fmt")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_get_sample_fmt_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVSampleFormat* @out_fmt);

        [NativeMethod(AVUTIL, "av_opt_get_video_rate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_get_video_rate_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVRational* @out_val);

        [NativeMethod(AVUTIL, "av_opt_is_set_to_default")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_is_set_to_default_delegate(void* @obj, AVOption* @o);

        [NativeMethod(AVUTIL, "av_opt_is_set_to_default_by_name")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_is_set_to_default_by_name_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_next")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVOption* av_opt_next_delegate(void* @obj, AVOption* @prev);

        [NativeMethod(AVUTIL, "av_opt_ptr")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_opt_ptr_delegate(AVClass* @avclass, void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name);

        [NativeMethod(AVUTIL, "av_opt_query_ranges")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_query_ranges_delegate(AVOptionRanges** @p0, void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, int @flags);

        [NativeMethod(AVUTIL, "av_opt_query_ranges_default")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_query_ranges_default_delegate(AVOptionRanges** @p0, void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, int @flags);

        [NativeMethod(AVUTIL, "av_opt_serialize")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_serialize_delegate(void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep);

        [NativeMethod(AVUTIL, "av_opt_set")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_set_bin")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_bin_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, byte* @val, int @size, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_set_channel_layout")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_channel_layout_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, long @ch_layout, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_set_defaults")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_opt_set_defaults_delegate(void* @s);

        [NativeMethod(AVUTIL, "av_opt_set_defaults2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_opt_set_defaults2_delegate(void* @s, int @mask, int @flags);

        [NativeMethod(AVUTIL, "av_opt_set_dict")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_dict_delegate(void* @obj, AVDictionary** @options);

        [NativeMethod(AVUTIL, "av_opt_set_dict_val")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_dict_val_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVDictionary* @val, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_set_dict2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_dict2_delegate(void* @obj, AVDictionary** @options, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_set_double")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_double_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, double @val, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_set_from_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_from_string_delegate(void* @ctx, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @opts, byte** @shorthand, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key_val_sep, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @pairs_sep);

        [NativeMethod(AVUTIL, "av_opt_set_image_size")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_image_size_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @w, int @h, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_set_int")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_int_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, long @val, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_set_pixel_fmt")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_pixel_fmt_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVPixelFormat @fmt, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_set_q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_q_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVRational @val, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_set_sample_fmt")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_sample_fmt_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVSampleFormat @fmt, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_set_video_rate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_set_video_rate_delegate(void* @obj, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVRational @val, int @search_flags);

        [NativeMethod(AVUTIL, "av_opt_show2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_opt_show2_delegate(void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags);

        [NativeMethod(AVUTIL, "av_parse_cpu_caps")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_parse_cpu_caps_delegate(uint* @flags, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @s);

        [NativeMethod(AVUTIL, "av_pix_fmt_count_planes")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_pix_fmt_count_planes_delegate(AVPixelFormat @pix_fmt);

        [NativeMethod(AVUTIL, "av_pix_fmt_desc_get")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVPixFmtDescriptor* av_pix_fmt_desc_get_delegate(AVPixelFormat @pix_fmt);

        [NativeMethod(AVUTIL, "av_pix_fmt_desc_get_id")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVPixelFormat av_pix_fmt_desc_get_id_delegate(AVPixFmtDescriptor* @desc);

        [NativeMethod(AVUTIL, "av_pix_fmt_desc_next")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVPixFmtDescriptor* av_pix_fmt_desc_next_delegate(AVPixFmtDescriptor* @prev);

        [NativeMethod(AVUTIL, "av_pix_fmt_get_chroma_sub_sample")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_pix_fmt_get_chroma_sub_sample_delegate(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);

        [NativeMethod(AVUTIL, "av_pix_fmt_swap_endianness")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVPixelFormat av_pix_fmt_swap_endianness_delegate(AVPixelFormat @pix_fmt);

        [NativeMethod(AVUTIL, "av_q2intfloat")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint av_q2intfloat_delegate(AVRational @q);

        [NativeMethod(AVUTIL, "av_read_image_line")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_read_image_line_delegate(ushort* @dst, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component);

        [NativeMethod(AVUTIL, "av_read_image_line2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_read_image_line2_delegate(void* @dst, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component, int @dst_element_size);

        [NativeMethod(AVUTIL, "av_realloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_realloc_delegate(void* @ptr, ulong @size);

        [NativeMethod(AVUTIL, "av_realloc_array")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_realloc_array_delegate(void* @ptr, ulong @nmemb, ulong @size);

        [NativeMethod(AVUTIL, "av_realloc_f")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_realloc_f_delegate(void* @ptr, ulong @nelem, ulong @elsize);

        [NativeMethod(AVUTIL, "av_reallocp")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_reallocp_delegate(void* @ptr, ulong @size);

        [NativeMethod(AVUTIL, "av_reallocp_array")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_reallocp_array_delegate(void* @ptr, ulong @nmemb, ulong @size);

        [NativeMethod(AVUTIL, "av_reduce")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_reduce_delegate(int* @dst_num, int* @dst_den, long @num, long @den, long @max);

        [NativeMethod(AVUTIL, "av_rescale")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_rescale_delegate(long @a, long @b, long @c);

        [NativeMethod(AVUTIL, "av_rescale_delta")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_rescale_delta_delegate(AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb);

        [NativeMethod(AVUTIL, "av_rescale_q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_rescale_q_delegate(long @a, AVRational @bq, AVRational @cq);

        [NativeMethod(AVUTIL, "av_rescale_q_rnd")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_rescale_q_rnd_delegate(long @a, AVRational @bq, AVRational @cq, AVRounding @rnd);

        [NativeMethod(AVUTIL, "av_rescale_rnd")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long av_rescale_rnd_delegate(long @a, long @b, long @c, AVRounding @rnd);

        [NativeMethod(AVUTIL, "av_sample_fmt_is_planar")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_sample_fmt_is_planar_delegate(AVSampleFormat @sample_fmt);

        [NativeMethod(AVUTIL, "av_samples_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_samples_alloc_delegate(byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);

        [NativeMethod(AVUTIL, "av_samples_alloc_array_and_samples")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_samples_alloc_array_and_samples_delegate(byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);

        [NativeMethod(AVUTIL, "av_samples_copy")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_samples_copy_delegate(byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);

        [NativeMethod(AVUTIL, "av_samples_fill_arrays")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_samples_fill_arrays_delegate(byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);

        [NativeMethod(AVUTIL, "av_samples_get_buffer_size")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_samples_get_buffer_size_delegate(int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);

        [NativeMethod(AVUTIL, "av_samples_set_silence")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_samples_set_silence_delegate(byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);

        [NativeMethod(AVUTIL, "av_set_options_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_set_options_string_delegate(void* @ctx, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @opts, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key_val_sep, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @pairs_sep);

        [NativeMethod(AVUTIL, "av_size_mult")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_size_mult_delegate(ulong @a, ulong @b, ulong* @r);

        [NativeMethod(AVUTIL, "av_strdup")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_strdup_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @s);

        [NativeMethod(AVUTIL, "av_strerror")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_strerror_delegate(int @errnum, byte* @errbuf, ulong @errbuf_size);

        [NativeMethod(AVUTIL, "av_strndup")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_strndup_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @s, ulong @len);

        [NativeMethod(AVUTIL, "av_sub_q")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVRational av_sub_q_delegate(AVRational @b, AVRational @c);

        [NativeMethod(AVUTIL, "av_tempfile")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_tempfile_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @prefix, byte** @filename, int @log_offset, void* @log_ctx);

        [NativeMethod(AVUTIL, "av_timecode_adjust_ntsc_framenum2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_timecode_adjust_ntsc_framenum2_delegate(int @framenum, int @fps);

        [NativeMethod(AVUTIL, "av_timecode_check_frame_rate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_timecode_check_frame_rate_delegate(AVRational @rate);

        [NativeMethod(AVUTIL, "av_timecode_get_smpte")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint av_timecode_get_smpte_delegate(AVRational @rate, int @drop, int @hh, int @mm, int @ss, int @ff);

        [NativeMethod(AVUTIL, "av_timecode_get_smpte_from_framenum")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint av_timecode_get_smpte_from_framenum_delegate(AVTimecode* @tc, int @framenum);

        [NativeMethod(AVUTIL, "av_timecode_init")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_timecode_init_delegate(AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx);

        [NativeMethod(AVUTIL, "av_timecode_init_from_components")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_timecode_init_from_components_delegate(AVTimecode* @tc, AVRational @rate, int @flags, int @hh, int @mm, int @ss, int @ff, void* @log_ctx);

        [NativeMethod(AVUTIL, "av_timecode_init_from_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_timecode_init_from_string_delegate(AVTimecode* @tc, AVRational @rate, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str, void* @log_ctx);

        [NativeMethod(AVUTIL, "av_timecode_make_mpeg_tc_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_timecode_make_mpeg_tc_string_delegate(byte* @buf, uint @tc25bit);

        [NativeMethod(AVUTIL, "av_timecode_make_smpte_tc_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_timecode_make_smpte_tc_string_delegate(byte* @buf, uint @tcsmpte, int @prevent_df);

        [NativeMethod(AVUTIL, "av_timecode_make_smpte_tc_string2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_timecode_make_smpte_tc_string2_delegate(byte* @buf, AVRational @rate, uint @tcsmpte, int @prevent_df, int @skip_field);

        [NativeMethod(AVUTIL, "av_timecode_make_string")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate byte* av_timecode_make_string_delegate(AVTimecode* @tc, byte* @buf, int @framenum);

        [NativeMethod(AVUTIL, "av_tree_destroy")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_tree_destroy_delegate(AVTreeNode* @t);

        [NativeMethod(AVUTIL, "av_tree_enumerate")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_tree_enumerate_delegate(AVTreeNode* @t, void* @opaque, av_tree_enumerate_cmp_func @cmp, av_tree_enumerate_enu_func @enu);

        [NativeMethod(AVUTIL, "av_tree_find")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_tree_find_delegate(AVTreeNode* @root, void* @key, av_tree_find_cmp_func @cmp, void_ptrArray2 @next);

        [NativeMethod(AVUTIL, "av_tree_insert")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* av_tree_insert_delegate(AVTreeNode** @rootp, void* @key, av_tree_insert_cmp_func @cmp, AVTreeNode** @next);

        [NativeMethod(AVUTIL, "av_tree_node_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVTreeNode* av_tree_node_alloc_delegate();

        [NativeMethod(AVUTIL, "av_usleep")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int av_usleep_delegate(uint @usec);

        [NativeMethod(AVUTIL, "av_version_info")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string av_version_info_delegate();

        [NativeMethod(AVUTIL, "av_vlog")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_vlog_delegate(void* @avcl, int @level, 
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl);

        [NativeMethod(AVUTIL, "av_write_image_line")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_write_image_line_delegate(ushort* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w);

        [NativeMethod(AVUTIL, "av_write_image_line2")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void av_write_image_line2_delegate(void* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @src_element_size);

        [NativeMethod(AVUTIL, "avutil_configuration")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avutil_configuration_delegate();

        [NativeMethod(AVUTIL, "avutil_license")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string avutil_license_delegate();

        [NativeMethod(AVUTIL, "avutil_version")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint avutil_version_delegate();

        [NativeMethod(POSTPROC, "postproc_configuration")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string postproc_configuration_delegate();

        [NativeMethod(POSTPROC, "postproc_license")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string postproc_license_delegate();

        [NativeMethod(POSTPROC, "postproc_version")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint postproc_version_delegate();

        [NativeMethod(POSTPROC, "pp_free_context")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void pp_free_context_delegate(void* @ppContext);

        [NativeMethod(POSTPROC, "pp_free_mode")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void pp_free_mode_delegate(void* @mode);

        [NativeMethod(POSTPROC, "pp_get_context")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* pp_get_context_delegate(int @width, int @height, int @flags);

        [NativeMethod(POSTPROC, "pp_get_mode_by_name_and_quality")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void* pp_get_mode_by_name_and_quality_delegate(
    #if NET40
    #elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
    #else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @quality);

        [NativeMethod(POSTPROC, "pp_postprocess")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void pp_postprocess_delegate(byte_ptrArray3 @src, int_array3 @srcStride, ref byte_ptrArray3 @dst, int_array3 @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type);

        [NativeMethod(SWRESAMPLE, "swr_alloc")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate SwrContext* swr_alloc_delegate();

        [NativeMethod(SWRESAMPLE, "swr_alloc_set_opts")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate SwrContext* swr_alloc_set_opts_delegate(SwrContext* @s, long @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, long @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx);

        [NativeMethod(SWRESAMPLE, "swr_build_matrix")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_build_matrix_delegate(ulong @in_layout, ulong @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @rematrix_maxval, double @rematrix_volume, double* @matrix, int @stride, AVMatrixEncoding @matrix_encoding, void* @log_ctx);

        [NativeMethod(SWRESAMPLE, "swr_close")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void swr_close_delegate(SwrContext* @s);

        [NativeMethod(SWRESAMPLE, "swr_config_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_config_frame_delegate(SwrContext* @swr, AVFrame* @out, AVFrame* @in);

        [NativeMethod(SWRESAMPLE, "swr_convert")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_convert_delegate(SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count);

        [NativeMethod(SWRESAMPLE, "swr_convert_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_convert_frame_delegate(SwrContext* @swr, AVFrame* @output, AVFrame* @input);

        [NativeMethod(SWRESAMPLE, "swr_drop_output")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_drop_output_delegate(SwrContext* @s, int @count);

        [NativeMethod(SWRESAMPLE, "swr_free")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void swr_free_delegate(SwrContext** @s);

        [NativeMethod(SWRESAMPLE, "swr_get_class")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVClass* swr_get_class_delegate();

        [NativeMethod(SWRESAMPLE, "swr_get_delay")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long swr_get_delay_delegate(SwrContext* @s, long @base);

        [NativeMethod(SWRESAMPLE, "swr_get_out_samples")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_get_out_samples_delegate(SwrContext* @s, int @in_samples);

        [NativeMethod(SWRESAMPLE, "swr_init")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_init_delegate(SwrContext* @s);

        [NativeMethod(SWRESAMPLE, "swr_inject_silence")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_inject_silence_delegate(SwrContext* @s, int @count);

        [NativeMethod(SWRESAMPLE, "swr_is_initialized")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_is_initialized_delegate(SwrContext* @s);

        [NativeMethod(SWRESAMPLE, "swr_next_pts")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate long swr_next_pts_delegate(SwrContext* @s, long @pts);

        [NativeMethod(SWRESAMPLE, "swr_set_channel_mapping")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_set_channel_mapping_delegate(SwrContext* @s, int* @channel_map);

        [NativeMethod(SWRESAMPLE, "swr_set_compensation")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_set_compensation_delegate(SwrContext* @s, int @sample_delta, int @compensation_distance);

        [NativeMethod(SWRESAMPLE, "swr_set_matrix")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int swr_set_matrix_delegate(SwrContext* @s, double* @matrix, int @stride);

        [NativeMethod(SWRESAMPLE, "swresample_configuration")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string swresample_configuration_delegate();

        [NativeMethod(SWRESAMPLE, "swresample_license")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string swresample_license_delegate();

        [NativeMethod(SWRESAMPLE, "swresample_version")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint swresample_version_delegate();

        [NativeMethod(SWSCALE, "sws_alloc_context")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate SwsContext* sws_alloc_context_delegate();

        [NativeMethod(SWSCALE, "sws_allocVec")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate SwsVector* sws_allocVec_delegate(int @length);

        [NativeMethod(SWSCALE, "sws_convertPalette8ToPacked24")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void sws_convertPalette8ToPacked24_delegate(byte* @src, byte* @dst, int @num_pixels, byte* @palette);

        [NativeMethod(SWSCALE, "sws_convertPalette8ToPacked32")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void sws_convertPalette8ToPacked32_delegate(byte* @src, byte* @dst, int @num_pixels, byte* @palette);

        [NativeMethod(SWSCALE, "sws_frame_end")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void sws_frame_end_delegate(SwsContext* @c);

        [NativeMethod(SWSCALE, "sws_frame_start")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int sws_frame_start_delegate(SwsContext* @c, AVFrame* @dst, AVFrame* @src);

        [NativeMethod(SWSCALE, "sws_freeContext")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void sws_freeContext_delegate(SwsContext* @swsContext);

        [NativeMethod(SWSCALE, "sws_freeFilter")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void sws_freeFilter_delegate(SwsFilter* @filter);

        [NativeMethod(SWSCALE, "sws_freeVec")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void sws_freeVec_delegate(SwsVector* @a);

        [NativeMethod(SWSCALE, "sws_get_class")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate AVClass* sws_get_class_delegate();

        [NativeMethod(SWSCALE, "sws_getCachedContext")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate SwsContext* sws_getCachedContext_delegate(SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);

        [NativeMethod(SWSCALE, "sws_getCoefficients")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int* sws_getCoefficients_delegate(int @colorspace);

        [NativeMethod(SWSCALE, "sws_getColorspaceDetails")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int sws_getColorspaceDetails_delegate(SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation);

        [NativeMethod(SWSCALE, "sws_getContext")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate SwsContext* sws_getContext_delegate(int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);

        [NativeMethod(SWSCALE, "sws_getDefaultFilter")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate SwsFilter* sws_getDefaultFilter_delegate(float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose);

        [NativeMethod(SWSCALE, "sws_getGaussianVec")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate SwsVector* sws_getGaussianVec_delegate(double @variance, double @quality);

        [NativeMethod(SWSCALE, "sws_init_context")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int sws_init_context_delegate(SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter);

        [NativeMethod(SWSCALE, "sws_isSupportedEndiannessConversion")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int sws_isSupportedEndiannessConversion_delegate(AVPixelFormat @pix_fmt);

        [NativeMethod(SWSCALE, "sws_isSupportedInput")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int sws_isSupportedInput_delegate(AVPixelFormat @pix_fmt);

        [NativeMethod(SWSCALE, "sws_isSupportedOutput")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int sws_isSupportedOutput_delegate(AVPixelFormat @pix_fmt);

        [NativeMethod(SWSCALE, "sws_normalizeVec")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void sws_normalizeVec_delegate(SwsVector* @a, double @height);

        [NativeMethod(SWSCALE, "sws_receive_slice")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int sws_receive_slice_delegate(SwsContext* @c, uint @slice_start, uint @slice_height);

        [NativeMethod(SWSCALE, "sws_receive_slice_alignment")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint sws_receive_slice_alignment_delegate(SwsContext* @c);

        [NativeMethod(SWSCALE, "sws_scale")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int sws_scale_delegate(SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride);

        [NativeMethod(SWSCALE, "sws_scale_frame")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int sws_scale_frame_delegate(SwsContext* @c, AVFrame* @dst, AVFrame* @src);

        [NativeMethod(SWSCALE, "sws_scaleVec")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate void sws_scaleVec_delegate(SwsVector* @a, double @scalar);

        [NativeMethod(SWSCALE, "sws_send_slice")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int sws_send_slice_delegate(SwsContext* @c, uint @slice_start, uint @slice_height);

        [NativeMethod(SWSCALE, "sws_setColorspaceDetails")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate int sws_setColorspaceDetails_delegate(SwsContext* @c, int_array4 @inv_table, int @srcRange, int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation);

        [NativeMethod(SWSCALE, "swscale_configuration")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string swscale_configuration_delegate();

        [NativeMethod(SWSCALE, "swscale_license")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate string swscale_license_delegate();

        [NativeMethod(SWSCALE, "swscale_version")]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        internal delegate uint swscale_version_delegate();

    }
}