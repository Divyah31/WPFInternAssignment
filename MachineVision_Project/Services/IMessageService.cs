using System.Collections.ObjectModel;

namespace MachineVision_Project.Services
{
    public interface IMessageService
    {
        ObservableCollection<string> Messages { get; }
        void AddMessage(string message);
    }
}
