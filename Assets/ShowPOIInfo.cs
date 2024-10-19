using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPOIInfo : MonoBehaviour
{
    public Button imageButton;

    void Start()
    {
        // Add a listener to call the OnClick function when the image is clicked
        imageButton.onClick.AddListener(OnImageClick);
    }

    // Function to handle the image click
    void OnImageClick()
    {
        Debug.Log("Image clicked!");
    }
}
