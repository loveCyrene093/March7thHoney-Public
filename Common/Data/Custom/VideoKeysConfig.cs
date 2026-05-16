using System.Collections.Generic;

namespace March7thHoney.Data.Custom;

public class VideoKeysConfig
{
	public List<ActivityVideoKeyInfoList> ActivityVideoKeyData { get; set; } = new List<ActivityVideoKeyInfoList>();

	public List<VideoKeyInfoList> VideoKeyInfoData { get; set; } = new List<VideoKeyInfoList>();

	public int TotalCount => ActivityVideoKeyData.Count + VideoKeyInfoData.Count;
}
