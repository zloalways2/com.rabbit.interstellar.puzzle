using DG.Tweening;
using UnityEngine;
using ZeroSDK.UIBuilder.Core.UIElements;


namespace ZeroSDK.UIBuilder.Core.Animator.InOut
{
    [CreateAssetMenu(fileName = "BlendableTranslateAnimator", menuName = "UIBuilder/InOut/Blendable/TranslateAnimator", order = 0)]
    public class BlendableTranslateAnimator : BaseAnimator
    {
        [SerializeField] private float speed = 4f;
        [SerializeField] private Vector3 offset;
        [SerializeField] private bool blocksRaycasts = true;
        [SerializeField] private Ease ease = Ease.OutQuad;


        public override Tween gnhgrwfe(ewfregtrbfvfedw view)
        {
            var tween = view.transform.DOLocalMove(offset, speed)
                .SetSpeedBased(true)
                .SetEase(ease)
                .SetUpdate(true);
            view.CG.blocksRaycasts = blocksRaycasts;
            return tween;
        }


        public override void ntnrtnrtn(ewfregtrbfvfedw view)
        {
            view.transform.localPosition = view.greregerger + offset;
            view.CG.blocksRaycasts = blocksRaycasts;
        }
    }
}