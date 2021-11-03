using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class controlePersonagem : MonoBehaviour
{

    [SerializeField]
    private float velocidade = 1f, gravidade = -9.81f;

    private CharacterController CC;
    private float velocidadeQueda = 0f;


    // Start is called before the first frame update
    void Start()
    {
        CC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * velocidade;
        float dz = Input.GetAxis("Vertical") * velocidade;
        CC.Move((transform.right * dx + transform.forward * dz) * Time.deltaTime);
        if (CC.isGrounded && velocidadeQueda < 0)
        {
            velocidadeQueda = 0;
        }
        else
        {
            velocidadeQueda += gravidade * Time.deltaTime;
            CC.Move(new Vector3(0, velocidadeQueda * Time.deltaTime / 2f, 0));
        }

    }
}
