namespace Notifications.Tests.ValidationsTests.Password;

[TestClass]
public class PasswordValidTest
{
    /// <summary>
    /// Tests the IsPassword method in the ValidationRules class with a valid password.
    /// The method should recognize a valid password that meets the specified minimum length and complexity requirements.
    /// As a result, it should not add any notifications to the validation instance, indicating the password is valid.
    /// </summary>
    [TestMethod]
    public void ValidationPassword_Valid_Test()
    {
        // Arrange
        // Create a new instance of ValidationRules for an object.
        // Define a valid password string that meets the required criteria (minimum length and complexity).
        // Set the minimum length for the password validation.
        var validation = new ValidationRules<object>();
        var password = "@A1b2c3d4";
        int min = 8;
        
        // Act
        // Call the IsPassword method with the "Password" key, the valid password string, and the minimum length.
        // This should perform the validation and, because the password is valid,
        // not add any notification to the validation instance.
        validation.IsPassword("Password", password, min);
        
        // Assert
        // Verify that the validation instance has no notifications,
        // indicating that the password was correctly identified as valid.
        Assert.IsTrue(!validation.HasNotifications);
    }
}