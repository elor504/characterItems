using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IteamSwap : MonoBehaviour
{
    public Image imagePrefab;

    List<Sprite> images = new List<Sprite>();

    public Sprite spriteTest;
    void Start()
    {
        images.Add(spriteTest);

        Image imageInstance = Instantiate(imagePrefab);


        imageInstance.transform.SetParent(imagePrefab.transform, true);

        imageInstance.sprite = images[0];
    }

    
    void Update()
    {
        
    }
}
