using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject evolution;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.name == collision.gameObject.name)
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<NewMonoBehaviourScript >().evolution = null;
            if(evolution)
            {
                Instantiate(evolution, this.transform.position, this.transform.rotation);
            }
            
        }
    }
}
