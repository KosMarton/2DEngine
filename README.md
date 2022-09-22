# 2DEngine
## This is a 2D rendering engine in the early days of development, written mainly in C++. Updates are constantly pushed.

# How to start #

<ins>** Prerequirements **<ins>
First of all, the project is only avaiable on Windows (later in development, we will expand the project to Mac and Linux).
Other than that you will need to have installed Visual Studio 2022 to your machine, with at least msvc17 (Visual C++ version 17) with it.

<ins>**1. Clone and run**<ins>

Start by cloning the repository with `git clone --recursive https://github.com/KosMarton/2DEngine`.

<ins>**2. Configuring the dependencies:**</ins>

1. Run the [Setup.bat](https://github.com/KosMarton/2DEngine/blob/main/scripts/Setup.bat) file found in `scripts` folder. This will download the required prerequisites for the project if they are not present yet.
2. One prerequisite is the Vulkan SDK. If it is not installed, the script will execute the `VulkanSDK.exe` file, and will prompt the user to install the SDK.
3. After installation, run the [Setup.bat](https://github.com/KosMarton/2DEngine/blob/main/scripts/Setup.bat) file again. If the Vulkan SDK is installed properly, it will then download the Vulkan SDK Debug libraries. (This may take a longer amount of time)
4. After downloading and unzipping the files, the [Win-GenProjects.bat](https://github.com/KosMarton/2DEngine/blob/master/scripts/Win-GenProjects.bat) script file will get executed automatically, which will then generate a Visual Studio solution file for user's usage.

If changes are made, or if you want to regenerate project files, rerun the [Win-GenProjects.bat](https://github.com/KosMarton/2DEngine/blob/master/scripts/Win-GenProjects.bat) script file found in `scripts` folder.
