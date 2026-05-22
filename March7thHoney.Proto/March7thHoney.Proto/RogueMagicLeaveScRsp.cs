using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicLeaveScRsp : IMessage<RogueMagicLeaveScRsp>, IMessage, IEquatable<RogueMagicLeaveScRsp>, IDeepCloneable<RogueMagicLeaveScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicLeaveScRsp> _parser = new MessageParser<RogueMagicLeaveScRsp>(() => new RogueMagicLeaveScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int AFLJJJFCBINFieldNumber = 14;

	private JKAIDKIGEGP aFLJJJFCBIN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicLeaveScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicLeaveScRspReflection.Descriptor.MessageTypes[0];

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
	public JKAIDKIGEGP AFLJJJFCBIN
	{
		get
		{
			return aFLJJJFCBIN_;
		}
		set
		{
			aFLJJJFCBIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicLeaveScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicLeaveScRsp(RogueMagicLeaveScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		aFLJJJFCBIN_ = ((other.aFLJJJFCBIN_ != null) ? other.aFLJJJFCBIN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicLeaveScRsp Clone()
	{
		return new RogueMagicLeaveScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicLeaveScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicLeaveScRsp other)
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
		if (!object.Equals(AFLJJJFCBIN, other.AFLJJJFCBIN))
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
		if (aFLJJJFCBIN_ != null)
		{
			num ^= AFLJJJFCBIN.GetHashCode();
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
		if (aFLJJJFCBIN_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(AFLJJJFCBIN);
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
		if (aFLJJJFCBIN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AFLJJJFCBIN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicLeaveScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.aFLJJJFCBIN_ != null)
		{
			if (aFLJJJFCBIN_ == null)
			{
				AFLJJJFCBIN = new JKAIDKIGEGP();
			}
			AFLJJJFCBIN.MergeFrom(other.AFLJJJFCBIN);
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
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (aFLJJJFCBIN_ == null)
				{
					AFLJJJFCBIN = new JKAIDKIGEGP();
				}
				input.ReadMessage(AFLJJJFCBIN);
				break;
			}
		}
	}
}
