using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LOMCAKMMGOM : IMessage<LOMCAKMMGOM>, IMessage, IEquatable<LOMCAKMMGOM>, IDeepCloneable<LOMCAKMMGOM>, IBufferMessage
{
	public enum FNJJNAOCOIIOneofCase
	{
		None = 0,
		FNLDFGLGEOA = 8,
		GEFMMOOEDJI = 9
	}

	private static readonly MessageParser<LOMCAKMMGOM> _parser = new MessageParser<LOMCAKMMGOM>(() => new LOMCAKMMGOM());

	private UnknownFieldSet _unknownFields;

	public const int HJMJIADBAOCFieldNumber = 6;

	private uint hJMJIADBAOC_;

	public const int FNLDFGLGEOAFieldNumber = 8;

	public const int GEFMMOOEDJIFieldNumber = 9;

	private object fNJJNAOCOII_;

	private FNJJNAOCOIIOneofCase fNJJNAOCOIICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LOMCAKMMGOM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LOMCAKMMGOMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJMJIADBAOC
	{
		get
		{
			return hJMJIADBAOC_;
		}
		set
		{
			hJMJIADBAOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList FNLDFGLGEOA
	{
		get
		{
			if (fNJJNAOCOIICase_ != FNJJNAOCOIIOneofCase.FNLDFGLGEOA)
			{
				return null;
			}
			return (ItemList)fNJJNAOCOII_;
		}
		set
		{
			fNJJNAOCOII_ = value;
			fNJJNAOCOIICase_ = ((value != null) ? FNJJNAOCOIIOneofCase.FNLDFGLGEOA : FNJJNAOCOIIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKKOGGBFMIP GEFMMOOEDJI
	{
		get
		{
			if (fNJJNAOCOIICase_ != FNJJNAOCOIIOneofCase.GEFMMOOEDJI)
			{
				return null;
			}
			return (KKKOGGBFMIP)fNJJNAOCOII_;
		}
		set
		{
			fNJJNAOCOII_ = value;
			fNJJNAOCOIICase_ = ((value != null) ? FNJJNAOCOIIOneofCase.GEFMMOOEDJI : FNJJNAOCOIIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNJJNAOCOIIOneofCase FNJJNAOCOIICase => fNJJNAOCOIICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOMCAKMMGOM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOMCAKMMGOM(LOMCAKMMGOM other)
		: this()
	{
		hJMJIADBAOC_ = other.hJMJIADBAOC_;
		switch (other.FNJJNAOCOIICase)
		{
		case FNJJNAOCOIIOneofCase.FNLDFGLGEOA:
			FNLDFGLGEOA = other.FNLDFGLGEOA.Clone();
			break;
		case FNJJNAOCOIIOneofCase.GEFMMOOEDJI:
			GEFMMOOEDJI = other.GEFMMOOEDJI.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOMCAKMMGOM Clone()
	{
		return new LOMCAKMMGOM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearFNJJNAOCOII()
	{
		fNJJNAOCOIICase_ = FNJJNAOCOIIOneofCase.None;
		fNJJNAOCOII_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LOMCAKMMGOM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LOMCAKMMGOM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HJMJIADBAOC != other.HJMJIADBAOC)
		{
			return false;
		}
		if (!object.Equals(FNLDFGLGEOA, other.FNLDFGLGEOA))
		{
			return false;
		}
		if (!object.Equals(GEFMMOOEDJI, other.GEFMMOOEDJI))
		{
			return false;
		}
		if (FNJJNAOCOIICase != other.FNJJNAOCOIICase)
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
		if (HJMJIADBAOC != 0)
		{
			num ^= HJMJIADBAOC.GetHashCode();
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.FNLDFGLGEOA)
		{
			num ^= FNLDFGLGEOA.GetHashCode();
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.GEFMMOOEDJI)
		{
			num ^= GEFMMOOEDJI.GetHashCode();
		}
		num ^= (int)fNJJNAOCOIICase_;
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
		if (HJMJIADBAOC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(HJMJIADBAOC);
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.FNLDFGLGEOA)
		{
			output.WriteRawTag(66);
			output.WriteMessage(FNLDFGLGEOA);
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.GEFMMOOEDJI)
		{
			output.WriteRawTag(74);
			output.WriteMessage(GEFMMOOEDJI);
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
		if (HJMJIADBAOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJMJIADBAOC);
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.FNLDFGLGEOA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FNLDFGLGEOA);
		}
		if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.GEFMMOOEDJI)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GEFMMOOEDJI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LOMCAKMMGOM other)
	{
		if (other == null)
		{
			return;
		}
		if (other.HJMJIADBAOC != 0)
		{
			HJMJIADBAOC = other.HJMJIADBAOC;
		}
		switch (other.FNJJNAOCOIICase)
		{
		case FNJJNAOCOIIOneofCase.FNLDFGLGEOA:
			if (FNLDFGLGEOA == null)
			{
				FNLDFGLGEOA = new ItemList();
			}
			FNLDFGLGEOA.MergeFrom(other.FNLDFGLGEOA);
			break;
		case FNJJNAOCOIIOneofCase.GEFMMOOEDJI:
			if (GEFMMOOEDJI == null)
			{
				GEFMMOOEDJI = new KKKOGGBFMIP();
			}
			GEFMMOOEDJI.MergeFrom(other.GEFMMOOEDJI);
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
			case 48u:
				HJMJIADBAOC = input.ReadUInt32();
				break;
			case 66u:
			{
				ItemList itemList = new ItemList();
				if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.FNLDFGLGEOA)
				{
					itemList.MergeFrom(FNLDFGLGEOA);
				}
				input.ReadMessage(itemList);
				FNLDFGLGEOA = itemList;
				break;
			}
			case 74u:
			{
				KKKOGGBFMIP kKKOGGBFMIP = new KKKOGGBFMIP();
				if (fNJJNAOCOIICase_ == FNJJNAOCOIIOneofCase.GEFMMOOEDJI)
				{
					kKKOGGBFMIP.MergeFrom(GEFMMOOEDJI);
				}
				input.ReadMessage(kKKOGGBFMIP);
				GEFMMOOEDJI = kKKOGGBFMIP;
				break;
			}
			}
		}
	}
}
