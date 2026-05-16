using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CFOIFABCGAE : IMessage<CFOIFABCGAE>, IMessage, IEquatable<CFOIFABCGAE>, IDeepCloneable<CFOIFABCGAE>, IBufferMessage
{
	private static readonly MessageParser<CFOIFABCGAE> _parser = new MessageParser<CFOIFABCGAE>(() => new CFOIFABCGAE());

	private UnknownFieldSet _unknownFields;

	public const int IKLDFMBGHGBFieldNumber = 5;

	private uint iKLDFMBGHGB_;

	public const int NAFLDJFCCPCFieldNumber = 9;

	private uint nAFLDJFCCPC_;

	public const int DKJFDLKJLBEFieldNumber = 11;

	private bool dKJFDLKJLBE_;

	public const int IAHOBGFDBMLFieldNumber = 14;

	private uint iAHOBGFDBML_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CFOIFABCGAE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CFOIFABCGAEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IKLDFMBGHGB
	{
		get
		{
			return iKLDFMBGHGB_;
		}
		set
		{
			iKLDFMBGHGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NAFLDJFCCPC
	{
		get
		{
			return nAFLDJFCCPC_;
		}
		set
		{
			nAFLDJFCCPC_ = value;
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
	public uint IAHOBGFDBML
	{
		get
		{
			return iAHOBGFDBML_;
		}
		set
		{
			iAHOBGFDBML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFOIFABCGAE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFOIFABCGAE(CFOIFABCGAE other)
		: this()
	{
		iKLDFMBGHGB_ = other.iKLDFMBGHGB_;
		nAFLDJFCCPC_ = other.nAFLDJFCCPC_;
		dKJFDLKJLBE_ = other.dKJFDLKJLBE_;
		iAHOBGFDBML_ = other.iAHOBGFDBML_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CFOIFABCGAE Clone()
	{
		return new CFOIFABCGAE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CFOIFABCGAE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CFOIFABCGAE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IKLDFMBGHGB != other.IKLDFMBGHGB)
		{
			return false;
		}
		if (NAFLDJFCCPC != other.NAFLDJFCCPC)
		{
			return false;
		}
		if (DKJFDLKJLBE != other.DKJFDLKJLBE)
		{
			return false;
		}
		if (IAHOBGFDBML != other.IAHOBGFDBML)
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
		if (IKLDFMBGHGB != 0)
		{
			num ^= IKLDFMBGHGB.GetHashCode();
		}
		if (NAFLDJFCCPC != 0)
		{
			num ^= NAFLDJFCCPC.GetHashCode();
		}
		if (DKJFDLKJLBE)
		{
			num ^= DKJFDLKJLBE.GetHashCode();
		}
		if (IAHOBGFDBML != 0)
		{
			num ^= IAHOBGFDBML.GetHashCode();
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
		if (IKLDFMBGHGB != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(IKLDFMBGHGB);
		}
		if (NAFLDJFCCPC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(NAFLDJFCCPC);
		}
		if (DKJFDLKJLBE)
		{
			output.WriteRawTag(88);
			output.WriteBool(DKJFDLKJLBE);
		}
		if (IAHOBGFDBML != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(IAHOBGFDBML);
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
		if (IKLDFMBGHGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IKLDFMBGHGB);
		}
		if (NAFLDJFCCPC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NAFLDJFCCPC);
		}
		if (DKJFDLKJLBE)
		{
			num += 2;
		}
		if (IAHOBGFDBML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IAHOBGFDBML);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CFOIFABCGAE other)
	{
		if (other != null)
		{
			if (other.IKLDFMBGHGB != 0)
			{
				IKLDFMBGHGB = other.IKLDFMBGHGB;
			}
			if (other.NAFLDJFCCPC != 0)
			{
				NAFLDJFCCPC = other.NAFLDJFCCPC;
			}
			if (other.DKJFDLKJLBE)
			{
				DKJFDLKJLBE = other.DKJFDLKJLBE;
			}
			if (other.IAHOBGFDBML != 0)
			{
				IAHOBGFDBML = other.IAHOBGFDBML;
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
			case 40u:
				IKLDFMBGHGB = input.ReadUInt32();
				break;
			case 72u:
				NAFLDJFCCPC = input.ReadUInt32();
				break;
			case 88u:
				DKJFDLKJLBE = input.ReadBool();
				break;
			case 112u:
				IAHOBGFDBML = input.ReadUInt32();
				break;
			}
		}
	}
}
