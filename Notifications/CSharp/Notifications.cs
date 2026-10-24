using System;

namespace OOP_Practice.Notifications.CSharp
{
    internal interface INotifier
    {
        void Send(string message);
    }

    internal class EmailNotifier : INotifier
    {
        public string Email { get; }

        public EmailNotifier(string email)
        {
            Email = email;
        }

        public void Send(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Message cannot be empty.");
                return;
            }

            Console.WriteLine($"Email to {Email}: {message}");
        }
    }

    internal class SmsNotifier : INotifier
    {
        public string PhoneNumber { get; }

        public SmsNotifier(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public void Send(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Message cannot be empty.");
                return;
            }

            Console.WriteLine($"SMS to {PhoneNumber}: {message}");
        }
    }

    internal class NotificationService
    {
        private readonly INotifier notifier;

        public NotificationService(INotifier notifier)
        {
            this.notifier = notifier;
        }

        public void Notify(string message)
        {
            notifier.Send(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            INotifier emailNotifier =
                new EmailNotifier("student@example.com");

            INotifier smsNotifier =
                new SmsNotifier("+38970000000");

            NotificationService emailService =
                new NotificationService(emailNotifier);

            NotificationService smsService =
                new NotificationService(smsNotifier);

            emailService.Notify("Your registration is confirmed.");
            smsService.Notify("Your session starts in 30 minutes.");

            Console.WriteLine();

            emailService.Notify("");
            smsService.Notify("   ");
        }
    }
}