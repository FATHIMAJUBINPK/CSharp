.NET Windows Forms General Coding Instructions


1. Naming Conventions


Classes & User Controls: Use PascalCase
Example: CustomerForm, OrderDetailsControl


Methods: Use PascalCase
Example: LoadCustomerData, ValidateInput


Variables & Fields: Use camelCase
Example: customerName, orderList


Private fields: Prefix with _
Example: _connectionString, _logger


Constants: Use ALL_CAPS_WITH_UNDERSCORES
Example: MAX_RETRY_COUNT


UI Controls: Prefix with control type + purpose
Example: btnSave, txtCustomerName, lblStatus


Events: Use On prefix + action
Example: OnCustomerSaved, OnFormClosing




2. Method Name Declaration Standards


Use verbs to indicate action:


✅ CalculateTotal(), LoadSettings(), RefreshGrid()


❌ TotalCalculation(), SettingsLoader()




Keep names short but descriptive (avoid abbreviations like CalcTot).


Async methods must end with Async:


✅ LoadCustomerDataAsync()




Event handlers should follow the pattern:


ControlName_EventName
Example: btnSave_Click, txtName_TextChanged






3. Namespace Definition Standards

Use company → project → module hierarchy:


namespace MyCompany.MyProduct.UI
{
    public partial class CustomerForm : Form
    {
        // ...
    }
}



Namespace Definition Standards


Avoid generic names like Utilities or Helpers at the root level — instead, scope them properly:


✅ MyCompany.MyProduct.Common.Utilities




Each layer (UI, Business, Data) should have its own namespace:

MyCompany.MyProduct.Data
MyCompany.MyProduct.Business
MyCompany.MyProduct.UI




4. User Control Definition Standards


Naming: End with Control
Example: CustomerDetailsControl, OrderSummaryControl


Encapsulation: Expose only necessary properties/events; keep internal logic private.


Initialization: Use InitializeComponent() for UI setup, and separate business logic into methods.


Reusability: Design controls to be reusable across forms (avoid hard-coded dependencies).


Events: Raise custom events for parent forms to handle
Example: CustomerSaved event


Documentation: Add XML comments for public properties and events:



/// <summary>
/// Gets or sets the customer ID displayed in the control.
/// </summary>
public int CustomerId { get; set; }



Example User Control

namespace MyCompany.MyProduct.UI.Controls
{
    public partial class CustomerDetailsControl : UserControl
    {
        public event EventHandler CustomerSaved;

        public CustomerDetailsControl()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save logic here
            CustomerSaved?.Invoke(this, EventArgs.Empty);
        }
    }
}



✅ Quick Checklist

Use PascalCase for classes/methods, camelCase for variables, _ prefix for private fields.
Async methods end with Async.
Event handlers follow ControlName_EventName.
Namespaces follow Company → Project → Module.
User controls end with Control, are reusable, and raise events for parent forms.
Document public members with XML comments.


📂 Project Folder Structure

/MyProduct.WinForms
│
├── /UI
│   ├── /Forms            # Windows Forms (e.g., CustomerForm, OrderForm)
│   ├── /Controls         # User Controls (e.g., CustomerDetailsControl)
│   ├── /Resources        # Images, icons, and other UI assets
│   └── /Themes           # Custom styles or themes
│
├── /Business
│   ├── /Services         # Business logic classes
│   ├── /Managers         # Workflow or orchestration classes
│   └── /Validators       # Input validation logic
│
├── /Data
│   ├── /Repositories     # RepoDB or EF repositories
│   ├── /Models           # Data models (POCOs, DTOs)
│   └── /Migrations       # Database migration scripts
│
├── /Common
│   ├── /Utilities        # Helper classes (scoped properly, not generic)
│   ├── /Extensions       # Extension methods
│   └── /Constants        # Shared constants and enums
│
├── /Config
│   ├── appsettings.json    # Application configuration
│   └── CompanySettings.xml   # Company-specific settings
│
├── /Tests
│   ├── /UnitTests        # Unit test projects
│   └── /IntegrationTests # Integration test projects
│
└── README.md  
