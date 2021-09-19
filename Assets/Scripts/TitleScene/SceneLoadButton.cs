using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// ���O����V�[�����[�h�BButton�ɂ���OnClick��OnClickButton()��ݒ�B

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