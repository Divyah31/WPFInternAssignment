using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using MachineVision_Project.Services;

namespace MachineVision_Project.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private object currentViewModel;

        private readonly SenderViewModel _senderViewModel;
        private readonly ReceiverViewModel _receiverViewModel;

        public MainViewModel(SenderViewModel sender, ReceiverViewModel receiver)
        {
            _senderViewModel = sender;
            _receiverViewModel = receiver;

            // Default view
            CurrentViewModel = _senderViewModel;
        }

        [RelayCommand]
        private void ShowSender()
        {
            CurrentViewModel = _senderViewModel;
        }

        [RelayCommand]
        private void ShowReceiver()
        {
            CurrentViewModel = _receiverViewModel;
        }
    }
}
