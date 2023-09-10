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

    // 외부에서 게임을 시작 시킬 수 있는 함수
    public void GameStart()
    {
        SceneManager.LoadScene("MainScene");
    }
}
