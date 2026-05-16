using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class COKHGIMNLEK : IMessage<COKHGIMNLEK>, IMessage, IEquatable<COKHGIMNLEK>, IDeepCloneable<COKHGIMNLEK>, IBufferMessage
{
	private static readonly MessageParser<COKHGIMNLEK> _parser = new MessageParser<COKHGIMNLEK>(() => new COKHGIMNLEK());

	private UnknownFieldSet _unknownFields;

	public const int LKBGIEHLDLKFieldNumber = 1;

	private string lKBGIEHLDLK_ = "";

	public const int GGFJFKKJPDFFieldNumber = 2;

	private int gGFJFKKJPDF_;

	public const int NKCHPOBJFAPFieldNumber = 3;

	private int nKCHPOBJFAP_;

	public const int BGOEKCKEKILFieldNumber = 4;

	private int bGOEKCKEKIL_;

	public const int KKEEHBAKODIFieldNumber = 5;

	private int kKEEHBAKODI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<COKHGIMNLEK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => COKHGIMNLEKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LKBGIEHLDLK
	{
		get
		{
			return lKBGIEHLDLK_;
		}
		set
		{
			lKBGIEHLDLK_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GGFJFKKJPDF
	{
		get
		{
			return gGFJFKKJPDF_;
		}
		set
		{
			gGFJFKKJPDF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NKCHPOBJFAP
	{
		get
		{
			return nKCHPOBJFAP_;
		}
		set
		{
			nKCHPOBJFAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BGOEKCKEKIL
	{
		get
		{
			return bGOEKCKEKIL_;
		}
		set
		{
			bGOEKCKEKIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int KKEEHBAKODI
	{
		get
		{
			return kKEEHBAKODI_;
		}
		set
		{
			kKEEHBAKODI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COKHGIMNLEK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COKHGIMNLEK(COKHGIMNLEK other)
		: this()
	{
		lKBGIEHLDLK_ = other.lKBGIEHLDLK_;
		gGFJFKKJPDF_ = other.gGFJFKKJPDF_;
		nKCHPOBJFAP_ = other.nKCHPOBJFAP_;
		bGOEKCKEKIL_ = other.bGOEKCKEKIL_;
		kKEEHBAKODI_ = other.kKEEHBAKODI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COKHGIMNLEK Clone()
	{
		return new COKHGIMNLEK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as COKHGIMNLEK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(COKHGIMNLEK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LKBGIEHLDLK != other.LKBGIEHLDLK)
		{
			return false;
		}
		if (GGFJFKKJPDF != other.GGFJFKKJPDF)
		{
			return false;
		}
		if (NKCHPOBJFAP != other.NKCHPOBJFAP)
		{
			return false;
		}
		if (BGOEKCKEKIL != other.BGOEKCKEKIL)
		{
			return false;
		}
		if (KKEEHBAKODI != other.KKEEHBAKODI)
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
		if (LKBGIEHLDLK.Length != 0)
		{
			num ^= LKBGIEHLDLK.GetHashCode();
		}
		if (GGFJFKKJPDF != 0)
		{
			num ^= GGFJFKKJPDF.GetHashCode();
		}
		if (NKCHPOBJFAP != 0)
		{
			num ^= NKCHPOBJFAP.GetHashCode();
		}
		if (BGOEKCKEKIL != 0)
		{
			num ^= BGOEKCKEKIL.GetHashCode();
		}
		if (KKEEHBAKODI != 0)
		{
			num ^= KKEEHBAKODI.GetHashCode();
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
		if (LKBGIEHLDLK.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(LKBGIEHLDLK);
		}
		if (GGFJFKKJPDF != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(GGFJFKKJPDF);
		}
		if (NKCHPOBJFAP != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(NKCHPOBJFAP);
		}
		if (BGOEKCKEKIL != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BGOEKCKEKIL);
		}
		if (KKEEHBAKODI != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(KKEEHBAKODI);
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
		if (LKBGIEHLDLK.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LKBGIEHLDLK);
		}
		if (GGFJFKKJPDF != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GGFJFKKJPDF);
		}
		if (NKCHPOBJFAP != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NKCHPOBJFAP);
		}
		if (BGOEKCKEKIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BGOEKCKEKIL);
		}
		if (KKEEHBAKODI != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KKEEHBAKODI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(COKHGIMNLEK other)
	{
		if (other != null)
		{
			if (other.LKBGIEHLDLK.Length != 0)
			{
				LKBGIEHLDLK = other.LKBGIEHLDLK;
			}
			if (other.GGFJFKKJPDF != 0)
			{
				GGFJFKKJPDF = other.GGFJFKKJPDF;
			}
			if (other.NKCHPOBJFAP != 0)
			{
				NKCHPOBJFAP = other.NKCHPOBJFAP;
			}
			if (other.BGOEKCKEKIL != 0)
			{
				BGOEKCKEKIL = other.BGOEKCKEKIL;
			}
			if (other.KKEEHBAKODI != 0)
			{
				KKEEHBAKODI = other.KKEEHBAKODI;
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
				LKBGIEHLDLK = input.ReadString();
				break;
			case 16u:
				GGFJFKKJPDF = input.ReadInt32();
				break;
			case 24u:
				NKCHPOBJFAP = input.ReadInt32();
				break;
			case 32u:
				BGOEKCKEKIL = input.ReadInt32();
				break;
			case 40u:
				KKEEHBAKODI = input.ReadInt32();
				break;
			}
		}
	}
}
