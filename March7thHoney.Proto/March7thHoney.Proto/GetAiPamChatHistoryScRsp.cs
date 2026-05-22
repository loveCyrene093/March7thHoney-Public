using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAiPamChatHistoryScRsp : IMessage<GetAiPamChatHistoryScRsp>, IMessage, IEquatable<GetAiPamChatHistoryScRsp>, IDeepCloneable<GetAiPamChatHistoryScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetAiPamChatHistoryScRsp> _parser = new MessageParser<GetAiPamChatHistoryScRsp>(() => new GetAiPamChatHistoryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int TargetSideFieldNumber = 7;

	private uint targetSide_;

	public const int BAPMDIEFDOJFieldNumber = 11;

	private static readonly FieldCodec<ChatMessageData> _repeated_bAPMDIEFDOJ_codec = FieldCodec.ForMessage(90u, ChatMessageData.Parser);

	private readonly RepeatedField<ChatMessageData> bAPMDIEFDOJ_ = new RepeatedField<ChatMessageData>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAiPamChatHistoryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAiPamChatHistoryScRspReflection.Descriptor.MessageTypes[0];

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
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ChatMessageData> BAPMDIEFDOJ => bAPMDIEFDOJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAiPamChatHistoryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAiPamChatHistoryScRsp(GetAiPamChatHistoryScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		targetSide_ = other.targetSide_;
		bAPMDIEFDOJ_ = other.bAPMDIEFDOJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAiPamChatHistoryScRsp Clone()
	{
		return new GetAiPamChatHistoryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAiPamChatHistoryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAiPamChatHistoryScRsp other)
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
		if (TargetSide != other.TargetSide)
		{
			return false;
		}
		if (!bAPMDIEFDOJ_.Equals(other.bAPMDIEFDOJ_))
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
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
		}
		num ^= bAPMDIEFDOJ_.GetHashCode();
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
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (TargetSide != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(TargetSide);
		}
		bAPMDIEFDOJ_.WriteTo(ref output, _repeated_bAPMDIEFDOJ_codec);
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
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		num += bAPMDIEFDOJ_.CalculateSize(_repeated_bAPMDIEFDOJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetAiPamChatHistoryScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
			}
			bAPMDIEFDOJ_.Add(other.bAPMDIEFDOJ_);
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
				Retcode = input.ReadUInt32();
				break;
			case 56u:
				TargetSide = input.ReadUInt32();
				break;
			case 90u:
				bAPMDIEFDOJ_.AddEntriesFrom(ref input, _repeated_bAPMDIEFDOJ_codec);
				break;
			}
		}
	}
}
