using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialCalorie : MonoBehaviour
{
    public Slider calobar;
    public GameObject calo0text;
    public int calo = 100;
    public int decrease;
    private float currentTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        calobar = GameObject.Find("calobar").GetComponent<Slider>();
        calobar.maxValue = calo;

        calobar.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= 1.0f)
        {
            //5�������Ă���
            calobar.value -= decrease;
            currentTime = 0;
        }
        //�J�����[��0�ɂȂ�����
        if (calobar.value == 0)
        {
            //�e�L�X�g��\��
            calo0text.SetActive(true);
        }
    }
}
