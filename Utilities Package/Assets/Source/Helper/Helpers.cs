using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helpers : MonoBehaviour
{
    public static void SetXPos(Transform tr, float xValue)
    {
        var position = tr.position;
        var newPos = new Vector3(xValue, position.y, position.z);
        tr.position = newPos;
    }
    
    public static void SetYPos(Transform tr, float yValue)
    {
        var position = tr.position;
        var newPos = new Vector3(position.x, yValue, position.z);
        tr.position = newPos;
    }
    
    public static void SetZPos(Transform tr, float zValue)
    {
        var position = tr.position;
        var newPos = new Vector3(position.x, position.y, zValue);
        tr.position = newPos;
    }

   

    public static void SetGlobalLocalScale(RectTransform canvas, float value)
    {
        canvas.localScale = new Vector3(value,value,value);
    }
    
    public static void SetXLocalScale(RectTransform canvas, float value)
    {
        var scale = canvas.localScale;
        var newScale = new Vector3(value, scale.y, scale.z);
        canvas.localScale = newScale;
    }
    
    public static void SetYLocalScale(RectTransform canvas, float value)
    {
        var scale = canvas.localScale;
        var newScale = new Vector3(scale.x, value, scale.z);
        canvas.localScale = newScale;
    }
    
    public static void SetZLocalScale(RectTransform canvas, float value)
    {
        var scale = canvas.localScale;
        var newScale = new Vector3(scale.x, scale.y, value);
        canvas.localScale = newScale;
    }
    #region Canvas

    public static void SetWidth(RectTransform canvas, float value)
    {
        var canvasSizeDelta = canvas.sizeDelta;
        canvasSizeDelta.x = value;
        canvas.sizeDelta = canvasSizeDelta;
    }
    
    public static void SetHeight(RectTransform canvas, float value)
    {
        var canvasSizeDelta = canvas.sizeDelta;
        canvasSizeDelta.y = value;
        canvas.sizeDelta = canvasSizeDelta;
    }
    
    #endregion
}
