using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Xenu.Game {

	public class UnityOutlineManager : MonoBehaviour {
		[System.Serializable]
		public class OutlineData
		{
			public Renderer renderer;
		}

		public UnityOutlineFX outlinePostEffect;
		public OutlineData[] outliners;

		private void Start()
		{
			foreach (var obj in outliners)
			{
				outlinePostEffect.AddRenderers(new List<Renderer>() { obj.renderer });
			}
		}
	}

}