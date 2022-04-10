namespace FFmpeg.NET
{
    public interface IFFmpegApi
    {
        av_codec_is_decoder_delegate av_codec_is_decoder_ptr { get; }
        av_codec_is_encoder_delegate av_codec_is_encoder_ptr { get; }
        av_codec_iterate_delegate av_codec_iterate_ptr { get; }
        av_cpb_properties_alloc_delegate av_cpb_properties_alloc_ptr { get; }
        av_d3d11va_alloc_context_delegate av_d3d11va_alloc_context_ptr { get; }
        av_fast_padded_malloc_delegate av_fast_padded_malloc_ptr { get; }
        av_fast_padded_mallocz_delegate av_fast_padded_mallocz_ptr { get; }
        av_get_audio_frame_duration_delegate av_get_audio_frame_duration_ptr { get; }
        av_get_audio_frame_duration2_delegate av_get_audio_frame_duration2_ptr { get; }
        av_get_bits_per_sample_delegate av_get_bits_per_sample_ptr { get; }
        av_get_exact_bits_per_sample_delegate av_get_exact_bits_per_sample_ptr { get; }
        av_get_pcm_codec_delegate av_get_pcm_codec_ptr { get; }
        av_get_profile_name_delegate av_get_profile_name_ptr { get; }
        av_grow_packet_delegate av_grow_packet_ptr { get; }
        av_init_packet_delegate av_init_packet_ptr { get; }
        av_new_packet_delegate av_new_packet_ptr { get; }
        av_packet_add_side_data_delegate av_packet_add_side_data_ptr { get; }
        av_packet_alloc_delegate av_packet_alloc_ptr { get; }
        av_packet_clone_delegate av_packet_clone_ptr { get; }
        av_packet_copy_props_delegate av_packet_copy_props_ptr { get; }
        av_packet_free_delegate av_packet_free_ptr { get; }
        av_packet_free_side_data_delegate av_packet_free_side_data_ptr { get; }
        av_packet_from_data_delegate av_packet_from_data_ptr { get; }
        av_packet_get_side_data_delegate av_packet_get_side_data_ptr { get; }
        av_packet_make_refcounted_delegate av_packet_make_refcounted_ptr { get; }
        av_packet_make_writable_delegate av_packet_make_writable_ptr { get; }
        av_packet_move_ref_delegate av_packet_move_ref_ptr { get; }
        av_packet_new_side_data_delegate av_packet_new_side_data_ptr { get; }
        av_packet_pack_dictionary_delegate av_packet_pack_dictionary_ptr { get; }
        av_packet_ref_delegate av_packet_ref_ptr { get; }
        av_packet_rescale_ts_delegate av_packet_rescale_ts_ptr { get; }
        av_packet_shrink_side_data_delegate av_packet_shrink_side_data_ptr { get; }
        av_packet_side_data_name_delegate av_packet_side_data_name_ptr { get; }
        av_packet_unpack_dictionary_delegate av_packet_unpack_dictionary_ptr { get; }
        av_packet_unref_delegate av_packet_unref_ptr { get; }
        av_parser_close_delegate av_parser_close_ptr { get; }
        av_parser_init_delegate av_parser_init_ptr { get; }
        av_parser_iterate_delegate av_parser_iterate_ptr { get; }
        av_parser_parse2_delegate av_parser_parse2_ptr { get; }
        av_shrink_packet_delegate av_shrink_packet_ptr { get; }
        av_xiphlacing_delegate av_xiphlacing_ptr { get; }
        avcodec_align_dimensions_delegate avcodec_align_dimensions_ptr { get; }
        avcodec_align_dimensions2_delegate avcodec_align_dimensions2_ptr { get; }
        avcodec_alloc_context3_delegate avcodec_alloc_context3_ptr { get; }
        avcodec_chroma_pos_to_enum_delegate avcodec_chroma_pos_to_enum_ptr { get; }
        avcodec_close_delegate avcodec_close_ptr { get; }
        avcodec_configuration_delegate avcodec_configuration_ptr { get; }
        avcodec_decode_subtitle2_delegate avcodec_decode_subtitle2_ptr { get; }
        avcodec_default_execute_delegate avcodec_default_execute_ptr { get; }
        avcodec_default_execute2_delegate avcodec_default_execute2_ptr { get; }
        avcodec_default_get_buffer2_delegate avcodec_default_get_buffer2_ptr { get; }
        avcodec_default_get_encode_buffer_delegate avcodec_default_get_encode_buffer_ptr { get; }
        avcodec_default_get_format_delegate avcodec_default_get_format_ptr { get; }
        avcodec_descriptor_get_delegate avcodec_descriptor_get_ptr { get; }
        avcodec_descriptor_get_by_name_delegate avcodec_descriptor_get_by_name_ptr { get; }
        avcodec_descriptor_next_delegate avcodec_descriptor_next_ptr { get; }
        avcodec_encode_subtitle_delegate avcodec_encode_subtitle_ptr { get; }
        avcodec_enum_to_chroma_pos_delegate avcodec_enum_to_chroma_pos_ptr { get; }
        avcodec_fill_audio_frame_delegate avcodec_fill_audio_frame_ptr { get; }
        avcodec_find_best_pix_fmt_of_list_delegate avcodec_find_best_pix_fmt_of_list_ptr { get; }
        avcodec_find_decoder_delegate avcodec_find_decoder_ptr { get; }
        avcodec_find_decoder_by_name_delegate avcodec_find_decoder_by_name_ptr { get; }
        avcodec_find_encoder_delegate avcodec_find_encoder_ptr { get; }
        avcodec_find_encoder_by_name_delegate avcodec_find_encoder_by_name_ptr { get; }
        avcodec_flush_buffers_delegate avcodec_flush_buffers_ptr { get; }
        avcodec_free_context_delegate avcodec_free_context_ptr { get; }
        avcodec_get_class_delegate avcodec_get_class_ptr { get; }
        avcodec_get_frame_class_delegate avcodec_get_frame_class_ptr { get; }
        avcodec_get_hw_config_delegate avcodec_get_hw_config_ptr { get; }
        avcodec_get_hw_frames_parameters_delegate avcodec_get_hw_frames_parameters_ptr { get; }
        avcodec_get_name_delegate avcodec_get_name_ptr { get; }
        avcodec_get_subtitle_rect_class_delegate avcodec_get_subtitle_rect_class_ptr { get; }
        avcodec_get_type_delegate avcodec_get_type_ptr { get; }
        avcodec_is_open_delegate avcodec_is_open_ptr { get; }
        avcodec_license_delegate avcodec_license_ptr { get; }
        avcodec_open2_delegate avcodec_open2_ptr { get; }
        avcodec_parameters_alloc_delegate avcodec_parameters_alloc_ptr { get; }
        avcodec_parameters_copy_delegate avcodec_parameters_copy_ptr { get; }
        avcodec_parameters_free_delegate avcodec_parameters_free_ptr { get; }
        avcodec_parameters_from_context_delegate avcodec_parameters_from_context_ptr { get; }
        avcodec_parameters_to_context_delegate avcodec_parameters_to_context_ptr { get; }
        avcodec_pix_fmt_to_codec_tag_delegate avcodec_pix_fmt_to_codec_tag_ptr { get; }
        avcodec_profile_name_delegate avcodec_profile_name_ptr { get; }
        avcodec_receive_frame_delegate avcodec_receive_frame_ptr { get; }
        avcodec_receive_packet_delegate avcodec_receive_packet_ptr { get; }
        avcodec_send_frame_delegate avcodec_send_frame_ptr { get; }
        avcodec_send_packet_delegate avcodec_send_packet_ptr { get; }
        avcodec_string_delegate avcodec_string_ptr { get; }
        avcodec_version_delegate avcodec_version_ptr { get; }
        avsubtitle_free_delegate avsubtitle_free_ptr { get; }
        av_input_audio_device_next_delegate av_input_audio_device_next_ptr { get; }
        av_input_video_device_next_delegate av_input_video_device_next_ptr { get; }
        av_output_audio_device_next_delegate av_output_audio_device_next_ptr { get; }
        av_output_video_device_next_delegate av_output_video_device_next_ptr { get; }
        avdevice_app_to_dev_control_message_delegate avdevice_app_to_dev_control_message_ptr { get; }
        avdevice_capabilities_create_delegate avdevice_capabilities_create_ptr { get; }
        avdevice_capabilities_free_delegate avdevice_capabilities_free_ptr { get; }
        avdevice_configuration_delegate avdevice_configuration_ptr { get; }
        avdevice_dev_to_app_control_message_delegate avdevice_dev_to_app_control_message_ptr { get; }
        avdevice_free_list_devices_delegate avdevice_free_list_devices_ptr { get; }
        avdevice_license_delegate avdevice_license_ptr { get; }
        avdevice_list_devices_delegate avdevice_list_devices_ptr { get; }
        avdevice_list_input_sources_delegate avdevice_list_input_sources_ptr { get; }
        avdevice_list_output_sinks_delegate avdevice_list_output_sinks_ptr { get; }
        avdevice_register_all_delegate avdevice_register_all_ptr { get; }
        avdevice_version_delegate avdevice_version_ptr { get; }
        av_abuffersink_params_alloc_delegate av_abuffersink_params_alloc_ptr { get; }
        av_buffersink_get_channel_layout_delegate av_buffersink_get_channel_layout_ptr { get; }
        av_buffersink_get_channels_delegate av_buffersink_get_channels_ptr { get; }
        av_buffersink_get_format_delegate av_buffersink_get_format_ptr { get; }
        av_buffersink_get_frame_delegate av_buffersink_get_frame_ptr { get; }
        av_buffersink_get_frame_flags_delegate av_buffersink_get_frame_flags_ptr { get; }
        av_buffersink_get_frame_rate_delegate av_buffersink_get_frame_rate_ptr { get; }
        av_buffersink_get_h_delegate av_buffersink_get_h_ptr { get; }
        av_buffersink_get_hw_frames_ctx_delegate av_buffersink_get_hw_frames_ctx_ptr { get; }
        av_buffersink_get_sample_aspect_ratio_delegate av_buffersink_get_sample_aspect_ratio_ptr { get; }
        av_buffersink_get_sample_rate_delegate av_buffersink_get_sample_rate_ptr { get; }
        av_buffersink_get_samples_delegate av_buffersink_get_samples_ptr { get; }
        av_buffersink_get_time_base_delegate av_buffersink_get_time_base_ptr { get; }
        av_buffersink_get_type_delegate av_buffersink_get_type_ptr { get; }
        av_buffersink_get_w_delegate av_buffersink_get_w_ptr { get; }
        av_buffersink_params_alloc_delegate av_buffersink_params_alloc_ptr { get; }
        av_buffersink_set_frame_size_delegate av_buffersink_set_frame_size_ptr { get; }
        av_buffersrc_add_frame_delegate av_buffersrc_add_frame_ptr { get; }
        av_buffersrc_add_frame_flags_delegate av_buffersrc_add_frame_flags_ptr { get; }
        av_buffersrc_close_delegate av_buffersrc_close_ptr { get; }
        av_buffersrc_get_nb_failed_requests_delegate av_buffersrc_get_nb_failed_requests_ptr { get; }
        av_buffersrc_parameters_alloc_delegate av_buffersrc_parameters_alloc_ptr { get; }
        av_buffersrc_parameters_set_delegate av_buffersrc_parameters_set_ptr { get; }
        av_buffersrc_write_frame_delegate av_buffersrc_write_frame_ptr { get; }
        av_filter_iterate_delegate av_filter_iterate_ptr { get; }
        avfilter_config_links_delegate avfilter_config_links_ptr { get; }
        avfilter_configuration_delegate avfilter_configuration_ptr { get; }
        avfilter_filter_pad_count_delegate avfilter_filter_pad_count_ptr { get; }
        avfilter_free_delegate avfilter_free_ptr { get; }
        avfilter_get_by_name_delegate avfilter_get_by_name_ptr { get; }
        avfilter_get_class_delegate avfilter_get_class_ptr { get; }
        avfilter_graph_alloc_delegate avfilter_graph_alloc_ptr { get; }
        avfilter_graph_alloc_filter_delegate avfilter_graph_alloc_filter_ptr { get; }
        avfilter_graph_config_delegate avfilter_graph_config_ptr { get; }
        avfilter_graph_create_filter_delegate avfilter_graph_create_filter_ptr { get; }
        avfilter_graph_dump_delegate avfilter_graph_dump_ptr { get; }
        avfilter_graph_free_delegate avfilter_graph_free_ptr { get; }
        avfilter_graph_get_filter_delegate avfilter_graph_get_filter_ptr { get; }
        avfilter_graph_parse_delegate avfilter_graph_parse_fptr { get; }
        avfilter_graph_parse_ptr_delegate avfilter_graph_parse_ptr_ptr { get; }
        avfilter_graph_parse2_delegate avfilter_graph_parse2_ptr { get; }
        avfilter_graph_queue_command_delegate avfilter_graph_queue_command_ptr { get; }
        avfilter_graph_request_oldest_delegate avfilter_graph_request_oldest_ptr { get; }
        avfilter_graph_send_command_delegate avfilter_graph_send_command_ptr { get; }
        avfilter_graph_set_auto_convert_delegate avfilter_graph_set_auto_convert_ptr { get; }
        avfilter_init_dict_delegate avfilter_init_dict_ptr { get; }
        avfilter_init_str_delegate avfilter_init_str_ptr { get; }
        avfilter_inout_alloc_delegate avfilter_inout_alloc_ptr { get; }
        avfilter_inout_free_delegate avfilter_inout_free_ptr { get; }
        avfilter_insert_filter_delegate avfilter_insert_filter_ptr { get; }
        avfilter_license_delegate avfilter_license_ptr { get; }
        avfilter_link_delegate avfilter_link_ptr { get; }
        avfilter_link_free_delegate avfilter_link_free_ptr { get; }
        avfilter_pad_count_delegate avfilter_pad_count_ptr { get; }
        avfilter_pad_get_name_delegate avfilter_pad_get_name_ptr { get; }
        avfilter_pad_get_type_delegate avfilter_pad_get_type_ptr { get; }
        avfilter_process_command_delegate avfilter_process_command_ptr { get; }
        avfilter_version_delegate avfilter_version_ptr { get; }
        av_add_index_entry_delegate av_add_index_entry_ptr { get; }
        av_append_packet_delegate av_append_packet_ptr { get; }
        av_codec_get_id_delegate av_codec_get_id_ptr { get; }
        av_codec_get_tag_delegate av_codec_get_tag_ptr { get; }
        av_codec_get_tag2_delegate av_codec_get_tag2_ptr { get; }
        av_demuxer_iterate_delegate av_demuxer_iterate_ptr { get; }
        av_disposition_from_string_delegate av_disposition_from_string_ptr { get; }
        av_disposition_to_string_delegate av_disposition_to_string_ptr { get; }
        av_dump_format_delegate av_dump_format_ptr { get; }
        av_filename_number_test_delegate av_filename_number_test_ptr { get; }
        av_find_best_stream_delegate av_find_best_stream_ptr { get; }
        av_find_default_stream_index_delegate av_find_default_stream_index_ptr { get; }
        av_find_input_format_delegate av_find_input_format_ptr { get; }
        av_find_program_from_stream_delegate av_find_program_from_stream_ptr { get; }
        av_fmt_ctx_get_duration_estimation_method_delegate av_fmt_ctx_get_duration_estimation_method_ptr { get; }
        av_format_inject_global_side_data_delegate av_format_inject_global_side_data_ptr { get; }
        av_get_frame_filename_delegate av_get_frame_filename_ptr { get; }
        av_get_frame_filename2_delegate av_get_frame_filename2_ptr { get; }
        av_get_output_timestamp_delegate av_get_output_timestamp_ptr { get; }
        av_get_packet_delegate av_get_packet_ptr { get; }
        av_guess_codec_delegate av_guess_codec_ptr { get; }
        av_guess_format_delegate av_guess_format_ptr { get; }
        av_guess_frame_rate_delegate av_guess_frame_rate_ptr { get; }
        av_guess_sample_aspect_ratio_delegate av_guess_sample_aspect_ratio_ptr { get; }
        av_hex_dump_delegate av_hex_dump_ptr { get; }
        av_hex_dump_log_delegate av_hex_dump_log_ptr { get; }
        av_index_search_timestamp_delegate av_index_search_timestamp_ptr { get; }
        av_interleaved_write_frame_delegate av_interleaved_write_frame_ptr { get; }
        av_interleaved_write_uncoded_frame_delegate av_interleaved_write_uncoded_frame_ptr { get; }
        av_match_ext_delegate av_match_ext_ptr { get; }
        av_muxer_iterate_delegate av_muxer_iterate_ptr { get; }
        av_new_program_delegate av_new_program_ptr { get; }
        av_pkt_dump_log2_delegate av_pkt_dump_log2_ptr { get; }
        av_pkt_dump2_delegate av_pkt_dump2_ptr { get; }
        av_probe_input_buffer_delegate av_probe_input_buffer_ptr { get; }
        av_probe_input_buffer2_delegate av_probe_input_buffer2_ptr { get; }
        av_probe_input_format_delegate av_probe_input_format_ptr { get; }
        av_probe_input_format2_delegate av_probe_input_format2_ptr { get; }
        av_probe_input_format3_delegate av_probe_input_format3_ptr { get; }
        av_program_add_stream_index_delegate av_program_add_stream_index_ptr { get; }
        av_read_frame_delegate av_read_frame_ptr { get; }
        av_read_pause_delegate av_read_pause_ptr { get; }
        av_read_play_delegate av_read_play_ptr { get; }
        av_sdp_create_delegate av_sdp_create_ptr { get; }
        av_seek_frame_delegate av_seek_frame_ptr { get; }
        av_stream_add_side_data_delegate av_stream_add_side_data_ptr { get; }
        av_stream_get_class_delegate av_stream_get_class_ptr { get; }
        av_stream_get_codec_timebase_delegate av_stream_get_codec_timebase_ptr { get; }
        av_stream_get_end_pts_delegate av_stream_get_end_pts_ptr { get; }
        av_stream_get_parser_delegate av_stream_get_parser_ptr { get; }
        av_stream_get_side_data_delegate av_stream_get_side_data_ptr { get; }
        av_stream_new_side_data_delegate av_stream_new_side_data_ptr { get; }
        av_url_split_delegate av_url_split_ptr { get; }
        av_write_frame_delegate av_write_frame_ptr { get; }
        av_write_trailer_delegate av_write_trailer_ptr { get; }
        av_write_uncoded_frame_delegate av_write_uncoded_frame_ptr { get; }
        av_write_uncoded_frame_query_delegate av_write_uncoded_frame_query_ptr { get; }
        avformat_alloc_context_delegate avformat_alloc_context_ptr { get; }
        avformat_alloc_output_context2_delegate avformat_alloc_output_context2_ptr { get; }
        avformat_close_input_delegate avformat_close_input_ptr { get; }
        avformat_configuration_delegate avformat_configuration_ptr { get; }
        avformat_find_stream_info_delegate avformat_find_stream_info_ptr { get; }
        avformat_flush_delegate avformat_flush_ptr { get; }
        avformat_free_context_delegate avformat_free_context_ptr { get; }
        avformat_get_class_delegate avformat_get_class_ptr { get; }
        avformat_get_mov_audio_tags_delegate avformat_get_mov_audio_tags_ptr { get; }
        avformat_get_mov_video_tags_delegate avformat_get_mov_video_tags_ptr { get; }
        avformat_get_riff_audio_tags_delegate avformat_get_riff_audio_tags_ptr { get; }
        avformat_get_riff_video_tags_delegate avformat_get_riff_video_tags_ptr { get; }
        avformat_index_get_entries_count_delegate avformat_index_get_entries_count_ptr { get; }
        avformat_index_get_entry_delegate avformat_index_get_entry_ptr { get; }
        avformat_index_get_entry_from_timestamp_delegate avformat_index_get_entry_from_timestamp_ptr { get; }
        avformat_init_output_delegate avformat_init_output_ptr { get; }
        avformat_license_delegate avformat_license_ptr { get; }
        avformat_match_stream_specifier_delegate avformat_match_stream_specifier_ptr { get; }
        avformat_network_deinit_delegate avformat_network_deinit_ptr { get; }
        avformat_network_init_delegate avformat_network_init_ptr { get; }
        avformat_new_stream_delegate avformat_new_stream_ptr { get; }
        avformat_open_input_delegate avformat_open_input_ptr { get; }
        avformat_query_codec_delegate avformat_query_codec_ptr { get; }
        avformat_queue_attached_pictures_delegate avformat_queue_attached_pictures_ptr { get; }
        avformat_seek_file_delegate avformat_seek_file_ptr { get; }
        avformat_transfer_internal_stream_timing_info_delegate avformat_transfer_internal_stream_timing_info_ptr { get; }
        avformat_version_delegate avformat_version_ptr { get; }
        avformat_write_header_delegate avformat_write_header_ptr { get; }
        avio_accept_delegate avio_accept_ptr { get; }
        avio_alloc_context_delegate avio_alloc_context_ptr { get; }
        avio_check_delegate avio_check_ptr { get; }
        avio_close_delegate avio_close_ptr { get; }
        avio_close_dir_delegate avio_close_dir_ptr { get; }
        avio_close_dyn_buf_delegate avio_close_dyn_buf_ptr { get; }
        avio_closep_delegate avio_closep_ptr { get; }
        avio_context_free_delegate avio_context_free_ptr { get; }
        avio_enum_protocols_delegate avio_enum_protocols_ptr { get; }
        avio_feof_delegate avio_feof_ptr { get; }
        avio_find_protocol_name_delegate avio_find_protocol_name_ptr { get; }
        avio_flush_delegate avio_flush_ptr { get; }
        avio_free_directory_entry_delegate avio_free_directory_entry_ptr { get; }
        avio_get_dyn_buf_delegate avio_get_dyn_buf_ptr { get; }
        avio_get_str_delegate avio_get_str_ptr { get; }
        avio_get_str16be_delegate avio_get_str16be_ptr { get; }
        avio_get_str16le_delegate avio_get_str16le_ptr { get; }
        avio_handshake_delegate avio_handshake_ptr { get; }
        avio_open_delegate avio_open_ptr { get; }
        avio_open_dir_delegate avio_open_dir_ptr { get; }
        avio_open_dyn_buf_delegate avio_open_dyn_buf_ptr { get; }
        avio_open2_delegate avio_open2_ptr { get; }
        avio_pause_delegate avio_pause_ptr { get; }
        avio_print_string_array_delegate avio_print_string_array_ptr { get; }
        avio_printf_delegate avio_printf_ptr { get; }
        avio_protocol_get_class_delegate avio_protocol_get_class_ptr { get; }
        avio_put_str_delegate avio_put_str_ptr { get; }
        avio_put_str16be_delegate avio_put_str16be_ptr { get; }
        avio_put_str16le_delegate avio_put_str16le_ptr { get; }
        avio_r8_delegate avio_r8_ptr { get; }
        avio_rb16_delegate avio_rb16_ptr { get; }
        avio_rb24_delegate avio_rb24_ptr { get; }
        avio_rb32_delegate avio_rb32_ptr { get; }
        avio_rb64_delegate avio_rb64_ptr { get; }
        avio_read_delegate avio_read_ptr { get; }
        avio_read_dir_delegate avio_read_dir_ptr { get; }
        avio_read_partial_delegate avio_read_partial_ptr { get; }
        avio_read_to_bprint_delegate avio_read_to_bprint_ptr { get; }
        avio_rl16_delegate avio_rl16_ptr { get; }
        avio_rl24_delegate avio_rl24_ptr { get; }
        avio_rl32_delegate avio_rl32_ptr { get; }
        avio_rl64_delegate avio_rl64_ptr { get; }
        avio_seek_delegate avio_seek_ptr { get; }
        avio_seek_time_delegate avio_seek_time_ptr { get; }
        avio_size_delegate avio_size_ptr { get; }
        avio_skip_delegate avio_skip_ptr { get; }
        avio_w8_delegate avio_w8_ptr { get; }
        avio_wb16_delegate avio_wb16_ptr { get; }
        avio_wb24_delegate avio_wb24_ptr { get; }
        avio_wb32_delegate avio_wb32_ptr { get; }
        avio_wb64_delegate avio_wb64_ptr { get; }
        avio_wl16_delegate avio_wl16_ptr { get; }
        avio_wl24_delegate avio_wl24_ptr { get; }
        avio_wl32_delegate avio_wl32_ptr { get; }
        avio_wl64_delegate avio_wl64_ptr { get; }
        avio_write_delegate avio_write_ptr { get; }
        avio_write_marker_delegate avio_write_marker_ptr { get; }
        av_add_q_delegate av_add_q_ptr { get; }
        av_add_stable_delegate av_add_stable_ptr { get; }
        av_audio_fifo_alloc_delegate av_audio_fifo_alloc_ptr { get; }
        av_audio_fifo_drain_delegate av_audio_fifo_drain_ptr { get; }
        av_audio_fifo_free_delegate av_audio_fifo_free_ptr { get; }
        av_audio_fifo_peek_delegate av_audio_fifo_peek_ptr { get; }
        av_audio_fifo_peek_at_delegate av_audio_fifo_peek_at_ptr { get; }
        av_audio_fifo_read_delegate av_audio_fifo_read_ptr { get; }
        av_audio_fifo_realloc_delegate av_audio_fifo_realloc_ptr { get; }
        av_audio_fifo_reset_delegate av_audio_fifo_reset_ptr { get; }
        av_audio_fifo_size_delegate av_audio_fifo_size_ptr { get; }
        av_audio_fifo_space_delegate av_audio_fifo_space_ptr { get; }
        av_audio_fifo_write_delegate av_audio_fifo_write_ptr { get; }
        av_bprint_channel_layout_delegate av_bprint_channel_layout_ptr { get; }
        av_buffer_alloc_delegate av_buffer_alloc_ptr { get; }
        av_buffer_allocz_delegate av_buffer_allocz_ptr { get; }
        av_buffer_create_delegate av_buffer_create_ptr { get; }
        av_buffer_default_free_delegate av_buffer_default_free_ptr { get; }
        av_buffer_get_opaque_delegate av_buffer_get_opaque_ptr { get; }
        av_buffer_get_ref_count_delegate av_buffer_get_ref_count_ptr { get; }
        av_buffer_is_writable_delegate av_buffer_is_writable_ptr { get; }
        av_buffer_make_writable_delegate av_buffer_make_writable_ptr { get; }
        av_buffer_pool_buffer_get_opaque_delegate av_buffer_pool_buffer_get_opaque_ptr { get; }
        av_buffer_pool_get_delegate av_buffer_pool_get_ptr { get; }
        av_buffer_pool_init_delegate av_buffer_pool_init_ptr { get; }
        av_buffer_pool_init2_delegate av_buffer_pool_init2_ptr { get; }
        av_buffer_pool_uninit_delegate av_buffer_pool_uninit_ptr { get; }
        av_buffer_realloc_delegate av_buffer_realloc_ptr { get; }
        av_buffer_ref_delegate av_buffer_ref_ptr { get; }
        av_buffer_replace_delegate av_buffer_replace_ptr { get; }
        av_buffer_unref_delegate av_buffer_unref_ptr { get; }
        av_calloc_delegate av_calloc_ptr { get; }
        av_channel_layout_extract_channel_delegate av_channel_layout_extract_channel_ptr { get; }
        av_chroma_location_from_name_delegate av_chroma_location_from_name_ptr { get; }
        av_chroma_location_name_delegate av_chroma_location_name_ptr { get; }
        av_color_primaries_from_name_delegate av_color_primaries_from_name_ptr { get; }
        av_color_primaries_name_delegate av_color_primaries_name_ptr { get; }
        av_color_range_from_name_delegate av_color_range_from_name_ptr { get; }
        av_color_range_name_delegate av_color_range_name_ptr { get; }
        av_color_space_from_name_delegate av_color_space_from_name_ptr { get; }
        av_color_space_name_delegate av_color_space_name_ptr { get; }
        av_color_transfer_from_name_delegate av_color_transfer_from_name_ptr { get; }
        av_color_transfer_name_delegate av_color_transfer_name_ptr { get; }
        av_compare_mod_delegate av_compare_mod_ptr { get; }
        av_compare_ts_delegate av_compare_ts_ptr { get; }
        av_content_light_metadata_alloc_delegate av_content_light_metadata_alloc_ptr { get; }
        av_content_light_metadata_create_side_data_delegate av_content_light_metadata_create_side_data_ptr { get; }
        av_cpu_count_delegate av_cpu_count_ptr { get; }
        av_cpu_force_count_delegate av_cpu_force_count_ptr { get; }
        av_cpu_max_align_delegate av_cpu_max_align_ptr { get; }
        av_d2q_delegate av_d2q_ptr { get; }
        av_default_get_category_delegate av_default_get_category_ptr { get; }
        av_default_item_name_delegate av_default_item_name_ptr { get; }
        av_dict_copy_delegate av_dict_copy_ptr { get; }
        av_dict_count_delegate av_dict_count_ptr { get; }
        av_dict_free_delegate av_dict_free_ptr { get; }
        av_dict_get_delegate av_dict_get_ptr { get; }
        av_dict_get_string_delegate av_dict_get_string_ptr { get; }
        av_dict_parse_string_delegate av_dict_parse_string_ptr { get; }
        av_dict_set_delegate av_dict_set_ptr { get; }
        av_dict_set_int_delegate av_dict_set_int_ptr { get; }
        av_div_q_delegate av_div_q_ptr { get; }
        av_dynamic_hdr_plus_alloc_delegate av_dynamic_hdr_plus_alloc_ptr { get; }
        av_dynamic_hdr_plus_create_side_data_delegate av_dynamic_hdr_plus_create_side_data_ptr { get; }
        av_dynarray_add_delegate av_dynarray_add_ptr { get; }
        av_dynarray_add_nofree_delegate av_dynarray_add_nofree_ptr { get; }
        av_dynarray2_add_delegate av_dynarray2_add_ptr { get; }
        av_fast_malloc_delegate av_fast_malloc_ptr { get; }
        av_fast_mallocz_delegate av_fast_mallocz_ptr { get; }
        av_fast_realloc_delegate av_fast_realloc_ptr { get; }
        av_fifo_alloc_delegate av_fifo_alloc_ptr { get; }
        av_fifo_alloc_array_delegate av_fifo_alloc_array_ptr { get; }
        av_fifo_drain_delegate av_fifo_drain_ptr { get; }
        av_fifo_free_delegate av_fifo_free_ptr { get; }
        av_fifo_freep_delegate av_fifo_freep_ptr { get; }
        av_fifo_generic_peek_delegate av_fifo_generic_peek_ptr { get; }
        av_fifo_generic_peek_at_delegate av_fifo_generic_peek_at_ptr { get; }
        av_fifo_generic_read_delegate av_fifo_generic_read_ptr { get; }
        av_fifo_generic_write_delegate av_fifo_generic_write_ptr { get; }
        av_fifo_grow_delegate av_fifo_grow_ptr { get; }
        av_fifo_realloc2_delegate av_fifo_realloc2_ptr { get; }
        av_fifo_reset_delegate av_fifo_reset_ptr { get; }
        av_fifo_size_delegate av_fifo_size_ptr { get; }
        av_fifo_space_delegate av_fifo_space_ptr { get; }
        av_file_map_delegate av_file_map_ptr { get; }
        av_file_unmap_delegate av_file_unmap_ptr { get; }
        av_find_best_pix_fmt_of_2_delegate av_find_best_pix_fmt_of_2_ptr { get; }
        av_find_nearest_q_idx_delegate av_find_nearest_q_idx_ptr { get; }
        av_fopen_utf8_delegate av_fopen_utf8_ptr { get; }
        av_force_cpu_flags_delegate av_force_cpu_flags_ptr { get; }
        av_fourcc_make_string_delegate av_fourcc_make_string_ptr { get; }
        av_frame_alloc_delegate av_frame_alloc_ptr { get; }
        av_frame_apply_cropping_delegate av_frame_apply_cropping_ptr { get; }
        av_frame_clone_delegate av_frame_clone_ptr { get; }
        av_frame_copy_delegate av_frame_copy_ptr { get; }
        av_frame_copy_props_delegate av_frame_copy_props_ptr { get; }
        av_frame_free_delegate av_frame_free_ptr { get; }
        av_frame_get_buffer_delegate av_frame_get_buffer_ptr { get; }
        av_frame_get_plane_buffer_delegate av_frame_get_plane_buffer_ptr { get; }
        av_frame_get_side_data_delegate av_frame_get_side_data_ptr { get; }
        av_frame_is_writable_delegate av_frame_is_writable_ptr { get; }
        av_frame_make_writable_delegate av_frame_make_writable_ptr { get; }
        av_frame_move_ref_delegate av_frame_move_ref_ptr { get; }
        av_frame_new_side_data_delegate av_frame_new_side_data_ptr { get; }
        av_frame_new_side_data_from_buf_delegate av_frame_new_side_data_from_buf_ptr { get; }
        av_frame_ref_delegate av_frame_ref_ptr { get; }
        av_frame_remove_side_data_delegate av_frame_remove_side_data_ptr { get; }
        av_frame_side_data_name_delegate av_frame_side_data_name_ptr { get; }
        av_frame_unref_delegate av_frame_unref_ptr { get; }
        av_free_delegate av_free_ptr { get; }
        av_freep_delegate av_freep_ptr { get; }
        av_gcd_delegate av_gcd_ptr { get; }
        av_gcd_q_delegate av_gcd_q_ptr { get; }
        av_get_alt_sample_fmt_delegate av_get_alt_sample_fmt_ptr { get; }
        av_get_bits_per_pixel_delegate av_get_bits_per_pixel_ptr { get; }
        av_get_bytes_per_sample_delegate av_get_bytes_per_sample_ptr { get; }
        av_get_channel_description_delegate av_get_channel_description_ptr { get; }
        av_get_channel_layout_delegate av_get_channel_layout_ptr { get; }
        av_get_channel_layout_channel_index_delegate av_get_channel_layout_channel_index_ptr { get; }
        av_get_channel_layout_nb_channels_delegate av_get_channel_layout_nb_channels_ptr { get; }
        av_get_channel_layout_string_delegate av_get_channel_layout_string_ptr { get; }
        av_get_channel_name_delegate av_get_channel_name_ptr { get; }
        av_get_colorspace_name_delegate av_get_colorspace_name_ptr { get; }
        av_get_cpu_flags_delegate av_get_cpu_flags_ptr { get; }
        av_get_default_channel_layout_delegate av_get_default_channel_layout_ptr { get; }
        av_get_extended_channel_layout_delegate av_get_extended_channel_layout_ptr { get; }
        av_get_media_type_string_delegate av_get_media_type_string_ptr { get; }
        av_get_packed_sample_fmt_delegate av_get_packed_sample_fmt_ptr { get; }
        av_get_padded_bits_per_pixel_delegate av_get_padded_bits_per_pixel_ptr { get; }
        av_get_picture_type_char_delegate av_get_picture_type_char_ptr { get; }
        av_get_pix_fmt_delegate av_get_pix_fmt_ptr { get; }
        av_get_pix_fmt_loss_delegate av_get_pix_fmt_loss_ptr { get; }
        av_get_pix_fmt_name_delegate av_get_pix_fmt_name_ptr { get; }
        av_get_pix_fmt_string_delegate av_get_pix_fmt_string_ptr { get; }
        av_get_planar_sample_fmt_delegate av_get_planar_sample_fmt_ptr { get; }
        av_get_sample_fmt_delegate av_get_sample_fmt_ptr { get; }
        av_get_sample_fmt_name_delegate av_get_sample_fmt_name_ptr { get; }
        av_get_sample_fmt_string_delegate av_get_sample_fmt_string_ptr { get; }
        av_get_standard_channel_layout_delegate av_get_standard_channel_layout_ptr { get; }
        av_get_time_base_q_delegate av_get_time_base_q_ptr { get; }
        av_gettime_delegate av_gettime_ptr { get; }
        av_gettime_relative_delegate av_gettime_relative_ptr { get; }
        av_gettime_relative_is_monotonic_delegate av_gettime_relative_is_monotonic_ptr { get; }
        av_hwdevice_ctx_alloc_delegate av_hwdevice_ctx_alloc_ptr { get; }
        av_hwdevice_ctx_create_delegate av_hwdevice_ctx_create_ptr { get; }
        av_hwdevice_ctx_create_derived_delegate av_hwdevice_ctx_create_derived_ptr { get; }
        av_hwdevice_ctx_create_derived_opts_delegate av_hwdevice_ctx_create_derived_opts_ptr { get; }
        av_hwdevice_ctx_init_delegate av_hwdevice_ctx_init_ptr { get; }
        av_hwdevice_find_type_by_name_delegate av_hwdevice_find_type_by_name_ptr { get; }
        av_hwdevice_get_hwframe_constraints_delegate av_hwdevice_get_hwframe_constraints_ptr { get; }
        av_hwdevice_get_type_name_delegate av_hwdevice_get_type_name_ptr { get; }
        av_hwdevice_hwconfig_alloc_delegate av_hwdevice_hwconfig_alloc_ptr { get; }
        av_hwdevice_iterate_types_delegate av_hwdevice_iterate_types_ptr { get; }
        av_hwframe_constraints_free_delegate av_hwframe_constraints_free_ptr { get; }
        av_hwframe_ctx_alloc_delegate av_hwframe_ctx_alloc_ptr { get; }
        av_hwframe_ctx_create_derived_delegate av_hwframe_ctx_create_derived_ptr { get; }
        av_hwframe_ctx_init_delegate av_hwframe_ctx_init_ptr { get; }
        av_hwframe_get_buffer_delegate av_hwframe_get_buffer_ptr { get; }
        av_hwframe_map_delegate av_hwframe_map_ptr { get; }
        av_hwframe_transfer_data_delegate av_hwframe_transfer_data_ptr { get; }
        av_hwframe_transfer_get_formats_delegate av_hwframe_transfer_get_formats_ptr { get; }
        av_image_alloc_delegate av_image_alloc_ptr { get; }
        av_image_check_sar_delegate av_image_check_sar_ptr { get; }
        av_image_check_size_delegate av_image_check_size_ptr { get; }
        av_image_check_size2_delegate av_image_check_size2_ptr { get; }
        av_image_copy_delegate av_image_copy_ptr { get; }
        av_image_copy_plane_delegate av_image_copy_plane_ptr { get; }
        av_image_copy_plane_uc_from_delegate av_image_copy_plane_uc_from_ptr { get; }
        av_image_copy_to_buffer_delegate av_image_copy_to_buffer_ptr { get; }
        av_image_copy_uc_from_delegate av_image_copy_uc_from_ptr { get; }
        av_image_fill_arrays_delegate av_image_fill_arrays_ptr { get; }
        av_image_fill_black_delegate av_image_fill_black_ptr { get; }
        av_image_fill_linesizes_delegate av_image_fill_linesizes_ptr { get; }
        av_image_fill_max_pixsteps_delegate av_image_fill_max_pixsteps_ptr { get; }
        av_image_fill_plane_sizes_delegate av_image_fill_plane_sizes_ptr { get; }
        av_image_fill_pointers_delegate av_image_fill_pointers_ptr { get; }
        av_image_get_buffer_size_delegate av_image_get_buffer_size_ptr { get; }
        av_image_get_linesize_delegate av_image_get_linesize_ptr { get; }
        av_int_list_length_for_size_delegate av_int_list_length_for_size_ptr { get; }
        av_log_delegate av_log_ptr { get; }
        av_log_default_callback_delegate av_log_default_callback_ptr { get; }
        av_log_format_line_delegate av_log_format_line_ptr { get; }
        av_log_format_line2_delegate av_log_format_line2_ptr { get; }
        av_log_get_flags_delegate av_log_get_flags_ptr { get; }
        av_log_get_level_delegate av_log_get_level_ptr { get; }
        av_log_once_delegate av_log_once_ptr { get; }
        av_log_set_callback_delegate av_log_set_callback_ptr { get; }
        av_log_set_flags_delegate av_log_set_flags_ptr { get; }
        av_log_set_level_delegate av_log_set_level_ptr { get; }
        av_log2_delegate av_log2_ptr { get; }
        av_log2_16bit_delegate av_log2_16bit_ptr { get; }
        av_malloc_delegate av_malloc_ptr { get; }
        av_malloc_array_delegate av_malloc_array_ptr { get; }
        av_mallocz_delegate av_mallocz_ptr { get; }
        av_mallocz_array_delegate av_mallocz_array_ptr { get; }
        av_mastering_display_metadata_alloc_delegate av_mastering_display_metadata_alloc_ptr { get; }
        av_mastering_display_metadata_create_side_data_delegate av_mastering_display_metadata_create_side_data_ptr { get; }
        av_max_alloc_delegate av_max_alloc_ptr { get; }
        av_memcpy_backptr_delegate av_memcpy_backptr_ptr { get; }
        av_memdup_delegate av_memdup_ptr { get; }
        av_mul_q_delegate av_mul_q_ptr { get; }
        av_nearer_q_delegate av_nearer_q_ptr { get; }
        av_opt_child_class_iterate_delegate av_opt_child_class_iterate_ptr { get; }
        av_opt_child_next_delegate av_opt_child_next_ptr { get; }
        av_opt_copy_delegate av_opt_copy_ptr { get; }
        av_opt_eval_double_delegate av_opt_eval_double_ptr { get; }
        av_opt_eval_flags_delegate av_opt_eval_flags_ptr { get; }
        av_opt_eval_float_delegate av_opt_eval_float_ptr { get; }
        av_opt_eval_int_delegate av_opt_eval_int_ptr { get; }
        av_opt_eval_int64_delegate av_opt_eval_int64_ptr { get; }
        av_opt_eval_q_delegate av_opt_eval_q_ptr { get; }
        av_opt_find_delegate av_opt_find_ptr { get; }
        av_opt_find2_delegate av_opt_find2_ptr { get; }
        av_opt_flag_is_set_delegate av_opt_flag_is_set_ptr { get; }
        av_opt_free_delegate av_opt_free_ptr { get; }
        av_opt_freep_ranges_delegate av_opt_freep_ranges_ptr { get; }
        av_opt_get_delegate av_opt_get_ptr { get; }
        av_opt_get_channel_layout_delegate av_opt_get_channel_layout_ptr { get; }
        av_opt_get_dict_val_delegate av_opt_get_dict_val_ptr { get; }
        av_opt_get_double_delegate av_opt_get_double_ptr { get; }
        av_opt_get_image_size_delegate av_opt_get_image_size_ptr { get; }
        av_opt_get_int_delegate av_opt_get_int_ptr { get; }
        av_opt_get_key_value_delegate av_opt_get_key_value_ptr { get; }
        av_opt_get_pixel_fmt_delegate av_opt_get_pixel_fmt_ptr { get; }
        av_opt_get_q_delegate av_opt_get_q_ptr { get; }
        av_opt_get_sample_fmt_delegate av_opt_get_sample_fmt_ptr { get; }
        av_opt_get_video_rate_delegate av_opt_get_video_rate_ptr { get; }
        av_opt_is_set_to_default_delegate av_opt_is_set_to_default_ptr { get; }
        av_opt_is_set_to_default_by_name_delegate av_opt_is_set_to_default_by_name_ptr { get; }
        av_opt_next_delegate av_opt_next_ptr { get; }
        av_opt_ptr_delegate av_opt_ptr_ptr { get; }
        av_opt_query_ranges_delegate av_opt_query_ranges_ptr { get; }
        av_opt_query_ranges_default_delegate av_opt_query_ranges_default_ptr { get; }
        av_opt_serialize_delegate av_opt_serialize_ptr { get; }
        av_opt_set_delegate av_opt_set_ptr { get; }
        av_opt_set_bin_delegate av_opt_set_bin_ptr { get; }
        av_opt_set_channel_layout_delegate av_opt_set_channel_layout_ptr { get; }
        av_opt_set_defaults_delegate av_opt_set_defaults_ptr { get; }
        av_opt_set_defaults2_delegate av_opt_set_defaults2_ptr { get; }
        av_opt_set_dict_delegate av_opt_set_dict_ptr { get; }
        av_opt_set_dict_val_delegate av_opt_set_dict_val_ptr { get; }
        av_opt_set_dict2_delegate av_opt_set_dict2_ptr { get; }
        av_opt_set_double_delegate av_opt_set_double_ptr { get; }
        av_opt_set_from_string_delegate av_opt_set_from_string_ptr { get; }
        av_opt_set_image_size_delegate av_opt_set_image_size_ptr { get; }
        av_opt_set_int_delegate av_opt_set_int_ptr { get; }
        av_opt_set_pixel_fmt_delegate av_opt_set_pixel_fmt_ptr { get; }
        av_opt_set_q_delegate av_opt_set_q_ptr { get; }
        av_opt_set_sample_fmt_delegate av_opt_set_sample_fmt_ptr { get; }
        av_opt_set_video_rate_delegate av_opt_set_video_rate_ptr { get; }
        av_opt_show2_delegate av_opt_show2_ptr { get; }
        av_parse_cpu_caps_delegate av_parse_cpu_caps_ptr { get; }
        av_pix_fmt_count_planes_delegate av_pix_fmt_count_planes_ptr { get; }
        av_pix_fmt_desc_get_delegate av_pix_fmt_desc_get_ptr { get; }
        av_pix_fmt_desc_get_id_delegate av_pix_fmt_desc_get_id_ptr { get; }
        av_pix_fmt_desc_next_delegate av_pix_fmt_desc_next_ptr { get; }
        av_pix_fmt_get_chroma_sub_sample_delegate av_pix_fmt_get_chroma_sub_sample_ptr { get; }
        av_pix_fmt_swap_endianness_delegate av_pix_fmt_swap_endianness_ptr { get; }
        av_q2intfloat_delegate av_q2intfloat_ptr { get; }
        av_read_image_line_delegate av_read_image_line_ptr { get; }
        av_read_image_line2_delegate av_read_image_line2_ptr { get; }
        av_realloc_delegate av_realloc_ptr { get; }
        av_realloc_array_delegate av_realloc_array_ptr { get; }
        av_realloc_f_delegate av_realloc_f_ptr { get; }
        av_reallocp_delegate av_reallocp_ptr { get; }
        av_reallocp_array_delegate av_reallocp_array_ptr { get; }
        av_reduce_delegate av_reduce_ptr { get; }
        av_rescale_delegate av_rescale_ptr { get; }
        av_rescale_delta_delegate av_rescale_delta_ptr { get; }
        av_rescale_q_delegate av_rescale_q_ptr { get; }
        av_rescale_q_rnd_delegate av_rescale_q_rnd_ptr { get; }
        av_rescale_rnd_delegate av_rescale_rnd_ptr { get; }
        av_sample_fmt_is_planar_delegate av_sample_fmt_is_planar_ptr { get; }
        av_samples_alloc_delegate av_samples_alloc_ptr { get; }
        av_samples_alloc_array_and_samples_delegate av_samples_alloc_array_and_samples_ptr { get; }
        av_samples_copy_delegate av_samples_copy_ptr { get; }
        av_samples_fill_arrays_delegate av_samples_fill_arrays_ptr { get; }
        av_samples_get_buffer_size_delegate av_samples_get_buffer_size_ptr { get; }
        av_samples_set_silence_delegate av_samples_set_silence_ptr { get; }
        av_set_options_string_delegate av_set_options_string_ptr { get; }
        av_size_mult_delegate av_size_mult_ptr { get; }
        av_strdup_delegate av_strdup_ptr { get; }
        av_strerror_delegate av_strerror_ptr { get; }
        av_strndup_delegate av_strndup_ptr { get; }
        av_sub_q_delegate av_sub_q_ptr { get; }
        av_tempfile_delegate av_tempfile_ptr { get; }
        av_timecode_adjust_ntsc_framenum2_delegate av_timecode_adjust_ntsc_framenum2_ptr { get; }
        av_timecode_check_frame_rate_delegate av_timecode_check_frame_rate_ptr { get; }
        av_timecode_get_smpte_delegate av_timecode_get_smpte_ptr { get; }
        av_timecode_get_smpte_from_framenum_delegate av_timecode_get_smpte_from_framenum_ptr { get; }
        av_timecode_init_delegate av_timecode_init_ptr { get; }
        av_timecode_init_from_components_delegate av_timecode_init_from_components_ptr { get; }
        av_timecode_init_from_string_delegate av_timecode_init_from_string_ptr { get; }
        av_timecode_make_mpeg_tc_string_delegate av_timecode_make_mpeg_tc_string_ptr { get; }
        av_timecode_make_smpte_tc_string_delegate av_timecode_make_smpte_tc_string_ptr { get; }
        av_timecode_make_smpte_tc_string2_delegate av_timecode_make_smpte_tc_string2_ptr { get; }
        av_timecode_make_string_delegate av_timecode_make_string_ptr { get; }
        av_tree_destroy_delegate av_tree_destroy_ptr { get; }
        av_tree_enumerate_delegate av_tree_enumerate_ptr { get; }
        av_tree_find_delegate av_tree_find_ptr { get; }
        av_tree_insert_delegate av_tree_insert_ptr { get; }
        av_tree_node_alloc_delegate av_tree_node_alloc_ptr { get; }
        av_usleep_delegate av_usleep_ptr { get; }
        av_version_info_delegate av_version_info_ptr { get; }
        av_vlog_delegate av_vlog_ptr { get; }
        av_write_image_line_delegate av_write_image_line_ptr { get; }
        av_write_image_line2_delegate av_write_image_line2_ptr { get; }
        avutil_configuration_delegate avutil_configuration_ptr { get; }
        avutil_license_delegate avutil_license_ptr { get; }
        avutil_version_delegate avutil_version_ptr { get; }
        postproc_configuration_delegate postproc_configuration_ptr { get; }
        postproc_license_delegate postproc_license_ptr { get; }
        postproc_version_delegate postproc_version_ptr { get; }
        pp_free_context_delegate pp_free_context_ptr { get; }
        pp_free_mode_delegate pp_free_mode_ptr { get; }
        pp_get_context_delegate pp_get_context_ptr { get; }
        pp_get_mode_by_name_and_quality_delegate pp_get_mode_by_name_and_quality_ptr { get; }
        pp_postprocess_delegate pp_postprocess_ptr { get; }
        swr_alloc_delegate swr_alloc_ptr { get; }
        swr_alloc_set_opts_delegate swr_alloc_set_opts_ptr { get; }
        swr_build_matrix_delegate swr_build_matrix_ptr { get; }
        swr_close_delegate swr_close_ptr { get; }
        swr_config_frame_delegate swr_config_frame_ptr { get; }
        swr_convert_delegate swr_convert_ptr { get; }
        swr_convert_frame_delegate swr_convert_frame_ptr { get; }
        swr_drop_output_delegate swr_drop_output_ptr { get; }
        swr_free_delegate swr_free_ptr { get; }
        swr_get_class_delegate swr_get_class_ptr { get; }
        swr_get_delay_delegate swr_get_delay_ptr { get; }
        swr_get_out_samples_delegate swr_get_out_samples_ptr { get; }
        swr_init_delegate swr_init_ptr { get; }
        swr_inject_silence_delegate swr_inject_silence_ptr { get; }
        swr_is_initialized_delegate swr_is_initialized_ptr { get; }
        swr_next_pts_delegate swr_next_pts_ptr { get; }
        swr_set_channel_mapping_delegate swr_set_channel_mapping_ptr { get; }
        swr_set_compensation_delegate swr_set_compensation_ptr { get; }
        swr_set_matrix_delegate swr_set_matrix_ptr { get; }
        swresample_configuration_delegate swresample_configuration_ptr { get; }
        swresample_license_delegate swresample_license_ptr { get; }
        swresample_version_delegate swresample_version_ptr { get; }
        sws_alloc_context_delegate sws_alloc_context_ptr { get; }
        sws_allocVec_delegate sws_allocVec_ptr { get; }
        sws_convertPalette8ToPacked24_delegate sws_convertPalette8ToPacked24_ptr { get; }
        sws_convertPalette8ToPacked32_delegate sws_convertPalette8ToPacked32_ptr { get; }
        sws_frame_end_delegate sws_frame_end_ptr { get; }
        sws_frame_start_delegate sws_frame_start_ptr { get; }
        sws_freeContext_delegate sws_freeContext_ptr { get; }
        sws_freeFilter_delegate sws_freeFilter_ptr { get; }
        sws_freeVec_delegate sws_freeVec_ptr { get; }
        sws_get_class_delegate sws_get_class_ptr { get; }
        sws_getCachedContext_delegate sws_getCachedContext_ptr { get; }
        sws_getCoefficients_delegate sws_getCoefficients_ptr { get; }
        sws_getColorspaceDetails_delegate sws_getColorspaceDetails_ptr { get; }
        sws_getContext_delegate sws_getContext_ptr { get; }
        sws_getDefaultFilter_delegate sws_getDefaultFilter_ptr { get; }
        sws_getGaussianVec_delegate sws_getGaussianVec_ptr { get; }
        sws_init_context_delegate sws_init_context_ptr { get; }
        sws_isSupportedEndiannessConversion_delegate sws_isSupportedEndiannessConversion_ptr { get; }
        sws_isSupportedInput_delegate sws_isSupportedInput_ptr { get; }
        sws_isSupportedOutput_delegate sws_isSupportedOutput_ptr { get; }
        sws_normalizeVec_delegate sws_normalizeVec_ptr { get; }
        sws_receive_slice_delegate sws_receive_slice_ptr { get; }
        sws_receive_slice_alignment_delegate sws_receive_slice_alignment_ptr { get; }
        sws_scale_delegate sws_scale_ptr { get; }
        sws_scale_frame_delegate sws_scale_frame_ptr { get; }
        sws_scaleVec_delegate sws_scaleVec_ptr { get; }
        sws_send_slice_delegate sws_send_slice_ptr { get; }
        sws_setColorspaceDetails_delegate sws_setColorspaceDetails_ptr { get; }
        swscale_configuration_delegate swscale_configuration_ptr { get; }
        swscale_license_delegate swscale_license_ptr { get; }
        swscale_version_delegate swscale_version_ptr { get; }

        unsafe void avcodec_align_dimensions(AVCodecContext* s, int* width, int* height);
        unsafe void avcodec_align_dimensions2(AVCodecContext* s, int* width, int* height, ref int_array8 linesize_align);
        unsafe AVCodecContext* avcodec_alloc_context3(AVCodec* codec);
        AVChromaLocation avcodec_chroma_pos_to_enum(int xpos, int ypos);
        unsafe int avcodec_close(AVCodecContext* avctx);
        string avcodec_configuration();
        unsafe int avcodec_decode_subtitle2(AVCodecContext* avctx, AVSubtitle* sub, int* got_sub_ptr, AVPacket* avpkt);
        unsafe int avcodec_default_execute(AVCodecContext* c, avcodec_default_execute_func_func func, void* arg, int* ret, int count, int size);
        unsafe int avcodec_default_execute2(AVCodecContext* c, avcodec_default_execute2_func_func func, void* arg, int* ret, int count);
        unsafe int avcodec_default_get_buffer2(AVCodecContext* s, AVFrame* frame, int flags);
        unsafe int avcodec_default_get_encode_buffer(AVCodecContext* s, AVPacket* pkt, int flags);
        unsafe AVPixelFormat avcodec_default_get_format(AVCodecContext* s, AVPixelFormat* fmt);
        unsafe AVCodecDescriptor* avcodec_descriptor_get(AVCodecID id);
        unsafe AVCodecDescriptor* avcodec_descriptor_get_by_name([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        unsafe AVCodecDescriptor* avcodec_descriptor_next(AVCodecDescriptor* prev);
        unsafe int avcodec_encode_subtitle(AVCodecContext* avctx, byte* buf, int buf_size, AVSubtitle* sub);
        unsafe int avcodec_enum_to_chroma_pos(int* xpos, int* ypos, AVChromaLocation pos);
        unsafe int avcodec_fill_audio_frame(AVFrame* frame, int nb_channels, AVSampleFormat sample_fmt, byte* buf, int buf_size, int align);
        unsafe AVPixelFormat avcodec_find_best_pix_fmt_of_list(AVPixelFormat* pix_fmt_list, AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);
        unsafe AVCodec* avcodec_find_decoder(AVCodecID id);
        unsafe AVCodec* avcodec_find_decoder_by_name([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        unsafe AVCodec* avcodec_find_encoder(AVCodecID id);
        unsafe AVCodec* avcodec_find_encoder_by_name([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        unsafe void avcodec_flush_buffers(AVCodecContext* avctx);
        unsafe void avcodec_free_context(AVCodecContext** avctx);
        unsafe AVClass* avcodec_get_class();
        unsafe AVClass* avcodec_get_frame_class();
        unsafe AVCodecHWConfig* avcodec_get_hw_config(AVCodec* codec, int index);
        unsafe int avcodec_get_hw_frames_parameters(AVCodecContext* avctx, AVBufferRef* device_ref, AVPixelFormat hw_pix_fmt, AVBufferRef** out_frames_ref);
        string avcodec_get_name(AVCodecID id);
        unsafe AVClass* avcodec_get_subtitle_rect_class();
        AVMediaType avcodec_get_type(AVCodecID codec_id);
        unsafe int avcodec_is_open(AVCodecContext* s);
        string avcodec_license();
        unsafe int avcodec_open2(AVCodecContext* avctx, AVCodec* codec, AVDictionary** options);
        unsafe AVCodecParameters* avcodec_parameters_alloc();
        unsafe int avcodec_parameters_copy(AVCodecParameters* dst, AVCodecParameters* src);
        unsafe void avcodec_parameters_free(AVCodecParameters** par);
        unsafe int avcodec_parameters_from_context(AVCodecParameters* par, AVCodecContext* codec);
        unsafe int avcodec_parameters_to_context(AVCodecContext* codec, AVCodecParameters* par);
        uint avcodec_pix_fmt_to_codec_tag(AVPixelFormat pix_fmt);
        string avcodec_profile_name(AVCodecID codec_id, int profile);
        unsafe int avcodec_receive_frame(AVCodecContext* avctx, AVFrame* frame);
        unsafe int avcodec_receive_packet(AVCodecContext* avctx, AVPacket* avpkt);
        unsafe int avcodec_send_frame(AVCodecContext* avctx, AVFrame* frame);
        unsafe int avcodec_send_packet(AVCodecContext* avctx, AVPacket* avpkt);
        unsafe void avcodec_string(byte* buf, int buf_size, AVCodecContext* enc, int encode);
        uint avcodec_version();
        unsafe int avdevice_app_to_dev_control_message(AVFormatContext* s, AVAppToDevMessageType type, void* data, ulong data_size);
        unsafe int avdevice_capabilities_create(AVDeviceCapabilitiesQuery** caps, AVFormatContext* s, AVDictionary** device_options);
        unsafe void avdevice_capabilities_free(AVDeviceCapabilitiesQuery** caps, AVFormatContext* s);
        string avdevice_configuration();
        unsafe int avdevice_dev_to_app_control_message(AVFormatContext* s, AVDevToAppMessageType type, void* data, ulong data_size);
        unsafe void avdevice_free_list_devices(AVDeviceInfoList** device_list);
        string avdevice_license();
        unsafe int avdevice_list_devices(AVFormatContext* s, AVDeviceInfoList** device_list);
        unsafe int avdevice_list_input_sources(AVInputFormat* device, [MarshalAs(UnmanagedType.LPUTF8Str)] string device_name, AVDictionary* device_options, AVDeviceInfoList** device_list);
        unsafe int avdevice_list_output_sinks(AVOutputFormat* device, [MarshalAs(UnmanagedType.LPUTF8Str)] string device_name, AVDictionary* device_options, AVDeviceInfoList** device_list);
        void avdevice_register_all();
        uint avdevice_version();
        string avfilter_configuration();
        unsafe int avfilter_config_links(AVFilterContext* filter);
        unsafe uint avfilter_filter_pad_count(AVFilter* filter, int is_output);
        unsafe void avfilter_free(AVFilterContext* filter);
        unsafe AVFilter* avfilter_get_by_name([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        unsafe AVClass* avfilter_get_class();
        unsafe AVFilterGraph* avfilter_graph_alloc();
        unsafe AVFilterContext* avfilter_graph_alloc_filter(AVFilterGraph* graph, AVFilter* filter, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        unsafe int avfilter_graph_config(AVFilterGraph* graphctx, void* log_ctx);
        unsafe int avfilter_graph_create_filter(AVFilterContext** filt_ctx, AVFilter* filt, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string args, void* opaque, AVFilterGraph* graph_ctx);
        unsafe byte* avfilter_graph_dump(AVFilterGraph* graph, [MarshalAs(UnmanagedType.LPUTF8Str)] string options);
        unsafe void avfilter_graph_free(AVFilterGraph** graph);
        unsafe AVFilterContext* avfilter_graph_get_filter(AVFilterGraph* graph, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        unsafe int avfilter_graph_parse(AVFilterGraph* graph, [MarshalAs(UnmanagedType.LPUTF8Str)] string filters, AVFilterInOut* inputs, AVFilterInOut* outputs, void* log_ctx);
        unsafe int avfilter_graph_parse2(AVFilterGraph* graph, [MarshalAs(UnmanagedType.LPUTF8Str)] string filters, AVFilterInOut** inputs, AVFilterInOut** outputs);
        unsafe int avfilter_graph_parse_ptr(AVFilterGraph* graph, [MarshalAs(UnmanagedType.LPUTF8Str)] string filters, AVFilterInOut** inputs, AVFilterInOut** outputs, void* log_ctx);
        unsafe int avfilter_graph_queue_command(AVFilterGraph* graph, [MarshalAs(UnmanagedType.LPUTF8Str)] string target, [MarshalAs(UnmanagedType.LPUTF8Str)] string cmd, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg, int flags, double ts);
        unsafe int avfilter_graph_request_oldest(AVFilterGraph* graph);
        unsafe int avfilter_graph_send_command(AVFilterGraph* graph, [MarshalAs(UnmanagedType.LPUTF8Str)] string target, [MarshalAs(UnmanagedType.LPUTF8Str)] string cmd, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg, byte* res, int res_len, int flags);
        unsafe void avfilter_graph_set_auto_convert(AVFilterGraph* graph, uint flags);
        unsafe int avfilter_init_dict(AVFilterContext* ctx, AVDictionary** options);
        unsafe int avfilter_init_str(AVFilterContext* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string args);
        unsafe AVFilterInOut* avfilter_inout_alloc();
        unsafe void avfilter_inout_free(AVFilterInOut** inout);
        unsafe int avfilter_insert_filter(AVFilterLink* link, AVFilterContext* filt, uint filt_srcpad_idx, uint filt_dstpad_idx);
        string avfilter_license();
        unsafe int avfilter_link(AVFilterContext* src, uint srcpad, AVFilterContext* dst, uint dstpad);
        unsafe void avfilter_link_free(AVFilterLink** link);
        unsafe int avfilter_pad_count(AVFilterPad* pads);
        unsafe string avfilter_pad_get_name(AVFilterPad* pads, int pad_idx);
        unsafe AVMediaType avfilter_pad_get_type(AVFilterPad* pads, int pad_idx);
        unsafe int avfilter_process_command(AVFilterContext* filter, [MarshalAs(UnmanagedType.LPUTF8Str)] string cmd, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg, byte* res, int res_len, int flags);
        uint avfilter_version();
        unsafe AVFormatContext* avformat_alloc_context();
        unsafe int avformat_alloc_output_context2(AVFormatContext** ctx, AVOutputFormat* oformat, [MarshalAs(UnmanagedType.LPUTF8Str)] string format_name, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);
        unsafe void avformat_close_input(AVFormatContext** s);
        string avformat_configuration();
        unsafe int avformat_find_stream_info(AVFormatContext* ic, AVDictionary** options);
        unsafe int avformat_flush(AVFormatContext* s);
        unsafe void avformat_free_context(AVFormatContext* s);
        unsafe AVClass* avformat_get_class();
        unsafe AVCodecTag* avformat_get_mov_audio_tags();
        unsafe AVCodecTag* avformat_get_mov_video_tags();
        unsafe AVCodecTag* avformat_get_riff_audio_tags();
        unsafe AVCodecTag* avformat_get_riff_video_tags();
        unsafe int avformat_index_get_entries_count(AVStream* st);
        unsafe AVIndexEntry* avformat_index_get_entry(AVStream* st, int idx);
        unsafe AVIndexEntry* avformat_index_get_entry_from_timestamp(AVStream* st, long wanted_timestamp, int flags);
        unsafe int avformat_init_output(AVFormatContext* s, AVDictionary** options);
        string avformat_license();
        unsafe int avformat_match_stream_specifier(AVFormatContext* s, AVStream* st, [MarshalAs(UnmanagedType.LPUTF8Str)] string spec);
        int avformat_network_deinit();
        int avformat_network_init();
        unsafe AVStream* avformat_new_stream(AVFormatContext* s, AVCodec* c);
        unsafe int avformat_open_input(AVFormatContext** ps, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, AVInputFormat* fmt, AVDictionary** options);
        unsafe int avformat_query_codec(AVOutputFormat* ofmt, AVCodecID codec_id, int std_compliance);
        unsafe int avformat_queue_attached_pictures(AVFormatContext* s);
        unsafe int avformat_seek_file(AVFormatContext* s, int stream_index, long min_ts, long ts, long max_ts, int flags);
        unsafe int avformat_transfer_internal_stream_timing_info(AVOutputFormat* ofmt, AVStream* ost, AVStream* ist, AVTimebaseSource copy_tb);
        uint avformat_version();
        unsafe int avformat_write_header(AVFormatContext* s, AVDictionary** options);
        unsafe int avio_accept(AVIOContext* s, AVIOContext** c);
        unsafe AVIOContext* avio_alloc_context(byte* buffer, int buffer_size, int write_flag, void* opaque, avio_alloc_context_read_packet_func read_packet, avio_alloc_context_write_packet_func write_packet, avio_alloc_context_seek_func seek);
        int avio_check([MarshalAs(UnmanagedType.LPUTF8Str)] string url, int flags);
        unsafe int avio_close(AVIOContext* s);
        unsafe int avio_closep(AVIOContext** s);
        unsafe int avio_close_dir(AVIODirContext** s);
        unsafe int avio_close_dyn_buf(AVIOContext* s, byte** pbuffer);
        unsafe void avio_context_free(AVIOContext** s);
        unsafe string avio_enum_protocols(void** opaque, int output);
        unsafe int avio_feof(AVIOContext* s);
        string avio_find_protocol_name([MarshalAs(UnmanagedType.LPUTF8Str)] string url);
        unsafe void avio_flush(AVIOContext* s);
        unsafe void avio_free_directory_entry(AVIODirEntry** entry);
        unsafe int avio_get_dyn_buf(AVIOContext* s, byte** pbuffer);
        unsafe int avio_get_str(AVIOContext* pb, int maxlen, byte* buf, int buflen);
        unsafe int avio_get_str16be(AVIOContext* pb, int maxlen, byte* buf, int buflen);
        unsafe int avio_get_str16le(AVIOContext* pb, int maxlen, byte* buf, int buflen);
        unsafe int avio_handshake(AVIOContext* c);
        unsafe int avio_open(AVIOContext** s, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, int flags);
        unsafe int avio_open2(AVIOContext** s, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, int flags, AVIOInterruptCB* int_cb, AVDictionary** options);
        unsafe int avio_open_dir(AVIODirContext** s, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, AVDictionary** options);
        unsafe int avio_open_dyn_buf(AVIOContext** s);
        unsafe int avio_pause(AVIOContext* h, int pause);
        unsafe int avio_printf(AVIOContext* s, [MarshalAs(UnmanagedType.LPUTF8Str)] string fmt);
        unsafe void avio_print_string_array(AVIOContext* s, byte*[] strings);
        unsafe AVClass* avio_protocol_get_class([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        unsafe int avio_put_str(AVIOContext* s, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);
        unsafe int avio_put_str16be(AVIOContext* s, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);
        unsafe int avio_put_str16le(AVIOContext* s, [MarshalAs(UnmanagedType.LPUTF8Str)] string str);
        unsafe int avio_r8(AVIOContext* s);
        unsafe uint avio_rb16(AVIOContext* s);
        unsafe uint avio_rb24(AVIOContext* s);
        unsafe uint avio_rb32(AVIOContext* s);
        unsafe ulong avio_rb64(AVIOContext* s);
        unsafe int avio_read(AVIOContext* s, byte* buf, int size);
        unsafe int avio_read_dir(AVIODirContext* s, AVIODirEntry** next);
        unsafe int avio_read_partial(AVIOContext* s, byte* buf, int size);
        unsafe int avio_read_to_bprint(AVIOContext* h, AVBPrint* pb, ulong max_size);
        unsafe uint avio_rl16(AVIOContext* s);
        unsafe uint avio_rl24(AVIOContext* s);
        unsafe uint avio_rl32(AVIOContext* s);
        unsafe ulong avio_rl64(AVIOContext* s);
        unsafe long avio_seek(AVIOContext* s, long offset, int whence);
        unsafe long avio_seek_time(AVIOContext* h, int stream_index, long timestamp, int flags);
        unsafe long avio_size(AVIOContext* s);
        unsafe long avio_skip(AVIOContext* s, long offset);
        unsafe void avio_w8(AVIOContext* s, int b);
        unsafe void avio_wb16(AVIOContext* s, uint val);
        unsafe void avio_wb24(AVIOContext* s, uint val);
        unsafe void avio_wb32(AVIOContext* s, uint val);
        unsafe void avio_wb64(AVIOContext* s, ulong val);
        unsafe void avio_wl16(AVIOContext* s, uint val);
        unsafe void avio_wl24(AVIOContext* s, uint val);
        unsafe void avio_wl32(AVIOContext* s, uint val);
        unsafe void avio_wl64(AVIOContext* s, ulong val);
        unsafe void avio_write(AVIOContext* s, byte* buf, int size);
        unsafe void avio_write_marker(AVIOContext* s, long time, AVIODataMarkerType type);
        unsafe void avsubtitle_free(AVSubtitle* sub);
        string avutil_configuration();
        string avutil_license();
        uint avutil_version();
        unsafe AVABufferSinkParams* av_abuffersink_params_alloc();
        unsafe int av_add_index_entry(AVStream* st, long pos, long timestamp, int size, int distance, int flags);
        AVRational av_add_q(AVRational b, AVRational c);
        long av_add_stable(AVRational ts_tb, long ts, AVRational inc_tb, long inc);
        unsafe int av_append_packet(AVIOContext* s, AVPacket* pkt, int size);
        unsafe AVAudioFifo* av_audio_fifo_alloc(AVSampleFormat sample_fmt, int channels, int nb_samples);
        unsafe int av_audio_fifo_drain(AVAudioFifo* af, int nb_samples);
        unsafe void av_audio_fifo_free(AVAudioFifo* af);
        unsafe int av_audio_fifo_peek(AVAudioFifo* af, void** data, int nb_samples);
        unsafe int av_audio_fifo_peek_at(AVAudioFifo* af, void** data, int nb_samples, int offset);
        unsafe int av_audio_fifo_read(AVAudioFifo* af, void** data, int nb_samples);
        unsafe int av_audio_fifo_realloc(AVAudioFifo* af, int nb_samples);
        unsafe void av_audio_fifo_reset(AVAudioFifo* af);
        unsafe int av_audio_fifo_size(AVAudioFifo* af);
        unsafe int av_audio_fifo_space(AVAudioFifo* af);
        unsafe int av_audio_fifo_write(AVAudioFifo* af, void** data, int nb_samples);
        unsafe void av_bprint_channel_layout(AVBPrint* bp, int nb_channels, ulong channel_layout);
        unsafe int av_buffersink_get_channels(AVFilterContext* ctx);
        unsafe ulong av_buffersink_get_channel_layout(AVFilterContext* ctx);
        unsafe int av_buffersink_get_format(AVFilterContext* ctx);
        unsafe int av_buffersink_get_frame(AVFilterContext* ctx, AVFrame* frame);
        unsafe int av_buffersink_get_frame_flags(AVFilterContext* ctx, AVFrame* frame, int flags);
        unsafe AVRational av_buffersink_get_frame_rate(AVFilterContext* ctx);
        unsafe int av_buffersink_get_h(AVFilterContext* ctx);
        unsafe AVBufferRef* av_buffersink_get_hw_frames_ctx(AVFilterContext* ctx);
        unsafe int av_buffersink_get_samples(AVFilterContext* ctx, AVFrame* frame, int nb_samples);
        unsafe AVRational av_buffersink_get_sample_aspect_ratio(AVFilterContext* ctx);
        unsafe int av_buffersink_get_sample_rate(AVFilterContext* ctx);
        unsafe AVRational av_buffersink_get_time_base(AVFilterContext* ctx);
        unsafe AVMediaType av_buffersink_get_type(AVFilterContext* ctx);
        unsafe int av_buffersink_get_w(AVFilterContext* ctx);
        unsafe AVBufferSinkParams* av_buffersink_params_alloc();
        unsafe void av_buffersink_set_frame_size(AVFilterContext* ctx, uint frame_size);
        unsafe int av_buffersrc_add_frame(AVFilterContext* ctx, AVFrame* frame);
        unsafe int av_buffersrc_add_frame_flags(AVFilterContext* buffer_src, AVFrame* frame, int flags);
        unsafe int av_buffersrc_close(AVFilterContext* ctx, long pts, uint flags);
        unsafe uint av_buffersrc_get_nb_failed_requests(AVFilterContext* buffer_src);
        unsafe AVBufferSrcParameters* av_buffersrc_parameters_alloc();
        unsafe int av_buffersrc_parameters_set(AVFilterContext* ctx, AVBufferSrcParameters* param);
        unsafe int av_buffersrc_write_frame(AVFilterContext* ctx, AVFrame* frame);
        unsafe AVBufferRef* av_buffer_alloc(ulong size);
        unsafe AVBufferRef* av_buffer_allocz(ulong size);
        unsafe AVBufferRef* av_buffer_create(byte* data, ulong size, av_buffer_create_free_func free, void* opaque, int flags);
        unsafe void av_buffer_default_free(void* opaque, byte* data);
        unsafe void* av_buffer_get_opaque(AVBufferRef* buf);
        unsafe int av_buffer_get_ref_count(AVBufferRef* buf);
        unsafe int av_buffer_is_writable(AVBufferRef* buf);
        unsafe int av_buffer_make_writable(AVBufferRef** buf);
        unsafe void* av_buffer_pool_buffer_get_opaque(AVBufferRef* @ref);
        unsafe AVBufferRef* av_buffer_pool_get(AVBufferPool* pool);
        unsafe AVBufferPool* av_buffer_pool_init(ulong size, av_buffer_pool_init_alloc_func alloc);
        unsafe AVBufferPool* av_buffer_pool_init2(ulong size, void* opaque, av_buffer_pool_init2_alloc_func alloc, av_buffer_pool_init2_pool_free_func pool_free);
        unsafe void av_buffer_pool_uninit(AVBufferPool** pool);
        unsafe int av_buffer_realloc(AVBufferRef** buf, ulong size);
        unsafe AVBufferRef* av_buffer_ref(AVBufferRef* buf);
        unsafe int av_buffer_replace(AVBufferRef** dst, AVBufferRef* src);
        unsafe void av_buffer_unref(AVBufferRef** buf);
        unsafe void* av_calloc(ulong nmemb, ulong size);
        ulong av_channel_layout_extract_channel(ulong channel_layout, int index);
        int av_chroma_location_from_name([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        string av_chroma_location_name(AVChromaLocation location);
        unsafe AVCodecID av_codec_get_id(AVCodecTag** tags, uint tag);
        unsafe uint av_codec_get_tag(AVCodecTag** tags, AVCodecID id);
        unsafe int av_codec_get_tag2(AVCodecTag** tags, AVCodecID id, uint* tag);
        unsafe int av_codec_is_decoder(AVCodec* codec);
        unsafe int av_codec_is_encoder(AVCodec* codec);
        unsafe AVCodec* av_codec_iterate(void** opaque);
        int av_color_primaries_from_name([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        string av_color_primaries_name(AVColorPrimaries primaries);
        int av_color_range_from_name([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        string av_color_range_name(AVColorRange range);
        int av_color_space_from_name([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        string av_color_space_name(AVColorSpace space);
        int av_color_transfer_from_name([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        string av_color_transfer_name(AVColorTransferCharacteristic transfer);
        long av_compare_mod(ulong a, ulong b, ulong mod);
        int av_compare_ts(long ts_a, AVRational tb_a, long ts_b, AVRational tb_b);
        unsafe AVContentLightMetadata* av_content_light_metadata_alloc(ulong* size);
        unsafe AVContentLightMetadata* av_content_light_metadata_create_side_data(AVFrame* frame);
        unsafe AVCPBProperties* av_cpb_properties_alloc(ulong* size);
        int av_cpu_count();
        void av_cpu_force_count(int count);
        ulong av_cpu_max_align();
        AVRational av_d2q(double d, int max);
        unsafe AVD3D11VAContext* av_d3d11va_alloc_context();
        unsafe AVClassCategory av_default_get_category(void* ptr);
        unsafe string av_default_item_name(void* ctx);
        unsafe AVInputFormat* av_demuxer_iterate(void** opaque);
        unsafe int av_dict_copy(AVDictionary** dst, AVDictionary* src, int flags);
        unsafe int av_dict_count(AVDictionary* m);
        unsafe void av_dict_free(AVDictionary** m);
        unsafe AVDictionaryEntry* av_dict_get(AVDictionary* m, [MarshalAs(UnmanagedType.LPUTF8Str)] string key, AVDictionaryEntry* prev, int flags);
        unsafe int av_dict_get_string(AVDictionary* m, byte** buffer, byte key_val_sep, byte pairs_sep);
        unsafe int av_dict_parse_string(AVDictionary** pm, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, [MarshalAs(UnmanagedType.LPUTF8Str)] string key_val_sep, [MarshalAs(UnmanagedType.LPUTF8Str)] string pairs_sep, int flags);
        unsafe int av_dict_set(AVDictionary** pm, [MarshalAs(UnmanagedType.LPUTF8Str)] string key, [MarshalAs(UnmanagedType.LPUTF8Str)] string value, int flags);
        unsafe int av_dict_set_int(AVDictionary** pm, [MarshalAs(UnmanagedType.LPUTF8Str)] string key, long value, int flags);
        int av_disposition_from_string([MarshalAs(UnmanagedType.LPUTF8Str)] string disp);
        string av_disposition_to_string(int disposition);
        AVRational av_div_q(AVRational b, AVRational c);
        unsafe void av_dump_format(AVFormatContext* ic, int index, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, int is_output);
        unsafe AVDynamicHDRPlus* av_dynamic_hdr_plus_alloc(ulong* size);
        unsafe AVDynamicHDRPlus* av_dynamic_hdr_plus_create_side_data(AVFrame* frame);
        unsafe void* av_dynarray2_add(void** tab_ptr, int* nb_ptr, ulong elem_size, byte* elem_data);
        unsafe void av_dynarray_add(void* tab_ptr, int* nb_ptr, void* elem);
        unsafe int av_dynarray_add_nofree(void* tab_ptr, int* nb_ptr, void* elem);
        unsafe void av_fast_malloc(void* ptr, uint* size, ulong min_size);
        unsafe void av_fast_mallocz(void* ptr, uint* size, ulong min_size);
        unsafe void av_fast_padded_malloc(void* ptr, uint* size, ulong min_size);
        unsafe void av_fast_padded_mallocz(void* ptr, uint* size, ulong min_size);
        unsafe void* av_fast_realloc(void* ptr, uint* size, ulong min_size);
        unsafe AVFifoBuffer* av_fifo_alloc(uint size);
        unsafe AVFifoBuffer* av_fifo_alloc_array(ulong nmemb, ulong size);
        unsafe void av_fifo_drain(AVFifoBuffer* f, int size);
        unsafe void av_fifo_free(AVFifoBuffer* f);
        unsafe void av_fifo_freep(AVFifoBuffer** f);
        unsafe int av_fifo_generic_peek(AVFifoBuffer* f, void* dest, int buf_size, av_fifo_generic_peek_func_func func);
        unsafe int av_fifo_generic_peek_at(AVFifoBuffer* f, void* dest, int offset, int buf_size, av_fifo_generic_peek_at_func_func func);
        unsafe int av_fifo_generic_read(AVFifoBuffer* f, void* dest, int buf_size, av_fifo_generic_read_func_func func);
        unsafe int av_fifo_generic_write(AVFifoBuffer* f, void* src, int size, av_fifo_generic_write_func_func func);
        unsafe int av_fifo_grow(AVFifoBuffer* f, uint additional_space);
        unsafe int av_fifo_realloc2(AVFifoBuffer* f, uint size);
        unsafe void av_fifo_reset(AVFifoBuffer* f);
        unsafe int av_fifo_size(AVFifoBuffer* f);
        unsafe int av_fifo_space(AVFifoBuffer* f);
        int av_filename_number_test([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);
        unsafe int av_file_map([MarshalAs(UnmanagedType.LPUTF8Str)] string filename, byte** bufptr, ulong* size, int log_offset, void* log_ctx);
        unsafe void av_file_unmap(byte* bufptr, ulong size);
        unsafe AVFilter* av_filter_iterate(void** opaque);
        unsafe AVPixelFormat av_find_best_pix_fmt_of_2(AVPixelFormat dst_pix_fmt1, AVPixelFormat dst_pix_fmt2, AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);
        unsafe int av_find_best_stream(AVFormatContext* ic, AVMediaType type, int wanted_stream_nb, int related_stream, AVCodec** decoder_ret, int flags);
        unsafe int av_find_default_stream_index(AVFormatContext* s);
        unsafe AVInputFormat* av_find_input_format([MarshalAs(UnmanagedType.LPUTF8Str)] string short_name);
        unsafe int av_find_nearest_q_idx(AVRational q, AVRational* q_list);
        unsafe AVProgram* av_find_program_from_stream(AVFormatContext* ic, AVProgram* last, int s);
        unsafe AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method(AVFormatContext* ctx);
        unsafe _iobuf* av_fopen_utf8([MarshalAs(UnmanagedType.LPUTF8Str)] string path, [MarshalAs(UnmanagedType.LPUTF8Str)] string mode);
        void av_force_cpu_flags(int flags);
        unsafe void av_format_inject_global_side_data(AVFormatContext* s);
        unsafe byte* av_fourcc_make_string(byte* buf, uint fourcc);
        unsafe AVFrame* av_frame_alloc();
        unsafe int av_frame_apply_cropping(AVFrame* frame, int flags);
        unsafe AVFrame* av_frame_clone(AVFrame* src);
        unsafe int av_frame_copy(AVFrame* dst, AVFrame* src);
        unsafe int av_frame_copy_props(AVFrame* dst, AVFrame* src);
        unsafe void av_frame_free(AVFrame** frame);
        unsafe int av_frame_get_buffer(AVFrame* frame, int align);
        unsafe AVBufferRef* av_frame_get_plane_buffer(AVFrame* frame, int plane);
        unsafe AVFrameSideData* av_frame_get_side_data(AVFrame* frame, AVFrameSideDataType type);
        unsafe int av_frame_is_writable(AVFrame* frame);
        unsafe int av_frame_make_writable(AVFrame* frame);
        unsafe void av_frame_move_ref(AVFrame* dst, AVFrame* src);
        unsafe AVFrameSideData* av_frame_new_side_data(AVFrame* frame, AVFrameSideDataType type, ulong size);
        unsafe AVFrameSideData* av_frame_new_side_data_from_buf(AVFrame* frame, AVFrameSideDataType type, AVBufferRef* buf);
        unsafe int av_frame_ref(AVFrame* dst, AVFrame* src);
        unsafe void av_frame_remove_side_data(AVFrame* frame, AVFrameSideDataType type);
        string av_frame_side_data_name(AVFrameSideDataType type);
        unsafe void av_frame_unref(AVFrame* frame);
        unsafe void av_free(void* ptr);
        unsafe void av_freep(void* ptr);
        long av_gcd(long a, long b);
        AVRational av_gcd_q(AVRational a, AVRational b, int max_den, AVRational def);
        long av_gettime();
        long av_gettime_relative();
        int av_gettime_relative_is_monotonic();
        AVSampleFormat av_get_alt_sample_fmt(AVSampleFormat sample_fmt, int planar);
        unsafe int av_get_audio_frame_duration(AVCodecContext* avctx, int frame_bytes);
        unsafe int av_get_audio_frame_duration2(AVCodecParameters* par, int frame_bytes);
        unsafe int av_get_bits_per_pixel(AVPixFmtDescriptor* pixdesc);
        int av_get_bits_per_sample(AVCodecID codec_id);
        int av_get_bytes_per_sample(AVSampleFormat sample_fmt);
        string av_get_channel_description(ulong channel);
        ulong av_get_channel_layout([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        int av_get_channel_layout_channel_index(ulong channel_layout, ulong channel);
        int av_get_channel_layout_nb_channels(ulong channel_layout);
        unsafe void av_get_channel_layout_string(byte* buf, int buf_size, int nb_channels, ulong channel_layout);
        string av_get_channel_name(ulong channel);
        string av_get_colorspace_name(AVColorSpace val);
        int av_get_cpu_flags();
        long av_get_default_channel_layout(int nb_channels);
        int av_get_exact_bits_per_sample(AVCodecID codec_id);
        unsafe int av_get_extended_channel_layout([MarshalAs(UnmanagedType.LPUTF8Str)] string name, ulong* channel_layout, int* nb_channels);
        unsafe int av_get_frame_filename(byte* buf, int buf_size, [MarshalAs(UnmanagedType.LPUTF8Str)] string path, int number);
        unsafe int av_get_frame_filename2(byte* buf, int buf_size, [MarshalAs(UnmanagedType.LPUTF8Str)] string path, int number, int flags);
        string av_get_media_type_string(AVMediaType media_type);
        unsafe int av_get_output_timestamp(AVFormatContext* s, int stream, long* dts, long* wall);
        AVSampleFormat av_get_packed_sample_fmt(AVSampleFormat sample_fmt);
        unsafe int av_get_packet(AVIOContext* s, AVPacket* pkt, int size);
        unsafe int av_get_padded_bits_per_pixel(AVPixFmtDescriptor* pixdesc);
        AVCodecID av_get_pcm_codec(AVSampleFormat fmt, int be);
        byte av_get_picture_type_char(AVPictureType pict_type);
        AVPixelFormat av_get_pix_fmt([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        int av_get_pix_fmt_loss(AVPixelFormat dst_pix_fmt, AVPixelFormat src_pix_fmt, int has_alpha);
        string av_get_pix_fmt_name(AVPixelFormat pix_fmt);
        unsafe byte* av_get_pix_fmt_string(byte* buf, int buf_size, AVPixelFormat pix_fmt);
        AVSampleFormat av_get_planar_sample_fmt(AVSampleFormat sample_fmt);
        unsafe string av_get_profile_name(AVCodec* codec, int profile);
        AVSampleFormat av_get_sample_fmt([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        string av_get_sample_fmt_name(AVSampleFormat sample_fmt);
        unsafe byte* av_get_sample_fmt_string(byte* buf, int buf_size, AVSampleFormat sample_fmt);
        unsafe int av_get_standard_channel_layout(uint index, ulong* layout, byte** name);
        AVRational av_get_time_base_q();
        unsafe int av_grow_packet(AVPacket* pkt, int grow_by);
        unsafe AVCodecID av_guess_codec(AVOutputFormat* fmt, [MarshalAs(UnmanagedType.LPUTF8Str)] string short_name, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename, [MarshalAs(UnmanagedType.LPUTF8Str)] string mime_type, AVMediaType type);
        unsafe AVOutputFormat* av_guess_format([MarshalAs(UnmanagedType.LPUTF8Str)] string short_name, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename, [MarshalAs(UnmanagedType.LPUTF8Str)] string mime_type);
        unsafe AVRational av_guess_frame_rate(AVFormatContext* ctx, AVStream* stream, AVFrame* frame);
        unsafe AVRational av_guess_sample_aspect_ratio(AVFormatContext* format, AVStream* stream, AVFrame* frame);
        unsafe void av_hex_dump(_iobuf* f, byte* buf, int size);
        unsafe void av_hex_dump_log(void* avcl, int level, byte* buf, int size);
        unsafe AVBufferRef* av_hwdevice_ctx_alloc(AVHWDeviceType type);
        unsafe int av_hwdevice_ctx_create(AVBufferRef** device_ctx, AVHWDeviceType type, [MarshalAs(UnmanagedType.LPUTF8Str)] string device, AVDictionary* opts, int flags);
        unsafe int av_hwdevice_ctx_create_derived(AVBufferRef** dst_ctx, AVHWDeviceType type, AVBufferRef* src_ctx, int flags);
        unsafe int av_hwdevice_ctx_create_derived_opts(AVBufferRef** dst_ctx, AVHWDeviceType type, AVBufferRef* src_ctx, AVDictionary* options, int flags);
        unsafe int av_hwdevice_ctx_init(AVBufferRef* @ref);
        AVHWDeviceType av_hwdevice_find_type_by_name([MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        unsafe AVHWFramesConstraints* av_hwdevice_get_hwframe_constraints(AVBufferRef* @ref, void* hwconfig);
        string av_hwdevice_get_type_name(AVHWDeviceType type);
        unsafe void* av_hwdevice_hwconfig_alloc(AVBufferRef* device_ctx);
        AVHWDeviceType av_hwdevice_iterate_types(AVHWDeviceType prev);
        unsafe void av_hwframe_constraints_free(AVHWFramesConstraints** constraints);
        unsafe AVBufferRef* av_hwframe_ctx_alloc(AVBufferRef* device_ctx);
        unsafe int av_hwframe_ctx_create_derived(AVBufferRef** derived_frame_ctx, AVPixelFormat format, AVBufferRef* derived_device_ctx, AVBufferRef* source_frame_ctx, int flags);
        unsafe int av_hwframe_ctx_init(AVBufferRef* @ref);
        unsafe int av_hwframe_get_buffer(AVBufferRef* hwframe_ctx, AVFrame* frame, int flags);
        unsafe int av_hwframe_map(AVFrame* dst, AVFrame* src, int flags);
        unsafe int av_hwframe_transfer_data(AVFrame* dst, AVFrame* src, int flags);
        unsafe int av_hwframe_transfer_get_formats(AVBufferRef* hwframe_ctx, AVHWFrameTransferDirection dir, AVPixelFormat** formats, int flags);
        int av_image_alloc(ref byte_ptrArray4 pointers, ref int_array4 linesizes, int w, int h, AVPixelFormat pix_fmt, int align);
        int av_image_check_sar(uint w, uint h, AVRational sar);
        unsafe int av_image_check_size(uint w, uint h, int log_offset, void* log_ctx);
        unsafe int av_image_check_size2(uint w, uint h, long max_pixels, AVPixelFormat pix_fmt, int log_offset, void* log_ctx);
        void av_image_copy(ref byte_ptrArray4 dst_data, ref int_array4 dst_linesizes, ref byte_ptrArray4 src_data, int_array4 src_linesizes, AVPixelFormat pix_fmt, int width, int height);
        unsafe void av_image_copy_plane(byte* dst, int dst_linesize, byte* src, int src_linesize, int bytewidth, int height);
        unsafe void av_image_copy_plane_uc_from(byte* dst, long dst_linesize, byte* src, long src_linesize, long bytewidth, int height);
        unsafe int av_image_copy_to_buffer(byte* dst, int dst_size, byte_ptrArray4 src_data, int_array4 src_linesize, AVPixelFormat pix_fmt, int width, int height, int align);
        void av_image_copy_uc_from(ref byte_ptrArray4 dst_data, long_array4 dst_linesizes, ref byte_ptrArray4 src_data, long_array4 src_linesizes, AVPixelFormat pix_fmt, int width, int height);
        unsafe int av_image_fill_arrays(ref byte_ptrArray4 dst_data, ref int_array4 dst_linesize, byte* src, AVPixelFormat pix_fmt, int width, int height, int align);
        int av_image_fill_black(ref byte_ptrArray4 dst_data, long_array4 dst_linesize, AVPixelFormat pix_fmt, AVColorRange range, int width, int height);
        int av_image_fill_linesizes(ref int_array4 linesizes, AVPixelFormat pix_fmt, int width);
        unsafe void av_image_fill_max_pixsteps(int_array4 max_pixsteps, ref int_array4 max_pixstep_comps, AVPixFmtDescriptor* pixdesc);
        int av_image_fill_plane_sizes(ulong_array4 size, AVPixelFormat pix_fmt, int height, long_array4 linesizes);
        unsafe int av_image_fill_pointers(byte_ptrArray4 data, AVPixelFormat pix_fmt, int height, byte* ptr, int_array4 linesizes);
        int av_image_get_buffer_size(AVPixelFormat pix_fmt, int width, int height, int align);
        int av_image_get_linesize(AVPixelFormat pix_fmt, int width, int plane);
        unsafe int av_index_search_timestamp(AVStream* st, long timestamp, int flags);
        unsafe void av_init_packet(AVPacket* pkt);
        unsafe AVInputFormat* av_input_audio_device_next(AVInputFormat* d);
        unsafe AVInputFormat* av_input_video_device_next(AVInputFormat* d);
        unsafe int av_interleaved_write_frame(AVFormatContext* s, AVPacket* pkt);
        unsafe int av_interleaved_write_uncoded_frame(AVFormatContext* s, int stream_index, AVFrame* frame);
        unsafe uint av_int_list_length_for_size(uint elsize, void* list, ulong term);
        unsafe void av_log(void* avcl, int level, [MarshalAs(UnmanagedType.LPUTF8Str)] string fmt);
        int av_log2(uint v);
        int av_log2_16bit(uint v);
        unsafe void av_log_default_callback(void* avcl, int level, [MarshalAs(UnmanagedType.LPUTF8Str)] string fmt, byte* vl);
        unsafe void av_log_format_line(void* ptr, int level, [MarshalAs(UnmanagedType.LPUTF8Str)] string fmt, byte* vl, byte* line, int line_size, int* print_prefix);
        unsafe int av_log_format_line2(void* ptr, int level, [MarshalAs(UnmanagedType.LPUTF8Str)] string fmt, byte* vl, byte* line, int line_size, int* print_prefix);
        int av_log_get_flags();
        int av_log_get_level();
        unsafe void av_log_once(void* avcl, int initial_level, int subsequent_level, int* state, [MarshalAs(UnmanagedType.LPUTF8Str)] string fmt);
        void av_log_set_callback(av_log_set_callback_callback_func callback);
        void av_log_set_flags(int arg);
        void av_log_set_level(int level);
        unsafe void* av_malloc(ulong size);
        unsafe void* av_mallocz(ulong size);
        unsafe void* av_mallocz_array(ulong nmemb, ulong size);
        unsafe void* av_malloc_array(ulong nmemb, ulong size);
        unsafe AVMasteringDisplayMetadata* av_mastering_display_metadata_alloc();
        unsafe AVMasteringDisplayMetadata* av_mastering_display_metadata_create_side_data(AVFrame* frame);
        int av_match_ext([MarshalAs(UnmanagedType.LPUTF8Str)] string filename, [MarshalAs(UnmanagedType.LPUTF8Str)] string extensions);
        void av_max_alloc(ulong max);
        unsafe void av_memcpy_backptr(byte* dst, int back, int cnt);
        unsafe void* av_memdup(void* p, ulong size);
        AVRational av_mul_q(AVRational b, AVRational c);
        unsafe AVOutputFormat* av_muxer_iterate(void** opaque);
        int av_nearer_q(AVRational q, AVRational q1, AVRational q2);
        unsafe int av_new_packet(AVPacket* pkt, int size);
        unsafe AVProgram* av_new_program(AVFormatContext* s, int id);
        unsafe AVClass* av_opt_child_class_iterate(AVClass* parent, void** iter);
        unsafe void* av_opt_child_next(void* obj, void* prev);
        unsafe int av_opt_copy(void* dest, void* src);
        unsafe int av_opt_eval_double(void* obj, AVOption* o, [MarshalAs(UnmanagedType.LPUTF8Str)] string val, double* double_out);
        unsafe int av_opt_eval_flags(void* obj, AVOption* o, [MarshalAs(UnmanagedType.LPUTF8Str)] string val, int* flags_out);
        unsafe int av_opt_eval_float(void* obj, AVOption* o, [MarshalAs(UnmanagedType.LPUTF8Str)] string val, float* float_out);
        unsafe int av_opt_eval_int(void* obj, AVOption* o, [MarshalAs(UnmanagedType.LPUTF8Str)] string val, int* int_out);
        unsafe int av_opt_eval_int64(void* obj, AVOption* o, [MarshalAs(UnmanagedType.LPUTF8Str)] string val, long* int64_out);
        unsafe int av_opt_eval_q(void* obj, AVOption* o, [MarshalAs(UnmanagedType.LPUTF8Str)] string val, AVRational* q_out);
        unsafe AVOption* av_opt_find(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string unit, int opt_flags, int search_flags);
        unsafe AVOption* av_opt_find2(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string unit, int opt_flags, int search_flags, void** target_obj);
        unsafe int av_opt_flag_is_set(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string field_name, [MarshalAs(UnmanagedType.LPUTF8Str)] string flag_name);
        unsafe void av_opt_free(void* obj);
        unsafe void av_opt_freep_ranges(AVOptionRanges** ranges);
        unsafe int av_opt_get(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int search_flags, byte** out_val);
        unsafe int av_opt_get_channel_layout(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int search_flags, long* ch_layout);
        unsafe int av_opt_get_dict_val(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int search_flags, AVDictionary** out_val);
        unsafe int av_opt_get_double(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int search_flags, double* out_val);
        unsafe int av_opt_get_image_size(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int search_flags, int* w_out, int* h_out);
        unsafe int av_opt_get_int(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int search_flags, long* out_val);
        unsafe int av_opt_get_key_value(byte** ropts, [MarshalAs(UnmanagedType.LPUTF8Str)] string key_val_sep, [MarshalAs(UnmanagedType.LPUTF8Str)] string pairs_sep, uint flags, byte** rkey, byte** rval);
        unsafe int av_opt_get_pixel_fmt(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int search_flags, AVPixelFormat* out_fmt);
        unsafe int av_opt_get_q(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int search_flags, AVRational* out_val);
        unsafe int av_opt_get_sample_fmt(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int search_flags, AVSampleFormat* out_fmt);
        unsafe int av_opt_get_video_rate(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int search_flags, AVRational* out_val);
        unsafe int av_opt_is_set_to_default(void* obj, AVOption* o);
        unsafe int av_opt_is_set_to_default_by_name(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int search_flags);
        unsafe AVOption* av_opt_next(void* obj, AVOption* prev);
        unsafe void* av_opt_ptr(AVClass* avclass, void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);
        unsafe int av_opt_query_ranges(AVOptionRanges** p0, void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string key, int flags);
        unsafe int av_opt_query_ranges_default(AVOptionRanges** p0, void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string key, int flags);
        unsafe int av_opt_serialize(void* obj, int opt_flags, int flags, byte** buffer, byte key_val_sep, byte pairs_sep);
        unsafe int av_opt_set(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string val, int search_flags);
        unsafe int av_opt_set_bin(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, byte* val, int size, int search_flags);
        unsafe int av_opt_set_channel_layout(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, long ch_layout, int search_flags);
        unsafe void av_opt_set_defaults(void* s);
        unsafe void av_opt_set_defaults2(void* s, int mask, int flags);
        unsafe int av_opt_set_dict(void* obj, AVDictionary** options);
        unsafe int av_opt_set_dict2(void* obj, AVDictionary** options, int search_flags);
        unsafe int av_opt_set_dict_val(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, AVDictionary* val, int search_flags);
        unsafe int av_opt_set_double(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, double val, int search_flags);
        unsafe int av_opt_set_from_string(void* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string opts, byte** shorthand, [MarshalAs(UnmanagedType.LPUTF8Str)] string key_val_sep, [MarshalAs(UnmanagedType.LPUTF8Str)] string pairs_sep);
        unsafe int av_opt_set_image_size(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int w, int h, int search_flags);
        unsafe int av_opt_set_int(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, long val, int search_flags);
        unsafe int av_opt_set_pixel_fmt(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, AVPixelFormat fmt, int search_flags);
        unsafe int av_opt_set_q(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, AVRational val, int search_flags);
        unsafe int av_opt_set_sample_fmt(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, AVSampleFormat fmt, int search_flags);
        unsafe int av_opt_set_video_rate(void* obj, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, AVRational val, int search_flags);
        unsafe int av_opt_show2(void* obj, void* av_log_obj, int req_flags, int rej_flags);
        unsafe AVOutputFormat* av_output_audio_device_next(AVOutputFormat* d);
        unsafe AVOutputFormat* av_output_video_device_next(AVOutputFormat* d);
        unsafe int av_packet_add_side_data(AVPacket* pkt, AVPacketSideDataType type, byte* data, ulong size);
        unsafe AVPacket* av_packet_alloc();
        unsafe AVPacket* av_packet_clone(AVPacket* src);
        unsafe int av_packet_copy_props(AVPacket* dst, AVPacket* src);
        unsafe void av_packet_free(AVPacket** pkt);
        unsafe void av_packet_free_side_data(AVPacket* pkt);
        unsafe int av_packet_from_data(AVPacket* pkt, byte* data, int size);
        unsafe byte* av_packet_get_side_data(AVPacket* pkt, AVPacketSideDataType type, ulong* size);
        unsafe int av_packet_make_refcounted(AVPacket* pkt);
        unsafe int av_packet_make_writable(AVPacket* pkt);
        unsafe void av_packet_move_ref(AVPacket* dst, AVPacket* src);
        unsafe byte* av_packet_new_side_data(AVPacket* pkt, AVPacketSideDataType type, ulong size);
        unsafe byte* av_packet_pack_dictionary(AVDictionary* dict, ulong* size);
        unsafe int av_packet_ref(AVPacket* dst, AVPacket* src);
        unsafe void av_packet_rescale_ts(AVPacket* pkt, AVRational tb_src, AVRational tb_dst);
        unsafe int av_packet_shrink_side_data(AVPacket* pkt, AVPacketSideDataType type, ulong size);
        string av_packet_side_data_name(AVPacketSideDataType type);
        unsafe int av_packet_unpack_dictionary(byte* data, ulong size, AVDictionary** dict);
        unsafe void av_packet_unref(AVPacket* pkt);
        unsafe void av_parser_close(AVCodecParserContext* s);
        unsafe AVCodecParserContext* av_parser_init(int codec_id);
        unsafe AVCodecParser* av_parser_iterate(void** opaque);
        unsafe int av_parser_parse2(AVCodecParserContext* s, AVCodecContext* avctx, byte** poutbuf, int* poutbuf_size, byte* buf, int buf_size, long pts, long dts, long pos);
        unsafe int av_parse_cpu_caps(uint* flags, [MarshalAs(UnmanagedType.LPUTF8Str)] string s);
        int av_pix_fmt_count_planes(AVPixelFormat pix_fmt);
        unsafe AVPixFmtDescriptor* av_pix_fmt_desc_get(AVPixelFormat pix_fmt);
        unsafe AVPixelFormat av_pix_fmt_desc_get_id(AVPixFmtDescriptor* desc);
        unsafe AVPixFmtDescriptor* av_pix_fmt_desc_next(AVPixFmtDescriptor* prev);
        unsafe int av_pix_fmt_get_chroma_sub_sample(AVPixelFormat pix_fmt, int* h_shift, int* v_shift);
        AVPixelFormat av_pix_fmt_swap_endianness(AVPixelFormat pix_fmt);
        unsafe void av_pkt_dump2(_iobuf* f, AVPacket* pkt, int dump_payload, AVStream* st);
        unsafe void av_pkt_dump_log2(void* avcl, int level, AVPacket* pkt, int dump_payload, AVStream* st);
        unsafe int av_probe_input_buffer(AVIOContext* pb, AVInputFormat** fmt, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, void* logctx, uint offset, uint max_probe_size);
        unsafe int av_probe_input_buffer2(AVIOContext* pb, AVInputFormat** fmt, [MarshalAs(UnmanagedType.LPUTF8Str)] string url, void* logctx, uint offset, uint max_probe_size);
        unsafe AVInputFormat* av_probe_input_format(AVProbeData* pd, int is_opened);
        unsafe AVInputFormat* av_probe_input_format2(AVProbeData* pd, int is_opened, int* score_max);
        unsafe AVInputFormat* av_probe_input_format3(AVProbeData* pd, int is_opened, int* score_ret);
        unsafe void av_program_add_stream_index(AVFormatContext* ac, int progid, uint idx);
        uint av_q2intfloat(AVRational q);
        unsafe int av_read_frame(AVFormatContext* s, AVPacket* pkt);
        unsafe void av_read_image_line(ushort* dst, ref byte_ptrArray4 data, int_array4 linesize, AVPixFmtDescriptor* desc, int x, int y, int c, int w, int read_pal_component);
        unsafe void av_read_image_line2(void* dst, ref byte_ptrArray4 data, int_array4 linesize, AVPixFmtDescriptor* desc, int x, int y, int c, int w, int read_pal_component, int dst_element_size);
        unsafe int av_read_pause(AVFormatContext* s);
        unsafe int av_read_play(AVFormatContext* s);
        unsafe void* av_realloc(void* ptr, ulong size);
        unsafe int av_reallocp(void* ptr, ulong size);
        unsafe int av_reallocp_array(void* ptr, ulong nmemb, ulong size);
        unsafe void* av_realloc_array(void* ptr, ulong nmemb, ulong size);
        unsafe void* av_realloc_f(void* ptr, ulong nelem, ulong elsize);
        unsafe int av_reduce(int* dst_num, int* dst_den, long num, long den, long max);
        long av_rescale(long a, long b, long c);
        unsafe long av_rescale_delta(AVRational in_tb, long in_ts, AVRational fs_tb, int duration, long* last, AVRational out_tb);
        long av_rescale_q(long a, AVRational bq, AVRational cq);
        long av_rescale_q_rnd(long a, AVRational bq, AVRational cq, AVRounding rnd);
        long av_rescale_rnd(long a, long b, long c, AVRounding rnd);
        unsafe int av_samples_alloc(byte** audio_data, int* linesize, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
        unsafe int av_samples_alloc_array_and_samples(byte*** audio_data, int* linesize, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
        unsafe int av_samples_copy(byte** dst, byte** src, int dst_offset, int src_offset, int nb_samples, int nb_channels, AVSampleFormat sample_fmt);
        unsafe int av_samples_fill_arrays(byte** audio_data, int* linesize, byte* buf, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
        unsafe int av_samples_get_buffer_size(int* linesize, int nb_channels, int nb_samples, AVSampleFormat sample_fmt, int align);
        unsafe int av_samples_set_silence(byte** audio_data, int offset, int nb_samples, int nb_channels, AVSampleFormat sample_fmt);
        int av_sample_fmt_is_planar(AVSampleFormat sample_fmt);
        unsafe int av_sdp_create(AVFormatContext** ac, int n_files, byte* buf, int size);
        unsafe int av_seek_frame(AVFormatContext* s, int stream_index, long timestamp, int flags);
        unsafe int av_set_options_string(void* ctx, [MarshalAs(UnmanagedType.LPUTF8Str)] string opts, [MarshalAs(UnmanagedType.LPUTF8Str)] string key_val_sep, [MarshalAs(UnmanagedType.LPUTF8Str)] string pairs_sep);
        unsafe void av_shrink_packet(AVPacket* pkt, int size);
        unsafe int av_size_mult(ulong a, ulong b, ulong* r);
        unsafe byte* av_strdup([MarshalAs(UnmanagedType.LPUTF8Str)] string s);
        unsafe int av_stream_add_side_data(AVStream* st, AVPacketSideDataType type, byte* data, ulong size);
        unsafe AVClass* av_stream_get_class();
        unsafe AVRational av_stream_get_codec_timebase(AVStream* st);
        unsafe long av_stream_get_end_pts(AVStream* st);
        unsafe AVCodecParserContext* av_stream_get_parser(AVStream* s);
        unsafe byte* av_stream_get_side_data(AVStream* stream, AVPacketSideDataType type, ulong* size);
        unsafe byte* av_stream_new_side_data(AVStream* stream, AVPacketSideDataType type, ulong size);
        unsafe int av_strerror(int errnum, byte* errbuf, ulong errbuf_size);
        unsafe byte* av_strndup([MarshalAs(UnmanagedType.LPUTF8Str)] string s, ulong len);
        AVRational av_sub_q(AVRational b, AVRational c);
        unsafe int av_tempfile([MarshalAs(UnmanagedType.LPUTF8Str)] string prefix, byte** filename, int log_offset, void* log_ctx);
        int av_timecode_adjust_ntsc_framenum2(int framenum, int fps);
        int av_timecode_check_frame_rate(AVRational rate);
        uint av_timecode_get_smpte(AVRational rate, int drop, int hh, int mm, int ss, int ff);
        unsafe uint av_timecode_get_smpte_from_framenum(AVTimecode* tc, int framenum);
        unsafe int av_timecode_init(AVTimecode* tc, AVRational rate, int flags, int frame_start, void* log_ctx);
        unsafe int av_timecode_init_from_components(AVTimecode* tc, AVRational rate, int flags, int hh, int mm, int ss, int ff, void* log_ctx);
        unsafe int av_timecode_init_from_string(AVTimecode* tc, AVRational rate, [MarshalAs(UnmanagedType.LPUTF8Str)] string str, void* log_ctx);
        unsafe byte* av_timecode_make_mpeg_tc_string(byte* buf, uint tc25bit);
        unsafe byte* av_timecode_make_smpte_tc_string(byte* buf, uint tcsmpte, int prevent_df);
        unsafe byte* av_timecode_make_smpte_tc_string2(byte* buf, AVRational rate, uint tcsmpte, int prevent_df, int skip_field);
        unsafe byte* av_timecode_make_string(AVTimecode* tc, byte* buf, int framenum);
        unsafe void av_tree_destroy(AVTreeNode* t);
        unsafe void av_tree_enumerate(AVTreeNode* t, void* opaque, av_tree_enumerate_cmp_func cmp, av_tree_enumerate_enu_func enu);
        unsafe void* av_tree_find(AVTreeNode* root, void* key, av_tree_find_cmp_func cmp, void_ptrArray2 next);
        unsafe void* av_tree_insert(AVTreeNode** rootp, void* key, av_tree_insert_cmp_func cmp, AVTreeNode** next);
        unsafe AVTreeNode* av_tree_node_alloc();
        unsafe void av_url_split(byte* proto, int proto_size, byte* authorization, int authorization_size, byte* hostname, int hostname_size, int* port_ptr, byte* path, int path_size, [MarshalAs(UnmanagedType.LPUTF8Str)] string url);
        int av_usleep(uint usec);
        string av_version_info();
        unsafe void av_vlog(void* avcl, int level, [MarshalAs(UnmanagedType.LPUTF8Str)] string fmt, byte* vl);
        unsafe int av_write_frame(AVFormatContext* s, AVPacket* pkt);
        unsafe void av_write_image_line(ushort* src, ref byte_ptrArray4 data, int_array4 linesize, AVPixFmtDescriptor* desc, int x, int y, int c, int w);
        unsafe void av_write_image_line2(void* src, ref byte_ptrArray4 data, int_array4 linesize, AVPixFmtDescriptor* desc, int x, int y, int c, int w, int src_element_size);
        unsafe int av_write_trailer(AVFormatContext* s);
        unsafe int av_write_uncoded_frame(AVFormatContext* s, int stream_index, AVFrame* frame);
        unsafe int av_write_uncoded_frame_query(AVFormatContext* s, int stream_index);
        unsafe uint av_xiphlacing(byte* s, uint v);
        T NativeMethodDelegate<T>();
        string postproc_configuration();
        string postproc_license();
        uint postproc_version();
        unsafe void pp_free_context(void* ppContext);
        unsafe void pp_free_mode(void* mode);
        unsafe void* pp_get_context(int width, int height, int flags);
        unsafe void* pp_get_mode_by_name_and_quality([MarshalAs(UnmanagedType.LPUTF8Str)] string name, int quality);
        unsafe void pp_postprocess(byte_ptrArray3 src, int_array3 srcStride, ref byte_ptrArray3 dst, int_array3 dstStride, int horizontalSize, int verticalSize, sbyte* QP_store, int QP_stride, void* mode, void* ppContext, int pict_type);
        string swresample_configuration();
        string swresample_license();
        uint swresample_version();
        unsafe SwrContext* swr_alloc();
        unsafe SwrContext* swr_alloc_set_opts(SwrContext* s, long out_ch_layout, AVSampleFormat out_sample_fmt, int out_sample_rate, long in_ch_layout, AVSampleFormat in_sample_fmt, int in_sample_rate, int log_offset, void* log_ctx);
        unsafe int swr_build_matrix(ulong in_layout, ulong out_layout, double center_mix_level, double surround_mix_level, double lfe_mix_level, double rematrix_maxval, double rematrix_volume, double* matrix, int stride, AVMatrixEncoding matrix_encoding, void* log_ctx);
        unsafe void swr_close(SwrContext* s);
        unsafe int swr_config_frame(SwrContext* swr, AVFrame* @out, AVFrame* @in);
        unsafe int swr_convert(SwrContext* s, byte** @out, int out_count, byte** @in, int in_count);
        unsafe int swr_convert_frame(SwrContext* swr, AVFrame* output, AVFrame* input);
        unsafe int swr_drop_output(SwrContext* s, int count);
        unsafe void swr_free(SwrContext** s);
        unsafe AVClass* swr_get_class();
        unsafe long swr_get_delay(SwrContext* s, long @base);
        unsafe int swr_get_out_samples(SwrContext* s, int in_samples);
        unsafe int swr_init(SwrContext* s);
        unsafe int swr_inject_silence(SwrContext* s, int count);
        unsafe int swr_is_initialized(SwrContext* s);
        unsafe long swr_next_pts(SwrContext* s, long pts);
        unsafe int swr_set_channel_mapping(SwrContext* s, int* channel_map);
        unsafe int swr_set_compensation(SwrContext* s, int sample_delta, int compensation_distance);
        unsafe int swr_set_matrix(SwrContext* s, double* matrix, int stride);
        string swscale_configuration();
        string swscale_license();
        uint swscale_version();
        unsafe SwsVector* sws_allocVec(int length);
        unsafe SwsContext* sws_alloc_context();
        unsafe void sws_convertPalette8ToPacked24(byte* src, byte* dst, int num_pixels, byte* palette);
        unsafe void sws_convertPalette8ToPacked32(byte* src, byte* dst, int num_pixels, byte* palette);
        unsafe void sws_frame_end(SwsContext* c);
        unsafe int sws_frame_start(SwsContext* c, AVFrame* dst, AVFrame* src);
        unsafe void sws_freeContext(SwsContext* swsContext);
        unsafe void sws_freeFilter(SwsFilter* filter);
        unsafe void sws_freeVec(SwsVector* a);
        unsafe SwsContext* sws_getCachedContext(SwsContext* context, int srcW, int srcH, AVPixelFormat srcFormat, int dstW, int dstH, AVPixelFormat dstFormat, int flags, SwsFilter* srcFilter, SwsFilter* dstFilter, double* param);
        unsafe int* sws_getCoefficients(int colorspace);
        unsafe int sws_getColorspaceDetails(SwsContext* c, int** inv_table, int* srcRange, int** table, int* dstRange, int* brightness, int* contrast, int* saturation);
        unsafe SwsContext* sws_getContext(int srcW, int srcH, AVPixelFormat srcFormat, int dstW, int dstH, AVPixelFormat dstFormat, int flags, SwsFilter* srcFilter, SwsFilter* dstFilter, double* param);
        unsafe SwsFilter* sws_getDefaultFilter(float lumaGBlur, float chromaGBlur, float lumaSharpen, float chromaSharpen, float chromaHShift, float chromaVShift, int verbose);
        unsafe SwsVector* sws_getGaussianVec(double variance, double quality);
        unsafe AVClass* sws_get_class();
        unsafe int sws_init_context(SwsContext* sws_context, SwsFilter* srcFilter, SwsFilter* dstFilter);
        int sws_isSupportedEndiannessConversion(AVPixelFormat pix_fmt);
        int sws_isSupportedInput(AVPixelFormat pix_fmt);
        int sws_isSupportedOutput(AVPixelFormat pix_fmt);
        unsafe void sws_normalizeVec(SwsVector* a, double height);
        unsafe int sws_receive_slice(SwsContext* c, uint slice_start, uint slice_height);
        unsafe uint sws_receive_slice_alignment(SwsContext* c);
        unsafe int sws_scale(SwsContext* c, byte*[] srcSlice, int[] srcStride, int srcSliceY, int srcSliceH, byte*[] dst, int[] dstStride);
        unsafe void sws_scaleVec(SwsVector* a, double scalar);
        unsafe int sws_scale_frame(SwsContext* c, AVFrame* dst, AVFrame* src);
        unsafe int sws_send_slice(SwsContext* c, uint slice_start, uint slice_height);
        unsafe int sws_setColorspaceDetails(SwsContext* c, int_array4 inv_table, int srcRange, int_array4 table, int dstRange, int brightness, int contrast, int saturation);
    }

}