using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("------------Добро пожаловать!-------------\n");

			User user = new User();

			user.InitMail();
			user.InitPhone();
			user.InitFullName();
			user.InitAge();
			user.InitPassword();
			Console.WriteLine("\n------------Вывод--------------\n");
			user.Print();

			Accounts ourUsers = new Accounts();

			Console.WriteLine("\n------------Добавление пользователя--------------\n");
			ourUsers.AddUser(user);

			Console.WriteLine("\n------------Удаление пользователя--------------\n");
			ourUsers.RemoveUser(user);

			Console.WriteLine("\n------------Список всех пользователей--------------\n");
			ourUsers.Print();

			Console.WriteLine("\n------------Запись в файл--------------\n");
			//Serializer<string[]>.Save("куда-то", что_то);

			Console.WriteLine("\n------------Чтение из файла--------------\n");
			//что_то = Serializer<string[]>.Load("откуда-то");

		}
	}
}
