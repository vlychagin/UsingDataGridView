using UsingDataGridView.Controllers;
using UsingDataGridView.Infrastructure;

namespace UsingDataGridView.Views;

public partial class MainForm : Form
{
    private RareMusicalController _musicalController;

    // ���������� �������� ����������, ������ ��� ���������
    public MainForm() {
        InitializeComponent();

        // ������ ����������
        _musicalController = new RareMusicalController();

        // ��������� �����-����� ��������� � DataGridView
        colCategory.Items.AddRange(Utils.Categories);

        // ��������� �����-������ ��� ������� ������
        cbxCategory.Items.AddRange(Utils.Categories);
        cbxArtisan.Items.AddRange(Utils.ArtisanNames);    
        cbxCity.Items.AddRange(Utils.Cities);    

        // ��������� ������ � DataGridView
        dgvInstruments.DataSource = _musicalController.RareMusicals;

        dgvOrdered.DataSource = _musicalController.OrderByName();
        tbpOrdered.Text = "������������� �� ��������";

        dgvSelected.DataSource = _musicalController.SelectWhereCategory(Utils.Categories[0]);
        tbpSelected.Text = $"������� �� ��������� \"{Utils.Categories[0]}\"";
    } // MainForm

    // ����� �� ����������
    private void Exit_Command(object sender, EventArgs e) => Application.Exit();


    // ������ ���������� �� �������� �����������
    private void OrderByName_Command(object sender, EventArgs e) {
        // ����������� ����� ���������
        // ��������� ����� � DataGridView ��� ������������� ������
        dgvOrdered.DataSource = null!;
        dgvOrdered.DataSource = _musicalController.OrderByName();

        // ����� ������ ����������
        tbpOrdered.Text = "������������� �� ��������";

        // ������� �� �������  ������������� ������
        tabControl1.SelectTab("tbpOrdered");
    } // OrderByName_Command


    // ������ ���������� �� �������
    private void OrderByArtisan_Command(object sender, EventArgs e) {
        // ����������� ����� ���������
        // ��������� ����� � DataGridView ��� ������������� ������
        dgvOrdered.DataSource = null!;
        dgvOrdered.DataSource = _musicalController.OrderByArtisan();

        // ����� ������ ����������
        tbpOrdered.Text = "������������� �� �������";

        // ������� �� �������  ������������� ������
        tabControl1.SelectTab("tbpOrdered");
    } // OrderByArtisan_Command


    // ������ ���������� �� ���� ������������
    private void OrderByYear_Command(object sender, EventArgs e) {
        // ����������� ����� ���������
        // ��������� ����� � DataGridView ��� ������������� ������
        dgvOrdered.DataSource = null!;
        dgvOrdered.DataSource = _musicalController.OrderByYear();

        // ����� ������ ����������
        tbpOrdered.Text = "������������� �� ���� ������������";

        // ������� �� �������  ������������� ������
        tabControl1.SelectTab("tbpOrdered");
    } // OrderByYear_Command

    // ������ ���������� �� �������� ��������� ���������
    private void OrderByInsuranceDesc_Command(object sender, EventArgs e) {
        // ����������� ����� ���������
        // ��������� ����� � DataGridView ��� ������������� ������
        dgvOrdered.DataSource = null!;
        dgvOrdered.DataSource = _musicalController.OrderByInsuranceDesc();

        // ����� ������ ����������
        tbpOrdered.Text = "������������� �� �������� ��������� ���������";

        // ������� �� �������  ������������� ������
        tabControl1.SelectTab("tbpOrdered");
    } // OrderByYear_Command

    // ������ ������� �� ��������� ��� ��������� ��������� � �����-�����
    private void SelectWhereCategory_Command(object sender, EventArgs e) {
        // ������� ������ � ����� � DataGridView
        dgvSelected.DataSource = null!;
        dgvSelected.DataSource = _musicalController.SelectWhereCategory(cbxCategory.Text);
        tbpSelected.Text = $"������� �� ��������� \"{cbxCategory.Text}\"";

        // ������� �� �������  ������������� ������
        tabControl1.SelectTab("tbpSelected");
    } // SelectWhereCategory_Command


    // ������ ������� �� ������� ��� ��������� ������� � �����-�����
    private void SelectWhereArtisan_Command(object sender, EventArgs e) {
        // ������� ������ � ����� � DataGridView
        dgvSelected.DataSource = null!;
        dgvSelected.DataSource = _musicalController.SelectWhereArtisan(cbxArtisan.Text);
        tbpSelected.Text = $"������� �� ������� \"{cbxArtisan.Text}\"";

        // ������� �� �������  ������������� ������
        tabControl1.SelectTab("tbpSelected");
    } // SelectWhereArtisan_Command


    // ������ ������� �� ������ �������� ��� ��������� � �����-�����
    private void SelectWhereCity_Command(object sender, EventArgs e) {
        // ������� ������ � ����� � DataGridView
        dgvSelected.DataSource = null!;
        dgvSelected.DataSource = _musicalController.SelectWhereCity(cbxCity.Text);
        tbpSelected.Text = $"������� �� ������ �������� \"{cbxCity.Text}\"";

        // ������� �� �������  ������������� ������
        tabControl1.SelectTab("tbpSelected");
    } // SelectWhereCity_Command
} // class MainForm
