using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
[RequireComponent(typeof(InputField))]
public class InputMark_WebGL : MonoBehaviour {
#if UNITY_WEBGL && !UNITY_EDITOR  //只在WebGl下生效
    public InputField inputField = null;
    void Start () {
        inputField = GetComponent<InputField>();
        //添加unity输入框回调
        inputField.onValueChanged.AddListener(OnValueChanged);
        //添加获得焦点回调
        EventTrigger trigger = inputField.gameObject.GetComponent<EventTrigger>();
        if (null == trigger)
            trigger = inputField.gameObject.AddComponent<EventTrigger>();
        EventTrigger.Entry e = new EventTrigger.Entry();
        e.eventID = EventTriggerType.PointerDown;
        e.callback.AddListener((data) => { OnFocus((PointerEventData)data); });
        trigger.triggers.Add(e);
    }
    #region ugui回调
    private void OnValueChanged(string arg0)
    {
        //暂时没用
    }
    private void OnFocus(PointerEventData pointerEventData)
    {
        WebGLInput.captureAllKeyboardInput = false;
        Input4WebGL.InputShow(gameObject.name, inputField.text);
    }
    #endregion

    #region WebGL回调
    public void OnInputText(string text)
    {
        inputField.text = text;
        inputField.caretPosition = inputField.text.Length;
    }
    public void OnInputEnd()
    {
        WebGLInput.captureAllKeyboardInput = true;
    }
    
    #endregion
#endif
}
