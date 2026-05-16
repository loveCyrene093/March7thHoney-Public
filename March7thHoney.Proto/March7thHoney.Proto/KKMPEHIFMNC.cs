using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KKMPEHIFMNC : IMessage<KKMPEHIFMNC>, IMessage, IEquatable<KKMPEHIFMNC>, IDeepCloneable<KKMPEHIFMNC>, IBufferMessage
{
	private static readonly MessageParser<KKMPEHIFMNC> _parser = new MessageParser<KKMPEHIFMNC>(() => new KKMPEHIFMNC());

	private UnknownFieldSet _unknownFields;

	public const int JBNFILFNFMCFieldNumber = 7;

	private uint jBNFILFNFMC_;

	public const int DKJFDLKJLBEFieldNumber = 9;

	private bool dKJFDLKJLBE_;

	public const int CAHNHPANKICFieldNumber = 13;

	private uint cAHNHPANKIC_;

	public const int PAMHEDDIEJAFieldNumber = 14;

	private uint pAMHEDDIEJA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KKMPEHIFMNC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KKMPEHIFMNCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JBNFILFNFMC
	{
		get
		{
			return jBNFILFNFMC_;
		}
		set
		{
			jBNFILFNFMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DKJFDLKJLBE
	{
		get
		{
			return dKJFDLKJLBE_;
		}
		set
		{
			dKJFDLKJLBE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CAHNHPANKIC
	{
		get
		{
			return cAHNHPANKIC_;
		}
		set
		{
			cAHNHPANKIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PAMHEDDIEJA
	{
		get
		{
			return pAMHEDDIEJA_;
		}
		set
		{
			pAMHEDDIEJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKMPEHIFMNC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKMPEHIFMNC(KKMPEHIFMNC other)
		: this()
	{
		jBNFILFNFMC_ = other.jBNFILFNFMC_;
		dKJFDLKJLBE_ = other.dKJFDLKJLBE_;
		cAHNHPANKIC_ = other.cAHNHPANKIC_;
		pAMHEDDIEJA_ = other.pAMHEDDIEJA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKMPEHIFMNC Clone()
	{
		return new KKMPEHIFMNC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KKMPEHIFMNC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KKMPEHIFMNC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JBNFILFNFMC != other.JBNFILFNFMC)
		{
			return false;
		}
		if (DKJFDLKJLBE != other.DKJFDLKJLBE)
		{
			return false;
		}
		if (CAHNHPANKIC != other.CAHNHPANKIC)
		{
			return false;
		}
		if (PAMHEDDIEJA != other.PAMHEDDIEJA)
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
		if (JBNFILFNFMC != 0)
		{
			num ^= JBNFILFNFMC.GetHashCode();
		}
		if (DKJFDLKJLBE)
		{
			num ^= DKJFDLKJLBE.GetHashCode();
		}
		if (CAHNHPANKIC != 0)
		{
			num ^= CAHNHPANKIC.GetHashCode();
		}
		if (PAMHEDDIEJA != 0)
		{
			num ^= PAMHEDDIEJA.GetHashCode();
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
		if (JBNFILFNFMC != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(JBNFILFNFMC);
		}
		if (DKJFDLKJLBE)
		{
			output.WriteRawTag(72);
			output.WriteBool(DKJFDLKJLBE);
		}
		if (CAHNHPANKIC != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CAHNHPANKIC);
		}
		if (PAMHEDDIEJA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PAMHEDDIEJA);
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
		if (JBNFILFNFMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JBNFILFNFMC);
		}
		if (DKJFDLKJLBE)
		{
			num += 2;
		}
		if (CAHNHPANKIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CAHNHPANKIC);
		}
		if (PAMHEDDIEJA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PAMHEDDIEJA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KKMPEHIFMNC other)
	{
		if (other != null)
		{
			if (other.JBNFILFNFMC != 0)
			{
				JBNFILFNFMC = other.JBNFILFNFMC;
			}
			if (other.DKJFDLKJLBE)
			{
				DKJFDLKJLBE = other.DKJFDLKJLBE;
			}
			if (other.CAHNHPANKIC != 0)
			{
				CAHNHPANKIC = other.CAHNHPANKIC;
			}
			if (other.PAMHEDDIEJA != 0)
			{
				PAMHEDDIEJA = other.PAMHEDDIEJA;
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
			case 56u:
				JBNFILFNFMC = input.ReadUInt32();
				break;
			case 72u:
				DKJFDLKJLBE = input.ReadBool();
				break;
			case 104u:
				CAHNHPANKIC = input.ReadUInt32();
				break;
			case 112u:
				PAMHEDDIEJA = input.ReadUInt32();
				break;
			}
		}
	}
}
