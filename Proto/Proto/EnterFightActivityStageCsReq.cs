using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterFightActivityStageCsReq : IMessage<EnterFightActivityStageCsReq>, IMessage, IEquatable<EnterFightActivityStageCsReq>, IDeepCloneable<EnterFightActivityStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<EnterFightActivityStageCsReq> _parser = new MessageParser<EnterFightActivityStageCsReq>(() => new EnterFightActivityStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();

	public const int ItemListFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_itemList_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> itemList_ = new RepeatedField<uint>();

	public const int GroupIdFieldNumber = 11;

	private uint groupId_;

	public const int FDHJCBNAICBFieldNumber = 14;

	private static readonly FieldCodec<ILNEBPJCGHB> _repeated_fDHJCBNAICB_codec = FieldCodec.ForMessage(114u, ILNEBPJCGHB.Parser);

	private readonly RepeatedField<ILNEBPJCGHB> fDHJCBNAICB_ = new RepeatedField<ILNEBPJCGHB>();

	public const int INOMFFAIEOAFieldNumber = 15;

	private uint iNOMFFAIEOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterFightActivityStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterFightActivityStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ItemList => itemList_;

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
	public RepeatedField<ILNEBPJCGHB> FDHJCBNAICB => fDHJCBNAICB_;

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
	public EnterFightActivityStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterFightActivityStageCsReq(EnterFightActivityStageCsReq other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		itemList_ = other.itemList_.Clone();
		groupId_ = other.groupId_;
		fDHJCBNAICB_ = other.fDHJCBNAICB_.Clone();
		iNOMFFAIEOA_ = other.iNOMFFAIEOA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterFightActivityStageCsReq Clone()
	{
		return new EnterFightActivityStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterFightActivityStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterFightActivityStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (!fDHJCBNAICB_.Equals(other.fDHJCBNAICB_))
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
		num ^= avatarList_.GetHashCode();
		num ^= itemList_.GetHashCode();
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= fDHJCBNAICB_.GetHashCode();
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
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		itemList_.WriteTo(ref output, _repeated_itemList_codec);
		if (GroupId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GroupId);
		}
		fDHJCBNAICB_.WriteTo(ref output, _repeated_fDHJCBNAICB_codec);
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
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		num += fDHJCBNAICB_.CalculateSize(_repeated_fDHJCBNAICB_codec);
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
	public void MergeFrom(EnterFightActivityStageCsReq other)
	{
		if (other != null)
		{
			avatarList_.Add(other.avatarList_);
			itemList_.Add(other.itemList_);
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			fDHJCBNAICB_.Add(other.fDHJCBNAICB_);
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
			case 24u:
			case 26u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 64u:
			case 66u:
				itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
				break;
			case 88u:
				GroupId = input.ReadUInt32();
				break;
			case 114u:
				fDHJCBNAICB_.AddEntriesFrom(ref input, _repeated_fDHJCBNAICB_codec);
				break;
			case 120u:
				INOMFFAIEOA = input.ReadUInt32();
				break;
			}
		}
	}
}
