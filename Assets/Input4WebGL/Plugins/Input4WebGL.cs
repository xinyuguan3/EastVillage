using System;
using System.Runtime.InteropServices;

public static class Input4WebGL {

#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
	public static extern void InputShow (string GameObjectName,string v);
    [DllImport("__Internal")]
	public static extern void InputEnd ();
#else
    public static void InputShow(string GameObjectName,string v) { }
    public static void InputEnd() { }
#endif
}
