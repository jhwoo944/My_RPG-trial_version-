using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : BaseMonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
