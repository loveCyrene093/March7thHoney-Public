using System.Threading.Tasks;

namespace March7thHoney.GameServer.Game.Scene.Component;

public class RotatableRegionSceneComponent : BaseSceneComponent
{
	public RotatableRegionSceneComponent(SceneInstance scene)
		: base(scene)
	{
	}

	public override async ValueTask Initialize()
	{
		await ValueTask.CompletedTask;
	}
}
