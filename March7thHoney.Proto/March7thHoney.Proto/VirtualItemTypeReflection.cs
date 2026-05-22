using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class VirtualItemTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static VirtualItemTypeReflection()
	{
		_003C_003Ey__InlineArray55<string> buffer = default(_003C_003Ey__InlineArray55<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 0) = "ChVWaXJ0dWFsSXRlbVR5cGUucHJvdG8qxxIKD1ZpcnR1YWxJdGVtVHlwZRIV";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 1) = "ChFWSVJUVUFMX0lURU1fTk9ORRAAEhYKElZJUlRVQUxfSVRFTV9IQ09JThAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 2) = "EhYKElZJUlRVQUxfSVRFTV9TQ09JThACEhYKElZJUlRVQUxfSVRFTV9NQ09J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 3) = "ThADEhgKFFZJUlRVQUxfSVRFTV9TVEFNSU5BEAsSIAocVklSVFVBTF9JVEVN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 4) = "X1JFU0VSVkVfU1RBTUlOQRAMEhsKF1ZJUlRVQUxfSVRFTV9BVkFUQVJfRVhQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 5) = "EBUSFAoQVklSVFVBTF9JVEVNX0VYUBAWEiMKH1ZJUlRVQUxfSVRFTV9EQUlM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 6) = "WV9BQ1RJVkVfUE9JTlQQFxIXChNWSVJUVUFMX0lURU1fTVBfTUFYEBgSJAog";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 7) = "VklSVFVBTF9JVEVNX1BMQVlFUl9SRVRVUk5fUE9JTlQQGRIlCiFWSVJUVUFM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 8) = "X0lURU1fQkFUVExFX0NPTExFR0VfUE9JTlQQGhIbChdWSVJUVUFMX0lURU1f";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 9) = "Uk9HVUVfQ09JThAfEiIKHlZJUlRVQUxfSVRFTV9ST0dVRV9UQUxFTlRfQ09J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 10) = "ThAgEiEKHVZJUlRVQUxfSVRFTV9ST0dVRV9SRVdBUkRfS0VZECESJwojVklS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 11) = "VFVBTF9JVEVNX1JPR1VFX1NVUEVSX1JFV0FSRF9LRVkQIhIgChxWSVJUVUFM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 12) = "X0lURU1fQUNISUVWRU1FTlRfRVhQECkSFwoTVklSVFVBTF9JVEVNX0JQX0VY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 13) = "UBAzEhwKGFZJUlRVQUxfSVRFTV9CUF9SRUFMX0VYUBA0Eh0KGVZJUlRVQUxf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 14) = "SVRFTV9NVVNFVU1fRlVORFMQNRIlCiFWSVJUVUFMX1RSQUlOUEFSVFlfQlVJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 15) = "TERJTkdfRlVORFMQNhInCiNWSVJUVUFMX1RSQUlOUEFSVFlfQVJFQV9VTkxP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 16) = "Q0tfQ09JThA3Eh8KG1ZJUlRVQUxfVFJBSU5QQVJUWV9NT0JJTElUWRA4Eh0K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 17) = "GFZJUlRVQUxfSVRFTV9XQVJSSU9SX0VYUBC+ARIbChZWSVJUVUFMX0lURU1f";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 18) = "Uk9HVUVfRVhQEL8BEhoKFVZJUlRVQUxfSVRFTV9NQUdFX0VYUBDAARIcChdW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 19) = "SVJUVUFMX0lURU1fU0hBTUFOX0VYUBDBARIdChhWSVJUVUFMX0lURU1fV0FS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 20) = "TE9DS19FWFAQwgESHAoXVklSVFVBTF9JVEVNX0tOSUdIVF9FWFAQwwESHAoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 21) = "VklSVFVBTF9JVEVNX1BSSUVTVF9FWFAQxAESIgocVklSVFVBTF9JVEVNX1BV";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 22) = "TktfTE9SRF9QT0lOVBCgjQYSOAoyVklSVFVBTF9JVEVNX0dBTUVQTEFZX0NP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 23) = "VU5URVJfTU9OU1RFUl9TTkVBS19WSVNJT04QwYsREjMKLVZJUlRVQUxfSVRF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 24) = "TV9HQU1FUExBWV9DT1VOVEVSX1dPTEZfQlJPX0JVTExFVBDCixESHgoYVklS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 25) = "VFVBTF9JVEVNX0FMTEVZX0ZVTkRTEKmTERIlCh9WSVJUVUFMX0lURU1fUk9H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 26) = "VUVfUFVNQU5fQ09VUE9OELSTERIdChdWSVJUVUFMX0lURU1fTU9OVEhfQ0FS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 27) = "RBDFqBISHAoWVklSVFVBTF9JVEVNX0JQX05PUk1BTBDGqBISHAoWVklSVFVB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 28) = "TF9JVEVNX0JQX0RFTFVYRRDHqBISHQoXVklSVFVBTF9JVEVNX0JQX1VQR1JB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 29) = "REUQyKgSEiAKGlZJUlRVQUxfSVRFTV9IRUxJT0JVU19GQU5TEKqTERIoCiJW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 30) = "SVJUVUFMX0lURU1fU1BBQ0VfWk9PX0hZQlJJRF9JVEVNEKuTERImCiBWSVJU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 31) = "VUFMX0lURU1fU1BBQ0VfWk9PX0VYUF9QT0lOVBCskxESKQojVklSVFVBTF9J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 32) = "VEVNX1JPR1VFX05PVVNfVEFMRU5UX0NPSU4QtZMREiQKHlZJUlRVQUxfSVRF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 33) = "TV9FVk9MVkVfQlVJTERfQ09JThC7kxESIgocVklSVFVBTF9JVEVNX0RSSU5L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 34) = "X01BS0VSX1RJUBCtkxESIAoaVklSVFVBTF9JVEVNX01PTk9QT0xZX0RJQ0UQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 35) = "tpMREiAKGlZJUlRVQUxfSVRFTV9NT05PUE9MWV9DT0lOELeTERIlCh9WSVJU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 36) = "VUFMX0lURU1fTU9OT1BPTFlfQ0hFQVRESUNFELiTERIiChxWSVJUVUFMX0lU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 37) = "RU1fTU9OT1BPTFlfUkVST0xMELmTERI0Ci5WSVJUVUFMX0lURU1fUk9HVUVf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 38) = "VE9VUk5fUEVSTUFORU5UX1RBTEVOVF9DT0lOELqTERIxCitWSVJUVUFMX0lU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 39) = "RU1fUk9HVUVfVE9VUk5fU0VBU09OX1RBTEVOVF9DT0lOELyTERIiChxWSVJU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 40) = "VUFMX0lURU1fUk9HVUVfVE9VUk5fRVhQEL6TERIiChxWSVJUVUFMX0lURU1f";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 41) = "TUFUQ0hUSFJFRV9DT0lOEMCTERItCidWSVJUVUFMX0lURU1fU1dPUkRfVFJB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 42) = "SU5JTkdfU0tJTExfUE9JTlQQv5MREiIKHFZJUlRVQUxfSVRFTV9GSUdIVF9G";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 43) = "RVNUX0NPSU4QwZMREioKJFZJUlRVQUxfSVRFTV9ST0dVRV9NQUdJQ19UQUxF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 44) = "TlRfQ09JThDCkxESJwohVklSVFVBTF9JVEVNX0VWT0xWRV9CVUlMRF9TQ19D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 45) = "T0lOEMOTERIqCiRWSVJUVUFMX0lURU1fRVZPTFZFX0JVSUxEX1JFV0FSRF9F";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 46) = "WFAQxJMREiUKH1ZJUlRVQUxfSVRFTV9NQVRDSFRIUkVFX1YyX0NPSU4QxZMR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 47) = "EiIKHFZJUlRVQUxfSVRFTV9HUklEX0ZJR0hUX0NPSU4Qx5MREikKI1ZJUlRV";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 48) = "QUxfSVRFTV9HUklEX0ZJR0hUX1RBTEVOVF9DT0lOEMiTERIoCiJWSVJUVUFM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 49) = "X0lURU1fR1JJRF9GSUdIVF9TRUFTT05fRVhQEMmTERIqCiRWSVJUVUFMX0lU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 50) = "RU1fR1JJRF9GSUdIVF9HQU1FUExBWV9FWFAQypMREjAKKlZJUlRVQUxfSVRF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 51) = "TV9HUklEX0ZJR0hUX0ZSRUVfUkVGUkVTSF9USU1FUxDLkxESIQobVklSVFVB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 52) = "TF9JVEVNX0NBS0VfUkFDRV9DT0lOEM6TERIiChxWSVJUVUFMX0lURU1fQ0FL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 53) = "RV9SQUNFX1NDT1JFEM+TEUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray55<string>, string>(ref buffer, 54) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray55<string>, string>(in buffer, 55))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(VirtualItemType) }, null, null));
	}
}
