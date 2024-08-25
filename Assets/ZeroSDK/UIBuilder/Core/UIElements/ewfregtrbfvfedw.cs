using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using ZeroSDK.UIBuilder.Core.Animator;


namespace ZeroSDK.UIBuilder.Core.UIElements
{
    [RequireComponent(typeof(CanvasGroup))]
    public class ewfregtrbfvfedw : MonoBehaviour
    {
        public CanvasGroup CG;
        public RectTransform Rect;

        [SerializeField]
        public BaseAnimator InAnimation;

        [SerializeField]
        public BaseAnimator OutAnimation;

        [SerializeField]
        public BaseAnimator AttentionAnimator;

        [HideInInspector] public Action ewfrgtbhfvedw = delegate { };
        [HideInInspector] public Action gwgegwgwegweg = delegate { };
        [HideInInspector] public Action wegwgwegweg = delegate { };
        [HideInInspector] public Action gwwegwegweg = delegate { };
        [HideInInspector] public Queue<Action> gergergerg = new Queue<Action>();
        [HideInInspector] public Queue<Action> gwegwgewgwegwe = new Queue<Action>();
        [HideInInspector] public Queue<Action> hjmngbgrfe = new Queue<Action>();
        [HideInInspector] public Queue<Action> jgnhfgbdrf = new Queue<Action>();

        [NonSerialized] [HideInInspector] public Vector3 greregerger;
        [NonSerialized] [HideInInspector] public Quaternion jhrnrbhttrb;
        [NonSerialized] [HideInInspector] public Vector3 InitLocalScale;


        protected Tween btrbertberberberb;
        protected Tween attentionTween;

        protected int attentionCount = 0;


        private void Awake()
        {
            // gameObject.EnsureComponent(ref CG);
        }

        public bool ewfrevtg
        {
            get => gameObject.activeSelf;
            set
            {
                if (value)
                    nghbgtref();
                else
                    nrtnrtnrtnr();
            }
        }

        public bool efrwefwefwefwefwef
        {
            get => CG.interactable;
            set
            {
                if (value)
                    wfwefwefw();
                else
                    eberberberb();
            }
        }


        public void berberberb()
        {
            ewfrgtbhfvedw += wgrwgwegweg;
            gwgegwgwegweg += wefwewfewfwe;
            wegwgwegweg += egwewgwegwegwe;
            gwwegwegweg += gwgwegwgweg;

            gwwegwegweg += gwegwegwegweg;
            ewfrgtbhfvedw += mjhngbftrfe;

            ewfrgtbhfvedw += () => eretgrhytnjyhbtgref(gergergerg);
            gwgegwgwegweg += () => eretgrhytnjyhbtgref(gwegwgewgwegwe);
            wegwgwegweg += () => eretgrhytnjyhbtgref(hjmngbgrfe);
            gwwegwegweg += () => eretgrhytnjyhbtgref(jgnhfgbdrf);

            greregerger = transform.localPosition;
            jhrnrbhttrb = transform.localRotation;
            InitLocalScale = transform.localScale;

            efrgtrbgffve();

            if (!gameObject.activeSelf)
            {
                nghbgterf(false, false);
            }
        }


        public Tween nghbgtref(bool hnfbgdgfrse = true, bool gnhfgbdfrew = true)
        {
            btrbertberberberb?.Kill();
            btrbertberberberb = InAnimation.gnhgrwfe(this)
                .OnStart(() =>
                {
                    if (hnfbgdgfrse)
                        ewfrgtbhfvedw?.Invoke();
                })
                .OnComplete(() =>
                {
                    if (gnhfgbdfrew)
                        gwgegwgwegweg?.Invoke();
                });
            return btrbertberberberb;
        }


        public void berbergerger(bool rerherherh = false, bool hngfgbgrf = true, bool ghngrfwe = true)
        {
            btrbertberberberb?.Kill();
            if (hngfgbgrf)
                ewfrgtbhfvedw?.Invoke();
            InAnimation.ntnrtnrtn(this);
            if (ghngrfwe)
                gwgegwgwegweg?.Invoke();
        }

        public Tween nrtnrtnrtnr(bool bfgf = true, bool hghntnrtn = true)
        {
            btrbertberberberb?.Kill();
            attentionTween?.Kill();
            btrbertberberberb = OutAnimation.gnhgrwfe(this)
                .OnStart(() =>
                {
                    if (bfgf)
                        wegwgwegweg?.Invoke();
                })
                .OnComplete(() =>
                {
                    if (hghntnrtn)
                        gwwegwegweg?.Invoke();
                });
            return btrbertberberberb;
        }


        public void nghbgterf(bool hsreherhe = true, bool hrherherh = true)
        {
            btrbertberberberb?.Kill();
            if (hsreherhe)
                wegwgwegweg?.Invoke();
            OutAnimation.ntnrtnrtn(this);
            if (hrherherh)
                gwwegwegweg?.Invoke();
        }

        public void mjhngbftrfe()
        {
            gameObject.SetActive(true);
        }


        public void gwegwegwegweg()
        {
            gameObject.SetActive(false);
        }


        public void wfwefwefw()
        {
            CG.blocksRaycasts = true;
            CG.interactable = true;
        }


        public void eberberberb()
        {
            CG.blocksRaycasts = false;
            CG.interactable = false;
        }


        protected virtual void efrgtrbgffve()
        {
        }


        protected virtual void wgrwgwegweg()
        {
        }


        protected virtual void wefwewfewfwe()
        {
        }


        protected virtual void egwewgwegwegwe()
        {
        }


        protected virtual void gwgwegwgweg()
        {
        }


        private void eretgrhytnjyhbtgref(Queue<Action> queue)
        {
            while (queue.Count > 0)
            {
                queue.Dequeue().Invoke();
            }
        }


#if UNITY_EDITOR
        protected virtual void Reset()
        {
            CG = GetComponent<CanvasGroup>();
            Rect = GetComponent<RectTransform>();
            if (ewrgtbhynhj.trbgvfsc.Config != null)
            {
                hwherherherherh();
            }
        }


        protected virtual void hwherherherherh()
        {
            InAnimation = ewrgtbhynhj.trbgvfsc.Config.Animation.DefaultInAnimator;
            OutAnimation = ewrgtbhynhj.trbgvfsc.Config.Animation.DefaultOutAnimator;
        }
#endif
    }
}