using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdAetherDivideTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdAetherDivideTypeReflection()
	{
		_003C_003Ey__InlineArray33<string> buffer = default(_003C_003Ey__InlineArray33<string>);
		buffer[0] = "ChlDbWRBZXRoZXJEaXZpZGVUeXBlLnByb3RvKuMKChNDbWRBZXRoZXJEaXZp";
		buffer[1] = "ZGVUeXBlEhsKF0ZJQkdOQktHSE5GX1BDUERIRUxQS0VNEAASHQoYQ21kVGFr";
		buffer[2] = "ZU9mZlNraWxsQ29yZVNjUnNwENAlEioKJUNtZENsZWFyQWV0aGVyRGl2aWRl";
		buffer[3] = "UGFzc2l2ZVNraWxsQ3NSZXEQ8iUSKQokQ21kU3dpdGNoQWV0aGVyRGl2aWRl";
		buffer[4] = "TGluZVVwU2xvdFNjUnNwENUlEhMKDkNtZE5QQk5QT0tHTkNJENslEikKJENt";
		buffer[5] = "ZFN0YXJ0QWV0aGVyRGl2aWRlU3RhZ2VCYXR0bGVTY1JzcBDPJRIsCidDbWRB";
		buffer[6] = "ZXRoZXJEaXZpZGVUYWtlQ2hhbGxlbmdlUmV3YXJkU2NSc3AQ6CUSJgohQ21k";
		buffer[7] = "QWV0aGVyRGl2aWRlVGFpbmVySW5mb1NjTm90aWZ5EOUlEicKIkNtZEFldGhl";
		buffer[8] = "ckRpdmlkZVJlZnJlc2hFbmRsZXNzU2NSc3AQ1CUSLQooQ21kU3RhcnRBZXRo";
		buffer[9] = "ZXJEaXZpZGVDaGFsbGVuZ2VCYXR0bGVTY1JzcBDBJRIpCiRDbWRHZXRBZXRo";
		buffer[10] = "ZXJEaXZpZGVDaGFsbGVuZ2VJbmZvU2NSc3AQySUSJgohQ21kQWV0aGVyRGl2";
		buffer[11] = "aWRlU3Bpcml0SW5mb1NjTm90aWZ5EMglEiQKH0NtZEFldGhlckRpdmlkZVNw";
		buffer[12] = "aXJpdEV4cFVwU2NSc3AQ2iUSKQokQ21kR2V0QWV0aGVyRGl2aWRlQ2hhbGxl";
		buffer[13] = "bmdlSW5mb0NzUmVxEOElEiIKHUNtZFNldEFldGhlckRpdmlkZUxpbmVVcENz";
		buffer[14] = "UmVxENIlEikKJENtZFN3aXRjaEFldGhlckRpdmlkZUxpbmVVcFNsb3RDc1Jl";
		buffer[15] = "cRDfJRIsCidDbWRBZXRoZXJEaXZpZGVUYWtlQ2hhbGxlbmdlUmV3YXJkQ3NS";
		buffer[16] = "ZXEQ7iUSLQooQ21kU3RhcnRBZXRoZXJEaXZpZGVDaGFsbGVuZ2VCYXR0bGVD";
		buffer[17] = "c1JlcRDFJRIgChtDbWRHZXRBZXRoZXJEaXZpZGVJbmZvQ3NSZXEQwiUSJQog";
		buffer[18] = "Q21kQWV0aGVyRGl2aWRlU2tpbGxJdGVtU2NOb3RpZnkQ8CUSIgodQ21kU2V0";
		buffer[19] = "QWV0aGVyRGl2aWRlTGluZVVwU2NSc3AQ7SUSIgodQ21kQWV0aGVyRGl2aWRl";
		buffer[20] = "TGluZXVwU2NOb3RpZnkQ6yUSKgolQ21kQWV0aGVyRGl2aWRlUmVmcmVzaEVu";
		buffer[21] = "ZGxlc3NTY05vdGlmeRDWJRIpCiRDbWRTdGFydEFldGhlckRpdmlkZVNjZW5l";
		buffer[22] = "QmF0dGxlU2NSc3AQ5iUSEwoOQ21kSUFLQkxPTUpFTEoQxyUSGwoWQ21kRXF1";
		buffer[23] = "aXBTa2lsbENvcmVTY1JzcBDDJRIjCh5DbWRMZWF2ZUFldGhlckRpdmlkZVNj";
		buffer[24] = "ZW5lQ3NSZXEQ3iUSIAobQ21kR2V0QWV0aGVyRGl2aWRlSW5mb1NjUnNwEOwl";
		buffer[25] = "EisKJkNtZEFldGhlckRpdmlkZUZpbmlzaENoYWxsZW5nZVNjTm90aWZ5EMQl";
		buffer[26] = "EicKIkNtZEFldGhlckRpdmlkZVJlZnJlc2hFbmRsZXNzQ3NSZXEQ5yUSKQok";
		buffer[27] = "Q21kU3RhcnRBZXRoZXJEaXZpZGVTdGFnZUJhdHRsZUNzUmVxEPElEikKJENt";
		buffer[28] = "ZFN0YXJ0QWV0aGVyRGl2aWRlU2NlbmVCYXR0bGVDc1JlcRDjJRIkCh9DbWRB";
		buffer[29] = "ZXRoZXJEaXZpZGVTcGlyaXRFeHBVcENzUmVxEMYlEioKJUNtZEVxdWlwQWV0";
		buffer[30] = "aGVyRGl2aWRlUGFzc2l2ZVNraWxsQ3NSZXEQ5CUSHAoXRklCR05CS0dITkZf";
		buffer[31] = "TE1FT0VLREFNQU0QzSVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[32] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdAetherDivideType) }, null, null));
	}
}
