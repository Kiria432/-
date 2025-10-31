using SupportChainPattern.Models;

namespace SupportChainPattern.Handlers
{
    public class TechnicalSpecialist : SupportHandler
    {
        public TechnicalSpecialist() : base("ТЕХНИЧЕСКИЙ СПЕЦИАЛИСТ (ГУРУ)") { }
        protected override bool CanHandle(SupportRequest request)
        {
            return true;
        }
        protected override void ProcessRequest(SupportRequest request)
        {
            Console.WriteLine("   Технический специалист анализирует проблему...");
            Console.WriteLine("   РЕШЕНИЕ ГУРУ для Linux:");
            Console.WriteLine("   1. Установите пакет linux-headers для вашего ядра");
            Console.WriteLine("   2. Скачайте исходный код драйвера с GitHub");
            Console.WriteLine("   3. Установите build-essential: sudo apt-get install build-essential");
            Console.WriteLine("   4. Скомпилируйте драйвер: make && sudo make install");
            Console.WriteLine("   5. Загрузите модуль: sudo modprobe ваш_драйвер");
            Console.WriteLine("   ПРОБЛЕМА РЕШЕНА! Можете играть на новом оборудовании!");
            request.IsSolved = true;
        }
    }
}
