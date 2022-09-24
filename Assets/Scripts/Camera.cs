using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
   [SerializeField]
   private CarMovie _car;
   
   [SerializeField]
   private Vector3 _offset;
   private void Update()
   {
      transform.position = _car.transform.position + _offset;
   }
}
