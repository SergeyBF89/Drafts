Console.WriteLine("Enter password");
string pass1 = Console.ReadLine();
Console.WriteLine("Enter login");
string login1 = Console.ReadLine();
Console.WriteLine("Repeat password");
string pass2 = Console.ReadLine();
Console.WriteLine("Repeat login");
string login2 = Console.ReadLine();
if (pass1 == pass2 & login1 == login2)
{
   Console.Write("You are logged in as, ");
   Console.WriteLine(login1, login2);
}
else
{
    Console.WriteLine("The data entered is not correct");
}

