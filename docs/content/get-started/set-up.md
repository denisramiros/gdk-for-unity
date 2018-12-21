# Get started: 1 - Set up
There are three parts to this step: 

* Sign up for a SpatialOS account
* Set up your machine
* Clone the repos 

(This step is the longest of the 6 steps - the others are much quicker.)
<br/>
<br/>
## Sign up for a SpatialOS account, or make sure you are logged in

If you have already signed up, make sure you are logged in (you should see your picture in the top right of the page if you are, if not - hit "Sign In".)

If you have not signed up before, you can do this [here](https://improbable.io/get-spatialos).
<br/>
<br/>

## Set up your machine

<%(#Expandable title="Setup for Windows")%>

**Step 1.** Install **<a href="https://unity3d.com/get-unity/download/archive" data-track-link="Unity Download Link Clicked|product=Docs|platform=Win|label=Win" target="_blank"><strong>Unity 2018.2.14</strong></a>**

Ensure you install this exact version as other Unity versions may not work with the GDK.

- Make sure you download the **Installer** version, and select the following components during installation:
  - **Linux Build Support**
  - **Mac Build Support**

> **Note:**
Even though you are developing on a Windows PC, you need:<br/>
**Linux Build Support** because all server-workers in a cloud deployment run in a Linux environment. <br/>
**Mac Build Support** if you want to share your game with end-users on a Mac.<br/>
Unity gives you Windows build support by default.

**Step 2.** Install **<a href="https://www.microsoft.com/net/download/dotnet-core/2.1" data-track-link=".NET Core Download Link Clicked|product=Docs|platform=Win|label=Win" target="_blank"><strong>.NET Core SDK (x64)</strong></a>**

- Verified with versions `2.1.3xx` and `2.1.4xx`

> **Note:** After installing the .NET Core SDK, you should restart any Unity and Unity Hub processes. This will prevent errors where Unity cannot find the `dotnet` executable.

**Step 3.** Run the **<a href="https://console.improbable.io/installer/download/stable/latest/win" data-track-link="SpatialOS Installer Downloaded|product=Docs|platform=Win|label=Win" target="_blank">SpatialOS Installer</a>**

- This installs the [SpatialOS CLI]({{urlRoot}}/content/glossary#spatial-command-line-tool-cli) , the [SpatialOS Launcher]({{urlRoot}}/content/glossary#launcher), and 32-bit and 64-bit Visual C++ Redistributables

**Step 4.** Install a **code editor** if you don't have one already

- We recommend either [Visual Studio 2017](https://www.visualstudio.com/downloads/) or [Rider](https://www.jetbrains.com/rider/). See _**Code editor set up**_, below.

**Step 5.** Restart your machine.

> If you do not restart your machine, you may experience errors when opening a GDK project.


#### Code editor set up

 **Using Visual Studio?**

As you install [Visual Studio](https://www.visualstudio.com/downloads/), click on the **Workloads** tab in the Installer. If you already have Visual Studio installed, you can find this by clicking on the **More** option for *Visual Studio Build Tools* in the Visual Studio Installer, and selecting **Modify** from the drop-down menu.

![Click Modify to find the Workloads tab.]({{assetRoot}}assets/setup/windows/visualstudioworkloads.png)

Once you have navigated to the **Workloads** tab:

* Select **.NET Core cross-platform development**.

* After selecting **Game development with Unity**:
  * Deselect any options in the **Summary** on the right that mention a Unity Editor (for example, Unity 2017.2 64-bit Editor or Unity 2018.1 64-bit Editor).
  * The SpatialOS GDK for Unity requires **Unity 2018.2.14**, which should already be installed if you have followed the setup guide correctly.
  * Make sure **Visual Studio Tools for Unity** is included (there should be a tick next to it).

> **Warning**: Older versions of Visual Studio 2017 have been known to cause some issues with Unity 2018.2.14 - the issues are projects loading and unloading frequently, and Intellisense breaking. If you do experience these issues, try updating to a newer version of Visual Studio 2017.

**Using Rider?**

Once you have installed [Rider](https://www.jetbrains.com/rider/), install the [**Unity Support** plugin](https://github.com/JetBrains/resharper-unity) for a better experience.

<%(/Expandable)%>

<%(#Expandable title="Setup for Mac")%>

**Step 1.** Install **<a href="https://unity3d.com/get-unity/download/archive" data-track-link="Unity Download Link Clicked|product=Docs|platform=Mac|label=Mac" target="_blank"><strong>Unity 2018.2.14</strong></a>**

Ensure you install this exact version as other Unity versions may not work with the GDK.

- Make sure to download the **Installer** version, and select the following components during installation:
  - **Linux Build Support**
  - **Windows Build Support**

> **Note:**
Even though you are developing on a Mac, you need:<br/>
**Linux Build Support** because all server-workers in a cloud deployment run in a Linux environment. <br/>
**Windows Build Support** if you want to share your game with end-users on a Windows PC.<br/>
Unity gives you Mac build support by default.

**Step 2.** Install **<a href="https://www.microsoft.com/net/download/dotnet-core/2.1" data-track-link=".NET Core Download Link Clicked|product=Docs|platform=Mac|label=Mac" target="_blank"><strong>.NET Core SDK (x64)</strong></a>**

- Verified with versions `2.1.3xx` and `2.1.4xx`

> **Note:** After installing the .NET Core SDK, you should restart any Unity and Unity Hub processes. This will prevent errors where Unity cannot find the `dotnet` executable.

**Step 3.** Run the **<a href="https://console.improbable.io/installer/download/stable/latest/mac" data-track-link="SpatialOS Installer Downloaded|product=Docs|platform=Mac|label=Mac" target="_blank">SpatialOS installer</a>**

* This installs the [SpatialOS CLI]({{urlRoot}}/content/glossary#spatial-command-line-tool-cli) , the [SpatialOS Launcher]({{urlRoot}}/content/glossary#launcher), and 32-bit and 64-bit Visual C++ Redistributables.

**Step 4.** Install a **code editor** if you don't have one already

* We recommend either [Visual Studio](https://www.visualstudio.com/downloads/) or [Rider](https://www.jetbrains.com/rider/). See _**Code editor set up**_, below.

**Step 5.** Restart your machine.

> If you do not restart your machine, you may experience errors when opening a GDK project.

#### Code editor set up

**Using Visual Studio?**

Once you have installed [Visual Studio](https://www.visualstudio.com/downloads/), within the Visual Studio Installer, select **.NET Core + ASP .NET Core**.

**Using Rider?**

Once you have installed [Rider](https://www.jetbrains.com/rider/), install the [**Unity Support** plugin](https://github.com/JetBrains/resharper-unity) for a better experience.

<%(/Expandable)%>

<%(Callout type="alert" message="
* You need **Linux** build support. This is because server-workers in a cloud deployment run in a Linux environment. In the `Assets/Fps/Config/BuildConfiguration`, do not change the `UnityGameLogic Cloud Environment` from Linux.<br/>
* You need **Mac** build support if you are developing on a Windows PC and want to share your game with Mac users.<br/>
* You need **Windows** build support if you are developing on a Mac and want to share your game with Windows PC users. <br/>
* Unity gives you build support for your development machine (Windows or Mac) by default.")%>


If you need help using the GDK, come and talk to us about the software and the documentation via:

* **The SpatialOS forums** - Visit the [support section](https://forums.improbable.io/new-topic?category=Support&tags=unity-gdk) in our forums and use the unity-gdk tag.
* **Discord** - Find us in the [#unity channel](https://discord.gg/SCZTCYm). You may need to grab Discord [here](https://discordapp.com/).
* **Github issues** - Create an [issue](https://github.com/spatialos/gdk-for-unity/issues) in this repository.
<br/>
<br/>


## Get the GDK and Starter Project Source Code

### Zip Download

<%(Callout type="alert" message="
If you can, please use Git to get the GDK and its starter project, as version control will make it easier for you to get updates in the future.")%>

If you are unfamiliar with Git, you can download a Zip file of the GDK and its Starter Project [here](https://github.com/spatialos/gdk-for-unity-fps-starter-project/releases/tag/0.1.3). 

**If you have downloaded it and unzipped it, skip the rest of this page and move on to [Open the FPS Starter Project]({{urlRoot}}/content/get-started/open-project.md).**

### Cloning the Repos using Git

If you haven't downloaded the zip, you need to clone two repositories; the FPS Starter Project and the GDK for Unity.

#### Clone the FPS Starter Project repository

Clone the FPS starter project using one of the following commands:

|     |     |
| --- | --- |
| HTTPS | `git clone https://github.com/spatialos/gdk-for-unity-fps-starter-project.git` |
| SSH | `git clone git@github.com:spatialos/gdk-for-unity-fps-starter-project.git` |

<%(Callout type="warning" message="
You can only clone via SSH if you have already [set up SSH keys](https://help.github.com/articles/connecting-to-github-with-ssh/) with your GitHub account.")%>

Then navigate to the root folder of the FPS starter project and run the following command: `git checkout 0.1.3`

This ensures that you are on the alpha release version of the FPS starter project.

#### Clone the GDK for Unity and checkout the latest release

You can use scripts to automatically do this or follow manual instructions.

* To use the scripts:<br/>
From the root of the `gdk-for-unity-fps-starter-project` repository:
    * If you are using Windows run: `powershell scripts/powershell/setup.ps1`
    * If you are using Mac run: `bash scripts/shell/setup.sh`
* To follow manual instructions, see below:

<%(#Expandable title="Manually clone the GDK")%>

1. Clone the [GDK for Unity](https://github.com/spatialos/gdk-for-unity) repository alongside the FPS Starter Project so that they sit side-by-side:

|     |     |
| --- | --- |
| HTTPS | `git clone https://github.com/spatialos/gdk-for-unity.git` |
| SSH | `git clone git@github.com:spatialos/gdk-for-unity.git` |

  > The two repositories should share a common parent, like the example below:

  ```text
  <common_parent_directory>
      ├── gdk-for-unity-fps-starter-project
      ├── gdk-for-unity
  ```

2. Navigate to the `gdk-for-unity` directory and checkout the pinned version which you can find in the `gdk.pinned` file, in the root of the `gdk-for-unity-fps-starter-project` directory.
  * `git checkout <pinned_version>`

<%(/Expandable)%>

<br/>

#### Next: [Open the FPS Starter Project]({{urlRoot}}/content/get-started/open-project.md)