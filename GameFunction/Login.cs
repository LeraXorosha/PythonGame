		private void Btn_Login(object sender, RoutedEventArgs e)
		{
			var context = Demo2Entities.GetContext();

			var user = context.Пользователь.FirstOrDefault(u => u.Пароль == PasswordTextBox.Password && u.Логин == LoginTextBox.Text);
			if (user == null)
			{
				MessageBox.Show("Ошибка!!! Введите корректный логин и пароль");
				return;
			}


			if (user.Роль == 3)
			{
				NavigationService.Navigate(new Pages.Administrator());
			}
		}