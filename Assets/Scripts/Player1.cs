using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    GameObject go;
    GameObject pawn;
    Vector3 position;
    

    private void OnEnable() {
        go = gameObject;
        pawn = go.transform.Find("Pawn").gameObject;
        position = pawn.transform.localPosition;
    }


    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal Player1") * 8.0f * Time.deltaTime;
        pawn.transform.localPosition = position;
    }
}
