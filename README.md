# Material Design Creative

Material Design Creative is based on [Material Design in XAML Toolkit]（http://materialdesigninxaml.net/) ( [GitHub](https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit) , [NuGet](https://www.nuget.org/packages/MaterialDesignThemes/) ) and [Material Design Extensions](https://spiegelp.github.io/MaterialDesignExtensions/) ( [GitHub](https://github.com/spiegelp/MaterialDesignExtensions) , [NuGet](https://www.nuget.org/packages/MaterialDesignExtensions/) ) to provide tinny bitty little additional features for WPF Applications.

## Getting Started

1.  Make sure you had checked [Material Design in XAML Toolkit](http://materialdesigninxaml.net/) ( [GitHub](https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit) , [NuGet](https://www.nuget.org/packages/MaterialDesignThemes/) ) , [Material Design Extensions](https://spiegelp.github.io/MaterialDesignExtensions/) ( [GitHub](https://github.com/spiegelp/MaterialDesignExtensions) , [NuGet](https://www.nuget.org/packages/MaterialDesignExtensions/) ) and other GitHub Repos or NuGet Packages for the required feature before turning to Material Design Creative , which has been and will be under arbitrary development for a period of time ;
2.  Get the latest distribution of Material Design Creative using NuGet Package Manager command `PM> Install-Package MaterialDesignCreative` . This assembly is compiled for both .NET Core and .NET Framework 4.5 ;
3.  Add the XML namespace `xmlns:mdc="http://amahane.ml/xaml/materialdesigncreative"` ( Mapped to CLR Namespace `MaterialDesignCreative` ) to your XAML , and you are ready.

## Documentations

### Geometry Customizable Buttons

#### Summary

This feature is very similar to the `MaterialDesignRaisedButton` WPF style provided in the assembly `MaterialDesignThemes.Wpf` , but enables you to use an expression ( Typically, a `MultiBinding` expression ) of `System.Windows.Media.Geometry` to customize the shape of a raised button. Everything in the original `MaterialDesignRaisedButton` style is reshaped and looks pretty fine ( at least so far XD ). This means that if used properly, visual effects including ripples, dropdown shadows, and other animations are rendered as expected. Also, the integrated progress bar component is fully available.

To use this feature, you may:

1.  Set the dependency property `MaterialDesignCreative.GeometryAssist.GeometryProperty` on your button. To keep it simple, set property `mdc:GeometryAssist.Geometry` in your XAML ( Assuming you are using XML Namespace `mdc` as `xmlns:mdc="http://amahane.ml/xaml/materialdesigncreative"` ) ;
2.  Apply the style `MaterialDesignCreative.Button.Raised` to your button. Extra resource dictionary merges are not necessary ;
3.  Let the magic happen ~

#### Layout

The geometry is NOT scaled according to the size that the content requires, and the content outside the geometry is simply clipped. So it is strongly recommended to use a `MultiBinding` to the `ActualWidth` and `ActualHeight` property, and implement a customized `MultiValueConverter` to generate the geometry dynamically. This trick will help you using this feature while enjoying the convenience of existing WPF Layout System ;

Or you might prefer to specify the desired size in the geometry, and set `Height` and `Width` property of your button to `Auto` ( `Auto` is the default value of `ButtonBase.Width` , but not `ButtonBase.Height` ). Anyway, remember that the larger one of the geometry and the content decide the actual size of the button.

#### Implementation

This feature is implemented in `MaterialDesignCreative/Themes/Button.xaml` of this repo , based on the original `MaterialDesignRaisedButton` WPF style provided in ``pack://application:,,,MaterialDesignThemes.Wpf;components/Themes/MaterialButton`. To provide a uniform experience, changes are made as few as possible.

#### Known Issues

Ripples outside the first quadrant are not rendered properly. To solve this, shift the geometry into the first quadrant. 

## License & Contributions

Material Design Creative is licensed under the [GNU Public License Version 3](https://github.com/Amahane/MaterialDesignCreative/blob/master/LICENSE) , and issues and pull requests are welcomed at anytime . But anyway , why not consider contributing to other popular repos XD