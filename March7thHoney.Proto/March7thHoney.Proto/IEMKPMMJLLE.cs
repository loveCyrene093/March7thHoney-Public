using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IEMKPMMJLLE : IMessage<IEMKPMMJLLE>, IMessage, IEquatable<IEMKPMMJLLE>, IDeepCloneable<IEMKPMMJLLE>, IBufferMessage
{
	private static readonly MessageParser<IEMKPMMJLLE> _parser = new MessageParser<IEMKPMMJLLE>(() => new IEMKPMMJLLE());

	private UnknownFieldSet _unknownFields;

	public const int GBHPHCMGBGKFieldNumber = 3;

	private static readonly FieldCodec<CGDLAIPNECD> _repeated_gBHPHCMGBGK_codec = FieldCodec.ForMessage(26u, CGDLAIPNECD.Parser);

	private readonly RepeatedField<CGDLAIPNECD> gBHPHCMGBGK_ = new RepeatedField<CGDLAIPNECD>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IEMKPMMJLLE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IEMKPMMJLLEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CGDLAIPNECD> GBHPHCMGBGK => gBHPHCMGBGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEMKPMMJLLE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEMKPMMJLLE(IEMKPMMJLLE other)
		: this()
	{
		gBHPHCMGBGK_ = other.gBHPHCMGBGK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IEMKPMMJLLE Clone()
	{
		return new IEMKPMMJLLE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IEMKPMMJLLE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IEMKPMMJLLE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gBHPHCMGBGK_.Equals(other.gBHPHCMGBGK_))
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
		num ^= gBHPHCMGBGK_.GetHashCode();
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
		gBHPHCMGBGK_.WriteTo(ref output, _repeated_gBHPHCMGBGK_codec);
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
		num += gBHPHCMGBGK_.CalculateSize(_repeated_gBHPHCMGBGK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IEMKPMMJLLE other)
	{
		if (other != null)
		{
			gBHPHCMGBGK_.Add(other.gBHPHCMGBGK_);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				gBHPHCMGBGK_.AddEntriesFrom(ref input, _repeated_gBHPHCMGBGK_codec);
			}
		}
	}
}
