namespace Notifications;

public class Notifier : INotifications
{
    private readonly List<Notification> _notifications = new();
    public IReadOnlyCollection<Notification> Notifications => _notifications;
    public bool HasNotifications => _notifications.Any();

    public void AddNotification(string key, string message)
        => AddNotification(new Notification(key, message));

    public void AddNotification(string message)
        => AddNotification(new Notification(message));

    public void AddNotification(string key, string message, params object[] args)
        => AddNotification(new Notification(key, message, args));
    
    public void AddNotification(string message, params object[] args)
        => AddNotification(new Notification(message, args));

    public void AddNotification(params object[] args)
        => AddNotification(new Notification(args));
    
    public void AddNotification(Notification notification)
        => _notifications.Add(notification);

    public void AddNotifications(Notifier notifier)
        => AddNotifications(notifier.Notifications);
    
    public void AddNotifications(IEnumerable<Notification> notifications)
        => _notifications.AddRange(notifications);

    public void ClearNotifications()
        => _notifications.Clear();
}