using SupportChainPattern.Models;

namespace SupportChainPattern.Handlers
{
    public class AutoResponder : SupportHandler
    {
        public AutoResponder() : base("АВТООТВЕТЧИК") { }
        protected override bool CanHandle(SupportRequest request)
        {
            return request.Description.Contains("кабель") || request.Description.Contains("перезагрузка");
        }
        protected override void ProcessRequest(SupportRequest request)
        {
            Console.WriteLine("   Автоответчик предлагает стандартные решения:");
            Console.WriteLine("   - Перезагрузите компьютер");
            Console.WriteLine("   - Проверьте подключение кабеля");
            Console.WriteLine("   - Обновите драйверы");
            request.IsSolved = true;
        }
    }
}
