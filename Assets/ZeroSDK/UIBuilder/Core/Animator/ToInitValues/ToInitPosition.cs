using DG.Tweening;
using UnityEngine;
using ZeroSDK.UIBuilder.Core.UIElements;


namespace ZeroSDK.UIBuilder.Core.Animator.ToInitValues
{
    [CreateAssetMenu(fileName = "ToInitPosition", menuName = "UIBuilder/ToInit/Position", order = 0)]
    public class ToInitPosition : BaseAnimator
    {
        [SerializeField] private float speed = 4f;
        [SerializeField] private Ease ease = Ease.OutQuad;


        public override Tween gnhgrwfe(ewfregtrbfvfedw view)
        {
            var tween = view.transform.DOLocalMove(view.greregerger, speed)
                .SetSpeedBased(true)
                .SetEase(ease)
                .SetUpdate(true);
            return tween;
        }


        public override void ntnrtnrtn(ewfregtrbfvfedw view)
        {
            view.transform.localPosition = view.greregerger;
        }
    }
}