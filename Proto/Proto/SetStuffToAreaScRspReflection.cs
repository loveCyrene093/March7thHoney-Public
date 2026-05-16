using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetStuffToAreaScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetStuffToAreaScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChlTZXRTdHVmZlRvQXJlYVNjUnNwLnByb3RvGhFKRkZPTklEUE5EQS5wcm90";
		buffer[1] = "byJrChNTZXRTdHVmZlRvQXJlYVNjUnNwEg8KB3JldGNvZGUYASABKA0SEwoL";
		buffer[2] = "UEVHRUxOSEdNSkEYAiABKA0SEwoLR0tGRUdJQkdFR0kYBSABKA0SGQoDcG9z";
		buffer[3] = "GAggASgOMgwuSkZGT05JRFBOREFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JFFONIDPNDAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetStuffToAreaScRsp), SetStuffToAreaScRsp.Parser, new string[4] { "Retcode", "PEGELNHGMJA", "GKFEGIBGEGI", "Pos" }, null, null, null, null)
		}));
	}
}
