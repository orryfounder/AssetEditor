using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AssetEditor
{
    public abstract class GroupAssetListViewItem : ListViewItem
    {
        protected MainForm MainForm;
        protected DataColumn[] Columns;
        protected void InitializeColumns(params string[] headersName)
        {
            Columns = new DataColumn[headersName.Length];
            for (int i = 0; i < Columns.Length; i++)
            {
                Columns[i] = new DataColumn();
                Columns[i].ColumnName = headersName[i];
            }
        }
        protected void AddRowsAndColumns(List<Asset> assets)
        {
            DataTable table = (DataTable)MainForm.AssetsGridView.DataSource;
            table.Rows.Clear();
            table.Columns.Clear();
            table.Columns.AddRange(Columns);
            foreach (Asset asset in assets)
            {
                var listRow = asset.ToString().Split(';').ToList();
                listRow.RemoveRange(table.Columns.Count, listRow.Count - table.Columns.Count);
                table.Rows.Add(listRow.ToArray<string>());
            }
        }
        public abstract void Open();
    }
    public class AllAssetsViewItem : GroupAssetListViewItem
    {
        public AllAssetsViewItem(MainForm form)
        {
            MainForm = form;
            InitializeColumns("Название актива");
            Text = "Все активы";
        }
        public override void Open()
        {
            AddRowsAndColumns(MainForm.Assets);
        }
    }
    public class MonetaryViewItem : GroupAssetListViewItem
    {
        public MonetaryViewItem(MainForm form)
        {
            MainForm = form;
            InitializeColumns("Название актива", "Валюта", "Сумма");
            Text = "Денежные активы";
        }
        public override void Open()
        {
            var assets = MainForm.Assets.FindAll(element => element is Monetary);
            AddRowsAndColumns(assets);
        }
    }
    public class NonCashViewItem : GroupAssetListViewItem
    {
        public NonCashViewItem(MainForm form)
        {
            MainForm = form;
            InitializeColumns("Название актива", "Валюта", "Сумма", "Название банка", "Номер счёта");
            Text = "Безналичные денежные активы";
        }
        public override void Open()
        {
            var assets = MainForm.Assets.FindAll(element => element is NonCash);
            AddRowsAndColumns(assets);
        }
    }
    public class CashViewItem : GroupAssetListViewItem
    {
        public CashViewItem(MainForm form)
        {
            MainForm = form;
            InitializeColumns("Название актива", "Валюта", "Сумма");
            Text = "Наличные денежные активы";
        }
        public override void Open()
        {
            var assets = MainForm.Assets.FindAll(element => element is Cash);
            AddRowsAndColumns(assets);
        }
    }
    public class OtherMonetaryViewItem : GroupAssetListViewItem
    {
        public OtherMonetaryViewItem(MainForm form)
        {
            MainForm = form;
            InitializeColumns("Название актива", "Валюта", "Сумма", "Название денежного актива");
            Text = "Другие денежные активы";
        }
        public override void Open()
        {
            var assets = MainForm.Assets.FindAll(element => element is OtherMonetary);
            AddRowsAndColumns(assets);
        }
    }
    public class NonMonetaryViewItem : GroupAssetListViewItem
    {
        public NonMonetaryViewItem(MainForm form)
        {
            MainForm = form;
            InitializeColumns("Название актива", "Валюта", "Начальная балансовая стоимость", "Остаточная балансовая стоимость", "Оценочная балансовая стоимость");
            Text = "Неденежные активы";
        }
        public override void Open()
        {
            var assets = MainForm.Assets.FindAll(element => element is NonMonetary);
            AddRowsAndColumns(assets);
        }
    }
    public class OfficeViewItem : GroupAssetListViewItem
    {
        public OfficeViewItem(MainForm form)
        {
            MainForm = form;
            InitializeColumns("Название актива", "Валюта", "Начальная балансовая стоимость", "Остаточная балансовая стоимость", "Оценочная балансовая стоимость",
                "Адрес", "Год постройки", "Инвентарный номер", "Площадь");
            Text = "Офисы";
        }
        public override void Open()
        {
            var assets = MainForm.Assets.FindAll(element => element is Office);
            AddRowsAndColumns(assets);
        }
    }
    public class CarViewItem : GroupAssetListViewItem
    {
        public CarViewItem(MainForm form)
        {
            MainForm = form;
            InitializeColumns("Название актива", "Валюта", "Начальная балансовая стоимость", "Остаточная балансовая стоимость", "Оценочная балансовая стоимость",
                "Модель", "Год выпуска");
            Text = "Машины";
        }
        public override void Open()
        {
            var assets = MainForm.Assets.FindAll(element => element is Car);
            AddRowsAndColumns(assets);
        }
    }
    public class OtherNonMonetaryViewItem : GroupAssetListViewItem
    {
        public OtherNonMonetaryViewItem(MainForm form)
        {
            MainForm = form;
            InitializeColumns("Название актива", "Валюта", "Начальная балансовая стоимость", "Остаточная балансовая стоимость", "Оценочная балансовая стоимость",
                "Название неденежного актива");
            Text = "Другие неденежные активы";
        }
        public override void Open()
        {
            var assets = MainForm.Assets.FindAll(element => element is OtherNonMonetary);
            AddRowsAndColumns(assets);
        }
    }
}
