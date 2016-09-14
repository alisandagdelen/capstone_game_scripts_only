using UnityEngine;
using System.Collections;

namespace alisanCapstone
{
	public class Item_Tag : MonoBehaviour {

        public string itemTag;

		void OnEnable()
		{
            SetTag();
		}

        void SetTag()
        {
            if (itemTag == "")
            {
                itemTag = "Untagged";
            }

            transform.tag = itemTag;
        }
	}
}


