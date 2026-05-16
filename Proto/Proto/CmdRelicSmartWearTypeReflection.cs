using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRelicSmartWearTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRelicSmartWearTypeReflection()
	{
		InlineArray16<string> buffer = default(InlineArray16<string>);
		buffer[0] = "ChtDbWRSZWxpY1NtYXJ0V2VhclR5cGUucHJvdG8qigUKFUNtZFJlbGljU21h";
		buffer[1] = "cnRXZWFyVHlwZRIbChdCTEZNQ0ZNSkpFRV9QQ1BESEVMUEtFTRAAEiIKHUNt";
		buffer[2] = "ZFJlbGljU21hcnRXZWFyQWRkUGxhblNjUnNwEMRAEiUKIENtZFJlbGljU21h";
		buffer[3] = "cnRXZWFyRGVsZXRlUGxhblNjUnNwEMtAEiUKIENtZFJlbGljU21hcnRXZWFy";
		buffer[4] = "RGVsZXRlUGxhbkNzUmVxEMhAEikKJENtZFJlbGljU21hcnRXZWFyVXBkYXRl";
		buffer[5] = "UGluUmVsaWNTY1JzcBC/QBIpCiRDbWRSZWxpY1NtYXJ0V2VhclVwZGF0ZVBp";
		buffer[6] = "blJlbGljQ3NSZXEQx0ASKQokQ21kUmVsaWNTbWFydFdlYXJEZWxldGVQaW5S";
		buffer[7] = "ZWxpY0NzUmVxEMZAEiYKIUNtZFJlbGljU21hcnRXZWFyR2V0UGluUmVsaWNT";
		buffer[8] = "Y1JzcBDMQBIlCiBDbWRSZWxpY1NtYXJ0V2VhclVwZGF0ZVBsYW5Dc1JlcRDJ";
		buffer[9] = "QBIlCiBDbWRSZWxpY1NtYXJ0V2VhclVwZGF0ZVBsYW5TY1JzcBDCQBIsCidD";
		buffer[10] = "bWRSZWxpY1NtYXJ0V2VhclVwZGF0ZVBpblJlbGljU2NOb3RpZnkQvkASIgod";
		buffer[11] = "Q21kUmVsaWNTbWFydFdlYXJBZGRQbGFuQ3NSZXEQvEASIgodQ21kUmVsaWNT";
		buffer[12] = "bWFydFdlYXJHZXRQbGFuU2NSc3AQzkASKQokQ21kUmVsaWNTbWFydFdlYXJE";
		buffer[13] = "ZWxldGVQaW5SZWxpY1NjUnNwEMBAEiYKIUNtZFJlbGljU21hcnRXZWFyR2V0";
		buffer[14] = "UGluUmVsaWNDc1JlcRDFQBIiCh1DbWRSZWxpY1NtYXJ0V2VhckdldFBsYW5D";
		buffer[15] = "c1JlcRC7QEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRelicSmartWearType) }, null, null));
	}
}
