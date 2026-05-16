using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AntiAddictScNotify : IMessage<AntiAddictScNotify>, IMessage, IEquatable<AntiAddictScNotify>, IDeepCloneable<AntiAddictScNotify>, IBufferMessage
{
	private static readonly MessageParser<AntiAddictScNotify> _parser = new MessageParser<AntiAddictScNotify>(() => new AntiAddictScNotify());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 3;

	private string level_ = "";

	public const int MsgTypeFieldNumber = 7;

	private uint msgType_;

	public const int MsgFieldNumber = 15;

	private string msg_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AntiAddictScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AntiAddictScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MsgType
	{
		get
		{
			return msgType_;
		}
		set
		{
			msgType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Msg
	{
		get
		{
			return msg_;
		}
		set
		{
			msg_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AntiAddictScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AntiAddictScNotify(AntiAddictScNotify other)
		: this()
	{
		level_ = other.level_;
		msgType_ = other.msgType_;
		msg_ = other.msg_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AntiAddictScNotify Clone()
	{
		return new AntiAddictScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AntiAddictScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AntiAddictScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (MsgType != other.MsgType)
		{
			return false;
		}
		if (Msg != other.Msg)
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
		if (Level.Length != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (MsgType != 0)
		{
			num ^= MsgType.GetHashCode();
		}
		if (Msg.Length != 0)
		{
			num ^= Msg.GetHashCode();
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
		if (Level.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Level);
		}
		if (MsgType != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(MsgType);
		}
		if (Msg.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(Msg);
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
		if (Level.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Level);
		}
		if (MsgType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MsgType);
		}
		if (Msg.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Msg);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AntiAddictScNotify other)
	{
		if (other != null)
		{
			if (other.Level.Length != 0)
			{
				Level = other.Level;
			}
			if (other.MsgType != 0)
			{
				MsgType = other.MsgType;
			}
			if (other.Msg.Length != 0)
			{
				Msg = other.Msg;
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
			case 26u:
				Level = input.ReadString();
				break;
			case 56u:
				MsgType = input.ReadUInt32();
				break;
			case 122u:
				Msg = input.ReadString();
				break;
			}
		}
	}
}
