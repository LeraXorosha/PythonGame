using System.Text;
using System;

public AddEditRequestPage(Заявки selectedRequest)
{
	InitializeComponent();
	if (selectedRequest != null)
		_currentRequest = selectedRequest;

	DataContext = _currentRequest;
	ComboClient.ItemsSource = Demo2Entities.GetContext().Клиент.ToList();
	ComboEmployee.ItemsSource = Demo2Entities.GetContext().Сотрудник.ToList();
	ComboTypeClean.ItemsSource = Demo2Entities.GetContext().C_Тип_уборки_.ToList();
	ComboAddress.ItemsSource = Demo2Entities.GetContext().Помещение.ToList();
}

private void BtnSave_Click(object sender, RoutedEventArgs e)
{
	StringBuilder errors = new StringBuilder();

	if (_currentRequest.Клиент == null)
		errors.AppendLine("Выбеите клиента");
	if (_currentRequest.Помещение == null)
		errors.AppendLine("Выбеите адрес помещения");
	if (_currentRequest.Дата_исполнения == null)
		errors.AppendLine("Введите дату исполнения заявки");
	if (_currentRequest.Сотрудник == null)
		errors.AppendLine("Выбеите исполнителя");
	if (_currentRequest.C_Тип_уборки_ == null)
		errors.AppendLine("Выбеите тип уборки");

	if (errors.Length > 0)
	{
		MessageBox.Show(errors.ToString());
		return;
	}

	if (_currentRequest.Id == 0)
	{
		Demo2Entities.GetContext().Заявки.Add(_currentRequest);
	}

	try
	{
		Demo2Entities.GetContext().SaveChanges();
		MessageBox.Show("Информация успешно сохранена!");
		NavigationService.GoBack();
	}
	catch (Exception ex)
	{
		MessageBox.Show(ex.ToString());
	}
}