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


// cef_geolocation_handler

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_geolocation_handler_t {
    cef_geolocation_handler_t cef_geolocation_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_geolocation_handler_t;

int CEF_CALLBACK _cfx_geolocation_handler_add_ref(struct _cef_base_t* base) {
    cfx_geolocation_handler_t* ptr = (cfx_geolocation_handler_t*)base;
    return InterlockedIncrement(&ptr->ref_count);
}
int CEF_CALLBACK _cfx_geolocation_handler_release(struct _cef_base_t* base) {
    cfx_geolocation_handler_t* ptr = (cfx_geolocation_handler_t*)base;
    int count = InterlockedDecrement(&((cfx_geolocation_handler_t*)ptr)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_geolocation_handler_t*)ptr)->gc_handle);
        free(ptr);
    }
    return count;
}
int CEF_CALLBACK _cfx_geolocation_handler_get_refct(struct _cef_base_t* base) {
    cfx_geolocation_handler_t* ptr = (cfx_geolocation_handler_t*)base;
    return ptr->ref_count;
}

CFX_EXPORT cfx_geolocation_handler_t* cfx_geolocation_handler_ctor(gc_handle_t gc_handle) {
    cfx_geolocation_handler_t* ptr = (cfx_geolocation_handler_t*)calloc(1, sizeof(cfx_geolocation_handler_t));
    if(!ptr) return 0;
    ptr->cef_geolocation_handler.base.size = sizeof(cef_geolocation_handler_t);
    ptr->cef_geolocation_handler.base.add_ref = _cfx_geolocation_handler_add_ref;
    ptr->cef_geolocation_handler.base.release = _cfx_geolocation_handler_release;
    ptr->cef_geolocation_handler.base.get_refct = _cfx_geolocation_handler_get_refct;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

CFX_EXPORT gc_handle_t cfx_geolocation_handler_get_gc_handle(cfx_geolocation_handler_t* self) {
    return self->gc_handle;
}

// on_request_geolocation_permission

void (CEF_CALLBACK *cfx_geolocation_handler_on_request_geolocation_permission_callback)(gc_handle_t self, cef_browser_t* browser, char16 *requesting_url_str, int requesting_url_length, int request_id, cef_geolocation_callback_t* callback);

void CEF_CALLBACK cfx_geolocation_handler_on_request_geolocation_permission(cef_geolocation_handler_t* self, cef_browser_t* browser, const cef_string_t* requesting_url, int request_id, cef_geolocation_callback_t* callback) {
    cfx_geolocation_handler_on_request_geolocation_permission_callback(((cfx_geolocation_handler_t*)self)->gc_handle, browser, requesting_url ? requesting_url->str : 0, requesting_url ? requesting_url->length : 0, request_id, callback);
}


// on_cancel_geolocation_permission

void (CEF_CALLBACK *cfx_geolocation_handler_on_cancel_geolocation_permission_callback)(gc_handle_t self, cef_browser_t* browser, char16 *requesting_url_str, int requesting_url_length, int request_id);

void CEF_CALLBACK cfx_geolocation_handler_on_cancel_geolocation_permission(cef_geolocation_handler_t* self, cef_browser_t* browser, const cef_string_t* requesting_url, int request_id) {
    cfx_geolocation_handler_on_cancel_geolocation_permission_callback(((cfx_geolocation_handler_t*)self)->gc_handle, browser, requesting_url ? requesting_url->str : 0, requesting_url ? requesting_url->length : 0, request_id);
}


CFX_EXPORT void cfx_geolocation_handler_activate_callback(cef_geolocation_handler_t* self, int index, int is_active) {
    switch(index) {
    case 0:
        self->on_request_geolocation_permission = is_active ? cfx_geolocation_handler_on_request_geolocation_permission : 0;
        break;
    case 1:
        self->on_cancel_geolocation_permission = is_active ? cfx_geolocation_handler_on_cancel_geolocation_permission : 0;
        break;
    }
}
CFX_EXPORT void cfx_geolocation_handler_set_callback_ptrs(void *cb_0, void *cb_1) {
    cfx_geolocation_handler_on_request_geolocation_permission_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, char16 *requesting_url_str, int requesting_url_length, int request_id, cef_geolocation_callback_t* callback)) cb_0;
    cfx_geolocation_handler_on_cancel_geolocation_permission_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, char16 *requesting_url_str, int requesting_url_length, int request_id)) cb_1;
}

#ifdef __cplusplus
} // extern "C"
#endif

