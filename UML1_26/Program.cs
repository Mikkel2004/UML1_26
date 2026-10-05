using UML1_26;

Console.WriteLine("Hello, World!");

Pizza pizza1 = new Pizza(1, "Vesuvio", "Ost, Tomat og Skinke", 90);
Pizza pizza2 = new Pizza(2, "Marcerita", "Ost og Tomat", 94);
Pizza pizza3 = new Pizza(3, "La Marfia", "Ost, Tomat, Pepperroni og Skinke", 95);

Customer customer1 = new Customer("Mikkel", 134431, "Brandvej 68");
Customer customer2 = new Customer("Carl", 134411, "Sandvej 48");
Customer customer3 = new Customer("Fredrik", 111431, "Andevej 62");

Order order1 = new Order(pizza1, customer1, "10-2-2025", 10, true);
Order order2 = new Order(pizza1, customer1, "11-3-2025", 10, false);


Console.WriteLine("------Pizza------");
Console.WriteLine(pizza1.ToString());
Console.WriteLine(pizza2.ToString());
Console.WriteLine(pizza3.ToString());

Console.WriteLine("|");
Console.WriteLine("Customers");
Console.WriteLine(customer1.ToString());
Console.WriteLine(customer2.ToString());
Console.WriteLine(customer3.ToString());

Console.WriteLine(order1.ToString());
Console.WriteLine(order2.ToString());

