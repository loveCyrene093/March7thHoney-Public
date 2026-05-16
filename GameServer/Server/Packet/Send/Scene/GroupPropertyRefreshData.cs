namespace March7thHoney.GameServer.Server.Packet.Send.Scene;

public record GroupPropertyRefreshData(int GroupId, string PropertyName, int OldValue, int NewValue);
