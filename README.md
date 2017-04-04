MaterialSkin for .NET WinForms
=====================

Theming .NET WinForms, C# or VB.Net, to Google's Material Design Principles.

*Notice: this project is no longer under active development. Though, contributions are still welcome and the community will likely still help if you open an issue.*

<a href="https://www.youtube.com/watch?v=A8osVM_SXlg" target="_blank">![alt tag](http://i.imgur.com/JAttoOo.png)</a>

*High quality images can be found at the bottom of this page.*

---

#### Current state of the MaterialSkin components
| Component | Supported | Dark & light version | Disabled mode | Animated |
| --- | --- | --- | --- | --- |
| Checkbox | Yes | Yes | Yes | Yes |
| Divider | Yes | Yes | N/A | N/A |
| Flat Button | Yes | Yes | Yes | Yes |
| Label | Yes | Yes | N/A | N/A |
| Radio Button | Yes | Yes | Yes | Yes |
| Raised Button | Yes | Yes | Yes | Yes |
| Single-line text field | Yes | Yes | No | Yes |
| TabControl | Yes | N/A | N/A | Yes |
| ContextMenuStrip | Yes | Yes | Yes | Yes |
| ListView | Yes | Yes | No | No |
| ProgressBar | Yes | Yes | No | No |
| FloatingActionButton | No | No | No | No |
| Dialogs | No | No | No | No |
| Switch | No | No | No | No |
| More... | No | No | No | No |

---

#### Implementing MaterialSkin in your application. Updated for this fork!

**1. Add the library to your project**

  Clone the project from GitHub, compile the library and add it as a reference.
  
**2. Add the MaterialSkin components to your ToolBox**

  Once you compile the project, the MaterialSkin.dll file should be in the folder //bin/Debug. Simply drag the MaterialSkin.dll file into your IDE's ToolBox and all the controls should be added there.
  
**3. Inherit from MaterialForm**

  Open the code behind your Form you wish to skin. Make it inherit from MaterialForm rather than Form. Don't forget to put the library in your imports, so it can find the MaterialForm class!
  
  C# (Form1.cs)
  ```cs
  public partial class Form1 : MaterialForm
  ```
  
  VB.NET (Form1.Designer.vb)
  ```vb
  Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm
  ```
  
**4. Initialize your colorscheme**

  Set your preferred colors & theme. Also add the form to the manager so it keeps updated if the color scheme or theme changes later on.

C# (Form1.cs)
  ```cs
  public Form1()
  {
      InitializeComponent();

      var materialSkinManager = MaterialSkinManager.Instance;
      materialSkinManager.AddFormToManage(this);
      materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
      materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
  }
  ```

VB.NET (Form1.vb)
```vb
Imports MaterialSkin

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub
End Class
```

---

#### Material Design in WPF

If you love .NET and Material Design, you should definitely check out [Material Design Xaml Toolkit](https://github.com/ButchersBoy/MaterialDesignInXamlToolkit) by ButchersBoy. It's a similar project but for WPF instead of WinForms.

---

#### Contact original creator of this library

- Twitter: https://twitter.com/Ignace_Maes
- Personal Website: http://ignacemaes.com

---

#### Images

![alt tag](http://i.imgur.com/Ub0N9Xf.png)

*A simple demo interface with MaterialSkin components.*

![alt tag](http://i.imgur.com/eIAtRkc.png)

*The MaterialSkin checkboxes.*

![alt tag](http://i.imgur.com/sAPyvdH.png)

*The MaterialSkin radiobuttons.*

![alt tag](http://i.imgur.com/3Zpuv6x.png)

*The MaterialSkin ListView.*

![alt tag](http://i.imgur.com/07MrJZQ.png)

*MaterialSkin using a custom color scheme.*
