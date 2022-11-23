using Rocket.API.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueScreen
{
    public partial class BlueScreen
    {
        public override TranslationList DefaultTranslations => new TranslationList
        {
            {
                "ProperUsage", "[color=#FF0000]{{BTBlueScreen}} [/color] [color=#F3F3F3]Proper Usage |[/color] [color=#3E65FF]{0}[/color]"
            },
            {
                "TargetNotFound", "[color=#FF0000]{{BTBlueScreen}} [/color][color=#F3F3F3]Target Not Found![/color]"
            },
            {
                "BlueScreened", "[color=#FF0000]{{BTBlueScreen}} [/color][color=#F3F3F3]You have successfully BlueScreened[/color] [color=#3E65FF]{0}[/color]"
            },
            {
                "BlueScreenRemoved", "[color=#FF0000]{{BTBlueScreen}} [/color][color=#3E65FF]{0}[/color] [color=#F3F3F3]has been Removed from the BlueScreen[/color]"
            },
        };
    }
}