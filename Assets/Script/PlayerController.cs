using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    private int count;

    public Text countText;
    public Text winText;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        Counttext();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveH, 0.0f, moveV);

        rb.AddForce(move * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            other.gameObject.SetActive(false);
            count++;
            Counttext();
        }
    }

    private void Counttext()
    {
        countText.text = "Score: " + count.ToString();
        if (count >= 18)
            winText.text = "You Win!";
    }
}
