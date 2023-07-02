using System.Diagnostics;

namespace ColorPicker;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    void ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        var red = SliderRed.Value;
        var green = SliderGreen.Value;
        var blue = SliderBlue.Value;

        Color color = Color.FromRgb(red, green, blue);
        Debug.WriteLine(SliderRed.Value);
        SetColor(color);
    }

    private void SetColor(Color color)
    {
        btnRandom.BackgroundColor = color;
        Container.Background = color;
        lblHex.Text = color.ToHex();

    }

    void btnRandom_Clicked(System.Object sender, System.EventArgs e)
    {
        var random = new Random();
        var red = random.Next(0, 255);
        var green = random.Next(0, 255);
        var blue = random.Next(0, 255);
        var color = Color.FromRgb(red, green, blue);
        setSlider(color);
        SetColor(color);
    }

    private void setSlider(Color color)
    {
        SliderRed.Value = color.Red;
        SliderGreen.Value = color.Green;
        SliderBlue.Value = color.Blue;
    }
}


