# WPSS (WebPage Screen Saver)

Display a web page as your screen saver. This is particularly useful as an information radiator for your projects.

If you are practicing DevOps, you probably want a monitor to show a variety of web pages containing build status, code coverage, backlog items, team metrics, and the like. These are often available as web pages, but there are few tools that can cycle through these pages easily. This tool allows you to setup a small Windows compute instance (physical or virtual) with a monitor in a prominent location and let the screen saver cycle through all the pages.

## Use Cases

The primary use case for this project is to simply display the web pages of various DevOps tools and a information radiator. The team can place this screensaver on a small, dedicated Windows compute instance connected to a monitor somewhere in the team space. In out teamspace it shows the Jenkins Build Monitor, our Jira Board, our metrics page, our application monitoring dashboard and our team calendar. Actually, out build monitor is displayed between all the other pages so we keep close watch on our builds.

This screen save allows us to use a corporate provided PC for our information radiator, allowing it to go to go to sleep at the pre-defined time and still allow our important pages to be displayed.

This may not work for all environments. For example, some workstations display a lock screen after a certain amount of time and the lock screen displays instead of the screen saver.

## Example Usage

After installing the screen saver (right-clicking it and selecting "Install"), configure the screen saver. It is useful to uncheck (turn off) the "Close on mouse movement" option.

Press the "Preview" button and watch the URLs display. If you are required to log into a site, you should be able to do it with the mouse and keyboard as long as the "Close on mouse movement" option has be de-selected in the configuration above. For some sites, you make have to temporarily change the "Seconds to display each site" value to give you time to sign-in to the site.

Set the screen saver to go on after a short amount of time, 1 minute for example.

To allow the monitor to constantly show the screen saver, make sure the power settings are set to never turn off the display when the workstation is plugged-in. 

Lock the workstation and allow the screen saver to start. It should no continually cycle through all your configured URLs. You should not have to unlock your workstation again, unless you need to reconfigure the screen saver. It is essentially operating like a web kiosk, allowing you to browse sites although they will automatically cycle to the next URL after the "Seconds to display each site" value has elapsed.

## Installation

Copy `WPSS.scr` to `C:\Windows\System32 ` if you have permission, or place the file in another location.

Right-click the `WPSS.scr` file and chose "Install". You will be taken to the screen saver configuration screen with WPSS set as the screen saver.

Note:  If you delete or move `WPSS.scr`, your screen saver will revert back to "none". It is important to keep the screen saver file in its original location or you will have to re-install it.

## Upgrading

Simply copy `WPSS.scr` over top of the existing file.

Optionally, you can drope the new file in a new location and install it from there.

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
1. In the folder `bin\Debug\` rename `WPSS.exe` to `WPSS.scr`
1. Right click `WPSS.scr` to Test, Configure or Install. 

## Updates
Since the original procjec is archived (and essentially dormant), this project has built upon it and other projects forked from it.
1. Added build instructions for newbies to Csharp. - [topsrek](https://github.com/topsrek/web-page-screensaver)
1. Replaced webbrowser with modern webview (uses Edge engine) - [webstylecenter](https://github.com/webstylecenter/web-page-screensaver)
1. Removed multi-display support. Keeping project simple for DevOps use cases.

### Multi-Display Support
Started a multi-display version of the project in the `multi_display` branch. This version was causing several issues and moved for a separate branch for archiving.
1. Fixing a crash an and UI issue - [carlossanlop](https://github.com/carlossanlop/web-page-screensaver)

Multi-display support may be abandoned since there is no use case for it currently and the existing design seems to have introduced a few bugs on some workstations. 

## Tips

Below are tips in using WPSS to display your teams information.

### Displaying Images

On thing many teams want to do is show Excel charts and graphs on their wall monitor. The challange is determining what size to make the image so it fills the screen on their monitor. Here is what you do:

1. Create your image. Export your Excel charts and other graphics to a shared directory your wall monitor can reach. Try to make your image the same aspect ratio as your monitor (16:9)
1. Copy the HTML below into a file on a shared directory your wall monitor can reach.
1. Edit the HTML to reference your image. Test it in your browser.
1. Update the WPSS to include the URL to the shared directory (e.g., file://C:/shared/status/burndown.html)

This is the HTML to use:
```html
<html>
<head>
    <style>
        * {
            margin: 0;
            padding: 0;
        }
        .imgbox {
            display: grid;
            height: 100%;
        }
        .center-fit {
            max-width: 100%;
            max-height: 100vh;
            margin: auto;
        }
    </style>
</head>
<body>
<div class="imgbox">
    <img class="center-fit" src='image.png'>
</div>
</body>
</html>
```

In the above HTML, change `image.png` to the location of your image. When the page is rendered, the image will be scaled to 100% of the display. If the image is smaller than the display size, it will scale up and may be pixelated. If the image is larger than the display, it should still remain sharp. Therefore, try to make your image the same aspect ratio and larger than your display to get the best sizing and image quality.

