using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterLocalLegendLevelScRsp : IMessage<EnterLocalLegendLevelScRsp>, IMessage, IEquatable<EnterLocalLegendLevelScRsp>, IDeepCloneable<EnterLocalLegendLevelScRsp>, IBufferMessage
{
	private static readonly MessageParser<EnterLocalLegendLevelScRsp> _parser = new MessageParser<EnterLocalLegendLevelScRsp>(() => new EnterLocalLegendLevelScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int BattleInfoFieldNumber = 7;

	private SceneBattleInfo battleInfo_;

	public const int GroupIdFieldNumber = 9;

	private uint groupId_;

	public const int INOMFFAIEOAFieldNumber = 15;

	private uint iNOMFFAIEOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterLocalLegendLevelScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterLocalLegendLevelScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneBattleInfo BattleInfo
	{
		get
		{
			return battleInfo_;
		}
		set
		{
			battleInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint INOMFFAIEOA
	{
		get
		{
			return iNOMFFAIEOA_;
		}
		set
		{
			iNOMFFAIEOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterLocalLegendLevelScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterLocalLegendLevelScRsp(EnterLocalLegendLevelScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
		groupId_ = other.groupId_;
		iNOMFFAIEOA_ = other.iNOMFFAIEOA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterLocalLegendLevelScRsp Clone()
	{
		return new EnterLocalLegendLevelScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterLocalLegendLevelScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterLocalLegendLevelScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(BattleInfo, other.BattleInfo))
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (INOMFFAIEOA != other.INOMFFAIEOA)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (battleInfo_ != null)
		{
			num ^= BattleInfo.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (INOMFFAIEOA != 0)
		{
			num ^= INOMFFAIEOA.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (battleInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(BattleInfo);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GroupId);
		}
		if (INOMFFAIEOA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(INOMFFAIEOA);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (battleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleInfo);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (INOMFFAIEOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INOMFFAIEOA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterLocalLegendLevelScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.battleInfo_ != null)
		{
			if (battleInfo_ == null)
			{
				BattleInfo = new SceneBattleInfo();
			}
			BattleInfo.MergeFrom(other.BattleInfo);
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		if (other.INOMFFAIEOA != 0)
		{
			INOMFFAIEOA = other.INOMFFAIEOA;
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
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 58u:
				if (battleInfo_ == null)
				{
					BattleInfo = new SceneBattleInfo();
				}
				input.ReadMessage(BattleInfo);
				break;
			case 72u:
				GroupId = input.ReadUInt32();
				break;
			case 120u:
				INOMFFAIEOA = input.ReadUInt32();
				break;
			}
		}
	}
}
