using March7thHoney.Proto;

namespace March7thHoney.Database.Scene;

public class SceneMarkedChestData
{
	public int ConfigId { get; set; }

	public int GroupId { get; set; }

	public int FloorId { get; set; }

	public int PlaneId { get; set; }

	public MarkChestInfo ToProto()
	{
		return new MarkChestInfo
		{
			ConfigId = (uint)ConfigId,
			FloorId = (uint)FloorId,
			GroupId = (uint)GroupId,
			PlaneId = (uint)PlaneId
		};
	}
}
