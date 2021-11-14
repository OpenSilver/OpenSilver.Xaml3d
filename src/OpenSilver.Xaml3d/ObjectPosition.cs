using System.Windows;

namespace OpenSilver.Xaml3d
{
    public static class ObjectPosition
    {
        public static double GetRotateX(DependencyObject obj)
        {
            return (double)obj.GetValue(AriaLabelProperty);
        }

        public static void SetRotateX(DependencyObject obj, double value)
        {
            obj.SetValue(AriaLabelProperty, value);
        }

        public static readonly DependencyProperty AriaLabelProperty =
            DependencyProperty.RegisterAttached(
                name: "RotateX",
                propertyType: typeof(double),
                ownerType: typeof(ObjectPosition),
                typeMetadata: new PropertyMetadata(defaultValue: null)
                {
                    MethodToUpdateDom = (d, newValue) => { Update(); }
                });

        private static void Update()
        {

        }
    }
}
