using System;
using System.Collections.Generic;
using UnityEngine;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class erherherherherh : ewfregtbgvf
    {
        [SerializeField] private ButtonView exitButton;
        [SerializeField] private List<ButtonView> levelButtons;

        public event Action herherherherh
        {
            add => exitButton.OnClickEvent += value;
            remove => exitButton.OnClickEvent += value;
        }

        public event Action<int> jghnhtgrfwe;

        protected override void efrgtrbgffve()
        {
            for (int i = 0; i < levelButtons.Count; i++)
            {
                var eherherherhe = i;
                levelButtons[i].OnClickEvent += () => jghnhtgrfwe?.Invoke(eherherherhe);
            }
        }

        public void ngfgbfgwe(int herherherherh)
        {
            for (int i = 0; i < Mathf.Min(herherherherh, levelButtons.Count); i++)
            {
                var rnrtnrtnrtn = i <= herherherherh - 1 ? 1 : 0.16f;
                levelButtons[i].CG.alpha = rnrtnrtnrtn;
            }
        }
        
        protected override void wgrwgwegweg() => ewrgtbhynhj.trbgvfsc.ewrgthynh<rgtrhytujmhngbfvdcs>().efregtrhynbgfve();
    }
}