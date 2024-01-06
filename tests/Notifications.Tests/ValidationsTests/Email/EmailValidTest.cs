namespace Notifications.Tests.ValidationsTests.Email;

[TestClass]
public class EmailValidTest
{
    /// <summary>
    /// Tests the IsEmail method in the ValidationRules class with a valid email address.
    /// The method should recognize the valid email and thus not add any notification to the validation instance,
    /// indicating that the email passes the validation criteria.
    /// </summary>
    [TestMethod]
    public void ValidationEmail_IsEmail_Valid_Test()
    {
        // Arrange
        // Create a new instance of ValidationRules for an object.
        // Define a valid email string that includes both the local-part and the domain.
        var validation = new ValidationRules<object>();
        string email = "email@domain.com";
        
        // Act
        // Call the IsEmail method with the "Email" key and the valid email string.
        // This should perform the validation and, because the email is valid,
        // not add any notification to the validation instance.
        validation.IsEmail("Email", email);
        
        // Assert
        // Verify that the validation instance has no notifications,
        // indicating that the email was correctly identified as valid.
        Assert.IsTrue(!validation.HasNotifications);
    }
}