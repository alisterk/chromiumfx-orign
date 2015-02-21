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


// cef_domevent

#ifdef __cplusplus
extern "C" {
#endif

// cef_base_t base

// get_type
CFX_EXPORT cef_string_userfree_t cfx_domevent_get_type(cef_domevent_t* self) {
    return self->get_type(self);
}

// get_category
CFX_EXPORT cef_dom_event_category_t cfx_domevent_get_category(cef_domevent_t* self) {
    return self->get_category(self);
}

// get_phase
CFX_EXPORT cef_dom_event_phase_t cfx_domevent_get_phase(cef_domevent_t* self) {
    return self->get_phase(self);
}

// can_bubble
CFX_EXPORT int cfx_domevent_can_bubble(cef_domevent_t* self) {
    return self->can_bubble(self);
}

// can_cancel
CFX_EXPORT int cfx_domevent_can_cancel(cef_domevent_t* self) {
    return self->can_cancel(self);
}

// get_document
CFX_EXPORT cef_domdocument_t* cfx_domevent_get_document(cef_domevent_t* self) {
    return self->get_document(self);
}

// get_target
CFX_EXPORT cef_domnode_t* cfx_domevent_get_target(cef_domevent_t* self) {
    return self->get_target(self);
}

// get_current_target
CFX_EXPORT cef_domnode_t* cfx_domevent_get_current_target(cef_domevent_t* self) {
    return self->get_current_target(self);
}


#ifdef __cplusplus
} // extern "C"
#endif

