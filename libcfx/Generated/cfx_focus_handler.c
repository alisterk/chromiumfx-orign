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


// cef_focus_handler

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_focus_handler_t {
    cef_focus_handler_t cef_focus_handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_focus_handler_t;

int CEF_CALLBACK _cfx_focus_handler_add_ref(struct _cef_base_t* base) {
    cfx_focus_handler_t* ptr = (cfx_focus_handler_t*)base;
    return InterlockedIncrement(&ptr->ref_count);
}
int CEF_CALLBACK _cfx_focus_handler_release(struct _cef_base_t* base) {
    cfx_focus_handler_t* ptr = (cfx_focus_handler_t*)base;
    int count = InterlockedDecrement(&((cfx_focus_handler_t*)ptr)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_focus_handler_t*)ptr)->gc_handle);
        free(ptr);
    }
    return count;
}
int CEF_CALLBACK _cfx_focus_handler_get_refct(struct _cef_base_t* base) {
    cfx_focus_handler_t* ptr = (cfx_focus_handler_t*)base;
    return ptr->ref_count;
}

CFX_EXPORT cfx_focus_handler_t* cfx_focus_handler_ctor(gc_handle_t gc_handle) {
    cfx_focus_handler_t* ptr = (cfx_focus_handler_t*)calloc(1, sizeof(cfx_focus_handler_t));
    if(!ptr) return 0;
    ptr->cef_focus_handler.base.size = sizeof(cef_focus_handler_t);
    ptr->cef_focus_handler.base.add_ref = _cfx_focus_handler_add_ref;
    ptr->cef_focus_handler.base.release = _cfx_focus_handler_release;
    ptr->cef_focus_handler.base.get_refct = _cfx_focus_handler_get_refct;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

CFX_EXPORT gc_handle_t cfx_focus_handler_get_gc_handle(cfx_focus_handler_t* self) {
    return self->gc_handle;
}

// on_take_focus

void (CEF_CALLBACK *cfx_focus_handler_on_take_focus_callback)(gc_handle_t self, cef_browser_t* browser, int next);

void CEF_CALLBACK cfx_focus_handler_on_take_focus(cef_focus_handler_t* self, cef_browser_t* browser, int next) {
    cfx_focus_handler_on_take_focus_callback(((cfx_focus_handler_t*)self)->gc_handle, browser, next);
}


// on_set_focus

void (CEF_CALLBACK *cfx_focus_handler_on_set_focus_callback)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_focus_source_t source);

int CEF_CALLBACK cfx_focus_handler_on_set_focus(cef_focus_handler_t* self, cef_browser_t* browser, cef_focus_source_t source) {
    int __retval;
    cfx_focus_handler_on_set_focus_callback(((cfx_focus_handler_t*)self)->gc_handle, &__retval, browser, source);
    return __retval;
}


// on_got_focus

void (CEF_CALLBACK *cfx_focus_handler_on_got_focus_callback)(gc_handle_t self, cef_browser_t* browser);

void CEF_CALLBACK cfx_focus_handler_on_got_focus(cef_focus_handler_t* self, cef_browser_t* browser) {
    cfx_focus_handler_on_got_focus_callback(((cfx_focus_handler_t*)self)->gc_handle, browser);
}


CFX_EXPORT void cfx_focus_handler_activate_callback(cef_focus_handler_t* self, int index, int is_active) {
    switch(index) {
    case 0:
        self->on_take_focus = is_active ? cfx_focus_handler_on_take_focus : 0;
        break;
    case 1:
        self->on_set_focus = is_active ? cfx_focus_handler_on_set_focus : 0;
        break;
    case 2:
        self->on_got_focus = is_active ? cfx_focus_handler_on_got_focus : 0;
        break;
    }
}
CFX_EXPORT void cfx_focus_handler_set_callback_ptrs(void *cb_0, void *cb_1, void *cb_2) {
    cfx_focus_handler_on_take_focus_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser, int next)) cb_0;
    cfx_focus_handler_on_set_focus_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, cef_browser_t* browser, cef_focus_source_t source)) cb_1;
    cfx_focus_handler_on_got_focus_callback = (void (CEF_CALLBACK *)(gc_handle_t self, cef_browser_t* browser)) cb_2;
}

#ifdef __cplusplus
} // extern "C"
#endif

