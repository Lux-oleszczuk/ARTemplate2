using UnityEngine;

public class etSelectedState : MonoBehaviour
{   
    public Material SelectedMaterial;
    private Material originalMaterial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get a reference to orginal prefab material
        originalMaterial = gameObject.GetComponent<MeshRenderer>().material;
    }
    public void SetSelected()
    {
        gameObject.GetComponent<MeshRenderer>().material = SelectedMaterial;
    }
    public void SetUnselected()
    {
        gameObject.GetComponent<MeshRenderer>().material = SelectedMaterial;
    }
}
