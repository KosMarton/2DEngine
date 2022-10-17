using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hazel;

namespace Sandbox
{
	public class Camera : Entity
	{
		public Entity OtherEntity;

		public float DistanceFromPlayer = 5.0f;

		void OnCreate()
		{
			Translation = new Vector3(Translation.XY, DistanceFromPlayer);
		}
		void OnUpdate(float ts)
		{
			Entity player = FindEntityByName("Player");
			if (player != null)
			{
				Console.WriteLine("Player is not null!");
				Translation = new Vector3(player.Translation.XY, Translation.Z);
			}
			else
			{
				Console.WriteLine("Player is null!");
			}
			// Player player = FindEntityByName("Player").As<Player>();

			float speed = 1.0f;
			Vector3 velocity = Vector3.Zero;

			if (Input.IsKeyDown(KeyCode.Up))
				velocity.Y = 1.0f;
			else if (Input.IsKeyDown(KeyCode.Down))
				velocity.Y = -1.0f;

			if (Input.IsKeyDown(KeyCode.Left))
				velocity.X = -1.0f;
			else if (Input.IsKeyDown(KeyCode.Right))
				velocity.X = 1.0f;

			velocity *= speed;

			Vector3 translation = Translation;
			translation += velocity * ts;
			Translation = translation;
		}

	}
}
