using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SummonActivityBattleEndScNotify : IMessage<SummonActivityBattleEndScNotify>, IMessage, IEquatable<SummonActivityBattleEndScNotify>, IDeepCloneable<SummonActivityBattleEndScNotify>, IBufferMessage
{
	private static readonly MessageParser<SummonActivityBattleEndScNotify> _parser = new MessageParser<SummonActivityBattleEndScNotify>(() => new SummonActivityBattleEndScNotify());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 2;

	private uint groupId_;

	public const int NIIEKCMBENIFieldNumber = 7;

	private uint nIIEKCMBENI_;

	public const int StarFieldNumber = 8;

	private uint star_;

	public const int INOMFFAIEOAFieldNumber = 15;

	private uint iNOMFFAIEOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SummonActivityBattleEndScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SummonActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint NIIEKCMBENI
	{
		get
		{
			return nIIEKCMBENI_;
		}
		set
		{
			nIIEKCMBENI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Star
	{
		get
		{
			return star_;
		}
		set
		{
			star_ = value;
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
	public SummonActivityBattleEndScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SummonActivityBattleEndScNotify(SummonActivityBattleEndScNotify other)
		: this()
	{
		groupId_ = other.groupId_;
		nIIEKCMBENI_ = other.nIIEKCMBENI_;
		star_ = other.star_;
		iNOMFFAIEOA_ = other.iNOMFFAIEOA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SummonActivityBattleEndScNotify Clone()
	{
		return new SummonActivityBattleEndScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SummonActivityBattleEndScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SummonActivityBattleEndScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (NIIEKCMBENI != other.NIIEKCMBENI)
		{
			return false;
		}
		if (Star != other.Star)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (NIIEKCMBENI != 0)
		{
			num ^= NIIEKCMBENI.GetHashCode();
		}
		if (Star != 0)
		{
			num ^= Star.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GroupId);
		}
		if (NIIEKCMBENI != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(NIIEKCMBENI);
		}
		if (Star != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Star);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (NIIEKCMBENI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NIIEKCMBENI);
		}
		if (Star != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Star);
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
	public void MergeFrom(SummonActivityBattleEndScNotify other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.NIIEKCMBENI != 0)
			{
				NIIEKCMBENI = other.NIIEKCMBENI;
			}
			if (other.Star != 0)
			{
				Star = other.Star;
			}
			if (other.INOMFFAIEOA != 0)
			{
				INOMFFAIEOA = other.INOMFFAIEOA;
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
			case 16u:
				GroupId = input.ReadUInt32();
				break;
			case 56u:
				NIIEKCMBENI = input.ReadUInt32();
				break;
			case 64u:
				Star = input.ReadUInt32();
				break;
			case 120u:
				INOMFFAIEOA = input.ReadUInt32();
				break;
			}
		}
	}
}
