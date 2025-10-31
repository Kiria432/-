using SupportChainPattern.Handlers;
using SupportChainPattern.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("СИМУЛЯЦИЯ СЛУЖБЫ ПОДДЕРЖКИ");
        Console.WriteLine("===============================\n");
        // Цепочка
        var autoResponder = new AutoResponder();
        var supportBot = new SupportBot();
        var supportOperator = new SupportOperator();
        var technicalSpecialist = new TechnicalSpecialist();
        autoResponder
            .SetNext(supportBot)
            .SetNext(supportOperator)
            .SetNext(technicalSpecialist);
        var problem = new SupportRequest(
            "Новое игровое оборудование не работает под Linux после перехода с Windows"
        );
        Console.WriteLine("ЗВОНОК В СЛУЖБУ ПОДДЕРЖКИ");
        Console.WriteLine("===============================");
        Console.WriteLine($"Проблема: {problem.Description}");
        // Запускаем цепочку
        autoResponder.HandleRequest(problem);
        Console.WriteLine($"\nРЕЗУЛЬТАТ: {(problem.IsSolved ? "Проблема решена!" : "Проблема не решена")}");
    }
}
