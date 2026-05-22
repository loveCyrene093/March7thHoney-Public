using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GIFNOKLKCGH : IMessage<GIFNOKLKCGH>, IMessage, IEquatable<GIFNOKLKCGH>, IDeepCloneable<GIFNOKLKCGH>, IBufferMessage
{
	private static readonly MessageParser<GIFNOKLKCGH> _parser = new MessageParser<GIFNOKLKCGH>(() => new GIFNOKLKCGH());

	private UnknownFieldSet _unknownFields;

	public const int DNLALPGKFDKFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_dNLALPGKFDK_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> dNLALPGKFDK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GIFNOKLKCGH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GIFNOKLKCGHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DNLALPGKFDK => dNLALPGKFDK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GIFNOKLKCGH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GIFNOKLKCGH(GIFNOKLKCGH other)
		: this()
	{
		dNLALPGKFDK_ = other.dNLALPGKFDK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GIFNOKLKCGH Clone()
	{
		return new GIFNOKLKCGH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GIFNOKLKCGH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GIFNOKLKCGH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dNLALPGKFDK_.Equals(other.dNLALPGKFDK_))
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
		num ^= dNLALPGKFDK_.GetHashCode();
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
		dNLALPGKFDK_.WriteTo(ref output, _repeated_dNLALPGKFDK_codec);
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
		num += dNLALPGKFDK_.CalculateSize(_repeated_dNLALPGKFDK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GIFNOKLKCGH other)
	{
		if (other != null)
		{
			dNLALPGKFDK_.Add(other.dNLALPGKFDK_);
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
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				dNLALPGKFDK_.AddEntriesFrom(ref input, _repeated_dNLALPGKFDK_codec);
			}
		}
	}
}
