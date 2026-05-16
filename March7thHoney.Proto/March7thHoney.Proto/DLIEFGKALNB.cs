using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DLIEFGKALNB : IMessage<DLIEFGKALNB>, IMessage, IEquatable<DLIEFGKALNB>, IDeepCloneable<DLIEFGKALNB>, IBufferMessage
{
	private static readonly MessageParser<DLIEFGKALNB> _parser = new MessageParser<DLIEFGKALNB>(() => new DLIEFGKALNB());

	private UnknownFieldSet _unknownFields;

	public const int GridFightAvatarListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_gridFightAvatarList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> gridFightAvatarList_ = new RepeatedField<uint>();

	public const int GridFightTraitMemberUniqueIdListFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_gridFightTraitMemberUniqueIdList_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> gridFightTraitMemberUniqueIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DLIEFGKALNB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DLIEFGKALNBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightAvatarList => gridFightAvatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightTraitMemberUniqueIdList => gridFightTraitMemberUniqueIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLIEFGKALNB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLIEFGKALNB(DLIEFGKALNB other)
		: this()
	{
		gridFightAvatarList_ = other.gridFightAvatarList_.Clone();
		gridFightTraitMemberUniqueIdList_ = other.gridFightTraitMemberUniqueIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLIEFGKALNB Clone()
	{
		return new DLIEFGKALNB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DLIEFGKALNB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DLIEFGKALNB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightAvatarList_.Equals(other.gridFightAvatarList_))
		{
			return false;
		}
		if (!gridFightTraitMemberUniqueIdList_.Equals(other.gridFightTraitMemberUniqueIdList_))
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
		num ^= gridFightAvatarList_.GetHashCode();
		num ^= gridFightTraitMemberUniqueIdList_.GetHashCode();
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
		gridFightAvatarList_.WriteTo(ref output, _repeated_gridFightAvatarList_codec);
		gridFightTraitMemberUniqueIdList_.WriteTo(ref output, _repeated_gridFightTraitMemberUniqueIdList_codec);
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
		num += gridFightAvatarList_.CalculateSize(_repeated_gridFightAvatarList_codec);
		num += gridFightTraitMemberUniqueIdList_.CalculateSize(_repeated_gridFightTraitMemberUniqueIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DLIEFGKALNB other)
	{
		if (other != null)
		{
			gridFightAvatarList_.Add(other.gridFightAvatarList_);
			gridFightTraitMemberUniqueIdList_.Add(other.gridFightTraitMemberUniqueIdList_);
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
				gridFightAvatarList_.AddEntriesFrom(ref input, _repeated_gridFightAvatarList_codec);
				break;
			case 112u:
			case 114u:
				gridFightTraitMemberUniqueIdList_.AddEntriesFrom(ref input, _repeated_gridFightTraitMemberUniqueIdList_codec);
				break;
			}
		}
	}
}
