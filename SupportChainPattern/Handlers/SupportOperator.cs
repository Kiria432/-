using SupportChainPattern.Models;

namespace SupportChainPattern.Handlers
{
    public class SupportOperator : SupportHandler
    {
        public SupportOperator() : base("ОПЕРАТОР ПОДДЕРЖКИ") { }

        protected override bool CanHandle(SupportRequest request)
        {
            return request.ProblemType == "os_compatibility" || request.ProblemType == "advanced_config";
        }

        protected override void ProcessRequest(SupportRequest request)
        {
            Console.WriteLine("Оператор дает рекомендации:");

            if (request.OperatingSystem == "Linux")
            {
                Console.WriteLine("   - Проверьте совместимость оборудования с Linux");
                Console.WriteLine("   - Установите проприетарные драйверы");
                Console.WriteLine("   - Настройте права доступа udev");
                Console.WriteLine("   - Проверьте наличие в ядре поддержки устройства");
            }
            else
            {
                Console.WriteLine("   - Проверьте журналы событий Windows");
                Console.WriteLine("   - Отключите проверку цифровых подписей");
                Console.WriteLine("   - Обновите .NET Framework");
                Console.WriteLine("   - Проверьте антивирусные блокировки");
            }

            Console.WriteLine("Рекомендации не помогли? Переводим на технического специалиста...");
            request.IsSolved = false;
        }
    }
}
