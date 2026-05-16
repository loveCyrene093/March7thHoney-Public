using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMapRotationTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMapRotationTypeReflection()
	{
		InlineArray14<string> buffer = default(InlineArray14<string>);
		buffer[0] = "ChhDbWRNYXBSb3RhdGlvblR5cGUucHJvdG8qqwQKEkNtZE1hcFJvdGF0aW9u";
		buffer[1] = "VHlwZRIbChdCQ0xQUEdPS0dHQ19QQ1BESEVMUEtFTRAAEhMKDkNtZFBMSUVE";
		buffer[2] = "SlBQQ1BGEJo1Eh8KGkNtZEdldE1hcFJvdGF0aW9uRGF0YUNzUmVxELc1EhMK";
		buffer[3] = "DkNtZERIS0dERk5CS0REENg1EhoKFUNtZFJlbW92ZVJvdGF0b3JDc1JlcRCw";
		buffer[4] = "NRITCg5DbWRCSEtKQUZHSE1JRBCxNRIjCh5DbWRSZXNldE1hcFJvdGF0aW9u";
		buffer[5] = "UmVnaW9uQ3NSZXEQ2jUSEwoOQ21kR0RGUEVOTE9PRkwQlDUSFgoRQ21kUm90";
		buffer[6] = "YXRlTWFwQ3NSZXEQmTUSEwoOQ21kSkRMRExHSlBORU8QtTUSEwoOQ21kSUJG";
		buffer[7] = "QU5HTEhNRUEQ8jUSIwoeQ21kTGVhdmVNYXBSb3RhdGlvblJlZ2lvbkNzUmVx";
		buffer[8] = "EM81EhMKDkNtZEpNR01PQUNQQ0NIEKI1EhMKDkNtZEdBRUpCTUNGQk1KEO81";
		buffer[9] = "EhMKDkNtZE9NUElDSEhKREtPELY1EiMKHkNtZEVudGVyTWFwUm90YXRpb25S";
		buffer[10] = "ZWdpb25Dc1JlcRDrNRIaChVDbWREZXBsb3lSb3RhdG9yQ3NSZXEQnjUSEwoO";
		buffer[11] = "Q21kR09LRExMQURFTEIQzTUSHAoXQ21kSW50ZXJhY3RDaGFyZ2VyQ3NSZXEQ";
		buffer[12] = "7jUSEwoOQ21kQ0VNSkpDTk1DQkkQqjUSEwoOQ21kSk1NQ0JEQUdFS1AQkTVC";
		buffer[13] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMapRotationType) }, null, null));
	}
}
