using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JCADEHNDGLF : IMessage<JCADEHNDGLF>, IMessage, IEquatable<JCADEHNDGLF>, IDeepCloneable<JCADEHNDGLF>, IBufferMessage
{
	private static readonly MessageParser<JCADEHNDGLF> _parser = new MessageParser<JCADEHNDGLF>(() => new JCADEHNDGLF());

	private UnknownFieldSet _unknownFields;

	public const int ICINHMIKJLHFieldNumber = 3;

	private uint iCINHMIKJLH_;

	public const int OJCHPAPJDFOFieldNumber = 4;

	private uint oJCHPAPJDFO_;

	public const int PELPDAPDBKJFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_pELPDAPDBKJ_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> pELPDAPDBKJ_ = new RepeatedField<uint>();

	public const int BJJONGHLOFCFieldNumber = 8;

	private uint bJJONGHLOFC_;

	public const int IHLLMLLNIFNFieldNumber = 10;

	private uint iHLLMLLNIFN_;

	public const int NNKHMIEJPOIFieldNumber = 14;

	private static readonly FieldCodec<NOKKAPGBNHP> _repeated_nNKHMIEJPOI_codec = FieldCodec.ForMessage(114u, NOKKAPGBNHP.Parser);

	private readonly RepeatedField<NOKKAPGBNHP> nNKHMIEJPOI_ = new RepeatedField<NOKKAPGBNHP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JCADEHNDGLF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JCADEHNDGLFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ICINHMIKJLH
	{
		get
		{
			return iCINHMIKJLH_;
		}
		set
		{
			iCINHMIKJLH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OJCHPAPJDFO
	{
		get
		{
			return oJCHPAPJDFO_;
		}
		set
		{
			oJCHPAPJDFO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PELPDAPDBKJ => pELPDAPDBKJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BJJONGHLOFC
	{
		get
		{
			return bJJONGHLOFC_;
		}
		set
		{
			bJJONGHLOFC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IHLLMLLNIFN
	{
		get
		{
			return iHLLMLLNIFN_;
		}
		set
		{
			iHLLMLLNIFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NOKKAPGBNHP> NNKHMIEJPOI => nNKHMIEJPOI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCADEHNDGLF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCADEHNDGLF(JCADEHNDGLF other)
		: this()
	{
		iCINHMIKJLH_ = other.iCINHMIKJLH_;
		oJCHPAPJDFO_ = other.oJCHPAPJDFO_;
		pELPDAPDBKJ_ = other.pELPDAPDBKJ_.Clone();
		bJJONGHLOFC_ = other.bJJONGHLOFC_;
		iHLLMLLNIFN_ = other.iHLLMLLNIFN_;
		nNKHMIEJPOI_ = other.nNKHMIEJPOI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCADEHNDGLF Clone()
	{
		return new JCADEHNDGLF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JCADEHNDGLF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JCADEHNDGLF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ICINHMIKJLH != other.ICINHMIKJLH)
		{
			return false;
		}
		if (OJCHPAPJDFO != other.OJCHPAPJDFO)
		{
			return false;
		}
		if (!pELPDAPDBKJ_.Equals(other.pELPDAPDBKJ_))
		{
			return false;
		}
		if (BJJONGHLOFC != other.BJJONGHLOFC)
		{
			return false;
		}
		if (IHLLMLLNIFN != other.IHLLMLLNIFN)
		{
			return false;
		}
		if (!nNKHMIEJPOI_.Equals(other.nNKHMIEJPOI_))
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
		if (ICINHMIKJLH != 0)
		{
			num ^= ICINHMIKJLH.GetHashCode();
		}
		if (OJCHPAPJDFO != 0)
		{
			num ^= OJCHPAPJDFO.GetHashCode();
		}
		num ^= pELPDAPDBKJ_.GetHashCode();
		if (BJJONGHLOFC != 0)
		{
			num ^= BJJONGHLOFC.GetHashCode();
		}
		if (IHLLMLLNIFN != 0)
		{
			num ^= IHLLMLLNIFN.GetHashCode();
		}
		num ^= nNKHMIEJPOI_.GetHashCode();
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
		if (ICINHMIKJLH != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ICINHMIKJLH);
		}
		if (OJCHPAPJDFO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(OJCHPAPJDFO);
		}
		pELPDAPDBKJ_.WriteTo(ref output, _repeated_pELPDAPDBKJ_codec);
		if (BJJONGHLOFC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BJJONGHLOFC);
		}
		if (IHLLMLLNIFN != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IHLLMLLNIFN);
		}
		nNKHMIEJPOI_.WriteTo(ref output, _repeated_nNKHMIEJPOI_codec);
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
		if (ICINHMIKJLH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ICINHMIKJLH);
		}
		if (OJCHPAPJDFO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OJCHPAPJDFO);
		}
		num += pELPDAPDBKJ_.CalculateSize(_repeated_pELPDAPDBKJ_codec);
		if (BJJONGHLOFC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BJJONGHLOFC);
		}
		if (IHLLMLLNIFN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IHLLMLLNIFN);
		}
		num += nNKHMIEJPOI_.CalculateSize(_repeated_nNKHMIEJPOI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JCADEHNDGLF other)
	{
		if (other != null)
		{
			if (other.ICINHMIKJLH != 0)
			{
				ICINHMIKJLH = other.ICINHMIKJLH;
			}
			if (other.OJCHPAPJDFO != 0)
			{
				OJCHPAPJDFO = other.OJCHPAPJDFO;
			}
			pELPDAPDBKJ_.Add(other.pELPDAPDBKJ_);
			if (other.BJJONGHLOFC != 0)
			{
				BJJONGHLOFC = other.BJJONGHLOFC;
			}
			if (other.IHLLMLLNIFN != 0)
			{
				IHLLMLLNIFN = other.IHLLMLLNIFN;
			}
			nNKHMIEJPOI_.Add(other.nNKHMIEJPOI_);
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
				ICINHMIKJLH = input.ReadUInt32();
				break;
			case 32u:
				OJCHPAPJDFO = input.ReadUInt32();
				break;
			case 40u:
			case 42u:
				pELPDAPDBKJ_.AddEntriesFrom(ref input, _repeated_pELPDAPDBKJ_codec);
				break;
			case 64u:
				BJJONGHLOFC = input.ReadUInt32();
				break;
			case 80u:
				IHLLMLLNIFN = input.ReadUInt32();
				break;
			case 114u:
				nNKHMIEJPOI_.AddEntriesFrom(ref input, _repeated_nNKHMIEJPOI_codec);
				break;
			}
		}
	}
}
