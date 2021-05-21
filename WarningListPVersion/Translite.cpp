#include "Translite.h"


enum ConsoleColor
{
	Black = 0,
	Blue = 1,
	Green = 2,
	Cyan = 3,
	Red = 4,
	Magneta = 5,
	Brown = 6,
	LightGray = 7,
	DarkGray = 8,
	LightBlue = 9,
	LightGreen = 10,
	LightCyan = 11,
	LightRed = 12,
	LightMagneta = 13,
	Yellow = 14,
	White = 15
};

void SytColor(int text, int bg)
{
	HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hStdOut, (WORD)((bg << 4) | text));
}

enum class score { two = 2, three, four, five };

void introR()
{
	cout << endl;
	cout << "\t\t\t\t.___________________________." << endl;
	cout << "\t\t\t\t|WarningList 0.4.5 BASIC    |" << endl;
	cout << "\t\t\t\t|Последнее обновление       |" << endl;
	cout << "\t\t\t\t|Создал AMPrograms          |" << endl;
	cout << "\t\t\t\t.---------------------------." << endl;
	cout << "\t\t\t\t      .______________." << endl;
	cout << "\t\t\t\t      |1)Старт       |" << endl;
	cout << "\t\t\t\t      |2)Выход       |" << endl;
	cout << "\t\t\t\t      |3)Опции       |" << endl;
	cout << "\t\t\t\t      |4)Информация  |" << endl;
	cout << "\t\t\t\t      .--------------." << endl;
}
void TranseleteR(int h)
{
	if (h == 1)
	{
		main();
	}
}
void BackEventR(int d)
{
	cout << "<------" << endl;
	cout << "1) Назад" << endl;
	cin >> d;
	if (d == 1)
	{
		system("cls");
		introR();
	}
	else
	{
		cin >> d;
	}
}
class UserR //User Information
{
public:
	UserR(string h,string j,int d) : name(h),family(j),ID(d)
	{

	}
	void Tabl()
	{
		cout << "._____________________________." << endl;
		cout << "|Твоё имя: " << name << endl;
		cout << "|Твоя Фамилия: " << family << endl;
		cout << "|Твой ID - " << ID << endl;
		cout << "._____________________________." << endl;
	}
	void SetID(int id)
	{
		this->ID = id;
	}
	int GetID()
	{
		return ID;
	}
private:
	int ID;
	string name;
	string family;
};

