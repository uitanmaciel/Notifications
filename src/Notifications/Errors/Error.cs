namespace Notifications.Errors;

public abstract class Error
{
    /// <summary>
    /// Creates a required field error notification.
    /// </summary>
    /// <param name="key">The key identifying the field that is required.</param>    
    /// <returns>A notification indicating that the field is required.</returns>
    public static string IsRequired(string key) 
        => $"The field '{key}' is required";
    
    /// <summary>
    /// Creates a maximum length error notification.
    /// </summary>
    /// <param name="key">The key identifying the field with a maximum length constraint.</param>    
    /// <param name="maxLength">The maximum allowed length for the field.</param>
    /// <returns>A notification indicating that the field exceeds the maximum allowed length.</returns>
    public static string MaxLength(string key, int maxLength) 
        => $"The field '{key}' must have a maximum of {maxLength} characters";
    
    /// <summary>
    /// Creates a minimum length error notification.
    /// </summary>
    /// <param name="key">The key identifying the field with a minimum length constraint.</param>
    /// <param name="minLength">The minimum required length for the field.</param>
    /// <returns>A notification indicating that the field does not meet the minimum required length.</returns>
    public static string MinLength(string key, int minLength) 
        => $"The field '{key}' must have a minimum of {minLength} characters";
    
    /// <summary>
    /// Creates an email error notification.
    /// </summary>
    /// <param name="value">The value of the field.</param>
    /// <returns>A notification indicating that the field does not contain a valid email.</returns>
    public static string Email(string value) 
        => $"The '{value}' is not a valid email";
    
    /// <summary>
    /// Creates a generic invalid field error notification.
    /// </summary>
    /// <param name="key">The key identifying the invalid field.</param>
    /// <returns>A notification indicating that the field is invalid.</returns>
    public static string Invalid(string key) 
        => $"The value of field '{key}' is invalid";
    
    /// <summary>
    /// Creates a null field error notification.
    /// </summary>
    /// <param name="key">The key identifying the field that must be null.</param>
    /// <returns>A notification indicating that the field must be null.</returns>
    public static string IsNull(string key) 
        => $"The field '{key}' must be null";

    /// <summary>
    /// Creates a not null field error notification.
    /// </summary>
    /// <param name="key">The key identifying the field that must not be null.</param>
    /// <returns>A notification indicating that the field must not be null.</returns>
    public static string IsNotNull(string key) 
        => $"The field '{key}' must not be null";

    /// <summary>
    /// Creates a not null field error notification.
    /// </summary>
    /// <param name="key">The key identifying the field that must bigger than value param.</param>
    /// <param name="value">The value required for field.</param>
    /// <returns>A notification indicating that the field does not meet the bigger required length.</returns>
    public static string IsBiggerThan(string key, int value) 
        => $"The field '{key}' must be bigger than {value}";

    /// <summary>
    /// Creates a not null field error notification.
    /// </summary>
    /// <param name="date">The date reported for comparison.</param>
    /// <param name="comparer">The reference date for comparison.</param>
    /// <param name="key">The identification key of the field to be compared.</param>
    /// <returns>A notification indicating that the field is not bigger than the reference date.</returns>
    public static string IsBiggerThan(DateTime date, DateTime comparer, string key) 
        => $"The field '{key}' must be bigger than {comparer}";

    /// <summary>
    /// Creates a not null field error notification.
    /// </summary>
    /// <param name="key">The key identifying the field that must lower than value param.</param>
    /// <param name="value">The value required for field.</param>
    /// <returns>A notification indicating that the field does not meet the lower required length.</returns>
    public static string IsLowerThan(string key, int value) 
        => $"The field '{key}' must be lower than {value}";

    /// <summary>
    /// Creates a notification indicating that a field's value must fall within a specific range.
    /// </summary>
    /// <param name="key">The key identifying the field to check.</param>
    /// <param name="from">The minimum allowed value for the field.</param>
    /// <param name="to">The maximum allowed value for the field.</param>
    /// <returns>A notification indicating that the field must be between the specified minimum and maximum values.</returns>
    public static string IsBetween(string key, int from, int to) 
        => $"The value of field '{key}' must be between {from} and {to}";
    
    /// <summary>
    /// Creates a notification indicating that a field must be null or empty.
    /// </summary>
    /// <param name="key">The key identifying the field to check.</param>
    /// <returns>A notification indicating that the field must be null or empty.</returns>
    public static string IsNullOrEmpty(string key) 
        => $"The field '{key}' must be null or empty";
    
    /// <summary>
    /// Creates a notification indicating that a field must not be null or empty.
    /// </summary>
    /// <param name="key">The key identifying the field to check.</param>
    /// <returns>A notification indicating that the field must not be null or empty.</returns>
    public static string IsNotNullOrEmpty(string key) 
        => $"The field '{key}' must not be null or empty";
    
    /// <summary>
    /// Creates a notification indicating that a field must be null or contain only white space.
    /// </summary>
    /// <param name="key">The key identifying the field to check.</param>
    /// <returns>A notification indicating that the field must be null or contain only white space.</returns>
    public static string IsNullOrWhiteSpace(string key) 
        => $"The field '{key}' must be null or contain white space";
    
    /// <summary>
    /// Creates a notification indicating that a field must not be null and must contain more than just white space.
    /// </summary>
    /// <param name="key">The key identifying the field to check.</param>
    /// <returns>A notification indicating that the field must not be null or contain only white space.</returns>
    public static string IsNotNullOrWhiteSpace(string key) 
        => $"The field '{key}' must not be null or contain white space";
}