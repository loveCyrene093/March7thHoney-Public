using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GLOONOCCEFG : IMessage<GLOONOCCEFG>, IMessage, IEquatable<GLOONOCCEFG>, IDeepCloneable<GLOONOCCEFG>, IBufferMessage
{
	private static readonly MessageParser<GLOONOCCEFG> _parser = new MessageParser<GLOONOCCEFG>(() => new GLOONOCCEFG());

	private UnknownFieldSet _unknownFields;

	public const int IKGDNGFIOIKFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_iKGDNGFIOIK_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> iKGDNGFIOIK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GLOONOCCEFG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GLOONOCCEFGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IKGDNGFIOIK => iKGDNGFIOIK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLOONOCCEFG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLOONOCCEFG(GLOONOCCEFG other)
		: this()
	{
		iKGDNGFIOIK_ = other.iKGDNGFIOIK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLOONOCCEFG Clone()
	{
		return new GLOONOCCEFG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GLOONOCCEFG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GLOONOCCEFG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iKGDNGFIOIK_.Equals(other.iKGDNGFIOIK_))
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
		num ^= iKGDNGFIOIK_.GetHashCode();
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
		iKGDNGFIOIK_.WriteTo(ref output, _repeated_iKGDNGFIOIK_codec);
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
		num += iKGDNGFIOIK_.CalculateSize(_repeated_iKGDNGFIOIK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GLOONOCCEFG other)
	{
		if (other != null)
		{
			iKGDNGFIOIK_.Add(other.iKGDNGFIOIK_);
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
				iKGDNGFIOIK_.AddEntriesFrom(ref input, _repeated_iKGDNGFIOIK_codec);
			}
		}
	}
}
