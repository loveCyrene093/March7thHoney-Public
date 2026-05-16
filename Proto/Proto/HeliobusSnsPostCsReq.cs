using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeliobusSnsPostCsReq : IMessage<HeliobusSnsPostCsReq>, IMessage, IEquatable<HeliobusSnsPostCsReq>, IDeepCloneable<HeliobusSnsPostCsReq>, IBufferMessage
{
	private static readonly MessageParser<HeliobusSnsPostCsReq> _parser = new MessageParser<HeliobusSnsPostCsReq>(() => new HeliobusSnsPostCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ILEMMKPGPNDFieldNumber = 3;

	private uint iLEMMKPGPND_;

	public const int CDKEDFPEFIJFieldNumber = 8;

	private uint cDKEDFPEFIJ_;

	public const int HFOKNODFIJIFieldNumber = 14;

	private uint hFOKNODFIJI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeliobusSnsPostCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeliobusSnsPostCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILEMMKPGPND
	{
		get
		{
			return iLEMMKPGPND_;
		}
		set
		{
			iLEMMKPGPND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CDKEDFPEFIJ
	{
		get
		{
			return cDKEDFPEFIJ_;
		}
		set
		{
			cDKEDFPEFIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HFOKNODFIJI
	{
		get
		{
			return hFOKNODFIJI_;
		}
		set
		{
			hFOKNODFIJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsPostCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsPostCsReq(HeliobusSnsPostCsReq other)
		: this()
	{
		iLEMMKPGPND_ = other.iLEMMKPGPND_;
		cDKEDFPEFIJ_ = other.cDKEDFPEFIJ_;
		hFOKNODFIJI_ = other.hFOKNODFIJI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeliobusSnsPostCsReq Clone()
	{
		return new HeliobusSnsPostCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeliobusSnsPostCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeliobusSnsPostCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ILEMMKPGPND != other.ILEMMKPGPND)
		{
			return false;
		}
		if (CDKEDFPEFIJ != other.CDKEDFPEFIJ)
		{
			return false;
		}
		if (HFOKNODFIJI != other.HFOKNODFIJI)
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
		if (ILEMMKPGPND != 0)
		{
			num ^= ILEMMKPGPND.GetHashCode();
		}
		if (CDKEDFPEFIJ != 0)
		{
			num ^= CDKEDFPEFIJ.GetHashCode();
		}
		if (HFOKNODFIJI != 0)
		{
			num ^= HFOKNODFIJI.GetHashCode();
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
		if (ILEMMKPGPND != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ILEMMKPGPND);
		}
		if (CDKEDFPEFIJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(CDKEDFPEFIJ);
		}
		if (HFOKNODFIJI != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HFOKNODFIJI);
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
		if (ILEMMKPGPND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILEMMKPGPND);
		}
		if (CDKEDFPEFIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CDKEDFPEFIJ);
		}
		if (HFOKNODFIJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HFOKNODFIJI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeliobusSnsPostCsReq other)
	{
		if (other != null)
		{
			if (other.ILEMMKPGPND != 0)
			{
				ILEMMKPGPND = other.ILEMMKPGPND;
			}
			if (other.CDKEDFPEFIJ != 0)
			{
				CDKEDFPEFIJ = other.CDKEDFPEFIJ;
			}
			if (other.HFOKNODFIJI != 0)
			{
				HFOKNODFIJI = other.HFOKNODFIJI;
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
				ILEMMKPGPND = input.ReadUInt32();
				break;
			case 64u:
				CDKEDFPEFIJ = input.ReadUInt32();
				break;
			case 112u:
				HFOKNODFIJI = input.ReadUInt32();
				break;
			}
		}
	}
}
