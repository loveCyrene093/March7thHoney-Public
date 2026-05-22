using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CCKCCKHEFFB : IMessage<CCKCCKHEFFB>, IMessage, IEquatable<CCKCCKHEFFB>, IDeepCloneable<CCKCCKHEFFB>, IBufferMessage
{
	private static readonly MessageParser<CCKCCKHEFFB> _parser = new MessageParser<CCKCCKHEFFB>(() => new CCKCCKHEFFB());

	private UnknownFieldSet _unknownFields;

	public const int NCFHGIBCEBGFieldNumber = 1;

	private uint nCFHGIBCEBG_;

	public const int FIPIDGKPFHAFieldNumber = 2;

	private static readonly FieldCodec<MACJBIAFNOI> _repeated_fIPIDGKPFHA_codec = FieldCodec.ForMessage(18u, MACJBIAFNOI.Parser);

	private readonly RepeatedField<MACJBIAFNOI> fIPIDGKPFHA_ = new RepeatedField<MACJBIAFNOI>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CCKCCKHEFFB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CCKCCKHEFFBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCFHGIBCEBG
	{
		get
		{
			return nCFHGIBCEBG_;
		}
		set
		{
			nCFHGIBCEBG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MACJBIAFNOI> FIPIDGKPFHA => fIPIDGKPFHA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCKCCKHEFFB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCKCCKHEFFB(CCKCCKHEFFB other)
		: this()
	{
		nCFHGIBCEBG_ = other.nCFHGIBCEBG_;
		fIPIDGKPFHA_ = other.fIPIDGKPFHA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CCKCCKHEFFB Clone()
	{
		return new CCKCCKHEFFB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CCKCCKHEFFB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CCKCCKHEFFB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NCFHGIBCEBG != other.NCFHGIBCEBG)
		{
			return false;
		}
		if (!fIPIDGKPFHA_.Equals(other.fIPIDGKPFHA_))
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
		if (NCFHGIBCEBG != 0)
		{
			num ^= NCFHGIBCEBG.GetHashCode();
		}
		num ^= fIPIDGKPFHA_.GetHashCode();
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
		if (NCFHGIBCEBG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NCFHGIBCEBG);
		}
		fIPIDGKPFHA_.WriteTo(ref output, _repeated_fIPIDGKPFHA_codec);
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
		if (NCFHGIBCEBG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCFHGIBCEBG);
		}
		num += fIPIDGKPFHA_.CalculateSize(_repeated_fIPIDGKPFHA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CCKCCKHEFFB other)
	{
		if (other != null)
		{
			if (other.NCFHGIBCEBG != 0)
			{
				NCFHGIBCEBG = other.NCFHGIBCEBG;
			}
			fIPIDGKPFHA_.Add(other.fIPIDGKPFHA_);
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
				NCFHGIBCEBG = input.ReadUInt32();
				break;
			case 18u:
				fIPIDGKPFHA_.AddEntriesFrom(ref input, _repeated_fIPIDGKPFHA_codec);
				break;
			}
		}
	}
}
