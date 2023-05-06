using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node: MonoBehaviour{
        public Vector3 position;
        public List<Node> neighbors;
        public Sprite image;
        public string name;

        private void Awake() {
            position=this.gameObject.transform.position;

        }
    }
