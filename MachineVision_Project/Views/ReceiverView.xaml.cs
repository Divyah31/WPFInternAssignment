using MachineVision_Project.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Controls;

namespace MachineVision_Project.Views
{
    public partial class ReceiverView : UserControl
    {
        public ReceiverView()
        {
            InitializeComponent();

            // Inject ReceiverViewModel using DI
           // DataContext = App.ServiceProvider.GetRequiredService<ReceiverViewModel>();
        }
    }
}
