using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AGEDPIBJPGLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AGEDPIBJPGLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBR0VEUElCSlBHTC5wcm90byJgCgtBR0VEUElCSlBHTBISCgptb25zdGVy" + "X2lkGAEgASgNEhMKC0lCRkJHRUZMT0pLGAIgASgNEhMKC0ZIT0xCSkdPUEdJ" + "GAMgASgNEhMKC0RMSExQTkxJQkFGGAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AGEDPIBJPGL), AGEDPIBJPGL.Parser, new string[4] { "MonsterId", "IBFBGEFLOJK", "FHOLBJGOPGI", "DLHLPNLIBAF" }, null, null, null, null)
		}));
	}
}
