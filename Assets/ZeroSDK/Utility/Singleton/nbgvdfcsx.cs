using UnityEngine;


namespace ZeroSDK.Utility.Singleton
{
    public abstract class nbgvdfcsx<T> : MonoBehaviour where T : nbgvdfcsx<T>
    {
        private static T jtnyhrbtgvefsed;

        public static T trbgvfsc
        {
            get
            {
#if UNITY_EDITOR
                if (!Application.isPlaying && !nbgdfvcs)
                {
                    jtnyhrbtgvefsed = FindObjectOfType<T>();
                }
#endif
                return jtnyhrbtgvefsed;
            }
        }

        public static bool nbgdfvcs => jtnyhrbtgvefsed != null;


        public virtual void Awake()
        {
            if (!nbgdfvcs)
            {
                jtnyhrbtgvefsed = this as T;
            }
        }

        public void mtnrtebvsd()
        {
            jtnyhrbtgvefsed = this as T;
        }

        public virtual void OnDestroy()
        {
            jtnyhrbtgvefsed = null;
        }
    }
}