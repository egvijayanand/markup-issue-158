namespace TestLib
{
	public class HomePage : ContentPage
	{
		public HomePage()
		{
			Content = new Grid
			{
				Children =
				{
					new Label
					{
						Text = "Welcome to .NET MAUI!!!"
					}.Center()
				}
			};
		}
	}
}
