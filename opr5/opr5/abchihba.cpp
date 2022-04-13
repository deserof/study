#include <iostream>
#include <stdio.h>
#include <windows.h>
#include <string>
#include "tinyexpr.h"
#include <math.h>

using namespace std;

float squaric_function_solver(string squaric_function, int* x_numbers, int* y_numbers, int i, int j); //Для Mij.
float squaric_function_solver(string squaric_function, int x, int y); // Для простой замены x и y.
float squaric_function_solver(string squaric_function, float x, float y); //Для float x и y
int partial_differention_on_x(int x);
int partial_differention_on_y(int y, int mu);
float partial_differention_on_x(float x);
float partial_differention_on_y(float y, int mu);
int partial_differention_on_x_target(int x, int mu, int number_with_x);
int partial_differention_on_y_target(int y, int number_with_y);
float partial_differention_on_x_target(float x, int mu, int number_with_x);
float partial_differention_on_y_target(float y, int number_with_y);
string ReplaceString(std::string subject, const std::string& search, const std::string& replace);
float finding_step(float lyambda, int number_of_step);
float finding_projection_x(float starting_x, float starting_y, int mu, int number_with_x, int number_with_y);
float finding_projection_y(float starting_x, float starting_y, int mu, int number_with_x, int number_with_y);

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	setlocale(LC_ALL, "RUSSIAN");
	//int x_numbers, y_numbers;
	int startPointX, startPointY, vmax, number_with_x, number_with_y, mu;
	float lyambda;
	string formula;
	cout << "enter (will replace x1 and x2 as x and y):\n> ";
	cout << "2*(x-7)^2+(y-1)^2\n> ";
	cin >> formula;
	cout << "enter value in brackets with x = 7:\n> ";
	cin >> number_with_x;
	cout << "enter value in brackets with y = 1:\n> ";
	cin >> number_with_y;
	cout << "enter value Mu=1:\n> ";
	cin >> mu;
	cout << "enter value x start point 0:\n> ";
	cin >> startPointX;
	cout << "enter value y end point -7:\n> ";
	cin >> startPointY;
	//cout << "Введите значение i:\n> ";
	//cin >> x_numbers;
	//cout << "Введите значение j:\n> ";
	//cin >> y_numbers;
	cout << "enter value v=20:\n> ";
	cin >> vmax;
	cout << "enter lenght of step (lambda) = 0.3:\n> ";
	cin >> lyambda;
	//Создание двумерного массива
	//int c_x_numbers = x_numbers, c_y_numbers = y_numbers;
	//float** M_i_j = new float* [c_x_numbers]();
	//int* x_numbers_array;
	//x_numbers_array = new int[x_numbers]();
   //int* y_numbers_array;
	//y_numbers_array = new int[y_numbers]();
	//for (int i = 0; i < c_x_numbers; i++)
	//    M_i_j[i] = new float[c_y_numbers]();
	//Расчёт координат xi и yj
   // for (int i = 0; i < x_numbers; i++)
  //  {
  //      x_numbers_array[i] = (-5 + i);
  //  }
  //  for (int j = 0; j < y_numbers; j++)
   //     y_numbers_array[j] = (-5 + j);
	//Вычисление Mi, j
 //   for (int i = 0; i < x_numbers; i++)
   //     for (int j = 0; j < y_numbers; j++)
	//        M_i_j[i][j] = squaric_function_solver(formula, x_numbers_array, y_numbers_array, i, j);
	//Пункт 2.2
	//Определения вектора начальных значений
	float* x_with_v = new float[vmax];
	float* y_with_v = new float[vmax];
	float* ff = new float[vmax];
	for (int i = 0; i < vmax; i++)
	{
		if (i == 0)
		{
			x_with_v[i] = (float)startPointX;
			y_with_v[i] = (float)startPointY;
			ff[i] = squaric_function_solver(formula, startPointX, startPointY);
		}
		if (i != 0)
		{
			x_with_v[i] = x_with_v[i - 1] + (finding_step(lyambda, i) * finding_projection_x(x_with_v[i - 1], y_with_v[i - 1], mu, number_with_x, number_with_y));
			y_with_v[i] = y_with_v[i - 1] + (finding_step(lyambda, i) * finding_projection_y(x_with_v[i - 1], y_with_v[i - 1], mu, number_with_x, number_with_y));
			ff[i] = squaric_function_solver(formula, x_with_v[i], y_with_v[i]);
		}
	}
	//Вывод значений аргументов
	for (int i = 0; i < vmax; i++)
	{
		cout << setw(10) << "\t\tx" << i << "= " << x_with_v[i] << "\t\ty" << i << "= " << y_with_v[i] << "\t\tff" << i << "= " << ff[i] << endl;
	}
	//Выбор мест автоколебаний

	//int selected_x_begin, selected_x_end, selected_y_begin, selected_y_end;
	//cout << "Выберите точку начала колебаний по оси х (если их нет - поставить -1):\n> ";
	//cin >> selected_x_begin;
	//if (selected_x_begin != -1)
	//{
	//	cout << "Выберите точку конца колебаний по оси х:\n> ";
	//	cin >> selected_x_end;
	//}
	//else selected_x_end = -1;
	//cout << "Выберите точку начала колебаний по оси y (если их нет - поставить -1):\n> ";
	//cin >> selected_y_begin;
	//if (selected_y_begin != -1)
	//{
	//	cout << "Выберите точку конца колебаний по оси y:\n> ";
	//	cin >> selected_y_end;
	//}
	//else selected_y_end = -1;

	//Определение точки минимума

	//float minimum_x, minimum_y, minimum_function;
	//if (selected_x_begin != -1)
	//{
	//	minimum_x = (x_with_v[selected_x_begin] - (-x_with_v[selected_x_end])) / 2;
	//}
	//else minimum_x = 0;
	//if (selected_y_begin != -1)
	//{
	//	minimum_y = (y_with_v[selected_y_end] - (-y_with_v[selected_y_begin])) / 2;
	//}
	//else minimum_y = 0;
	//minimum_function = squaric_function_solver(formula, minimum_x, minimum_y);

	//Расчёт амплитуды колебаний

	//float amplitude;
	//float x_start_positive, x_end_positive, y_start_positive, y_end_positive;
	//if (x_with_v[selected_x_begin] < 0)
	//{
	//	x_start_positive = -x_with_v[selected_x_begin];
	//}
	//else x_start_positive = x_with_v[selected_x_begin];
	//if (x_with_v[selected_x_end] < 0)
	//{
	//	x_end_positive = -x_with_v[selected_x_end];
	//}
	//else x_end_positive = x_with_v[selected_x_end];
	//if (y_with_v[selected_y_begin] < 0)
	//{
	//	y_start_positive = -y_with_v[selected_y_begin];
	//}
	//else y_start_positive = y_with_v[selected_y_begin];
	//if (y_with_v[selected_y_end] < 0)
	//{
	//	y_end_positive = -y_with_v[selected_y_end];
	//}
	//else y_end_positive = y_with_v[selected_y_end];
	//amplitude = sqrt(pow((x_start_positive + x_end_positive), 2) + pow((y_start_positive + y_end_positive), 2));
	////Вывод ответа
	//cout << "Точка минимума функции:\nx=" << minimum_x << "\t\ty=" << minimum_y << "\t\tf(x,y)=" << minimum_function << "\nАмплитуда: " << amplitude;
	return 0;
}


