using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ACPMKPLOBEF : IMessage<ACPMKPLOBEF>, IMessage, IEquatable<ACPMKPLOBEF>, IDeepCloneable<ACPMKPLOBEF>, IBufferMessage
{
	private static readonly MessageParser<ACPMKPLOBEF> _parser = new MessageParser<ACPMKPLOBEF>(() => new ACPMKPLOBEF());

	private UnknownFieldSet _unknownFields;

	public const int JKLPNOFDNALFieldNumber = 2;

	private ulong jKLPNOFDNAL_;

	public const int KGKOHNAACENFieldNumber = 3;

	private JAMLHOHBIGB kGKOHNAACEN_;

	public const int DNNOFGJJMCPFieldNumber = 7;

	private static readonly FieldCodec<KLMKLDONEJG> _repeated_dNNOFGJJMCP_codec = FieldCodec.ForMessage(58u, KLMKLDONEJG.Parser);

	private readonly RepeatedField<KLMKLDONEJG> dNNOFGJJMCP_ = new RepeatedField<KLMKLDONEJG>();

	public const int AHIFHGNPGBBFieldNumber = 8;

	private uint aHIFHGNPGBB_;

	public const int LFBIELBHOBKFieldNumber = 10;

	private uint lFBIELBHOBK_;

	public const int LHKDDBBIKOBFieldNumber = 11;

	private int lHKDDBBIKOB_;

	public const int IPLEOOLCACIFieldNumber = 13;

	private DNAGPMEBBCK iPLEOOLCACI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ACPMKPLOBEF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ACPMKPLOBEFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong JKLPNOFDNAL
	{
		get
		{
			return jKLPNOFDNAL_;
		}
		set
		{
			jKLPNOFDNAL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAMLHOHBIGB KGKOHNAACEN
	{
		get
		{
			return kGKOHNAACEN_;
		}
		set
		{
			kGKOHNAACEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KLMKLDONEJG> DNNOFGJJMCP => dNNOFGJJMCP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AHIFHGNPGBB
	{
		get
		{
			return aHIFHGNPGBB_;
		}
		set
		{
			aHIFHGNPGBB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LFBIELBHOBK
	{
		get
		{
			return lFBIELBHOBK_;
		}
		set
		{
			lFBIELBHOBK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LHKDDBBIKOB
	{
		get
		{
			return lHKDDBBIKOB_;
		}
		set
		{
			lHKDDBBIKOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNAGPMEBBCK IPLEOOLCACI
	{
		get
		{
			return iPLEOOLCACI_;
		}
		set
		{
			iPLEOOLCACI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACPMKPLOBEF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACPMKPLOBEF(ACPMKPLOBEF other)
		: this()
	{
		jKLPNOFDNAL_ = other.jKLPNOFDNAL_;
		kGKOHNAACEN_ = ((other.kGKOHNAACEN_ != null) ? other.kGKOHNAACEN_.Clone() : null);
		dNNOFGJJMCP_ = other.dNNOFGJJMCP_.Clone();
		aHIFHGNPGBB_ = other.aHIFHGNPGBB_;
		lFBIELBHOBK_ = other.lFBIELBHOBK_;
		lHKDDBBIKOB_ = other.lHKDDBBIKOB_;
		iPLEOOLCACI_ = other.iPLEOOLCACI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACPMKPLOBEF Clone()
	{
		return new ACPMKPLOBEF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ACPMKPLOBEF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ACPMKPLOBEF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JKLPNOFDNAL != other.JKLPNOFDNAL)
		{
			return false;
		}
		if (!object.Equals(KGKOHNAACEN, other.KGKOHNAACEN))
		{
			return false;
		}
		if (!dNNOFGJJMCP_.Equals(other.dNNOFGJJMCP_))
		{
			return false;
		}
		if (AHIFHGNPGBB != other.AHIFHGNPGBB)
		{
			return false;
		}
		if (LFBIELBHOBK != other.LFBIELBHOBK)
		{
			return false;
		}
		if (LHKDDBBIKOB != other.LHKDDBBIKOB)
		{
			return false;
		}
		if (IPLEOOLCACI != other.IPLEOOLCACI)
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
		if (JKLPNOFDNAL != 0L)
		{
			num ^= JKLPNOFDNAL.GetHashCode();
		}
		if (kGKOHNAACEN_ != null)
		{
			num ^= KGKOHNAACEN.GetHashCode();
		}
		num ^= dNNOFGJJMCP_.GetHashCode();
		if (AHIFHGNPGBB != 0)
		{
			num ^= AHIFHGNPGBB.GetHashCode();
		}
		if (LFBIELBHOBK != 0)
		{
			num ^= LFBIELBHOBK.GetHashCode();
		}
		if (LHKDDBBIKOB != 0)
		{
			num ^= LHKDDBBIKOB.GetHashCode();
		}
		if (IPLEOOLCACI != DNAGPMEBBCK.Mcdjammcldo)
		{
			num ^= IPLEOOLCACI.GetHashCode();
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
		if (JKLPNOFDNAL != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(JKLPNOFDNAL);
		}
		if (kGKOHNAACEN_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(KGKOHNAACEN);
		}
		dNNOFGJJMCP_.WriteTo(ref output, _repeated_dNNOFGJJMCP_codec);
		if (AHIFHGNPGBB != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(AHIFHGNPGBB);
		}
		if (LFBIELBHOBK != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(LFBIELBHOBK);
		}
		if (LHKDDBBIKOB != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(LHKDDBBIKOB);
		}
		if (IPLEOOLCACI != DNAGPMEBBCK.Mcdjammcldo)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)IPLEOOLCACI);
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
		if (JKLPNOFDNAL != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(JKLPNOFDNAL);
		}
		if (kGKOHNAACEN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KGKOHNAACEN);
		}
		num += dNNOFGJJMCP_.CalculateSize(_repeated_dNNOFGJJMCP_codec);
		if (AHIFHGNPGBB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AHIFHGNPGBB);
		}
		if (LFBIELBHOBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LFBIELBHOBK);
		}
		if (LHKDDBBIKOB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LHKDDBBIKOB);
		}
		if (IPLEOOLCACI != DNAGPMEBBCK.Mcdjammcldo)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IPLEOOLCACI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ACPMKPLOBEF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JKLPNOFDNAL != 0L)
		{
			JKLPNOFDNAL = other.JKLPNOFDNAL;
		}
		if (other.kGKOHNAACEN_ != null)
		{
			if (kGKOHNAACEN_ == null)
			{
				KGKOHNAACEN = new JAMLHOHBIGB();
			}
			KGKOHNAACEN.MergeFrom(other.KGKOHNAACEN);
		}
		dNNOFGJJMCP_.Add(other.dNNOFGJJMCP_);
		if (other.AHIFHGNPGBB != 0)
		{
			AHIFHGNPGBB = other.AHIFHGNPGBB;
		}
		if (other.LFBIELBHOBK != 0)
		{
			LFBIELBHOBK = other.LFBIELBHOBK;
		}
		if (other.LHKDDBBIKOB != 0)
		{
			LHKDDBBIKOB = other.LHKDDBBIKOB;
		}
		if (other.IPLEOOLCACI != DNAGPMEBBCK.Mcdjammcldo)
		{
			IPLEOOLCACI = other.IPLEOOLCACI;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 16u:
				JKLPNOFDNAL = input.ReadUInt64();
				break;
			case 26u:
				if (kGKOHNAACEN_ == null)
				{
					KGKOHNAACEN = new JAMLHOHBIGB();
				}
				input.ReadMessage(KGKOHNAACEN);
				break;
			case 58u:
				dNNOFGJJMCP_.AddEntriesFrom(ref input, _repeated_dNNOFGJJMCP_codec);
				break;
			case 64u:
				AHIFHGNPGBB = input.ReadUInt32();
				break;
			case 80u:
				LFBIELBHOBK = input.ReadUInt32();
				break;
			case 88u:
				LHKDDBBIKOB = input.ReadInt32();
				break;
			case 104u:
				IPLEOOLCACI = (DNAGPMEBBCK)input.ReadEnum();
				break;
			}
		}
	}
}
