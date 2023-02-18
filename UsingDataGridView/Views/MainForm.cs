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

        // настройка комбо-бокса категорий в DataGridView
        colCategory.Items.AddRange(Utils.Categories);

        // настройка комбо-боксов для выборки данных
        cbxCategory.Items.AddRange(Utils.Categories);
        cbxArtisan.Items.AddRange(Utils.ArtisanNames);    
        cbxCity.Items.AddRange(Utils.Cities);    

        // загрузить данные в DataGridView
        dgvInstruments.DataSource = _musicalController.RareMusicals;

        dgvOrdered.DataSource = _musicalController.OrderByName();
        tbpOrdered.Text = "Упорядоченные по названию";

        dgvSelected.DataSource = _musicalController.SelectWhereCategory(Utils.Categories[0]);
        tbpSelected.Text = $"Выборка по категории \"{Utils.Categories[0]}\"";
    } // MainForm

    // Выход из приложения
    private void Exit_Command(object sender, EventArgs e) => Application.Exit();


    // Запуск сортировки по названию инструмента
    private void OrderByName_Command(object sender, EventArgs e) {
        // упорядочить копию коллекции
        // загрузить копию в DataGridView для сортированных данных
        dgvOrdered.DataSource = null!;
        dgvOrdered.DataSource = _musicalController.OrderByName();

        // вывод метода сортировки
        tbpOrdered.Text = "Упорядоченные по названию";

        // перейти на вкладку  упорядоченных данных
        tabControl1.SelectTab("tbpOrdered");
    } // OrderByName_Command


    // Запуск сортировки по мастеру
    private void OrderByArtisan_Command(object sender, EventArgs e) {
        // упорядочить копию коллекции
        // загрузить копию в DataGridView для сортированных данных
        dgvOrdered.DataSource = null!;
        dgvOrdered.DataSource = _musicalController.OrderByArtisan();

        // вывод метода сортировки
        tbpOrdered.Text = "Упорядоченные по мастеру";

        // перейти на вкладку  упорядоченных данных
        tabControl1.SelectTab("tbpOrdered");
    } // OrderByArtisan_Command


    // Запуск сортировки по году изготовления
    private void OrderByYear_Command(object sender, EventArgs e) {
        // упорядочить копию коллекции
        // загрузить копию в DataGridView для сортированных данных
        dgvOrdered.DataSource = null!;
        dgvOrdered.DataSource = _musicalController.OrderByYear();

        // вывод метода сортировки
        tbpOrdered.Text = "Упорядоченные по году изготовления";

        // перейти на вкладку  упорядоченных данных
        tabControl1.SelectTab("tbpOrdered");
    } // OrderByYear_Command

    // Запуск сортировки по убыванию страховой стоимости
    private void OrderByInsuranceDesc_Command(object sender, EventArgs e) {
        // упорядочить копию коллекции
        // загрузить копию в DataGridView для сортированных данных
        dgvOrdered.DataSource = null!;
        dgvOrdered.DataSource = _musicalController.OrderByInsuranceDesc();

        // вывод метода сортировки
        tbpOrdered.Text = "Упорядоченные по убыванию страховой стоимости";

        // перейти на вкладку  упорядоченных данных
        tabControl1.SelectTab("tbpOrdered");
    } // OrderByYear_Command

    // запуск выборки по категории при изменении категории в комбо-боксе
    private void SelectWhereCategory_Command(object sender, EventArgs e) {
        // выборка данных и вывод в DataGridView
        dgvSelected.DataSource = null!;
        dgvSelected.DataSource = _musicalController.SelectWhereCategory(cbxCategory.Text);
        tbpSelected.Text = $"Выборка по категории \"{cbxCategory.Text}\"";

        // перейти на вкладку  упорядоченных данных
        tabControl1.SelectTab("tbpSelected");
    } // SelectWhereCategory_Command


    // запуск выборки по мастеру при изменении мастера в комбо-боксе
    private void SelectWhereArtisan_Command(object sender, EventArgs e) {
        // выборка данных и вывод в DataGridView
        dgvSelected.DataSource = null!;
        dgvSelected.DataSource = _musicalController.SelectWhereArtisan(cbxArtisan.Text);
        tbpSelected.Text = $"Выборка по мастеру \"{cbxArtisan.Text}\"";

        // перейти на вкладку  упорядоченных данных
        tabControl1.SelectTab("tbpSelected");
    } // SelectWhereArtisan_Command


    // запуск выборки по городу хранения при изменении в комбо-боксе
    private void SelectWhereCity_Command(object sender, EventArgs e) {
        // выборка данных и вывод в DataGridView
        dgvSelected.DataSource = null!;
        dgvSelected.DataSource = _musicalController.SelectWhereCity(cbxCity.Text);
        tbpSelected.Text = $"Выборка по городу хранения \"{cbxCity.Text}\"";

        // перейти на вкладку  упорядоченных данных
        tabControl1.SelectTab("tbpSelected");
    } // SelectWhereCity_Command
} // class MainForm
