using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHMDONEOEAK : IMessage<HHMDONEOEAK>, IMessage, IEquatable<HHMDONEOEAK>, IDeepCloneable<HHMDONEOEAK>, IBufferMessage
{
	private static readonly MessageParser<HHMDONEOEAK> _parser = new MessageParser<HHMDONEOEAK>(() => new HHMDONEOEAK());

	private UnknownFieldSet _unknownFields;

	public const int MCOAMPKKLJLFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_mCOAMPKKLJL_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> mCOAMPKKLJL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHMDONEOEAK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHMDONEOEAKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MCOAMPKKLJL => mCOAMPKKLJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHMDONEOEAK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHMDONEOEAK(HHMDONEOEAK other)
		: this()
	{
		mCOAMPKKLJL_ = other.mCOAMPKKLJL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHMDONEOEAK Clone()
	{
		return new HHMDONEOEAK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHMDONEOEAK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHMDONEOEAK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mCOAMPKKLJL_.Equals(other.mCOAMPKKLJL_))
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
		num ^= mCOAMPKKLJL_.GetHashCode();
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
		mCOAMPKKLJL_.WriteTo(ref output, _repeated_mCOAMPKKLJL_codec);
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
		num += mCOAMPKKLJL_.CalculateSize(_repeated_mCOAMPKKLJL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHMDONEOEAK other)
	{
		if (other != null)
		{
			mCOAMPKKLJL_.Add(other.mCOAMPKKLJL_);
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
			if (num != 88 && num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				mCOAMPKKLJL_.AddEntriesFrom(ref input, _repeated_mCOAMPKKLJL_codec);
			}
		}
	}
}
