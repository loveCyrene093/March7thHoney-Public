using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetGrowthTargetAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetGrowthTargetAvatarScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiBTZXRHcm93dGhUYXJnZXRBdmF0YXJTY1JzcC5wcm90bxobR3Jvd3RoVGFy";
		buffer[1] = "dGdldEZ1bmNUeXBlLnByb3RvIokBChpTZXRHcm93dGhUYXJnZXRBdmF0YXJT";
		buffer[2] = "Y1JzcBIPCgdyZXRjb2RlGAUgASgNEhgKEGdyb3d0aF9hdmF0YXJfaWQYBiAB";
		buffer[3] = "KA0SKwoLREhBSUpMSkNKQUYYCiADKA4yFi5Hcm93dGhUYXJ0Z2V0RnVuY1R5";
		buffer[4] = "cGUSEwoLTU1PUENLTFBISU8YDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[5] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GrowthTartgetFuncTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetGrowthTargetAvatarScRsp), SetGrowthTargetAvatarScRsp.Parser, new string[4] { "Retcode", "GrowthAvatarId", "DHAIJLJCJAF", "MMOPCKLPHIO" }, null, null, null, null)
		}));
	}
}
