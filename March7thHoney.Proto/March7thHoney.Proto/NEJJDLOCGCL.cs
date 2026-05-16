using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NEJJDLOCGCL : IMessage<NEJJDLOCGCL>, IMessage, IEquatable<NEJJDLOCGCL>, IDeepCloneable<NEJJDLOCGCL>, IBufferMessage
{
	private static readonly MessageParser<NEJJDLOCGCL> _parser = new MessageParser<NEJJDLOCGCL>(() => new NEJJDLOCGCL());

	private UnknownFieldSet _unknownFields;

	public const int LCEHDGBBDJLFieldNumber = 7;

	private static readonly FieldCodec<IFMGFPICGGH> _repeated_lCEHDGBBDJL_codec = FieldCodec.ForMessage(58u, IFMGFPICGGH.Parser);

	private readonly RepeatedField<IFMGFPICGGH> lCEHDGBBDJL_ = new RepeatedField<IFMGFPICGGH>();

	public const int FOOLMIADMMHFieldNumber = 13;

	private uint fOOLMIADMMH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NEJJDLOCGCL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NEJJDLOCGCLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IFMGFPICGGH> LCEHDGBBDJL => lCEHDGBBDJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FOOLMIADMMH
	{
		get
		{
			return fOOLMIADMMH_;
		}
		set
		{
			fOOLMIADMMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEJJDLOCGCL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEJJDLOCGCL(NEJJDLOCGCL other)
		: this()
	{
		lCEHDGBBDJL_ = other.lCEHDGBBDJL_.Clone();
		fOOLMIADMMH_ = other.fOOLMIADMMH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEJJDLOCGCL Clone()
	{
		return new NEJJDLOCGCL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NEJJDLOCGCL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NEJJDLOCGCL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lCEHDGBBDJL_.Equals(other.lCEHDGBBDJL_))
		{
			return false;
		}
		if (FOOLMIADMMH != other.FOOLMIADMMH)
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
		num ^= lCEHDGBBDJL_.GetHashCode();
		if (FOOLMIADMMH != 0)
		{
			num ^= FOOLMIADMMH.GetHashCode();
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
		lCEHDGBBDJL_.WriteTo(ref output, _repeated_lCEHDGBBDJL_codec);
		if (FOOLMIADMMH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(FOOLMIADMMH);
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
		num += lCEHDGBBDJL_.CalculateSize(_repeated_lCEHDGBBDJL_codec);
		if (FOOLMIADMMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOOLMIADMMH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NEJJDLOCGCL other)
	{
		if (other != null)
		{
			lCEHDGBBDJL_.Add(other.lCEHDGBBDJL_);
			if (other.FOOLMIADMMH != 0)
			{
				FOOLMIADMMH = other.FOOLMIADMMH;
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
			case 58u:
				lCEHDGBBDJL_.AddEntriesFrom(ref input, _repeated_lCEHDGBBDJL_codec);
				break;
			case 104u:
				FOOLMIADMMH = input.ReadUInt32();
				break;
			}
		}
	}
}
