using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NIIGAPILPGD : IMessage<NIIGAPILPGD>, IMessage, IEquatable<NIIGAPILPGD>, IDeepCloneable<NIIGAPILPGD>, IBufferMessage
{
	private static readonly MessageParser<NIIGAPILPGD> _parser = new MessageParser<NIIGAPILPGD>(() => new NIIGAPILPGD());

	private UnknownFieldSet _unknownFields;

	public const int UidFieldNumber = 1;

	private uint uid_;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int NicknameFieldNumber = 3;

	private string nickname_ = "";

	public const int JHHHONJIKGLFieldNumber = 4;

	private uint jHHHONJIKGL_;

	public const int PlatformFieldNumber = 5;

	private PlatformType platform_;

	public const int HBIDCAFOPMGFieldNumber = 6;

	private string hBIDCAFOPMG_ = "";

	public const int IKIKMEEJNDNFieldNumber = 7;

	private string iKIKMEEJNDN_ = "";

	public const int VersionFieldNumber = 8;

	private ulong version_;

	public const int GIKABEMCFAOFieldNumber = 9;

	private bool gIKABEMCFAO_;

	public const int CLDNGAEIBDFFieldNumber = 10;

	private uint cLDNGAEIBDF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NIIGAPILPGD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NIIGAPILPGDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Nickname
	{
		get
		{
			return nickname_;
		}
		set
		{
			nickname_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHHHONJIKGL
	{
		get
		{
			return jHHHONJIKGL_;
		}
		set
		{
			jHHHONJIKGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlatformType Platform
	{
		get
		{
			return platform_;
		}
		set
		{
			platform_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string HBIDCAFOPMG
	{
		get
		{
			return hBIDCAFOPMG_;
		}
		set
		{
			hBIDCAFOPMG_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IKIKMEEJNDN
	{
		get
		{
			return iKIKMEEJNDN_;
		}
		set
		{
			iKIKMEEJNDN_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GIKABEMCFAO
	{
		get
		{
			return gIKABEMCFAO_;
		}
		set
		{
			gIKABEMCFAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CLDNGAEIBDF
	{
		get
		{
			return cLDNGAEIBDF_;
		}
		set
		{
			cLDNGAEIBDF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NIIGAPILPGD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NIIGAPILPGD(NIIGAPILPGD other)
		: this()
	{
		uid_ = other.uid_;
		level_ = other.level_;
		nickname_ = other.nickname_;
		jHHHONJIKGL_ = other.jHHHONJIKGL_;
		platform_ = other.platform_;
		hBIDCAFOPMG_ = other.hBIDCAFOPMG_;
		iKIKMEEJNDN_ = other.iKIKMEEJNDN_;
		version_ = other.version_;
		gIKABEMCFAO_ = other.gIKABEMCFAO_;
		cLDNGAEIBDF_ = other.cLDNGAEIBDF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NIIGAPILPGD Clone()
	{
		return new NIIGAPILPGD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NIIGAPILPGD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NIIGAPILPGD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Nickname != other.Nickname)
		{
			return false;
		}
		if (JHHHONJIKGL != other.JHHHONJIKGL)
		{
			return false;
		}
		if (Platform != other.Platform)
		{
			return false;
		}
		if (HBIDCAFOPMG != other.HBIDCAFOPMG)
		{
			return false;
		}
		if (IKIKMEEJNDN != other.IKIKMEEJNDN)
		{
			return false;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (GIKABEMCFAO != other.GIKABEMCFAO)
		{
			return false;
		}
		if (CLDNGAEIBDF != other.CLDNGAEIBDF)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Nickname.Length != 0)
		{
			num ^= Nickname.GetHashCode();
		}
		if (JHHHONJIKGL != 0)
		{
			num ^= JHHHONJIKGL.GetHashCode();
		}
		if (Platform != PlatformType.Editor)
		{
			num ^= Platform.GetHashCode();
		}
		if (HBIDCAFOPMG.Length != 0)
		{
			num ^= HBIDCAFOPMG.GetHashCode();
		}
		if (IKIKMEEJNDN.Length != 0)
		{
			num ^= IKIKMEEJNDN.GetHashCode();
		}
		if (Version != 0L)
		{
			num ^= Version.GetHashCode();
		}
		if (GIKABEMCFAO)
		{
			num ^= GIKABEMCFAO.GetHashCode();
		}
		if (CLDNGAEIBDF != 0)
		{
			num ^= CLDNGAEIBDF.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Uid != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Uid);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		if (Nickname.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Nickname);
		}
		if (JHHHONJIKGL != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(JHHHONJIKGL);
		}
		if (Platform != PlatformType.Editor)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Platform);
		}
		if (HBIDCAFOPMG.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(HBIDCAFOPMG);
		}
		if (IKIKMEEJNDN.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(IKIKMEEJNDN);
		}
		if (Version != 0L)
		{
			output.WriteRawTag(64);
			output.WriteUInt64(Version);
		}
		if (GIKABEMCFAO)
		{
			output.WriteRawTag(72);
			output.WriteBool(GIKABEMCFAO);
		}
		if (CLDNGAEIBDF != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CLDNGAEIBDF);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Nickname.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Nickname);
		}
		if (JHHHONJIKGL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHHHONJIKGL);
		}
		if (Platform != PlatformType.Editor)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Platform);
		}
		if (HBIDCAFOPMG.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HBIDCAFOPMG);
		}
		if (IKIKMEEJNDN.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IKIKMEEJNDN);
		}
		if (Version != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Version);
		}
		if (GIKABEMCFAO)
		{
			num += 2;
		}
		if (CLDNGAEIBDF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CLDNGAEIBDF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NIIGAPILPGD other)
	{
		if (other != null)
		{
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Nickname.Length != 0)
			{
				Nickname = other.Nickname;
			}
			if (other.JHHHONJIKGL != 0)
			{
				JHHHONJIKGL = other.JHHHONJIKGL;
			}
			if (other.Platform != PlatformType.Editor)
			{
				Platform = other.Platform;
			}
			if (other.HBIDCAFOPMG.Length != 0)
			{
				HBIDCAFOPMG = other.HBIDCAFOPMG;
			}
			if (other.IKIKMEEJNDN.Length != 0)
			{
				IKIKMEEJNDN = other.IKIKMEEJNDN;
			}
			if (other.Version != 0L)
			{
				Version = other.Version;
			}
			if (other.GIKABEMCFAO)
			{
				GIKABEMCFAO = other.GIKABEMCFAO;
			}
			if (other.CLDNGAEIBDF != 0)
			{
				CLDNGAEIBDF = other.CLDNGAEIBDF;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				Uid = input.ReadUInt32();
				break;
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 26u:
				Nickname = input.ReadString();
				break;
			case 32u:
				JHHHONJIKGL = input.ReadUInt32();
				break;
			case 40u:
				Platform = (PlatformType)input.ReadEnum();
				break;
			case 50u:
				HBIDCAFOPMG = input.ReadString();
				break;
			case 58u:
				IKIKMEEJNDN = input.ReadString();
				break;
			case 64u:
				Version = input.ReadUInt64();
				break;
			case 72u:
				GIKABEMCFAO = input.ReadBool();
				break;
			case 80u:
				CLDNGAEIBDF = input.ReadUInt32();
				break;
			}
		}
	}
}
