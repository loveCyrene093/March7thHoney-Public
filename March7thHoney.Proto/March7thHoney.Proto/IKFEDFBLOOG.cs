using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IKFEDFBLOOG : IMessage<IKFEDFBLOOG>, IMessage, IEquatable<IKFEDFBLOOG>, IDeepCloneable<IKFEDFBLOOG>, IBufferMessage
{
	private static readonly MessageParser<IKFEDFBLOOG> _parser = new MessageParser<IKFEDFBLOOG>(() => new IKFEDFBLOOG());

	private UnknownFieldSet _unknownFields;

	public const int LMJKIPEJBEBFieldNumber = 4;

	private static readonly FieldCodec<OHMIINKLKAM> _repeated_lMJKIPEJBEB_codec = FieldCodec.ForMessage(34u, OHMIINKLKAM.Parser);

	private readonly RepeatedField<OHMIINKLKAM> lMJKIPEJBEB_ = new RepeatedField<OHMIINKLKAM>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IKFEDFBLOOG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IKFEDFBLOOGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OHMIINKLKAM> LMJKIPEJBEB => lMJKIPEJBEB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IKFEDFBLOOG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IKFEDFBLOOG(IKFEDFBLOOG other)
		: this()
	{
		lMJKIPEJBEB_ = other.lMJKIPEJBEB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IKFEDFBLOOG Clone()
	{
		return new IKFEDFBLOOG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IKFEDFBLOOG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IKFEDFBLOOG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lMJKIPEJBEB_.Equals(other.lMJKIPEJBEB_))
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
		num ^= lMJKIPEJBEB_.GetHashCode();
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
		lMJKIPEJBEB_.WriteTo(ref output, _repeated_lMJKIPEJBEB_codec);
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
		num += lMJKIPEJBEB_.CalculateSize(_repeated_lMJKIPEJBEB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IKFEDFBLOOG other)
	{
		if (other != null)
		{
			lMJKIPEJBEB_.Add(other.lMJKIPEJBEB_);
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
			if (num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				lMJKIPEJBEB_.AddEntriesFrom(ref input, _repeated_lMJKIPEJBEB_codec);
			}
		}
	}
}
