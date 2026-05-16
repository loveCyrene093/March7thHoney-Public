using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class APNHPMINDKB : IMessage<APNHPMINDKB>, IMessage, IEquatable<APNHPMINDKB>, IDeepCloneable<APNHPMINDKB>, IBufferMessage
{
	private static readonly MessageParser<APNHPMINDKB> _parser = new MessageParser<APNHPMINDKB>(() => new APNHPMINDKB());

	private UnknownFieldSet _unknownFields;

	public const int JJAABLCMFLPFieldNumber = 10;

	private static readonly FieldCodec<BAIKMOMEJMB> _repeated_jJAABLCMFLP_codec = FieldCodec.ForMessage(82u, BAIKMOMEJMB.Parser);

	private readonly RepeatedField<BAIKMOMEJMB> jJAABLCMFLP_ = new RepeatedField<BAIKMOMEJMB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<APNHPMINDKB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => APNHPMINDKBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BAIKMOMEJMB> JJAABLCMFLP => jJAABLCMFLP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APNHPMINDKB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APNHPMINDKB(APNHPMINDKB other)
		: this()
	{
		jJAABLCMFLP_ = other.jJAABLCMFLP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APNHPMINDKB Clone()
	{
		return new APNHPMINDKB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as APNHPMINDKB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(APNHPMINDKB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jJAABLCMFLP_.Equals(other.jJAABLCMFLP_))
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
		num ^= jJAABLCMFLP_.GetHashCode();
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
		jJAABLCMFLP_.WriteTo(ref output, _repeated_jJAABLCMFLP_codec);
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
		num += jJAABLCMFLP_.CalculateSize(_repeated_jJAABLCMFLP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(APNHPMINDKB other)
	{
		if (other != null)
		{
			jJAABLCMFLP_.Add(other.jJAABLCMFLP_);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				jJAABLCMFLP_.AddEntriesFrom(ref input, _repeated_jJAABLCMFLP_codec);
			}
		}
	}
}
