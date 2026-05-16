using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DiceCombatFinishPveStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DiceCombatFinishPveStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNEaWNlQ29tYmF0RmluaXNoUHZlU3RhZ2VDc1JlcS5wcm90byJpCh1EaWNl" + "Q29tYmF0RmluaXNoUHZlU3RhZ2VDc1JlcRITCgtNTUxLRkpJQUtLSBgCIAEo" + "DRIOCgZpc193aW4YBSABKAgSDgoGZGFtYWdlGAcgASgNEhMKC0JJT0RBSkxM" + "SU5PGAogASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DiceCombatFinishPveStageCsReq), DiceCombatFinishPveStageCsReq.Parser, new string[4] { "MMLKFJIAKKH", "IsWin", "Damage", "BIODAJLLINO" }, null, null, null, null)
		}));
	}
}
