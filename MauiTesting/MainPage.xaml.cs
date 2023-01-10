namespace MauiTesting;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		var t = DisplayAlert("提示", "测试文字，展示弹窗效果", "确定");

		await Task.Delay(2000);

        count++;

		var button = (Button)sender;
		if (count == 1)
			button.Text = $"Clicked {count} time";
		else
            button.Text = $"Clicked {count} times";
        
		await t;
		await DisplayAlert("提示", "22222222", "确定");
	}
}

