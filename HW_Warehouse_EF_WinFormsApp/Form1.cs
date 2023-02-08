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
        }

        async void LoadFormShowGoods(object sender, EventArgs e)
        {
            TabPageShow(await _context.Goods.ToListAsync(), gridGoods, "Id", "Name", "Cost", "GoodsTypeId");
        }

        async void TbpDeliveryShow(object sender, EventArgs e)
        {
            TabPageShow(await _context.Deliveries.ToListAsync(), gridDeliveres, "Id", "Amount", "DeleveryDate", "GoodsId", "SupplierId");
        }

        static void TabPageShow<T>(IEnumerable<T> list, DataGridView view, params string[] nameColumns)
        {
            var table = new DataTable();
            using var reader = ObjectReader.Create(list, nameColumns);
            table.Load(reader);
            view.DataSource = null;
            view.DataSource = table;
        }
    }
}