using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlaMouse : MonoBehaviour
{
    [SerializeField]
    private float velocHor = 1f, velociVer = 1f;

    private float rotX = 0f, rotY = 0f;
    private Camera cabeca;

    // Start is called before the first frame update
    void Start()
    {
        cabeca = Camera.main;
        
        
    }

    // Update is called once per frame
    void Update()
    {

        float mx = Input.GetAxis("Mouse X") * velocHor;
        float my = Input.GetAxis("Mouse Y") * velociVer;

        rotX -= my;
        rotY += mx;
        //Limitar o movimento 
        rotX = Mathf.Clamp(rotX, -60, 90);

        cabeca.transform.eulerAngles = new Vector3(rotX, rotY, 0);
        transform.eulerAngles = new Vector3(0, rotY, 0);
    }
}
