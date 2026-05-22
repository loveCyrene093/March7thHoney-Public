using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PHMBJKMKMDK : IMessage<PHMBJKMKMDK>, IMessage, IEquatable<PHMBJKMKMDK>, IDeepCloneable<PHMBJKMKMDK>, IBufferMessage
{
	private static readonly MessageParser<PHMBJKMKMDK> _parser = new MessageParser<PHMBJKMKMDK>(() => new PHMBJKMKMDK());

	private UnknownFieldSet _unknownFields;

	public const int BuffListFieldNumber = 9;

	private static readonly FieldCodec<DIMBAAJNEAF> _repeated_buffList_codec = FieldCodec.ForMessage(74u, DIMBAAJNEAF.Parser);

	private readonly RepeatedField<DIMBAAJNEAF> buffList_ = new RepeatedField<DIMBAAJNEAF>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PHMBJKMKMDK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PHMBJKMKMDKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DIMBAAJNEAF> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHMBJKMKMDK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHMBJKMKMDK(PHMBJKMKMDK other)
		: this()
	{
		buffList_ = other.buffList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHMBJKMKMDK Clone()
	{
		return new PHMBJKMKMDK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PHMBJKMKMDK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PHMBJKMKMDK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!buffList_.Equals(other.buffList_))
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
		num ^= buffList_.GetHashCode();
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
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
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
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PHMBJKMKMDK other)
	{
		if (other != null)
		{
			buffList_.Add(other.buffList_);
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
			if (num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
			}
		}
	}
}
