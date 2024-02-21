using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Public_Variable : BaseMonoBehaviour
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

    // ============================================[����� ���� ������]=================================================


    // ���� ������ ���õ� ����
    public int initialPlayerHealth = 100;
    public float playerMoveSpeed = 5.0f;
    public Color playerDefaultColor = Color.white;

    // ���ҽ� ������ ���� ����
    public GameObject[] enemyPrefabs;
    public AudioClip[] soundEffects;

    // ���� ���¿� ���õ� ����
    public bool isGamePaused = false;
    public int currentScore = 0;

    // �÷��̾� ������ ���¸� �����ϴ� ����
    public string playerName = "Player1";
    public Vector3 playerStartPosition = new Vector3(0, 0, 0);
    public bool isPlayerAlive = true;

    // �����۰� �κ��丮 ���� ����
    public int playerGold = 0;
    public List<GameObject> playerInventory = new List<GameObject>();
    public int maxInventorySize = 20;


    // ȭ�� �� UI ���� ����
    public bool showHUD = true;
    public Color uiThemeColor = Color.blue;
    public int screenResolutionWidth = 1920;
    public int screenResolutionHeight = 1080;

    // ���� �� ����ġ ����
    public int playerLevel = 1;
    public int experiencePoints = 0;
    public int experienceToNextLevel = 100;

    // �پ��� ���� ���� ���õ� ����
    public bool isTutorialMode = false;
    public bool isMultiplayer = false;
    public int numberOfPlayers = 1;

    // �ð��� �̺�Ʈ ���� ����
    public float gameTimeElapsed = 0.0f;
    public bool isNightTime = false;

    // ��Ÿ ���� ���� ����
    public bool useSound = true;
    public int difficultyLevel = 2;
    public bool enableDebugMode = false;

    // ============================================[����� ���� ������]=================================================
}
