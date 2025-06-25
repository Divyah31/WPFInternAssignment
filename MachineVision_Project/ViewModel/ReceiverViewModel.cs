using CommunityToolkit.Mvvm.ComponentModel;
using MachineVision_Project.Services;
using System.Collections.ObjectModel;

namespace MachineVision_Project.ViewModels
{
    public partial class ReceiverViewModel : ObservableObject
    {
        public ObservableCollection<string> Messages => _messageService.Messages;

        private readonly IMessageService _messageService;

        public ReceiverViewModel(IMessageService messageService)
        {
            _messageService = messageService;
        }
    }
}
