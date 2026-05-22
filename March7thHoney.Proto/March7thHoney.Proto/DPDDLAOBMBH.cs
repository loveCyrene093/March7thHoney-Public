using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPDDLAOBMBH : IMessage<DPDDLAOBMBH>, IMessage, IEquatable<DPDDLAOBMBH>, IDeepCloneable<DPDDLAOBMBH>, IBufferMessage
{
	private static readonly MessageParser<DPDDLAOBMBH> _parser = new MessageParser<DPDDLAOBMBH>(() => new DPDDLAOBMBH());

	private UnknownFieldSet _unknownFields;

	public const int HBNHKPDMGIPFieldNumber = 6;

	private ENAKDNCEJBO hBNHKPDMGIP_;

	public const int ALFHNEHOBJAFieldNumber = 13;

	private RelicPresetPlanSourceType aLFHNEHOBJA_;

	public const int RelicIdsFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_relicIds_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> relicIds_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPDDLAOBMBH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPDDLAOBMBHReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> RelicIds => relicIds_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPDDLAOBMBH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPDDLAOBMBH(DPDDLAOBMBH other)
		: this()
	{
		hBNHKPDMGIP_ = other.hBNHKPDMGIP_;
		aLFHNEHOBJA_ = other.aLFHNEHOBJA_;
		relicIds_ = other.relicIds_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPDDLAOBMBH Clone()
	{
		return new DPDDLAOBMBH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPDDLAOBMBH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPDDLAOBMBH other)
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
		if (ALFHNEHOBJA != other.ALFHNEHOBJA)
		{
			return false;
		}
		if (!relicIds_.Equals(other.relicIds_))
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
		if (ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
		{
			num ^= ALFHNEHOBJA.GetHashCode();
		}
		num ^= relicIds_.GetHashCode();
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
			output.WriteRawTag(48);
			output.WriteEnum((int)HBNHKPDMGIP);
		}
		if (ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)ALFHNEHOBJA);
		}
		relicIds_.WriteTo(ref output, _repeated_relicIds_codec);
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
		if (ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ALFHNEHOBJA);
		}
		num += relicIds_.CalculateSize(_repeated_relicIds_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPDDLAOBMBH other)
	{
		if (other != null)
		{
			if (other.HBNHKPDMGIP != ENAKDNCEJBO.Pcpdhelpkem)
			{
				HBNHKPDMGIP = other.HBNHKPDMGIP;
			}
			if (other.ALFHNEHOBJA != RelicPresetPlanSourceType.KhimaphkdliPcpdhelpkem)
			{
				ALFHNEHOBJA = other.ALFHNEHOBJA;
			}
			relicIds_.Add(other.relicIds_);
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
			case 48u:
				HBNHKPDMGIP = (ENAKDNCEJBO)input.ReadEnum();
				break;
			case 104u:
				ALFHNEHOBJA = (RelicPresetPlanSourceType)input.ReadEnum();
				break;
			case 112u:
			case 114u:
				relicIds_.AddEntriesFrom(ref input, _repeated_relicIds_codec);
				break;
			}
		}
	}
}
