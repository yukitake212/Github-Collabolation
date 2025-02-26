using UnityEngine;

public class sliding : MonoBehaviour
{
    public int speed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed* Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed*(-1)* Time.deltaTime, 0, 0);
        }
    }
}
