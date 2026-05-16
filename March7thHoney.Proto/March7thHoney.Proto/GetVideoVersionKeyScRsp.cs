using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetVideoVersionKeyScRsp : IMessage<GetVideoVersionKeyScRsp>, IMessage, IEquatable<GetVideoVersionKeyScRsp>, IDeepCloneable<GetVideoVersionKeyScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetVideoVersionKeyScRsp> _parser = new MessageParser<GetVideoVersionKeyScRsp>(() => new GetVideoVersionKeyScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int ActivityVideoKeyInfoListFieldNumber = 6;

	private static readonly FieldCodec<VideoKeyInfo> _repeated_activityVideoKeyInfoList_codec = FieldCodec.ForMessage(50u, VideoKeyInfo.Parser);

	private readonly RepeatedField<VideoKeyInfo> activityVideoKeyInfoList_ = new RepeatedField<VideoKeyInfo>();

	public const int VideoKeyInfoListFieldNumber = 8;

	private static readonly FieldCodec<VideoKeyInfo> _repeated_videoKeyInfoList_codec = FieldCodec.ForMessage(66u, VideoKeyInfo.Parser);

	private readonly RepeatedField<VideoKeyInfo> videoKeyInfoList_ = new RepeatedField<VideoKeyInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetVideoVersionKeyScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetVideoVersionKeyScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<VideoKeyInfo> ActivityVideoKeyInfoList => activityVideoKeyInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<VideoKeyInfo> VideoKeyInfoList => videoKeyInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetVideoVersionKeyScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetVideoVersionKeyScRsp(GetVideoVersionKeyScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		activityVideoKeyInfoList_ = other.activityVideoKeyInfoList_.Clone();
		videoKeyInfoList_ = other.videoKeyInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetVideoVersionKeyScRsp Clone()
	{
		return new GetVideoVersionKeyScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetVideoVersionKeyScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetVideoVersionKeyScRsp other)
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
		if (!activityVideoKeyInfoList_.Equals(other.activityVideoKeyInfoList_))
		{
			return false;
		}
		if (!videoKeyInfoList_.Equals(other.videoKeyInfoList_))
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
		num ^= activityVideoKeyInfoList_.GetHashCode();
		num ^= videoKeyInfoList_.GetHashCode();
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
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		activityVideoKeyInfoList_.WriteTo(ref output, _repeated_activityVideoKeyInfoList_codec);
		videoKeyInfoList_.WriteTo(ref output, _repeated_videoKeyInfoList_codec);
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
		num += activityVideoKeyInfoList_.CalculateSize(_repeated_activityVideoKeyInfoList_codec);
		num += videoKeyInfoList_.CalculateSize(_repeated_videoKeyInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetVideoVersionKeyScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			activityVideoKeyInfoList_.Add(other.activityVideoKeyInfoList_);
			videoKeyInfoList_.Add(other.videoKeyInfoList_);
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
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 50u:
				activityVideoKeyInfoList_.AddEntriesFrom(ref input, _repeated_activityVideoKeyInfoList_codec);
				break;
			case 66u:
				videoKeyInfoList_.AddEntriesFrom(ref input, _repeated_videoKeyInfoList_codec);
				break;
			}
		}
	}
}
