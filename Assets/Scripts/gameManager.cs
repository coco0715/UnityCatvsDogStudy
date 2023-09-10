using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject dog;
    public GameObject food;
    public GameObject normalCat;
    public GameObject fatCat;
    public GameObject retryBtn;
    public Text levelText;
    public GameObject levelFront;
    public static gameManager I;

    int level = 0;
    int cat = 0;

    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // 반복할 함수, 반복할 위치, 몇초마다 반복 할 것인지
        InvokeRepeating("MakeFood", 0.0f, 0.1f);
        InvokeRepeating("MakeCat", 0.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MakeFood()
    {
        // 어떻게 food를 만들지 설명하는 함수 
        float x = dog.transform.position.x;
        float y = dog.transform.position.y + 0.2f;
        // 만들 객체, 만들 위치,  물체의 회전 표현
        Instantiate(food, new Vector3(x, y, 0), Quaternion.identity);
    }

    void MakeCat()
    {
        Instantiate(normalCat);
        if (level == 1)
        {
            float p = Random.Range(0, 10);
            if (p < 2) Instantiate(normalCat);
        }
        else if (level == 2)
        {
            float p = Random.Range(0, 10);
            if (p < 5) Instantiate(normalCat);
        }
        else if (level >= 3)
        {
            float p = Random.Range(0, 10);
            if (p < 6) Instantiate(normalCat);
            Instantiate(fatCat);
        }
    }

    public void GameOver()
    {
        retryBtn.SetActive(true);
        Time.timeScale = 0f;
    }

    public void AddCat()
    {
        cat += 1;
        level = cat / 5;

        levelText.text = level.ToString();
        levelFront.transform.localScale = new Vector3((cat - level * 5) / 5.0f, 1.0f, 1.0f);
    }
}
