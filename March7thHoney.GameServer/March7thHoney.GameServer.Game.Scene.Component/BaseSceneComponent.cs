using System.Threading.Tasks;

namespace March7thHoney.GameServer.Game.Scene.Component;

public abstract class BaseSceneComponent
{
	public SceneInstance SceneInst { get; }

	protected BaseSceneComponent(SceneInstance scene)
	{
		SceneInst = scene;
		base._002Ector();
	}

	public abstract ValueTask Initialize();
}
