using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // x, 낮은 숫자일 수록 속도가 빠르다, 0.1 보다 0.5가 빠름
        transform.position += new Vector3(0.0f, 0.8f, 0.0f);
        // 푸드가 화면 밖을 나가면 없애기
        if(transform.position.y > 26.0f)
        {
            Destroy(gameObject);
        }
    }
}
