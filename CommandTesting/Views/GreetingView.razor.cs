using CommandTesting.ViewModels;

namespace CommandTesting.Views
{
    public partial class GreetingView
    {
        public GreetingView()
        {
            ViewModel = new GreetingViewModel();
        }
    }
}
