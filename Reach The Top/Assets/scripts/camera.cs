using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
    public Transform target;
  private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = offset + target.position;
    }
}
//reference http://jingyan.baidu.com/album/ed2a5d1f6851a809f6be17a8.html?picindex=11