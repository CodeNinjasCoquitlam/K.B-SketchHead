using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlatforms : MonoBehaviour
{
  private void OnBecameInvisible()
    {
        GameController.MovePlatformToTop(gameObject);
    }


























}
