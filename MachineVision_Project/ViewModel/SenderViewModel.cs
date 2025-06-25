using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MachineVision_Project.Services;

namespace MachineVision_Project.ViewModels
{
    public partial class SenderViewModel : ObservableObject //ObservableObject comes from CommunityToolkit.Mvvm
    {
        private readonly IMessageService _messageService; //DI of 

        [ObservableProperty]
        private string messageText;

        public SenderViewModel(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [RelayCommand]
        private void Send()
        {
            if (!string.IsNullOrWhiteSpace(MessageText))
            {
                _messageService.AddMessage(MessageText);
                MessageText = string.Empty;
            }
        }
    }
}
