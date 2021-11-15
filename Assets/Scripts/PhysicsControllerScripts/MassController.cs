using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MaterialType
{

    // Enum to Chose Material from (Inspector);
    public enum Material { Wood, Stone, Metal }

    // Assigns material to its allocated density 
    public static float GetDensity(Material material)
    {
        float denisty = 0;
        switch (material)
        {
            case (Material.Metal):
                denisty = 7900.0f;
                break;
            case (Material.Stone):
                denisty = 2700.0f;
                break;
            case (Material.Wood):
                denisty = 755.0f;
                break;
        }
        return denisty;
    }
}


[ExecuteInEditMode]
[RequireComponent(typeof(Rigidbody))]
public class MassController : MonoBehaviour
{
    // Choose Value in Inspector
    public MaterialType.Material material;
    public BodyType objShape;

    // Private Class Variables
    private Rigidbody _rb;
    private Vector3 size;
    private float volume, mass;

    // Enum to choose shape of Gameobject from
    public enum BodyType { Sphere, Cube, }

    // Initalisation and Updating ( also Executed in EditMode)
    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        AdjustValues();
    }

    void Update()
    {
        AdjustValues();
    }


    // Coordinates Class - Logik
    private void AdjustValues()
    {
        TransferScale();
        volume = GetVolume();
        mass = volume * MaterialType.GetDensity(material);
        _rb.mass = mass;
    }

    // Returns Volume - Outcome depends on size. 
    private float GetVolume()
    {
        float volume;
        switch (objShape)
        {
            case (BodyType.Cube):
                volume = size.x * size.y * size.z;
                break;
            case (BodyType.Sphere):
                volume = 4.0f / 3.0f * Mathf.PI * size.x * size.y * size.z;
                break;
            default:
                volume = 0f;
                Debug.Log("MassController.GetVolume(): Could not find given Object Shape");
                break;
        }
        return volume;
    }

    // Transfers Local Size to Global Size
    protected void TransferScale()
    {
        Vector3 scalingRelation = transform.localScale;
        Transform partenObj = transform.parent;

        while (partenObj != null)
        {
            scalingRelation.Set(scalingRelation.x * partenObj.localScale.x,
                                scalingRelation.y * partenObj.localScale.y,
                                scalingRelation.z * partenObj.localScale.z);
            partenObj = partenObj.parent;
            size = scalingRelation;
        }
    }
}

