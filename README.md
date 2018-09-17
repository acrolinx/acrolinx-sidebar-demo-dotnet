# Acrolinx .NET Sidebar Demo

Demo code for an integration of the Acrolinx Sidebar in a .NET application

## Prerequisites

Please contact Acrolinx SDK support (sdk-support@acrolinx.com) for initial consulting. 
We like to schedule a kickoff meeting to answer any questions about your integration project. 
After the meeting, we provide you with test server credentials and configuration settings you need to get started.

## Configuration of the Sample

The Acrolinx Server checks if a connecting client is allowed to connect. To connect to a server, you must provide a valid client signature by using the Visual Studio Designer (described in [How to use the Sidebar in Your Integration]) or by editing the code:

In the two files:

* `Acrolinx.Demo.Sidebar\MultiSample.Designer.cs`
* `Acrolinx.Demo.Sidebar\SimpleSample.Designer.cs`

find the line:

	// acrolinxSidebar

and add the following line:

	this.acrolinxSidebar.ClientSignature = "";

with the signature provided by Acrolinx.

## How to Start

First make sure that you have installed Microsoft Visual Studio with C# support version 2015 or later.

Since the Acrolinx Sidebar performs static code analysis to improve quality, you also have to install Code Contracts for .NET:

https://visualstudiogallery.msdn.microsoft.com/1ec7db13-3363-46c9-851f-1ce455f66970

Open the solution file `Acrolinx.Demo.Sidebar.Net` with Visual Studio.

Run the solution.
 
Visual Studio downloads the required dependencies and compiles the Acrolinx .NET Sidebar solution using NuGet (https://www.nuget.org/).
(Note: The dependency download may fail on the first build. This problem can usually be solved by building a second time.)

![Screen Shot of .NET Sidebar Example](/doc/sample.png)

## How to Use the Sidebar in Your Integration

After you resolve the Acrolinx .NET Sidebar dependency you can start using it in your project. In the Designer View of your form, reference the file `Acrolinx.Sidebar.dll` using the "Choose Items" function of the Toolbox:

![Choose Items](/doc/chooseitems.png)

You should be able to drag and drop the Acrolinx Sidebar to your form:

![Toolbox](/doc/toolbox.png)

Usually you dock (Properties->Layout->Dock->Right) the Acrolinx Sidebar to the right side of your form or some child panel:

![Form1](/doc/form1.png)

Set the client signature which you received from Acrolinx. Scroll to the Sidebar section in the properties window:

![Signature](/doc/signature.png)

Somewhere in your initialization code, tell the Sidebar to start:

	acrolinxSidebar1.Start();

![Start Sidebar](/doc/start.png)

Run the application. If you see the Acrolinx Sidebar, then everything went well.

The next step is to implement the extraction and the events of the Sidebar:

![Events](/doc/events.png)

Have a look at the sample source code provided in the sample project. 

## CORS, HTTPS, Servers

* By default, this sample will only connect to Acrolinx Servers using HTTPS.
* The Acrolinx Server must have CORS enabled (https://en.wikipedia.org/wiki/Cross-origin_resource_sharing),
* The client computer must be connected to the internet.

If you have been granted access to an Acrolinx test server, the Acrolinx Sidebar will work out of the box.

If you use an Acrolinx server version 4.7 or later, then you can change the `SidebarSourceLocation` property of the Acrolinx Sidebar control.
The address follows the pattern `http(s)://<hostname>:port/sidebar/v14/index.html`

## License

Copyright 2016-2017 Acrolinx GmbH

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

For more information visit: http://www.acrolinx.com
