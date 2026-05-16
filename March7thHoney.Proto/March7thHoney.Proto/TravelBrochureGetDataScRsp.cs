using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TravelBrochureGetDataScRsp : IMessage<TravelBrochureGetDataScRsp>, IMessage, IEquatable<TravelBrochureGetDataScRsp>, IDeepCloneable<TravelBrochureGetDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<TravelBrochureGetDataScRsp> _parser = new MessageParser<TravelBrochureGetDataScRsp>(() => new TravelBrochureGetDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LNDBNIHAICBFieldNumber = 3;

	private static readonly MapField<uint, PBPIOFGODHC>.Codec _map_lNDBNIHAICB_codec = new MapField<uint, PBPIOFGODHC>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, PBPIOFGODHC.Parser), 26u);

	private readonly MapField<uint, PBPIOFGODHC> lNDBNIHAICB_ = new MapField<uint, PBPIOFGODHC>();

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int CustomValueFieldNumber = 14;

	private uint customValue_;

	public const int CIBCCOJLLIAFieldNumber = 15;

	private static readonly MapField<uint, uint>.Codec _map_cIBCCOJLLIA_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 122u);

	private readonly MapField<uint, uint> cIBCCOJLLIA_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TravelBrochureGetDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TravelBrochureGetDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, PBPIOFGODHC> LNDBNIHAICB => lNDBNIHAICB_;

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
	public uint CustomValue
	{
		get
		{
			return customValue_;
		}
		set
		{
			customValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> CIBCCOJLLIA => cIBCCOJLLIA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureGetDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureGetDataScRsp(TravelBrochureGetDataScRsp other)
		: this()
	{
		lNDBNIHAICB_ = other.lNDBNIHAICB_.Clone();
		retcode_ = other.retcode_;
		customValue_ = other.customValue_;
		cIBCCOJLLIA_ = other.cIBCCOJLLIA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureGetDataScRsp Clone()
	{
		return new TravelBrochureGetDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TravelBrochureGetDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TravelBrochureGetDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!LNDBNIHAICB.Equals(other.LNDBNIHAICB))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (CustomValue != other.CustomValue)
		{
			return false;
		}
		if (!CIBCCOJLLIA.Equals(other.CIBCCOJLLIA))
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
		num ^= LNDBNIHAICB.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (CustomValue != 0)
		{
			num ^= CustomValue.GetHashCode();
		}
		num ^= CIBCCOJLLIA.GetHashCode();
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
		lNDBNIHAICB_.WriteTo(ref output, _map_lNDBNIHAICB_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (CustomValue != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CustomValue);
		}
		cIBCCOJLLIA_.WriteTo(ref output, _map_cIBCCOJLLIA_codec);
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
		num += lNDBNIHAICB_.CalculateSize(_map_lNDBNIHAICB_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (CustomValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CustomValue);
		}
		num += cIBCCOJLLIA_.CalculateSize(_map_cIBCCOJLLIA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TravelBrochureGetDataScRsp other)
	{
		if (other != null)
		{
			lNDBNIHAICB_.MergeFrom(other.lNDBNIHAICB_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.CustomValue != 0)
			{
				CustomValue = other.CustomValue;
			}
			cIBCCOJLLIA_.MergeFrom(other.cIBCCOJLLIA_);
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
			case 26u:
				lNDBNIHAICB_.AddEntriesFrom(ref input, _map_lNDBNIHAICB_codec);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				CustomValue = input.ReadUInt32();
				break;
			case 122u:
				cIBCCOJLLIA_.AddEntriesFrom(ref input, _map_cIBCCOJLLIA_codec);
				break;
			}
		}
	}
}
