using LearnEnglish.Desktop.Interfaces;
using LearnEnglish.Desktop.Presentation;
using Microsoft.Extensions.DependencyInjection;

namespace LearnEnglish.Desktop.Factorys
{
    public class FrmCreateTextFactory 
    {
        private readonly IServiceProvider _provider;

        public FrmCreateTextFactory(IServiceProvider serviceProvider)
        {
            _provider = serviceProvider;
        }

        public FrmCreateText Create(string text, bool isTranslate)
        {
            return new FrmCreateText(_provider.GetService<IHttpService>(), text, isTranslate);    
        }
    }
}
