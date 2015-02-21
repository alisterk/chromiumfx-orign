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
    /// Structure used to represent a DOM node. The functions of this structure
    /// should only be called on the render process main thread.
    /// </summary>
    public class CfxDomNode : CfxBase {

        private static readonly WeakCache weakCache = new WeakCache();

        internal static CfxDomNode Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            lock(weakCache) {
                var wrapper = (CfxDomNode)weakCache.Get(nativePtr);
                if(wrapper == null) {
                    wrapper = new CfxDomNode(nativePtr);
                    weakCache.Add(wrapper);
                } else {
                    CfxApi.cfx_release(nativePtr);
                }
                return wrapper;
            }
        }


        internal CfxDomNode(IntPtr nativePtr) : base(nativePtr) {}

        /// <summary>
        /// Returns the type for this node.
        /// </summary>
        public CfxDomNodeType Type {
            get {
                return CfxApi.cfx_domnode_get_type(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if this is a text node.
        /// </summary>
        public bool IsText {
            get {
                return 0 != CfxApi.cfx_domnode_is_text(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if this is an element node.
        /// </summary>
        public bool IsElement {
            get {
                return 0 != CfxApi.cfx_domnode_is_element(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if this is an editable node.
        /// </summary>
        public bool IsEditable {
            get {
                return 0 != CfxApi.cfx_domnode_is_editable(NativePtr);
            }
        }

        /// <summary>
        /// Returns true (1) if this is a form control element node.
        /// </summary>
        public bool IsFormControlElement {
            get {
                return 0 != CfxApi.cfx_domnode_is_form_control_element(NativePtr);
            }
        }

        /// <summary>
        /// Returns the type of this form control element node.
        /// </summary>
        public String FormControlElementType {
            get {
                return StringUserfree.Convert(CfxApi.cfx_domnode_get_form_control_element_type(NativePtr));
            }
        }

        /// <summary>
        /// Returns the name of this node.
        /// </summary>
        public String Name {
            get {
                return StringUserfree.Convert(CfxApi.cfx_domnode_get_name(NativePtr));
            }
        }

        /// <summary>
        /// Returns the value of this node.
        /// </summary>
        public String Value {
            get {
                return StringUserfree.Convert(CfxApi.cfx_domnode_get_value(NativePtr));
            }
        }

        /// <summary>
        /// Returns the contents of this node as markup.
        /// </summary>
        public String AsMarkup {
            get {
                return StringUserfree.Convert(CfxApi.cfx_domnode_get_as_markup(NativePtr));
            }
        }

        /// <summary>
        /// Returns the document associated with this node.
        /// </summary>
        public CfxDomDocument Document {
            get {
                return CfxDomDocument.Wrap(CfxApi.cfx_domnode_get_document(NativePtr));
            }
        }

        /// <summary>
        /// Returns the parent node.
        /// </summary>
        public CfxDomNode Parent {
            get {
                return CfxDomNode.Wrap(CfxApi.cfx_domnode_get_parent(NativePtr));
            }
        }

        /// <summary>
        /// Returns the previous sibling node.
        /// </summary>
        public CfxDomNode PreviousSibling {
            get {
                return CfxDomNode.Wrap(CfxApi.cfx_domnode_get_previous_sibling(NativePtr));
            }
        }

        /// <summary>
        /// Returns the next sibling node.
        /// </summary>
        public CfxDomNode NextSibling {
            get {
                return CfxDomNode.Wrap(CfxApi.cfx_domnode_get_next_sibling(NativePtr));
            }
        }

        /// <summary>
        /// Returns true (1) if this node has child nodes.
        /// </summary>
        public bool HasChildren {
            get {
                return 0 != CfxApi.cfx_domnode_has_children(NativePtr);
            }
        }

        /// <summary>
        /// Return the first child node.
        /// </summary>
        public CfxDomNode FirstChild {
            get {
                return CfxDomNode.Wrap(CfxApi.cfx_domnode_get_first_child(NativePtr));
            }
        }

        /// <summary>
        /// Returns the last child node.
        /// </summary>
        public CfxDomNode LastChild {
            get {
                return CfxDomNode.Wrap(CfxApi.cfx_domnode_get_last_child(NativePtr));
            }
        }

        /// <summary>
        /// The following functions are valid only for element nodes.
        /// Returns the tag name of this element.
        /// </summary>
        public String ElementTagName {
            get {
                return StringUserfree.Convert(CfxApi.cfx_domnode_get_element_tag_name(NativePtr));
            }
        }

        /// <summary>
        /// Returns true (1) if this element has attributes.
        /// </summary>
        public bool HasElementAttributes {
            get {
                return 0 != CfxApi.cfx_domnode_has_element_attributes(NativePtr);
            }
        }

        /// <summary>
        /// Returns the inner text of the element.
        /// </summary>
        public String ElementInnerText {
            get {
                return StringUserfree.Convert(CfxApi.cfx_domnode_get_element_inner_text(NativePtr));
            }
        }

        /// <summary>
        /// Returns true (1) if this object is pointing to the same handle as |that|
        /// object.
        /// </summary>
        public bool IsSame(CfxDomNode that) {
            return 0 != CfxApi.cfx_domnode_is_same(NativePtr, CfxDomNode.Unwrap(that));
        }

        /// <summary>
        /// Set the value of this node. Returns true (1) on success.
        /// </summary>
        public bool SetValue(string value) {
            var value_pinned = new PinnedString(value);
            var __retval = CfxApi.cfx_domnode_set_value(NativePtr, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            value_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Add an event listener to this node for the specified event type. If
        /// |useCapture| is true (1) then this listener will be considered a capturing
        /// listener. Capturing listeners will recieve all events of the specified type
        /// before the events are dispatched to any other event targets beneath the
        /// current node in the tree. Events which are bubbling upwards through the
        /// tree will not trigger a capturing listener. Separate calls to this function
        /// can be used to register the same listener with and without capture. See
        /// WebCore/dom/EventNames.h for the list of supported event types.
        /// </summary>
        public void AddEventListener(string eventType, CfxDomEventListener listener, bool useCapture) {
            var eventType_pinned = new PinnedString(eventType);
            CfxApi.cfx_domnode_add_event_listener(NativePtr, eventType_pinned.Obj.PinnedPtr, eventType_pinned.Length, CfxDomEventListener.Unwrap(listener), useCapture ? 1 : 0);
            eventType_pinned.Obj.Free();
        }

        /// <summary>
        /// Returns true (1) if this element has an attribute named |attrName|.
        /// </summary>
        public bool HasElementAttribute(string attrName) {
            var attrName_pinned = new PinnedString(attrName);
            var __retval = CfxApi.cfx_domnode_has_element_attribute(NativePtr, attrName_pinned.Obj.PinnedPtr, attrName_pinned.Length);
            attrName_pinned.Obj.Free();
            return 0 != __retval;
        }

        /// <summary>
        /// Returns the element attribute named |attrName|.
        /// </summary>
        public String GetElementAttribute(string attrName) {
            var attrName_pinned = new PinnedString(attrName);
            var __retval = CfxApi.cfx_domnode_get_element_attribute(NativePtr, attrName_pinned.Obj.PinnedPtr, attrName_pinned.Length);
            attrName_pinned.Obj.Free();
            return StringUserfree.Convert(__retval);
        }

        /// <summary>
        /// Returns a map of all element attributes.
        /// </summary>
        public void GetElementAttributes(System.Collections.Generic.List<string[]> attrMap) {
            PinnedString[] attrMap_handles;
            var attrMap_unwrapped = CfxStringCollections.UnwrapCfxStringMap(attrMap, out attrMap_handles);
            CfxApi.cfx_domnode_get_element_attributes(NativePtr, attrMap_unwrapped);
            CfxStringCollections.FreePinnedStrings(attrMap_handles);
            CfxStringCollections.CfxStringMapCopyToManaged(attrMap_unwrapped, attrMap);
            CfxApi.cfx_string_map_free(attrMap_unwrapped);
        }

        /// <summary>
        /// Set the value for the element attribute named |attrName|. Returns true (1)
        /// on success.
        /// </summary>
        public bool SetElementAttribute(string attrName, string value) {
            var attrName_pinned = new PinnedString(attrName);
            var value_pinned = new PinnedString(value);
            var __retval = CfxApi.cfx_domnode_set_element_attribute(NativePtr, attrName_pinned.Obj.PinnedPtr, attrName_pinned.Length, value_pinned.Obj.PinnedPtr, value_pinned.Length);
            attrName_pinned.Obj.Free();
            value_pinned.Obj.Free();
            return 0 != __retval;
        }

        internal override void OnDispose(IntPtr nativePtr) {
            weakCache.Remove(nativePtr);
            base.OnDispose(nativePtr);
        }
    }
}
