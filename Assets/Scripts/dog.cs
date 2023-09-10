using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //강아지의 움직임을 마우스로 설정하기 
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float x = mousePos.x;
        if (x > 8.5f)
        {
            x = 8.5f;
        }
        if (x < -8.5f)
        {
            x = -8.5f;
        }
        transform.position = new Vector3(x, transform.position.y, 0);
    }
}