string ReplaceString(std::string subject, const std::string& search,
	const std::string& replace) {
	size_t pos = 0;
	while ((pos = subject.find(search, pos)) != std::string::npos) {
		subject.replace(pos, search.length(), replace);
		pos += replace.length();
	}
	return subject;
}

float finding_step(float lyambda, int number_of_step)
{
	float step;
	int alpha = 1, beta = 1, gamma = 0;
	step = alpha * (lyambda / (beta + (gamma * number_of_step)));
	return step;
}

float finding_projection_x(float starting_x, float starting_y, int mu, int number_with_x, int number_with_y)
{
	//Вычисление длины вектора
	float L;
	//L = sqrt(pow(partial_differention_on_x(starting_x), 2) + pow(partial_differention_on_y(starting_y, mu), 2));
	L = sqrt(pow(partial_differention_on_x_target(starting_x, mu, number_with_x), 2) + pow(partial_differention_on_y_target(starting_y, number_with_y), 2));
	//Вычисление проекции
	float projection_on_x;
	//projection_on_x = (-partial_differention_on_x(starting_x)) / L;
	projection_on_x = (-partial_differention_on_x_target(starting_x, mu, number_with_x)) / L;
	return projection_on_x;
}

float finding_projection_y(float starting_x, float starting_y, int mu, int number_with_x, int number_with_y)
{
	//Вычисление длины вектора
	float L;
	//L = sqrt(pow(partial_differention_on_x(starting_x), 2) + pow(partial_differention_on_y(starting_y, mu), 2));
	L = sqrt(pow(partial_differention_on_x_target(starting_x, mu, number_with_x), 2) + pow(partial_differention_on_y_target(starting_y, number_with_y), 2));
	//Вычисление проекции
	float projection_on_y;
	//projection_on_y = (-partial_differention_on_y(starting_y, mu)) / L;
	projection_on_y = (-partial_differention_on_y_target(starting_y, number_with_y)) / L;
	return projection_on_y;
}

float squaric_function_solver(string squaric_function, int* x_array, int* y_array, int i, int j)
{
	string x_str(to_string(x_array[i]));
	string toReplace = "x";
	string resultString = ReplaceString(squaric_function, toReplace, x_str);
	string y_str(to_string(y_array[j]));
	toReplace = "y";
	resultString = ReplaceString(resultString, toReplace, y_str);
	const char* c = resultString.c_str();
	float f_result = (float)te_interp(c, 0);
	return f_result;
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

int partial_differention_on_x(int x)
{
	int result = 2 * x;
	return result;
}

float partial_differention_on_x(float x)
{
	float result = 2 * x;
	return result;
}

int partial_differention_on_y(int y, int mu)
{
	int result = 2 * mu * y;
	return result;
}

float partial_differention_on_y(float y, int mu)
{
	float result = 2 * mu * y;
	return result;
}

int partial_differention_on_y_target(int y, int number_with_y)
{
	int result = (2 * y) - (number_with_y * 2);
	return result;
}
int partial_differention_on_x_target(int x, int mu, int number_with_x)
{
	int result = (2 * mu * x) - (number_with_x * 2 * mu);
	return result;
}
float partial_differention_on_y_target(float y, int number_with_y)
{
	float result = (2 * y) - (number_with_y * 2);
	return result;
}
float partial_differention_on_x_target(float x, int mu, int number_with_x)
{
	float result = (2 * mu * x) - (number_with_x * 2 * mu);
	return result;
}