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
        Invoke("TutorialText", 3);
        Invoke("Tuto", 7);
        Invoke("rial", 10);
        Invoke("Tutorial", 14);
        Invoke("rialText", 18);
        Invoke("Tutor", 21);
        Invoke("Turia", 24);
        Invoke("TutorialTex", 26);
    }

    void TutorialText()
    {
        //3�b��e�L�X�g�ύX
        textUI.text = "�������X�N���[������";
    }

    void Tuto()
    {
        //7�b��e�L�X�g�ύX
        textUI.text = "�����X�ɃJ�����[������̂�";
    }

    void rial()
    {
        //10�b��e�L�X�g�ύX
        textUI.text = "�񕜃A�C�e�����E����";
    }

    void Tutorial()
    {
        //14�b��e�L�X�g�ύX
        textUI.text = "�����̃A�C�e���͔����悤";
    }

    void rialText()
    {
        //18�b��e�L�X�g�ύX
        textUI.text = "�J�����[��0�ɂȂ�����";
    }

    void Tutor()
    {
        //21�b��e�L�X�g�ύX
        textUI.text = "�Q�[���I�[�o�[����";
    }

    void Turia()
    {
        //24�b��e�L�X�g�ύX
        textUI.text = "0�ɂȂ�Ȃ��悤��";
    }

    void TutorialTex()
    {
        //26�b��e�L�X�g�ύX
        textUI.text = "�S�[����ڎw�����I";
    }
}
