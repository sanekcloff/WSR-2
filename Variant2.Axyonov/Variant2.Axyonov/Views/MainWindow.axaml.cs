using Avalonia.Controls;
using Variant2.Axyonov.ViewModels;

namespace Variant2.Axyonov.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
