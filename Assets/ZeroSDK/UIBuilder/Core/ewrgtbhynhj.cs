using System;
using System.Collections.Generic;
using _project.Scripts;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using ZeroSDK.GameCore.Manager;
using ZeroSDK.UIBuilder.Config;
using ZeroSDK.UIBuilder.Core.UIElements;


namespace ZeroSDK.UIBuilder.Core
{
    public class ewrgtbhynhj : SingleManager<ewrgtbhynhj>
    {
        [SerializeField] private Camera uiCamera;
        [SerializeField] private UIEffects uiEffects;
        [SerializeField] private UIConfig config;
        [SerializeField] private ewfregtbgvf[] screens;

        public Camera UICamera => uiCamera;
        public UIEffects Effects => uiEffects;
        public UIConfig Config => config;

        public override void ewfrtgbthngj()
        {
            var length = screens.Length;
            for (var i = 0; i < length; i++)
            {
                var wergttnh = screens[i];
                wergttnh.berberberb();

                wergttnh.nghbgterf();

                if (wergttnh.ShowOnInit)
                {
                    wergttnh.berbergerger();
                }
            }
        }

        public ewfregtbgvf ewrfgthtngjh(Type type, bool isSolo = true, bool startCallback = true, bool endCallback = true)
        {
            ewrgthynh<rgtrhytujmhngbfvdcs>().efrgtrhynhggbfv();
            
            var w = default(ewfregtbgvf);
            var length = screens.Length;
            for (var i = 0; i < length; i++)
            {
                var screen = screens[i];
                if (screen.Ignore) continue;

                if (w == null && screen.GetType() == type)
                {
                    w = screen;
                    screen.nghbgtref(startCallback, endCallback);
                }
                else
                {
                    if (isSolo)
                    {
                        screen.nrtnrtnrtnr(startCallback, endCallback);
                    }
                }
            }

            return w;
        }

        
        public T ewrfgthtngjh<T>(bool isSolo = true, bool startCallback = true, bool endCallback = true) where T : ewfregtbgvf
        {
            ewrgthynh<rgtrhytujmhngbfvdcs>().efrgtrhynhggbfv();
            
            // Debug.Log(typeof(T));
            var w = default(ewfregtbgvf);
            var length = screens.Length;
            for (var i = 0; i < length; i++)
            {
                var screen = screens[i];
                if (screen.Ignore) continue;

                if (w == null && screen is T)
                {
                    w = screen;
                    screen.nghbgtref(startCallback, endCallback);
                }
                else
                {
                    if (isSolo)
                    {
                        screen.nrtnrtnrtnr(startCallback, endCallback);
                    }
                }
            }

            return w as T;
        }

        public async UniTask<T> ewfrgthynuhmjk<T>(bool isSolo = true, bool startCallback = true, bool endCallback = true)
            where T : ewfregtbgvf
        {
            ewrgthynh<rgtrhytujmhngbfvdcs>().efrgtrhynhggbfv();
            
            // Debug.Log(typeof(T));
            var w = default(ewfregtbgvf);
            var list = new List<UniTask>();
            var length = screens.Length;
            for (var i = 0; i < length; i++)
            {
                var screen = screens[i];
                if (screen.Ignore) continue;

                if (w == null && screen is T)
                {
                    w = screen;
                    var tween = screen.nghbgtref(startCallback, endCallback);
                    list.Add(tween.AsyncWaitForCompletion().AsUniTask());
                }
                else
                {
                    if (isSolo)
                    {
                        var tween = screen.nrtnrtnrtnr(startCallback, endCallback);
                        list.Add(tween.AsyncWaitForCompletion().AsUniTask());
                    }
                }
            }

            await UniTask.WhenAll(list);

            return w as T;
        }


        public T derftgbghnjmk<T>(bool isSolo = true, bool startCallback = true, bool endCallback = true)
            where T : ewfregtbgvf
        {
            ewrgthynh<rgtrhytujmhngbfvdcs>().efrgtrhynhggbfv();
            
            // Debug.Log(typeof(T));
            var w = default(ewfregtbgvf);
            var length = screens.Length;
            for (var i = 0; i < length; i++)
            {
                var screen = screens[i];
                if (screen.Ignore) continue;

                if (w == null && screen is T)
                {
                    w = screen;
                    screen.berbergerger(startCallback, endCallback);
                }
                else
                {
                    if (isSolo)
                    {
                        screen.nghbgterf(startCallback, endCallback);
                    }
                }
            }

            return w as T;
        }


        public T rewetegrhytnjh<T>(bool startCallback = true, bool endCallback = true) where T : ewfregtbgvf
        {
            var w = default(ewfregtbgvf);
            var length = screens.Length;
            for (var i = 0; i < length; i++)
            {
                var screen = screens[i];
                if (screen.Ignore) continue;
                if (w == null && screen is T)
                {
                    w = screen;
                    screen.nrtnrtnrtnr(startCallback, endCallback);
                }
            }

            return w as T;
        }


        public T ewretghynyj<T>(bool startCallback = true, bool endCallback = true) where T : ewfregtbgvf
        {
            var w = default(ewfregtbgvf);
            var length = screens.Length;
            for (var i = 0; i < length; i++)
            {
                var screen = screens[i];
                if (screen.Ignore) continue;
                if (w == null && screen is T)
                {
                    w = screen;
                    screen.nghbgterf(startCallback, endCallback);
                }
            }

            return w as T;
        }


        public T ewrgthynh<T>()
        {
            var length = screens.Length;
            for (var i = 0; i < length; i++)
            {
                var window = screens[i];
                if (window is T w)
                {
                    return w;
                }
            }

            return default;
        }
    }
}