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
void reserching_Search(string function, float increment, float*& reserchingSearchCoodinates, int& isAnyResult);
void reserching_Search(string function, float increment, float*& reserchingSearchCoodinates);
//Поиски с ограничением
void reserching_Search(string function, string limit, int limitMoreOrLessThanZero, float increment, float*& reserchingSearchCoodinates, int& isAnyResult);
void reserching_Search(string function, string limit, int limitMoreOrLessThanZero, float increment, float*& reserchingSearchCoodinates);
string ReplaceString(std::string subject, const std::string& search, const std::string& replace);

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    setlocale(LC_ALL, "RUSSIAN");
	int xZero, yZero;
	float increment, stepReductionCoefficient, searchStopParameter, limitMoreOrLessThanZero;
	string function, limit;
	cout << "Введите функцию (без пробелов):\n> ";
	cin >> function;
	cout << "Введите приращение:\n> ";
	cin >> increment;
	cout << "Введите коэффициент уменьшения шага:\n> ";
	cin >> stepReductionCoefficient;
	cout << "Введите параметр остановки поиска:\n> ";
	cin >> searchStopParameter;
	cout << "Введите формулу ограничения:\n> ";
	cin >> limit;
	cout << "Введите 1, если ограничение БОЛЬШЕ 0, или 2, если ограничение МЕНЬШЕ 0:\n> ";
	cin >> limitMoreOrLessThanZero;
	//////////////////
	float limitFunction;
	do
	{
		cout << "Введите начальную ночку. Введите x:\n> ";
		cin >> xZero;
		cout << "Введите начальную ночку. Введите y:\n> ";
		cin >> yZero;
		limitFunction = squaric_function_solver(limit, xZero, yZero);
		if (limitMoreOrLessThanZero == 1)
			if (limitFunction < 0)
			{
				cout << "Начальная точка не соответствует ограничению, выберите другое начальное значение." << endl;
			}
		if (limitMoreOrLessThanZero == 1)
			if (limitFunction >= 0)
			{
				break;
			}
		if (limitMoreOrLessThanZero == 2)
			if (limitFunction > 0)
			{
				cout << "Начальная точка не соответствует ограничению, выберите другое начальное значение." << endl;
			}
		if (limitMoreOrLessThanZero == 2)
			if (limitFunction <= 0)
			{
				break;
			}
	} while (true);
	///////////////////
	float* coordinatesBase = new float[3]; //включая вычисленную функцию.
	coordinatesBase[0] = xZero;
	coordinatesBase[1] = yZero;
	coordinatesBase[2] = squaric_function_solver(function, xZero, yZero);
	do
	{
		float xLastLast = coordinatesBase[0];
		float yLastLast = coordinatesBase[1];
		//Исследующий поиск в итерации.
		int isAnyResult = 0;
		//reserching_Search(function, increment, coordinatesBase, isAnyResult);
		reserching_Search(function, limit, limitMoreOrLessThanZero, increment, coordinatesBase, isAnyResult);
		if (isAnyResult != 0) {
			//Поиск по образцу в итерации.
			float fLast = 0;
			float* coordinatesTemp = new float[3];
			float limitForResearch;
			int checker;
			do
			{
				checker = 0;
				fLast = coordinatesBase[2];
				coordinatesTemp[0] = coordinatesBase[0] + (coordinatesBase[0] - xLastLast);
				coordinatesTemp[1] = coordinatesBase[1] + (coordinatesBase[1] - yLastLast);
				xLastLast = coordinatesBase[0];
				yLastLast = coordinatesBase[1];
				coordinatesTemp[2] = squaric_function_solver(function, coordinatesTemp[0], coordinatesTemp[1]);
				//Исследующий поиск в поиске по образцу.
				//reserching_Search(function, increment, coordinatesTemp);
				reserching_Search(function, limit, limitMoreOrLessThanZero, increment, coordinatesTemp);
				limitForResearch = squaric_function_solver(limit, coordinatesTemp[0], coordinatesTemp[1]);
				if (limitMoreOrLessThanZero == 1)
					if (limitForResearch > 0 && coordinatesTemp[2] < fLast)
					{
						coordinatesBase[0] = coordinatesTemp[0];
						coordinatesBase[1] = coordinatesTemp[1];
						coordinatesBase[2] = coordinatesTemp[2];
						checker++;
					}
				if (limitMoreOrLessThanZero == 1 && checker == 0) break;
				if (limitMoreOrLessThanZero == 2)
					if (limitForResearch < 0 && coordinatesTemp[2] < fLast)
					{
						coordinatesBase[0] = coordinatesTemp[0];
						coordinatesBase[1] = coordinatesTemp[1];
						coordinatesBase[2] = coordinatesTemp[2];
						checker++;
					}
				if (limitMoreOrLessThanZero == 2 && checker == 0) break;
			} while (true);
		}
		else if (increment > searchStopParameter) increment = increment / stepReductionCoefficient;
			else break;
	} while (true);
	cout << "Ответ:\n" << coordinatesBase[0] << " " << coordinatesBase[1] << " " << coordinatesBase[2] << endl;
	system("pause");
	return 0;
}

