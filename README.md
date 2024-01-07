
# Notification Pattern Library


This library is a comprehensive implementation of the Notification Design Pattern, designed to facilitate error handling and validation in a systematic and flexible manner. It allows for accumulating errors and messages throughout the process flow, enabling a cohesive response mechanism.




## Features

- **Validation Rules:** Customizable rules for validating strings, emails, passwords, and more, ensuring data integrity and consistency across your application.
- **Notification Handling:** Centralized management of notifications, providing a seamless way to collect and respond to errors and messages.
- **Test Suites:** Included test suites for email validation, ensuring the robustness and reliability of your email-related operations.
## Getting Started

To integrate this library into your project:

**1- Setup:** Include the library files in your project directory by installing directly from the NuGet repository.
```bash
  Install-Package Notifiers -Version 1.0.0
```

**2- Initialization:** Instantiate the Notifier and integrate it with your project's flow. Example:
```bash
  using Notifications;

  public class MyClass : Notifier
  {...}
```

**3- Usage:** Utilize the provided utilities and validations to manage errors and notifications throughout your application.
```bash
  using Notifications;
  using Notifications.Validations;

  public class MyClass : Notifier
  {
      public string Email { get; set; }
      public string Password { get; set; }

      //Using validation method in constructor
      public MyClass(string email, string password)
      {
          Email = email;
          Password = password;
          ValidationFields();
      }

      //Validation aggregator method
      void ValidationFields()
      {
          AddNotifications(new ValidationRules<MyClass>()
              .IsRequired()
              .IsEmail(nameof(Email), Email);
              .IsPassword(nameof(Password), Password, 8)
          );
      }
  }
```
## Running the tests

To run the tests, run the following command

```bash
  dotnet test
```


## Roadmap

- Include other validation types with: date and time, credit card, telephone.


## Feedback

If you have any feedback, please let us know at uitan.s.maciel@gmail.com

