using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class APBOFCPJCAF : IMessage<APBOFCPJCAF>, IMessage, IEquatable<APBOFCPJCAF>, IDeepCloneable<APBOFCPJCAF>, IBufferMessage
{
	private static readonly MessageParser<APBOFCPJCAF> _parser = new MessageParser<APBOFCPJCAF>(() => new APBOFCPJCAF());

	private UnknownFieldSet _unknownFields;

	public const int StatusFieldNumber = 1;

	private JILICANHLLC status_;

	public const int GJGKLFCHOFOFieldNumber = 3;

	private static readonly FieldCodec<PGKNFMANPNI> _repeated_gJGKLFCHOFO_codec = FieldCodec.ForMessage(26u, PGKNFMANPNI.Parser);

	private readonly RepeatedField<PGKNFMANPNI> gJGKLFCHOFO_ = new RepeatedField<PGKNFMANPNI>();

	public const int INGCDIAFAFGFieldNumber = 8;

	private uint iNGCDIAFAFG_;

	public const int LNODOJOOPBKFieldNumber = 11;

	private uint lNODOJOOPBK_;

	public const int LMKBDICOLKOFieldNumber = 14;

	private uint lMKBDICOLKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<APBOFCPJCAF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => APBOFCPJCAFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JILICANHLLC Status
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
	public RepeatedField<PGKNFMANPNI> GJGKLFCHOFO => gJGKLFCHOFO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint INGCDIAFAFG
	{
		get
		{
			return iNGCDIAFAFG_;
		}
		set
		{
			iNGCDIAFAFG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LNODOJOOPBK
	{
		get
		{
			return lNODOJOOPBK_;
		}
		set
		{
			lNODOJOOPBK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LMKBDICOLKO
	{
		get
		{
			return lMKBDICOLKO_;
		}
		set
		{
			lMKBDICOLKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APBOFCPJCAF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APBOFCPJCAF(APBOFCPJCAF other)
		: this()
	{
		status_ = other.status_;
		gJGKLFCHOFO_ = other.gJGKLFCHOFO_.Clone();
		iNGCDIAFAFG_ = other.iNGCDIAFAFG_;
		lNODOJOOPBK_ = other.lNODOJOOPBK_;
		lMKBDICOLKO_ = other.lMKBDICOLKO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APBOFCPJCAF Clone()
	{
		return new APBOFCPJCAF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as APBOFCPJCAF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(APBOFCPJCAF other)
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
		if (!gJGKLFCHOFO_.Equals(other.gJGKLFCHOFO_))
		{
			return false;
		}
		if (INGCDIAFAFG != other.INGCDIAFAFG)
		{
			return false;
		}
		if (LNODOJOOPBK != other.LNODOJOOPBK)
		{
			return false;
		}
		if (LMKBDICOLKO != other.LMKBDICOLKO)
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
		if (Status != JILICANHLLC.Pcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		num ^= gJGKLFCHOFO_.GetHashCode();
		if (INGCDIAFAFG != 0)
		{
			num ^= INGCDIAFAFG.GetHashCode();
		}
		if (LNODOJOOPBK != 0)
		{
			num ^= LNODOJOOPBK.GetHashCode();
		}
		if (LMKBDICOLKO != 0)
		{
			num ^= LMKBDICOLKO.GetHashCode();
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
		if (Status != JILICANHLLC.Pcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Status);
		}
		gJGKLFCHOFO_.WriteTo(ref output, _repeated_gJGKLFCHOFO_codec);
		if (INGCDIAFAFG != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(INGCDIAFAFG);
		}
		if (LNODOJOOPBK != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(LNODOJOOPBK);
		}
		if (LMKBDICOLKO != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LMKBDICOLKO);
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
		if (Status != JILICANHLLC.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		num += gJGKLFCHOFO_.CalculateSize(_repeated_gJGKLFCHOFO_codec);
		if (INGCDIAFAFG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INGCDIAFAFG);
		}
		if (LNODOJOOPBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LNODOJOOPBK);
		}
		if (LMKBDICOLKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMKBDICOLKO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(APBOFCPJCAF other)
	{
		if (other != null)
		{
			if (other.Status != JILICANHLLC.Pcpdhelpkem)
			{
				Status = other.Status;
			}
			gJGKLFCHOFO_.Add(other.gJGKLFCHOFO_);
			if (other.INGCDIAFAFG != 0)
			{
				INGCDIAFAFG = other.INGCDIAFAFG;
			}
			if (other.LNODOJOOPBK != 0)
			{
				LNODOJOOPBK = other.LNODOJOOPBK;
			}
			if (other.LMKBDICOLKO != 0)
			{
				LMKBDICOLKO = other.LMKBDICOLKO;
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
				Status = (JILICANHLLC)input.ReadEnum();
				break;
			case 26u:
				gJGKLFCHOFO_.AddEntriesFrom(ref input, _repeated_gJGKLFCHOFO_codec);
				break;
			case 64u:
				INGCDIAFAFG = input.ReadUInt32();
				break;
			case 88u:
				LNODOJOOPBK = input.ReadUInt32();
				break;
			case 112u:
				LMKBDICOLKO = input.ReadUInt32();
				break;
			}
		}
	}
}
