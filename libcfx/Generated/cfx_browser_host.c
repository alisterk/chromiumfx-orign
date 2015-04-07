// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


// cef_browser_host

#ifdef __cplusplus
extern "C" {
#endif

// CEF_EXPORT int cef_browser_host_create_browser(const cef_window_info_t* windowInfo, cef_client_t* client, const cef_string_t* url, const cef_browser_settings_t* settings, cef_request_context_t* request_context);
static int cfx_browser_host_create_browser(const cef_window_info_t* windowInfo, cef_client_t* client, char16 *url_str, int url_length, const cef_browser_settings_t* settings, cef_request_context_t* request_context) {
    if(client) ((cef_base_t*)client)->add_ref((cef_base_t*)client);
    cef_string_t url = { url_str, url_length, 0 };
    if(request_context) ((cef_base_t*)request_context)->add_ref((cef_base_t*)request_context);
    return cef_browser_host_create_browser(windowInfo, client, &url, settings, request_context);
}
// CEF_EXPORT cef_browser_t* cef_browser_host_create_browser_sync(const cef_window_info_t* windowInfo, cef_client_t* client, const cef_string_t* url, const cef_browser_settings_t* settings, cef_request_context_t* request_context);
static cef_browser_t* cfx_browser_host_create_browser_sync(const cef_window_info_t* windowInfo, cef_client_t* client, char16 *url_str, int url_length, const cef_browser_settings_t* settings, cef_request_context_t* request_context) {
    if(client) ((cef_base_t*)client)->add_ref((cef_base_t*)client);
    cef_string_t url = { url_str, url_length, 0 };
    if(request_context) ((cef_base_t*)request_context)->add_ref((cef_base_t*)request_context);
    return cef_browser_host_create_browser_sync(windowInfo, client, &url, settings, request_context);
}
// cef_base_t base

// get_browser
static cef_browser_t* cfx_browser_host_get_browser(cef_browser_host_t* self) {
    return self->get_browser(self);
}

// parent_window_will_close
static void cfx_browser_host_parent_window_will_close(cef_browser_host_t* self) {
    self->parent_window_will_close(self);
}

// close_browser
static void cfx_browser_host_close_browser(cef_browser_host_t* self, int force_close) {
    self->close_browser(self, force_close);
}

// set_focus
static void cfx_browser_host_set_focus(cef_browser_host_t* self, int focus) {
    self->set_focus(self, focus);
}

// set_window_visibility
static void cfx_browser_host_set_window_visibility(cef_browser_host_t* self, int visible) {
    self->set_window_visibility(self, visible);
}

// get_window_handle
static cef_window_handle_t cfx_browser_host_get_window_handle(cef_browser_host_t* self) {
    return self->get_window_handle(self);
}

// get_opener_window_handle
static cef_window_handle_t cfx_browser_host_get_opener_window_handle(cef_browser_host_t* self) {
    return self->get_opener_window_handle(self);
}

// get_client
static cef_client_t* cfx_browser_host_get_client(cef_browser_host_t* self) {
    return self->get_client(self);
}

// get_request_context
static cef_request_context_t* cfx_browser_host_get_request_context(cef_browser_host_t* self) {
    return self->get_request_context(self);
}

// get_zoom_level
static double cfx_browser_host_get_zoom_level(cef_browser_host_t* self) {
    return self->get_zoom_level(self);
}

// set_zoom_level
static void cfx_browser_host_set_zoom_level(cef_browser_host_t* self, double zoomLevel) {
    self->set_zoom_level(self, zoomLevel);
}

// run_file_dialog
static void cfx_browser_host_run_file_dialog(cef_browser_host_t* self, cef_file_dialog_mode_t mode, char16 *title_str, int title_length, char16 *default_file_name_str, int default_file_name_length, cef_string_list_t accept_types, cef_run_file_dialog_callback_t* callback) {
    cef_string_t title = { title_str, title_length, 0 };
    cef_string_t default_file_name = { default_file_name_str, default_file_name_length, 0 };
    if(callback) ((cef_base_t*)callback)->add_ref((cef_base_t*)callback);
    self->run_file_dialog(self, mode, &title, &default_file_name, accept_types, callback);
}

// start_download
static void cfx_browser_host_start_download(cef_browser_host_t* self, char16 *url_str, int url_length) {
    cef_string_t url = { url_str, url_length, 0 };
    self->start_download(self, &url);
}

// print
static void cfx_browser_host_print(cef_browser_host_t* self) {
    self->print(self);
}

// find
static void cfx_browser_host_find(cef_browser_host_t* self, int identifier, char16 *searchText_str, int searchText_length, int forward, int matchCase, int findNext) {
    cef_string_t searchText = { searchText_str, searchText_length, 0 };
    self->find(self, identifier, &searchText, forward, matchCase, findNext);
}

// stop_finding
static void cfx_browser_host_stop_finding(cef_browser_host_t* self, int clearSelection) {
    self->stop_finding(self, clearSelection);
}

// show_dev_tools
static void cfx_browser_host_show_dev_tools(cef_browser_host_t* self, const cef_window_info_t* windowInfo, cef_client_t* client, const cef_browser_settings_t* settings) {
    if(client) ((cef_base_t*)client)->add_ref((cef_base_t*)client);
    self->show_dev_tools(self, windowInfo, client, settings);
}

// close_dev_tools
static void cfx_browser_host_close_dev_tools(cef_browser_host_t* self) {
    self->close_dev_tools(self);
}

// set_mouse_cursor_change_disabled
static void cfx_browser_host_set_mouse_cursor_change_disabled(cef_browser_host_t* self, int disabled) {
    self->set_mouse_cursor_change_disabled(self, disabled);
}

// is_mouse_cursor_change_disabled
static int cfx_browser_host_is_mouse_cursor_change_disabled(cef_browser_host_t* self) {
    return self->is_mouse_cursor_change_disabled(self);
}

// is_window_rendering_disabled
static int cfx_browser_host_is_window_rendering_disabled(cef_browser_host_t* self) {
    return self->is_window_rendering_disabled(self);
}

// was_resized
static void cfx_browser_host_was_resized(cef_browser_host_t* self) {
    self->was_resized(self);
}

// was_hidden
static void cfx_browser_host_was_hidden(cef_browser_host_t* self, int hidden) {
    self->was_hidden(self, hidden);
}

// notify_screen_info_changed
static void cfx_browser_host_notify_screen_info_changed(cef_browser_host_t* self) {
    self->notify_screen_info_changed(self);
}

// invalidate
static void cfx_browser_host_invalidate(cef_browser_host_t* self, const cef_rect_t* dirtyRect, cef_paint_element_type_t type) {
    self->invalidate(self, dirtyRect, type);
}

// send_key_event
static void cfx_browser_host_send_key_event(cef_browser_host_t* self, const cef_key_event_t* event) {
    self->send_key_event(self, event);
}

// send_mouse_click_event
static void cfx_browser_host_send_mouse_click_event(cef_browser_host_t* self, const cef_mouse_event_t* event, cef_mouse_button_type_t type, int mouseUp, int clickCount) {
    self->send_mouse_click_event(self, event, type, mouseUp, clickCount);
}

// send_mouse_move_event
static void cfx_browser_host_send_mouse_move_event(cef_browser_host_t* self, const cef_mouse_event_t* event, int mouseLeave) {
    self->send_mouse_move_event(self, event, mouseLeave);
}

// send_mouse_wheel_event
static void cfx_browser_host_send_mouse_wheel_event(cef_browser_host_t* self, const cef_mouse_event_t* event, int deltaX, int deltaY) {
    self->send_mouse_wheel_event(self, event, deltaX, deltaY);
}

// send_focus_event
static void cfx_browser_host_send_focus_event(cef_browser_host_t* self, int setFocus) {
    self->send_focus_event(self, setFocus);
}

// send_capture_lost_event
static void cfx_browser_host_send_capture_lost_event(cef_browser_host_t* self) {
    self->send_capture_lost_event(self);
}

// get_nstext_input_context
static cef_text_input_context_t cfx_browser_host_get_nstext_input_context(cef_browser_host_t* self) {
    return self->get_nstext_input_context(self);
}

// handle_key_event_before_text_input_client
static void cfx_browser_host_handle_key_event_before_text_input_client(cef_browser_host_t* self, cef_event_handle_t keyEvent) {
    self->handle_key_event_before_text_input_client(self, keyEvent);
}

// handle_key_event_after_text_input_client
static void cfx_browser_host_handle_key_event_after_text_input_client(cef_browser_host_t* self, cef_event_handle_t keyEvent) {
    self->handle_key_event_after_text_input_client(self, keyEvent);
}


#ifdef __cplusplus
} // extern "C"
#endif

