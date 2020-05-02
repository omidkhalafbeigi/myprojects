#include <iostream>
#include <conio.h>
#include <string.h>
using namespace std;
class date
{
public: int changed_year;
public: int changed_month;
public: int changed_day;
public: int end_day;
public: int week_day;
public: string week_day_name;
public: char c;
public: int num, a;
public: int d, y, m;
public: int month_day[13] = { 0, 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
public: void get() //be in function faghat dastoor (cin) akhari ro baraye bedast avordan rooze jari (on rozi ke hastim) ezafe kardam...
{
	cout << "Enter last day of month: ";//me
	cin >> end_day;
	cout << "Enter day: ";
	cin >> d;
	cout << "Enter month: ";
	cin >> m;
	cout << "Enter year: ";
	cin >> y;
	cout << "What day is today (per week, between 0 and 6)? ";
	cin >> week_day;
	if (week_day > 7 || week_day < 0 || m < 1 || m > 12 || y <= 1010 || y >= 2100 || d < 1 || d > end_day)
	{
		cout << "Enter true information...";
	}
	else 
	{
		switch (week_day)
		{
		case 0:
			week_day_name = "Saturday";
			break;
		case 1:
			week_day_name = "Sunday";
			break;
		case 2:
			week_day_name = "Monday";
			break;
		case 3:
			week_day_name = "Tuesday";
			break;
		case 4:
			week_day_name = "Wednesday";
			break;
		case 5:
			week_day_name = "Thursday";
		case 6:
			week_day_name = "Friday";
			break;
		default:
			cout << "Enter true day.";
			break;
		}
		plus_minus();
		show();
	}
};//Done
	void plus_minus() //function baraye bedast avordane operator va jam va kam kardan rooze hafte...
	{
		date mydate;
        cout << "wich one do you prefer - or +? ";
		cin >> c;
		cout << "enter number: ";
		cin >> num;
		switch (c) 
		{
			case '+':
				operator+();
				break;
			case '-':
				operator-();
				break;
		};
    };
	void operator+()
	{
		changed_year = y;
		changed_month = m;
		changed_day = d;
		if ((d + num) > end_day)
		{
			if (m == 12)
			{
				changed_year += 1;
				changed_month = 1;
				changed_day += num;
				changed_day -= end_day;
			}
			else
			{
				changed_month += 1;
				changed_day += num;
				changed_day -= end_day;
			}
		}
		else
		{
			changed_day += num;
		}
		
	};
	void operator-()
	{

		changed_year = y;
		changed_month = m;
		changed_day = d;
		if ((d - num) < 1)
		{
			if (m == 1)
			{
				changed_year -= 1;
				changed_month = 12;
				changed_day -= num;
				changed_day += end_day;
			}
			else
			{
				changed_month -= 1;
				changed_day -= num;
				changed_day += end_day;
			}
		}
		else
		{
			changed_day -= num;
		}
	};
	void show()
	{
		date mydate;
		cout << "Primary date: " << y << "-" << m << "-" << d << "\n";
		cout << "Date (per week day): " << y << "-" << m << "-" << week_day << " (" << week_day_name << ")" << "\n";
		cout << "Changed date: " << changed_year << "-" << changed_month << "-" << changed_day << "\n";
	};
};

int main()
{
	date mydate;
	mydate.get();
	cin;
	return 0;
}