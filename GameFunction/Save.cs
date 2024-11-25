using System.Text;
using System;

public AddEditRequestPage(������ selectedRequest)
{
	InitializeComponent();
	if (selectedRequest != null)
		_currentRequest = selectedRequest;

	DataContext = _currentRequest;
	ComboClient.ItemsSource = Demo2Entities.GetContext().������.ToList();
	ComboEmployee.ItemsSource = Demo2Entities.GetContext().���������.ToList();
	ComboTypeClean.ItemsSource = Demo2Entities.GetContext().C_���_������_.ToList();
	ComboAddress.ItemsSource = Demo2Entities.GetContext().���������.ToList();
}

private void BtnSave_Click(object sender, RoutedEventArgs e)
{
	StringBuilder errors = new StringBuilder();

	if (_currentRequest.������ == null)
		errors.AppendLine("������� �������");
	if (_currentRequest.��������� == null)
		errors.AppendLine("������� ����� ���������");
	if (_currentRequest.����_���������� == null)
		errors.AppendLine("������� ���� ���������� ������");
	if (_currentRequest.��������� == null)
		errors.AppendLine("������� �����������");
	if (_currentRequest.C_���_������_ == null)
		errors.AppendLine("������� ��� ������");

	if (errors.Length > 0)
	{
		MessageBox.Show(errors.ToString());
		return;
	}

	if (_currentRequest.Id == 0)
	{
		Demo2Entities.GetContext().������.Add(_currentRequest);
	}

	try
	{
		Demo2Entities.GetContext().SaveChanges();
		MessageBox.Show("���������� ������� ���������!");
		NavigationService.GoBack();
	}
	catch (Exception ex)
	{
		MessageBox.Show(ex.ToString());
	}
}