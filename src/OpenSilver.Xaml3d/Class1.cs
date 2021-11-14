﻿using System.Windows;

namespace OpenSilver.Xaml3d
{
    public static class Xaml3d
    {
        public static void MoveCameraToHere(this UIElement uielement)
        {

        }

        public static string GetAriaLabel(DependencyObject obj)
        {
            return (string)obj.GetValue(AriaLabelProperty);
        }

        public static void SetAriaLabel(DependencyObject obj, string value)
        {
            obj.SetValue(AriaLabelProperty, value);
        }

        public static readonly DependencyProperty AriaLabelProperty =
            DependencyProperty.RegisterAttached(
                name: "AriaLabel",
                propertyType: typeof(string),
                ownerType: typeof(Xaml3d),
                typeMetadata: new PropertyMetadata(defaultValue: null)
                {
                    MethodToUpdateDom = AriaLabel_MethodToUpdateDom
                });

        /// <summary>
        /// This method is called when the DOM tree is rendered.
        /// </summary>
        /// <param name="d">The dependency object to which the property is attached</param>
        /// <param name="newValue">The new value of the attached property</param>
        public static void AriaLabel_MethodToUpdateDom(DependencyObject d, object newValue)
        {
            if (d is FrameworkElement)
            {
                // Convert the value to string:
                string value = (newValue != null ? newValue.ToString() : "");

                // Get a reference to the <div> DOM element used to render the UI element:
                object div = CSHTML5.Interop.GetDiv((FrameworkElement)d);

                // Set the "Aria Label" attribute on the <div> via a JavaScript interop call:
                CSHTML5.Interop.ExecuteJavaScript("$0.setAttribute('aria-label', $1)", div, value);

                //Note: for documentation related to the commands above, please refer to http://www.cshtml5.com/links/how-to-call-javascript.aspx
            }
        }

    }
}