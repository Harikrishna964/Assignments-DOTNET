
namespace ExceptionHandling
{
    class BankAccountDetails
    {
        int _accountNumber;
        private String _accountHolder;
        private double _bankbalance;
        private String _acc_type;
        public double Deposit(double Amount)
        {
            _bankbalance = _bankbalance + Amount;
            return _bankbalance;
        }
        public double Withdraw(double Amount)
        {

            if (Amount <= _bankbalance)
            {
                _bankbalance = _bankbalance - Amount;

            }
            else
            {
                throw new InSufficientBalanceException("Insufficient Balance!");
            }

            return _bankbalance;

        }

        public string AccountSummary()
        {
            return string.Format("Account number: {0}\n Account Holder:{1}\n Balance : {2}", _accountNumber, _accountHolder, _bankbalance);
        }



        public BankAccountDetails(int acc_no, String _cname, double initialAmount, string account_type)
        {
            this._accountNumber = acc_no;
            this._accountHolder = _cname;
            this._bankbalance = initialAmount;
            this._acc_type = account_type;
        }
        public double BalanceEnquiry
        {
            get
            {
                return _bankbalance;
            }
        }
        public int Accountno
        {
            get
            {
                return this._accountNumber;
            }
        }



    }

    class MainClass
    {
        static BankAccountDetails[] acc = new BankAccountDetails[10];
        static string name, acc_type;
        static double balance;
        static int count;
        static int acc_no;
        public static void AddAccount()
        {
            Console.WriteLine("Enter Bank Account Number");
            acc_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the account holders name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the initial amount of the account");
            balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the account type:");
            acc_type = Console.ReadLine();
        }
        public static int searchAccount(int accNo)
        {
            for (int i = 0; i < count; i++)
            {
                if (acc[i].Accountno == accNo)
                {
                    return i;
                }
            }
            return 0;
        }
        static void Main()
        {
            float amount;
            char ch;
            do
            {
                Console.WriteLine("1. Add Account\n2.Transaction Type\n3.Account Summary\n4.Exit \n");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        AddAccount();
                        acc[count++] = new BankAccountDetails(acc_no, name, balance, acc_type);
                        Console.WriteLine("Account created Succesfully!");
                        break;
                    case 2:
                        Console.WriteLine("Enter the account number");
                        int a = int.Parse(Console.ReadLine());
                        if (searchAccount(a) != null)
                        {
                            int i = searchAccount(a);
                            Console.WriteLine("1.Deposit\n2. Withdraw\n3.BalanceEnquiry\n4.Account Summary");
                            int option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    Console.WriteLine("Enter the amount to deposit");
                                    amount = float.Parse(Console.ReadLine());
                                    acc[i].Deposit(amount);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the amount to withdraw");
                                    amount = float.Parse(Console.ReadLine());
                                    try
                                    {
                                        acc[i].Withdraw(amount);
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Balance is " + acc[i].BalanceEnquiry);
                                    break;
                                case 4:
                                    Console.WriteLine(acc[i].AccountSummary());
                                    break;



                            }



                        }
                        else
                        {
                            Console.WriteLine("Please enter valid account Number");
                        }



                        break;
                    case 3:
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(acc[i].AccountSummary());
                            Console.WriteLine("------------------------------");
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Do you want to continue?(Y|N)");
                ch = Console.ReadLine()[0];
            } while (ch == 'Y' || ch == 'y');
        }
    }



}

namespace ExceptionHandling
{
    public class InSufficientBalanceException : Exception
    {
        public InSufficientBalanceException(string message) : base(message) { }



        public InSufficientBalanceException(string message, Exception innerException) : base(message, innerException) { }
        public InSufficientBalanceException() : base() { }
    }
}




