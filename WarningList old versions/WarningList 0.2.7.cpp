#include <iostream>
#include <string>
#include <Windows.h>
#include <time.h>
#include <conio.h>
#include <fstream>
#include <sql.h>

#pragma warning(disable : 4996);

using namespace std;

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

void SetColor(int text, int bg)
{
	HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
	SetConsoleTextAttribute(hStdOut, (WORD)((bg << 4) | text));
}

enum class score { two = 2, three, four, five };

void intro()
{
	cout << endl;
	cout << "\t\t\t\t.___________________________." << endl;
	cout << "\t\t\t\t|WarningList 0.2.7 BASIC    |" << endl;
	cout << "\t\t\t\t|Colums and boxes           |" << endl;
	cout << "\t\t\t\t|Created by AMPrograms      |" << endl;
	cout << "\t\t\t\t.---------------------------." << endl;
	cout << "\t\t\t\t      .______________." << endl;
	cout << "\t\t\t\t      |1)Start       |" << endl;
	cout << "\t\t\t\t      |2)Exit        |" << endl;
	cout << "\t\t\t\t      |3)Options     |" << endl;
	cout << "\t\t\t\t      |4)Information |" << endl;
    cout << "\t\t\t\t      .--------------." << endl;
}

void BackEvent(int d)
{
	cout << "<------" << endl;
	cout << "1) Back" << endl;
	cin >> d;
	if (d == 1)
	{
		system("cls");
		intro();
	}
	else
	{
		cin >> d;
	}
}
class User //User Information
{
public:
	string name;
	string family;
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
};

int main()
{
	ofstream("Yourdannie.txt");
	srand(time(NULL));
	int totalScore, totalResult, CorrectResult;
	int arrx = 0;
	int correct;
	int hit, hit2;
	int enter1 = 0, enter2, enter3 = 0;
	double warning = 0;
	double Count = 0; // Сумма оценок полученная вводом
	double result; // Общий результат(средний балл)
	const int suze = 14;
	double ryr[suze]{};
	const int size = 14;
	string arr[size]{ "Match: ", "Rus.Iaz: ", "Physics: ", "History: ","Eng.Iaz: ","Chemistry: ","Literature: ","Socialscience: ","Biology: ","Geography: ","LSF: ","PE: ","PD: ","Informatics: " };
	User user;
	user.SetID(rand() % 10000);
	intro();
	cin >> enter1;
	if (enter1 == 3)
	{
		system("cls");
		cout << "\t\t\t\t     OPTIONS TEST" << endl;
		cout << "\t\t\t\t     *SAMPLETEXT" << endl;
		cout << "\t\t\t\t     *SAMPLETEXT" << endl;
		cout << "\t\t\t\t     *SAMPLETEXT" << endl;
		BackEvent(enter3);
		cin >> enter1;
	}
	if (enter1 == 4)
	{
		system("cls");
		cout << "\t\t\t\t     INFORMATION MENU" << endl;
		cout << "\t\t\t\t  .----------------------." << endl;
		cout << "\t\t\t\t  |1)Version information |" << endl;
		cout << "\t\t\t\t  |2)About developer     |" << endl;
		cout << "\t\t\t\t  |3)What is WarningList?|" << endl;
		cout << "\t\t\t\t  .----------------------." << endl;
		cin >> enter2;
		switch (enter2)
		{
		case 1:
			cout << "\t\t\t .------------------------------------------------." << endl;
			cout << "\t\t\t |Name - WarningList                              |" << endl;
			cout << "\t\t\t |Version - 0.2.7 Basic                           |" << endl;
			cout << "\t\t\t |Information:                                    |" << endl;
			cout << "\t\t\t |Added - Correction Results                      |" << endl;
			cout << "\t\t\t |Added - Test options                            |" << endl;
			cout << "\t\t\t .------------------------------------------------." << endl;
			BackEvent(enter3);
			cin >> enter1;
			break;
		case 2:
			cout << "\t\t\t.-----------------------------------------------------------." << endl;
			cout << "\t\t\t|Hello! My name Alexander! It's my three project.           |" << endl;
			cout << "\t\t\t|You probably know me from two other projects, namely       |" << endl;
			cout << "\t\t\t|RPG BASIC and Snake. I've been programmimg for 2 years now |" << endl;
			cout << "\t\t\t|and 3 mounts. My main classification is C++, C(Newble),and |" << endl;
			cout << "\t\t\t|C#(3 - 6 mounts). The development of the program is onging |" << endl;
			cout << "\t\t\t|to this day...                                             |" << endl;
			cout << "\t\t\t.-----------------------------------------------------------." << endl;
			BackEvent(enter3);
			cin >> enter1;
			break;
		case 3:
			cout << "\t\t\t.------------------------------------------------------." << endl;
			cout << "\t\t\t|WarningList - this is a program                       |" << endl;
			cout << "\t\t\t|that calculates your GPA by entering several values.  |" << endl;
			cout << "\t\t\t|This program is very suitable for both schoolchildrens|" << endl;
			cout << "\t\t\t|and students                                          |" << endl;
			cout << "\t\t\t.------------------------------------------------------." << endl;
			BackEvent(enter3);
			cin >> enter1;
			break;
		default:
			cin >> enter2;
			break;
		}

	}
	if (enter1 == 1)
	{
		cout << "Loading..." << endl;
		cout << "\t\t\t._________________________________________________." << endl;
		cout << "\t\t\t";
		for (int f = 0; f < 50; f++)
		{

			SetColor(0, 15);
			cout << " ";
			SetColor(15, 0);
			Sleep(100);
		}
		cout << endl;
		cout << "\t\t\t.-------------------------------------------------." << endl;
		system("cls");
	}
	else
	{
		cout << "Exit..." << endl;
		return 0;
	}
	cout << "WarningList 0.2.6 BASIC" << endl;
	cout << ".__________________________." << endl;
	cout << "|Enter name student: ";
	cin >> user.name;
	cout << "|Enter family student: ";
	cin >> user.family;
	if (user.name == user.family)
	{
		cout << "Error! Name and Family equal!" << endl;
		cout << "|Enter name student: ";
		cin >> user.name;
		cout << "|Enter family student: ";
		cin >> user.family;
	}
	cout << "|Your ID: " << "#" << user.GetID() << "|" << endl;
	cout << ".--------------------------." << endl;
	Sleep(300);
	system("cls");

	int* d_syze = new int[arrx]; // Количество вводимых оценок

	/*for (int i = 0; i < size; i++)
	{
		cout << arr[i] << endl;
	}
	*/

	cout << "Entering score subjects: " << endl;

	for (int c = 0; c < size; c++)
	{
		cout << "._____________________________." << endl;
		cout << "|Your name: " << user.name << endl;
		cout << "|Your family: " << user.family << endl;
		cout << "|Your ID - " << user.GetID() << endl;
		cout << "._____________________________." << endl;
		for (int h = 0; h < size; h++)
		{
			cout << "|" << arr[h] << " = " << ryr[h] << "\t|" << endl;
		}
		cout << ".------------------------------" << endl;
		cout << arr[c] << endl;
		cout << "--------------------" << endl;
		cout << "|Enter quantity array: " << endl;
		cin >> arrx;
		if (arrx < 3)
		{
			SetColor(4, 0);
			cout << ".________________________________." << endl;
			cout << "|Error! Your array is very low!  |" << endl;
			cout << "|Please, enter the number again: |" << endl;
			cin >> arrx;
			cout << ".--------------------------------." << endl;
			SetColor(15, 0);
		}
		cout << "--------------------" << endl;


		for (int i = 0;i < arrx; i++)
		{
			cout << "Enter score: " << endl;
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
				cout << "Error! Wrong number! " << endl;
				d_syze[i] = NULL;
				cin >> d_syze[i];
			}

			Count += d_syze[i];


		}
		cout << "Do you want correct result? " << endl;
		cout << "1) Yes " << endl;
		cout << "2) No " << endl;
		cin >> CorrectResult;
		if (CorrectResult == 1)
		{
			Count = NULL;
			for (int i = 0;i < arrx; i++)
			{
				cout << "Enter score: " << endl;
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
					cout << "Error! Wrong number! " << endl;
					d_syze[i] = NULL;
					cin >> d_syze[i];
				}

				Count += d_syze[i];


			}
		}
		
			// Count = d_syze[0] + d_syze[1] + d_syze[2] + d_syze[3] + d_syze[4];

			result = Count / arrx;


			ryr[c] = result;


			if (ryr[c] <= 2.5)
			{
				SetColor(4, 0);
				cout << "Your middle score = " << result << endl;
				cout << "WARNING!!! Low-score! " << endl;
				for (; warning < 2.6; )
				{
					warning = (Count + 3) / (arrx + 1);
					Count += 3;
					arrx += 1;
					cout << "You need: " << 3 << " for " << warning << endl;

				}
				warning = NULL;
				SetColor(15, 0);
				getch();
			}
			else if (ryr[c] <= 3.5)
			{
				SetColor(14, 0);
				cout << "Your middle score = " << result << endl;
				cout << "Warning! Score equal 3!" << endl;
				for (; warning < 3.6; )
				{
					warning = (Count + 4) / (arrx + 1);
					Count += 4;
					arrx += 1;
					cout << "You need: " << 4 << " for " << warning << endl;
				}
				warning = NULL;
				SetColor(15, 0);
				getch();
			}
			else if (ryr[c] <= 4.5)
			{
				SetColor(10, 0);
				cout << "Your middle score = " << result << endl;
				cout << "Warning! Score equal 4!" << endl;
				for (; warning < 4.6; )
				{
					warning = (Count + 5) / (arrx + 1);
					Count += 5;
					arrx += 1;
					cout << "You need: " << 5 << " for " << warning << endl;
				}
				warning = NULL;
				SetColor(15, 0);
				getch();
			}
			else
			{
				SetColor(3, 0);
				cout << "Your middle score = " << result << endl;
				cout << "Total score is normal! ;) " << endl;
				SetColor(15, 0);
				getch();
			}


			Count = NULL;
			system("cls");
		}
	
		cout << endl;

		totalScore = ryr[0] + ryr[1] + ryr[2] + ryr[3] + ryr[4] + ryr[5] + ryr[6] + ryr[7] + ryr[8] + ryr[9] + ryr[10] + ryr[11] + ryr[12] + ryr[13]; // Общая сумма всех предметов 
		totalResult = totalScore / 14; // Общий средний балл
		switch (totalResult)
		{
		case 2:
			SetColor(4, 0);
			cout << "Your Total Score " << totalResult << endl;
			SetColor(15, 0);
			break;
		case 3:
			SetColor(14, 0);
			cout << "Your Total Score " << totalResult << endl;
			SetColor(15, 0);
			break;
		case 4:
			SetColor(2, 0);
			cout << "Your Total Score " << totalResult << endl;
			SetColor(15, 0);
			break;
		case 5:
			SetColor(3, 0);
			cout << "Your Total Score " << totalResult << endl;
			SetColor(15, 0);
			break;
		}
		cout << "End Statistics: " << endl;
		cout << ".____________________________." << endl;
		cout << "|Your name: " << user.name << "\t|" << endl;
		cout << "|Your family: " << user.family << "\t|" << endl;
		cout << "|Your ID: " << user.GetID() << "\t|" << endl;
		cout << "|Your total score: " << totalResult << "\t|" << endl;
		cout << "|Your recomend: " << "\t|" << endl;
		cout << ".----------------------------." << endl;
		delete[] d_syze;
		return 0;
	}

