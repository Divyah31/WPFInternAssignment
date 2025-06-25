using System.Collections.ObjectModel;

namespace MachineVision_Project.Services
{
    public class MessageService : IMessageService
    {
        public ObservableCollection<string> Messages { get; } = new();

        public void AddMessage(string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                Messages.Add(message);
            }
        }
    }
}
