// See https://aka.ms/new-console-template for more information

namespace KasiATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var welcomeMessage = @"
 __          __  _                            _          _  __         _   ____              _    
 \ \        / / | |                          | |        | |/ /        (_) |  _ \            | |   
  \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___   | ' / __ _ ___ _  | |_) | __ _ _ __ | | __
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  |  < / _` / __| | |  _ < / _` | '_ \| |/ /
    \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | . \ (_| \__ \ | | |_) | (_| | | | |   < 
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  |_|\_\__,_|___/_| |____/ \__,_|_| |_|_|\_\
                                                                                                  
                                                                                                  
";
            Console.WriteLine(welcomeMessage);
            Console.WriteLine("Please select a service.");

            var serviceChoice = @"
1. Deposit
2. Withdraw
";
            Console.WriteLine(serviceChoice);
            var acc = new Account(5000);
            var selectedService = Console.ReadLine();
            if (selectedService == "1")
            {
                Console.WriteLine("How much would you like to deposit?");
                var depositAmount = Convert.ToDouble(Console.ReadLine());
                var currentBalance = acc.Deposit(depositAmount);
                var message = $"You deposited: R{depositAmount}. Your current balance is: {currentBalance}";
                NotificationService.SendMessage(true, "lg.setlhodi@gmail.com", "0764591933", message);

            }
            else if (selectedService == "2")
            {
                Console.WriteLine("How much would you like to withdraw?");
                var withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                var currentBalance = acc.Withdraw(withdrawalAmount);
                var message = $"You withdrew: R{withdrawalAmount}. Your current balance is: {currentBalance}";
                NotificationService.SendMessage(true, "lg.setlhodi@gmail.com", "0764591933", message);
            }

        }
    }
}