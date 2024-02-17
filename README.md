# .NET Core Service Lifetimes

### Differents service lifetimes in .NET Core:
#### ✅Transient
#### ✅Scoped
#### ✅Singleton.

## Project Structure
- `ITransientDateTimeService`, `IScopedDateTimeService`, `ISingletonDateTimeService`: Interfaces for the different service lifetimes.
- `DateTimeService`: Implements the above interfaces. This service simply provides the current UTC date and time.
- `ApplicationLogger`: A class that uses the services to log the current date and time.
- `LifeTimesController`: A controller that also uses the services and logs the current date and time.

## Usage:

- **Ensure you have the .NET 8 SDK installed.**

- **Run the application using `dotnet run` command.**

- Call the only API that exists in this project with `/lifetimes` URL multiple times.

⚠ **Pay attention to the console output**, as it provides information about the **service lifetimes** and when certain events occur.

⚠ Console messages in different colors represent the **beginning** and **end** of a **request**, as well as service instantiation timestamps.

---
🟡The `transient` service gives a `new instance` for `each request`.

🔵The `scoped` service gives the `same instance` within `a request` but different instances across requests.

🔴The `singleton` service gives the `same instance` across `all requests`.

<img src="https://drive.google.com/uc?export=view&id=1BGk3LGGxTsWJo5Ub2DLFvYaUOdyoeVZF" alt="ServiceLifetime" width="500">

**While there may be some mistakes or less-than-optimal practices in the code, please feel at ease. Remember, this is just a simple sample 🙃**
