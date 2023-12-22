using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

[ExecuteInEditMode]
public class GeradorMapa : MonoBehaviour
{
    [SerializeField] private SpriteShapeController spriteShapeControler;

    [SerializeField, Range(3f, 1000f)] private int levelLenght = 50;
    [SerializeField, Range(1f, 50f)] private float xMultiplier = 2f;
    [SerializeField, Range(1f, 50f)] private float yMultiplier = 2f;
    [SerializeField, Range(0f, 1f)] private float curveSmoothness = 0.5f;
    [SerializeField] private float noiseStep = 0.5f;
    [SerializeField] private float bottom = 10f;

    private Vector3 lastPos;

    private void OnValidate()
    {
        spriteShapeControler.spline.Clear();
        for (int i = 0; i < levelLenght; i++)
        {
            lastPos = transform.position + new Vector3(i * xMultiplier, Mathf.PerlinNoise(0, i * noiseStep) * yMultiplier);
            spriteShapeControler.spline.InsertPointAt(i, lastPos);

            if (i != 0 && i != levelLenght - 1)
            {
                spriteShapeControler.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
                spriteShapeControler.spline.SetLeftTangent(i, Vector3.left * xMultiplier * curveSmoothness);
                spriteShapeControler.spline.SetRightTangent(i, Vector3.right * xMultiplier * curveSmoothness);
            }
        }
        
        spriteShapeControler.spline.InsertPointAt(levelLenght, new Vector3(lastPos.x, transform.position.y - bottom));
        spriteShapeControler.spline.InsertPointAt( levelLenght + 1, new Vector3(transform.position.x, transform. position.y - bottom));
    }
}
