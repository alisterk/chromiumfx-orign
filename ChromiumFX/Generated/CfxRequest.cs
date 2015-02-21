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


using System;

namespace Chromium {
    /// <summary>
    /// Structure used to represent a web request. The functions of this structure
    /// may be called on any thread.
    /// </summary>
    public class CfxRequest : CfxBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxRequest Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxRequest)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxRequest(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxRequest(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Create a new cef_request_t object.
        /// </summary>
        public static CfxRequest Create() {
            return CfxRequest.Wrap(CfxApi.cfx_request_create());
        }

        /// <summary>
        /// Returns true (1) if this object is read-only.
        /// </summary>
        public bool IsReadOnly {
            get {
                return 0 != CfxApi.cfx_request_is_read_only(NativePtr);
            }
        }

        /// <summary>
        /// Get the fully qualified URL.
        /// 
        /// Set the fully qualified URL.
        /// </summary>
        public String Url {
            get {
                return StringUserfree.Convert(CfxApi.cfx_request_get_url(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_request_set_url(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Get the request function type. The value will default to POST if post data
        /// is provided and GET otherwise.
        /// 
        /// Set the request function type.
        /// </summary>
        public String Method {
            get {
                return StringUserfree.Convert(CfxApi.cfx_request_get_method(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_request_set_method(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Get the post data.
        /// 
        /// Set the post data.
        /// </summary>
        public CfxPostData PostData {
            get {
                return CfxPostData.Wrap(CfxApi.cfx_request_get_post_data(NativePtr));
            }
            set {
                CfxApi.cfx_request_set_post_data(NativePtr, CfxPostData.Unwrap(value));
            }
        }

        /// <summary>
        /// Get the flags used in combination with cef_urlrequest_t. See
        /// cef_urlrequest_flags_t for supported values.
        /// 
        /// Set the flags used in combination with cef_urlrequest_t.  See
        /// cef_urlrequest_flags_t for supported values.
        /// </summary>
        public int Flags {
            get {
                return CfxApi.cfx_request_get_flags(NativePtr);
            }
            set {
                CfxApi.cfx_request_set_flags(NativePtr, value);
            }
        }

        /// <summary>
        /// Set the URL to the first party for cookies used in combination with
        /// cef_urlrequest_t.
        /// 
        /// Get the URL to the first party for cookies used in combination with
        /// cef_urlrequest_t.
        /// </summary>
        public String FirstPartyForCookies {
            get {
                return StringUserfree.Convert(CfxApi.cfx_request_get_first_party_for_cookies(NativePtr));
            }
            set {
                var value_pinned = new PinnedString(value);
                CfxApi.cfx_request_set_first_party_for_cookies(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
                value_pinned.Obj.Free();
            }
        }

        /// <summary>
        /// Get the resource type for this request. Accurate resource type information
        /// may only be available in the browser process.
        /// </summary>
        public CfxResourceType ResourceType {
            get {
                return CfxApi.cfx_request_get_resource_type(NativePtr);
            }
        }

        /// <summary>
        /// Get the transition type for this request. Only available in the browser
        /// process and only applies to requests that represent a main frame or sub-
        /// frame navigation.
        /// </summary>
        public CfxTransitionType TransitionType {
            get {
                return CfxApi.cfx_request_get_transition_type(NativePtr);
            }
        }

        /// <summary>
        /// Get the header values.
        /// </summary>
        public void GetHeaderMap(System.Collections.Generic.List<string[]> headerMap) {
            PinnedString[] headerMap_handles;
            var headerMap_unwrapped = CfxStringCollections.UnwrapCfxStringMultimap(headerMap, out headerMap_handles);
            CfxApi.cfx_request_get_header_map(NativePtr, headerMap_unwrapped);
            CfxStringCollections.FreePinnedStrings(headerMap_handles);
            CfxStringCollections.CfxStringMultimapCopyToManaged(headerMap_unwrapped, headerMap);
            CfxApi.cfx_string_multimap_free(headerMap_unwrapped);
        }

        /// <summary>
        /// Set the header values.
        /// </summary>
        public void SetHeaderMap(System.Collections.Generic.List<string[]> headerMap) {
            PinnedString[] headerMap_handles;
            var headerMap_unwrapped = CfxStringCollections.UnwrapCfxStringMultimap(headerMap, out headerMap_handles);
            CfxApi.cfx_request_set_header_map(NativePtr, headerMap_unwrapped);
            CfxStringCollections.FreePinnedStrings(headerMap_handles);
            CfxStringCollections.CfxStringMultimapCopyToManaged(headerMap_unwrapped, headerMap);
            CfxApi.cfx_string_multimap_free(headerMap_unwrapped);
        }

        /// <summary>
        /// Set all values at one time.
        /// </summary>
        public void Set(string url, string method, CfxPostData postData, System.Collections.Generic.List<string[]> headerMap) {
            var url_pinned = new PinnedString(url);
            var method_pinned = new PinnedString(method);
            PinnedString[] headerMap_handles;
            var headerMap_unwrapped = CfxStringCollections.UnwrapCfxStringMultimap(headerMap, out headerMap_handles);
            CfxApi.cfx_request_set(NativePtr, url_pinned.Obj.PinnedPtr, url_pinned.Length, method_pinned.Obj.PinnedPtr, method_pinned.Length, CfxPostData.Unwrap(postData), headerMap_unwrapped);
            url_pinned.Obj.Free();
            method_pinned.Obj.Free();
            CfxStringCollections.FreePinnedStrings(headerMap_handles);
            CfxStringCollections.CfxStringMultimapCopyToManaged(headerMap_unwrapped, headerMap);
            CfxApi.cfx_string_multimap_free(headerMap_unwrapped);
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
