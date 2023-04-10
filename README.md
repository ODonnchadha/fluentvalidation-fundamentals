## FluentValidation Fundamentals by Vladimir Khorikov

- This course will teach you how to use FluentValidation library to perform validation in ASP.NET Core applications. 
- [FluentValidation](https://fluentvalidation.net) is a free and open-source library developed by Jeremy Skinner.

> Welcome to the Validation in DDD course.

> This is the source code for my Pluralsight course about Validation in DDD.

> How to Get Started:

> No need to set up a database, just hit F5 and you are good to go!

- OVERVIEW:
  - Validation is surprisingly complex.
    - The FluentValidation library.
    - Always-valid domain model.
    - The Value Object design pattern.
    - Explicit application errors.

- INTRODUCTION:
  - It is important to have the correct mental model around the subject.
  - Validation: The process of ensuring that some data is correct.
    - Data under vaidation = Data from ecternal sources. 
    - Validation = Input validation.
    - 400 versus 500 response codes.
  - [Sample project](https://github.com/vkhorikov/ValidationInDDD).
  
- VALIDATING INPUT WITH FLUENTVALIDATION:
  - Using the FLuentValidation library:
  - .NotEmpty(). Null, empty collections, whitespace, or empty.
  - Fluent interface pattern -> FLuentValidation.
  - Validate request data. Not the domain class. Domain classes should never be a part of the data contract.
  - Validating complex properties. Address is an object with multiple properties.

- DIVING DEEPER INTO FLUENTVALIDATION:
- VALIDATING INPUT THE DDD WAY:
- COMBINING FLUENTVALIDATION WITH DDD PATTERNS:
- DIVING DEEPER INTO DDD AND VALIDATION: