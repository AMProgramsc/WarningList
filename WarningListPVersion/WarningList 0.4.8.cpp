#include <iostream>
#include <string>
#include <Windows.h>
#include <time.h>
#include <conio.h>
#include <vector>
#include <fstream>
#include "Translite.h"

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
void SetFont()
{
	HANDLE soh = GetStdHandle(STD_OUTPUT_HANDLE);
	CONSOLE_FONT_INFOEX cfi;
	memset(&cfi, 0, sizeof(cfi));
	cfi.cbSize = sizeof(cfi);
	GetCurrentConsoleFontEx(soh, FALSE, &cfi);
	cfi.dwFontSize.Y = 14;
	SetCurrentConsoleFontEx(soh, FALSE, &cfi);

}
enum class score { two = 2, three, four, five };

void intro(string logo,string f)
{
	system("mode con cols=140 lines=31");
	SetFont();
	fstream lg;
	lg.open(logo, fstream::in | fstream::out | fstream::app);
	
		while (!lg.eof())
		{

			getline(lg, f);

			cout << f << endl;

		}

}
void Transelete(int h)
{
	if (h == 1)
	{
		Translite();
	}
}
void BackEvent(int d,string f,string g)
{
	cout << "<------" << endl;
	cout << "1) Back" << endl;
	cin >> d;
	if (d == 1)
	{
		system("cls");
		intro(f,g);
	}
	else
	{
		cin >> d;
	}
}


class User //User Information
{
public:
	User(string g, int y,string jh) : name(g) , ID(y) , family(jh)
	{

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

int main()
{
	string bd = "BD.txt";
	string logos = "Logo.txt";
	string info = "Information.txt";
	string options = "Options.txt";
	string files = "Files.txt";
	fstream fs;
	fstream fe;
	fstream le;
	fstream ne;
	fstream me;
	fstream ke;
	string str,msg,ftr,ltr,ntr,mtr,ktr;
	char ch,ce;
	string ster,sty;
	srand(time(NULL));
	int totalScore, totalResult, CorrectResult;
	int y = 0,x,selectdata,savedata,loaddata,save = 0,i = 0, deletedata , e = 0;
	bool exit = false;
	string name, family;
	string newname, addname;
	const int size = 10;
	int arrx = 0;
	int correct;
	int hit, hit2;
	int fix;
	int Delete,deletef;
	int enter1 = 0, enter2, enter3 = 0 ,enter4 , enter5 = 0,enter6 = 0,enter7 = 0;
	double warning = 0;
	double Count = 0; // Сумма оценок полученная вводом
	double result; // Общий результат(средний балл)
	vector<string> data = {""};
	vector<string> mylist = { "Match: ", "Rus.Iaz: ", "Physics: ", "History: ","Eng.Iaz: ","Chemistry: ","Literature: ","Socialscience: ","Biology: ","Geography: ","LSF: ","PE: ","PD: ","Informatics: " };
	vector<double> ryr = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
	SetFont();
    int id = (rand() % 10000);
	intro(logos,ftr);
	fs.open(bd, fstream::in | fstream::out | fstream::app);
	cin >> enter1;
	while (enter1 != 1)
	{

		if (enter1 == 2)
		{
			cout << "Exit..." << endl;
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
				Transelete(enter4);
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
				cout << ".---------------------------------------------------." << endl;
				cout << "|Name - WarningList                                 |" << endl;
				cout << "|Version - 0.4.8 Basic                              |" << endl;
				cout << "|id - 11062021                                      |" << endl;
				cout << "|Information:                                       |" << endl;
				cout << "|Updated - Interface                                |" << endl;
				cout << "|                                                   |" << endl;
				cout << "|                                                   |" << endl;
				cout << ".---------------------------------------------------." << endl;
				BackEvent(enter3, logos, ftr);
				cin >> enter1;
				break;
			case 2:
				cout << ".-----------------------------------------------------------." << endl;
				cout << "|Hello! My name Alexander! It's my three project.           |" << endl;
				cout << "|You probably know me from two other projects, namely       |" << endl;
				cout << "|RPG BASIC and Snake. I've been programmimg for 2 years now |" << endl;
				cout << "|and 3 mounts. My main classification is C++, C(Newble),and |" << endl;
				cout << "|C#(3 - 6 mounts). The development of the program is onging |" << endl;
				cout << "|to this day...                                             |" << endl;
				cout << ".-----------------------------------------------------------." << endl;
				BackEvent(enter3,logos,ftr);
				cin >> enter1;
				break;
			case 3:
				cout << ".------------------------------------------------------." << endl;
				cout << "|WarningList - this is a program                       |" << endl;
				cout << "|that calculates your GPA by entering several values.  |" << endl;
				cout << "|This program is very suitable for both schoolchildrens|" << endl;
				cout << "|and students                                          |" << endl;
				cout << ".------------------------------------------------------." << endl;
				BackEvent(enter3, logos, ftr);
				cin >> enter1;
				break;
			default:
				cin >> enter2;
				break;
			}

		}
		else if (enter1 == 5)
		{
			system("cls");
			me.open(files, fstream::in | fstream::out | fstream::app);

			while (!me.eof())
			{

				getline(me, mtr);

				cout << mtr << endl;

			}
			cout << "Select further action with the file:" << endl;
			cout << "1) Load " << endl;
			cout << "2) Delete " << endl;
			cin >> deletef;
			if (deletef == 1)
			{
				
				while (fs.peek() == EOF)
				{
					cout << "File BD empty" << endl;
					fs.close();
					BackEvent(enter3, logos, ftr);
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
					cout << "File "<< data[i] << "empty or does not exist!" << endl;
					BackEvent(enter3, logos, ftr);
					cin >> enter1;
				}
				
					while (!fe.eof())
					{
						msg = "";
						getline(fe, msg);

						cout << msg << endl;
					}
					
					BackEvent(enter3, logos, ftr);
					cin >> enter1;
				
				fe.close();
				fs.close();
		}
			else if (deletef == 2)
			{
				while (fs.peek() == EOF)
				{
					cout << "File BD empty" << endl;
					fs.close();
					BackEvent(enter3, logos, ftr);
					cin >> enter1;
				}
				cout << "Change your savedata file for delete: " << endl;

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
					cout << "File " << data[deletedata] << " Deleted" << endl;
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
					cout << "Error!" << endl;
				}
				
				fs.close();
				BackEvent(enter3, logos, ftr);
				cin >> enter1;
			}
		}
	}
		if (enter1 == 1)
		{
			system("cls");
			cout << "\t\t\t\tLoading..." << endl;
			cout << "\t\t\t\t._________________________________________________." << endl;
			cout << "\t\t\t\t";
			for (int f = 0; f < 50; f++)
			{

				SetColor(0, 15);
				cout << " ";
				SetColor(15, 0);
				Sleep(100);
			}
			cout << endl;
			cout << "\t\t\t\t.-------------------------------------------------." << endl;
			system("cls");
		}
	cout << "WarningList 0.4.8 BASIC" << endl;
	cout << ".__________________________." << endl;
	cout << "|Enter name student: ";
	cin >> name;
	cout << "|Enter Sername student: ";
	cin >> family;
	
	while (name == family)
	{
		cout << "Error! Name and Family equal!" << endl;
		cout << "|Enter name student: ";
		cin >> name;
		cout << "|Enter family student: ";
		cin >> family;
	}
	cout << "|Your ID: " << "#" << id << "|" << endl;
	cout << ".--------------------------." << endl;
	User user(name, id , family);
	Sleep(300);
	system("cls");

	vector<int> d_syze = {}; // Количество вводимых оценок

	/*for (int i = 0; i < size; i++)
	{
		cout << arr[i] << endl;
	}
	*/

	cout << "Entering score subjects: " << endl;

