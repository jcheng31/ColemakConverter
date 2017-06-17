# ColemakConverter

A .NET Core 1.1 app to decipher ciphertext written with the [Colemak keyboard layout](https://en.wikipedia.org/wiki/Keyboard_layout#Colemak) but with the system layout set to QWERTY.

## What.

Let's say you want to write something in a public place without anyone being able to see what you're actually typing. Let's also say you're using Colemak and are familiar enough with it to touch type. Switch your keyboard layout into QWERTY, type whatever you want to type, then use this tool to convert the "encrypted" file back into human-readable text later.

## Usage

You'll need [.NET Core 1.1](https://www.microsoft.com/net/download/core#/runtime) or better installed and in your PATH. Grab the latest [release](https://github.com/jcheng31/ColemakConverter/releases/), unpack it somewhere, then run `dotnet ColemakConverter.dll <ciphertext file path> <output file path>`.

This tool is **very** quick-and-dirty. It does not do any error handling, and will crash if either path is not specified. It'll probably crash if the input file path is not a text file.