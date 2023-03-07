using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiamondDisplay : MonoBehaviour
{
   public TextMeshProUGUI diamondTmp;
   void Start()
   {
      GameDataManager.Instance.playerData.onChangeDiamond += i => OnChangeDiamond(i);
      diamondTmp.text = $"x{GameDataManager.Instance.playerData.intBullets}";
   }

   private void OnChangeDiamond(int i)
   {
      diamondTmp.text = $"x{i}";
   }
   void OnValidated()
   {
      diamondTmp = GetComponent<TextMeshProUGUI>();
   }
   
   void OnDestroy()
   {
      GameDataManager.Instance.playerData.onChangeDiamond -= i => OnChangeDiamond(i);
   }


}
