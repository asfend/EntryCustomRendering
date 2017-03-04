using System;
using System.Collections.Generic;
using System.Text;
using EntryCustomRendering;
using EntryCustomRendering.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NoBorderEntry), typeof(NoBorderEntryRenderer))]
namespace EntryCustomRendering.iOS
{
    public class NoBorderEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Unsubscribe from event handlers and cleanup any resources
            }

            if (e.NewElement != null)
            {
                // Configure the native control and subscribe to event handlers
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }
    }
}
