namespace Notifications;

public sealed class Notification
{
    public string Key { get; set; } = null!;
    public string Message { get; set; } 

    public Notification(string key, string message)
    {
        Key = key;
        Message = message;
    }

    public Notification(string key, string message, params object[] args)
    {
        Key = key;
        Message = string.Format(message, args);
    }

    public Notification(string message, params object[] args)
        => Message = string.Format(message, args);   

    public Notification(params object[] args)
        => Message = string.Format("{0}", args);

    public override string ToString() => $"{Key}: {Message}";
}