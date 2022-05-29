#include <iostream>
#include <stdio.h>
#include <windows.h>
#include <string>
#include "tinyexpr.h"
#include <math.h>

using namespace std;

// Для простой замены x и y.
float squaric_function_solver(string squaric_function, int x, int y);
//Для float x и y.
float squaric_function_solver(string squaric_function, float x, float y);
//Поиски без ограничения.
string ReplaceString(std::string subject, const std::string& search, const std::string& replace);
void finding_the_solutions(float* coordinatesFirst, float* coordinatesSecond, float* coordinatesThird, float*& best, float*& good, float*& worst);

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	setlocale(LC_ALL, "RUSSIAN");
	int xFirst, yFirst, n = 2;
	int alpha = 1, gamma = 2;
	float beta = 0.5;
	// -(25/34)x-(15/34)y+190/17
	// x^2+y^2-12*x-8*y+18

	//string function = "(x)^2+(x)*(y)+(y)^2-6*(x)-9*(y)";
	//string limit = "x^2+y^2-12*x+8*y+18";
	string function;
	string limit;
	float delta1 = ((pow((n + 1), (1 / 2)) + n - 1) / (n * sqrt(2))) * alpha;
	float delta2 = ((pow((n + 1), (1 / 2)) - 1) / (n * sqrt(2))) * alpha;
	float* coordinatesFirst = new float[3];
	float* coordinatesSecond = new float[3];
	float* coordinatesThird = new float[3];
	float* coordinatesResult = new float[3];
	cout << "enter function:\n> ";
	cin >> function;
	cout << "enter restrictions:\n> ";
	cin >> limit;
	float limitFloat;
	do
	{
		cout << "x:\n> ";
		cin >> xFirst;
		cout << "y:\n> ";
		cin >> yFirst;
		limitFloat = squaric_function_solver(limit, xFirst, yFirst);
		//if (limitFloat > 0)
		//{
		//	cout << "err. choose another" << endl;
		//}
		//else {
			coordinatesFirst[0] = xFirst;
			coordinatesFirst[1] = yFirst;
			coordinatesFirst[2] = squaric_function_solver(function, coordinatesFirst[0], coordinatesFirst[1]);
			coordinatesSecond[0] = coordinatesFirst[0] + delta1;
			coordinatesSecond[1] = coordinatesFirst[1] + delta1;
			coordinatesSecond[2] = squaric_function_solver(function, coordinatesSecond[0], coordinatesSecond[1]);
			coordinatesThird[0] = coordinatesFirst[0] + delta2;
			coordinatesThird[1] = coordinatesFirst[1] + delta2;
			coordinatesThird[2] = squaric_function_solver(function, coordinatesThird[0], coordinatesThird[1]);
			break;
		//}
	} while (true);
	int iteration = -1;
	float* worst = new float[3];
	float* good = new float[3];
	float* best = new float[3];
	do {
		iteration++;
		finding_the_solutions(coordinatesFirst, coordinatesSecond, coordinatesThird, best, good, worst);
		//Центр
		float* center = new float[3];
		center[0] = (good[0] + best[0]) / 2;
		center[1] = (good[1] + best[1]) / 2;
		//Отражение
		float* reflection = new float[3];
		reflection[0] = center[0] + alpha * (center[0] - worst[0]);
		reflection[1] = center[1] + alpha * (center[1] - worst[1]);
		reflection[2] = squaric_function_solver(function, reflection[0], reflection[1]);
		if (reflection[2] < good[2])
			worst = reflection;
		else
		{
			if (reflection[2] < worst[2])
				worst = reflection;
			float* c = new float[3];
			c[0] = (worst[0] + center[0]) / 2;
			c[1] = (worst[1] + center[1]) / 2;
			c[2] = squaric_function_solver(function, c[0], c[1]);
			if (c[2] < worst[2])
				worst = c;
		}
		limitFloat = squaric_function_solver(limit, worst[0], worst[1]);
		int isLimit = 0;
		int isExpanded = 0;
		if (limitFloat > 0) isLimit++;
		//Растяжение
		if (isLimit == 0)
			if (reflection[2] < best[2])
			{
				float* expansion = new float[3];
				expansion[0] = center[0] + gamma * (reflection[0] - center[0]);
				expansion[1] = center[1] + gamma * (reflection[1] - center[1]);
				expansion[2] = squaric_function_solver(function, expansion[0], expansion[1]);
				if (expansion[2] < reflection[2])
				{
					worst = expansion;
					isExpanded = 1;
				}
				else
				{
					worst = reflection;
					isExpanded = 1;
				}
			}
		//Сжатие
		if (isLimit == 1 || isExpanded == 0)
			if (reflection[2] > good[2])
			{
				float* contraction = new float[3];
				contraction[0] = center[0] + beta * (worst[0] - center[0]);
				contraction[1] = center[1] + beta * (worst[1] - center[1]);
				contraction[2] = squaric_function_solver(function, contraction[0], contraction[1]);
				if (contraction[2] < worst[2])
					worst = contraction;
			}
		//Приравнивание результатов
		coordinatesFirst = worst;
		coordinatesSecond = good;
		coordinatesThird = best;
		//Чисто повторно вычислить, вдруг что
		coordinatesFirst[2] = squaric_function_solver(function, coordinatesFirst[0], coordinatesFirst[1]);
		coordinatesSecond[2] = squaric_function_solver(function, coordinatesSecond[0], coordinatesSecond[1]);
		coordinatesThird[2] = squaric_function_solver(function, coordinatesThird[0], coordinatesThird[1]);
	} while (iteration < 10);
	//Вывод значений
	finding_the_solutions(coordinatesFirst, coordinatesSecond, coordinatesThird, best, good, worst);
	cout << "best sol: " << best[0] << " " << best[1] << endl;
	system("pause");
	return 0;
}

