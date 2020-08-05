using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller_terrain : MonoBehaviour
{
    public float speed;
    TextMesh t;
    //public Text countText1;
    public Text palin;
    public Text countText;
    private int count;
    private Rigidbody rb;
    private AudioSource source;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
        count = 0;
        SetCountText();
        //countText1.text ="";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        t = GameObject.Find("Pick Up").GetComponentInChildren<TextMesh>();
        string palString = t.text;

        bool flg = areParanthesisBalanced(palString);


        if (flg.Equals(true) && other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            palin.text = "eaten palindrom:" + count.ToString();
            SetCountText();
            source.Play();


        }
    }
    void SetCountText()
    {
        countText.text = "Count Text: " + count.ToString();

        if (count >= 10)
        {

            //countText1.text = "Three palindfromes are collected:" +count.ToString();
            countText.text = "collected ";
        }

    }




}
}
