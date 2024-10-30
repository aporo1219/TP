using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMove : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed = -1;
    Vector3 cameraRectMin;
    // Start is called before the first frame update
    void Start()
    {
        cameraRectMin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);   //X�������ɃX�N���[��
        //�J�����̍��[���犮�S�ɏo����A�E�[�ɏu�Ԉړ�
        if (transform.position.x < (cameraRectMin.x - Camera.main.transform.position.x) * 2)
        {
            transform.position = new Vector2((Camera.main.transform.position.x - cameraRectMin.x) * 2, transform.position.y);
        }
    }
}