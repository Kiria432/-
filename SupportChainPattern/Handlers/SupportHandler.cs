using SupportChainPattern.Models;

namespace SupportChainPattern.Handlers
{
    public abstract class SupportHandler
    {
        protected SupportHandler _nextHandler;
        protected string _handlerName;
        public SupportHandler(string handlerName)
        {
            _handlerName = handlerName;
        }
        public SupportHandler SetNext(SupportHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
        public virtual void HandleRequest(SupportRequest request)
        {
            Console.WriteLine($"\n Обработчик: {_handlerName}");
            Console.WriteLine($"   Проблема: {request.Description}");
            if (CanHandle(request))
            {
                ProcessRequest(request);
            }
            else
            {
                Console.WriteLine($"Переводим на следующий уровень поддержки...");
                _nextHandler.HandleRequest(request);
            }
        }
        protected abstract bool CanHandle(SupportRequest request);
        protected abstract void ProcessRequest(SupportRequest request);
    }
}
