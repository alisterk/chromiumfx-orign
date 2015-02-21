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
    /// Structure the client can implement to provide a custom stream reader. The
    /// functions of this structure may be called on any thread.
    /// </summary>
    public class CfxReadHandler : CfxBase {

        internal static CfxReadHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_read_handler_get_gc_handle(nativePtr);
            return (CfxReadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void read(IntPtr gcHandlePtr, out int __retval, IntPtr ptr, int size, int n) {
            var self = (CfxReadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxReadEventArgs(ptr, size, n);
            var eventHandler = self.m_Read;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue;
        }

        internal static void seek(IntPtr gcHandlePtr, out int __retval, long offset, int whence) {
            var self = (CfxReadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxSeekEventArgs(offset, whence);
            var eventHandler = self.m_Seek;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue;
        }

        internal static void tell(IntPtr gcHandlePtr, out long __retval) {
            var self = (CfxReadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(long);
                return;
            }
            var e = new CfxTellEventArgs();
            var eventHandler = self.m_Tell;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue;
        }

        internal static void eof(IntPtr gcHandlePtr, out int __retval) {
            var self = (CfxReadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxReadHandlerEofEventArgs();
            var eventHandler = self.m_Eof;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue;
        }

        internal static void may_block(IntPtr gcHandlePtr, out int __retval) {
            var self = (CfxReadHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxMayBlockEventArgs();
            var eventHandler = self.m_MayBlock;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxReadHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxReadHandler() : base(CfxApi.cfx_read_handler_ctor) {}

        /// <summary>
        /// Read raw binary data.
        /// </summary>
        public event CfxReadEventHandler Read {
            add {
                if(m_Read == null) {
                    CfxApi.cfx_read_handler_activate_callback(NativePtr, 0, 1);
                }
                m_Read += value;
            }
            remove {
                m_Read -= value;
                if(m_Read == null) {
                    CfxApi.cfx_read_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxReadEventHandler m_Read;

        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of SEEK_CUR,
        /// SEEK_END or SEEK_SET. Return zero on success and non-zero on failure.
        /// </summary>
        public event CfxSeekEventHandler Seek {
            add {
                if(m_Seek == null) {
                    CfxApi.cfx_read_handler_activate_callback(NativePtr, 1, 1);
                }
                m_Seek += value;
            }
            remove {
                m_Seek -= value;
                if(m_Seek == null) {
                    CfxApi.cfx_read_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxSeekEventHandler m_Seek;

        /// <summary>
        /// Return the current offset position.
        /// </summary>
        public event CfxTellEventHandler Tell {
            add {
                if(m_Tell == null) {
                    CfxApi.cfx_read_handler_activate_callback(NativePtr, 2, 1);
                }
                m_Tell += value;
            }
            remove {
                m_Tell -= value;
                if(m_Tell == null) {
                    CfxApi.cfx_read_handler_activate_callback(NativePtr, 2, 0);
                }
            }
        }

        private CfxTellEventHandler m_Tell;

        /// <summary>
        /// Return non-zero if at end of file.
        /// </summary>
        public event CfxReadHandlerEofEventHandler Eof {
            add {
                if(m_Eof == null) {
                    CfxApi.cfx_read_handler_activate_callback(NativePtr, 3, 1);
                }
                m_Eof += value;
            }
            remove {
                m_Eof -= value;
                if(m_Eof == null) {
                    CfxApi.cfx_read_handler_activate_callback(NativePtr, 3, 0);
                }
            }
        }

        private CfxReadHandlerEofEventHandler m_Eof;

        /// <summary>
        /// Return true (1) if this handler performs work like accessing the file
        /// system which may block. Used as a hint for determining the thread to access
        /// the handler from.
        /// </summary>
        public event CfxMayBlockEventHandler MayBlock {
            add {
                if(m_MayBlock == null) {
                    CfxApi.cfx_read_handler_activate_callback(NativePtr, 4, 1);
                }
                m_MayBlock += value;
            }
            remove {
                m_MayBlock -= value;
                if(m_MayBlock == null) {
                    CfxApi.cfx_read_handler_activate_callback(NativePtr, 4, 0);
                }
            }
        }

        private CfxMayBlockEventHandler m_MayBlock;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_Read != null) {
                m_Read = null;
                CfxApi.cfx_read_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_Seek != null) {
                m_Seek = null;
                CfxApi.cfx_read_handler_activate_callback(NativePtr, 1, 0);
            }
            if(m_Tell != null) {
                m_Tell = null;
                CfxApi.cfx_read_handler_activate_callback(NativePtr, 2, 0);
            }
            if(m_Eof != null) {
                m_Eof = null;
                CfxApi.cfx_read_handler_activate_callback(NativePtr, 3, 0);
            }
            if(m_MayBlock != null) {
                m_MayBlock = null;
                CfxApi.cfx_read_handler_activate_callback(NativePtr, 4, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    public delegate void CfxReadEventHandler(object sender, CfxReadEventArgs e);

    /// <summary>
    /// Read raw binary data.
    /// </summary>
    public class CfxReadEventArgs : CfxEventArgs {

        internal IntPtr m_ptr;
        internal int m_size;
        internal int m_n;

        internal int m_returnValue;
        private bool returnValueSet;

        internal CfxReadEventArgs(IntPtr ptr, int size, int n) {
            m_ptr = ptr;
            m_size = size;
            m_n = n;
        }

        public IntPtr Ptr {
            get {
                CheckAccess();
                return m_ptr;
            }
        }
        public int Size {
            get {
                CheckAccess();
                return m_size;
            }
        }
        public int N {
            get {
                CheckAccess();
                return m_n;
            }
        }
        public void SetReturnValue(int returnValue) {
            CheckAccess();
            if(returnValueSet) {
                throw new CfxException("The return value has already been set");
            }
            returnValueSet = true;
            this.m_returnValue = returnValue;
        }

        public override string ToString() {
            return String.Format("Ptr={{{0}}}, Size={{{1}}}, N={{{2}}}", Ptr, Size, N);
        }
    }

    public delegate void CfxSeekEventHandler(object sender, CfxSeekEventArgs e);

    /// <summary>
    /// Seek to the specified offset position. |whence| may be any one of SEEK_CUR,
    /// SEEK_END or SEEK_SET. Return zero on success and non-zero on failure.
    /// </summary>
    public class CfxSeekEventArgs : CfxEventArgs {

        internal long m_offset;
        internal int m_whence;

        internal int m_returnValue;
        private bool returnValueSet;

        internal CfxSeekEventArgs(long offset, int whence) {
            m_offset = offset;
            m_whence = whence;
        }

        public long Offset {
            get {
                CheckAccess();
                return m_offset;
            }
        }
        public int Whence {
            get {
                CheckAccess();
                return m_whence;
            }
        }
        public void SetReturnValue(int returnValue) {
            CheckAccess();
            if(returnValueSet) {
                throw new CfxException("The return value has already been set");
            }
            returnValueSet = true;
            this.m_returnValue = returnValue;
        }

        public override string ToString() {
            return String.Format("Offset={{{0}}}, Whence={{{1}}}", Offset, Whence);
        }
    }

    public delegate void CfxTellEventHandler(object sender, CfxTellEventArgs e);

    /// <summary>
    /// Return the current offset position.
    /// </summary>
    public class CfxTellEventArgs : CfxEventArgs {


        internal long m_returnValue;
        private bool returnValueSet;

        internal CfxTellEventArgs() {
        }

        public void SetReturnValue(long returnValue) {
            CheckAccess();
            if(returnValueSet) {
                throw new CfxException("The return value has already been set");
            }
            returnValueSet = true;
            this.m_returnValue = returnValue;
        }
    }

    public delegate void CfxReadHandlerEofEventHandler(object sender, CfxReadHandlerEofEventArgs e);

    /// <summary>
    /// Return non-zero if at end of file.
    /// </summary>
    public class CfxReadHandlerEofEventArgs : CfxEventArgs {


        internal int m_returnValue;
        private bool returnValueSet;

        internal CfxReadHandlerEofEventArgs() {
        }

        public void SetReturnValue(int returnValue) {
            CheckAccess();
            if(returnValueSet) {
                throw new CfxException("The return value has already been set");
            }
            returnValueSet = true;
            this.m_returnValue = returnValue;
        }
    }

    public delegate void CfxMayBlockEventHandler(object sender, CfxMayBlockEventArgs e);

    /// <summary>
    /// Return true (1) if this handler performs work like accessing the file
    /// system which may block. Used as a hint for determining the thread to access
    /// the handler from.
    /// </summary>
    public class CfxMayBlockEventArgs : CfxEventArgs {


        internal bool m_returnValue;
        private bool returnValueSet;

        internal CfxMayBlockEventArgs() {
        }

        public void SetReturnValue(bool returnValue) {
            CheckAccess();
            if(returnValueSet) {
                throw new CfxException("The return value has already been set");
            }
            returnValueSet = true;
            this.m_returnValue = returnValue;
        }
    }

}
