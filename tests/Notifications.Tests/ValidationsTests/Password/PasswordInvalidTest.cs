namespace Notifications.Tests.ValidationsTests.Password;

[TestClass]
public class PasswordInvalidTest
{
    /// <summary>
    /// Tests the IsPassword method in the ValidationRules class with an empty password.
    /// This method should recognize the password as invalid since it doesn't meet the minimum length criteria and is empty.
    /// As a result, it should add a specific notification to the validation instance indicating that the password field must not be null or empty.
    /// </summary>
    [TestMethod]
    public void ValidationPassword_IsNotNullOrEmpty_Invalid_Test()
    {
        // Arrange
        // Create a new instance of ValidationRules for an object.
        // Define an empty password string to simulate a user not entering a password.
        // Set the expected notification message for a null or empty password.
        // Set the minimum length for the password validation.
        var validation = new ValidationRules<object>();
        var notificationMessageExpected = $"The field 'Password' must not be null or empty";
        var password = string.Empty;
        int min = 8;
        
        // Act
        // Call the IsPassword method with the "Password" key, the empty password string, and the minimum length.
        // This should perform the validation and, because the password is empty,
        // add a notification to the validation instance indicating the field must not be null or empty.
        validation.IsPassword("Password", password, min);
        
        // Assert
        // Verify that the validation instance has notifications, indicating that the password was identified as invalid.
        Assert.IsTrue(validation.HasNotifications);
        
        // Verify that the specific expected notification message is among the notifications added.
        bool notificationMessageExpectedFound = NotificationMessageExpectedFound(
            validation.Notifications,
            notificationMessageExpected);
        
        // Assert that the expected notification message was found.
        Assert.IsTrue(notificationMessageExpectedFound, notificationMessageExpected);
    }

    /// <summary>
    /// Tests the IsPassword method in the ValidationRules class with a password containing only whitespace.
    /// This method should recognize the password as invalid since it doesn't meet the requirement of being non-empty and free of whitespace.
    /// As a result, it should add a specific notification to the validation instance indicating that the password field must not be null or contain whitespace.
    /// </summary>
    [TestMethod]
    public void ValidationPassword_IsNotNullOrWhitespace_Invalid_Test()
    {
        // Arrange
        // Create a new instance of ValidationRules for an object.
        // Define a password string containing only whitespace to simulate a user entering an effectively empty password.
        // Set the expected notification message for a password containing only whitespace.
        // Set the minimum length for the password validation.
        var validation = new ValidationRules<object>();
        var notificationMessageExpected = $"The field 'Password' must not be null or contain white space";
        var password = " ";
        int min = 8;
        
        // Act
        // Call the IsPassword method with the "Password" key, the whitespace-only password string, and the minimum length.
        // This should perform the validation and, because the password is effectively empty,
        // add a notification to the validation instance indicating the field must not be null or contain whitespace.
        validation.IsPassword("Password", password, min);
        
        // Assert
        // Verify that the validation instance has notifications, indicating that the password was identified as invalid.
        Assert.IsTrue(validation.HasNotifications);
        
        // Verify that the specific expected notification message is among the notifications added.
        bool notificationMessageExpectedFound = NotificationMessageExpectedFound(
            validation.Notifications,
            notificationMessageExpected);
        
        // Assert that the expected notification message was found.
        Assert.IsTrue(notificationMessageExpectedFound, notificationMessageExpected);
    }

    /// <summary>
    /// Tests the IsPassword method in the ValidationRules class with a password that is shorter than the specified minimum length.
    /// This method should recognize the password as invalid since it doesn't meet the minimum length requirement.
    /// As a result, it should add a specific notification to the validation instance indicating that the password field must have a minimum number of characters.
    /// </summary>
    [TestMethod]
    public void ValidationPassword_MinLength_Invalid_Test()
    {
        // Arrange
        // Create a new instance of ValidationRules for an object.
        // Define a password string that is shorter than the required minimum length to simulate a user entering an insufficiently long password.
        // Set the expected notification message for a password that is too short.
        // Set the minimum length for the password validation.
        var validation = new ValidationRules<object>();
        var notificationMessageExpected = $"The field 'Password' must have a minimum of 8 characters";
        var password = "@A1b2c3";
        int min = 8;
        
        // Act
        // Call the IsPassword method with the "Password" key, the too-short password string, and the minimum length.
        // This should perform the validation and, because the password is too short,
        // add a notification to the validation instance indicating the field must have a minimum number of characters.
        validation.IsPassword("Password", password, min);
        
        // Assert
        // Verify that the validation instance has notifications, indicating that the password was identified as invalid.
        Assert.IsTrue(validation.HasNotifications);
        
        // Verify that the specific expected notification message is among the notifications added.
        bool notificationMessageExpectedFound = NotificationMessageExpectedFound(
            validation.Notifications,
            notificationMessageExpected);
        
        // Assert that the expected notification message was found.
        Assert.IsTrue(notificationMessageExpectedFound, notificationMessageExpected);
    }
    
    /// <summary>
    /// Tests the IsPassword method in the ValidationRules class with a password that doesn't match the required regex pattern.
    /// This method should recognize the password as invalid since it doesn't meet the complexity requirements defined by the regex pattern.
    /// As a result, it should add a specific notification to the validation instance indicating that the value of the password field is invalid.
    /// </summary>
    [TestMethod]
    public void ValidationPassword_RegexIsMatch_Invalid_Test()
    {
        // Arrange
        // Create a new instance of ValidationRules for an object.
        // Define a password string that doesn't match the required regex pattern, simulating a user entering a password without the necessary complexity.
        // Set the expected notification message for a password that doesn't meet the complexity requirements.
        // Set the minimum length for the password validation.
        var validation = new ValidationRules<object>();
        var notificationMessageExpected = $"The value of field 'Password' is invalid";
        var password = "a1b2c3d4";
        int min = 8;
        
        // Act
        // Call the IsPassword method with the "Password" key, the password string that doesn't meet the regex pattern, and the minimum length.
        // This should perform the validation and, because the password doesn't match the regex pattern,
        // add a notification to the validation instance indicating the password value is invalid.
        validation.IsPassword("Password", password, min);
        
        // Assert
        // Verify that the validation instance has notifications, indicating that the password was identified as invalid.
        Assert.IsTrue(validation.HasNotifications);
        
        // Verify that the specific expected notification message is among the notifications added.
        bool notificationMessageExpectedFound = NotificationMessageExpectedFound(
            validation.Notifications,
            notificationMessageExpected);
        
        // Assert that the expected notification message was found.
        Assert.IsTrue(notificationMessageExpectedFound, notificationMessageExpected);
    }
    
    /// <summary>
    /// Checks if a specific notification message exists within a collection of notifications.
    /// </summary>
    /// <param name="notifications">The collection of Notification objects to search through.</param>
    /// <param name="notificationCompare">The notification message to look for.</param>
    /// <returns>True if the specified notification message is found in the collection; otherwise, false.</returns>
    bool NotificationMessageExpectedFound(IReadOnlyCollection<Notification> notifications, string notificationCompare)
    {
        bool notificationMessageExpectedFound = false;
        foreach (var notification in notifications)
        {
            if (notification.Message.Equals(notificationCompare))
            {
                notificationMessageExpectedFound = true;
                break;
            }
        }
        return notificationMessageExpectedFound;
    }
}