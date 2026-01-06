using System.Collections;
using UnityEngine;

public class CatInteraction : MonoBehaviour
{   
    // array to hold textures to show in sequence
    public Texture[] NewTextures;
    // the index of the current textures to show
    private int TextureIndex = 0;
    private IEnumerator coroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // define corutine 
        coroutine = WaitAndSwithImage(5.0f);
        StartCoroutine(coroutine);
    }
    public void UpdateMaterialTexture()
    {
        //get references to render
        Renderer renderer = GetComponent<Renderer>();
        if(renderer != null && NewTextures != null)
        {
            if(TextureIndex < NewTextures.Length - 1)
            { 
                TextureIndex++;
                // Debug.Log("TextureIndex = " + TextureIndex);
                renderer.material.mainTexture = NewTextures[TextureIndex];
                if(TextureIndex == NewTextures.Length - 1){
                    StopCoroutine(coroutine);   
                }
            }
        }
    }
    // create a timed function
    public IEnumerator WaitAndSwithImage(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            UpdateMaterialTexture();
        }
    }
    public void SetSelected()
    {
        Debug.Log("Cat Selected");
    }
}

