using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stratBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �ܺο��� ������ ���� ��ų �� �ִ� �Լ�
    public void GameStart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
