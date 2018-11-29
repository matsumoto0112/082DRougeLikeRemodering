using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Completed
{

    public class Attack : MonoBehaviour
    {

        [SerializeField]
        private float dieTime;
        // Use this for initialization
        void Start()
        {
            StartCoroutine(Die(dieTime));
        }

        // Update is called once per frame
        void Update()
        {

        }

        private IEnumerator Die(float dieTime)
        {
            yield return new WaitForSeconds(this.dieTime);
            Destroy(this.gameObject);
        }
    }
}
