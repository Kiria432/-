using SupportChainPattern.Models;

namespace SupportChainPattern.Handlers
{
    public class AutoResponder : SupportHandler
    {
        private readonly string[] _standardSolutions =
        {
            "Перезагрузите компьютер",
            "Проверьте подключение кабеля",
            "Обновите драйверы",
            "Переустановите программное обеспечение",
            "Проверьте настройки питания"
        };
        public AutoResponder() : base("АВТООТВЕТЧИК") { }
        protected override bool CanHandle(SupportRequest request)
        {
            return request.ProblemType == "simple" || request.ProblemType == "connection";
        }
        protected override void ProcessRequest(SupportRequest request)
        {
            Console.WriteLine("Автоответчик предлагает стандартные решения:");

            for (int i = 0; i < _standardSolutions.Length; i++)
            {
                Console.WriteLine($"      {i + 1}. {_standardSolutions[i]}");
            }

            Console.WriteLine("Ни одно из решений не помогло? Переводим на бота...");
            request.IsSolved = false;
        }
    }
}
