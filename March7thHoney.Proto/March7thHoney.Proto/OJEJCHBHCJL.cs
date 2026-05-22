using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OJEJCHBHCJL : IMessage<OJEJCHBHCJL>, IMessage, IEquatable<OJEJCHBHCJL>, IDeepCloneable<OJEJCHBHCJL>, IBufferMessage
{
	private static readonly MessageParser<OJEJCHBHCJL> _parser = new MessageParser<OJEJCHBHCJL>(() => new OJEJCHBHCJL());

	private UnknownFieldSet _unknownFields;

	public const int GJGKLFCHOFOFieldNumber = 1;

	private static readonly FieldCodec<NBJGNPPDHKM> _repeated_gJGKLFCHOFO_codec = FieldCodec.ForMessage(10u, NBJGNPPDHKM.Parser);

	private readonly RepeatedField<NBJGNPPDHKM> gJGKLFCHOFO_ = new RepeatedField<NBJGNPPDHKM>();

	public const int INGCDIAFAFGFieldNumber = 2;

	private uint iNGCDIAFAFG_;

	public const int StatusFieldNumber = 5;

	private MHKGLMBBCKP status_;

	public const int LMKBDICOLKOFieldNumber = 12;

	private uint lMKBDICOLKO_;

	public const int LNODOJOOPBKFieldNumber = 14;

	private uint lNODOJOOPBK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OJEJCHBHCJL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OJEJCHBHCJLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NBJGNPPDHKM> GJGKLFCHOFO => gJGKLFCHOFO_;

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
	public MHKGLMBBCKP Status
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
	public OJEJCHBHCJL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJEJCHBHCJL(OJEJCHBHCJL other)
		: this()
	{
		gJGKLFCHOFO_ = other.gJGKLFCHOFO_.Clone();
		iNGCDIAFAFG_ = other.iNGCDIAFAFG_;
		status_ = other.status_;
		lMKBDICOLKO_ = other.lMKBDICOLKO_;
		lNODOJOOPBK_ = other.lNODOJOOPBK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OJEJCHBHCJL Clone()
	{
		return new OJEJCHBHCJL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OJEJCHBHCJL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OJEJCHBHCJL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gJGKLFCHOFO_.Equals(other.gJGKLFCHOFO_))
		{
			return false;
		}
		if (INGCDIAFAFG != other.INGCDIAFAFG)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (LMKBDICOLKO != other.LMKBDICOLKO)
		{
			return false;
		}
		if (LNODOJOOPBK != other.LNODOJOOPBK)
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
		num ^= gJGKLFCHOFO_.GetHashCode();
		if (INGCDIAFAFG != 0)
		{
			num ^= INGCDIAFAFG.GetHashCode();
		}
		if (Status != MHKGLMBBCKP.Pcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		if (LMKBDICOLKO != 0)
		{
			num ^= LMKBDICOLKO.GetHashCode();
		}
		if (LNODOJOOPBK != 0)
		{
			num ^= LNODOJOOPBK.GetHashCode();
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
		gJGKLFCHOFO_.WriteTo(ref output, _repeated_gJGKLFCHOFO_codec);
		if (INGCDIAFAFG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(INGCDIAFAFG);
		}
		if (Status != MHKGLMBBCKP.Pcpdhelpkem)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Status);
		}
		if (LMKBDICOLKO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(LMKBDICOLKO);
		}
		if (LNODOJOOPBK != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LNODOJOOPBK);
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
		num += gJGKLFCHOFO_.CalculateSize(_repeated_gJGKLFCHOFO_codec);
		if (INGCDIAFAFG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INGCDIAFAFG);
		}
		if (Status != MHKGLMBBCKP.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (LMKBDICOLKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMKBDICOLKO);
		}
		if (LNODOJOOPBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LNODOJOOPBK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OJEJCHBHCJL other)
	{
		if (other != null)
		{
			gJGKLFCHOFO_.Add(other.gJGKLFCHOFO_);
			if (other.INGCDIAFAFG != 0)
			{
				INGCDIAFAFG = other.INGCDIAFAFG;
			}
			if (other.Status != MHKGLMBBCKP.Pcpdhelpkem)
			{
				Status = other.Status;
			}
			if (other.LMKBDICOLKO != 0)
			{
				LMKBDICOLKO = other.LMKBDICOLKO;
			}
			if (other.LNODOJOOPBK != 0)
			{
				LNODOJOOPBK = other.LNODOJOOPBK;
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
			case 10u:
				gJGKLFCHOFO_.AddEntriesFrom(ref input, _repeated_gJGKLFCHOFO_codec);
				break;
			case 16u:
				INGCDIAFAFG = input.ReadUInt32();
				break;
			case 40u:
				Status = (MHKGLMBBCKP)input.ReadEnum();
				break;
			case 96u:
				LMKBDICOLKO = input.ReadUInt32();
				break;
			case 112u:
				LNODOJOOPBK = input.ReadUInt32();
				break;
			}
		}
	}
}
