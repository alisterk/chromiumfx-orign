# ChromiumFX #

### .NET bindings for the [Chromium Embedded Framework](https://bitbucket.org/chromiumembedded/cef/). ###
----------

## Home ##
[https://bitbucket.org/chromiumfx/chromiumfx]()

## Overview ##

### ChromiumFX.dll ###

* **[Managed wrapper](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Project) for the complete CEF API**
* **[Remote wrapper](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Walkthrough_02) for full access to DOM and V8 from within the browser process**

### ChromiumWebBrowser.dll ###

* **[Windows Forms control](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Walkthrough_01) based on ChromiumFX**

### See Also ###

* [Project Setup and Description](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Project)
* [Getting started with the Browser Control](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Walkthrough_01) 
* [Getting started with the Remoting Framework](https://bitbucket.org/chromiumfx/chromiumfx/wiki/Walkthrough_02)
* [API Reference](http://chromiumfx.bitbucket.org/api/)
* [Binary releases](https://bitbucket.org/chromiumfx/chromiumfx/downloads)

### Warning ###
The API of this project is not frozen and is subject to change. The overall structure will be kept though.

### Versioning ###

ChromiumFX version numbers consist of four digits. The first three digits are the version number of the underlying CEF binaries. The fourth number is the release number of ChromiumFX for a specific CEF version. Example: 3.1750.1738.0 is the first release of ChromiumFX for CEF 3.1750.1738 and 3.1750.1738.3 would be the fourth release for the same CEF version, and so on.

### Licensing and Credits ###

ChromiumFX is BSD licensed. The CEF project is BSD licensed. Please visit
"about:credits" in a CEF-based application for complete Chromium and third-party
licensing information. See also cef/LICENSE.txt and cef/README.txt.


## Changes ##

This is a summary of the most important changes and those relevant to embedders (API changes etc.).

### Version 3.2171.1979.9 ###

* The generator tool now extracts additional information about the public CEF C++ API to help translation of the C API:
 * The translation from C int (0/1) to C# bool (false/true) is now based on the signatures found in the C++ header files. This should have fixed the remaining issues with the int to bool translation.
 * Some CEF C functions have different names in the CEF C++ API. The C# translation now prefers the C++ names, including overloads like `CfxV8Value.HasValue()` for both `cef_v8value->has_value_bykey()` and `cef_v8value->has_value_byindex()`.

### Version 3.2171.1979.8 ###

* ChromiumFX and ChromiumWebBrowser assemblies are now built for platform x86 instead of AnyCPU, so the compiler will complain if you reference them from AnyCPU projects.
* Fixed int to bool conversion for `SetOsModalLoop` and `SetOsModalLoop` was removed from remote layer.
* Moved API delegate instantiation into static initializers of the types they belong to. This reduces work load at startup and avoids the allocation of unnecessary delegates for types never used by an application or secondary processes.
* CEF getter functions for string collections (`cef_string_list`, `cef_string_map`, `cef_string_multimap`) are now translated as functions with return value instead of functions with out paramenter. Example: `CfxBrowser.GetFrameNames(List<string> names)` ->  `List<string> CfxBrowser.GetFrameNames()`. This affects the public API of several classes.

### Version 3.2171.1979.7 ###

* Some of the framework callback container classes were not recognized as such by the code generator. This has been fixed. `CfxEndTracingCallback`, `CfxCompletionCallback`, `CfxRunFileDialogCallback` and `CfxSchemeHandlerFactory` are now correctly wrapped as framework callbacks.
* Removed browser-only `EndTracing` and `CfxEndTracingCallback` from remote layer.
* Fixed int to bool conversion for `GetBool` and `SetBool` functions in several classes.

### Version 3.2171.1979.6 ###

* Removed the `CfxRuntime.Initialize()` and `CfxRuntime.ExecuteProcess()` functions with sandbox parameter from the public API. Currently there is no way to start this within a sandbox. 
* Internally, the callback delegates and native function pointers are now created on demand, reducing the work load at startup. Most applications won't use all callbacks anyway. 
* Version information functions added to CfxRuntime.

### Version 3.2171.1979.5 ###

* The event handler and event arg classes for the framework callback events moved into their own namespaces. If you get errors, add `using Chromium.Event` and/or `using Chromium.Remote.Event` directives.
* A Sandcastle Help File Builder project was added and the xml documentation comments were improved for the new API reference.