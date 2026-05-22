using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetNicknameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetNicknameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZTZXROaWNrbmFtZVNjUnNwLnByb3RvIkgKEFNldE5pY2tuYW1lU2NSc3AS" + "DwoHcmV0Y29kZRgBIAEoDRIQCghzZXRfdGltZRgFIAEoAxIRCglpc19tb2Rp" + "ZnkYDCABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetNicknameScRsp), SetNicknameScRsp.Parser, new string[3] { "Retcode", "SetTime", "IsModify" }, null, null, null, null)
		}));
	}
}
