using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectChessRogueSubStoryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectChessRogueSubStoryCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiNTZWxlY3RDaGVzc1JvZ3VlU3ViU3RvcnlDc1JlcS5wcm90byJ/Ch1TZWxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Y3RDaGVzc1JvZ3VlU3ViU3RvcnlDc1JlcRITCgtGT01ORkhKQ0RPQxgDIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "DRITCgtJRU5CS0lBR1BCQRgHIAEoDRITCgtFS0VGTU5QRk9HTxgMIAEoDRIf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Chdyb2d1ZV9kaWFsb2d1ZV9ldmVudF9pZBgNIAEoDUIWqgITTWFyY2g3dGhI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectChessRogueSubStoryCsReq), SelectChessRogueSubStoryCsReq.Parser, new string[4] { "FOMNFHJCDOC", "IENBKIAGPBA", "EKEFMNPFOGO", "RogueDialogueEventId" }, null, null, null, null)
		}));
	}
}
