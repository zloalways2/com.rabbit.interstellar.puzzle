using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class rgtrhytujmhngbfvdcs : ewfregtbgvf
    {
        [SerializeField] private Image rabbits;

        public void efregtrhynbgfve()
        {
            rabbits.DOKill();
            rabbits.DOFade(1, 0.08f).SetEase(Ease.InOutSine);
        }
        
        public void efrgtrhynhggbfv()
        {
            rabbits.DOKill();
            rabbits.DOFade(0, 0.08f).SetEase(Ease.InOutSine);
        }
    }
}