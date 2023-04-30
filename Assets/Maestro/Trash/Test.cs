using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIManaging;

public class Test : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            ScreenManager.Instance.ScreenChange(this.gameObject, ChangeDirection.left, 0.5f);
        }
    }
}
