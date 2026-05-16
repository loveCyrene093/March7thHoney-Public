namespace March7thHoney.Internationalization.Message;

public class GiveAllTextEN
{
	public string Desc => "Give the player all items of the specified type.\navatar means characters, equipment means Light Cones, relic means relics, unlock means chat bubbles, phone wallpapers, avatars, train means Trailblazer's room contents, pet means pets, path means Paths for multi-Path characters.";

	public string Usage => "Usage: /giveall avatar r<Eidolon> l<Level>\n\nUsage: /giveall equipment r<Superimposition> l<Level> x<Count>\n\nUsage: /giveall relic l<Level> x<Count>\n\nUsage: /giveall unlock\n\nUsage: /giveall train\n\nUsage: /giveall pet\n\nUsage: /giveall path";

	public string GiveAllItems => "Gave all {0}, {1} each";
}
