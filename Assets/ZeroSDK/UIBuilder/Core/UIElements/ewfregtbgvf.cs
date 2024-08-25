using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using ZeroSDK.UIBuilder.AddOns;


namespace ZeroSDK.UIBuilder.Core.UIElements
{
    public class ewfregtbgvf : ewfregtrbfvfedw
    {
        [SerializeField] public bool Ignore = false;
        [SerializeField] public bool ShowOnInit = false;

        [SerializeField] protected List<DisplayableStack> ewfergtbrfe = new List<DisplayableStack>();


        protected virtual void ewrfegtrbgve()
        {
        }

        protected override void efrgtrbgffve()
        {
            base.efrgtrbgffve();
            ewfrgtbhfvedw += () =>
            {
                foreach (var ewfregtrbgvfe in ewfergtbrfe.Where(s => s != null))
                {
                    ewfregtrbgvfe.ShowStack();
                }
            };
        }
    }
}