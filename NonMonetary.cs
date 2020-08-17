using System;
using System.Windows.Forms;

namespace AssetEditor
{
    public class NonMonetary : Asset
    {
        private double initialValue;
        public double InitialValue
        {
            get { return initialValue; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательное число");
                else
                    initialValue = value;
            }
        }
        private double netBookValue;
        public double NetBookValue
        {
            get { return netBookValue; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательное число");
                else
                    netBookValue = value;
            }
        }
        private double estimatedValue;
        public double EstimatedValue
        {
            get { return estimatedValue; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательное число");
                else
                    estimatedValue = value;
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
                            InitialValue = Managment.GetNewDouble("Начальная балансовая стоимость", InitialValue);
                            break;
                        case 3:
                            NetBookValue = Managment.GetNewDouble("Остаточная балансовая стоимость", NetBookValue);
                            break;
                        case 4:
                            EstimatedValue = Managment.GetNewDouble("Оценочная балансовая стоимость", EstimatedValue);
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
            return $"{AssetName};{Currency};{InitialValue};{NetBookValue};{EstimatedValue}";
        }
    }
    public class Office : NonMonetary
    {
        private const int countProperties = 9;
        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Строка пустая");
                }
                else
                    address = value;
            }
        }
        private int yearBuilding;
        public int YearBuilding
        {
            get { return yearBuilding; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательное число");
                else if (value > DateTime.Now.Year)
                    throw new ArgumentException("Год постройки больше текущего");
                else
                    yearBuilding = value;
            }
        }
        private int inventoryNumber;
        public int InventoryNumber
        {
            get { return inventoryNumber; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательное число");
                else
                    inventoryNumber = value;
            }
        }
        private double size;
        public double Size
        {
            get { return size; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательное число");
                else
                    size = value;
            }
        }
        public Office()
        {
            InitializeAsset(countProperties);
        }
        public Office (string assetName, CurrencyEnum currency, double initialValue, 
            double netBookValue, double estimatedValue, string address, 
            int yearBuilding, int inventoryNumber, double size)
        {
            AssetName = assetName;
            Currency = currency;
            InitialValue = initialValue;
            NetBookValue = netBookValue;
            EstimatedValue = estimatedValue;
            Address = address;
            YearBuilding = yearBuilding;
            InventoryNumber = inventoryNumber;
            Size = size;
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
                        case 5:
                            Address = Managment.GetNewString("Адрес", Address);
                            break;
                        case 6:
                            YearBuilding = Managment.GetNewInt("Год постройки", YearBuilding);
                            break;
                        case 7:
                            InventoryNumber = Managment.GetNewInt("Инвентарный номер", InventoryNumber);
                            break;
                        case 8:
                            Size = Managment.GetNewDouble("Площадь", Size);
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
            return $"{AssetName};{Currency};{InitialValue};{NetBookValue};" +
                $"{EstimatedValue};{Address};{YearBuilding};{InventoryNumber};{Size}";
        }
    }
    public class Car : NonMonetary
    {
        private const int countProperties = 7;
        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Строка пустая");
                }
                else
                    model = value;
            }
        }
        private int yearRelease;
        public int YearRelease
        {
            get { return yearRelease; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Отрицательное число");
                else if (value > DateTime.Now.Year)
                    throw new ArgumentException("Год выпуска больше текущего");
                else
                    yearRelease = value;
            }
        }
        public Car()
        {
            InitializeAsset(countProperties);
        }
        public Car (string assetName, CurrencyEnum currency, double initialValue,
            double netBookValue, double estimatedValue, string model,
            int yearRelease)
        {
            AssetName = assetName;
            Currency = currency;
            InitialValue = initialValue;
            NetBookValue = netBookValue;
            EstimatedValue = estimatedValue;
            Model = model;
            YearRelease = yearRelease;
        }
        public override void Edit(int columnIndex)
        {
            while(true)
            {
                try
                {
                    base.Edit(columnIndex);
                    switch (columnIndex)
                    {
                        case 5:
                            Model = Managment.GetNewString("Модель", Model);
                            break;
                        case 6:
                            YearRelease = Managment.GetNewInt("Год выпуска", YearRelease);
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
            return $"{AssetName};{Currency};{InitialValue};{NetBookValue};{EstimatedValue};{Model};{YearRelease}";
        }
    }
    public class OtherNonMonetary : NonMonetary
    {
        private const int countProperties = 6;
        private string nonMonetaryName;
        public string NonMonetaryName
        {
            get { return nonMonetaryName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Строка пустая");
                }
                else
                    nonMonetaryName = value;
            }
        }
        public OtherNonMonetary()
        {
            InitializeAsset(countProperties);
        }
        public OtherNonMonetary(string assetName, CurrencyEnum currency, double initialValue,
            double netBookValue, double estimatedValue, string nonMonetaryName)
        {
            AssetName = assetName;
            Currency = currency;
            InitialValue = initialValue;
            NetBookValue = netBookValue;
            EstimatedValue = estimatedValue;
            NonMonetaryName = nonMonetaryName;
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
                        case 5:
                            NonMonetaryName = Managment.GetNewString("Название неденежного актива", NonMonetaryName);
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
            return $"{AssetName};{Currency};{InitialValue};{NetBookValue};{EstimatedValue};{NonMonetaryName}";
        }
    }
}
