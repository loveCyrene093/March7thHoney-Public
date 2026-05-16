using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BJOBDIHNLPK : IMessage<BJOBDIHNLPK>, IMessage, IEquatable<BJOBDIHNLPK>, IDeepCloneable<BJOBDIHNLPK>, IBufferMessage
{
	private static readonly MessageParser<BJOBDIHNLPK> _parser = new MessageParser<BJOBDIHNLPK>(() => new BJOBDIHNLPK());

	private UnknownFieldSet _unknownFields;

	public const int CBDBFANJGPBFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_cBDBFANJGPB_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> cBDBFANJGPB_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BJOBDIHNLPK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BJOBDIHNLPKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CBDBFANJGPB => cBDBFANJGPB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJOBDIHNLPK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJOBDIHNLPK(BJOBDIHNLPK other)
		: this()
	{
		cBDBFANJGPB_ = other.cBDBFANJGPB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJOBDIHNLPK Clone()
	{
		return new BJOBDIHNLPK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BJOBDIHNLPK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BJOBDIHNLPK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cBDBFANJGPB_.Equals(other.cBDBFANJGPB_))
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
		num ^= cBDBFANJGPB_.GetHashCode();
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
		cBDBFANJGPB_.WriteTo(ref output, _repeated_cBDBFANJGPB_codec);
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
		num += cBDBFANJGPB_.CalculateSize(_repeated_cBDBFANJGPB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BJOBDIHNLPK other)
	{
		if (other != null)
		{
			cBDBFANJGPB_.Add(other.cBDBFANJGPB_);
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
			if (num != 80 && num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cBDBFANJGPB_.AddEntriesFrom(ref input, _repeated_cBDBFANJGPB_codec);
			}
		}
	}
}
