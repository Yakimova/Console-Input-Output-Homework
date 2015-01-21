using System;
/*
    Problem 2. Print Company Information

    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.

 */
class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine(@"{0}
Address: {1}
Phone number: {2}
Fax: {3}
Web site: {4}
Manager: {5} {6} (age: {7}, phone: {8})", companyName, companyAdress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
