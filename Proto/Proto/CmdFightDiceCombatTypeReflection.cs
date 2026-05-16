using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFightDiceCombatTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFightDiceCombatTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDbWRGaWdodERpY2VDb21iYXRUeXBlLnByb3RvKjUKFkNtZEZpZ2h0RGlj" + "ZUNvbWJhdFR5cGUSGwoXTU9JSkZNRUdPR0NfUENQREhFTFBLRU0QAEIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFightDiceCombatType) }, null, null));
	}
}
