using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BBMGPIKBJJC : IMessage<BBMGPIKBJJC>, IMessage, IEquatable<BBMGPIKBJJC>, IDeepCloneable<BBMGPIKBJJC>, IBufferMessage
{
	private static readonly MessageParser<BBMGPIKBJJC> _parser = new MessageParser<BBMGPIKBJJC>(() => new BBMGPIKBJJC());

	private UnknownFieldSet _unknownFields;

	public const int GameModeTypeFieldNumber = 3;

	private uint gameModeType_;

	public const int HEOKGAKLFPMFieldNumber = 9;

	private static readonly FieldCodec<LGLGCCJEKCL> _repeated_hEOKGAKLFPM_codec = FieldCodec.ForMessage(74u, LGLGCCJEKCL.Parser);

	private readonly RepeatedField<LGLGCCJEKCL> hEOKGAKLFPM_ = new RepeatedField<LGLGCCJEKCL>();

	public const int HOHANPJNANAFieldNumber = 12;

	private uint hOHANPJNANA_;

	public const int AHKFFCIEPDGFieldNumber = 13;

	private uint aHKFFCIEPDG_;

	public const int EGABLBJIJCKFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_eGABLBJIJCK_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> eGABLBJIJCK_ = new RepeatedField<uint>();

	public const int JBEILMFIIGMFieldNumber = 15;

	private uint jBEILMFIIGM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BBMGPIKBJJC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BBMGPIKBJJCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GameModeType
	{
		get
		{
			return gameModeType_;
		}
		set
		{
			gameModeType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LGLGCCJEKCL> HEOKGAKLFPM => hEOKGAKLFPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HOHANPJNANA
	{
		get
		{
			return hOHANPJNANA_;
		}
		set
		{
			hOHANPJNANA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AHKFFCIEPDG
	{
		get
		{
			return aHKFFCIEPDG_;
		}
		set
		{
			aHKFFCIEPDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EGABLBJIJCK => eGABLBJIJCK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JBEILMFIIGM
	{
		get
		{
			return jBEILMFIIGM_;
		}
		set
		{
			jBEILMFIIGM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBMGPIKBJJC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBMGPIKBJJC(BBMGPIKBJJC other)
		: this()
	{
		gameModeType_ = other.gameModeType_;
		hEOKGAKLFPM_ = other.hEOKGAKLFPM_.Clone();
		hOHANPJNANA_ = other.hOHANPJNANA_;
		aHKFFCIEPDG_ = other.aHKFFCIEPDG_;
		eGABLBJIJCK_ = other.eGABLBJIJCK_.Clone();
		jBEILMFIIGM_ = other.jBEILMFIIGM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBMGPIKBJJC Clone()
	{
		return new BBMGPIKBJJC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BBMGPIKBJJC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BBMGPIKBJJC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GameModeType != other.GameModeType)
		{
			return false;
		}
		if (!hEOKGAKLFPM_.Equals(other.hEOKGAKLFPM_))
		{
			return false;
		}
		if (HOHANPJNANA != other.HOHANPJNANA)
		{
			return false;
		}
		if (AHKFFCIEPDG != other.AHKFFCIEPDG)
		{
			return false;
		}
		if (!eGABLBJIJCK_.Equals(other.eGABLBJIJCK_))
		{
			return false;
		}
		if (JBEILMFIIGM != other.JBEILMFIIGM)
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
		if (GameModeType != 0)
		{
			num ^= GameModeType.GetHashCode();
		}
		num ^= hEOKGAKLFPM_.GetHashCode();
		if (HOHANPJNANA != 0)
		{
			num ^= HOHANPJNANA.GetHashCode();
		}
		if (AHKFFCIEPDG != 0)
		{
			num ^= AHKFFCIEPDG.GetHashCode();
		}
		num ^= eGABLBJIJCK_.GetHashCode();
		if (JBEILMFIIGM != 0)
		{
			num ^= JBEILMFIIGM.GetHashCode();
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
		if (GameModeType != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GameModeType);
		}
		hEOKGAKLFPM_.WriteTo(ref output, _repeated_hEOKGAKLFPM_codec);
		if (HOHANPJNANA != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(HOHANPJNANA);
		}
		if (AHKFFCIEPDG != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(AHKFFCIEPDG);
		}
		eGABLBJIJCK_.WriteTo(ref output, _repeated_eGABLBJIJCK_codec);
		if (JBEILMFIIGM != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(JBEILMFIIGM);
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
		if (GameModeType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GameModeType);
		}
		num += hEOKGAKLFPM_.CalculateSize(_repeated_hEOKGAKLFPM_codec);
		if (HOHANPJNANA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HOHANPJNANA);
		}
		if (AHKFFCIEPDG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AHKFFCIEPDG);
		}
		num += eGABLBJIJCK_.CalculateSize(_repeated_eGABLBJIJCK_codec);
		if (JBEILMFIIGM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JBEILMFIIGM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BBMGPIKBJJC other)
	{
		if (other != null)
		{
			if (other.GameModeType != 0)
			{
				GameModeType = other.GameModeType;
			}
			hEOKGAKLFPM_.Add(other.hEOKGAKLFPM_);
			if (other.HOHANPJNANA != 0)
			{
				HOHANPJNANA = other.HOHANPJNANA;
			}
			if (other.AHKFFCIEPDG != 0)
			{
				AHKFFCIEPDG = other.AHKFFCIEPDG;
			}
			eGABLBJIJCK_.Add(other.eGABLBJIJCK_);
			if (other.JBEILMFIIGM != 0)
			{
				JBEILMFIIGM = other.JBEILMFIIGM;
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
				GameModeType = input.ReadUInt32();
				break;
			case 74u:
				hEOKGAKLFPM_.AddEntriesFrom(ref input, _repeated_hEOKGAKLFPM_codec);
				break;
			case 96u:
				HOHANPJNANA = input.ReadUInt32();
				break;
			case 104u:
				AHKFFCIEPDG = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				eGABLBJIJCK_.AddEntriesFrom(ref input, _repeated_eGABLBJIJCK_codec);
				break;
			case 120u:
				JBEILMFIIGM = input.ReadUInt32();
				break;
			}
		}
	}
}
