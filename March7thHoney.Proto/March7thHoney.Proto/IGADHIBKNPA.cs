using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IGADHIBKNPA : IMessage<IGADHIBKNPA>, IMessage, IEquatable<IGADHIBKNPA>, IDeepCloneable<IGADHIBKNPA>, IBufferMessage
{
	private static readonly MessageParser<IGADHIBKNPA> _parser = new MessageParser<IGADHIBKNPA>(() => new IGADHIBKNPA());

	private UnknownFieldSet _unknownFields;

	public const int KCFPIGCEHIGFieldNumber = 1;

	private uint kCFPIGCEHIG_;

	public const int NIFHFOHLCEDFieldNumber = 2;

	private uint nIFHFOHLCED_;

	public const int KIENHENNAKJFieldNumber = 3;

	private double kIENHENNAKJ_;

	public const int NBMNHCMJDFOFieldNumber = 4;

	private double nBMNHCMJDFO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IGADHIBKNPA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IGADHIBKNPAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KCFPIGCEHIG
	{
		get
		{
			return kCFPIGCEHIG_;
		}
		set
		{
			kCFPIGCEHIG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NIFHFOHLCED
	{
		get
		{
			return nIFHFOHLCED_;
		}
		set
		{
			nIFHFOHLCED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double KIENHENNAKJ
	{
		get
		{
			return kIENHENNAKJ_;
		}
		set
		{
			kIENHENNAKJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double NBMNHCMJDFO
	{
		get
		{
			return nBMNHCMJDFO_;
		}
		set
		{
			nBMNHCMJDFO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGADHIBKNPA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGADHIBKNPA(IGADHIBKNPA other)
		: this()
	{
		kCFPIGCEHIG_ = other.kCFPIGCEHIG_;
		nIFHFOHLCED_ = other.nIFHFOHLCED_;
		kIENHENNAKJ_ = other.kIENHENNAKJ_;
		nBMNHCMJDFO_ = other.nBMNHCMJDFO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IGADHIBKNPA Clone()
	{
		return new IGADHIBKNPA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IGADHIBKNPA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IGADHIBKNPA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KCFPIGCEHIG != other.KCFPIGCEHIG)
		{
			return false;
		}
		if (NIFHFOHLCED != other.NIFHFOHLCED)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(KIENHENNAKJ, other.KIENHENNAKJ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(NBMNHCMJDFO, other.NBMNHCMJDFO))
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
		if (KCFPIGCEHIG != 0)
		{
			num ^= KCFPIGCEHIG.GetHashCode();
		}
		if (NIFHFOHLCED != 0)
		{
			num ^= NIFHFOHLCED.GetHashCode();
		}
		if (KIENHENNAKJ != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(KIENHENNAKJ);
		}
		if (NBMNHCMJDFO != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(NBMNHCMJDFO);
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
		if (KCFPIGCEHIG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KCFPIGCEHIG);
		}
		if (NIFHFOHLCED != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NIFHFOHLCED);
		}
		if (KIENHENNAKJ != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(KIENHENNAKJ);
		}
		if (NBMNHCMJDFO != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(NBMNHCMJDFO);
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
		if (KCFPIGCEHIG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KCFPIGCEHIG);
		}
		if (NIFHFOHLCED != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NIFHFOHLCED);
		}
		if (KIENHENNAKJ != 0.0)
		{
			num += 9;
		}
		if (NBMNHCMJDFO != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IGADHIBKNPA other)
	{
		if (other != null)
		{
			if (other.KCFPIGCEHIG != 0)
			{
				KCFPIGCEHIG = other.KCFPIGCEHIG;
			}
			if (other.NIFHFOHLCED != 0)
			{
				NIFHFOHLCED = other.NIFHFOHLCED;
			}
			if (other.KIENHENNAKJ != 0.0)
			{
				KIENHENNAKJ = other.KIENHENNAKJ;
			}
			if (other.NBMNHCMJDFO != 0.0)
			{
				NBMNHCMJDFO = other.NBMNHCMJDFO;
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
			case 8u:
				KCFPIGCEHIG = input.ReadUInt32();
				break;
			case 16u:
				NIFHFOHLCED = input.ReadUInt32();
				break;
			case 25u:
				KIENHENNAKJ = input.ReadDouble();
				break;
			case 33u:
				NBMNHCMJDFO = input.ReadDouble();
				break;
			}
		}
	}
}
