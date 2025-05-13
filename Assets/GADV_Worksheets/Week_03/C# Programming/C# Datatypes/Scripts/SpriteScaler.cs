using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
namespace ProjectNamespace1
{
    public class SpriteScaler : MonoBehaviour
    {
        private Transform spriteTransform;
        private string scale = "2.0";
        
        void Start()
        {
            float scalenum = float.Parse(scale);
            spriteTransform = GetComponent<Transform>();
            spriteTransform.localScale = new Vector3(scalenum, scalenum, 1f);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
