using ListEmployee.Data;
using ListEmployee.Field;
using ListEmployee.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ListEmployee
{
    public partial class CustomMessageBox : Form
    {
        private IService _service;

        private ICustomCollection _collection { get; }

        public CustomMessageBox(ICustomCollection collection, IService service)
        {
            _collection = collection;
            _service = service;
            InitializeComponent();
        }

        public CustomMessageBox()
        {
            using var serviceProvider = Program.Services.BuildServiceProvider();
            _collection = serviceProvider.GetRequiredService<ICustomCollection>();
            _service = serviceProvider.GetRequiredService<IService>();
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexChangedHandler(checkedListBox1);
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string text(int id) => id > 0 ? id.ToString() : string.Empty;

            var sortType = (FieldSortInfo)checkedListBox1.SelectedItem!;
            _collection.Sort["@SortDirection"] = sortType.name;

            var sortMenu = (FieldSortInfo)checkedListBox2.SelectedItem!;
            _collection.Sort["@SortColumn"] = sortMenu.name;

            var status = (FieldFilter)comboBox1.SelectedItem!;
            _collection.Sort["@FilterStatus"] = text(status.id);

            var department = (FieldFilter)comboBox2.SelectedItem!;
            _collection.Sort["@FilterDepartment"] = text(department.id);

            var position = (FieldFilter)comboBox3.SelectedItem!;
            _collection.Sort["@FilterPosition"] = text(position.id);

            _collection.Sort["@FilterText"] = textBox1.Text;

            await _service.GetPersonAsync();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexChangedHandler(checkedListBox2);
        }

        private void IndexChangedHandler(CheckedListBox box)
        {
            if (box.CheckedItems.Count > 1)
            {
                for (int i = 0; i < box.Items.Count; i++)
                    box.SetItemChecked(i, false);
                box.SetItemChecked(box.SelectedIndex, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
