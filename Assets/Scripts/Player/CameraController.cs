using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraController : BaseMonoBehaviour
{
    private static CameraController _instance;

    private void Awake()
    {
        // �̹� �ν��Ͻ��� �ִ��� Ȯ���ϰ�, �ִٸ� �ڽ��� �ı�
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;

        // �� ������Ʈ�� �ı����� �ʵ��� ����
        DontDestroyOnLoad(gameObject);
    }



    public float cameraSpeed = 5.0f;

    public GameObject player;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        Vector3 dir = player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime, 0.0f);
        this.transform.Translate(moveVector);
    }

    private void OnEnable()
    {
        // �� �ε� �Ŀ� ȣ��Ǵ� �̺�Ʈ�� ���� ������ �߰�
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // ������ ����
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // ���� �ε�� �Ŀ� ȣ��Ǵ� �ݹ�
        // �̵��� ��ǥ�� OverallManager.Instance.returnMoveMapInfo()�� ����
        Vector3 position = OverallManager.Instance.returnMoveMapInfo();
        position.z = -1;
        transform.position = position;
    }
}
