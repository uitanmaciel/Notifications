using System.Text.RegularExpressions;
using Notifications.Errors;

namespace Notifications.Validations;

public partial class ValidationRules<T>
{
    /// <summary>
    /// Validates that the specified key corresponds to a valid password.
    /// A valid password must meet a specified minimum length and a regex pattern for complexity.
    /// If the key is null or empty, too short, or doesn't match the pattern, a notification is added.
    /// </summary>
    /// <param name="key">The key representing the password field in the object being validated.</param>
    /// <param name="password">The password to be validated.</param>
    /// <param name="min">The minimum length the password must have.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsPassword(string key, string password, int min)
    {
        if(string.IsNullOrEmpty(password))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if(string.IsNullOrWhiteSpace(password))
        {
            AddNotification(new Notification(Error.IsNotNullOrWhiteSpace(key)));
            return this;
        }
        if (password.Length < min)
        {
            AddNotification(new Notification(Error.MinLength(key, min)));
            return this;
        }
        if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{"+ min +",}$"))
            AddNotification(new Notification(Error.Invalid(key)));
        return this;
    }

    /// <summary>
    /// Validates that the specified key corresponds to a valid password with a custom error message.
    /// A valid password must meet a specified minimum length and a regex pattern for complexity.
    /// If the key is null or empty, too short, or doesn't match the pattern, a custom notification is added.
    /// </summary>
    /// <param name="key">The key representing the password field in the object being validated.</param>
    /// <param name="password">The password to be validated.</param>
    /// <param name="min">The minimum length the password must have.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsPassword(string key, string password, int min, string message)
    {
        if(string.IsNullOrEmpty(password))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if(string.IsNullOrWhiteSpace(password))
        {
            AddNotification(new Notification(Error.IsNotNullOrWhiteSpace(key)));
            return this;
        }
        if(password.Length <= min)
        {
            AddNotification(new Notification(key, message));
            return this;
        }
        if(!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{"+ min +",}$"))
            AddNotification(new Notification(key, message));
        return this;
    }
}