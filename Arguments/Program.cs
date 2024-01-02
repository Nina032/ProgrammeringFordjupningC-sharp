WriteLine($"There are {args.Length} argument");
if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, e.g");
    WriteLine("dotnet run red yellow 50");
    return;
}
ForegroundColor = (ConsoleColor)Enum.Parse(
  enumType: typeof(ConsoleColor),
  value: args[0],
  ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
  enumType: typeof(ConsoleColor),
  value: args[1],
  ignoreCase: true);

try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the size of the cursor");
}

if (OperatingSystem.IsWindows())
{
    //funkar för Windows
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
    //kör kod för Windows 10
}
else if (OperatingSystem.IsIOSVersionAtLeast(major:14, minor: 5))
{
    //kör kod för IOS 14.5 eller senare
}
else if (OperatingSystem.IsBrowser())
{
    //kör kod fr webbläsare - Blazor
}

foreach (string arg in args)
{
    WriteLine(arg);

}



