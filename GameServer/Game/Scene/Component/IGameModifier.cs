using System.Collections.Generic;
using System.Threading.Tasks;

namespace March7thHoney.GameServer.Game.Scene.Component;

public interface IGameModifier
{
	List<string> Modifiers { get; set; }

	ValueTask AddModifier(string modifierName);

	ValueTask RemoveModifier(string modifierName);
}
