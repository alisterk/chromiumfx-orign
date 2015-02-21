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


// cef_v8handler

#ifdef __cplusplus
extern "C" {
#endif

typedef struct _cfx_v8handler_t {
    cef_v8handler_t cef_v8handler;
    unsigned int ref_count;
    gc_handle_t gc_handle;
} cfx_v8handler_t;

int CEF_CALLBACK _cfx_v8handler_add_ref(struct _cef_base_t* base) {
    cfx_v8handler_t* ptr = (cfx_v8handler_t*)base;
    return InterlockedIncrement(&ptr->ref_count);
}
int CEF_CALLBACK _cfx_v8handler_release(struct _cef_base_t* base) {
    cfx_v8handler_t* ptr = (cfx_v8handler_t*)base;
    int count = InterlockedDecrement(&((cfx_v8handler_t*)ptr)->ref_count);
    if(!count) {
        cfx_gc_handle_free(((cfx_v8handler_t*)ptr)->gc_handle);
        free(ptr);
    }
    return count;
}
int CEF_CALLBACK _cfx_v8handler_get_refct(struct _cef_base_t* base) {
    cfx_v8handler_t* ptr = (cfx_v8handler_t*)base;
    return ptr->ref_count;
}

CFX_EXPORT cfx_v8handler_t* cfx_v8handler_ctor(gc_handle_t gc_handle) {
    cfx_v8handler_t* ptr = (cfx_v8handler_t*)calloc(1, sizeof(cfx_v8handler_t));
    if(!ptr) return 0;
    ptr->cef_v8handler.base.size = sizeof(cef_v8handler_t);
    ptr->cef_v8handler.base.add_ref = _cfx_v8handler_add_ref;
    ptr->cef_v8handler.base.release = _cfx_v8handler_release;
    ptr->cef_v8handler.base.get_refct = _cfx_v8handler_get_refct;
    ptr->ref_count = 1;
    ptr->gc_handle = gc_handle;
    return ptr;
}

CFX_EXPORT gc_handle_t cfx_v8handler_get_gc_handle(cfx_v8handler_t* self) {
    return self->gc_handle;
}

// execute

void (CEF_CALLBACK *cfx_v8handler_execute_callback)(gc_handle_t self, int* __retval, char16 *name_str, int name_length, cef_v8value_t* object, int argumentsCount, cef_v8value_t* const* arguments, cef_v8value_t** retval, char16 **exception_str, int *exception_length);

int CEF_CALLBACK cfx_v8handler_execute(cef_v8handler_t* self, const cef_string_t* name, cef_v8value_t* object, size_t argumentsCount, cef_v8value_t* const* arguments, cef_v8value_t** retval, cef_string_t* exception) {
    int __retval;
    char16* exception_tmp_str = exception->str; int exception_tmp_length = exception->length;
    cfx_v8handler_execute_callback(((cfx_v8handler_t*)self)->gc_handle, &__retval, name ? name->str : 0, name ? name->length : 0, object, (int)(argumentsCount), arguments, retval, &(exception_tmp_str), &(exception_tmp_length));
    if(*retval)((cef_base_t*)*retval)->add_ref((cef_base_t*)*retval);
    if(exception_tmp_str != exception->str) {
        if(exception->dtor) exception->dtor(exception->str);
        cef_string_set(exception_tmp_str, exception_tmp_length, exception, 1);
        cfx_gc_handle_free((gc_handle_t)exception_tmp_str);
    }
    return __retval;
}


CFX_EXPORT void cfx_v8handler_activate_callback(cef_v8handler_t* self, int index, int is_active) {
    switch(index) {
    case 0:
        self->execute = is_active ? cfx_v8handler_execute : 0;
        break;
    }
}
CFX_EXPORT void cfx_v8handler_set_callback_ptrs(void *cb_0) {
    cfx_v8handler_execute_callback = (void (CEF_CALLBACK *)(gc_handle_t self, int* __retval, char16 *name_str, int name_length, cef_v8value_t* object, int argumentsCount, cef_v8value_t* const* arguments, cef_v8value_t** retval, char16 **exception_str, int *exception_length)) cb_0;
}

#ifdef __cplusplus
} // extern "C"
#endif

