using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestManager : BaseMonoBehaviour
{
    // ============================================[�鿪���� ������]=================================================

    private IOverallManager _overallManager;

    public IOverallManager OverallManager
    {
        get { return _overallManager; }
    }

    public void Init(IOverallManager overallManager)
    {
        _overallManager = overallManager;
    }

    // ============================================[�迪���� ������]=================================================

    // ============================================[���׽�Ʈ�� �޼��� ������]=================================================


    // �ð� ������ ���� ����
    float originalTimeScale;

    // Start is called before the first frame update
    void Start()
    {
        originalTimeScale = Time.timeScale; // �ʱ� �ð� ������ ����
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // 1�� �Է��ϸ� �ð� ������
            Time.timeScale += 2f;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // 2�� �Է��ϸ� �ð� ������
            Time.timeScale -= 2f;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // 3�� �Է��ϸ� �ð� �ʱ�ȭ
            Time.timeScale = originalTimeScale;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            // 4�� �Է��ϸ� �ð� ���� / �簳
            Time.timeScale = Time.timeScale == 0 ? originalTimeScale : 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            // 5�� �Է��ϸ� �������� ����� �α׷� ǥ��
            LogDebugInformation();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            // 6�� �Է��ϸ� ���� ��
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            // 7�� �Է��ϸ� ���� ��
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            // 8�� �Է��ϸ� �� �ʱ�ȭ
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        // 9�� 0�� ����
    }

    void LogDebugInformation()
    {
        // ���⿡ ����� �α׷� ǥ���� �������� �߰�
        Debug.Log("Debug Information");
    }

    // ============================================[���׽�Ʈ�� �޼��� ������]=================================================
}