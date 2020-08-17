using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AssetEditor
{
    public partial class MainForm : Form
    {
        private string enterpriseName;
        public string EnterpriseName
        {
            get { return enterpriseName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Строка пустая");
                }
                else
                {
                    Text = "Редактор активов предприятия " + value;
                    enterpriseName = value;
                }
            }
        }
        private ListViewItem[] AssetGroupsItems;
        public List<Asset> Assets;
        public MainForm()
        {
            InitializeComponent();
            changeEnterpriseMenuSubItem.PerformClick();
            AssetsGridView.DataSource = new DataTable();
            Assets = new List<Asset>()
            {
                new NonCash("Актив 1", 1000, Asset.CurrencyEnum.Ruble, "ЕвроВорБанк", 5),
                new NonCash("Актив 2", 5, Asset.CurrencyEnum.Dollar, "Внешторгабк", 3),
                new Cash("Актив 3", 100, Asset.CurrencyEnum.Ruble),
                new OtherMonetary("Актив 4", 3000, Asset.CurrencyEnum.Ruble, "Талоны на бензин от Аспека"),
                new Office("Актив 5", Asset.CurrencyEnum.Ruble, 30000, 5000, 1000000, "Бассейная-6", 1970, 7, 1540),
                new OtherNonMonetary("Актив 6", Asset.CurrencyEnum.Ruble, 1000, 100, 2000, "100 киллограммов гвоздей 2000 года"),
                new Cash("Актив 7", 2000, Asset.CurrencyEnum.Dollar),
                new Car("Актив 8", Asset.CurrencyEnum.Dollar, 2000, 1000, 3000, "Opel Astra J", 2012)
            };
            AssetGroupsItems = new ListViewItem[]
            {
                new AllAssetsViewItem(this),
                new MonetaryViewItem(this),
                new NonCashViewItem(this),
                new CashViewItem(this),
                new OtherMonetaryViewItem(this),
                new NonMonetaryViewItem(this),
                new OfficeViewItem(this),
                new CarViewItem(this),
                new OtherNonMonetaryViewItem(this)
            };
            AssetGroupsListView.Items.AddRange(AssetGroupsItems);
        }
        private void FillAssetsGridView()
        {
            (AssetGroupsListView.SelectedItems[0] as GroupAssetListViewItem).Open();
            foreach (DataGridViewColumn column in AssetsGridView.Columns)
                column.ContextMenuStrip = contextMenuStrip;
        }
        private void AssetGroupsListView_ItemActivate(object sender, EventArgs e)
        {
            FillAssetsGridView();
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (AssetsGridView.SelectedCells.Count > 0)
            {
                string editableAssetName = AssetsGridView.CurrentCell.OwningRow.Cells[0].Value.ToString();
                Assets.Find(asset => asset.AssetName == editableAssetName).Edit(AssetsGridView.CurrentCell.ColumnIndex);
                FillAssetsGridView();
            }
            else
            {
                MessageBox.Show("Выберите ячейку для редактирования", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string editableAssetName = AssetsGridView.CurrentCell.OwningRow.Cells[0].Value.ToString();
            Assets.Find(asset => asset.AssetName == editableAssetName).Edit(AssetsGridView.CurrentCell.ColumnIndex);
            FillAssetsGridView();
        }
        private void AssetsGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.Button == MouseButtons.Right)
            {
                AssetsGridView.CurrentCell = AssetsGridView[e.ColumnIndex, e.RowIndex];
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (AssetsGridView.SelectedCells.Count > 0)
            {
                string assetNameToDelete = AssetsGridView.CurrentCell.OwningRow.Cells[0].Value.ToString();
                if (MessageBox.Show($"Вы уверены, что хотите удалить {assetNameToDelete}?",
                    Text,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Assets.Remove(Assets.Find(asset => asset.AssetName == assetNameToDelete));
                    FillAssetsGridView();
                    MessageBox.Show("Актив успешно удален!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите актив для удаления", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string[] assetClasses = new string[]
            {
                "Безналичный денежный актив",
                "Наличный денежный актив",
                "Другой денежный актив",
                "Здание",
                "Авто",
                "Другие неденежные активы"
            };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < assetClasses.Length; i++)
                sb.AppendLine($"{i} - {assetClasses[i]}");
            sb.AppendLine("Выберите тип актива");
            int indexAsset;
            string input;
            bool isIndex;
            do
            {
                input = Interaction.InputBox(sb.ToString(), Text);
                if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                    return;
                isIndex = int.TryParse(input, out indexAsset) && indexAsset >= 0 && indexAsset < assetClasses.Length;
            }
            while (!isIndex);
            switch (indexAsset)
            {
                case 0:
                    Assets.Add(new NonCash());
                    break;
                case 1:
                    Assets.Add(new Cash());
                    break;
                case 2:
                    Assets.Add(new OtherMonetary());
                    break;
                case 3:
                    Assets.Add(new Office());
                    break;
                case 4:
                    Assets.Add(new Car());
                    break;
                case 5:
                    Assets.Add(new OtherNonMonetary());
                    break;
            }
            FillAssetsGridView();
            MessageBox.Show("Актив успешно добавлен!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void AddAssetMenuSubItem_Click(object sender, EventArgs e)
        {
            addButton.PerformClick();
        }
        private void DeleteAssetMenuSubItem_Click(object sender, EventArgs e)
        {
            deleteButton.PerformClick();
        }
        private void ClearAssetsMenuSubItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите очистить список активов?",
                Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Assets.Clear();
                FillAssetsGridView();
                MessageBox.Show("Список активов успешно очищен!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void EditMenuSubItem_Click(object sender, EventArgs e)
        {
            changeButton.PerformClick();
        }
        private void ChangeEnterpriseMenuSubItem_Click(object sender, EventArgs e)
        {
            EnterpriseName = Managment.GetNewString("Название предприятия", EnterpriseName);
        }

        private void SumNonCashMenuSubItem_Click(object sender, EventArgs e)
        {
            double sumDollar = Assets.FindAll(x => x is NonCash && x.Currency == Asset.CurrencyEnum.Dollar).Sum(x => ((Monetary)x).Amount);
            double sumRuble = Assets.FindAll(x => x is NonCash && x.Currency == Asset.CurrencyEnum.Ruble).Sum(x => ((Monetary)x).Amount);
            MessageBox.Show($"Сумма безналичных денежных активов.\nДолларов: {sumDollar:0.##}\nРублей: {sumRuble:0.##}");
        }
        private void SumCashMenuSubItem_Click(object sender, EventArgs e)
        {
            double sumDollar = Assets.FindAll(x => x is Cash && x.Currency == Asset.CurrencyEnum.Dollar).Sum(x => ((Monetary)x).Amount);
            double sumRuble = Assets.FindAll(x => x is Cash && x.Currency == Asset.CurrencyEnum.Ruble).Sum(x => ((Monetary)x).Amount);
            MessageBox.Show($"Сумма наличных денежных активов.\nДолларов: {sumDollar:0.##}\nРублей: {sumRuble:0.##}");
        }
        private void SumOtherMonetaryMenuSubItem_Click(object sender, EventArgs e)
        {
            double sumDollar = Assets.FindAll(x => x is OtherMonetary && x.Currency == Asset.CurrencyEnum.Dollar).Sum(x => ((Monetary)x).Amount);
            double sumRuble = Assets.FindAll(x => x is OtherMonetary && x.Currency == Asset.CurrencyEnum.Ruble).Sum(x => ((Monetary)x).Amount);
            MessageBox.Show($"Сумма других денежных активов.\nДолларов: {sumDollar:0.##}\nРублей: {sumRuble:0.##}");
        }
        private void TotalSumMenuSubItem_Click(object sender, EventArgs e)
        {
            double sumDollar = Assets.FindAll(x => x is Monetary && x.Currency == Asset.CurrencyEnum.Dollar).Sum(x => ((Monetary)x).Amount);
            double sumRuble = Assets.FindAll(x => x is Monetary && x.Currency == Asset.CurrencyEnum.Ruble).Sum(x => ((Monetary)x).Amount);
            MessageBox.Show($"Общая сумма денежных активов.\nДолларов: {sumDollar:0.##}\nРублей: {sumRuble:0.##}");
        }
        private void AvgNonCashMenuSubItem_Click(object sender, EventArgs e)
        {
            List<Asset> listDollarAssets = Assets.FindAll(x => x is NonCash && x.Currency == Asset.CurrencyEnum.Dollar);
            List<Asset> listRublesAssets = Assets.FindAll(x => x is NonCash && x.Currency == Asset.CurrencyEnum.Ruble);
            double avgDollar = listDollarAssets.Count > 0 ? listDollarAssets.Average(x => ((Monetary)x).Amount) : 0;
            double avgRuble = listRublesAssets.Count > 0 ? listRublesAssets.Average(x => ((Monetary)x).Amount) : 0;
            MessageBox.Show($"Средняя стоимость безналичных денежных активов.\nСреди долларов: {avgDollar:0.##}\nСреди рублей: {avgRuble:0.##}");
        }
        private void AvgCashMenuSubItem_Click(object sender, EventArgs e)
        {
            List<Asset> listDollarAssets = Assets.FindAll(x => x is Cash && x.Currency == Asset.CurrencyEnum.Dollar);
            List<Asset> listRublesAssets = Assets.FindAll(x => x is Cash && x.Currency == Asset.CurrencyEnum.Ruble);
            double avgDollar = listDollarAssets.Count > 0 ? listDollarAssets.Average(x => ((Monetary)x).Amount) : 0;
            double avgRuble = listRublesAssets.Count > 0 ? listRublesAssets.Average(x => ((Monetary)x).Amount) : 0;
            MessageBox.Show($"Средняя стоимость наличных денежных активов.\nСреди долларов: {avgDollar:0.##}\nСреди рублей: {avgRuble:0.##}");
        }
        private void AvgOtherMonetaryMenuSubItem_Click(object sender, EventArgs e)
        {
            List<Asset> listDollarAssets = Assets.FindAll(x => x is OtherMonetary && x.Currency == Asset.CurrencyEnum.Dollar);
            List<Asset> listRublesAssets = Assets.FindAll(x => x is OtherMonetary && x.Currency == Asset.CurrencyEnum.Ruble);
            double avgDollar = listDollarAssets.Count > 0 ? listDollarAssets.Average(x => ((Monetary)x).Amount) : 0;
            double avgRuble = listRublesAssets.Count > 0 ? listRublesAssets.Average(x => ((Monetary)x).Amount) : 0;
            MessageBox.Show($"Средняя стоимость других денежных активов.\nСреди долларов: {avgDollar:0.##}\nСреди рублей: {avgRuble:0.##}");
        }
        private void AvgAllMonetariesMenuSubItem_Click(object sender, EventArgs e)
        {
            List<Asset> listDollarAssets = Assets.FindAll(x => x is Monetary && x.Currency == Asset.CurrencyEnum.Dollar);
            List<Asset> listRublesAssets = Assets.FindAll(x => x is Monetary && x.Currency == Asset.CurrencyEnum.Ruble);
            double avgDollar = listDollarAssets.Count > 0 ? listDollarAssets.Average(x => ((Monetary)x).Amount) : 0;
            double avgRuble = listRublesAssets.Count > 0 ? listRublesAssets.Average(x => ((Monetary)x).Amount) : 0;
            MessageBox.Show($"Средняя стоимость всех денежных активов.\nСреди долларов: {avgDollar:0.##}\nСреди рублей: {avgRuble:0.##}");
        }
        private void CountAssetsMenuSubItems_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Текущее количество активов: {Assets.Count}");
        }
    }
}
