# Acrolinx .NET Sidebar Demo

This is a showcase for integrating the [Acrolinx](https://www.acrolinx.com/) Sidebar into a .NET application.

See: [Build With Acrolinx](https://support.acrolinx.com/hc/en-us/categories/10209837818770-Build-With-Acrolinx)

## Live Demo

[Acrolinx Sidebar Web Live Demo](https://acrolinx.github.io/acrolinx-sidebar-demo/samples/index.html)

A downloadable build of the .NET Sidebar Sample can be found in the [release section](https://github.com/acrolinx/acrolinx-sidebar-demo-dotnet/releases).

## The Acrolinx Sidebar

The Acrolinx Sidebar is designed to show up beside the window where you edit your content.
You use it for checking, reviewing, and correcting your content.
To get an impression what the Sidebar looks like in existing integrations, have a look at
[Sidebar Quick Start](https://support.acrolinx.com/hc/en-us/articles/10252588984594-Sidebar-Quick-Start).

## Prerequisites

Please contact [Acrolinx SDK support](https://github.com/acrolinx/acrolinx-coding-guidance/blob/master/topics/sdk-support.md)
for consulting and getting your integration certified.
This sample works with a test license on an internal Acrolinx URL.
This license is only meant for demonstration and developing purposes.
Once you finished your integration, you'll have to get a license for your integration from Acrolinx.
  
Acrolinx offers different other SDKs, and examples for developing integrations.

Before you start developing your own integration, you might benefit from looking into:

* [Build With Acrolinx](https://support.acrolinx.com/hc/en-us/categories/10209837818770-Build-With-Acrolinx),
* the [Guidance for the Development of Acrolinx Integrations](https://github.com/acrolinx/acrolinx-coding-guidance),
* the [Acrolinx SDKs](https://github.com/acrolinx?q=sdk), and
* the [Acrolinx Demo Projects](https://github.com/acrolinx?q=demo).

## Requirements

The SDK uses Microsoft Web View 2 as browser control to render the Sidebar.

WebView 2 comes preinstalled with Windows 11 and above.

Windows 10 and 7 users are recommended to install WebVew 2 evergreen installer from Microsoft.

Link to download evergreen installer for webview 2 from Microsoft: https://developer.microsoft.com/en-us/microsoft-edge/webview2/ 

## Getting Started

## Run Locally

1. Make sure that you have installed Microsoft Visual Studio with C# support version 2019 or later.
2. Since the Acrolinx Sidebar performs static code analysis to improve quality,
   you also have to install [Code Contracts for .NET](https://visualstudiogallery.msdn.microsoft.com/1ec7db13-3363-46c9-851f-1ce455f66970).
3. Open the solution file [`Acrolinx.Demo.Sidebar.Net.sln`](Acrolinx.Demo.Sidebar.Net.sln) with Visual Studio.
4. Run the solution.

Visual Studio downloads the required dependencies and compiles the Acrolinx .NET Sidebar Demo solution using [NuGet](https://www.nuget.org/).

*Note: The dependency download may fail on the first build. This problem can usually be solved by building a second time.*

![Screenshot of .NET Sidebar Example](/doc/sample.png)

## Using the SDK

1. Use the [Acrolinx Sidebar .NET SDK NuGet package](https://www.nuget.org/packages/Acrolinx.Sidebar/) as dependency.
2. After you resolve the Acrolinx .NET Sidebar dependency, you can start using it in your project.
   In the Designer View of your form, reference the file `Acrolinx.Sidebar.dll`
   using the "Choose Items" function of the Toolbox:
   ![Choose Items](/doc/chooseitems.png)

3. You should be able to drag and drop the Acrolinx Sidebar to your form:

   ![Toolbox](/doc/toolbox.png)

4. Usually you dock (`Properties`->`Layout`->`Dock`->`Right`) the Acrolinx Sidebar
   to the right side of your form or some child panel:

   ![Form1](/doc/form1.png)

5. Somewhere in your initialization code, tell the Sidebar to start:

   ```csharp
   await acrolinxSidebar1.Start();
   ```

   ![Start Sidebar](/doc/start.png)

   As the Sidebar uses Microsoft's WebView 2 control, which is asynchronous in nature, make sure you handle asynchronous code by appropriately using async/await keywords.

6. Run the application. If you see the Acrolinx Sidebar, then everything went well.

7. The next step is to implement the extraction and the events of the Sidebar:

![Events](/doc/events.png)

Have a look at the sample source code provided in the sample project.

### Configuration

To configure the Sidebar, use the properties window:

![Properties Window](/doc/signature.png)

## SDK Features

1. Provides [lookup](https://github.com/acrolinx/acrolinx-coding-guidance/blob/master/topics/text-lookup.md) functionality.
2. **Start page**: Provides an interactive way to sign in to Acrolinx with built-in error handling.
3. **Logger**: Provides [logging](https://github.com/acrolinx/sidebar-sdk-dotnet/blob/master/Acrolinx.Sidebar/Util/Logging/Logger.cs)
   using Log4net.
4. **Acrolinx Storage**: The SDK uses its own [storage](https://github.com/acrolinx/sidebar-sdk-dotnet/blob/master/Acrolinx.Sidebar/Storage/RegistryAcrolinxStorage.cs)
   mechanism using the Windows registry:
   + **Registry path**: `HKCU\Software\Acrolinx\Plugins\Storage\[KEY]`
   + **Fallback path**: `HKLM\Software\Acrolinx\Plugins\Storage\[KEY]`

## References

* This DEMO is built on the [Sidebar SDK .NET](https://github.com/acrolinx/sidebar-sdk-dotnet).
* The Sidebar SDKs are based on the [Acrolinx Sidebar Interface](https://acrolinx.github.io/sidebar-interface/).

## License

Copyright 2016-present Acrolinx GmbH

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at:

[http://www.apache.org/licenses/LICENSE-2.0](http://www.apache.org/licenses/LICENSE-2.0)

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

For more information visit: [https://www.acrolinx.com](https://www.acrolinx.com)
