using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public int _scrollSpeed;
    public GameObject _textToScroll;

    private Rect screen;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = _textToScroll.transform.localPosition;

        Canvas menuCanvas = gameObject.GetComponentInParent<Canvas>();

        Vector3 canvasWorldPointZero = menuCanvas.worldCamera.ScreenToWorldPoint(Vector3.zero);
        Vector3 canvasWorldPointWH = menuCanvas.worldCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));

        screen = new Rect(canvasWorldPointZero, new Vector2(canvasWorldPointWH.x - canvasWorldPointZero.x, canvasWorldPointWH.y - canvasWorldPointZero.y));
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _scrollSpeed = 23;
        }
        else
        {
            _scrollSpeed = 6;
        }

        Vector3[] wc = new Vector3[4];

        _textToScroll.GetComponent<RectTransform>().GetLocalCorners(wc);

        Rect rect = new Rect(wc[0].x, wc[0].y, wc[2].x - wc[0].x, wc[2].y - wc[0].y);

        if (rect.Overlaps(screen))
        {
            _textToScroll.transform.Translate(Vector3.up * (_scrollSpeed * Time.deltaTime));
        }

        if(_textToScroll.transform.localPosition.y > 3950f)
        {
            _textToScroll.transform.localPosition = startPosition;
        }
    }
}
