using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneEntityMoveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneEntityMoveScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChpTY2VuZUVudGl0eU1vdmVTY1JzcC5wcm90bxoYQ2xpZW50RG93bmxvYWRE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "YXRhLnByb3RvGhJFbnRpdHlNb3Rpb24ucHJvdG8ifgoUU2NlbmVFbnRpdHlN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "b3ZlU2NSc3ASKgoNZG93bmxvYWRfZGF0YRgGIAEoCzITLkNsaWVudERvd25s";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "b2FkRGF0YRIpChJlbnRpdHlfbW90aW9uX2xpc3QYCyADKAsyDS5FbnRpdHlN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "b3Rpb24SDwoHcmV0Y29kZRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			ClientDownloadDataReflection.Descriptor,
			EntityMotionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityMoveScRsp), SceneEntityMoveScRsp.Parser, new string[3] { "DownloadData", "EntityMotionList", "Retcode" }, null, null, null, null)
		}));
	}
}
