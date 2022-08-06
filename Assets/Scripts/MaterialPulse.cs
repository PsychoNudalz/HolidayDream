using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPulse : MonoBehaviour
{
    [SerializeField]
    Camera mainCamera;

    [SerializeField]
    private Material[] environmentMaterials;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void FixedUpdate()
    {
        foreach (Material environmentMaterial in environmentMaterials)
        {
            environmentMaterial.SetVector("_PlayerPos", mainCamera.transform.position);
        }
    }
}