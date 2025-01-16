using UnityEngine;

namespace _Shooter._Scripts.Miscellaneous
{
    public class TextureScrolling : MonoBehaviour
    {
        public Vector2 scrollSpeed = new Vector2(0, 0.5f);

        private Material material;
        private Vector2 currentOffset;
        private Vector2 tempScrollSpedd = Vector2.zero;

        void Start()
        {
            // Get the material of the object's renderer
            Renderer renderer = GetComponent<Renderer>();
            material = renderer.material;
        }

        public void ToggleScroll(bool state) => tempScrollSpedd = state ? scrollSpeed : Vector2.zero;
        void Update()
        {
            if (material != null)
            {
                currentOffset += tempScrollSpedd * Time.deltaTime;
                material.mainTextureOffset = currentOffset;
            }
        }
    }
}