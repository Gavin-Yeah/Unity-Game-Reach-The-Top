using UnityEngine;
using System.Collections;

public class fly : MonoBehaviour {
    float x;
    Vector3 flytran;
    int num = 0;
    // Use this for initialization
    void Start () {

    
}
	
	// Update is called once per frame
	void Update () {
        flytran = GetComponent<Transform>().position;
      
        
        if(num>=0)
        {
            transform.position += (Vector3.left /20);
            num++;
            if (num == 104)
            {
                num = num - 209;
            }
        }
        if (num<0){
            transform.position += (Vector3.right /20);
            num++;
        }
       
	}
}
