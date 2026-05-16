using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LocalLegendDataChangeNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LocalLegendDataChangeNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFMb2NhbExlZ2VuZERhdGFDaGFuZ2VOb3RpZnkucHJvdG8aEU1NUEpITEpI" + "TU5QLnByb3RvIj8KG0xvY2FsTGVnZW5kRGF0YUNoYW5nZU5vdGlmeRIgCgps" + "ZXZlbF9kYXRhGA4gASgLMgwuTU1QSkhMSkhNTlBCFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MMPJHLJHMNPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LocalLegendDataChangeNotify), LocalLegendDataChangeNotify.Parser, new string[1] { "LevelData" }, null, null, null, null)
		}));
	}
}
