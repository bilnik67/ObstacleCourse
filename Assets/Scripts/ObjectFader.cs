using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFader : MonoBehaviour
{
    [SerializeField] private float fadeSpeed, fadeAmount;
    float originalOpacity;
    Material mat;
    public bool isFading = false;


    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        originalOpacity = mat.color.a;

        // mats = GetComponent<Renderer>().materials;
        // foreach (Material mat in mats)
        // {
        // }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFading)
        {
            FadeObj();
        }
        else{
            ResetFade();
        }
        
    }

    // Fade object
    void FadeObj()
    {
        // foreach (Material mat in mats) 
        // {
            Debug.Log("obj is fading");
            Color currentColor = mat.color;
            Color smoothColor = new Color(currentColor.r, currentColor.g, currentColor.b, 
                Mathf.Lerp(currentColor.a, fadeAmount, fadeSpeed * Time.deltaTime));
            mat.color = smoothColor;
        // }
        
    }
    // Reset fade of Object
    void ResetFade()
    {
        // foreach (Material mat in mats) {
            Color currentColor = mat.color;
            Color smoothColor = new Color(currentColor.r, currentColor.g, currentColor.b, 
                Mathf.Lerp(currentColor.a, originalOpacity, fadeSpeed * Time.deltaTime));
            mat.color = smoothColor;
        // }
    }
}
