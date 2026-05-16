using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NBMFOJAKMGP : IMessage<NBMFOJAKMGP>, IMessage, IEquatable<NBMFOJAKMGP>, IDeepCloneable<NBMFOJAKMGP>, IBufferMessage
{
	private static readonly MessageParser<NBMFOJAKMGP> _parser = new MessageParser<NBMFOJAKMGP>(() => new NBMFOJAKMGP());

	private UnknownFieldSet _unknownFields;

	public const int ALFHNEHOBJAFieldNumber = 3;

	private RelicPresetPlanSourceType aLFHNEHOBJA_;

	public const int NameFieldNumber = 5;

	private string name_ = "";

	public const int RelicIdsFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_relicIds_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> relicIds_ = new RepeatedField<uint>();

	public const int AvatarIdFieldNumber = 13;

	private uint avatarId_;

	public const int UniqueIdFieldNumber = 15;

	private uint uniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NBMFOJAKMGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NBMFOJAKMGPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicPresetPlanSourceType ALFHNEHOBJA
	{
		get
		{
			return aLFHNEHOBJA_;
		}
		set
		{
			aLFHNEHOBJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> RelicIds => relicIds_;

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
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBMFOJAKMGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBMFOJAKMGP(NBMFOJAKMGP other)
		: this()
	{
		aLFHNEHOBJA_ = other.aLFHNEHOBJA_;
		name_ = other.name_;
		relicIds_ = other.relicIds_.Clone();
		avatarId_ = other.avatarId_;
		uniqueId_ = other.uniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBMFOJAKMGP Clone()
	{
		return new NBMFOJAKMGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NBMFOJAKMGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NBMFOJAKMGP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ALFHNEHOBJA != other.ALFHNEHOBJA)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (!relicIds_.Equals(other.relicIds_))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
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
		if (ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
		{
			num ^= ALFHNEHOBJA.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		num ^= relicIds_.GetHashCode();
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
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
		if (ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ALFHNEHOBJA);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Name);
		}
		relicIds_.WriteTo(ref output, _repeated_relicIds_codec);
		if (AvatarId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(AvatarId);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(UniqueId);
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
		if (ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ALFHNEHOBJA);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		num += relicIds_.CalculateSize(_repeated_relicIds_codec);
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NBMFOJAKMGP other)
	{
		if (other != null)
		{
			if (other.ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
			{
				ALFHNEHOBJA = other.ALFHNEHOBJA;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			relicIds_.Add(other.relicIds_);
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
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
				ALFHNEHOBJA = (RelicPresetPlanSourceType)input.ReadEnum();
				break;
			case 42u:
				Name = input.ReadString();
				break;
			case 64u:
			case 66u:
				relicIds_.AddEntriesFrom(ref input, _repeated_relicIds_codec);
				break;
			case 104u:
				AvatarId = input.ReadUInt32();
				break;
			case 120u:
				UniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
