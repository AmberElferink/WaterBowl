using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MixLiquid : MonoBehaviour
{
    public float rotationMaxSpeed = 300.0f;
    public float rotationSpeed = 0.0f;
    public float maxSwirlEffect = 4;
    [Range(0, 1)]
    public float goToSwirl = 0;
    float transitionSwirl = 0;
    public string shaderNamePart = "SimpleWater";
    Material material;

    // Start is called before the first frame update
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        for (int i = 0; i < renderer.materials.Length; i++)
            if (renderer.materials[i].shader.name.Contains(shaderNamePart))
                material = renderer.materials[i];

    }
    float map(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    // Update is called once per frame
    void Update()
    {
        
        rotationSpeed = map(goToSwirl, 0, 1, 0, rotationMaxSpeed);
        transitionSwirl = map(goToSwirl, 0, 1, 0, maxSwirlEffect);
        this.gameObject.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.gameObject.transform.eulerAngles.y + rotationSpeed * Time.deltaTime, this.gameObject.transform.eulerAngles.z);
    }

    void OnGUI()
    {
        material.SetFloat(this.transitionSwirlShader, this.transitionSwirl);
        //transitionSwirl.Remap()
    }

    readonly int transitionSwirlShader = Shader.PropertyToID("_TransitionSwirl");

}

