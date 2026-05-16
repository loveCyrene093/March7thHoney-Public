using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum SceneGroupRefreshType
{
	[OriginalName("SCENE_GROUP_REFRESH_TYPE_NONE")]
	None,
	[OriginalName("SCENE_GROUP_REFRESH_TYPE_LOADED")]
	Loaded,
	[OriginalName("SCENE_GROUP_REFRESH_TYPE_UNLOAD")]
	Unload,
	[OriginalName("SCENE_GROUP_REFRESH_TYPE_AFIBFMAFNCC")]
	Afibfmafncc
}
