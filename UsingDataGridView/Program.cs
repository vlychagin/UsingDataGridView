using UsingDataGridView.Views;

namespace UsingDataGridView;

/*
 * ������������ ���������� Windows Forms � �������������� ��������� ���������
 * ����������. ����������� ��������� ����.
 * � DataGridView �������� ���������� � ��������� ������ �����������
 * ������������. ���������� ����������� ������: 
 *     � �������� �������������
 *     � �������� �����������
 *     � ��������� (�������, ��������, �������, � �.�.)
 *     � ������, ��������� ����������
 *     � ��� ������������ �����������
 *     � ����� ��������
 *     � ��������� ��������� 
 * ����������� �� ����� 10 �������, �������� ���������� � ������� Load �����
 * �� ����� � ������� JSON (������� App_Data � ��� �� ��������, ��� �
 * ����������� ����, ��� ����� rare_musical.json). ����� �������� ����������
 * �� �������� ����, � �������������� ����������� ��������, ���������������.
 * ���������� ���� ������ ����������� � ������ DataGridView, ��� ���� ��������
 * ������������� ������� �� ���������, ������� ��� ����� ������� �������� read
 * only, �������� ���� ���������� ����������� ������������� ��������������.
 * ��������� ����������� ������� ��� ������ �����-����� � ������ �����.
 * ������������� ��������� ����� � ������ �����.
 * ���������� ��������� � ����� � ������� JSON, ��� ����� � ����� ���
 * ���������� ��������� ����������� ��������.  
 * �� �������� ���� ��������� ��������� ��������� ��� ��������� ��������
 * � ������ ����������� ������������.
 *     1. ���������� ����� ��������� � ������� ��������������� ���������
 *        � DataGridView � ������ �������:
 *         � �� ��������
 *         � �� �������
 *         � �� ���� ������������
 *         � �� �������� ����
 *     2. ������� �� ���������:
 *         � �� ���������
 *         � �� �������, ���������� ����������
 *         � �� ������ ��������
 *
 */
internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
