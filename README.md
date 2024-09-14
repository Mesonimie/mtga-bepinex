# mtga-bepinex

This repository contains a Bepinex Plugin for Magic The Gathering: Arena.

The goal of the plugin is to track the cards in your inventory.

# Compilation

Copy the `Assembly-Csharp.dll` and `Core.dll` from MTGA to the libs repository, then `dotnet build`

# Usage

Copy the bepinex 6.0.0-pre files in the MTGA repository.

Launch and quit MTGA.
Verify that everything worked correctly by looking if a Log file and a plugin file were created in the bepinex directory.

Under linux, you have to use protontricks to make the winhttp dll native (see documentation on bepinex)

If everything worked OK, put the dll from the `bin/Debug/netstandard2.1` directory into the plugin file, and start MTGA again.

# Note

Works only with bepinex 6.0.0-pre, does not work with bepinex 5 or bepinex 6-BE.





