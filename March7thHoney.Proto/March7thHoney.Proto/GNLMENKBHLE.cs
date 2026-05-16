using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GNLMENKBHLE : IMessage<GNLMENKBHLE>, IMessage, IEquatable<GNLMENKBHLE>, IDeepCloneable<GNLMENKBHLE>, IBufferMessage
{
	private static readonly MessageParser<GNLMENKBHLE> _parser = new MessageParser<GNLMENKBHLE>(() => new GNLMENKBHLE());

	private UnknownFieldSet _unknownFields;

	public const int MMOJOECDMILFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_mMOJOECDMIL_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> mMOJOECDMIL_ = new RepeatedField<uint>();

	public const int GIJOAADKDINFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_gIJOAADKDIN_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> gIJOAADKDIN_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GNLMENKBHLE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GNLMENKBHLEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MMOJOECDMIL => mMOJOECDMIL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GIJOAADKDIN => gIJOAADKDIN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNLMENKBHLE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNLMENKBHLE(GNLMENKBHLE other)
		: this()
	{
		mMOJOECDMIL_ = other.mMOJOECDMIL_.Clone();
		gIJOAADKDIN_ = other.gIJOAADKDIN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNLMENKBHLE Clone()
	{
		return new GNLMENKBHLE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GNLMENKBHLE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GNLMENKBHLE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mMOJOECDMIL_.Equals(other.mMOJOECDMIL_))
		{
			return false;
		}
		if (!gIJOAADKDIN_.Equals(other.gIJOAADKDIN_))
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
		num ^= mMOJOECDMIL_.GetHashCode();
		num ^= gIJOAADKDIN_.GetHashCode();
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
		mMOJOECDMIL_.WriteTo(ref output, _repeated_mMOJOECDMIL_codec);
		gIJOAADKDIN_.WriteTo(ref output, _repeated_gIJOAADKDIN_codec);
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
		num += mMOJOECDMIL_.CalculateSize(_repeated_mMOJOECDMIL_codec);
		num += gIJOAADKDIN_.CalculateSize(_repeated_gIJOAADKDIN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GNLMENKBHLE other)
	{
		if (other != null)
		{
			mMOJOECDMIL_.Add(other.mMOJOECDMIL_);
			gIJOAADKDIN_.Add(other.gIJOAADKDIN_);
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
			case 96u:
			case 98u:
				mMOJOECDMIL_.AddEntriesFrom(ref input, _repeated_mMOJOECDMIL_codec);
				break;
			case 120u:
			case 122u:
				gIJOAADKDIN_.AddEntriesFrom(ref input, _repeated_gIJOAADKDIN_codec);
				break;
			}
		}
	}
}
