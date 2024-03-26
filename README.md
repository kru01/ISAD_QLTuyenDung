<a name="readme-top"></a>

# ISAD - QLTuyenDung and IS Analysis & Design

-   Group project from HCMUS's 2024 Information Systems Analysis & Design course.

<details open>
  <summary>Table of Contents</summary>
  <ul>
    <li>
      <a href="#content">Content</a>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li>
      <a href="#usage">Usage</a>
      <ul>
        <li><a href="#to-set-up-the-database">To set up the database</a></li>
        <li><a href="#to-uninstall-the-database">To uninstall the database</a></li>
        <li><a href="#to-link-oracle-with-winforms">To link Oracle with WinForms</a></li>
      </ul>
    </li>
    <li><a href="#built-with">Built With</a></li>
    <li><a href="#meet-the-team">Meet The Team</a></li>
  </ul>
</details>

## Content

## Getting Started

### Prerequisites

-   Windows 10 or 11.
-   [Oracle Database 21c Express Edition](https://www.oracle.com/database/technologies/xe-downloads.html) and
    [SQL Developer 23.1.1](https://www.oracle.com/database/sqldeveloper/technologies/download/).
-   **_For WinForms development:_**

    -   [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) and its `.NET desktop development` workload.

-   _(Optional)_ Any decent code editor, preferably [VSCode](https://code.visualstudio.com/).
    -   It just makes editing the database's source code easier.

### Installation

-   Clone the repo.

## Usage

### To set up the database

1. Well, good luck setting up `Oracle Database 21c Express Edition`.
1. [Have a `PDB` and enable `OLS`](#to-enable-ols).
1. Navigate into `SQL` folder.
1. If a different `PDB` is used, replace all instances of `XEPDB1`.
1. `SYS.XEPDB1` Run the files in the specified order, `createDB.sql` &rarr; `data.sql` &rarr; `procs.sql` &rarr; `users_privs.sql`.

### To uninstall the database

1. Run `cleanupDB.sql`.
    - Should take care to close all connections beforehand so everything can be dropped smoothly, no `ORA-01940: cannot DROP a user that is currently logged in`.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### To link Oracle with WinForms

1. Open `ISS_QLNoiBo.sln` with Visual Studio 2022.
1. On the taskbar, select `Project` &rarr; `Manage NuGet Packages...`.
1. Move to `Browse` tab, search for `oracle`, and install `Oracle.ManagedDataAccess.Core`.
1. Try to run the program, if it still fails, proceed to step 5.
1. Locate the path to `Oracle.DataAccess.dll` with Windows File Explorer.
    - Mine was `...\Oracle21c\dbhomeXE\ODP.NET\bin\4`.
1. Back to VS2022, in the `Solution Explorer`, right-click `ISS_QLNoiBo`.
    - It's right beneath `Solution 'ISS_QLNoiBo' (1 of 1 project)`.
1. Select `Add` &rarr; `Project Reference...`.
1. Move to `Browse` tab, then click `Browse...` at bottom right of the window.
1. Navigate to the path at step 5.
1. Select `Oracle.DataAccess.dll` then `Add`.
    - Try to run the app, if it still fails, o7 then since I got mine to work at this point.

## Built With

[vsicon]: https://skillicons.dev/icons?i=visualstudio&theme=dark
[vsurl]: https://visualstudio.microsoft.com/vs/
[dotneticon]: https://skillicons.dev/icons?i=dotnet
[dotneturl]: https://dotnet.microsoft.com/en-us/download/dotnet/8.0
[oracleicon]: https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/oracle/oracle-original.svg
[oracleurl]: https://www.oracle.com/database/technologies/xe-downloads.html
[sqldevicon]: https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/sqldeveloper/sqldeveloper-original.svg
[sqldevurl]: https://www.oracle.com/database/sqldeveloper/technologies/download/
[vscodeicon]: https://skillicons.dev/icons?i=vscode&theme=dark
[vscodeurl]: https://code.visualstudio.com/
[windowsicon]: https://cdn.jsdelivr.net/gh/devicons/devicon/icons/windows8/windows8-original.svg
[windowsurl]: https://www.microsoft.com/en-us/windows/

| [![VisualStudio2022][vsicon]][vsurl] | [![.NET8.0][dotneticon]][dotneturl] | [![Oracle 21c Express][oracleicon]][oracleurl] | [![SQL Developer][sqldevicon]][sqldevurl] | [![VSCode][vscodeicon]][vscodeurl] | [![Windows][windowsicon]][windowsurl] |
| :----------------------------------: | :---------------------------------: | :--------------------------------------------: | :---------------------------------------: | :--------------------------------: | :-----------------------------------: |
|             2022 v17.9.4             |                 8.0                 |              21c Express Edition               |                23.1.1.345                 |               1.87.2               |     &nbsp;&nbsp; 11 &nbsp;&nbsp;      |

## Meet The Team

<div align="center">
  <a href="https://github.com/phongan1x5"><img alt="phongan1x5" src="https://github.com/phongan1x5.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/kru01"><img alt="kru01" src="https://github.com/kru01.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/faithdanghuy"><img alt="faithdanghuy" src="https://github.com/faithdanghuy.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
  <a href="https://github.com/Namiscrea7or"><img alt="Namiscrea7or" src="https://github.com/Namiscrea7or.png" width="60px" height="auto"></a>&nbsp;&nbsp;&nbsp;
</div>

<p align="right">(<a href="#readme-top">back to top</a>)</p>