int Translite()
{
	srand(time(NULL));
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int id = rand() % 10000;
	string bd = "BD.txt";
	string str, msg;
	char ch;
	fstream fs;
	fstream fe;
	int totalScore, totalResult, CorrectResult;
	int y = 0 ,x,selectdata, savedata, loaddata, save = 0, i = 0;
	const int size = 10;
	bool exit = false;
	string name, family;
	string newname, addname;
	int arrx = 0;
	int correct;
	int hit, hit2;
	int fix;
	int add;
	int Delete;
	int enter1 = 0, enter2, enter3 = 0, enter4, enter5 = 0;
	double warning = 0;
	double Count = 0; // Сумма оценок полученная вводом
	double result; // Общий результат(средний балл)
	string data[size]{};
	vector<string> mylist = { "Математика: ", "Русский язык: ", "Физика: ", "История: ","Английский язык: ","Химия: ","Литература: ","Обществознание: ","Биология: ","География: ","ОБЖ: ","Физкультура: ","Проектная деятельность: ","Информатика: " };
	vector<double> ryr = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
	introR();
	fs.open(bd, fstream::in | fstream::out | fstream::app);
	cin >> enter1;
	while (enter1 != 1)
	{
		if (enter1 == 2)
		{
			cout << "Выход..." << endl;
			return 0;
		}
		else if (enter1 == 3)
		{
			system("cls");
			cout << "\t\t\t\t     Опции *Тест*" << endl;
			cout << "\t\t\t\t     .------------." << endl;
			cout << "\t\t\t\t     |1)Язык      |" << endl;
			cout << "\t\t\t\t     |2)Графика   |" << endl;
			cout << "\t\t\t\t     |3)НЕИЗВЕСТНО|" << endl;
			cout << "\t\t\t\t     .------------." << endl;
			cin >> enter4;
			TranseleteR(enter4);
			BackEventR(enter3);
			cin >> enter1;
		}
		else if (enter1 == 4)
		{
			system("cls");
			cout << "\t\t\t\t     Информационное меню" << endl;
			cout << "\t\t\t\t  .-------------------------." << endl;
			cout << "\t\t\t\t  |1)Информация об версии   |" << endl;
			cout << "\t\t\t\t  |2)Об разработчике        |" << endl;
			cout << "\t\t\t\t  |3)Что такое WarningList? |" << endl;
			cout << "\t\t\t\t  .-------------------------." << endl;
			cin >> enter2;
			switch (enter2)
			{
			case 1:
				cout << "\t\t\t .------------------------------------------------------." << endl;
				cout << "\t\t\t |Название - WarningList                                |" << endl;
				cout << "\t\t\t |Версия - 0.4.5 Basic                                  |" << endl;
				cout << "\t\t\t |id - 21052021                                         |" << endl;
				cout << "\t\t\t |Информация:                                           |" << endl;
				cout << "\t\t\t |Добавленно - Тест записи информации в файл            |" << endl;
				cout << "\t\t\t |                                                      |" << endl;
				cout << "\t\t\t .------------------------------------------------------." << endl;
				BackEventR(enter3);
				cin >> enter1;
				break;
			case 2:
				cout << "\t\t\t.-----------------------------------------------------------." << endl;
				cout << "\t\t\t|Здравствуйте! Меня зовут Александр, это мой третий проект. |" << endl;
				cout << "\t\t\t|Вы наверное знаете меня по двум другим проектам,и их имена |" << endl;
				cout << "\t\t\t|RPG BASIC и Snake. Я уже программирую два года и 3 месяца. |" << endl;
				cout << "\t\t\t|Моя основная классификация это C++, C(Новичок),и           |" << endl;
				cout << "\t\t\t|C#(3 - 6 месяца). Разработка данной программы введётся     |" << endl;
				cout << "\t\t\t|по сей день...                                             |" << endl;
				cout << "\t\t\t.-----------------------------------------------------------." << endl;
				BackEventR(enter3);
				cin >> enter1;
				break;
			case 3:
				cout << "\t\t\t.------------------------------------------------------." << endl;
				cout << "\t\t\t|WarningList - это программа                           |" << endl;
				cout << "\t\t\t|Которая вычисляет твой средний балл ,путём ввода чисел|" << endl;
				cout << "\t\t\t|Эта программа больше подойдёт для школьников          |" << endl;
				cout << "\t\t\t|и студентов.                                          |" << endl;
				cout << "\t\t\t.------------------------------------------------------." << endl;
				BackEventR(enter3);
				cin >> enter1;
				break;
			default:
				cin >> enter2;
				break;
			}
		
		}
		
		else if (enter1 == 5)
		{

			cout << "Выберите файл для загрузки информации: " << endl;
			while (!fs.eof())
			{



				data[i] = (char*)malloc(sizeof(char) * size);
				fs >> data[i] >> ch;
				if (i > 0)
				{
					str = ch + data[i];
					data[i] = str;
				}
				cout << data[i] << endl;
				i++;
			}

			cin >> loaddata;

			fe.open(data[loaddata]);

			while (!fe.eof())
			{
				msg = "";
				getline(fe, msg);

				cout << msg << endl;
			}
			fe.close();
			fs.close();
			BackEventR(enter3);
			cin >> enter1;
		}
		
	}
	if (enter1 == 1)
	{
		cout << "Загрузка..." << endl;
		cout << "\t\t\t._________________________________________________." << endl;
		cout << "\t\t\t";
		for (int f = 0; f < 50; f++)
		{

			SytColor(0, 15);
			cout << " ";
			SytColor(15, 0);
			Sleep(100);
		}
		cout << endl;
		cout << "\t\t\t.-------------------------------------------------." << endl;
		system("cls");
	}
	cout << "WarningList 0.4.5 BASIC" << endl;
	cout << ".__________________________." << endl;
	cout << "|Введите имя студента/школьника: ";
	cin >> name;
	cout << "|Введите Фамилию студента/школьника: ";
	cin >> family;
	while (name == family)
	{
		cout << "Ошибка! Имя и фамилия одинаковы!" << endl;
		cout << "|Введите имя студента/школьника: ";
		cin >> name;
		cout << "|Введите Фамилию студента/школьника: ";
		cin >> family;
	}
	cout << "|Ваш ID: " << "#" << id << "|" << endl;
	cout << ".--------------------------." << endl;
	UserR user(name, family, id);
	Sleep(300);
	system("cls");

	vector<int> d_syze = {}; // Количество вводимых оценок

	/*for (int i = 0; i < size; i++)
	{
		cout << arr[i] << endl;
	}
	*/

	cout << "Введите ваши оценки: " << endl;

	for (int c = 0; c < mylist.size(); c++)
	{
		user.Tabl();
		cout << "Хотите добавить или изменить элемент?" << endl;
		cout << "1)Да" << endl;
		cout << "2)Удалить" << endl;
		cout << "3)Нет" << endl;
		cin >> enter5;

		while (exit != 1)
		{
			if (enter5 == 1)
			{
				cout << "Выберите элемент чтобы изменить или добавьте новый" << endl;
				cin >> fix;
				if (fix > mylist.size())
				{
					cout << "Введите имя добавленого элемента: " << endl;
					cin >> addname;

					mylist.push_back(addname);
					ryr.push_back(0);
				}
				else
				{
					cout << "Введите имя изменёного элемента: " << endl;
					cin >> newname;
					mylist[fix] = newname;
				}
			}
			if (enter5 == 2)
			{
				cout << "Введите элемент для его удаления: " << endl;
				cin >> Delete;
				while (Delete > mylist.size())
				{
					SytColor(4, 0);
					cout << ".__________________________________." << endl;
					cout << "|Ошибка! Элемент не найден!        |" << endl;
					cout << "|Пожалуйста,введите элемент снова: |" << endl;
					cin >> Delete;
					cout << ".----------------------------------." << endl;
					SytColor(15, 0);
				}
				mylist.erase(mylist.begin() + Delete);
				ryr.erase(ryr.begin() + Delete);

			}
			cout << "Выход?" << endl;
			cout << "1)Да" << endl;
			cout << "0)Нет" << endl;
			cin >> exit;
			if (exit == 0)
			{
				cout << "1)Исправить элемент" << endl;
				cout << "2)Удалить" << endl;
				cout << "3)Нет" << endl;
				cin >> enter5;
			}
		}
		for (int h = 0; h < mylist.size(); h++)
		{
			cout << "|" << mylist[h] << " = " << ryr[h] << "\t|" << endl;
		}
		cout << ".------------------------------" << endl;
		cout << "Enter element array: " << endl;
		cin >> x;
		cout << mylist[x] << endl;
		cout << "--------------------" << endl;
		cout << "|Введите количество оценок: " << endl;
		cin >> arrx;
		d_syze.resize(arrx);
		while (arrx < 3)
		{
			SytColor(4, 0);
			cout << ".________________________________________________." << endl;
			cout << "|Ошибка! Ваше количество оценок очень маленькое! |" << endl;
			cout << "|Пожалуйста, введите количество оценок повторно: |" << endl;
			cin >> arrx;
			cout << ".------------------------------------------------." << endl;
			SytColor(15, 0);
		}
		cout << "--------------------" << endl;


		for (int i = 0;i < arrx; i++)
		{
			cout << "Введите Оценку: " << endl;
			cin >> d_syze[i];
			switch (d_syze[i])
			{
			case 2:
				score::two;
				break;
			case 3:
				score::three;
				break;
			case 4:
				score::four;
				break;
			case 5:
				score::five;
				break;
			}
			while (d_syze[i] <= 1 || d_syze[i] > 5)
			{
				cout << "Ошибка! Неправильный номер! " << endl;
				d_syze[i] = NULL;
				cin >> d_syze[i];
			}

			Count += d_syze[i];


		}
		cout << "Хотите изменить результат? " << endl;
		cout << "1) Да " << endl;
		cout << "2) Нет " << endl;
		cin >> CorrectResult;
		if (CorrectResult == 1)
		{
			Count = NULL;
			for (int i = 0;i < arrx; i++)
			{
				cout << "Введите оценки: " << endl;
				cin >> d_syze[i];
				switch (d_syze[i])
				{
				case 2:
					score::two;
					break;
				case 3:
					score::three;
					break;
				case 4:
					score::four;
					break;
				case 5:
					score::five;
					break;
				}

				if (d_syze[i] == 1 || d_syze[i] > 5)
				{
					cout << "Ошибка! Неправильный номер! " << endl;
					d_syze[i] = NULL;
					cin >> d_syze[i];
				}

				Count += d_syze[i];


			}
		}

		// Count = d_syze[0] + d_syze[1] + d_syze[2] + d_syze[3] + d_syze[4];

		result = Count / arrx;


		ryr[x] = result;


		if (ryr[x] <= 2.5)
		{
			SytColor(4, 0);
			cout << "Твой средний балл = " << result << endl;
			cout << "ВНИМАНИЕ!!! Средний балл очень низкий! " << endl;
			for (; warning < 2.6; )
			{
				warning = (Count + 3) / (arrx + 1);
				Count += 3;
				arrx += 1;
				cout << "Тебе нужно: " << 3 << " для " << warning << endl;

			}
			warning = NULL;
			SytColor(15, 0);
			getch();
		}
		else if (ryr[x] <= 3.5)
		{
			SytColor(14, 0);
			cout << "Твой средний балл = " << result << endl;
			cout << "Внимание! Средний балл равен 3!" << endl;
			for (; warning < 3.6; )
			{
				warning = (Count + 4) / (arrx + 1);
				Count += 4;
				arrx += 1;
				cout << "Тебе нужно: " << 4 << " для " << warning << endl;
			}
			warning = NULL;
			SytColor(15, 0);
			getch();
		}
		else if (ryr[x] <= 4.5)
		{
			SytColor(10, 0);
			cout << "Твой средний балл = " << result << endl;
			cout << "Внимание! Средний балл равен 4!" << endl;
			for (; warning < 4.6; )
			{
				warning = (Count + 5) / (arrx + 1);
				Count += 5;
				arrx += 1;
				cout << "Тебе нужно: " << 5 << " для " << warning << endl;
			}
			warning = NULL;
			SytColor(15, 0);
			getch();
		}
		else
		{
			SytColor(3, 0);
			cout << "Твой средний балл = " << result << endl;
			cout << "У тебя всё просто идельно! ;) " << endl;
			SytColor(15, 0);
			getch();
		}

		exit = false;
		Count = NULL;
		system("cls");
	}

	cout << endl;

	totalScore = ryr[0] + ryr[1] + ryr[2] + ryr[3] + ryr[4] + ryr[5] + ryr[6] + ryr[7] + ryr[8] + ryr[9] + ryr[10] + ryr[11] + ryr[12] + ryr[13]; // Общая сумма всех предметов 
	totalResult = totalScore / 14; // Общий средний балл
	switch (totalResult)
	{
	case 2:
		SytColor(4, 0);
		cout << "Твой общий средний балл(четвертная)" << totalResult << endl;
		SytColor(15, 0);
		break;
	case 3:
		SytColor(14, 0);
		cout << "Твой общий средний балл(четвертная) " << totalResult << endl;
		SytColor(15, 0);
		break;
	case 4:
		SytColor(2, 0);
		cout << "Твой общий средний балл(четвертная) " << totalResult << endl;
		SytColor(15, 0);
		break;
	case 5:
		SytColor(3, 0);
		cout << "Твой общий средний балл(четвертная) " << totalResult << endl;
		SytColor(15, 0);
		break;
	}
	cout << "Конечная статистика: " << endl;
	cout << "._____________________________________." << endl;
	cout << "|Твоё имя: " << name << "\t|" << endl;
	cout << "|Твоя фамилия: " << family << "\t|" << endl;
	cout << "|Твой ID: " << id << "\t|" << endl;
	cout << "|Твой общий средний балл(Четвертная): " << totalResult << "\t|" << endl;
	cout << "|Рекомендация: " << "\t|" << endl;
	cout << ".-------------------------------------." << endl;
	return 0;
	cout << "Сохранить: " << endl;
	cout << "1) Да " << endl;
	cout << "2) Нет " << endl;
	cin >> savedata;
	if (savedata == 1)
	{
		cout << "Введите имя файла: " << endl;
		cin >> data[i];
		fs << data[i] << "\n";

		fs.open(bd, fstream::in | fstream::out | fstream::app);
		fe.open(data[i], fstream::in | fstream::out | fstream::app);

		if (!fs.is_open())
		{
			cout << "Файл не открыт " << endl;
		}
		else
		{
			cout << "Файл открыт! " << endl;
			fs << data[i] << "\n";

		}
		if (!fe.is_open())
		{
			cout << "Файл не открыт! " << endl;
		}
		else
		{

			cout << "Файл открыт!" << endl;
			fe << "Конечная Статистика: " << endl;
			fe << ".____________________________." << endl;
			fe << "|Твоё имя: " << name << "\t|" << endl;
			fe << "|Твоя фамилия: " << family << "\t|" << endl;
			fe << "|Твой ID: " << user.GetID() << "\t|" << endl;
			fe << "|Твой общий счёт: " << totalResult << "\t|" << endl;
			fe << "|Рекомендация: " << "\t|" << endl;
			fe << ".----------------------------." << endl;
			fe << "._____________________________." << endl;
			for (int h = 0; h < mylist.size(); h++)
			{
				fe << "|" << mylist[h] << " = " << ryr[h] << "\t|" << endl;
			}
			fe << ".------------------------------" << endl;
		}
		fs.close();
		fe.close();
	}
}