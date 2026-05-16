using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SocialPlayTalkScRsp : IMessage<SocialPlayTalkScRsp>, IMessage, IEquatable<SocialPlayTalkScRsp>, IDeepCloneable<SocialPlayTalkScRsp>, IBufferMessage
{
	private static readonly MessageParser<SocialPlayTalkScRsp> _parser = new MessageParser<SocialPlayTalkScRsp>(() => new SocialPlayTalkScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int NGPGKFELCEDFieldNumber = 5;

	private GFLKDHPBAMJ nGPGKFELCED_;

	public const int EndTimeFieldNumber = 11;

	private long endTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SocialPlayTalkScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SocialPlayTalkScRspReflection.Descriptor.MessageTypes[0];

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
	public GFLKDHPBAMJ NGPGKFELCED
	{
		get
		{
			return nGPGKFELCED_;
		}
		set
		{
			nGPGKFELCED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayTalkScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayTalkScRsp(SocialPlayTalkScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		nGPGKFELCED_ = ((other.nGPGKFELCED_ != null) ? other.nGPGKFELCED_.Clone() : null);
		endTime_ = other.endTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayTalkScRsp Clone()
	{
		return new SocialPlayTalkScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SocialPlayTalkScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SocialPlayTalkScRsp other)
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
		if (!object.Equals(NGPGKFELCED, other.NGPGKFELCED))
		{
			return false;
		}
		if (EndTime != other.EndTime)
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
		if (nGPGKFELCED_ != null)
		{
			num ^= NGPGKFELCED.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
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
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (nGPGKFELCED_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(NGPGKFELCED);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(88);
			output.WriteInt64(EndTime);
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
		if (nGPGKFELCED_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NGPGKFELCED);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(EndTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SocialPlayTalkScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.nGPGKFELCED_ != null)
		{
			if (nGPGKFELCED_ == null)
			{
				NGPGKFELCED = new GFLKDHPBAMJ();
			}
			NGPGKFELCED.MergeFrom(other.NGPGKFELCED);
		}
		if (other.EndTime != 0L)
		{
			EndTime = other.EndTime;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				Retcode = input.ReadUInt32();
				break;
			case 42u:
				if (nGPGKFELCED_ == null)
				{
					NGPGKFELCED = new GFLKDHPBAMJ();
				}
				input.ReadMessage(NGPGKFELCED);
				break;
			case 88u:
				EndTime = input.ReadInt64();
				break;
			}
		}
	}
}