	for (int c = 0; c < mylist.size(); c++)
	{
		cout << "._____________________________." << endl;
		cout << "|Your name: " << name << endl;
		cout << "|Your family: " << family << endl;
		cout << "|Your ID - " << id << endl;
		cout << "._____________________________." << endl;
		cout << "Do you fixed or add and delete element in list?" << endl;
		cout << "1)Yes" << endl;
		cout << "2)Delete " << endl;
		cout << "3)No" << endl;
		cin >> enter5;
		if (enter5 == 1)
		{
			while (exit != 1)
			{

				if (enter5 == 1)
				{
					cout << "Change element to fix or add element in list" << endl;
					cin >> fix;
					if (fix > mylist.size())
					{
						cout << "Enter name added element: " << endl;
						cin >> addname;

						mylist.push_back(addname);
						ryr.push_back(0);
					}
					else
					{
						cout << "Enter new name element: " << endl;
						cin >> newname;
						mylist[fix] = newname;
					}
				}
				if (enter5 == 2)
				{
					cout << "Enter index for delete element: " << endl;
					cin >> Delete;
					while (Delete > mylist.size())
					{
						SetColor(4, 0);
						cout << ".________________________________." << endl;
						cout << "|Error! Index not found!         |" << endl;
						cout << "|Please, enter the number again: |" << endl;
						cin >> Delete;
						cout << ".--------------------------------." << endl;
						SetColor(15, 0);
					}
					mylist.erase(mylist.begin() + Delete);
					ryr.erase(ryr.begin() + Delete);

				}

				cout << "Exit?" << endl;
				cout << "1)Yes" << endl;
				cout << "0)No" << endl;
				cin >> exit;
				if (exit == 0)
				{
					cout << "1)Fix element" << endl;
					cout << "2)Delete " << endl;
					cout << "3)No" << endl;
					cin >> enter5;
				}
			}
		}
		cout << "._____________________________." << endl;
		for (int h = 0; h < mylist.size(); h++)
		{
			cout << "|" << mylist[h] << " = " << ryr[h] << "\t|" << endl;
		}
		cout << ".------------------------------" << endl;
		cout << "Enter element array: " << endl;
		cin >> x;
		cout << mylist[x] << endl;
		cout << "--------------------" << endl;
		cout << "|Enter quantity array: " << endl;
		cin >> arrx;
		d_syze.resize(arrx);
		while (arrx < 3)
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
				2;
				break;
			case 3:
				3;
				break;
			case 4:
				4;
				break;
			case 5:
				5;
				break;
			}
			while (d_syze[i] <= 1 || d_syze[i] > 5)
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
					2;
					break;
				case 3:
					3;
					break;
				case 4:
					4;
					break;
				case 5:
					5;
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


		ryr[x] = result;


		if (ryr[x] <= 2.5)
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
		else if (ryr[x] <= 3.5)
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
		else if (ryr[x] <= 4.5)
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
	cout << "|Your name: " << name << "\t|" << endl;
	cout << "|Your family: " << family << "\t|" << endl;
	cout << "|Your ID: " << user.GetID() << "\t|" << endl;
	cout << "|Your total score: " << totalResult << "\t|" << endl;
	cout << "|Your recomend: " << "\t|" << endl;
	cout << ".----------------------------." << endl;
	cout << "Save?: " << endl;
	cout << "1) Yes " << endl;
	cout << "2) No " << endl;
	cin >> savedata;
	if (savedata == 1)
	{
		cout << "Enter name your save: " << endl;
		cin >> sty;
		fs << sty << "\n";

		fs.open(sty, fstream::in | fstream::out | fstream::app);
		fe.open(sty, fstream::in | fstream::out | fstream::app);

		try 
		{
			cout << "File is open!" << endl;
			fs << sty << "\n";
		}
		catch(exception er)
		{
			
			cout << "File is don't open " << endl;
			cout << er.what() << endl;
		}
		try 
		{
			cout << "File is open!" << endl;
			fe << "End Statistics: " << endl;
			fe << ".____________________________." << endl;
			fe << "|Your name: " << name << "\t|" << endl;
			fe << "|Your family: " << family << "\t|" << endl;
			fe << "|Your ID: " << user.GetID() << "\t|" << endl;
			fe << "|Your total score: " << totalResult << "\t|" << endl;
			fe << "|Your recomend: " << "\t|" << endl;
			fe << ".----------------------------." << endl;
			fe << "._____________________________." << endl;
			for (int h = 0; h < mylist.size(); h++)
			{
				fe << "|" << mylist[h] << " = " << ryr[h] << "\t|" << endl;
			}
			fe << ".------------------------------" << endl;
			fe << "Version: " << "0.4.7 BASIC" << endl;
			fe << "Programm running time: " << clock() / 1000000.0 << "/sec" << endl;
		}
		catch(exception ses)
		{
			cout << "File is don't open " << endl;
			cout << ses.what() << endl;
		}
		fs.close();
		fe.close();
	}
	/*else
	{

	}
	*/
	return 0;
}
//(c)AMProgramms, 2021