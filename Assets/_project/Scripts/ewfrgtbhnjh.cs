using System.Linq;
using Cysharp.Threading.Tasks;
using UnityEngine;
using ZeroSDK.UIBuilder.Core;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    [DefaultExecutionOrder(1)]
    public sealed class ewfrgtbhnjh : MonoBehaviour
    {
        [SerializeField] private ewrgtbhynhj uiManager;
        [SerializeField] private mhjngbgfvdfcsevrtrh rocketGameLevelsList;


        private ewfregtbgvf rwegrrtnrtn;
        private eregtrhynthbgfdvfscwevrtb egreherherherh;
        private int gererherherherher = 1;

        private async void Awake()
        {
            if (PlayerPrefs.HasKey(dewfrgtyhngj.ewfrgthygnujhm))
            {
                gererherherherher = Mathf.Max(1, PlayerPrefs.GetInt(dewfrgtyhngj.ewfrgthygnujhm));
            }

            uiManager.ewfrtgbthngj();
            dsfgfhngmjhk();


            var dsfdgfhj = uiManager.derftgbghnjmk<herherherherher>();
            await UniTask.WaitForSeconds(0.25f);
            dsfdgfhj.herherherherhh(1.9f);
            await UniTask.WaitForSeconds(2);
            uiManager.ewrfgthtngjh<iujyhtgrfed>();
        }

        private void dsfgfhngmjhk()
        {
            var sfdgfhgjmh = uiManager.ewrgthynh<iujyhtgrfed>();
            sfdgfhgjmh.kjmhngftdreds += () => uiManager.ewrfgthtngjh<erherherherherh>();
            sfdgfhgjmh.juythgrfed += () => ewfrgthynj(sfdgfhgjmh);
            sfdgfhgjmh.juyhtgrfsed += Application.Quit;

            var dsfdgfhgjmhj = uiManager.ewrgthynh<erhtnythngbebtr>();
            dsfdgfhgjmhj.hjgnhbgterfewd += () => uiManager.ewrfgthtngjh(rwegrrtnrtn.GetType());


            var dfsdgfhgnjm = uiManager.ewrgthynh<erherherherherh>();
            dfsdgfhgnjm.ngfgbfgwe(gererherherherher);
            dfsdgfhgnjm.herherherherh += () => uiManager.ewrfgthtngjh<iujyhtgrfed>();
            dfsdgfhgnjm.jghnhtgrfwe += level =>
            {
                if (level > gererherherherher - 1)
                    return;

                var screen = uiManager.ewrfgthtngjh<htyrgrefwed>();
                screen.wreegrtrhnybvwv(rocketGameLevelsList.gjnhfbgdvfscdbttng[level]);
            };


            var weretrhytjuymtnrgr = uiManager.ewrgthynh<htyrgrefwed>();

            weretrhytjuymtnrgr.jnbtgrfed += () => uiManager.ewrfgthtngjh<erherherherherh>();
            weretrhytjuymtnrgr.tyhrgfe += () => ewfrgthynj(weretrhytjuymtnrgr);

            weretrhytjuymtnrgr.htgfsewg += () =>
            {
                uiManager.ewrfgthtngjh<erherherherherh>();
                weretrhytjuymtnrgr.rwegerrhtbn();
            };

            weretrhytjuymtnrgr.ynutyrbtgerf += data =>
            {
                egreherherherh = data;
                gererherherherher = Mathf.Clamp(gererherherherher + 1, 0, rocketGameLevelsList.gjnhfbgdvfscdbttng.Count);

                PlayerPrefs.SetInt(dewfrgtyhngj.ewfrgthygnujhm, gererherherherher);
                PlayerPrefs.Save();

                dfsdgfhgnjm.ngfgbfgwe(gererherherherher);
            };

            weretrhytjuymtnrgr.htheheherherh += () =>
            {
                for (int i = 0; i < rocketGameLevelsList.gjnhfbgdvfscdbttng.Count; i++)
                {
                    if (egreherherherh == rocketGameLevelsList.gjnhfbgdvfscdbttng[i])
                    {
                        var sgfdhfngmj = (i + 1) % (rocketGameLevelsList.gjnhfbgdvfscdbttng.Count);
                        weretrhytjuymtnrgr.wreegrtrhnybvwv(rocketGameLevelsList.gjnhfbgdvfscdbttng[sgfdhfngmj]);
                        return;
                    }
                }
            };
        }

        private erhtnythngbebtr ewfrgthynj(ewfregtbgvf lastScreen)
        {
            rwegrrtnrtn = lastScreen;
            return uiManager.ewrfgthtngjh<erhtnythngbebtr>();
        }
    }
}