using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KMPCIKLJIHH : IMessage<KMPCIKLJIHH>, IMessage, IEquatable<KMPCIKLJIHH>, IDeepCloneable<KMPCIKLJIHH>, IBufferMessage
{
	private static readonly MessageParser<KMPCIKLJIHH> _parser = new MessageParser<KMPCIKLJIHH>(() => new KMPCIKLJIHH());

	private UnknownFieldSet _unknownFields;

	public const int OFENICFJANCFieldNumber = 4;

	private static readonly FieldCodec<AAEFGPIIHLK> _repeated_oFENICFJANC_codec = FieldCodec.ForMessage(34u, AAEFGPIIHLK.Parser);

	private readonly RepeatedField<AAEFGPIIHLK> oFENICFJANC_ = new RepeatedField<AAEFGPIIHLK>();

	public const int GBHPHCMGBGKFieldNumber = 5;

	private static readonly FieldCodec<JABFAOAIEIG> _repeated_gBHPHCMGBGK_codec = FieldCodec.ForMessage(42u, JABFAOAIEIG.Parser);

	private readonly RepeatedField<JABFAOAIEIG> gBHPHCMGBGK_ = new RepeatedField<JABFAOAIEIG>();

	public const int PADDEJDLFLAFieldNumber = 7;

	private static readonly FieldCodec<AKEKHLAEKBC> _repeated_pADDEJDLFLA_codec = FieldCodec.ForMessage(58u, AKEKHLAEKBC.Parser);

	private readonly RepeatedField<AKEKHLAEKBC> pADDEJDLFLA_ = new RepeatedField<AKEKHLAEKBC>();

	public const int BuffListFieldNumber = 8;

	private static readonly FieldCodec<PHDKMFDPABI> _repeated_buffList_codec = FieldCodec.ForMessage(66u, PHDKMFDPABI.Parser);

	private readonly RepeatedField<PHDKMFDPABI> buffList_ = new RepeatedField<PHDKMFDPABI>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KMPCIKLJIHH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KMPCIKLJIHHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AAEFGPIIHLK> OFENICFJANC => oFENICFJANC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JABFAOAIEIG> GBHPHCMGBGK => gBHPHCMGBGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AKEKHLAEKBC> PADDEJDLFLA => pADDEJDLFLA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PHDKMFDPABI> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMPCIKLJIHH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMPCIKLJIHH(KMPCIKLJIHH other)
		: this()
	{
		oFENICFJANC_ = other.oFENICFJANC_.Clone();
		gBHPHCMGBGK_ = other.gBHPHCMGBGK_.Clone();
		pADDEJDLFLA_ = other.pADDEJDLFLA_.Clone();
		buffList_ = other.buffList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMPCIKLJIHH Clone()
	{
		return new KMPCIKLJIHH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KMPCIKLJIHH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KMPCIKLJIHH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oFENICFJANC_.Equals(other.oFENICFJANC_))
		{
			return false;
		}
		if (!gBHPHCMGBGK_.Equals(other.gBHPHCMGBGK_))
		{
			return false;
		}
		if (!pADDEJDLFLA_.Equals(other.pADDEJDLFLA_))
		{
			return false;
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
		num ^= oFENICFJANC_.GetHashCode();
		num ^= gBHPHCMGBGK_.GetHashCode();
		num ^= pADDEJDLFLA_.GetHashCode();
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
		oFENICFJANC_.WriteTo(ref output, _repeated_oFENICFJANC_codec);
		gBHPHCMGBGK_.WriteTo(ref output, _repeated_gBHPHCMGBGK_codec);
		pADDEJDLFLA_.WriteTo(ref output, _repeated_pADDEJDLFLA_codec);
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
		num += oFENICFJANC_.CalculateSize(_repeated_oFENICFJANC_codec);
		num += gBHPHCMGBGK_.CalculateSize(_repeated_gBHPHCMGBGK_codec);
		num += pADDEJDLFLA_.CalculateSize(_repeated_pADDEJDLFLA_codec);
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KMPCIKLJIHH other)
	{
		if (other != null)
		{
			oFENICFJANC_.Add(other.oFENICFJANC_);
			gBHPHCMGBGK_.Add(other.gBHPHCMGBGK_);
			pADDEJDLFLA_.Add(other.pADDEJDLFLA_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 34u:
				oFENICFJANC_.AddEntriesFrom(ref input, _repeated_oFENICFJANC_codec);
				break;
			case 42u:
				gBHPHCMGBGK_.AddEntriesFrom(ref input, _repeated_gBHPHCMGBGK_codec);
				break;
			case 58u:
				pADDEJDLFLA_.AddEntriesFrom(ref input, _repeated_pADDEJDLFLA_codec);
				break;
			case 66u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			}
		}
	}
}
