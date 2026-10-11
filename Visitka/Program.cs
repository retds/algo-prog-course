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
