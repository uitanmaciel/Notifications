namespace Notifications.Tests.ValidationsTests.Email;

[TestClass]
public class EmailInvalidTest
{
    /// <summary>
    /// Tests the IsEmail method in the ValidationRules class with an invalid email address.
    /// The method should identify the invalid email and add a notification to the validation instance.
    /// </summary>
    [TestMethod]
    public void ValidationEmail_IsEmail_Invalid_Test()
    {
        //Arrange
        // Create a new instance of ValidationRules for an object.
        // Define an invalid email string that does not include the '@' character.
        var validation = new ValidationRules<object>();
        string email = "email.com";
        string notificationMessageExpected = $"The 'email.com' is not a valid email";

        //Act
        // Call the IsEmail method with the "Email" key and the invalid email string.
        // This should perform the validation and, because the email is invalid,
        // add a notification to the validation instance.
        validation.IsEmail("Email", email);

        //Assert
        // Check if the validation instance has notifications,
        // if there are notifications the test is correct.
        Assert.IsTrue(validation.HasNotifications);

        //Find a notification with the expected message
        bool notificationMessageExpectedFound = false;
        foreach (var notification in validation.Notifications)
        {
            if (notification.Message == notificationMessageExpected)
            {
                notificationMessageExpectedFound = true;
                break;
            }
        }

        //Assert that the expected message was found
        Assert.IsTrue(notificationMessageExpectedFound, notificationMessageExpected);
    }
}