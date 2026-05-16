using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NCDCKHHPDDE : IMessage<NCDCKHHPDDE>, IMessage, IEquatable<NCDCKHHPDDE>, IDeepCloneable<NCDCKHHPDDE>, IBufferMessage
{
	private static readonly MessageParser<NCDCKHHPDDE> _parser = new MessageParser<NCDCKHHPDDE>(() => new NCDCKHHPDDE());

	private UnknownFieldSet _unknownFields;

	public const int MGHHCOEIDHEFieldNumber = 4;

	private uint mGHHCOEIDHE_;

	public const int JFANNGJEEECFieldNumber = 5;

	private uint jFANNGJEEEC_;

	public const int EDIGFNFPBKAFieldNumber = 12;

	private uint eDIGFNFPBKA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NCDCKHHPDDE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NCDCKHHPDDEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGHHCOEIDHE
	{
		get
		{
			return mGHHCOEIDHE_;
		}
		set
		{
			mGHHCOEIDHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JFANNGJEEEC
	{
		get
		{
			return jFANNGJEEEC_;
		}
		set
		{
			jFANNGJEEEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDIGFNFPBKA
	{
		get
		{
			return eDIGFNFPBKA_;
		}
		set
		{
			eDIGFNFPBKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCDCKHHPDDE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCDCKHHPDDE(NCDCKHHPDDE other)
		: this()
	{
		mGHHCOEIDHE_ = other.mGHHCOEIDHE_;
		jFANNGJEEEC_ = other.jFANNGJEEEC_;
		eDIGFNFPBKA_ = other.eDIGFNFPBKA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCDCKHHPDDE Clone()
	{
		return new NCDCKHHPDDE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NCDCKHHPDDE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NCDCKHHPDDE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MGHHCOEIDHE != other.MGHHCOEIDHE)
		{
			return false;
		}
		if (JFANNGJEEEC != other.JFANNGJEEEC)
		{
			return false;
		}
		if (EDIGFNFPBKA != other.EDIGFNFPBKA)
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
		if (MGHHCOEIDHE != 0)
		{
			num ^= MGHHCOEIDHE.GetHashCode();
		}
		if (JFANNGJEEEC != 0)
		{
			num ^= JFANNGJEEEC.GetHashCode();
		}
		if (EDIGFNFPBKA != 0)
		{
			num ^= EDIGFNFPBKA.GetHashCode();
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
		if (MGHHCOEIDHE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MGHHCOEIDHE);
		}
		if (JFANNGJEEEC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(JFANNGJEEEC);
		}
		if (EDIGFNFPBKA != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(EDIGFNFPBKA);
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
		if (MGHHCOEIDHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGHHCOEIDHE);
		}
		if (JFANNGJEEEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JFANNGJEEEC);
		}
		if (EDIGFNFPBKA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDIGFNFPBKA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NCDCKHHPDDE other)
	{
		if (other != null)
		{
			if (other.MGHHCOEIDHE != 0)
			{
				MGHHCOEIDHE = other.MGHHCOEIDHE;
			}
			if (other.JFANNGJEEEC != 0)
			{
				JFANNGJEEEC = other.JFANNGJEEEC;
			}
			if (other.EDIGFNFPBKA != 0)
			{
				EDIGFNFPBKA = other.EDIGFNFPBKA;
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
			case 32u:
				MGHHCOEIDHE = input.ReadUInt32();
				break;
			case 40u:
				JFANNGJEEEC = input.ReadUInt32();
				break;
			case 96u:
				EDIGFNFPBKA = input.ReadUInt32();
				break;
			}
		}
	}
}
