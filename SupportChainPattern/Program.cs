using SupportChainPattern.Handlers;
using SupportChainPattern.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("СИМУЛЯЦИЯ СЛУЖБЫ ПОДДЕРЖКИ");
        Console.WriteLine("===============================\n");
        //Цепочка
        var autoResponder = new AutoResponder();
        var supportBot = new SupportBot();
        var supportOperator = new SupportOperator();
        var technicalSpecialist = new TechnicalSpecialist();
        autoResponder
            .SetNext(supportBot)
            .SetNext(supportOperator)
            .SetNext(technicalSpecialist);
        // проблема
        var problem = new SupportRequest(
            problemType: "driver",
            description: "Новое игровое оборудование не работает под Linux после перехода с Windows",
            equipmentModel: "GameDevice Pro X2024",
            operatingSystem: "Linux"
        );
        Console.WriteLine("ЗВОНОК В СЛУЖБУ ПОДДЕРЖКИ");
        Console.WriteLine("===============================");
        Console.WriteLine($"Оборудование: {problem.EquipmentModel}");
        Console.WriteLine($"ОС: {problem.OperatingSystem}");
        Console.WriteLine($"Проблема: {problem.Description}");
        // Запускаем цепочки
        autoResponder.HandleRequest(problem);
        Console.WriteLine($"\nРЕЗУЛЬТАТ: {(problem.IsSolved ? "Проблема решена!" : "Проблема не решена")}");

        // Дополнительные примеры
        Console.WriteLine("\n\nДОПОЛНИТЕЛЬНЫЕ СЦЕНАРИИ");
        Console.WriteLine("===============================");

        // Простая проблема - решается на раннем этапе
        var simpleProblem = new SupportRequest(
            "connection",
            "Оборудование не определяется",
            "Basic GamePad",
            "Windows"
        );

        Console.WriteLine("\nПростая проблема:");
        autoResponder.HandleRequest(simpleProblem);
    }
}
