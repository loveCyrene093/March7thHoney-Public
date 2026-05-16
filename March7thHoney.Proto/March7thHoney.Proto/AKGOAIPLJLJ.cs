using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AKGOAIPLJLJ : IMessage<AKGOAIPLJLJ>, IMessage, IEquatable<AKGOAIPLJLJ>, IDeepCloneable<AKGOAIPLJLJ>, IBufferMessage
{
	private static readonly MessageParser<AKGOAIPLJLJ> _parser = new MessageParser<AKGOAIPLJLJ>(() => new AKGOAIPLJLJ());

	private UnknownFieldSet _unknownFields;

	public const int GBHPHCMGBGKFieldNumber = 5;

	private static readonly FieldCodec<LNGJLLKGMNA> _repeated_gBHPHCMGBGK_codec = FieldCodec.ForMessage(42u, LNGJLLKGMNA.Parser);

	private readonly RepeatedField<LNGJLLKGMNA> gBHPHCMGBGK_ = new RepeatedField<LNGJLLKGMNA>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AKGOAIPLJLJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AKGOAIPLJLJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LNGJLLKGMNA> GBHPHCMGBGK => gBHPHCMGBGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKGOAIPLJLJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKGOAIPLJLJ(AKGOAIPLJLJ other)
		: this()
	{
		gBHPHCMGBGK_ = other.gBHPHCMGBGK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKGOAIPLJLJ Clone()
	{
		return new AKGOAIPLJLJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AKGOAIPLJLJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AKGOAIPLJLJ other)
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
	public void MergeFrom(AKGOAIPLJLJ other)
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
			if (num != 42)
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
