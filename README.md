# WPFInternAssignment
A simple WPF desktop app using the MVVM pattern, CommunityToolkit.Mvvm, and Microsoft.Extensions.DependencyInjection.

# Features

- Two-tab interface: Sender and Receiver
- Messages sent from Sender appear instantly in Receiver
- Built with clean MVVM separation
- Uses Dependency Injection for ViewModel and Service sharing
- Responsive layout that handles window resizing


# Setup Instructions

1. Open the solution in **Visual Studio 2022+**
2. Restore NuGet packages (right-click on solution > Restore)
3. Build the project
4. Run the app (`F5` or Debug > Start Debugging)

# High Level Architecture

# [SenderView] → [SenderViewModel] → [MessageService] → [ReceiverViewModel] → [ReceiverView]

- `SenderViewModel` calls `MessageService.AddMessage()`
- `MessageService` (registered as a singleton) holds shared messages
- `ReceiverViewModel` reads from the same service
- `ObservableCollection` ensures live updates in UI





