using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BasicModuleSyncReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BasicModuleSyncReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVCYXNpY01vZHVsZVN5bmMucHJvdG8iNwoPQmFzaWNNb2R1bGVTeW5jEhMK" + "C0xQTEVCSktERUlDGAsgASgNEg8KB3N0YW1pbmEYDSABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BasicModuleSync), BasicModuleSync.Parser, new string[2] { "LPLEBJKDEIC", "Stamina" }, null, null, null, null)
		}));
	}
}
