# Base64-Workbench

A Windows desktop utility built with **C# and WinForms** for encoding and decoding Base64 data.

Base64-Workbench allows users to convert images into Base64 text and reconstruct images from Base64 encoded data through a simple graphical interface.

## Current Version

**v0.2 - Initial Working Prototype**

## Features Completed

### Image Encoding

- Open an image file
- Preview the selected image
- Convert image binary data into Base64
- Display Base64 output
- Copy Base64 text to clipboard
- Save Base64 output as a `.txt` file

### Image Decoding

- Paste Base64 encoded image data
- Decode Base64 back into an image
- Display the reconstructed image

## Technologies

- C#
- .NET
- Windows Forms
- Visual Studio / dotnet CLI

## Project Structure

```
Base64Workbench
│
├── MainForm.cs
├── MainForm.Designer.cs
├── Program.cs
│
└── Helpers
    └── Base64Helper.cs
```

## How It Works

Images are read as raw bytes:

```
Image File
    |
    v
Byte Array
    |
    v
Base64 Encoding
    |
    v
Text Representation
```

Decoding performs the reverse operation:

```
Base64 Text
    |
    v
Byte Array
    |
    v
Original Image
```

## Roadmap

### Version 0.3

Improve the application structure and user experience.

Planned:

- Add Encode / Decode tabs
- Improve layout
- Add better spacing and alignment
- Add status messages
- Add file information display

### Version 0.4

Additional functionality:

- Drag and drop images
- Generate Data URI format:

```html
<img src="data:image/png;base64,...">
```

- Show Base64 size increase
- Display image metadata

### Version 1.0

Polished desktop application:

- Modern dark theme
- Application icon
- Better error handling
- Support for more file types
- Windows release package

## Why This Project?

This project was created as a practical exercise in:

- Desktop application development with C#
- Working with binary data
- File input/output
- Data encoding and decoding
- Windows GUI development

## Author

David Marín

GitHub:
https://github.com/david-marin-0xff