float squaric_function_solver(string squaric_function, int x, int y)
{
	string x_str(to_string(x));
	string toReplace = "x";
	string resultString = ReplaceString(squaric_function, toReplace, x_str);
	string y_str(to_string(y));
	toReplace = "y";
	resultString = ReplaceString(resultString, toReplace, y_str);
	const char* c = resultString.c_str();
	float f_result = (float)te_interp(c, 0);
	return f_result;
}

float squaric_function_solver(string squaric_function, float x, float y)
{
	string x_str(to_string(x));
	string toReplace = "x";
	string resultString = ReplaceString(squaric_function, toReplace, x_str);
	string y_str(to_string(y));
	toReplace = "y";
	resultString = ReplaceString(resultString, toReplace, y_str);
	const char* c = resultString.c_str();
	float f_result = (float)te_interp(c, 0);
	return f_result;
}

string ReplaceString(std::string subject, const std::string& search, const std::string& replace) {
	size_t pos = 0;
	while ((pos = subject.find(search, pos)) != std::string::npos) {
		subject.replace(pos, search.length(), replace);
		pos += replace.length();
	}
	return subject;
}

void finding_the_solutions(float* coordinatesFirst, float* coordinatesSecond, float* coordinatesThird, float*& best, float*& good, float*& worst)
{
	int isFind = 0;
	if (coordinatesFirst[2] >= coordinatesSecond[2] && coordinatesFirst[2] >= coordinatesThird[2])
	{
		worst = coordinatesFirst;
		if (coordinatesSecond[2] <= coordinatesThird[2])
		{
			best = coordinatesSecond;
			good = coordinatesThird;
			isFind++;
		}
		else
		{
			best = coordinatesThird;
			good = coordinatesSecond;
			isFind++;
		}
	}
	if (isFind == 0)
		if (coordinatesSecond[2] >= coordinatesFirst[2] && coordinatesSecond[2] >= coordinatesThird[2])
		{
			worst = coordinatesSecond;
			if (coordinatesFirst[2] <= coordinatesThird[2])
			{
				best = coordinatesFirst;
				good = coordinatesThird;
				isFind++;
			}
			else
			{
				best = coordinatesThird;
				good = coordinatesFirst;
				isFind++;
			}
		}
	if (isFind == 0)
		if (coordinatesThird[2] >= coordinatesFirst[2] && coordinatesThird[2] >= coordinatesSecond[2])
		{
			worst = coordinatesThird;
			if (coordinatesFirst[2] <= coordinatesSecond[2])
			{
				best = coordinatesFirst;
				good = coordinatesSecond;
			}
			else
			{
				best = coordinatesSecond;
				good = coordinatesFirst;
			}
		}
}