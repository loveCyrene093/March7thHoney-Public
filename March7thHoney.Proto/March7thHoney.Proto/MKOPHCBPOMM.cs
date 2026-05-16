using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MKOPHCBPOMM : IMessage<MKOPHCBPOMM>, IMessage, IEquatable<MKOPHCBPOMM>, IDeepCloneable<MKOPHCBPOMM>, IBufferMessage
{
	private static readonly MessageParser<MKOPHCBPOMM> _parser = new MessageParser<MKOPHCBPOMM>(() => new MKOPHCBPOMM());

	private UnknownFieldSet _unknownFields;

	public const int KPJGEGMCCAGFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_kPJGEGMCCAG_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> kPJGEGMCCAG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MKOPHCBPOMM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MKOPHCBPOMMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KPJGEGMCCAG => kPJGEGMCCAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKOPHCBPOMM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKOPHCBPOMM(MKOPHCBPOMM other)
		: this()
	{
		kPJGEGMCCAG_ = other.kPJGEGMCCAG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKOPHCBPOMM Clone()
	{
		return new MKOPHCBPOMM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MKOPHCBPOMM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MKOPHCBPOMM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kPJGEGMCCAG_.Equals(other.kPJGEGMCCAG_))
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
		num ^= kPJGEGMCCAG_.GetHashCode();
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
		kPJGEGMCCAG_.WriteTo(ref output, _repeated_kPJGEGMCCAG_codec);
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
		num += kPJGEGMCCAG_.CalculateSize(_repeated_kPJGEGMCCAG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MKOPHCBPOMM other)
	{
		if (other != null)
		{
			kPJGEGMCCAG_.Add(other.kPJGEGMCCAG_);
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
			if (num != 32 && num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				kPJGEGMCCAG_.AddEntriesFrom(ref input, _repeated_kPJGEGMCCAG_codec);
			}
		}
	}
}
