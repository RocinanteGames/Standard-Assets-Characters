﻿using StandardAssets.Characters.FirstPerson;
using UnityEngine;

namespace StandardAssets.Characters.Examples.SimpleMovingPlatforms
{
	/// <summary>
	/// Initialize the moving platforms for a third person or first person player.
	/// </summary>
	public class MovingPlatformInitializer : MonoBehaviour
	{
		// Initialize the platforms. Check if a first person input is active in the scene.
		void Start()
		{
			InitializePlatforms(FindObjectOfType<FirstPersonInput>() != null);
		}
		
		/// <summary>
		/// Initialize the moving platforms for a third person or first person player.
		/// </summary>
		/// <param name="useFixedUpdate">Use FixedUpdate instead of Update. Set this to true if the player's movement
		/// is updated in FixedUpdate. So that the player and platform's movement are updated at the same rate, to
		/// prevent jerkiness.</param>
		public void InitializePlatforms(bool useFixedUpdate)
		{
			var controllers = FindObjectsOfType<MovingPlatformController>();
			if (controllers == null || controllers.Length <= 0)
			{
				return;
			}
			for (int i = 0, len = controllers.Length; i < len; i++)
			{
				var controller = controllers[i];
				if (controller != null)
				{
					controller.useFixedUpdate = useFixedUpdate;
				}
			}
		}
	}
}
