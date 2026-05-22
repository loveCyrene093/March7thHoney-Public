using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SocialPlayPreCheckEnterRoomScRsp : IMessage<SocialPlayPreCheckEnterRoomScRsp>, IMessage, IEquatable<SocialPlayPreCheckEnterRoomScRsp>, IDeepCloneable<SocialPlayPreCheckEnterRoomScRsp>, IBufferMessage
{
	private static readonly MessageParser<SocialPlayPreCheckEnterRoomScRsp> _parser = new MessageParser<SocialPlayPreCheckEnterRoomScRsp>(() => new SocialPlayPreCheckEnterRoomScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int DHLGCEGONIBFieldNumber = 6;

	private long dHLGCEGONIB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SocialPlayPreCheckEnterRoomScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SocialPlayPreCheckEnterRoomScRspReflection.Descriptor.MessageTypes[0];

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
	public long DHLGCEGONIB
	{
		get
		{
			return dHLGCEGONIB_;
		}
		set
		{
			dHLGCEGONIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayPreCheckEnterRoomScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayPreCheckEnterRoomScRsp(SocialPlayPreCheckEnterRoomScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		dHLGCEGONIB_ = other.dHLGCEGONIB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayPreCheckEnterRoomScRsp Clone()
	{
		return new SocialPlayPreCheckEnterRoomScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SocialPlayPreCheckEnterRoomScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SocialPlayPreCheckEnterRoomScRsp other)
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
		if (DHLGCEGONIB != other.DHLGCEGONIB)
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
		if (DHLGCEGONIB != 0L)
		{
			num ^= DHLGCEGONIB.GetHashCode();
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
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (DHLGCEGONIB != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(DHLGCEGONIB);
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
		if (DHLGCEGONIB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DHLGCEGONIB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SocialPlayPreCheckEnterRoomScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.DHLGCEGONIB != 0L)
			{
				DHLGCEGONIB = other.DHLGCEGONIB;
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
				Retcode = input.ReadUInt32();
				break;
			case 48u:
				DHLGCEGONIB = input.ReadInt64();
				break;
			}
		}
	}
}
