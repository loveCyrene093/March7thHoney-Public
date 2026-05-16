using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum ReloginType
{
	[OriginalName("NO_KICK")]
	NoKick,
	[OriginalName("FORCE_KICK")]
	ForceKick,
	[OriginalName("IDLE_KICK")]
	IdleKick,
	[OriginalName("SILENCE")]
	Silence
}
