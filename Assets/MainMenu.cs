using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : BaseSceme
{
    public Button botStartBtn;
    public Button pvpStartBtn;

    private void Start()
    {
        LeanTween.scale(botStartBtn.gameObject, new Vector3(1.7f, 1.7f, 1.7f), 0.5f).setEase(LeanTweenType.easeOutBounce).setOnComplete(()=> {
            ScaleBack();
        });
    }

    void ScaleBack()
    {
        LeanTween.scale(botStartBtn.gameObject, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeInBounce).setOnComplete(() => {
            Start();
        });
    }

    public override void Init()
    {

    }

    protected void OnStartButton()
    {

    }
}

