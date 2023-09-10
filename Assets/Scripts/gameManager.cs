using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject dog;
    public GameObject food;
    public GameObject normalCat;
    public GameObject retryBtn;
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
        // �ݺ��� �Լ�, �ݺ��� ��ġ, ���ʸ��� �ݺ� �� ������
        InvokeRepeating("MakeFood", 0.0f, 0.1f);
        InvokeRepeating("MakeCat", 0.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MakeFood()
    {
        // ��� food�� ������ �����ϴ� �Լ� 
        float x = dog.transform.position.x;
        float y = dog.transform.position.y + 0.2f;
        // ���� ��ü, ���� ��ġ,  ��ü�� ȸ�� ǥ��
        Instantiate(food, new Vector3(x, y, 0), Quaternion.identity);
    }

    void MakeCat()
    {
        Instantiate(normalCat);
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
    }
}