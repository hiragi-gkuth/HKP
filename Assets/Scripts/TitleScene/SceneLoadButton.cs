using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 名前からシーンロード。ButtonにつけてOnClickにOnClickButton()を設定。

public class SceneLoadButton : MonoBehaviour
{
    #region field
    public string targetSceneName;
    #endregion
    #region func

    public void OnClickButton()
    {
        SceneManager.LoadScene(targetSceneName);
    }
    #endregion

}