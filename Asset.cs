using System;

namespace AssetEditor
{
    public abstract class Asset
    {
        private string assetName;
        public string AssetName
        {
            get { return assetName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Строка пустая");
                }
                else 
                    assetName = value;
            }
        }
        public CurrencyEnum Currency;
        public enum CurrencyEnum
        {
            Dollar,
            Ruble
        }
        protected void InitializeAsset(int countProperties)
        {
            for (int i = 0; i < countProperties; i++)
                Edit(i);
        }
        public virtual void Edit(int columnIndex)
        {
            while (true)
            {
                try
                {
                    switch (columnIndex)
                    {
                        case 0:
                            AssetName = Managment.GetNewString("Название актива", AssetName);
                            break;
                        case 1:
                            Currency = Managment.GetNewCurrency(Currency);
                            break;
                    }
                    break;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Исключение");
                    continue;
                }
            }
        }
        public override string ToString()
        {
            return AssetName;
        }
    }
}