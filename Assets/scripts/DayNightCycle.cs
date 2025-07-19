using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    
    public Light sun;
    public float rotationSpeed = 1f;
    public Gradient lightColorOverTime;
    public AnimationCurve intensityOverTime;

    void Update()
    {
     
        sun.transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);

        float time = Mathf.InverseLerp(-90f,270f, sun.transform.eulerAngles.x);
        
        sun.color = lightColorOverTime.Evaluate(time);
        sun.intensity = intensityOverTime.Evaluate(time);

    }
}
