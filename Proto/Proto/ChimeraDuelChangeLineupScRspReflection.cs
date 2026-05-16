using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelChangeLineupScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelChangeLineupScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJDaGltZXJhRHVlbENoYW5nZUxpbmV1cFNjUnNwLnByb3RvIkQKHENoaW1l" + "cmFEdWVsQ2hhbmdlTGluZXVwU2NSc3ASEwoLTUVLTElLTEdBRkkYByADKA0S" + "DwoHcmV0Y29kZRgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelChangeLineupScRsp), ChimeraDuelChangeLineupScRsp.Parser, new string[2] { "MEKLIKLGAFI", "Retcode" }, null, null, null, null)
		}));
	}
}
