using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Sidekick.Business.Languages;
using Sidekick.Core.Initialization.Notifications;

namespace Sidekick.Business.Apis.PoeNinja
{
    public class InitializeDataHandler : INotificationHandler<InitializeDataNotification>
    {
        private readonly IPoeNinjaClient poeNinjaClient;
        private readonly IPoeNinjaCache poeNinjaCache;
        private readonly ILanguageProvider languageProvider;

        public InitializeDataHandler(
            IPoeNinjaClient poeNinjaClient,
            IPoeNinjaCache poeNinjaCache,
            ILanguageProvider languageProvider)
        {
            this.poeNinjaClient = poeNinjaClient;
            this.poeNinjaCache = poeNinjaCache;
            this.languageProvider = languageProvider;
        }

        public async Task Handle(InitializeDataNotification notification, CancellationToken cancellationToken)
        {
            poeNinjaClient.IsSupportingCurrentLanguage = PoeNinjaClient.POE_NINJA_LANGUAGE_CODES.TryGetValue(languageProvider.Current.LanguageCode, out var languageCode);
            poeNinjaClient.LanguageCode = languageCode;

            await poeNinjaCache.RefreshData();
        }
    }
}
