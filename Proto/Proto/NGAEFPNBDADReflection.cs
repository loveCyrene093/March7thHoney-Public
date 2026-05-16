using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NGAEFPNBDADReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NGAEFPNBDADReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFOR0FFRlBOQkRBRC5wcm90byrMAgoLTkdBRUZQTkJEQUQSGwoXTkdBRUZQ";
		buffer[1] = "TkJEQURfUENQREhFTFBLRU0QABIbChdOR0FFRlBOQkRBRF9LT0FKUFBMQkVD";
		buffer[2] = "SBABEhsKF05HQUVGUE5CREFEX0JDQVBCRklPSERDEAISGwoXTkdBRUZQTkJE";
		buffer[3] = "QURfT0lDQU9KSkJHSU4QAxIbChdOR0FFRlBOQkRBRF9HREFISFBJSk5IRhAE";
		buffer[4] = "EhsKF05HQUVGUE5CREFEX05IT0ZERk5NSkRNEAUSGwoXTkdBRUZQTkJEQURf";
		buffer[5] = "SUtKTE1IR0xKTk4QBhIbChdOR0FFRlBOQkRBRF9CRkVLQUpOTEZHRBAHEhsK";
		buffer[6] = "F05HQUVGUE5CREFEX0hPS0xFSUtJQUtJEAgSGwoXTkdBRUZQTkJEQURfRURO";
		buffer[7] = "RklCR01OQ0YQCRIbChdOR0FFRlBOQkRBRF9DUEpBRkdIRUtHSBAKQhaqAhNN";
		buffer[8] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NGAEFPNBDAD) }, null, null));
	}
}
