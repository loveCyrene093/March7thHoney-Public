using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPBEGBNICPG : IMessage<DPBEGBNICPG>, IMessage, IEquatable<DPBEGBNICPG>, IDeepCloneable<DPBEGBNICPG>, IBufferMessage
{
	private static readonly MessageParser<DPBEGBNICPG> _parser = new MessageParser<DPBEGBNICPG>(() => new DPBEGBNICPG());

	private UnknownFieldSet _unknownFields;

	public const int CFEHPHAJIODFieldNumber = 5;

	private PileItem cFEHPHAJIOD_;

	public const int HKIBJPFKLLOFieldNumber = 14;

	private static readonly FieldCodec<PileItem> _repeated_hKIBJPFKLLO_codec = FieldCodec.ForMessage(114u, PileItem.Parser);

	private readonly RepeatedField<PileItem> hKIBJPFKLLO_ = new RepeatedField<PileItem>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPBEGBNICPG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPBEGBNICPGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PileItem CFEHPHAJIOD
	{
		get
		{
			return cFEHPHAJIOD_;
		}
		set
		{
			cFEHPHAJIOD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PileItem> HKIBJPFKLLO => hKIBJPFKLLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPBEGBNICPG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPBEGBNICPG(DPBEGBNICPG other)
		: this()
	{
		cFEHPHAJIOD_ = ((other.cFEHPHAJIOD_ != null) ? other.cFEHPHAJIOD_.Clone() : null);
		hKIBJPFKLLO_ = other.hKIBJPFKLLO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPBEGBNICPG Clone()
	{
		return new DPBEGBNICPG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPBEGBNICPG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPBEGBNICPG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CFEHPHAJIOD, other.CFEHPHAJIOD))
		{
			return false;
		}
		if (!hKIBJPFKLLO_.Equals(other.hKIBJPFKLLO_))
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
		if (cFEHPHAJIOD_ != null)
		{
			num ^= CFEHPHAJIOD.GetHashCode();
		}
		num ^= hKIBJPFKLLO_.GetHashCode();
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
		if (cFEHPHAJIOD_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(CFEHPHAJIOD);
		}
		hKIBJPFKLLO_.WriteTo(ref output, _repeated_hKIBJPFKLLO_codec);
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
		if (cFEHPHAJIOD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CFEHPHAJIOD);
		}
		num += hKIBJPFKLLO_.CalculateSize(_repeated_hKIBJPFKLLO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPBEGBNICPG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cFEHPHAJIOD_ != null)
		{
			if (cFEHPHAJIOD_ == null)
			{
				CFEHPHAJIOD = new PileItem();
			}
			CFEHPHAJIOD.MergeFrom(other.CFEHPHAJIOD);
		}
		hKIBJPFKLLO_.Add(other.hKIBJPFKLLO_);
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
			case 42u:
				if (cFEHPHAJIOD_ == null)
				{
					CFEHPHAJIOD = new PileItem();
				}
				input.ReadMessage(CFEHPHAJIOD);
				break;
			case 114u:
				hKIBJPFKLLO_.AddEntriesFrom(ref input, _repeated_hKIBJPFKLLO_codec);
				break;
			}
		}
	}
}
