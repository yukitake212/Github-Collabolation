using UnityEngine;

public class Falling_dish : MonoBehaviour
{
    public GameObject[] dishes = new GameObject[3];
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dishes[Random.Range(0,3)], this.transform.position, this.transform.rotation);
        }
    }
}
