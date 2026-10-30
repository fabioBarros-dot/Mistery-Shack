using UnityEngine;

public class Movimentaçãodetetive : MonoBehaviour
{
    int speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0 && Input.GetAxis("Vertical") == 0)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if(Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Vertical") == 0)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") == 0)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else if(Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") == 0)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}
