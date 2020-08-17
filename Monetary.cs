using System;
using System.Windows.Forms;

namespace AssetEditor
{
    public class Monetary : Asset
    {
        private double amount;
        public double Amount
        {
            get { return amount; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательное число");
                else
                    amount = value;
            }
        }
        public override void Edit(int columnIndex)
        {
            while (true)
            {
                try
                {
                    base.Edit(columnIndex);
                    switch (columnIndex)
                    {
                        case 2:
                            Amount = Managment.GetNewDouble("Сумма", Amount);
                            break;
                    }
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Исключение");
                    continue;
                }
            }
        }
        public override string ToString()
        {
            return $"{AssetName};{Currency};{Amount}";
        }
    }
    public class NonCash : Monetary
    {
        private const int countProperties = 5;
        private string bankName;
        public string BankName
        {
            get { return bankName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Строка пустая");
                }
                else 
                    bankName = value;
            }
        }
        private int accountNumber;
        public int AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательное число");
                else
                    accountNumber = value;
            }
        }
        public NonCash()
        {
            InitializeAsset(countProperties);
        }
        public NonCash (string assetName, double amount, CurrencyEnum currency, string bankName, int accountNumber)
        {
            AssetName = assetName;
            Currency = currency;
            Amount = amount;
            BankName = bankName;
            AccountNumber = accountNumber;
        }
        public override void Edit(int columnIndex)
        {
            while (true)
            {
                try
                {
                    base.Edit(columnIndex);
                    switch (columnIndex)
                    {
                        case 3:
                            BankName = Managment.GetNewString("Название банка", BankName);
                            break;
                        case 4:
                            AccountNumber = Managment.GetNewInt("Номер счёта", AccountNumber);
                            break;
                    }
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Исключение");
                    continue;
                }
            }
        }
        public override string ToString()
        {
            return $"{AssetName};{Currency};{Amount};{BankName};{AccountNumber}";
        }
    }
    public class Cash : Monetary
    {
        private const int countProperties = 3;
        public Cash()
        {
            InitializeAsset(countProperties);
        }
        public Cash (string assetName, double amount, CurrencyEnum currency)
        {
            AssetName = assetName;
            Amount = amount;
            Currency = currency;
        }
        public override string ToString()
        {
            return $"{AssetName};{Currency};{Amount}";
        }
    }
    public class OtherMonetary : Monetary
    {
        private const int countProperties = 4;
        private string monetaryName;
        public string MonetaryName
        {
            get { return monetaryName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Строка пустая");
                }
                else
                    monetaryName = value;
            }
        }
        public OtherMonetary()
        {
            InitializeAsset(countProperties);
        }
        public OtherMonetary (string assetName, double amount, CurrencyEnum currency, string monetaryName)
        {
            AssetName = assetName;
            Amount = amount;
            Currency = currency;
            MonetaryName = monetaryName;
        }
        public override void Edit(int columnIndex)
        {
            while (true)
            {
                try
                {
                    base.Edit(columnIndex);
                    switch (columnIndex)
                    {
                        case 3:
                            MonetaryName = Managment.GetNewString("Название денежного актива", MonetaryName);
                            break;
                    }
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Исключение");
                    continue;
                }
            }
        }
        public override string ToString()
        {
            return $"{AssetName};{Currency};{Amount};{MonetaryName}";
        }
    }
}
