using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IDHNJFPAEGP : IMessage<IDHNJFPAEGP>, IMessage, IEquatable<IDHNJFPAEGP>, IDeepCloneable<IDHNJFPAEGP>, IBufferMessage
{
	private static readonly MessageParser<IDHNJFPAEGP> _parser = new MessageParser<IDHNJFPAEGP>(() => new IDHNJFPAEGP());

	private UnknownFieldSet _unknownFields;

	public const int StatusFieldNumber = 3;

	private DPFHPILPNON status_;

	public const int FNLNPLHOEJNFieldNumber = 11;

	private uint fNLNPLHOEJN_;

	public const int ANAMOLBDCOLFieldNumber = 14;

	private uint aNAMOLBDCOL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IDHNJFPAEGP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IDHNJFPAEGPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPFHPILPNON Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FNLNPLHOEJN
	{
		get
		{
			return fNLNPLHOEJN_;
		}
		set
		{
			fNLNPLHOEJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ANAMOLBDCOL
	{
		get
		{
			return aNAMOLBDCOL_;
		}
		set
		{
			aNAMOLBDCOL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDHNJFPAEGP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDHNJFPAEGP(IDHNJFPAEGP other)
		: this()
	{
		status_ = other.status_;
		fNLNPLHOEJN_ = other.fNLNPLHOEJN_;
		aNAMOLBDCOL_ = other.aNAMOLBDCOL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDHNJFPAEGP Clone()
	{
		return new IDHNJFPAEGP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IDHNJFPAEGP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IDHNJFPAEGP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (FNLNPLHOEJN != other.FNLNPLHOEJN)
		{
			return false;
		}
		if (ANAMOLBDCOL != other.ANAMOLBDCOL)
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
		if (Status != DPFHPILPNON.Eifepomhekj)
		{
			num ^= Status.GetHashCode();
		}
		if (FNLNPLHOEJN != 0)
		{
			num ^= FNLNPLHOEJN.GetHashCode();
		}
		if (ANAMOLBDCOL != 0)
		{
			num ^= ANAMOLBDCOL.GetHashCode();
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
		if (Status != DPFHPILPNON.Eifepomhekj)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Status);
		}
		if (FNLNPLHOEJN != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FNLNPLHOEJN);
		}
		if (ANAMOLBDCOL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ANAMOLBDCOL);
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
		if (Status != DPFHPILPNON.Eifepomhekj)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (FNLNPLHOEJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FNLNPLHOEJN);
		}
		if (ANAMOLBDCOL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ANAMOLBDCOL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IDHNJFPAEGP other)
	{
		if (other != null)
		{
			if (other.Status != DPFHPILPNON.Eifepomhekj)
			{
				Status = other.Status;
			}
			if (other.FNLNPLHOEJN != 0)
			{
				FNLNPLHOEJN = other.FNLNPLHOEJN;
			}
			if (other.ANAMOLBDCOL != 0)
			{
				ANAMOLBDCOL = other.ANAMOLBDCOL;
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
				Status = (DPFHPILPNON)input.ReadEnum();
				break;
			case 88u:
				FNLNPLHOEJN = input.ReadUInt32();
				break;
			case 112u:
				ANAMOLBDCOL = input.ReadUInt32();
				break;
			}
		}
	}
}
