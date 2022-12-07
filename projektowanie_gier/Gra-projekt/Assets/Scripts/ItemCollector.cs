using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ItemCollector : MonoBehaviour
{   
    public static int globalbananas = 0;  
    public static int bananas = 0;  


    [SerializeField] public TextMeshProUGUI bananasText;


    [SerializeField] private AudioSource collectionSoundEffect;



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Banana"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            bananas++;
            bananasText.text = "Bananas: " + bananas;
        }
    }
}
