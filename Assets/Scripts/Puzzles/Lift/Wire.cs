using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Wire : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Image image;
    private LineRenderer lineRenderer;
    private Canvas canvas;
    private bool dragging = false;
    private Wiring wiringTask;

    public Vector3 initialPos;
    public bool isLeftWire;
    
    private void Awake()
    {
        image = GetComponent<Image>();
        lineRenderer = GetComponent<LineRenderer>();
        canvas = GetComponentInParent<Canvas>();
        initialPos = transform.position;
        wiringTask = GetComponentInParent<Wiring>();
    }

    private void Update()
    {
        if (dragging)
        {
            Vector2 movePos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out movePos);
            if (isLeftWire)
                lineRenderer.SetPosition(0, new Vector3(transform.position.x - 1,transform.position.y,transform.position.z));
            else
                lineRenderer.SetPosition(0, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z));
            lineRenderer.SetPosition(1, canvas.transform.TransformPoint(movePos));
        }
        else
        {
            if (!wiringTask.CheckConnection(this))
            {
                lineRenderer.SetPosition(0, Vector3.zero);
                lineRenderer.SetPosition(0, Vector3.zero);
            }
        }
    }

    public void OnHover()
    {
        wiringTask.currentHoveredWire = this;
    }

    public void OnExitHover()
    {
        if (wiringTask.currentHoveredWire == this)
            wiringTask.currentHoveredWire = null;
    }

    public void ConnectWire()
    {
        if (wiringTask.currentHoveredWire && wiringTask.currentHoveredWire.isLeftWire != isLeftWire && !wiringTask.CheckConnection(wiringTask.currentHoveredWire))
        {
            wiringTask.ConnectPair(wiringTask.currentHoveredWire, wiringTask.currentDraggedWire);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (wiringTask.CheckConnection(this))
            wiringTask.RemoveWire(this);
    }

    public void OnDrag(PointerEventData eventData)
    {
        wiringTask.currentDraggedWire = this;
        dragging = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragging = false;
        ConnectWire();
    }
}
