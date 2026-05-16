using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BFHNCFDGCLG : IMessage<BFHNCFDGCLG>, IMessage, IEquatable<BFHNCFDGCLG>, IDeepCloneable<BFHNCFDGCLG>, IBufferMessage
{
	private static readonly MessageParser<BFHNCFDGCLG> _parser = new MessageParser<BFHNCFDGCLG>(() => new BFHNCFDGCLG());

	private UnknownFieldSet _unknownFields;

	public const int MFOHABEOFFMFieldNumber = 5;

	private static readonly FieldCodec<JCHADPPOKAD> _repeated_mFOHABEOFFM_codec = FieldCodec.ForEnum(42u, (JCHADPPOKAD x) => (int)x, (int x) => (JCHADPPOKAD)x);

	private readonly RepeatedField<JCHADPPOKAD> mFOHABEOFFM_ = new RepeatedField<JCHADPPOKAD>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BFHNCFDGCLG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BFHNCFDGCLGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JCHADPPOKAD> MFOHABEOFFM => mFOHABEOFFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFHNCFDGCLG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFHNCFDGCLG(BFHNCFDGCLG other)
		: this()
	{
		mFOHABEOFFM_ = other.mFOHABEOFFM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFHNCFDGCLG Clone()
	{
		return new BFHNCFDGCLG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BFHNCFDGCLG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BFHNCFDGCLG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mFOHABEOFFM_.Equals(other.mFOHABEOFFM_))
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
		num ^= mFOHABEOFFM_.GetHashCode();
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
		mFOHABEOFFM_.WriteTo(ref output, _repeated_mFOHABEOFFM_codec);
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
		num += mFOHABEOFFM_.CalculateSize(_repeated_mFOHABEOFFM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BFHNCFDGCLG other)
	{
		if (other != null)
		{
			mFOHABEOFFM_.Add(other.mFOHABEOFFM_);
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
			if (num != 40 && num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				mFOHABEOFFM_.AddEntriesFrom(ref input, _repeated_mFOHABEOFFM_codec);
			}
		}
	}
}
