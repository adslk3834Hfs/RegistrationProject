using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Registration
{
	public class User
	{
		//-----magic numbers----

		int fifty= 50;
		int five = 5;

		//--------fields------
		private string _email;
		private string _phone;
		private string _fullName;
		private int    _age;
		private string _password;
		//----------------------------methods---------------------------
		public User()
		{
			_email="asd";
			_phone= "asd";
			_fullName= "asd";
			_age=100;
			_password= "asd";
		}
		//mail
		public void InitMail()
		{
			WriteLine("\nВведите мэйл [мэйл должен содержать @ и .]:");
			while (true)
			{
				_email = ReadLine();
				if (_email.Contains('@') == true && _email.Contains('.') == true && _email.IndexOf('@')<_email.IndexOf('.'))
				{
					break;
				}
				else
				{
					WriteLine("Неправильный мэйл! Смотри правила");
				}
			}
		}
		//phone
		public void InitPhone()
		{
			while (true)
			{
				WriteLine("\nВведите ваш телефон [больше 7 и меньше 16 знаков и можно использовать цифры,-,(),+]: ");
				_phone = ReadLine();

				if (string.IsNullOrWhiteSpace(_phone) == true)
				{
					WriteLine("телефон  не должно быть пустым!");
				}
				if (_phone.Length > 7 && _phone.Length < 16)
				{
					foreach (char symbol in _phone)
					{
						if (symbol >'0'&&symbol<'9'||symbol=='('&& symbol ==')'||symbol=='+'||symbol=='-')
						{
							if (_phone[0]=='+'||_phone.Contains('+') == false || _phone.IndexOf('(') < _phone.IndexOf(')'))
							{
								break;
							}
						}
					}
					break;
				}
				else { WriteLine("Вы ввели неправильный номер"); }
			}
		}
		//name
		public void InitFullName()
		{
			while (true)
			{
				WriteLine("\nВведите полное имя [не более 50 символов]: ");
				_fullName = ReadLine();

				if (string.IsNullOrWhiteSpace(_fullName) == true)
				{
					WriteLine("Имя должно быть не пустое!");
				}

				if (_fullName.Length > fifty)
				{
					_fullName = null;
					WriteLine("Логин не должен быть больше 50 символов\n");
				}
				else if (string.IsNullOrWhiteSpace(_fullName) == false && _fullName.Length < fifty) { break; }
			}
		}
		//password
		public void InitPassword()
		{
			bool correct = false;
			WriteLine("\nВведите пароль [Пароль должен содержать верхний и нижний регистр, цифру и символ]:");
			while (true)
			{
				_password = ReadLine();
				for (int i = 0; i < _password.Length; i++)
				{
					if (char.IsUpper(_password[i]) == true
						&& char.IsLower(_password[i]) == true
						&& char.IsSymbol(_password[i]) == true
						&& char.IsNumber(_password[i]) == true)
					{
						correct = true;
						break;
					}
					else if (i == _password.Length - 1) { WriteLine("Неправильный пароль!"); }
				}
				if (_password.Length < five && correct == false)
				{
					_password = null;
					WriteLine("Пароль должен быть больше 5 символов\n");
				}
				else { break; }
			}

			while (true)
			{
				WriteLine("Введите повторно пароль: ");
				string password = ReadLine();
				if (password != _password)
				{
					password = null;
					WriteLine("Пароль не совпадает!\n");
				}
				else { break; }
			}
		}
		public void InitAge()
		{
			bool correctAge = false;
			while (correctAge!=true)
			{
				try
				{
					WriteLine("Ваш возраст [цифры]: ");
					_age = Convert.ToInt32(ReadLine());
				}
				catch
				{
					WriteLine("Вы ввели возраст не правильно!");
					continue;
				}
				correctAge = true;
			}
		}
		//------------------------------Getters-----------------------------------

		public string GetFullName()
		{
			return _fullName;
		}
		public string GetPassword()
		{
			return _password;
		}
		public string GetMail()
		{
			return _email;
		}
		public string GetPhone()
		{
			return _phone;
		}
		//Print
		public void Print()
		{
			WriteLine($"Ваш мэйл: {_email}\nВаш телефон: {_phone}\nВаше имя: {_fullName}\nВаш возраст: {_age}\nВаш пароль: {_password}");
		}
	}
}
