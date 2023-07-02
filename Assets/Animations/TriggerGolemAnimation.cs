using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGolemAnimation : MonoBehaviour
{
   [SerializeField] private Animator golemAnimator;

   public void TriggerAnimation()
   {
      golemAnimator.SetTrigger("Open");
   }
}
