using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFirstTalkByPerformanceNpcScRsp : IMessage<GetFirstTalkByPerformanceNpcScRsp>, IMessage, IEquatable<GetFirstTalkByPerformanceNpcScRsp>, IDeepCloneable<GetFirstTalkByPerformanceNpcScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFirstTalkByPerformanceNpcScRsp> _parser = new MessageParser<GetFirstTalkByPerformanceNpcScRsp>(() => new GetFirstTalkByPerformanceNpcScRsp());

	private UnknownFieldSet _unknownFields;

	public const int NpcMeetStatusListFieldNumber = 10;

	private static readonly FieldCodec<NpcMeetByPerformanceStatus> _repeated_npcMeetStatusList_codec = FieldCodec.ForMessage(82u, NpcMeetByPerformanceStatus.Parser);

	private readonly RepeatedField<NpcMeetByPerformanceStatus> npcMeetStatusList_ = new RepeatedField<NpcMeetByPerformanceStatus>();

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFirstTalkByPerformanceNpcScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFirstTalkByPerformanceNpcScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NpcMeetByPerformanceStatus> NpcMeetStatusList => npcMeetStatusList_;

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
	public GetFirstTalkByPerformanceNpcScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFirstTalkByPerformanceNpcScRsp(GetFirstTalkByPerformanceNpcScRsp other)
		: this()
	{
		npcMeetStatusList_ = other.npcMeetStatusList_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFirstTalkByPerformanceNpcScRsp Clone()
	{
		return new GetFirstTalkByPerformanceNpcScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFirstTalkByPerformanceNpcScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFirstTalkByPerformanceNpcScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!npcMeetStatusList_.Equals(other.npcMeetStatusList_))
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
		num ^= npcMeetStatusList_.GetHashCode();
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
		npcMeetStatusList_.WriteTo(ref output, _repeated_npcMeetStatusList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
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
		num += npcMeetStatusList_.CalculateSize(_repeated_npcMeetStatusList_codec);
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
	public void MergeFrom(GetFirstTalkByPerformanceNpcScRsp other)
	{
		if (other != null)
		{
			npcMeetStatusList_.Add(other.npcMeetStatusList_);
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
			case 82u:
				npcMeetStatusList_.AddEntriesFrom(ref input, _repeated_npcMeetStatusList_codec);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
