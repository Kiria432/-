using SupportChainPattern.Models;

namespace SupportChainPattern.Handlers
{
    public class TechnicalSpecialist : SupportHandler
    {
        public TechnicalSpecialist() : base("ТЕХНИЧЕСКИЙ СПЕЦИАЛИСТ (ГУРУ)") { }

        protected override bool CanHandle(SupportRequest request)
        {
            // Гуру может решить ЛЮБУЮ проблему!
            return true;
        }

        protected override void ProcessRequest(SupportRequest request)
        {
            Console.WriteLine("   Технический специалист анализирует проблему...");
            Console.WriteLine("   Детальная диагностика:");
            Console.WriteLine($"      - Оборудование: {request.EquipmentModel}");
            Console.WriteLine($"      - ОС: {request.OperatingSystem}");
            Console.WriteLine($"      - Тип проблемы: {request.ProblemType}");

            // Детальное решение для конкретной ситуации
            if (request.OperatingSystem == "Linux" && request.ProblemType == "driver")
            {
                Console.WriteLine("\nРЕШЕНИЕ ГУРУ:");
                Console.WriteLine("   1. Установите пакет linux-headers для вашего ядра");
                Console.WriteLine("   2. Скачайте исходный код драйвера с GitHub производителя");
                Console.WriteLine("   3. Установите build-essential: sudo apt-get install build-essential");
                Console.WriteLine("   4. Скомпилируйте драйвер: make && sudo make install");
                Console.WriteLine("   5. Загрузите модуль: sudo modprobe ваш_драйвер");
                Console.WriteLine("   6. Создайте файл udev правила в /etc/udev/rules.d/");
                Console.WriteLine("   7. Перезагрузите службу udev: sudo udevadm control --reload");
                Console.WriteLine("   8. Подключите оборудование заново");
            }
            else
            {
                Console.WriteLine("\nРЕШЕНИЕ ГУРУ:");
                Console.WriteLine("   - Проведена глубокая диагностика системы");
                Console.WriteLine("   - Найдена и устранена корневая причина");
                Console.WriteLine("   - Выполнена оптимизация конфигурации");
                Console.WriteLine("   - Проблема полностью решена!");
            }

            request.IsSolved = true;
            Console.WriteLine("ПРОБЛЕМА РЕШЕНА! Можете наслаждаться игрой на новом оборудовании!");
        }
    }
}
