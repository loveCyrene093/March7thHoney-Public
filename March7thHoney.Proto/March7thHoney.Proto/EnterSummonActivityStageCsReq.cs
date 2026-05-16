using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterSummonActivityStageCsReq : IMessage<EnterSummonActivityStageCsReq>, IMessage, IEquatable<EnterSummonActivityStageCsReq>, IDeepCloneable<EnterSummonActivityStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<EnterSummonActivityStageCsReq> _parser = new MessageParser<EnterSummonActivityStageCsReq>(() => new EnterSummonActivityStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int INOMFFAIEOAFieldNumber = 1;

	private uint iNOMFFAIEOA_;

	public const int ABJFJBECCDJFieldNumber = 3;

	private OLPDNLJLFDL aBJFJBECCDJ_;

	public const int GroupIdFieldNumber = 8;

	private uint groupId_;

	public const int AvatarListFieldNumber = 11;

	private static readonly FieldCodec<OLPDNLJLFDL> _repeated_avatarList_codec = FieldCodec.ForMessage(90u, OLPDNLJLFDL.Parser);

	private readonly RepeatedField<OLPDNLJLFDL> avatarList_ = new RepeatedField<OLPDNLJLFDL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterSummonActivityStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterSummonActivityStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public OLPDNLJLFDL ABJFJBECCDJ
	{
		get
		{
			return aBJFJBECCDJ_;
		}
		set
		{
			aBJFJBECCDJ_ = value;
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
	public RepeatedField<OLPDNLJLFDL> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSummonActivityStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSummonActivityStageCsReq(EnterSummonActivityStageCsReq other)
		: this()
	{
		iNOMFFAIEOA_ = other.iNOMFFAIEOA_;
		aBJFJBECCDJ_ = ((other.aBJFJBECCDJ_ != null) ? other.aBJFJBECCDJ_.Clone() : null);
		groupId_ = other.groupId_;
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterSummonActivityStageCsReq Clone()
	{
		return new EnterSummonActivityStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterSummonActivityStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterSummonActivityStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (INOMFFAIEOA != other.INOMFFAIEOA)
		{
			return false;
		}
		if (!object.Equals(ABJFJBECCDJ, other.ABJFJBECCDJ))
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
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
		if (INOMFFAIEOA != 0)
		{
			num ^= INOMFFAIEOA.GetHashCode();
		}
		if (aBJFJBECCDJ_ != null)
		{
			num ^= ABJFJBECCDJ.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
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
		if (INOMFFAIEOA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(INOMFFAIEOA);
		}
		if (aBJFJBECCDJ_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ABJFJBECCDJ);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GroupId);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
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
		if (INOMFFAIEOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INOMFFAIEOA);
		}
		if (aBJFJBECCDJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ABJFJBECCDJ);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterSummonActivityStageCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.INOMFFAIEOA != 0)
		{
			INOMFFAIEOA = other.INOMFFAIEOA;
		}
		if (other.aBJFJBECCDJ_ != null)
		{
			if (aBJFJBECCDJ_ == null)
			{
				ABJFJBECCDJ = new OLPDNLJLFDL();
			}
			ABJFJBECCDJ.MergeFrom(other.ABJFJBECCDJ);
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		avatarList_.Add(other.avatarList_);
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
			case 8u:
				INOMFFAIEOA = input.ReadUInt32();
				break;
			case 26u:
				if (aBJFJBECCDJ_ == null)
				{
					ABJFJBECCDJ = new OLPDNLJLFDL();
				}
				input.ReadMessage(ABJFJBECCDJ);
				break;
			case 64u:
				GroupId = input.ReadUInt32();
				break;
			case 90u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
