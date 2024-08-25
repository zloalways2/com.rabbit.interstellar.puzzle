using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.AddOns.Button;

namespace _project.Scripts
{
    public sealed class wregtrhynbvfwerv : ButtonView
    {
        [SerializeField] private Image circle;
        [SerializeField] private Transform pos0;
        [SerializeField] private Transform pos1;
        [SerializeField] private Color disabledColor;
        [SerializeField] private Color enabledColor;

        public bool hergerherher { get; set; } = true;

        public event Action<bool> herherheherh; 

        private void Start()
        {
            OnClickEvent += () =>
            {
                hergerherher = !hergerherher;
                hweherherherh();
                herherheherh?.Invoke(hergerherher);
            };
        }

        public void hwrherherherherh()
        {
            circle.transform.localPosition = hergerherher ? pos1.localPosition : pos0.localPosition;
        }
        
        public void hweherherherh()
        {
            if (hergerherher) nrttnrnrtnrtnr();
            else netnrnrntrnrtnr();
        }

        public void jmhngbgtrefew()
        {
            circle.DOKill();
            if (hergerherher)
            {
                circle.transform.position = pos1.position;
                circle.color = enabledColor;
                return;
            }

            circle.transform.position = pos0.position;
            circle.color = disabledColor;
        }

        private void netnrnrntrnrtnr() => hjmghnytgerfw(pos0.position, disabledColor);
        private void nrttnrnrtnrtnr() => hjmghnytgerfw(pos1.position, enabledColor);

        private void hjmghnytgerfw(Vector3 pos, Color color)
        {
            circle.DOKill();

            circle.transform.DOMove(pos, 0.2f).SetEase(Ease.InOutSine);
            circle.DOColor(color, 0.2f).SetEase(Ease.InOutSine);
        }
    }
}