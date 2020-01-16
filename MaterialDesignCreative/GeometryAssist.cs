using System.Windows;
using System.Windows.Media;

namespace MaterialDesignCreative
{
	public static class GeometryAssist
	{
		public static readonly DependencyProperty GeometryProperty =
			DependencyProperty.RegisterAttached(
				name: "Geometry",
				propertyType: typeof(Geometry),
				ownerType: typeof(GeometryAssist),
				defaultMetadata: new UIPropertyMetadata(Geometry.Empty));

		public static Geometry GetGeometry(UIElement element) =>
			(Geometry)element.GetValue(GeometryProperty);

		public static void SetGeometry(UIElement element, Geometry value) =>
			element.SetValue(GeometryProperty, value);
	}
}
