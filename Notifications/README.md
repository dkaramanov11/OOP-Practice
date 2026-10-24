# Notifications — Notification Service

Create a system for sending notifications through different channels.

## Requirements

- Create an interface INotifier with a method:
  void Send(string message).

- Create an EmailNotifier class that implements INotifier.
- Initialize its read-only Email property through a constructor.
- Send() prints the recipient's email and the message.

- Create an SmsNotifier class that implements INotifier.
- Initialize its read-only PhoneNumber property through a constructor.
- Send() prints the recipient's phone number and the message.

- Both implementations must reject null, empty, or whitespace-only
  messages by displaying an error message.

- Create a NotificationService class.
- Receive an INotifier through its constructor.
- Add a Notify(string message) method that delegates sending
  to the provided notifier.

- Simulate sending with Console.WriteLine.
  No actual emails or SMS messages should be sent.

## Testing

In Main:
1. Create an email notifier and an SMS notifier.
2. Create a notification service for each notifier.
3. Send a valid notification through each service.
4. Test an empty message and a whitespace-only message.