using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : BaseMonoBehaviour
{
    private static PlayerController _instance;

    private Camera _camera;

    private void Awake()
    {
        // �̹� �ν��Ͻ��� �ִ��� Ȯ���ϰ�, �ִٸ� �ڽ��� �ı�
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;

        _camera = Camera.main;

        // �� ������Ʈ�� �ı����� �ʵ��� ����
        DontDestroyOnLoad(gameObject);
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public event Action<Vector2> OnMoveEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
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
        transform.position = OverallManager.Instance.returnMoveMapInfo();
    }
}