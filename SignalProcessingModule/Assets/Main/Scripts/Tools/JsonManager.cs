/// <summary>
/// Copyright (c) 2023 MirzkisD1Ex0 All rights reserved.
/// Code Version 1.0
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ToneTuneToolkit.Data
{
  public class JsonManager : MonoBehaviour
  {
    /// <summary>
    /// 配置文件获取器
    /// json被读取时必须被序列化过
    /// </summary>
    /// <param name="url">路径</param>
    /// <param name="keyName">字段名</param>
    public static string GetJsonAsString(string url, string keyName)
    {
      if (!File.Exists(url))
      {
        Debug.Log($"[JsonManager] Cant find [<color=red>{url}</color>]...[Er]");
        return null;
      }
      string json = File.ReadAllText(url, Encoding.UTF8);
      Dictionary<string, string> keys = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
      if (!keys.ContainsKey(keyName))
      {
        return null;
      }
      return keys[keyName];
    }

    public static int GetJsonAsInt(string url, string keyName)
    {
      if (!File.Exists(url))
      {
        Debug.Log($"[JsonManager] Cant find [<color=red>{url}</color>]...[Er]");
        return 0;
      }
      string json = File.ReadAllText(url, Encoding.UTF8);
      Dictionary<string, int> keys = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
      if (!keys.ContainsKey(keyName))
      {
        return 0;
      }
      return keys[keyName];
    }

    // ========================================

    /// <summary>
    /// 配置写入
    /// </summary>
    /// <param name="url">文件路径</param>
    /// <param name="keyName">字段名</param>
    /// <param name="content">写入内容</param>
    /// <returns></returns>
    public static bool SetJsonAsString(string url, string keyName, string content)
    {
      if (!File.Exists(url))
      {
        Debug.Log($"[JsonManager] Cant find [<color=red>{url}</color>]...[Er]");
        return false;
      }
      string json = File.ReadAllText(url, Encoding.UTF8);
      Dictionary<string, string> keys = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
      keys[keyName] = content;
      json = JsonConvert.SerializeObject(keys);
      File.WriteAllText(url, json, Encoding.UTF8);
      return true;
    }

    public static bool SetJsonAsInt(string url, string keyName, int content)
    {
      if (!File.Exists(url))
      {
        Debug.Log($"[JsonManager] Cant find [<color=red>{url}</color>]...[Er]");
        return false;
      }
      string json = File.ReadAllText(url, Encoding.UTF8);
      Dictionary<string, int> keys = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
      keys[keyName] = content;
      json = JsonConvert.SerializeObject(keys);
      File.WriteAllText(url, json, Encoding.UTF8);
      return true;
    }
  }
}