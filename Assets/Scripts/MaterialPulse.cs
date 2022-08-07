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

    private Vector3 originalPos = new Vector3();

    private void Awake()
    {
        mainCamera = Camera.main;
        originalPos = mainCamera.transform.position;
    }

    private void FixedUpdate()
    {
        SetMaterialPos(mainCamera.transform.position);
    }

    private void SetMaterialPos(Vector3 pos)
    {
        foreach (Material environmentMaterial in environmentMaterials)
        {
            environmentMaterial.SetVector("_PlayerPos", pos);
        }
    }

    private void OnApplicationQuit()
    {
        SetMaterialPos(originalPos);
    }

    private void OnDestroy()
    {
        SetMaterialPos(originalPos);
    }
}