using UnityEngine;

public class SunMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Rotate(0.1f,0,0);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.Rotate(-0.1f,0,0);
        }
       // transform.Rotate(0.1f,0,0);
    }
}
