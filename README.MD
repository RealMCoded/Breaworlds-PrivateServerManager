<div align="center">
<img src="./logo.png" >
<h1>Breaworlds Private Server Manager</h1>
</div>

A simple C# (WinForms) program to manage Breaworlds private servers (mostly [GoldenBedrock](https://github.com/RealMCoded/GoldenBedrock)).

## Downloads

You can download the newest release of BWPSM from the [releases page](https://github.com/RealMCoded/Breaworlds-PrivateServerManager/releases).

## Client modifications

BWPSM comes with a modified version of the Breaworlds 3.8.3 client.

Launching the exe independently does not work. It requires 3 command line arguments in this specific order.
- Server IP
- Server Port
- Server Name

An example launch command would be:
```
.\Breaworlds-PrivateServer.exe 127.0.0.1 1801 MyLocalServer
```

It has also been modified to save your login tokens to different files depending on what server name you provide, meaning multiple logins for different servers.

All modifications have been done by stuartwith2ts // RealMCoded.

## Building

BWPSM was built with Visual Studio 2022, with default compiler options. Just open the sln in VS and hit the build button.

## License 

This project is licensed under the [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.en.html).