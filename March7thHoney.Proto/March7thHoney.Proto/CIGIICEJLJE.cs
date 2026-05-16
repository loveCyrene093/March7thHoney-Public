using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CIGIICEJLJE : IMessage<CIGIICEJLJE>, IMessage, IEquatable<CIGIICEJLJE>, IDeepCloneable<CIGIICEJLJE>, IBufferMessage
{
	private static readonly MessageParser<CIGIICEJLJE> _parser = new MessageParser<CIGIICEJLJE>(() => new CIGIICEJLJE());

	private UnknownFieldSet _unknownFields;

	public const int BaseAvatarIdListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

	public const int UnfinishedStoryLineIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_unfinishedStoryLineIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> unfinishedStoryLineIdList_ = new RepeatedField<uint>();

	public const int PropEntityIdFieldNumber = 14;

	private uint propEntityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CIGIICEJLJE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CIGIICEJLJEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BaseAvatarIdList => baseAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnfinishedStoryLineIdList => unfinishedStoryLineIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PropEntityId
	{
		get
		{
			return propEntityId_;
		}
		set
		{
			propEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGIICEJLJE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGIICEJLJE(CIGIICEJLJE other)
		: this()
	{
		baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
		unfinishedStoryLineIdList_ = other.unfinishedStoryLineIdList_.Clone();
		propEntityId_ = other.propEntityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIGIICEJLJE Clone()
	{
		return new CIGIICEJLJE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CIGIICEJLJE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CIGIICEJLJE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!baseAvatarIdList_.Equals(other.baseAvatarIdList_))
		{
			return false;
		}
		if (!unfinishedStoryLineIdList_.Equals(other.unfinishedStoryLineIdList_))
		{
			return false;
		}
		if (PropEntityId != other.PropEntityId)
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
		num ^= baseAvatarIdList_.GetHashCode();
		num ^= unfinishedStoryLineIdList_.GetHashCode();
		if (PropEntityId != 0)
		{
			num ^= PropEntityId.GetHashCode();
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
		baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
		unfinishedStoryLineIdList_.WriteTo(ref output, _repeated_unfinishedStoryLineIdList_codec);
		if (PropEntityId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PropEntityId);
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
		num += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
		num += unfinishedStoryLineIdList_.CalculateSize(_repeated_unfinishedStoryLineIdList_codec);
		if (PropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PropEntityId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CIGIICEJLJE other)
	{
		if (other != null)
		{
			baseAvatarIdList_.Add(other.baseAvatarIdList_);
			unfinishedStoryLineIdList_.Add(other.unfinishedStoryLineIdList_);
			if (other.PropEntityId != 0)
			{
				PropEntityId = other.PropEntityId;
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
			case 18u:
				baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
				break;
			case 96u:
			case 98u:
				unfinishedStoryLineIdList_.AddEntriesFrom(ref input, _repeated_unfinishedStoryLineIdList_codec);
				break;
			case 112u:
				PropEntityId = input.ReadUInt32();
				break;
			}
		}
	}
}
