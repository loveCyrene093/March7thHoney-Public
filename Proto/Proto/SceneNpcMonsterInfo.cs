using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneNpcMonsterInfo : IMessage<SceneNpcMonsterInfo>, IMessage, IEquatable<SceneNpcMonsterInfo>, IDeepCloneable<SceneNpcMonsterInfo>, IBufferMessage
{
	private static readonly MessageParser<SceneNpcMonsterInfo> _parser = new MessageParser<SceneNpcMonsterInfo>(() => new SceneNpcMonsterInfo());

	private UnknownFieldSet _unknownFields;

	public const int ExtraInfoFieldNumber = 2;

	private NpcMonsterExtraInfo extraInfo_;

	public const int DKGCLLLIFNHFieldNumber = 4;

	private bool dKGCLLLIFNH_;

	public const int WorldLevelFieldNumber = 7;

	private uint worldLevel_;

	public const int MonsterIdFieldNumber = 11;

	private uint monsterId_;

	public const int JJAPBFGDPLAFieldNumber = 12;

	private PECMFBCBLHH jJAPBFGDPLA_;

	public const int EventIdFieldNumber = 13;

	private uint eventId_;

	public const int FDIHGHGEIOHFieldNumber = 14;

	private bool fDIHGHGEIOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneNpcMonsterInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneNpcMonsterInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcMonsterExtraInfo ExtraInfo
	{
		get
		{
			return extraInfo_;
		}
		set
		{
			extraInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DKGCLLLIFNH
	{
		get
		{
			return dKGCLLLIFNH_;
		}
		set
		{
			dKGCLLLIFNH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WorldLevel
	{
		get
		{
			return worldLevel_;
		}
		set
		{
			worldLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PECMFBCBLHH JJAPBFGDPLA
	{
		get
		{
			return jJAPBFGDPLA_;
		}
		set
		{
			jJAPBFGDPLA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FDIHGHGEIOH
	{
		get
		{
			return fDIHGHGEIOH_;
		}
		set
		{
			fDIHGHGEIOH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneNpcMonsterInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneNpcMonsterInfo(SceneNpcMonsterInfo other)
		: this()
	{
		extraInfo_ = ((other.extraInfo_ != null) ? other.extraInfo_.Clone() : null);
		dKGCLLLIFNH_ = other.dKGCLLLIFNH_;
		worldLevel_ = other.worldLevel_;
		monsterId_ = other.monsterId_;
		jJAPBFGDPLA_ = ((other.jJAPBFGDPLA_ != null) ? other.jJAPBFGDPLA_.Clone() : null);
		eventId_ = other.eventId_;
		fDIHGHGEIOH_ = other.fDIHGHGEIOH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneNpcMonsterInfo Clone()
	{
		return new SceneNpcMonsterInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneNpcMonsterInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneNpcMonsterInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ExtraInfo, other.ExtraInfo))
		{
			return false;
		}
		if (DKGCLLLIFNH != other.DKGCLLLIFNH)
		{
			return false;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (MonsterId != other.MonsterId)
		{
			return false;
		}
		if (!object.Equals(JJAPBFGDPLA, other.JJAPBFGDPLA))
		{
			return false;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (FDIHGHGEIOH != other.FDIHGHGEIOH)
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
		if (extraInfo_ != null)
		{
			num ^= ExtraInfo.GetHashCode();
		}
		if (DKGCLLLIFNH)
		{
			num ^= DKGCLLLIFNH.GetHashCode();
		}
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (jJAPBFGDPLA_ != null)
		{
			num ^= JJAPBFGDPLA.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (FDIHGHGEIOH)
		{
			num ^= FDIHGHGEIOH.GetHashCode();
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
		if (extraInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ExtraInfo);
		}
		if (DKGCLLLIFNH)
		{
			output.WriteRawTag(32);
			output.WriteBool(DKGCLLLIFNH);
		}
		if (WorldLevel != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(WorldLevel);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(MonsterId);
		}
		if (jJAPBFGDPLA_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(JJAPBFGDPLA);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(EventId);
		}
		if (FDIHGHGEIOH)
		{
			output.WriteRawTag(112);
			output.WriteBool(FDIHGHGEIOH);
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
		if (extraInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ExtraInfo);
		}
		if (DKGCLLLIFNH)
		{
			num += 2;
		}
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (jJAPBFGDPLA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JJAPBFGDPLA);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (FDIHGHGEIOH)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneNpcMonsterInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.extraInfo_ != null)
		{
			if (extraInfo_ == null)
			{
				ExtraInfo = new NpcMonsterExtraInfo();
			}
			ExtraInfo.MergeFrom(other.ExtraInfo);
		}
		if (other.DKGCLLLIFNH)
		{
			DKGCLLLIFNH = other.DKGCLLLIFNH;
		}
		if (other.WorldLevel != 0)
		{
			WorldLevel = other.WorldLevel;
		}
		if (other.MonsterId != 0)
		{
			MonsterId = other.MonsterId;
		}
		if (other.jJAPBFGDPLA_ != null)
		{
			if (jJAPBFGDPLA_ == null)
			{
				JJAPBFGDPLA = new PECMFBCBLHH();
			}
			JJAPBFGDPLA.MergeFrom(other.JJAPBFGDPLA);
		}
		if (other.EventId != 0)
		{
			EventId = other.EventId;
		}
		if (other.FDIHGHGEIOH)
		{
			FDIHGHGEIOH = other.FDIHGHGEIOH;
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
			case 18u:
				if (extraInfo_ == null)
				{
					ExtraInfo = new NpcMonsterExtraInfo();
				}
				input.ReadMessage(ExtraInfo);
				break;
			case 32u:
				DKGCLLLIFNH = input.ReadBool();
				break;
			case 56u:
				WorldLevel = input.ReadUInt32();
				break;
			case 88u:
				MonsterId = input.ReadUInt32();
				break;
			case 98u:
				if (jJAPBFGDPLA_ == null)
				{
					JJAPBFGDPLA = new PECMFBCBLHH();
				}
				input.ReadMessage(JJAPBFGDPLA);
				break;
			case 104u:
				EventId = input.ReadUInt32();
				break;
			case 112u:
				FDIHGHGEIOH = input.ReadBool();
				break;
			}
		}
	}
}
