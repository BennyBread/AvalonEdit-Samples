# AvalonEdit Samples
Implements sample projects to demo the [AvalonEdit](https://github.com/icsharpcode/AvalonEdit) control with extensions (see also [Dirkster99/AvalonEditHighlightingThemes](https://github.com/Dirkster99/AvalonEditHighlightingThemes)).

# Demo Projects

<font color="yellow">Obviously a fork. from the Dirkster repo.</font>

## 00 MVVMDemo

<font color="yellow">Changed / updated is the MVVMdemo to net8.0-windows and added Gcode syntax highlighting definition.</font>

The [00 MVVMDemo](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/00_MVVMDemo) project gives a simple MVVM/WPF demo application that implements some simple features like:
1) Text loading
2) Editing (Copy, Paste, Cut, Undo, Redo), and
3) Highlighting.

This demo project is the base project for all other sample projects in this repository and [Dirkster99/AvalonEditHighlightingThemes](https://github.com/Dirkster99/AvalonEditHighlightingThemes).

## 10 Scale Font Demo

The [10 ScaleFontDemo](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/10_ScaleFontDemo) project 
shows how the display font can be scalled with interactive means like

- the Scale up/scale down (two finger) gesture on your touch-pad, or 
- Control Key and mouse wheel to zoom text size in or out.

## 14 Scale Font Demo

The [14 ScaleFontDemo](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/14_ScaleFontDemo) project
implements the [10 ScaleFontDemo](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/10_ScaleFontDemo) project
and adds a custom scalling control from the
[UnitComboLib](https://github.com/Dirkster99/UnitComboLib) project.

- Use The UnitComboBox in the left/lower corner of the MainWindow to change the FontSize
  according to:  
  - Points or  
  - Percentage scales.

## 17 Switch Demo

The [17_SwitchDemo](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/17_SwitchDemo) project
is a small prototype app that reviews how AvalonEdit will cope if we use **2 different Document** bindings
and switch between them whenever we like to. I needed this feature because I wanted to kind of overlay
2 different displays when showing highlighting for different lines (comparing) or editing the text
when a user would wish to re-align different sections of text in [Ähnlich](https://github.com/Dirkster99/Aehnlich).

## 20 Highlight Current Line Renderer

The [20_HighlightCurrentLineRenderer](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/20_HighlightCurrentLineRenderer)
project shows how the currently edit line can be highlighted with a
current
[HighlightCurrentLineBackgroundRenderer](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/20_HighlightCurrentLineRenderer/TextEditLib/Extensions/HighlightCurrentLineBackgroundRenderer.cs)
extension.

## 30 CursorPosition Edit Status

The [30_CursorPosition_Edit_Status](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/30_CursorPosition_Edit_Status)

project demonstrates a status display in the lower right corner of the status bar (when a document is loaded).

Items shown are:
- Cursor position (Ln and Col)
- OverstrikeMode (whether user overwrites available content with next character typed or not)
- Encoding (UTF 8, Western European (Windows), etc) - See also Tool Tip of this element

## 40 View Options

The [40_View_Options](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/40_View_Options)

project demonstrates editing options, such as:

- toogle Word Wrap
- Toggle Display of Line Numbers
- Toggle display of white spaces, such as, End of Line, Space character, and Tab character

## 55 AE Commands

The [55_AE_Commands](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/55_AE_Commands)
project implements the basic features of the 00_MVVMDemo project in a seperate
control library called TextEditLib and adds the followinf features:

- Text Folding for C#, Java, XML, XAML
- Advanced Command Bindings via ContextMenu (Collapse All Text Folds, Expand All Folds)
- Integration of standard AvalonEdit commands, such as, Replace Tabs with Spaces etc.

## 88 MVVM ThemedDemo

The [88 MVVM ThemedDemo](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/88_MVVM%20ThemedDemo) project shows how syntax highlighting can be integrated into WPF Theming without using
custom highlighting definitions per theme.

This solution is just an intermediate step from the [00 MVVMDemo](https://github.com/Dirkster99/AvalonEdit-Samples/tree/master/source/00_MVVMDemo) solution to give you an understanding
of what might be necessary to add WPF theming to an existing MVVM application. This demo solution also
shows how bad it is to use highlighting definitions for a Light WPF theme on a Dark WPF theme and vice
versa.

Please refer to [Dirkster99/AvalonEditHighlightingThemes](https://github.com/Dirkster99/AvalonEditHighlightingThemes)
for an improved solution that coordinates:
1) Dark/Light/True Blue WPF themes
2) with an appropriate Syntax Highlighting Theme.

## Other AvalonEdit Demo Projects:

More demo projects may be listed at the [AvalonEdit's Wiki page](https://github.com/icsharpcode/AvalonEdit/wiki/Samples-and-Articles)
