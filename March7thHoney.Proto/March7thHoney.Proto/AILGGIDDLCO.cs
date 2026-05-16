using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AILGGIDDLCO : IMessage<AILGGIDDLCO>, IMessage, IEquatable<AILGGIDDLCO>, IDeepCloneable<AILGGIDDLCO>, IBufferMessage
{
	private static readonly MessageParser<AILGGIDDLCO> _parser = new MessageParser<AILGGIDDLCO>(() => new AILGGIDDLCO());

	private UnknownFieldSet _unknownFields;

	public const int JBOCOPNEJLBFieldNumber = 14;

	private static readonly FieldCodec<ANBOFKHHDNE> _repeated_jBOCOPNEJLB_codec = FieldCodec.ForMessage(114u, ANBOFKHHDNE.Parser);

	private readonly RepeatedField<ANBOFKHHDNE> jBOCOPNEJLB_ = new RepeatedField<ANBOFKHHDNE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AILGGIDDLCO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AILGGIDDLCOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ANBOFKHHDNE> JBOCOPNEJLB => jBOCOPNEJLB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AILGGIDDLCO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AILGGIDDLCO(AILGGIDDLCO other)
		: this()
	{
		jBOCOPNEJLB_ = other.jBOCOPNEJLB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AILGGIDDLCO Clone()
	{
		return new AILGGIDDLCO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AILGGIDDLCO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AILGGIDDLCO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jBOCOPNEJLB_.Equals(other.jBOCOPNEJLB_))
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
		num ^= jBOCOPNEJLB_.GetHashCode();
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
		jBOCOPNEJLB_.WriteTo(ref output, _repeated_jBOCOPNEJLB_codec);
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
		num += jBOCOPNEJLB_.CalculateSize(_repeated_jBOCOPNEJLB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AILGGIDDLCO other)
	{
		if (other != null)
		{
			jBOCOPNEJLB_.Add(other.jBOCOPNEJLB_);
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
			if (num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				jBOCOPNEJLB_.AddEntriesFrom(ref input, _repeated_jBOCOPNEJLB_codec);
			}
		}
	}
}
