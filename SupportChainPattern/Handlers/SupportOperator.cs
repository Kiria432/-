using SupportChainPattern.Models;

namespace SupportChainPattern.Handlers
{
    public class SupportOperator : SupportHandler
    {
        public SupportOperator() : base("ОПЕРАТОР ПОДДЕРЖКИ") { }
        protected override bool CanHandle(SupportRequest request)
        {
            return request.Description.Contains("Windows") || request.Description.Contains("настройк");
        }
        protected override void ProcessRequest(SupportRequest request)
        {
            Console.WriteLine("   Оператор дает рекомендации:");
            Console.WriteLine("   - Проверьте совместимость оборудования");
            Console.WriteLine("   - Установите проприетарные драйверы");
            Console.WriteLine("   - Проверьте настройки системы");
            Console.WriteLine("   Переводим на технического специалиста...");
            _nextHandler.HandleRequest(request);
            request.IsSolved = false;
        }
    }
}
