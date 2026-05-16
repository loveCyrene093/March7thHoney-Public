using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ReplayInfo : IMessage<ReplayInfo>, IMessage, IEquatable<ReplayInfo>, IDeepCloneable<ReplayInfo>, IBufferMessage
{
	private static readonly MessageParser<ReplayInfo> _parser = new MessageParser<ReplayInfo>(() => new ReplayInfo());

	private UnknownFieldSet _unknownFields;

	public const int PNLCMJOADKBFieldNumber = 1;

	private ulong pNLCMJOADKB_;

	public const int ReplayTypeFieldNumber = 2;

	private OCLEJLEFBFO replayType_;

	public const int StageIdFieldNumber = 3;

	private uint stageId_;

	public const int UidFieldNumber = 4;

	private uint uid_;

	public const int NicknameFieldNumber = 5;

	private string nickname_ = "";

	public const int HeadIconFieldNumber = 6;

	private uint headIcon_;

	public const int ReplayNameFieldNumber = 7;

	private string replayName_ = "";

	public const int CreateTimeFieldNumber = 8;

	private ulong createTime_;

	public const int DAFEJIENABLFieldNumber = 9;

	private uint dAFEJIENABL_;

	public const int KALAGIBCNAOFieldNumber = 10;

	private uint kALAGIBCNAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ReplayInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ReplayInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PNLCMJOADKB
	{
		get
		{
			return pNLCMJOADKB_;
		}
		set
		{
			pNLCMJOADKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OCLEJLEFBFO ReplayType
	{
		get
		{
			return replayType_;
		}
		set
		{
			replayType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
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
	public string ReplayName
	{
		get
		{
			return replayName_;
		}
		set
		{
			replayName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DAFEJIENABL
	{
		get
		{
			return dAFEJIENABL_;
		}
		set
		{
			dAFEJIENABL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KALAGIBCNAO
	{
		get
		{
			return kALAGIBCNAO_;
		}
		set
		{
			kALAGIBCNAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReplayInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReplayInfo(ReplayInfo other)
		: this()
	{
		pNLCMJOADKB_ = other.pNLCMJOADKB_;
		replayType_ = other.replayType_;
		stageId_ = other.stageId_;
		uid_ = other.uid_;
		nickname_ = other.nickname_;
		headIcon_ = other.headIcon_;
		replayName_ = other.replayName_;
		createTime_ = other.createTime_;
		dAFEJIENABL_ = other.dAFEJIENABL_;
		kALAGIBCNAO_ = other.kALAGIBCNAO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ReplayInfo Clone()
	{
		return new ReplayInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ReplayInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ReplayInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PNLCMJOADKB != other.PNLCMJOADKB)
		{
			return false;
		}
		if (ReplayType != other.ReplayType)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (Nickname != other.Nickname)
		{
			return false;
		}
		if (HeadIcon != other.HeadIcon)
		{
			return false;
		}
		if (ReplayName != other.ReplayName)
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
		{
			return false;
		}
		if (DAFEJIENABL != other.DAFEJIENABL)
		{
			return false;
		}
		if (KALAGIBCNAO != other.KALAGIBCNAO)
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
		if (PNLCMJOADKB != 0L)
		{
			num ^= PNLCMJOADKB.GetHashCode();
		}
		if (ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
		{
			num ^= ReplayType.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (Nickname.Length != 0)
		{
			num ^= Nickname.GetHashCode();
		}
		if (HeadIcon != 0)
		{
			num ^= HeadIcon.GetHashCode();
		}
		if (ReplayName.Length != 0)
		{
			num ^= ReplayName.GetHashCode();
		}
		if (CreateTime != 0L)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (DAFEJIENABL != 0)
		{
			num ^= DAFEJIENABL.GetHashCode();
		}
		if (KALAGIBCNAO != 0)
		{
			num ^= KALAGIBCNAO.GetHashCode();
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
		if (PNLCMJOADKB != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(PNLCMJOADKB);
		}
		if (ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ReplayType);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(StageId);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Uid);
		}
		if (Nickname.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Nickname);
		}
		if (HeadIcon != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(HeadIcon);
		}
		if (ReplayName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(ReplayName);
		}
		if (CreateTime != 0L)
		{
			output.WriteRawTag(64);
			output.WriteUInt64(CreateTime);
		}
		if (DAFEJIENABL != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(DAFEJIENABL);
		}
		if (KALAGIBCNAO != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(KALAGIBCNAO);
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
		if (PNLCMJOADKB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PNLCMJOADKB);
		}
		if (ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ReplayType);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (Nickname.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Nickname);
		}
		if (HeadIcon != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HeadIcon);
		}
		if (ReplayName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ReplayName);
		}
		if (CreateTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(CreateTime);
		}
		if (DAFEJIENABL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DAFEJIENABL);
		}
		if (KALAGIBCNAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KALAGIBCNAO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ReplayInfo other)
	{
		if (other != null)
		{
			if (other.PNLCMJOADKB != 0L)
			{
				PNLCMJOADKB = other.PNLCMJOADKB;
			}
			if (other.ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
			{
				ReplayType = other.ReplayType;
			}
			if (other.StageId != 0)
			{
				StageId = other.StageId;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.Nickname.Length != 0)
			{
				Nickname = other.Nickname;
			}
			if (other.HeadIcon != 0)
			{
				HeadIcon = other.HeadIcon;
			}
			if (other.ReplayName.Length != 0)
			{
				ReplayName = other.ReplayName;
			}
			if (other.CreateTime != 0L)
			{
				CreateTime = other.CreateTime;
			}
			if (other.DAFEJIENABL != 0)
			{
				DAFEJIENABL = other.DAFEJIENABL;
			}
			if (other.KALAGIBCNAO != 0)
			{
				KALAGIBCNAO = other.KALAGIBCNAO;
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
				PNLCMJOADKB = input.ReadUInt64();
				break;
			case 16u:
				ReplayType = (OCLEJLEFBFO)input.ReadEnum();
				break;
			case 24u:
				StageId = input.ReadUInt32();
				break;
			case 32u:
				Uid = input.ReadUInt32();
				break;
			case 42u:
				Nickname = input.ReadString();
				break;
			case 48u:
				HeadIcon = input.ReadUInt32();
				break;
			case 58u:
				ReplayName = input.ReadString();
				break;
			case 64u:
				CreateTime = input.ReadUInt64();
				break;
			case 72u:
				DAFEJIENABL = input.ReadUInt32();
				break;
			case 80u:
				KALAGIBCNAO = input.ReadUInt32();
				break;
			}
		}
	}
}
