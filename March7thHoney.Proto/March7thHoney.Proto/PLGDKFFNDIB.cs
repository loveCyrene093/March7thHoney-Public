using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PLGDKFFNDIB : IMessage<PLGDKFFNDIB>, IMessage, IEquatable<PLGDKFFNDIB>, IDeepCloneable<PLGDKFFNDIB>, IBufferMessage
{
	private static readonly MessageParser<PLGDKFFNDIB> _parser = new MessageParser<PLGDKFFNDIB>(() => new PLGDKFFNDIB());

	private UnknownFieldSet _unknownFields;

	public const int InteractIdFieldNumber = 1;

	private uint interactId_;

	public const int IFIJBPOLLPJFieldNumber = 2;

	private static readonly FieldCodec<ulong> _repeated_iFIJBPOLLPJ_codec = FieldCodec.ForUInt64(18u);

	private readonly RepeatedField<ulong> iFIJBPOLLPJ_ = new RepeatedField<ulong>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PLGDKFFNDIB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PLGDKFFNDIBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ulong> IFIJBPOLLPJ => iFIJBPOLLPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLGDKFFNDIB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLGDKFFNDIB(PLGDKFFNDIB other)
		: this()
	{
		interactId_ = other.interactId_;
		iFIJBPOLLPJ_ = other.iFIJBPOLLPJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLGDKFFNDIB Clone()
	{
		return new PLGDKFFNDIB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PLGDKFFNDIB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PLGDKFFNDIB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (!iFIJBPOLLPJ_.Equals(other.iFIJBPOLLPJ_))
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
		if (InteractId != 0)
		{
			num ^= InteractId.GetHashCode();
		}
		num ^= iFIJBPOLLPJ_.GetHashCode();
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
		if (InteractId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(InteractId);
		}
		iFIJBPOLLPJ_.WriteTo(ref output, _repeated_iFIJBPOLLPJ_codec);
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
		if (InteractId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(InteractId);
		}
		num += iFIJBPOLLPJ_.CalculateSize(_repeated_iFIJBPOLLPJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PLGDKFFNDIB other)
	{
		if (other != null)
		{
			if (other.InteractId != 0)
			{
				InteractId = other.InteractId;
			}
			iFIJBPOLLPJ_.Add(other.iFIJBPOLLPJ_);
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
				InteractId = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				iFIJBPOLLPJ_.AddEntriesFrom(ref input, _repeated_iFIJBPOLLPJ_codec);
				break;
			}
		}
	}
}
