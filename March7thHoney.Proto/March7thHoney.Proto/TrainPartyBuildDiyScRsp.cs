using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartyBuildDiyScRsp : IMessage<TrainPartyBuildDiyScRsp>, IMessage, IEquatable<TrainPartyBuildDiyScRsp>, IDeepCloneable<TrainPartyBuildDiyScRsp>, IBufferMessage
{
	private static readonly MessageParser<TrainPartyBuildDiyScRsp> _parser = new MessageParser<TrainPartyBuildDiyScRsp>(() => new TrainPartyBuildDiyScRsp());

	private UnknownFieldSet _unknownFields;

	public const int AreaIdFieldNumber = 4;

	private uint areaId_;

	public const int UpdateDynamicListFieldNumber = 7;

	private static readonly FieldCodec<PPECMOMNAMG> _repeated_updateDynamicList_codec = FieldCodec.ForMessage(58u, PPECMOMNAMG.Parser);

	private readonly RepeatedField<PPECMOMNAMG> updateDynamicList_ = new RepeatedField<PPECMOMNAMG>();

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int AFGNLDIMBGBFieldNumber = 9;

	private bool aFGNLDIMBGB_;

	public const int DynamicInfoFieldNumber = 13;

	private static readonly FieldCodec<AreaDynamicInfo> _repeated_dynamicInfo_codec = FieldCodec.ForMessage(106u, AreaDynamicInfo.Parser);

	private readonly RepeatedField<AreaDynamicInfo> dynamicInfo_ = new RepeatedField<AreaDynamicInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartyBuildDiyScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartyBuildDiyScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PPECMOMNAMG> UpdateDynamicList => updateDynamicList_;

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
	public bool AFGNLDIMBGB
	{
		get
		{
			return aFGNLDIMBGB_;
		}
		set
		{
			aFGNLDIMBGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AreaDynamicInfo> DynamicInfo => dynamicInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildDiyScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildDiyScRsp(TrainPartyBuildDiyScRsp other)
		: this()
	{
		areaId_ = other.areaId_;
		updateDynamicList_ = other.updateDynamicList_.Clone();
		retcode_ = other.retcode_;
		aFGNLDIMBGB_ = other.aFGNLDIMBGB_;
		dynamicInfo_ = other.dynamicInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartyBuildDiyScRsp Clone()
	{
		return new TrainPartyBuildDiyScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartyBuildDiyScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartyBuildDiyScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (!updateDynamicList_.Equals(other.updateDynamicList_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (AFGNLDIMBGB != other.AFGNLDIMBGB)
		{
			return false;
		}
		if (!dynamicInfo_.Equals(other.dynamicInfo_))
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
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		num ^= updateDynamicList_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (AFGNLDIMBGB)
		{
			num ^= AFGNLDIMBGB.GetHashCode();
		}
		num ^= dynamicInfo_.GetHashCode();
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
		if (AreaId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AreaId);
		}
		updateDynamicList_.WriteTo(ref output, _repeated_updateDynamicList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (AFGNLDIMBGB)
		{
			output.WriteRawTag(72);
			output.WriteBool(AFGNLDIMBGB);
		}
		dynamicInfo_.WriteTo(ref output, _repeated_dynamicInfo_codec);
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
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		num += updateDynamicList_.CalculateSize(_repeated_updateDynamicList_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (AFGNLDIMBGB)
		{
			num += 2;
		}
		num += dynamicInfo_.CalculateSize(_repeated_dynamicInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartyBuildDiyScRsp other)
	{
		if (other != null)
		{
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			updateDynamicList_.Add(other.updateDynamicList_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.AFGNLDIMBGB)
			{
				AFGNLDIMBGB = other.AFGNLDIMBGB;
			}
			dynamicInfo_.Add(other.dynamicInfo_);
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
			case 32u:
				AreaId = input.ReadUInt32();
				break;
			case 58u:
				updateDynamicList_.AddEntriesFrom(ref input, _repeated_updateDynamicList_codec);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				AFGNLDIMBGB = input.ReadBool();
				break;
			case 106u:
				dynamicInfo_.AddEntriesFrom(ref input, _repeated_dynamicInfo_codec);
				break;
			}
		}
	}
}
