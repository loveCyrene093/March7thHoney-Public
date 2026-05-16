using System.Collections.Generic;

namespace March7thHoney.Data.Custom;

public class ChessRogueDiceSurfaceEffectConfig
{
	public int SurfaceId { get; set; }

	public List<ChessRogueDiceSurfaceContentEffect> ContentEffects { get; set; } = new List<ChessRogueDiceSurfaceContentEffect>();
}
