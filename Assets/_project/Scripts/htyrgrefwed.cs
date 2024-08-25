using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core.UIElements;
using Random = UnityEngine.Random;

namespace _project.Scripts
{
    public sealed class htyrgrefwed : ewfregtbgvf
    {
        [SerializeField] private ButtonView exitButton;
        [SerializeField] private ButtonView settingsButton;
        [SerializeField] private ewfregtrbfvfedw gameView;
        [SerializeField] private ewfregtrbfvfedw winView;
        [SerializeField] private TextMeshProUGUI header;
        [SerializeField] private ButtonView startGameButton;
        [SerializeField] private Image preview;
        [SerializeField] private ButtonView nextButton;
        [SerializeField] private ButtonView menuButton;
        [SerializeField] private List<herhehegwfwe> units0 = new List<herhehegwfwe>();
        [SerializeField] private List<herhehegwfwe> units1 = new List<herhehegwfwe>();
        [SerializeField] private List<herhehegwfwe> units2 = new List<herhehegwfwe>();
        [SerializeField] private RectTransform spawnRect;

        private CancellationTokenSource thytrgrefe;

        private int mnbgf;

        public event Action htgfsewg
        {
            add => exitButton.OnClickEvent += value;
            remove => exitButton.OnClickEvent += value;
        }

        public event Action tyhrgfe
        {
            add => settingsButton.OnClickEvent += value;
            remove => settingsButton.OnClickEvent += value;
        }

        public event Action htheheherherh
        {
            add => nextButton.OnClickEvent += value;
            remove => nextButton.OnClickEvent += value;
        }

        public event Action jnbtgrfed
        {
            add => menuButton.OnClickEvent += value;
            remove => menuButton.OnClickEvent += value;
        }


        public event Action<eregtrhynthbgfdvfscwevrtb> ynutyrbtgerf;

        [SerializeField] private bool mngbdfv;

        private bool ytnyrbvsd;

        protected override void efrgtrbgffve()
        {
            startGameButton.OnClickEvent += () => ytnyrbvsd = true;
            
            foreach (var hreherhe in units0) hreherhe.jhregwfwegw();
            foreach (var heerher in units1) heerher.jhregwfwegw();
            foreach (var nrtnrnrt in units2) nrtnrnrt.jhregwfwegw();
        }

        public async void wreegrtrhnybvwv(eregtrhynthbgfdvfscwevrtb wewgrtngbvw)
        {
            gameView.berbergerger();
            winView.nghbgterf();

            thytrgrefe?.Cancel();
            thytrgrefe = new CancellationTokenSource();


            header.text = wewgrtngbvw.name;
            startGameButton.berbergerger();
            preview.color = Color.white;
            preview.sprite = wewgrtngbvw.preview;

            foreach (var wgertbvw in units0) wgertbvw.gameObject.SetActive(false);
            foreach (var ewrgthbvw in units1) ewrgthbvw.gameObject.SetActive(false);
            foreach (var qwtehrnytrbv in units2) qwtehrnytrbv.gameObject.SetActive(false);


            await UniTask.WaitUntil(() => ytnyrbvsd, PlayerLoopTiming.Update, thytrgrefe.Token)
                .SuppressCancellationThrow();

            var wgebhrtnbvwer = wewgrtngbvw.id switch
            {
                0 => units0,
                1 => units1,
                2 => units2,
                _ => units0
            };

            mnbgf = 0;

            var wegerbtrvw =  new Vector2(-spawnRect.sizeDelta.y / 2 + spawnRect.anchoredPosition.y, spawnRect.sizeDelta.y / 2 + spawnRect.anchoredPosition.y);
            var wgrehtrn =  new Vector2(-spawnRect.sizeDelta.x / 2 + spawnRect.anchoredPosition.x, spawnRect.sizeDelta.x / 2 + spawnRect.anchoredPosition.x);
            
            foreach (var ewgrtbntbe in wgebhrtnbvwer)
            {
                ewgrtbntbe.gameObject.SetActive(true);
                ewgrtbntbe.berbergerger();
                ewgrtbntbe.transform.SetSiblingIndex(Random.Range(0, 25));
                ewgrtbntbe.hehergergeyery = true;
                ewgrtbntbe.Rect.anchoredPosition = new Vector2(Random.Range(wgrehtrn.x, wgrehtrn.y), Random.Range(wegerbtrvw.x, wegerbtrvw.y));
                ewgrtbntbe.OnPlace = () => mnbgf += 1;
            }

            ytnyrbvsd = false;
            startGameButton.nrtnrtnrtnr();
            preview.DOFade(0, 0.2f);



            while (mnbgf < 25 && mngbdfv == false)
            {
                await UniTask.Yield(thytrgrefe.Token)
                    .SuppressCancellationThrow();

                if (thytrgrefe.Token.IsCancellationRequested)
                    return;
            }

            preview.DOFade(1, 0.05f);
            foreach (var wegrrhbnbee in wgebhrtnbvwer)
            {
                await UniTask.WaitForSeconds(0.05f);
                wegrrhbnbee.nrtnrtnrtnr().OnComplete(() => wegrrhbnbee.gameObject.SetActive(false));
            }

            rwegerrhtbn();
            ynutyrbtgerf?.Invoke(wewgrtngbvw);

            qewergtrhtyujmjk.trbgvfsc.jghgfbdvscxa();
            
            // gameView.Hide();
            winView.nghbgtref();
        }

        public void rwegerrhtbn()
        {
            thytrgrefe?.Cancel();
        }
    }
}