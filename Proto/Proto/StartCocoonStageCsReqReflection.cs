using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartCocoonStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartCocoonStageCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtTdGFydENvY29vblN0YWdlQ3NSZXEucHJvdG8aEU5LTkFBRElHR05BLnBy";
		buffer[1] = "b3RvIpcBChVTdGFydENvY29vblN0YWdlQ3NSZXESEwoLd29ybGRfbGV2ZWwY";
		buffer[2] = "AiABKA0SDQoFQ291bnQYBSABKA0SIQoLRExBQ0VFRkpBSEIYCiABKAsyDC5O";
		buffer[3] = "S05BQURJR0dOQRIWCg5wcm9wX2VudGl0eV9pZBgMIAEoDRIMCgR3YXZlGA4g";
		buffer[4] = "ASgNEhEKCWNvY29vbl9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[5] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NKNAADIGGNAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartCocoonStageCsReq), StartCocoonStageCsReq.Parser, new string[6] { "WorldLevel", "Count", "DLACEEFJAHB", "PropEntityId", "Wave", "CocoonId" }, null, null, null, null)
		}));
	}
}
