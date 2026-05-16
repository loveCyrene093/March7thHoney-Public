using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetExpeditionDataScRsp : IMessage<GetExpeditionDataScRsp>, IMessage, IEquatable<GetExpeditionDataScRsp>, IDeepCloneable<GetExpeditionDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetExpeditionDataScRsp> _parser = new MessageParser<GetExpeditionDataScRsp>(() => new GetExpeditionDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int KAMBBFDEBAMFieldNumber = 6;

	private long kAMBBFDEBAM_;

	public const int ExpeditionInfoFieldNumber = 7;

	private static readonly FieldCodec<ExpeditionInfo> _repeated_expeditionInfo_codec = FieldCodec.ForMessage(58u, March7thHoney.Proto.ExpeditionInfo.Parser);

	private readonly RepeatedField<ExpeditionInfo> expeditionInfo_ = new RepeatedField<ExpeditionInfo>();

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int TotalExpeditionCountFieldNumber = 12;

	private uint totalExpeditionCount_;

	public const int NBKFAEDOGPGFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_nBKFAEDOGPG_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> nBKFAEDOGPG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetExpeditionDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetExpeditionDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long KAMBBFDEBAM
	{
		get
		{
			return kAMBBFDEBAM_;
		}
		set
		{
			kAMBBFDEBAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ExpeditionInfo> ExpeditionInfo => expeditionInfo_;

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
	public uint TotalExpeditionCount
	{
		get
		{
			return totalExpeditionCount_;
		}
		set
		{
			totalExpeditionCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NBKFAEDOGPG => nBKFAEDOGPG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetExpeditionDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetExpeditionDataScRsp(GetExpeditionDataScRsp other)
		: this()
	{
		kAMBBFDEBAM_ = other.kAMBBFDEBAM_;
		expeditionInfo_ = other.expeditionInfo_.Clone();
		retcode_ = other.retcode_;
		totalExpeditionCount_ = other.totalExpeditionCount_;
		nBKFAEDOGPG_ = other.nBKFAEDOGPG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetExpeditionDataScRsp Clone()
	{
		return new GetExpeditionDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetExpeditionDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetExpeditionDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KAMBBFDEBAM != other.KAMBBFDEBAM)
		{
			return false;
		}
		if (!expeditionInfo_.Equals(other.expeditionInfo_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (TotalExpeditionCount != other.TotalExpeditionCount)
		{
			return false;
		}
		if (!nBKFAEDOGPG_.Equals(other.nBKFAEDOGPG_))
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
		if (KAMBBFDEBAM != 0L)
		{
			num ^= KAMBBFDEBAM.GetHashCode();
		}
		num ^= expeditionInfo_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (TotalExpeditionCount != 0)
		{
			num ^= TotalExpeditionCount.GetHashCode();
		}
		num ^= nBKFAEDOGPG_.GetHashCode();
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
		if (KAMBBFDEBAM != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(KAMBBFDEBAM);
		}
		expeditionInfo_.WriteTo(ref output, _repeated_expeditionInfo_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (TotalExpeditionCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(TotalExpeditionCount);
		}
		nBKFAEDOGPG_.WriteTo(ref output, _repeated_nBKFAEDOGPG_codec);
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
		if (KAMBBFDEBAM != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(KAMBBFDEBAM);
		}
		num += expeditionInfo_.CalculateSize(_repeated_expeditionInfo_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (TotalExpeditionCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalExpeditionCount);
		}
		num += nBKFAEDOGPG_.CalculateSize(_repeated_nBKFAEDOGPG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetExpeditionDataScRsp other)
	{
		if (other != null)
		{
			if (other.KAMBBFDEBAM != 0L)
			{
				KAMBBFDEBAM = other.KAMBBFDEBAM;
			}
			expeditionInfo_.Add(other.expeditionInfo_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.TotalExpeditionCount != 0)
			{
				TotalExpeditionCount = other.TotalExpeditionCount;
			}
			nBKFAEDOGPG_.Add(other.nBKFAEDOGPG_);
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
			case 48u:
				KAMBBFDEBAM = input.ReadInt64();
				break;
			case 58u:
				expeditionInfo_.AddEntriesFrom(ref input, _repeated_expeditionInfo_codec);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
				TotalExpeditionCount = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				nBKFAEDOGPG_.AddEntriesFrom(ref input, _repeated_nBKFAEDOGPG_codec);
				break;
			}
		}
	}
}
