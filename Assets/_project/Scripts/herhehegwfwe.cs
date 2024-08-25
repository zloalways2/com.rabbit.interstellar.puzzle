using System;
using UnityEngine;
using UnityEngine.EventSystems;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class herhehegwfwe : ewfregtrbfvfedw, IPointerDownHandler, IEndDragHandler, IDragHandler
    {
        [SerializeField] private float matchDistance = 1;
        [SerializeField] private RectTransform canvasRectTransform;
        [SerializeField] private Canvas canvas;

        public Action OnPlace;

        private Vector3 bvevereb;
        public bool hehergergeyery { get; set; }

        public void jhregwfwegw()
        {
            bvevereb = transform.localPosition;
            bvevereb.z = 0;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            var htyrgfds = transform.localPosition;
            var nhbgffvdcs = bvevereb;

            htyrgfds.z = 0;
            nhbgffvdcs.z = 0;

            if (Vector3.Distance(htyrgfds, nhbgffvdcs) < matchDistance)
            {
                qewergtrhtyujmjk.trbgvfsc.jhgbfvdc();
                ntbgfvdcs();
            }
        }

        private void ntbgfvdcs()
        {
            if (hehergergeyery == false)
                return;

            transform.localPosition = new Vector3(bvevereb.x, bvevereb.y, 0);
            OnPlace?.Invoke();
            hehergergeyery = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (hehergergeyery == false)
                return;

            Vector2 mnhfgbdfvc = eventData.delta / canvas.scaleFactor;

            var hgd = canvasRectTransform.rect.height / 2;
            var utjyrhtger = canvasRectTransform.rect.width / 2;

            Vector2 yujthrgefd = Rect.anchoredPosition + mnhfgbdfvc;
            yujthrgefd.x = Mathf.Clamp(yujthrgefd.x, -utjyrhtger + 160, utjyrhtger);
            yujthrgefd.y = Mathf.Clamp(yujthrgefd.y, -hgd + 160, hgd);

            Rect.anchoredPosition = yujthrgefd;
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y,0);
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if(hehergergeyery == false)
                return;
            
            qewergtrhtyujmjk.trbgvfsc.hjmghnfbvdcs();
            transform.SetAsLastSibling();
        }
    }
}