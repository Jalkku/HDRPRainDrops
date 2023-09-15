using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class WetnessChanger : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer m_RainDropMeshRenderer;
    private static readonly int Wetness = Shader.PropertyToID("_Wetness");

    void Update()
    {
        m_RainDropMeshRenderer.material.SetFloat(Wetness, Mathf.Abs(Mathf.Sin(Time.time * 0.1f)));
    }
}
