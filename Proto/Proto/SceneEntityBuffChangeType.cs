using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum SceneEntityBuffChangeType
{
	[OriginalName("SCENE_ENTITY_BUFF_CHANGE_TYPE_DEFAULT")]
	Default,
	[OriginalName("SCENE_ENTITY_BUFF_CHANGE_TYPE_ADD_MAZEBUFF")]
	AddMazebuff,
	[OriginalName("SCENE_ENTITY_BUFF_CHANGE_TYPE_ADD_ADV_MODIFIER")]
	AddAdvModifier
}
