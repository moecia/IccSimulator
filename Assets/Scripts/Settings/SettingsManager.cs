using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Settings
{
    public class SettingsManager: IGameManager
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

        public void Dispose()
        {
        }
    }

    public enum LanguageCodes
    {
        zh_CN,
        en_US
    }
}
