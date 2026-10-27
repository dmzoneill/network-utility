# Network Utility

<p align="center">
  <img src=".github/logo.png" alt="network-utility logo" width="128" />
</p>

A Windows Forms network diagnostics toolkit that wraps common Windows
networking commands in a tabbed GUI.

## What it does

- Runs `ipconfig` with custom arguments and can release or renew the
  DHCP lease.
- Runs `netstat` and traces routes to a host.
- Pings a single IP address or sweeps a Class B or Class C range.
- Scans ports, using a bundled copy of nmap.
- Sends Wake-on-LAN packets to a set of ClickHere computers.
- Saves or clears the results of each tool.

The repository holds two versions of the project:

- `network-utility1` uses the ActiveSocket COM library
  (`Interop.ASOCKETLib.dll`).
- `network-utility2` is a later revision of the same tool.

## Tech

- Visual Basic .NET (Windows Forms)
- ActiveSocket and nmap

## Building

Open one of the `.sln` files in Visual Studio and build it. The
projects target the .NET Framework on Windows only.

## License

Licensed under the Apache License 2.0. See [LICENSE](LICENSE).
