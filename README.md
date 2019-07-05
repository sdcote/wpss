# WPSS (WebPage Screen Saver)

Display a web page as your screen saver. This is particularly useful as an information radiator for your projects.

If you are practicing DevOps, you probably want a monitor to show a variety of web pages containing build status, code coverage, backlog items, team metrics, and the like. These are often available as web pages, but there are few tools that can cycle through these pages easily. This tool allows you to setup a small Windows compute instance (physical or virtual) with a monitor in a prominent location and let the screen saver cycle through all the pages.

## Credits

This is a clone of a project by a similar name ([cwc/web-page-screensaver](https://github.com/cwc/web-page-screensaver)) by Cameron Currie which has since been archived and probably no longer maintained. There were 3 pull requests pending at the time this project was cloned and this project has taken the effective results of each and a few personal updates. See the updates section for details on who made what changes,

In short, this is not my project; it is an updated and compiled work of other projects.

## Dependencies

[.NET Framework 4.6](https://www.microsoft.com/en-us/download/details.aspx?id=48130)

## Usage (Windows 7 & up)

1. Find Web-Page-Screensaver.scr on your computer, right click it
1. Select "Install" to install, or "Test" to test it out without installing
1. If installing, the Screen Saver Settings dialog will pop up with the correct screen saver selected
1. Use the `Settings...` button in the same dialog to change the web page(s) displayed by the screen saver

## Build instructions

1. Have the .NET Framework installed
1. Clone or Download the repository
1. Open a command prompt in the project folder and enter:
`C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe Web-Page-Screensaver.csproj`
1. In the folder `bin\Debug\` rename `Web-Page-Screensaver.exe` to `Web-Page-Screensaver.scr`
1. Right click `Web-Page-Screensaver.scr` to Test or Install. 

## Updates
1. Added build instructions for newbies to Csharp. - [topsrek](https://github.com/topsrek/web-page-screensaver)
1. Replaced webbrowser with modern webview (uses Edge engine) - [webstylecenter](https://github.com/webstylecenter/web-page-screensaver)
1. Fixing a crash an and UI issue - [carlossanlop](https://github.com/carlossanlop/web-page-screensaver)