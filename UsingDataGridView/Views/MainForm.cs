using UsingDataGridView.Controllers;
using UsingDataGridView.Infrastructure;

namespace UsingDataGridView.Views;

public partial class MainForm : Form
{
    private RareMusicalController _musicalController;    

    // подготовка элемнтов интерфейса, данных для обработки
    public MainForm() {
        InitializeComponent();

        // содать контроллер
        _musicalController = new RareMusicalController();

        // настройка комбо-бокса категорий
        colCategory.Items.AddRange(Utils.Categories);

        // загрузить данные в DataGridView
        dgvInstruments.DataSource = _musicalController.RareMusicals;
    } // MainForm

    // Выход из приложения
    private void Exit_Command(object sender, EventArgs e) => Application.Exit();
} // class MainForm
