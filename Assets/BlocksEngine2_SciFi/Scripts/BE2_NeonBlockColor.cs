using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BE2_NeonBlockColor : MonoBehaviour
{
    RectTransform _parentRectTransform;
    RectTransform _rectTransform;

    void OnEnable()
    {
        _parentRectTransform = transform.parent.GetComponent<RectTransform>();
        _rectTransform = transform.GetComponent<RectTransform>();
    }

    void OnValidate()
    {
        transform.SetAsLastSibling();
    }

    //void Start()
    //{
    //
    //}

    void LateUpdate()
    {
        _rectTransform.sizeDelta = _parentRectTransform.sizeDelta;
    }
}
