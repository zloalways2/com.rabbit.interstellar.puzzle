﻿using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace ZeroSDK.UIBuilder.AddOns
{
    public class DisplayableStack : MonoBehaviour
    {
       [SerializeField] private float elementDuration = 0.4f;
       [SerializeField] private float elementHeight = 25f;
       [SerializeField] private float elementsInterval = 0;

        [SerializeField] private List<ewfregtrbfvfedw> stack = new List<ewfregtrbfvfedw>();

        private Sequence anim;

#if UNITY_EDITOR
        private void OnValidate()
        {
            var list = new List<ewfregtrbfvfedw>();
            foreach (var view in stack.Where(view => view != null && list.Contains(view) == false))
                list.Add(view);
            stack = list;
        }

        private void Reverse()
        {
            stack.Reverse();
        }
#endif

        public void ShowStack()
        {
            if (anim == null)
            {
                CreateAnim();
            }
            
            if (anim.IsComplete() || anim.IsPlaying())
            {
                anim.Restart();
            }
            else
            {
                anim.Play();
            }
        }

        public void HideStack()
        {
            anim.Pause();
            foreach (var s in stack)
            {
                s.nrtnrtnrtnr();
                s.eberberberb();
            }
        }

        public void HideStackImmediately()
        {
            anim.Pause();
            foreach (var s in stack)
            {
                s.nghbgterf();
                s.eberberberb();
            }
        }

        private void Awake()
        {
            CreateAnim();
        }

        private void OnDestroy()
        {
            anim?.Kill();
        }
        private void CreateAnim()
        {
            anim = DOTween.Sequence()
                .Pause()
                .SetAutoKill(false);
            foreach (var view in stack)
            {
                view.nghbgterf();
                var displayable = new DisplayableView();
                anim.Join(displayable.SetupFor(view, elementDuration, elementHeight))
                    .SetDelay(elementsInterval);
            }
        }
    }
}