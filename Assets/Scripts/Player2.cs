using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    GameObject go;
    GameObject pawn;
    GameObject shield;
    Vector3 position;
    float direction;
    // Start is called before the first frame update
    void Start()
    {
        go = gameObject;
        pawn = go.transform.Find("Pawn").gameObject;
        shield = pawn.transform.Find("Shield").gameObject;
        position = pawn.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal Player1") * 8.0f * Time.deltaTime;
        pawn.transform.localPosition = position;

        float x = Input.GetAxisRaw("Right Joystick X Player2");
        float y = Input.GetAxisRaw("Right Joystick Y Player2");
        if (!(Mathf.Abs(x * x + y * y) < 0.8f))
        {
            float angle = Mathf.Atan2(-y, x);
            Vector3 eularAngles = shield.transform.localEulerAngles;
            eularAngles.z = angle / Mathf.PI * 180;
            shield.transform.localEulerAngles = eularAngles;

        }
    }
}
