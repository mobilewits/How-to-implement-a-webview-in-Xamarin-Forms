using System;

using Xamarin.Forms;

namespace WebViewXamarinForms
{
	public class WebViewPage : ContentPage
	{
		public WebViewPage ()
		{
			Label lbl_header = new Label {
				Text = "WebView",
				HorizontalOptions = LayoutOptions.Center
			};
			WebView webview = new WebView {
				Source = "http://google.com",
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			this.Content = new StackLayout {
				Children = {
					 webview
				}
			};
		
		}
	}
}


