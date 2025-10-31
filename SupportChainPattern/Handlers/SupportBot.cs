using SupportChainPattern.Models;

namespace SupportChainPattern.Handlers
{
    public class SupportBot : SupportHandler
    {
        public SupportBot() : base("БОТ ПОДДЕРЖКИ") { }
        protected override bool CanHandle(SupportRequest request)
        {
            return request.Description.Contains("драйвер") || request.Description.Contains("не определяется");
        }
        protected override void ProcessRequest(SupportRequest request)
        {
            Console.WriteLine("   Бот предоставляет алгоритм действий:");
            Console.WriteLine("   1. Откройте Диспетчер устройств");
            Console.WriteLine("   2. Найдите свое оборудование");
            Console.WriteLine("   3. Обновите драйверы автоматически");
            Console.WriteLine("   4. Перезагрузите компьютер");
            Console.WriteLine("   Переводим на следующий уровень поддержки...");
            _nextHandler.HandleRequest(request);
            request.IsSolved = false;
        }
    }
}
