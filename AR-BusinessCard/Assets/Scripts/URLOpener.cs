using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLOpener : MonoBehaviour
{
    public void openURL(string url) => Application.OpenURL(url);
}