void reserching_Search(string function, float increment, float*& reserchingSearchCoodinates, int& isAnyResult)
{
	float xTemp, yTemp, fTemp;
	xTemp = reserchingSearchCoodinates[0];
	yTemp = reserchingSearchCoodinates[1];
	//По х.
	reserchingSearchCoodinates[0] = reserchingSearchCoodinates[0] + increment;
	fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	if (fTemp < reserchingSearchCoodinates[2]) isAnyResult += 1;
	if (fTemp >= reserchingSearchCoodinates[2])
	{
		reserchingSearchCoodinates[0] = xTemp;
		reserchingSearchCoodinates[0] = reserchingSearchCoodinates[0] - increment;
		fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
		if (fTemp < reserchingSearchCoodinates[2]) isAnyResult += 1;
		if (fTemp >= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[0] = xTemp;
		}
	}
	reserchingSearchCoodinates[2] = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	//По у.
	reserchingSearchCoodinates[1] = reserchingSearchCoodinates[1] + increment;
	fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	if (fTemp < reserchingSearchCoodinates[2]) isAnyResult += 1;
	if (fTemp >= reserchingSearchCoodinates[2])
	{
		reserchingSearchCoodinates[1] = yTemp;
		reserchingSearchCoodinates[1] = reserchingSearchCoodinates[1] - increment;
		fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
		if (fTemp < reserchingSearchCoodinates[2]) isAnyResult += 1;
		if (fTemp >= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[1] = yTemp;
		}
	}
	reserchingSearchCoodinates[2] = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
}

void reserching_Search(string function, float increment, float*& reserchingSearchCoodinates)
{
	float xTemp, yTemp, fTemp;
	xTemp = reserchingSearchCoodinates[0];
	yTemp = reserchingSearchCoodinates[1];
	//По х.
	reserchingSearchCoodinates[0] = reserchingSearchCoodinates[0] + increment;
	fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	if (fTemp >= reserchingSearchCoodinates[2])
	{
		reserchingSearchCoodinates[0] = xTemp;
		reserchingSearchCoodinates[0] = reserchingSearchCoodinates[0] - increment;
		fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
		if (fTemp >= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[0] = xTemp;
		}
	}
	reserchingSearchCoodinates[2] = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	//По у.
	reserchingSearchCoodinates[1] = reserchingSearchCoodinates[1] + increment;
	fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	if (fTemp >= reserchingSearchCoodinates[2])
	{
		reserchingSearchCoodinates[1] = yTemp;
		reserchingSearchCoodinates[1] = reserchingSearchCoodinates[1] - increment;
		fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
		if (fTemp >= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[1] = yTemp;
		}
	}
	reserchingSearchCoodinates[2] = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
}


// ФУНКЦИИ С ОГРАНИЧЕНИЯМИ


