using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LGOPLIAFLCK : IMessage<LGOPLIAFLCK>, IMessage, IEquatable<LGOPLIAFLCK>, IDeepCloneable<LGOPLIAFLCK>, IBufferMessage
{
	private static readonly MessageParser<LGOPLIAFLCK> _parser = new MessageParser<LGOPLIAFLCK>(() => new LGOPLIAFLCK());

	private UnknownFieldSet _unknownFields;

	public const int DNNOFGJJMCPFieldNumber = 1;

	private static readonly FieldCodec<NBCBJJDFBPL> _repeated_dNNOFGJJMCP_codec = FieldCodec.ForMessage(10u, NBCBJJDFBPL.Parser);

	private readonly RepeatedField<NBCBJJDFBPL> dNNOFGJJMCP_ = new RepeatedField<NBCBJJDFBPL>();

	public const int FDJBKMDOPFDFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_fDJBKMDOPFD_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> fDJBKMDOPFD_ = new RepeatedField<uint>();

	public const int JKLPNOFDNALFieldNumber = 5;

	private ulong jKLPNOFDNAL_;

	public const int OKCNHPLOMCDFieldNumber = 6;

	private uint oKCNHPLOMCD_;

	public const int LHKDDBBIKOBFieldNumber = 7;

	private int lHKDDBBIKOB_;

	public const int IPLEOOLCACIFieldNumber = 8;

	private FNPDJFJFOBE iPLEOOLCACI_;

	public const int KGKOHNAACENFieldNumber = 15;

	private JAMLHOHBIGB kGKOHNAACEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LGOPLIAFLCK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LGOPLIAFLCKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NBCBJJDFBPL> DNNOFGJJMCP => dNNOFGJJMCP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FDJBKMDOPFD => fDJBKMDOPFD_;

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
	public uint OKCNHPLOMCD
	{
		get
		{
			return oKCNHPLOMCD_;
		}
		set
		{
			oKCNHPLOMCD_ = value;
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
	public FNPDJFJFOBE IPLEOOLCACI
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
	public LGOPLIAFLCK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGOPLIAFLCK(LGOPLIAFLCK other)
		: this()
	{
		dNNOFGJJMCP_ = other.dNNOFGJJMCP_.Clone();
		fDJBKMDOPFD_ = other.fDJBKMDOPFD_.Clone();
		jKLPNOFDNAL_ = other.jKLPNOFDNAL_;
		oKCNHPLOMCD_ = other.oKCNHPLOMCD_;
		lHKDDBBIKOB_ = other.lHKDDBBIKOB_;
		iPLEOOLCACI_ = other.iPLEOOLCACI_;
		kGKOHNAACEN_ = ((other.kGKOHNAACEN_ != null) ? other.kGKOHNAACEN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGOPLIAFLCK Clone()
	{
		return new LGOPLIAFLCK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LGOPLIAFLCK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LGOPLIAFLCK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dNNOFGJJMCP_.Equals(other.dNNOFGJJMCP_))
		{
			return false;
		}
		if (!fDJBKMDOPFD_.Equals(other.fDJBKMDOPFD_))
		{
			return false;
		}
		if (JKLPNOFDNAL != other.JKLPNOFDNAL)
		{
			return false;
		}
		if (OKCNHPLOMCD != other.OKCNHPLOMCD)
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
		if (!object.Equals(KGKOHNAACEN, other.KGKOHNAACEN))
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
		num ^= dNNOFGJJMCP_.GetHashCode();
		num ^= fDJBKMDOPFD_.GetHashCode();
		if (JKLPNOFDNAL != 0L)
		{
			num ^= JKLPNOFDNAL.GetHashCode();
		}
		if (OKCNHPLOMCD != 0)
		{
			num ^= OKCNHPLOMCD.GetHashCode();
		}
		if (LHKDDBBIKOB != 0)
		{
			num ^= LHKDDBBIKOB.GetHashCode();
		}
		if (IPLEOOLCACI != FNPDJFJFOBE.Ekefcljapdp)
		{
			num ^= IPLEOOLCACI.GetHashCode();
		}
		if (kGKOHNAACEN_ != null)
		{
			num ^= KGKOHNAACEN.GetHashCode();
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
		dNNOFGJJMCP_.WriteTo(ref output, _repeated_dNNOFGJJMCP_codec);
		fDJBKMDOPFD_.WriteTo(ref output, _repeated_fDJBKMDOPFD_codec);
		if (JKLPNOFDNAL != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(JKLPNOFDNAL);
		}
		if (OKCNHPLOMCD != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(OKCNHPLOMCD);
		}
		if (LHKDDBBIKOB != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(LHKDDBBIKOB);
		}
		if (IPLEOOLCACI != FNPDJFJFOBE.Ekefcljapdp)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)IPLEOOLCACI);
		}
		if (kGKOHNAACEN_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(KGKOHNAACEN);
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
		num += dNNOFGJJMCP_.CalculateSize(_repeated_dNNOFGJJMCP_codec);
		num += fDJBKMDOPFD_.CalculateSize(_repeated_fDJBKMDOPFD_codec);
		if (JKLPNOFDNAL != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(JKLPNOFDNAL);
		}
		if (OKCNHPLOMCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OKCNHPLOMCD);
		}
		if (LHKDDBBIKOB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LHKDDBBIKOB);
		}
		if (IPLEOOLCACI != FNPDJFJFOBE.Ekefcljapdp)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IPLEOOLCACI);
		}
		if (kGKOHNAACEN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KGKOHNAACEN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LGOPLIAFLCK other)
	{
		if (other == null)
		{
			return;
		}
		dNNOFGJJMCP_.Add(other.dNNOFGJJMCP_);
		fDJBKMDOPFD_.Add(other.fDJBKMDOPFD_);
		if (other.JKLPNOFDNAL != 0L)
		{
			JKLPNOFDNAL = other.JKLPNOFDNAL;
		}
		if (other.OKCNHPLOMCD != 0)
		{
			OKCNHPLOMCD = other.OKCNHPLOMCD;
		}
		if (other.LHKDDBBIKOB != 0)
		{
			LHKDDBBIKOB = other.LHKDDBBIKOB;
		}
		if (other.IPLEOOLCACI != FNPDJFJFOBE.Ekefcljapdp)
		{
			IPLEOOLCACI = other.IPLEOOLCACI;
		}
		if (other.kGKOHNAACEN_ != null)
		{
			if (kGKOHNAACEN_ == null)
			{
				KGKOHNAACEN = new JAMLHOHBIGB();
			}
			KGKOHNAACEN.MergeFrom(other.KGKOHNAACEN);
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
			case 10u:
				dNNOFGJJMCP_.AddEntriesFrom(ref input, _repeated_dNNOFGJJMCP_codec);
				break;
			case 32u:
			case 34u:
				fDJBKMDOPFD_.AddEntriesFrom(ref input, _repeated_fDJBKMDOPFD_codec);
				break;
			case 40u:
				JKLPNOFDNAL = input.ReadUInt64();
				break;
			case 48u:
				OKCNHPLOMCD = input.ReadUInt32();
				break;
			case 56u:
				LHKDDBBIKOB = input.ReadInt32();
				break;
			case 64u:
				IPLEOOLCACI = (FNPDJFJFOBE)input.ReadEnum();
				break;
			case 122u:
				if (kGKOHNAACEN_ == null)
				{
					KGKOHNAACEN = new JAMLHOHBIGB();
				}
				input.ReadMessage(KGKOHNAACEN);
				break;
			}
		}
	}
}
