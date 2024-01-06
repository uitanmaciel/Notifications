namespace Notifications;

public interface INotifications
{
    /// <summary>
    /// Gets a value indicating whether there are any notifications present.
    /// </summary>
    bool HasNotifications { get; }
    
    /// <summary>
    /// Gets the current list of notifications as a read-only collection.
    /// This ensures notifications can't be modified directly outside of the defined methods.
    /// </summary>
    IReadOnlyCollection<Notification> Notifications { get; }
    
    /// <summary>
    /// Adds a notification to the system with a specific key and message.
    /// </summary>
    /// <param name="key">The key associated with the notification.</param>
    /// <param name="message">The message content of the notification.</param>
    void AddNotification(string key, string message);
    
    /// <summary>
    /// Adds a notification to the system with just a message, no key.
    /// </summary>
    /// <param name="message">The message content of the notification.</param>
    void AddNotification(string message);
    
    /// <summary>
    /// Adds a formatted notification with a key, message, and additional arguments.
    /// Typically used for localized or formatted messages.
    /// </summary>
    /// <param name="key">The key associated with the notification.</param>
    /// <param name="message">The message template.</param>
    /// <param name="args">Additional arguments for message formatting.</param>
    void AddNotification(string key, string message, params object[] args);
    
    /// <summary>
    /// Adds a formatted notification with a message and additional arguments, without a specific key.
    /// </summary>
    /// <param name="message">The message template.</param>
    /// <param name="args">Additional arguments for message formatting.</param>
    void AddNotification(string message, params object[] args);

    /// <summary>
    /// Adds a formatted notification with a message and additional arguments, without a specific key.
    /// </summary>
    /// <param name="args">Additional arguments for message formatting.</param>
    void AddNotification(params object[] args);
    
    /// <summary>
    /// Adds a notification directly using a Notification object.
    /// </summary>
    /// <param name="notification">The notification object to add.</param>
    void AddNotification(Notification notification);
    
    /// <summary>
    /// Adds a notification directly using a Notification object.
    /// </summary>
    /// <param name="notifier">The notifier object to add.</param>
    void AddNotifications(Notifier notifier);
    
    /// <summary>
    /// Adds multiple notifications at once from a collection of Notification objects.
    /// </summary>
    /// <param name="notifications">A collection of notifications to add.</param>
    void AddNotifications(IEnumerable<Notification> notifications);
    
    /// <summary>
    /// Clears all the current notifications.
    /// This might be used when notifications have been processed or are no longer relevant.
    /// </summary>
    void ClearNotifications();
}