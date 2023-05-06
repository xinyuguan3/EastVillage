using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConnectionGraph : MonoBehaviour
{
    public Node[] nodes;
    public GameObject nodePrefab;
    public LineRenderer[] lines;
    private void Start() {
        nodes=GetComponentsInChildren<Node>();
        foreach (Node n in nodes)
        {
            
            //Instantiate(nodePrefab, n.position, Quaternion.identity,this.gameObject.transform);
            //Debug.Log(this.gameObject);
        }
    }

    private void Update() {
        foreach (LineRenderer l in lines)
        {
            l.SetPosition(0, l.transform.position);
            l.SetPosition(1, l.transform.parent.position);
        }
    }

    
    
}
