using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title_Ui_Controller : BaseMonoBehaviour
{
    public Image select_1;
    public Image select_2;
    public Image select_3;

    //�̺�Ʈ�� ��������Ʈ ����
    public delegate void IsTargetedChanged();
    public static event IsTargetedChanged OnIsTargetedChanged;

    private int isTargeted;
    public int _isTargeted
    {
        get { return isTargeted; }
        set
        {
            if (isTargeted != value)
            {
                isTargeted = value;
                OnIsTargetedChanged?.Invoke(); // isTargeted�� ����Ǹ� �κ�ũ
            }
        }
    }

    void Start()
    {
        // �̺�Ʈ ����
        OnIsTargetedChanged += HandleIsTargetedChanged;
        _isTargeted = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //���콺 ������ Ž��
        if (IsMouseOver(select_1)) _isTargeted = 0;
        else if (IsMouseOver(select_2)) _isTargeted = 1;
        else if (IsMouseOver(select_3)) _isTargeted = 2;

        //����Ű�� ����Ŭ�� ����
        if (Input.GetMouseButtonDown(0))
        {
            //���콺�� �̹��� ���� ���� ���
            if (IsMouseOverAnyImage())
            {
                HandleSelection();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            HandleSelection();
        }

        //Ű���� ����Ű �Է� ����
        HandleKeyboardInput();



    }

    //���콺�� � �̹��� ���� �ö� �ִ��� Ž��
    bool IsMouseOverAnyImage()
    {
        return IsMouseOver(select_1) || IsMouseOver(select_2) || IsMouseOver(select_3);
    }



    // Ÿ�� ����� �̹��� ���� ����
    void HandleIsTargetedChanged()
    {
        // Change image transparency based on isTargeted value
        switch (isTargeted)
        {
            case 0:
                SetImageTransparency(select_1, 225);
                SetImageTransparency(select_2, 121);
                SetImageTransparency(select_3, 121);
                break;
            case 1:
                SetImageTransparency(select_2, 225);
                SetImageTransparency(select_1, 121);
                SetImageTransparency(select_3, 121);
                break;
            case 2:
                SetImageTransparency(select_3, 225);
                SetImageTransparency(select_1, 121);
                SetImageTransparency(select_2, 121);
                break;
        }
    }

    //�̹��� ������ ���� �����ϴ� �޼���
    void SetImageTransparency(Image image, byte alpha)
    {
        Color color = image.color;
        color.a = alpha / 255f;
        image.color = color;
    }

    // ���콺�� �̹��� ���� �ö� �ִ��� �����Ѵ�
    bool IsMouseOver(Image image)
    {
        RectTransform rectTransform = image.GetComponent<RectTransform>();
        Vector2 localMousePosition = rectTransform.InverseTransformPoint(Input.mousePosition);
        return rectTransform.rect.Contains(localMousePosition);
    }

    //Ű���� ����Ű �Է½� ���� �̹��� ����
    void HandleKeyboardInput()
    {
        // Handle arrow key input
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            _isTargeted = (isTargeted + 1) % 3;
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow))
            _isTargeted = (isTargeted + 2) % 3;
    }

    // �̹��� �����ϰ� ��Ŭ���̳� ���� �� ȣ��Ǵ� �޼���. 1=Ʃ�丮��� �̵� 2=�̾��ϱ�(�̱���) 3=��������
    void HandleSelection()
    {
        switch (isTargeted)
        {
            case 0:
                UnityEngine.SceneManagement.SceneManager.LoadScene("2_Tutorial_Room");
                break;
            case 2:
                // Quit the game
                Application.Quit();
                break;
            // case 1: // isTargeted = 1�� �̱���
            default:
                break;
        }
    }
}