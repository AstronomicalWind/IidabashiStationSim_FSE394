using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitching : MonoBehaviour
{
// *** Attach to Manager obj for UI Button's OnClick
public void FSE394SceneChangeToTop()
{
SceneManager.LoadScene("TitleScreen");
}
public void FSE394SceneChange()
{
SceneManager.LoadScene("Main");

}
public void FSE394SceneChangeToResult()
{
SceneManager.LoadScene("Result");
Time.timeScale=0;
}
}
