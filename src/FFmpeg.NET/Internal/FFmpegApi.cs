using System;
using System.Runtime.InteropServices;
using FFmpeg.NET.Internal;
using FFmpeg.NET.Interop;
using static FFmpeg.NET.Internal.NativeMethods;

namespace FFmpeg.NET
{
    public unsafe sealed partial class FFmpegApi
    {
        private LibrariesLoader _loader;

        public FFmpegApi(FFmpegOptions options)
        {
            _loader = new LibrariesLoader(options);
        }

        public T NativeMethodDelegate<T>()
        {
            var attribute = (NativeMethodAttribute?)Attribute.GetCustomAttribute(typeof(T), typeof(NativeMethodAttribute));
            if (attribute == null) throw new AttributeNotFoundException(typeof(T), typeof(NativeMethodAttribute));
            IntPtr handle = _loader.GetPtr(attribute.Library);
            var intptr = NativeLibrary.TryGetExport(handle, attribute.Method, out IntPtr address) ? address : throw new NotSupportedException($"This method '{attribute.Method}' is not supported.");
            return Marshal.GetDelegateForFunctionPointer<T>(intptr);
        }

        private av_codec_is_decoder_delegate? _av_codec_is_decoder_ptr;

        public av_codec_is_decoder_delegate av_codec_is_decoder_ptr => _av_codec_is_decoder_ptr ?? (_av_codec_is_decoder_ptr = NativeMethodDelegate<av_codec_is_decoder_delegate>());

        /// <summary>Returns a non-zero number if codec is a decoder, zero otherwise</summary>
        /// <returns>a non-zero number if codec is a decoder, zero otherwise</returns>
        public int av_codec_is_decoder(AVCodec* @codec)
        {
            return NativeMethodDelegate<av_codec_is_decoder_delegate>()(@codec);
        }

        private av_codec_is_encoder_delegate? _av_codec_is_encoder_ptr;

        public av_codec_is_encoder_delegate av_codec_is_encoder_ptr => _av_codec_is_encoder_ptr ?? (_av_codec_is_encoder_ptr = NativeMethodDelegate<av_codec_is_encoder_delegate>());

        /// <summary>Returns a non-zero number if codec is an encoder, zero otherwise</summary>
        /// <returns>a non-zero number if codec is an encoder, zero otherwise</returns>
        public int av_codec_is_encoder(AVCodec* @codec)
        {
            return av_codec_is_encoder_ptr(@codec);
        }

        private av_codec_iterate_delegate? _av_codec_iterate_ptr;

        public av_codec_iterate_delegate av_codec_iterate_ptr => _av_codec_iterate_ptr ?? (_av_codec_iterate_ptr = NativeMethodDelegate<av_codec_iterate_delegate>());

        /// <summary>Iterate over all registered codecs.</summary>
        /// <param name="opaque">a pointer where libavcodec will store the iteration state. Must point to NULL to start the iteration.</param>
        /// <returns>the next registered codec or NULL when the iteration is finished</returns>
        public AVCodec* av_codec_iterate(void** @opaque)
        {
            return av_codec_iterate_ptr(@opaque);
        }

        private av_cpb_properties_alloc_delegate? _av_cpb_properties_alloc_ptr;

        public av_cpb_properties_alloc_delegate av_cpb_properties_alloc_ptr => _av_cpb_properties_alloc_ptr ?? (_av_cpb_properties_alloc_ptr = NativeMethodDelegate<av_cpb_properties_alloc_delegate>());

        /// <summary>Allocate a CPB properties structure and initialize its fields to default values.</summary>
        /// <param name="size">if non-NULL, the size of the allocated struct will be written here. This is useful for embedding it in side data.</param>
        /// <returns>the newly allocated struct or NULL on failure</returns>
        public AVCPBProperties* av_cpb_properties_alloc(ulong* @size)
        {
            return av_cpb_properties_alloc_ptr(@size);
        }

        private av_d3d11va_alloc_context_delegate? _av_d3d11va_alloc_context_ptr;

        public av_d3d11va_alloc_context_delegate av_d3d11va_alloc_context_ptr => _av_d3d11va_alloc_context_ptr ?? (_av_d3d11va_alloc_context_ptr = NativeMethodDelegate<av_d3d11va_alloc_context_delegate>());

        /// <summary>Allocate an AVD3D11VAContext.</summary>
        /// <returns>Newly-allocated AVD3D11VAContext or NULL on failure.</returns>
        public AVD3D11VAContext* av_d3d11va_alloc_context()
        {
            return av_d3d11va_alloc_context_ptr();
        }

        private av_fast_padded_malloc_delegate? _av_fast_padded_malloc_ptr;

        public av_fast_padded_malloc_delegate av_fast_padded_malloc_ptr => _av_fast_padded_malloc_ptr ?? (_av_fast_padded_malloc_ptr = NativeMethodDelegate<av_fast_padded_malloc_delegate>());

        /// <summary>Same behaviour av_fast_malloc but the buffer has additional AV_INPUT_BUFFER_PADDING_SIZE at the end which will always be 0.</summary>
        public void av_fast_padded_malloc(void* @ptr, uint* @size, ulong @min_size)
        {
            av_fast_padded_malloc_ptr(@ptr, @size, @min_size);
        }

        private av_fast_padded_mallocz_delegate? _av_fast_padded_mallocz_ptr;

        public av_fast_padded_mallocz_delegate av_fast_padded_mallocz_ptr => _av_fast_padded_mallocz_ptr ?? (_av_fast_padded_mallocz_ptr = NativeMethodDelegate<av_fast_padded_mallocz_delegate>());

        /// <summary>Same behaviour av_fast_padded_malloc except that buffer will always be 0-initialized after call.</summary>
        public void av_fast_padded_mallocz(void* @ptr, uint* @size, ulong @min_size)
        {
            av_fast_padded_mallocz_ptr(@ptr, @size, @min_size);
        }

        private av_get_audio_frame_duration_delegate? _av_get_audio_frame_duration_ptr;

        public av_get_audio_frame_duration_delegate av_get_audio_frame_duration_ptr => _av_get_audio_frame_duration_ptr ?? (_av_get_audio_frame_duration_ptr = NativeMethodDelegate<av_get_audio_frame_duration_delegate>());

        /// <summary>Return audio frame duration.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="frame_bytes">size of the frame, or 0 if unknown</param>
        /// <returns>frame duration, in samples, if known. 0 if not able to determine.</returns>
        public int av_get_audio_frame_duration(AVCodecContext* @avctx, int @frame_bytes)
        {
            return av_get_audio_frame_duration_ptr(@avctx, @frame_bytes);
        }

        private av_get_audio_frame_duration2_delegate? _av_get_audio_frame_duration2_ptr;

        public av_get_audio_frame_duration2_delegate av_get_audio_frame_duration2_ptr => _av_get_audio_frame_duration2_ptr ?? (_av_get_audio_frame_duration2_ptr = NativeMethodDelegate<av_get_audio_frame_duration2_delegate>());

        /// <summary>This function is the same as av_get_audio_frame_duration(), except it works with AVCodecParameters instead of an AVCodecContext.</summary>
        public int av_get_audio_frame_duration2(AVCodecParameters* @par, int @frame_bytes)
        {
            return av_get_audio_frame_duration2_ptr(@par, @frame_bytes);
        }

        private av_get_bits_per_sample_delegate? _av_get_bits_per_sample_ptr;

        public av_get_bits_per_sample_delegate av_get_bits_per_sample_ptr => _av_get_bits_per_sample_ptr ?? (_av_get_bits_per_sample_ptr = NativeMethodDelegate<av_get_bits_per_sample_delegate>());

        /// <summary>Return codec bits per sample.</summary>
        /// <param name="codec_id">the codec</param>
        /// <returns>Number of bits per sample or zero if unknown for the given codec.</returns>
        public int av_get_bits_per_sample(AVCodecID @codec_id)
        {
            return av_get_bits_per_sample_ptr(@codec_id);
        }

        private av_get_exact_bits_per_sample_delegate? _av_get_exact_bits_per_sample_ptr;

        public av_get_exact_bits_per_sample_delegate av_get_exact_bits_per_sample_ptr => _av_get_exact_bits_per_sample_ptr ?? (_av_get_exact_bits_per_sample_ptr = NativeMethodDelegate<av_get_exact_bits_per_sample_delegate>());

        /// <summary>Return codec bits per sample. Only return non-zero if the bits per sample is exactly correct, not an approximation.</summary>
        /// <param name="codec_id">the codec</param>
        /// <returns>Number of bits per sample or zero if unknown for the given codec.</returns>
        public int av_get_exact_bits_per_sample(AVCodecID @codec_id)
        {
            return av_get_exact_bits_per_sample_ptr(@codec_id);
        }

        private av_get_pcm_codec_delegate? _av_get_pcm_codec_ptr;

        public av_get_pcm_codec_delegate av_get_pcm_codec_ptr => _av_get_pcm_codec_ptr ?? (_av_get_pcm_codec_ptr = NativeMethodDelegate<av_get_pcm_codec_delegate>());

        /// <summary>Return the PCM codec associated with a sample format.</summary>
        /// <param name="be">endianness, 0 for little, 1 for big, -1 (or anything else) for native</param>
        /// <returns>AV_CODEC_ID_PCM_* or AV_CODEC_ID_NONE</returns>
        public AVCodecID av_get_pcm_codec(AVSampleFormat @fmt, int @be)
        {
            return av_get_pcm_codec_ptr(@fmt, @be);
        }

        private av_get_profile_name_delegate? _av_get_profile_name_ptr;

        public av_get_profile_name_delegate av_get_profile_name_ptr => _av_get_profile_name_ptr ?? (_av_get_profile_name_ptr = NativeMethodDelegate<av_get_profile_name_delegate>());

        /// <summary>Return a name for the specified profile, if available.</summary>
        /// <param name="codec">the codec that is searched for the given profile</param>
        /// <param name="profile">the profile value for which a name is requested</param>
        /// <returns>A name for the profile if found, NULL otherwise.</returns>
        public string av_get_profile_name(AVCodec* @codec, int @profile)
        {
            return av_get_profile_name_ptr(@codec, @profile);
        }

        private av_grow_packet_delegate? _av_grow_packet_ptr;

        public av_grow_packet_delegate av_grow_packet_ptr => _av_grow_packet_ptr ?? (_av_grow_packet_ptr = NativeMethodDelegate<av_grow_packet_delegate>());

        /// <summary>Increase packet size, correctly zeroing padding</summary>
        /// <param name="pkt">packet</param>
        /// <param name="grow_by">number of bytes by which to increase the size of the packet</param>
        public int av_grow_packet(AVPacket* @pkt, int @grow_by)
        {
            return av_grow_packet_ptr(@pkt, @grow_by);
        }

        private av_init_packet_delegate? _av_init_packet_ptr;

        public av_init_packet_delegate av_init_packet_ptr => _av_init_packet_ptr ?? (_av_init_packet_ptr = NativeMethodDelegate<av_init_packet_delegate>());

        /// <summary>Initialize optional fields of a packet with default values.</summary>
        /// <param name="pkt">packet</param>
        [Obsolete("This function is deprecated. Once it's removed, sizeof(AVPacket) will not be a part of the ABI anymore.")]
        public void av_init_packet(AVPacket* @pkt)
        {
            av_init_packet_ptr(@pkt);
        }

        private av_new_packet_delegate? _av_new_packet_ptr;

        public av_new_packet_delegate av_new_packet_ptr => _av_new_packet_ptr ?? (_av_new_packet_ptr = NativeMethodDelegate<av_new_packet_delegate>());

        /// <summary>Allocate the payload of a packet and initialize its fields with default values.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="size">wanted payload size</param>
        /// <returns>0 if OK, AVERROR_xxx otherwise</returns>
        public int av_new_packet(AVPacket* @pkt, int @size)
        {
            return av_new_packet_ptr(@pkt, @size);
        }

        private av_packet_add_side_data_delegate? _av_packet_add_side_data_ptr;

        public av_packet_add_side_data_delegate av_packet_add_side_data_ptr => _av_packet_add_side_data_ptr ?? (_av_packet_add_side_data_ptr = NativeMethodDelegate<av_packet_add_side_data_delegate>());

        /// <summary>Wrap an existing array as a packet side data.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">side information type</param>
        /// <param name="data">the side data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to pkt.</param>
        /// <param name="size">side information size</param>
        /// <returns>a non-negative number on success, a negative AVERROR code on failure. On failure, the packet is unchanged and the data remains owned by the caller.</returns>
        public int av_packet_add_side_data(AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size)
        {
            return av_packet_add_side_data_ptr(@pkt, @type, @data, @size);
        }

        private av_packet_alloc_delegate? _av_packet_alloc_ptr;

        public av_packet_alloc_delegate av_packet_alloc_ptr => _av_packet_alloc_ptr ?? (_av_packet_alloc_ptr = NativeMethodDelegate<av_packet_alloc_delegate>());

        /// <summary>Allocate an AVPacket and set its fields to default values. The resulting struct must be freed using av_packet_free().</summary>
        /// <returns>An AVPacket filled with default values or NULL on failure.</returns>
        public AVPacket* av_packet_alloc()
        {
            return av_packet_alloc_ptr();
        }

        private av_packet_clone_delegate? _av_packet_clone_ptr;

        public av_packet_clone_delegate av_packet_clone_ptr => _av_packet_clone_ptr ?? (_av_packet_clone_ptr = NativeMethodDelegate<av_packet_clone_delegate>());

        /// <summary>Create a new packet that references the same data as src.</summary>
        /// <returns>newly created AVPacket on success, NULL on error.</returns>
        public AVPacket* av_packet_clone(AVPacket* @src)
        {
            return av_packet_clone_ptr(@src);
        }

        private av_packet_copy_props_delegate? _av_packet_copy_props_ptr;

        public av_packet_copy_props_delegate av_packet_copy_props_ptr => _av_packet_copy_props_ptr ?? (_av_packet_copy_props_ptr = NativeMethodDelegate<av_packet_copy_props_delegate>());

        /// <summary>Copy only &quot;properties&quot; fields from src to dst.</summary>
        /// <param name="dst">Destination packet</param>
        /// <param name="src">Source packet</param>
        /// <returns>0 on success AVERROR on failure.</returns>
        public int av_packet_copy_props(AVPacket* @dst, AVPacket* @src)
        {
            return av_packet_copy_props_ptr(@dst, @src);
        }

        private av_packet_free_delegate? _av_packet_free_ptr;

        public av_packet_free_delegate av_packet_free_ptr => _av_packet_free_ptr ?? (_av_packet_free_ptr = NativeMethodDelegate<av_packet_free_delegate>());

        /// <summary>Free the packet, if the packet is reference counted, it will be unreferenced first.</summary>
        /// <param name="pkt">packet to be freed. The pointer will be set to NULL.</param>
        public void av_packet_free(AVPacket** @pkt)
        {
            av_packet_free_ptr(@pkt);
        }

        private av_packet_free_side_data_delegate? _av_packet_free_side_data_ptr;

        public av_packet_free_side_data_delegate av_packet_free_side_data_ptr => _av_packet_free_side_data_ptr ?? (_av_packet_free_side_data_ptr = NativeMethodDelegate<av_packet_free_side_data_delegate>());

        /// <summary>Convenience function to free all the side data stored. All the other fields stay untouched.</summary>
        /// <param name="pkt">packet</param>
        public void av_packet_free_side_data(AVPacket* @pkt)
        {
            av_packet_free_side_data_ptr(@pkt);
        }

        private av_packet_from_data_delegate? _av_packet_from_data_ptr;

        public av_packet_from_data_delegate av_packet_from_data_ptr => _av_packet_from_data_ptr ?? (_av_packet_from_data_ptr = NativeMethodDelegate<av_packet_from_data_delegate>());

        /// <summary>Initialize a reference-counted packet from av_malloc()ed data.</summary>
        /// <param name="pkt">packet to be initialized. This function will set the data, size, and buf fields, all others are left untouched.</param>
        /// <param name="data">Data allocated by av_malloc() to be used as packet data. If this function returns successfully, the data is owned by the underlying AVBuffer. The caller may not access the data through other means.</param>
        /// <param name="size">size of data in bytes, without the padding. I.e. the full buffer size is assumed to be size + AV_INPUT_BUFFER_PADDING_SIZE.</param>
        /// <returns>0 on success, a negative AVERROR on error</returns>
        public int av_packet_from_data(AVPacket* @pkt, byte* @data, int @size)
        {
            return av_packet_from_data_ptr(@pkt, @data, @size);
        }

        private av_packet_get_side_data_delegate? _av_packet_get_side_data_ptr;

        public av_packet_get_side_data_delegate av_packet_get_side_data_ptr => _av_packet_get_side_data_ptr ?? (_av_packet_get_side_data_ptr = NativeMethodDelegate<av_packet_get_side_data_delegate>());

        /// <summary>Get side information from packet.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">desired side information type</param>
        /// <param name="size">If supplied, *size will be set to the size of the side data or to zero if the desired side data is not present.</param>
        /// <returns>pointer to data if present or NULL otherwise</returns>
        public byte* av_packet_get_side_data(AVPacket* @pkt, AVPacketSideDataType @type, ulong* @size)
        {
            return av_packet_get_side_data_ptr(@pkt, @type, @size);
        }

        private av_packet_make_refcounted_delegate? _av_packet_make_refcounted_ptr;

        public av_packet_make_refcounted_delegate av_packet_make_refcounted_ptr => _av_packet_make_refcounted_ptr ?? (_av_packet_make_refcounted_ptr = NativeMethodDelegate<av_packet_make_refcounted_delegate>());

        /// <summary>Ensure the data described by a given packet is reference counted.</summary>
        /// <param name="pkt">packet whose data should be made reference counted.</param>
        /// <returns>0 on success, a negative AVERROR on error. On failure, the packet is unchanged.</returns>
        public int av_packet_make_refcounted(AVPacket* @pkt)
        {
            return av_packet_make_refcounted_ptr(@pkt);
        }

        private av_packet_make_writable_delegate? _av_packet_make_writable_ptr;

        public av_packet_make_writable_delegate av_packet_make_writable_ptr => _av_packet_make_writable_ptr ?? (_av_packet_make_writable_ptr = NativeMethodDelegate<av_packet_make_writable_delegate>());

        /// <summary>Create a writable reference for the data described by a given packet, avoiding data copy if possible.</summary>
        /// <param name="pkt">Packet whose data should be made writable.</param>
        /// <returns>0 on success, a negative AVERROR on failure. On failure, the packet is unchanged.</returns>
        public int av_packet_make_writable(AVPacket* @pkt)
        {
            return av_packet_make_writable_ptr(@pkt);
        }

        private av_packet_move_ref_delegate? _av_packet_move_ref_ptr;

        public av_packet_move_ref_delegate av_packet_move_ref_ptr => _av_packet_move_ref_ptr ?? (_av_packet_move_ref_ptr = NativeMethodDelegate<av_packet_move_ref_delegate>());

        /// <summary>Move every field in src to dst and reset src.</summary>
        /// <param name="dst">Destination packet</param>
        /// <param name="src">Source packet, will be reset</param>
        public void av_packet_move_ref(AVPacket* @dst, AVPacket* @src)
        {
            av_packet_move_ref_ptr(@dst, @src);
        }

        private av_packet_new_side_data_delegate? _av_packet_new_side_data_ptr;

        public av_packet_new_side_data_delegate av_packet_new_side_data_ptr => _av_packet_new_side_data_ptr ?? (_av_packet_new_side_data_ptr = NativeMethodDelegate<av_packet_new_side_data_delegate>());

        /// <summary>Allocate new information of a packet.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">side information type</param>
        /// <param name="size">side information size</param>
        /// <returns>pointer to fresh allocated data or NULL otherwise</returns>
        public byte* av_packet_new_side_data(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size)
        {
            return av_packet_new_side_data_ptr(@pkt, @type, @size);
        }

        private av_packet_pack_dictionary_delegate? _av_packet_pack_dictionary_ptr;

        public av_packet_pack_dictionary_delegate av_packet_pack_dictionary_ptr => _av_packet_pack_dictionary_ptr ?? (_av_packet_pack_dictionary_ptr = NativeMethodDelegate<av_packet_pack_dictionary_delegate>());

        /// <summary>Pack a dictionary for use in side_data.</summary>
        /// <param name="dict">The dictionary to pack.</param>
        /// <param name="size">pointer to store the size of the returned data</param>
        /// <returns>pointer to data if successful, NULL otherwise</returns>
        public byte* av_packet_pack_dictionary(AVDictionary* @dict, ulong* @size)
        {
            return av_packet_pack_dictionary_ptr(@dict, @size);
        }

        private av_packet_ref_delegate? _av_packet_ref_ptr;

        public av_packet_ref_delegate av_packet_ref_ptr => _av_packet_ref_ptr ?? (_av_packet_ref_ptr = NativeMethodDelegate<av_packet_ref_delegate>());

        /// <summary>Setup a new reference to the data described by a given packet</summary>
        /// <param name="dst">Destination packet. Will be completely overwritten.</param>
        /// <param name="src">Source packet</param>
        /// <returns>0 on success, a negative AVERROR on error. On error, dst will be blank (as if returned by av_packet_alloc()).</returns>
        public int av_packet_ref(AVPacket* @dst, AVPacket* @src)
        {
            return av_packet_ref_ptr(@dst, @src);
        }

        private av_packet_rescale_ts_delegate? _av_packet_rescale_ts_ptr;

        public av_packet_rescale_ts_delegate av_packet_rescale_ts_ptr => _av_packet_rescale_ts_ptr ?? (_av_packet_rescale_ts_ptr = NativeMethodDelegate<av_packet_rescale_ts_delegate>());

        /// <summary>Convert valid timing fields (timestamps / durations) in a packet from one timebase to another. Timestamps with unknown values (AV_NOPTS_VALUE) will be ignored.</summary>
        /// <param name="pkt">packet on which the conversion will be performed</param>
        /// <param name="tb_src">source timebase, in which the timing fields in pkt are expressed</param>
        /// <param name="tb_dst">destination timebase, to which the timing fields will be converted</param>
        public void av_packet_rescale_ts(AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst)
        {
            av_packet_rescale_ts_ptr(@pkt, @tb_src, @tb_dst);
        }

        private av_packet_shrink_side_data_delegate? _av_packet_shrink_side_data_ptr;

        public av_packet_shrink_side_data_delegate av_packet_shrink_side_data_ptr => _av_packet_shrink_side_data_ptr ?? (_av_packet_shrink_side_data_ptr = NativeMethodDelegate<av_packet_shrink_side_data_delegate>());

        /// <summary>Shrink the already allocated side data buffer</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">side information type</param>
        /// <param name="size">new side information size</param>
        /// <returns>0 on success, &lt; 0 on failure</returns>
        public int av_packet_shrink_side_data(AVPacket* @pkt, AVPacketSideDataType @type, ulong @size)
        {
            return av_packet_shrink_side_data_ptr(@pkt, @type, @size);
        }

        private av_packet_side_data_name_delegate? _av_packet_side_data_name_ptr;

        public av_packet_side_data_name_delegate av_packet_side_data_name_ptr => _av_packet_side_data_name_ptr ?? (_av_packet_side_data_name_ptr = NativeMethodDelegate<av_packet_side_data_name_delegate>());

        public string av_packet_side_data_name(AVPacketSideDataType @type)
        {
            return av_packet_side_data_name_ptr(@type);
        }

        private av_packet_unpack_dictionary_delegate? _av_packet_unpack_dictionary_ptr;

        public av_packet_unpack_dictionary_delegate av_packet_unpack_dictionary_ptr => _av_packet_unpack_dictionary_ptr ?? (_av_packet_unpack_dictionary_ptr = NativeMethodDelegate<av_packet_unpack_dictionary_delegate>());

        /// <summary>Unpack a dictionary from side_data.</summary>
        /// <param name="data">data from side_data</param>
        /// <param name="size">size of the data</param>
        /// <param name="dict">the metadata storage dictionary</param>
        /// <returns>0 on success, &lt; 0 on failure</returns>
        public int av_packet_unpack_dictionary(byte* @data, ulong @size, AVDictionary** @dict)
        {
            return av_packet_unpack_dictionary_ptr(@data, @size, @dict);
        }

        private av_packet_unref_delegate? _av_packet_unref_ptr;

        public av_packet_unref_delegate av_packet_unref_ptr => _av_packet_unref_ptr ?? (_av_packet_unref_ptr = NativeMethodDelegate<av_packet_unref_delegate>());

        /// <summary>Wipe the packet.</summary>
        /// <param name="pkt">The packet to be unreferenced.</param>
        public void av_packet_unref(AVPacket* @pkt)
        {
            av_packet_unref_ptr(@pkt);
        }

        private av_parser_close_delegate? _av_parser_close_ptr;

        public av_parser_close_delegate av_parser_close_ptr => _av_parser_close_ptr ?? (_av_parser_close_ptr = NativeMethodDelegate<av_parser_close_delegate>());

        public void av_parser_close(AVCodecParserContext* @s)
        {
            av_parser_close_ptr(@s);
        }

        private av_parser_init_delegate? _av_parser_init_ptr;

        public av_parser_init_delegate av_parser_init_ptr => _av_parser_init_ptr ?? (_av_parser_init_ptr = NativeMethodDelegate<av_parser_init_delegate>());

        public AVCodecParserContext* av_parser_init(int @codec_id)
        {
            return av_parser_init_ptr(@codec_id);
        }

        private av_parser_iterate_delegate? _av_parser_iterate_ptr;

        public av_parser_iterate_delegate av_parser_iterate_ptr => _av_parser_iterate_ptr ?? (_av_parser_iterate_ptr = NativeMethodDelegate<av_parser_iterate_delegate>());

        /// <summary>Iterate over all registered codec parsers.</summary>
        /// <param name="opaque">a pointer where libavcodec will store the iteration state. Must point to NULL to start the iteration.</param>
        /// <returns>the next registered codec parser or NULL when the iteration is finished</returns>
        public AVCodecParser* av_parser_iterate(void** @opaque)
        {
            return av_parser_iterate_ptr(@opaque);
        }

        private av_parser_parse2_delegate? _av_parser_parse2_ptr;

        public av_parser_parse2_delegate av_parser_parse2_ptr => _av_parser_parse2_ptr ?? (_av_parser_parse2_ptr = NativeMethodDelegate<av_parser_parse2_delegate>());

        /// <summary>Parse a packet.</summary>
        /// <param name="s">parser context.</param>
        /// <param name="avctx">codec context.</param>
        /// <param name="poutbuf">set to pointer to parsed buffer or NULL if not yet finished.</param>
        /// <param name="poutbuf_size">set to size of parsed buffer or zero if not yet finished.</param>
        /// <param name="buf">input buffer.</param>
        /// <param name="buf_size">buffer size in bytes without the padding. I.e. the full buffer size is assumed to be buf_size + AV_INPUT_BUFFER_PADDING_SIZE. To signal EOF, this should be 0 (so that the last frame can be output).</param>
        /// <param name="pts">input presentation timestamp.</param>
        /// <param name="dts">input decoding timestamp.</param>
        /// <param name="pos">input byte position in stream.</param>
        /// <returns>the number of bytes of the input bitstream used.</returns>
        public int av_parser_parse2(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos)
        {
            return av_parser_parse2_ptr(@s, @avctx, @poutbuf, @poutbuf_size, @buf, @buf_size, @pts, @dts, @pos);
        }

        private av_shrink_packet_delegate? _av_shrink_packet_ptr;

        public av_shrink_packet_delegate av_shrink_packet_ptr => _av_shrink_packet_ptr ?? (_av_shrink_packet_ptr = NativeMethodDelegate<av_shrink_packet_delegate>());

        /// <summary>Reduce packet size, correctly zeroing padding</summary>
        /// <param name="pkt">packet</param>
        /// <param name="size">new size</param>
        public void av_shrink_packet(AVPacket* @pkt, int @size)
        {
            av_shrink_packet_ptr(@pkt, @size);
        }

        private av_xiphlacing_delegate? _av_xiphlacing_ptr;

        public av_xiphlacing_delegate av_xiphlacing_ptr => _av_xiphlacing_ptr ?? (_av_xiphlacing_ptr = NativeMethodDelegate<av_xiphlacing_delegate>());

        /// <summary>Encode extradata length to a buffer. Used by xiph codecs.</summary>
        /// <param name="s">buffer to write to; must be at least (v/255+1) bytes long</param>
        /// <param name="v">size of extradata in bytes</param>
        /// <returns>number of bytes written to the buffer.</returns>
        public uint av_xiphlacing(byte* @s, uint @v)
        {
            return av_xiphlacing_ptr(@s, @v);
        }

        private avcodec_align_dimensions_delegate? _avcodec_align_dimensions_ptr;

        public avcodec_align_dimensions_delegate avcodec_align_dimensions_ptr => _avcodec_align_dimensions_ptr ?? (_avcodec_align_dimensions_ptr = NativeMethodDelegate<avcodec_align_dimensions_delegate>());

        /// <summary>Modify width and height values so that they will result in a memory buffer that is acceptable for the codec if you do not use any horizontal padding.</summary>
        public void avcodec_align_dimensions(AVCodecContext* @s, int* @width, int* @height)
        {
            avcodec_align_dimensions_ptr(@s, @width, @height);
        }

        private avcodec_align_dimensions2_delegate? _avcodec_align_dimensions2_ptr;

        public avcodec_align_dimensions2_delegate avcodec_align_dimensions2_ptr => _avcodec_align_dimensions2_ptr ?? (_avcodec_align_dimensions2_ptr = NativeMethodDelegate<avcodec_align_dimensions2_delegate>());

        /// <summary>Modify width and height values so that they will result in a memory buffer that is acceptable for the codec if you also ensure that all line sizes are a multiple of the respective linesize_align[i].</summary>
        public void avcodec_align_dimensions2(AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align)
        {
            avcodec_align_dimensions2_ptr(@s, @width, @height, ref @linesize_align);
        }

        private avcodec_alloc_context3_delegate? _avcodec_alloc_context3_ptr;

        public avcodec_alloc_context3_delegate avcodec_alloc_context3_ptr => _avcodec_alloc_context3_ptr ?? (_avcodec_alloc_context3_ptr = NativeMethodDelegate<avcodec_alloc_context3_delegate>());

        /// <summary>Allocate an AVCodecContext and set its fields to default values. The resulting struct should be freed with avcodec_free_context().</summary>
        /// <param name="codec">if non-NULL, allocate private data and initialize defaults for the given codec. It is illegal to then call avcodec_open2() with a different codec. If NULL, then the codec-specific defaults won&apos;t be initialized, which may result in suboptimal default settings (this is important mainly for encoders, e.g. libx264).</param>
        /// <returns>An AVCodecContext filled with default values or NULL on failure.</returns>
        public AVCodecContext* avcodec_alloc_context3(AVCodec* @codec)
        {
            return avcodec_alloc_context3_ptr(@codec);
        }

        private avcodec_chroma_pos_to_enum_delegate? _avcodec_chroma_pos_to_enum_ptr;

        public avcodec_chroma_pos_to_enum_delegate avcodec_chroma_pos_to_enum_ptr => _avcodec_chroma_pos_to_enum_ptr ?? (_avcodec_chroma_pos_to_enum_ptr = NativeMethodDelegate<avcodec_chroma_pos_to_enum_delegate>());

        /// <summary>Converts swscale x/y chroma position to AVChromaLocation.</summary>
        /// <param name="xpos">horizontal chroma sample position</param>
        /// <param name="ypos">vertical   chroma sample position</param>
        public AVChromaLocation avcodec_chroma_pos_to_enum(int @xpos, int @ypos)
        {
            return avcodec_chroma_pos_to_enum_ptr(@xpos, @ypos);
        }

        private avcodec_close_delegate? _avcodec_close_ptr;

        public avcodec_close_delegate avcodec_close_ptr => _avcodec_close_ptr ?? (_avcodec_close_ptr = NativeMethodDelegate<avcodec_close_delegate>());

        /// <summary>Close a given AVCodecContext and free all the data associated with it (but not the AVCodecContext itself).</summary>
        public int avcodec_close(AVCodecContext* @avctx)
        {
            return avcodec_close_ptr(@avctx);
        }

        private avcodec_configuration_delegate? _avcodec_configuration_ptr;

        public avcodec_configuration_delegate avcodec_configuration_ptr => _avcodec_configuration_ptr ?? (_avcodec_configuration_ptr = NativeMethodDelegate<avcodec_configuration_delegate>());

        /// <summary>Return the libavcodec build-time configuration.</summary>
        public string avcodec_configuration()
        {
            return avcodec_configuration_ptr();
        }

        private avcodec_decode_subtitle2_delegate? _avcodec_decode_subtitle2_ptr;

        public avcodec_decode_subtitle2_delegate avcodec_decode_subtitle2_ptr => _avcodec_decode_subtitle2_ptr ?? (_avcodec_decode_subtitle2_ptr = NativeMethodDelegate<avcodec_decode_subtitle2_delegate>());

        /// <summary>Decode a subtitle message. Return a negative value on error, otherwise return the number of bytes used. If no subtitle could be decompressed, got_sub_ptr is zero. Otherwise, the subtitle is stored in *sub. Note that AV_CODEC_CAP_DR1 is not available for subtitle codecs. This is for simplicity, because the performance difference is expected to be negligible and reusing a get_buffer written for video codecs would probably perform badly due to a potentially very different allocation pattern.</summary>
        /// <param name="avctx">the codec context</param>
        /// <param name="sub">The preallocated AVSubtitle in which the decoded subtitle will be stored, must be freed with avsubtitle_free if *got_sub_ptr is set.</param>
        /// <param name="got_sub_ptr">Zero if no subtitle could be decompressed, otherwise, it is nonzero.</param>
        /// <param name="avpkt">The input AVPacket containing the input buffer.</param>
        public int avcodec_decode_subtitle2(AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt)
        {
            return avcodec_decode_subtitle2_ptr(@avctx, @sub, @got_sub_ptr, @avpkt);
        }

        private avcodec_default_execute_delegate? _avcodec_default_execute_ptr;

        public avcodec_default_execute_delegate avcodec_default_execute_ptr => _avcodec_default_execute_ptr ?? (_avcodec_default_execute_ptr = NativeMethodDelegate<avcodec_default_execute_delegate>());

        public int avcodec_default_execute(AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size)
        {
            return avcodec_default_execute_ptr(@c, @func, @arg, @ret, @count, @size);
        }

        private avcodec_default_execute2_delegate? _avcodec_default_execute2_ptr;

        public avcodec_default_execute2_delegate avcodec_default_execute2_ptr => _avcodec_default_execute2_ptr ?? (_avcodec_default_execute2_ptr = NativeMethodDelegate<avcodec_default_execute2_delegate>());

        public int avcodec_default_execute2(AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count)
        {
            return avcodec_default_execute2_ptr(@c, @func, @arg, @ret, @count);
        }

        private avcodec_default_get_buffer2_delegate? _avcodec_default_get_buffer2_ptr;

        public avcodec_default_get_buffer2_delegate avcodec_default_get_buffer2_ptr => _avcodec_default_get_buffer2_ptr ?? (_avcodec_default_get_buffer2_ptr = NativeMethodDelegate<avcodec_default_get_buffer2_delegate>());

        /// <summary>The default callback for AVCodecContext.get_buffer2(). It is made public so it can be called by custom get_buffer2() implementations for decoders without AV_CODEC_CAP_DR1 set.</summary>
        public int avcodec_default_get_buffer2(AVCodecContext* @s, AVFrame* @frame, int @flags)
        {
            return avcodec_default_get_buffer2_ptr(@s, @frame, @flags);
        }

        private avcodec_default_get_encode_buffer_delegate? _avcodec_default_get_encode_buffer_ptr;

        public avcodec_default_get_encode_buffer_delegate avcodec_default_get_encode_buffer_ptr => _avcodec_default_get_encode_buffer_ptr ?? (_avcodec_default_get_encode_buffer_ptr = NativeMethodDelegate<avcodec_default_get_encode_buffer_delegate>());

        /// <summary>The default callback for AVCodecContext.get_encode_buffer(). It is made public so it can be called by custom get_encode_buffer() implementations for encoders without AV_CODEC_CAP_DR1 set.</summary>
        public int avcodec_default_get_encode_buffer(AVCodecContext* @s, AVPacket* @pkt, int @flags)
        {
            return avcodec_default_get_encode_buffer_ptr(@s, @pkt, @flags);
        }

        private avcodec_default_get_format_delegate? _avcodec_default_get_format_ptr;

        public avcodec_default_get_format_delegate avcodec_default_get_format_ptr => _avcodec_default_get_format_ptr ?? (_avcodec_default_get_format_ptr = NativeMethodDelegate<avcodec_default_get_format_delegate>());

        public AVPixelFormat avcodec_default_get_format(AVCodecContext* @s, AVPixelFormat* @fmt)
        {
            return avcodec_default_get_format_ptr(@s, @fmt);
        }

        private avcodec_descriptor_get_delegate? _avcodec_descriptor_get_ptr;

        public avcodec_descriptor_get_delegate avcodec_descriptor_get_ptr => _avcodec_descriptor_get_ptr ?? (_avcodec_descriptor_get_ptr = NativeMethodDelegate<avcodec_descriptor_get_delegate>());

        /// <summary>Returns descriptor for given codec ID or NULL if no descriptor exists.</summary>
        /// <returns>descriptor for given codec ID or NULL if no descriptor exists.</returns>
        public AVCodecDescriptor* avcodec_descriptor_get(AVCodecID @id)
        {
            return avcodec_descriptor_get_ptr(@id);
        }

        private avcodec_descriptor_get_by_name_delegate? _avcodec_descriptor_get_by_name_ptr;

        public avcodec_descriptor_get_by_name_delegate avcodec_descriptor_get_by_name_ptr => _avcodec_descriptor_get_by_name_ptr ?? (_avcodec_descriptor_get_by_name_ptr = NativeMethodDelegate<avcodec_descriptor_get_by_name_delegate>());

        /// <summary>Returns codec descriptor with the given name or NULL if no such descriptor exists.</summary>
        /// <returns>codec descriptor with the given name or NULL if no such descriptor exists.</returns>
        public AVCodecDescriptor* avcodec_descriptor_get_by_name(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return avcodec_descriptor_get_by_name_ptr(@name);
        }

        private avcodec_descriptor_next_delegate? _avcodec_descriptor_next_ptr;

        public avcodec_descriptor_next_delegate avcodec_descriptor_next_ptr => _avcodec_descriptor_next_ptr ?? (_avcodec_descriptor_next_ptr = NativeMethodDelegate<avcodec_descriptor_next_delegate>());

        /// <summary>Iterate over all codec descriptors known to libavcodec.</summary>
        /// <param name="prev">previous descriptor. NULL to get the first descriptor.</param>
        /// <returns>next descriptor or NULL after the last descriptor</returns>
        public AVCodecDescriptor* avcodec_descriptor_next(AVCodecDescriptor* @prev)
        {
            return avcodec_descriptor_next_ptr(@prev);
        }

        private avcodec_encode_subtitle_delegate? _avcodec_encode_subtitle_ptr;

        public avcodec_encode_subtitle_delegate avcodec_encode_subtitle_ptr => _avcodec_encode_subtitle_ptr ?? (_avcodec_encode_subtitle_ptr = NativeMethodDelegate<avcodec_encode_subtitle_delegate>());

        /// <summary>@{</summary>
        public int avcodec_encode_subtitle(AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub)
        {
            return avcodec_encode_subtitle_ptr(@avctx, @buf, @buf_size, @sub);
        }

        private avcodec_enum_to_chroma_pos_delegate? _avcodec_enum_to_chroma_pos_ptr;

        public avcodec_enum_to_chroma_pos_delegate avcodec_enum_to_chroma_pos_ptr => _avcodec_enum_to_chroma_pos_ptr ?? (_avcodec_enum_to_chroma_pos_ptr = NativeMethodDelegate<avcodec_enum_to_chroma_pos_delegate>());

        /// <summary>Converts AVChromaLocation to swscale x/y chroma position.</summary>
        /// <param name="xpos">horizontal chroma sample position</param>
        /// <param name="ypos">vertical   chroma sample position</param>
        public int avcodec_enum_to_chroma_pos(int* @xpos, int* @ypos, AVChromaLocation @pos)
        {
            return avcodec_enum_to_chroma_pos_ptr(@xpos, @ypos, @pos);
        }

        private avcodec_fill_audio_frame_delegate? _avcodec_fill_audio_frame_ptr;

        public avcodec_fill_audio_frame_delegate avcodec_fill_audio_frame_ptr => _avcodec_fill_audio_frame_ptr ?? (_avcodec_fill_audio_frame_ptr = NativeMethodDelegate<avcodec_fill_audio_frame_delegate>());

        /// <summary>Fill AVFrame audio data and linesize pointers.</summary>
        /// <param name="frame">the AVFrame frame-&gt;nb_samples must be set prior to calling the function. This function fills in frame-&gt;data, frame-&gt;extended_data, frame-&gt;linesize[0].</param>
        /// <param name="nb_channels">channel count</param>
        /// <param name="sample_fmt">sample format</param>
        /// <param name="buf">buffer to use for frame data</param>
        /// <param name="buf_size">size of buffer</param>
        /// <param name="align">plane size sample alignment (0 = default)</param>
        /// <returns>&gt;=0 on success, negative error code on failure</returns>
        public int avcodec_fill_audio_frame(AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align)
        {
            return avcodec_fill_audio_frame_ptr(@frame, @nb_channels, @sample_fmt, @buf, @buf_size, @align);
        }

        private avcodec_find_best_pix_fmt_of_list_delegate? _avcodec_find_best_pix_fmt_of_list_ptr;

        public avcodec_find_best_pix_fmt_of_list_delegate avcodec_find_best_pix_fmt_of_list_ptr => _avcodec_find_best_pix_fmt_of_list_ptr ?? (_avcodec_find_best_pix_fmt_of_list_ptr = NativeMethodDelegate<avcodec_find_best_pix_fmt_of_list_delegate>());

        /// <summary>Find the best pixel format to convert to given a certain source pixel format. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. avcodec_find_best_pix_fmt_of_2() searches which of the given pixel formats should be used to suffer the least amount of loss. The pixel formats from which it chooses one, are determined by the pix_fmt_list parameter.</summary>
        /// <param name="pix_fmt_list">AV_PIX_FMT_NONE terminated array of pixel formats to choose from</param>
        /// <param name="src_pix_fmt">source pixel format</param>
        /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
        /// <param name="loss_ptr">Combination of flags informing you what kind of losses will occur.</param>
        /// <returns>The best pixel format to convert to or -1 if none was found.</returns>
        public AVPixelFormat avcodec_find_best_pix_fmt_of_list(AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr)
        {
            return avcodec_find_best_pix_fmt_of_list_ptr(@pix_fmt_list, @src_pix_fmt, @has_alpha, @loss_ptr);
        }

        private avcodec_find_decoder_delegate? _avcodec_find_decoder_ptr;

        public avcodec_find_decoder_delegate avcodec_find_decoder_ptr => _avcodec_find_decoder_ptr ?? (_avcodec_find_decoder_ptr = NativeMethodDelegate<avcodec_find_decoder_delegate>());

        /// <summary>Find a registered decoder with a matching codec ID.</summary>
        /// <param name="id">AVCodecID of the requested decoder</param>
        /// <returns>A decoder if one was found, NULL otherwise.</returns>
        public AVCodec* avcodec_find_decoder(AVCodecID @id)
        {
            return avcodec_find_decoder_ptr(@id);
        }

        private avcodec_find_decoder_by_name_delegate? _avcodec_find_decoder_by_name_ptr;

        public avcodec_find_decoder_by_name_delegate avcodec_find_decoder_by_name_ptr => _avcodec_find_decoder_by_name_ptr ?? (_avcodec_find_decoder_by_name_ptr = NativeMethodDelegate<avcodec_find_decoder_by_name_delegate>());

        /// <summary>Find a registered decoder with the specified name.</summary>
        /// <param name="name">name of the requested decoder</param>
        /// <returns>A decoder if one was found, NULL otherwise.</returns>
        public AVCodec* avcodec_find_decoder_by_name(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return avcodec_find_decoder_by_name_ptr(@name);
        }

        private avcodec_find_encoder_delegate? _avcodec_find_encoder_ptr;

        public avcodec_find_encoder_delegate avcodec_find_encoder_ptr => _avcodec_find_encoder_ptr ?? (_avcodec_find_encoder_ptr = NativeMethodDelegate<avcodec_find_encoder_delegate>());

        /// <summary>Find a registered encoder with a matching codec ID.</summary>
        /// <param name="id">AVCodecID of the requested encoder</param>
        /// <returns>An encoder if one was found, NULL otherwise.</returns>
        public AVCodec* avcodec_find_encoder(AVCodecID @id)
        {
            return avcodec_find_encoder_ptr(@id);
        }

        private avcodec_find_encoder_by_name_delegate? _avcodec_find_encoder_by_name_ptr;

        public avcodec_find_encoder_by_name_delegate avcodec_find_encoder_by_name_ptr => _avcodec_find_encoder_by_name_ptr ?? (_avcodec_find_encoder_by_name_ptr = NativeMethodDelegate<avcodec_find_encoder_by_name_delegate>());

        /// <summary>Find a registered encoder with the specified name.</summary>
        /// <param name="name">name of the requested encoder</param>
        /// <returns>An encoder if one was found, NULL otherwise.</returns>
        public AVCodec* avcodec_find_encoder_by_name(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return avcodec_find_encoder_by_name_ptr(@name);
        }

        private avcodec_flush_buffers_delegate? _avcodec_flush_buffers_ptr;

        public avcodec_flush_buffers_delegate avcodec_flush_buffers_ptr => _avcodec_flush_buffers_ptr ?? (_avcodec_flush_buffers_ptr = NativeMethodDelegate<avcodec_flush_buffers_delegate>());

        /// <summary>Reset the internal codec state / flush internal buffers. Should be called e.g. when seeking or when switching to a different stream.</summary>
        public void avcodec_flush_buffers(AVCodecContext* @avctx)
        {
            avcodec_flush_buffers_ptr(@avctx);
        }

        private avcodec_free_context_delegate? _avcodec_free_context_ptr;

        public avcodec_free_context_delegate avcodec_free_context_ptr => _avcodec_free_context_ptr ?? (_avcodec_free_context_ptr = NativeMethodDelegate<avcodec_free_context_delegate>());

        /// <summary>Free the codec context and everything associated with it and write NULL to the provided pointer.</summary>
        public void avcodec_free_context(AVCodecContext** @avctx)
        {
            avcodec_free_context_ptr(@avctx);
        }

        private avcodec_get_class_delegate? _avcodec_get_class_ptr;

        public avcodec_get_class_delegate avcodec_get_class_ptr => _avcodec_get_class_ptr ?? (_avcodec_get_class_ptr = NativeMethodDelegate<avcodec_get_class_delegate>());

        /// <summary>Get the AVClass for AVCodecContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public AVClass* avcodec_get_class()
        {
            return avcodec_get_class_ptr();
        }

        private avcodec_get_frame_class_delegate? _avcodec_get_frame_class_ptr;

        public avcodec_get_frame_class_delegate avcodec_get_frame_class_ptr => _avcodec_get_frame_class_ptr ?? (_avcodec_get_frame_class_ptr = NativeMethodDelegate<avcodec_get_frame_class_delegate>());

        [Obsolete("This function should not be used.")]
        public AVClass* avcodec_get_frame_class()
        {
            return avcodec_get_frame_class_ptr();
        }

        private avcodec_get_hw_config_delegate? _avcodec_get_hw_config_ptr;

        public avcodec_get_hw_config_delegate avcodec_get_hw_config_ptr => _avcodec_get_hw_config_ptr ?? (_avcodec_get_hw_config_ptr = NativeMethodDelegate<avcodec_get_hw_config_delegate>());

        /// <summary>Retrieve supported hardware configurations for a codec.</summary>
        public AVCodecHWConfig* avcodec_get_hw_config(AVCodec* @codec, int @index)
        {
            return avcodec_get_hw_config_ptr(@codec, @index);
        }

        private avcodec_get_hw_frames_parameters_delegate? _avcodec_get_hw_frames_parameters_ptr;

        public avcodec_get_hw_frames_parameters_delegate avcodec_get_hw_frames_parameters_ptr => _avcodec_get_hw_frames_parameters_ptr ?? (_avcodec_get_hw_frames_parameters_ptr = NativeMethodDelegate<avcodec_get_hw_frames_parameters_delegate>());

        /// <summary>Create and return a AVHWFramesContext with values adequate for hardware decoding. This is meant to get called from the get_format callback, and is a helper for preparing a AVHWFramesContext for AVCodecContext.hw_frames_ctx. This API is for decoding with certain hardware acceleration modes/APIs only.</summary>
        /// <param name="avctx">The context which is currently calling get_format, and which implicitly contains all state needed for filling the returned AVHWFramesContext properly.</param>
        /// <param name="device_ref">A reference to the AVHWDeviceContext describing the device which will be used by the hardware decoder.</param>
        /// <param name="hw_pix_fmt">The hwaccel format you are going to return from get_format.</param>
        /// <param name="out_frames_ref">On success, set to a reference to an _uninitialized_ AVHWFramesContext, created from the given device_ref. Fields will be set to values required for decoding. Not changed if an error is returned.</param>
        /// <returns>zero on success, a negative value on error. The following error codes have special semantics: AVERROR(ENOENT): the decoder does not support this functionality. Setup is always manual, or it is a decoder which does not support setting AVCodecContext.hw_frames_ctx at all, or it is a software format. AVERROR(EINVAL): it is known that hardware decoding is not supported for this configuration, or the device_ref is not supported for the hwaccel referenced by hw_pix_fmt.</returns>
        public int avcodec_get_hw_frames_parameters(AVCodecContext* @avctx, AVBufferRef* @device_ref, AVPixelFormat @hw_pix_fmt, AVBufferRef** @out_frames_ref)
        {
            return avcodec_get_hw_frames_parameters_ptr(@avctx, @device_ref, @hw_pix_fmt, @out_frames_ref);
        }

        private avcodec_get_name_delegate? _avcodec_get_name_ptr;

        public avcodec_get_name_delegate avcodec_get_name_ptr => _avcodec_get_name_ptr ?? (_avcodec_get_name_ptr = NativeMethodDelegate<avcodec_get_name_delegate>());

        /// <summary>Get the name of a codec.</summary>
        /// <returns>a string identifying the codec; never NULL</returns>
        public string avcodec_get_name(AVCodecID @id)
        {
            return avcodec_get_name_ptr(@id);
        }

        private avcodec_get_subtitle_rect_class_delegate? _avcodec_get_subtitle_rect_class_ptr;

        public avcodec_get_subtitle_rect_class_delegate avcodec_get_subtitle_rect_class_ptr => _avcodec_get_subtitle_rect_class_ptr ?? (_avcodec_get_subtitle_rect_class_ptr = NativeMethodDelegate<avcodec_get_subtitle_rect_class_delegate>());

        /// <summary>Get the AVClass for AVSubtitleRect. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public AVClass* avcodec_get_subtitle_rect_class()
        {
            return avcodec_get_subtitle_rect_class_ptr();
        }

        private avcodec_get_type_delegate? _avcodec_get_type_ptr;

        public avcodec_get_type_delegate avcodec_get_type_ptr => _avcodec_get_type_ptr ?? (_avcodec_get_type_ptr = NativeMethodDelegate<avcodec_get_type_delegate>());

        /// <summary>Get the type of the given codec.</summary>
        public AVMediaType avcodec_get_type(AVCodecID @codec_id)
        {
            return avcodec_get_type_ptr(@codec_id);
        }

        private avcodec_is_open_delegate? _avcodec_is_open_ptr;

        public avcodec_is_open_delegate avcodec_is_open_ptr => _avcodec_is_open_ptr ?? (_avcodec_is_open_ptr = NativeMethodDelegate<avcodec_is_open_delegate>());

        /// <summary>Returns a positive value if s is open (i.e. avcodec_open2() was called on it with no corresponding avcodec_close()), 0 otherwise.</summary>
        /// <returns>a positive value if s is open (i.e. avcodec_open2() was called on it with no corresponding avcodec_close()), 0 otherwise.</returns>
        public int avcodec_is_open(AVCodecContext* @s)
        {
            return avcodec_is_open_ptr(@s);
        }

        private avcodec_license_delegate? _avcodec_license_ptr;

        public avcodec_license_delegate avcodec_license_ptr => _avcodec_license_ptr ?? (_avcodec_license_ptr = NativeMethodDelegate<avcodec_license_delegate>());

        /// <summary>Return the libavcodec license.</summary>
        public string avcodec_license()
        {
            return avcodec_license_ptr();
        }

        private avcodec_open2_delegate? _avcodec_open2_ptr;

        public avcodec_open2_delegate avcodec_open2_ptr => _avcodec_open2_ptr ?? (_avcodec_open2_ptr = NativeMethodDelegate<avcodec_open2_delegate>());

        /// <summary>Initialize the AVCodecContext to use the given AVCodec. Prior to using this function the context has to be allocated with avcodec_alloc_context3().</summary>
        /// <param name="avctx">The context to initialize.</param>
        /// <param name="codec">The codec to open this context for. If a non-NULL codec has been previously passed to avcodec_alloc_context3() or for this context, then this parameter MUST be either NULL or equal to the previously passed codec.</param>
        /// <param name="options">A dictionary filled with AVCodecContext and codec-private options. On return this object will be filled with options that were not found.</param>
        /// <returns>zero on success, a negative value on error</returns>
        public int avcodec_open2(AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options)
        {
            return avcodec_open2_ptr(@avctx, @codec, @options);
        }

        private avcodec_parameters_alloc_delegate? _avcodec_parameters_alloc_ptr;

        public avcodec_parameters_alloc_delegate avcodec_parameters_alloc_ptr => _avcodec_parameters_alloc_ptr ?? (_avcodec_parameters_alloc_ptr = NativeMethodDelegate<avcodec_parameters_alloc_delegate>());

        /// <summary>Allocate a new AVCodecParameters and set its fields to default values (unknown/invalid/0). The returned struct must be freed with avcodec_parameters_free().</summary>
        public AVCodecParameters* avcodec_parameters_alloc()
        {
            return avcodec_parameters_alloc_ptr();
        }

        private avcodec_parameters_copy_delegate? _avcodec_parameters_copy_ptr;

        public avcodec_parameters_copy_delegate avcodec_parameters_copy_ptr => _avcodec_parameters_copy_ptr ?? (_avcodec_parameters_copy_ptr = NativeMethodDelegate<avcodec_parameters_copy_delegate>());

        /// <summary>Copy the contents of src to dst. Any allocated fields in dst are freed and replaced with newly allocated duplicates of the corresponding fields in src.</summary>
        /// <returns>&gt;= 0 on success, a negative AVERROR code on failure.</returns>
        public int avcodec_parameters_copy(AVCodecParameters* @dst, AVCodecParameters* @src)
        {
            return avcodec_parameters_copy_ptr(@dst, @src);
        }

        private avcodec_parameters_free_delegate? _avcodec_parameters_free_ptr;

        public avcodec_parameters_free_delegate avcodec_parameters_free_ptr => _avcodec_parameters_free_ptr ?? (_avcodec_parameters_free_ptr = NativeMethodDelegate<avcodec_parameters_free_delegate>());

        /// <summary>Free an AVCodecParameters instance and everything associated with it and write NULL to the supplied pointer.</summary>
        public void avcodec_parameters_free(AVCodecParameters** @par)
        {
            avcodec_parameters_free_ptr(@par);
        }

        private avcodec_parameters_from_context_delegate? _avcodec_parameters_from_context_ptr;

        public avcodec_parameters_from_context_delegate avcodec_parameters_from_context_ptr => _avcodec_parameters_from_context_ptr ?? (_avcodec_parameters_from_context_ptr = NativeMethodDelegate<avcodec_parameters_from_context_delegate>());

        /// <summary>Fill the parameters struct based on the values from the supplied codec context. Any allocated fields in par are freed and replaced with duplicates of the corresponding fields in codec.</summary>
        /// <returns>&gt;= 0 on success, a negative AVERROR code on failure</returns>
        public int avcodec_parameters_from_context(AVCodecParameters* @par, AVCodecContext* @codec)
        {
            return avcodec_parameters_from_context_ptr(@par, @codec);
        }

        private avcodec_parameters_to_context_delegate? _avcodec_parameters_to_context_ptr;

        public avcodec_parameters_to_context_delegate avcodec_parameters_to_context_ptr => _avcodec_parameters_to_context_ptr ?? (_avcodec_parameters_to_context_ptr = NativeMethodDelegate<avcodec_parameters_to_context_delegate>());

        /// <summary>Fill the codec context based on the values from the supplied codec parameters. Any allocated fields in codec that have a corresponding field in par are freed and replaced with duplicates of the corresponding field in par. Fields in codec that do not have a counterpart in par are not touched.</summary>
        /// <returns>&gt;= 0 on success, a negative AVERROR code on failure.</returns>
        public int avcodec_parameters_to_context(AVCodecContext* @codec, AVCodecParameters* @par)
        {
            return avcodec_parameters_to_context_ptr(@codec, @par);
        }

        private avcodec_pix_fmt_to_codec_tag_delegate? _avcodec_pix_fmt_to_codec_tag_ptr;

        public avcodec_pix_fmt_to_codec_tag_delegate avcodec_pix_fmt_to_codec_tag_ptr => _avcodec_pix_fmt_to_codec_tag_ptr ?? (_avcodec_pix_fmt_to_codec_tag_ptr = NativeMethodDelegate<avcodec_pix_fmt_to_codec_tag_delegate>());

        /// <summary>Return a value representing the fourCC code associated to the pixel format pix_fmt, or 0 if no associated fourCC code can be found.</summary>
        public uint avcodec_pix_fmt_to_codec_tag(AVPixelFormat @pix_fmt)
        {
            return avcodec_pix_fmt_to_codec_tag_ptr(@pix_fmt);
        }

        private avcodec_profile_name_delegate? _avcodec_profile_name_ptr;

        public avcodec_profile_name_delegate avcodec_profile_name_ptr => _avcodec_profile_name_ptr ?? (_avcodec_profile_name_ptr = NativeMethodDelegate<avcodec_profile_name_delegate>());

        /// <summary>Return a name for the specified profile, if available.</summary>
        /// <param name="codec_id">the ID of the codec to which the requested profile belongs</param>
        /// <param name="profile">the profile value for which a name is requested</param>
        /// <returns>A name for the profile if found, NULL otherwise.</returns>
        public string avcodec_profile_name(AVCodecID @codec_id, int @profile)
        {
            return avcodec_profile_name_ptr(@codec_id, @profile);
        }

        private avcodec_receive_frame_delegate? _avcodec_receive_frame_ptr;

        public avcodec_receive_frame_delegate avcodec_receive_frame_ptr => _avcodec_receive_frame_ptr ?? (_avcodec_receive_frame_ptr = NativeMethodDelegate<avcodec_receive_frame_delegate>());

        /// <summary>Return decoded output data from a decoder.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="frame">This will be set to a reference-counted video or audio frame (depending on the decoder type) allocated by the decoder. Note that the function will always call av_frame_unref(frame) before doing anything else.</param>
        /// <returns>0:                 success, a frame was returned AVERROR(EAGAIN):   output is not available in this state - user must try to send new input AVERROR_EOF:       the decoder has been fully flushed, and there will be no more output frames AVERROR(EINVAL):   codec not opened, or it is an encoder AVERROR_INPUT_CHANGED:   current decoded frame has changed parameters with respect to first decoded frame. Applicable when flag AV_CODEC_FLAG_DROPCHANGED is set. other negative values: legitimate decoding errors</returns>
        public int avcodec_receive_frame(AVCodecContext* @avctx, AVFrame* @frame)
        {
            return avcodec_receive_frame_ptr(@avctx, @frame);
        }

        private avcodec_receive_packet_delegate? _avcodec_receive_packet_ptr;

        public avcodec_receive_packet_delegate avcodec_receive_packet_ptr => _avcodec_receive_packet_ptr ?? (_avcodec_receive_packet_ptr = NativeMethodDelegate<avcodec_receive_packet_delegate>());

        /// <summary>Read encoded data from the encoder.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="avpkt">This will be set to a reference-counted packet allocated by the encoder. Note that the function will always call av_packet_unref(avpkt) before doing anything else.</param>
        /// <returns>0 on success, otherwise negative error code: AVERROR(EAGAIN):   output is not available in the current state - user must try to send input AVERROR_EOF:       the encoder has been fully flushed, and there will be no more output packets AVERROR(EINVAL):   codec not opened, or it is a decoder other errors: legitimate encoding errors</returns>
        public int avcodec_receive_packet(AVCodecContext* @avctx, AVPacket* @avpkt)
        {
            return avcodec_receive_packet_ptr(@avctx, @avpkt);
        }

        private avcodec_send_frame_delegate? _avcodec_send_frame_ptr;

        public avcodec_send_frame_delegate avcodec_send_frame_ptr => _avcodec_send_frame_ptr ?? (_avcodec_send_frame_ptr = NativeMethodDelegate<avcodec_send_frame_delegate>());

        /// <summary>Supply a raw video or audio frame to the encoder. Use avcodec_receive_packet() to retrieve buffered output packets.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="frame">AVFrame containing the raw audio or video frame to be encoded. Ownership of the frame remains with the caller, and the encoder will not write to the frame. The encoder may create a reference to the frame data (or copy it if the frame is not reference-counted). It can be NULL, in which case it is considered a flush packet.  This signals the end of the stream. If the encoder still has packets buffered, it will return them after this call. Once flushing mode has been entered, additional flush packets are ignored, and sending frames will return AVERROR_EOF.</param>
        /// <returns>0 on success, otherwise negative error code: AVERROR(EAGAIN):   input is not accepted in the current state - user must read output with avcodec_receive_packet() (once all output is read, the packet should be resent, and the call will not fail with EAGAIN). AVERROR_EOF:       the encoder has been flushed, and no new frames can be sent to it AVERROR(EINVAL):   codec not opened, it is a decoder, or requires flush AVERROR(ENOMEM):   failed to add packet to internal queue, or similar other errors: legitimate encoding errors</returns>
        public int avcodec_send_frame(AVCodecContext* @avctx, AVFrame* @frame)
        {
            return avcodec_send_frame_ptr(@avctx, @frame);
        }

        private avcodec_send_packet_delegate? _avcodec_send_packet_ptr;

        public avcodec_send_packet_delegate avcodec_send_packet_ptr => _avcodec_send_packet_ptr ?? (_avcodec_send_packet_ptr = NativeMethodDelegate<avcodec_send_packet_delegate>());

        /// <summary>Supply raw packet data as input to a decoder.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="avpkt">The input AVPacket. Usually, this will be a single video frame, or several complete audio frames. Ownership of the packet remains with the caller, and the decoder will not write to the packet. The decoder may create a reference to the packet data (or copy it if the packet is not reference-counted). Unlike with older APIs, the packet is always fully consumed, and if it contains multiple frames (e.g. some audio codecs), will require you to call avcodec_receive_frame() multiple times afterwards before you can send a new packet. It can be NULL (or an AVPacket with data set to NULL and size set to 0); in this case, it is considered a flush packet, which signals the end of the stream. Sending the first flush packet will return success. Subsequent ones are unnecessary and will return AVERROR_EOF. If the decoder still has frames buffered, it will return them after sending a flush packet.</param>
        /// <returns>0 on success, otherwise negative error code: AVERROR(EAGAIN):   input is not accepted in the current state - user must read output with avcodec_receive_frame() (once all output is read, the packet should be resent, and the call will not fail with EAGAIN). AVERROR_EOF:       the decoder has been flushed, and no new packets can be sent to it (also returned if more than 1 flush packet is sent) AVERROR(EINVAL):   codec not opened, it is an encoder, or requires flush AVERROR(ENOMEM):   failed to add packet to internal queue, or similar other errors: legitimate decoding errors</returns>
        public int avcodec_send_packet(AVCodecContext* @avctx, AVPacket* @avpkt)
        {
            return avcodec_send_packet_ptr(@avctx, @avpkt);
        }

        private avcodec_string_delegate? _avcodec_string_ptr;

        public avcodec_string_delegate avcodec_string_ptr => _avcodec_string_ptr ?? (_avcodec_string_ptr = NativeMethodDelegate<avcodec_string_delegate>());

        /// <summary>@}</summary>
        public void avcodec_string(byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode)
        {
            avcodec_string_ptr(@buf, @buf_size, @enc, @encode);
        }

        private avcodec_version_delegate? _avcodec_version_ptr;

        public avcodec_version_delegate avcodec_version_ptr => _avcodec_version_ptr ?? (_avcodec_version_ptr = NativeMethodDelegate<avcodec_version_delegate>());

        /// <summary>Return the LIBAVCODEC_VERSION_INT constant.</summary>
        public uint avcodec_version()
        {
            return avcodec_version_ptr();
        }

        private avsubtitle_free_delegate? _avsubtitle_free_ptr;

        public avsubtitle_free_delegate avsubtitle_free_ptr => _avsubtitle_free_ptr ?? (_avsubtitle_free_ptr = NativeMethodDelegate<avsubtitle_free_delegate>());

        /// <summary>Free all allocated data in the given subtitle struct.</summary>
        /// <param name="sub">AVSubtitle to free.</param>
        public void avsubtitle_free(AVSubtitle* @sub)
        {
            avsubtitle_free_ptr(@sub);
        }

        private av_input_audio_device_next_delegate? _av_input_audio_device_next_ptr;

        public av_input_audio_device_next_delegate av_input_audio_device_next_ptr => _av_input_audio_device_next_ptr ?? (_av_input_audio_device_next_ptr = NativeMethodDelegate<av_input_audio_device_next_delegate>());

        /// <summary>Audio input devices iterator.</summary>
        public AVInputFormat* av_input_audio_device_next(AVInputFormat* @d)
        {
            return av_input_audio_device_next_ptr(@d);
        }

        private av_input_video_device_next_delegate? _av_input_video_device_next_ptr;

        public av_input_video_device_next_delegate av_input_video_device_next_ptr => _av_input_video_device_next_ptr ?? (_av_input_video_device_next_ptr = NativeMethodDelegate<av_input_video_device_next_delegate>());

        /// <summary>Video input devices iterator.</summary>
        public AVInputFormat* av_input_video_device_next(AVInputFormat* @d)
        {
            return av_input_video_device_next_ptr(@d);
        }

        private av_output_audio_device_next_delegate? _av_output_audio_device_next_ptr;

        public av_output_audio_device_next_delegate av_output_audio_device_next_ptr => _av_output_audio_device_next_ptr ?? (_av_output_audio_device_next_ptr = NativeMethodDelegate<av_output_audio_device_next_delegate>());

        /// <summary>Audio output devices iterator.</summary>
        public AVOutputFormat* av_output_audio_device_next(AVOutputFormat* @d)
        {
            return av_output_audio_device_next_ptr(@d);
        }

        private av_output_video_device_next_delegate? _av_output_video_device_next_ptr;

        public av_output_video_device_next_delegate av_output_video_device_next_ptr => _av_output_video_device_next_ptr ?? (_av_output_video_device_next_ptr = NativeMethodDelegate<av_output_video_device_next_delegate>());

        /// <summary>Video output devices iterator.</summary>
        public AVOutputFormat* av_output_video_device_next(AVOutputFormat* @d)
        {
            return av_output_video_device_next_ptr(@d);
        }

        private avdevice_app_to_dev_control_message_delegate? _avdevice_app_to_dev_control_message_ptr;

        public avdevice_app_to_dev_control_message_delegate avdevice_app_to_dev_control_message_ptr => _avdevice_app_to_dev_control_message_ptr ?? (_avdevice_app_to_dev_control_message_ptr = NativeMethodDelegate<avdevice_app_to_dev_control_message_delegate>());

        /// <summary>Send control message from application to device.</summary>
        /// <param name="s">device context.</param>
        /// <param name="type">message type.</param>
        /// <param name="data">message data. Exact type depends on message type.</param>
        /// <param name="data_size">size of message data.</param>
        /// <returns>&gt;= 0 on success, negative on error. AVERROR(ENOSYS) when device doesn&apos;t implement handler of the message.</returns>
        public int avdevice_app_to_dev_control_message(AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size)
        {
            return avdevice_app_to_dev_control_message_ptr(@s, @type, @data, @data_size);
        }

        private avdevice_capabilities_create_delegate? _avdevice_capabilities_create_ptr;

        public avdevice_capabilities_create_delegate avdevice_capabilities_create_ptr => _avdevice_capabilities_create_ptr ?? (_avdevice_capabilities_create_ptr = NativeMethodDelegate<avdevice_capabilities_create_delegate>());

        /// <summary>Initialize capabilities probing API based on AVOption API.</summary>
        /// <param name="caps">Device capabilities data. Pointer to a NULL pointer must be passed.</param>
        /// <param name="s">Context of the device.</param>
        /// <param name="device_options">An AVDictionary filled with device-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL. The same options must be passed later to avformat_write_header() for output devices or avformat_open_input() for input devices, or at any other place that affects device-private options.</param>
        /// <returns>&gt;= 0 on success, negative otherwise.</returns>
        [Obsolete("")]
        public int avdevice_capabilities_create(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s, AVDictionary** @device_options)
        {
            return avdevice_capabilities_create_ptr(@caps, @s, @device_options);
        }

        private avdevice_capabilities_free_delegate? _avdevice_capabilities_free_ptr;

        public avdevice_capabilities_free_delegate avdevice_capabilities_free_ptr => _avdevice_capabilities_free_ptr ?? (_avdevice_capabilities_free_ptr = NativeMethodDelegate<avdevice_capabilities_free_delegate>());

        /// <summary>Free resources created by avdevice_capabilities_create()</summary>
        /// <param name="caps">Device capabilities data to be freed.</param>
        /// <param name="s">Context of the device.</param>
        [Obsolete("")]
        public void avdevice_capabilities_free(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s)
        {
            avdevice_capabilities_free_ptr(@caps, @s);
        }

        private avdevice_configuration_delegate? _avdevice_configuration_ptr;

        public avdevice_configuration_delegate avdevice_configuration_ptr => _avdevice_configuration_ptr ?? (_avdevice_configuration_ptr = NativeMethodDelegate<avdevice_configuration_delegate>());

        /// <summary>Return the libavdevice build-time configuration.</summary>
        public string avdevice_configuration()
        {
            return avdevice_configuration_ptr();
        }

        private avdevice_dev_to_app_control_message_delegate? _avdevice_dev_to_app_control_message_ptr;

        public avdevice_dev_to_app_control_message_delegate avdevice_dev_to_app_control_message_ptr => _avdevice_dev_to_app_control_message_ptr ?? (_avdevice_dev_to_app_control_message_ptr = NativeMethodDelegate<avdevice_dev_to_app_control_message_delegate>());

        /// <summary>Send control message from device to application.</summary>
        /// <param name="s">device context.</param>
        /// <param name="type">message type.</param>
        /// <param name="data">message data. Can be NULL.</param>
        /// <param name="data_size">size of message data.</param>
        /// <returns>&gt;= 0 on success, negative on error. AVERROR(ENOSYS) when application doesn&apos;t implement handler of the message.</returns>
        public int avdevice_dev_to_app_control_message(AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size)
        {
            return avdevice_dev_to_app_control_message_ptr(@s, @type, @data, @data_size);
        }

        private avdevice_free_list_devices_delegate? _avdevice_free_list_devices_ptr;

        public avdevice_free_list_devices_delegate avdevice_free_list_devices_ptr => _avdevice_free_list_devices_ptr ?? (_avdevice_free_list_devices_ptr = NativeMethodDelegate<avdevice_free_list_devices_delegate>());

        /// <summary>Convenient function to free result of avdevice_list_devices().</summary>
        public void avdevice_free_list_devices(AVDeviceInfoList** @device_list)
        {
            avdevice_free_list_devices_ptr(@device_list);
        }

        private avdevice_license_delegate? _avdevice_license_ptr;

        public avdevice_license_delegate avdevice_license_ptr => _avdevice_license_ptr ?? (_avdevice_license_ptr = NativeMethodDelegate<avdevice_license_delegate>());

        /// <summary>Return the libavdevice license.</summary>
        public string avdevice_license()
        {
            return avdevice_license_ptr();
        }

        private avdevice_list_devices_delegate? _avdevice_list_devices_ptr;

        public avdevice_list_devices_delegate avdevice_list_devices_ptr => _avdevice_list_devices_ptr ?? (_avdevice_list_devices_ptr = NativeMethodDelegate<avdevice_list_devices_delegate>());

        /// <summary>List devices.</summary>
        /// <param name="s">device context.</param>
        /// <param name="device_list">list of autodetected devices.</param>
        /// <returns>count of autodetected devices, negative on error.</returns>
        public int avdevice_list_devices(AVFormatContext* @s, AVDeviceInfoList** @device_list)
        {
            return avdevice_list_devices_ptr(@s, @device_list);
        }

        private avdevice_list_input_sources_delegate? _avdevice_list_input_sources_ptr;

        public avdevice_list_input_sources_delegate avdevice_list_input_sources_ptr => _avdevice_list_input_sources_ptr ?? (_avdevice_list_input_sources_ptr = NativeMethodDelegate<avdevice_list_input_sources_delegate>());

        /// <summary>List devices.</summary>
        /// <param name="device">device format. May be NULL if device name is set.</param>
        /// <param name="device_name">device name. May be NULL if device format is set.</param>
        /// <param name="device_options">An AVDictionary filled with device-private options. May be NULL. The same options must be passed later to avformat_write_header() for output devices or avformat_open_input() for input devices, or at any other place that affects device-private options.</param>
        /// <param name="device_list">list of autodetected devices</param>
        /// <returns>count of autodetected devices, negative on error.</returns>
        public int avdevice_list_input_sources(AVInputFormat* @device,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list)
        {
            return avdevice_list_input_sources_ptr(@device, @device_name, @device_options, @device_list);
        }

        private avdevice_list_output_sinks_delegate? _avdevice_list_output_sinks_ptr;

        public avdevice_list_output_sinks_delegate avdevice_list_output_sinks_ptr => _avdevice_list_output_sinks_ptr ?? (_avdevice_list_output_sinks_ptr = NativeMethodDelegate<avdevice_list_output_sinks_delegate>());

        public int avdevice_list_output_sinks(AVOutputFormat* @device,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list)
        {
            return avdevice_list_output_sinks_ptr(@device, @device_name, @device_options, @device_list);
        }

        private avdevice_register_all_delegate? _avdevice_register_all_ptr;

        public avdevice_register_all_delegate avdevice_register_all_ptr => _avdevice_register_all_ptr ?? (_avdevice_register_all_ptr = NativeMethodDelegate<avdevice_register_all_delegate>());

        /// <summary>Initialize libavdevice and register all the input and output devices.</summary>
        public void avdevice_register_all()
        {
            avdevice_register_all_ptr();
        }

        private avdevice_version_delegate? _avdevice_version_ptr;

        public avdevice_version_delegate avdevice_version_ptr => _avdevice_version_ptr ?? (_avdevice_version_ptr = NativeMethodDelegate<avdevice_version_delegate>());

        /// <summary>Return the LIBAVDEVICE_VERSION_INT constant.</summary>
        public uint avdevice_version()
        {
            return avdevice_version_ptr();
        }

        private av_abuffersink_params_alloc_delegate? _av_abuffersink_params_alloc_ptr;

        public av_abuffersink_params_alloc_delegate av_abuffersink_params_alloc_ptr => _av_abuffersink_params_alloc_ptr ?? (_av_abuffersink_params_alloc_ptr = NativeMethodDelegate<av_abuffersink_params_alloc_delegate>());

        /// <summary>Create an AVABufferSinkParams structure.</summary>
        [Obsolete("")]
        public AVABufferSinkParams* av_abuffersink_params_alloc()
        {
            return av_abuffersink_params_alloc_ptr();
        }

        private av_buffersink_get_channel_layout_delegate? _av_buffersink_get_channel_layout_ptr;

        public av_buffersink_get_channel_layout_delegate av_buffersink_get_channel_layout_ptr => _av_buffersink_get_channel_layout_ptr ?? (_av_buffersink_get_channel_layout_ptr = NativeMethodDelegate<av_buffersink_get_channel_layout_delegate>());

        public ulong av_buffersink_get_channel_layout(AVFilterContext* @ctx)
        {
            return av_buffersink_get_channel_layout_ptr(@ctx);
        }

        private av_buffersink_get_channels_delegate? _av_buffersink_get_channels_ptr;

        public av_buffersink_get_channels_delegate av_buffersink_get_channels_ptr => _av_buffersink_get_channels_ptr ?? (_av_buffersink_get_channels_ptr = NativeMethodDelegate<av_buffersink_get_channels_delegate>());

        public int av_buffersink_get_channels(AVFilterContext* @ctx)
        {
            return av_buffersink_get_channels_ptr(@ctx);
        }

        private av_buffersink_get_format_delegate? _av_buffersink_get_format_ptr;

        public av_buffersink_get_format_delegate av_buffersink_get_format_ptr => _av_buffersink_get_format_ptr ?? (_av_buffersink_get_format_ptr = NativeMethodDelegate<av_buffersink_get_format_delegate>());

        public int av_buffersink_get_format(AVFilterContext* @ctx)
        {
            return av_buffersink_get_format_ptr(@ctx);
        }

        private av_buffersink_get_frame_delegate? _av_buffersink_get_frame_ptr;

        public av_buffersink_get_frame_delegate av_buffersink_get_frame_ptr => _av_buffersink_get_frame_ptr ?? (_av_buffersink_get_frame_ptr = NativeMethodDelegate<av_buffersink_get_frame_delegate>());

        /// <summary>Get a frame with filtered data from sink and put it in frame.</summary>
        /// <param name="ctx">pointer to a context of a buffersink or abuffersink AVFilter.</param>
        /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free()</param>
        /// <returns>- &gt;= 0 if a frame was successfully returned. - AVERROR(EAGAIN) if no frames are available at this point; more input frames must be added to the filtergraph to get more output. - AVERROR_EOF if there will be no more output frames on this sink. - A different negative AVERROR code in other failure cases.</returns>
        public int av_buffersink_get_frame(AVFilterContext* @ctx, AVFrame* @frame)
        {
            return av_buffersink_get_frame_ptr(@ctx, @frame);
        }

        private av_buffersink_get_frame_flags_delegate? _av_buffersink_get_frame_flags_ptr;

        public av_buffersink_get_frame_flags_delegate av_buffersink_get_frame_flags_ptr => _av_buffersink_get_frame_flags_ptr ?? (_av_buffersink_get_frame_flags_ptr = NativeMethodDelegate<av_buffersink_get_frame_flags_delegate>());

        /// <summary>Get a frame with filtered data from sink and put it in frame.</summary>
        /// <param name="ctx">pointer to a buffersink or abuffersink filter context.</param>
        /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free()</param>
        /// <param name="flags">a combination of AV_BUFFERSINK_FLAG_* flags</param>
        /// <returns>&gt;= 0 in for success, a negative AVERROR code for failure.</returns>
        public int av_buffersink_get_frame_flags(AVFilterContext* @ctx, AVFrame* @frame, int @flags)
        {
            return av_buffersink_get_frame_flags_ptr(@ctx, @frame, @flags);
        }

        private av_buffersink_get_frame_rate_delegate? _av_buffersink_get_frame_rate_ptr;

        public av_buffersink_get_frame_rate_delegate av_buffersink_get_frame_rate_ptr => _av_buffersink_get_frame_rate_ptr ?? (_av_buffersink_get_frame_rate_ptr = NativeMethodDelegate<av_buffersink_get_frame_rate_delegate>());

        public AVRational av_buffersink_get_frame_rate(AVFilterContext* @ctx)
        {
            return av_buffersink_get_frame_rate_ptr(@ctx);
        }

        private av_buffersink_get_h_delegate? _av_buffersink_get_h_ptr;

        public av_buffersink_get_h_delegate av_buffersink_get_h_ptr => _av_buffersink_get_h_ptr ?? (_av_buffersink_get_h_ptr = NativeMethodDelegate<av_buffersink_get_h_delegate>());

        public int av_buffersink_get_h(AVFilterContext* @ctx)
        {
            return av_buffersink_get_h_ptr(@ctx);
        }

        private av_buffersink_get_hw_frames_ctx_delegate? _av_buffersink_get_hw_frames_ctx_ptr;

        public av_buffersink_get_hw_frames_ctx_delegate av_buffersink_get_hw_frames_ctx_ptr => _av_buffersink_get_hw_frames_ctx_ptr ?? (_av_buffersink_get_hw_frames_ctx_ptr = NativeMethodDelegate<av_buffersink_get_hw_frames_ctx_delegate>());

        public AVBufferRef* av_buffersink_get_hw_frames_ctx(AVFilterContext* @ctx)
        {
            return av_buffersink_get_hw_frames_ctx_ptr(@ctx);
        }

        private av_buffersink_get_sample_aspect_ratio_delegate? _av_buffersink_get_sample_aspect_ratio_ptr;

        public av_buffersink_get_sample_aspect_ratio_delegate av_buffersink_get_sample_aspect_ratio_ptr => _av_buffersink_get_sample_aspect_ratio_ptr ?? (_av_buffersink_get_sample_aspect_ratio_ptr = NativeMethodDelegate<av_buffersink_get_sample_aspect_ratio_delegate>());

        public AVRational av_buffersink_get_sample_aspect_ratio(AVFilterContext* @ctx)
        {
            return av_buffersink_get_sample_aspect_ratio_ptr(@ctx);
        }

        private av_buffersink_get_sample_rate_delegate? _av_buffersink_get_sample_rate_ptr;

        public av_buffersink_get_sample_rate_delegate av_buffersink_get_sample_rate_ptr => _av_buffersink_get_sample_rate_ptr ?? (_av_buffersink_get_sample_rate_ptr = NativeMethodDelegate<av_buffersink_get_sample_rate_delegate>());

        public int av_buffersink_get_sample_rate(AVFilterContext* @ctx)
        {
            return av_buffersink_get_sample_rate_ptr(@ctx);
        }

        private av_buffersink_get_samples_delegate? _av_buffersink_get_samples_ptr;

        public av_buffersink_get_samples_delegate av_buffersink_get_samples_ptr => _av_buffersink_get_samples_ptr ?? (_av_buffersink_get_samples_ptr = NativeMethodDelegate<av_buffersink_get_samples_delegate>());

        /// <summary>Same as av_buffersink_get_frame(), but with the ability to specify the number of samples read. This function is less efficient than av_buffersink_get_frame(), because it copies the data around.</summary>
        /// <param name="ctx">pointer to a context of the abuffersink AVFilter.</param>
        /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free() frame will contain exactly nb_samples audio samples, except at the end of stream, when it can contain less than nb_samples.</param>
        /// <returns>The return codes have the same meaning as for av_buffersink_get_frame().</returns>
        public int av_buffersink_get_samples(AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples)
        {
            return av_buffersink_get_samples_ptr(@ctx, @frame, @nb_samples);
        }

        private av_buffersink_get_time_base_delegate? _av_buffersink_get_time_base_ptr;

        public av_buffersink_get_time_base_delegate av_buffersink_get_time_base_ptr => _av_buffersink_get_time_base_ptr ?? (_av_buffersink_get_time_base_ptr = NativeMethodDelegate<av_buffersink_get_time_base_delegate>());

        public AVRational av_buffersink_get_time_base(AVFilterContext* @ctx)
        {
            return av_buffersink_get_time_base_ptr(@ctx);
        }

        private av_buffersink_get_type_delegate? _av_buffersink_get_type_ptr;

        public av_buffersink_get_type_delegate av_buffersink_get_type_ptr => _av_buffersink_get_type_ptr ?? (_av_buffersink_get_type_ptr = NativeMethodDelegate<av_buffersink_get_type_delegate>());

        /// <summary>Get the properties of the stream @{</summary>
        public AVMediaType av_buffersink_get_type(AVFilterContext* @ctx)
        {
            return av_buffersink_get_type_ptr(@ctx);
        }

        private av_buffersink_get_w_delegate? _av_buffersink_get_w_ptr;

        public av_buffersink_get_w_delegate av_buffersink_get_w_ptr => _av_buffersink_get_w_ptr ?? (_av_buffersink_get_w_ptr = NativeMethodDelegate<av_buffersink_get_w_delegate>());

        public int av_buffersink_get_w(AVFilterContext* @ctx)
        {
            return av_buffersink_get_w_ptr(@ctx);
        }

        private av_buffersink_params_alloc_delegate? _av_buffersink_params_alloc_ptr;

        public av_buffersink_params_alloc_delegate av_buffersink_params_alloc_ptr => _av_buffersink_params_alloc_ptr ?? (_av_buffersink_params_alloc_ptr = NativeMethodDelegate<av_buffersink_params_alloc_delegate>());

        /// <summary>Create an AVBufferSinkParams structure.</summary>
        [Obsolete("")]
        public AVBufferSinkParams* av_buffersink_params_alloc()
        {
            return av_buffersink_params_alloc_ptr();
        }

        private av_buffersink_set_frame_size_delegate? _av_buffersink_set_frame_size_ptr;

        public av_buffersink_set_frame_size_delegate av_buffersink_set_frame_size_ptr => _av_buffersink_set_frame_size_ptr ?? (_av_buffersink_set_frame_size_ptr = NativeMethodDelegate<av_buffersink_set_frame_size_delegate>());

        /// <summary>Set the frame size for an audio buffer sink.</summary>
        public void av_buffersink_set_frame_size(AVFilterContext* @ctx, uint @frame_size)
        {
            av_buffersink_set_frame_size_ptr(@ctx, @frame_size);
        }

        private av_buffersrc_add_frame_delegate? _av_buffersrc_add_frame_ptr;

        public av_buffersrc_add_frame_delegate av_buffersrc_add_frame_ptr => _av_buffersrc_add_frame_ptr ?? (_av_buffersrc_add_frame_ptr = NativeMethodDelegate<av_buffersrc_add_frame_delegate>());

        /// <summary>Add a frame to the buffer source.</summary>
        /// <param name="ctx">an instance of the buffersrc filter</param>
        /// <param name="frame">frame to be added. If the frame is reference counted, this function will take ownership of the reference(s) and reset the frame. Otherwise the frame data will be copied. If this function returns an error, the input frame is not touched.</param>
        /// <returns>0 on success, a negative AVERROR on error.</returns>
        public int av_buffersrc_add_frame(AVFilterContext* @ctx, AVFrame* @frame)
        {
            return av_buffersrc_add_frame_ptr(@ctx, @frame);
        }

        private av_buffersrc_add_frame_flags_delegate? _av_buffersrc_add_frame_flags_ptr;

        public av_buffersrc_add_frame_flags_delegate av_buffersrc_add_frame_flags_ptr => _av_buffersrc_add_frame_flags_ptr ?? (_av_buffersrc_add_frame_flags_ptr = NativeMethodDelegate<av_buffersrc_add_frame_flags_delegate>());

        /// <summary>Add a frame to the buffer source.</summary>
        /// <param name="buffer_src">pointer to a buffer source context</param>
        /// <param name="frame">a frame, or NULL to mark EOF</param>
        /// <param name="flags">a combination of AV_BUFFERSRC_FLAG_*</param>
        /// <returns>&gt;= 0 in case of success, a negative AVERROR code in case of failure</returns>
        public int av_buffersrc_add_frame_flags(AVFilterContext* @buffer_src, AVFrame* @frame, int @flags)
        {
            return av_buffersrc_add_frame_flags_ptr(@buffer_src, @frame, @flags);
        }

        private av_buffersrc_close_delegate? _av_buffersrc_close_ptr;

        public av_buffersrc_close_delegate av_buffersrc_close_ptr => _av_buffersrc_close_ptr ?? (_av_buffersrc_close_ptr = NativeMethodDelegate<av_buffersrc_close_delegate>());

        /// <summary>Close the buffer source after EOF.</summary>
        public int av_buffersrc_close(AVFilterContext* @ctx, long @pts, uint @flags)
        {
            return av_buffersrc_close_ptr(@ctx, @pts, @flags);
        }

        private av_buffersrc_get_nb_failed_requests_delegate? _av_buffersrc_get_nb_failed_requests_ptr;

        public av_buffersrc_get_nb_failed_requests_delegate av_buffersrc_get_nb_failed_requests_ptr => _av_buffersrc_get_nb_failed_requests_ptr ?? (_av_buffersrc_get_nb_failed_requests_ptr = NativeMethodDelegate<av_buffersrc_get_nb_failed_requests_delegate>());

        /// <summary>Get the number of failed requests.</summary>
        public uint av_buffersrc_get_nb_failed_requests(AVFilterContext* @buffer_src)
        {
            return av_buffersrc_get_nb_failed_requests_ptr(@buffer_src);
        }

        private av_buffersrc_parameters_alloc_delegate? _av_buffersrc_parameters_alloc_ptr;

        public av_buffersrc_parameters_alloc_delegate av_buffersrc_parameters_alloc_ptr => _av_buffersrc_parameters_alloc_ptr ?? (_av_buffersrc_parameters_alloc_ptr = NativeMethodDelegate<av_buffersrc_parameters_alloc_delegate>());

        /// <summary>Allocate a new AVBufferSrcParameters instance. It should be freed by the caller with av_free().</summary>
        public AVBufferSrcParameters* av_buffersrc_parameters_alloc()
        {
            return av_buffersrc_parameters_alloc_ptr();
        }

        private av_buffersrc_parameters_set_delegate? _av_buffersrc_parameters_set_ptr;

        public av_buffersrc_parameters_set_delegate av_buffersrc_parameters_set_ptr => _av_buffersrc_parameters_set_ptr ?? (_av_buffersrc_parameters_set_ptr = NativeMethodDelegate<av_buffersrc_parameters_set_delegate>());

        /// <summary>Initialize the buffersrc or abuffersrc filter with the provided parameters. This function may be called multiple times, the later calls override the previous ones. Some of the parameters may also be set through AVOptions, then whatever method is used last takes precedence.</summary>
        /// <param name="ctx">an instance of the buffersrc or abuffersrc filter</param>
        /// <param name="param">the stream parameters. The frames later passed to this filter must conform to those parameters. All the allocated fields in param remain owned by the caller, libavfilter will make internal copies or references when necessary.</param>
        /// <returns>0 on success, a negative AVERROR code on failure.</returns>
        public int av_buffersrc_parameters_set(AVFilterContext* @ctx, AVBufferSrcParameters* @param)
        {
            return av_buffersrc_parameters_set_ptr(@ctx, @param);
        }

        private av_buffersrc_write_frame_delegate? _av_buffersrc_write_frame_ptr;

        public av_buffersrc_write_frame_delegate av_buffersrc_write_frame_ptr => _av_buffersrc_write_frame_ptr ?? (_av_buffersrc_write_frame_ptr = NativeMethodDelegate<av_buffersrc_write_frame_delegate>());

        /// <summary>Add a frame to the buffer source.</summary>
        /// <param name="ctx">an instance of the buffersrc filter</param>
        /// <param name="frame">frame to be added. If the frame is reference counted, this function will make a new reference to it. Otherwise the frame data will be copied.</param>
        /// <returns>0 on success, a negative AVERROR on error</returns>
        public int av_buffersrc_write_frame(AVFilterContext* @ctx, AVFrame* @frame)
        {
            return av_buffersrc_write_frame_ptr(@ctx, @frame);
        }

        private av_filter_iterate_delegate? _av_filter_iterate_ptr;

        public av_filter_iterate_delegate av_filter_iterate_ptr => _av_filter_iterate_ptr ?? (_av_filter_iterate_ptr = NativeMethodDelegate<av_filter_iterate_delegate>());

        /// <summary>Iterate over all registered filters.</summary>
        /// <param name="opaque">a pointer where libavfilter will store the iteration state. Must point to NULL to start the iteration.</param>
        /// <returns>the next registered filter or NULL when the iteration is finished</returns>
        public AVFilter* av_filter_iterate(void** @opaque)
        {
            return av_filter_iterate_ptr(@opaque);
        }

        private avfilter_config_links_delegate? _avfilter_config_links_ptr;

        public avfilter_config_links_delegate avfilter_config_links_ptr => _avfilter_config_links_ptr ?? (_avfilter_config_links_ptr = NativeMethodDelegate<avfilter_config_links_delegate>());

        /// <summary>Negotiate the media format, dimensions, etc of all inputs to a filter.</summary>
        /// <param name="filter">the filter to negotiate the properties for its inputs</param>
        /// <returns>zero on successful negotiation</returns>
        public int avfilter_config_links(AVFilterContext* @filter)
        {
            return avfilter_config_links_ptr(@filter);
        }

        private avfilter_configuration_delegate? _avfilter_configuration_ptr;

        public avfilter_configuration_delegate avfilter_configuration_ptr => _avfilter_configuration_ptr ?? (_avfilter_configuration_ptr = NativeMethodDelegate<avfilter_configuration_delegate>());

        /// <summary>Return the libavfilter build-time configuration.</summary>
        public string avfilter_configuration()
        {
            return avfilter_configuration_ptr();
        }

        private avfilter_filter_pad_count_delegate? _avfilter_filter_pad_count_ptr;

        public avfilter_filter_pad_count_delegate avfilter_filter_pad_count_ptr => _avfilter_filter_pad_count_ptr ?? (_avfilter_filter_pad_count_ptr = NativeMethodDelegate<avfilter_filter_pad_count_delegate>());

        /// <summary>Get the number of elements in an AVFilter&apos;s inputs or outputs array.</summary>
        public uint avfilter_filter_pad_count(AVFilter* @filter, int @is_output)
        {
            return avfilter_filter_pad_count_ptr(@filter, @is_output);
        }

        private avfilter_free_delegate? _avfilter_free_ptr;

        public avfilter_free_delegate avfilter_free_ptr => _avfilter_free_ptr ?? (_avfilter_free_ptr = NativeMethodDelegate<avfilter_free_delegate>());

        /// <summary>Free a filter context. This will also remove the filter from its filtergraph&apos;s list of filters.</summary>
        /// <param name="filter">the filter to free</param>
        public void avfilter_free(AVFilterContext* @filter)
        {
            avfilter_free_ptr(@filter);
        }

        private avfilter_get_by_name_delegate? _avfilter_get_by_name_ptr;

        public avfilter_get_by_name_delegate avfilter_get_by_name_ptr => _avfilter_get_by_name_ptr ?? (_avfilter_get_by_name_ptr = NativeMethodDelegate<avfilter_get_by_name_delegate>());

        /// <summary>Get a filter definition matching the given name.</summary>
        /// <param name="name">the filter name to find</param>
        /// <returns>the filter definition, if any matching one is registered. NULL if none found.</returns>
        public AVFilter* avfilter_get_by_name(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return avfilter_get_by_name_ptr(@name);
        }

        private avfilter_get_class_delegate? _avfilter_get_class_ptr;

        public avfilter_get_class_delegate avfilter_get_class_ptr => _avfilter_get_class_ptr ?? (_avfilter_get_class_ptr = NativeMethodDelegate<avfilter_get_class_delegate>());

        /// <summary>Returns AVClass for AVFilterContext.</summary>
        /// <returns>AVClass for AVFilterContext.</returns>
        public AVClass* avfilter_get_class()
        {
            return avfilter_get_class_ptr();
        }

        private avfilter_graph_alloc_delegate? _avfilter_graph_alloc_ptr;

        public avfilter_graph_alloc_delegate avfilter_graph_alloc_ptr => _avfilter_graph_alloc_ptr ?? (_avfilter_graph_alloc_ptr = NativeMethodDelegate<avfilter_graph_alloc_delegate>());

        /// <summary>Allocate a filter graph.</summary>
        /// <returns>the allocated filter graph on success or NULL.</returns>
        public AVFilterGraph* avfilter_graph_alloc()
        {
            return avfilter_graph_alloc_ptr();
        }

        private avfilter_graph_alloc_filter_delegate? _avfilter_graph_alloc_filter_ptr;

        public avfilter_graph_alloc_filter_delegate avfilter_graph_alloc_filter_ptr => _avfilter_graph_alloc_filter_ptr ?? (_avfilter_graph_alloc_filter_ptr = NativeMethodDelegate<avfilter_graph_alloc_filter_delegate>());

        /// <summary>Create a new filter instance in a filter graph.</summary>
        /// <param name="graph">graph in which the new filter will be used</param>
        /// <param name="filter">the filter to create an instance of</param>
        /// <param name="name">Name to give to the new instance (will be copied to AVFilterContext.name). This may be used by the caller to identify different filters, libavfilter itself assigns no semantics to this parameter. May be NULL.</param>
        /// <returns>the context of the newly created filter instance (note that it is also retrievable directly through AVFilterGraph.filters or with avfilter_graph_get_filter()) on success or NULL on failure.</returns>
        public AVFilterContext* avfilter_graph_alloc_filter(AVFilterGraph* @graph, AVFilter* @filter,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return avfilter_graph_alloc_filter_ptr(@graph, @filter, @name);
        }

        private avfilter_graph_config_delegate? _avfilter_graph_config_ptr;

        public avfilter_graph_config_delegate avfilter_graph_config_ptr => _avfilter_graph_config_ptr ?? (_avfilter_graph_config_ptr = NativeMethodDelegate<avfilter_graph_config_delegate>());

        /// <summary>Check validity and configure all the links and formats in the graph.</summary>
        /// <param name="graphctx">the filter graph</param>
        /// <param name="log_ctx">context used for logging</param>
        /// <returns>&gt;= 0 in case of success, a negative AVERROR code otherwise</returns>
        public int avfilter_graph_config(AVFilterGraph* @graphctx, void* @log_ctx)
        {
            return avfilter_graph_config_ptr(@graphctx, @log_ctx);
        }

        private avfilter_graph_create_filter_delegate? _avfilter_graph_create_filter_ptr;

        public avfilter_graph_create_filter_delegate avfilter_graph_create_filter_ptr => _avfilter_graph_create_filter_ptr ?? (_avfilter_graph_create_filter_ptr = NativeMethodDelegate<avfilter_graph_create_filter_delegate>());

        /// <summary>Create and add a filter instance into an existing graph. The filter instance is created from the filter filt and inited with the parameter args. opaque is currently ignored.</summary>
        /// <param name="name">the instance name to give to the created filter instance</param>
        /// <param name="graph_ctx">the filter graph</param>
        /// <returns>a negative AVERROR error code in case of failure, a non negative value otherwise</returns>
        public int avfilter_graph_create_filter(AVFilterContext** @filt_ctx, AVFilter* @filt,
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
    string @args, void* @opaque, AVFilterGraph* @graph_ctx)
        {
            return avfilter_graph_create_filter_ptr(@filt_ctx, @filt, @name, @args, @opaque, @graph_ctx);
        }

        private avfilter_graph_dump_delegate? _avfilter_graph_dump_ptr;

        public avfilter_graph_dump_delegate avfilter_graph_dump_ptr => _avfilter_graph_dump_ptr ?? (_avfilter_graph_dump_ptr = NativeMethodDelegate<avfilter_graph_dump_delegate>());

        /// <summary>Dump a graph into a human-readable string representation.</summary>
        /// <param name="graph">the graph to dump</param>
        /// <param name="options">formatting options; currently ignored</param>
        /// <returns>a string, or NULL in case of memory allocation failure; the string must be freed using av_free</returns>
        public byte* avfilter_graph_dump(AVFilterGraph* @graph,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @options)
        {
            return avfilter_graph_dump_ptr(@graph, @options);
        }

        private avfilter_graph_free_delegate? _avfilter_graph_free_ptr;

        public avfilter_graph_free_delegate avfilter_graph_free_ptr => _avfilter_graph_free_ptr ?? (_avfilter_graph_free_ptr = NativeMethodDelegate<avfilter_graph_free_delegate>());

        /// <summary>Free a graph, destroy its links, and set *graph to NULL. If *graph is NULL, do nothing.</summary>
        public void avfilter_graph_free(AVFilterGraph** @graph)
        {
            avfilter_graph_free_ptr(@graph);
        }

        private avfilter_graph_get_filter_delegate? _avfilter_graph_get_filter_ptr;

        public avfilter_graph_get_filter_delegate avfilter_graph_get_filter_ptr => _avfilter_graph_get_filter_ptr ?? (_avfilter_graph_get_filter_ptr = NativeMethodDelegate<avfilter_graph_get_filter_delegate>());

        /// <summary>Get a filter instance identified by instance name from graph.</summary>
        /// <param name="graph">filter graph to search through.</param>
        /// <param name="name">filter instance name (should be unique in the graph).</param>
        /// <returns>the pointer to the found filter instance or NULL if it cannot be found.</returns>
        public AVFilterContext* avfilter_graph_get_filter(AVFilterGraph* @graph,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return avfilter_graph_get_filter_ptr(@graph, @name);
        }

        private avfilter_graph_parse_delegate? _avfilter_graph_parse_ptr;

        public avfilter_graph_parse_delegate avfilter_graph_parse_fptr => _avfilter_graph_parse_ptr ?? (_avfilter_graph_parse_ptr = NativeMethodDelegate<avfilter_graph_parse_delegate>());

        /// <summary>Add a graph described by a string to a graph.</summary>
        /// <param name="graph">the filter graph where to link the parsed graph context</param>
        /// <param name="filters">string to be parsed</param>
        /// <param name="inputs">linked list to the inputs of the graph</param>
        /// <param name="outputs">linked list to the outputs of the graph</param>
        /// <returns>zero on success, a negative AVERROR code on error</returns>
        public int avfilter_graph_parse(AVFilterGraph* @graph,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx)
        {
            return avfilter_graph_parse_fptr(@graph, @filters, @inputs, @outputs, @log_ctx);
        }

        private avfilter_graph_parse_ptr_delegate? _avfilter_graph_parse_ptr_ptr;

        public avfilter_graph_parse_ptr_delegate avfilter_graph_parse_ptr_ptr => _avfilter_graph_parse_ptr_ptr ?? (_avfilter_graph_parse_ptr_ptr = NativeMethodDelegate<avfilter_graph_parse_ptr_delegate>());

        /// <summary>Add a graph described by a string to a graph.</summary>
        /// <param name="graph">the filter graph where to link the parsed graph context</param>
        /// <param name="filters">string to be parsed</param>
        /// <param name="inputs">pointer to a linked list to the inputs of the graph, may be NULL. If non-NULL, *inputs is updated to contain the list of open inputs after the parsing, should be freed with avfilter_inout_free().</param>
        /// <param name="outputs">pointer to a linked list to the outputs of the graph, may be NULL. If non-NULL, *outputs is updated to contain the list of open outputs after the parsing, should be freed with avfilter_inout_free().</param>
        /// <returns>non negative on success, a negative AVERROR code on error</returns>
        public int avfilter_graph_parse_ptr(AVFilterGraph* @graph,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx)
        {
            return avfilter_graph_parse_ptr_ptr(@graph, @filters, @inputs, @outputs, @log_ctx);
        }

        private avfilter_graph_parse2_delegate? _avfilter_graph_parse2_ptr;

        public avfilter_graph_parse2_delegate avfilter_graph_parse2_ptr => _avfilter_graph_parse2_ptr ?? (_avfilter_graph_parse2_ptr = NativeMethodDelegate<avfilter_graph_parse2_delegate>());

        /// <summary>Add a graph described by a string to a graph.</summary>
        /// <param name="graph">the filter graph where to link the parsed graph context</param>
        /// <param name="filters">string to be parsed</param>
        /// <param name="inputs">a linked list of all free (unlinked) inputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
        /// <param name="outputs">a linked list of all free (unlinked) outputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
        /// <returns>zero on success, a negative AVERROR code on error</returns>
        public int avfilter_graph_parse2(AVFilterGraph* @graph,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs)
        {
            return avfilter_graph_parse2_ptr(@graph, @filters, @inputs, @outputs);
        }

        private avfilter_graph_queue_command_delegate? _avfilter_graph_queue_command_ptr;

        public avfilter_graph_queue_command_delegate avfilter_graph_queue_command_ptr => _avfilter_graph_queue_command_ptr ?? (_avfilter_graph_queue_command_ptr = NativeMethodDelegate<avfilter_graph_queue_command_delegate>());

        /// <summary>Queue a command for one or more filter instances.</summary>
        /// <param name="graph">the filter graph</param>
        /// <param name="target">the filter(s) to which the command should be sent &quot;all&quot; sends to all filters otherwise it can be a filter or filter instance name which will send the command to all matching filters.</param>
        /// <param name="cmd">the command to sent, for handling simplicity all commands must be alphanumeric only</param>
        /// <param name="arg">the argument for the command</param>
        /// <param name="ts">time at which the command should be sent to the filter</param>
        public int avfilter_graph_queue_command(AVFilterGraph* @graph,
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
    string @arg, int @flags, double @ts)
        {
            return avfilter_graph_queue_command_ptr(@graph, @target, @cmd, @arg, @flags, @ts);
        }

        private avfilter_graph_request_oldest_delegate? _avfilter_graph_request_oldest_ptr;

        public avfilter_graph_request_oldest_delegate avfilter_graph_request_oldest_ptr => _avfilter_graph_request_oldest_ptr ?? (_avfilter_graph_request_oldest_ptr = NativeMethodDelegate<avfilter_graph_request_oldest_delegate>());

        /// <summary>Request a frame on the oldest sink link.</summary>
        /// <returns>the return value of ff_request_frame(), or AVERROR_EOF if all links returned AVERROR_EOF</returns>
        public int avfilter_graph_request_oldest(AVFilterGraph* @graph)
        {
            return avfilter_graph_request_oldest_ptr(@graph);
        }

        private avfilter_graph_send_command_delegate? _avfilter_graph_send_command_ptr;

        public avfilter_graph_send_command_delegate avfilter_graph_send_command_ptr => _avfilter_graph_send_command_ptr ?? (_avfilter_graph_send_command_ptr = NativeMethodDelegate<avfilter_graph_send_command_delegate>());

        /// <summary>Send a command to one or more filter instances.</summary>
        /// <param name="graph">the filter graph</param>
        /// <param name="target">the filter(s) to which the command should be sent &quot;all&quot; sends to all filters otherwise it can be a filter or filter instance name which will send the command to all matching filters.</param>
        /// <param name="cmd">the command to send, for handling simplicity all commands must be alphanumeric only</param>
        /// <param name="arg">the argument for the command</param>
        /// <param name="res">a buffer with size res_size where the filter(s) can return a response.</param>
        public int avfilter_graph_send_command(AVFilterGraph* @graph,
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
    string @arg, byte* @res, int @res_len, int @flags)
        {
            return avfilter_graph_send_command_ptr(@graph, @target, @cmd, @arg, @res, @res_len, @flags);
        }

        private avfilter_graph_set_auto_convert_delegate? _avfilter_graph_set_auto_convert_ptr;

        public avfilter_graph_set_auto_convert_delegate avfilter_graph_set_auto_convert_ptr => _avfilter_graph_set_auto_convert_ptr ?? (_avfilter_graph_set_auto_convert_ptr = NativeMethodDelegate<avfilter_graph_set_auto_convert_delegate>());

        /// <summary>Enable or disable automatic format conversion inside the graph.</summary>
        /// <param name="flags">any of the AVFILTER_AUTO_CONVERT_* constants</param>
        public void avfilter_graph_set_auto_convert(AVFilterGraph* @graph, uint @flags)
        {
            avfilter_graph_set_auto_convert_ptr(@graph, @flags);
        }

        private avfilter_init_dict_delegate? _avfilter_init_dict_ptr;

        public avfilter_init_dict_delegate avfilter_init_dict_ptr => _avfilter_init_dict_ptr ?? (_avfilter_init_dict_ptr = NativeMethodDelegate<avfilter_init_dict_delegate>());

        /// <summary>Initialize a filter with the supplied dictionary of options.</summary>
        /// <param name="ctx">uninitialized filter context to initialize</param>
        /// <param name="options">An AVDictionary filled with options for this filter. On return this parameter will be destroyed and replaced with a dict containing options that were not found. This dictionary must be freed by the caller. May be NULL, then this function is equivalent to avfilter_init_str() with the second parameter set to NULL.</param>
        /// <returns>0 on success, a negative AVERROR on failure</returns>
        public int avfilter_init_dict(AVFilterContext* @ctx, AVDictionary** @options)
        {
            return avfilter_init_dict_ptr(@ctx, @options);
        }

        private avfilter_init_str_delegate? _avfilter_init_str_ptr;

        public avfilter_init_str_delegate avfilter_init_str_ptr => _avfilter_init_str_ptr ?? (_avfilter_init_str_ptr = NativeMethodDelegate<avfilter_init_str_delegate>());

        /// <summary>Initialize a filter with the supplied parameters.</summary>
        /// <param name="ctx">uninitialized filter context to initialize</param>
        /// <param name="args">Options to initialize the filter with. This must be a &apos;:&apos;-separated list of options in the &apos;key=value&apos; form. May be NULL if the options have been set directly using the AVOptions API or there are no options that need to be set.</param>
        /// <returns>0 on success, a negative AVERROR on failure</returns>
        public int avfilter_init_str(AVFilterContext* @ctx,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @args)
        {
            return avfilter_init_str_ptr(@ctx, @args);
        }

        private avfilter_inout_alloc_delegate? _avfilter_inout_alloc_ptr;

        public avfilter_inout_alloc_delegate avfilter_inout_alloc_ptr => _avfilter_inout_alloc_ptr ?? (_avfilter_inout_alloc_ptr = NativeMethodDelegate<avfilter_inout_alloc_delegate>());

        /// <summary>Allocate a single AVFilterInOut entry. Must be freed with avfilter_inout_free().</summary>
        /// <returns>allocated AVFilterInOut on success, NULL on failure.</returns>
        public AVFilterInOut* avfilter_inout_alloc()
        {
            return avfilter_inout_alloc_ptr();
        }

        private avfilter_inout_free_delegate? _avfilter_inout_free_ptr;

        public avfilter_inout_free_delegate avfilter_inout_free_ptr => _avfilter_inout_free_ptr ?? (_avfilter_inout_free_ptr = NativeMethodDelegate<avfilter_inout_free_delegate>());

        /// <summary>Free the supplied list of AVFilterInOut and set *inout to NULL. If *inout is NULL, do nothing.</summary>
        public void avfilter_inout_free(AVFilterInOut** @inout)
        {
            avfilter_inout_free_ptr(@inout);
        }

        private avfilter_insert_filter_delegate? _avfilter_insert_filter_ptr;

        public avfilter_insert_filter_delegate avfilter_insert_filter_ptr => _avfilter_insert_filter_ptr ?? (_avfilter_insert_filter_ptr = NativeMethodDelegate<avfilter_insert_filter_delegate>());

        /// <summary>Insert a filter in the middle of an existing link.</summary>
        /// <param name="link">the link into which the filter should be inserted</param>
        /// <param name="filt">the filter to be inserted</param>
        /// <param name="filt_srcpad_idx">the input pad on the filter to connect</param>
        /// <param name="filt_dstpad_idx">the output pad on the filter to connect</param>
        /// <returns>zero on success</returns>
        public int avfilter_insert_filter(AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx)
        {
            return avfilter_insert_filter_ptr(@link, @filt, @filt_srcpad_idx, @filt_dstpad_idx);
        }

        private avfilter_license_delegate? _avfilter_license_ptr;

        public avfilter_license_delegate avfilter_license_ptr => _avfilter_license_ptr ?? (_avfilter_license_ptr = NativeMethodDelegate<avfilter_license_delegate>());

        /// <summary>Return the libavfilter license.</summary>
        public string avfilter_license()
        {
            return avfilter_license_ptr();
        }

        private avfilter_link_delegate? _avfilter_link_ptr;

        public avfilter_link_delegate avfilter_link_ptr => _avfilter_link_ptr ?? (_avfilter_link_ptr = NativeMethodDelegate<avfilter_link_delegate>());

        /// <summary>Link two filters together.</summary>
        /// <param name="src">the source filter</param>
        /// <param name="srcpad">index of the output pad on the source filter</param>
        /// <param name="dst">the destination filter</param>
        /// <param name="dstpad">index of the input pad on the destination filter</param>
        /// <returns>zero on success</returns>
        public int avfilter_link(AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad)
        {
            return avfilter_link_ptr(@src, @srcpad, @dst, @dstpad);
        }

        private avfilter_link_free_delegate? _avfilter_link_free_ptr;

        public avfilter_link_free_delegate avfilter_link_free_ptr => _avfilter_link_free_ptr ?? (_avfilter_link_free_ptr = NativeMethodDelegate<avfilter_link_free_delegate>());

        /// <summary>Free the link in *link, and set its pointer to NULL.</summary>
        public void avfilter_link_free(AVFilterLink** @link)
        {
            avfilter_link_free_ptr(@link);
        }

        private avfilter_pad_count_delegate? _avfilter_pad_count_ptr;

        public avfilter_pad_count_delegate avfilter_pad_count_ptr => _avfilter_pad_count_ptr ?? (_avfilter_pad_count_ptr = NativeMethodDelegate<avfilter_pad_count_delegate>());

        /// <summary>Get the number of elements in an AVFilter&apos;s inputs or outputs array.</summary>
        [Obsolete("Use avfilter_filter_pad_count() instead.")]
        public int avfilter_pad_count(AVFilterPad* @pads)
        {
            return avfilter_pad_count_ptr(@pads);
        }

        private avfilter_pad_get_name_delegate? _avfilter_pad_get_name_ptr;

        public avfilter_pad_get_name_delegate avfilter_pad_get_name_ptr => _avfilter_pad_get_name_ptr ?? (_avfilter_pad_get_name_ptr = NativeMethodDelegate<avfilter_pad_get_name_delegate>());

        /// <summary>Get the name of an AVFilterPad.</summary>
        /// <param name="pads">an array of AVFilterPads</param>
        /// <param name="pad_idx">index of the pad in the array; it is the caller&apos;s responsibility to ensure the index is valid</param>
        /// <returns>name of the pad_idx&apos;th pad in pads</returns>
        public string avfilter_pad_get_name(AVFilterPad* @pads, int @pad_idx)
        {
            return avfilter_pad_get_name_ptr(@pads, @pad_idx);
        }

        private avfilter_pad_get_type_delegate? _avfilter_pad_get_type_ptr;

        public avfilter_pad_get_type_delegate avfilter_pad_get_type_ptr => _avfilter_pad_get_type_ptr ?? (_avfilter_pad_get_type_ptr = NativeMethodDelegate<avfilter_pad_get_type_delegate>());

        /// <summary>Get the type of an AVFilterPad.</summary>
        /// <param name="pads">an array of AVFilterPads</param>
        /// <param name="pad_idx">index of the pad in the array; it is the caller&apos;s responsibility to ensure the index is valid</param>
        /// <returns>type of the pad_idx&apos;th pad in pads</returns>
        public AVMediaType avfilter_pad_get_type(AVFilterPad* @pads, int @pad_idx)
        {
            return avfilter_pad_get_type_ptr(@pads, @pad_idx);
        }

        private avfilter_process_command_delegate? _avfilter_process_command_ptr;

        public avfilter_process_command_delegate avfilter_process_command_ptr => _avfilter_process_command_ptr ?? (_avfilter_process_command_ptr = NativeMethodDelegate<avfilter_process_command_delegate>());

        /// <summary>Make the filter instance process a command. It is recommended to use avfilter_graph_send_command().</summary>
        public int avfilter_process_command(AVFilterContext* @filter,
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
    string @arg, byte* @res, int @res_len, int @flags)
        {
            return avfilter_process_command_ptr(@filter, @cmd, @arg, @res, @res_len, @flags);
        }

        private avfilter_version_delegate? _avfilter_version_ptr;

        public avfilter_version_delegate avfilter_version_ptr => _avfilter_version_ptr ?? (_avfilter_version_ptr = NativeMethodDelegate<avfilter_version_delegate>());

        /// <summary>Return the LIBAVFILTER_VERSION_INT constant.</summary>
        public uint avfilter_version()
        {
            return avfilter_version_ptr();
        }

        private av_add_index_entry_delegate? _av_add_index_entry_ptr;

        public av_add_index_entry_delegate av_add_index_entry_ptr => _av_add_index_entry_ptr ?? (_av_add_index_entry_ptr = NativeMethodDelegate<av_add_index_entry_delegate>());

        /// <summary>Add an index entry into a sorted list. Update the entry if the list already contains it.</summary>
        /// <param name="timestamp">timestamp in the time base of the given stream</param>
        public int av_add_index_entry(AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags)
        {
            return av_add_index_entry_ptr(@st, @pos, @timestamp, @size, @distance, @flags);
        }

        private av_append_packet_delegate? _av_append_packet_ptr;

        public av_append_packet_delegate av_append_packet_ptr => _av_append_packet_ptr ?? (_av_append_packet_ptr = NativeMethodDelegate<av_append_packet_delegate>());

        /// <summary>Read data and append it to the current content of the AVPacket. If pkt-&gt;size is 0 this is identical to av_get_packet. Note that this uses av_grow_packet and thus involves a realloc which is inefficient. Thus this function should only be used when there is no reasonable way to know (an upper bound of) the final size.</summary>
        /// <param name="s">associated IO context</param>
        /// <param name="pkt">packet</param>
        /// <param name="size">amount of data to read</param>
        /// <returns>&gt;0 (read size) if OK, AVERROR_xxx otherwise, previous data will not be lost even if an error occurs.</returns>
        public int av_append_packet(AVIOContext* @s, AVPacket* @pkt, int @size)
        {
            return av_append_packet_ptr(@s, @pkt, @size);
        }

        private av_codec_get_id_delegate? _av_codec_get_id_ptr;

        public av_codec_get_id_delegate av_codec_get_id_ptr => _av_codec_get_id_ptr ?? (_av_codec_get_id_ptr = NativeMethodDelegate<av_codec_get_id_delegate>());

        /// <summary>Get the AVCodecID for the given codec tag tag. If no codec id is found returns AV_CODEC_ID_NONE.</summary>
        /// <param name="tags">list of supported codec_id-codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
        /// <param name="tag">codec tag to match to a codec ID</param>
        public AVCodecID av_codec_get_id(AVCodecTag** @tags, uint @tag)
        {
            return av_codec_get_id_ptr(@tags, @tag);
        }

        private av_codec_get_tag_delegate? _av_codec_get_tag_ptr;

        public av_codec_get_tag_delegate av_codec_get_tag_ptr => _av_codec_get_tag_ptr ?? (_av_codec_get_tag_ptr = NativeMethodDelegate<av_codec_get_tag_delegate>());

        /// <summary>Get the codec tag for the given codec id id. If no codec tag is found returns 0.</summary>
        /// <param name="tags">list of supported codec_id-codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
        /// <param name="id">codec ID to match to a codec tag</param>
        public uint av_codec_get_tag(AVCodecTag** @tags, AVCodecID @id)
        {
            return av_codec_get_tag_ptr(@tags, @id);
        }

        private av_codec_get_tag2_delegate? _av_codec_get_tag2_ptr;

        public av_codec_get_tag2_delegate av_codec_get_tag2_ptr => _av_codec_get_tag2_ptr ?? (_av_codec_get_tag2_ptr = NativeMethodDelegate<av_codec_get_tag2_delegate>());

        /// <summary>Get the codec tag for the given codec id.</summary>
        /// <param name="tags">list of supported codec_id - codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
        /// <param name="id">codec id that should be searched for in the list</param>
        /// <param name="tag">A pointer to the found tag</param>
        /// <returns>0 if id was not found in tags, &gt; 0 if it was found</returns>
        public int av_codec_get_tag2(AVCodecTag** @tags, AVCodecID @id, uint* @tag)
        {
            return av_codec_get_tag2_ptr(@tags, @id, @tag);
        }

        private av_demuxer_iterate_delegate? _av_demuxer_iterate_ptr;

        public av_demuxer_iterate_delegate av_demuxer_iterate_ptr => _av_demuxer_iterate_ptr ?? (_av_demuxer_iterate_ptr = NativeMethodDelegate<av_demuxer_iterate_delegate>());

        /// <summary>Iterate over all registered demuxers.</summary>
        /// <param name="opaque">a pointer where libavformat will store the iteration state. Must point to NULL to start the iteration.</param>
        /// <returns>the next registered demuxer or NULL when the iteration is finished</returns>
        public AVInputFormat* av_demuxer_iterate(void** @opaque)
        {
            return av_demuxer_iterate_ptr(@opaque);
        }

        private av_disposition_from_string_delegate? _av_disposition_from_string_ptr;

        public av_disposition_from_string_delegate av_disposition_from_string_ptr => _av_disposition_from_string_ptr ?? (_av_disposition_from_string_ptr = NativeMethodDelegate<av_disposition_from_string_delegate>());

        /// <summary>Returns The AV_DISPOSITION_* flag corresponding to disp or a negative error code if disp does not correspond to a known stream disposition.</summary>
        /// <returns>The AV_DISPOSITION_* flag corresponding to disp or a negative error code if disp does not correspond to a known stream disposition.</returns>
        public int av_disposition_from_string(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @disp)
        {
            return av_disposition_from_string_ptr(@disp);
        }

        private av_disposition_to_string_delegate? _av_disposition_to_string_ptr;

        public av_disposition_to_string_delegate av_disposition_to_string_ptr => _av_disposition_to_string_ptr ?? (_av_disposition_to_string_ptr = NativeMethodDelegate<av_disposition_to_string_delegate>());

        /// <summary>Returns The string description corresponding to the lowest set bit in disposition. NULL when the lowest set bit does not correspond to a known disposition or when disposition is 0.</summary>
        /// <param name="disposition">a combination of AV_DISPOSITION_* values</param>
        /// <returns>The string description corresponding to the lowest set bit in disposition. NULL when the lowest set bit does not correspond to a known disposition or when disposition is 0.</returns>
        public string av_disposition_to_string(int @disposition)
        {
            return av_disposition_to_string_ptr(@disposition);
        }

        private av_dump_format_delegate? _av_dump_format_ptr;

        public av_dump_format_delegate av_dump_format_ptr => _av_dump_format_ptr ?? (_av_dump_format_ptr = NativeMethodDelegate<av_dump_format_delegate>());

        /// <summary>Print detailed information about the input or output format, such as duration, bitrate, streams, container, programs, metadata, side data, codec and time base.</summary>
        /// <param name="ic">the context to analyze</param>
        /// <param name="index">index of the stream to dump information about</param>
        /// <param name="url">the URL to print, such as source or destination file</param>
        /// <param name="is_output">Select whether the specified context is an input(0) or output(1)</param>
        public void av_dump_format(AVFormatContext* @ic, int @index,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @is_output)
        {
            av_dump_format_ptr(@ic, @index, @url, @is_output);
        }

        private av_filename_number_test_delegate? _av_filename_number_test_ptr;

        public av_filename_number_test_delegate av_filename_number_test_ptr => _av_filename_number_test_ptr ?? (_av_filename_number_test_ptr = NativeMethodDelegate<av_filename_number_test_delegate>());

        /// <summary>Check whether filename actually is a numbered sequence generator.</summary>
        /// <param name="filename">possible numbered sequence string</param>
        /// <returns>1 if a valid numbered sequence string, 0 otherwise</returns>
        public int av_filename_number_test(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename)
        {
            return av_filename_number_test_ptr(@filename);
        }

        private av_find_best_stream_delegate? _av_find_best_stream_ptr;

        public av_find_best_stream_delegate av_find_best_stream_ptr => _av_find_best_stream_ptr ?? (_av_find_best_stream_ptr = NativeMethodDelegate<av_find_best_stream_delegate>());

        /// <summary>Find the &quot;best&quot; stream in the file. The best stream is determined according to various heuristics as the most likely to be what the user expects. If the decoder parameter is non-NULL, av_find_best_stream will find the default decoder for the stream&apos;s codec; streams for which no decoder can be found are ignored.</summary>
        /// <param name="ic">media file handle</param>
        /// <param name="type">stream type: video, audio, subtitles, etc.</param>
        /// <param name="wanted_stream_nb">user-requested stream number, or -1 for automatic selection</param>
        /// <param name="related_stream">try to find a stream related (eg. in the same program) to this one, or -1 if none</param>
        /// <param name="decoder_ret">if non-NULL, returns the decoder for the selected stream</param>
        /// <param name="flags">flags; none are currently defined</param>
        /// <returns>the non-negative stream number in case of success, AVERROR_STREAM_NOT_FOUND if no stream with the requested type could be found, AVERROR_DECODER_NOT_FOUND if streams were found but no decoder</returns>
        public int av_find_best_stream(AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags)
        {
            return av_find_best_stream_ptr(@ic, @type, @wanted_stream_nb, @related_stream, @decoder_ret, @flags);
        }

        private av_find_default_stream_index_delegate? _av_find_default_stream_index_ptr;

        public av_find_default_stream_index_delegate av_find_default_stream_index_ptr => _av_find_default_stream_index_ptr ?? (_av_find_default_stream_index_ptr = NativeMethodDelegate<av_find_default_stream_index_delegate>());

        public int av_find_default_stream_index(AVFormatContext* @s)
        {
            return av_find_default_stream_index_ptr(@s);
        }

        private av_find_input_format_delegate? _av_find_input_format_ptr;

        public av_find_input_format_delegate av_find_input_format_ptr => _av_find_input_format_ptr ?? (_av_find_input_format_ptr = NativeMethodDelegate<av_find_input_format_delegate>());

        /// <summary>Find AVInputFormat based on the short name of the input format.</summary>
        public AVInputFormat* av_find_input_format(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @short_name)
        {
            return av_find_input_format_ptr(@short_name);
        }

        private av_find_program_from_stream_delegate? _av_find_program_from_stream_ptr;

        public av_find_program_from_stream_delegate av_find_program_from_stream_ptr => _av_find_program_from_stream_ptr ?? (_av_find_program_from_stream_ptr = NativeMethodDelegate<av_find_program_from_stream_delegate>());

        /// <summary>Find the programs which belong to a given stream.</summary>
        /// <param name="ic">media file handle</param>
        /// <param name="last">the last found program, the search will start after this program, or from the beginning if it is NULL</param>
        /// <param name="s">stream index</param>
        /// <returns>the next program which belongs to s, NULL if no program is found or the last program is not among the programs of ic.</returns>
        public AVProgram* av_find_program_from_stream(AVFormatContext* @ic, AVProgram* @last, int @s)
        {
            return av_find_program_from_stream_ptr(@ic, @last, @s);
        }

        private av_fmt_ctx_get_duration_estimation_method_delegate? _av_fmt_ctx_get_duration_estimation_method_ptr;

        public av_fmt_ctx_get_duration_estimation_method_delegate av_fmt_ctx_get_duration_estimation_method_ptr => _av_fmt_ctx_get_duration_estimation_method_ptr ?? (_av_fmt_ctx_get_duration_estimation_method_ptr = NativeMethodDelegate<av_fmt_ctx_get_duration_estimation_method_delegate>());

        /// <summary>Returns the method used to set ctx-&gt;duration.</summary>
        /// <returns>AVFMT_DURATION_FROM_PTS, AVFMT_DURATION_FROM_STREAM, or AVFMT_DURATION_FROM_BITRATE.</returns>
        public AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method(AVFormatContext* @ctx)
        {
            return av_fmt_ctx_get_duration_estimation_method_ptr(@ctx);
        }

        private av_format_inject_global_side_data_delegate? _av_format_inject_global_side_data_ptr;

        public av_format_inject_global_side_data_delegate av_format_inject_global_side_data_ptr => _av_format_inject_global_side_data_ptr ?? (_av_format_inject_global_side_data_ptr = NativeMethodDelegate<av_format_inject_global_side_data_delegate>());

        /// <summary>This function will cause global side data to be injected in the next packet of each stream as well as after any subsequent seek.</summary>
        public void av_format_inject_global_side_data(AVFormatContext* @s)
        {
            av_format_inject_global_side_data_ptr(@s);
        }

        private av_get_frame_filename_delegate? _av_get_frame_filename_ptr;

        public av_get_frame_filename_delegate av_get_frame_filename_ptr => _av_get_frame_filename_ptr ?? (_av_get_frame_filename_ptr = NativeMethodDelegate<av_get_frame_filename_delegate>());

        public int av_get_frame_filename(byte* @buf, int @buf_size,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @path, int @number)
        {
            return av_get_frame_filename_ptr(@buf, @buf_size, @path, @number);
        }

        private av_get_frame_filename2_delegate? _av_get_frame_filename2_ptr;

        public av_get_frame_filename2_delegate av_get_frame_filename2_ptr => _av_get_frame_filename2_ptr ?? (_av_get_frame_filename2_ptr = NativeMethodDelegate<av_get_frame_filename2_delegate>());

        /// <summary>Return in &apos;buf&apos; the path with &apos;%d&apos; replaced by a number.</summary>
        /// <param name="buf">destination buffer</param>
        /// <param name="buf_size">destination buffer size</param>
        /// <param name="path">numbered sequence string</param>
        /// <param name="number">frame number</param>
        /// <param name="flags">AV_FRAME_FILENAME_FLAGS_*</param>
        /// <returns>0 if OK, -1 on format error</returns>
        public int av_get_frame_filename2(byte* @buf, int @buf_size,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @path, int @number, int @flags)
        {
            return av_get_frame_filename2_ptr(@buf, @buf_size, @path, @number, @flags);
        }

        private av_get_output_timestamp_delegate? _av_get_output_timestamp_ptr;

        public av_get_output_timestamp_delegate av_get_output_timestamp_ptr => _av_get_output_timestamp_ptr ?? (_av_get_output_timestamp_ptr = NativeMethodDelegate<av_get_output_timestamp_delegate>());

        /// <summary>Get timing information for the data currently output. The exact meaning of &quot;currently output&quot; depends on the format. It is mostly relevant for devices that have an internal buffer and/or work in real time.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="stream">stream in the media file</param>
        /// <param name="dts">DTS of the last packet output for the stream, in stream time_base units</param>
        /// <param name="wall">absolute time when that packet whas output, in microsecond</param>
        /// <returns>0 if OK, AVERROR(ENOSYS) if the format does not support it Note: some formats or devices may not allow to measure dts and wall atomically.</returns>
        public int av_get_output_timestamp(AVFormatContext* @s, int @stream, long* @dts, long* @wall)
        {
            return av_get_output_timestamp_ptr(@s, @stream, @dts, @wall);
        }

        private av_get_packet_delegate? _av_get_packet_ptr;

        public av_get_packet_delegate av_get_packet_ptr => _av_get_packet_ptr ?? (_av_get_packet_ptr = NativeMethodDelegate<av_get_packet_delegate>());

        /// <summary>Allocate and read the payload of a packet and initialize its fields with default values.</summary>
        /// <param name="s">associated IO context</param>
        /// <param name="pkt">packet</param>
        /// <param name="size">desired payload size</param>
        /// <returns>&gt;0 (read size) if OK, AVERROR_xxx otherwise</returns>
        public int av_get_packet(AVIOContext* @s, AVPacket* @pkt, int @size)
        {
            return av_get_packet_ptr(@s, @pkt, @size);
        }

        private av_guess_codec_delegate? _av_guess_codec_ptr;

        public av_guess_codec_delegate av_guess_codec_ptr => _av_guess_codec_ptr ?? (_av_guess_codec_ptr = NativeMethodDelegate<av_guess_codec_delegate>());

        /// <summary>Guess the codec ID based upon muxer and filename.</summary>
        public AVCodecID av_guess_codec(AVOutputFormat* @fmt,
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
    string @mime_type, AVMediaType @type)
        {
            return av_guess_codec_ptr(@fmt, @short_name, @filename, @mime_type, @type);
        }

        private av_guess_format_delegate? _av_guess_format_ptr;

        public av_guess_format_delegate av_guess_format_ptr => _av_guess_format_ptr ?? (_av_guess_format_ptr = NativeMethodDelegate<av_guess_format_delegate>());

        /// <summary>Return the output format in the list of registered output formats which best matches the provided parameters, or return NULL if there is no match.</summary>
        /// <param name="short_name">if non-NULL checks if short_name matches with the names of the registered formats</param>
        /// <param name="filename">if non-NULL checks if filename terminates with the extensions of the registered formats</param>
        /// <param name="mime_type">if non-NULL checks if mime_type matches with the MIME type of the registered formats</param>
        public AVOutputFormat* av_guess_format(
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
    string @mime_type)
        {
            return av_guess_format_ptr(@short_name, @filename, @mime_type);
        }

        private av_guess_frame_rate_delegate? _av_guess_frame_rate_ptr;

        public av_guess_frame_rate_delegate av_guess_frame_rate_ptr => _av_guess_frame_rate_ptr ?? (_av_guess_frame_rate_ptr = NativeMethodDelegate<av_guess_frame_rate_delegate>());

        /// <summary>Guess the frame rate, based on both the container and codec information.</summary>
        /// <param name="ctx">the format context which the stream is part of</param>
        /// <param name="stream">the stream which the frame is part of</param>
        /// <param name="frame">the frame for which the frame rate should be determined, may be NULL</param>
        /// <returns>the guessed (valid) frame rate, 0/1 if no idea</returns>
        public AVRational av_guess_frame_rate(AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame)
        {
            return av_guess_frame_rate_ptr(@ctx, @stream, @frame);
        }

        private av_guess_sample_aspect_ratio_delegate? _av_guess_sample_aspect_ratio_ptr;

        public av_guess_sample_aspect_ratio_delegate av_guess_sample_aspect_ratio_ptr => _av_guess_sample_aspect_ratio_ptr ?? (_av_guess_sample_aspect_ratio_ptr = NativeMethodDelegate<av_guess_sample_aspect_ratio_delegate>());

        /// <summary>Guess the sample aspect ratio of a frame, based on both the stream and the frame aspect ratio.</summary>
        /// <param name="format">the format context which the stream is part of</param>
        /// <param name="stream">the stream which the frame is part of</param>
        /// <param name="frame">the frame with the aspect ratio to be determined</param>
        /// <returns>the guessed (valid) sample_aspect_ratio, 0/1 if no idea</returns>
        public AVRational av_guess_sample_aspect_ratio(AVFormatContext* @format, AVStream* @stream, AVFrame* @frame)
        {
            return av_guess_sample_aspect_ratio_ptr(@format, @stream, @frame);
        }

        private av_hex_dump_delegate? _av_hex_dump_ptr;

        public av_hex_dump_delegate av_hex_dump_ptr => _av_hex_dump_ptr ?? (_av_hex_dump_ptr = NativeMethodDelegate<av_hex_dump_delegate>());

        /// <summary>Send a nice hexadecimal dump of a buffer to the specified file stream.</summary>
        /// <param name="f">The file stream pointer where the dump should be sent to.</param>
        /// <param name="buf">buffer</param>
        /// <param name="size">buffer size</param>
        public void av_hex_dump(_iobuf* @f, byte* @buf, int @size)
        {
            av_hex_dump_ptr(@f, @buf, @size);
        }

        private av_hex_dump_log_delegate? _av_hex_dump_log_ptr;

        public av_hex_dump_log_delegate av_hex_dump_log_ptr => _av_hex_dump_log_ptr ?? (_av_hex_dump_log_ptr = NativeMethodDelegate<av_hex_dump_log_delegate>());

        /// <summary>Send a nice hexadecimal dump of a buffer to the log.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message, lower values signifying higher importance.</param>
        /// <param name="buf">buffer</param>
        /// <param name="size">buffer size</param>
        public void av_hex_dump_log(void* @avcl, int @level, byte* @buf, int @size)
        {
            av_hex_dump_log_ptr(@avcl, @level, @buf, @size);
        }

        private av_index_search_timestamp_delegate? _av_index_search_timestamp_ptr;

        public av_index_search_timestamp_delegate av_index_search_timestamp_ptr => _av_index_search_timestamp_ptr ?? (_av_index_search_timestamp_ptr = NativeMethodDelegate<av_index_search_timestamp_delegate>());

        /// <summary>Get the index for a specific timestamp.</summary>
        /// <param name="st">stream that the timestamp belongs to</param>
        /// <param name="timestamp">timestamp to retrieve the index for</param>
        /// <param name="flags">if AVSEEK_FLAG_BACKWARD then the returned index will correspond to the timestamp which is &lt; = the requested one, if backward is 0, then it will be &gt;= if AVSEEK_FLAG_ANY seek to any frame, only keyframes otherwise</param>
        /// <returns>&lt; 0 if no such timestamp could be found</returns>
        public int av_index_search_timestamp(AVStream* @st, long @timestamp, int @flags)
        {
            return av_index_search_timestamp_ptr(@st, @timestamp, @flags);
        }

        private av_interleaved_write_frame_delegate? _av_interleaved_write_frame_ptr;

        public av_interleaved_write_frame_delegate av_interleaved_write_frame_ptr => _av_interleaved_write_frame_ptr ?? (_av_interleaved_write_frame_ptr = NativeMethodDelegate<av_interleaved_write_frame_delegate>());

        /// <summary>Write a packet to an output media file ensuring correct interleaving.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="pkt">The packet containing the data to be written.  If the packet is reference-counted, this function will take ownership of this reference and unreference it later when it sees fit. If the packet is not reference-counted, libavformat will make a copy. The returned packet will be blank (as if returned from av_packet_alloc()), even on error.  This parameter can be NULL (at any time, not just at the end), to flush the interleaving queues.  Packet&apos;s &quot;stream_index&quot; field must be set to the index of the corresponding stream in &quot;s-&gt;streams&quot;.  The timestamps ( &quot;pts&quot;, &quot;dts&quot;) must be set to correct values in the stream&apos;s timebase (unless the output format is flagged with the AVFMT_NOTIMESTAMPS flag, then they can be set to AV_NOPTS_VALUE). The dts for subsequent packets in one stream must be strictly increasing (unless the output format is flagged with the AVFMT_TS_NONSTRICT, then they merely have to be nondecreasing).  &quot;duration&quot; should also be set if known.</param>
        /// <returns>0 on success, a negative AVERROR on error.</returns>
        public int av_interleaved_write_frame(AVFormatContext* @s, AVPacket* @pkt)
        {
            return av_interleaved_write_frame_ptr(@s, @pkt);
        }

        private av_interleaved_write_uncoded_frame_delegate? _av_interleaved_write_uncoded_frame_ptr;

        public av_interleaved_write_uncoded_frame_delegate av_interleaved_write_uncoded_frame_ptr => _av_interleaved_write_uncoded_frame_ptr ?? (_av_interleaved_write_uncoded_frame_ptr = NativeMethodDelegate<av_interleaved_write_uncoded_frame_delegate>());

        /// <summary>Write an uncoded frame to an output media file.</summary>
        /// <returns>&gt;=0 for success, a negative code on error</returns>
        public int av_interleaved_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame)
        {
            return av_interleaved_write_uncoded_frame_ptr(@s, @stream_index, @frame);
        }

        private av_match_ext_delegate? _av_match_ext_ptr;

        public av_match_ext_delegate av_match_ext_ptr => _av_match_ext_ptr ?? (_av_match_ext_ptr = NativeMethodDelegate<av_match_ext_delegate>());

        /// <summary>Return a positive value if the given filename has one of the given extensions, 0 otherwise.</summary>
        /// <param name="filename">file name to check against the given extensions</param>
        /// <param name="extensions">a comma-separated list of filename extensions</param>
        public int av_match_ext(
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
    string @extensions)
        {
            return av_match_ext_ptr(@filename, @extensions);
        }

        private av_muxer_iterate_delegate? _av_muxer_iterate_ptr;

        public av_muxer_iterate_delegate av_muxer_iterate_ptr => _av_muxer_iterate_ptr ?? (_av_muxer_iterate_ptr = NativeMethodDelegate<av_muxer_iterate_delegate>());

        /// <summary>Iterate over all registered muxers.</summary>
        /// <param name="opaque">a pointer where libavformat will store the iteration state. Must point to NULL to start the iteration.</param>
        /// <returns>the next registered muxer or NULL when the iteration is finished</returns>
        public AVOutputFormat* av_muxer_iterate(void** @opaque)
        {
            return av_muxer_iterate_ptr(@opaque);
        }

        private av_new_program_delegate? _av_new_program_ptr;

        public av_new_program_delegate av_new_program_ptr => _av_new_program_ptr ?? (_av_new_program_ptr = NativeMethodDelegate<av_new_program_delegate>());

        public AVProgram* av_new_program(AVFormatContext* @s, int @id)
        {
            return av_new_program_ptr(@s, @id);
        }

        private av_pkt_dump_log2_delegate? _av_pkt_dump_log2_ptr;

        public av_pkt_dump_log2_delegate av_pkt_dump_log2_ptr => _av_pkt_dump_log2_ptr ?? (_av_pkt_dump_log2_ptr = NativeMethodDelegate<av_pkt_dump_log2_delegate>());

        /// <summary>Send a nice dump of a packet to the log.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message, lower values signifying higher importance.</param>
        /// <param name="pkt">packet to dump</param>
        /// <param name="dump_payload">True if the payload must be displayed, too.</param>
        /// <param name="st">AVStream that the packet belongs to</param>
        public void av_pkt_dump_log2(void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st)
        {
            av_pkt_dump_log2_ptr(@avcl, @level, @pkt, @dump_payload, @st);
        }

        private av_pkt_dump2_delegate? _av_pkt_dump2_ptr;

        public av_pkt_dump2_delegate av_pkt_dump2_ptr => _av_pkt_dump2_ptr ?? (_av_pkt_dump2_ptr = NativeMethodDelegate<av_pkt_dump2_delegate>());

        /// <summary>Send a nice dump of a packet to the specified file stream.</summary>
        /// <param name="f">The file stream pointer where the dump should be sent to.</param>
        /// <param name="pkt">packet to dump</param>
        /// <param name="dump_payload">True if the payload must be displayed, too.</param>
        /// <param name="st">AVStream that the packet belongs to</param>
        public void av_pkt_dump2(_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st)
        {
            av_pkt_dump2_ptr(@f, @pkt, @dump_payload, @st);
        }

        private av_probe_input_buffer_delegate? _av_probe_input_buffer_ptr;

        public av_probe_input_buffer_delegate av_probe_input_buffer_ptr => _av_probe_input_buffer_ptr ?? (_av_probe_input_buffer_ptr = NativeMethodDelegate<av_probe_input_buffer_delegate>());

        /// <summary>Like av_probe_input_buffer2() but returns 0 on success</summary>
        public int av_probe_input_buffer(AVIOContext* @pb, AVInputFormat** @fmt,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size)
        {
            return av_probe_input_buffer_ptr(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
        }

        private av_probe_input_buffer2_delegate? _av_probe_input_buffer2_ptr;

        public av_probe_input_buffer2_delegate av_probe_input_buffer2_ptr => _av_probe_input_buffer2_ptr ?? (_av_probe_input_buffer2_ptr = NativeMethodDelegate<av_probe_input_buffer2_delegate>());

        /// <summary>Probe a bytestream to determine the input format. Each time a probe returns with a score that is too low, the probe buffer size is increased and another attempt is made. When the maximum probe size is reached, the input format with the highest score is returned.</summary>
        /// <param name="pb">the bytestream to probe</param>
        /// <param name="fmt">the input format is put here</param>
        /// <param name="url">the url of the stream</param>
        /// <param name="logctx">the log context</param>
        /// <param name="offset">the offset within the bytestream to probe from</param>
        /// <param name="max_probe_size">the maximum probe buffer size (zero for default)</param>
        /// <returns>the score in case of success, a negative value corresponding to an the maximal score is AVPROBE_SCORE_MAX AVERROR code otherwise</returns>
        public int av_probe_input_buffer2(AVIOContext* @pb, AVInputFormat** @fmt,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, void* @logctx, uint @offset, uint @max_probe_size)
        {
            return av_probe_input_buffer2_ptr(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
        }

        private av_probe_input_format_delegate? _av_probe_input_format_ptr;

        public av_probe_input_format_delegate av_probe_input_format_ptr => _av_probe_input_format_ptr ?? (_av_probe_input_format_ptr = NativeMethodDelegate<av_probe_input_format_delegate>());

        /// <summary>Guess the file format.</summary>
        /// <param name="pd">data to be probed</param>
        /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
        public AVInputFormat* av_probe_input_format(AVProbeData* @pd, int @is_opened)
        {
            return av_probe_input_format_ptr(@pd, @is_opened);
        }

        private av_probe_input_format2_delegate? _av_probe_input_format2_ptr;

        public av_probe_input_format2_delegate av_probe_input_format2_ptr => _av_probe_input_format2_ptr ?? (_av_probe_input_format2_ptr = NativeMethodDelegate<av_probe_input_format2_delegate>());

        /// <summary>Guess the file format.</summary>
        /// <param name="pd">data to be probed</param>
        /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
        /// <param name="score_max">A probe score larger that this is required to accept a detection, the variable is set to the actual detection score afterwards. If the score is &lt; = AVPROBE_SCORE_MAX / 4 it is recommended to retry with a larger probe buffer.</param>
        public AVInputFormat* av_probe_input_format2(AVProbeData* @pd, int @is_opened, int* @score_max)
        {
            return av_probe_input_format2_ptr(@pd, @is_opened, @score_max);
        }

        private av_probe_input_format3_delegate? _av_probe_input_format3_ptr;

        public av_probe_input_format3_delegate av_probe_input_format3_ptr => _av_probe_input_format3_ptr ?? (_av_probe_input_format3_ptr = NativeMethodDelegate<av_probe_input_format3_delegate>());

        /// <summary>Guess the file format.</summary>
        /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
        /// <param name="score_ret">The score of the best detection.</param>
        public AVInputFormat* av_probe_input_format3(AVProbeData* @pd, int @is_opened, int* @score_ret)
        {
            return av_probe_input_format3_ptr(@pd, @is_opened, @score_ret);
        }

        private av_program_add_stream_index_delegate? _av_program_add_stream_index_ptr;

        public av_program_add_stream_index_delegate av_program_add_stream_index_ptr => _av_program_add_stream_index_ptr ?? (_av_program_add_stream_index_ptr = NativeMethodDelegate<av_program_add_stream_index_delegate>());

        public void av_program_add_stream_index(AVFormatContext* @ac, int @progid, uint @idx)
        {
            av_program_add_stream_index_ptr(@ac, @progid, @idx);
        }

        private av_read_frame_delegate? _av_read_frame_ptr;

        public av_read_frame_delegate av_read_frame_ptr => _av_read_frame_ptr ?? (_av_read_frame_ptr = NativeMethodDelegate<av_read_frame_delegate>());

        /// <summary>Return the next frame of a stream. This function returns what is stored in the file, and does not validate that what is there are valid frames for the decoder. It will split what is stored in the file into frames and return one for each call. It will not omit invalid data between valid frames so as to give the decoder the maximum information possible for decoding.</summary>
        /// <returns>0 if OK, &lt; 0 on error or end of file. On error, pkt will be blank (as if it came from av_packet_alloc()).</returns>
        public int av_read_frame(AVFormatContext* @s, AVPacket* @pkt)
        {
            return av_read_frame_ptr(@s, @pkt);
        }

        private av_read_pause_delegate? _av_read_pause_ptr;

        public av_read_pause_delegate av_read_pause_ptr => _av_read_pause_ptr ?? (_av_read_pause_ptr = NativeMethodDelegate<av_read_pause_delegate>());

        /// <summary>Pause a network-based stream (e.g. RTSP stream).</summary>
        public int av_read_pause(AVFormatContext* @s)
        {
            return av_read_pause_ptr(@s);
        }

        private av_read_play_delegate? _av_read_play_ptr;

        public av_read_play_delegate av_read_play_ptr => _av_read_play_ptr ?? (_av_read_play_ptr = NativeMethodDelegate<av_read_play_delegate>());

        /// <summary>Start playing a network-based stream (e.g. RTSP stream) at the current position.</summary>
        public int av_read_play(AVFormatContext* @s)
        {
            return av_read_play_ptr(@s);
        }

        private av_sdp_create_delegate? _av_sdp_create_ptr;

        public av_sdp_create_delegate av_sdp_create_ptr => _av_sdp_create_ptr ?? (_av_sdp_create_ptr = NativeMethodDelegate<av_sdp_create_delegate>());

        /// <summary>Generate an SDP for an RTP session.</summary>
        /// <param name="ac">array of AVFormatContexts describing the RTP streams. If the array is composed by only one context, such context can contain multiple AVStreams (one AVStream per RTP stream). Otherwise, all the contexts in the array (an AVCodecContext per RTP stream) must contain only one AVStream.</param>
        /// <param name="n_files">number of AVCodecContexts contained in ac</param>
        /// <param name="buf">buffer where the SDP will be stored (must be allocated by the caller)</param>
        /// <param name="size">the size of the buffer</param>
        /// <returns>0 if OK, AVERROR_xxx on error</returns>
        public int av_sdp_create(AVFormatContext** @ac, int @n_files, byte* @buf, int @size)
        {
            return av_sdp_create_ptr(@ac, @n_files, @buf, @size);
        }

        private av_seek_frame_delegate? _av_seek_frame_ptr;

        public av_seek_frame_delegate av_seek_frame_ptr => _av_seek_frame_ptr ?? (_av_seek_frame_ptr = NativeMethodDelegate<av_seek_frame_delegate>());

        /// <summary>Seek to the keyframe at timestamp. &apos;timestamp&apos; in &apos;stream_index&apos;.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="stream_index">If stream_index is (-1), a default stream is selected, and timestamp is automatically converted from AV_TIME_BASE units to the stream specific time_base.</param>
        /// <param name="timestamp">Timestamp in AVStream.time_base units or, if no stream is specified, in AV_TIME_BASE units.</param>
        /// <param name="flags">flags which select direction and seeking mode</param>
        /// <returns>&gt;= 0 on success</returns>
        public int av_seek_frame(AVFormatContext* @s, int @stream_index, long @timestamp, int @flags)
        {
            return av_seek_frame_ptr(@s, @stream_index, @timestamp, @flags);
        }

        private av_stream_add_side_data_delegate? _av_stream_add_side_data_ptr;

        public av_stream_add_side_data_delegate av_stream_add_side_data_ptr => _av_stream_add_side_data_ptr ?? (_av_stream_add_side_data_ptr = NativeMethodDelegate<av_stream_add_side_data_delegate>());

        /// <summary>Wrap an existing array as stream side data.</summary>
        /// <param name="st">stream</param>
        /// <param name="type">side information type</param>
        /// <param name="data">the side data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to st.</param>
        /// <param name="size">side information size</param>
        /// <returns>zero on success, a negative AVERROR code on failure. On failure, the stream is unchanged and the data remains owned by the caller.</returns>
        public int av_stream_add_side_data(AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size)
        {
            return av_stream_add_side_data_ptr(@st, @type, @data, @size);
        }

        private av_stream_get_class_delegate? _av_stream_get_class_ptr;

        public av_stream_get_class_delegate av_stream_get_class_ptr => _av_stream_get_class_ptr ?? (_av_stream_get_class_ptr = NativeMethodDelegate<av_stream_get_class_delegate>());

        /// <summary>Get the AVClass for AVStream. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public AVClass* av_stream_get_class()
        {
            return av_stream_get_class_ptr();
        }

        private av_stream_get_codec_timebase_delegate? _av_stream_get_codec_timebase_ptr;

        public av_stream_get_codec_timebase_delegate av_stream_get_codec_timebase_ptr => _av_stream_get_codec_timebase_ptr ?? (_av_stream_get_codec_timebase_ptr = NativeMethodDelegate<av_stream_get_codec_timebase_delegate>());

        /// <summary>Get the internal codec timebase from a stream.</summary>
        /// <param name="st">input stream to extract the timebase from</param>
        public AVRational av_stream_get_codec_timebase(AVStream* @st)
        {
            return av_stream_get_codec_timebase_ptr(@st);
        }

        private av_stream_get_end_pts_delegate? _av_stream_get_end_pts_ptr;

        public av_stream_get_end_pts_delegate av_stream_get_end_pts_ptr => _av_stream_get_end_pts_ptr ?? (_av_stream_get_end_pts_ptr = NativeMethodDelegate<av_stream_get_end_pts_delegate>());

        /// <summary>Returns the pts of the last muxed packet + its duration</summary>
        public long av_stream_get_end_pts(AVStream* @st)
        {
            return av_stream_get_end_pts_ptr(@st);
        }

        private av_stream_get_parser_delegate? _av_stream_get_parser_ptr;

        public av_stream_get_parser_delegate av_stream_get_parser_ptr => _av_stream_get_parser_ptr ?? (_av_stream_get_parser_ptr = NativeMethodDelegate<av_stream_get_parser_delegate>());

        public AVCodecParserContext* av_stream_get_parser(AVStream* @s)
        {
            return av_stream_get_parser_ptr(@s);
        }

        private av_stream_get_side_data_delegate? _av_stream_get_side_data_ptr;

        public av_stream_get_side_data_delegate av_stream_get_side_data_ptr => _av_stream_get_side_data_ptr ?? (_av_stream_get_side_data_ptr = NativeMethodDelegate<av_stream_get_side_data_delegate>());

        /// <summary>Get side information from stream.</summary>
        /// <param name="stream">stream</param>
        /// <param name="type">desired side information type</param>
        /// <param name="size">If supplied, *size will be set to the size of the side data or to zero if the desired side data is not present.</param>
        /// <returns>pointer to data if present or NULL otherwise</returns>
        public byte* av_stream_get_side_data(AVStream* @stream, AVPacketSideDataType @type, ulong* @size)
        {
            return av_stream_get_side_data_ptr(@stream, @type, @size);
        }

        private av_stream_new_side_data_delegate? _av_stream_new_side_data_ptr;

        public av_stream_new_side_data_delegate av_stream_new_side_data_ptr => _av_stream_new_side_data_ptr ?? (_av_stream_new_side_data_ptr = NativeMethodDelegate<av_stream_new_side_data_delegate>());

        /// <summary>Allocate new information from stream.</summary>
        /// <param name="stream">stream</param>
        /// <param name="type">desired side information type</param>
        /// <param name="size">side information size</param>
        /// <returns>pointer to fresh allocated data or NULL otherwise</returns>
        public byte* av_stream_new_side_data(AVStream* @stream, AVPacketSideDataType @type, ulong @size)
        {
            return av_stream_new_side_data_ptr(@stream, @type, @size);
        }

        private av_url_split_delegate? _av_url_split_ptr;

        public av_url_split_delegate av_url_split_ptr => _av_url_split_ptr ?? (_av_url_split_ptr = NativeMethodDelegate<av_url_split_delegate>());

        /// <summary>Split a URL string into components.</summary>
        /// <param name="proto">the buffer for the protocol</param>
        /// <param name="proto_size">the size of the proto buffer</param>
        /// <param name="authorization">the buffer for the authorization</param>
        /// <param name="authorization_size">the size of the authorization buffer</param>
        /// <param name="hostname">the buffer for the host name</param>
        /// <param name="hostname_size">the size of the hostname buffer</param>
        /// <param name="port_ptr">a pointer to store the port number in</param>
        /// <param name="path">the buffer for the path</param>
        /// <param name="path_size">the size of the path buffer</param>
        /// <param name="url">the URL to split</param>
        public void av_url_split(byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url)
        {
            av_url_split_ptr(@proto, @proto_size, @authorization, @authorization_size, @hostname, @hostname_size, @port_ptr, @path, @path_size, @url);
        }

        private av_write_frame_delegate? _av_write_frame_ptr;

        public av_write_frame_delegate av_write_frame_ptr => _av_write_frame_ptr ?? (_av_write_frame_ptr = NativeMethodDelegate<av_write_frame_delegate>());

        /// <summary>Write a packet to an output media file.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="pkt">The packet containing the data to be written. Note that unlike av_interleaved_write_frame(), this function does not take ownership of the packet passed to it (though some muxers may make an internal reference to the input packet).  This parameter can be NULL (at any time, not just at the end), in order to immediately flush data buffered within the muxer, for muxers that buffer up data internally before writing it to the output.  Packet&apos;s &quot;stream_index&quot; field must be set to the index of the corresponding stream in &quot;s-&gt;streams&quot;.  The timestamps ( &quot;pts&quot;, &quot;dts&quot;) must be set to correct values in the stream&apos;s timebase (unless the output format is flagged with the AVFMT_NOTIMESTAMPS flag, then they can be set to AV_NOPTS_VALUE). The dts for subsequent packets passed to this function must be strictly increasing when compared in their respective timebases (unless the output format is flagged with the AVFMT_TS_NONSTRICT, then they merely have to be nondecreasing). &quot;duration&quot;) should also be set if known.</param>
        /// <returns>&lt; 0 on error, = 0 if OK, 1 if flushed and there is no more data to flush</returns>
        public int av_write_frame(AVFormatContext* @s, AVPacket* @pkt)
        {
            return av_write_frame_ptr(@s, @pkt);
        }

        private av_write_trailer_delegate? _av_write_trailer_ptr;

        public av_write_trailer_delegate av_write_trailer_ptr => _av_write_trailer_ptr ?? (_av_write_trailer_ptr = NativeMethodDelegate<av_write_trailer_delegate>());

        /// <summary>Write the stream trailer to an output media file and free the file private data.</summary>
        /// <param name="s">media file handle</param>
        /// <returns>0 if OK, AVERROR_xxx on error</returns>
        public int av_write_trailer(AVFormatContext* @s)
        {
            return av_write_trailer_ptr(@s);
        }

        private av_write_uncoded_frame_delegate? _av_write_uncoded_frame_ptr;

        public av_write_uncoded_frame_delegate av_write_uncoded_frame_ptr => _av_write_uncoded_frame_ptr ?? (_av_write_uncoded_frame_ptr = NativeMethodDelegate<av_write_uncoded_frame_delegate>());

        /// <summary>Write an uncoded frame to an output media file.</summary>
        public int av_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame)
        {
            return av_write_uncoded_frame_ptr(@s, @stream_index, @frame);
        }

        private av_write_uncoded_frame_query_delegate? _av_write_uncoded_frame_query_ptr;

        public av_write_uncoded_frame_query_delegate av_write_uncoded_frame_query_ptr => _av_write_uncoded_frame_query_ptr ?? (_av_write_uncoded_frame_query_ptr = NativeMethodDelegate<av_write_uncoded_frame_query_delegate>());

        /// <summary>Test whether a muxer supports uncoded frame.</summary>
        /// <returns>&gt;=0 if an uncoded frame can be written to that muxer and stream,  &lt; 0 if not</returns>
        public int av_write_uncoded_frame_query(AVFormatContext* @s, int @stream_index)
        {
            return av_write_uncoded_frame_query_ptr(@s, @stream_index);
        }

        private avformat_alloc_context_delegate? _avformat_alloc_context_ptr;

        public avformat_alloc_context_delegate avformat_alloc_context_ptr => _avformat_alloc_context_ptr ?? (_avformat_alloc_context_ptr = NativeMethodDelegate<avformat_alloc_context_delegate>());

        /// <summary>Allocate an AVFormatContext. avformat_free_context() can be used to free the context and everything allocated by the framework within it.</summary>
        public AVFormatContext* avformat_alloc_context()
        {
            return avformat_alloc_context_ptr();
        }

        private avformat_alloc_output_context2_delegate? _avformat_alloc_output_context2_ptr;

        public avformat_alloc_output_context2_delegate avformat_alloc_output_context2_ptr => _avformat_alloc_output_context2_ptr ?? (_avformat_alloc_output_context2_ptr = NativeMethodDelegate<avformat_alloc_output_context2_delegate>());

        /// <summary>Allocate an AVFormatContext for an output format. avformat_free_context() can be used to free the context and everything allocated by the framework within it.</summary>
        /// <param name="oformat">format to use for allocating the context, if NULL format_name and filename are used instead</param>
        /// <param name="format_name">the name of output format to use for allocating the context, if NULL filename is used instead</param>
        /// <param name="filename">the name of the filename to use for allocating the context, may be NULL</param>
        /// <returns>&gt;= 0 in case of success, a negative AVERROR code in case of failure</returns>
        public int avformat_alloc_output_context2(AVFormatContext** @ctx, AVOutputFormat* @oformat,
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
    string @filename)
        {
            return avformat_alloc_output_context2_ptr(@ctx, @oformat, @format_name, @filename);
        }

        private avformat_close_input_delegate? _avformat_close_input_ptr;

        public avformat_close_input_delegate avformat_close_input_ptr => _avformat_close_input_ptr ?? (_avformat_close_input_ptr = NativeMethodDelegate<avformat_close_input_delegate>());

        /// <summary>Close an opened input AVFormatContext. Free it and all its contents and set *s to NULL.</summary>
        public void avformat_close_input(AVFormatContext** @s)
        {
            avformat_close_input_ptr(@s);
        }

        private avformat_configuration_delegate? _avformat_configuration_ptr;

        public avformat_configuration_delegate avformat_configuration_ptr => _avformat_configuration_ptr ?? (_avformat_configuration_ptr = NativeMethodDelegate<avformat_configuration_delegate>());

        /// <summary>Return the libavformat build-time configuration.</summary>
        public string avformat_configuration()
        {
            return avformat_configuration_ptr();
        }

        private avformat_find_stream_info_delegate? _avformat_find_stream_info_ptr;

        public avformat_find_stream_info_delegate avformat_find_stream_info_ptr => _avformat_find_stream_info_ptr ?? (_avformat_find_stream_info_ptr = NativeMethodDelegate<avformat_find_stream_info_delegate>());

        /// <summary>Read packets of a media file to get stream information. This is useful for file formats with no headers such as MPEG. This function also computes the real framerate in case of MPEG-2 repeat frame mode. The logical file position is not changed by this function; examined packets may be buffered for later processing.</summary>
        /// <param name="ic">media file handle</param>
        /// <param name="options">If non-NULL, an ic.nb_streams long array of pointers to dictionaries, where i-th member contains options for codec corresponding to i-th stream. On return each dictionary will be filled with options that were not found.</param>
        /// <returns>&gt;=0 if OK, AVERROR_xxx on error</returns>
        public int avformat_find_stream_info(AVFormatContext* @ic, AVDictionary** @options)
        {
            return avformat_find_stream_info_ptr(@ic, @options);
        }

        private avformat_flush_delegate? _avformat_flush_ptr;

        public avformat_flush_delegate avformat_flush_ptr => _avformat_flush_ptr ?? (_avformat_flush_ptr = NativeMethodDelegate<avformat_flush_delegate>());

        /// <summary>Discard all internally buffered data. This can be useful when dealing with discontinuities in the byte stream. Generally works only with formats that can resync. This includes headerless formats like MPEG-TS/TS but should also work with NUT, Ogg and in a limited way AVI for example.</summary>
        /// <param name="s">media file handle</param>
        /// <returns>&gt;=0 on success, error code otherwise</returns>
        public int avformat_flush(AVFormatContext* @s)
        {
            return avformat_flush_ptr(@s);
        }

        private avformat_free_context_delegate? _avformat_free_context_ptr;

        public avformat_free_context_delegate avformat_free_context_ptr => _avformat_free_context_ptr ?? (_avformat_free_context_ptr = NativeMethodDelegate<avformat_free_context_delegate>());

        /// <summary>Free an AVFormatContext and all its streams.</summary>
        /// <param name="s">context to free</param>
        public void avformat_free_context(AVFormatContext* @s)
        {
            avformat_free_context_ptr(@s);
        }

        private avformat_get_class_delegate? _avformat_get_class_ptr;

        public avformat_get_class_delegate avformat_get_class_ptr => _avformat_get_class_ptr ?? (_avformat_get_class_ptr = NativeMethodDelegate<avformat_get_class_delegate>());

        /// <summary>Get the AVClass for AVFormatContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public AVClass* avformat_get_class()
        {
            return avformat_get_class_ptr();
        }

        private avformat_get_mov_audio_tags_delegate? _avformat_get_mov_audio_tags_ptr;

        public avformat_get_mov_audio_tags_delegate avformat_get_mov_audio_tags_ptr => _avformat_get_mov_audio_tags_ptr ?? (_avformat_get_mov_audio_tags_ptr = NativeMethodDelegate<avformat_get_mov_audio_tags_delegate>());

        /// <summary>Returns the table mapping MOV FourCCs for audio to AVCodecID.</summary>
        /// <returns>the table mapping MOV FourCCs for audio to AVCodecID.</returns>
        public AVCodecTag* avformat_get_mov_audio_tags()
        {
            return avformat_get_mov_audio_tags_ptr();
        }

        private avformat_get_mov_video_tags_delegate? _avformat_get_mov_video_tags_ptr;

        public avformat_get_mov_video_tags_delegate avformat_get_mov_video_tags_ptr => _avformat_get_mov_video_tags_ptr ?? (_avformat_get_mov_video_tags_ptr = NativeMethodDelegate<avformat_get_mov_video_tags_delegate>());

        /// <summary>Returns the table mapping MOV FourCCs for video to libavcodec AVCodecID.</summary>
        /// <returns>the table mapping MOV FourCCs for video to libavcodec AVCodecID.</returns>
        public AVCodecTag* avformat_get_mov_video_tags()
        {
            return avformat_get_mov_video_tags_ptr();
        }

        private avformat_get_riff_audio_tags_delegate? _avformat_get_riff_audio_tags_ptr;

        public avformat_get_riff_audio_tags_delegate avformat_get_riff_audio_tags_ptr => _avformat_get_riff_audio_tags_ptr ?? (_avformat_get_riff_audio_tags_ptr = NativeMethodDelegate<avformat_get_riff_audio_tags_delegate>());

        /// <summary>Returns the table mapping RIFF FourCCs for audio to AVCodecID.</summary>
        /// <returns>the table mapping RIFF FourCCs for audio to AVCodecID.</returns>
        public AVCodecTag* avformat_get_riff_audio_tags()
        {
            return avformat_get_riff_audio_tags_ptr();
        }

        private avformat_get_riff_video_tags_delegate? _avformat_get_riff_video_tags_ptr;

        public avformat_get_riff_video_tags_delegate avformat_get_riff_video_tags_ptr => _avformat_get_riff_video_tags_ptr ?? (_avformat_get_riff_video_tags_ptr = NativeMethodDelegate<avformat_get_riff_video_tags_delegate>());

        /// <summary>@{ Get the tables mapping RIFF FourCCs to libavcodec AVCodecIDs. The tables are meant to be passed to av_codec_get_id()/av_codec_get_tag() as in the following code:</summary>
        /// <returns>the table mapping RIFF FourCCs for video to libavcodec AVCodecID.</returns>
        public AVCodecTag* avformat_get_riff_video_tags()
        {
            return avformat_get_riff_video_tags_ptr();
        }

        private avformat_index_get_entries_count_delegate? _avformat_index_get_entries_count_ptr;

        public avformat_index_get_entries_count_delegate avformat_index_get_entries_count_ptr => _avformat_index_get_entries_count_ptr ?? (_avformat_index_get_entries_count_ptr = NativeMethodDelegate<avformat_index_get_entries_count_delegate>());

        /// <summary>Get the index entry count for the given AVStream.</summary>
        /// <param name="st">stream</param>
        /// <returns>the number of index entries in the stream</returns>
        public int avformat_index_get_entries_count(AVStream* @st)
        {
            return avformat_index_get_entries_count_ptr(@st);
        }

        private avformat_index_get_entry_delegate? _avformat_index_get_entry_ptr;

        public avformat_index_get_entry_delegate avformat_index_get_entry_ptr => _avformat_index_get_entry_ptr ?? (_avformat_index_get_entry_ptr = NativeMethodDelegate<avformat_index_get_entry_delegate>());

        /// <summary>Get the AVIndexEntry corresponding to the given index.</summary>
        /// <param name="st">Stream containing the requested AVIndexEntry.</param>
        /// <param name="idx">The desired index.</param>
        /// <returns>A pointer to the requested AVIndexEntry if it exists, NULL otherwise.</returns>
        public AVIndexEntry* avformat_index_get_entry(AVStream* @st, int @idx)
        {
            return avformat_index_get_entry_ptr(@st, @idx);
        }

        private avformat_index_get_entry_from_timestamp_delegate? _avformat_index_get_entry_from_timestamp_ptr;

        public avformat_index_get_entry_from_timestamp_delegate avformat_index_get_entry_from_timestamp_ptr => _avformat_index_get_entry_from_timestamp_ptr ?? (_avformat_index_get_entry_from_timestamp_ptr = NativeMethodDelegate<avformat_index_get_entry_from_timestamp_delegate>());

        /// <summary>Get the AVIndexEntry corresponding to the given timestamp.</summary>
        /// <param name="st">Stream containing the requested AVIndexEntry.</param>
        /// <param name="flags">If AVSEEK_FLAG_BACKWARD then the returned entry will correspond to the timestamp which is &lt; = the requested one, if backward is 0, then it will be &gt;= if AVSEEK_FLAG_ANY seek to any frame, only keyframes otherwise.</param>
        /// <returns>A pointer to the requested AVIndexEntry if it exists, NULL otherwise.</returns>
        public AVIndexEntry* avformat_index_get_entry_from_timestamp(AVStream* @st, long @wanted_timestamp, int @flags)
        {
            return avformat_index_get_entry_from_timestamp_ptr(@st, @wanted_timestamp, @flags);
        }

        private avformat_init_output_delegate? _avformat_init_output_ptr;

        public avformat_init_output_delegate avformat_init_output_ptr => _avformat_init_output_ptr ?? (_avformat_init_output_ptr = NativeMethodDelegate<avformat_init_output_delegate>());

        /// <summary>Allocate the stream private data and initialize the codec, but do not write the header. May optionally be used before avformat_write_header to initialize stream parameters before actually writing the header. If using this function, do not pass the same options to avformat_write_header.</summary>
        /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its oformat field must be set to the desired output format; Its pb field must be set to an already opened AVIOContext.</param>
        /// <param name="options">An AVDictionary filled with AVFormatContext and muxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        /// <returns>AVSTREAM_INIT_IN_WRITE_HEADER on success if the codec requires avformat_write_header to fully initialize, AVSTREAM_INIT_IN_INIT_OUTPUT  on success if the codec has been fully initialized, negative AVERROR on failure.</returns>
        public int avformat_init_output(AVFormatContext* @s, AVDictionary** @options)
        {
            return avformat_init_output_ptr(@s, @options);
        }

        private avformat_license_delegate? _avformat_license_ptr;

        public avformat_license_delegate avformat_license_ptr => _avformat_license_ptr ?? (_avformat_license_ptr = NativeMethodDelegate<avformat_license_delegate>());

        /// <summary>Return the libavformat license.</summary>
        public string avformat_license()
        {
            return avformat_license_ptr();
        }

        private avformat_match_stream_specifier_delegate? _avformat_match_stream_specifier_ptr;

        public avformat_match_stream_specifier_delegate avformat_match_stream_specifier_ptr => _avformat_match_stream_specifier_ptr ?? (_avformat_match_stream_specifier_ptr = NativeMethodDelegate<avformat_match_stream_specifier_delegate>());

        /// <summary>Check if the stream st contained in s is matched by the stream specifier spec.</summary>
        /// <returns>&gt;0 if st is matched by spec; 0  if st is not matched by spec; AVERROR code if spec is invalid</returns>
        public int avformat_match_stream_specifier(AVFormatContext* @s, AVStream* @st,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @spec)
        {
            return avformat_match_stream_specifier_ptr(@s, @st, @spec);
        }

        private avformat_network_deinit_delegate? _avformat_network_deinit_ptr;

        public avformat_network_deinit_delegate avformat_network_deinit_ptr => _avformat_network_deinit_ptr ?? (_avformat_network_deinit_ptr = NativeMethodDelegate<avformat_network_deinit_delegate>());

        /// <summary>Undo the initialization done by avformat_network_init. Call it only once for each time you called avformat_network_init.</summary>
        public int avformat_network_deinit()
        {
            return avformat_network_deinit_ptr();
        }

        private avformat_network_init_delegate? _avformat_network_init_ptr;

        public avformat_network_init_delegate avformat_network_init_ptr => _avformat_network_init_ptr ?? (_avformat_network_init_ptr = NativeMethodDelegate<avformat_network_init_delegate>());

        /// <summary>Do global initialization of network libraries. This is optional, and not recommended anymore.</summary>
        public int avformat_network_init()
        {
            return avformat_network_init_ptr();
        }

        private avformat_new_stream_delegate? _avformat_new_stream_ptr;

        public avformat_new_stream_delegate avformat_new_stream_ptr => _avformat_new_stream_ptr ?? (_avformat_new_stream_ptr = NativeMethodDelegate<avformat_new_stream_delegate>());

        /// <summary>Add a new stream to a media file.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="c">unused, does nothing</param>
        /// <returns>newly created stream or NULL on error.</returns>
        public AVStream* avformat_new_stream(AVFormatContext* @s, AVCodec* @c)
        {
            return avformat_new_stream_ptr(@s, @c);
        }

        private avformat_open_input_delegate? _avformat_open_input_ptr;

        public avformat_open_input_delegate avformat_open_input_ptr => _avformat_open_input_ptr ?? (_avformat_open_input_ptr = NativeMethodDelegate<avformat_open_input_delegate>());

        /// <summary>Open an input stream and read the header. The codecs are not opened. The stream must be closed with avformat_close_input().</summary>
        /// <param name="ps">Pointer to user-supplied AVFormatContext (allocated by avformat_alloc_context). May be a pointer to NULL, in which case an AVFormatContext is allocated by this function and written into ps. Note that a user-supplied AVFormatContext will be freed on failure.</param>
        /// <param name="url">URL of the stream to open.</param>
        /// <param name="fmt">If non-NULL, this parameter forces a specific input format. Otherwise the format is autodetected.</param>
        /// <param name="options">A dictionary filled with AVFormatContext and demuxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        /// <returns>0 on success, a negative AVERROR on failure.</returns>
        public int avformat_open_input(AVFormatContext** @ps,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, AVInputFormat* @fmt, AVDictionary** @options)
        {
            return avformat_open_input_ptr(@ps, @url, @fmt, @options);
        }

        private avformat_query_codec_delegate? _avformat_query_codec_ptr;

        public avformat_query_codec_delegate avformat_query_codec_ptr => _avformat_query_codec_ptr ?? (_avformat_query_codec_ptr = NativeMethodDelegate<avformat_query_codec_delegate>());

        /// <summary>Test if the given container can store a codec.</summary>
        /// <param name="ofmt">container to check for compatibility</param>
        /// <param name="codec_id">codec to potentially store in container</param>
        /// <param name="std_compliance">standards compliance level, one of FF_COMPLIANCE_*</param>
        /// <returns>1 if codec with ID codec_id can be stored in ofmt, 0 if it cannot. A negative number if this information is not available.</returns>
        public int avformat_query_codec(AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance)
        {
            return avformat_query_codec_ptr(@ofmt, @codec_id, @std_compliance);
        }

        private avformat_queue_attached_pictures_delegate? _avformat_queue_attached_pictures_ptr;

        public avformat_queue_attached_pictures_delegate avformat_queue_attached_pictures_ptr => _avformat_queue_attached_pictures_ptr ?? (_avformat_queue_attached_pictures_ptr = NativeMethodDelegate<avformat_queue_attached_pictures_delegate>());

        public int avformat_queue_attached_pictures(AVFormatContext* @s)
        {
            return avformat_queue_attached_pictures_ptr(@s);
        }

        private avformat_seek_file_delegate? _avformat_seek_file_ptr;

        public avformat_seek_file_delegate avformat_seek_file_ptr => _avformat_seek_file_ptr ?? (_avformat_seek_file_ptr = NativeMethodDelegate<avformat_seek_file_delegate>());

        /// <summary>Seek to timestamp ts. Seeking will be done so that the point from which all active streams can be presented successfully will be closest to ts and within min/max_ts. Active streams are all streams that have AVStream.discard &lt; AVDISCARD_ALL.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="stream_index">index of the stream which is used as time base reference</param>
        /// <param name="min_ts">smallest acceptable timestamp</param>
        /// <param name="ts">target timestamp</param>
        /// <param name="max_ts">largest acceptable timestamp</param>
        /// <param name="flags">flags</param>
        /// <returns>&gt;=0 on success, error code otherwise</returns>
        public int avformat_seek_file(AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags)
        {
            return avformat_seek_file_ptr(@s, @stream_index, @min_ts, @ts, @max_ts, @flags);
        }

        private avformat_transfer_internal_stream_timing_info_delegate? _avformat_transfer_internal_stream_timing_info_ptr;

        public avformat_transfer_internal_stream_timing_info_delegate avformat_transfer_internal_stream_timing_info_ptr => _avformat_transfer_internal_stream_timing_info_ptr ?? (_avformat_transfer_internal_stream_timing_info_ptr = NativeMethodDelegate<avformat_transfer_internal_stream_timing_info_delegate>());

        /// <summary>Transfer internal timing information from one stream to another.</summary>
        /// <param name="ofmt">target output format for ost</param>
        /// <param name="ost">output stream which needs timings copy and adjustments</param>
        /// <param name="ist">reference input stream to copy timings from</param>
        /// <param name="copy_tb">define from where the stream codec timebase needs to be imported</param>
        public int avformat_transfer_internal_stream_timing_info(AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb)
        {
            return avformat_transfer_internal_stream_timing_info_ptr(@ofmt, @ost, @ist, @copy_tb);
        }

        private avformat_version_delegate? _avformat_version_ptr;

        public avformat_version_delegate avformat_version_ptr => _avformat_version_ptr ?? (_avformat_version_ptr = NativeMethodDelegate<avformat_version_delegate>());

        /// <summary>Return the LIBAVFORMAT_VERSION_INT constant.</summary>
        public uint avformat_version()
        {
            return avformat_version_ptr();
        }

        private avformat_write_header_delegate? _avformat_write_header_ptr;

        public avformat_write_header_delegate avformat_write_header_ptr => _avformat_write_header_ptr ?? (_avformat_write_header_ptr = NativeMethodDelegate<avformat_write_header_delegate>());

        /// <summary>Allocate the stream private data and write the stream header to an output media file.</summary>
        /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its oformat field must be set to the desired output format; Its pb field must be set to an already opened AVIOContext.</param>
        /// <param name="options">An AVDictionary filled with AVFormatContext and muxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        /// <returns>AVSTREAM_INIT_IN_WRITE_HEADER on success if the codec had not already been fully initialized in avformat_init, AVSTREAM_INIT_IN_INIT_OUTPUT  on success if the codec had already been fully initialized in avformat_init, negative AVERROR on failure.</returns>
        public int avformat_write_header(AVFormatContext* @s, AVDictionary** @options)
        {
            return avformat_write_header_ptr(@s, @options);
        }

        private avio_accept_delegate? _avio_accept_ptr;

        public avio_accept_delegate avio_accept_ptr => _avio_accept_ptr ?? (_avio_accept_ptr = NativeMethodDelegate<avio_accept_delegate>());

        /// <summary>Accept and allocate a client context on a server context.</summary>
        /// <param name="s">the server context</param>
        /// <param name="c">the client context, must be unallocated</param>
        /// <returns>&gt;= 0 on success or a negative value corresponding to an AVERROR on failure</returns>
        public int avio_accept(AVIOContext* @s, AVIOContext** @c)
        {
            return avio_accept_ptr(@s, @c);
        }

        private avio_alloc_context_delegate? _avio_alloc_context_ptr;

        public avio_alloc_context_delegate avio_alloc_context_ptr => _avio_alloc_context_ptr ?? (_avio_alloc_context_ptr = NativeMethodDelegate<avio_alloc_context_delegate>());

        /// <summary>Allocate and initialize an AVIOContext for buffered I/O. It must be later freed with avio_context_free().</summary>
        /// <param name="buffer">Memory block for input/output operations via AVIOContext. The buffer must be allocated with av_malloc() and friends. It may be freed and replaced with a new buffer by libavformat. AVIOContext.buffer holds the buffer currently in use, which must be later freed with av_free().</param>
        /// <param name="buffer_size">The buffer size is very important for performance. For protocols with fixed blocksize it should be set to this blocksize. For others a typical size is a cache page, e.g. 4kb.</param>
        /// <param name="write_flag">Set to 1 if the buffer should be writable, 0 otherwise.</param>
        /// <param name="opaque">An opaque pointer to user-specific data.</param>
        /// <param name="read_packet">A function for refilling the buffer, may be NULL. For stream protocols, must never return 0 but rather a proper AVERROR code.</param>
        /// <param name="write_packet">A function for writing the buffer contents, may be NULL. The function may not change the input buffers content.</param>
        /// <param name="seek">A function for seeking to specified byte position, may be NULL.</param>
        /// <returns>Allocated AVIOContext or NULL on failure.</returns>
        public AVIOContext* avio_alloc_context(byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek)
        {
            return avio_alloc_context_ptr(@buffer, @buffer_size, @write_flag, @opaque, @read_packet, @write_packet, @seek);
        }

        private avio_check_delegate? _avio_check_ptr;

        public avio_check_delegate avio_check_ptr => _avio_check_ptr ?? (_avio_check_ptr = NativeMethodDelegate<avio_check_delegate>());

        /// <summary>Return AVIO_FLAG_* access flags corresponding to the access permissions of the resource in url, or a negative value corresponding to an AVERROR code in case of failure. The returned access flags are masked by the value in flags.</summary>
        public int avio_check(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @flags)
        {
            return avio_check_ptr(@url, @flags);
        }

        private avio_close_delegate? _avio_close_ptr;

        public avio_close_delegate avio_close_ptr => _avio_close_ptr ?? (_avio_close_ptr = NativeMethodDelegate<avio_close_delegate>());

        /// <summary>Close the resource accessed by the AVIOContext s and free it. This function can only be used if s was opened by avio_open().</summary>
        /// <returns>0 on success, an AVERROR &lt; 0 on error.</returns>
        public int avio_close(AVIOContext* @s)
        {
            return avio_close_ptr(@s);
        }

        private avio_close_dir_delegate? _avio_close_dir_ptr;

        public avio_close_dir_delegate avio_close_dir_ptr => _avio_close_dir_ptr ?? (_avio_close_dir_ptr = NativeMethodDelegate<avio_close_dir_delegate>());

        /// <summary>Close directory.</summary>
        /// <param name="s">directory read context.</param>
        /// <returns>&gt;=0 on success or negative on error.</returns>
        public int avio_close_dir(AVIODirContext** @s)
        {
            return avio_close_dir_ptr(@s);
        }

        private avio_close_dyn_buf_delegate? _avio_close_dyn_buf_ptr;

        public avio_close_dyn_buf_delegate avio_close_dyn_buf_ptr => _avio_close_dyn_buf_ptr ?? (_avio_close_dyn_buf_ptr = NativeMethodDelegate<avio_close_dyn_buf_delegate>());

        /// <summary>Return the written size and a pointer to the buffer. The buffer must be freed with av_free(). Padding of AV_INPUT_BUFFER_PADDING_SIZE is added to the buffer.</summary>
        /// <param name="s">IO context</param>
        /// <param name="pbuffer">pointer to a byte buffer</param>
        /// <returns>the length of the byte buffer</returns>
        public int avio_close_dyn_buf(AVIOContext* @s, byte** @pbuffer)
        {
            return avio_close_dyn_buf_ptr(@s, @pbuffer);
        }

        private avio_closep_delegate? _avio_closep_ptr;

        public avio_closep_delegate avio_closep_ptr => _avio_closep_ptr ?? (_avio_closep_ptr = NativeMethodDelegate<avio_closep_delegate>());

        /// <summary>Close the resource accessed by the AVIOContext *s, free it and set the pointer pointing to it to NULL. This function can only be used if s was opened by avio_open().</summary>
        /// <returns>0 on success, an AVERROR &lt; 0 on error.</returns>
        public int avio_closep(AVIOContext** @s)
        {
            return avio_closep_ptr(@s);
        }

        private avio_context_free_delegate? _avio_context_free_ptr;

        public avio_context_free_delegate avio_context_free_ptr => _avio_context_free_ptr ?? (_avio_context_free_ptr = NativeMethodDelegate<avio_context_free_delegate>());

        /// <summary>Free the supplied IO context and everything associated with it.</summary>
        /// <param name="s">Double pointer to the IO context. This function will write NULL into s.</param>
        public void avio_context_free(AVIOContext** @s)
        {
            avio_context_free_ptr(@s);
        }

        private avio_enum_protocols_delegate? _avio_enum_protocols_ptr;

        public avio_enum_protocols_delegate avio_enum_protocols_ptr => _avio_enum_protocols_ptr ?? (_avio_enum_protocols_ptr = NativeMethodDelegate<avio_enum_protocols_delegate>());

        /// <summary>Iterate through names of available protocols.</summary>
        /// <param name="opaque">A private pointer representing current protocol. It must be a pointer to NULL on first iteration and will be updated by successive calls to avio_enum_protocols.</param>
        /// <param name="output">If set to 1, iterate over output protocols, otherwise over input protocols.</param>
        /// <returns>A string containing the name of current protocol or NULL</returns>
        public string avio_enum_protocols(void** @opaque, int @output)
        {
            return avio_enum_protocols_ptr(@opaque, @output);
        }

        private avio_feof_delegate? _avio_feof_ptr;

        public avio_feof_delegate avio_feof_ptr => _avio_feof_ptr ?? (_avio_feof_ptr = NativeMethodDelegate<avio_feof_delegate>());

        /// <summary>Similar to feof() but also returns nonzero on read errors.</summary>
        /// <returns>non zero if and only if at end of file or a read error happened when reading.</returns>
        public int avio_feof(AVIOContext* @s)
        {
            return avio_feof_ptr(@s);
        }

        private avio_find_protocol_name_delegate? _avio_find_protocol_name_ptr;

        public avio_find_protocol_name_delegate avio_find_protocol_name_ptr => _avio_find_protocol_name_ptr ?? (_avio_find_protocol_name_ptr = NativeMethodDelegate<avio_find_protocol_name_delegate>());

        /// <summary>Return the name of the protocol that will handle the passed URL.</summary>
        /// <returns>Name of the protocol or NULL.</returns>
        public string avio_find_protocol_name(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url)
        {
            return avio_find_protocol_name_ptr(@url);
        }

        private avio_flush_delegate? _avio_flush_ptr;

        public avio_flush_delegate avio_flush_ptr => _avio_flush_ptr ?? (_avio_flush_ptr = NativeMethodDelegate<avio_flush_delegate>());

        /// <summary>Force flushing of buffered data.</summary>
        public void avio_flush(AVIOContext* @s)
        {
            avio_flush_ptr(@s);
        }

        private avio_free_directory_entry_delegate? _avio_free_directory_entry_ptr;

        public avio_free_directory_entry_delegate avio_free_directory_entry_ptr => _avio_free_directory_entry_ptr ?? (_avio_free_directory_entry_ptr = NativeMethodDelegate<avio_free_directory_entry_delegate>());

        /// <summary>Free entry allocated by avio_read_dir().</summary>
        /// <param name="entry">entry to be freed.</param>
        public void avio_free_directory_entry(AVIODirEntry** @entry)
        {
            avio_free_directory_entry_ptr(@entry);
        }

        private avio_get_dyn_buf_delegate? _avio_get_dyn_buf_ptr;

        public avio_get_dyn_buf_delegate avio_get_dyn_buf_ptr => _avio_get_dyn_buf_ptr ?? (_avio_get_dyn_buf_ptr = NativeMethodDelegate<avio_get_dyn_buf_delegate>());

        /// <summary>Return the written size and a pointer to the buffer. The AVIOContext stream is left intact. The buffer must NOT be freed. No padding is added to the buffer.</summary>
        /// <param name="s">IO context</param>
        /// <param name="pbuffer">pointer to a byte buffer</param>
        /// <returns>the length of the byte buffer</returns>
        public int avio_get_dyn_buf(AVIOContext* @s, byte** @pbuffer)
        {
            return avio_get_dyn_buf_ptr(@s, @pbuffer);
        }

        private avio_get_str_delegate? _avio_get_str_ptr;

        public avio_get_str_delegate avio_get_str_ptr => _avio_get_str_ptr ?? (_avio_get_str_ptr = NativeMethodDelegate<avio_get_str_delegate>());

        /// <summary>Read a string from pb into buf. The reading will terminate when either a NULL character was encountered, maxlen bytes have been read, or nothing more can be read from pb. The result is guaranteed to be NULL-terminated, it will be truncated if buf is too small. Note that the string is not interpreted or validated in any way, it might get truncated in the middle of a sequence for multi-byte encodings.</summary>
        /// <returns>number of bytes read (is always &lt; = maxlen). If reading ends on EOF or error, the return value will be one more than bytes actually read.</returns>
        public int avio_get_str(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen)
        {
            return avio_get_str_ptr(@pb, @maxlen, @buf, @buflen);
        }

        private avio_get_str16be_delegate? _avio_get_str16be_ptr;

        public avio_get_str16be_delegate avio_get_str16be_ptr => _avio_get_str16be_ptr ?? (_avio_get_str16be_ptr = NativeMethodDelegate<avio_get_str16be_delegate>());

        public int avio_get_str16be(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen)
        {
            return avio_get_str16be_ptr(@pb, @maxlen, @buf, @buflen);
        }

        private avio_get_str16le_delegate? _avio_get_str16le_ptr;

        public avio_get_str16le_delegate avio_get_str16le_ptr => _avio_get_str16le_ptr ?? (_avio_get_str16le_ptr = NativeMethodDelegate<avio_get_str16le_delegate>());

        /// <summary>Read a UTF-16 string from pb and convert it to UTF-8. The reading will terminate when either a null or invalid character was encountered or maxlen bytes have been read.</summary>
        /// <returns>number of bytes read (is always &lt; = maxlen)</returns>
        public int avio_get_str16le(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen)
        {
            return avio_get_str16le_ptr(@pb, @maxlen, @buf, @buflen);
        }

        private avio_handshake_delegate? _avio_handshake_ptr;

        public avio_handshake_delegate avio_handshake_ptr => _avio_handshake_ptr ?? (_avio_handshake_ptr = NativeMethodDelegate<avio_handshake_delegate>());

        /// <summary>Perform one step of the protocol handshake to accept a new client. This function must be called on a client returned by avio_accept() before using it as a read/write context. It is separate from avio_accept() because it may block. A step of the handshake is defined by places where the application may decide to change the proceedings. For example, on a protocol with a request header and a reply header, each one can constitute a step because the application may use the parameters from the request to change parameters in the reply; or each individual chunk of the request can constitute a step. If the handshake is already finished, avio_handshake() does nothing and returns 0 immediately.</summary>
        /// <param name="c">the client context to perform the handshake on</param>
        /// <returns>0   on a complete and successful handshake &gt; 0 if the handshake progressed, but is not complete  &lt; 0 for an AVERROR code</returns>
        public int avio_handshake(AVIOContext* @c)
        {
            return avio_handshake_ptr(@c);
        }

        private avio_open_delegate? _avio_open_ptr;

        public avio_open_delegate avio_open_ptr => _avio_open_ptr ?? (_avio_open_ptr = NativeMethodDelegate<avio_open_delegate>());

        /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
        /// <param name="s">Used to return the pointer to the created AVIOContext. In case of failure the pointed to value is set to NULL.</param>
        /// <param name="url">resource to access</param>
        /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
        /// <returns>&gt;= 0 in case of success, a negative value corresponding to an AVERROR code in case of failure</returns>
        public int avio_open(AVIOContext** @s,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @flags)
        {
            return avio_open_ptr(@s, @url, @flags);
        }

        private avio_open_dir_delegate? _avio_open_dir_ptr;

        public avio_open_dir_delegate avio_open_dir_ptr => _avio_open_dir_ptr ?? (_avio_open_dir_ptr = NativeMethodDelegate<avio_open_dir_delegate>());

        /// <summary>Open directory for reading.</summary>
        /// <param name="s">directory read context. Pointer to a NULL pointer must be passed.</param>
        /// <param name="url">directory to be listed.</param>
        /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dictionary containing options that were not found. May be NULL.</param>
        /// <returns>&gt;=0 on success or negative on error.</returns>
        public int avio_open_dir(AVIODirContext** @s,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, AVDictionary** @options)
        {
            return avio_open_dir_ptr(@s, @url, @options);
        }

        private avio_open_dyn_buf_delegate? _avio_open_dyn_buf_ptr;

        public avio_open_dyn_buf_delegate avio_open_dyn_buf_ptr => _avio_open_dyn_buf_ptr ?? (_avio_open_dyn_buf_ptr = NativeMethodDelegate<avio_open_dyn_buf_delegate>());

        /// <summary>Open a write only memory stream.</summary>
        /// <param name="s">new IO context</param>
        /// <returns>zero if no error.</returns>
        public int avio_open_dyn_buf(AVIOContext** @s)
        {
            return avio_open_dyn_buf_ptr(@s);
        }

        private avio_open2_delegate? _avio_open2_ptr;

        public avio_open2_delegate avio_open2_ptr => _avio_open2_ptr ?? (_avio_open2_ptr = NativeMethodDelegate<avio_open2_delegate>());

        /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
        /// <param name="s">Used to return the pointer to the created AVIOContext. In case of failure the pointed to value is set to NULL.</param>
        /// <param name="url">resource to access</param>
        /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
        /// <param name="int_cb">an interrupt callback to be used at the protocols level</param>
        /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        /// <returns>&gt;= 0 in case of success, a negative value corresponding to an AVERROR code in case of failure</returns>
        public int avio_open2(AVIOContext** @s,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options)
        {
            return avio_open2_ptr(@s, @url, @flags, @int_cb, @options);
        }

        private avio_pause_delegate? _avio_pause_ptr;

        public avio_pause_delegate avio_pause_ptr => _avio_pause_ptr ?? (_avio_pause_ptr = NativeMethodDelegate<avio_pause_delegate>());

        /// <summary>Pause and resume playing - only meaningful if using a network streaming protocol (e.g. MMS).</summary>
        /// <param name="h">IO context from which to call the read_pause function pointer</param>
        /// <param name="pause">1 for pause, 0 for resume</param>
        public int avio_pause(AVIOContext* @h, int @pause)
        {
            return avio_pause_ptr(@h, @pause);
        }

        private avio_print_string_array_delegate? _avio_print_string_array_ptr;

        public avio_print_string_array_delegate avio_print_string_array_ptr => _avio_print_string_array_ptr ?? (_avio_print_string_array_ptr = NativeMethodDelegate<avio_print_string_array_delegate>());

        /// <summary>Write a NULL terminated array of strings to the context. Usually you don&apos;t need to use this function directly but its macro wrapper, avio_print.</summary>
        public void avio_print_string_array(AVIOContext* @s, byte*[] @strings)
        {
            avio_print_string_array_ptr(@s, @strings);
        }

        private avio_printf_delegate? _avio_printf_ptr;

        public avio_printf_delegate avio_printf_ptr => _avio_printf_ptr ?? (_avio_printf_ptr = NativeMethodDelegate<avio_printf_delegate>());

        /// <summary>Writes a formatted string to the context.</summary>
        /// <returns>number of bytes written, &lt; 0 on error.</returns>
        public int avio_printf(AVIOContext* @s,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt)
        {
            return avio_printf_ptr(@s, @fmt);
        }

        private avio_protocol_get_class_delegate? _avio_protocol_get_class_ptr;

        public avio_protocol_get_class_delegate avio_protocol_get_class_ptr => _avio_protocol_get_class_ptr ?? (_avio_protocol_get_class_ptr = NativeMethodDelegate<avio_protocol_get_class_delegate>());

        /// <summary>Get AVClass by names of available protocols.</summary>
        /// <returns>A AVClass of input protocol name or NULL</returns>
        public AVClass* avio_protocol_get_class(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return avio_protocol_get_class_ptr(@name);
        }

        private avio_put_str_delegate? _avio_put_str_ptr;

        public avio_put_str_delegate avio_put_str_ptr => _avio_put_str_ptr ?? (_avio_put_str_ptr = NativeMethodDelegate<avio_put_str_delegate>());

        /// <summary>Write a NULL-terminated string.</summary>
        /// <returns>number of bytes written.</returns>
        public int avio_put_str(AVIOContext* @s,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str)
        {
            return avio_put_str_ptr(@s, @str);
        }

        private avio_put_str16be_delegate? _avio_put_str16be_ptr;

        public avio_put_str16be_delegate avio_put_str16be_ptr => _avio_put_str16be_ptr ?? (_avio_put_str16be_ptr = NativeMethodDelegate<avio_put_str16be_delegate>());

        /// <summary>Convert an UTF-8 string to UTF-16BE and write it.</summary>
        /// <param name="s">the AVIOContext</param>
        /// <param name="str">NULL-terminated UTF-8 string</param>
        /// <returns>number of bytes written.</returns>
        public int avio_put_str16be(AVIOContext* @s,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str)
        {
            return avio_put_str16be_ptr(@s, @str);
        }

        private avio_put_str16le_delegate? _avio_put_str16le_ptr;

        public avio_put_str16le_delegate avio_put_str16le_ptr => _avio_put_str16le_ptr ?? (_avio_put_str16le_ptr = NativeMethodDelegate<avio_put_str16le_delegate>());

        /// <summary>Convert an UTF-8 string to UTF-16LE and write it.</summary>
        /// <param name="s">the AVIOContext</param>
        /// <param name="str">NULL-terminated UTF-8 string</param>
        /// <returns>number of bytes written.</returns>
        public int avio_put_str16le(AVIOContext* @s,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str)
        {
            return avio_put_str16le_ptr(@s, @str);
        }

        private avio_r8_delegate? _avio_r8_ptr;

        public avio_r8_delegate avio_r8_ptr => _avio_r8_ptr ?? (_avio_r8_ptr = NativeMethodDelegate<avio_r8_delegate>());

        /// <summary>@{</summary>
        public int avio_r8(AVIOContext* @s)
        {
            return avio_r8_ptr(@s);
        }

        private avio_rb16_delegate? _avio_rb16_ptr;

        public avio_rb16_delegate avio_rb16_ptr => _avio_rb16_ptr ?? (_avio_rb16_ptr = NativeMethodDelegate<avio_rb16_delegate>());

        public uint avio_rb16(AVIOContext* @s)
        {
            return avio_rb16_ptr(@s);
        }

        private avio_rb24_delegate? _avio_rb24_ptr;

        public avio_rb24_delegate avio_rb24_ptr => _avio_rb24_ptr ?? (_avio_rb24_ptr = NativeMethodDelegate<avio_rb24_delegate>());

        public uint avio_rb24(AVIOContext* @s)
        {
            return avio_rb24_ptr(@s);
        }

        private avio_rb32_delegate? _avio_rb32_ptr;

        public avio_rb32_delegate avio_rb32_ptr => _avio_rb32_ptr ?? (_avio_rb32_ptr = NativeMethodDelegate<avio_rb32_delegate>());

        public uint avio_rb32(AVIOContext* @s)
        {
            return avio_rb32_ptr(@s);
        }

        private avio_rb64_delegate? _avio_rb64_ptr;

        public avio_rb64_delegate avio_rb64_ptr => _avio_rb64_ptr ?? (_avio_rb64_ptr = NativeMethodDelegate<avio_rb64_delegate>());

        public ulong avio_rb64(AVIOContext* @s)
        {
            return avio_rb64_ptr(@s);
        }

        private avio_read_delegate? _avio_read_ptr;

        public avio_read_delegate avio_read_ptr => _avio_read_ptr ?? (_avio_read_ptr = NativeMethodDelegate<avio_read_delegate>());

        /// <summary>Read size bytes from AVIOContext into buf.</summary>
        /// <returns>number of bytes read or AVERROR</returns>
        public int avio_read(AVIOContext* @s, byte* @buf, int @size)
        {
            return avio_read_ptr(@s, @buf, @size);
        }

        private avio_read_dir_delegate? _avio_read_dir_ptr;

        public avio_read_dir_delegate avio_read_dir_ptr => _avio_read_dir_ptr ?? (_avio_read_dir_ptr = NativeMethodDelegate<avio_read_dir_delegate>());

        /// <summary>Get next directory entry.</summary>
        /// <param name="s">directory read context.</param>
        /// <param name="next">next entry or NULL when no more entries.</param>
        /// <returns>&gt;=0 on success or negative on error. End of list is not considered an error.</returns>
        public int avio_read_dir(AVIODirContext* @s, AVIODirEntry** @next)
        {
            return avio_read_dir_ptr(@s, @next);
        }

        private avio_read_partial_delegate? _avio_read_partial_ptr;

        public avio_read_partial_delegate avio_read_partial_ptr => _avio_read_partial_ptr ?? (_avio_read_partial_ptr = NativeMethodDelegate<avio_read_partial_delegate>());

        /// <summary>Read size bytes from AVIOContext into buf. Unlike avio_read(), this is allowed to read fewer bytes than requested. The missing bytes can be read in the next call. This always tries to read at least 1 byte. Useful to reduce latency in certain cases.</summary>
        /// <returns>number of bytes read or AVERROR</returns>
        public int avio_read_partial(AVIOContext* @s, byte* @buf, int @size)
        {
            return avio_read_partial_ptr(@s, @buf, @size);
        }

        private avio_read_to_bprint_delegate? _avio_read_to_bprint_ptr;

        public avio_read_to_bprint_delegate avio_read_to_bprint_ptr => _avio_read_to_bprint_ptr ?? (_avio_read_to_bprint_ptr = NativeMethodDelegate<avio_read_to_bprint_delegate>());

        /// <summary>Read contents of h into print buffer, up to max_size bytes, or up to EOF.</summary>
        /// <returns>0 for success (max_size bytes read or EOF reached), negative error code otherwise</returns>
        public int avio_read_to_bprint(AVIOContext* @h, AVBPrint* @pb, ulong @max_size)
        {
            return avio_read_to_bprint_ptr(@h, @pb, @max_size);
        }

        private avio_rl16_delegate? _avio_rl16_ptr;

        public avio_rl16_delegate avio_rl16_ptr => _avio_rl16_ptr ?? (_avio_rl16_ptr = NativeMethodDelegate<avio_rl16_delegate>());

        public uint avio_rl16(AVIOContext* @s)
        {
            return avio_rl16_ptr(@s);
        }

        private avio_rl24_delegate? _avio_rl24_ptr;

        public avio_rl24_delegate avio_rl24_ptr => _avio_rl24_ptr ?? (_avio_rl24_ptr = NativeMethodDelegate<avio_rl24_delegate>());

        public uint avio_rl24(AVIOContext* @s)
        {
            return avio_rl24_ptr(@s);
        }

        private avio_rl32_delegate? _avio_rl32_ptr;

        public avio_rl32_delegate avio_rl32_ptr => _avio_rl32_ptr ?? (_avio_rl32_ptr = NativeMethodDelegate<avio_rl32_delegate>());

        public uint avio_rl32(AVIOContext* @s)
        {
            return avio_rl32_ptr(@s);
        }

        private avio_rl64_delegate? _avio_rl64_ptr;

        public avio_rl64_delegate avio_rl64_ptr => _avio_rl64_ptr ?? (_avio_rl64_ptr = NativeMethodDelegate<avio_rl64_delegate>());

        public ulong avio_rl64(AVIOContext* @s)
        {
            return avio_rl64_ptr(@s);
        }

        private avio_seek_delegate? _avio_seek_ptr;

        public avio_seek_delegate avio_seek_ptr => _avio_seek_ptr ?? (_avio_seek_ptr = NativeMethodDelegate<avio_seek_delegate>());

        /// <summary>fseek() equivalent for AVIOContext.</summary>
        /// <returns>new position or AVERROR.</returns>
        public long avio_seek(AVIOContext* @s, long @offset, int @whence)
        {
            return avio_seek_ptr(@s, @offset, @whence);
        }

        private avio_seek_time_delegate? _avio_seek_time_ptr;

        public avio_seek_time_delegate avio_seek_time_ptr => _avio_seek_time_ptr ?? (_avio_seek_time_ptr = NativeMethodDelegate<avio_seek_time_delegate>());

        /// <summary>Seek to a given timestamp relative to some component stream. Only meaningful if using a network streaming protocol (e.g. MMS.).</summary>
        /// <param name="h">IO context from which to call the seek function pointers</param>
        /// <param name="stream_index">The stream index that the timestamp is relative to. If stream_index is (-1) the timestamp should be in AV_TIME_BASE units from the beginning of the presentation. If a stream_index &gt;= 0 is used and the protocol does not support seeking based on component streams, the call will fail.</param>
        /// <param name="timestamp">timestamp in AVStream.time_base units or if there is no stream specified then in AV_TIME_BASE units.</param>
        /// <param name="flags">Optional combination of AVSEEK_FLAG_BACKWARD, AVSEEK_FLAG_BYTE and AVSEEK_FLAG_ANY. The protocol may silently ignore AVSEEK_FLAG_BACKWARD and AVSEEK_FLAG_ANY, but AVSEEK_FLAG_BYTE will fail if used and not supported.</param>
        /// <returns>&gt;= 0 on success</returns>
        public long avio_seek_time(AVIOContext* @h, int @stream_index, long @timestamp, int @flags)
        {
            return avio_seek_time_ptr(@h, @stream_index, @timestamp, @flags);
        }

        private avio_size_delegate? _avio_size_ptr;

        public avio_size_delegate avio_size_ptr => _avio_size_ptr ?? (_avio_size_ptr = NativeMethodDelegate<avio_size_delegate>());

        /// <summary>Get the filesize.</summary>
        /// <returns>filesize or AVERROR</returns>
        public long avio_size(AVIOContext* @s)
        {
            return avio_size_ptr(@s);
        }

        private avio_skip_delegate? _avio_skip_ptr;

        public avio_skip_delegate avio_skip_ptr => _avio_skip_ptr ?? (_avio_skip_ptr = NativeMethodDelegate<avio_skip_delegate>());

        /// <summary>Skip given number of bytes forward</summary>
        /// <returns>new position or AVERROR.</returns>
        public long avio_skip(AVIOContext* @s, long @offset)
        {
            return avio_skip_ptr(@s, @offset);
        }

        private avio_w8_delegate? _avio_w8_ptr;

        public avio_w8_delegate avio_w8_ptr => _avio_w8_ptr ?? (_avio_w8_ptr = NativeMethodDelegate<avio_w8_delegate>());

        public void avio_w8(AVIOContext* @s, int @b)
        {
            avio_w8_ptr(@s, @b);
        }

        private avio_wb16_delegate? _avio_wb16_ptr;

        public avio_wb16_delegate avio_wb16_ptr => _avio_wb16_ptr ?? (_avio_wb16_ptr = NativeMethodDelegate<avio_wb16_delegate>());

        public void avio_wb16(AVIOContext* @s, uint @val)
        {
            avio_wb16_ptr(@s, @val);
        }

        private avio_wb24_delegate? _avio_wb24_ptr;

        public avio_wb24_delegate avio_wb24_ptr => _avio_wb24_ptr ?? (_avio_wb24_ptr = NativeMethodDelegate<avio_wb24_delegate>());

        public void avio_wb24(AVIOContext* @s, uint @val)
        {
            avio_wb24_ptr(@s, @val);
        }

        private avio_wb32_delegate? _avio_wb32_ptr;

        public avio_wb32_delegate avio_wb32_ptr => _avio_wb32_ptr ?? (_avio_wb32_ptr = NativeMethodDelegate<avio_wb32_delegate>());

        public void avio_wb32(AVIOContext* @s, uint @val)
        {
            avio_wb32_ptr(@s, @val);
        }

        private avio_wb64_delegate? _avio_wb64_ptr;

        public avio_wb64_delegate avio_wb64_ptr => _avio_wb64_ptr ?? (_avio_wb64_ptr = NativeMethodDelegate<avio_wb64_delegate>());

        public void avio_wb64(AVIOContext* @s, ulong @val)
        {
            avio_wb64_ptr(@s, @val);
        }

        private avio_wl16_delegate? _avio_wl16_ptr;

        public avio_wl16_delegate avio_wl16_ptr => _avio_wl16_ptr ?? (_avio_wl16_ptr = NativeMethodDelegate<avio_wl16_delegate>());

        public void avio_wl16(AVIOContext* @s, uint @val)
        {
            avio_wl16_ptr(@s, @val);
        }

        private avio_wl24_delegate? _avio_wl24_ptr;

        public avio_wl24_delegate avio_wl24_ptr => _avio_wl24_ptr ?? (_avio_wl24_ptr = NativeMethodDelegate<avio_wl24_delegate>());

        public void avio_wl24(AVIOContext* @s, uint @val)
        {
            avio_wl24_ptr(@s, @val);
        }

        private avio_wl32_delegate? _avio_wl32_ptr;

        public avio_wl32_delegate avio_wl32_ptr => _avio_wl32_ptr ?? (_avio_wl32_ptr = NativeMethodDelegate<avio_wl32_delegate>());

        public void avio_wl32(AVIOContext* @s, uint @val)
        {
            avio_wl32_ptr(@s, @val);
        }

        private avio_wl64_delegate? _avio_wl64_ptr;

        public avio_wl64_delegate avio_wl64_ptr => _avio_wl64_ptr ?? (_avio_wl64_ptr = NativeMethodDelegate<avio_wl64_delegate>());

        public void avio_wl64(AVIOContext* @s, ulong @val)
        {
            avio_wl64_ptr(@s, @val);
        }

        private avio_write_delegate? _avio_write_ptr;

        public avio_write_delegate avio_write_ptr => _avio_write_ptr ?? (_avio_write_ptr = NativeMethodDelegate<avio_write_delegate>());

        public void avio_write(AVIOContext* @s, byte* @buf, int @size)
        {
            avio_write_ptr(@s, @buf, @size);
        }

        private avio_write_marker_delegate? _avio_write_marker_ptr;

        public avio_write_marker_delegate avio_write_marker_ptr => _avio_write_marker_ptr ?? (_avio_write_marker_ptr = NativeMethodDelegate<avio_write_marker_delegate>());

        /// <summary>Mark the written bytestream as a specific type.</summary>
        /// <param name="time">the stream time the current bytestream pos corresponds to (in AV_TIME_BASE units), or AV_NOPTS_VALUE if unknown or not applicable</param>
        /// <param name="type">the kind of data written starting at the current pos</param>
        public void avio_write_marker(AVIOContext* @s, long @time, AVIODataMarkerType @type)
        {
            avio_write_marker_ptr(@s, @time, @type);
        }

        private av_add_q_delegate? _av_add_q_ptr;

        public av_add_q_delegate av_add_q_ptr => _av_add_q_ptr ?? (_av_add_q_ptr = NativeMethodDelegate<av_add_q_delegate>());

        /// <summary>Add two rationals.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        /// <returns>b+c</returns>
        public AVRational av_add_q(AVRational @b, AVRational @c)
        {
            return av_add_q_ptr(@b, @c);
        }

        private av_add_stable_delegate? _av_add_stable_ptr;

        public av_add_stable_delegate av_add_stable_ptr => _av_add_stable_ptr ?? (_av_add_stable_ptr = NativeMethodDelegate<av_add_stable_delegate>());

        /// <summary>Add a value to a timestamp.</summary>
        /// <param name="ts_tb">Input timestamp time base</param>
        /// <param name="ts">Input timestamp</param>
        /// <param name="inc_tb">Time base of `inc`</param>
        /// <param name="inc">Value to be added</param>
        public long av_add_stable(AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc)
        {
            return av_add_stable_ptr(@ts_tb, @ts, @inc_tb, @inc);
        }

        private av_audio_fifo_alloc_delegate? _av_audio_fifo_alloc_ptr;

        public av_audio_fifo_alloc_delegate av_audio_fifo_alloc_ptr => _av_audio_fifo_alloc_ptr ?? (_av_audio_fifo_alloc_ptr = NativeMethodDelegate<av_audio_fifo_alloc_delegate>());

        /// <summary>Allocate an AVAudioFifo.</summary>
        /// <param name="sample_fmt">sample format</param>
        /// <param name="channels">number of channels</param>
        /// <param name="nb_samples">initial allocation size, in samples</param>
        /// <returns>newly allocated AVAudioFifo, or NULL on error</returns>
        public AVAudioFifo* av_audio_fifo_alloc(AVSampleFormat @sample_fmt, int @channels, int @nb_samples)
        {
            return av_audio_fifo_alloc_ptr(@sample_fmt, @channels, @nb_samples);
        }

        private av_audio_fifo_drain_delegate? _av_audio_fifo_drain_ptr;

        public av_audio_fifo_drain_delegate av_audio_fifo_drain_ptr => _av_audio_fifo_drain_ptr ?? (_av_audio_fifo_drain_ptr = NativeMethodDelegate<av_audio_fifo_drain_delegate>());

        /// <summary>Drain data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to drain</param>
        /// <param name="nb_samples">number of samples to drain</param>
        /// <returns>0 if OK, or negative AVERROR code on failure</returns>
        public int av_audio_fifo_drain(AVAudioFifo* @af, int @nb_samples)
        {
            return av_audio_fifo_drain_ptr(@af, @nb_samples);
        }

        private av_audio_fifo_free_delegate? _av_audio_fifo_free_ptr;

        public av_audio_fifo_free_delegate av_audio_fifo_free_ptr => _av_audio_fifo_free_ptr ?? (_av_audio_fifo_free_ptr = NativeMethodDelegate<av_audio_fifo_free_delegate>());

        /// <summary>Free an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to free</param>
        public void av_audio_fifo_free(AVAudioFifo* @af)
        {
            av_audio_fifo_free_ptr(@af);
        }

        private av_audio_fifo_peek_delegate? _av_audio_fifo_peek_ptr;

        public av_audio_fifo_peek_delegate av_audio_fifo_peek_ptr => _av_audio_fifo_peek_ptr ?? (_av_audio_fifo_peek_ptr = NativeMethodDelegate<av_audio_fifo_peek_delegate>());

        /// <summary>Peek data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to read from</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to peek</param>
        /// <returns>number of samples actually peek, or negative AVERROR code on failure. The number of samples actually peek will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
        public int av_audio_fifo_peek(AVAudioFifo* @af, void** @data, int @nb_samples)
        {
            return av_audio_fifo_peek_ptr(@af, @data, @nb_samples);
        }

        private av_audio_fifo_peek_at_delegate? _av_audio_fifo_peek_at_ptr;

        public av_audio_fifo_peek_at_delegate av_audio_fifo_peek_at_ptr => _av_audio_fifo_peek_at_ptr ?? (_av_audio_fifo_peek_at_ptr = NativeMethodDelegate<av_audio_fifo_peek_at_delegate>());

        /// <summary>Peek data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to read from</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to peek</param>
        /// <param name="offset">offset from current read position</param>
        /// <returns>number of samples actually peek, or negative AVERROR code on failure. The number of samples actually peek will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
        public int av_audio_fifo_peek_at(AVAudioFifo* @af, void** @data, int @nb_samples, int @offset)
        {
            return av_audio_fifo_peek_at_ptr(@af, @data, @nb_samples, @offset);
        }

        private av_audio_fifo_read_delegate? _av_audio_fifo_read_ptr;

        public av_audio_fifo_read_delegate av_audio_fifo_read_ptr => _av_audio_fifo_read_ptr ?? (_av_audio_fifo_read_ptr = NativeMethodDelegate<av_audio_fifo_read_delegate>());

        /// <summary>Read data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to read from</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to read</param>
        /// <returns>number of samples actually read, or negative AVERROR code on failure. The number of samples actually read will not be greater than nb_samples, and will only be less than nb_samples if av_audio_fifo_size is less than nb_samples.</returns>
        public int av_audio_fifo_read(AVAudioFifo* @af, void** @data, int @nb_samples)
        {
            return av_audio_fifo_read_ptr(@af, @data, @nb_samples);
        }

        private av_audio_fifo_realloc_delegate? _av_audio_fifo_realloc_ptr;

        public av_audio_fifo_realloc_delegate av_audio_fifo_realloc_ptr => _av_audio_fifo_realloc_ptr ?? (_av_audio_fifo_realloc_ptr = NativeMethodDelegate<av_audio_fifo_realloc_delegate>());

        /// <summary>Reallocate an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to reallocate</param>
        /// <param name="nb_samples">new allocation size, in samples</param>
        /// <returns>0 if OK, or negative AVERROR code on failure</returns>
        public int av_audio_fifo_realloc(AVAudioFifo* @af, int @nb_samples)
        {
            return av_audio_fifo_realloc_ptr(@af, @nb_samples);
        }

        private av_audio_fifo_reset_delegate? _av_audio_fifo_reset_ptr;

        public av_audio_fifo_reset_delegate av_audio_fifo_reset_ptr => _av_audio_fifo_reset_ptr ?? (_av_audio_fifo_reset_ptr = NativeMethodDelegate<av_audio_fifo_reset_delegate>());

        /// <summary>Reset the AVAudioFifo buffer.</summary>
        /// <param name="af">AVAudioFifo to reset</param>
        public void av_audio_fifo_reset(AVAudioFifo* @af)
        {
            av_audio_fifo_reset_ptr(@af);
        }

        private av_audio_fifo_size_delegate? _av_audio_fifo_size_ptr;

        public av_audio_fifo_size_delegate av_audio_fifo_size_ptr => _av_audio_fifo_size_ptr ?? (_av_audio_fifo_size_ptr = NativeMethodDelegate<av_audio_fifo_size_delegate>());

        /// <summary>Get the current number of samples in the AVAudioFifo available for reading.</summary>
        /// <param name="af">the AVAudioFifo to query</param>
        /// <returns>number of samples available for reading</returns>
        public int av_audio_fifo_size(AVAudioFifo* @af)
        {
            return av_audio_fifo_size_ptr(@af);
        }

        private av_audio_fifo_space_delegate? _av_audio_fifo_space_ptr;

        public av_audio_fifo_space_delegate av_audio_fifo_space_ptr => _av_audio_fifo_space_ptr ?? (_av_audio_fifo_space_ptr = NativeMethodDelegate<av_audio_fifo_space_delegate>());

        /// <summary>Get the current number of samples in the AVAudioFifo available for writing.</summary>
        /// <param name="af">the AVAudioFifo to query</param>
        /// <returns>number of samples available for writing</returns>
        public int av_audio_fifo_space(AVAudioFifo* @af)
        {
            return av_audio_fifo_space_ptr(@af);
        }

        private av_audio_fifo_write_delegate? _av_audio_fifo_write_ptr;

        public av_audio_fifo_write_delegate av_audio_fifo_write_ptr => _av_audio_fifo_write_ptr ?? (_av_audio_fifo_write_ptr = NativeMethodDelegate<av_audio_fifo_write_delegate>());

        /// <summary>Write data to an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to write to</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to write</param>
        /// <returns>number of samples actually written, or negative AVERROR code on failure. If successful, the number of samples actually written will always be nb_samples.</returns>
        public int av_audio_fifo_write(AVAudioFifo* @af, void** @data, int @nb_samples)
        {
            return av_audio_fifo_write_ptr(@af, @data, @nb_samples);
        }

        private av_bprint_channel_layout_delegate? _av_bprint_channel_layout_ptr;

        public av_bprint_channel_layout_delegate av_bprint_channel_layout_ptr => _av_bprint_channel_layout_ptr ?? (_av_bprint_channel_layout_ptr = NativeMethodDelegate<av_bprint_channel_layout_delegate>());

        /// <summary>Append a description of a channel layout to a bprint buffer.</summary>
        public void av_bprint_channel_layout(AVBPrint* @bp, int @nb_channels, ulong @channel_layout)
        {
            av_bprint_channel_layout_ptr(@bp, @nb_channels, @channel_layout);
        }

        private av_buffer_alloc_delegate? _av_buffer_alloc_ptr;

        public av_buffer_alloc_delegate av_buffer_alloc_ptr => _av_buffer_alloc_ptr ?? (_av_buffer_alloc_ptr = NativeMethodDelegate<av_buffer_alloc_delegate>());

        /// <summary>Allocate an AVBuffer of the given size using av_malloc().</summary>
        /// <returns>an AVBufferRef of given size or NULL when out of memory</returns>
        public AVBufferRef* av_buffer_alloc(ulong @size)
        {
            return av_buffer_alloc_ptr(@size);
        }

        private av_buffer_allocz_delegate? _av_buffer_allocz_ptr;

        public av_buffer_allocz_delegate av_buffer_allocz_ptr => _av_buffer_allocz_ptr ?? (_av_buffer_allocz_ptr = NativeMethodDelegate<av_buffer_allocz_delegate>());

        /// <summary>Same as av_buffer_alloc(), except the returned buffer will be initialized to zero.</summary>
        public AVBufferRef* av_buffer_allocz(ulong @size)
        {
            return av_buffer_allocz_ptr(@size);
        }

        private av_buffer_create_delegate? _av_buffer_create_ptr;

        public av_buffer_create_delegate av_buffer_create_ptr => _av_buffer_create_ptr ?? (_av_buffer_create_ptr = NativeMethodDelegate<av_buffer_create_delegate>());

        /// <summary>Create an AVBuffer from an existing array.</summary>
        /// <param name="data">data array</param>
        /// <param name="size">size of data in bytes</param>
        /// <param name="free">a callback for freeing this buffer&apos;s data</param>
        /// <param name="opaque">parameter to be got for processing or passed to free</param>
        /// <param name="flags">a combination of AV_BUFFER_FLAG_*</param>
        /// <returns>an AVBufferRef referring to data on success, NULL on failure.</returns>
        public AVBufferRef* av_buffer_create(byte* @data, ulong @size, av_buffer_create_free_func @free, void* @opaque, int @flags)
        {
            return av_buffer_create_ptr(@data, @size, @free, @opaque, @flags);
        }

        private av_buffer_default_free_delegate? _av_buffer_default_free_ptr;

        public av_buffer_default_free_delegate av_buffer_default_free_ptr => _av_buffer_default_free_ptr ?? (_av_buffer_default_free_ptr = NativeMethodDelegate<av_buffer_default_free_delegate>());

        /// <summary>Default free callback, which calls av_free() on the buffer data. This function is meant to be passed to av_buffer_create(), not called directly.</summary>
        public void av_buffer_default_free(void* @opaque, byte* @data)
        {
            av_buffer_default_free_ptr(@opaque, @data);
        }

        private av_buffer_get_opaque_delegate? _av_buffer_get_opaque_ptr;

        public av_buffer_get_opaque_delegate av_buffer_get_opaque_ptr => _av_buffer_get_opaque_ptr ?? (_av_buffer_get_opaque_ptr = NativeMethodDelegate<av_buffer_get_opaque_delegate>());

        /// <summary>Returns the opaque parameter set by av_buffer_create.</summary>
        /// <returns>the opaque parameter set by av_buffer_create.</returns>
        public void* av_buffer_get_opaque(AVBufferRef* @buf)
        {
            return av_buffer_get_opaque_ptr(@buf);
        }

        private av_buffer_get_ref_count_delegate? _av_buffer_get_ref_count_ptr;

        public av_buffer_get_ref_count_delegate av_buffer_get_ref_count_ptr => _av_buffer_get_ref_count_ptr ?? (_av_buffer_get_ref_count_ptr = NativeMethodDelegate<av_buffer_get_ref_count_delegate>());

        public int av_buffer_get_ref_count(AVBufferRef* @buf)
        {
            return av_buffer_get_ref_count_ptr(@buf);
        }

        private av_buffer_is_writable_delegate? _av_buffer_is_writable_ptr;

        public av_buffer_is_writable_delegate av_buffer_is_writable_ptr => _av_buffer_is_writable_ptr ?? (_av_buffer_is_writable_ptr = NativeMethodDelegate<av_buffer_is_writable_delegate>());

        /// <summary>Returns 1 if the caller may write to the data referred to by buf (which is true if and only if buf is the only reference to the underlying AVBuffer). Return 0 otherwise. A positive answer is valid until av_buffer_ref() is called on buf.</summary>
        /// <returns>1 if the caller may write to the data referred to by buf (which is true if and only if buf is the only reference to the underlying AVBuffer). Return 0 otherwise. A positive answer is valid until av_buffer_ref() is called on buf.</returns>
        public int av_buffer_is_writable(AVBufferRef* @buf)
        {
            return av_buffer_is_writable_ptr(@buf);
        }

        private av_buffer_make_writable_delegate? _av_buffer_make_writable_ptr;

        public av_buffer_make_writable_delegate av_buffer_make_writable_ptr => _av_buffer_make_writable_ptr ?? (_av_buffer_make_writable_ptr = NativeMethodDelegate<av_buffer_make_writable_delegate>());

        /// <summary>Create a writable reference from a given buffer reference, avoiding data copy if possible.</summary>
        /// <param name="buf">buffer reference to make writable. On success, buf is either left untouched, or it is unreferenced and a new writable AVBufferRef is written in its place. On failure, buf is left untouched.</param>
        /// <returns>0 on success, a negative AVERROR on failure.</returns>
        public int av_buffer_make_writable(AVBufferRef** @buf)
        {
            return av_buffer_make_writable_ptr(@buf);
        }

        private av_buffer_pool_buffer_get_opaque_delegate? _av_buffer_pool_buffer_get_opaque_ptr;

        public av_buffer_pool_buffer_get_opaque_delegate av_buffer_pool_buffer_get_opaque_ptr => _av_buffer_pool_buffer_get_opaque_ptr ?? (_av_buffer_pool_buffer_get_opaque_ptr = NativeMethodDelegate<av_buffer_pool_buffer_get_opaque_delegate>());

        /// <summary>Query the original opaque parameter of an allocated buffer in the pool.</summary>
        /// <param name="ref">a buffer reference to a buffer returned by av_buffer_pool_get.</param>
        /// <returns>the opaque parameter set by the buffer allocator function of the buffer pool.</returns>
        public void* av_buffer_pool_buffer_get_opaque(AVBufferRef* @ref)
        {
            return av_buffer_pool_buffer_get_opaque_ptr(@ref);
        }

        private av_buffer_pool_get_delegate? _av_buffer_pool_get_ptr;

        public av_buffer_pool_get_delegate av_buffer_pool_get_ptr => _av_buffer_pool_get_ptr ?? (_av_buffer_pool_get_ptr = NativeMethodDelegate<av_buffer_pool_get_delegate>());

        /// <summary>Allocate a new AVBuffer, reusing an old buffer from the pool when available. This function may be called simultaneously from multiple threads.</summary>
        /// <returns>a reference to the new buffer on success, NULL on error.</returns>
        public AVBufferRef* av_buffer_pool_get(AVBufferPool* @pool)
        {
            return av_buffer_pool_get_ptr(@pool);
        }

        private av_buffer_pool_init_delegate? _av_buffer_pool_init_ptr;

        public av_buffer_pool_init_delegate av_buffer_pool_init_ptr => _av_buffer_pool_init_ptr ?? (_av_buffer_pool_init_ptr = NativeMethodDelegate<av_buffer_pool_init_delegate>());

        /// <summary>Allocate and initialize a buffer pool.</summary>
        /// <param name="size">size of each buffer in this pool</param>
        /// <param name="alloc">a function that will be used to allocate new buffers when the pool is empty. May be NULL, then the default allocator will be used (av_buffer_alloc()).</param>
        /// <returns>newly created buffer pool on success, NULL on error.</returns>
        public AVBufferPool* av_buffer_pool_init(ulong @size, av_buffer_pool_init_alloc_func @alloc)
        {
            return av_buffer_pool_init_ptr(@size, @alloc);
        }

        private av_buffer_pool_init2_delegate? _av_buffer_pool_init2_ptr;

        public av_buffer_pool_init2_delegate av_buffer_pool_init2_ptr => _av_buffer_pool_init2_ptr ?? (_av_buffer_pool_init2_ptr = NativeMethodDelegate<av_buffer_pool_init2_delegate>());

        /// <summary>Allocate and initialize a buffer pool with a more complex allocator.</summary>
        /// <param name="size">size of each buffer in this pool</param>
        /// <param name="opaque">arbitrary user data used by the allocator</param>
        /// <param name="alloc">a function that will be used to allocate new buffers when the pool is empty. May be NULL, then the default allocator will be used (av_buffer_alloc()).</param>
        /// <param name="pool_free">a function that will be called immediately before the pool is freed. I.e. after av_buffer_pool_uninit() is called by the caller and all the frames are returned to the pool and freed. It is intended to uninitialize the user opaque data. May be NULL.</param>
        /// <returns>newly created buffer pool on success, NULL on error.</returns>
        public AVBufferPool* av_buffer_pool_init2(ulong @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free)
        {
            return av_buffer_pool_init2_ptr(@size, @opaque, @alloc, @pool_free);
        }

        private av_buffer_pool_uninit_delegate? _av_buffer_pool_uninit_ptr;

        public av_buffer_pool_uninit_delegate av_buffer_pool_uninit_ptr => _av_buffer_pool_uninit_ptr ?? (_av_buffer_pool_uninit_ptr = NativeMethodDelegate<av_buffer_pool_uninit_delegate>());

        /// <summary>Mark the pool as being available for freeing. It will actually be freed only once all the allocated buffers associated with the pool are released. Thus it is safe to call this function while some of the allocated buffers are still in use.</summary>
        /// <param name="pool">pointer to the pool to be freed. It will be set to NULL.</param>
        public void av_buffer_pool_uninit(AVBufferPool** @pool)
        {
            av_buffer_pool_uninit_ptr(@pool);
        }

        private av_buffer_realloc_delegate? _av_buffer_realloc_ptr;

        public av_buffer_realloc_delegate av_buffer_realloc_ptr => _av_buffer_realloc_ptr ?? (_av_buffer_realloc_ptr = NativeMethodDelegate<av_buffer_realloc_delegate>());

        /// <summary>Reallocate a given buffer.</summary>
        /// <param name="buf">a buffer reference to reallocate. On success, buf will be unreferenced and a new reference with the required size will be written in its place. On failure buf will be left untouched. *buf may be NULL, then a new buffer is allocated.</param>
        /// <param name="size">required new buffer size.</param>
        /// <returns>0 on success, a negative AVERROR on failure.</returns>
        public int av_buffer_realloc(AVBufferRef** @buf, ulong @size)
        {
            return av_buffer_realloc_ptr(@buf, @size);
        }

        private av_buffer_ref_delegate? _av_buffer_ref_ptr;

        public av_buffer_ref_delegate av_buffer_ref_ptr => _av_buffer_ref_ptr ?? (_av_buffer_ref_ptr = NativeMethodDelegate<av_buffer_ref_delegate>());

        /// <summary>Create a new reference to an AVBuffer.</summary>
        /// <returns>a new AVBufferRef referring to the same AVBuffer as buf or NULL on failure.</returns>
        public AVBufferRef* av_buffer_ref(AVBufferRef* @buf)
        {
            return av_buffer_ref_ptr(@buf);
        }

        private av_buffer_replace_delegate? _av_buffer_replace_ptr;

        public av_buffer_replace_delegate av_buffer_replace_ptr => _av_buffer_replace_ptr ?? (_av_buffer_replace_ptr = NativeMethodDelegate<av_buffer_replace_delegate>());

        /// <summary>Ensure dst refers to the same data as src.</summary>
        /// <param name="dst">Pointer to either a valid buffer reference or NULL. On success, this will point to a buffer reference equivalent to src. On failure, dst will be left untouched.</param>
        /// <param name="src">A buffer reference to replace dst with. May be NULL, then this function is equivalent to av_buffer_unref(dst).</param>
        /// <returns>0 on success AVERROR(ENOMEM) on memory allocation failure.</returns>
        public int av_buffer_replace(AVBufferRef** @dst, AVBufferRef* @src)
        {
            return av_buffer_replace_ptr(@dst, @src);
        }

        private av_buffer_unref_delegate? _av_buffer_unref_ptr;

        public av_buffer_unref_delegate av_buffer_unref_ptr => _av_buffer_unref_ptr ?? (_av_buffer_unref_ptr = NativeMethodDelegate<av_buffer_unref_delegate>());

        /// <summary>Free a given reference and automatically free the buffer if there are no more references to it.</summary>
        /// <param name="buf">the reference to be freed. The pointer is set to NULL on return.</param>
        public void av_buffer_unref(AVBufferRef** @buf)
        {
            av_buffer_unref_ptr(@buf);
        }

        private av_calloc_delegate? _av_calloc_ptr;

        public av_calloc_delegate av_calloc_ptr => _av_calloc_ptr ?? (_av_calloc_ptr = NativeMethodDelegate<av_calloc_delegate>());

        /// <summary>Allocate a memory block for an array with av_mallocz().</summary>
        /// <param name="nmemb">Number of elements</param>
        /// <param name="size">Size of the single element</param>
        /// <returns>Pointer to the allocated block, or `NULL` if the block cannot be allocated</returns>
        public void* av_calloc(ulong @nmemb, ulong @size)
        {
            return av_calloc_ptr(@nmemb, @size);
        }

        private av_channel_layout_extract_channel_delegate? _av_channel_layout_extract_channel_ptr;

        public av_channel_layout_extract_channel_delegate av_channel_layout_extract_channel_ptr => _av_channel_layout_extract_channel_ptr ?? (_av_channel_layout_extract_channel_ptr = NativeMethodDelegate<av_channel_layout_extract_channel_delegate>());

        /// <summary>Get the channel with the given index in channel_layout.</summary>
        public ulong av_channel_layout_extract_channel(ulong @channel_layout, int @index)
        {
            return av_channel_layout_extract_channel_ptr(@channel_layout, @index);
        }

        private av_chroma_location_from_name_delegate? _av_chroma_location_from_name_ptr;

        public av_chroma_location_from_name_delegate av_chroma_location_from_name_ptr => _av_chroma_location_from_name_ptr ?? (_av_chroma_location_from_name_ptr = NativeMethodDelegate<av_chroma_location_from_name_delegate>());

        /// <summary>Returns the AVChromaLocation value for name or an AVError if not found.</summary>
        /// <returns>the AVChromaLocation value for name or an AVError if not found.</returns>
        public int av_chroma_location_from_name(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return av_chroma_location_from_name_ptr(@name);
        }

        private av_chroma_location_name_delegate? _av_chroma_location_name_ptr;

        public av_chroma_location_name_delegate av_chroma_location_name_ptr => _av_chroma_location_name_ptr ?? (_av_chroma_location_name_ptr = NativeMethodDelegate<av_chroma_location_name_delegate>());

        /// <summary>Returns the name for provided chroma location or NULL if unknown.</summary>
        /// <returns>the name for provided chroma location or NULL if unknown.</returns>
        public string av_chroma_location_name(AVChromaLocation @location)
        {
            return av_chroma_location_name_ptr(@location);
        }

        private av_color_primaries_from_name_delegate? _av_color_primaries_from_name_ptr;

        public av_color_primaries_from_name_delegate av_color_primaries_from_name_ptr => _av_color_primaries_from_name_ptr ?? (_av_color_primaries_from_name_ptr = NativeMethodDelegate<av_color_primaries_from_name_delegate>());

        /// <summary>Returns the AVColorPrimaries value for name or an AVError if not found.</summary>
        /// <returns>the AVColorPrimaries value for name or an AVError if not found.</returns>
        public int av_color_primaries_from_name(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return av_color_primaries_from_name_ptr(@name);
        }

        private av_color_primaries_name_delegate? _av_color_primaries_name_ptr;

        public av_color_primaries_name_delegate av_color_primaries_name_ptr => _av_color_primaries_name_ptr ?? (_av_color_primaries_name_ptr = NativeMethodDelegate<av_color_primaries_name_delegate>());

        /// <summary>Returns the name for provided color primaries or NULL if unknown.</summary>
        /// <returns>the name for provided color primaries or NULL if unknown.</returns>
        public string av_color_primaries_name(AVColorPrimaries @primaries)
        {
            return av_color_primaries_name_ptr(@primaries);
        }

        private av_color_range_from_name_delegate? _av_color_range_from_name_ptr;

        public av_color_range_from_name_delegate av_color_range_from_name_ptr => _av_color_range_from_name_ptr ?? (_av_color_range_from_name_ptr = NativeMethodDelegate<av_color_range_from_name_delegate>());

        /// <summary>Returns the AVColorRange value for name or an AVError if not found.</summary>
        /// <returns>the AVColorRange value for name or an AVError if not found.</returns>
        public int av_color_range_from_name(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return av_color_range_from_name_ptr(@name);
        }

        private av_color_range_name_delegate? _av_color_range_name_ptr;

        public av_color_range_name_delegate av_color_range_name_ptr => _av_color_range_name_ptr ?? (_av_color_range_name_ptr = NativeMethodDelegate<av_color_range_name_delegate>());

        /// <summary>Returns the name for provided color range or NULL if unknown.</summary>
        /// <returns>the name for provided color range or NULL if unknown.</returns>
        public string av_color_range_name(AVColorRange @range)
        {
            return av_color_range_name_ptr(@range);
        }

        private av_color_space_from_name_delegate? _av_color_space_from_name_ptr;

        public av_color_space_from_name_delegate av_color_space_from_name_ptr => _av_color_space_from_name_ptr ?? (_av_color_space_from_name_ptr = NativeMethodDelegate<av_color_space_from_name_delegate>());

        /// <summary>Returns the AVColorSpace value for name or an AVError if not found.</summary>
        /// <returns>the AVColorSpace value for name or an AVError if not found.</returns>
        public int av_color_space_from_name(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return av_color_space_from_name_ptr(@name);
        }

        private av_color_space_name_delegate? _av_color_space_name_ptr;

        public av_color_space_name_delegate av_color_space_name_ptr => _av_color_space_name_ptr ?? (_av_color_space_name_ptr = NativeMethodDelegate<av_color_space_name_delegate>());

        /// <summary>Returns the name for provided color space or NULL if unknown.</summary>
        /// <returns>the name for provided color space or NULL if unknown.</returns>
        public string av_color_space_name(AVColorSpace @space)
        {
            return av_color_space_name_ptr(@space);
        }

        private av_color_transfer_from_name_delegate? _av_color_transfer_from_name_ptr;

        public av_color_transfer_from_name_delegate av_color_transfer_from_name_ptr => _av_color_transfer_from_name_ptr ?? (_av_color_transfer_from_name_ptr = NativeMethodDelegate<av_color_transfer_from_name_delegate>());

        /// <summary>Returns the AVColorTransferCharacteristic value for name or an AVError if not found.</summary>
        /// <returns>the AVColorTransferCharacteristic value for name or an AVError if not found.</returns>
        public int av_color_transfer_from_name(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return av_color_transfer_from_name_ptr(@name);
        }

        private av_color_transfer_name_delegate? _av_color_transfer_name_ptr;

        public av_color_transfer_name_delegate av_color_transfer_name_ptr => _av_color_transfer_name_ptr ?? (_av_color_transfer_name_ptr = NativeMethodDelegate<av_color_transfer_name_delegate>());

        /// <summary>Returns the name for provided color transfer or NULL if unknown.</summary>
        /// <returns>the name for provided color transfer or NULL if unknown.</returns>
        public string av_color_transfer_name(AVColorTransferCharacteristic @transfer)
        {
            return av_color_transfer_name_ptr(@transfer);
        }

        private av_compare_mod_delegate? _av_compare_mod_ptr;

        public av_compare_mod_delegate av_compare_mod_ptr => _av_compare_mod_ptr ?? (_av_compare_mod_ptr = NativeMethodDelegate<av_compare_mod_delegate>());

        /// <summary>Compare the remainders of two integer operands divided by a common divisor.</summary>
        /// <param name="mod">Divisor; must be a power of 2</param>
        /// <returns>- a negative value if `a % mod &lt; b % mod` - a positive value if `a % mod &gt; b % mod` - zero             if `a % mod == b % mod`</returns>
        public long av_compare_mod(ulong @a, ulong @b, ulong @mod)
        {
            return av_compare_mod_ptr(@a, @b, @mod);
        }

        private av_compare_ts_delegate? _av_compare_ts_ptr;

        public av_compare_ts_delegate av_compare_ts_ptr => _av_compare_ts_ptr ?? (_av_compare_ts_ptr = NativeMethodDelegate<av_compare_ts_delegate>());

        /// <summary>Compare two timestamps each in its own time base.</summary>
        /// <returns>One of the following values: - -1 if `ts_a` is before `ts_b` - 1 if `ts_a` is after `ts_b` - 0 if they represent the same position</returns>
        public int av_compare_ts(long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b)
        {
            return av_compare_ts_ptr(@ts_a, @tb_a, @ts_b, @tb_b);
        }

        private av_content_light_metadata_alloc_delegate? _av_content_light_metadata_alloc_ptr;

        public av_content_light_metadata_alloc_delegate av_content_light_metadata_alloc_ptr => _av_content_light_metadata_alloc_ptr ?? (_av_content_light_metadata_alloc_ptr = NativeMethodDelegate<av_content_light_metadata_alloc_delegate>());

        /// <summary>Allocate an AVContentLightMetadata structure and set its fields to default values. The resulting struct can be freed using av_freep().</summary>
        /// <returns>An AVContentLightMetadata filled with default values or NULL on failure.</returns>
        public AVContentLightMetadata* av_content_light_metadata_alloc(ulong* @size)
        {
            return av_content_light_metadata_alloc_ptr(@size);
        }

        private av_content_light_metadata_create_side_data_delegate? _av_content_light_metadata_create_side_data_ptr;

        public av_content_light_metadata_create_side_data_delegate av_content_light_metadata_create_side_data_ptr => _av_content_light_metadata_create_side_data_ptr ?? (_av_content_light_metadata_create_side_data_ptr = NativeMethodDelegate<av_content_light_metadata_create_side_data_delegate>());

        /// <summary>Allocate a complete AVContentLightMetadata and add it to the frame.</summary>
        /// <param name="frame">The frame which side data is added to.</param>
        /// <returns>The AVContentLightMetadata structure to be filled by caller.</returns>
        public AVContentLightMetadata* av_content_light_metadata_create_side_data(AVFrame* @frame)
        {
            return av_content_light_metadata_create_side_data_ptr(@frame);
        }

        private av_cpu_count_delegate? _av_cpu_count_ptr;

        public av_cpu_count_delegate av_cpu_count_ptr => _av_cpu_count_ptr ?? (_av_cpu_count_ptr = NativeMethodDelegate<av_cpu_count_delegate>());

        /// <summary>Returns the number of logical CPU cores present.</summary>
        /// <returns>the number of logical CPU cores present.</returns>
        public int av_cpu_count()
        {
            return av_cpu_count_ptr();
        }

        private av_cpu_force_count_delegate? _av_cpu_force_count_ptr;

        public av_cpu_force_count_delegate av_cpu_force_count_ptr => _av_cpu_force_count_ptr ?? (_av_cpu_force_count_ptr = NativeMethodDelegate<av_cpu_force_count_delegate>());

        /// <summary>Overrides cpu count detection and forces the specified count. Count &lt; 1 disables forcing of specific count.</summary>
        public void av_cpu_force_count(int @count)
        {
            av_cpu_force_count_ptr(@count);
        }

        private av_cpu_max_align_delegate? _av_cpu_max_align_ptr;

        public av_cpu_max_align_delegate av_cpu_max_align_ptr => _av_cpu_max_align_ptr ?? (_av_cpu_max_align_ptr = NativeMethodDelegate<av_cpu_max_align_delegate>());

        /// <summary>Get the maximum data alignment that may be required by FFmpeg.</summary>
        public ulong av_cpu_max_align()
        {
            return av_cpu_max_align_ptr();
        }

        private av_d2q_delegate? _av_d2q_ptr;

        public av_d2q_delegate av_d2q_ptr => _av_d2q_ptr ?? (_av_d2q_ptr = NativeMethodDelegate<av_d2q_delegate>());

        /// <summary>Convert a double precision floating point number to a rational.</summary>
        /// <param name="d">`double` to convert</param>
        /// <param name="max">Maximum allowed numerator and denominator</param>
        /// <returns>`d` in AVRational form</returns>
        public AVRational av_d2q(double @d, int @max)
        {
            return av_d2q_ptr(@d, @max);
        }

        private av_default_get_category_delegate? _av_default_get_category_ptr;

        public av_default_get_category_delegate av_default_get_category_ptr => _av_default_get_category_ptr ?? (_av_default_get_category_ptr = NativeMethodDelegate<av_default_get_category_delegate>());

        public AVClassCategory av_default_get_category(void* @ptr)
        {
            return av_default_get_category_ptr(@ptr);
        }

        private av_default_item_name_delegate? _av_default_item_name_ptr;

        public av_default_item_name_delegate av_default_item_name_ptr => _av_default_item_name_ptr ?? (_av_default_item_name_ptr = NativeMethodDelegate<av_default_item_name_delegate>());

        /// <summary>Return the context name</summary>
        /// <param name="ctx">The AVClass context</param>
        /// <returns>The AVClass class_name</returns>
        public string av_default_item_name(void* @ctx)
        {
            return av_default_item_name_ptr(@ctx);
        }

        private av_dict_copy_delegate? _av_dict_copy_ptr;

        public av_dict_copy_delegate av_dict_copy_ptr => _av_dict_copy_ptr ?? (_av_dict_copy_ptr = NativeMethodDelegate<av_dict_copy_delegate>());

        /// <summary>Copy entries from one AVDictionary struct into another.</summary>
        /// <param name="dst">pointer to a pointer to a AVDictionary struct. If *dst is NULL, this function will allocate a struct for you and put it in *dst</param>
        /// <param name="src">pointer to source AVDictionary struct</param>
        /// <param name="flags">flags to use when setting entries in *dst</param>
        /// <returns>0 on success, negative AVERROR code on failure. If dst was allocated by this function, callers should free the associated memory.</returns>
        public int av_dict_copy(AVDictionary** @dst, AVDictionary* @src, int @flags)
        {
            return av_dict_copy_ptr(@dst, @src, @flags);
        }

        private av_dict_count_delegate? _av_dict_count_ptr;

        public av_dict_count_delegate av_dict_count_ptr => _av_dict_count_ptr ?? (_av_dict_count_ptr = NativeMethodDelegate<av_dict_count_delegate>());

        /// <summary>Get number of entries in dictionary.</summary>
        /// <param name="m">dictionary</param>
        /// <returns>number of entries in dictionary</returns>
        public int av_dict_count(AVDictionary* @m)
        {
            return av_dict_count_ptr(@m);
        }

        private av_dict_free_delegate? _av_dict_free_ptr;

        public av_dict_free_delegate av_dict_free_ptr => _av_dict_free_ptr ?? (_av_dict_free_ptr = NativeMethodDelegate<av_dict_free_delegate>());

        /// <summary>Free all the memory allocated for an AVDictionary struct and all keys and values.</summary>
        public void av_dict_free(AVDictionary** @m)
        {
            av_dict_free_ptr(@m);
        }

        private av_dict_get_delegate? _av_dict_get_ptr;

        public av_dict_get_delegate av_dict_get_ptr => _av_dict_get_ptr ?? (_av_dict_get_ptr = NativeMethodDelegate<av_dict_get_delegate>());

        /// <summary>Get a dictionary entry with matching key.</summary>
        /// <param name="key">matching key</param>
        /// <param name="prev">Set to the previous matching element to find the next. If set to NULL the first matching element is returned.</param>
        /// <param name="flags">a collection of AV_DICT_* flags controlling how the entry is retrieved</param>
        /// <returns>found entry or NULL in case no matching entry was found in the dictionary</returns>
        public AVDictionaryEntry* av_dict_get(AVDictionary* @m,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, AVDictionaryEntry* @prev, int @flags)
        {
            return av_dict_get_ptr(@m, @key, @prev, @flags);
        }

        private av_dict_get_string_delegate? _av_dict_get_string_ptr;

        public av_dict_get_string_delegate av_dict_get_string_ptr => _av_dict_get_string_ptr ?? (_av_dict_get_string_ptr = NativeMethodDelegate<av_dict_get_string_delegate>());

        /// <summary>Get dictionary entries as a string.</summary>
        /// <param name="m">dictionary</param>
        /// <param name="buffer">Pointer to buffer that will be allocated with string containg entries. Buffer must be freed by the caller when is no longer needed.</param>
        /// <param name="key_val_sep">character used to separate key from value</param>
        /// <param name="pairs_sep">character used to separate two pairs from each other</param>
        /// <returns>&gt;= 0 on success, negative on error</returns>
        public int av_dict_get_string(AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep)
        {
            return av_dict_get_string_ptr(@m, @buffer, @key_val_sep, @pairs_sep);
        }

        private av_dict_parse_string_delegate? _av_dict_parse_string_ptr;

        public av_dict_parse_string_delegate av_dict_parse_string_ptr => _av_dict_parse_string_ptr ?? (_av_dict_parse_string_ptr = NativeMethodDelegate<av_dict_parse_string_delegate>());

        /// <summary>Parse the key/value pairs list and add the parsed entries to a dictionary.</summary>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other</param>
        /// <param name="flags">flags to use when adding to dictionary. AV_DICT_DONT_STRDUP_KEY and AV_DICT_DONT_STRDUP_VAL are ignored since the key/value tokens will always be duplicated.</param>
        /// <returns>0 on success, negative AVERROR code on failure</returns>
        public int av_dict_parse_string(AVDictionary** @pm,
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
    string @pairs_sep, int @flags)
        {
            return av_dict_parse_string_ptr(@pm, @str, @key_val_sep, @pairs_sep, @flags);
        }

        private av_dict_set_delegate? _av_dict_set_ptr;

        public av_dict_set_delegate av_dict_set_ptr => _av_dict_set_ptr ?? (_av_dict_set_ptr = NativeMethodDelegate<av_dict_set_delegate>());

        /// <summary>Set the given entry in *pm, overwriting an existing entry.</summary>
        /// <param name="pm">pointer to a pointer to a dictionary struct. If *pm is NULL a dictionary struct is allocated and put in *pm.</param>
        /// <param name="key">entry key to add to *pm (will either be av_strduped or added as a new key depending on flags)</param>
        /// <param name="value">entry value to add to *pm (will be av_strduped or added as a new key depending on flags). Passing a NULL value will cause an existing entry to be deleted.</param>
        /// <returns>&gt;= 0 on success otherwise an error code &lt; 0</returns>
        public int av_dict_set(AVDictionary** @pm,
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
    string @value, int @flags)
        {
            return av_dict_set_ptr(@pm, @key, @value, @flags);
        }

        private av_dict_set_int_delegate? _av_dict_set_int_ptr;

        public av_dict_set_int_delegate av_dict_set_int_ptr => _av_dict_set_int_ptr ?? (_av_dict_set_int_ptr = NativeMethodDelegate<av_dict_set_int_delegate>());

        /// <summary>Convenience wrapper for av_dict_set that converts the value to a string and stores it.</summary>
        public int av_dict_set_int(AVDictionary** @pm,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, long @value, int @flags)
        {
            return av_dict_set_int_ptr(@pm, @key, @value, @flags);
        }

        private av_div_q_delegate? _av_div_q_ptr;

        public av_div_q_delegate av_div_q_ptr => _av_div_q_ptr ?? (_av_div_q_ptr = NativeMethodDelegate<av_div_q_delegate>());

        /// <summary>Divide one rational by another.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        /// <returns>b/c</returns>
        public AVRational av_div_q(AVRational @b, AVRational @c)
        {
            return av_div_q_ptr(@b, @c);
        }

        private av_dynamic_hdr_plus_alloc_delegate? _av_dynamic_hdr_plus_alloc_ptr;

        public av_dynamic_hdr_plus_alloc_delegate av_dynamic_hdr_plus_alloc_ptr => _av_dynamic_hdr_plus_alloc_ptr ?? (_av_dynamic_hdr_plus_alloc_ptr = NativeMethodDelegate<av_dynamic_hdr_plus_alloc_delegate>());

        /// <summary>Allocate an AVDynamicHDRPlus structure and set its fields to default values. The resulting struct can be freed using av_freep().</summary>
        /// <returns>An AVDynamicHDRPlus filled with default values or NULL on failure.</returns>
        public AVDynamicHDRPlus* av_dynamic_hdr_plus_alloc(ulong* @size)
        {
            return av_dynamic_hdr_plus_alloc_ptr(@size);
        }

        private av_dynamic_hdr_plus_create_side_data_delegate? _av_dynamic_hdr_plus_create_side_data_ptr;

        public av_dynamic_hdr_plus_create_side_data_delegate av_dynamic_hdr_plus_create_side_data_ptr => _av_dynamic_hdr_plus_create_side_data_ptr ?? (_av_dynamic_hdr_plus_create_side_data_ptr = NativeMethodDelegate<av_dynamic_hdr_plus_create_side_data_delegate>());

        /// <summary>Allocate a complete AVDynamicHDRPlus and add it to the frame.</summary>
        /// <param name="frame">The frame which side data is added to.</param>
        /// <returns>The AVDynamicHDRPlus structure to be filled by caller or NULL on failure.</returns>
        public AVDynamicHDRPlus* av_dynamic_hdr_plus_create_side_data(AVFrame* @frame)
        {
            return av_dynamic_hdr_plus_create_side_data_ptr(@frame);
        }

        private av_dynarray_add_delegate? _av_dynarray_add_ptr;

        public av_dynarray_add_delegate av_dynarray_add_ptr => _av_dynarray_add_ptr ?? (_av_dynarray_add_ptr = NativeMethodDelegate<av_dynarray_add_delegate>());

        /// <summary>Add the pointer to an element to a dynamic array.</summary>
        /// <param name="tab_ptr">Pointer to the array to grow</param>
        /// <param name="nb_ptr">Pointer to the number of elements in the array</param>
        /// <param name="elem">Element to add</param>
        public void av_dynarray_add(void* @tab_ptr, int* @nb_ptr, void* @elem)
        {
            av_dynarray_add_ptr(@tab_ptr, @nb_ptr, @elem);
        }

        private av_dynarray_add_nofree_delegate? _av_dynarray_add_nofree_ptr;

        public av_dynarray_add_nofree_delegate av_dynarray_add_nofree_ptr => _av_dynarray_add_nofree_ptr ?? (_av_dynarray_add_nofree_ptr = NativeMethodDelegate<av_dynarray_add_nofree_delegate>());

        /// <summary>Add an element to a dynamic array.</summary>
        /// <returns>&gt;=0 on success, negative otherwise</returns>
        public int av_dynarray_add_nofree(void* @tab_ptr, int* @nb_ptr, void* @elem)
        {
            return av_dynarray_add_nofree_ptr(@tab_ptr, @nb_ptr, @elem);
        }

        private av_dynarray2_add_delegate? _av_dynarray2_add_ptr;

        public av_dynarray2_add_delegate av_dynarray2_add_ptr => _av_dynarray2_add_ptr ?? (_av_dynarray2_add_ptr = NativeMethodDelegate<av_dynarray2_add_delegate>());

        /// <summary>Add an element of size `elem_size` to a dynamic array.</summary>
        /// <param name="tab_ptr">Pointer to the array to grow</param>
        /// <param name="nb_ptr">Pointer to the number of elements in the array</param>
        /// <param name="elem_size">Size in bytes of an element in the array</param>
        /// <param name="elem_data">Pointer to the data of the element to add. If `NULL`, the space of the newly added element is allocated but left uninitialized.</param>
        /// <returns>Pointer to the data of the element to copy in the newly allocated space</returns>
        public void* av_dynarray2_add(void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data)
        {
            return av_dynarray2_add_ptr(@tab_ptr, @nb_ptr, @elem_size, @elem_data);
        }

        private av_fast_malloc_delegate? _av_fast_malloc_ptr;

        public av_fast_malloc_delegate av_fast_malloc_ptr => _av_fast_malloc_ptr ?? (_av_fast_malloc_ptr = NativeMethodDelegate<av_fast_malloc_delegate>());

        /// <summary>Allocate a buffer, reusing the given one if large enough.</summary>
        /// <param name="ptr">Pointer to pointer to an already allocated buffer. `*ptr` will be overwritten with pointer to new buffer on success or `NULL` on failure</param>
        /// <param name="size">Pointer to the size of buffer `*ptr`. `*size` is updated to the new allocated size, in particular 0 in case of failure.</param>
        /// <param name="min_size">Desired minimal size of buffer `*ptr`</param>
        public void av_fast_malloc(void* @ptr, uint* @size, ulong @min_size)
        {
            av_fast_malloc_ptr(@ptr, @size, @min_size);
        }

        private av_fast_mallocz_delegate? _av_fast_mallocz_ptr;

        public av_fast_mallocz_delegate av_fast_mallocz_ptr => _av_fast_mallocz_ptr ?? (_av_fast_mallocz_ptr = NativeMethodDelegate<av_fast_mallocz_delegate>());

        /// <summary>Allocate and clear a buffer, reusing the given one if large enough.</summary>
        /// <param name="ptr">Pointer to pointer to an already allocated buffer. `*ptr` will be overwritten with pointer to new buffer on success or `NULL` on failure</param>
        /// <param name="size">Pointer to the size of buffer `*ptr`. `*size` is updated to the new allocated size, in particular 0 in case of failure.</param>
        /// <param name="min_size">Desired minimal size of buffer `*ptr`</param>
        public void av_fast_mallocz(void* @ptr, uint* @size, ulong @min_size)
        {
            av_fast_mallocz_ptr(@ptr, @size, @min_size);
        }

        private av_fast_realloc_delegate? _av_fast_realloc_ptr;

        public av_fast_realloc_delegate av_fast_realloc_ptr => _av_fast_realloc_ptr ?? (_av_fast_realloc_ptr = NativeMethodDelegate<av_fast_realloc_delegate>());

        /// <summary>Reallocate the given buffer if it is not large enough, otherwise do nothing.</summary>
        /// <param name="ptr">Already allocated buffer, or `NULL`</param>
        /// <param name="size">Pointer to the size of buffer `ptr`. `*size` is updated to the new allocated size, in particular 0 in case of failure.</param>
        /// <param name="min_size">Desired minimal size of buffer `ptr`</param>
        /// <returns>`ptr` if the buffer is large enough, a pointer to newly reallocated buffer if the buffer was not large enough, or `NULL` in case of error</returns>
        public void* av_fast_realloc(void* @ptr, uint* @size, ulong @min_size)
        {
            return av_fast_realloc_ptr(@ptr, @size, @min_size);
        }

        private av_fifo_alloc_delegate? _av_fifo_alloc_ptr;

        public av_fifo_alloc_delegate av_fifo_alloc_ptr => _av_fifo_alloc_ptr ?? (_av_fifo_alloc_ptr = NativeMethodDelegate<av_fifo_alloc_delegate>());

        /// <summary>Initialize an AVFifoBuffer.</summary>
        /// <param name="size">of FIFO</param>
        /// <returns>AVFifoBuffer or NULL in case of memory allocation failure</returns>
        public AVFifoBuffer* av_fifo_alloc(uint @size)
        {
            return av_fifo_alloc_ptr(@size);
        }

        private av_fifo_alloc_array_delegate? _av_fifo_alloc_array_ptr;

        public av_fifo_alloc_array_delegate av_fifo_alloc_array_ptr => _av_fifo_alloc_array_ptr ?? (_av_fifo_alloc_array_ptr = NativeMethodDelegate<av_fifo_alloc_array_delegate>());

        /// <summary>Initialize an AVFifoBuffer.</summary>
        /// <param name="nmemb">number of elements</param>
        /// <param name="size">size of the single element</param>
        /// <returns>AVFifoBuffer or NULL in case of memory allocation failure</returns>
        public AVFifoBuffer* av_fifo_alloc_array(ulong @nmemb, ulong @size)
        {
            return av_fifo_alloc_array_ptr(@nmemb, @size);
        }

        private av_fifo_drain_delegate? _av_fifo_drain_ptr;

        public av_fifo_drain_delegate av_fifo_drain_ptr => _av_fifo_drain_ptr ?? (_av_fifo_drain_ptr = NativeMethodDelegate<av_fifo_drain_delegate>());

        /// <summary>Read and discard the specified amount of data from an AVFifoBuffer.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="size">amount of data to read in bytes</param>
        public void av_fifo_drain(AVFifoBuffer* @f, int @size)
        {
            av_fifo_drain_ptr(@f, @size);
        }

        private av_fifo_free_delegate? _av_fifo_free_ptr;

        public av_fifo_free_delegate av_fifo_free_ptr => _av_fifo_free_ptr ?? (_av_fifo_free_ptr = NativeMethodDelegate<av_fifo_free_delegate>());

        /// <summary>Free an AVFifoBuffer.</summary>
        /// <param name="f">AVFifoBuffer to free</param>
        public void av_fifo_free(AVFifoBuffer* @f)
        {
            av_fifo_free_ptr(@f);
        }

        private av_fifo_freep_delegate? _av_fifo_freep_ptr;

        public av_fifo_freep_delegate av_fifo_freep_ptr => _av_fifo_freep_ptr ?? (_av_fifo_freep_ptr = NativeMethodDelegate<av_fifo_freep_delegate>());

        /// <summary>Free an AVFifoBuffer and reset pointer to NULL.</summary>
        /// <param name="f">AVFifoBuffer to free</param>
        public void av_fifo_freep(AVFifoBuffer** @f)
        {
            av_fifo_freep_ptr(@f);
        }

        private av_fifo_generic_peek_delegate? _av_fifo_generic_peek_ptr;

        public av_fifo_generic_peek_delegate av_fifo_generic_peek_ptr => _av_fifo_generic_peek_ptr ?? (_av_fifo_generic_peek_ptr = NativeMethodDelegate<av_fifo_generic_peek_delegate>());

        /// <summary>Feed data from an AVFifoBuffer to a user-supplied callback. Similar as av_fifo_gereric_read but without discarding data.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="dest">data destination</param>
        /// <param name="buf_size">number of bytes to read</param>
        /// <param name="func">generic read function</param>
        public int av_fifo_generic_peek(AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_peek_func_func @func)
        {
            return av_fifo_generic_peek_ptr(@f, @dest, @buf_size, @func);
        }

        private av_fifo_generic_peek_at_delegate? _av_fifo_generic_peek_at_ptr;

        public av_fifo_generic_peek_at_delegate av_fifo_generic_peek_at_ptr => _av_fifo_generic_peek_at_ptr ?? (_av_fifo_generic_peek_at_ptr = NativeMethodDelegate<av_fifo_generic_peek_at_delegate>());

        /// <summary>Feed data at specific position from an AVFifoBuffer to a user-supplied callback. Similar as av_fifo_gereric_read but without discarding data.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="dest">data destination</param>
        /// <param name="offset">offset from current read position</param>
        /// <param name="buf_size">number of bytes to read</param>
        /// <param name="func">generic read function</param>
        public int av_fifo_generic_peek_at(AVFifoBuffer* @f, void* @dest, int @offset, int @buf_size, av_fifo_generic_peek_at_func_func @func)
        {
            return av_fifo_generic_peek_at_ptr(@f, @dest, @offset, @buf_size, @func);
        }

        private av_fifo_generic_read_delegate? _av_fifo_generic_read_ptr;

        public av_fifo_generic_read_delegate av_fifo_generic_read_ptr => _av_fifo_generic_read_ptr ?? (_av_fifo_generic_read_ptr = NativeMethodDelegate<av_fifo_generic_read_delegate>());

        /// <summary>Feed data from an AVFifoBuffer to a user-supplied callback.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="dest">data destination</param>
        /// <param name="buf_size">number of bytes to read</param>
        /// <param name="func">generic read function</param>
        public int av_fifo_generic_read(AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_read_func_func @func)
        {
            return av_fifo_generic_read_ptr(@f, @dest, @buf_size, @func);
        }

        private av_fifo_generic_write_delegate? _av_fifo_generic_write_ptr;

        public av_fifo_generic_write_delegate av_fifo_generic_write_ptr => _av_fifo_generic_write_ptr ?? (_av_fifo_generic_write_ptr = NativeMethodDelegate<av_fifo_generic_write_delegate>());

        /// <summary>Feed data from a user-supplied callback to an AVFifoBuffer.</summary>
        /// <param name="f">AVFifoBuffer to write to</param>
        /// <param name="src">data source; non-const since it may be used as a modifiable context by the function defined in func</param>
        /// <param name="size">number of bytes to write</param>
        /// <param name="func">generic write function; the first parameter is src, the second is dest_buf, the third is dest_buf_size. func must return the number of bytes written to dest_buf, or &lt; = 0 to indicate no more data available to write. If func is NULL, src is interpreted as a simple byte array for source data.</param>
        /// <returns>the number of bytes written to the FIFO</returns>
        public int av_fifo_generic_write(AVFifoBuffer* @f, void* @src, int @size, av_fifo_generic_write_func_func @func)
        {
            return av_fifo_generic_write_ptr(@f, @src, @size, @func);
        }

        private av_fifo_grow_delegate? _av_fifo_grow_ptr;

        public av_fifo_grow_delegate av_fifo_grow_ptr => _av_fifo_grow_ptr ?? (_av_fifo_grow_ptr = NativeMethodDelegate<av_fifo_grow_delegate>());

        /// <summary>Enlarge an AVFifoBuffer. In case of reallocation failure, the old FIFO is kept unchanged. The new fifo size may be larger than the requested size.</summary>
        /// <param name="f">AVFifoBuffer to resize</param>
        /// <param name="additional_space">the amount of space in bytes to allocate in addition to av_fifo_size()</param>
        /// <returns>&lt; 0 for failure, &gt;=0 otherwise</returns>
        public int av_fifo_grow(AVFifoBuffer* @f, uint @additional_space)
        {
            return av_fifo_grow_ptr(@f, @additional_space);
        }

        private av_fifo_realloc2_delegate? _av_fifo_realloc2_ptr;

        public av_fifo_realloc2_delegate av_fifo_realloc2_ptr => _av_fifo_realloc2_ptr ?? (_av_fifo_realloc2_ptr = NativeMethodDelegate<av_fifo_realloc2_delegate>());

        /// <summary>Resize an AVFifoBuffer. In case of reallocation failure, the old FIFO is kept unchanged.</summary>
        /// <param name="f">AVFifoBuffer to resize</param>
        /// <param name="size">new AVFifoBuffer size in bytes</param>
        /// <returns>&lt; 0 for failure, &gt;=0 otherwise</returns>
        public int av_fifo_realloc2(AVFifoBuffer* @f, uint @size)
        {
            return av_fifo_realloc2_ptr(@f, @size);
        }

        private av_fifo_reset_delegate? _av_fifo_reset_ptr;

        public av_fifo_reset_delegate av_fifo_reset_ptr => _av_fifo_reset_ptr ?? (_av_fifo_reset_ptr = NativeMethodDelegate<av_fifo_reset_delegate>());

        /// <summary>Reset the AVFifoBuffer to the state right after av_fifo_alloc, in particular it is emptied.</summary>
        /// <param name="f">AVFifoBuffer to reset</param>
        public void av_fifo_reset(AVFifoBuffer* @f)
        {
            av_fifo_reset_ptr(@f);
        }

        private av_fifo_size_delegate? _av_fifo_size_ptr;

        public av_fifo_size_delegate av_fifo_size_ptr => _av_fifo_size_ptr ?? (_av_fifo_size_ptr = NativeMethodDelegate<av_fifo_size_delegate>());

        /// <summary>Return the amount of data in bytes in the AVFifoBuffer, that is the amount of data you can read from it.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <returns>size</returns>
        public int av_fifo_size(AVFifoBuffer* @f)
        {
            return av_fifo_size_ptr(@f);
        }

        private av_fifo_space_delegate? _av_fifo_space_ptr;

        public av_fifo_space_delegate av_fifo_space_ptr => _av_fifo_space_ptr ?? (_av_fifo_space_ptr = NativeMethodDelegate<av_fifo_space_delegate>());

        /// <summary>Return the amount of space in bytes in the AVFifoBuffer, that is the amount of data you can write into it.</summary>
        /// <param name="f">AVFifoBuffer to write into</param>
        /// <returns>size</returns>
        public int av_fifo_space(AVFifoBuffer* @f)
        {
            return av_fifo_space_ptr(@f);
        }

        private av_file_map_delegate? _av_file_map_ptr;

        public av_file_map_delegate av_file_map_ptr => _av_file_map_ptr ?? (_av_file_map_ptr = NativeMethodDelegate<av_file_map_delegate>());

        /// <summary>Read the file with name filename, and put its content in a newly allocated buffer or map it with mmap() when available. In case of success set *bufptr to the read or mmapped buffer, and *size to the size in bytes of the buffer in *bufptr. Unlike mmap this function succeeds with zero sized files, in this case *bufptr will be set to NULL and *size will be set to 0. The returned buffer must be released with av_file_unmap().</summary>
        /// <param name="log_offset">loglevel offset used for logging</param>
        /// <param name="log_ctx">context used for logging</param>
        /// <returns>a non negative number in case of success, a negative value corresponding to an AVERROR error code in case of failure</returns>
        public int av_file_map(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @filename, byte** @bufptr, ulong* @size, int @log_offset, void* @log_ctx)
        {
            return av_file_map_ptr(@filename, @bufptr, @size, @log_offset, @log_ctx);
        }

        private av_file_unmap_delegate? _av_file_unmap_ptr;

        public av_file_unmap_delegate av_file_unmap_ptr => _av_file_unmap_ptr ?? (_av_file_unmap_ptr = NativeMethodDelegate<av_file_unmap_delegate>());

        /// <summary>Unmap or free the buffer bufptr created by av_file_map().</summary>
        /// <param name="size">size in bytes of bufptr, must be the same as returned by av_file_map()</param>
        public void av_file_unmap(byte* @bufptr, ulong @size)
        {
            av_file_unmap_ptr(@bufptr, @size);
        }

        private av_find_best_pix_fmt_of_2_delegate? _av_find_best_pix_fmt_of_2_ptr;

        public av_find_best_pix_fmt_of_2_delegate av_find_best_pix_fmt_of_2_ptr => _av_find_best_pix_fmt_of_2_ptr ?? (_av_find_best_pix_fmt_of_2_ptr = NativeMethodDelegate<av_find_best_pix_fmt_of_2_delegate>());

        /// <summary>Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another.</summary>
        /// <param name="src_pix_fmt">source pixel format</param>
        /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
        /// <returns>Combination of flags informing you what kind of losses will occur (maximum loss for an invalid dst_pix_fmt).</returns>
        public AVPixelFormat av_find_best_pix_fmt_of_2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr)
        {
            return av_find_best_pix_fmt_of_2_ptr(@dst_pix_fmt1, @dst_pix_fmt2, @src_pix_fmt, @has_alpha, @loss_ptr);
        }

        private av_find_nearest_q_idx_delegate? _av_find_nearest_q_idx_ptr;

        public av_find_nearest_q_idx_delegate av_find_nearest_q_idx_ptr => _av_find_nearest_q_idx_ptr ?? (_av_find_nearest_q_idx_ptr = NativeMethodDelegate<av_find_nearest_q_idx_delegate>());

        /// <summary>Find the value in a list of rationals nearest a given reference rational.</summary>
        /// <param name="q">Reference rational</param>
        /// <param name="q_list">Array of rationals terminated by `{0, 0}`</param>
        /// <returns>Index of the nearest value found in the array</returns>
        public int av_find_nearest_q_idx(AVRational @q, AVRational* @q_list)
        {
            return av_find_nearest_q_idx_ptr(@q, @q_list);
        }

        private av_fopen_utf8_delegate? _av_fopen_utf8_ptr;

        public av_fopen_utf8_delegate av_fopen_utf8_ptr => _av_fopen_utf8_ptr ?? (_av_fopen_utf8_ptr = NativeMethodDelegate<av_fopen_utf8_delegate>());

        /// <summary>Open a file using a UTF-8 filename. The API of this function matches POSIX fopen(), errors are returned through errno.</summary>
        public _iobuf* av_fopen_utf8(
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
    string @mode)
        {
            return av_fopen_utf8_ptr(@path, @mode);
        }

        private av_force_cpu_flags_delegate? _av_force_cpu_flags_ptr;

        public av_force_cpu_flags_delegate av_force_cpu_flags_ptr => _av_force_cpu_flags_ptr ?? (_av_force_cpu_flags_ptr = NativeMethodDelegate<av_force_cpu_flags_delegate>());

        /// <summary>Disables cpu detection and forces the specified flags. -1 is a special case that disables forcing of specific flags.</summary>
        public void av_force_cpu_flags(int @flags)
        {
            av_force_cpu_flags_ptr(@flags);
        }

        private av_fourcc_make_string_delegate? _av_fourcc_make_string_ptr;

        public av_fourcc_make_string_delegate av_fourcc_make_string_ptr => _av_fourcc_make_string_ptr ?? (_av_fourcc_make_string_ptr = NativeMethodDelegate<av_fourcc_make_string_delegate>());

        /// <summary>Fill the provided buffer with a string containing a FourCC (four-character code) representation.</summary>
        /// <param name="buf">a buffer with size in bytes of at least AV_FOURCC_MAX_STRING_SIZE</param>
        /// <param name="fourcc">the fourcc to represent</param>
        /// <returns>the buffer in input</returns>
        public byte* av_fourcc_make_string(byte* @buf, uint @fourcc)
        {
            return av_fourcc_make_string_ptr(@buf, @fourcc);
        }

        private av_frame_alloc_delegate? _av_frame_alloc_ptr;

        public av_frame_alloc_delegate av_frame_alloc_ptr => _av_frame_alloc_ptr ?? (_av_frame_alloc_ptr = NativeMethodDelegate<av_frame_alloc_delegate>());

        /// <summary>Allocate an AVFrame and set its fields to default values. The resulting struct must be freed using av_frame_free().</summary>
        /// <returns>An AVFrame filled with default values or NULL on failure.</returns>
        public AVFrame* av_frame_alloc()
        {
            return av_frame_alloc_ptr();
        }

        private av_frame_apply_cropping_delegate? _av_frame_apply_cropping_ptr;

        public av_frame_apply_cropping_delegate av_frame_apply_cropping_ptr => _av_frame_apply_cropping_ptr ?? (_av_frame_apply_cropping_ptr = NativeMethodDelegate<av_frame_apply_cropping_delegate>());

        /// <summary>Crop the given video AVFrame according to its crop_left/crop_top/crop_right/ crop_bottom fields. If cropping is successful, the function will adjust the data pointers and the width/height fields, and set the crop fields to 0.</summary>
        /// <param name="frame">the frame which should be cropped</param>
        /// <param name="flags">Some combination of AV_FRAME_CROP_* flags, or 0.</param>
        /// <returns>&gt;= 0 on success, a negative AVERROR on error. If the cropping fields were invalid, AVERROR(ERANGE) is returned, and nothing is changed.</returns>
        public int av_frame_apply_cropping(AVFrame* @frame, int @flags)
        {
            return av_frame_apply_cropping_ptr(@frame, @flags);
        }

        private av_frame_clone_delegate? _av_frame_clone_ptr;

        public av_frame_clone_delegate av_frame_clone_ptr => _av_frame_clone_ptr ?? (_av_frame_clone_ptr = NativeMethodDelegate<av_frame_clone_delegate>());

        /// <summary>Create a new frame that references the same data as src.</summary>
        /// <returns>newly created AVFrame on success, NULL on error.</returns>
        public AVFrame* av_frame_clone(AVFrame* @src)
        {
            return av_frame_clone_ptr(@src);
        }

        private av_frame_copy_delegate? _av_frame_copy_ptr;

        public av_frame_copy_delegate av_frame_copy_ptr => _av_frame_copy_ptr ?? (_av_frame_copy_ptr = NativeMethodDelegate<av_frame_copy_delegate>());

        /// <summary>Copy the frame data from src to dst.</summary>
        /// <returns>&gt;= 0 on success, a negative AVERROR on error.</returns>
        public int av_frame_copy(AVFrame* @dst, AVFrame* @src)
        {
            return av_frame_copy_ptr(@dst, @src);
        }

        private av_frame_copy_props_delegate? _av_frame_copy_props_ptr;

        public av_frame_copy_props_delegate av_frame_copy_props_ptr => _av_frame_copy_props_ptr ?? (_av_frame_copy_props_ptr = NativeMethodDelegate<av_frame_copy_props_delegate>());

        /// <summary>Copy only &quot;metadata&quot; fields from src to dst.</summary>
        public int av_frame_copy_props(AVFrame* @dst, AVFrame* @src)
        {
            return av_frame_copy_props_ptr(@dst, @src);
        }

        private av_frame_free_delegate? _av_frame_free_ptr;

        public av_frame_free_delegate av_frame_free_ptr => _av_frame_free_ptr ?? (_av_frame_free_ptr = NativeMethodDelegate<av_frame_free_delegate>());

        /// <summary>Free the frame and any dynamically allocated objects in it, e.g. extended_data. If the frame is reference counted, it will be unreferenced first.</summary>
        /// <param name="frame">frame to be freed. The pointer will be set to NULL.</param>
        public void av_frame_free(AVFrame** @frame)
        {
            av_frame_free_ptr(@frame);
        }

        private av_frame_get_buffer_delegate? _av_frame_get_buffer_ptr;

        public av_frame_get_buffer_delegate av_frame_get_buffer_ptr => _av_frame_get_buffer_ptr ?? (_av_frame_get_buffer_ptr = NativeMethodDelegate<av_frame_get_buffer_delegate>());

        /// <summary>Allocate new buffer(s) for audio or video data.</summary>
        /// <param name="frame">frame in which to store the new buffers.</param>
        /// <param name="align">Required buffer size alignment. If equal to 0, alignment will be chosen automatically for the current CPU. It is highly recommended to pass 0 here unless you know what you are doing.</param>
        /// <returns>0 on success, a negative AVERROR on error.</returns>
        public int av_frame_get_buffer(AVFrame* @frame, int @align)
        {
            return av_frame_get_buffer_ptr(@frame, @align);
        }

        private av_frame_get_plane_buffer_delegate? _av_frame_get_plane_buffer_ptr;

        public av_frame_get_plane_buffer_delegate av_frame_get_plane_buffer_ptr => _av_frame_get_plane_buffer_ptr ?? (_av_frame_get_plane_buffer_ptr = NativeMethodDelegate<av_frame_get_plane_buffer_delegate>());

        /// <summary>Get the buffer reference a given data plane is stored in.</summary>
        /// <param name="plane">index of the data plane of interest in frame-&gt;extended_data.</param>
        /// <returns>the buffer reference that contains the plane or NULL if the input frame is not valid.</returns>
        public AVBufferRef* av_frame_get_plane_buffer(AVFrame* @frame, int @plane)
        {
            return av_frame_get_plane_buffer_ptr(@frame, @plane);
        }

        private av_frame_get_side_data_delegate? _av_frame_get_side_data_ptr;

        public av_frame_get_side_data_delegate av_frame_get_side_data_ptr => _av_frame_get_side_data_ptr ?? (_av_frame_get_side_data_ptr = NativeMethodDelegate<av_frame_get_side_data_delegate>());

        /// <summary>Returns a pointer to the side data of a given type on success, NULL if there is no side data with such type in this frame.</summary>
        /// <returns>a pointer to the side data of a given type on success, NULL if there is no side data with such type in this frame.</returns>
        public AVFrameSideData* av_frame_get_side_data(AVFrame* @frame, AVFrameSideDataType @type)
        {
            return av_frame_get_side_data_ptr(@frame, @type);
        }

        private av_frame_is_writable_delegate? _av_frame_is_writable_ptr;

        public av_frame_is_writable_delegate av_frame_is_writable_ptr => _av_frame_is_writable_ptr ?? (_av_frame_is_writable_ptr = NativeMethodDelegate<av_frame_is_writable_delegate>());

        /// <summary>Check if the frame data is writable.</summary>
        /// <returns>A positive value if the frame data is writable (which is true if and only if each of the underlying buffers has only one reference, namely the one stored in this frame). Return 0 otherwise.</returns>
        public int av_frame_is_writable(AVFrame* @frame)
        {
            return av_frame_is_writable_ptr(@frame);
        }

        private av_frame_make_writable_delegate? _av_frame_make_writable_ptr;

        public av_frame_make_writable_delegate av_frame_make_writable_ptr => _av_frame_make_writable_ptr ?? (_av_frame_make_writable_ptr = NativeMethodDelegate<av_frame_make_writable_delegate>());

        /// <summary>Ensure that the frame data is writable, avoiding data copy if possible.</summary>
        /// <returns>0 on success, a negative AVERROR on error.</returns>
        public int av_frame_make_writable(AVFrame* @frame)
        {
            return av_frame_make_writable_ptr(@frame);
        }

        private av_frame_move_ref_delegate? _av_frame_move_ref_ptr;

        public av_frame_move_ref_delegate av_frame_move_ref_ptr => _av_frame_move_ref_ptr ?? (_av_frame_move_ref_ptr = NativeMethodDelegate<av_frame_move_ref_delegate>());

        /// <summary>Move everything contained in src to dst and reset src.</summary>
        public void av_frame_move_ref(AVFrame* @dst, AVFrame* @src)
        {
            av_frame_move_ref_ptr(@dst, @src);
        }

        private av_frame_new_side_data_delegate? _av_frame_new_side_data_ptr;

        public av_frame_new_side_data_delegate av_frame_new_side_data_ptr => _av_frame_new_side_data_ptr ?? (_av_frame_new_side_data_ptr = NativeMethodDelegate<av_frame_new_side_data_delegate>());

        /// <summary>Add a new side data to a frame.</summary>
        /// <param name="frame">a frame to which the side data should be added</param>
        /// <param name="type">type of the added side data</param>
        /// <param name="size">size of the side data</param>
        /// <returns>newly added side data on success, NULL on error</returns>
        public AVFrameSideData* av_frame_new_side_data(AVFrame* @frame, AVFrameSideDataType @type, ulong @size)
        {
            return av_frame_new_side_data_ptr(@frame, @type, @size);
        }

        private av_frame_new_side_data_from_buf_delegate? _av_frame_new_side_data_from_buf_ptr;

        public av_frame_new_side_data_from_buf_delegate av_frame_new_side_data_from_buf_ptr => _av_frame_new_side_data_from_buf_ptr ?? (_av_frame_new_side_data_from_buf_ptr = NativeMethodDelegate<av_frame_new_side_data_from_buf_delegate>());

        /// <summary>Add a new side data to a frame from an existing AVBufferRef</summary>
        /// <param name="frame">a frame to which the side data should be added</param>
        /// <param name="type">the type of the added side data</param>
        /// <param name="buf">an AVBufferRef to add as side data. The ownership of the reference is transferred to the frame.</param>
        /// <returns>newly added side data on success, NULL on error. On failure the frame is unchanged and the AVBufferRef remains owned by the caller.</returns>
        public AVFrameSideData* av_frame_new_side_data_from_buf(AVFrame* @frame, AVFrameSideDataType @type, AVBufferRef* @buf)
        {
            return av_frame_new_side_data_from_buf_ptr(@frame, @type, @buf);
        }

        private av_frame_ref_delegate? _av_frame_ref_ptr;

        public av_frame_ref_delegate av_frame_ref_ptr => _av_frame_ref_ptr ?? (_av_frame_ref_ptr = NativeMethodDelegate<av_frame_ref_delegate>());

        /// <summary>Set up a new reference to the data described by the source frame.</summary>
        /// <returns>0 on success, a negative AVERROR on error</returns>
        public int av_frame_ref(AVFrame* @dst, AVFrame* @src)
        {
            return av_frame_ref_ptr(@dst, @src);
        }

        private av_frame_remove_side_data_delegate? _av_frame_remove_side_data_ptr;

        public av_frame_remove_side_data_delegate av_frame_remove_side_data_ptr => _av_frame_remove_side_data_ptr ?? (_av_frame_remove_side_data_ptr = NativeMethodDelegate<av_frame_remove_side_data_delegate>());

        /// <summary>Remove and free all side data instances of the given type.</summary>
        public void av_frame_remove_side_data(AVFrame* @frame, AVFrameSideDataType @type)
        {
            av_frame_remove_side_data_ptr(@frame, @type);
        }

        private av_frame_side_data_name_delegate? _av_frame_side_data_name_ptr;

        public av_frame_side_data_name_delegate av_frame_side_data_name_ptr => _av_frame_side_data_name_ptr ?? (_av_frame_side_data_name_ptr = NativeMethodDelegate<av_frame_side_data_name_delegate>());

        /// <summary>Returns a string identifying the side data type</summary>
        /// <returns>a string identifying the side data type</returns>
        public string av_frame_side_data_name(AVFrameSideDataType @type)
        {
            return av_frame_side_data_name_ptr(@type);
        }

        private av_frame_unref_delegate? _av_frame_unref_ptr;

        public av_frame_unref_delegate av_frame_unref_ptr => _av_frame_unref_ptr ?? (_av_frame_unref_ptr = NativeMethodDelegate<av_frame_unref_delegate>());

        /// <summary>Unreference all the buffers referenced by frame and reset the frame fields.</summary>
        public void av_frame_unref(AVFrame* @frame)
        {
            av_frame_unref_ptr(@frame);
        }

        private av_free_delegate? _av_free_ptr;

        public av_free_delegate av_free_ptr => _av_free_ptr ?? (_av_free_ptr = NativeMethodDelegate<av_free_delegate>());

        /// <summary>Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family.</summary>
        /// <param name="ptr">Pointer to the memory block which should be freed.</param>
        public void av_free(void* @ptr)
        {
            av_free_ptr(@ptr);
        }

        private av_freep_delegate? _av_freep_ptr;

        public av_freep_delegate av_freep_ptr => _av_freep_ptr ?? (_av_freep_ptr = NativeMethodDelegate<av_freep_delegate>());

        /// <summary>Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family, and set the pointer pointing to it to `NULL`.</summary>
        /// <param name="ptr">Pointer to the pointer to the memory block which should be freed</param>
        public void av_freep(void* @ptr)
        {
            av_freep_ptr(@ptr);
        }

        private av_gcd_delegate? _av_gcd_ptr;

        public av_gcd_delegate av_gcd_ptr => _av_gcd_ptr ?? (_av_gcd_ptr = NativeMethodDelegate<av_gcd_delegate>());

        /// <summary>Compute the greatest common divisor of two integer operands.</summary>
        /// <returns>GCD of a and b up to sign; if a &gt;= 0 and b &gt;= 0, return value is &gt;= 0; if a == 0 and b == 0, returns 0.</returns>
        public long av_gcd(long @a, long @b)
        {
            return av_gcd_ptr(@a, @b);
        }

        private av_gcd_q_delegate? _av_gcd_q_ptr;

        public av_gcd_q_delegate av_gcd_q_ptr => _av_gcd_q_ptr ?? (_av_gcd_q_ptr = NativeMethodDelegate<av_gcd_q_delegate>());

        /// <summary>Return the best rational so that a and b are multiple of it. If the resulting denominator is larger than max_den, return def.</summary>
        public AVRational av_gcd_q(AVRational @a, AVRational @b, int @max_den, AVRational @def)
        {
            return av_gcd_q_ptr(@a, @b, @max_den, @def);
        }

        private av_get_alt_sample_fmt_delegate? _av_get_alt_sample_fmt_ptr;

        public av_get_alt_sample_fmt_delegate av_get_alt_sample_fmt_ptr => _av_get_alt_sample_fmt_ptr ?? (_av_get_alt_sample_fmt_ptr = NativeMethodDelegate<av_get_alt_sample_fmt_delegate>());

        /// <summary>Return the planar&lt;-&gt;packed alternative form of the given sample format, or AV_SAMPLE_FMT_NONE on error. If the passed sample_fmt is already in the requested planar/packed format, the format returned is the same as the input.</summary>
        public AVSampleFormat av_get_alt_sample_fmt(AVSampleFormat @sample_fmt, int @planar)
        {
            return av_get_alt_sample_fmt_ptr(@sample_fmt, @planar);
        }

        private av_get_bits_per_pixel_delegate? _av_get_bits_per_pixel_ptr;

        public av_get_bits_per_pixel_delegate av_get_bits_per_pixel_ptr => _av_get_bits_per_pixel_ptr ?? (_av_get_bits_per_pixel_ptr = NativeMethodDelegate<av_get_bits_per_pixel_delegate>());

        /// <summary>Return the number of bits per pixel used by the pixel format described by pixdesc. Note that this is not the same as the number of bits per sample.</summary>
        public int av_get_bits_per_pixel(AVPixFmtDescriptor* @pixdesc)
        {
            return av_get_bits_per_pixel_ptr(@pixdesc);
        }

        private av_get_bytes_per_sample_delegate? _av_get_bytes_per_sample_ptr;

        public av_get_bytes_per_sample_delegate av_get_bytes_per_sample_ptr => _av_get_bytes_per_sample_ptr ?? (_av_get_bytes_per_sample_ptr = NativeMethodDelegate<av_get_bytes_per_sample_delegate>());

        /// <summary>Return number of bytes per sample.</summary>
        /// <param name="sample_fmt">the sample format</param>
        /// <returns>number of bytes per sample or zero if unknown for the given sample format</returns>
        public int av_get_bytes_per_sample(AVSampleFormat @sample_fmt)
        {
            return av_get_bytes_per_sample_ptr(@sample_fmt);
        }

        private av_get_channel_description_delegate? _av_get_channel_description_ptr;

        public av_get_channel_description_delegate av_get_channel_description_ptr => _av_get_channel_description_ptr ?? (_av_get_channel_description_ptr = NativeMethodDelegate<av_get_channel_description_delegate>());

        /// <summary>Get the description of a given channel.</summary>
        /// <param name="channel">a channel layout with a single channel</param>
        /// <returns>channel description on success, NULL on error</returns>
        public string av_get_channel_description(ulong @channel)
        {
            return av_get_channel_description_ptr(@channel);
        }

        private av_get_channel_layout_delegate? _av_get_channel_layout_ptr;

        public av_get_channel_layout_delegate av_get_channel_layout_ptr => _av_get_channel_layout_ptr ?? (_av_get_channel_layout_ptr = NativeMethodDelegate<av_get_channel_layout_delegate>());

        /// <summary>Return a channel layout id that matches name, or 0 if no match is found.</summary>
        public ulong av_get_channel_layout(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return av_get_channel_layout_ptr(@name);
        }

        private av_get_channel_layout_channel_index_delegate? _av_get_channel_layout_channel_index_ptr;

        public av_get_channel_layout_channel_index_delegate av_get_channel_layout_channel_index_ptr => _av_get_channel_layout_channel_index_ptr ?? (_av_get_channel_layout_channel_index_ptr = NativeMethodDelegate<av_get_channel_layout_channel_index_delegate>());

        /// <summary>Get the index of a channel in channel_layout.</summary>
        /// <param name="channel">a channel layout describing exactly one channel which must be present in channel_layout.</param>
        /// <returns>index of channel in channel_layout on success, a negative AVERROR on error.</returns>
        public int av_get_channel_layout_channel_index(ulong @channel_layout, ulong @channel)
        {
            return av_get_channel_layout_channel_index_ptr(@channel_layout, @channel);
        }

        private av_get_channel_layout_nb_channels_delegate? _av_get_channel_layout_nb_channels_ptr;

        public av_get_channel_layout_nb_channels_delegate av_get_channel_layout_nb_channels_ptr => _av_get_channel_layout_nb_channels_ptr ?? (_av_get_channel_layout_nb_channels_ptr = NativeMethodDelegate<av_get_channel_layout_nb_channels_delegate>());

        /// <summary>Return the number of channels in the channel layout.</summary>
        public int av_get_channel_layout_nb_channels(ulong @channel_layout)
        {
            return av_get_channel_layout_nb_channels_ptr(@channel_layout);
        }

        private av_get_channel_layout_string_delegate? _av_get_channel_layout_string_ptr;

        public av_get_channel_layout_string_delegate av_get_channel_layout_string_ptr => _av_get_channel_layout_string_ptr ?? (_av_get_channel_layout_string_ptr = NativeMethodDelegate<av_get_channel_layout_string_delegate>());

        /// <summary>Return a description of a channel layout. If nb_channels is &lt;= 0, it is guessed from the channel_layout.</summary>
        /// <param name="buf">put here the string containing the channel layout</param>
        /// <param name="buf_size">size in bytes of the buffer</param>
        public void av_get_channel_layout_string(byte* @buf, int @buf_size, int @nb_channels, ulong @channel_layout)
        {
            av_get_channel_layout_string_ptr(@buf, @buf_size, @nb_channels, @channel_layout);
        }

        private av_get_channel_name_delegate? _av_get_channel_name_ptr;

        public av_get_channel_name_delegate av_get_channel_name_ptr => _av_get_channel_name_ptr ?? (_av_get_channel_name_ptr = NativeMethodDelegate<av_get_channel_name_delegate>());

        /// <summary>Get the name of a given channel.</summary>
        /// <returns>channel name on success, NULL on error.</returns>
        public string av_get_channel_name(ulong @channel)
        {
            return av_get_channel_name_ptr(@channel);
        }

        private av_get_colorspace_name_delegate? _av_get_colorspace_name_ptr;

        public av_get_colorspace_name_delegate av_get_colorspace_name_ptr => _av_get_colorspace_name_ptr ?? (_av_get_colorspace_name_ptr = NativeMethodDelegate<av_get_colorspace_name_delegate>());

        /// <summary>Get the name of a colorspace.</summary>
        /// <returns>a string identifying the colorspace; can be NULL.</returns>
        [Obsolete("use av_color_space_name()")]
        public string av_get_colorspace_name(AVColorSpace @val)
        {
            return av_get_colorspace_name_ptr(@val);
        }

        private av_get_cpu_flags_delegate? _av_get_cpu_flags_ptr;

        public av_get_cpu_flags_delegate av_get_cpu_flags_ptr => _av_get_cpu_flags_ptr ?? (_av_get_cpu_flags_ptr = NativeMethodDelegate<av_get_cpu_flags_delegate>());

        /// <summary>Return the flags which specify extensions supported by the CPU. The returned value is affected by av_force_cpu_flags() if that was used before. So av_get_cpu_flags() can easily be used in an application to detect the enabled cpu flags.</summary>
        public int av_get_cpu_flags()
        {
            return av_get_cpu_flags_ptr();
        }

        private av_get_default_channel_layout_delegate? _av_get_default_channel_layout_ptr;

        public av_get_default_channel_layout_delegate av_get_default_channel_layout_ptr => _av_get_default_channel_layout_ptr ?? (_av_get_default_channel_layout_ptr = NativeMethodDelegate<av_get_default_channel_layout_delegate>());

        /// <summary>Return default channel layout for a given number of channels.</summary>
        public long av_get_default_channel_layout(int @nb_channels)
        {
            return av_get_default_channel_layout_ptr(@nb_channels);
        }

        private av_get_extended_channel_layout_delegate? _av_get_extended_channel_layout_ptr;

        public av_get_extended_channel_layout_delegate av_get_extended_channel_layout_ptr => _av_get_extended_channel_layout_ptr ?? (_av_get_extended_channel_layout_ptr = NativeMethodDelegate<av_get_extended_channel_layout_delegate>());

        /// <summary>Return a channel layout and the number of channels based on the specified name.</summary>
        /// <param name="name">channel layout specification string</param>
        /// <param name="channel_layout">parsed channel layout (0 if unknown)</param>
        /// <param name="nb_channels">number of channels</param>
        /// <returns>0 on success, AVERROR(EINVAL) if the parsing fails.</returns>
        public int av_get_extended_channel_layout(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, ulong* @channel_layout, int* @nb_channels)
        {
            return av_get_extended_channel_layout_ptr(@name, @channel_layout, @nb_channels);
        }

        private av_get_media_type_string_delegate? _av_get_media_type_string_ptr;

        public av_get_media_type_string_delegate av_get_media_type_string_ptr => _av_get_media_type_string_ptr ?? (_av_get_media_type_string_ptr = NativeMethodDelegate<av_get_media_type_string_delegate>());

        /// <summary>Return a string describing the media_type enum, NULL if media_type is unknown.</summary>
        public string av_get_media_type_string(AVMediaType @media_type)
        {
            return av_get_media_type_string_ptr(@media_type);
        }

        private av_get_packed_sample_fmt_delegate? _av_get_packed_sample_fmt_ptr;

        public av_get_packed_sample_fmt_delegate av_get_packed_sample_fmt_ptr => _av_get_packed_sample_fmt_ptr ?? (_av_get_packed_sample_fmt_ptr = NativeMethodDelegate<av_get_packed_sample_fmt_delegate>());

        /// <summary>Get the packed alternative form of the given sample format.</summary>
        /// <returns>the packed alternative form of the given sample format or AV_SAMPLE_FMT_NONE on error.</returns>
        public AVSampleFormat av_get_packed_sample_fmt(AVSampleFormat @sample_fmt)
        {
            return av_get_packed_sample_fmt_ptr(@sample_fmt);
        }

        private av_get_padded_bits_per_pixel_delegate? _av_get_padded_bits_per_pixel_ptr;

        public av_get_padded_bits_per_pixel_delegate av_get_padded_bits_per_pixel_ptr => _av_get_padded_bits_per_pixel_ptr ?? (_av_get_padded_bits_per_pixel_ptr = NativeMethodDelegate<av_get_padded_bits_per_pixel_delegate>());

        /// <summary>Return the number of bits per pixel for the pixel format described by pixdesc, including any padding or unused bits.</summary>
        public int av_get_padded_bits_per_pixel(AVPixFmtDescriptor* @pixdesc)
        {
            return av_get_padded_bits_per_pixel_ptr(@pixdesc);
        }

        private av_get_picture_type_char_delegate? _av_get_picture_type_char_ptr;

        public av_get_picture_type_char_delegate av_get_picture_type_char_ptr => _av_get_picture_type_char_ptr ?? (_av_get_picture_type_char_ptr = NativeMethodDelegate<av_get_picture_type_char_delegate>());

        /// <summary>Return a single letter to describe the given picture type pict_type.</summary>
        /// <param name="pict_type">the picture type</param>
        /// <returns>a single character representing the picture type, &apos;?&apos; if pict_type is unknown</returns>
        public byte av_get_picture_type_char(AVPictureType @pict_type)
        {
            return av_get_picture_type_char_ptr(@pict_type);
        }

        private av_get_pix_fmt_delegate? _av_get_pix_fmt_ptr;

        public av_get_pix_fmt_delegate av_get_pix_fmt_ptr => _av_get_pix_fmt_ptr ?? (_av_get_pix_fmt_ptr = NativeMethodDelegate<av_get_pix_fmt_delegate>());

        /// <summary>Return the pixel format corresponding to name.</summary>
        public AVPixelFormat av_get_pix_fmt(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return av_get_pix_fmt_ptr(@name);
        }

        private av_get_pix_fmt_loss_delegate? _av_get_pix_fmt_loss_ptr;

        public av_get_pix_fmt_loss_delegate av_get_pix_fmt_loss_ptr => _av_get_pix_fmt_loss_ptr ?? (_av_get_pix_fmt_loss_ptr = NativeMethodDelegate<av_get_pix_fmt_loss_delegate>());

        /// <summary>Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another.</summary>
        /// <param name="dst_pix_fmt">destination pixel format</param>
        /// <param name="src_pix_fmt">source pixel format</param>
        /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
        /// <returns>Combination of flags informing you what kind of losses will occur (maximum loss for an invalid dst_pix_fmt).</returns>
        public int av_get_pix_fmt_loss(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha)
        {
            return av_get_pix_fmt_loss_ptr(@dst_pix_fmt, @src_pix_fmt, @has_alpha);
        }

        private av_get_pix_fmt_name_delegate? _av_get_pix_fmt_name_ptr;

        public av_get_pix_fmt_name_delegate av_get_pix_fmt_name_ptr => _av_get_pix_fmt_name_ptr ?? (_av_get_pix_fmt_name_ptr = NativeMethodDelegate<av_get_pix_fmt_name_delegate>());

        /// <summary>Return the short name for a pixel format, NULL in case pix_fmt is unknown.</summary>
        public string av_get_pix_fmt_name(AVPixelFormat @pix_fmt)
        {
            return av_get_pix_fmt_name_ptr(@pix_fmt);
        }

        private av_get_pix_fmt_string_delegate? _av_get_pix_fmt_string_ptr;

        public av_get_pix_fmt_string_delegate av_get_pix_fmt_string_ptr => _av_get_pix_fmt_string_ptr ?? (_av_get_pix_fmt_string_ptr = NativeMethodDelegate<av_get_pix_fmt_string_delegate>());

        /// <summary>Print in buf the string corresponding to the pixel format with number pix_fmt, or a header if pix_fmt is negative.</summary>
        /// <param name="buf">the buffer where to write the string</param>
        /// <param name="buf_size">the size of buf</param>
        /// <param name="pix_fmt">the number of the pixel format to print the corresponding info string, or a negative value to print the corresponding header.</param>
        public byte* av_get_pix_fmt_string(byte* @buf, int @buf_size, AVPixelFormat @pix_fmt)
        {
            return av_get_pix_fmt_string_ptr(@buf, @buf_size, @pix_fmt);
        }

        private av_get_planar_sample_fmt_delegate? _av_get_planar_sample_fmt_ptr;

        public av_get_planar_sample_fmt_delegate av_get_planar_sample_fmt_ptr => _av_get_planar_sample_fmt_ptr ?? (_av_get_planar_sample_fmt_ptr = NativeMethodDelegate<av_get_planar_sample_fmt_delegate>());

        /// <summary>Get the planar alternative form of the given sample format.</summary>
        /// <returns>the planar alternative form of the given sample format or AV_SAMPLE_FMT_NONE on error.</returns>
        public AVSampleFormat av_get_planar_sample_fmt(AVSampleFormat @sample_fmt)
        {
            return av_get_planar_sample_fmt_ptr(@sample_fmt);
        }

        private av_get_sample_fmt_delegate? _av_get_sample_fmt_ptr;

        public av_get_sample_fmt_delegate av_get_sample_fmt_ptr => _av_get_sample_fmt_ptr ?? (_av_get_sample_fmt_ptr = NativeMethodDelegate<av_get_sample_fmt_delegate>());

        /// <summary>Return a sample format corresponding to name, or AV_SAMPLE_FMT_NONE on error.</summary>
        public AVSampleFormat av_get_sample_fmt(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return av_get_sample_fmt_ptr(@name);
        }

        private av_get_sample_fmt_name_delegate? _av_get_sample_fmt_name_ptr;

        public av_get_sample_fmt_name_delegate av_get_sample_fmt_name_ptr => _av_get_sample_fmt_name_ptr ?? (_av_get_sample_fmt_name_ptr = NativeMethodDelegate<av_get_sample_fmt_name_delegate>());

        /// <summary>Return the name of sample_fmt, or NULL if sample_fmt is not recognized.</summary>
        public string av_get_sample_fmt_name(AVSampleFormat @sample_fmt)
        {
            return av_get_sample_fmt_name_ptr(@sample_fmt);
        }

        private av_get_sample_fmt_string_delegate? _av_get_sample_fmt_string_ptr;

        public av_get_sample_fmt_string_delegate av_get_sample_fmt_string_ptr => _av_get_sample_fmt_string_ptr ?? (_av_get_sample_fmt_string_ptr = NativeMethodDelegate<av_get_sample_fmt_string_delegate>());

        /// <summary>Generate a string corresponding to the sample format with sample_fmt, or a header if sample_fmt is negative.</summary>
        /// <param name="buf">the buffer where to write the string</param>
        /// <param name="buf_size">the size of buf</param>
        /// <param name="sample_fmt">the number of the sample format to print the corresponding info string, or a negative value to print the corresponding header.</param>
        /// <returns>the pointer to the filled buffer or NULL if sample_fmt is unknown or in case of other errors</returns>
        public byte* av_get_sample_fmt_string(byte* @buf, int @buf_size, AVSampleFormat @sample_fmt)
        {
            return av_get_sample_fmt_string_ptr(@buf, @buf_size, @sample_fmt);
        }

        private av_get_standard_channel_layout_delegate? _av_get_standard_channel_layout_ptr;

        public av_get_standard_channel_layout_delegate av_get_standard_channel_layout_ptr => _av_get_standard_channel_layout_ptr ?? (_av_get_standard_channel_layout_ptr = NativeMethodDelegate<av_get_standard_channel_layout_delegate>());

        /// <summary>Get the value and name of a standard channel layout.</summary>
        /// <param name="index">index in an internal list, starting at 0</param>
        /// <param name="layout">channel layout mask</param>
        /// <param name="name">name of the layout</param>
        /// <returns>0  if the layout exists,  &lt; 0 if index is beyond the limits</returns>
        public int av_get_standard_channel_layout(uint @index, ulong* @layout, byte** @name)
        {
            return av_get_standard_channel_layout_ptr(@index, @layout, @name);
        }

        private av_get_time_base_q_delegate? _av_get_time_base_q_ptr;

        public av_get_time_base_q_delegate av_get_time_base_q_ptr => _av_get_time_base_q_ptr ?? (_av_get_time_base_q_ptr = NativeMethodDelegate<av_get_time_base_q_delegate>());

        /// <summary>Return the fractional representation of the internal time base.</summary>
        public AVRational av_get_time_base_q()
        {
            return av_get_time_base_q_ptr();
        }

        private av_gettime_delegate? _av_gettime_ptr;

        public av_gettime_delegate av_gettime_ptr => _av_gettime_ptr ?? (_av_gettime_ptr = NativeMethodDelegate<av_gettime_delegate>());

        /// <summary>Get the current time in microseconds.</summary>
        public long av_gettime()
        {
            return av_gettime_ptr();
        }

        private av_gettime_relative_delegate? _av_gettime_relative_ptr;

        public av_gettime_relative_delegate av_gettime_relative_ptr => _av_gettime_relative_ptr ?? (_av_gettime_relative_ptr = NativeMethodDelegate<av_gettime_relative_delegate>());

        /// <summary>Get the current time in microseconds since some unspecified starting point. On platforms that support it, the time comes from a monotonic clock This property makes this time source ideal for measuring relative time. The returned values may not be monotonic on platforms where a monotonic clock is not available.</summary>
        public long av_gettime_relative()
        {
            return av_gettime_relative_ptr();
        }

        private av_gettime_relative_is_monotonic_delegate? _av_gettime_relative_is_monotonic_ptr;

        public av_gettime_relative_is_monotonic_delegate av_gettime_relative_is_monotonic_ptr => _av_gettime_relative_is_monotonic_ptr ?? (_av_gettime_relative_is_monotonic_ptr = NativeMethodDelegate<av_gettime_relative_is_monotonic_delegate>());

        /// <summary>Indicates with a boolean result if the av_gettime_relative() time source is monotonic.</summary>
        public int av_gettime_relative_is_monotonic()
        {
            return av_gettime_relative_is_monotonic_ptr();
        }

        private av_hwdevice_ctx_alloc_delegate? _av_hwdevice_ctx_alloc_ptr;

        public av_hwdevice_ctx_alloc_delegate av_hwdevice_ctx_alloc_ptr => _av_hwdevice_ctx_alloc_ptr ?? (_av_hwdevice_ctx_alloc_ptr = NativeMethodDelegate<av_hwdevice_ctx_alloc_delegate>());

        /// <summary>Allocate an AVHWDeviceContext for a given hardware type.</summary>
        /// <param name="type">the type of the hardware device to allocate.</param>
        /// <returns>a reference to the newly created AVHWDeviceContext on success or NULL on failure.</returns>
        public AVBufferRef* av_hwdevice_ctx_alloc(AVHWDeviceType @type)
        {
            return av_hwdevice_ctx_alloc_ptr(@type);
        }

        private av_hwdevice_ctx_create_delegate? _av_hwdevice_ctx_create_ptr;

        public av_hwdevice_ctx_create_delegate av_hwdevice_ctx_create_ptr => _av_hwdevice_ctx_create_ptr ?? (_av_hwdevice_ctx_create_ptr = NativeMethodDelegate<av_hwdevice_ctx_create_delegate>());

        /// <summary>Open a device of the specified type and create an AVHWDeviceContext for it.</summary>
        /// <param name="device_ctx">On success, a reference to the newly-created device context will be written here. The reference is owned by the caller and must be released with av_buffer_unref() when no longer needed. On failure, NULL will be written to this pointer.</param>
        /// <param name="type">The type of the device to create.</param>
        /// <param name="device">A type-specific string identifying the device to open.</param>
        /// <param name="opts">A dictionary of additional (type-specific) options to use in opening the device. The dictionary remains owned by the caller.</param>
        /// <param name="flags">currently unused</param>
        /// <returns>0 on success, a negative AVERROR code on failure.</returns>
        public int av_hwdevice_ctx_create(AVBufferRef** @device_ctx, AVHWDeviceType @type,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @device, AVDictionary* @opts, int @flags)
        {
            return av_hwdevice_ctx_create_ptr(@device_ctx, @type, @device, @opts, @flags);
        }

        private av_hwdevice_ctx_create_derived_delegate? _av_hwdevice_ctx_create_derived_ptr;

        public av_hwdevice_ctx_create_derived_delegate av_hwdevice_ctx_create_derived_ptr => _av_hwdevice_ctx_create_derived_ptr ?? (_av_hwdevice_ctx_create_derived_ptr = NativeMethodDelegate<av_hwdevice_ctx_create_derived_delegate>());

        /// <summary>Create a new device of the specified type from an existing device.</summary>
        /// <param name="dst_ctx">On success, a reference to the newly-created AVHWDeviceContext.</param>
        /// <param name="type">The type of the new device to create.</param>
        /// <param name="src_ctx">A reference to an existing AVHWDeviceContext which will be used to create the new device.</param>
        /// <param name="flags">Currently unused; should be set to zero.</param>
        /// <returns>Zero on success, a negative AVERROR code on failure.</returns>
        public int av_hwdevice_ctx_create_derived(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags)
        {
            return av_hwdevice_ctx_create_derived_ptr(@dst_ctx, @type, @src_ctx, @flags);
        }

        private av_hwdevice_ctx_create_derived_opts_delegate? _av_hwdevice_ctx_create_derived_opts_ptr;

        public av_hwdevice_ctx_create_derived_opts_delegate av_hwdevice_ctx_create_derived_opts_ptr => _av_hwdevice_ctx_create_derived_opts_ptr ?? (_av_hwdevice_ctx_create_derived_opts_ptr = NativeMethodDelegate<av_hwdevice_ctx_create_derived_opts_delegate>());

        /// <summary>Create a new device of the specified type from an existing device.</summary>
        /// <param name="dst_ctx">On success, a reference to the newly-created AVHWDeviceContext.</param>
        /// <param name="type">The type of the new device to create.</param>
        /// <param name="src_ctx">A reference to an existing AVHWDeviceContext which will be used to create the new device.</param>
        /// <param name="options">Options for the new device to create, same format as in av_hwdevice_ctx_create.</param>
        /// <param name="flags">Currently unused; should be set to zero.</param>
        /// <returns>Zero on success, a negative AVERROR code on failure.</returns>
        public int av_hwdevice_ctx_create_derived_opts(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, AVDictionary* @options, int @flags)
        {
            return av_hwdevice_ctx_create_derived_opts_ptr(@dst_ctx, @type, @src_ctx, @options, @flags);
        }

        private av_hwdevice_ctx_init_delegate? _av_hwdevice_ctx_init_ptr;

        public av_hwdevice_ctx_init_delegate av_hwdevice_ctx_init_ptr => _av_hwdevice_ctx_init_ptr ?? (_av_hwdevice_ctx_init_ptr = NativeMethodDelegate<av_hwdevice_ctx_init_delegate>());

        /// <summary>Finalize the device context before use. This function must be called after the context is filled with all the required information and before it is used in any way.</summary>
        /// <param name="ref">a reference to the AVHWDeviceContext</param>
        /// <returns>0 on success, a negative AVERROR code on failure</returns>
        public int av_hwdevice_ctx_init(AVBufferRef* @ref)
        {
            return av_hwdevice_ctx_init_ptr(@ref);
        }

        private av_hwdevice_find_type_by_name_delegate? _av_hwdevice_find_type_by_name_ptr;

        public av_hwdevice_find_type_by_name_delegate av_hwdevice_find_type_by_name_ptr => _av_hwdevice_find_type_by_name_ptr ?? (_av_hwdevice_find_type_by_name_ptr = NativeMethodDelegate<av_hwdevice_find_type_by_name_delegate>());

        /// <summary>Look up an AVHWDeviceType by name.</summary>
        /// <param name="name">String name of the device type (case-insensitive).</param>
        /// <returns>The type from enum AVHWDeviceType, or AV_HWDEVICE_TYPE_NONE if not found.</returns>
        public AVHWDeviceType av_hwdevice_find_type_by_name(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return av_hwdevice_find_type_by_name_ptr(@name);
        }

        private av_hwdevice_get_hwframe_constraints_delegate? _av_hwdevice_get_hwframe_constraints_ptr;

        public av_hwdevice_get_hwframe_constraints_delegate av_hwdevice_get_hwframe_constraints_ptr => _av_hwdevice_get_hwframe_constraints_ptr ?? (_av_hwdevice_get_hwframe_constraints_ptr = NativeMethodDelegate<av_hwdevice_get_hwframe_constraints_delegate>());

        /// <summary>Get the constraints on HW frames given a device and the HW-specific configuration to be used with that device. If no HW-specific configuration is provided, returns the maximum possible capabilities of the device.</summary>
        /// <param name="ref">a reference to the associated AVHWDeviceContext.</param>
        /// <param name="hwconfig">a filled HW-specific configuration structure, or NULL to return the maximum possible capabilities of the device.</param>
        /// <returns>AVHWFramesConstraints structure describing the constraints on the device, or NULL if not available.</returns>
        public AVHWFramesConstraints* av_hwdevice_get_hwframe_constraints(AVBufferRef* @ref, void* @hwconfig)
        {
            return av_hwdevice_get_hwframe_constraints_ptr(@ref, @hwconfig);
        }

        private av_hwdevice_get_type_name_delegate? _av_hwdevice_get_type_name_ptr;

        public av_hwdevice_get_type_name_delegate av_hwdevice_get_type_name_ptr => _av_hwdevice_get_type_name_ptr ?? (_av_hwdevice_get_type_name_ptr = NativeMethodDelegate<av_hwdevice_get_type_name_delegate>());

        /// <summary>Get the string name of an AVHWDeviceType.</summary>
        /// <param name="type">Type from enum AVHWDeviceType.</param>
        /// <returns>Pointer to a string containing the name, or NULL if the type is not valid.</returns>
        public string av_hwdevice_get_type_name(AVHWDeviceType @type)
        {
            return av_hwdevice_get_type_name_ptr(@type);
        }

        private av_hwdevice_hwconfig_alloc_delegate? _av_hwdevice_hwconfig_alloc_ptr;

        public av_hwdevice_hwconfig_alloc_delegate av_hwdevice_hwconfig_alloc_ptr => _av_hwdevice_hwconfig_alloc_ptr ?? (_av_hwdevice_hwconfig_alloc_ptr = NativeMethodDelegate<av_hwdevice_hwconfig_alloc_delegate>());

        /// <summary>Allocate a HW-specific configuration structure for a given HW device. After use, the user must free all members as required by the specific hardware structure being used, then free the structure itself with av_free().</summary>
        /// <param name="device_ctx">a reference to the associated AVHWDeviceContext.</param>
        /// <returns>The newly created HW-specific configuration structure on success or NULL on failure.</returns>
        public void* av_hwdevice_hwconfig_alloc(AVBufferRef* @device_ctx)
        {
            return av_hwdevice_hwconfig_alloc_ptr(@device_ctx);
        }

        private av_hwdevice_iterate_types_delegate? _av_hwdevice_iterate_types_ptr;

        public av_hwdevice_iterate_types_delegate av_hwdevice_iterate_types_ptr => _av_hwdevice_iterate_types_ptr ?? (_av_hwdevice_iterate_types_ptr = NativeMethodDelegate<av_hwdevice_iterate_types_delegate>());

        /// <summary>Iterate over supported device types.</summary>
        /// <returns>The next usable device type from enum AVHWDeviceType, or AV_HWDEVICE_TYPE_NONE if there are no more.</returns>
        public AVHWDeviceType av_hwdevice_iterate_types(AVHWDeviceType @prev)
        {
            return av_hwdevice_iterate_types_ptr(@prev);
        }

        private av_hwframe_constraints_free_delegate? _av_hwframe_constraints_free_ptr;

        public av_hwframe_constraints_free_delegate av_hwframe_constraints_free_ptr => _av_hwframe_constraints_free_ptr ?? (_av_hwframe_constraints_free_ptr = NativeMethodDelegate<av_hwframe_constraints_free_delegate>());

        /// <summary>Free an AVHWFrameConstraints structure.</summary>
        /// <param name="constraints">The (filled or unfilled) AVHWFrameConstraints structure.</param>
        public void av_hwframe_constraints_free(AVHWFramesConstraints** @constraints)
        {
            av_hwframe_constraints_free_ptr(@constraints);
        }

        private av_hwframe_ctx_alloc_delegate? _av_hwframe_ctx_alloc_ptr;

        public av_hwframe_ctx_alloc_delegate av_hwframe_ctx_alloc_ptr => _av_hwframe_ctx_alloc_ptr ?? (_av_hwframe_ctx_alloc_ptr = NativeMethodDelegate<av_hwframe_ctx_alloc_delegate>());

        /// <summary>Allocate an AVHWFramesContext tied to a given device context.</summary>
        /// <param name="device_ctx">a reference to a AVHWDeviceContext. This function will make a new reference for internal use, the one passed to the function remains owned by the caller.</param>
        /// <returns>a reference to the newly created AVHWFramesContext on success or NULL on failure.</returns>
        public AVBufferRef* av_hwframe_ctx_alloc(AVBufferRef* @device_ctx)
        {
            return av_hwframe_ctx_alloc_ptr(@device_ctx);
        }

        private av_hwframe_ctx_create_derived_delegate? _av_hwframe_ctx_create_derived_ptr;

        public av_hwframe_ctx_create_derived_delegate av_hwframe_ctx_create_derived_ptr => _av_hwframe_ctx_create_derived_ptr ?? (_av_hwframe_ctx_create_derived_ptr = NativeMethodDelegate<av_hwframe_ctx_create_derived_delegate>());

        /// <summary>Create and initialise an AVHWFramesContext as a mapping of another existing AVHWFramesContext on a different device.</summary>
        /// <param name="derived_frame_ctx">On success, a reference to the newly created AVHWFramesContext.</param>
        /// <param name="derived_device_ctx">A reference to the device to create the new AVHWFramesContext on.</param>
        /// <param name="source_frame_ctx">A reference to an existing AVHWFramesContext which will be mapped to the derived context.</param>
        /// <param name="flags">Some combination of AV_HWFRAME_MAP_* flags, defining the mapping parameters to apply to frames which are allocated in the derived device.</param>
        /// <returns>Zero on success, negative AVERROR code on failure.</returns>
        public int av_hwframe_ctx_create_derived(AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags)
        {
            return av_hwframe_ctx_create_derived_ptr(@derived_frame_ctx, @format, @derived_device_ctx, @source_frame_ctx, @flags);
        }

        private av_hwframe_ctx_init_delegate? _av_hwframe_ctx_init_ptr;

        public av_hwframe_ctx_init_delegate av_hwframe_ctx_init_ptr => _av_hwframe_ctx_init_ptr ?? (_av_hwframe_ctx_init_ptr = NativeMethodDelegate<av_hwframe_ctx_init_delegate>());

        /// <summary>Finalize the context before use. This function must be called after the context is filled with all the required information and before it is attached to any frames.</summary>
        /// <param name="ref">a reference to the AVHWFramesContext</param>
        /// <returns>0 on success, a negative AVERROR code on failure</returns>
        public int av_hwframe_ctx_init(AVBufferRef* @ref)
        {
            return av_hwframe_ctx_init_ptr(@ref);
        }

        private av_hwframe_get_buffer_delegate? _av_hwframe_get_buffer_ptr;

        public av_hwframe_get_buffer_delegate av_hwframe_get_buffer_ptr => _av_hwframe_get_buffer_ptr ?? (_av_hwframe_get_buffer_ptr = NativeMethodDelegate<av_hwframe_get_buffer_delegate>());

        /// <summary>Allocate a new frame attached to the given AVHWFramesContext.</summary>
        /// <param name="hwframe_ctx">a reference to an AVHWFramesContext</param>
        /// <param name="frame">an empty (freshly allocated or unreffed) frame to be filled with newly allocated buffers.</param>
        /// <param name="flags">currently unused, should be set to zero</param>
        /// <returns>0 on success, a negative AVERROR code on failure</returns>
        public int av_hwframe_get_buffer(AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags)
        {
            return av_hwframe_get_buffer_ptr(@hwframe_ctx, @frame, @flags);
        }

        private av_hwframe_map_delegate? _av_hwframe_map_ptr;

        public av_hwframe_map_delegate av_hwframe_map_ptr => _av_hwframe_map_ptr ?? (_av_hwframe_map_ptr = NativeMethodDelegate<av_hwframe_map_delegate>());

        /// <summary>Map a hardware frame.</summary>
        /// <param name="dst">Destination frame, to contain the mapping.</param>
        /// <param name="src">Source frame, to be mapped.</param>
        /// <param name="flags">Some combination of AV_HWFRAME_MAP_* flags.</param>
        /// <returns>Zero on success, negative AVERROR code on failure.</returns>
        public int av_hwframe_map(AVFrame* @dst, AVFrame* @src, int @flags)
        {
            return av_hwframe_map_ptr(@dst, @src, @flags);
        }

        private av_hwframe_transfer_data_delegate? _av_hwframe_transfer_data_ptr;

        public av_hwframe_transfer_data_delegate av_hwframe_transfer_data_ptr => _av_hwframe_transfer_data_ptr ?? (_av_hwframe_transfer_data_ptr = NativeMethodDelegate<av_hwframe_transfer_data_delegate>());

        /// <summary>Copy data to or from a hw surface. At least one of dst/src must have an AVHWFramesContext attached.</summary>
        /// <param name="dst">the destination frame. dst is not touched on failure.</param>
        /// <param name="src">the source frame.</param>
        /// <param name="flags">currently unused, should be set to zero</param>
        /// <returns>0 on success, a negative AVERROR error code on failure.</returns>
        public int av_hwframe_transfer_data(AVFrame* @dst, AVFrame* @src, int @flags)
        {
            return av_hwframe_transfer_data_ptr(@dst, @src, @flags);
        }

        private av_hwframe_transfer_get_formats_delegate? _av_hwframe_transfer_get_formats_ptr;

        public av_hwframe_transfer_get_formats_delegate av_hwframe_transfer_get_formats_ptr => _av_hwframe_transfer_get_formats_ptr ?? (_av_hwframe_transfer_get_formats_ptr = NativeMethodDelegate<av_hwframe_transfer_get_formats_delegate>());

        /// <summary>Get a list of possible source or target formats usable in av_hwframe_transfer_data().</summary>
        /// <param name="hwframe_ctx">the frame context to obtain the information for</param>
        /// <param name="dir">the direction of the transfer</param>
        /// <param name="formats">the pointer to the output format list will be written here. The list is terminated with AV_PIX_FMT_NONE and must be freed by the caller when no longer needed using av_free(). If this function returns successfully, the format list will have at least one item (not counting the terminator). On failure, the contents of this pointer are unspecified.</param>
        /// <param name="flags">currently unused, should be set to zero</param>
        /// <returns>0 on success, a negative AVERROR code on failure.</returns>
        public int av_hwframe_transfer_get_formats(AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags)
        {
            return av_hwframe_transfer_get_formats_ptr(@hwframe_ctx, @dir, @formats, @flags);
        }

        private av_image_alloc_delegate? _av_image_alloc_ptr;

        public av_image_alloc_delegate av_image_alloc_ptr => _av_image_alloc_ptr ?? (_av_image_alloc_ptr = NativeMethodDelegate<av_image_alloc_delegate>());

        /// <summary>Allocate an image with size w and h and pixel format pix_fmt, and fill pointers and linesizes accordingly. The allocated image buffer has to be freed by using av_freep(&amp;pointers[0]).</summary>
        /// <param name="align">the value to use for buffer size alignment</param>
        /// <returns>the size in bytes required for the image buffer, a negative error code in case of failure</returns>
        public int av_image_alloc(ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align)
        {
            return av_image_alloc_ptr(ref @pointers, ref @linesizes, @w, @h, @pix_fmt, @align);
        }

        private av_image_check_sar_delegate? _av_image_check_sar_ptr;

        public av_image_check_sar_delegate av_image_check_sar_ptr => _av_image_check_sar_ptr ?? (_av_image_check_sar_ptr = NativeMethodDelegate<av_image_check_sar_delegate>());

        /// <summary>Check if the given sample aspect ratio of an image is valid.</summary>
        /// <param name="w">width of the image</param>
        /// <param name="h">height of the image</param>
        /// <param name="sar">sample aspect ratio of the image</param>
        /// <returns>0 if valid, a negative AVERROR code otherwise</returns>
        public int av_image_check_sar(uint @w, uint @h, AVRational @sar)
        {
            return av_image_check_sar_ptr(@w, @h, @sar);
        }

        private av_image_check_size_delegate? _av_image_check_size_ptr;

        public av_image_check_size_delegate av_image_check_size_ptr => _av_image_check_size_ptr ?? (_av_image_check_size_ptr = NativeMethodDelegate<av_image_check_size_delegate>());

        /// <summary>Check if the given dimension of an image is valid, meaning that all bytes of the image can be addressed with a signed int.</summary>
        /// <param name="w">the width of the picture</param>
        /// <param name="h">the height of the picture</param>
        /// <param name="log_offset">the offset to sum to the log level for logging with log_ctx</param>
        /// <param name="log_ctx">the parent logging context, it may be NULL</param>
        /// <returns>&gt;= 0 if valid, a negative error code otherwise</returns>
        public int av_image_check_size(uint @w, uint @h, int @log_offset, void* @log_ctx)
        {
            return av_image_check_size_ptr(@w, @h, @log_offset, @log_ctx);
        }

        private av_image_check_size2_delegate? _av_image_check_size2_ptr;

        public av_image_check_size2_delegate av_image_check_size2_ptr => _av_image_check_size2_ptr ?? (_av_image_check_size2_ptr = NativeMethodDelegate<av_image_check_size2_delegate>());

        /// <summary>Check if the given dimension of an image is valid, meaning that all bytes of a plane of an image with the specified pix_fmt can be addressed with a signed int.</summary>
        /// <param name="w">the width of the picture</param>
        /// <param name="h">the height of the picture</param>
        /// <param name="max_pixels">the maximum number of pixels the user wants to accept</param>
        /// <param name="pix_fmt">the pixel format, can be AV_PIX_FMT_NONE if unknown.</param>
        /// <param name="log_offset">the offset to sum to the log level for logging with log_ctx</param>
        /// <param name="log_ctx">the parent logging context, it may be NULL</param>
        /// <returns>&gt;= 0 if valid, a negative error code otherwise</returns>
        public int av_image_check_size2(uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx)
        {
            return av_image_check_size2_ptr(@w, @h, @max_pixels, @pix_fmt, @log_offset, @log_ctx);
        }

        private av_image_copy_delegate? _av_image_copy_ptr;

        public av_image_copy_delegate av_image_copy_ptr => _av_image_copy_ptr ?? (_av_image_copy_ptr = NativeMethodDelegate<av_image_copy_delegate>());

        /// <summary>Copy image in src_data to dst_data.</summary>
        /// <param name="dst_linesizes">linesizes for the image in dst_data</param>
        /// <param name="src_linesizes">linesizes for the image in src_data</param>
        public void av_image_copy(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height)
        {
            av_image_copy_ptr(ref @dst_data, ref @dst_linesizes, ref @src_data, @src_linesizes, @pix_fmt, @width, @height);
        }

        private av_image_copy_plane_delegate? _av_image_copy_plane_ptr;

        public av_image_copy_plane_delegate av_image_copy_plane_ptr => _av_image_copy_plane_ptr ?? (_av_image_copy_plane_ptr = NativeMethodDelegate<av_image_copy_plane_delegate>());

        /// <summary>Copy image plane from src to dst. That is, copy &quot;height&quot; number of lines of &quot;bytewidth&quot; bytes each. The first byte of each successive line is separated by *_linesize bytes.</summary>
        /// <param name="dst_linesize">linesize for the image plane in dst</param>
        /// <param name="src_linesize">linesize for the image plane in src</param>
        public void av_image_copy_plane(byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height)
        {
            av_image_copy_plane_ptr(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
        }

        private av_image_copy_plane_uc_from_delegate? _av_image_copy_plane_uc_from_ptr;

        public av_image_copy_plane_uc_from_delegate av_image_copy_plane_uc_from_ptr => _av_image_copy_plane_uc_from_ptr ?? (_av_image_copy_plane_uc_from_ptr = NativeMethodDelegate<av_image_copy_plane_uc_from_delegate>());

        /// <summary>Copy image data located in uncacheable (e.g. GPU mapped) memory. Where available, this function will use special functionality for reading from such memory, which may result in greatly improved performance compared to plain av_image_copy_plane().</summary>
        public void av_image_copy_plane_uc_from(byte* @dst, long @dst_linesize, byte* @src, long @src_linesize, long @bytewidth, int @height)
        {
            av_image_copy_plane_uc_from_ptr(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
        }

        private av_image_copy_to_buffer_delegate? _av_image_copy_to_buffer_ptr;

        public av_image_copy_to_buffer_delegate av_image_copy_to_buffer_ptr => _av_image_copy_to_buffer_ptr ?? (_av_image_copy_to_buffer_ptr = NativeMethodDelegate<av_image_copy_to_buffer_delegate>());

        /// <summary>Copy image data from an image into a buffer.</summary>
        /// <param name="dst">a buffer into which picture data will be copied</param>
        /// <param name="dst_size">the size in bytes of dst</param>
        /// <param name="src_data">pointers containing the source image data</param>
        /// <param name="src_linesize">linesizes for the image in src_data</param>
        /// <param name="pix_fmt">the pixel format of the source image</param>
        /// <param name="width">the width of the source image in pixels</param>
        /// <param name="height">the height of the source image in pixels</param>
        /// <param name="align">the assumed linesize alignment for dst</param>
        /// <returns>the number of bytes written to dst, or a negative value (error code) on error</returns>
        public int av_image_copy_to_buffer(byte* @dst, int @dst_size, byte_ptrArray4 @src_data, int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align)
        {
            return av_image_copy_to_buffer_ptr(@dst, @dst_size, @src_data, @src_linesize, @pix_fmt, @width, @height, @align);
        }

        private av_image_copy_uc_from_delegate? _av_image_copy_uc_from_ptr;

        public av_image_copy_uc_from_delegate av_image_copy_uc_from_ptr => _av_image_copy_uc_from_ptr ?? (_av_image_copy_uc_from_ptr = NativeMethodDelegate<av_image_copy_uc_from_delegate>());

        /// <summary>Copy image data located in uncacheable (e.g. GPU mapped) memory. Where available, this function will use special functionality for reading from such memory, which may result in greatly improved performance compared to plain av_image_copy().</summary>
        public void av_image_copy_uc_from(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height)
        {
            av_image_copy_uc_from_ptr(ref @dst_data, @dst_linesizes, ref @src_data, @src_linesizes, @pix_fmt, @width, @height);
        }

        private av_image_fill_arrays_delegate? _av_image_fill_arrays_ptr;

        public av_image_fill_arrays_delegate av_image_fill_arrays_ptr => _av_image_fill_arrays_ptr ?? (_av_image_fill_arrays_ptr = NativeMethodDelegate<av_image_fill_arrays_delegate>());

        /// <summary>Setup the data pointers and linesizes based on the specified image parameters and the provided array.</summary>
        /// <param name="dst_data">data pointers to be filled in</param>
        /// <param name="dst_linesize">linesizes for the image in dst_data to be filled in</param>
        /// <param name="src">buffer which will contain or contains the actual image data, can be NULL</param>
        /// <param name="pix_fmt">the pixel format of the image</param>
        /// <param name="width">the width of the image in pixels</param>
        /// <param name="height">the height of the image in pixels</param>
        /// <param name="align">the value used in src for linesize alignment</param>
        /// <returns>the size in bytes required for src, a negative error code in case of failure</returns>
        public int av_image_fill_arrays(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align)
        {
            return av_image_fill_arrays_ptr(ref @dst_data, ref @dst_linesize, @src, @pix_fmt, @width, @height, @align);
        }

        private av_image_fill_black_delegate? _av_image_fill_black_ptr;

        public av_image_fill_black_delegate av_image_fill_black_ptr => _av_image_fill_black_ptr ?? (_av_image_fill_black_ptr = NativeMethodDelegate<av_image_fill_black_delegate>());

        /// <summary>Overwrite the image data with black. This is suitable for filling a sub-rectangle of an image, meaning the padding between the right most pixel and the left most pixel on the next line will not be overwritten. For some formats, the image size might be rounded up due to inherent alignment.</summary>
        /// <param name="dst_data">data pointers to destination image</param>
        /// <param name="dst_linesize">linesizes for the destination image</param>
        /// <param name="pix_fmt">the pixel format of the image</param>
        /// <param name="range">the color range of the image (important for colorspaces such as YUV)</param>
        /// <param name="width">the width of the image in pixels</param>
        /// <param name="height">the height of the image in pixels</param>
        /// <returns>0 if the image data was cleared, a negative AVERROR code otherwise</returns>
        public int av_image_fill_black(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height)
        {
            return av_image_fill_black_ptr(ref @dst_data, @dst_linesize, @pix_fmt, @range, @width, @height);
        }

        private av_image_fill_linesizes_delegate? _av_image_fill_linesizes_ptr;

        public av_image_fill_linesizes_delegate av_image_fill_linesizes_ptr => _av_image_fill_linesizes_ptr ?? (_av_image_fill_linesizes_ptr = NativeMethodDelegate<av_image_fill_linesizes_delegate>());

        /// <summary>Fill plane linesizes for an image with pixel format pix_fmt and width width.</summary>
        /// <param name="linesizes">array to be filled with the linesize for each plane</param>
        /// <returns>&gt;= 0 in case of success, a negative error code otherwise</returns>
        public int av_image_fill_linesizes(ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width)
        {
            return av_image_fill_linesizes_ptr(ref @linesizes, @pix_fmt, @width);
        }

        private av_image_fill_max_pixsteps_delegate? _av_image_fill_max_pixsteps_ptr;

        public av_image_fill_max_pixsteps_delegate av_image_fill_max_pixsteps_ptr => _av_image_fill_max_pixsteps_ptr ?? (_av_image_fill_max_pixsteps_ptr = NativeMethodDelegate<av_image_fill_max_pixsteps_delegate>());

        /// <summary>Compute the max pixel step for each plane of an image with a format described by pixdesc.</summary>
        /// <param name="max_pixsteps">an array which is filled with the max pixel step for each plane. Since a plane may contain different pixel components, the computed max_pixsteps[plane] is relative to the component in the plane with the max pixel step.</param>
        /// <param name="max_pixstep_comps">an array which is filled with the component for each plane which has the max pixel step. May be NULL.</param>
        public void av_image_fill_max_pixsteps(int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc)
        {
            av_image_fill_max_pixsteps_ptr(@max_pixsteps, ref @max_pixstep_comps, @pixdesc);
        }

        private av_image_fill_plane_sizes_delegate? _av_image_fill_plane_sizes_ptr;

        public av_image_fill_plane_sizes_delegate av_image_fill_plane_sizes_ptr => _av_image_fill_plane_sizes_ptr ?? (_av_image_fill_plane_sizes_ptr = NativeMethodDelegate<av_image_fill_plane_sizes_delegate>());

        /// <summary>Fill plane sizes for an image with pixel format pix_fmt and height height.</summary>
        /// <param name="size">the array to be filled with the size of each image plane</param>
        /// <param name="linesizes">the array containing the linesize for each plane, should be filled by av_image_fill_linesizes()</param>
        /// <returns>&gt;= 0 in case of success, a negative error code otherwise</returns>
        public int av_image_fill_plane_sizes(ulong_array4 @size, AVPixelFormat @pix_fmt, int @height, long_array4 @linesizes)
        {
            return av_image_fill_plane_sizes_ptr(@size, @pix_fmt, @height, @linesizes);
        }

        private av_image_fill_pointers_delegate? _av_image_fill_pointers_ptr;

        public av_image_fill_pointers_delegate av_image_fill_pointers_ptr => _av_image_fill_pointers_ptr ?? (_av_image_fill_pointers_ptr = NativeMethodDelegate<av_image_fill_pointers_delegate>());

        /// <summary>Fill plane data pointers for an image with pixel format pix_fmt and height height.</summary>
        /// <param name="data">pointers array to be filled with the pointer for each image plane</param>
        /// <param name="ptr">the pointer to a buffer which will contain the image</param>
        /// <param name="linesizes">the array containing the linesize for each plane, should be filled by av_image_fill_linesizes()</param>
        /// <returns>the size in bytes required for the image buffer, a negative error code in case of failure</returns>
        public int av_image_fill_pointers(byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, int_array4 @linesizes)
        {
            return av_image_fill_pointers_ptr(@data, @pix_fmt, @height, @ptr, @linesizes);
        }

        private av_image_get_buffer_size_delegate? _av_image_get_buffer_size_ptr;

        public av_image_get_buffer_size_delegate av_image_get_buffer_size_ptr => _av_image_get_buffer_size_ptr ?? (_av_image_get_buffer_size_ptr = NativeMethodDelegate<av_image_get_buffer_size_delegate>());

        /// <summary>Return the size in bytes of the amount of data required to store an image with the given parameters.</summary>
        /// <param name="pix_fmt">the pixel format of the image</param>
        /// <param name="width">the width of the image in pixels</param>
        /// <param name="height">the height of the image in pixels</param>
        /// <param name="align">the assumed linesize alignment</param>
        /// <returns>the buffer size in bytes, a negative error code in case of failure</returns>
        public int av_image_get_buffer_size(AVPixelFormat @pix_fmt, int @width, int @height, int @align)
        {
            return av_image_get_buffer_size_ptr(@pix_fmt, @width, @height, @align);
        }

        private av_image_get_linesize_delegate? _av_image_get_linesize_ptr;

        public av_image_get_linesize_delegate av_image_get_linesize_ptr => _av_image_get_linesize_ptr ?? (_av_image_get_linesize_ptr = NativeMethodDelegate<av_image_get_linesize_delegate>());

        /// <summary>Compute the size of an image line with format pix_fmt and width width for the plane plane.</summary>
        /// <returns>the computed size in bytes</returns>
        public int av_image_get_linesize(AVPixelFormat @pix_fmt, int @width, int @plane)
        {
            return av_image_get_linesize_ptr(@pix_fmt, @width, @plane);
        }

        private av_int_list_length_for_size_delegate? _av_int_list_length_for_size_ptr;

        public av_int_list_length_for_size_delegate av_int_list_length_for_size_ptr => _av_int_list_length_for_size_ptr ?? (_av_int_list_length_for_size_ptr = NativeMethodDelegate<av_int_list_length_for_size_delegate>());

        /// <summary>Compute the length of an integer list.</summary>
        /// <param name="elsize">size in bytes of each list element (only 1, 2, 4 or 8)</param>
        /// <param name="list">pointer to the list</param>
        /// <param name="term">list terminator (usually 0 or -1)</param>
        /// <returns>length of the list, in elements, not counting the terminator</returns>
        public uint av_int_list_length_for_size(uint @elsize, void* @list, ulong @term)
        {
            return av_int_list_length_for_size_ptr(@elsize, @list, @term);
        }

        private av_log_delegate? _av_log_ptr;

        public av_log_delegate av_log_ptr => _av_log_ptr ?? (_av_log_ptr = NativeMethodDelegate<av_log_delegate>());

        /// <summary>Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct or NULL if general log.</param>
        /// <param name="level">The importance level of the message expressed using a &quot;Logging Constant&quot;.</param>
        /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
        public void av_log(void* @avcl, int @level,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt)
        {
            av_log_ptr(@avcl, @level, @fmt);
        }

        private av_log_default_callback_delegate? _av_log_default_callback_ptr;

        public av_log_default_callback_delegate av_log_default_callback_ptr => _av_log_default_callback_ptr ?? (_av_log_default_callback_ptr = NativeMethodDelegate<av_log_default_callback_delegate>());

        /// <summary>Default logging callback</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message expressed using a &quot;Logging Constant&quot;.</param>
        /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
        /// <param name="vl">The arguments referenced by the format string.</param>
        public void av_log_default_callback(void* @avcl, int @level,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl)
        {
            av_log_default_callback_ptr(@avcl, @level, @fmt, @vl);
        }

        private av_log_format_line_delegate? _av_log_format_line_ptr;

        public av_log_format_line_delegate av_log_format_line_ptr => _av_log_format_line_ptr ?? (_av_log_format_line_ptr = NativeMethodDelegate<av_log_format_line_delegate>());

        /// <summary>Format a line of log the same way as the default callback.</summary>
        /// <param name="line">buffer to receive the formatted line</param>
        /// <param name="line_size">size of the buffer</param>
        /// <param name="print_prefix">used to store whether the prefix must be printed; must point to a persistent integer initially set to 1</param>
        public void av_log_format_line(void* @ptr, int @level,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix)
        {
            av_log_format_line_ptr(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
        }

        private av_log_format_line2_delegate? _av_log_format_line2_ptr;

        public av_log_format_line2_delegate av_log_format_line2_ptr => _av_log_format_line2_ptr ?? (_av_log_format_line2_ptr = NativeMethodDelegate<av_log_format_line2_delegate>());

        /// <summary>Format a line of log the same way as the default callback.</summary>
        /// <param name="line">buffer to receive the formatted line; may be NULL if line_size is 0</param>
        /// <param name="line_size">size of the buffer; at most line_size-1 characters will be written to the buffer, plus one null terminator</param>
        /// <param name="print_prefix">used to store whether the prefix must be printed; must point to a persistent integer initially set to 1</param>
        /// <returns>Returns a negative value if an error occurred, otherwise returns the number of characters that would have been written for a sufficiently large buffer, not including the terminating null character. If the return value is not less than line_size, it means that the log message was truncated to fit the buffer.</returns>
        public int av_log_format_line2(void* @ptr, int @level,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix)
        {
            return av_log_format_line2_ptr(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
        }

        private av_log_get_flags_delegate? _av_log_get_flags_ptr;

        public av_log_get_flags_delegate av_log_get_flags_ptr => _av_log_get_flags_ptr ?? (_av_log_get_flags_ptr = NativeMethodDelegate<av_log_get_flags_delegate>());

        public int av_log_get_flags()
        {
            return av_log_get_flags_ptr();
        }

        private av_log_get_level_delegate? _av_log_get_level_ptr;

        public av_log_get_level_delegate av_log_get_level_ptr => _av_log_get_level_ptr ?? (_av_log_get_level_ptr = NativeMethodDelegate<av_log_get_level_delegate>());

        /// <summary>Get the current log level</summary>
        /// <returns>Current log level</returns>
        public int av_log_get_level()
        {
            return av_log_get_level_ptr();
        }

        private av_log_once_delegate? _av_log_once_ptr;

        public av_log_once_delegate av_log_once_ptr => _av_log_once_ptr ?? (_av_log_once_ptr = NativeMethodDelegate<av_log_once_delegate>());

        /// <summary>Send the specified message to the log once with the initial_level and then with the subsequent_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct or NULL if general log.</param>
        /// <param name="initial_level">importance level of the message expressed using a &quot;Logging Constant&quot; for the first occurance.</param>
        /// <param name="subsequent_level">importance level of the message expressed using a &quot;Logging Constant&quot; after the first occurance.</param>
        /// <param name="state">a variable to keep trak of if a message has already been printed this must be initialized to 0 before the first use. The same state must not be accessed by 2 Threads simultaneously.</param>
        /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
        public void av_log_once(void* @avcl, int @initial_level, int @subsequent_level, int* @state,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt)
        {
            av_log_once_ptr(@avcl, @initial_level, @subsequent_level, @state, @fmt);
        }

        private av_log_set_callback_delegate? _av_log_set_callback_ptr;

        public av_log_set_callback_delegate av_log_set_callback_ptr => _av_log_set_callback_ptr ?? (_av_log_set_callback_ptr = NativeMethodDelegate<av_log_set_callback_delegate>());

        /// <summary>Set the logging callback</summary>
        /// <param name="callback">A logging function with a compatible signature.</param>
        public void av_log_set_callback(av_log_set_callback_callback_func @callback)
        {
            av_log_set_callback_ptr(@callback);
        }

        private av_log_set_flags_delegate? _av_log_set_flags_ptr;

        public av_log_set_flags_delegate av_log_set_flags_ptr => _av_log_set_flags_ptr ?? (_av_log_set_flags_ptr = NativeMethodDelegate<av_log_set_flags_delegate>());

        public void av_log_set_flags(int @arg)
        {
            av_log_set_flags_ptr(@arg);
        }

        private av_log_set_level_delegate? _av_log_set_level_ptr;

        public av_log_set_level_delegate av_log_set_level_ptr => _av_log_set_level_ptr ?? (_av_log_set_level_ptr = NativeMethodDelegate<av_log_set_level_delegate>());

        /// <summary>Set the log level</summary>
        /// <param name="level">Logging level</param>
        public void av_log_set_level(int @level)
        {
            av_log_set_level_ptr(@level);
        }

        private av_log2_delegate? _av_log2_ptr;

        public av_log2_delegate av_log2_ptr => _av_log2_ptr ?? (_av_log2_ptr = NativeMethodDelegate<av_log2_delegate>());

        public int av_log2(uint @v)
        {
            return av_log2_ptr(@v);
        }

        private av_log2_16bit_delegate? _av_log2_16bit_ptr;

        public av_log2_16bit_delegate av_log2_16bit_ptr => _av_log2_16bit_ptr ?? (_av_log2_16bit_ptr = NativeMethodDelegate<av_log2_16bit_delegate>());

        public int av_log2_16bit(uint @v)
        {
            return av_log2_16bit_ptr(@v);
        }

        private av_malloc_delegate? _av_malloc_ptr;

        public av_malloc_delegate av_malloc_ptr => _av_malloc_ptr ?? (_av_malloc_ptr = NativeMethodDelegate<av_malloc_delegate>());

        /// <summary>Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU).</summary>
        /// <param name="size">Size in bytes for the memory block to be allocated</param>
        /// <returns>Pointer to the allocated block, or `NULL` if the block cannot be allocated</returns>
        public void* av_malloc(ulong @size)
        {
            return av_malloc_ptr(@size);
        }

        private av_malloc_array_delegate? _av_malloc_array_ptr;

        public av_malloc_array_delegate av_malloc_array_ptr => _av_malloc_array_ptr ?? (_av_malloc_array_ptr = NativeMethodDelegate<av_malloc_array_delegate>());

        /// <summary>Allocate a memory block for an array with av_malloc().</summary>
        /// <param name="nmemb">Number of element</param>
        /// <param name="size">Size of a single element</param>
        /// <returns>Pointer to the allocated block, or `NULL` if the block cannot be allocated</returns>
        public void* av_malloc_array(ulong @nmemb, ulong @size)
        {
            return av_malloc_array_ptr(@nmemb, @size);
        }

        private av_mallocz_delegate? _av_mallocz_ptr;

        public av_mallocz_delegate av_mallocz_ptr => _av_mallocz_ptr ?? (_av_mallocz_ptr = NativeMethodDelegate<av_mallocz_delegate>());

        /// <summary>Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU) and zero all the bytes of the block.</summary>
        /// <param name="size">Size in bytes for the memory block to be allocated</param>
        /// <returns>Pointer to the allocated block, or `NULL` if it cannot be allocated</returns>
        public void* av_mallocz(ulong @size)
        {
            return av_mallocz_ptr(@size);
        }

        private av_mallocz_array_delegate? _av_mallocz_array_ptr;

        public av_mallocz_array_delegate av_mallocz_array_ptr => _av_mallocz_array_ptr ?? (_av_mallocz_array_ptr = NativeMethodDelegate<av_mallocz_array_delegate>());

        [Obsolete("use av_calloc()")]
        public void* av_mallocz_array(ulong @nmemb, ulong @size)
        {
            return av_mallocz_array_ptr(@nmemb, @size);
        }

        private av_mastering_display_metadata_alloc_delegate? _av_mastering_display_metadata_alloc_ptr;

        public av_mastering_display_metadata_alloc_delegate av_mastering_display_metadata_alloc_ptr => _av_mastering_display_metadata_alloc_ptr ?? (_av_mastering_display_metadata_alloc_ptr = NativeMethodDelegate<av_mastering_display_metadata_alloc_delegate>());

        /// <summary>Allocate an AVMasteringDisplayMetadata structure and set its fields to default values. The resulting struct can be freed using av_freep().</summary>
        /// <returns>An AVMasteringDisplayMetadata filled with default values or NULL on failure.</returns>
        public AVMasteringDisplayMetadata* av_mastering_display_metadata_alloc()
        {
            return av_mastering_display_metadata_alloc_ptr();
        }

        private av_mastering_display_metadata_create_side_data_delegate? _av_mastering_display_metadata_create_side_data_ptr;

        public av_mastering_display_metadata_create_side_data_delegate av_mastering_display_metadata_create_side_data_ptr => _av_mastering_display_metadata_create_side_data_ptr ?? (_av_mastering_display_metadata_create_side_data_ptr = NativeMethodDelegate<av_mastering_display_metadata_create_side_data_delegate>());

        /// <summary>Allocate a complete AVMasteringDisplayMetadata and add it to the frame.</summary>
        /// <param name="frame">The frame which side data is added to.</param>
        /// <returns>The AVMasteringDisplayMetadata structure to be filled by caller.</returns>
        public AVMasteringDisplayMetadata* av_mastering_display_metadata_create_side_data(AVFrame* @frame)
        {
            return av_mastering_display_metadata_create_side_data_ptr(@frame);
        }

        private av_max_alloc_delegate? _av_max_alloc_ptr;

        public av_max_alloc_delegate av_max_alloc_ptr => _av_max_alloc_ptr ?? (_av_max_alloc_ptr = NativeMethodDelegate<av_max_alloc_delegate>());

        /// <summary>Set the maximum size that may be allocated in one block.</summary>
        /// <param name="max">Value to be set as the new maximum size</param>
        public void av_max_alloc(ulong @max)
        {
            av_max_alloc_ptr(@max);
        }

        private av_memcpy_backptr_delegate? _av_memcpy_backptr_ptr;

        public av_memcpy_backptr_delegate av_memcpy_backptr_ptr => _av_memcpy_backptr_ptr ?? (_av_memcpy_backptr_ptr = NativeMethodDelegate<av_memcpy_backptr_delegate>());

        /// <summary>Overlapping memcpy() implementation.</summary>
        /// <param name="dst">Destination buffer</param>
        /// <param name="back">Number of bytes back to start copying (i.e. the initial size of the overlapping window); must be &gt; 0</param>
        /// <param name="cnt">Number of bytes to copy; must be &gt;= 0</param>
        public void av_memcpy_backptr(byte* @dst, int @back, int @cnt)
        {
            av_memcpy_backptr_ptr(@dst, @back, @cnt);
        }

        private av_memdup_delegate? _av_memdup_ptr;

        public av_memdup_delegate av_memdup_ptr => _av_memdup_ptr ?? (_av_memdup_ptr = NativeMethodDelegate<av_memdup_delegate>());

        /// <summary>Duplicate a buffer with av_malloc().</summary>
        /// <param name="p">Buffer to be duplicated</param>
        /// <param name="size">Size in bytes of the buffer copied</param>
        /// <returns>Pointer to a newly allocated buffer containing a copy of `p` or `NULL` if the buffer cannot be allocated</returns>
        public void* av_memdup(void* @p, ulong @size)
        {
            return av_memdup_ptr(@p, @size);
        }

        private av_mul_q_delegate? _av_mul_q_ptr;

        public av_mul_q_delegate av_mul_q_ptr => _av_mul_q_ptr ?? (_av_mul_q_ptr = NativeMethodDelegate<av_mul_q_delegate>());

        /// <summary>Multiply two rationals.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        /// <returns>b*c</returns>
        public AVRational av_mul_q(AVRational @b, AVRational @c)
        {
            return av_mul_q_ptr(@b, @c);
        }

        private av_nearer_q_delegate? _av_nearer_q_ptr;

        public av_nearer_q_delegate av_nearer_q_ptr => _av_nearer_q_ptr ?? (_av_nearer_q_ptr = NativeMethodDelegate<av_nearer_q_delegate>());

        /// <summary>Find which of the two rationals is closer to another rational.</summary>
        /// <param name="q">Rational to be compared against</param>
        /// <returns>One of the following values: - 1 if `q1` is nearer to `q` than `q2` - -1 if `q2` is nearer to `q` than `q1` - 0 if they have the same distance</returns>
        public int av_nearer_q(AVRational @q, AVRational @q1, AVRational @q2)
        {
            return av_nearer_q_ptr(@q, @q1, @q2);
        }

        private av_opt_child_class_iterate_delegate? _av_opt_child_class_iterate_ptr;

        public av_opt_child_class_iterate_delegate av_opt_child_class_iterate_ptr => _av_opt_child_class_iterate_ptr ?? (_av_opt_child_class_iterate_ptr = NativeMethodDelegate<av_opt_child_class_iterate_delegate>());

        /// <summary>Iterate over potential AVOptions-enabled children of parent.</summary>
        /// <param name="iter">a pointer where iteration state is stored.</param>
        /// <returns>AVClass corresponding to next potential child or NULL</returns>
        public AVClass* av_opt_child_class_iterate(AVClass* @parent, void** @iter)
        {
            return av_opt_child_class_iterate_ptr(@parent, @iter);
        }

        private av_opt_child_next_delegate? _av_opt_child_next_ptr;

        public av_opt_child_next_delegate av_opt_child_next_ptr => _av_opt_child_next_ptr ?? (_av_opt_child_next_ptr = NativeMethodDelegate<av_opt_child_next_delegate>());

        /// <summary>Iterate over AVOptions-enabled children of obj.</summary>
        /// <param name="prev">result of a previous call to this function or NULL</param>
        /// <returns>next AVOptions-enabled child or NULL</returns>
        public void* av_opt_child_next(void* @obj, void* @prev)
        {
            return av_opt_child_next_ptr(@obj, @prev);
        }

        private av_opt_copy_delegate? _av_opt_copy_ptr;

        public av_opt_copy_delegate av_opt_copy_ptr => _av_opt_copy_ptr ?? (_av_opt_copy_ptr = NativeMethodDelegate<av_opt_copy_delegate>());

        /// <summary>Copy options from src object into dest object.</summary>
        /// <param name="dest">Object to copy from</param>
        /// <param name="src">Object to copy into</param>
        /// <returns>0 on success, negative on error</returns>
        public int av_opt_copy(void* @dest, void* @src)
        {
            return av_opt_copy_ptr(@dest, @src);
        }

        private av_opt_eval_double_delegate? _av_opt_eval_double_ptr;

        public av_opt_eval_double_delegate av_opt_eval_double_ptr => _av_opt_eval_double_ptr ?? (_av_opt_eval_double_ptr = NativeMethodDelegate<av_opt_eval_double_delegate>());

        public int av_opt_eval_double(void* @obj, AVOption* @o,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, double* @double_out)
        {
            return av_opt_eval_double_ptr(@obj, @o, @val, @double_out);
        }

        private av_opt_eval_flags_delegate? _av_opt_eval_flags_ptr;

        public av_opt_eval_flags_delegate av_opt_eval_flags_ptr => _av_opt_eval_flags_ptr ?? (_av_opt_eval_flags_ptr = NativeMethodDelegate<av_opt_eval_flags_delegate>());

        /// <summary>@{ This group of functions can be used to evaluate option strings and get numbers out of them. They do the same thing as av_opt_set(), except the result is written into the caller-supplied pointer.</summary>
        /// <param name="obj">a struct whose first element is a pointer to AVClass.</param>
        /// <param name="o">an option for which the string is to be evaluated.</param>
        /// <param name="val">string to be evaluated.</param>
        /// <returns>0 on success, a negative number on failure.</returns>
        public int av_opt_eval_flags(void* @obj, AVOption* @o,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, int* @flags_out)
        {
            return av_opt_eval_flags_ptr(@obj, @o, @val, @flags_out);
        }

        private av_opt_eval_float_delegate? _av_opt_eval_float_ptr;

        public av_opt_eval_float_delegate av_opt_eval_float_ptr => _av_opt_eval_float_ptr ?? (_av_opt_eval_float_ptr = NativeMethodDelegate<av_opt_eval_float_delegate>());

        public int av_opt_eval_float(void* @obj, AVOption* @o,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, float* @float_out)
        {
            return av_opt_eval_float_ptr(@obj, @o, @val, @float_out);
        }

        private av_opt_eval_int_delegate? _av_opt_eval_int_ptr;

        public av_opt_eval_int_delegate av_opt_eval_int_ptr => _av_opt_eval_int_ptr ?? (_av_opt_eval_int_ptr = NativeMethodDelegate<av_opt_eval_int_delegate>());

        public int av_opt_eval_int(void* @obj, AVOption* @o,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, int* @int_out)
        {
            return av_opt_eval_int_ptr(@obj, @o, @val, @int_out);
        }

        private av_opt_eval_int64_delegate? _av_opt_eval_int64_ptr;

        public av_opt_eval_int64_delegate av_opt_eval_int64_ptr => _av_opt_eval_int64_ptr ?? (_av_opt_eval_int64_ptr = NativeMethodDelegate<av_opt_eval_int64_delegate>());

        public int av_opt_eval_int64(void* @obj, AVOption* @o,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, long* @int64_out)
        {
            return av_opt_eval_int64_ptr(@obj, @o, @val, @int64_out);
        }

        private av_opt_eval_q_delegate? _av_opt_eval_q_ptr;

        public av_opt_eval_q_delegate av_opt_eval_q_ptr => _av_opt_eval_q_ptr ?? (_av_opt_eval_q_ptr = NativeMethodDelegate<av_opt_eval_q_delegate>());

        public int av_opt_eval_q(void* @obj, AVOption* @o,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @val, AVRational* @q_out)
        {
            return av_opt_eval_q_ptr(@obj, @o, @val, @q_out);
        }

        private av_opt_find_delegate? _av_opt_find_ptr;

        public av_opt_find_delegate av_opt_find_ptr => _av_opt_find_ptr ?? (_av_opt_find_ptr = NativeMethodDelegate<av_opt_find_delegate>());

        /// <summary>Look for an option in an object. Consider only options which have all the specified flags set.</summary>
        /// <param name="obj">A pointer to a struct whose first element is a pointer to an AVClass. Alternatively a double pointer to an AVClass, if AV_OPT_SEARCH_FAKE_OBJ search flag is set.</param>
        /// <param name="name">The name of the option to look for.</param>
        /// <param name="unit">When searching for named constants, name of the unit it belongs to.</param>
        /// <param name="opt_flags">Find only options with all the specified flags set (AV_OPT_FLAG).</param>
        /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
        /// <returns>A pointer to the option found, or NULL if no option was found.</returns>
        public AVOption* av_opt_find(void* @obj,
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
    string @unit, int @opt_flags, int @search_flags)
        {
            return av_opt_find_ptr(@obj, @name, @unit, @opt_flags, @search_flags);
        }

        private av_opt_find2_delegate? _av_opt_find2_ptr;

        public av_opt_find2_delegate av_opt_find2_ptr => _av_opt_find2_ptr ?? (_av_opt_find2_ptr = NativeMethodDelegate<av_opt_find2_delegate>());

        /// <summary>Look for an option in an object. Consider only options which have all the specified flags set.</summary>
        /// <param name="obj">A pointer to a struct whose first element is a pointer to an AVClass. Alternatively a double pointer to an AVClass, if AV_OPT_SEARCH_FAKE_OBJ search flag is set.</param>
        /// <param name="name">The name of the option to look for.</param>
        /// <param name="unit">When searching for named constants, name of the unit it belongs to.</param>
        /// <param name="opt_flags">Find only options with all the specified flags set (AV_OPT_FLAG).</param>
        /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
        /// <param name="target_obj">if non-NULL, an object to which the option belongs will be written here. It may be different from obj if AV_OPT_SEARCH_CHILDREN is present in search_flags. This parameter is ignored if search_flags contain AV_OPT_SEARCH_FAKE_OBJ.</param>
        /// <returns>A pointer to the option found, or NULL if no option was found.</returns>
        public AVOption* av_opt_find2(void* @obj,
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
    string @unit, int @opt_flags, int @search_flags, void** @target_obj)
        {
            return av_opt_find2_ptr(@obj, @name, @unit, @opt_flags, @search_flags, @target_obj);
        }

        private av_opt_flag_is_set_delegate? _av_opt_flag_is_set_ptr;

        public av_opt_flag_is_set_delegate av_opt_flag_is_set_ptr => _av_opt_flag_is_set_ptr ?? (_av_opt_flag_is_set_ptr = NativeMethodDelegate<av_opt_flag_is_set_delegate>());

        /// <summary>Check whether a particular flag is set in a flags field.</summary>
        /// <param name="field_name">the name of the flag field option</param>
        /// <param name="flag_name">the name of the flag to check</param>
        /// <returns>non-zero if the flag is set, zero if the flag isn&apos;t set, isn&apos;t of the right type, or the flags field doesn&apos;t exist.</returns>
        public int av_opt_flag_is_set(void* @obj,
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
    string @flag_name)
        {
            return av_opt_flag_is_set_ptr(@obj, @field_name, @flag_name);
        }

        private av_opt_free_delegate? _av_opt_free_ptr;

        public av_opt_free_delegate av_opt_free_ptr => _av_opt_free_ptr ?? (_av_opt_free_ptr = NativeMethodDelegate<av_opt_free_delegate>());

        /// <summary>Free all allocated objects in obj.</summary>
        public void av_opt_free(void* @obj)
        {
            av_opt_free_ptr(@obj);
        }

        private av_opt_freep_ranges_delegate? _av_opt_freep_ranges_ptr;

        public av_opt_freep_ranges_delegate av_opt_freep_ranges_ptr => _av_opt_freep_ranges_ptr ?? (_av_opt_freep_ranges_ptr = NativeMethodDelegate<av_opt_freep_ranges_delegate>());

        /// <summary>Free an AVOptionRanges struct and set it to NULL.</summary>
        public void av_opt_freep_ranges(AVOptionRanges** @ranges)
        {
            av_opt_freep_ranges_ptr(@ranges);
        }

        private av_opt_get_delegate? _av_opt_get_ptr;

        public av_opt_get_delegate av_opt_get_ptr => _av_opt_get_ptr ?? (_av_opt_get_ptr = NativeMethodDelegate<av_opt_get_delegate>());

        /// <summary>@{ Those functions get a value of the option with the given name from an object.</summary>
        /// <param name="obj">a struct whose first element is a pointer to an AVClass.</param>
        /// <param name="name">name of the option to get.</param>
        /// <param name="search_flags">flags passed to av_opt_find2. I.e. if AV_OPT_SEARCH_CHILDREN is passed here, then the option may be found in a child of obj.</param>
        /// <param name="out_val">value of the option will be written here</param>
        /// <returns>&gt;=0 on success, a negative error code otherwise</returns>
        public int av_opt_get(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, byte** @out_val)
        {
            return av_opt_get_ptr(@obj, @name, @search_flags, @out_val);
        }

        private av_opt_get_channel_layout_delegate? _av_opt_get_channel_layout_ptr;

        public av_opt_get_channel_layout_delegate av_opt_get_channel_layout_ptr => _av_opt_get_channel_layout_ptr ?? (_av_opt_get_channel_layout_ptr = NativeMethodDelegate<av_opt_get_channel_layout_delegate>());

        public int av_opt_get_channel_layout(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, long* @ch_layout)
        {
            return av_opt_get_channel_layout_ptr(@obj, @name, @search_flags, @ch_layout);
        }

        private av_opt_get_dict_val_delegate? _av_opt_get_dict_val_ptr;

        public av_opt_get_dict_val_delegate av_opt_get_dict_val_ptr => _av_opt_get_dict_val_ptr ?? (_av_opt_get_dict_val_ptr = NativeMethodDelegate<av_opt_get_dict_val_delegate>());

        /// <param name="out_val">The returned dictionary is a copy of the actual value and must be freed with av_dict_free() by the caller</param>
        public int av_opt_get_dict_val(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVDictionary** @out_val)
        {
            return av_opt_get_dict_val_ptr(@obj, @name, @search_flags, @out_val);
        }

        private av_opt_get_double_delegate? _av_opt_get_double_ptr;

        public av_opt_get_double_delegate av_opt_get_double_ptr => _av_opt_get_double_ptr ?? (_av_opt_get_double_ptr = NativeMethodDelegate<av_opt_get_double_delegate>());

        public int av_opt_get_double(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, double* @out_val)
        {
            return av_opt_get_double_ptr(@obj, @name, @search_flags, @out_val);
        }

        private av_opt_get_image_size_delegate? _av_opt_get_image_size_ptr;

        public av_opt_get_image_size_delegate av_opt_get_image_size_ptr => _av_opt_get_image_size_ptr ?? (_av_opt_get_image_size_ptr = NativeMethodDelegate<av_opt_get_image_size_delegate>());

        public int av_opt_get_image_size(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, int* @w_out, int* @h_out)
        {
            return av_opt_get_image_size_ptr(@obj, @name, @search_flags, @w_out, @h_out);
        }

        private av_opt_get_int_delegate? _av_opt_get_int_ptr;

        public av_opt_get_int_delegate av_opt_get_int_ptr => _av_opt_get_int_ptr ?? (_av_opt_get_int_ptr = NativeMethodDelegate<av_opt_get_int_delegate>());

        public int av_opt_get_int(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, long* @out_val)
        {
            return av_opt_get_int_ptr(@obj, @name, @search_flags, @out_val);
        }

        private av_opt_get_key_value_delegate? _av_opt_get_key_value_ptr;

        public av_opt_get_key_value_delegate av_opt_get_key_value_ptr => _av_opt_get_key_value_ptr ?? (_av_opt_get_key_value_ptr = NativeMethodDelegate<av_opt_get_key_value_delegate>());

        /// <summary>Extract a key-value pair from the beginning of a string.</summary>
        /// <param name="ropts">pointer to the options string, will be updated to point to the rest of the string (one of the pairs_sep or the final NUL)</param>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
        /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
        /// <param name="rkey">parsed key; must be freed using av_free()</param>
        /// <param name="rval">parsed value; must be freed using av_free()</param>
        /// <returns>&gt;=0 for success, or a negative value corresponding to an AVERROR code in case of error; in particular: AVERROR(EINVAL) if no key is present</returns>
        public int av_opt_get_key_value(byte** @ropts,
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
    string @pairs_sep, uint @flags, byte** @rkey, byte** @rval)
        {
            return av_opt_get_key_value_ptr(@ropts, @key_val_sep, @pairs_sep, @flags, @rkey, @rval);
        }

        private av_opt_get_pixel_fmt_delegate? _av_opt_get_pixel_fmt_ptr;

        public av_opt_get_pixel_fmt_delegate av_opt_get_pixel_fmt_ptr => _av_opt_get_pixel_fmt_ptr ?? (_av_opt_get_pixel_fmt_ptr = NativeMethodDelegate<av_opt_get_pixel_fmt_delegate>());

        public int av_opt_get_pixel_fmt(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVPixelFormat* @out_fmt)
        {
            return av_opt_get_pixel_fmt_ptr(@obj, @name, @search_flags, @out_fmt);
        }

        private av_opt_get_q_delegate? _av_opt_get_q_ptr;

        public av_opt_get_q_delegate av_opt_get_q_ptr => _av_opt_get_q_ptr ?? (_av_opt_get_q_ptr = NativeMethodDelegate<av_opt_get_q_delegate>());

        public int av_opt_get_q(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVRational* @out_val)
        {
            return av_opt_get_q_ptr(@obj, @name, @search_flags, @out_val);
        }

        private av_opt_get_sample_fmt_delegate? _av_opt_get_sample_fmt_ptr;

        public av_opt_get_sample_fmt_delegate av_opt_get_sample_fmt_ptr => _av_opt_get_sample_fmt_ptr ?? (_av_opt_get_sample_fmt_ptr = NativeMethodDelegate<av_opt_get_sample_fmt_delegate>());

        public int av_opt_get_sample_fmt(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVSampleFormat* @out_fmt)
        {
            return av_opt_get_sample_fmt_ptr(@obj, @name, @search_flags, @out_fmt);
        }

        private av_opt_get_video_rate_delegate? _av_opt_get_video_rate_ptr;

        public av_opt_get_video_rate_delegate av_opt_get_video_rate_ptr => _av_opt_get_video_rate_ptr ?? (_av_opt_get_video_rate_ptr = NativeMethodDelegate<av_opt_get_video_rate_delegate>());

        public int av_opt_get_video_rate(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags, AVRational* @out_val)
        {
            return av_opt_get_video_rate_ptr(@obj, @name, @search_flags, @out_val);
        }

        private av_opt_is_set_to_default_delegate? _av_opt_is_set_to_default_ptr;

        public av_opt_is_set_to_default_delegate av_opt_is_set_to_default_ptr => _av_opt_is_set_to_default_ptr ?? (_av_opt_is_set_to_default_ptr = NativeMethodDelegate<av_opt_is_set_to_default_delegate>());

        /// <summary>Check if given option is set to its default value.</summary>
        /// <param name="obj">AVClass object to check option on</param>
        /// <param name="o">option to be checked</param>
        /// <returns>&gt;0 when option is set to its default, 0 when option is not set its default,  &lt; 0 on error</returns>
        public int av_opt_is_set_to_default(void* @obj, AVOption* @o)
        {
            return av_opt_is_set_to_default_ptr(@obj, @o);
        }

        private av_opt_is_set_to_default_by_name_delegate? _av_opt_is_set_to_default_by_name_ptr;

        public av_opt_is_set_to_default_by_name_delegate av_opt_is_set_to_default_by_name_ptr => _av_opt_is_set_to_default_by_name_ptr ?? (_av_opt_is_set_to_default_by_name_ptr = NativeMethodDelegate<av_opt_is_set_to_default_by_name_delegate>());

        /// <summary>Check if given option is set to its default value.</summary>
        /// <param name="obj">AVClass object to check option on</param>
        /// <param name="name">option name</param>
        /// <param name="search_flags">combination of AV_OPT_SEARCH_*</param>
        /// <returns>&gt;0 when option is set to its default, 0 when option is not set its default,  &lt; 0 on error</returns>
        public int av_opt_is_set_to_default_by_name(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @search_flags)
        {
            return av_opt_is_set_to_default_by_name_ptr(@obj, @name, @search_flags);
        }

        private av_opt_next_delegate? _av_opt_next_ptr;

        public av_opt_next_delegate av_opt_next_ptr => _av_opt_next_ptr ?? (_av_opt_next_ptr = NativeMethodDelegate<av_opt_next_delegate>());

        /// <summary>Iterate over all AVOptions belonging to obj.</summary>
        /// <param name="obj">an AVOptions-enabled struct or a double pointer to an AVClass describing it.</param>
        /// <param name="prev">result of the previous call to av_opt_next() on this object or NULL</param>
        /// <returns>next AVOption or NULL</returns>
        public AVOption* av_opt_next(void* @obj, AVOption* @prev)
        {
            return av_opt_next_ptr(@obj, @prev);
        }

        private av_opt_ptr_delegate? _av_opt_ptr_ptr;

        public av_opt_ptr_delegate av_opt_ptr_ptr => _av_opt_ptr_ptr ?? (_av_opt_ptr_ptr = NativeMethodDelegate<av_opt_ptr_delegate>());

        /// <summary>@}</summary>
        public void* av_opt_ptr(AVClass* @avclass, void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name)
        {
            return av_opt_ptr_ptr(@avclass, @obj, @name);
        }

        private av_opt_query_ranges_delegate? _av_opt_query_ranges_ptr;

        public av_opt_query_ranges_delegate av_opt_query_ranges_ptr => _av_opt_query_ranges_ptr ?? (_av_opt_query_ranges_ptr = NativeMethodDelegate<av_opt_query_ranges_delegate>());

        /// <summary>Get a list of allowed ranges for the given option.</summary>
        /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
        /// <returns>number of compontents returned on success, a negative errro code otherwise</returns>
        public int av_opt_query_ranges(AVOptionRanges** @p0, void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, int @flags)
        {
            return av_opt_query_ranges_ptr(@p0, @obj, @key, @flags);
        }

        private av_opt_query_ranges_default_delegate? _av_opt_query_ranges_default_ptr;

        public av_opt_query_ranges_default_delegate av_opt_query_ranges_default_ptr => _av_opt_query_ranges_default_ptr ?? (_av_opt_query_ranges_default_ptr = NativeMethodDelegate<av_opt_query_ranges_default_delegate>());

        /// <summary>Get a default list of allowed ranges for the given option.</summary>
        /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
        /// <returns>number of compontents returned on success, a negative errro code otherwise</returns>
        public int av_opt_query_ranges_default(AVOptionRanges** @p0, void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @key, int @flags)
        {
            return av_opt_query_ranges_default_ptr(@p0, @obj, @key, @flags);
        }

        private av_opt_serialize_delegate? _av_opt_serialize_ptr;

        public av_opt_serialize_delegate av_opt_serialize_ptr => _av_opt_serialize_ptr ?? (_av_opt_serialize_ptr = NativeMethodDelegate<av_opt_serialize_delegate>());

        /// <summary>Serialize object&apos;s options.</summary>
        /// <param name="obj">AVClass object to serialize</param>
        /// <param name="opt_flags">serialize options with all the specified flags set (AV_OPT_FLAG)</param>
        /// <param name="flags">combination of AV_OPT_SERIALIZE_* flags</param>
        /// <param name="buffer">Pointer to buffer that will be allocated with string containg serialized options. Buffer must be freed by the caller when is no longer needed.</param>
        /// <param name="key_val_sep">character used to separate key from value</param>
        /// <param name="pairs_sep">character used to separate two pairs from each other</param>
        /// <returns>&gt;= 0 on success, negative on error</returns>
        public int av_opt_serialize(void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep)
        {
            return av_opt_serialize_ptr(@obj, @opt_flags, @flags, @buffer, @key_val_sep, @pairs_sep);
        }

        private av_opt_set_delegate? _av_opt_set_ptr;

        public av_opt_set_delegate av_opt_set_ptr => _av_opt_set_ptr ?? (_av_opt_set_ptr = NativeMethodDelegate<av_opt_set_delegate>());

        /// <summary>@{ Those functions set the field of obj with the given name to value.</summary>
        /// <param name="obj">A struct whose first element is a pointer to an AVClass.</param>
        /// <param name="name">the name of the field to set</param>
        /// <param name="val">The value to set. In case of av_opt_set() if the field is not of a string type, then the given string is parsed. SI postfixes and some named scalars are supported. If the field is of a numeric type, it has to be a numeric or named scalar. Behavior with more than one scalar and +- infix operators is undefined. If the field is of a flags type, it has to be a sequence of numeric scalars or named flags separated by &apos;+&apos; or &apos;-&apos;. Prefixing a flag with &apos;+&apos; causes it to be set without affecting the other flags; similarly, &apos;-&apos; unsets a flag. If the field is of a dictionary type, it has to be a &apos;:&apos; separated list of key=value parameters. Values containing &apos;:&apos; special characters must be escaped.</param>
        /// <param name="search_flags">flags passed to av_opt_find2. I.e. if AV_OPT_SEARCH_CHILDREN is passed here, then the option may be set on a child of obj.</param>
        /// <returns>0 if the value has been set, or an AVERROR code in case of error: AVERROR_OPTION_NOT_FOUND if no matching option exists AVERROR(ERANGE) if the value is out of range AVERROR(EINVAL) if the value is not valid</returns>
        public int av_opt_set(void* @obj,
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
    string @val, int @search_flags)
        {
            return av_opt_set_ptr(@obj, @name, @val, @search_flags);
        }

        private av_opt_set_bin_delegate? _av_opt_set_bin_ptr;

        public av_opt_set_bin_delegate av_opt_set_bin_ptr => _av_opt_set_bin_ptr ?? (_av_opt_set_bin_ptr = NativeMethodDelegate<av_opt_set_bin_delegate>());

        public int av_opt_set_bin(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, byte* @val, int @size, int @search_flags)
        {
            return av_opt_set_bin_ptr(@obj, @name, @val, @size, @search_flags);
        }

        private av_opt_set_channel_layout_delegate? _av_opt_set_channel_layout_ptr;

        public av_opt_set_channel_layout_delegate av_opt_set_channel_layout_ptr => _av_opt_set_channel_layout_ptr ?? (_av_opt_set_channel_layout_ptr = NativeMethodDelegate<av_opt_set_channel_layout_delegate>());

        public int av_opt_set_channel_layout(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, long @ch_layout, int @search_flags)
        {
            return av_opt_set_channel_layout_ptr(@obj, @name, @ch_layout, @search_flags);
        }

        private av_opt_set_defaults_delegate? _av_opt_set_defaults_ptr;

        public av_opt_set_defaults_delegate av_opt_set_defaults_ptr => _av_opt_set_defaults_ptr ?? (_av_opt_set_defaults_ptr = NativeMethodDelegate<av_opt_set_defaults_delegate>());

        /// <summary>Set the values of all AVOption fields to their default values.</summary>
        /// <param name="s">an AVOption-enabled struct (its first member must be a pointer to AVClass)</param>
        public void av_opt_set_defaults(void* @s)
        {
            av_opt_set_defaults_ptr(@s);
        }

        private av_opt_set_defaults2_delegate? _av_opt_set_defaults2_ptr;

        public av_opt_set_defaults2_delegate av_opt_set_defaults2_ptr => _av_opt_set_defaults2_ptr ?? (_av_opt_set_defaults2_ptr = NativeMethodDelegate<av_opt_set_defaults2_delegate>());

        /// <summary>Set the values of all AVOption fields to their default values. Only these AVOption fields for which (opt-&gt;flags &amp; mask) == flags will have their default applied to s.</summary>
        /// <param name="s">an AVOption-enabled struct (its first member must be a pointer to AVClass)</param>
        /// <param name="mask">combination of AV_OPT_FLAG_*</param>
        /// <param name="flags">combination of AV_OPT_FLAG_*</param>
        public void av_opt_set_defaults2(void* @s, int @mask, int @flags)
        {
            av_opt_set_defaults2_ptr(@s, @mask, @flags);
        }

        private av_opt_set_dict_delegate? _av_opt_set_dict_ptr;

        public av_opt_set_dict_delegate av_opt_set_dict_ptr => _av_opt_set_dict_ptr ?? (_av_opt_set_dict_ptr = NativeMethodDelegate<av_opt_set_dict_delegate>());

        /// <summary>Set all the options from a given dictionary on an object.</summary>
        /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
        /// <param name="options">options to process. This dictionary will be freed and replaced by a new one containing all options not found in obj. Of course this new dictionary needs to be freed by caller with av_dict_free().</param>
        /// <returns>0 on success, a negative AVERROR if some option was found in obj, but could not be set.</returns>
        public int av_opt_set_dict(void* @obj, AVDictionary** @options)
        {
            return av_opt_set_dict_ptr(@obj, @options);
        }

        private av_opt_set_dict_val_delegate? _av_opt_set_dict_val_ptr;

        public av_opt_set_dict_val_delegate av_opt_set_dict_val_ptr => _av_opt_set_dict_val_ptr ?? (_av_opt_set_dict_val_ptr = NativeMethodDelegate<av_opt_set_dict_val_delegate>());

        public int av_opt_set_dict_val(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVDictionary* @val, int @search_flags)
        {
            return av_opt_set_dict_val_ptr(@obj, @name, @val, @search_flags);
        }

        private av_opt_set_dict2_delegate? _av_opt_set_dict2_ptr;

        public av_opt_set_dict2_delegate av_opt_set_dict2_ptr => _av_opt_set_dict2_ptr ?? (_av_opt_set_dict2_ptr = NativeMethodDelegate<av_opt_set_dict2_delegate>());

        /// <summary>Set all the options from a given dictionary on an object.</summary>
        /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
        /// <param name="options">options to process. This dictionary will be freed and replaced by a new one containing all options not found in obj. Of course this new dictionary needs to be freed by caller with av_dict_free().</param>
        /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
        /// <returns>0 on success, a negative AVERROR if some option was found in obj, but could not be set.</returns>
        public int av_opt_set_dict2(void* @obj, AVDictionary** @options, int @search_flags)
        {
            return av_opt_set_dict2_ptr(@obj, @options, @search_flags);
        }

        private av_opt_set_double_delegate? _av_opt_set_double_ptr;

        public av_opt_set_double_delegate av_opt_set_double_ptr => _av_opt_set_double_ptr ?? (_av_opt_set_double_ptr = NativeMethodDelegate<av_opt_set_double_delegate>());

        public int av_opt_set_double(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, double @val, int @search_flags)
        {
            return av_opt_set_double_ptr(@obj, @name, @val, @search_flags);
        }

        private av_opt_set_from_string_delegate? _av_opt_set_from_string_ptr;

        public av_opt_set_from_string_delegate av_opt_set_from_string_ptr => _av_opt_set_from_string_ptr ?? (_av_opt_set_from_string_ptr = NativeMethodDelegate<av_opt_set_from_string_delegate>());

        /// <summary>Parse the key-value pairs list in opts. For each key=value pair found, set the value of the corresponding option in ctx.</summary>
        /// <param name="ctx">the AVClass object to set options on</param>
        /// <param name="opts">the options string, key-value pairs separated by a delimiter</param>
        /// <param name="shorthand">a NULL-terminated array of options names for shorthand notation: if the first field in opts has no key part, the key is taken from the first element of shorthand; then again for the second, etc., until either opts is finished, shorthand is finished or a named option is found; after that, all options must be named</param>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
        /// <returns>the number of successfully set key=value pairs, or a negative value corresponding to an AVERROR code in case of error: AVERROR(EINVAL) if opts cannot be parsed, the error code issued by av_set_string3() if a key/value pair cannot be set</returns>
        public int av_opt_set_from_string(void* @ctx,
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
    string @pairs_sep)
        {
            return av_opt_set_from_string_ptr(@ctx, @opts, @shorthand, @key_val_sep, @pairs_sep);
        }

        private av_opt_set_image_size_delegate? _av_opt_set_image_size_ptr;

        public av_opt_set_image_size_delegate av_opt_set_image_size_ptr => _av_opt_set_image_size_ptr ?? (_av_opt_set_image_size_ptr = NativeMethodDelegate<av_opt_set_image_size_delegate>());

        public int av_opt_set_image_size(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @w, int @h, int @search_flags)
        {
            return av_opt_set_image_size_ptr(@obj, @name, @w, @h, @search_flags);
        }

        private av_opt_set_int_delegate? _av_opt_set_int_ptr;

        public av_opt_set_int_delegate av_opt_set_int_ptr => _av_opt_set_int_ptr ?? (_av_opt_set_int_ptr = NativeMethodDelegate<av_opt_set_int_delegate>());

        public int av_opt_set_int(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, long @val, int @search_flags)
        {
            return av_opt_set_int_ptr(@obj, @name, @val, @search_flags);
        }

        private av_opt_set_pixel_fmt_delegate? _av_opt_set_pixel_fmt_ptr;

        public av_opt_set_pixel_fmt_delegate av_opt_set_pixel_fmt_ptr => _av_opt_set_pixel_fmt_ptr ?? (_av_opt_set_pixel_fmt_ptr = NativeMethodDelegate<av_opt_set_pixel_fmt_delegate>());

        public int av_opt_set_pixel_fmt(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVPixelFormat @fmt, int @search_flags)
        {
            return av_opt_set_pixel_fmt_ptr(@obj, @name, @fmt, @search_flags);
        }

        private av_opt_set_q_delegate? _av_opt_set_q_ptr;

        public av_opt_set_q_delegate av_opt_set_q_ptr => _av_opt_set_q_ptr ?? (_av_opt_set_q_ptr = NativeMethodDelegate<av_opt_set_q_delegate>());

        public int av_opt_set_q(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVRational @val, int @search_flags)
        {
            return av_opt_set_q_ptr(@obj, @name, @val, @search_flags);
        }

        private av_opt_set_sample_fmt_delegate? _av_opt_set_sample_fmt_ptr;

        public av_opt_set_sample_fmt_delegate av_opt_set_sample_fmt_ptr => _av_opt_set_sample_fmt_ptr ?? (_av_opt_set_sample_fmt_ptr = NativeMethodDelegate<av_opt_set_sample_fmt_delegate>());

        public int av_opt_set_sample_fmt(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVSampleFormat @fmt, int @search_flags)
        {
            return av_opt_set_sample_fmt_ptr(@obj, @name, @fmt, @search_flags);
        }

        private av_opt_set_video_rate_delegate? _av_opt_set_video_rate_ptr;

        public av_opt_set_video_rate_delegate av_opt_set_video_rate_ptr => _av_opt_set_video_rate_ptr ?? (_av_opt_set_video_rate_ptr = NativeMethodDelegate<av_opt_set_video_rate_delegate>());

        public int av_opt_set_video_rate(void* @obj,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, AVRational @val, int @search_flags)
        {
            return av_opt_set_video_rate_ptr(@obj, @name, @val, @search_flags);
        }

        private av_opt_show2_delegate? _av_opt_show2_ptr;

        public av_opt_show2_delegate av_opt_show2_ptr => _av_opt_show2_ptr ?? (_av_opt_show2_ptr = NativeMethodDelegate<av_opt_show2_delegate>());

        /// <summary>Show the obj options.</summary>
        /// <param name="av_log_obj">log context to use for showing the options</param>
        /// <param name="req_flags">requested flags for the options to show. Show only the options for which it is opt-&gt;flags &amp; req_flags.</param>
        /// <param name="rej_flags">rejected flags for the options to show. Show only the options for which it is !(opt-&gt;flags &amp; req_flags).</param>
        public int av_opt_show2(void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags)
        {
            return av_opt_show2_ptr(@obj, @av_log_obj, @req_flags, @rej_flags);
        }

        private av_parse_cpu_caps_delegate? _av_parse_cpu_caps_ptr;

        public av_parse_cpu_caps_delegate av_parse_cpu_caps_ptr => _av_parse_cpu_caps_ptr ?? (_av_parse_cpu_caps_ptr = NativeMethodDelegate<av_parse_cpu_caps_delegate>());

        /// <summary>Parse CPU caps from a string and update the given AV_CPU_* flags based on that.</summary>
        /// <returns>negative on error.</returns>
        public int av_parse_cpu_caps(uint* @flags,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @s)
        {
            return av_parse_cpu_caps_ptr(@flags, @s);
        }

        private av_pix_fmt_count_planes_delegate? _av_pix_fmt_count_planes_ptr;

        public av_pix_fmt_count_planes_delegate av_pix_fmt_count_planes_ptr => _av_pix_fmt_count_planes_ptr ?? (_av_pix_fmt_count_planes_ptr = NativeMethodDelegate<av_pix_fmt_count_planes_delegate>());

        /// <summary>Returns number of planes in pix_fmt, a negative AVERROR if pix_fmt is not a valid pixel format.</summary>
        /// <returns>number of planes in pix_fmt, a negative AVERROR if pix_fmt is not a valid pixel format.</returns>
        public int av_pix_fmt_count_planes(AVPixelFormat @pix_fmt)
        {
            return av_pix_fmt_count_planes_ptr(@pix_fmt);
        }

        private av_pix_fmt_desc_get_delegate? _av_pix_fmt_desc_get_ptr;

        public av_pix_fmt_desc_get_delegate av_pix_fmt_desc_get_ptr => _av_pix_fmt_desc_get_ptr ?? (_av_pix_fmt_desc_get_ptr = NativeMethodDelegate<av_pix_fmt_desc_get_delegate>());

        /// <summary>Returns a pixel format descriptor for provided pixel format or NULL if this pixel format is unknown.</summary>
        /// <returns>a pixel format descriptor for provided pixel format or NULL if this pixel format is unknown.</returns>
        public AVPixFmtDescriptor* av_pix_fmt_desc_get(AVPixelFormat @pix_fmt)
        {
            return av_pix_fmt_desc_get_ptr(@pix_fmt);
        }

        private av_pix_fmt_desc_get_id_delegate? _av_pix_fmt_desc_get_id_ptr;

        public av_pix_fmt_desc_get_id_delegate av_pix_fmt_desc_get_id_ptr => _av_pix_fmt_desc_get_id_ptr ?? (_av_pix_fmt_desc_get_id_ptr = NativeMethodDelegate<av_pix_fmt_desc_get_id_delegate>());

        /// <summary>Returns an AVPixelFormat id described by desc, or AV_PIX_FMT_NONE if desc is not a valid pointer to a pixel format descriptor.</summary>
        /// <returns>an AVPixelFormat id described by desc, or AV_PIX_FMT_NONE if desc is not a valid pointer to a pixel format descriptor.</returns>
        public AVPixelFormat av_pix_fmt_desc_get_id(AVPixFmtDescriptor* @desc)
        {
            return av_pix_fmt_desc_get_id_ptr(@desc);
        }

        private av_pix_fmt_desc_next_delegate? _av_pix_fmt_desc_next_ptr;

        public av_pix_fmt_desc_next_delegate av_pix_fmt_desc_next_ptr => _av_pix_fmt_desc_next_ptr ?? (_av_pix_fmt_desc_next_ptr = NativeMethodDelegate<av_pix_fmt_desc_next_delegate>());

        /// <summary>Iterate over all pixel format descriptors known to libavutil.</summary>
        /// <param name="prev">previous descriptor. NULL to get the first descriptor.</param>
        /// <returns>next descriptor or NULL after the last descriptor</returns>
        public AVPixFmtDescriptor* av_pix_fmt_desc_next(AVPixFmtDescriptor* @prev)
        {
            return av_pix_fmt_desc_next_ptr(@prev);
        }

        private av_pix_fmt_get_chroma_sub_sample_delegate? _av_pix_fmt_get_chroma_sub_sample_ptr;

        public av_pix_fmt_get_chroma_sub_sample_delegate av_pix_fmt_get_chroma_sub_sample_ptr => _av_pix_fmt_get_chroma_sub_sample_ptr ?? (_av_pix_fmt_get_chroma_sub_sample_ptr = NativeMethodDelegate<av_pix_fmt_get_chroma_sub_sample_delegate>());

        /// <summary>Utility function to access log2_chroma_w log2_chroma_h from the pixel format AVPixFmtDescriptor.</summary>
        /// <param name="pix_fmt">the pixel format</param>
        /// <param name="h_shift">store log2_chroma_w (horizontal/width shift)</param>
        /// <param name="v_shift">store log2_chroma_h (vertical/height shift)</param>
        /// <returns>0 on success, AVERROR(ENOSYS) on invalid or unknown pixel format</returns>
        public int av_pix_fmt_get_chroma_sub_sample(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift)
        {
            return av_pix_fmt_get_chroma_sub_sample_ptr(@pix_fmt, @h_shift, @v_shift);
        }

        private av_pix_fmt_swap_endianness_delegate? _av_pix_fmt_swap_endianness_ptr;

        public av_pix_fmt_swap_endianness_delegate av_pix_fmt_swap_endianness_ptr => _av_pix_fmt_swap_endianness_ptr ?? (_av_pix_fmt_swap_endianness_ptr = NativeMethodDelegate<av_pix_fmt_swap_endianness_delegate>());

        /// <summary>Utility function to swap the endianness of a pixel format.</summary>
        /// <param name="pix_fmt">the pixel format</param>
        /// <returns>pixel format with swapped endianness if it exists, otherwise AV_PIX_FMT_NONE</returns>
        public AVPixelFormat av_pix_fmt_swap_endianness(AVPixelFormat @pix_fmt)
        {
            return av_pix_fmt_swap_endianness_ptr(@pix_fmt);
        }

        private av_q2intfloat_delegate? _av_q2intfloat_ptr;

        public av_q2intfloat_delegate av_q2intfloat_ptr => _av_q2intfloat_ptr ?? (_av_q2intfloat_ptr = NativeMethodDelegate<av_q2intfloat_delegate>());

        /// <summary>Convert an AVRational to a IEEE 32-bit `float` expressed in fixed-point format.</summary>
        /// <param name="q">Rational to be converted</param>
        /// <returns>Equivalent floating-point value, expressed as an unsigned 32-bit integer.</returns>
        public uint av_q2intfloat(AVRational @q)
        {
            return av_q2intfloat_ptr(@q);
        }

        private av_read_image_line_delegate? _av_read_image_line_ptr;

        public av_read_image_line_delegate av_read_image_line_ptr => _av_read_image_line_ptr ?? (_av_read_image_line_ptr = NativeMethodDelegate<av_read_image_line_delegate>());

        public void av_read_image_line(ushort* @dst, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component)
        {
            av_read_image_line_ptr(@dst, ref @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component);
        }

        private av_read_image_line2_delegate? _av_read_image_line2_ptr;

        public av_read_image_line2_delegate av_read_image_line2_ptr => _av_read_image_line2_ptr ?? (_av_read_image_line2_ptr = NativeMethodDelegate<av_read_image_line2_delegate>());

        /// <summary>Read a line from an image, and write the values of the pixel format component c to dst.</summary>
        /// <param name="data">the array containing the pointers to the planes of the image</param>
        /// <param name="linesize">the array containing the linesizes of the image</param>
        /// <param name="desc">the pixel format descriptor for the image</param>
        /// <param name="x">the horizontal coordinate of the first pixel to read</param>
        /// <param name="y">the vertical coordinate of the first pixel to read</param>
        /// <param name="w">the width of the line to read, that is the number of values to write to dst</param>
        /// <param name="read_pal_component">if not zero and the format is a paletted format writes the values corresponding to the palette component c in data[1] to dst, rather than the palette indexes in data[0]. The behavior is undefined if the format is not paletted.</param>
        /// <param name="dst_element_size">size of elements in dst array (2 or 4 byte)</param>
        public void av_read_image_line2(void* @dst, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component, int @dst_element_size)
        {
            av_read_image_line2_ptr(@dst, ref @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component, @dst_element_size);
        }

        private av_realloc_delegate? _av_realloc_ptr;

        public av_realloc_delegate av_realloc_ptr => _av_realloc_ptr ?? (_av_realloc_ptr = NativeMethodDelegate<av_realloc_delegate>());

        /// <summary>Allocate, reallocate, or free a block of memory.</summary>
        /// <param name="ptr">Pointer to a memory block already allocated with av_realloc() or `NULL`</param>
        /// <param name="size">Size in bytes of the memory block to be allocated or reallocated</param>
        /// <returns>Pointer to a newly-reallocated block or `NULL` if the block cannot be reallocated or the function is used to free the memory block</returns>
        public void* av_realloc(void* @ptr, ulong @size)
        {
            return av_realloc_ptr(@ptr, @size);
        }

        private av_realloc_array_delegate? _av_realloc_array_ptr;

        public av_realloc_array_delegate av_realloc_array_ptr => _av_realloc_array_ptr ?? (_av_realloc_array_ptr = NativeMethodDelegate<av_realloc_array_delegate>());

        /// <summary>Allocate, reallocate, or free an array.</summary>
        /// <param name="ptr">Pointer to a memory block already allocated with av_realloc() or `NULL`</param>
        /// <param name="nmemb">Number of elements in the array</param>
        /// <param name="size">Size of the single element of the array</param>
        /// <returns>Pointer to a newly-reallocated block or NULL if the block cannot be reallocated or the function is used to free the memory block</returns>
        public void* av_realloc_array(void* @ptr, ulong @nmemb, ulong @size)
        {
            return av_realloc_array_ptr(@ptr, @nmemb, @size);
        }

        private av_realloc_f_delegate? _av_realloc_f_ptr;

        public av_realloc_f_delegate av_realloc_f_ptr => _av_realloc_f_ptr ?? (_av_realloc_f_ptr = NativeMethodDelegate<av_realloc_f_delegate>());

        /// <summary>Allocate, reallocate, or free a block of memory.</summary>
        public void* av_realloc_f(void* @ptr, ulong @nelem, ulong @elsize)
        {
            return av_realloc_f_ptr(@ptr, @nelem, @elsize);
        }

        private av_reallocp_delegate? _av_reallocp_ptr;

        public av_reallocp_delegate av_reallocp_ptr => _av_reallocp_ptr ?? (_av_reallocp_ptr = NativeMethodDelegate<av_reallocp_delegate>());

        /// <summary>Allocate, reallocate, or free a block of memory through a pointer to a pointer.</summary>
        /// <param name="ptr">Pointer to a pointer to a memory block already allocated with av_realloc(), or a pointer to `NULL`. The pointer is updated on success, or freed on failure.</param>
        /// <param name="size">Size in bytes for the memory block to be allocated or reallocated</param>
        /// <returns>Zero on success, an AVERROR error code on failure</returns>
        public int av_reallocp(void* @ptr, ulong @size)
        {
            return av_reallocp_ptr(@ptr, @size);
        }

        private av_reallocp_array_delegate? _av_reallocp_array_ptr;

        public av_reallocp_array_delegate av_reallocp_array_ptr => _av_reallocp_array_ptr ?? (_av_reallocp_array_ptr = NativeMethodDelegate<av_reallocp_array_delegate>());

        /// <summary>Allocate, reallocate, or free an array through a pointer to a pointer.</summary>
        /// <param name="ptr">Pointer to a pointer to a memory block already allocated with av_realloc(), or a pointer to `NULL`. The pointer is updated on success, or freed on failure.</param>
        /// <param name="nmemb">Number of elements</param>
        /// <param name="size">Size of the single element</param>
        /// <returns>Zero on success, an AVERROR error code on failure</returns>
        public int av_reallocp_array(void* @ptr, ulong @nmemb, ulong @size)
        {
            return av_reallocp_array_ptr(@ptr, @nmemb, @size);
        }

        private av_reduce_delegate? _av_reduce_ptr;

        public av_reduce_delegate av_reduce_ptr => _av_reduce_ptr ?? (_av_reduce_ptr = NativeMethodDelegate<av_reduce_delegate>());

        /// <summary>Reduce a fraction.</summary>
        /// <param name="dst_num">Destination numerator</param>
        /// <param name="dst_den">Destination denominator</param>
        /// <param name="num">Source numerator</param>
        /// <param name="den">Source denominator</param>
        /// <param name="max">Maximum allowed values for `dst_num` &amp; `dst_den`</param>
        /// <returns>1 if the operation is exact, 0 otherwise</returns>
        public int av_reduce(int* @dst_num, int* @dst_den, long @num, long @den, long @max)
        {
            return av_reduce_ptr(@dst_num, @dst_den, @num, @den, @max);
        }

        private av_rescale_delegate? _av_rescale_ptr;

        public av_rescale_delegate av_rescale_ptr => _av_rescale_ptr ?? (_av_rescale_ptr = NativeMethodDelegate<av_rescale_delegate>());

        /// <summary>Rescale a 64-bit integer with rounding to nearest.</summary>
        public long av_rescale(long @a, long @b, long @c)
        {
            return av_rescale_ptr(@a, @b, @c);
        }

        private av_rescale_delta_delegate? _av_rescale_delta_ptr;

        public av_rescale_delta_delegate av_rescale_delta_ptr => _av_rescale_delta_ptr ?? (_av_rescale_delta_ptr = NativeMethodDelegate<av_rescale_delta_delegate>());

        /// <summary>Rescale a timestamp while preserving known durations.</summary>
        /// <param name="in_tb">Input time base</param>
        /// <param name="in_ts">Input timestamp</param>
        /// <param name="fs_tb">Duration time base; typically this is finer-grained (greater) than `in_tb` and `out_tb`</param>
        /// <param name="duration">Duration till the next call to this function (i.e. duration of the current packet/frame)</param>
        /// <param name="last">Pointer to a timestamp expressed in terms of `fs_tb`, acting as a state variable</param>
        /// <param name="out_tb">Output timebase</param>
        /// <returns>Timestamp expressed in terms of `out_tb`</returns>
        public long av_rescale_delta(AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb)
        {
            return av_rescale_delta_ptr(@in_tb, @in_ts, @fs_tb, @duration, @last, @out_tb);
        }

        private av_rescale_q_delegate? _av_rescale_q_ptr;

        public av_rescale_q_delegate av_rescale_q_ptr => _av_rescale_q_ptr ?? (_av_rescale_q_ptr = NativeMethodDelegate<av_rescale_q_delegate>());

        /// <summary>Rescale a 64-bit integer by 2 rational numbers.</summary>
        public long av_rescale_q(long @a, AVRational @bq, AVRational @cq)
        {
            return av_rescale_q_ptr(@a, @bq, @cq);
        }

        private av_rescale_q_rnd_delegate? _av_rescale_q_rnd_ptr;

        public av_rescale_q_rnd_delegate av_rescale_q_rnd_ptr => _av_rescale_q_rnd_ptr ?? (_av_rescale_q_rnd_ptr = NativeMethodDelegate<av_rescale_q_rnd_delegate>());

        /// <summary>Rescale a 64-bit integer by 2 rational numbers with specified rounding.</summary>
        public long av_rescale_q_rnd(long @a, AVRational @bq, AVRational @cq, AVRounding @rnd)
        {
            return av_rescale_q_rnd_ptr(@a, @bq, @cq, @rnd);
        }

        private av_rescale_rnd_delegate? _av_rescale_rnd_ptr;

        public av_rescale_rnd_delegate av_rescale_rnd_ptr => _av_rescale_rnd_ptr ?? (_av_rescale_rnd_ptr = NativeMethodDelegate<av_rescale_rnd_delegate>());

        /// <summary>Rescale a 64-bit integer with specified rounding.</summary>
        public long av_rescale_rnd(long @a, long @b, long @c, AVRounding @rnd)
        {
            return av_rescale_rnd_ptr(@a, @b, @c, @rnd);
        }

        private av_sample_fmt_is_planar_delegate? _av_sample_fmt_is_planar_ptr;

        public av_sample_fmt_is_planar_delegate av_sample_fmt_is_planar_ptr => _av_sample_fmt_is_planar_ptr ?? (_av_sample_fmt_is_planar_ptr = NativeMethodDelegate<av_sample_fmt_is_planar_delegate>());

        /// <summary>Check if the sample format is planar.</summary>
        /// <param name="sample_fmt">the sample format to inspect</param>
        /// <returns>1 if the sample format is planar, 0 if it is interleaved</returns>
        public int av_sample_fmt_is_planar(AVSampleFormat @sample_fmt)
        {
            return av_sample_fmt_is_planar_ptr(@sample_fmt);
        }

        private av_samples_alloc_delegate? _av_samples_alloc_ptr;

        public av_samples_alloc_delegate av_samples_alloc_ptr => _av_samples_alloc_ptr ?? (_av_samples_alloc_ptr = NativeMethodDelegate<av_samples_alloc_delegate>());

        /// <summary>Allocate a samples buffer for nb_samples samples, and fill data pointers and linesize accordingly. The allocated samples buffer can be freed by using av_freep(&amp;audio_data[0]) Allocated data will be initialized to silence.</summary>
        /// <param name="audio_data">array to be filled with the pointer for each channel</param>
        /// <param name="linesize">aligned size for audio buffer(s), may be NULL</param>
        /// <param name="nb_channels">number of audio channels</param>
        /// <param name="nb_samples">number of samples per channel</param>
        /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
        /// <returns>&gt;=0 on success or a negative error code on failure</returns>
        public int av_samples_alloc(byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
        {
            return av_samples_alloc_ptr(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        }

        private av_samples_alloc_array_and_samples_delegate? _av_samples_alloc_array_and_samples_ptr;

        public av_samples_alloc_array_and_samples_delegate av_samples_alloc_array_and_samples_ptr => _av_samples_alloc_array_and_samples_ptr ?? (_av_samples_alloc_array_and_samples_ptr = NativeMethodDelegate<av_samples_alloc_array_and_samples_delegate>());

        /// <summary>Allocate a data pointers array, samples buffer for nb_samples samples, and fill data pointers and linesize accordingly.</summary>
        public int av_samples_alloc_array_and_samples(byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
        {
            return av_samples_alloc_array_and_samples_ptr(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        }

        private av_samples_copy_delegate? _av_samples_copy_ptr;

        public av_samples_copy_delegate av_samples_copy_ptr => _av_samples_copy_ptr ?? (_av_samples_copy_ptr = NativeMethodDelegate<av_samples_copy_delegate>());

        /// <summary>Copy samples from src to dst.</summary>
        /// <param name="dst">destination array of pointers to data planes</param>
        /// <param name="src">source array of pointers to data planes</param>
        /// <param name="dst_offset">offset in samples at which the data will be written to dst</param>
        /// <param name="src_offset">offset in samples at which the data will be read from src</param>
        /// <param name="nb_samples">number of samples to be copied</param>
        /// <param name="nb_channels">number of audio channels</param>
        /// <param name="sample_fmt">audio sample format</param>
        public int av_samples_copy(byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt)
        {
            return av_samples_copy_ptr(@dst, @src, @dst_offset, @src_offset, @nb_samples, @nb_channels, @sample_fmt);
        }

        private av_samples_fill_arrays_delegate? _av_samples_fill_arrays_ptr;

        public av_samples_fill_arrays_delegate av_samples_fill_arrays_ptr => _av_samples_fill_arrays_ptr ?? (_av_samples_fill_arrays_ptr = NativeMethodDelegate<av_samples_fill_arrays_delegate>());

        /// <summary>Fill plane data pointers and linesize for samples with sample format sample_fmt.</summary>
        /// <param name="audio_data">array to be filled with the pointer for each channel</param>
        /// <param name="linesize">calculated linesize, may be NULL</param>
        /// <param name="buf">the pointer to a buffer containing the samples</param>
        /// <param name="nb_channels">the number of channels</param>
        /// <param name="nb_samples">the number of samples in a single channel</param>
        /// <param name="sample_fmt">the sample format</param>
        /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
        /// <returns>minimum size in bytes required for the buffer on success, or a negative error code on failure</returns>
        public int av_samples_fill_arrays(byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
        {
            return av_samples_fill_arrays_ptr(@audio_data, @linesize, @buf, @nb_channels, @nb_samples, @sample_fmt, @align);
        }

        private av_samples_get_buffer_size_delegate? _av_samples_get_buffer_size_ptr;

        public av_samples_get_buffer_size_delegate av_samples_get_buffer_size_ptr => _av_samples_get_buffer_size_ptr ?? (_av_samples_get_buffer_size_ptr = NativeMethodDelegate<av_samples_get_buffer_size_delegate>());

        /// <summary>Get the required buffer size for the given audio parameters.</summary>
        /// <param name="linesize">calculated linesize, may be NULL</param>
        /// <param name="nb_channels">the number of channels</param>
        /// <param name="nb_samples">the number of samples in a single channel</param>
        /// <param name="sample_fmt">the sample format</param>
        /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
        /// <returns>required buffer size, or negative error code on failure</returns>
        public int av_samples_get_buffer_size(int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
        {
            return av_samples_get_buffer_size_ptr(@linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        }

        private av_samples_set_silence_delegate? _av_samples_set_silence_ptr;

        public av_samples_set_silence_delegate av_samples_set_silence_ptr => _av_samples_set_silence_ptr ?? (_av_samples_set_silence_ptr = NativeMethodDelegate<av_samples_set_silence_delegate>());

        /// <summary>Fill an audio buffer with silence.</summary>
        /// <param name="audio_data">array of pointers to data planes</param>
        /// <param name="offset">offset in samples at which to start filling</param>
        /// <param name="nb_samples">number of samples to fill</param>
        /// <param name="nb_channels">number of audio channels</param>
        /// <param name="sample_fmt">audio sample format</param>
        public int av_samples_set_silence(byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt)
        {
            return av_samples_set_silence_ptr(@audio_data, @offset, @nb_samples, @nb_channels, @sample_fmt);
        }

        private av_set_options_string_delegate? _av_set_options_string_ptr;

        public av_set_options_string_delegate av_set_options_string_ptr => _av_set_options_string_ptr ?? (_av_set_options_string_ptr = NativeMethodDelegate<av_set_options_string_delegate>());

        /// <summary>Parse the key/value pairs list in opts. For each key/value pair found, stores the value in the field in ctx that is named like the key. ctx must be an AVClass context, storing is done using AVOptions.</summary>
        /// <param name="opts">options string to parse, may be NULL</param>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other</param>
        /// <returns>the number of successfully set key/value pairs, or a negative value corresponding to an AVERROR code in case of error: AVERROR(EINVAL) if opts cannot be parsed, the error code issued by av_opt_set() if a key/value pair cannot be set</returns>
        public int av_set_options_string(void* @ctx,
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
    string @pairs_sep)
        {
            return av_set_options_string_ptr(@ctx, @opts, @key_val_sep, @pairs_sep);
        }

        private av_size_mult_delegate? _av_size_mult_ptr;

        public av_size_mult_delegate av_size_mult_ptr => _av_size_mult_ptr ?? (_av_size_mult_ptr = NativeMethodDelegate<av_size_mult_delegate>());

        /// <summary>Multiply two `size_t` values checking for overflow.</summary>
        /// <param name="r">Pointer to the result of the operation</param>
        /// <returns>0 on success, AVERROR(EINVAL) on overflow</returns>
        public int av_size_mult(ulong @a, ulong @b, ulong* @r)
        {
            return av_size_mult_ptr(@a, @b, @r);
        }

        private av_strdup_delegate? _av_strdup_ptr;

        public av_strdup_delegate av_strdup_ptr => _av_strdup_ptr ?? (_av_strdup_ptr = NativeMethodDelegate<av_strdup_delegate>());

        /// <summary>Duplicate a string.</summary>
        /// <param name="s">String to be duplicated</param>
        /// <returns>Pointer to a newly-allocated string containing a copy of `s` or `NULL` if the string cannot be allocated</returns>
        public byte* av_strdup(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @s)
        {
            return av_strdup_ptr(@s);
        }

        private av_strerror_delegate? _av_strerror_ptr;

        public av_strerror_delegate av_strerror_ptr => _av_strerror_ptr ?? (_av_strerror_ptr = NativeMethodDelegate<av_strerror_delegate>());

        /// <summary>Put a description of the AVERROR code errnum in errbuf. In case of failure the global variable errno is set to indicate the error. Even in case of failure av_strerror() will print a generic error message indicating the errnum provided to errbuf.</summary>
        /// <param name="errnum">error code to describe</param>
        /// <param name="errbuf">buffer to which description is written</param>
        /// <param name="errbuf_size">the size in bytes of errbuf</param>
        /// <returns>0 on success, a negative value if a description for errnum cannot be found</returns>
        public int av_strerror(int @errnum, byte* @errbuf, ulong @errbuf_size)
        {
            return av_strerror_ptr(@errnum, @errbuf, @errbuf_size);
        }

        private av_strndup_delegate? _av_strndup_ptr;

        public av_strndup_delegate av_strndup_ptr => _av_strndup_ptr ?? (_av_strndup_ptr = NativeMethodDelegate<av_strndup_delegate>());

        /// <summary>Duplicate a substring of a string.</summary>
        /// <param name="s">String to be duplicated</param>
        /// <param name="len">Maximum length of the resulting string (not counting the terminating byte)</param>
        /// <returns>Pointer to a newly-allocated string containing a substring of `s` or `NULL` if the string cannot be allocated</returns>
        public byte* av_strndup(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @s, ulong @len)
        {
            return av_strndup_ptr(@s, @len);
        }

        private av_sub_q_delegate? _av_sub_q_ptr;

        public av_sub_q_delegate av_sub_q_ptr => _av_sub_q_ptr ?? (_av_sub_q_ptr = NativeMethodDelegate<av_sub_q_delegate>());

        /// <summary>Subtract one rational from another.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        /// <returns>b-c</returns>
        public AVRational av_sub_q(AVRational @b, AVRational @c)
        {
            return av_sub_q_ptr(@b, @c);
        }

        private av_tempfile_delegate? _av_tempfile_ptr;

        public av_tempfile_delegate av_tempfile_ptr => _av_tempfile_ptr ?? (_av_tempfile_ptr = NativeMethodDelegate<av_tempfile_delegate>());

        /// <summary>Wrapper to work around the lack of mkstemp() on mingw. Also, tries to create file in /tmp first, if possible. *prefix can be a character constant; *filename will be allocated internally.</summary>
        /// <returns>file descriptor of opened file (or negative value corresponding to an AVERROR code on error) and opened file name in **filename.</returns>
        [Obsolete("as fd numbers cannot be passed saftely between libs on some platforms")]
        public int av_tempfile(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @prefix, byte** @filename, int @log_offset, void* @log_ctx)
        {
            return av_tempfile_ptr(@prefix, @filename, @log_offset, @log_ctx);
        }

        private av_timecode_adjust_ntsc_framenum2_delegate? _av_timecode_adjust_ntsc_framenum2_ptr;

        public av_timecode_adjust_ntsc_framenum2_delegate av_timecode_adjust_ntsc_framenum2_ptr => _av_timecode_adjust_ntsc_framenum2_ptr ?? (_av_timecode_adjust_ntsc_framenum2_ptr = NativeMethodDelegate<av_timecode_adjust_ntsc_framenum2_delegate>());

        /// <summary>Adjust frame number for NTSC drop frame time code.</summary>
        /// <param name="framenum">frame number to adjust</param>
        /// <param name="fps">frame per second, multiples of 30</param>
        /// <returns>adjusted frame number</returns>
        public int av_timecode_adjust_ntsc_framenum2(int @framenum, int @fps)
        {
            return av_timecode_adjust_ntsc_framenum2_ptr(@framenum, @fps);
        }

        private av_timecode_check_frame_rate_delegate? _av_timecode_check_frame_rate_ptr;

        public av_timecode_check_frame_rate_delegate av_timecode_check_frame_rate_ptr => _av_timecode_check_frame_rate_ptr ?? (_av_timecode_check_frame_rate_ptr = NativeMethodDelegate<av_timecode_check_frame_rate_delegate>());

        /// <summary>Check if the timecode feature is available for the given frame rate</summary>
        /// <returns>0 if supported, &lt; 0 otherwise</returns>
        public int av_timecode_check_frame_rate(AVRational @rate)
        {
            return av_timecode_check_frame_rate_ptr(@rate);
        }

        private av_timecode_get_smpte_delegate? _av_timecode_get_smpte_ptr;

        public av_timecode_get_smpte_delegate av_timecode_get_smpte_ptr => _av_timecode_get_smpte_ptr ?? (_av_timecode_get_smpte_ptr = NativeMethodDelegate<av_timecode_get_smpte_delegate>());

        /// <summary>Convert sei info to SMPTE 12M binary representation.</summary>
        /// <param name="rate">frame rate in rational form</param>
        /// <param name="drop">drop flag</param>
        /// <param name="hh">hour</param>
        /// <param name="mm">minute</param>
        /// <param name="ss">second</param>
        /// <param name="ff">frame number</param>
        /// <returns>the SMPTE binary representation</returns>
        public uint av_timecode_get_smpte(AVRational @rate, int @drop, int @hh, int @mm, int @ss, int @ff)
        {
            return av_timecode_get_smpte_ptr(@rate, @drop, @hh, @mm, @ss, @ff);
        }

        private av_timecode_get_smpte_from_framenum_delegate? _av_timecode_get_smpte_from_framenum_ptr;

        public av_timecode_get_smpte_from_framenum_delegate av_timecode_get_smpte_from_framenum_ptr => _av_timecode_get_smpte_from_framenum_ptr ?? (_av_timecode_get_smpte_from_framenum_ptr = NativeMethodDelegate<av_timecode_get_smpte_from_framenum_delegate>());

        /// <summary>Convert frame number to SMPTE 12M binary representation.</summary>
        /// <param name="tc">timecode data correctly initialized</param>
        /// <param name="framenum">frame number</param>
        /// <returns>the SMPTE binary representation</returns>
        public uint av_timecode_get_smpte_from_framenum(AVTimecode* @tc, int @framenum)
        {
            return av_timecode_get_smpte_from_framenum_ptr(@tc, @framenum);
        }

        private av_timecode_init_delegate? _av_timecode_init_ptr;

        public av_timecode_init_delegate av_timecode_init_ptr => _av_timecode_init_ptr ?? (_av_timecode_init_ptr = NativeMethodDelegate<av_timecode_init_delegate>());

        /// <summary>Init a timecode struct with the passed parameters.</summary>
        /// <param name="tc">pointer to an allocated AVTimecode</param>
        /// <param name="rate">frame rate in rational form</param>
        /// <param name="flags">miscellaneous flags such as drop frame, +24 hours, ... (see AVTimecodeFlag)</param>
        /// <param name="frame_start">the first frame number</param>
        /// <param name="log_ctx">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct (used for av_log)</param>
        /// <returns>0 on success, AVERROR otherwise</returns>
        public int av_timecode_init(AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx)
        {
            return av_timecode_init_ptr(@tc, @rate, @flags, @frame_start, @log_ctx);
        }

        private av_timecode_init_from_components_delegate? _av_timecode_init_from_components_ptr;

        public av_timecode_init_from_components_delegate av_timecode_init_from_components_ptr => _av_timecode_init_from_components_ptr ?? (_av_timecode_init_from_components_ptr = NativeMethodDelegate<av_timecode_init_from_components_delegate>());

        /// <summary>Init a timecode struct from the passed timecode components.</summary>
        /// <param name="tc">pointer to an allocated AVTimecode</param>
        /// <param name="rate">frame rate in rational form</param>
        /// <param name="flags">miscellaneous flags such as drop frame, +24 hours, ... (see AVTimecodeFlag)</param>
        /// <param name="hh">hours</param>
        /// <param name="mm">minutes</param>
        /// <param name="ss">seconds</param>
        /// <param name="ff">frames</param>
        /// <param name="log_ctx">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct (used for av_log)</param>
        /// <returns>0 on success, AVERROR otherwise</returns>
        public int av_timecode_init_from_components(AVTimecode* @tc, AVRational @rate, int @flags, int @hh, int @mm, int @ss, int @ff, void* @log_ctx)
        {
            return av_timecode_init_from_components_ptr(@tc, @rate, @flags, @hh, @mm, @ss, @ff, @log_ctx);
        }

        private av_timecode_init_from_string_delegate? _av_timecode_init_from_string_ptr;

        public av_timecode_init_from_string_delegate av_timecode_init_from_string_ptr => _av_timecode_init_from_string_ptr ?? (_av_timecode_init_from_string_ptr = NativeMethodDelegate<av_timecode_init_from_string_delegate>());

        /// <summary>Parse timecode representation (hh:mm:ss[:;.]ff).</summary>
        /// <param name="tc">pointer to an allocated AVTimecode</param>
        /// <param name="rate">frame rate in rational form</param>
        /// <param name="str">timecode string which will determine the frame start</param>
        /// <param name="log_ctx">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct (used for av_log).</param>
        /// <returns>0 on success, AVERROR otherwise</returns>
        public int av_timecode_init_from_string(AVTimecode* @tc, AVRational @rate,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @str, void* @log_ctx)
        {
            return av_timecode_init_from_string_ptr(@tc, @rate, @str, @log_ctx);
        }

        private av_timecode_make_mpeg_tc_string_delegate? _av_timecode_make_mpeg_tc_string_ptr;

        public av_timecode_make_mpeg_tc_string_delegate av_timecode_make_mpeg_tc_string_ptr => _av_timecode_make_mpeg_tc_string_ptr ?? (_av_timecode_make_mpeg_tc_string_ptr = NativeMethodDelegate<av_timecode_make_mpeg_tc_string_delegate>());

        /// <summary>Get the timecode string from the 25-bit timecode format (MPEG GOP format).</summary>
        /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
        /// <param name="tc25bit">the 25-bits timecode</param>
        /// <returns>the buf parameter</returns>
        public byte* av_timecode_make_mpeg_tc_string(byte* @buf, uint @tc25bit)
        {
            return av_timecode_make_mpeg_tc_string_ptr(@buf, @tc25bit);
        }

        private av_timecode_make_smpte_tc_string_delegate? _av_timecode_make_smpte_tc_string_ptr;

        public av_timecode_make_smpte_tc_string_delegate av_timecode_make_smpte_tc_string_ptr => _av_timecode_make_smpte_tc_string_ptr ?? (_av_timecode_make_smpte_tc_string_ptr = NativeMethodDelegate<av_timecode_make_smpte_tc_string_delegate>());

        /// <summary>Get the timecode string from the SMPTE timecode format.</summary>
        /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
        /// <param name="tcsmpte">the 32-bit SMPTE timecode</param>
        /// <param name="prevent_df">prevent the use of a drop flag when it is known the DF bit is arbitrary</param>
        /// <returns>the buf parameter</returns>
        public byte* av_timecode_make_smpte_tc_string(byte* @buf, uint @tcsmpte, int @prevent_df)
        {
            return av_timecode_make_smpte_tc_string_ptr(@buf, @tcsmpte, @prevent_df);
        }

        private av_timecode_make_smpte_tc_string2_delegate? _av_timecode_make_smpte_tc_string2_ptr;

        public av_timecode_make_smpte_tc_string2_delegate av_timecode_make_smpte_tc_string2_ptr => _av_timecode_make_smpte_tc_string2_ptr ?? (_av_timecode_make_smpte_tc_string2_ptr = NativeMethodDelegate<av_timecode_make_smpte_tc_string2_delegate>());

        /// <summary>Get the timecode string from the SMPTE timecode format.</summary>
        /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
        /// <param name="rate">frame rate of the timecode</param>
        /// <param name="tcsmpte">the 32-bit SMPTE timecode</param>
        /// <param name="prevent_df">prevent the use of a drop flag when it is known the DF bit is arbitrary</param>
        /// <param name="skip_field">prevent the use of a field flag when it is known the field bit is arbitrary (e.g. because it is used as PC flag)</param>
        /// <returns>the buf parameter</returns>
        public byte* av_timecode_make_smpte_tc_string2(byte* @buf, AVRational @rate, uint @tcsmpte, int @prevent_df, int @skip_field)
        {
            return av_timecode_make_smpte_tc_string2_ptr(@buf, @rate, @tcsmpte, @prevent_df, @skip_field);
        }

        private av_timecode_make_string_delegate? _av_timecode_make_string_ptr;

        public av_timecode_make_string_delegate av_timecode_make_string_ptr => _av_timecode_make_string_ptr ?? (_av_timecode_make_string_ptr = NativeMethodDelegate<av_timecode_make_string_delegate>());

        /// <summary>Load timecode string in buf.</summary>
        /// <param name="tc">timecode data correctly initialized</param>
        /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
        /// <param name="framenum">frame number</param>
        /// <returns>the buf parameter</returns>
        public byte* av_timecode_make_string(AVTimecode* @tc, byte* @buf, int @framenum)
        {
            return av_timecode_make_string_ptr(@tc, @buf, @framenum);
        }

        private av_tree_destroy_delegate? _av_tree_destroy_ptr;

        public av_tree_destroy_delegate av_tree_destroy_ptr => _av_tree_destroy_ptr ?? (_av_tree_destroy_ptr = NativeMethodDelegate<av_tree_destroy_delegate>());

        public void av_tree_destroy(AVTreeNode* @t)
        {
            av_tree_destroy_ptr(@t);
        }

        private av_tree_enumerate_delegate? _av_tree_enumerate_ptr;

        public av_tree_enumerate_delegate av_tree_enumerate_ptr => _av_tree_enumerate_ptr ?? (_av_tree_enumerate_ptr = NativeMethodDelegate<av_tree_enumerate_delegate>());

        /// <summary>Apply enu(opaque, &amp;elem) to all the elements in the tree in a given range.</summary>
        /// <param name="cmp">a comparison function that returns &lt; 0 for an element below the range, &gt; 0 for an element above the range and == 0 for an element inside the range</param>
        public void av_tree_enumerate(AVTreeNode* @t, void* @opaque, av_tree_enumerate_cmp_func @cmp, av_tree_enumerate_enu_func @enu)
        {
            av_tree_enumerate_ptr(@t, @opaque, @cmp, @enu);
        }

        private av_tree_find_delegate? _av_tree_find_ptr;

        public av_tree_find_delegate av_tree_find_ptr => _av_tree_find_ptr ?? (_av_tree_find_ptr = NativeMethodDelegate<av_tree_find_delegate>());

        /// <summary>Find an element.</summary>
        /// <param name="root">a pointer to the root node of the tree</param>
        /// <param name="cmp">compare function used to compare elements in the tree, API identical to that of Standard C&apos;s qsort It is guaranteed that the first and only the first argument to cmp() will be the key parameter to av_tree_find(), thus it could if the user wants, be a different type (like an opaque context).</param>
        /// <param name="next">If next is not NULL, then next[0] will contain the previous element and next[1] the next element. If either does not exist, then the corresponding entry in next is unchanged.</param>
        /// <returns>An element with cmp(key, elem) == 0 or NULL if no such element exists in the tree.</returns>
        public void* av_tree_find(AVTreeNode* @root, void* @key, av_tree_find_cmp_func @cmp, void_ptrArray2 @next)
        {
            return av_tree_find_ptr(@root, @key, @cmp, @next);
        }

        private av_tree_insert_delegate? _av_tree_insert_ptr;

        public av_tree_insert_delegate av_tree_insert_ptr => _av_tree_insert_ptr ?? (_av_tree_insert_ptr = NativeMethodDelegate<av_tree_insert_delegate>());

        /// <summary>Insert or remove an element.</summary>
        /// <param name="rootp">A pointer to a pointer to the root node of the tree; note that the root node can change during insertions, this is required to keep the tree balanced.</param>
        /// <param name="key">pointer to the element key to insert in the tree</param>
        /// <param name="cmp">compare function used to compare elements in the tree, API identical to that of Standard C&apos;s qsort</param>
        /// <param name="next">Used to allocate and free AVTreeNodes. For insertion the user must set it to an allocated and zeroed object of at least av_tree_node_size bytes size. av_tree_insert() will set it to NULL if it has been consumed. For deleting elements *next is set to NULL by the user and av_tree_insert() will set it to the AVTreeNode which was used for the removed element. This allows the use of flat arrays, which have lower overhead compared to many malloced elements. You might want to define a function like:</param>
        /// <returns>If no insertion happened, the found element; if an insertion or removal happened, then either key or NULL will be returned. Which one it is depends on the tree state and the implementation. You should make no assumptions that it&apos;s one or the other in the code.</returns>
        public void* av_tree_insert(AVTreeNode** @rootp, void* @key, av_tree_insert_cmp_func @cmp, AVTreeNode** @next)
        {
            return av_tree_insert_ptr(@rootp, @key, @cmp, @next);
        }

        private av_tree_node_alloc_delegate? _av_tree_node_alloc_ptr;

        public av_tree_node_alloc_delegate av_tree_node_alloc_ptr => _av_tree_node_alloc_ptr ?? (_av_tree_node_alloc_ptr = NativeMethodDelegate<av_tree_node_alloc_delegate>());

        /// <summary>Allocate an AVTreeNode.</summary>
        public AVTreeNode* av_tree_node_alloc()
        {
            return av_tree_node_alloc_ptr();
        }

        private av_usleep_delegate? _av_usleep_ptr;

        public av_usleep_delegate av_usleep_ptr => _av_usleep_ptr ?? (_av_usleep_ptr = NativeMethodDelegate<av_usleep_delegate>());

        /// <summary>Sleep for a period of time. Although the duration is expressed in microseconds, the actual delay may be rounded to the precision of the system timer.</summary>
        /// <param name="usec">Number of microseconds to sleep.</param>
        /// <returns>zero on success or (negative) error code.</returns>
        public int av_usleep(uint @usec)
        {
            return av_usleep_ptr(@usec);
        }

        private av_version_info_delegate? _av_version_info_ptr;

        public av_version_info_delegate av_version_info_ptr => _av_version_info_ptr ?? (_av_version_info_ptr = NativeMethodDelegate<av_version_info_delegate>());

        /// <summary>Return an informative version string. This usually is the actual release version number or a git commit description. This string has no fixed format and can change any time. It should never be parsed by code.</summary>
        public string av_version_info()
        {
            return av_version_info_ptr();
        }

        private av_vlog_delegate? _av_vlog_ptr;

        public av_vlog_delegate av_vlog_ptr => _av_vlog_ptr ?? (_av_vlog_ptr = NativeMethodDelegate<av_vlog_delegate>());

        /// <summary>Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message expressed using a &quot;Logging Constant&quot;.</param>
        /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
        /// <param name="vl">The arguments referenced by the format string.</param>
        public void av_vlog(void* @avcl, int @level,
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @fmt, byte* @vl)
        {
            av_vlog_ptr(@avcl, @level, @fmt, @vl);
        }

        private av_write_image_line_delegate? _av_write_image_line_ptr;

        public av_write_image_line_delegate av_write_image_line_ptr => _av_write_image_line_ptr ?? (_av_write_image_line_ptr = NativeMethodDelegate<av_write_image_line_delegate>());

        public void av_write_image_line(ushort* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w)
        {
            av_write_image_line_ptr(@src, ref @data, @linesize, @desc, @x, @y, @c, @w);
        }

        private av_write_image_line2_delegate? _av_write_image_line2_ptr;

        public av_write_image_line2_delegate av_write_image_line2_ptr => _av_write_image_line2_ptr ?? (_av_write_image_line2_ptr = NativeMethodDelegate<av_write_image_line2_delegate>());

        /// <summary>Write the values from src to the pixel format component c of an image line.</summary>
        /// <param name="src">array containing the values to write</param>
        /// <param name="data">the array containing the pointers to the planes of the image to write into. It is supposed to be zeroed.</param>
        /// <param name="linesize">the array containing the linesizes of the image</param>
        /// <param name="desc">the pixel format descriptor for the image</param>
        /// <param name="x">the horizontal coordinate of the first pixel to write</param>
        /// <param name="y">the vertical coordinate of the first pixel to write</param>
        /// <param name="w">the width of the line to write, that is the number of values to write to the image line</param>
        /// <param name="src_element_size">size of elements in src array (2 or 4 byte)</param>
        public void av_write_image_line2(void* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @src_element_size)
        {
            av_write_image_line2_ptr(@src, ref @data, @linesize, @desc, @x, @y, @c, @w, @src_element_size);
        }

        private avutil_configuration_delegate? _avutil_configuration_ptr;

        public avutil_configuration_delegate avutil_configuration_ptr => _avutil_configuration_ptr ?? (_avutil_configuration_ptr = NativeMethodDelegate<avutil_configuration_delegate>());

        /// <summary>Return the libavutil build-time configuration.</summary>
        public string avutil_configuration()
        {
            return avutil_configuration_ptr();
        }

        private avutil_license_delegate? _avutil_license_ptr;

        public avutil_license_delegate avutil_license_ptr => _avutil_license_ptr ?? (_avutil_license_ptr = NativeMethodDelegate<avutil_license_delegate>());

        /// <summary>Return the libavutil license.</summary>
        public string avutil_license()
        {
            return avutil_license_ptr();
        }

        private avutil_version_delegate? _avutil_version_ptr;

        public avutil_version_delegate avutil_version_ptr => _avutil_version_ptr ?? (_avutil_version_ptr = NativeMethodDelegate<avutil_version_delegate>());

        /// <summary>Return the LIBAVUTIL_VERSION_INT constant.</summary>
        public uint avutil_version()
        {
            return avutil_version_ptr();
        }

        private postproc_configuration_delegate? _postproc_configuration_ptr;

        public postproc_configuration_delegate postproc_configuration_ptr => _postproc_configuration_ptr ?? (_postproc_configuration_ptr = NativeMethodDelegate<postproc_configuration_delegate>());

        /// <summary>Return the libpostproc build-time configuration.</summary>
        public string postproc_configuration()
        {
            return postproc_configuration_ptr();
        }

        private postproc_license_delegate? _postproc_license_ptr;

        public postproc_license_delegate postproc_license_ptr => _postproc_license_ptr ?? (_postproc_license_ptr = NativeMethodDelegate<postproc_license_delegate>());

        /// <summary>Return the libpostproc license.</summary>
        public string postproc_license()
        {
            return postproc_license_ptr();
        }

        private postproc_version_delegate? _postproc_version_ptr;

        public postproc_version_delegate postproc_version_ptr => _postproc_version_ptr ?? (_postproc_version_ptr = NativeMethodDelegate<postproc_version_delegate>());

        /// <summary>Return the LIBPOSTPROC_VERSION_INT constant.</summary>
        public uint postproc_version()
        {
            return postproc_version_ptr();
        }

        private pp_free_context_delegate? _pp_free_context_ptr;

        public pp_free_context_delegate pp_free_context_ptr => _pp_free_context_ptr ?? (_pp_free_context_ptr = NativeMethodDelegate<pp_free_context_delegate>());

        public void pp_free_context(void* @ppContext)
        {
            pp_free_context_ptr(@ppContext);
        }

        private pp_free_mode_delegate? _pp_free_mode_ptr;

        public pp_free_mode_delegate pp_free_mode_ptr => _pp_free_mode_ptr ?? (_pp_free_mode_ptr = NativeMethodDelegate<pp_free_mode_delegate>());

        public void pp_free_mode(void* @mode)
        {
            pp_free_mode_ptr(@mode);
        }

        private pp_get_context_delegate? _pp_get_context_ptr;

        public pp_get_context_delegate pp_get_context_ptr => _pp_get_context_ptr ?? (_pp_get_context_ptr = NativeMethodDelegate<pp_get_context_delegate>());

        public void* pp_get_context(int @width, int @height, int @flags)
        {
            return pp_get_context_ptr(@width, @height, @flags);
        }

        private pp_get_mode_by_name_and_quality_delegate? _pp_get_mode_by_name_and_quality_ptr;

        public pp_get_mode_by_name_and_quality_delegate pp_get_mode_by_name_and_quality_ptr => _pp_get_mode_by_name_and_quality_ptr ?? (_pp_get_mode_by_name_and_quality_ptr = NativeMethodDelegate<pp_get_mode_by_name_and_quality_delegate>());

        /// <summary>Return a pp_mode or NULL if an error occurred.</summary>
        /// <param name="name">the string after &quot;-pp&quot; on the command line</param>
        /// <param name="quality">a number from 0 to PP_QUALITY_MAX</param>
        public void* pp_get_mode_by_name_and_quality(
#if NET40
#elif NET45 || NETSTANDARD2_0
    [MarshalAs((UnmanagedType)48)]
#else
    [MarshalAs(UnmanagedType.LPUTF8Str)]
    #endif
    string @name, int @quality)
        {
            return pp_get_mode_by_name_and_quality_ptr(@name, @quality);
        }

        private pp_postprocess_delegate? _pp_postprocess_ptr;

        public pp_postprocess_delegate pp_postprocess_ptr => _pp_postprocess_ptr ?? (_pp_postprocess_ptr = NativeMethodDelegate<pp_postprocess_delegate>());

        public void pp_postprocess(byte_ptrArray3 @src, int_array3 @srcStride, ref byte_ptrArray3 @dst, int_array3 @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type)
        {
            pp_postprocess_ptr(@src, @srcStride, ref @dst, @dstStride, @horizontalSize, @verticalSize, @QP_store, @QP_stride, @mode, @ppContext, @pict_type);
        }

        private swr_alloc_delegate? _swr_alloc_ptr;

        public swr_alloc_delegate swr_alloc_ptr => _swr_alloc_ptr ?? (_swr_alloc_ptr = NativeMethodDelegate<swr_alloc_delegate>());

        /// <summary>Allocate SwrContext.</summary>
        /// <returns>NULL on error, allocated context otherwise</returns>
        public SwrContext* swr_alloc()
        {
            return swr_alloc_ptr();
        }

        private swr_alloc_set_opts_delegate? _swr_alloc_set_opts_ptr;

        public swr_alloc_set_opts_delegate swr_alloc_set_opts_ptr => _swr_alloc_set_opts_ptr ?? (_swr_alloc_set_opts_ptr = NativeMethodDelegate<swr_alloc_set_opts_delegate>());

        /// <summary>Allocate SwrContext if needed and set/reset common parameters.</summary>
        /// <param name="s">existing Swr context if available, or NULL if not</param>
        /// <param name="out_ch_layout">output channel layout (AV_CH_LAYOUT_*)</param>
        /// <param name="out_sample_fmt">output sample format (AV_SAMPLE_FMT_*).</param>
        /// <param name="out_sample_rate">output sample rate (frequency in Hz)</param>
        /// <param name="in_ch_layout">input channel layout (AV_CH_LAYOUT_*)</param>
        /// <param name="in_sample_fmt">input sample format (AV_SAMPLE_FMT_*).</param>
        /// <param name="in_sample_rate">input sample rate (frequency in Hz)</param>
        /// <param name="log_offset">logging level offset</param>
        /// <param name="log_ctx">parent logging context, can be NULL</param>
        /// <returns>NULL on error, allocated context otherwise</returns>
        public SwrContext* swr_alloc_set_opts(SwrContext* @s, long @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, long @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx)
        {
            return swr_alloc_set_opts_ptr(@s, @out_ch_layout, @out_sample_fmt, @out_sample_rate, @in_ch_layout, @in_sample_fmt, @in_sample_rate, @log_offset, @log_ctx);
        }

        private swr_build_matrix_delegate? _swr_build_matrix_ptr;

        public swr_build_matrix_delegate swr_build_matrix_ptr => _swr_build_matrix_ptr ?? (_swr_build_matrix_ptr = NativeMethodDelegate<swr_build_matrix_delegate>());

        /// <summary>Generate a channel mixing matrix.</summary>
        /// <param name="in_layout">input channel layout</param>
        /// <param name="out_layout">output channel layout</param>
        /// <param name="center_mix_level">mix level for the center channel</param>
        /// <param name="surround_mix_level">mix level for the surround channel(s)</param>
        /// <param name="lfe_mix_level">mix level for the low-frequency effects channel</param>
        /// <param name="rematrix_maxval">if 1.0, coefficients will be normalized to prevent overflow. if INT_MAX, coefficients will not be normalized.</param>
        /// <param name="matrix">mixing coefficients; matrix[i + stride * o] is the weight of input channel i in output channel o.</param>
        /// <param name="stride">distance between adjacent input channels in the matrix array</param>
        /// <param name="matrix_encoding">matrixed stereo downmix mode (e.g. dplii)</param>
        /// <param name="log_ctx">parent logging context, can be NULL</param>
        /// <returns>0 on success, negative AVERROR code on failure</returns>
        public int swr_build_matrix(ulong @in_layout, ulong @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @rematrix_maxval, double @rematrix_volume, double* @matrix, int @stride, AVMatrixEncoding @matrix_encoding, void* @log_ctx)
        {
            return swr_build_matrix_ptr(@in_layout, @out_layout, @center_mix_level, @surround_mix_level, @lfe_mix_level, @rematrix_maxval, @rematrix_volume, @matrix, @stride, @matrix_encoding, @log_ctx);
        }

        private swr_close_delegate? _swr_close_ptr;

        public swr_close_delegate swr_close_ptr => _swr_close_ptr ?? (_swr_close_ptr = NativeMethodDelegate<swr_close_delegate>());

        /// <summary>Closes the context so that swr_is_initialized() returns 0.</summary>
        /// <param name="s">Swr context to be closed</param>
        public void swr_close(SwrContext* @s)
        {
            swr_close_ptr(@s);
        }

        private swr_config_frame_delegate? _swr_config_frame_ptr;

        public swr_config_frame_delegate swr_config_frame_ptr => _swr_config_frame_ptr ?? (_swr_config_frame_ptr = NativeMethodDelegate<swr_config_frame_delegate>());

        /// <summary>Configure or reconfigure the SwrContext using the information provided by the AVFrames.</summary>
        /// <param name="swr">audio resample context</param>
        /// <returns>0 on success, AVERROR on failure.</returns>
        public int swr_config_frame(SwrContext* @swr, AVFrame* @out, AVFrame* @in)
        {
            return swr_config_frame_ptr(@swr, @out, @in);
        }

        private swr_convert_delegate? _swr_convert_ptr;

        public swr_convert_delegate swr_convert_ptr => _swr_convert_ptr ?? (_swr_convert_ptr = NativeMethodDelegate<swr_convert_delegate>());

        /// <summary>Convert audio.</summary>
        /// <param name="s">allocated Swr context, with parameters set</param>
        /// <param name="out">output buffers, only the first one need be set in case of packed audio</param>
        /// <param name="out_count">amount of space available for output in samples per channel</param>
        /// <param name="in">input buffers, only the first one need to be set in case of packed audio</param>
        /// <param name="in_count">number of input samples available in one channel</param>
        /// <returns>number of samples output per channel, negative value on error</returns>
        public int swr_convert(SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count)
        {
            return swr_convert_ptr(@s, @out, @out_count, @in, @in_count);
        }

        private swr_convert_frame_delegate? _swr_convert_frame_ptr;

        public swr_convert_frame_delegate swr_convert_frame_ptr => _swr_convert_frame_ptr ?? (_swr_convert_frame_ptr = NativeMethodDelegate<swr_convert_frame_delegate>());

        /// <summary>Convert the samples in the input AVFrame and write them to the output AVFrame.</summary>
        /// <param name="swr">audio resample context</param>
        /// <param name="output">output AVFrame</param>
        /// <param name="input">input AVFrame</param>
        /// <returns>0 on success, AVERROR on failure or nonmatching configuration.</returns>
        public int swr_convert_frame(SwrContext* @swr, AVFrame* @output, AVFrame* @input)
        {
            return swr_convert_frame_ptr(@swr, @output, @input);
        }

        private swr_drop_output_delegate? _swr_drop_output_ptr;

        public swr_drop_output_delegate swr_drop_output_ptr => _swr_drop_output_ptr ?? (_swr_drop_output_ptr = NativeMethodDelegate<swr_drop_output_delegate>());

        /// <summary>Drops the specified number of output samples.</summary>
        /// <param name="s">allocated Swr context</param>
        /// <param name="count">number of samples to be dropped</param>
        /// <returns>&gt;= 0 on success, or a negative AVERROR code on failure</returns>
        public int swr_drop_output(SwrContext* @s, int @count)
        {
            return swr_drop_output_ptr(@s, @count);
        }

        private swr_free_delegate? _swr_free_ptr;

        public swr_free_delegate swr_free_ptr => _swr_free_ptr ?? (_swr_free_ptr = NativeMethodDelegate<swr_free_delegate>());

        /// <summary>Free the given SwrContext and set the pointer to NULL.</summary>
        /// <param name="s">a pointer to a pointer to Swr context</param>
        public void swr_free(SwrContext** @s)
        {
            swr_free_ptr(@s);
        }

        private swr_get_class_delegate? _swr_get_class_ptr;

        public swr_get_class_delegate swr_get_class_ptr => _swr_get_class_ptr ?? (_swr_get_class_ptr = NativeMethodDelegate<swr_get_class_delegate>());

        /// <summary>Get the AVClass for SwrContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        /// <returns>the AVClass of SwrContext</returns>
        public AVClass* swr_get_class()
        {
            return swr_get_class_ptr();
        }

        private swr_get_delay_delegate? _swr_get_delay_ptr;

        public swr_get_delay_delegate swr_get_delay_ptr => _swr_get_delay_ptr ?? (_swr_get_delay_ptr = NativeMethodDelegate<swr_get_delay_delegate>());

        /// <summary>Gets the delay the next input sample will experience relative to the next output sample.</summary>
        /// <param name="s">swr context</param>
        /// <param name="base">timebase in which the returned delay will be:</param>
        public long swr_get_delay(SwrContext* @s, long @base)
        {
            return swr_get_delay_ptr(@s, @base);
        }

        private swr_get_out_samples_delegate? _swr_get_out_samples_ptr;

        public swr_get_out_samples_delegate swr_get_out_samples_ptr => _swr_get_out_samples_ptr ?? (_swr_get_out_samples_ptr = NativeMethodDelegate<swr_get_out_samples_delegate>());

        /// <summary>Find an upper bound on the number of samples that the next swr_convert call will output, if called with in_samples of input samples. This depends on the internal state, and anything changing the internal state (like further swr_convert() calls) will may change the number of samples swr_get_out_samples() returns for the same number of input samples.</summary>
        /// <param name="in_samples">number of input samples.</param>
        public int swr_get_out_samples(SwrContext* @s, int @in_samples)
        {
            return swr_get_out_samples_ptr(@s, @in_samples);
        }

        private swr_init_delegate? _swr_init_ptr;

        public swr_init_delegate swr_init_ptr => _swr_init_ptr ?? (_swr_init_ptr = NativeMethodDelegate<swr_init_delegate>());

        /// <summary>Initialize context after user parameters have been set.</summary>
        /// <param name="s">Swr context to initialize</param>
        /// <returns>AVERROR error code in case of failure.</returns>
        public int swr_init(SwrContext* @s)
        {
            return swr_init_ptr(@s);
        }

        private swr_inject_silence_delegate? _swr_inject_silence_ptr;

        public swr_inject_silence_delegate swr_inject_silence_ptr => _swr_inject_silence_ptr ?? (_swr_inject_silence_ptr = NativeMethodDelegate<swr_inject_silence_delegate>());

        /// <summary>Injects the specified number of silence samples.</summary>
        /// <param name="s">allocated Swr context</param>
        /// <param name="count">number of samples to be dropped</param>
        /// <returns>&gt;= 0 on success, or a negative AVERROR code on failure</returns>
        public int swr_inject_silence(SwrContext* @s, int @count)
        {
            return swr_inject_silence_ptr(@s, @count);
        }

        private swr_is_initialized_delegate? _swr_is_initialized_ptr;

        public swr_is_initialized_delegate swr_is_initialized_ptr => _swr_is_initialized_ptr ?? (_swr_is_initialized_ptr = NativeMethodDelegate<swr_is_initialized_delegate>());

        /// <summary>Check whether an swr context has been initialized or not.</summary>
        /// <param name="s">Swr context to check</param>
        /// <returns>positive if it has been initialized, 0 if not initialized</returns>
        public int swr_is_initialized(SwrContext* @s)
        {
            return swr_is_initialized_ptr(@s);
        }

        private swr_next_pts_delegate? _swr_next_pts_ptr;

        public swr_next_pts_delegate swr_next_pts_ptr => _swr_next_pts_ptr ?? (_swr_next_pts_ptr = NativeMethodDelegate<swr_next_pts_delegate>());

        /// <summary>Convert the next timestamp from input to output timestamps are in 1/(in_sample_rate * out_sample_rate) units.</summary>
        /// <returns>the output timestamp for the next output sample</returns>
        public long swr_next_pts(SwrContext* @s, long @pts)
        {
            return swr_next_pts_ptr(@s, @pts);
        }

        private swr_set_channel_mapping_delegate? _swr_set_channel_mapping_ptr;

        public swr_set_channel_mapping_delegate swr_set_channel_mapping_ptr => _swr_set_channel_mapping_ptr ?? (_swr_set_channel_mapping_ptr = NativeMethodDelegate<swr_set_channel_mapping_delegate>());

        /// <summary>Set a customized input channel mapping.</summary>
        /// <param name="s">allocated Swr context, not yet initialized</param>
        /// <param name="channel_map">customized input channel mapping (array of channel indexes, -1 for a muted channel)</param>
        /// <returns>&gt;= 0 on success, or AVERROR error code in case of failure.</returns>
        public int swr_set_channel_mapping(SwrContext* @s, int* @channel_map)
        {
            return swr_set_channel_mapping_ptr(@s, @channel_map);
        }

        private swr_set_compensation_delegate? _swr_set_compensation_ptr;

        public swr_set_compensation_delegate swr_set_compensation_ptr => _swr_set_compensation_ptr ?? (_swr_set_compensation_ptr = NativeMethodDelegate<swr_set_compensation_delegate>());

        /// <summary>Activate resampling compensation (&quot;soft&quot; compensation). This function is internally called when needed in swr_next_pts().</summary>
        /// <param name="s">allocated Swr context. If it is not initialized, or SWR_FLAG_RESAMPLE is not set, swr_init() is called with the flag set.</param>
        /// <param name="sample_delta">delta in PTS per sample</param>
        /// <param name="compensation_distance">number of samples to compensate for</param>
        /// <returns>&gt;= 0 on success, AVERROR error codes if:</returns>
        public int swr_set_compensation(SwrContext* @s, int @sample_delta, int @compensation_distance)
        {
            return swr_set_compensation_ptr(@s, @sample_delta, @compensation_distance);
        }

        private swr_set_matrix_delegate? _swr_set_matrix_ptr;

        public swr_set_matrix_delegate swr_set_matrix_ptr => _swr_set_matrix_ptr ?? (_swr_set_matrix_ptr = NativeMethodDelegate<swr_set_matrix_delegate>());

        /// <summary>Set a customized remix matrix.</summary>
        /// <param name="s">allocated Swr context, not yet initialized</param>
        /// <param name="matrix">remix coefficients; matrix[i + stride * o] is the weight of input channel i in output channel o</param>
        /// <param name="stride">offset between lines of the matrix</param>
        /// <returns>&gt;= 0 on success, or AVERROR error code in case of failure.</returns>
        public int swr_set_matrix(SwrContext* @s, double* @matrix, int @stride)
        {
            return swr_set_matrix_ptr(@s, @matrix, @stride);
        }

        private swresample_configuration_delegate? _swresample_configuration_ptr;

        public swresample_configuration_delegate swresample_configuration_ptr => _swresample_configuration_ptr ?? (_swresample_configuration_ptr = NativeMethodDelegate<swresample_configuration_delegate>());

        /// <summary>Return the swr build-time configuration.</summary>
        public string swresample_configuration()
        {
            return swresample_configuration_ptr();
        }

        private swresample_license_delegate? _swresample_license_ptr;

        public swresample_license_delegate swresample_license_ptr => _swresample_license_ptr ?? (_swresample_license_ptr = NativeMethodDelegate<swresample_license_delegate>());

        /// <summary>Return the swr license.</summary>
        public string swresample_license()
        {
            return swresample_license_ptr();
        }

        private swresample_version_delegate? _swresample_version_ptr;

        public swresample_version_delegate swresample_version_ptr => _swresample_version_ptr ?? (_swresample_version_ptr = NativeMethodDelegate<swresample_version_delegate>());

        /// <summary>Return the LIBSWRESAMPLE_VERSION_INT constant.</summary>
        public uint swresample_version()
        {
            return swresample_version_ptr();
        }

        private sws_alloc_context_delegate? _sws_alloc_context_ptr;

        public sws_alloc_context_delegate sws_alloc_context_ptr => _sws_alloc_context_ptr ?? (_sws_alloc_context_ptr = NativeMethodDelegate<sws_alloc_context_delegate>());

        /// <summary>Allocate an empty SwsContext. This must be filled and passed to sws_init_context(). For filling see AVOptions, options.c and sws_setColorspaceDetails().</summary>
        public SwsContext* sws_alloc_context()
        {
            return sws_alloc_context_ptr();
        }

        private sws_allocVec_delegate? _sws_allocVec_ptr;

        public sws_allocVec_delegate sws_allocVec_ptr => _sws_allocVec_ptr ?? (_sws_allocVec_ptr = NativeMethodDelegate<sws_allocVec_delegate>());

        /// <summary>Allocate and return an uninitialized vector with length coefficients.</summary>
        public SwsVector* sws_allocVec(int @length)
        {
            return sws_allocVec_ptr(@length);
        }

        private sws_convertPalette8ToPacked24_delegate? _sws_convertPalette8ToPacked24_ptr;

        public sws_convertPalette8ToPacked24_delegate sws_convertPalette8ToPacked24_ptr => _sws_convertPalette8ToPacked24_ptr ?? (_sws_convertPalette8ToPacked24_ptr = NativeMethodDelegate<sws_convertPalette8ToPacked24_delegate>());

        /// <summary>Convert an 8-bit paletted frame into a frame with a color depth of 24 bits.</summary>
        /// <param name="src">source frame buffer</param>
        /// <param name="dst">destination frame buffer</param>
        /// <param name="num_pixels">number of pixels to convert</param>
        /// <param name="palette">array with [256] entries, which must match color arrangement (RGB or BGR) of src</param>
        public void sws_convertPalette8ToPacked24(byte* @src, byte* @dst, int @num_pixels, byte* @palette)
        {
            sws_convertPalette8ToPacked24_ptr(@src, @dst, @num_pixels, @palette);
        }

        private sws_convertPalette8ToPacked32_delegate? _sws_convertPalette8ToPacked32_ptr;

        public sws_convertPalette8ToPacked32_delegate sws_convertPalette8ToPacked32_ptr => _sws_convertPalette8ToPacked32_ptr ?? (_sws_convertPalette8ToPacked32_ptr = NativeMethodDelegate<sws_convertPalette8ToPacked32_delegate>());

        /// <summary>Convert an 8-bit paletted frame into a frame with a color depth of 32 bits.</summary>
        /// <param name="src">source frame buffer</param>
        /// <param name="dst">destination frame buffer</param>
        /// <param name="num_pixels">number of pixels to convert</param>
        /// <param name="palette">array with [256] entries, which must match color arrangement (RGB or BGR) of src</param>
        public void sws_convertPalette8ToPacked32(byte* @src, byte* @dst, int @num_pixels, byte* @palette)
        {
            sws_convertPalette8ToPacked32_ptr(@src, @dst, @num_pixels, @palette);
        }

        private sws_frame_end_delegate? _sws_frame_end_ptr;

        public sws_frame_end_delegate sws_frame_end_ptr => _sws_frame_end_ptr ?? (_sws_frame_end_ptr = NativeMethodDelegate<sws_frame_end_delegate>());

        /// <summary>Finish the scaling process for a pair of source/destination frames previously submitted with sws_frame_start(). Must be called after all sws_send_slice() and sws_receive_slice() calls are done, before any new sws_frame_start() calls.</summary>
        public void sws_frame_end(SwsContext* @c)
        {
            sws_frame_end_ptr(@c);
        }

        private sws_frame_start_delegate? _sws_frame_start_ptr;

        public sws_frame_start_delegate sws_frame_start_ptr => _sws_frame_start_ptr ?? (_sws_frame_start_ptr = NativeMethodDelegate<sws_frame_start_delegate>());

        /// <summary>Initialize the scaling process for a given pair of source/destination frames. Must be called before any calls to sws_send_slice() and sws_receive_slice().</summary>
        /// <param name="dst">The destination frame.</param>
        /// <param name="src">The source frame. The data buffers must be allocated, but the frame data does not have to be ready at this point. Data availability is then signalled by sws_send_slice().</param>
        /// <returns>0 on success, a negative AVERROR code on failure</returns>
        public int sws_frame_start(SwsContext* @c, AVFrame* @dst, AVFrame* @src)
        {
            return sws_frame_start_ptr(@c, @dst, @src);
        }

        private sws_freeContext_delegate? _sws_freeContext_ptr;

        public sws_freeContext_delegate sws_freeContext_ptr => _sws_freeContext_ptr ?? (_sws_freeContext_ptr = NativeMethodDelegate<sws_freeContext_delegate>());

        /// <summary>Free the swscaler context swsContext. If swsContext is NULL, then does nothing.</summary>
        public void sws_freeContext(SwsContext* @swsContext)
        {
            sws_freeContext_ptr(@swsContext);
        }

        private sws_freeFilter_delegate? _sws_freeFilter_ptr;

        public sws_freeFilter_delegate sws_freeFilter_ptr => _sws_freeFilter_ptr ?? (_sws_freeFilter_ptr = NativeMethodDelegate<sws_freeFilter_delegate>());

        public void sws_freeFilter(SwsFilter* @filter)
        {
            sws_freeFilter_ptr(@filter);
        }

        private sws_freeVec_delegate? _sws_freeVec_ptr;

        public sws_freeVec_delegate sws_freeVec_ptr => _sws_freeVec_ptr ?? (_sws_freeVec_ptr = NativeMethodDelegate<sws_freeVec_delegate>());

        public void sws_freeVec(SwsVector* @a)
        {
            sws_freeVec_ptr(@a);
        }

        private sws_get_class_delegate? _sws_get_class_ptr;

        public sws_get_class_delegate sws_get_class_ptr => _sws_get_class_ptr ?? (_sws_get_class_ptr = NativeMethodDelegate<sws_get_class_delegate>());

        /// <summary>Get the AVClass for swsContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public AVClass* sws_get_class()
        {
            return sws_get_class_ptr();
        }

        private sws_getCachedContext_delegate? _sws_getCachedContext_ptr;

        public sws_getCachedContext_delegate sws_getCachedContext_ptr => _sws_getCachedContext_ptr ?? (_sws_getCachedContext_ptr = NativeMethodDelegate<sws_getCachedContext_delegate>());

        /// <summary>Check if context can be reused, otherwise reallocate a new one.</summary>
        public SwsContext* sws_getCachedContext(SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param)
        {
            return sws_getCachedContext_ptr(@context, @srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
        }

        private sws_getCoefficients_delegate? _sws_getCoefficients_ptr;

        public sws_getCoefficients_delegate sws_getCoefficients_ptr => _sws_getCoefficients_ptr ?? (_sws_getCoefficients_ptr = NativeMethodDelegate<sws_getCoefficients_delegate>());

        /// <summary>Return a pointer to yuv&lt;-&gt;rgb coefficients for the given colorspace suitable for sws_setColorspaceDetails().</summary>
        /// <param name="colorspace">One of the SWS_CS_* macros. If invalid, SWS_CS_DEFAULT is used.</param>
        public int* sws_getCoefficients(int @colorspace)
        {
            return sws_getCoefficients_ptr(@colorspace);
        }

        private sws_getColorspaceDetails_delegate? _sws_getColorspaceDetails_ptr;

        public sws_getColorspaceDetails_delegate sws_getColorspaceDetails_ptr => _sws_getColorspaceDetails_ptr ?? (_sws_getColorspaceDetails_ptr = NativeMethodDelegate<sws_getColorspaceDetails_delegate>());

        /// <summary>#if LIBSWSCALE_VERSION_MAJOR &gt; 6</summary>
        /// <returns>negative error code on error, non negative otherwise #else</returns>
        public int sws_getColorspaceDetails(SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation)
        {
            return sws_getColorspaceDetails_ptr(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
        }

        private sws_getContext_delegate? _sws_getContext_ptr;

        public sws_getContext_delegate sws_getContext_ptr => _sws_getContext_ptr ?? (_sws_getContext_ptr = NativeMethodDelegate<sws_getContext_delegate>());

        /// <summary>Allocate and return an SwsContext. You need it to perform scaling/conversion operations using sws_scale().</summary>
        /// <param name="srcW">the width of the source image</param>
        /// <param name="srcH">the height of the source image</param>
        /// <param name="srcFormat">the source image format</param>
        /// <param name="dstW">the width of the destination image</param>
        /// <param name="dstH">the height of the destination image</param>
        /// <param name="dstFormat">the destination image format</param>
        /// <param name="flags">specify which algorithm and options to use for rescaling</param>
        /// <param name="param">extra parameters to tune the used scaler For SWS_BICUBIC param[0] and [1] tune the shape of the basis function, param[0] tunes f(1) and param[1] f´(1) For SWS_GAUSS param[0] tunes the exponent and thus cutoff frequency For SWS_LANCZOS param[0] tunes the width of the window function</param>
        /// <returns>a pointer to an allocated context, or NULL in case of error</returns>
        public SwsContext* sws_getContext(int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param)
        {
            return sws_getContext_ptr(@srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
        }

        private sws_getDefaultFilter_delegate? _sws_getDefaultFilter_ptr;

        public sws_getDefaultFilter_delegate sws_getDefaultFilter_ptr => _sws_getDefaultFilter_ptr ?? (_sws_getDefaultFilter_ptr = NativeMethodDelegate<sws_getDefaultFilter_delegate>());

        public SwsFilter* sws_getDefaultFilter(float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose)
        {
            return sws_getDefaultFilter_ptr(@lumaGBlur, @chromaGBlur, @lumaSharpen, @chromaSharpen, @chromaHShift, @chromaVShift, @verbose);
        }

        private sws_getGaussianVec_delegate? _sws_getGaussianVec_ptr;

        public sws_getGaussianVec_delegate sws_getGaussianVec_ptr => _sws_getGaussianVec_ptr ?? (_sws_getGaussianVec_ptr = NativeMethodDelegate<sws_getGaussianVec_delegate>());

        /// <summary>Return a normalized Gaussian curve used to filter stuff quality = 3 is high quality, lower is lower quality.</summary>
        public SwsVector* sws_getGaussianVec(double @variance, double @quality)
        {
            return sws_getGaussianVec_ptr(@variance, @quality);
        }

        private sws_init_context_delegate? _sws_init_context_ptr;

        public sws_init_context_delegate sws_init_context_ptr => _sws_init_context_ptr ?? (_sws_init_context_ptr = NativeMethodDelegate<sws_init_context_delegate>());

        /// <summary>Initialize the swscaler context sws_context.</summary>
        /// <returns>zero or positive value on success, a negative value on error</returns>
        public int sws_init_context(SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter)
        {
            return sws_init_context_ptr(@sws_context, @srcFilter, @dstFilter);
        }

        private sws_isSupportedEndiannessConversion_delegate? _sws_isSupportedEndiannessConversion_ptr;

        public sws_isSupportedEndiannessConversion_delegate sws_isSupportedEndiannessConversion_ptr => _sws_isSupportedEndiannessConversion_ptr ?? (_sws_isSupportedEndiannessConversion_ptr = NativeMethodDelegate<sws_isSupportedEndiannessConversion_delegate>());

        /// <summary>Returns a positive value if an endianness conversion for pix_fmt is supported, 0 otherwise.</summary>
        /// <param name="pix_fmt">the pixel format</param>
        /// <returns>a positive value if an endianness conversion for pix_fmt is supported, 0 otherwise.</returns>
        public int sws_isSupportedEndiannessConversion(AVPixelFormat @pix_fmt)
        {
            return sws_isSupportedEndiannessConversion_ptr(@pix_fmt);
        }

        private sws_isSupportedInput_delegate? _sws_isSupportedInput_ptr;

        public sws_isSupportedInput_delegate sws_isSupportedInput_ptr => _sws_isSupportedInput_ptr ?? (_sws_isSupportedInput_ptr = NativeMethodDelegate<sws_isSupportedInput_delegate>());

        /// <summary>Return a positive value if pix_fmt is a supported input format, 0 otherwise.</summary>
        public int sws_isSupportedInput(AVPixelFormat @pix_fmt)
        {
            return sws_isSupportedInput_ptr(@pix_fmt);
        }

        private sws_isSupportedOutput_delegate? _sws_isSupportedOutput_ptr;

        public sws_isSupportedOutput_delegate sws_isSupportedOutput_ptr => _sws_isSupportedOutput_ptr ?? (_sws_isSupportedOutput_ptr = NativeMethodDelegate<sws_isSupportedOutput_delegate>());

        /// <summary>Return a positive value if pix_fmt is a supported output format, 0 otherwise.</summary>
        public int sws_isSupportedOutput(AVPixelFormat @pix_fmt)
        {
            return sws_isSupportedOutput_ptr(@pix_fmt);
        }

        private sws_normalizeVec_delegate? _sws_normalizeVec_ptr;

        public sws_normalizeVec_delegate sws_normalizeVec_ptr => _sws_normalizeVec_ptr ?? (_sws_normalizeVec_ptr = NativeMethodDelegate<sws_normalizeVec_delegate>());

        /// <summary>Scale all the coefficients of a so that their sum equals height.</summary>
        public void sws_normalizeVec(SwsVector* @a, double @height)
        {
            sws_normalizeVec_ptr(@a, @height);
        }

        private sws_receive_slice_delegate? _sws_receive_slice_ptr;

        public sws_receive_slice_delegate sws_receive_slice_ptr => _sws_receive_slice_ptr ?? (_sws_receive_slice_ptr = NativeMethodDelegate<sws_receive_slice_delegate>());

        /// <summary>Request a horizontal slice of the output data to be written into the frame previously provided to sws_frame_start().</summary>
        /// <param name="slice_start">first row of the slice; must be a multiple of sws_receive_slice_alignment()</param>
        /// <param name="slice_height">number of rows in the slice; must be a multiple of sws_receive_slice_alignment(), except for the last slice (i.e. when slice_start+slice_height is equal to output frame height)</param>
        /// <returns>a non-negative number if the data was successfully written into the output AVERROR(EAGAIN) if more input data needs to be provided before the output can be produced another negative AVERROR code on other kinds of scaling failure</returns>
        public int sws_receive_slice(SwsContext* @c, uint @slice_start, uint @slice_height)
        {
            return sws_receive_slice_ptr(@c, @slice_start, @slice_height);
        }

        private sws_receive_slice_alignment_delegate? _sws_receive_slice_alignment_ptr;

        public sws_receive_slice_alignment_delegate sws_receive_slice_alignment_ptr => _sws_receive_slice_alignment_ptr ?? (_sws_receive_slice_alignment_ptr = NativeMethodDelegate<sws_receive_slice_alignment_delegate>());

        /// <summary>Returns alignment required for output slices requested with sws_receive_slice(). Slice offsets and sizes passed to sws_receive_slice() must be multiples of the value returned from this function.</summary>
        /// <returns>alignment required for output slices requested with sws_receive_slice(). Slice offsets and sizes passed to sws_receive_slice() must be multiples of the value returned from this function.</returns>
        public uint sws_receive_slice_alignment(SwsContext* @c)
        {
            return sws_receive_slice_alignment_ptr(@c);
        }

        private sws_scale_delegate? _sws_scale_ptr;

        public sws_scale_delegate sws_scale_ptr => _sws_scale_ptr ?? (_sws_scale_ptr = NativeMethodDelegate<sws_scale_delegate>());

        /// <summary>Scale the image slice in srcSlice and put the resulting scaled slice in the image in dst. A slice is a sequence of consecutive rows in an image.</summary>
        /// <param name="c">the scaling context previously created with sws_getContext()</param>
        /// <param name="srcSlice">the array containing the pointers to the planes of the source slice</param>
        /// <param name="srcStride">the array containing the strides for each plane of the source image</param>
        /// <param name="srcSliceY">the position in the source image of the slice to process, that is the number (counted starting from zero) in the image of the first row of the slice</param>
        /// <param name="srcSliceH">the height of the source slice, that is the number of rows in the slice</param>
        /// <param name="dst">the array containing the pointers to the planes of the destination image</param>
        /// <param name="dstStride">the array containing the strides for each plane of the destination image</param>
        /// <returns>the height of the output slice</returns>
        public int sws_scale(SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride)
        {
            return sws_scale_ptr(@c, @srcSlice, @srcStride, @srcSliceY, @srcSliceH, @dst, @dstStride);
        }

        private sws_scale_frame_delegate? _sws_scale_frame_ptr;

        public sws_scale_frame_delegate sws_scale_frame_ptr => _sws_scale_frame_ptr ?? (_sws_scale_frame_ptr = NativeMethodDelegate<sws_scale_frame_delegate>());

        /// <summary>Scale source data from src and write the output to dst.</summary>
        /// <param name="dst">The destination frame. See documentation for sws_frame_start() for more details.</param>
        /// <param name="src">The source frame.</param>
        /// <returns>0 on success, a negative AVERROR code on failure</returns>
        public int sws_scale_frame(SwsContext* @c, AVFrame* @dst, AVFrame* @src)
        {
            return sws_scale_frame_ptr(@c, @dst, @src);
        }

        private sws_scaleVec_delegate? _sws_scaleVec_ptr;

        public sws_scaleVec_delegate sws_scaleVec_ptr => _sws_scaleVec_ptr ?? (_sws_scaleVec_ptr = NativeMethodDelegate<sws_scaleVec_delegate>());

        /// <summary>Scale all the coefficients of a by the scalar value.</summary>
        public void sws_scaleVec(SwsVector* @a, double @scalar)
        {
            sws_scaleVec_ptr(@a, @scalar);
        }

        private sws_send_slice_delegate? _sws_send_slice_ptr;

        public sws_send_slice_delegate sws_send_slice_ptr => _sws_send_slice_ptr ?? (_sws_send_slice_ptr = NativeMethodDelegate<sws_send_slice_delegate>());

        /// <summary>Indicate that a horizontal slice of input data is available in the source frame previously provided to sws_frame_start(). The slices may be provided in any order, but may not overlap. For vertically subsampled pixel formats, the slices must be aligned according to subsampling.</summary>
        /// <param name="slice_start">first row of the slice</param>
        /// <param name="slice_height">number of rows in the slice</param>
        /// <returns>a non-negative number on success, a negative AVERROR code on failure.</returns>
        public int sws_send_slice(SwsContext* @c, uint @slice_start, uint @slice_height)
        {
            return sws_send_slice_ptr(@c, @slice_start, @slice_height);
        }

        private sws_setColorspaceDetails_delegate? _sws_setColorspaceDetails_ptr;

        public sws_setColorspaceDetails_delegate sws_setColorspaceDetails_ptr => _sws_setColorspaceDetails_ptr ?? (_sws_setColorspaceDetails_ptr = NativeMethodDelegate<sws_setColorspaceDetails_delegate>());

        /// <summary>Returns negative error code on error, non negative otherwise #else Returns -1 if not supported #endif</summary>
        /// <param name="inv_table">the yuv2rgb coefficients describing the input yuv space, normally ff_yuv2rgb_coeffs[x]</param>
        /// <param name="srcRange">flag indicating the while-black range of the input (1=jpeg / 0=mpeg)</param>
        /// <param name="table">the yuv2rgb coefficients describing the output yuv space, normally ff_yuv2rgb_coeffs[x]</param>
        /// <param name="dstRange">flag indicating the while-black range of the output (1=jpeg / 0=mpeg)</param>
        /// <param name="brightness">16.16 fixed point brightness correction</param>
        /// <param name="contrast">16.16 fixed point contrast correction</param>
        /// <param name="saturation">16.16 fixed point saturation correction #if LIBSWSCALE_VERSION_MAJOR &gt; 6</param>
        /// <returns>negative error code on error, non negative otherwise #else</returns>
        public int sws_setColorspaceDetails(SwsContext* @c, int_array4 @inv_table, int @srcRange, int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation)
        {
            return sws_setColorspaceDetails_ptr(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
        }

        private swscale_configuration_delegate? _swscale_configuration_ptr;

        public swscale_configuration_delegate swscale_configuration_ptr => _swscale_configuration_ptr ?? (_swscale_configuration_ptr = NativeMethodDelegate<swscale_configuration_delegate>());

        /// <summary>Return the libswscale build-time configuration.</summary>
        public string swscale_configuration()
        {
            return swscale_configuration_ptr();
        }

        private swscale_license_delegate? _swscale_license_ptr;

        public swscale_license_delegate swscale_license_ptr => _swscale_license_ptr ?? (_swscale_license_ptr = NativeMethodDelegate<swscale_license_delegate>());

        /// <summary>Return the libswscale license.</summary>
        public string swscale_license()
        {
            return swscale_license_ptr();
        }

        private swscale_version_delegate? _swscale_version_ptr;

        public swscale_version_delegate swscale_version_ptr => _swscale_version_ptr ?? (_swscale_version_ptr = NativeMethodDelegate<swscale_version_delegate>());

        /// <summary>Color conversion and scaling library.</summary>
        public uint swscale_version()
        {
            return swscale_version_ptr();
        }
    }
}
