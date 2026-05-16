using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFriendTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFriendTypeReflection()
	{
		_003C_003Ey__InlineArray45<string> buffer = default(_003C_003Ey__InlineArray45<string>);
		buffer[0] = "ChNDbWRGcmllbmRUeXBlLnByb3RvKogPCg1DbWRGcmllbmRUeXBlEhsKF0dF";
		buffer[1] = "R0hJRUhORUVQX1BDUERIRUxQS0VNEAASIwoeQ21kR2V0RnJpZW5kQXBwbHlM";
		buffer[2] = "aXN0SW5mb1NjUnNwEOYWEiAKG0NtZFN5bmNIYW5kbGVGcmllbmRTY05vdGlm";
		buffer[3] = "eRDVFhIiCh1DbWRHZXRQbGF0Zm9ybVBsYXllckluZm9TY1JzcBCFFxInCiJD";
		buffer[4] = "bWRHZXRGcmllbmRSZWNvbW1lbmRMaXN0SW5mb1NjUnNwEJEXEisKJkNtZEdl";
		buffer[5] = "dEZyaWVuZFJlY29tbWVuZExpbmV1cERldGFpbENzUmVxEIgXEhoKFUNtZEdl";
		buffer[6] = "dEFzc2lzdExpc3RDc1JlcRDwFhIdChhDbWRUYWtlQXNzaXN0UmV3YXJkU2NS";
		buffer[7] = "c3AQ6BYSEwoOQ21kQUJOTEtJRERJT0sQuBcSGQoUQ21kRGVsZXRlRnJpZW5k";
		buffer[8] = "Q3NSZXEQnhcSGgoVQ21kR2V0QXNzaXN0TGlzdFNjUnNwEJUXEhkKFENtZFJl";
		buffer[9] = "cG9ydFBsYXllckNzUmVxEIAXEiAKG0NtZEdldFBsYXllckRldGFpbEluZm9D";
		buffer[10] = "c1JlcRCyFxIlCiBDbWRHZXRGcmllbmREZXZlbG9wbWVudEluZm9Dc1JlcRCh";
		buffer[11] = "FxIjCh5DbWRHZXRGcmllbmRBcHBseUxpc3RJbmZvQ3NSZXEQ4hYSJQogQ21k";
		buffer[12] = "R2V0RnJpZW5kUmVjb21tZW5kTGluZXVwU2NSc3AQrBcSGQoUQ21kR2V0Q3Vy";
		buffer[13] = "QXNzaXN0U2NSc3AQ5RYSGgoVQ21kU2V0RnJpZW5kTWFya0NzUmVxEJsXEiIK";
		buffer[14] = "HUNtZEdldFBsYXRmb3JtUGxheWVySW5mb0NzUmVxENYWEhkKFENtZEFkZEJs";
		buffer[15] = "YWNrbGlzdENzUmVxEPoWEiUKIENtZEdldEZyaWVuZFJlY29tbWVuZExpbmV1";
		buffer[16] = "cENzUmVxENoWEh8KGkNtZEdldEZyaWVuZExvZ2luSW5mb0NzUmVxEJYXEiAK";
		buffer[17] = "G0NtZFNldEZyaWVuZFJlbWFya05hbWVDc1JlcRDbFhIeChlDbWRDdXJBc3Np";
		buffer[18] = "c3RDaGFuZ2VkTm90aWZ5ELEXEh4KGUNtZEdldEZyaWVuZExpc3RJbmZvQ3NS";
		buffer[19] = "ZXEQrxcSHQoYQ21kR2V0QXNzaXN0SGlzdG9yeVNjUnNwEO0WEiAKG0NtZFN5";
		buffer[20] = "bmNEZWxldGVGcmllbmRTY05vdGlmeRDYFhIoCiNDbWRHZXRGcmllbmRCYXR0";
		buffer[21] = "bGVSZWNvcmREZXRhaWxTY1JzcBDgFhIgChtDbWRTeW5jQWRkQmxhY2tsaXN0";
		buffer[22] = "U2NOb3RpZnkQ9BYSGgoVQ21kU2V0RnJpZW5kTWFya1NjUnNwEPgWEh0KGENt";
		buffer[23] = "ZFRha2VBc3Npc3RSZXdhcmRDc1JlcRCjFxIZChRDbWREZWxldGVGcmllbmRT";
		buffer[24] = "Y1JzcBD5FhIYChNDbWRBcHBseUZyaWVuZFNjUnNwELYXEhkKFENtZFNlYXJj";
		buffer[25] = "aFBsYXllckNzUmVxEI0XEhYKEUNtZFNldEFzc2lzdENzUmVxEJ0XEh8KGkNt";
		buffer[26] = "ZFN5bmNBcHBseUZyaWVuZFNjTm90aWZ5EJMXEiAKG0NtZEdldEZyaWVuZEFz";
		buffer[27] = "c2lzdExpc3RDc1JlcRDXFhIZChRDbWRIYW5kbGVGcmllbmRTY1JzcBD7FhIc";
		buffer[28] = "ChdDbWREZWxldGVCbGFja2xpc3RTY1JzcBC0FxIoCiNDbWRHZXRGcmllbmRC";
		buffer[29] = "YXR0bGVSZWNvcmREZXRhaWxDc1JlcRDxFhIgChtDbWRHZXRGcmllbmRBc3Np";
		buffer[30] = "c3RMaXN0U2NSc3AQsBcSHAoXQ21kRGVsZXRlQmxhY2tsaXN0Q3NSZXEQrRcS";
		buffer[31] = "GAoTQ21kQXBwbHlGcmllbmRDc1JlcRDdFhIrCiZDbWRHZXRGcmllbmRSZWNv";
		buffer[32] = "bW1lbmRMaW5ldXBEZXRhaWxTY1JzcBCuFxIlCiBDbWRTZXRBbGxvd090aGVy";
		buffer[33] = "QXBwbHlGcmllbmRDc1JlcRDfFhIZChRDbWRIYW5kbGVGcmllbmRDc1JlcRDu";
		buffer[34] = "FhIZChRDbWRHZXRDdXJBc3Npc3RDc1JlcRDcFhIeChlDbWRHZXRGcmllbmRM";
		buffer[35] = "aXN0SW5mb1NjUnNwEN4WEiAKG0NtZFNldEZyaWVuZFJlbWFya05hbWVTY1Jz";
		buffer[36] = "cBCOFxIdChhDbWRHZXRBc3Npc3RIaXN0b3J5Q3NSZXEQhxcSJgohQ21kU2V0";
		buffer[37] = "Rm9yYmlkT3RoZXJBcHBseUZyaWVuZFNjUnNwEPIWEiAKG0NtZEdldFBsYXll";
		buffer[38] = "ckRldGFpbEluZm9TY1JzcBCzFxIlCiBDbWRHZXRGcmllbmREZXZlbG9wbWVu";
		buffer[39] = "dEluZm9TY1JzcBDkFhIZChRDbWRBZGRCbGFja2xpc3RTY1JzcBCcFxInCiJD";
		buffer[40] = "bWRHZXRGcmllbmRSZWNvbW1lbmRMaXN0SW5mb0NzUmVxEPUWEh8KGkNtZEdl";
		buffer[41] = "dEZyaWVuZExvZ2luSW5mb1NjUnNwENkWEhYKEUNtZFNldEFzc2lzdFNjUnNw";
		buffer[42] = "EIkXEhkKFENtZFNlYXJjaFBsYXllclNjUnNwEOkWEh4KGUNtZE5ld0Fzc2lz";
		buffer[43] = "dEhpc3RvcnlOb3RpZnkQihdCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[44] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFriendType) }, null, null));
	}
}
