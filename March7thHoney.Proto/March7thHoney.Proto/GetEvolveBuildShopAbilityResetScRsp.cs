using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetEvolveBuildShopAbilityResetScRsp : IMessage<GetEvolveBuildShopAbilityResetScRsp>, IMessage, IEquatable<GetEvolveBuildShopAbilityResetScRsp>, IDeepCloneable<GetEvolveBuildShopAbilityResetScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetEvolveBuildShopAbilityResetScRsp> _parser = new MessageParser<GetEvolveBuildShopAbilityResetScRsp>(() => new GetEvolveBuildShopAbilityResetScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int PMCBBMKMHNIFieldNumber = 10;

	private static readonly FieldCodec<GPFMEDLLKGH> _repeated_pMCBBMKMHNI_codec = FieldCodec.ForMessage(82u, GPFMEDLLKGH.Parser);

	private readonly RepeatedField<GPFMEDLLKGH> pMCBBMKMHNI_ = new RepeatedField<GPFMEDLLKGH>();

	public const int ItemValueFieldNumber = 12;

	private uint itemValue_;

	public const int EGLCKGKECAJFieldNumber = 15;

	private GCHPNHBDCDO eGLCKGKECAJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetEvolveBuildShopAbilityResetScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetEvolveBuildShopAbilityResetScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<GPFMEDLLKGH> PMCBBMKMHNI => pMCBBMKMHNI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCHPNHBDCDO EGLCKGKECAJ
	{
		get
		{
			return eGLCKGKECAJ_;
		}
		set
		{
			eGLCKGKECAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildShopAbilityResetScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildShopAbilityResetScRsp(GetEvolveBuildShopAbilityResetScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		pMCBBMKMHNI_ = other.pMCBBMKMHNI_.Clone();
		itemValue_ = other.itemValue_;
		eGLCKGKECAJ_ = other.eGLCKGKECAJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildShopAbilityResetScRsp Clone()
	{
		return new GetEvolveBuildShopAbilityResetScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetEvolveBuildShopAbilityResetScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetEvolveBuildShopAbilityResetScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!pMCBBMKMHNI_.Equals(other.pMCBBMKMHNI_))
		{
			return false;
		}
		if (ItemValue != other.ItemValue)
		{
			return false;
		}
		if (EGLCKGKECAJ != other.EGLCKGKECAJ)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= pMCBBMKMHNI_.GetHashCode();
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			num ^= EGLCKGKECAJ.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		pMCBBMKMHNI_.WriteTo(ref output, _repeated_pMCBBMKMHNI_codec);
		if (ItemValue != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ItemValue);
		}
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)EGLCKGKECAJ);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += pMCBBMKMHNI_.CalculateSize(_repeated_pMCBBMKMHNI_codec);
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EGLCKGKECAJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetEvolveBuildShopAbilityResetScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			pMCBBMKMHNI_.Add(other.pMCBBMKMHNI_);
			if (other.ItemValue != 0)
			{
				ItemValue = other.ItemValue;
			}
			if (other.EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
			{
				EGLCKGKECAJ = other.EGLCKGKECAJ;
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
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				pMCBBMKMHNI_.AddEntriesFrom(ref input, _repeated_pMCBBMKMHNI_codec);
				break;
			case 96u:
				ItemValue = input.ReadUInt32();
				break;
			case 120u:
				EGLCKGKECAJ = (GCHPNHBDCDO)input.ReadEnum();
				break;
			}
		}
	}
}
