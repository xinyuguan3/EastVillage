using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Sirenix.OdinInspector;
using UnityEditor;

public class RecreateScene : MonoBehaviour
{
    private string[] data;
    //public GameObject aa;
    private string path="C:/Users/关新宇/EastVillage/Assets/MonoBehaviour";
    // Start is called before the first frame update
    void Start()
    {
        //Resources.LoadAll<JSON>()
        Load();
        
    }

    // string m_Path;

    // void Start()
    // {
    //     //Get the path of the Game data folder
    //     m_Path = Application.dataPath;

    //     //Output the Game data path to the console
    //     Debug.Log("dataPath : " + m_Path);
    // }
    [Button("Recreate")]
    void Load()
    {
        data=Directory.GetFiles(path);
        
        //EditorJsonUtility.FromJsonOverwrite(data[7],this);
        
        foreach(string q in data){
            Debug.Log(q);
            if (q.EndsWith(".meta")) continue;
            string json=File.ReadAllText(q);
            EditorJsonUtility.FromJsonOverwrite(q,this.gameObject);
            //Debug.Log(q);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
