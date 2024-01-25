using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestManager : MonoBehaviour
{
  public static TestManager Instance;

  // ========================================

  private void Awake()
  {
    Instance = this;
  }

  // ========================================

  public Text DebugText;
  public void UpdateDebugText(string input, string output)
  {
    DebugText.text = $"Input\t[{input}]\nOutput\t[{output}]";
    return;
  }

}