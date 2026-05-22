using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AddBlacklistScRsp : IMessage<AddBlacklistScRsp>, IMessage, IEquatable<AddBlacklistScRsp>, IDeepCloneable<AddBlacklistScRsp>, IBufferMessage
{
	private static readonly MessageParser<AddBlacklistScRsp> _parser = new MessageParser<AddBlacklistScRsp>(() => new AddBlacklistScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BlackInfoFieldNumber = 8;

	private PlayerSimpleInfo blackInfo_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AddBlacklistScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AddBlacklistScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSimpleInfo BlackInfo
	{
		get
		{
			return blackInfo_;
		}
		set
		{
			blackInfo_ = value;
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
	public AddBlacklistScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddBlacklistScRsp(AddBlacklistScRsp other)
		: this()
	{
		blackInfo_ = ((other.blackInfo_ != null) ? other.blackInfo_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddBlacklistScRsp Clone()
	{
		return new AddBlacklistScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AddBlacklistScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AddBlacklistScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BlackInfo, other.BlackInfo))
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
		if (blackInfo_ != null)
		{
			num ^= BlackInfo.GetHashCode();
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
		if (blackInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(BlackInfo);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
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
		if (blackInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BlackInfo);
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
	public void MergeFrom(AddBlacklistScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.blackInfo_ != null)
		{
			if (blackInfo_ == null)
			{
				BlackInfo = new PlayerSimpleInfo();
			}
			BlackInfo.MergeFrom(other.BlackInfo);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 66u:
				if (blackInfo_ == null)
				{
					BlackInfo = new PlayerSimpleInfo();
				}
				input.ReadMessage(BlackInfo);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
