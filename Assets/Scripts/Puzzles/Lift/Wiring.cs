using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Wiring : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Image image;
    private LineRenderer lineRenderer;
    private Canvas canvas;
    private bool dragging = false;

    public Vector3 initialPos;

    private void Awake()
    {
        image = GetComponent<Image>();
        lineRenderer = GetComponent<LineRenderer>();
        canvas = GetComponentInParent<Canvas>();
        initialPos = transform.position;
    }

    private void Update()
    {
        if (dragging)
        {
            Vector2 movePos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out movePos);
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, canvas.transform.TransformPoint(movePos));
        }
        else
        {
            lineRenderer.SetPosition(0, Vector3.zero);
            lineRenderer.SetPosition(0, Vector3.zero);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        dragging = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragging = false;
    }
}
