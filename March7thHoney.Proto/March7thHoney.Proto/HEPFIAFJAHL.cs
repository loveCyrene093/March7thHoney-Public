using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HEPFIAFJAHL : IMessage<HEPFIAFJAHL>, IMessage, IEquatable<HEPFIAFJAHL>, IDeepCloneable<HEPFIAFJAHL>, IBufferMessage
{
	private static readonly MessageParser<HEPFIAFJAHL> _parser = new MessageParser<HEPFIAFJAHL>(() => new HEPFIAFJAHL());

	private UnknownFieldSet _unknownFields;

	public const int EffectIdFieldNumber = 2;

	private uint effectId_;

	public const int DJBLFGFDNCAFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_dJBLFGFDNCA_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> dJBLFGFDNCA_ = new RepeatedField<uint>();

	public const int BNAMECLCJAKFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_bNAMECLCJAK_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> bNAMECLCJAK_ = new RepeatedField<uint>();

	public const int DOGFDDNCFOPFieldNumber = 9;

	private bool dOGFDDNCFOP_;

	public const int TraitIdFieldNumber = 12;

	private uint traitId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HEPFIAFJAHL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HEPFIAFJAHLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EffectId
	{
		get
		{
			return effectId_;
		}
		set
		{
			effectId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DJBLFGFDNCA => dJBLFGFDNCA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BNAMECLCJAK => bNAMECLCJAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DOGFDDNCFOP
	{
		get
		{
			return dOGFDDNCFOP_;
		}
		set
		{
			dOGFDDNCFOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitId
	{
		get
		{
			return traitId_;
		}
		set
		{
			traitId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEPFIAFJAHL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEPFIAFJAHL(HEPFIAFJAHL other)
		: this()
	{
		effectId_ = other.effectId_;
		dJBLFGFDNCA_ = other.dJBLFGFDNCA_.Clone();
		bNAMECLCJAK_ = other.bNAMECLCJAK_.Clone();
		dOGFDDNCFOP_ = other.dOGFDDNCFOP_;
		traitId_ = other.traitId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEPFIAFJAHL Clone()
	{
		return new HEPFIAFJAHL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HEPFIAFJAHL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HEPFIAFJAHL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EffectId != other.EffectId)
		{
			return false;
		}
		if (!dJBLFGFDNCA_.Equals(other.dJBLFGFDNCA_))
		{
			return false;
		}
		if (!bNAMECLCJAK_.Equals(other.bNAMECLCJAK_))
		{
			return false;
		}
		if (DOGFDDNCFOP != other.DOGFDDNCFOP)
		{
			return false;
		}
		if (TraitId != other.TraitId)
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
		if (EffectId != 0)
		{
			num ^= EffectId.GetHashCode();
		}
		num ^= dJBLFGFDNCA_.GetHashCode();
		num ^= bNAMECLCJAK_.GetHashCode();
		if (DOGFDDNCFOP)
		{
			num ^= DOGFDDNCFOP.GetHashCode();
		}
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
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
		if (EffectId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EffectId);
		}
		dJBLFGFDNCA_.WriteTo(ref output, _repeated_dJBLFGFDNCA_codec);
		bNAMECLCJAK_.WriteTo(ref output, _repeated_bNAMECLCJAK_codec);
		if (DOGFDDNCFOP)
		{
			output.WriteRawTag(72);
			output.WriteBool(DOGFDDNCFOP);
		}
		if (TraitId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(TraitId);
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
		if (EffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EffectId);
		}
		num += dJBLFGFDNCA_.CalculateSize(_repeated_dJBLFGFDNCA_codec);
		num += bNAMECLCJAK_.CalculateSize(_repeated_bNAMECLCJAK_codec);
		if (DOGFDDNCFOP)
		{
			num += 2;
		}
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HEPFIAFJAHL other)
	{
		if (other != null)
		{
			if (other.EffectId != 0)
			{
				EffectId = other.EffectId;
			}
			dJBLFGFDNCA_.Add(other.dJBLFGFDNCA_);
			bNAMECLCJAK_.Add(other.bNAMECLCJAK_);
			if (other.DOGFDDNCFOP)
			{
				DOGFDDNCFOP = other.DOGFDDNCFOP;
			}
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
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
				EffectId = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				dJBLFGFDNCA_.AddEntriesFrom(ref input, _repeated_dJBLFGFDNCA_codec);
				break;
			case 48u:
			case 50u:
				bNAMECLCJAK_.AddEntriesFrom(ref input, _repeated_bNAMECLCJAK_codec);
				break;
			case 72u:
				DOGFDDNCFOP = input.ReadBool();
				break;
			case 96u:
				TraitId = input.ReadUInt32();
				break;
			}
		}
	}
}
