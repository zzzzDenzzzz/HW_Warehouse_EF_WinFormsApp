using FastMember;
using HW_Warehouse_EF_WinFormsApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HW_Warehouse_EF_WinFormsApp
{
    public partial class Form1 : Form
    {
        WarehouseContext? _context;

        public Form1()
        {
            InitializeComponent();
            _context = new WarehouseContext();
            _context.Database.Migrate();
            Load += new EventHandler(GoodsShowAsync!);
            mainTabControl.Selected += new TabControlEventHandler(TabPageSelecting!);
        }

        void TabPageSelecting(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == tbpGoods)
            {
                GoodsShowAsync(sender, e);
            }
            else if (mainTabControl.SelectedTab == tbpDelivery)
            {
                DeliveryShowAsync(sender, e);
            }
            else if (mainTabControl.SelectedTab == tbpSuppliers)
            {
                SuppliersShowAsync(sender, e);
            }
            else if (mainTabControl.SelectedTab == tbpGoodsTypes)
            {
                GoodsTypesShowAsync(sender, e);
            }
            else
            {
                ;
            }
        }

        async void GoodsShowAsync(object sender, EventArgs e)
        {
            DatabaseContextTabPageShow(await _context!.Goods.ToListAsync(), gridGoods, "Id", "Name", "Cost", "GoodsTypeId");
        }

        async void DeliveryShowAsync(object sender, EventArgs e)
        {
            DatabaseContextTabPageShow(await _context!.Deliveries.ToListAsync(), gridDeliveres, "Id", "Amount", "DeleveryDate", "GoodsId", "SupplierId");
        }

        async void SuppliersShowAsync(object sender, EventArgs e)
        {
            DatabaseContextTabPageShow(await _context!.Suppliers.ToListAsync(), gridSuppliers, "Id", "Name");
        }

        async void GoodsTypesShowAsync(object sender, EventArgs e)
        {
            DatabaseContextTabPageShow(await _context!.GoodsTypes.ToListAsync(), gridGoodsTypes, "Id", "Name");
        }

        static void DatabaseContextTabPageShow<T>(IEnumerable<T> list, DataGridView view, params string[] namesColumn)
        {
            var table = new DataTable();
            using var reader = ObjectReader.Create(list, namesColumn);
            table.Load(reader);
            view.DataSource = table;
        }

        void BtnSave_Click(object sender, EventArgs e)
        {
            SaveGoogsAsync();
        }

        async void SaveGoogsAsync()
        {
            for (int i = 1; i < gridGoods.RowCount; i++)
            {
                var name = gridGoods["Name", i].Value;
                var goodsTypeId = gridGoods["GoodsTypeId", i].Value;
                var cost = gridGoods["Cost", i].Value;

                if (name != null && goodsTypeId != null && cost != null)
                {
                    _context?.Goods.Add(
                        new Good
                        {
                            Name = Convert.ToString(name),
                            GoodsTypeId = Convert.ToInt32(goodsTypeId),
                            Cost = Convert.ToDecimal(cost)
                        });
                    await _context!.SaveChangesAsync();
                }
            }
        }
    }
}