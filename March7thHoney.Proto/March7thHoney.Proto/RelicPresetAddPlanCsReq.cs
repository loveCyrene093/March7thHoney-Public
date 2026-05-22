using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicPresetAddPlanCsReq : IMessage<RelicPresetAddPlanCsReq>, IMessage, IEquatable<RelicPresetAddPlanCsReq>, IDeepCloneable<RelicPresetAddPlanCsReq>, IBufferMessage
{
	private static readonly MessageParser<RelicPresetAddPlanCsReq> _parser = new MessageParser<RelicPresetAddPlanCsReq>(() => new RelicPresetAddPlanCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HBNHKPDMGIPFieldNumber = 3;

	private ENAKDNCEJBO hBNHKPDMGIP_;

	public const int RelicIdsFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_relicIds_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> relicIds_ = new RepeatedField<uint>();

	public const int AvatarIdFieldNumber = 5;

	private uint avatarId_;

	public const int NameFieldNumber = 11;

	private string name_ = "";

	public const int ALFHNEHOBJAFieldNumber = 14;

	private RelicPresetPlanSourceType aLFHNEHOBJA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicPresetAddPlanCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicPresetAddPlanCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENAKDNCEJBO HBNHKPDMGIP
	{
		get
		{
			return hBNHKPDMGIP_;
		}
		set
		{
			hBNHKPDMGIP_ = value;
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
	public RelicPresetAddPlanCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicPresetAddPlanCsReq(RelicPresetAddPlanCsReq other)
		: this()
	{
		hBNHKPDMGIP_ = other.hBNHKPDMGIP_;
		relicIds_ = other.relicIds_.Clone();
		avatarId_ = other.avatarId_;
		name_ = other.name_;
		aLFHNEHOBJA_ = other.aLFHNEHOBJA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicPresetAddPlanCsReq Clone()
	{
		return new RelicPresetAddPlanCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicPresetAddPlanCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicPresetAddPlanCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HBNHKPDMGIP != other.HBNHKPDMGIP)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (ALFHNEHOBJA != other.ALFHNEHOBJA)
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
		if (HBNHKPDMGIP != ENAKDNCEJBO.Pcpdhelpkem)
		{
			num ^= HBNHKPDMGIP.GetHashCode();
		}
		num ^= relicIds_.GetHashCode();
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
		{
			num ^= ALFHNEHOBJA.GetHashCode();
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
		if (HBNHKPDMGIP != ENAKDNCEJBO.Pcpdhelpkem)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)HBNHKPDMGIP);
		}
		relicIds_.WriteTo(ref output, _repeated_relicIds_codec);
		if (AvatarId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(AvatarId);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(Name);
		}
		if (ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)ALFHNEHOBJA);
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
		if (HBNHKPDMGIP != ENAKDNCEJBO.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HBNHKPDMGIP);
		}
		num += relicIds_.CalculateSize(_repeated_relicIds_codec);
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ALFHNEHOBJA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicPresetAddPlanCsReq other)
	{
		if (other != null)
		{
			if (other.HBNHKPDMGIP != ENAKDNCEJBO.Pcpdhelpkem)
			{
				HBNHKPDMGIP = other.HBNHKPDMGIP;
			}
			relicIds_.Add(other.relicIds_);
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
			{
				ALFHNEHOBJA = other.ALFHNEHOBJA;
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
				HBNHKPDMGIP = (ENAKDNCEJBO)input.ReadEnum();
				break;
			case 32u:
			case 34u:
				relicIds_.AddEntriesFrom(ref input, _repeated_relicIds_codec);
				break;
			case 40u:
				AvatarId = input.ReadUInt32();
				break;
			case 90u:
				Name = input.ReadString();
				break;
			case 112u:
				ALFHNEHOBJA = (RelicPresetPlanSourceType)input.ReadEnum();
				break;
			}
		}
	}
}
