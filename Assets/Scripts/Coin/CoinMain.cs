using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Coin
{

    public class CoinMain : MonoBehaviour
    {

        void Start()
        {

        }

        void Update()
        {
            float rotation = Time.deltaTime * 100;

            transform.Rotate(rotation, 0, 0); //omg so annoying

        }

    }
}