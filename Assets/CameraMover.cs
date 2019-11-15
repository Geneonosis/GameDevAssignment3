using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] public int speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Screen.width);
        if (Input.mousePosition.x <= 20 || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
        }
        if (Input.mousePosition.x >= Screen.width - 20 || Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
        }
        if (Input.mousePosition.y <= 20 || Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * speed, Space.World);
        }
        if (Input.mousePosition.y >= Screen.height - 20 || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
        }
    }
}
