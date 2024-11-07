using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenu : MonoBehaviour
{
    [SerializeField]
    GameObject buttonMenu;
    [SerializeField]
    GameObject canvasMenu;
    [SerializeField]
    GameObject buttonMenuImage;
    [SerializeField]
    GameObject buttonObjectImage;
    [SerializeField]
    GameObject buttonObjects;
    [SerializeField]
    float posbuttonObjects;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickMenuButton()
    {
        LeanTween.moveLocalY(buttonMenu, -160f, 1f);
        LeanTween.scale(buttonMenu, Vector3.one * 0.5f, 0.9f);
        LeanTween.moveLocalY(canvasMenu, 143f, 0.95f);
        buttonMenuImage.SetActive (false);
    }

    public void ClickAñadirButton()
    {
        LeanTween.moveLocalX(buttonObjectImage, 400f, 1f);
        LeanTween.moveLocalX(canvasMenu, -50f, 0.9f);
        LeanTween.scaleX(canvasMenu, 0.85f, 0.55f);
        LeanTween.moveLocalX(buttonMenu, -50f, 0.9f);
    }

    public void ClickUpButton()
    {

        

        if (posbuttonObjects==0)
        {
            posbuttonObjects = 400;
            
        }
        else
        {
            posbuttonObjects += 400;
            LeanTween.moveLocalY(buttonObjects, posbuttonObjects, 1f);
        }
    }

    public void ClickDownButton()
    {
        posbuttonObjects -= 400;
        LeanTween.moveLocalY(buttonObjects, posbuttonObjects, 1f);
    }
}
