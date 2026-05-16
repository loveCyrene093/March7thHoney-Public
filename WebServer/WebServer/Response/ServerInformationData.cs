using System.Collections.Generic;
using March7thHoney.WebServer.Server;

namespace March7thHoney.WebServer.Response;

public class ServerInformationData
{
	public List<SimplePlayerInformationData> OnlinePlayers { get; set; } = new List<SimplePlayerInformationData>();

	public long ServerTime { get; set; }

	public float MaxMemory { get; set; }

	public float UsedMemory { get; set; }

	public float ProgramUsedMemory { get; set; }

	public float CpuUsage { get; set; } = MuipManager.GetCpuUsage();

	public string CpuModel { get; set; } = MuipManager.GetCpuDetails().ModelName;

	public int CpuCores { get; set; } = MuipManager.GetCpuDetails().Cores;

	public float CpuFrequency { get; set; } = MuipManager.GetCpuDetails().Frequency;

	public string SystemVersion { get; set; } = MuipManager.GetSystemVersion();
}
