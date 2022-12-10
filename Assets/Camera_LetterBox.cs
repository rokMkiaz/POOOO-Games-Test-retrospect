using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_LetterBox : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
        SetResolution();

        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
   

        float scaleheight = ((float)Screen.width / Screen.height) / (9.0f / 16.0f);
        float scalewidth = 1f / scaleheight;

        if (scalewidth < 1)
        {
            rect.width = scalewidth;
            rect.x = (1f - scalewidth) / 2f;
  
        }
        else
        {
            rect.height = scaleheight;
            rect.y = (1f - scaleheight) / 2f;
        }
        camera.rect = rect;
    }

    void OnPreCull() => GL.Clear(true, true, Color.black);


   
    /* �ػ� �����ϴ� �Լ� */
    public void SetResolution()
    {
        int setWidth = 1440; // ����� ���� �ʺ�
        int setHeight = 2560; // ����� ���� ����

        int deviceWidth = Screen.width; // ��� �ʺ� ����
        int deviceHeight = Screen.height; // ��� ���� ����

        Screen.SetResolution(setWidth, (int)(((float)deviceHeight / deviceWidth) * setWidth), true); // SetResolution �Լ� ����� ����ϱ�

        if ((float)setWidth / setHeight < (float)deviceWidth / deviceHeight) // ����� �ػ� �� �� ū ���
        {
            float newWidth = ((float)setWidth / setHeight) / ((float)deviceWidth / deviceHeight); // ���ο� �ʺ�
            Camera.main.rect = new Rect((1f - newWidth) / 2f, 0f, newWidth, 1f); // ���ο� Rect ����
        }
        else // ������ �ػ� �� �� ū ���
        {
            float newHeight = ((float)deviceWidth / deviceHeight) / ((float)setWidth / setHeight); // ���ο� ����
            Camera.main.rect = new Rect(0f, (1f - newHeight) / 2f, 1f, newHeight); // ���ο� Rect ����
        }
    }

}
