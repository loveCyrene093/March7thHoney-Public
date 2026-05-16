using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LIOLPIJOMBI : IMessage<LIOLPIJOMBI>, IMessage, IEquatable<LIOLPIJOMBI>, IDeepCloneable<LIOLPIJOMBI>, IBufferMessage
{
	private static readonly MessageParser<LIOLPIJOMBI> _parser = new MessageParser<LIOLPIJOMBI>(() => new LIOLPIJOMBI());

	private UnknownFieldSet _unknownFields;

	public const int MJLLOEEDJEAFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_mJLLOEEDJEA_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> mJLLOEEDJEA_ = new RepeatedField<uint>();

	public const int MPEMBDAGJJOFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_mPEMBDAGJJO_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> mPEMBDAGJJO_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LIOLPIJOMBI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LIOLPIJOMBIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MJLLOEEDJEA => mJLLOEEDJEA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MPEMBDAGJJO => mPEMBDAGJJO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LIOLPIJOMBI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LIOLPIJOMBI(LIOLPIJOMBI other)
		: this()
	{
		mJLLOEEDJEA_ = other.mJLLOEEDJEA_.Clone();
		mPEMBDAGJJO_ = other.mPEMBDAGJJO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LIOLPIJOMBI Clone()
	{
		return new LIOLPIJOMBI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LIOLPIJOMBI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LIOLPIJOMBI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mJLLOEEDJEA_.Equals(other.mJLLOEEDJEA_))
		{
			return false;
		}
		if (!mPEMBDAGJJO_.Equals(other.mPEMBDAGJJO_))
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
		num ^= mJLLOEEDJEA_.GetHashCode();
		num ^= mPEMBDAGJJO_.GetHashCode();
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
		mJLLOEEDJEA_.WriteTo(ref output, _repeated_mJLLOEEDJEA_codec);
		mPEMBDAGJJO_.WriteTo(ref output, _repeated_mPEMBDAGJJO_codec);
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
		num += mJLLOEEDJEA_.CalculateSize(_repeated_mJLLOEEDJEA_codec);
		num += mPEMBDAGJJO_.CalculateSize(_repeated_mPEMBDAGJJO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LIOLPIJOMBI other)
	{
		if (other != null)
		{
			mJLLOEEDJEA_.Add(other.mJLLOEEDJEA_);
			mPEMBDAGJJO_.Add(other.mPEMBDAGJJO_);
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
			case 10u:
				mJLLOEEDJEA_.AddEntriesFrom(ref input, _repeated_mJLLOEEDJEA_codec);
				break;
			case 24u:
			case 26u:
				mPEMBDAGJJO_.AddEntriesFrom(ref input, _repeated_mPEMBDAGJJO_codec);
				break;
			}
		}
	}
}
