using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterTreasureDungeonScRsp : IMessage<EnterTreasureDungeonScRsp>, IMessage, IEquatable<EnterTreasureDungeonScRsp>, IDeepCloneable<EnterTreasureDungeonScRsp>, IBufferMessage
{
	private static readonly MessageParser<EnterTreasureDungeonScRsp> _parser = new MessageParser<EnterTreasureDungeonScRsp>(() => new EnterTreasureDungeonScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IKHJLMAKNCDFieldNumber = 6;

	private KPBGMOCCMLA iKHJLMAKNCD_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterTreasureDungeonScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterTreasureDungeonScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPBGMOCCMLA IKHJLMAKNCD
	{
		get
		{
			return iKHJLMAKNCD_;
		}
		set
		{
			iKHJLMAKNCD_ = value;
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
	public EnterTreasureDungeonScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterTreasureDungeonScRsp(EnterTreasureDungeonScRsp other)
		: this()
	{
		iKHJLMAKNCD_ = ((other.iKHJLMAKNCD_ != null) ? other.iKHJLMAKNCD_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterTreasureDungeonScRsp Clone()
	{
		return new EnterTreasureDungeonScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterTreasureDungeonScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterTreasureDungeonScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IKHJLMAKNCD, other.IKHJLMAKNCD))
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
		if (iKHJLMAKNCD_ != null)
		{
			num ^= IKHJLMAKNCD.GetHashCode();
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
		if (iKHJLMAKNCD_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(IKHJLMAKNCD);
		}
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
		if (iKHJLMAKNCD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IKHJLMAKNCD);
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
	public void MergeFrom(EnterTreasureDungeonScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iKHJLMAKNCD_ != null)
		{
			if (iKHJLMAKNCD_ == null)
			{
				IKHJLMAKNCD = new KPBGMOCCMLA();
			}
			IKHJLMAKNCD.MergeFrom(other.IKHJLMAKNCD);
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
			case 50u:
				if (iKHJLMAKNCD_ == null)
				{
					IKHJLMAKNCD = new KPBGMOCCMLA();
				}
				input.ReadMessage(IKHJLMAKNCD);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
