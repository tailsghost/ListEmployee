using ListEmployee.Field;
using ListEmployee.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace ListEmployee;

public partial class ListEmployee : Form
{
    private ICustomCollection _collection { get; }
    private IService _service { get; }

    public ListEmployee(ICustomCollection collection, IService service)
    {
        _collection = collection;
        _service = service;
        InitializeComponent();
    }

    public ListEmployee()
    {
        using var serviceProvider = Program.Services.BuildServiceProvider();
        _collection = serviceProvider.GetRequiredService<ICustomCollection>();
        _service = serviceProvider.GetRequiredService<IService>();
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        try
        {
            _collection.Sort.Clear();
            UpdateFilter();
            await _service.GetPersonAsync();
        }
        catch
        {
            MessageBox.Show("Ошибка обновления");
        }
    }

    private async void ListEmployee_Load(object sender, EventArgs e)
    {
        UpdateFilter();
        await _service.GetPersonAsync();

        await _service.GetComboBoxAsync("GetStatus");
        await _service.GetComboBoxAsync("GetDepartment");
        await _service.GetComboBoxAsync("GetPosition");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var box = new CustomMessageBox();
        box.StartPosition = FormStartPosition.CenterScreen;
        box.Show();
    }

    private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int filterId = ((FieldFilter?)comboBox1.SelectedItem)?.id ?? 0;

        int? result = await _service.GetStatisticsStatusAsync(filterId, dateTimePicker1.Value, dateTimePicker2.Value);
        if (result is int count)
        {
            textBox1.Text = $"Всего работников за все время с статусом \"{((FieldFilter?)comboBox1.SelectedItem)?.text}\": {count}";
        }
        else
        {
            textBox1.Text = string.Empty;
        }
    }

    private void UpdateFilter()
    {
        _collection.Sort.Add("@SortColumn", "last_name");
        _collection.Sort.Add("@SortDirection", "Сортировка по возрастанию");
        _collection.Sort.Add("@FilterStatus", "");
        _collection.Sort.Add("@FilterDepartment", "");
        _collection.Sort.Add("@FilterPosition", "");
        _collection.Sort.Add("@FilterText", "");
    }
}
