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

namespace Chromium.Remote {
    /// <summary>
    /// Structure used to implement render process callbacks. The functions of this
    /// structure will be called on the render process main thread (TID_RENDERER)
    /// unless otherwise indicated.
    /// </summary>
    public class CfrRenderProcessHandler : CfrBase {

        private static readonly RemoteWeakCache weakCache = new RemoteWeakCache();

        internal static CfrRenderProcessHandler Wrap(ulong proxyId, CfrRuntime remoteRuntime) {
            if(proxyId == 0) return null;
            lock(weakCache) {
                var cfrObj = (CfrRenderProcessHandler)weakCache.Get(remoteRuntime, proxyId);
                if(cfrObj == null) {
                    cfrObj = new CfrRenderProcessHandler(proxyId, remoteRuntime);
                    weakCache.Add(remoteRuntime, proxyId, cfrObj);
                }
                return cfrObj;
            }
        }


        internal static ulong CreateRemote(CfrRuntime remoteRuntime) {
            var call = new CfxRenderProcessHandlerCtorRenderProcessCall();
            call.Execute(remoteRuntime.connection);
            return call.__retval;
        }

        internal void raise_OnRenderThreadCreated(object sender, CfrOnRenderThreadCreatedEventArgs e) {
            var handler = m_OnRenderThreadCreated;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnWebKitInitialized(object sender, CfrEventArgs e) {
            var handler = m_OnWebKitInitialized;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnBrowserCreated(object sender, CfrOnBrowserCreatedEventArgs e) {
            var handler = m_OnBrowserCreated;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnBrowserDestroyed(object sender, CfrOnBrowserDestroyedEventArgs e) {
            var handler = m_OnBrowserDestroyed;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_GetLoadHandler(object sender, CfrGetLoadHandlerEventArgs e) {
            var handler = m_GetLoadHandler;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnBeforeNavigation(object sender, CfrOnBeforeNavigationEventArgs e) {
            var handler = m_OnBeforeNavigation;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnContextCreated(object sender, CfrOnContextCreatedEventArgs e) {
            var handler = m_OnContextCreated;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnContextReleased(object sender, CfrOnContextReleasedEventArgs e) {
            var handler = m_OnContextReleased;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnUncaughtException(object sender, CfrOnUncaughtExceptionEventArgs e) {
            var handler = m_OnUncaughtException;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnFocusedNodeChanged(object sender, CfrOnFocusedNodeChangedEventArgs e) {
            var handler = m_OnFocusedNodeChanged;
            if(handler == null) return;
            handler(this, e);
        }

        internal void raise_OnProcessMessageReceived(object sender, CfrOnProcessMessageReceivedEventArgs e) {
            var handler = m_OnProcessMessageReceived;
            if(handler == null) return;
            handler(this, e);
        }


        private CfrRenderProcessHandler(ulong proxyId, CfrRuntime remoteRuntime) : base(proxyId, remoteRuntime) {}
        public CfrRenderProcessHandler(CfrRuntime remoteRuntime) : base(CreateRemote(remoteRuntime), remoteRuntime) {
            weakCache.Add(remoteRuntime, this.proxyId, this);
        }

        /// <summary>
        /// Called after the render process main thread has been created. |extra_info|
        /// is a read-only value originating from
        /// cef_browser_process_handler_t::on_render_process_thread_created(). Do not
        /// keep a reference to |extra_info| outside of this function.
        /// </summary>
        public event CfrOnRenderThreadCreatedEventHandler OnRenderThreadCreated {
            add {
                if(m_OnRenderThreadCreated == null) {
                    var call = new CfxOnRenderThreadCreatedActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnRenderThreadCreated += value;
            }
            remove {
                m_OnRenderThreadCreated -= value;
                if(m_OnRenderThreadCreated == null) {
                    var call = new CfxOnRenderThreadCreatedDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnRenderThreadCreatedEventHandler m_OnRenderThreadCreated;


        /// <summary>
        /// Called after WebKit has been initialized.
        /// </summary>
        public event CfrEventHandler OnWebKitInitialized {
            add {
                if(m_OnWebKitInitialized == null) {
                    var call = new CfxOnWebKitInitializedActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnWebKitInitialized += value;
            }
            remove {
                m_OnWebKitInitialized -= value;
                if(m_OnWebKitInitialized == null) {
                    var call = new CfxOnWebKitInitializedDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrEventHandler m_OnWebKitInitialized;


        /// <summary>
        /// Called after a browser has been created. When browsing cross-origin a new
        /// browser will be created before the old browser with the same identifier is
        /// destroyed.
        /// </summary>
        public event CfrOnBrowserCreatedEventHandler OnBrowserCreated {
            add {
                if(m_OnBrowserCreated == null) {
                    var call = new CfxOnBrowserCreatedActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnBrowserCreated += value;
            }
            remove {
                m_OnBrowserCreated -= value;
                if(m_OnBrowserCreated == null) {
                    var call = new CfxOnBrowserCreatedDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnBrowserCreatedEventHandler m_OnBrowserCreated;


        /// <summary>
        /// Called before a browser is destroyed.
        /// </summary>
        public event CfrOnBrowserDestroyedEventHandler OnBrowserDestroyed {
            add {
                if(m_OnBrowserDestroyed == null) {
                    var call = new CfxOnBrowserDestroyedActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnBrowserDestroyed += value;
            }
            remove {
                m_OnBrowserDestroyed -= value;
                if(m_OnBrowserDestroyed == null) {
                    var call = new CfxOnBrowserDestroyedDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnBrowserDestroyedEventHandler m_OnBrowserDestroyed;


        /// <summary>
        /// Return the handler for browser load status events.
        /// </summary>
        public event CfrGetLoadHandlerEventHandler GetLoadHandler {
            add {
                if(m_GetLoadHandler == null) {
                    var call = new CfxGetLoadHandlerActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_GetLoadHandler += value;
            }
            remove {
                m_GetLoadHandler -= value;
                if(m_GetLoadHandler == null) {
                    var call = new CfxGetLoadHandlerDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrGetLoadHandlerEventHandler m_GetLoadHandler;


        /// <summary>
        /// Called before browser navigation. Return true (1) to cancel the navigation
        /// or false (0) to allow the navigation to proceed. The |request| object
        /// cannot be modified in this callback.
        /// </summary>
        public event CfrOnBeforeNavigationEventHandler OnBeforeNavigation {
            add {
                if(m_OnBeforeNavigation == null) {
                    var call = new CfxOnBeforeNavigationActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnBeforeNavigation += value;
            }
            remove {
                m_OnBeforeNavigation -= value;
                if(m_OnBeforeNavigation == null) {
                    var call = new CfxOnBeforeNavigationDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnBeforeNavigationEventHandler m_OnBeforeNavigation;


        /// <summary>
        /// Called immediately after the V8 context for a frame has been created. To
        /// retrieve the JavaScript 'window' object use the
        /// cef_v8context_t::get_global() function. V8 handles can only be accessed
        /// from the thread on which they are created. A task runner for posting tasks
        /// on the associated thread can be retrieved via the
        /// cef_v8context_t::get_task_runner() function.
        /// </summary>
        public event CfrOnContextCreatedEventHandler OnContextCreated {
            add {
                if(m_OnContextCreated == null) {
                    var call = new CfxOnContextCreatedActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnContextCreated += value;
            }
            remove {
                m_OnContextCreated -= value;
                if(m_OnContextCreated == null) {
                    var call = new CfxOnContextCreatedDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnContextCreatedEventHandler m_OnContextCreated;


        /// <summary>
        /// Called immediately before the V8 context for a frame is released. No
        /// references to the context should be kept after this function is called.
        /// </summary>
        public event CfrOnContextReleasedEventHandler OnContextReleased {
            add {
                if(m_OnContextReleased == null) {
                    var call = new CfxOnContextReleasedActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnContextReleased += value;
            }
            remove {
                m_OnContextReleased -= value;
                if(m_OnContextReleased == null) {
                    var call = new CfxOnContextReleasedDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnContextReleasedEventHandler m_OnContextReleased;


        /// <summary>
        /// Called for global uncaught exceptions in a frame. Execution of this
        /// callback is disabled by default. To enable set
        /// CefSettings.uncaught_exception_stack_size > 0.
        /// </summary>
        public event CfrOnUncaughtExceptionEventHandler OnUncaughtException {
            add {
                if(m_OnUncaughtException == null) {
                    var call = new CfxOnUncaughtExceptionActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnUncaughtException += value;
            }
            remove {
                m_OnUncaughtException -= value;
                if(m_OnUncaughtException == null) {
                    var call = new CfxOnUncaughtExceptionDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnUncaughtExceptionEventHandler m_OnUncaughtException;


        /// <summary>
        /// Called when a new node in the the browser gets focus. The |node| value may
        /// be NULL if no specific node has gained focus. The node object passed to
        /// this function represents a snapshot of the DOM at the time this function is
        /// executed. DOM objects are only valid for the scope of this function. Do not
        /// keep references to or attempt to access any DOM objects outside the scope
        /// of this function.
        /// </summary>
        public event CfrOnFocusedNodeChangedEventHandler OnFocusedNodeChanged {
            add {
                if(m_OnFocusedNodeChanged == null) {
                    var call = new CfxOnFocusedNodeChangedActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnFocusedNodeChanged += value;
            }
            remove {
                m_OnFocusedNodeChanged -= value;
                if(m_OnFocusedNodeChanged == null) {
                    var call = new CfxOnFocusedNodeChangedDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnFocusedNodeChangedEventHandler m_OnFocusedNodeChanged;


        /// <summary>
        /// Called when a new message is received from a different process. Return true
        /// (1) if the message was handled or false (0) otherwise. Do not keep a
        /// reference to or attempt to access the message outside of this callback.
        /// </summary>
        public event CfrOnProcessMessageReceivedEventHandler OnProcessMessageReceived {
            add {
                if(m_OnProcessMessageReceived == null) {
                    var call = new CfxOnProcessMessageReceivedActivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
                m_OnProcessMessageReceived += value;
            }
            remove {
                m_OnProcessMessageReceived -= value;
                if(m_OnProcessMessageReceived == null) {
                    var call = new CfxOnProcessMessageReceivedDeactivateRenderProcessCall();
                    call.sender = proxyId;
                    call.Execute(remoteRuntime.connection);
                }
            }
        }

        CfrOnProcessMessageReceivedEventHandler m_OnProcessMessageReceived;


        internal override void OnDispose(ulong proxyId) {
            weakCache.Remove(remoteRuntime, proxyId);
        }
    }


    public delegate void CfrOnRenderThreadCreatedEventHandler(object sender, CfrOnRenderThreadCreatedEventArgs e);

    /// <summary>
    /// Called after the render process main thread has been created. |extra_info|
    /// is a read-only value originating from
    /// cef_browser_process_handler_t::on_render_process_thread_created(). Do not
    /// keep a reference to |extra_info| outside of this function.
    /// </summary>
    public class CfrOnRenderThreadCreatedEventArgs : CfrEventArgs {

        bool ExtraInfoFetched;
        CfrListValue m_ExtraInfo;

        internal CfrOnRenderThreadCreatedEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

        public CfrListValue ExtraInfo {
            get {
                if(!ExtraInfoFetched) {
                    ExtraInfoFetched = true;
                    var call = new CfxOnRenderThreadCreatedGetExtraInfoRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_ExtraInfo = CfrListValue.Wrap(call.value, remoteRuntime);
                }
                return m_ExtraInfo;
            }
        }

        public override string ToString() {
            return String.Format("ExtraInfo={{{0}}}", ExtraInfo);
        }
    }


    public delegate void CfrOnBrowserCreatedEventHandler(object sender, CfrOnBrowserCreatedEventArgs e);

    /// <summary>
    /// Called after a browser has been created. When browsing cross-origin a new
    /// browser will be created before the old browser with the same identifier is
    /// destroyed.
    /// </summary>
    public class CfrOnBrowserCreatedEventArgs : CfrEventArgs {

        bool BrowserFetched;
        CfrBrowser m_Browser;

        internal CfrOnBrowserCreatedEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

        public CfrBrowser Browser {
            get {
                if(!BrowserFetched) {
                    BrowserFetched = true;
                    var call = new CfxOnBrowserCreatedGetBrowserRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                }
                return m_Browser;
            }
        }

        public override string ToString() {
            return String.Format("Browser={{{0}}}", Browser);
        }
    }

    public delegate void CfrOnBrowserDestroyedEventHandler(object sender, CfrOnBrowserDestroyedEventArgs e);

    /// <summary>
    /// Called before a browser is destroyed.
    /// </summary>
    public class CfrOnBrowserDestroyedEventArgs : CfrEventArgs {

        bool BrowserFetched;
        CfrBrowser m_Browser;

        internal CfrOnBrowserDestroyedEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

        public CfrBrowser Browser {
            get {
                if(!BrowserFetched) {
                    BrowserFetched = true;
                    var call = new CfxOnBrowserDestroyedGetBrowserRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                }
                return m_Browser;
            }
        }

        public override string ToString() {
            return String.Format("Browser={{{0}}}", Browser);
        }
    }

    public delegate void CfrGetLoadHandlerEventHandler(object sender, CfrGetLoadHandlerEventArgs e);

    /// <summary>
    /// Return the handler for browser load status events.
    /// </summary>
    public class CfrGetLoadHandlerEventArgs : CfrEventArgs {


        internal CfrGetLoadHandlerEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

        public void SetReturnValue(CfrLoadHandler returnValue) {
            var call = new CfxGetLoadHandlerSetReturnValueRenderProcessCall();
            call.eventArgsId = eventArgsId;
            call.value = CfrObject.Unwrap(returnValue);
            call.Execute(remoteRuntime.connection);
        }
    }

    public delegate void CfrOnBeforeNavigationEventHandler(object sender, CfrOnBeforeNavigationEventArgs e);

    /// <summary>
    /// Called before browser navigation. Return true (1) to cancel the navigation
    /// or false (0) to allow the navigation to proceed. The |request| object
    /// cannot be modified in this callback.
    /// </summary>
    public class CfrOnBeforeNavigationEventArgs : CfrEventArgs {

        bool BrowserFetched;
        CfrBrowser m_Browser;
        bool FrameFetched;
        CfrFrame m_Frame;
        bool RequestFetched;
        CfrRequest m_Request;
        bool NavigationTypeFetched;
        CfxNavigationType m_NavigationType;
        bool IsRedirectFetched;
        bool m_IsRedirect;

        internal CfrOnBeforeNavigationEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

        public CfrBrowser Browser {
            get {
                if(!BrowserFetched) {
                    BrowserFetched = true;
                    var call = new CfxOnBeforeNavigationGetBrowserRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                }
                return m_Browser;
            }
        }
        public CfrFrame Frame {
            get {
                if(!FrameFetched) {
                    FrameFetched = true;
                    var call = new CfxOnBeforeNavigationGetFrameRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Frame = CfrFrame.Wrap(call.value, remoteRuntime);
                }
                return m_Frame;
            }
        }
        public CfrRequest Request {
            get {
                if(!RequestFetched) {
                    RequestFetched = true;
                    var call = new CfxOnBeforeNavigationGetRequestRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Request = CfrRequest.Wrap(call.value, remoteRuntime);
                }
                return m_Request;
            }
        }
        public CfxNavigationType NavigationType {
            get {
                if(!NavigationTypeFetched) {
                    NavigationTypeFetched = true;
                    var call = new CfxOnBeforeNavigationGetNavigationTypeRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_NavigationType = (CfxNavigationType)call.value;
                }
                return m_NavigationType;
            }
        }
        public bool IsRedirect {
            get {
                if(!IsRedirectFetched) {
                    IsRedirectFetched = true;
                    var call = new CfxOnBeforeNavigationGetIsRedirectRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_IsRedirect = call.value;
                }
                return m_IsRedirect;
            }
        }
        public void SetReturnValue(bool returnValue) {
            var call = new CfxOnBeforeNavigationSetReturnValueRenderProcessCall();
            call.eventArgsId = eventArgsId;
            call.value = returnValue;
            call.Execute(remoteRuntime.connection);
        }

        public override string ToString() {
            return String.Format("Browser={{{0}}}, Frame={{{1}}}, Request={{{2}}}, NavigationType={{{3}}}, IsRedirect={{{4}}}", Browser, Frame, Request, NavigationType, IsRedirect);
        }
    }

    public delegate void CfrOnContextCreatedEventHandler(object sender, CfrOnContextCreatedEventArgs e);

    /// <summary>
    /// Called immediately after the V8 context for a frame has been created. To
    /// retrieve the JavaScript 'window' object use the
    /// cef_v8context_t::get_global() function. V8 handles can only be accessed
    /// from the thread on which they are created. A task runner for posting tasks
    /// on the associated thread can be retrieved via the
    /// cef_v8context_t::get_task_runner() function.
    /// </summary>
    public class CfrOnContextCreatedEventArgs : CfrEventArgs {

        bool BrowserFetched;
        CfrBrowser m_Browser;
        bool FrameFetched;
        CfrFrame m_Frame;
        bool ContextFetched;
        CfrV8Context m_Context;

        internal CfrOnContextCreatedEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

        public CfrBrowser Browser {
            get {
                if(!BrowserFetched) {
                    BrowserFetched = true;
                    var call = new CfxOnContextCreatedGetBrowserRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                }
                return m_Browser;
            }
        }
        public CfrFrame Frame {
            get {
                if(!FrameFetched) {
                    FrameFetched = true;
                    var call = new CfxOnContextCreatedGetFrameRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Frame = CfrFrame.Wrap(call.value, remoteRuntime);
                }
                return m_Frame;
            }
        }
        public CfrV8Context Context {
            get {
                if(!ContextFetched) {
                    ContextFetched = true;
                    var call = new CfxOnContextCreatedGetContextRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Context = CfrV8Context.Wrap(call.value, remoteRuntime);
                }
                return m_Context;
            }
        }

        public override string ToString() {
            return String.Format("Browser={{{0}}}, Frame={{{1}}}, Context={{{2}}}", Browser, Frame, Context);
        }
    }

    public delegate void CfrOnContextReleasedEventHandler(object sender, CfrOnContextReleasedEventArgs e);

    /// <summary>
    /// Called immediately before the V8 context for a frame is released. No
    /// references to the context should be kept after this function is called.
    /// </summary>
    public class CfrOnContextReleasedEventArgs : CfrEventArgs {

        bool BrowserFetched;
        CfrBrowser m_Browser;
        bool FrameFetched;
        CfrFrame m_Frame;
        bool ContextFetched;
        CfrV8Context m_Context;

        internal CfrOnContextReleasedEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

        public CfrBrowser Browser {
            get {
                if(!BrowserFetched) {
                    BrowserFetched = true;
                    var call = new CfxOnContextReleasedGetBrowserRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                }
                return m_Browser;
            }
        }
        public CfrFrame Frame {
            get {
                if(!FrameFetched) {
                    FrameFetched = true;
                    var call = new CfxOnContextReleasedGetFrameRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Frame = CfrFrame.Wrap(call.value, remoteRuntime);
                }
                return m_Frame;
            }
        }
        public CfrV8Context Context {
            get {
                if(!ContextFetched) {
                    ContextFetched = true;
                    var call = new CfxOnContextReleasedGetContextRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Context = CfrV8Context.Wrap(call.value, remoteRuntime);
                }
                return m_Context;
            }
        }

        public override string ToString() {
            return String.Format("Browser={{{0}}}, Frame={{{1}}}, Context={{{2}}}", Browser, Frame, Context);
        }
    }

    public delegate void CfrOnUncaughtExceptionEventHandler(object sender, CfrOnUncaughtExceptionEventArgs e);

    /// <summary>
    /// Called for global uncaught exceptions in a frame. Execution of this
    /// callback is disabled by default. To enable set
    /// CefSettings.uncaught_exception_stack_size > 0.
    /// </summary>
    public class CfrOnUncaughtExceptionEventArgs : CfrEventArgs {

        bool BrowserFetched;
        CfrBrowser m_Browser;
        bool FrameFetched;
        CfrFrame m_Frame;
        bool ContextFetched;
        CfrV8Context m_Context;
        bool ExceptionFetched;
        CfrV8Exception m_Exception;
        bool StackTraceFetched;
        CfrV8StackTrace m_StackTrace;

        internal CfrOnUncaughtExceptionEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

        public CfrBrowser Browser {
            get {
                if(!BrowserFetched) {
                    BrowserFetched = true;
                    var call = new CfxOnUncaughtExceptionGetBrowserRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                }
                return m_Browser;
            }
        }
        public CfrFrame Frame {
            get {
                if(!FrameFetched) {
                    FrameFetched = true;
                    var call = new CfxOnUncaughtExceptionGetFrameRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Frame = CfrFrame.Wrap(call.value, remoteRuntime);
                }
                return m_Frame;
            }
        }
        public CfrV8Context Context {
            get {
                if(!ContextFetched) {
                    ContextFetched = true;
                    var call = new CfxOnUncaughtExceptionGetContextRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Context = CfrV8Context.Wrap(call.value, remoteRuntime);
                }
                return m_Context;
            }
        }
        public CfrV8Exception Exception {
            get {
                if(!ExceptionFetched) {
                    ExceptionFetched = true;
                    var call = new CfxOnUncaughtExceptionGetExceptionRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Exception = CfrV8Exception.Wrap(call.value, remoteRuntime);
                }
                return m_Exception;
            }
        }
        public CfrV8StackTrace StackTrace {
            get {
                if(!StackTraceFetched) {
                    StackTraceFetched = true;
                    var call = new CfxOnUncaughtExceptionGetStackTraceRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_StackTrace = CfrV8StackTrace.Wrap(call.value, remoteRuntime);
                }
                return m_StackTrace;
            }
        }

        public override string ToString() {
            return String.Format("Browser={{{0}}}, Frame={{{1}}}, Context={{{2}}}, Exception={{{3}}}, StackTrace={{{4}}}", Browser, Frame, Context, Exception, StackTrace);
        }
    }

    public delegate void CfrOnFocusedNodeChangedEventHandler(object sender, CfrOnFocusedNodeChangedEventArgs e);

    /// <summary>
    /// Called when a new node in the the browser gets focus. The |node| value may
    /// be NULL if no specific node has gained focus. The node object passed to
    /// this function represents a snapshot of the DOM at the time this function is
    /// executed. DOM objects are only valid for the scope of this function. Do not
    /// keep references to or attempt to access any DOM objects outside the scope
    /// of this function.
    /// </summary>
    public class CfrOnFocusedNodeChangedEventArgs : CfrEventArgs {

        bool BrowserFetched;
        CfrBrowser m_Browser;
        bool FrameFetched;
        CfrFrame m_Frame;
        bool NodeFetched;
        CfrDomNode m_Node;

        internal CfrOnFocusedNodeChangedEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

        public CfrBrowser Browser {
            get {
                if(!BrowserFetched) {
                    BrowserFetched = true;
                    var call = new CfxOnFocusedNodeChangedGetBrowserRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                }
                return m_Browser;
            }
        }
        public CfrFrame Frame {
            get {
                if(!FrameFetched) {
                    FrameFetched = true;
                    var call = new CfxOnFocusedNodeChangedGetFrameRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Frame = CfrFrame.Wrap(call.value, remoteRuntime);
                }
                return m_Frame;
            }
        }
        public CfrDomNode Node {
            get {
                if(!NodeFetched) {
                    NodeFetched = true;
                    var call = new CfxOnFocusedNodeChangedGetNodeRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Node = CfrDomNode.Wrap(call.value, remoteRuntime);
                }
                return m_Node;
            }
        }

        public override string ToString() {
            return String.Format("Browser={{{0}}}, Frame={{{1}}}, Node={{{2}}}", Browser, Frame, Node);
        }
    }

    public delegate void CfrOnProcessMessageReceivedEventHandler(object sender, CfrOnProcessMessageReceivedEventArgs e);

    /// <summary>
    /// Called when a new message is received from a different process. Return true
    /// (1) if the message was handled or false (0) otherwise. Do not keep a
    /// reference to or attempt to access the message outside of this callback.
    /// </summary>
    public class CfrOnProcessMessageReceivedEventArgs : CfrEventArgs {

        bool BrowserFetched;
        CfrBrowser m_Browser;
        bool SourceProcessFetched;
        CfxProcessId m_SourceProcess;
        bool MessageFetched;
        CfrProcessMessage m_Message;

        internal CfrOnProcessMessageReceivedEventArgs(ulong eventArgsId, CfrRuntime remoteRuntime) : base(eventArgsId, remoteRuntime) {}

        public CfrBrowser Browser {
            get {
                if(!BrowserFetched) {
                    BrowserFetched = true;
                    var call = new CfxOnProcessMessageReceivedGetBrowserRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Browser = CfrBrowser.Wrap(call.value, remoteRuntime);
                }
                return m_Browser;
            }
        }
        public CfxProcessId SourceProcess {
            get {
                if(!SourceProcessFetched) {
                    SourceProcessFetched = true;
                    var call = new CfxOnProcessMessageReceivedGetSourceProcessRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_SourceProcess = (CfxProcessId)call.value;
                }
                return m_SourceProcess;
            }
        }
        public CfrProcessMessage Message {
            get {
                if(!MessageFetched) {
                    MessageFetched = true;
                    var call = new CfxOnProcessMessageReceivedGetMessageRenderProcessCall();
                    call.eventArgsId = eventArgsId;
                    call.Execute(remoteRuntime.connection);
                    m_Message = CfrProcessMessage.Wrap(call.value, remoteRuntime);
                }
                return m_Message;
            }
        }
        public void SetReturnValue(bool returnValue) {
            var call = new CfxOnProcessMessageReceivedSetReturnValueRenderProcessCall();
            call.eventArgsId = eventArgsId;
            call.value = returnValue;
            call.Execute(remoteRuntime.connection);
        }

        public override string ToString() {
            return String.Format("Browser={{{0}}}, SourceProcess={{{1}}}, Message={{{2}}}", Browser, SourceProcess, Message);
        }
    }

}
