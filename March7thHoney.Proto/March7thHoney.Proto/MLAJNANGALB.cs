using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MLAJNANGALB : IMessage<MLAJNANGALB>, IMessage, IEquatable<MLAJNANGALB>, IDeepCloneable<MLAJNANGALB>, IBufferMessage
{
	public enum FABBIGDKAINOneofCase
	{
		None = 0,
		EOJHLPDEPPJ = 181,
		DCFDMKEBEMC = 415,
		CDKMMHGKJFI = 1648
	}

	private static readonly MessageParser<MLAJNANGALB> _parser = new MessageParser<MLAJNANGALB>(() => new MLAJNANGALB());

	private UnknownFieldSet _unknownFields;

	public const int SourceFieldNumber = 10;

	private MOFDANDCGHJ source_;

	public const int DHHLINHKJKCFieldNumber = 13;

	private NNHPDNACICF dHHLINHKJKC_;

	public const int HPEOJNOOHDDFieldNumber = 14;

	private uint hPEOJNOOHDD_;

	public const int EOJHLPDEPPJFieldNumber = 181;

	public const int DCFDMKEBEMCFieldNumber = 415;

	public const int CDKMMHGKJFIFieldNumber = 1648;

	private object fABBIGDKAIN_;

	private FABBIGDKAINOneofCase fABBIGDKAINCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MLAJNANGALB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MLAJNANGALBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOFDANDCGHJ Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNHPDNACICF DHHLINHKJKC
	{
		get
		{
			return dHHLINHKJKC_;
		}
		set
		{
			dHHLINHKJKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HPEOJNOOHDD
	{
		get
		{
			return hPEOJNOOHDD_;
		}
		set
		{
			hPEOJNOOHDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGJPCOOMPGH EOJHLPDEPPJ
	{
		get
		{
			if (!HasEOJHLPDEPPJ)
			{
				return AGJPCOOMPGH.Pcpdhelpkem;
			}
			return (AGJPCOOMPGH)fABBIGDKAIN_;
		}
		set
		{
			fABBIGDKAIN_ = value;
			fABBIGDKAINCase_ = FABBIGDKAINOneofCase.EOJHLPDEPPJ;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEOJHLPDEPPJ => fABBIGDKAINCase_ == FABBIGDKAINOneofCase.EOJHLPDEPPJ;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NILDPLJDLLJ DCFDMKEBEMC
	{
		get
		{
			if (fABBIGDKAINCase_ != FABBIGDKAINOneofCase.DCFDMKEBEMC)
			{
				return null;
			}
			return (NILDPLJDLLJ)fABBIGDKAIN_;
		}
		set
		{
			fABBIGDKAIN_ = value;
			fABBIGDKAINCase_ = ((value != null) ? FABBIGDKAINOneofCase.DCFDMKEBEMC : FABBIGDKAINOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CDKMMHGKJFI
	{
		get
		{
			if (!HasCDKMMHGKJFI)
			{
				return 0u;
			}
			return (uint)fABBIGDKAIN_;
		}
		set
		{
			fABBIGDKAIN_ = value;
			fABBIGDKAINCase_ = FABBIGDKAINOneofCase.CDKMMHGKJFI;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCDKMMHGKJFI => fABBIGDKAINCase_ == FABBIGDKAINOneofCase.CDKMMHGKJFI;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FABBIGDKAINOneofCase FABBIGDKAINCase => fABBIGDKAINCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLAJNANGALB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLAJNANGALB(MLAJNANGALB other)
		: this()
	{
		source_ = ((other.source_ != null) ? other.source_.Clone() : null);
		dHHLINHKJKC_ = ((other.dHHLINHKJKC_ != null) ? other.dHHLINHKJKC_.Clone() : null);
		hPEOJNOOHDD_ = other.hPEOJNOOHDD_;
		switch (other.FABBIGDKAINCase)
		{
		case FABBIGDKAINOneofCase.EOJHLPDEPPJ:
			EOJHLPDEPPJ = other.EOJHLPDEPPJ;
			break;
		case FABBIGDKAINOneofCase.DCFDMKEBEMC:
			DCFDMKEBEMC = other.DCFDMKEBEMC.Clone();
			break;
		case FABBIGDKAINOneofCase.CDKMMHGKJFI:
			CDKMMHGKJFI = other.CDKMMHGKJFI;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLAJNANGALB Clone()
	{
		return new MLAJNANGALB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEOJHLPDEPPJ()
	{
		if (HasEOJHLPDEPPJ)
		{
			ClearFABBIGDKAIN();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCDKMMHGKJFI()
	{
		if (HasCDKMMHGKJFI)
		{
			ClearFABBIGDKAIN();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFABBIGDKAIN()
	{
		fABBIGDKAINCase_ = FABBIGDKAINOneofCase.None;
		fABBIGDKAIN_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MLAJNANGALB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MLAJNANGALB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Source, other.Source))
		{
			return false;
		}
		if (!object.Equals(DHHLINHKJKC, other.DHHLINHKJKC))
		{
			return false;
		}
		if (HPEOJNOOHDD != other.HPEOJNOOHDD)
		{
			return false;
		}
		if (EOJHLPDEPPJ != other.EOJHLPDEPPJ)
		{
			return false;
		}
		if (!object.Equals(DCFDMKEBEMC, other.DCFDMKEBEMC))
		{
			return false;
		}
		if (CDKMMHGKJFI != other.CDKMMHGKJFI)
		{
			return false;
		}
		if (FABBIGDKAINCase != other.FABBIGDKAINCase)
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
		if (source_ != null)
		{
			num ^= Source.GetHashCode();
		}
		if (dHHLINHKJKC_ != null)
		{
			num ^= DHHLINHKJKC.GetHashCode();
		}
		if (HPEOJNOOHDD != 0)
		{
			num ^= HPEOJNOOHDD.GetHashCode();
		}
		if (HasEOJHLPDEPPJ)
		{
			num ^= EOJHLPDEPPJ.GetHashCode();
		}
		if (fABBIGDKAINCase_ == FABBIGDKAINOneofCase.DCFDMKEBEMC)
		{
			num ^= DCFDMKEBEMC.GetHashCode();
		}
		if (HasCDKMMHGKJFI)
		{
			num ^= CDKMMHGKJFI.GetHashCode();
		}
		num ^= (int)fABBIGDKAINCase_;
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
		if (source_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Source);
		}
		if (dHHLINHKJKC_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(DHHLINHKJKC);
		}
		if (HPEOJNOOHDD != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HPEOJNOOHDD);
		}
		if (HasEOJHLPDEPPJ)
		{
			output.WriteRawTag(168, 11);
			output.WriteEnum((int)EOJHLPDEPPJ);
		}
		if (fABBIGDKAINCase_ == FABBIGDKAINOneofCase.DCFDMKEBEMC)
		{
			output.WriteRawTag(250, 25);
			output.WriteMessage(DCFDMKEBEMC);
		}
		if (HasCDKMMHGKJFI)
		{
			output.WriteRawTag(128, 103);
			output.WriteUInt32(CDKMMHGKJFI);
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
		if (source_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Source);
		}
		if (dHHLINHKJKC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DHHLINHKJKC);
		}
		if (HPEOJNOOHDD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HPEOJNOOHDD);
		}
		if (HasEOJHLPDEPPJ)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)EOJHLPDEPPJ);
		}
		if (fABBIGDKAINCase_ == FABBIGDKAINOneofCase.DCFDMKEBEMC)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DCFDMKEBEMC);
		}
		if (HasCDKMMHGKJFI)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(CDKMMHGKJFI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MLAJNANGALB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.source_ != null)
		{
			if (source_ == null)
			{
				Source = new MOFDANDCGHJ();
			}
			Source.MergeFrom(other.Source);
		}
		if (other.dHHLINHKJKC_ != null)
		{
			if (dHHLINHKJKC_ == null)
			{
				DHHLINHKJKC = new NNHPDNACICF();
			}
			DHHLINHKJKC.MergeFrom(other.DHHLINHKJKC);
		}
		if (other.HPEOJNOOHDD != 0)
		{
			HPEOJNOOHDD = other.HPEOJNOOHDD;
		}
		switch (other.FABBIGDKAINCase)
		{
		case FABBIGDKAINOneofCase.EOJHLPDEPPJ:
			EOJHLPDEPPJ = other.EOJHLPDEPPJ;
			break;
		case FABBIGDKAINOneofCase.DCFDMKEBEMC:
			if (DCFDMKEBEMC == null)
			{
				DCFDMKEBEMC = new NILDPLJDLLJ();
			}
			DCFDMKEBEMC.MergeFrom(other.DCFDMKEBEMC);
			break;
		case FABBIGDKAINOneofCase.CDKMMHGKJFI:
			CDKMMHGKJFI = other.CDKMMHGKJFI;
			break;
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
			case 82u:
				if (source_ == null)
				{
					Source = new MOFDANDCGHJ();
				}
				input.ReadMessage(Source);
				break;
			case 106u:
				if (dHHLINHKJKC_ == null)
				{
					DHHLINHKJKC = new NNHPDNACICF();
				}
				input.ReadMessage(DHHLINHKJKC);
				break;
			case 112u:
				HPEOJNOOHDD = input.ReadUInt32();
				break;
			case 1448u:
				fABBIGDKAIN_ = input.ReadEnum();
				fABBIGDKAINCase_ = FABBIGDKAINOneofCase.EOJHLPDEPPJ;
				break;
			case 3322u:
			{
				NILDPLJDLLJ nILDPLJDLLJ = new NILDPLJDLLJ();
				if (fABBIGDKAINCase_ == FABBIGDKAINOneofCase.DCFDMKEBEMC)
				{
					nILDPLJDLLJ.MergeFrom(DCFDMKEBEMC);
				}
				input.ReadMessage(nILDPLJDLLJ);
				DCFDMKEBEMC = nILDPLJDLLJ;
				break;
			}
			case 13184u:
				CDKMMHGKJFI = input.ReadUInt32();
				break;
			}
		}
	}
}
