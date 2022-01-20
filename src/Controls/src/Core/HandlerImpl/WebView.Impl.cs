namespace Microsoft.Maui.Controls
{
	/// <include file="../../../docs/Microsoft.Maui.Controls/WebView.xml" path="Type[@FullName='Microsoft.Maui.Controls.WebView']/Docs" />
	public partial class WebView : IWebView
	{
		IWebViewSource IWebView.Source => Source;
	}
}