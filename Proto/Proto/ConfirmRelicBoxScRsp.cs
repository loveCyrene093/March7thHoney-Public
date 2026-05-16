using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ConfirmRelicBoxScRsp : IMessage<ConfirmRelicBoxScRsp>, IMessage, IEquatable<ConfirmRelicBoxScRsp>, IDeepCloneable<ConfirmRelicBoxScRsp>, IBufferMessage
{
	private static readonly MessageParser<ConfirmRelicBoxScRsp> _parser = new MessageParser<ConfirmRelicBoxScRsp>(() => new ConfirmRelicBoxScRsp());

	private UnknownFieldSet _unknownFields;

	public const int NLGFAAFIIIEFieldNumber = 1;

	private bool nLGFAAFIIIE_;

	public const int KAIMHOJAAKPFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_kAIMHOJAAKP_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> kAIMHOJAAKP_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int EKAOCHPHOAAFieldNumber = 13;

	private uint eKAOCHPHOAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ConfirmRelicBoxScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ConfirmRelicBoxScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NLGFAAFIIIE
	{
		get
		{
			return nLGFAAFIIIE_;
		}
		set
		{
			nLGFAAFIIIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KAIMHOJAAKP => kAIMHOJAAKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EKAOCHPHOAA
	{
		get
		{
			return eKAOCHPHOAA_;
		}
		set
		{
			eKAOCHPHOAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConfirmRelicBoxScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConfirmRelicBoxScRsp(ConfirmRelicBoxScRsp other)
		: this()
	{
		nLGFAAFIIIE_ = other.nLGFAAFIIIE_;
		kAIMHOJAAKP_ = other.kAIMHOJAAKP_.Clone();
		retcode_ = other.retcode_;
		eKAOCHPHOAA_ = other.eKAOCHPHOAA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConfirmRelicBoxScRsp Clone()
	{
		return new ConfirmRelicBoxScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ConfirmRelicBoxScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ConfirmRelicBoxScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NLGFAAFIIIE != other.NLGFAAFIIIE)
		{
			return false;
		}
		if (!kAIMHOJAAKP_.Equals(other.kAIMHOJAAKP_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (EKAOCHPHOAA != other.EKAOCHPHOAA)
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
		if (NLGFAAFIIIE)
		{
			num ^= NLGFAAFIIIE.GetHashCode();
		}
		num ^= kAIMHOJAAKP_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (EKAOCHPHOAA != 0)
		{
			num ^= EKAOCHPHOAA.GetHashCode();
		}
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
		if (NLGFAAFIIIE)
		{
			output.WriteRawTag(8);
			output.WriteBool(NLGFAAFIIIE);
		}
		kAIMHOJAAKP_.WriteTo(ref output, _repeated_kAIMHOJAAKP_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (EKAOCHPHOAA != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(EKAOCHPHOAA);
		}
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
		if (NLGFAAFIIIE)
		{
			num += 2;
		}
		num += kAIMHOJAAKP_.CalculateSize(_repeated_kAIMHOJAAKP_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (EKAOCHPHOAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EKAOCHPHOAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ConfirmRelicBoxScRsp other)
	{
		if (other != null)
		{
			if (other.NLGFAAFIIIE)
			{
				NLGFAAFIIIE = other.NLGFAAFIIIE;
			}
			kAIMHOJAAKP_.Add(other.kAIMHOJAAKP_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.EKAOCHPHOAA != 0)
			{
				EKAOCHPHOAA = other.EKAOCHPHOAA;
			}
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
			case 8u:
				NLGFAAFIIIE = input.ReadBool();
				break;
			case 24u:
			case 26u:
				kAIMHOJAAKP_.AddEntriesFrom(ref input, _repeated_kAIMHOJAAKP_codec);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				EKAOCHPHOAA = input.ReadUInt32();
				break;
			}
		}
	}
}
