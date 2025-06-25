using CommunityToolkit.Mvvm.ComponentModel;

namespace MachineVision_Project.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public SenderViewModel SenderVM { get; }
        public ReceiverViewModel ReceiverVM { get; }

        public MainViewModel(SenderViewModel senderVM, ReceiverViewModel receiverVM)
        {
            SenderVM = senderVM;
            ReceiverVM = receiverVM;
        }
    }
}
