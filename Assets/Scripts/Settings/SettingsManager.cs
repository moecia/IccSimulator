using UnityEngine;

namespace Assets.Scripts.Settings
{
    public class SettingsManager: MonoBehaviour
    {
        public Settings settings { get; private set; }

        public SettingsManager()
        {
            settings = new Settings();
            // TODO: Load settings from save files.
            this.SetLanguage(LanguageCodes.zh_CN);
        }

        public void SetLanguage(LanguageCodes languageCode)
        {
            settings.Language = languageCode;
        }
    }

    public enum LanguageCodes
    {
        zh_CN,
        en_US
    }
}
