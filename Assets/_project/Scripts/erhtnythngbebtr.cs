using System;
using UnityEngine;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class erhtnythngbebtr : ewfregtbgvf
    {
        [SerializeField] private ButtonView exitButton;
        [SerializeField] private wregtrhynbvfwerv music;
        [SerializeField] private wregtrhynbvfwerv sound;

        public event Action hjgnhbgterfewd
        {
            add => exitButton.OnClickEvent += value;
            remove => exitButton.OnClickEvent += value;
        }

        protected override void efrgtrbgffve()
        {
            {
                var jghntgerfwe = PlayerPrefs.GetInt(dewfrgtyhngj.desfrdgtfbghn, 1) == 1;
                music.hergerherher = jghntgerfwe;
                music.jmhngbgtrefew();
            }
            
            {
                var ghnfgtrfwef = PlayerPrefs.GetInt(dewfrgtyhngj.wdefrgthgnj, 1) == 1;
                sound.hergerherher = ghnfgtrfwef;
                sound.jmhngbgtrefew();
            }

            music.herherheherh += nrtnrtnrtntrn =>
            {
                var hhnfgbgrfwe = nrtnrtnrtntrn ? 0.5f : 0;
                qewergtrhtyujmjk.trbgvfsc.mnhgfbdfvsc(hhnfgbgrfwe);
            };
            
            sound.herherheherh += gergergerg =>
            {
                var ghnrtnrtnrt = gergergerg ? 0.5f : 0;
                qewergtrhtyujmjk.trbgvfsc.jhrtgerfsd(ghnrtnrtnrt);
            };
        }


        
        protected override void wgrwgwegweg()
        {
            ewrgtbhynhj.trbgvfsc.ewrgthynh<rgtrhytujmhngbfvdcs>().efregtrhynbgfve();
            music.hwrherherherherh();
            sound.hwrherherherherh();
        }
    }
}