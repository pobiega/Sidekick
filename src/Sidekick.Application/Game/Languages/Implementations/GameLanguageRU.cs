using System;
using Sidekick.Domain.Game.Languages;

namespace Sidekick.Application.Game.Languages.Implementations
{
    [GameLanguage("Russian", "ru")]
    public class GameLanguageRU : IGameLanguage
    {
        public string LanguageCode => "ru";
        public Uri PoeTradeSearchBaseUrl => new Uri("https://ru.pathofexile.com/trade/search/");
        public Uri PoeTradeExchangeBaseUrl => new Uri("https://ru.pathofexile.com/trade/exchange/");
        public Uri PoeTradeApiBaseUrl => new Uri("https://ru.pathofexile.com/api/trade/");
        public Uri PoeCdnBaseUrl => new Uri("https://web.poecdn.com/");
        public string RarityUnique => "Уникальный";
        public string RarityRare => "Редкий";
        public string RarityMagic => "Волшебный";
        public string RarityNormal => "Обычный";
        public string RarityCurrency => "Валюта";
        public string RarityGem => "Камень";
        public string RarityDivinationCard => "Гадальная карта";
        public string DescriptionUnidentified => "Неопознано";
        public string DescriptionQuality => "Качество";
        public string DescriptionAlternateQuality => "Изменённый эффект качества";
        public string DescriptionCorrupted => "Осквернено";
        public string DescriptionSockets => "Гнезда";
        public string DescriptionItemLevel => "Уровень предмета";
        public string PrefixSuperior => "Рог";
        public string InfluenceShaper => "Создателя";
        public string InfluenceElder => "Древнего";
        public string InfluenceCrusader => "Крестоносца";
        public string InfluenceHunter => "Охотника";
        public string InfluenceRedeemer => "Избавительницы";
        public string InfluenceWarlord => "Вождя";
        public string DescriptionMapTier => "Уровень карты";
        public string DescriptionItemQuantity => "Количество предметов";
        public string DescriptionItemRarity => "Редкость предметов";
        public string DescriptionMonsterPackSize => "Размер групп монстров";
        public string PrefixBlighted => "Заражённая";
        public string DescriptionExperience => "Опыт";
        
        public string DescriptionPhysicalDamage => "__TranslationRequired__";

        public string DescriptionElementalDamage => "__TranslationRequired__";

        public string DescriptionAttacksPerSecond => "__TranslationRequired__";

        public string DescriptionCriticalStrikeChance => "__TranslationRequired__";

        public string DescriptionEnergyShield => "__TranslationRequired__";

        public string DescriptionArmour => "__TranslationRequired__";

        public string DescriptionEvasion => "__TranslationRequired__";
        public string DescriptionChanceToBlock => "__TranslationRequired__";

        public string DescriptionLevel => "__TranslationRequired__";

        public string PrefixAnomalous => "Аномальный: ";
        public string PrefixDivergent => "Искривлённый: ";
        public string PrefixPhantasmal => "Фантомный: ";
    }
}
