using MachineVision_Project.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Controls;

namespace MachineVision_Project.Views
{
    public partial class SenderView : UserControl
    {
        public SenderView()
        {
            InitializeComponent();

            // Inject SenderViewModel via DI
            //DataContext = App.ServiceProvider.GetRequiredService<SenderViewModel>();

        }
    }
}
