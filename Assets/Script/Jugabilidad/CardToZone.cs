using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardToZone : MonoBehaviour
{
    public GameObject Zone;
    public GameObject It;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Zone = GameObject.Find("Zone");
        It.transform.SetParent(Zone.transform);
        It.transform.localScale = new Vector3(0.8f , 0.8f , 0.8f);
        It.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        It.transform.eulerAngles = new Vector3(0, 0, 0);

        
        
       
    }



}
