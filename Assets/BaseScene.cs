using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseSceme : MonoBehaviour
{
    public Button settingBtn;
    public Button muteBtn;

    SoundManager soundManager;
    StorageManager StorageManager;

    public virtual void Init() { }

    public virtual void Show() { }

    public virtual void Exit() { }
}
