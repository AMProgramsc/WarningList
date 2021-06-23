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

void introR(string logo, string f, int cF, int cW)
{
	SytColor(cF, cW);
	system("mode con cols=140 lines=31");
	fstream lg;
	lg.open(logo, fstream::in | fstream::out | fstream::app);

	while (!lg.eof())
	{

		getline(lg, f);

		cout << f << endl;

	}

}
void TranseleteR(int h)
{
	if (h == 1)
	{
		main();
	}
}
void BackEventR(int d, string f, string g, int CF, int CW)
{
	cout << "<------" << endl;
	cout << "1) Назад" << endl;
	cin >> d;
	if (d == 1)
	{
		system("cls");
		introR(f, g, CF, CW);
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
	string logos = "Logo.txt";
	string info = "Information.txt";
	string options = "Options.txt";
	string files = "Files.txt";
	string str, msg, ftr, ltr, ntr, mtr, ktr;
	char ch, ce;
	fstream fs;
	fstream fe;
	fstream le;
	fstream ne;
	fstream me;
	fstream ke;
	string ster, stry;
	int totalScore, totalResult, CorrectResult;
	int y = 0, x, selectdata, savedata, loaddata, deletedata, save = 0, i = 0, e = 0;
	const int size = 10;
	bool exit = false;
	string name, family;
	string newname, addname;
	int arrx = 0;
	int correct;
	int colorW = 0, colorF = 7;
	int hit, hit2;
	int fix;
	int add;
	int Delete, deletef;
	int enter1 = 0, enter2, enter3 = 0, enter4, enter5 = 0;
	double warning = 0;
	double Count = 0; // Сумма оценок полученная вводом
	double result; // Общий результат(средний балл)
	vector<string> data = { "" };
	vector<string> mylist = { "Математика: ", "Русский язык: ", "Физика: ", "История: ","Английский язык: ","Химия: ","Литература: ","Обществознание: ","Биология: ","География: ","ОБЖ: ","Физкультура: ","Проектная деятельность: ","Информатика: " };
	vector<double> ryr = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
	introR(logos, ftr, colorF, colorW);
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
			le.open(options, fstream::in | fstream::out | fstream::app);

			while (!le.eof())
			{

				getline(le, ltr);

				cout << ltr << endl;

			}
			cin >> enter4;
			if (enter4 == 1)
			{
				TranseleteR(enter4);
			}
			if (enter4 == 2)
			{
				cout << "Выберите цвет окна: " << endl;
				SytColor(8, colorW);
				cout << "0.Чёрный" << endl;
				SytColor(1, colorW);
				cout << "1.Синий" << endl;
				SytColor(2, colorW);
				cout << "2.Зелёный" << endl;
				SytColor(3, colorW);
				cout << "3.Голубой" << endl;
				SytColor(4, colorW);
				cout << "4.Красный" << endl;
				SytColor(5, colorW);
				cout << "5.Фиолетовый" << endl;
				SytColor(6, colorW);
				cout << "6.Коричневый" << endl;
				SytColor(7, colorW);
				cout << "7.Светло-Серый" << endl;
				SytColor(8, colorW);
				cout << "8.Чёрно-Серый" << endl;
				SytColor(9, colorW);
				cout << "9.Светло-Синий" << endl;
				SytColor(10, colorW);
				cout << "10.Светло-Зелёный" << endl;
				SytColor(11, colorW);
				cout << "11.Светло=Голубой" << endl;
				SytColor(12, colorW);
				cout << "12.Светло-Красный" << endl;
				SytColor(13, colorW);
				cout << "13.Светло-Фиолетовый" << endl;
				SytColor(14, colorW);
				cout << "14.Жёлтый" << endl;
				SytColor(15, colorW);
				cout << "15.Белый" << endl;
				SytColor(7, colorW);
				cin >> colorW;
				switch (colorW)
				{
				case 0:
					SytColor(colorF, 0);
					break;
				case 1:
					SytColor(colorF, 1);
					break;
				case 2:
					SytColor(colorF, 2);
					break;
				case 3:
					SytColor(colorF, 3);
					break;
				case 4:
					SytColor(colorF, 4);
					break;
				case 5:
					SytColor(colorF, 5);
					break;
				case 6:
					SytColor(colorF, 6);
					break;
				case 7:
					SytColor(colorF, 7);
					break;
				case 8:
					SytColor(colorF, 8);
					break;
				case 9:
					SytColor(colorF, 9);
					break;
				case 10:
					SytColor(colorF, 10);
					break;
				case 11:
					SytColor(colorF, 11);
					break;
				case 12:
					SytColor(colorF, 12);
					break;
				case 13:
					SytColor(colorF, 13);
					break;
				case 14:
					SytColor(colorF, 14);
					break;
				case 15:
					SytColor(colorF, 15);
					break;
				}
				if (colorF == colorW)
				{
					SytColor(7, 0);
					cout << "Ошибка!Цвет текста равен цвету окна! " << endl;

				}

				BackEventR(enter3, logos, ftr, colorF, colorW);
				cin >> enter1;
				le.close();
			}
			if (enter4 == 3)
			{
				cout << "Выберите цвет шрифт: " << endl;
				SytColor(8, colorW);
				cout << "0.Чёрный" << endl;
				SytColor(1, colorW);
				cout << "1.Синий" << endl;
				SytColor(2, colorW);
				cout << "2.Зелёный" << endl;
				SytColor(3, colorW);
				cout << "3.Голубой" << endl;
				SytColor(4, colorW);
				cout << "4.Красный" << endl;
				SytColor(5, colorW);
				cout << "5.Фиолетовый" << endl;
				SytColor(6, colorW);
				cout << "6.Коричневый" << endl;
				SytColor(7, colorW);
				cout << "7.Светло-Серый" << endl;
				SytColor(8, colorW);
				cout << "8.Чёрно-Серый" << endl;
				SytColor(9, colorW);
				cout << "9.Светло-Синий" << endl;
				SytColor(10, colorW);
				cout << "10.Светло-Зелёный" << endl;
				SytColor(11, colorW);
				cout << "11.Светло=Голубой" << endl;
				SytColor(12, colorW);
				cout << "12.Светло-Красный" << endl;
				SytColor(13, colorW);
				cout << "13.Светло-Фиолетовый" << endl;
				SytColor(14, colorW);
				cout << "14.Жёлтый" << endl;
				SytColor(15, colorW);
				cout << "15.Белый" << endl;
				SytColor(7, colorW);
				cin >> colorF;
				switch (colorF)
				{
				case 0:
					SytColor(0, colorW);
					break;
				case 1:
					SytColor(1, colorW);
					break;
				case 2:
					SytColor(2, colorW);
					break;
				case 3:
					SytColor(3, colorW);
					break;
				case 4:
					SytColor(4, colorW);
					break;
				case 5:
					SytColor(5, colorW);
					break;
				case 6:
					SytColor(6, colorW);
					break;
				case 7:
					SytColor(7, colorW);
					break;
				case 8:
					SytColor(8, colorW);
					break;
				case 9:
					SytColor(9, colorW);
					break;
				case 10:
					SytColor(10, colorW);
					break;
				case 11:
					SytColor(11, colorW);
					break;
				case 12:
					SytColor(12, colorW);
					break;
				case 13:
					SytColor(13, colorW);
					break;
				case 14:
					SytColor(14, colorW);
					break;
				case 15:
					SytColor(15, colorW);
					break;
				}
				if (colorF == colorW)
				{
					SytColor(7, 0);
					cout << "Ошибка!Цвет текста равен цвету окна! " << endl;

				}

				BackEventR(enter3, logos, ftr, colorF, colorW);
				cin >> enter1;
				le.close();
			}
		}

		else if (enter1 == 4)
		{
			system("cls");
			ne.open(info, fstream::in | fstream::out | fstream::app);

			while (!ne.eof())
			{

				getline(ne, ntr);

				cout << ntr << endl;

			}
			cin >> enter2;
			switch (enter2)
			{
			case 1:
				cout << "\t\t\t .------------------------------------------------------." << endl;
				cout << "\t\t\t |Название - WarningList                                |" << endl;
				cout << "\t\t\t |Версия - 0.4.9 Basic                                  |" << endl;
				cout << "\t\t\t |id - 18062021                                         |" << endl;
				cout << "\t\t\t |Информация:                                           |" << endl;
				cout << "\t\t\t |Добавленно - Выбор любого цвета для шрифта и окна     |" << endl;
				cout << "\t\t\t |*Последняя версия Basic                               |" << endl;
				cout << "\t\t\t .------------------------------------------------------." << endl;
				BackEventR(enter3, logos, ftr, colorF, colorW);
				cin >> enter1;
				ne.close();
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
				BackEventR(enter3, logos, ftr, colorF, colorW);
				cin >> enter1;
				ne.close();
				break;
			case 3:
				cout << "\t\t\t.------------------------------------------------------." << endl;
				cout << "\t\t\t|WarningList - это программа                           |" << endl;
				cout << "\t\t\t|Которая вычисляет твой средний балл ,путём ввода чисел|" << endl;
				cout << "\t\t\t|Эта программа больше подойдёт для школьников          |" << endl;
				cout << "\t\t\t|и студентов.                                          |" << endl;
				cout << "\t\t\t.------------------------------------------------------." << endl;
				BackEventR(enter3, logos, ftr, colorF, colorW);
				cin >> enter1;
				ne.close();
				break;
			default:
				cin >> enter2;
				ne.close();
				break;
			}

		}

		else if (enter1 == 5)
		{
		me.open(files, fstream::in | fstream::out | fstream::app);

		while (!me.eof())
		{

			getline(me, mtr);

			cout << mtr << endl;

		}
			cout << "Выберите дальнейшие действия с файлом:" << endl;
			cout << "1) Загрузить " << endl;
			cout << "2) Удалить " << endl;
			cin >> deletef;
			if (deletef == 1)
			{
				while (fs.peek() == EOF)
				{
					cout << "Файл BD пуст" << endl;
					fs.close();
					BackEventR(enter3, logos, ftr, colorF, colorW);
					cin >> enter1;
				}
				while (!fs.eof())
				{



					data[i] = (char*)malloc(sizeof(char) * size);
					fs >> data[i] >> ch;
					if (i > 0)
					{
						ster = ch + data[i];
						data[i] = ster;
					}
					ce = ch;
					cout << data[i] << "\0" << endl;
					i++;
					if (i > 0)
					{
						data.push_back("");
					}
				}

				cin >> loaddata;

				fe.open(data[loaddata]);
				while (fe.peek() == EOF)
				{
					cout << "Файл " << data[i] << "пуст или не существует!" << endl;
					BackEventR(enter3, logos, ftr, colorF, colorW);
					cin >> enter1;
				}

				while (!fe.eof())
				{
					msg = "";
					getline(fe, msg);

					cout << msg << endl;
				}
				BackEventR(enter3, logos, ftr, colorF, colorW);
				cin >> enter1;
				fe.close();
				fs.close();
				me.close();
			}
			else if (deletef == 2)
			{
				while (fs.peek() == EOF)
				{
					cout << "Файл BD пуст" << endl;
					fs.close();
					BackEventR(enter3, logos, ftr, colorF, colorW);
					cin >> enter1;
				}
				cout << "Выберите файл для удаления: " << endl;
				while (!fs.eof())
				{

					data[i] = (char*)malloc(sizeof(char) * save);
					fs >> data[i] >> ch;

					if (i > 0)
					{
						str = ce + data[i];
						data[i] = str;
					}
					ce = ch;
					cout << data[i] << endl;

					i++;
					if (i > 0)
					{
						data.push_back("");
					}
				}
				cin >> deletedata;

				if (remove(data[deletedata].c_str()) != -1)
				{
					cout << "Файл " << data[deletedata] << " Удалён" << endl;
					data.erase(data.begin() + deletedata);

					fs.close();
					if (remove(bd.c_str()) != -1)
					{
						fs.open(bd, fstream::in | fstream::out | fstream::app);
						for (; e < i; e++)
						{
							fs << data[e] << endl;
						}
					}


				}
				else
				{
					cout << "Ошибка!" << endl;
				}

				fs.close();
				BackEventR(enter3, logos, ftr, colorF, colorW);
				cin >> enter1;
				me.close();
			}

		}
		if (enter1 == 1)
		{
			cout << "Загрузка..." << endl;
			cout << "\t\t\t\t._________________________________________________." << endl;
			cout << "\t\t\t\t";
			for (int f = 0; f < 50; f++)
			{

				SytColor(colorF, 15);
				cout << " ";
				SytColor(colorF, colorW);
				Sleep(100);
			}
			cout << endl;
			cout << "\t\t\t\t.-------------------------------------------------." << endl;
			system("cls");
		}
		cout << "WarningList 0.4.9 BASIC" << endl;
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
						SytColor(4, colorW);
						cout << ".__________________________________." << endl;
						cout << "|Ошибка! Элемент не найден!        |" << endl;
						cout << "|Пожалуйста,введите элемент снова: |" << endl;
						cin >> Delete;
						cout << ".----------------------------------." << endl;
						SytColor(colorF, colorW);
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
				SytColor(4, colorW);
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
				SytColor(colorF, colorW);
				getch();
			}
			else if (ryr[x] <= 3.5)
			{
				SytColor(14, colorW);
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
				SytColor(colorF, colorW);
				getch();
			}
			else if (ryr[x] <= 4.5)
			{
				SytColor(10, colorW);
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
				SytColor(colorF, colorW);
				getch();
			}
			else
			{
				SytColor(3, colorW);
				cout << "Твой средний балл = " << result << endl;
				cout << "У тебя всё просто идельно! ;) " << endl;
				SytColor(colorF, colorW);
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
			SytColor(4, colorW);
			cout << "Твой общий средний балл(четвертная)" << totalResult << endl;
			SytColor(colorF, colorW);
			break;
		case 3:
			SytColor(14, colorW);
			cout << "Твой общий средний балл(четвертная) " << totalResult << endl;
			SytColor(colorF, colorW);
			break;
		case 4:
			SytColor(2, colorW);
			cout << "Твой общий средний балл(четвертная) " << totalResult << endl;
			SytColor(colorF, colorW);
			break;
		case 5:
			SytColor(3, colorW);
			cout << "Твой общий средний балл(четвертная) " << totalResult << endl;
			SytColor(colorF, colorW);
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
			cin >> ster;
			fs << ster << "\n";

			fs.open(bd, fstream::in | fstream::out | fstream::app);
			fe.open(ster, fstream::in | fstream::out | fstream::app);

			try
			{
				cout << "Файл открыт! " << endl;
				fs << ster << "\n";

			}
			catch (exception esf)
			{
				cout << "Файл не открыт " << endl;
				cout << esf.what() << endl;
			}
			try
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
				fe << "Версия: " << "0.4.9 BASIC" << endl;
				fe << "Время работы программы: " << clock() << "/сек" << endl;

			}
			catch (exception ese)
			{
				cout << "Файл не открыт! " << endl;
				cout << ese.what() << endl;
			}
			fs.close();
			fe.close();
		}
	}
}
