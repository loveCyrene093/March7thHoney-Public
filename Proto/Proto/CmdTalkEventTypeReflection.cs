using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdTalkEventTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdTalkEventTypeReflection()
	{
		InlineArray13<string> buffer = default(InlineArray13<string>);
		buffer[0] = "ChZDbWRUYWxrRXZlbnRUeXBlLnByb3RvKosEChBDbWRUYWxrRXZlbnRUeXBl";
		buffer[1] = "EhsKF0tQREZFTVBLTUFEX0NDSU5MQUFDREFMEAASLAonQ21kRmluaXNoRmly";
		buffer[2] = "c3RUYWxrQnlQZXJmb3JtYW5jZU5wY0NzUmVxEP4QEh8KGkNtZEZpbmlzaEZp";
		buffer[3] = "cnN0VGFsa05wY1NjUnNwEJYREhMKDkNtZEtCRUVKT0VIT05PEPMQEh8KGkNt";
		buffer[4] = "ZEdldFRhbGtFdmVudFJld2FyZENzUmVxEJIREhwKF0NtZEdldEZpcnN0VGFs";
		buffer[5] = "a05wY0NzUmVxEMIQEhMKDkNtZENIS05JS1BFUEFNEM4QEh8KGkNtZEZpbmlz";
		buffer[6] = "aEZpcnN0VGFsa05wY0NzUmVxEL0QEiwKJ0NtZEZpbmlzaEZpcnN0VGFsa0J5";
		buffer[7] = "UGVyZm9ybWFuY2VOcGNTY1JzcBDZEBIeChlDbWRHZXROcGNUYWtlblJld2Fy";
		buffer[8] = "ZFNjUnNwEL4QEhsKFkNtZFRha2VUYWxrUmV3YXJkU2NSc3AQkxESIgodQ21k";
		buffer[9] = "R2V0UmVjZWl2ZWRUYWxrRXZlbnRzQ3NSZXEQjxESKQokQ21kR2V0Rmlyc3RU";
		buffer[10] = "YWxrQnlQZXJmb3JtYW5jZU5wY0NzUmVxENsQEhwKF0NtZEdldEZpcnN0VGFs";
		buffer[11] = "a05wY1NjUnNwEMYQEikKJENtZEdldEZpcnN0VGFsa0J5UGVyZm9ybWFuY2VO";
		buffer[12] = "cGNTY1JzcBC1EEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdTalkEventType) }, null, null));
	}
}
