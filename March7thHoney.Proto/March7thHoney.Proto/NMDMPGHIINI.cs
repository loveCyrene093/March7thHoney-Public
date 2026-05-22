using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NMDMPGHIINI : IMessage<NMDMPGHIINI>, IMessage, IEquatable<NMDMPGHIINI>, IDeepCloneable<NMDMPGHIINI>, IBufferMessage
{
	private static readonly MessageParser<NMDMPGHIINI> _parser = new MessageParser<NMDMPGHIINI>(() => new NMDMPGHIINI());

	private UnknownFieldSet _unknownFields;

	public const int ILIPGAECPPCFieldNumber = 3;

	private uint iLIPGAECPPC_;

	public const int ICDFDOKFLAKFieldNumber = 8;

	private uint iCDFDOKFLAK_;

	public const int AMOOPCLGKGDFieldNumber = 10;

	private bool aMOOPCLGKGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NMDMPGHIINI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NMDMPGHIINIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILIPGAECPPC
	{
		get
		{
			return iLIPGAECPPC_;
		}
		set
		{
			iLIPGAECPPC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ICDFDOKFLAK
	{
		get
		{
			return iCDFDOKFLAK_;
		}
		set
		{
			iCDFDOKFLAK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AMOOPCLGKGD
	{
		get
		{
			return aMOOPCLGKGD_;
		}
		set
		{
			aMOOPCLGKGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMDMPGHIINI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMDMPGHIINI(NMDMPGHIINI other)
		: this()
	{
		iLIPGAECPPC_ = other.iLIPGAECPPC_;
		iCDFDOKFLAK_ = other.iCDFDOKFLAK_;
		aMOOPCLGKGD_ = other.aMOOPCLGKGD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NMDMPGHIINI Clone()
	{
		return new NMDMPGHIINI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NMDMPGHIINI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NMDMPGHIINI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ILIPGAECPPC != other.ILIPGAECPPC)
		{
			return false;
		}
		if (ICDFDOKFLAK != other.ICDFDOKFLAK)
		{
			return false;
		}
		if (AMOOPCLGKGD != other.AMOOPCLGKGD)
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
		if (ILIPGAECPPC != 0)
		{
			num ^= ILIPGAECPPC.GetHashCode();
		}
		if (ICDFDOKFLAK != 0)
		{
			num ^= ICDFDOKFLAK.GetHashCode();
		}
		if (AMOOPCLGKGD)
		{
			num ^= AMOOPCLGKGD.GetHashCode();
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
		if (ILIPGAECPPC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ILIPGAECPPC);
		}
		if (ICDFDOKFLAK != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ICDFDOKFLAK);
		}
		if (AMOOPCLGKGD)
		{
			output.WriteRawTag(80);
			output.WriteBool(AMOOPCLGKGD);
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
		if (ILIPGAECPPC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILIPGAECPPC);
		}
		if (ICDFDOKFLAK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ICDFDOKFLAK);
		}
		if (AMOOPCLGKGD)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NMDMPGHIINI other)
	{
		if (other != null)
		{
			if (other.ILIPGAECPPC != 0)
			{
				ILIPGAECPPC = other.ILIPGAECPPC;
			}
			if (other.ICDFDOKFLAK != 0)
			{
				ICDFDOKFLAK = other.ICDFDOKFLAK;
			}
			if (other.AMOOPCLGKGD)
			{
				AMOOPCLGKGD = other.AMOOPCLGKGD;
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
				ILIPGAECPPC = input.ReadUInt32();
				break;
			case 64u:
				ICDFDOKFLAK = input.ReadUInt32();
				break;
			case 80u:
				AMOOPCLGKGD = input.ReadBool();
				break;
			}
		}
	}
}
