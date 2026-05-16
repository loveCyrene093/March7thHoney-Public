using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JIICPJNINBB : IMessage<JIICPJNINBB>, IMessage, IEquatable<JIICPJNINBB>, IDeepCloneable<JIICPJNINBB>, IBufferMessage
{
	private static readonly MessageParser<JIICPJNINBB> _parser = new MessageParser<JIICPJNINBB>(() => new JIICPJNINBB());

	private UnknownFieldSet _unknownFields;

	public const int JHEDINDCODEFieldNumber = 12;

	private static readonly MapField<uint, MHGCNDDMIIJ>.Codec _map_jHEDINDCODE_codec = new MapField<uint, MHGCNDDMIIJ>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, MHGCNDDMIIJ.Parser), 98u);

	private readonly MapField<uint, MHGCNDDMIIJ> jHEDINDCODE_ = new MapField<uint, MHGCNDDMIIJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JIICPJNINBB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JIICPJNINBBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, MHGCNDDMIIJ> JHEDINDCODE => jHEDINDCODE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIICPJNINBB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIICPJNINBB(JIICPJNINBB other)
		: this()
	{
		jHEDINDCODE_ = other.jHEDINDCODE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIICPJNINBB Clone()
	{
		return new JIICPJNINBB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JIICPJNINBB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JIICPJNINBB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!JHEDINDCODE.Equals(other.JHEDINDCODE))
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
		num ^= JHEDINDCODE.GetHashCode();
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
		jHEDINDCODE_.WriteTo(ref output, _map_jHEDINDCODE_codec);
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
		num += jHEDINDCODE_.CalculateSize(_map_jHEDINDCODE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JIICPJNINBB other)
	{
		if (other != null)
		{
			jHEDINDCODE_.MergeFrom(other.jHEDINDCODE_);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				jHEDINDCODE_.AddEntriesFrom(ref input, _map_jHEDINDCODE_codec);
			}
		}
	}
}
