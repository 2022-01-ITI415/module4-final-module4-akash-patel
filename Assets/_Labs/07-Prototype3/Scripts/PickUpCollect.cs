using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpCollect : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    void Start()
    {
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 60)
        {
            winTextObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
    }
}
