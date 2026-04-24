// Create customers
BankCustomer customer1 = new BankCustomer("Tim", "Shao");
BankCustomer customer2 = new BankCustomer("Lisa", "Shao");
BankCustomer customer3 = new BankCustomer("Sandy", "Zoeng");

Console.WriteLine(customer1.DisplayCustomerInfo());
Console.WriteLine(customer2.DisplayCustomerInfo());
Console.WriteLine(customer3.DisplayCustomerInfo());

// Create accounts
BankAccount account1 = new BankAccount(customer1.CustomerId);
BankAccount account2 = new BankAccount(customer2.CustomerId, 1500, "Checking");
BankAccount account3 = new BankAccount(customer3.CustomerId, 2500, "Checking");

// Use methods
account1.Deposit(500);
account2.Withdraw(200);
account3.Transfer(account1, 300);

// Extension methods
Console.WriteLine(customer1.GreetCustomer());
Console.WriteLine(account2.CanWithdraw(2000));

// Display final info
Console.WriteLine(account1.DisplayAccountInfo());// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
