using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MBICBKAFGIK : IMessage<MBICBKAFGIK>, IMessage, IEquatable<MBICBKAFGIK>, IDeepCloneable<MBICBKAFGIK>, IBufferMessage
{
	private static readonly MessageParser<MBICBKAFGIK> _parser = new MessageParser<MBICBKAFGIK>(() => new MBICBKAFGIK());

	private UnknownFieldSet _unknownFields;

	public const int RemarkNameFieldNumber = 1;

	private string remarkName_ = "";

	public const int HeadFrameInfoFieldNumber = 3;

	private HeadFrameInfo headFrameInfo_;

	public const int CLDNGAEIBDFFieldNumber = 4;

	private uint cLDNGAEIBDF_;

	public const int NicknameFieldNumber = 5;

	private string nickname_ = "";

	public const int UidFieldNumber = 6;

	private uint uid_;

	public const int LevelFieldNumber = 7;

	private uint level_;

	public const int GKDPLCCALMHFieldNumber = 9;

	private uint gKDPLCCALMH_;

	public const int ICJIGHOMDNLFieldNumber = 10;

	private string iCJIGHOMDNL_ = "";

	public const int PlatformFieldNumber = 12;

	private PlatformType platform_;

	public const int HeadIconFieldNumber = 14;

	private uint headIcon_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MBICBKAFGIK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MBICBKAFGIKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RemarkName
	{
		get
		{
			return remarkName_;
		}
		set
		{
			remarkName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeadFrameInfo HeadFrameInfo
	{
		get
		{
			return headFrameInfo_;
		}
		set
		{
			headFrameInfo_ = value;
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
	public uint GKDPLCCALMH
	{
		get
		{
			return gKDPLCCALMH_;
		}
		set
		{
			gKDPLCCALMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ICJIGHOMDNL
	{
		get
		{
			return iCJIGHOMDNL_;
		}
		set
		{
			iCJIGHOMDNL_ = ProtoPreconditions.CheckNotNull(value, "value");
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
	public uint HeadIcon
	{
		get
		{
			return headIcon_;
		}
		set
		{
			headIcon_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBICBKAFGIK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBICBKAFGIK(MBICBKAFGIK other)
		: this()
	{
		remarkName_ = other.remarkName_;
		headFrameInfo_ = ((other.headFrameInfo_ != null) ? other.headFrameInfo_.Clone() : null);
		cLDNGAEIBDF_ = other.cLDNGAEIBDF_;
		nickname_ = other.nickname_;
		uid_ = other.uid_;
		level_ = other.level_;
		gKDPLCCALMH_ = other.gKDPLCCALMH_;
		iCJIGHOMDNL_ = other.iCJIGHOMDNL_;
		platform_ = other.platform_;
		headIcon_ = other.headIcon_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MBICBKAFGIK Clone()
	{
		return new MBICBKAFGIK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MBICBKAFGIK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MBICBKAFGIK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RemarkName != other.RemarkName)
		{
			return false;
		}
		if (!object.Equals(HeadFrameInfo, other.HeadFrameInfo))
		{
			return false;
		}
		if (CLDNGAEIBDF != other.CLDNGAEIBDF)
		{
			return false;
		}
		if (Nickname != other.Nickname)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (GKDPLCCALMH != other.GKDPLCCALMH)
		{
			return false;
		}
		if (ICJIGHOMDNL != other.ICJIGHOMDNL)
		{
			return false;
		}
		if (Platform != other.Platform)
		{
			return false;
		}
		if (HeadIcon != other.HeadIcon)
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
		if (RemarkName.Length != 0)
		{
			num ^= RemarkName.GetHashCode();
		}
		if (headFrameInfo_ != null)
		{
			num ^= HeadFrameInfo.GetHashCode();
		}
		if (CLDNGAEIBDF != 0)
		{
			num ^= CLDNGAEIBDF.GetHashCode();
		}
		if (Nickname.Length != 0)
		{
			num ^= Nickname.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (GKDPLCCALMH != 0)
		{
			num ^= GKDPLCCALMH.GetHashCode();
		}
		if (ICJIGHOMDNL.Length != 0)
		{
			num ^= ICJIGHOMDNL.GetHashCode();
		}
		if (Platform != PlatformType.Editor)
		{
			num ^= Platform.GetHashCode();
		}
		if (HeadIcon != 0)
		{
			num ^= HeadIcon.GetHashCode();
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
		if (RemarkName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(RemarkName);
		}
		if (headFrameInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(HeadFrameInfo);
		}
		if (CLDNGAEIBDF != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CLDNGAEIBDF);
		}
		if (Nickname.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Nickname);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Uid);
		}
		if (Level != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Level);
		}
		if (GKDPLCCALMH != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GKDPLCCALMH);
		}
		if (ICJIGHOMDNL.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(ICJIGHOMDNL);
		}
		if (Platform != PlatformType.Editor)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)Platform);
		}
		if (HeadIcon != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HeadIcon);
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
		if (RemarkName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RemarkName);
		}
		if (headFrameInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HeadFrameInfo);
		}
		if (CLDNGAEIBDF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CLDNGAEIBDF);
		}
		if (Nickname.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Nickname);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (GKDPLCCALMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKDPLCCALMH);
		}
		if (ICJIGHOMDNL.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ICJIGHOMDNL);
		}
		if (Platform != PlatformType.Editor)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Platform);
		}
		if (HeadIcon != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HeadIcon);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MBICBKAFGIK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RemarkName.Length != 0)
		{
			RemarkName = other.RemarkName;
		}
		if (other.headFrameInfo_ != null)
		{
			if (headFrameInfo_ == null)
			{
				HeadFrameInfo = new HeadFrameInfo();
			}
			HeadFrameInfo.MergeFrom(other.HeadFrameInfo);
		}
		if (other.CLDNGAEIBDF != 0)
		{
			CLDNGAEIBDF = other.CLDNGAEIBDF;
		}
		if (other.Nickname.Length != 0)
		{
			Nickname = other.Nickname;
		}
		if (other.Uid != 0)
		{
			Uid = other.Uid;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.GKDPLCCALMH != 0)
		{
			GKDPLCCALMH = other.GKDPLCCALMH;
		}
		if (other.ICJIGHOMDNL.Length != 0)
		{
			ICJIGHOMDNL = other.ICJIGHOMDNL;
		}
		if (other.Platform != PlatformType.Editor)
		{
			Platform = other.Platform;
		}
		if (other.HeadIcon != 0)
		{
			HeadIcon = other.HeadIcon;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				RemarkName = input.ReadString();
				break;
			case 26u:
				if (headFrameInfo_ == null)
				{
					HeadFrameInfo = new HeadFrameInfo();
				}
				input.ReadMessage(HeadFrameInfo);
				break;
			case 32u:
				CLDNGAEIBDF = input.ReadUInt32();
				break;
			case 42u:
				Nickname = input.ReadString();
				break;
			case 48u:
				Uid = input.ReadUInt32();
				break;
			case 56u:
				Level = input.ReadUInt32();
				break;
			case 72u:
				GKDPLCCALMH = input.ReadUInt32();
				break;
			case 82u:
				ICJIGHOMDNL = input.ReadString();
				break;
			case 96u:
				Platform = (PlatformType)input.ReadEnum();
				break;
			case 112u:
				HeadIcon = input.ReadUInt32();
				break;
			}
		}
	}
}
