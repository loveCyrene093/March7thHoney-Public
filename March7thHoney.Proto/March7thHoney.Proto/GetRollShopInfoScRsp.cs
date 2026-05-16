using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRollShopInfoScRsp : IMessage<GetRollShopInfoScRsp>, IMessage, IEquatable<GetRollShopInfoScRsp>, IDeepCloneable<GetRollShopInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetRollShopInfoScRsp> _parser = new MessageParser<GetRollShopInfoScRsp>(() => new GetRollShopInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ShopGroupIdListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_shopGroupIdList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> shopGroupIdList_ = new RepeatedField<uint>();

	public const int GachaRandomFieldNumber = 3;

	private uint gachaRandom_;

	public const int RollShopIdFieldNumber = 7;

	private uint rollShopId_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRollShopInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRollShopInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ShopGroupIdList => shopGroupIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaRandom
	{
		get
		{
			return gachaRandom_;
		}
		set
		{
			gachaRandom_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RollShopId
	{
		get
		{
			return rollShopId_;
		}
		set
		{
			rollShopId_ = value;
		}
	}

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
	public GetRollShopInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRollShopInfoScRsp(GetRollShopInfoScRsp other)
		: this()
	{
		shopGroupIdList_ = other.shopGroupIdList_.Clone();
		gachaRandom_ = other.gachaRandom_;
		rollShopId_ = other.rollShopId_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRollShopInfoScRsp Clone()
	{
		return new GetRollShopInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRollShopInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRollShopInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!shopGroupIdList_.Equals(other.shopGroupIdList_))
		{
			return false;
		}
		if (GachaRandom != other.GachaRandom)
		{
			return false;
		}
		if (RollShopId != other.RollShopId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= shopGroupIdList_.GetHashCode();
		if (GachaRandom != 0)
		{
			num ^= GachaRandom.GetHashCode();
		}
		if (RollShopId != 0)
		{
			num ^= RollShopId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		shopGroupIdList_.WriteTo(ref output, _repeated_shopGroupIdList_codec);
		if (GachaRandom != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GachaRandom);
		}
		if (RollShopId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(RollShopId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
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
		num += shopGroupIdList_.CalculateSize(_repeated_shopGroupIdList_codec);
		if (GachaRandom != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaRandom);
		}
		if (RollShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RollShopId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetRollShopInfoScRsp other)
	{
		if (other != null)
		{
			shopGroupIdList_.Add(other.shopGroupIdList_);
			if (other.GachaRandom != 0)
			{
				GachaRandom = other.GachaRandom;
			}
			if (other.RollShopId != 0)
			{
				RollShopId = other.RollShopId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 16u:
			case 18u:
				shopGroupIdList_.AddEntriesFrom(ref input, _repeated_shopGroupIdList_codec);
				break;
			case 24u:
				GachaRandom = input.ReadUInt32();
				break;
			case 56u:
				RollShopId = input.ReadUInt32();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
