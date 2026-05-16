using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRogueModifierTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRogueModifierTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChpDbWRSb2d1ZU1vZGlmaWVyVHlwZS5wcm90byqJAgoUQ21kUm9ndWVNb2Rp";
		buffer[1] = "ZmllclR5cGUSGwoXTEtPS05ITExPTUZfUENQREhFTFBLRU0QABIhChxDbWRS";
		buffer[2] = "b2d1ZU1vZGlmaWVyVXBkYXRlTm90aWZ5EJYqEh4KGUNtZFJvZ3VlTW9kaWZp";
		buffer[3] = "ZXJBZGROb3RpZnkQkioSJAofQ21kUm9ndWVNb2RpZmllclNlbGVjdENlbGxT";
		buffer[4] = "Y1JzcBDCKRIeChlDbWRSb2d1ZU1vZGlmaWVyRGVsTm90aWZ5EPMpEiQKH0Nt";
		buffer[5] = "ZFJvZ3VlTW9kaWZpZXJTZWxlY3RDZWxsQ3NSZXEQkyoSJQogQ21kUm9ndWVN";
		buffer[6] = "b2RpZmllclN0YWdlU3RhcnROb3RpZnkQzilCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[7] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueModifierType) }, null, null));
	}
}
