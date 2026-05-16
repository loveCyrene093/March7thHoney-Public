using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionCustomValueSnapshotListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionCustomValueSnapshotListReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiRNaXNzaW9uQ3VzdG9tVmFsdWVTbmFwc2hvdExpc3QucHJvdG8aIE1pc3Np";
		buffer[1] = "b25DdXN0b21WYWx1ZVNuYXBzaG90LnByb3RvIlgKHk1pc3Npb25DdXN0b21W";
		buffer[2] = "YWx1ZVNuYXBzaG90TGlzdBI2ChFjdXN0b21fdmFsdWVfbGlzdBgBIAMoCzIb";
		buffer[3] = "Lk1pc3Npb25DdXN0b21WYWx1ZVNuYXBzaG90QhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[4] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MissionCustomValueSnapshotReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MissionCustomValueSnapshotList), MissionCustomValueSnapshotList.Parser, new string[1] { "CustomValueList" }, null, null, null, null)
		}));
	}
}
