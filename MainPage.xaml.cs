using System.Globalization;

namespace MauiLocalization;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        if (LangResources.Culture != null && LangResources.Culture.TwoLetterISOLanguageName.Contains("ta"))
        {
            CounterBtn.Text = "Change to English";
        }
        else
        {
            CounterBtn.Text = "Change to Tamil";
        }
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (CounterBtn.Text.Contains("Tamil"))
        {
            LangResources.Culture = new CultureInfo("ta");
            CounterBtn.Text = "Change to English";
        }
        else
        {
            LangResources.Culture = CultureInfo.InvariantCulture;
            CounterBtn.Text = "Change to Tamil";
        }
        App.Current.MainPage = new MainPage();
    }
}

