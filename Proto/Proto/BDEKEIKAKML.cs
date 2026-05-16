using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BDEKEIKAKML : IMessage<BDEKEIKAKML>, IMessage, IEquatable<BDEKEIKAKML>, IDeepCloneable<BDEKEIKAKML>, IBufferMessage
{
	private static readonly MessageParser<BDEKEIKAKML> _parser = new MessageParser<BDEKEIKAKML>(() => new BDEKEIKAKML());

	private UnknownFieldSet _unknownFields;

	public const int RelicIdsFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_relicIds_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> relicIds_ = new RepeatedField<uint>();

	public const int DFIEHPIHEEEFieldNumber = 8;

	private NHFOGDPBOHN dFIEHPIHEEE_;

	public const int AvatarIdFieldNumber = 15;

	private uint avatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BDEKEIKAKML> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BDEKEIKAKMLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> RelicIds => relicIds_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHFOGDPBOHN DFIEHPIHEEE
	{
		get
		{
			return dFIEHPIHEEE_;
		}
		set
		{
			dFIEHPIHEEE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDEKEIKAKML()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDEKEIKAKML(BDEKEIKAKML other)
		: this()
	{
		relicIds_ = other.relicIds_.Clone();
		dFIEHPIHEEE_ = ((other.dFIEHPIHEEE_ != null) ? other.dFIEHPIHEEE_.Clone() : null);
		avatarId_ = other.avatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDEKEIKAKML Clone()
	{
		return new BDEKEIKAKML(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BDEKEIKAKML);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BDEKEIKAKML other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!relicIds_.Equals(other.relicIds_))
		{
			return false;
		}
		if (!object.Equals(DFIEHPIHEEE, other.DFIEHPIHEEE))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
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
		num ^= relicIds_.GetHashCode();
		if (dFIEHPIHEEE_ != null)
		{
			num ^= DFIEHPIHEEE.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
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
		relicIds_.WriteTo(ref output, _repeated_relicIds_codec);
		if (dFIEHPIHEEE_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(DFIEHPIHEEE);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(AvatarId);
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
		num += relicIds_.CalculateSize(_repeated_relicIds_codec);
		if (dFIEHPIHEEE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DFIEHPIHEEE);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BDEKEIKAKML other)
	{
		if (other == null)
		{
			return;
		}
		relicIds_.Add(other.relicIds_);
		if (other.dFIEHPIHEEE_ != null)
		{
			if (dFIEHPIHEEE_ == null)
			{
				DFIEHPIHEEE = new NHFOGDPBOHN();
			}
			DFIEHPIHEEE.MergeFrom(other.DFIEHPIHEEE);
		}
		if (other.AvatarId != 0)
		{
			AvatarId = other.AvatarId;
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
			case 8u:
			case 10u:
				relicIds_.AddEntriesFrom(ref input, _repeated_relicIds_codec);
				break;
			case 66u:
				if (dFIEHPIHEEE_ == null)
				{
					DFIEHPIHEEE = new NHFOGDPBOHN();
				}
				input.ReadMessage(DFIEHPIHEEE);
				break;
			case 120u:
				AvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}
