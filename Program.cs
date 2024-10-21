// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
    using congestion.calculator;
    Vehicle car = new Car();
    DateTime[] dates = 
    {
        new DateTime(2024, 10, 21, 6, 15, 0),
        new DateTime(2024, 10, 21, 7, 0, 0),
        new DateTime(2024, 10, 21, 8, 0, 0),
        new DateTime(2024, 10, 21, 9, 0, 0)
    };

    var calculator = new CongestionTaxCalculator();
    int totalTax = calculator.GetTax(car, dates);
    Console.WriteLine($"Total congestion tax for the day: {totalTax}");
