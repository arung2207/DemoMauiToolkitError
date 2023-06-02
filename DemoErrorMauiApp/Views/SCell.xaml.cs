using DemoErrorMauiApp.ViewModels;

namespace DemoErrorMauiApp.Views;

public partial class SCell : ContentView
{
    public SCell()
    {
        InitializeComponent();

        //Either of the following throws error
        //BindingContext = new SCellViewModel();
        BindingContext = new SCellViewModel { Candidates = new List<string>() };

        //Following runs without error
        //BindingContext = new SCellViewModel { Candidates = new List<string> {""} };
        //BindingContext = new SCellViewModel { Candidates = new List<string> {"1","Q","-8"} };
    }
}