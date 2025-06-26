using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MachineVision_Project.Services;
using System.Windows;

namespace MachineVision_Project.ViewModels
{
    public partial class SenderViewModel : ObservableObject //ObservableObject comes from CommunityToolkit.Mvvm
    {
        private readonly IMessageService _messageService; //DI of service

        [ObservableProperty]
        private string messageText;

        [ObservableProperty]
        private string confirmationMessage;

        public SenderViewModel(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [RelayCommand]
        private async void Send()
        {
            if (string.IsNullOrWhiteSpace(MessageText))
            {
                MessageBox.Show("Text box cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            _messageService.AddMessage(MessageText);
            MessageText = string.Empty;

            ConfirmationMessage = "Message sent!";
            // Wait 2 seconds, then clear it
            await Task.Delay(2000);
            ConfirmationMessage = string.Empty;
        }
    }
}