void reserching_Search(string function, string limit, int limitMoreOrLessThanZero, float increment, float*& reserchingSearchCoodinates, int& isAnyResult)
{
	float xTemp, yTemp, fTemp, limitFloat;
	int xChecker = 0, yChecker = 0;
	xTemp = reserchingSearchCoodinates[0];
	yTemp = reserchingSearchCoodinates[1];
	//По х.
	reserchingSearchCoodinates[0] = reserchingSearchCoodinates[0] + increment;
	fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	if (limitMoreOrLessThanZero == 1) 
		if (fTemp < reserchingSearchCoodinates[2] && limitFloat > 0)
		{
			isAnyResult += 1;
			xChecker++;
		}
	if (limitMoreOrLessThanZero == 2)
		if (fTemp > reserchingSearchCoodinates[2] && limitFloat < 0)
		{
			isAnyResult += 1;
			xChecker++;
		}
	if (limitMoreOrLessThanZero == 1 && xChecker == 0)
		if (limitFloat < 0 || fTemp >= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[0] = xTemp;
			reserchingSearchCoodinates[0] = reserchingSearchCoodinates[0] - increment;
			fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			if (fTemp > reserchingSearchCoodinates[2] && limitFloat > 0)
			{
				isAnyResult += 1;
			}
			if (limitFloat < 0 || fTemp >= reserchingSearchCoodinates[2])
			{
				reserchingSearchCoodinates[0] = xTemp;
			}
		}
	if (limitMoreOrLessThanZero == 2 && xChecker == 0)
		if (limitFloat > 0 || fTemp <= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[0] = xTemp;
			reserchingSearchCoodinates[0] = reserchingSearchCoodinates[0] - increment;
			fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			if (fTemp > reserchingSearchCoodinates[2] && limitFloat < 0)
			{
				isAnyResult += 1;
			}
			if (limitFloat > 0 || fTemp <= reserchingSearchCoodinates[2])
			{
				reserchingSearchCoodinates[0] = xTemp;
			}
		}
	reserchingSearchCoodinates[2] = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	//По у.
	reserchingSearchCoodinates[1] = reserchingSearchCoodinates[1] + increment;
	fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	if (limitMoreOrLessThanZero == 1)
		if (fTemp < reserchingSearchCoodinates[2] && limitFloat > 0)
		{
			isAnyResult += 1;
			yChecker++;
		}
	if (limitMoreOrLessThanZero == 2)
		if (fTemp > reserchingSearchCoodinates[2] && limitFloat < 0)
		{
			isAnyResult += 1;
			yChecker++;
		}
	if (limitMoreOrLessThanZero == 1 && yChecker == 0)
		if (limitFloat < 0 || fTemp >= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[1] = yTemp;
			reserchingSearchCoodinates[1] = reserchingSearchCoodinates[1] - increment;
			fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			if (fTemp > reserchingSearchCoodinates[2] && limitFloat > 0)
			{
				isAnyResult += 1;
				yChecker++;
			}
			if (limitFloat < 0 || fTemp >= reserchingSearchCoodinates[2])
			{
				reserchingSearchCoodinates[1] = yTemp;
			}
		}
	if (limitMoreOrLessThanZero == 2 && yChecker == 0)
		if (limitFloat > 0 || fTemp <= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[0] = xTemp;
			reserchingSearchCoodinates[0] = reserchingSearchCoodinates[0] - increment;
			fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			if (fTemp > reserchingSearchCoodinates[2] && limitFloat < 0)
			{
				isAnyResult += 1;
				yChecker++;
			}
			if (limitFloat > 0 || fTemp <= reserchingSearchCoodinates[2])
			{
				reserchingSearchCoodinates[0] = xTemp;
			}
		}
	reserchingSearchCoodinates[2] = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
}

void reserching_Search(string function, string limit, int limitMoreOrLessThanZero, float increment, float*& reserchingSearchCoodinates)
{
	float xTemp, yTemp, fTemp, limitFloat;
	xTemp = reserchingSearchCoodinates[0];
	yTemp = reserchingSearchCoodinates[1];
	//По х.
	reserchingSearchCoodinates[0] = reserchingSearchCoodinates[0] + increment;
	fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	if (limitMoreOrLessThanZero == 1)
		if (limitFloat < 0 || fTemp >= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[0] = xTemp;
			reserchingSearchCoodinates[0] = reserchingSearchCoodinates[0] - increment;
			fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			if (limitFloat < 0 || fTemp >= reserchingSearchCoodinates[2])
			{
				reserchingSearchCoodinates[0] = xTemp;
			}
		}
	if (limitMoreOrLessThanZero == 2)
		if (limitFloat > 0 || fTemp <= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[0] = xTemp;
			reserchingSearchCoodinates[0] = reserchingSearchCoodinates[0] - increment;
			fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			if (limitFloat > 0 || fTemp <= reserchingSearchCoodinates[2])
			{
				reserchingSearchCoodinates[0] = xTemp;
			}
		}
	reserchingSearchCoodinates[2] = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	//По у.
	reserchingSearchCoodinates[1] = reserchingSearchCoodinates[1] + increment;
	fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
	if (limitMoreOrLessThanZero == 1)
		if (limitFloat < 0 || fTemp >= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[1] = yTemp;
			reserchingSearchCoodinates[1] = reserchingSearchCoodinates[1] - increment;
			fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			if (limitFloat < 0 || fTemp >= reserchingSearchCoodinates[2])
			{
				reserchingSearchCoodinates[1] = yTemp;
			}
		}
	if (limitMoreOrLessThanZero == 2)
		if (limitFloat > 0 || fTemp <= reserchingSearchCoodinates[2])
		{
			reserchingSearchCoodinates[1] = yTemp;
			reserchingSearchCoodinates[1] = reserchingSearchCoodinates[1] - increment;
			fTemp = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			limitFloat = squaric_function_solver(limit, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
			if (limitFloat > 0 || fTemp <= reserchingSearchCoodinates[2])
			{
				reserchingSearchCoodinates[1] = yTemp;
			}
		}
	reserchingSearchCoodinates[2] = squaric_function_solver(function, reserchingSearchCoodinates[0], reserchingSearchCoodinates[1]);
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