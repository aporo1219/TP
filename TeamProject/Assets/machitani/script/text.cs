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
        //3�b��e�L�X�g�ύX
        textUI.text = "�������X�N���[������";
    }

    void Ho()
    {
        //7�b��e�L�X�g�ύX
        textUI.text = "�����X�ɃJ�����[������̂�";
    }

    void og()
    {
        //10�b��e�L�X�g�ύX
        textUI.text = "�񕜃A�C�e�����E����";
    }

    void Hog()
    {
        //14�b��e�L�X�g�ύX
        textUI.text = "�����̃A�C�e���͔����悤";
    }

    void ge()
    {
        //18�b��e�L�X�g�ύX
        textUI.text = "�J�����[��0�ɂȂ�����";
    }

    void oge()
    {
        //21�b��e�L�X�g�ύX
        textUI.text = "�Q�[���I�[�o�[����";
    }

    void machi()
    {
        //24�b��e�L�X�g�ύX
        textUI.text = "0�ɂȂ�Ȃ��悤��";
    }

    void gema()
    {
        //26�b��e�L�X�g�ύX
        textUI.text = "�S�[����ڎw�����I";
    }
}
