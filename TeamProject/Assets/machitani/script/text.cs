using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public Text textUI;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Hoge", 3);
        Invoke("Ho", 7);
        Invoke("og", 10);
        Invoke("Hog", 14);
        Invoke("ge", 18);
        Invoke("oge", 21);
        Invoke("machi", 24);
        Invoke("gema", 26);
    }

    void Hoge()
    {
        textUI.text = "�������X�N���[������";
    }

    void Ho()
    {
        textUI.text = "�����X�ɃJ�����[������̂�";
    }

    void og()
    {
        textUI.text = "�񕜃A�C�e�����E����";
    }

    void Hog()
    {
        textUI.text = "�����̃A�C�e���͔����悤";
    }

    void ge()
    {
        textUI.text = "�J�����[��0�ɂȂ�����";
    }

    void oge()
    {
        textUI.text = "�Q�[���I�[�o�[����";
    }

    void machi()
    {
        textUI.text = "0�ɂȂ�Ȃ��悤��";
    }

    void gema()
    {
        textUI.text = "�S�[����ڎw�����I";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
