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
        // x, ���� ������ ���� �ӵ��� ������, 0.1 ���� 0.5�� ����
        transform.position += new Vector3(0.0f, 0.8f, 0.0f);
        // Ǫ�尡 ȭ�� ���� ������ ���ֱ�
        if(transform.position.y > 26.0f)
        {
            Destroy(gameObject);
        }
    }
}
