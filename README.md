# Bitcoin Price Dashboard

Bitcoin Price Dashboard is an ASP.NET Core web application that displays live or recent Bitcoin price data, using HTML/CSS/JavaScript on the front‑end and C# on the back‑end.

The project is structured as a typical ASP.NET Core web app, with Razor pages (or MVC views), static assets in `wwwroot`, and C# services / configuration classes to interact with external APIs (e.g. Coinbase).

---

### Features (adapt to match your actual implementation)

- Fetch current Bitcoin price data from a public API (e.g. Coinbase)
- Display price information in a simple web dashboard
- Basic styling with HTML and CSS
- Configurable settings through `appsettings.json`
- Separation of concerns:
  - API client
  - Data models
  - Web UI

---

### Tech Stack

- **Backend**: ASP.NET Core (C#)
- **Frontend**: HTML, CSS, JavaScript
- **Package / project files**:
  - `BitcoinPriceDashboard.csproj` – Project configuration
  - `BitcoinPriceDashboard.sln` – Solution file
- **Key C# files**:
  - `Program.cs` – Application entry point
  - `Startup.cs` – Middleware & service configuration
  - `CoinBaseClient.cs` – API client for fetching Bitcoin prices
  - `JSONModel.cs` – C# types matching the JSON response
  - `AppSettings.cs` – Strongly‑typed configuration bindings
- **Config**:
  - `appsettings.json`
  - `appsettings.Development.json`

---

### Getting Started

#### Prerequisites

- .NET SDK (for example .NET 5 / .NET 6 or newer):  
  https://dotnet.microsoft.com/download
- Visual Studio, Rider, or VS Code with the C# extension

#### Clone the repository

```bash
git clone https://github.com/arijanala/bitcoin_price_dashboard.git
cd bitcoin_price_dashboard
```

#### Configure API settings

Open `appsettings.json` (and optionally `appsettings.Development.json`) and verify / update:

- API base URL for the Bitcoin price provider (e.g. Coinbase)
- Any required API keys or authentication (if applicable)

Example (adjust to your actual structure):

```json
{
  "CoinBase": {
    "BaseUrl": "https://api.coinbase.com",
    "TimeoutSeconds": 10
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

#### Run the application

Using the .NET CLI:

```bash
dotnet run
```

Then open the URL printed in the console, commonly:

```text
https://localhost:5001
```

or

```text
http://localhost:5000
```

Using Visual Studio:  
Open `BitcoinPriceDashboard.sln` and press **F5** or click **Run**.

---

### Project Structure

- `Pages/` – Razor pages (or views) for the UI
- `wwwroot/` – Static files (CSS, JS, images)
- `CoinBaseClient.cs` – Encapsulates HTTP calls to the Coinbase (or similar) API
- `JSONModel.cs` – Strongly‑typed models for JSON responses
- `AppSettings.cs` – Configuration model bound from `appsettings.json`
- `Program.cs` / `Startup.cs` – Web host and pipeline configuration

---

### Development & Testing

- **Hot reload**: available via `dotnet watch run` (if supported by your .NET version)
- **Logging**: configured via `appsettings*.json` and `Startup.cs`

You can add tests later using xUnit / NUnit / MSTest and document running them here:

```bash
dotnet test
```

---

### Possible Improvements / Next Steps

- [ ] Add charts (e.g. historical price graph with Chart.js)
- [ ] Display multiple currencies (USD, EUR, etc.)
- [ ] Add alerts or thresholds for price changes
- [ ] Containerize with Docker for easy deployment
- [ ] Deploy to a cloud provider (Azure, AWS, etc.)

---

### License

Add your preferred license details here.