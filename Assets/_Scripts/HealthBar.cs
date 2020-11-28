using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HealthBar : MonoBehaviour
{
    public float value;
    float maxValue;
    public Transform bar;
    public Transform entity;
    void Start()
    {
        maxValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (entity != null)
        {
            transform.position = entity.position + Vector3.up;
        }
    }


    public void SetValue(float new_value)
    {
        value = new_value;
        bar.localScale = new Vector3(value/maxValue,1,1);
        //clamps localscale.x
        if(bar.localScale.x < 0)
        {
            bar.localScale = new Vector3(0, 1, 1);
        }
    }
}
