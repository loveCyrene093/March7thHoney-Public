using March7thHoney.Database.Inventory;
using March7thHoney.Database.Lineup;
using March7thHoney.Database.Player;

namespace March7thHoney.Database.Avatar;

public record PlayerDataCollection(PlayerData PlayerData, InventoryData InventoryData, LineupInfo LineupInfo);
