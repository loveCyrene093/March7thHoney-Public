using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMissionStatusScRsp : IMessage<GetMissionStatusScRsp>, IMessage, IEquatable<GetMissionStatusScRsp>, IDeepCloneable<GetMissionStatusScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetMissionStatusScRsp> _parser = new MessageParser<GetMissionStatusScRsp>(() => new GetMissionStatusScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CurversionFinishedMainMissionIdListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_curversionFinishedMainMissionIdList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> curversionFinishedMainMissionIdList_ = new RepeatedField<uint>();

	public const int SubMissionStatusListFieldNumber = 2;

	private static readonly FieldCodec<Mission> _repeated_subMissionStatusList_codec = FieldCodec.ForMessage(18u, Mission.Parser);

	private readonly RepeatedField<Mission> subMissionStatusList_ = new RepeatedField<Mission>();

	public const int DisabledMainMissionIdListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_disabledMainMissionIdList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> disabledMainMissionIdList_ = new RepeatedField<uint>();

	public const int UnfinishedMainMissionIdListFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_unfinishedMainMissionIdList_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> unfinishedMainMissionIdList_ = new RepeatedField<uint>();

	public const int FinishedMainMissionIdListFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_finishedMainMissionIdList_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> finishedMainMissionIdList_ = new RepeatedField<uint>();

	public const int MainMissionMcvListFieldNumber = 11;

	private static readonly FieldCodec<MainMissionCustomValue> _repeated_mainMissionMcvList_codec = FieldCodec.ForMessage(90u, MainMissionCustomValue.Parser);

	private readonly RepeatedField<MainMissionCustomValue> mainMissionMcvList_ = new RepeatedField<MainMissionCustomValue>();

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMissionStatusScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMissionStatusScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CurversionFinishedMainMissionIdList => curversionFinishedMainMissionIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Mission> SubMissionStatusList => subMissionStatusList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DisabledMainMissionIdList => disabledMainMissionIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnfinishedMainMissionIdList => unfinishedMainMissionIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishedMainMissionIdList => finishedMainMissionIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MainMissionCustomValue> MainMissionMcvList => mainMissionMcvList_;

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
	public GetMissionStatusScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMissionStatusScRsp(GetMissionStatusScRsp other)
		: this()
	{
		curversionFinishedMainMissionIdList_ = other.curversionFinishedMainMissionIdList_.Clone();
		subMissionStatusList_ = other.subMissionStatusList_.Clone();
		disabledMainMissionIdList_ = other.disabledMainMissionIdList_.Clone();
		unfinishedMainMissionIdList_ = other.unfinishedMainMissionIdList_.Clone();
		finishedMainMissionIdList_ = other.finishedMainMissionIdList_.Clone();
		mainMissionMcvList_ = other.mainMissionMcvList_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMissionStatusScRsp Clone()
	{
		return new GetMissionStatusScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMissionStatusScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMissionStatusScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!curversionFinishedMainMissionIdList_.Equals(other.curversionFinishedMainMissionIdList_))
		{
			return false;
		}
		if (!subMissionStatusList_.Equals(other.subMissionStatusList_))
		{
			return false;
		}
		if (!disabledMainMissionIdList_.Equals(other.disabledMainMissionIdList_))
		{
			return false;
		}
		if (!unfinishedMainMissionIdList_.Equals(other.unfinishedMainMissionIdList_))
		{
			return false;
		}
		if (!finishedMainMissionIdList_.Equals(other.finishedMainMissionIdList_))
		{
			return false;
		}
		if (!mainMissionMcvList_.Equals(other.mainMissionMcvList_))
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
		num ^= curversionFinishedMainMissionIdList_.GetHashCode();
		num ^= subMissionStatusList_.GetHashCode();
		num ^= disabledMainMissionIdList_.GetHashCode();
		num ^= unfinishedMainMissionIdList_.GetHashCode();
		num ^= finishedMainMissionIdList_.GetHashCode();
		num ^= mainMissionMcvList_.GetHashCode();
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
		curversionFinishedMainMissionIdList_.WriteTo(ref output, _repeated_curversionFinishedMainMissionIdList_codec);
		subMissionStatusList_.WriteTo(ref output, _repeated_subMissionStatusList_codec);
		disabledMainMissionIdList_.WriteTo(ref output, _repeated_disabledMainMissionIdList_codec);
		unfinishedMainMissionIdList_.WriteTo(ref output, _repeated_unfinishedMainMissionIdList_codec);
		finishedMainMissionIdList_.WriteTo(ref output, _repeated_finishedMainMissionIdList_codec);
		mainMissionMcvList_.WriteTo(ref output, _repeated_mainMissionMcvList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		num += curversionFinishedMainMissionIdList_.CalculateSize(_repeated_curversionFinishedMainMissionIdList_codec);
		num += subMissionStatusList_.CalculateSize(_repeated_subMissionStatusList_codec);
		num += disabledMainMissionIdList_.CalculateSize(_repeated_disabledMainMissionIdList_codec);
		num += unfinishedMainMissionIdList_.CalculateSize(_repeated_unfinishedMainMissionIdList_codec);
		num += finishedMainMissionIdList_.CalculateSize(_repeated_finishedMainMissionIdList_codec);
		num += mainMissionMcvList_.CalculateSize(_repeated_mainMissionMcvList_codec);
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
	public void MergeFrom(GetMissionStatusScRsp other)
	{
		if (other != null)
		{
			curversionFinishedMainMissionIdList_.Add(other.curversionFinishedMainMissionIdList_);
			subMissionStatusList_.Add(other.subMissionStatusList_);
			disabledMainMissionIdList_.Add(other.disabledMainMissionIdList_);
			unfinishedMainMissionIdList_.Add(other.unfinishedMainMissionIdList_);
			finishedMainMissionIdList_.Add(other.finishedMainMissionIdList_);
			mainMissionMcvList_.Add(other.mainMissionMcvList_);
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
			case 8u:
			case 10u:
				curversionFinishedMainMissionIdList_.AddEntriesFrom(ref input, _repeated_curversionFinishedMainMissionIdList_codec);
				break;
			case 18u:
				subMissionStatusList_.AddEntriesFrom(ref input, _repeated_subMissionStatusList_codec);
				break;
			case 48u:
			case 50u:
				disabledMainMissionIdList_.AddEntriesFrom(ref input, _repeated_disabledMainMissionIdList_codec);
				break;
			case 56u:
			case 58u:
				unfinishedMainMissionIdList_.AddEntriesFrom(ref input, _repeated_unfinishedMainMissionIdList_codec);
				break;
			case 72u:
			case 74u:
				finishedMainMissionIdList_.AddEntriesFrom(ref input, _repeated_finishedMainMissionIdList_codec);
				break;
			case 90u:
				mainMissionMcvList_.AddEntriesFrom(ref input, _repeated_mainMissionMcvList_codec);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
