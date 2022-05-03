using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerspeed = 100f;
    [SerializeField] float carspeed = 100f;
    [SerializeField] TextMeshProUGUI textMeshPro;
    [SerializeField] int boxCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float carVert = Input.GetAxis("Vertical") * carspeed * Time.deltaTime;
        float steerAxis = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAxis);
        transform.Translate(0,carVert,0);
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch! " + collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Box")
        {
            Destroy(collision.gameObject);
            boxCount++;
            textMeshPro.text = "Box Count:" + boxCount;
        }
       if(collision.tag == "FinishArea")
        {
            if(boxCount >= 6)
            {
                textMeshPro.text = "YOU WIN";
            }
        }
    }
}
