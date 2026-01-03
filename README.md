# InventoryManagementSystem

The Inventory Management System is a web-based application designed to manage and automate daily inventory operations efficiently. This project is developed using ASP.NET Core MVC and SQL Server, following the MVC architecture.

The system allows an administrator and users to:
- Perform secure user login with role-based access control
- Add, update, search, and delete products from inventory
- Manage stock levels with real-time tracking
- Update inventory through stock in/out operations
- View a dashboard with inventory statistics such as total products, total stock quantity, and total inventory value
- Track stock transactions and movements

This project demonstrates CRUD operations, session-based authentication, role-based authorization, and a responsive user interface, making it suitable for academic projects and small to medium-sized inventory systems.

---

## 🔧 Technologies Used

- **Backend**: ASP.NET Core MVC (C#)
- **Frontend**: HTML5, CSS3, Bootstrap 5, JavaScript
- **Database**: SQL Server (LocalDB)
- **ORM**: Entity Framework Core
- **IDE**: Microsoft Visual Studio 2022
- **Version Control**: Git & GitHub
- **Authentication**: Session-based with role management
- **UI Components**: Bootstrap 5, Font Awesome

---

## ✨ Key Features

### Authentication & Authorization
- Secure user login with username and password
- Role-based access control (Admin and User roles)
- Session management with automatic timeout
- Secure logout functionality

### Product Management
- **View Products**: Display all products in a table with search functionality
- **Add Products**: Create new products with name, category, price, and quantity
- **Edit Products**: Modify existing product details
- **Delete Products**: Remove products from inventory with confirmation
- **Search Functionality**: Search products by name
- **Categorization**: Organize products by categories

### Inventory Management
- **Real-time Stock Tracking**: Monitor current inventory levels
- **Stock In**: Add inventory when new products arrive
- **Stock Out**: Reduce inventory when products are sold or used
- **Transaction History**: Track all stock movements with timestamps
- **Inventory Value**: Calculate total inventory value based on quantity and price

### Dashboard Analytics
- Total number of products in inventory
- Total stock quantity across all products
- Total inventory value (quantity × unit price)
- Quick navigation to all modules
- User-friendly welcome message

---

## 📊 Database Schema

The application uses the following database tables:

### Users Table
```
UserID | Username | Password | Email              | Role
1      | admin    | admin123 | admin@inventory.com | Admin
2      | user     | user123  | user@inventory.com  | User
```

### Categories Table
```
CategoryID | CategoryName
1          | Electronics
2          | Clothing
3          | Furniture
```

### Products Table
```
ProductID | ProductName | CategoryID | UnitPrice | Quantity | DateAdded
1         | Laptop      | 1          | 999.99    | 10       | 2024-01-15
2         | Mouse       | 1          | 25.50     | 45       | 2024-01-15
```

### StockTransactions Table
```
TransactionID | ProductID | Quantity | TransactionType | Date
1             | 1         | 5        | In              | 2024-01-20
2             | 2         | 10       | Out             | 2024-01-21
```

---

## 📁 Project Structure

```
InventoryManagementSystem/
├── Controllers/
│   ├── AuthController.cs          # Authentication logic
│   ├── DashboardController.cs      # Dashboard functionality
│   ├── ProductsController.cs       # Product management
│   └── StockController.cs          # Stock operations
│
├── Models/
│   ├── User.cs                     # User data model
│   ├── Product.cs                  # Product data model
│   ├── Category.cs                 # Category data model
│   ├── StockTransaction.cs         # Transaction data model
│   └── InventoryContext.cs         # Database context
│
├── Views/
│   ├── Auth/
│   │   └── Login.cshtml            # Login page
│   ├── Dashboard/
│   │   └── Index.cshtml            # Dashboard page
│   ├── Products/
│   │   ├── Index.cshtml            # Products list page
│   │   ├── Create.cshtml           # Add product page
│   │   └── Edit.cshtml             # Edit product page
│   ├── Stock/
│   │   └── Index.cshtml            # Stock management page
│   └── Shared/
│       └── _Layout.cshtml          # Master layout
│
├── Migrations/                      # Database migrations
├── wwwroot/                        # Static files (CSS, JS, images)
├── appsettings.json                # Application configuration
├── Program.cs                      # Application entry point
├── .gitignore                      # Git ignore file
└── README.md                       # This file
```

---

## 📄 Application Pages

### 1. Login Page
- Secure user authentication
- Username and password input
- Error handling for invalid credentials

### 2. Dashboard
- Welcome message with logged-in user's name
- Total products count
- Total stock quantity display
- Total inventory value calculation
- Quick navigation links

### 3. Products List Page
- Display all products in table format
- Search by product name
- Edit and delete buttons for each product
- Add new product button
- Product details: ID, Name, Category, Price, Quantity

### 4. Add/Edit Product Page
- Form to create or modify products
- Input fields: Product Name, Category, Unit Price, Quantity
- Form validation
- Save and cancel options

### 5. Stock Management Page
- View all products with current stock levels
- Modal dialog to update stock
- Select transaction type (Stock In/Out)
- Input quantity to add or remove
- Transaction timestamp recording

---

## 🎯 Features Demonstration

### Adding a Product
1. Login with credentials
2. Click "Manage Products" on dashboard
3. Click "Add New Product"
4. Fill in product details
5. Select category from dropdown
6. Click "Add Product"

### Updating Stock
1. Navigate to "Manage Stock"
2. Click "Update Stock" button for any product
3. Select "Stock In" to add or "Stock Out" to remove
4. Enter quantity
5. Click "Update Stock" to save

### Searching Products
1. Go to Products page
2. Enter product name in search box
3. Click "Search"
4. Results displayed in real-time

---

## 🔄 CRUD Operations

The application supports full CRUD operations:

- **Create**: Add new products to inventory
- **Read**: View products and stock levels
- **Update**: Edit product details and stock quantities
- **Delete**: Remove products from inventory

---

## 📈 Inventory Calculations

The dashboard automatically calculates:

- **Total Products**: Count of all products in inventory
- **Total Stock Quantity**: Sum of quantities across all products
- **Total Inventory Value**: Total quantity × Unit price for all products

