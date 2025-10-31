using SupportChainPattern.Models;

namespace SupportChainPattern.Handlers
{
    public class SupportBot : SupportHandler
    {
        public SupportBot() : base("БОТ ПОДДЕРЖКИ") { }

        protected override bool CanHandle(SupportRequest request)
        {
            return request.ProblemType == "driver" || request.ProblemType == "configuration";
        }

        protected override void ProcessRequest(SupportRequest request)
        {
            Console.WriteLine("Бот предоставляет алгоритм действий:");

            if (request.ProblemType == "driver")
            {
                Console.WriteLine("   1. Откройте Диспетчер устройств");
                Console.WriteLine("   2. Найдите свое оборудование");
                Console.WriteLine("   3. Обновите драйверы автоматически");
                Console.WriteLine("   4. Перезагрузите компьютер");
            }
            else
            {
                Console.WriteLine("   1. Откройте настройки системы");
                Console.WriteLine("   2. Перейдите в раздел 'Устройства'");
                Console.WriteLine("   3. Проверьте разрешения для оборудования");
                Console.WriteLine("   4. Перезапустите службу устройств");
            }

            Console.WriteLine("Алгоритм не сработал? Переводим на оператора...");
            request.IsSolved = false;
        }
    }
}
