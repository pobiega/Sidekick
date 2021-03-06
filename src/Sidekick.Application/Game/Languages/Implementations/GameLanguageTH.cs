using System;
using Sidekick.Domain.Game.Languages;

namespace Sidekick.Application.Game.Languages.Implementations
{
    [GameLanguage("Thai", "th")]
    public class GameLanguageTH : IGameLanguage
    {
        public string LanguageCode => "th";
        public Uri PoeTradeSearchBaseUrl => new Uri("https://th.pathofexile.com/trade/search/");
        public Uri PoeTradeExchangeBaseUrl => new Uri("https://th.pathofexile.com/trade/exchange/");
        public Uri PoeTradeApiBaseUrl => new Uri("https://th.pathofexile.com/api/trade/");
        public Uri PoeCdnBaseUrl => new Uri("https://web.poecdn.com/");
        public string RarityUnique => "Unique";
        public string RarityRare => "แรร์";
        public string RarityMagic => "เมจิก";
        public string RarityNormal => "ปกติ";
        public string RarityCurrency => "เคอเรนซี่";
        public string RarityGem => "เจ็ม";
        public string RarityDivinationCard => "ไพ่พยากรณ์";
        public string DescriptionUnidentified => "ยังไม่ได้ตรวจสอบ";
        public string DescriptionQuality => "คุณภาพ";
        public string DescriptionAlternateQuality => "คุณภาพแบบพิเศษ";
        public string DescriptionCorrupted => "คอร์รัปต์";
        public string DescriptionSockets => "ซ็อกเก็ต";
        public string DescriptionItemLevel => "เลเวลไอเทม";
        public string PrefixSuperior => "Superior";
        public string InfluenceShaper => "เชปเปอร์";
        public string InfluenceElder => "เอลเดอร์";
        public string InfluenceCrusader => "ครูเซเดอร์";
        public string InfluenceHunter => "ฮันเตอร์";
        public string InfluenceRedeemer => "รีดีมเมอร์";
        public string InfluenceWarlord => "วอร์หลอด";
        public string DescriptionMapTier => "ระดับแผนที่";
        public string DescriptionItemQuantity => "จำนวนไอเท็ม";
        public string DescriptionItemRarity => "ระดับความหายากของไอเทม";
        public string DescriptionMonsterPackSize => "ขนาดบรรจุมอนสเตอร์";
        public string PrefixBlighted => "Blighted";
        public string DescriptionExperience => "ประสบการณ์";
        
        public string DescriptionPhysicalDamage => "__TranslationRequired__";

        public string DescriptionElementalDamage => "__TranslationRequired__";

        public string DescriptionAttacksPerSecond => "__TranslationRequired__";

        public string DescriptionCriticalStrikeChance => "__TranslationRequired__";

        public string DescriptionEnergyShield => "__TranslationRequired__";

        public string DescriptionArmour => "__TranslationRequired__";

        public string DescriptionEvasion => "__TranslationRequired__";
        public string DescriptionChanceToBlock => "__TranslationRequired__";

        public string DescriptionLevel => "__TranslationRequired__";

        public string PrefixAnomalous => "Anomalous";
        public string PrefixDivergent => "Divergent";
        public string PrefixPhantasmal => "Phantasmal";
    }
}
