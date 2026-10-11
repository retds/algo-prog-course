// === Задание 1:
Console.WriteLine("\n=== Финансовый мини-расчёт ===");

int scholarship = 3500;      // Стипендия
int monthlyExpenses = 2800;  // Ежемесячные расходы

// Расчёт остатка на конец месяца
int monthlyBalance = scholarship - monthlyExpenses;

// Константа для количества месяцев в семестре
const int MonthsInSemester = 4;

// Расчёт общего остатка за семестр
int semesterBalance = monthlyBalance * MonthsInSemester;

Console.WriteLine($"Стипендия: {scholarship} руб.");
Console.WriteLine($"Расходы в месяц: {monthlyExpenses} руб.");
Console.WriteLine($"Остаток в конце месяца: {monthlyBalance} руб.");
Console.WriteLine($"Остаток за весь семестр ({MonthsInSemester} мес.): {semesterBalance} руб.");

// === Задание 2:
Console.WriteLine("=== Конвертер температур ===");

// Исходная температура в Цельсиях
double celsius = 23.5;

// Константы для перевода (по заданию используем хотя бы одну)
const double CelsiusToFahrenheitRatio = 9.0 / 5.0; // Дробное деление для точности
const double FahrenheitOffset = 32;
const double KelvinOffset = 273.15;

// Расчёт по Фаренгейту: F = C * 9/5 + 32
double fahrenheit = celsius * CelsiusToFahrenheitRatio + FahrenheitOffset;

// Расчёт по Кельвину: K = C + 273.15
double kelvin = celsius + KelvinOffset;

// Вывод результата
Console.WriteLine($"{celsius}°C = {fahrenheit}°F = {kelvin}K");