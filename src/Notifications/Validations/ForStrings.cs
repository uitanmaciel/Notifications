using Notifications.Errors;

namespace Notifications.Validations;

public partial class ValidationRules<T>
{
    /// <summary>
    /// Validates that the length of the string does not exceed the specified maximum length.
    /// If the key is null or empty, or if the length exceeds the specified maximum, a notification is added.
    /// </summary>
    /// <param name="key">The key representing the string field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="maxLength">The maximum allowed length for the string.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> MaxLength(string key, string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if (key.Length > maxLength)
            AddNotification(new Notification(Error.MaxLength(key, maxLength)));
        return this;
    }

    /// <summary>
    /// Validates that the length of the string does not exceed the specified maximum length, with a custom error message.
    /// If the key is null or empty, or if the length exceeds the specified maximum, a custom notification is added.
    /// </summary>
    /// <param name="key">The key representing the string field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="maxLength">The maximum allowed length for the string.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> MaxLength(string key, string value, int maxLength, string message)
    {
        if (string.IsNullOrEmpty(value))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if (key.Length > maxLength)
            AddNotification(new Notification(key, message));
        return this;
    }

    /// <summary>
    /// Validates that the length of the string meets or exceeds the specified minimum length.
    /// If the key is null or empty, or if the length is less than the specified minimum, a notification is added.
    /// </summary>
    /// <param name="key">The key representing the string field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="minLength">The minimum required length for the string.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> MinLength(string key, string value, int minLength)
    {
        if (string.IsNullOrEmpty(value))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if (key.Length < minLength)
            AddNotification(new Notification(Error.MinLength(key, minLength)));
        return this;
    }

    /// <summary>
    /// Validates that the length of the string meets or exceeds the specified minimum length, with a custom error message.
    /// If the key is null or empty, or if the length is less than the specified minimum, a custom notification is added.
    /// </summary>
    /// <param name="key">The key representing the string field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="minLength">The minimum required length for the string.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> MinLength(string key, string value, int minLength, string message)
    {
        if (string.IsNullOrEmpty(value))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if (key.Length < minLength)
            AddNotification(new Notification(key, message));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is not null or an empty string.
    /// If the key is null or empty, a standard notification indicating the field should not be null is added.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNotNull(string key, string value)
    {
        if (string.IsNullOrEmpty(key))
            AddNotification(new Notification(Error.IsNotNull(key)));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is not null or an empty string, with a custom error message.
    /// If the key is null or empty, a custom notification is added using the provided message.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNotNull(string key, string value, string message)
    {
        if (string.IsNullOrEmpty(value))
            AddNotification(new Notification(key, message));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is null or an empty string.
    /// If the key is not null or empty, a standard notification indicating the field should be null is added.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNull(string key, string value)
    {
        if (!string.IsNullOrEmpty(value))
            AddNotification(new Notification(Error.IsNull(key)));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is null or an empty string, with a custom error message.
    /// If the key is not null or empty, a custom notification is added using the provided message.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNull(string key, string value, string message)
    {
        if (!string.IsNullOrEmpty(value))
            AddNotification(new Notification(key, message));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is null or an empty string.
    /// If the key is not null and not empty, a standard notification indicating the field should be null or empty is added.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNullOrEmpty(string key, string value)
    {
        if (!string.IsNullOrEmpty(value))
            AddNotification(new Notification(key, Error.IsNullOrEmpty(key)));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is null or an empty string, with a custom error message.
    /// If the key is not null and not empty, a custom notification is added using the provided message.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNullOrEmpty(string key, string value, string message)
    {
        if (!string.IsNullOrEmpty(value))
            AddNotification(new Notification(key, message));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is not null and not an empty string.
    /// If the key is null or empty, a standard notification indicating the field should not be null or empty is added.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNotNullOrEmpty(string key, string value)
    {
        if (string.IsNullOrEmpty(value))
            AddNotification(new Notification(key, Error.IsNotNullOrEmpty(key)));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is not null and not an empty string, with a custom error message.
    /// If the key is null or empty, a custom notification is added using the provided message.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNotNullOrEmpty(string key, string value,string message)
    {
        if (string.IsNullOrEmpty(value))
            AddNotification(new Notification(key, message));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is null, an empty string, or consists only of white-space characters.
    /// If the key is not null, not empty, and not just white-space, a standard notification indicating the field should be null or white-space is added.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNullOrWhiteSpace(string key, string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            AddNotification(new Notification(key, Error.IsNullOrWhiteSpace(key)));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is null, an empty string, or consists only of white-space characters, with a custom error message.
    /// If the key is not null, not empty, and not just white-space, a custom notification is added using the provided message.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNullOrWhiteSpace(string key, string value, string message)
    {
        if (!string.IsNullOrWhiteSpace(value))
            AddNotification(new Notification(key, message));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is not null, not an empty string, and does not consist only of white-space characters.
    /// If the key is null, empty, or consists only of white-space characters, a standard notification indicating the field should not be null or white-space is added.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNotNullOrWhiteSpace(string key, string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            AddNotification(new Notification(key, Error.IsNotNullOrWhiteSpace(key)));
        return this;
    }

    /// <summary>
    /// Validates that the specified key is not null, not an empty string, and does not consist only of white-space characters, with a custom error message.
    /// If the key is null, empty, or consists only of white-space characters, a custom notification is added using the provided message.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsNotNullOrWhiteSpace(string key, string value, string message)
    {
        if (string.IsNullOrWhiteSpace(value))
            AddNotification(new Notification(key, message));
        return this;
    }

    /// <summary>
    /// Validates that the length of the specified key is greater than the provided value.
    /// If the key is null or empty, or its length is not greater than the provided value, a standard notification is added.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="biggerThan">The integer value that the length of the key should be greater than.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsBiggerThan(string key, string value, int biggerThan)
    {
        if (string.IsNullOrEmpty(value))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if(key.Length < biggerThan)
            AddNotification(new Notification(Error.IsBiggerThan(key, biggerThan)));
        return this;
    }

    /// <summary>
    /// Validates that the length of the specified key is greater than the provided value, with a custom error message.
    /// If the key is null or empty, or its length is not greater than the provided value, a custom notification is added using the provided message.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="biggerThan">The integer value that the length of the key should be greater than.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsBiggerThan(string key, string value, int biggerThan, string message)
    {
        if (string.IsNullOrEmpty(value))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if(key.Length < biggerThan)
            AddNotification(new Notification(key, message));
        return this;
    }

    /// <summary>
    /// Validates that the length of the specified key is less than the provided value.
    /// If the key is null or empty, or its length is not less than the provided value, a standard notification is added.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="lowerThan">The integer value that the length of the key should be less than.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsLowerThan(string key, string value, int lowerThan)
    {
        if (string.IsNullOrEmpty(value))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if(key.Length >= lowerThan)
            AddNotification(new Notification(Error.IsLowerThan(key, lowerThan)));
        return this;
    }

    /// <summary>
    /// Validates that the length of the specified key is less than the provided value, with a custom error message.
    /// If the key is null or empty, or its length is not less than the provided value, a custom notification is added using the provided message.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="lowerThan">The integer value that the length of the key should be less than.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsLowerThan(string key, string value, int lowerThan, string message)
    {
        if (string.IsNullOrEmpty(value))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if(key.Length >= lowerThan)
            AddNotification(new Notification(key, message));
        return this;
    }

    /// <summary>
    /// Validates that the length of the specified key is between the provided range (inclusive of 'from' and exclusive of 'to').
    /// If the key is null or empty, or its length is not within the specified range, a standard notification is added.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="from">The inclusive lower bound of the range the length of the key should fall within.</param>
    /// <param name="to">The exclusive upper bound of the range the length of the key should fall within.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsBetween(string key, string value, int from, int to)
    {
        if (string.IsNullOrEmpty(value))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if(key.Length <= from && key.Length > to  )
            AddNotification(new Notification(Error.IsBetween(key, from, to)));
        return this;
    }

    /// <summary>
    /// Validates that the length of the specified key is between the provided range (inclusive of 'from' and exclusive of 'to'), with a custom error message.
    /// If the key is null or empty, or its length is not within the specified range, a custom notification is added using the provided message.
    /// </summary>
    /// <param name="key">The key representing the field in the object being validated.</param>
    /// <param name="value">The string value to be validated.</param>
    /// <param name="from">The inclusive lower bound of the range the length of the key should fall within.</param>
    /// <param name="to">The exclusive upper bound of the range the length of the key should fall within.</param>
    /// <param name="message">The custom error message to be used in the notification if validation fails.</param>
    /// <returns>The current instance of <see cref="ValidationRules{T}"/> after performing the validation.</returns>
    public ValidationRules<T> IsBetween(string key, string value, int from, int to, string message)
    {
        if (string.IsNullOrEmpty(value))
        {
            AddNotification(new Notification(Error.IsNotNullOrEmpty(key)));
            return this;
        }
        if(key.Length <= from && key.Length > to  )
            AddNotification(new Notification(key, message));
        return this;
    }
}