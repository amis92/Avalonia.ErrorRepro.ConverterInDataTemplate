# Avalonia bug repro

This repository reproduces a bug with using Converters in DataTemplates (seemingly).

1. Build the solution, run
2. Observe last TextBox is invisibile
3. Last TextBox has content for which DataTemplate uses Converter from `Window.Resources`
4. That converter is instantiated (you can put breakpoint in constructor and get hit)
5. The converter never gets called for the item from DataTemplate

This repo uses Avalonia v0.6.1 from NuGet feed.