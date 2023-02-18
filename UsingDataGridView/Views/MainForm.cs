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

        // ��������� �����-����� ���������
        colCategory.Items.AddRange(Utils.Categories);

        // ��������� ������ � DataGridView
        dgvInstruments.DataSource = _musicalController.RareMusicals;
    } // MainForm

    // ����� �� ����������
    private void Exit_Command(object sender, EventArgs e) => Application.Exit();
} // class MainForm
