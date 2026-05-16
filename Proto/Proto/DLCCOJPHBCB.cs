using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DLCCOJPHBCB : IMessage<DLCCOJPHBCB>, IMessage, IEquatable<DLCCOJPHBCB>, IDeepCloneable<DLCCOJPHBCB>, IBufferMessage
{
	private static readonly MessageParser<DLCCOJPHBCB> _parser = new MessageParser<DLCCOJPHBCB>(() => new DLCCOJPHBCB());

	private UnknownFieldSet _unknownFields;

	public const int KGKOHNAACENFieldNumber = 1;

	private JAMLHOHBIGB kGKOHNAACEN_;

	public const int IPLEOOLCACIFieldNumber = 2;

	private HNDCKMIALOG iPLEOOLCACI_;

	public const int LHKDDBBIKOBFieldNumber = 6;

	private int lHKDDBBIKOB_;

	public const int JKLPNOFDNALFieldNumber = 10;

	private ulong jKLPNOFDNAL_;

	public const int LFBIELBHOBKFieldNumber = 12;

	private uint lFBIELBHOBK_;

	public const int DNNOFGJJMCPFieldNumber = 15;

	private static readonly FieldCodec<GIGAKCOMKOG> _repeated_dNNOFGJJMCP_codec = FieldCodec.ForMessage(122u, GIGAKCOMKOG.Parser);

	private readonly RepeatedField<GIGAKCOMKOG> dNNOFGJJMCP_ = new RepeatedField<GIGAKCOMKOG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DLCCOJPHBCB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DLCCOJPHBCBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public HNDCKMIALOG IPLEOOLCACI
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
	public RepeatedField<GIGAKCOMKOG> DNNOFGJJMCP => dNNOFGJJMCP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLCCOJPHBCB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLCCOJPHBCB(DLCCOJPHBCB other)
		: this()
	{
		kGKOHNAACEN_ = ((other.kGKOHNAACEN_ != null) ? other.kGKOHNAACEN_.Clone() : null);
		iPLEOOLCACI_ = other.iPLEOOLCACI_;
		lHKDDBBIKOB_ = other.lHKDDBBIKOB_;
		jKLPNOFDNAL_ = other.jKLPNOFDNAL_;
		lFBIELBHOBK_ = other.lFBIELBHOBK_;
		dNNOFGJJMCP_ = other.dNNOFGJJMCP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLCCOJPHBCB Clone()
	{
		return new DLCCOJPHBCB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DLCCOJPHBCB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DLCCOJPHBCB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KGKOHNAACEN, other.KGKOHNAACEN))
		{
			return false;
		}
		if (IPLEOOLCACI != other.IPLEOOLCACI)
		{
			return false;
		}
		if (LHKDDBBIKOB != other.LHKDDBBIKOB)
		{
			return false;
		}
		if (JKLPNOFDNAL != other.JKLPNOFDNAL)
		{
			return false;
		}
		if (LFBIELBHOBK != other.LFBIELBHOBK)
		{
			return false;
		}
		if (!dNNOFGJJMCP_.Equals(other.dNNOFGJJMCP_))
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
		if (kGKOHNAACEN_ != null)
		{
			num ^= KGKOHNAACEN.GetHashCode();
		}
		if (IPLEOOLCACI != HNDCKMIALOG.Ojaogbdjclm)
		{
			num ^= IPLEOOLCACI.GetHashCode();
		}
		if (LHKDDBBIKOB != 0)
		{
			num ^= LHKDDBBIKOB.GetHashCode();
		}
		if (JKLPNOFDNAL != 0L)
		{
			num ^= JKLPNOFDNAL.GetHashCode();
		}
		if (LFBIELBHOBK != 0)
		{
			num ^= LFBIELBHOBK.GetHashCode();
		}
		num ^= dNNOFGJJMCP_.GetHashCode();
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
		if (kGKOHNAACEN_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(KGKOHNAACEN);
		}
		if (IPLEOOLCACI != HNDCKMIALOG.Ojaogbdjclm)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IPLEOOLCACI);
		}
		if (LHKDDBBIKOB != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(LHKDDBBIKOB);
		}
		if (JKLPNOFDNAL != 0L)
		{
			output.WriteRawTag(80);
			output.WriteUInt64(JKLPNOFDNAL);
		}
		if (LFBIELBHOBK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(LFBIELBHOBK);
		}
		dNNOFGJJMCP_.WriteTo(ref output, _repeated_dNNOFGJJMCP_codec);
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
		if (kGKOHNAACEN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KGKOHNAACEN);
		}
		if (IPLEOOLCACI != HNDCKMIALOG.Ojaogbdjclm)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IPLEOOLCACI);
		}
		if (LHKDDBBIKOB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LHKDDBBIKOB);
		}
		if (JKLPNOFDNAL != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(JKLPNOFDNAL);
		}
		if (LFBIELBHOBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LFBIELBHOBK);
		}
		num += dNNOFGJJMCP_.CalculateSize(_repeated_dNNOFGJJMCP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DLCCOJPHBCB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kGKOHNAACEN_ != null)
		{
			if (kGKOHNAACEN_ == null)
			{
				KGKOHNAACEN = new JAMLHOHBIGB();
			}
			KGKOHNAACEN.MergeFrom(other.KGKOHNAACEN);
		}
		if (other.IPLEOOLCACI != HNDCKMIALOG.Ojaogbdjclm)
		{
			IPLEOOLCACI = other.IPLEOOLCACI;
		}
		if (other.LHKDDBBIKOB != 0)
		{
			LHKDDBBIKOB = other.LHKDDBBIKOB;
		}
		if (other.JKLPNOFDNAL != 0L)
		{
			JKLPNOFDNAL = other.JKLPNOFDNAL;
		}
		if (other.LFBIELBHOBK != 0)
		{
			LFBIELBHOBK = other.LFBIELBHOBK;
		}
		dNNOFGJJMCP_.Add(other.dNNOFGJJMCP_);
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
			case 10u:
				if (kGKOHNAACEN_ == null)
				{
					KGKOHNAACEN = new JAMLHOHBIGB();
				}
				input.ReadMessage(KGKOHNAACEN);
				break;
			case 16u:
				IPLEOOLCACI = (HNDCKMIALOG)input.ReadEnum();
				break;
			case 48u:
				LHKDDBBIKOB = input.ReadInt32();
				break;
			case 80u:
				JKLPNOFDNAL = input.ReadUInt64();
				break;
			case 96u:
				LFBIELBHOBK = input.ReadUInt32();
				break;
			case 122u:
				dNNOFGJJMCP_.AddEntriesFrom(ref input, _repeated_dNNOFGJJMCP_codec);
				break;
			}
		}
	}
}
