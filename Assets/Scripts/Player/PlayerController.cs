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
        // 이미 인스턴스가 있는지 확인하고, 있다면 자신을 파괴
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;

        _camera = Camera.main;

        // 이 오브젝트를 파괴되지 않도록 설정
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
        // 씬 로드 후에 호출되는 이벤트에 대한 리스너 추가
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // 리스너 제거
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // 씬이 로드된 후에 호출되는 콜백
        // 이동할 좌표를 OverallManager.Instance.returnMoveMapInfo()로 설정
        transform.position = OverallManager.Instance.returnMoveMapInfo();
    }
}